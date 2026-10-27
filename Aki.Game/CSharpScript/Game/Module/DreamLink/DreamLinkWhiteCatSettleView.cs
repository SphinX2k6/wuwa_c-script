using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AAE RID: 23214
	public class DreamLinkWhiteCatSettleView : UiViewBase
	{
		// Token: 0x0603ACDE RID: 240862 RVA: 0x00E02FCE File Offset: 0x00E011CE
		[NullableContext(1)]
		public DreamLinkWhiteCatSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603ACDF RID: 240863 RVA: 0x00E02FD8 File Offset: 0x00E011D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603ACE0 RID: 240864 RVA: 0x00E030A8 File Offset: 0x00E012A8
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkWhiteCatSettleView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkWhiteCatSettleView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ACE1 RID: 240865 RVA: 0x00E030EB File Offset: 0x00E012EB
		protected override void OnBeforeShow()
		{
			this.InitAutoLeaveTimer();
			this.RefreshTitle();
		}

		// Token: 0x0603ACE2 RID: 240866 RVA: 0x00E030F9 File Offset: 0x00E012F9
		protected override void OnBeforeDestroy()
		{
			this.ClearAutoLeaveTimer();
		}

		// Token: 0x0603ACE3 RID: 240867 RVA: 0x00E03104 File Offset: 0x00E01304
		protected void RefreshTitle()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIText text = base.GetText(1);
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(text, "Text_ChallengeFinish_Text", Array.Empty<object>());
			base.PlaySequence("Success", null, false);
		}

		// Token: 0x0603ACE4 RID: 240868 RVA: 0x00E03157 File Offset: 0x00E01357
		private void ClearAutoLeaveTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
			}
			this.AutoLeaveTimerId = null;
		}

		// Token: 0x0603ACE5 RID: 240869 RVA: 0x00E03183 File Offset: 0x00E01383
		private void OnClickContinueButton()
		{
			base.CloseMe(delegate(bool success)
			{
				if (success)
				{
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon();
				}
			});
		}

		// Token: 0x0603ACE6 RID: 240870 RVA: 0x00E031AA File Offset: 0x00E013AA
		private void OnClickBtnLeave()
		{
			base.CloseMe(delegate(bool success)
			{
				if (success)
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
				}
			});
		}

		// Token: 0x0603ACE7 RID: 240871 RVA: 0x00E031D4 File Offset: 0x00E013D4
		private void InitAutoLeaveTimer()
		{
			int leftSecondToAutoLeave = 31;
			this.AutoLeaveTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				int leftSecondToAutoLeave;
				if (leftSecondToAutoLeave <= 0)
				{
					TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
					this.OnClickBtnLeave();
					return;
				}
				ActivityCorniceMeetingButton activityCorniceMeetingButton;
				this.ButtonMap.TryGetValue(0, out activityCorniceMeetingButton);
				if (activityCorniceMeetingButton != null)
				{
					ActivityCorniceMeetingButton activityCorniceMeetingButton2 = activityCorniceMeetingButton;
					string textId = "InstanceDungeonLeftTimeToAutoLeave";
					string[] array = new string[1];
					int num = 0;
					leftSecondToAutoLeave = leftSecondToAutoLeave;
					leftSecondToAutoLeave--;
					array[num] = leftSecondToAutoLeave.ToString();
					activityCorniceMeetingButton2.SetFloatText(textId, array);
				}
			}, 1000f, 1f, null, null, true);
		}

		// Token: 0x0603ACE8 RID: 240872 RVA: 0x00E03220 File Offset: 0x00E01420
		private UniTask InitButtonAsync()
		{
			DreamLinkWhiteCatSettleView.<InitButtonAsync>d__17 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<DreamLinkWhiteCatSettleView.<InitButtonAsync>d__17>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ACE9 RID: 240873 RVA: 0x00E03264 File Offset: 0x00E01464
		[NullableContext(1)]
		private UniTask CreateButton(UUIItem uiItem, int buttonIndex, Action clickFunction)
		{
			DreamLinkWhiteCatSettleView.<CreateButton>d__18 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.buttonIndex = buttonIndex;
			<CreateButton>d__.clickFunction = clickFunction;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<DreamLinkWhiteCatSettleView.<CreateButton>d__18>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x0401EB08 RID: 125704
		private const int LEAVETIME = 30;

		// Token: 0x0401EB09 RID: 125705
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

		// Token: 0x0401EB0A RID: 125706
		[Nullable(2)]
		private TimerHandle AutoLeaveTimerId;

		// Token: 0x0401EB0B RID: 125707
		[Nullable(2)]
		protected RogueBossLinkSettleNotify Data;

		// Token: 0x0401EB0C RID: 125708
		[Nullable(2)]
		protected DreamLinkWhiteCatSettlePanel RewardExploreTargetReachedList;

		// Token: 0x0200BCFB RID: 48379
		private class EComponents
		{
			// Token: 0x04038FE4 RID: 233444
			public const int TxtTitle = 1;

			// Token: 0x04038FE5 RID: 233445
			public const int TextureIcon = 2;

			// Token: 0x04038FE6 RID: 233446
			public const int ButtonHorizontalItem = 4;

			// Token: 0x04038FE7 RID: 233447
			public const int ButtonItem = 5;

			// Token: 0x04038FE8 RID: 233448
			public const int Content = 20;
		}

		// Token: 0x0200BCFC RID: 48380
		private class EButtons
		{
			// Token: 0x04038FE9 RID: 233449
			public const int LeftButton = 0;

			// Token: 0x04038FEA RID: 233450
			public const int RightButton = 1;
		}
	}
}
