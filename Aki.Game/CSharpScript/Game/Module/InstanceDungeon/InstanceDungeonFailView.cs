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
	// Token: 0x02005874 RID: 22644
	public class InstanceDungeonFailView : UiViewBase
	{
		// Token: 0x060399D2 RID: 235986 RVA: 0x00DB0FDA File Offset: 0x00DAF1DA
		[NullableContext(1)]
		public InstanceDungeonFailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17008A66 RID: 35430
		// (get) Token: 0x060399D3 RID: 235987 RVA: 0x00DB0FE4 File Offset: 0x00DAF1E4
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

		// Token: 0x060399D4 RID: 235988 RVA: 0x00DB1014 File Offset: 0x00DAF214
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

		// Token: 0x060399D5 RID: 235989 RVA: 0x00DB1140 File Offset: 0x00DAF340
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

		// Token: 0x060399D6 RID: 235990 RVA: 0x00DB11B0 File Offset: 0x00DAF3B0
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

		// Token: 0x060399D7 RID: 235991 RVA: 0x00DB11D0 File Offset: 0x00DAF3D0
		private void InitView()
		{
			base.GetText(0).ShowTextNew(this.InstanceConfig.Value.FailTips);
		}

		// Token: 0x060399D8 RID: 235992 RVA: 0x00DB1200 File Offset: 0x00DAF400
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

		// Token: 0x060399D9 RID: 235993 RVA: 0x00DB1267 File Offset: 0x00DAF467
		private void ClearAutoLeaveTimer()
		{
			if (this.AutoLeaveTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
			}
			this.AutoLeaveTimerId = null;
		}

		// Token: 0x060399DA RID: 235994 RVA: 0x00DB129C File Offset: 0x00DAF49C
		private UniTask LeaveInstance()
		{
			InstanceDungeonFailView.<LeaveInstance>d__13 <LeaveInstance>d__;
			<LeaveInstance>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LeaveInstance>d__.<>4__this = this;
			<LeaveInstance>d__.<>1__state = -1;
			<LeaveInstance>d__.<>t__builder.Start<InstanceDungeonFailView.<LeaveInstance>d__13>(ref <LeaveInstance>d__);
			return <LeaveInstance>d__.<>t__builder.Task;
		}

		// Token: 0x060399DB RID: 235995 RVA: 0x00DB12DF File Offset: 0x00DAF4DF
		private void OnClickBtnLeave()
		{
			this.LeaveInstance();
		}

		// Token: 0x060399DC RID: 235996 RVA: 0x00DB12E8 File Offset: 0x00DAF4E8
		private void OnClickBtnAgain()
		{
			this.ClearAutoLeaveTimer();
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().ContinueWith(delegate(bool _)
			{
				if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x0401E1DE RID: 123358
		private int InstanceId;

		// Token: 0x0401E1DF RID: 123359
		[Nullable(2)]
		private TimerHandle AutoLeaveTimerId;

		// Token: 0x0401E1E0 RID: 123360
		[Nullable(2)]
		private TrainingView TrainingView;

		// Token: 0x0200BACE RID: 47822
		private static class EChildCom
		{
			// Token: 0x04038734 RID: 231220
			public const int TextTips = 0;

			// Token: 0x04038735 RID: 231221
			public const int BtnLeave = 1;

			// Token: 0x04038736 RID: 231222
			public const int BtnAgain = 2;

			// Token: 0x04038737 RID: 231223
			public const int TextLeftTime = 3;

			// Token: 0x04038738 RID: 231224
			public const int RoleTrainingLayout = 4;
		}
	}
}
