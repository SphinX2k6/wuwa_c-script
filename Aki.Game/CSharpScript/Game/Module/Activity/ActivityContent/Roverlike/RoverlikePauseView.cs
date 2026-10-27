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
	// Token: 0x0200614B RID: 24907
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikePauseView : UiViewBase
	{
		// Token: 0x0603EF5D RID: 257885 RVA: 0x00F358D1 File Offset: 0x00F33AD1
		public RoverlikePauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EF5E RID: 257886 RVA: 0x00F358DC File Offset: 0x00F33ADC
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

		// Token: 0x0603EF5F RID: 257887 RVA: 0x00F35AD4 File Offset: 0x00F33CD4
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikePauseView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikePauseView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EF60 RID: 257888 RVA: 0x00F35B18 File Offset: 0x00F33D18
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

		// Token: 0x0603EF61 RID: 257889 RVA: 0x00F35B7F File Offset: 0x00F33D7F
		private void RefreshTitle(RoverlikeInstanceData instanceData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RoverRogue_ProcessingStage", new <>z__ReadOnlyArray<object>(new object[]
			{
				instanceData.CurLayer,
				instanceData.MaxLayer
			}));
		}

		// Token: 0x0603EF62 RID: 257890 RVA: 0x00F35BBE File Offset: 0x00F33DBE
		private void RefreshLevelTips(RoverlikeInstanceData instanceData)
		{
			RoverlikeLevelTipsItem levelTips = this.LevelTips;
			if (levelTips == null)
			{
				return;
			}
			levelTips.Refresh(instanceData, true, null);
		}

		// Token: 0x0603EF63 RID: 257891 RVA: 0x00F35BD4 File Offset: 0x00F33DD4
		private void OnClickQuit()
		{
			int? currentActivityId = RoverlikeActivityController.Instance.GetCurrentActivityId();
			if (currentActivityId != null)
			{
				RoverlikeController.Instance.RoverRogueQuitRequest(currentActivityId.Value, null);
			}
		}

		// Token: 0x0603EF64 RID: 257892 RVA: 0x00F35C08 File Offset: 0x00F33E08
		private void OnClickSettle()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoverlikeResultConfirm);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.<OnClickSettle>g__settle|11_0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603EF65 RID: 257893 RVA: 0x00F35C44 File Offset: 0x00F33E44
		private void OnClickSetting()
		{
			UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
		}

		// Token: 0x0603EF66 RID: 257894 RVA: 0x00F35C57 File Offset: 0x00F33E57
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603EF68 RID: 257896 RVA: 0x00F35C6C File Offset: 0x00F33E6C
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

		// Token: 0x04020DBC RID: 134588
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x04020DBD RID: 134589
		[Nullable(2)]
		private RoverlikeLevelTipsItem LevelTips;

		// Token: 0x04020DBE RID: 134590
		[Nullable(2)]
		private RoverlikeLevelInfoList InfoList;

		// Token: 0x0200C3AB RID: 50091
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B0AC RID: 241836
			public const int CaptionItem = 0;

			// Token: 0x0403B0AD RID: 241837
			public const int BtnQuit = 1;

			// Token: 0x0403B0AE RID: 241838
			public const int BtnSettle = 2;

			// Token: 0x0403B0AF RID: 241839
			public const int BtnSetting = 3;

			// Token: 0x0403B0B0 RID: 241840
			public const int BtnClose = 4;

			// Token: 0x0403B0B1 RID: 241841
			public const int ItemLevelTips = 5;

			// Token: 0x0403B0B2 RID: 241842
			public const int SvInfo = 6;

			// Token: 0x0403B0B3 RID: 241843
			public const int ItemSkillTips = 7;

			// Token: 0x0403B0B4 RID: 241844
			public const int TxtTitle = 8;
		}
	}
}
