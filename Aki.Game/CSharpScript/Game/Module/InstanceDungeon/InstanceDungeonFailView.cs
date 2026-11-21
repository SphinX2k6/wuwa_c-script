using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200484C RID: 18508
	public class InstanceDungeonFailView : UiViewBase
	{
		// Token: 0x0602E8F3 RID: 190707 RVA: 0x00CFFEA6 File Offset: 0x00CFE0A6
		[NullableContext(1)]
		public InstanceDungeonFailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17005E32 RID: 24114
		// (get) Token: 0x0602E8F4 RID: 190708 RVA: 0x00CFFEB0 File Offset: 0x00CFE0B0
		private InstanceDungeon? InstanceConfig
		{
			get
			{
				if (this.InstanceId == 0)
				{
					return null;
				}
				return InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			}
		}

		// Token: 0x0602E8F5 RID: 190709 RVA: 0x00CFFEE0 File Offset: 0x00CFE0E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnLeave));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnAgain));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E8F6 RID: 190710 RVA: 0x00D0000C File Offset: 0x00CFE20C
		protected override void OnStart()
		{
			this.InstanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			if (UiManager.Instance.IsViewShow(EUiViewName.ReviveView))
			{
				UiManager.Instance.CloseView(EUiViewName.ReviveView, null);
			}
			this.InitView();
			this.InitAutoLeaveTimer();
			this.TrainingView = new TrainingView();
			this.TrainingView.Show(base.GetVerticalLayout(4), null);
			base.SetButtonUiActive(2, false);
		}

		// Token: 0x0602E8F7 RID: 190711 RVA: 0x00D0007C File Offset: 0x00CFE27C
		protected override void OnBeforeDestroy()
		{
			TrainingView trainingView = this.TrainingView;
			if (trainingView != null)
			{
				trainingView.Clear();
			}
			this.TrainingView = null;
			this.ClearAutoLeaveTimer();
		}

		// Token: 0x0602E8F8 RID: 190712 RVA: 0x00D0009C File Offset: 0x00CFE29C
		private void InitView()
		{
			base.GetText(0).ShowTextNew(this.InstanceConfig.Value.FailTips);
		}

		// Token: 0x0602E8F9 RID: 190713 RVA: 0x00D000CC File Offset: 0x00CFE2CC
		private void InitAutoLeaveTimer()
		{
			int leftSecondToAutoLeave = this.InstanceConfig.Value.AutoLeaveTime;
			this.AutoLeaveTimerId = TimerSystem.GameplayTimeInstance.Loop(delegate(float _)
			{
				int leftSecondToAutoLeave;
				if (leftSecondToAutoLeave <= 0)
				{
					this.LeaveInstance();
					return;
				}
				LguiUtil instance = LguiUtil.Instance;
				UUIText text = this.GetText(3);
				string textTableId = "InstanceDungeonLeftTimeToAutoLeave";
				leftSecondToAutoLeave = leftSecondToAutoLeave;
				leftSecondToAutoLeave--;
				instance.SetLocalText(text, textTableId, new <>z__ReadOnlySingleElementList<object>(leftSecondToAutoLeave));
			}, 1000f, leftSecondToAutoLeave + 1, 1f, null, null, true);
		}

		// Token: 0x0602E8FA RID: 190714 RVA: 0x00D00133 File Offset: 0x00CFE333
		private void ClearAutoLeaveTimer()
		{
			if (this.AutoLeaveTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
			}
			this.AutoLeaveTimerId = null;
		}

		// Token: 0x0602E8FB RID: 190715 RVA: 0x00D00168 File Offset: 0x00CFE368
		private UniTask LeaveInstance()
		{
			InstanceDungeonFailView.<LeaveInstance>d__13 <LeaveInstance>d__;
			<LeaveInstance>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LeaveInstance>d__.<>4__this = this;
			<LeaveInstance>d__.<>1__state = -1;
			<LeaveInstance>d__.<>t__builder.Start<InstanceDungeonFailView.<LeaveInstance>d__13>(ref <LeaveInstance>d__);
			return <LeaveInstance>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8FC RID: 190716 RVA: 0x00D001AB File Offset: 0x00CFE3AB
		private void OnClickBtnLeave()
		{
			this.LeaveInstance();
		}

		// Token: 0x0602E8FD RID: 190717 RVA: 0x00D001B4 File Offset: 0x00CFE3B4
		private void OnClickBtnAgain()
		{
			this.ClearAutoLeaveTimer();
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).ContinueWith(delegate(bool _)
			{
				if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x04018C7B RID: 101499
		private int InstanceId;

		// Token: 0x04018C7C RID: 101500
		[Nullable(2)]
		private TimerHandle AutoLeaveTimerId;

		// Token: 0x04018C7D RID: 101501
		[Nullable(2)]
		private TrainingView TrainingView;

		// Token: 0x0200A4E7 RID: 42215
		private static class EChildCom
		{
			// Token: 0x04033135 RID: 209205
			public const int TextTips = 0;

			// Token: 0x04033136 RID: 209206
			public const int BtnLeave = 1;

			// Token: 0x04033137 RID: 209207
			public const int BtnAgain = 2;

			// Token: 0x04033138 RID: 209208
			public const int TextLeftTime = 3;

			// Token: 0x04033139 RID: 209209
			public const int RoleTrainingLayout = 4;
		}
	}
}
