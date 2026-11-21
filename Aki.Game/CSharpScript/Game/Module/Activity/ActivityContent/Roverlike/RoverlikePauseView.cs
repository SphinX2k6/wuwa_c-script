using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050C9 RID: 20681
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikePauseView : UiViewBase
	{
		// Token: 0x06033C1D RID: 211997 RVA: 0x00E7C7B1 File Offset: 0x00E7A9B1
		public RoverlikePauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033C1E RID: 211998 RVA: 0x00E7C7BC File Offset: 0x00E7A9BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickQuit));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickSettle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickSetting));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033C1F RID: 211999 RVA: 0x00E7C9B4 File Offset: 0x00E7ABB4
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikePauseView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikePauseView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033C20 RID: 212000 RVA: 0x00E7C9F8 File Offset: 0x00E7ABF8
		protected override void OnBeforeShow()
		{
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			if (instanceData == null)
			{
				return;
			}
			this.RefreshTitle(instanceData);
			this.RefreshLevelTips(instanceData);
			int instanceId = CreatureModel.Instance.GetInstanceId();
			RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(instanceId);
			if (insConfig == null)
			{
				return;
			}
			RoverlikeLevelInfoList infoList = this.InfoList;
			if (infoList == null)
			{
				return;
			}
			infoList.RefreshByConfig(new RoverRogueIns?(insConfig.Value));
		}

		// Token: 0x06033C21 RID: 212001 RVA: 0x00E7CA5F File Offset: 0x00E7AC5F
		private void RefreshTitle(RoverlikeInstanceData instanceData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RoverRogue_ProcessingStage", new <>z__ReadOnlyArray<object>(new object[]
			{
				instanceData.CurLayer,
				instanceData.MaxLayer
			}));
		}

		// Token: 0x06033C22 RID: 212002 RVA: 0x00E7CA9E File Offset: 0x00E7AC9E
		private void RefreshLevelTips(RoverlikeInstanceData instanceData)
		{
			RoverlikeLevelTipsItem levelTips = this.LevelTips;
			if (levelTips == null)
			{
				return;
			}
			levelTips.Refresh(instanceData, true, null);
		}

		// Token: 0x06033C23 RID: 212003 RVA: 0x00E7CAB4 File Offset: 0x00E7ACB4
		private void OnClickQuit()
		{
			int? currentActivityId = RoverlikeActivityController.Instance.GetCurrentActivityId();
			if (currentActivityId != null)
			{
				RoverlikeController.Instance.RoverRogueQuitRequest(currentActivityId.Value, null);
			}
		}

		// Token: 0x06033C24 RID: 212004 RVA: 0x00E7CAE8 File Offset: 0x00E7ACE8
		private void OnClickSettle()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoverlikeResultConfirm);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.<OnClickSettle>g__settle|11_0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06033C25 RID: 212005 RVA: 0x00E7CB24 File Offset: 0x00E7AD24
		private void OnClickSetting()
		{
			UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
		}

		// Token: 0x06033C26 RID: 212006 RVA: 0x00E7CB37 File Offset: 0x00E7AD37
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033C28 RID: 212008 RVA: 0x00E7CB4C File Offset: 0x00E7AD4C
		[CompilerGenerated]
		private void <OnClickSettle>g__settle|11_0()
		{
			int? currentActivityId = RoverlikeActivityController.Instance.GetCurrentActivityId();
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (currentActivityId != null)
			{
				RoverlikeController.Instance.RoverRogueResultRequest(currentActivityId.Value, instanceId, delegate(bool success)
				{
					if (!success)
					{
						return;
					}
					base.CloseMe(null);
				});
			}
		}

		// Token: 0x0401B6E9 RID: 112361
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401B6EA RID: 112362
		[Nullable(2)]
		private RoverlikeLevelTipsItem LevelTips;

		// Token: 0x0401B6EB RID: 112363
		[Nullable(2)]
		private RoverlikeLevelInfoList InfoList;

		// Token: 0x0200AD92 RID: 44434
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035A0D RID: 219661
			public const int CaptionItem = 0;

			// Token: 0x04035A0E RID: 219662
			public const int BtnQuit = 1;

			// Token: 0x04035A0F RID: 219663
			public const int BtnSettle = 2;

			// Token: 0x04035A10 RID: 219664
			public const int BtnSetting = 3;

			// Token: 0x04035A11 RID: 219665
			public const int BtnClose = 4;

			// Token: 0x04035A12 RID: 219666
			public const int ItemLevelTips = 5;

			// Token: 0x04035A13 RID: 219667
			public const int SvInfo = 6;

			// Token: 0x04035A14 RID: 219668
			public const int ItemSkillTips = 7;

			// Token: 0x04035A15 RID: 219669
			public const int TxtTitle = 8;
		}
	}
}
