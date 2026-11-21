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
	// Token: 0x02004A8A RID: 19082
	public class DreamLinkWhiteCatSettleView : UiViewBase
	{
		// Token: 0x0602FC2A RID: 195626 RVA: 0x00D53596 File Offset: 0x00D51796
		[NullableContext(1)]
		public DreamLinkWhiteCatSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602FC2B RID: 195627 RVA: 0x00D535A0 File Offset: 0x00D517A0
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

		// Token: 0x0602FC2C RID: 195628 RVA: 0x00D53670 File Offset: 0x00D51870
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkWhiteCatSettleView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkWhiteCatSettleView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC2D RID: 195629 RVA: 0x00D536B3 File Offset: 0x00D518B3
		protected override void OnBeforeShow()
		{
			this.InitAutoLeaveTimer();
			this.RefreshTitle();
		}

		// Token: 0x0602FC2E RID: 195630 RVA: 0x00D536C1 File Offset: 0x00D518C1
		protected override void OnBeforeDestroy()
		{
			this.ClearAutoLeaveTimer();
		}

		// Token: 0x0602FC2F RID: 195631 RVA: 0x00D536CC File Offset: 0x00D518CC
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

		// Token: 0x0602FC30 RID: 195632 RVA: 0x00D5371F File Offset: 0x00D5191F
		private void ClearAutoLeaveTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
			}
			this.AutoLeaveTimerId = null;
		}

		// Token: 0x0602FC31 RID: 195633 RVA: 0x00D5374B File Offset: 0x00D5194B
		private void OnClickContinueButton()
		{
			base.CloseMe(delegate(bool success)
			{
				if (success)
				{
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false);
				}
			});
		}

		// Token: 0x0602FC32 RID: 195634 RVA: 0x00D53772 File Offset: 0x00D51972
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

		// Token: 0x0602FC33 RID: 195635 RVA: 0x00D5379C File Offset: 0x00D5199C
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

		// Token: 0x0602FC34 RID: 195636 RVA: 0x00D537E8 File Offset: 0x00D519E8
		private UniTask InitButtonAsync()
		{
			DreamLinkWhiteCatSettleView.<InitButtonAsync>d__17 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<DreamLinkWhiteCatSettleView.<InitButtonAsync>d__17>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC35 RID: 195637 RVA: 0x00D5382C File Offset: 0x00D51A2C
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

		// Token: 0x040195AF RID: 103855
		private const int LEAVETIME = 30;

		// Token: 0x040195B0 RID: 103856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

		// Token: 0x040195B1 RID: 103857
		[Nullable(2)]
		private TimerHandle AutoLeaveTimerId;

		// Token: 0x040195B2 RID: 103858
		[Nullable(2)]
		protected RogueBossLinkSettleNotify Data;

		// Token: 0x040195B3 RID: 103859
		[Nullable(2)]
		protected DreamLinkWhiteCatSettlePanel RewardExploreTargetReachedList;

		// Token: 0x0200A703 RID: 42755
		private class EComponents
		{
			// Token: 0x040339AE RID: 211374
			public const int TxtTitle = 1;

			// Token: 0x040339AF RID: 211375
			public const int TextureIcon = 2;

			// Token: 0x040339B0 RID: 211376
			public const int ButtonHorizontalItem = 4;

			// Token: 0x040339B1 RID: 211377
			public const int ButtonItem = 5;

			// Token: 0x040339B2 RID: 211378
			public const int Content = 20;
		}

		// Token: 0x0200A704 RID: 42756
		private class EButtons
		{
			// Token: 0x040339B3 RID: 211379
			public const int LeftButton = 0;

			// Token: 0x040339B4 RID: 211380
			public const int RightButton = 1;
		}
	}
}
