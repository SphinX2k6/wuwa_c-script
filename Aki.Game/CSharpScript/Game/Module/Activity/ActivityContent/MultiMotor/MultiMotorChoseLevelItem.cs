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
	// Token: 0x0200530A RID: 21258
	public class MultiMotorChoseLevelItem : GridProxyAbstract<int>
	{
		// Token: 0x06034E31 RID: 216625 RVA: 0x00EC9BA4 File Offset: 0x00EC7DA4
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

		// Token: 0x06034E32 RID: 216626 RVA: 0x00EC9CF0 File Offset: 0x00EC7EF0
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

		// Token: 0x06034E33 RID: 216627 RVA: 0x00EC9E7C File Offset: 0x00EC807C
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

		// Token: 0x06034E34 RID: 216628 RVA: 0x00EC9ED0 File Offset: 0x00EC80D0
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

		// Token: 0x06034E35 RID: 216629 RVA: 0x00EC9F3D File Offset: 0x00EC813D
		public void SelectToggle()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x0401BF7E RID: 114558
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickToggleCallBack;

		// Token: 0x0401BF7F RID: 114559
		private int LevelId;

		// Token: 0x0200AF8A RID: 44938
		private class EItemComponents
		{
			// Token: 0x0403640F RID: 222223
			public const int Toggle = 0;

			// Token: 0x04036410 RID: 222224
			public const int TitleTexture = 1;

			// Token: 0x04036411 RID: 222225
			public const int NumberSprite = 2;

			// Token: 0x04036412 RID: 222226
			public const int FinishItem = 3;

			// Token: 0x04036413 RID: 222227
			public const int LockItem = 4;

			// Token: 0x04036414 RID: 222228
			public const int RedDotItem = 5;

			// Token: 0x04036415 RID: 222229
			public const int RankSprite = 6;
		}
	}
}
