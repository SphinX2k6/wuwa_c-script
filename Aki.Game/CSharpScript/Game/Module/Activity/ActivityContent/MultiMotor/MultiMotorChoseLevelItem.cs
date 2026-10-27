using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200638C RID: 25484
	public class MultiMotorChoseLevelItem : GridProxyAbstract<int>
	{
		// Token: 0x06040170 RID: 262512 RVA: 0x00F82C30 File Offset: 0x00F80E30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggleTextureTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040171 RID: 262513 RVA: 0x00F82D7C File Offset: 0x00F80F7C
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.LevelId = data;
			OnlineMotorLevel? motorMultiParkourLevelById = MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(this.LevelId);
			if (motorMultiParkourLevelById == null)
			{
				return;
			}
			UUIExtendToggleTextureTransition uiExtendToggleTextureTransition = base.GetUiExtendToggleTextureTransition(1);
			uiExtendToggleTextureTransition.RootUIComp.Get().SetUIActive(false);
			this.LoadTitleTextureAsync(motorMultiParkourLevelById.Value, uiExtendToggleTextureTransition).Forget();
			this.SetSpriteByPath(motorMultiParkourLevelById.Value.LevelTitleSprite, base.GetSprite(2), false, null, null);
			bool levelUnLock = MultiMotorModel.Instance.GetLevelUnLock(this.LevelId);
			base.GetItem(4).SetUIActive(!levelUnLock);
			if (!levelUnLock)
			{
				base.GetItem(3).SetUIActive(false);
				base.GetSprite(6).SetUIActive(false);
				base.GetItem(5).SetUIActive(false);
				return;
			}
			MultiMotorLevelData multiMotorLevelData = null;
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			if (activityData != null)
			{
				activityData.LevelDataMap.TryGetValue(this.LevelId, out multiMotorLevelData);
			}
			bool uiactive = multiMotorLevelData != null && multiMotorLevelData.IsFinish;
			base.GetItem(3).SetUIActive(uiactive);
			base.GetItem(5).SetUIActive(multiMotorLevelData != null && multiMotorLevelData.HasLevelRedDot);
			int num = (multiMotorLevelData != null) ? multiMotorLevelData.BestRanking : 0;
			if (num > 0)
			{
				string resourceId;
				MultiMotorDefine.MultiMotorRankSprite.TryGetValue(num, out resourceId);
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
				this.SetSpriteByPath(resourcePath, base.GetSprite(6), false, null, null);
			}
			base.GetSprite(6).SetUIActive(num > 0);
		}

		// Token: 0x06040172 RID: 262514 RVA: 0x00F82F08 File Offset: 0x00F81108
		[NullableContext(1)]
		private UniTask LoadTitleTextureAsync(OnlineMotorLevel config, UUIExtendToggleTextureTransition titleTexture)
		{
			MultiMotorChoseLevelItem.<LoadTitleTextureAsync>d__5 <LoadTitleTextureAsync>d__;
			<LoadTitleTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTitleTextureAsync>d__.<>4__this = this;
			<LoadTitleTextureAsync>d__.config = config;
			<LoadTitleTextureAsync>d__.titleTexture = titleTexture;
			<LoadTitleTextureAsync>d__.<>1__state = -1;
			<LoadTitleTextureAsync>d__.<>t__builder.Start<MultiMotorChoseLevelItem.<LoadTitleTextureAsync>d__5>(ref <LoadTitleTextureAsync>d__);
			return <LoadTitleTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040173 RID: 262515 RVA: 0x00F82F5C File Offset: 0x00F8115C
		private void OnClickToggle(EToggleState _)
		{
			MultiMotorLevelData multiMotorLevelData = null;
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			if (activityData != null)
			{
				activityData.LevelDataMap.TryGetValue(this.LevelId, out multiMotorLevelData);
			}
			if (multiMotorLevelData != null && multiMotorLevelData.HasLevelRedDot)
			{
				multiMotorLevelData.ReadLevelRedDot();
				base.GetItem(5).SetUIActive(false);
			}
			Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.LevelId, base.GetExtendToggle(0));
		}

		// Token: 0x06040174 RID: 262516 RVA: 0x00F82FC9 File Offset: 0x00F811C9
		public void SelectToggle()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x0402164F RID: 136783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickToggleCallBack;

		// Token: 0x04021650 RID: 136784
		private int LevelId;

		// Token: 0x0200C5A3 RID: 50595
		private class EItemComponents
		{
			// Token: 0x0403BAAE RID: 244398
			public const int Toggle = 0;

			// Token: 0x0403BAAF RID: 244399
			public const int TitleTexture = 1;

			// Token: 0x0403BAB0 RID: 244400
			public const int NumberSprite = 2;

			// Token: 0x0403BAB1 RID: 244401
			public const int FinishItem = 3;

			// Token: 0x0403BAB2 RID: 244402
			public const int LockItem = 4;

			// Token: 0x0403BAB3 RID: 244403
			public const int RedDotItem = 5;

			// Token: 0x0403BAB4 RID: 244404
			public const int RankSprite = 6;
		}
	}
}
