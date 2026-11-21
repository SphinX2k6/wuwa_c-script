using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058F0 RID: 22768
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolDayInProgressState : SolarSchoolInProgressStateBase
	{
		// Token: 0x17006BB8 RID: 27576
		// (get) Token: 0x06038233 RID: 229939 RVA: 0x00FB0EB4 File Offset: 0x00FAF0B4
		private IReadOnlyList<SolarSchoolTimeSlot> SlotOrder
		{
			get
			{
				return SolarSchoolConfig.Instance.GetTimeSlotListOrdered(SolarSchoolGamePlayModel.Instance.ActivityId);
			}
		}

		// Token: 0x06038234 RID: 229940 RVA: 0x00FB0ECC File Offset: 0x00FAF0CC
		protected unsafe override void OnEnterState(ESolarSchoolStageStateType? prev)
		{
			this.TimeSlotIndex = -1;
			this.WaitGoOutPhase = false;
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] DayInProgress 进入";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dayIndex", timeData.DayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dayType", timeData.GetDayType());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.AdvanceToNextTask();
		}

		// Token: 0x06038235 RID: 229941 RVA: 0x00FB0F62 File Offset: 0x00FAF162
		protected override void OnExitState(ESolarSchoolStageStateType? next)
		{
			this.WaitGoOutPhase = false;
			this.TimeSlotIndex = -1;
		}

		// Token: 0x06038236 RID: 229942 RVA: 0x00FB0F74 File Offset: 0x00FAF174
		private void AdvanceToNextTask()
		{
			if (!base.IsActive || base.CurrentTask != null)
			{
				return;
			}
			this.TimeSlotIndex++;
			if (this.TimeSlotIndex >= this.SlotOrder.Count)
			{
				base.FinishDay();
				return;
			}
			this.CreateCurrentSlotTask();
		}

		// Token: 0x06038237 RID: 229943 RVA: 0x00FB0FC0 File Offset: 0x00FAF1C0
		private bool TryEnterWaitGoOutPhase()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (this.TimeSlotIndex != 0 || this.SlotOrder[this.TimeSlotIndex].Id != 1 || !this.ShouldStartDayAtHome() || instance.GetBehaviorIdBySlot(ESolarSchoolTimeSlot.Day) == 0)
			{
				return false;
			}
			this.WaitGoOutPhase = true;
			base.RunTask(new SolarSchoolWaitGoOutTask
			{
				SlotTag = ESolarSchoolTimeSlot.None
			});
			return true;
		}

		// Token: 0x06038238 RID: 229944 RVA: 0x00FB1024 File Offset: 0x00FAF224
		private void CreateCurrentSlotTask()
		{
			ESolarSchoolTimeSlot id = (ESolarSchoolTimeSlot)this.SlotOrder[this.TimeSlotIndex].Id;
			base.RunTask(this.CreateSlotTask(id));
		}

		// Token: 0x06038239 RID: 229945 RVA: 0x00FB1058 File Offset: 0x00FAF258
		private unsafe SolarSchoolTaskBase CreateSlotTask(ESolarSchoolTimeSlot slot)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			List<SolarSchoolActionBase> list = this.CreateGoHomeActions(slot);
			foreach (int actionId in instance.GetSlotActions(slot))
			{
				SolarSchoolActionBase solarSchoolActionBase = instance.CreateAction(actionId);
				if (solarSchoolActionBase != null)
				{
					list.Add(solarSchoolActionBase);
				}
			}
			bool flag = instance.IsActionSlot(slot);
			int num = 0;
			bool flag2 = false;
			if (flag)
			{
				num = instance.GetBehaviorIdBySlot(slot);
				if (num != 0 && instance.IsBehaviorFatigueOverflow(num))
				{
					int num2 = instance.ScheduleData.ClearNormalFromNow();
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 排期行为执行前疲劳超标，转自由行动点并清后续普通排期";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("slot", slot);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("behaviorId", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("clearedCount", num2);
					instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					num = 0;
					flag2 = true;
				}
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 建行动点 Task";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("slot", slot);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("scheduledBehaviorId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("task", (num != 0) ? "Auto(排期)" : "Free(自由)");
				instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				if (num != 0)
				{
					list.AddRange(instance.CreateBehaviorActionSequence(num));
				}
			}
			bool hasContent = flag || list.Count > 0;
			list.InsertRange(0, this.CreateSlotTransitionActions(slot, hasContent));
			if (this.TimeSlotIndex == 0)
			{
				SolarSchoolModel.Instance.SetFirstScreenReadyIfNoPreparer(list);
			}
			if (flag && num == 0)
			{
				return new SolarSchoolFreeActionTask(list)
				{
					SlotTag = slot,
					StartAtHome = (!flag2 && slot == ESolarSchoolTimeSlot.Day && this.ShouldStartDayAtHome()),
					IsFatigueBlocked = flag2
				};
			}
			return new SolarSchoolAutoTimeSlotTask(list)
			{
				SlotTag = slot
			};
		}

		// Token: 0x0603823A RID: 229946 RVA: 0x00FB1270 File Offset: 0x00FAF470
		private List<SolarSchoolActionBase> CreateSlotTransitionActions(ESolarSchoolTimeSlot slot, bool hasContent)
		{
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			EActivityActionType type = EActivityActionType.SolarSchoolTimeSlotSwitch;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string key = "SolarSchoolTimeSlot";
			int num = (int)slot;
			dictionary.Add(key, num.ToString());
			dictionary.Add("SolarSchoolTimeSlotSilent", hasContent ? "0" : "1");
			SolarSchoolActionBase solarSchoolActionBase = instance.CreateAction(type, dictionary);
			if (solarSchoolActionBase != null)
			{
				list.Add(solarSchoolActionBase);
			}
			return list;
		}

		// Token: 0x0603823B RID: 229947 RVA: 0x00FB12D4 File Offset: 0x00FAF4D4
		private List<SolarSchoolActionBase> CreateGoHomeActions(ESolarSchoolTimeSlot slot)
		{
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (this.TimeSlotIndex == 0 && this.ShouldStartDayAtHome())
			{
				SolarSchoolActionBase solarSchoolActionBase = instance.CreateAction(EActivityActionType.SolarSchoolGoHome, null);
				if (solarSchoolActionBase != null)
				{
					list.Add(solarSchoolActionBase);
				}
			}
			return list;
		}

		// Token: 0x0603823C RID: 229948 RVA: 0x00FB1318 File Offset: 0x00FAF518
		private bool ShouldStartDayAtHome()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			return instance.ShouldReturnDayStart(instance.TimeData.DayIndex) && (instance.IsActionSlot(ESolarSchoolTimeSlot.Day) || instance.IsActionSlot(ESolarSchoolTimeSlot.Dusk));
		}

		// Token: 0x0603823D RID: 229949 RVA: 0x00FB1352 File Offset: 0x00FAF552
		protected override void OnTaskFinish(int taskId)
		{
			if (this.WaitGoOutPhase)
			{
				this.WaitGoOutPhase = false;
				this.AdvanceToNextTask();
				return;
			}
			if (this.TryEnterWaitGoOutPhase())
			{
				return;
			}
			this.AdvanceToNextTask();
		}

		// Token: 0x0603823E RID: 229950 RVA: 0x00FB137C File Offset: 0x00FAF57C
		public unsafe override void OnPlayerChooseOption(int locationId, int optionId)
		{
			SolarSchoolFreeActionTask solarSchoolFreeActionTask = base.CurrentTask as SolarSchoolFreeActionTask;
			if (solarSchoolFreeActionTask == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前不在自由行动点，无法选选项";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("optionId", optionId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			solarSchoolFreeActionTask.OnPlayerChooseOption(locationId, optionId);
		}

		// Token: 0x0603823F RID: 229951 RVA: 0x00FB1404 File Offset: 0x00FAF604
		public unsafe override void OnPlayerChooseRoleOption(int roleId, int optionId)
		{
			SolarSchoolFreeActionTask solarSchoolFreeActionTask = base.CurrentTask as SolarSchoolFreeActionTask;
			if (solarSchoolFreeActionTask == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前不在自由行动点，无法选角色选项";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("optionId", optionId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			solarSchoolFreeActionTask.OnPlayerChooseRoleOption(roleId, optionId);
		}

		// Token: 0x06038240 RID: 229952 RVA: 0x00FB148C File Offset: 0x00FAF68C
		public override void OnPlayerChooseBehavior(int behaviorId)
		{
			SolarSchoolFreeActionTask solarSchoolFreeActionTask = base.CurrentTask as SolarSchoolFreeActionTask;
			if (solarSchoolFreeActionTask == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前不在自由行动点，无法选行为";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", behaviorId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			solarSchoolFreeActionTask.OnPlayerChooseBehavior(behaviorId);
		}

		// Token: 0x06038241 RID: 229953 RVA: 0x00FB14E0 File Offset: 0x00FAF6E0
		public unsafe override void OnClickMapLocation(int locationId)
		{
			SolarSchoolFreeActionTask solarSchoolFreeActionTask = base.CurrentTask as SolarSchoolFreeActionTask;
			if (solarSchoolFreeActionTask == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前不在自由行动点，忽略点地点";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", locationId);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "task";
				SolarSchoolTaskBase currentTask = base.CurrentTask;
				ptr = new ValueTuple<string, object>(item, ((currentTask != null) ? currentTask.GetType().Name : null) ?? "null");
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			solarSchoolFreeActionTask.OnClickMapLocation(locationId);
		}

		// Token: 0x06038242 RID: 229954 RVA: 0x00FB1580 File Offset: 0x00FAF780
		public override void OnClickGoOut()
		{
			SolarSchoolTaskBase currentTask = base.CurrentTask;
			SolarSchoolWaitGoOutTask solarSchoolWaitGoOutTask = currentTask as SolarSchoolWaitGoOutTask;
			if (solarSchoolWaitGoOutTask != null)
			{
				solarSchoolWaitGoOutTask.OnPlayerEnter();
				return;
			}
			SolarSchoolFreeActionTask solarSchoolFreeActionTask = currentTask as SolarSchoolFreeActionTask;
			if (solarSchoolFreeActionTask == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 当前不在可【外出】的停驻点", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			solarSchoolFreeActionTask.OnClickGoOut();
		}

		// Token: 0x06038243 RID: 229955 RVA: 0x00FB15D8 File Offset: 0x00FAF7D8
		public override bool CanPlayerFreeChoose()
		{
			if (base.IsActive)
			{
				SolarSchoolFreeActionTask solarSchoolFreeActionTask = base.CurrentTask as SolarSchoolFreeActionTask;
				return solarSchoolFreeActionTask != null && solarSchoolFreeActionTask.CanChoose;
			}
			return false;
		}

		// Token: 0x0401D90B RID: 121099
		private int TimeSlotIndex = -1;

		// Token: 0x0401D90C RID: 121100
		private bool WaitGoOutPhase;
	}
}
