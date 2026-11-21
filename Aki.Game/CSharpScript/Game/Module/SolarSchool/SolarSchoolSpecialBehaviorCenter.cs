using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005980 RID: 22912
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolSpecialBehaviorCenter : Singleton
	{
		// Token: 0x17006C18 RID: 27672
		// (get) Token: 0x0603879B RID: 231323 RVA: 0x00FCBA5E File Offset: 0x00FC9C5E
		private SolarSchoolPlayerData PlayerData
		{
			get
			{
				return SolarSchoolGamePlayModel.Instance.PlayerData;
			}
		}

		// Token: 0x0603879C RID: 231324 RVA: 0x00FCBA6A File Offset: 0x00FC9C6A
		public void Init(int activityId)
		{
			this.UnwatchAppearConditions();
			this.ActivityId = activityId;
			this.IsUnlockedLastRefresh = false;
			this.ValidateAppearDayConfig();
			this.ValidateFinishDeadlineConfig();
			this.RefreshAppear();
		}

		// Token: 0x0603879D RID: 231325 RVA: 0x00FCBA92 File Offset: 0x00FC9C92
		public void End()
		{
			this.UnwatchAppearConditions();
			this.ActivityId = 0;
			this.IsUnlockedLastRefresh = false;
		}

		// Token: 0x0603879E RID: 231326 RVA: 0x00FCBAA8 File Offset: 0x00FC9CA8
		public unsafe void RestoreFromSave(int activityId)
		{
			this.UnwatchAppearConditions();
			this.ActivityId = activityId;
			this.IsUnlockedLastRefresh = this.IsUnlocked();
			this.ValidateAppearDayConfig();
			this.ValidateFinishDeadlineConfig();
			this.RefreshAppear();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 读档重建特批运行态";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("监听数", this.AppearConditionHandleMap.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("存档读入记录数", this.PlayerData.GetSpecialStateCount());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0603879F RID: 231327 RVA: 0x00FCBB71 File Offset: 0x00FC9D71
		public void OnDayStart(int dayIndex)
		{
			this.RefreshAppear();
			if (!this.IsUnlocked())
			{
				return;
			}
			this.CheckDeadline(dayIndex);
		}

		// Token: 0x060387A0 RID: 231328 RVA: 0x00FCBB89 File Offset: 0x00FC9D89
		public bool IsUnlocked()
		{
			return SolarSchoolGamePlayModel.Instance.IsFunctionUnlocked(ESolarSchoolFunction.Special);
		}

		// Token: 0x060387A1 RID: 231329 RVA: 0x00FCBB98 File Offset: 0x00FC9D98
		private void RefreshAppear()
		{
			if (!this.IsUnlocked())
			{
				this.UnwatchAppearConditions();
				this.IsUnlockedLastRefresh = false;
				return;
			}
			if (!this.IsUnlockedLastRefresh)
			{
				this.IsUnlockedLastRefresh = true;
				this.ValidateUnlockTooLate();
			}
			foreach (int behaviorId in this.GetAllSpecialBehaviorIds())
			{
				SolarSchoolBehavior? specialRow = this.GetSpecialRow(behaviorId);
				if (specialRow != null)
				{
					this.UpdateAppear(specialRow.Value);
				}
			}
		}

		// Token: 0x060387A2 RID: 231330 RVA: 0x00FCBC30 File Offset: 0x00FC9E30
		private unsafe void UpdateAppear(SolarSchoolBehavior row)
		{
			int behaviorId = row.BehaviorId;
			if (this.GetState(behaviorId) != ESolarSchoolSpecialState.None)
			{
				return;
			}
			if (this.IsAcceptDeadlinePassed(row, SolarSchoolGamePlayModel.Instance.TimeData.DayIndex))
			{
				if (this.AppearConditionHandleMap.ContainsKey(behaviorId))
				{
					this.UnregisterAppear(behaviorId);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 特批到接取截止日仍未出现，停止监听出现条件";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("acceptDeadline", row.AcceptDeadline);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return;
			}
			long uniqueId;
			if (this.AppearConditionHandleMap.TryGetValue(behaviorId, out uniqueId))
			{
				ActivityConditionBase activityConditionBase;
				if (ActivityConditionCenter.Instance.TryGetCondition(uniqueId, out activityConditionBase))
				{
					return;
				}
				this.AppearConditionHandleMap.Remove(behaviorId);
			}
			if (!this.IsAppearDayReached(row))
			{
				return;
			}
			if (row.ShowConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(row.ShowConditionGroupId))
			{
				this.OnAppearHit(behaviorId);
				return;
			}
			long num = ActivityConditionCenter.Instance.RegisterGroup(row.ShowConditionGroupId, delegate
			{
				this.OnAppearConditionReached(behaviorId);
			});
			if (num == 0L)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[SolarSchool] 特批注册出现监听失败，请检查条件是否可监听及条件构建日志";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("showConditionGroupId", row.ShowConditionGroupId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			this.AppearConditionHandleMap[behaviorId] = num;
		}

		// Token: 0x060387A3 RID: 231331 RVA: 0x00FCBE15 File Offset: 0x00FCA015
		private void OnAppearConditionReached(int behaviorId)
		{
			this.AppearConditionHandleMap.Remove(behaviorId);
			this.OnAppearHit(behaviorId);
		}

		// Token: 0x060387A4 RID: 231332 RVA: 0x00FCBE2C File Offset: 0x00FCA02C
		private unsafe void OnAppearHit(int behaviorId)
		{
			if (this.GetState(behaviorId) != ESolarSchoolSpecialState.None)
			{
				return;
			}
			this.PlayerData.SetSpecialState(behaviorId, ESolarSchoolSpecialState.Appeared);
			this.UnregisterAppear(behaviorId);
			SolarSchoolBehavior? specialRow = this.GetSpecialRow(behaviorId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 特批出现";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bindRoleId", (specialRow != null) ? specialRow.GetValueOrDefault().BindRoleId : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("deliverEntry", (ESolarSchoolDeliverEntry)((specialRow != null) ? specialRow.GetValueOrDefault().DeliverEntry : 0));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("appearDay", (specialRow != null) ? specialRow.GetValueOrDefault().AppearDay : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("dayIndex", SolarSchoolGamePlayModel.Instance.TimeData.DayIndex);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x060387A5 RID: 231333 RVA: 0x00FCBF74 File Offset: 0x00FCA174
		private void UnregisterAppear(int behaviorId)
		{
			long uniqueId;
			if (this.AppearConditionHandleMap.Remove(behaviorId, out uniqueId))
			{
				ActivityConditionCenter.Instance.Unregister(uniqueId);
			}
		}

		// Token: 0x060387A6 RID: 231334 RVA: 0x00FCBF9C File Offset: 0x00FCA19C
		private void UnwatchAppearConditions()
		{
			long[] array = new long[this.AppearConditionHandleMap.Count];
			this.AppearConditionHandleMap.Values.CopyTo(array, 0);
			this.AppearConditionHandleMap.Clear();
			foreach (long uniqueId in array)
			{
				ActivityConditionCenter.Instance.Unregister(uniqueId);
			}
		}

		// Token: 0x060387A7 RID: 231335 RVA: 0x00FCBFF8 File Offset: 0x00FCA1F8
		private unsafe void CheckDeadline(int dayIndex)
		{
			foreach (int num in this.GetAllSpecialBehaviorIds())
			{
				SolarSchoolBehavior? specialRow = this.GetSpecialRow(num);
				if (specialRow != null && this.GetState(num) == ESolarSchoolSpecialState.Appeared && this.IsAcceptDeadlinePassed(specialRow.Value, dayIndex))
				{
					this.PlayerData.SetSpecialState(num, ESolarSchoolSpecialState.Failed);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 特批未接取即过期";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("acceptDeadline", specialRow.Value.AcceptDeadline);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("dayIndex", dayIndex);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
		}

		// Token: 0x060387A8 RID: 231336 RVA: 0x00FCC118 File Offset: 0x00FCA318
		public unsafe List<SolarSchoolActionBase> SettleDeadlineFailures(int dayIndex)
		{
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			if (!this.IsUnlocked())
			{
				return list;
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			foreach (int num in this.GetAllSpecialBehaviorIds())
			{
				SolarSchoolBehavior? specialRow = this.GetSpecialRow(num);
				if (specialRow != null && this.GetState(num) == ESolarSchoolSpecialState.Accepted)
				{
					int finishDeadline = this.GetFinishDeadline(num);
					if (finishDeadline > 0 && dayIndex >= finishDeadline)
					{
						this.PlayerData.SetSpecialState(num, ESolarSchoolSpecialState.Failed);
						Log instance2 = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.LRC;
						string message = "[SolarSchool] 特批到期未完成，判失败";
						<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("finishDeadline", finishDeadline);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("dayIndex", dayIndex);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("完成次数", this.GetFinishedCount(num));
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("需要次数", specialRow.Value.FinishCount);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("failAction", specialRow.Value.FailAction);
						instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
						SolarSchoolActionBase solarSchoolActionBase = instance.CreateAction(EActivityActionType.SolarSchoolPopup, SolarSchoolPopupAction.CreateEventPopupParams(ESolarSchoolPopupId.SpecialBehaviorFail, num));
						if (solarSchoolActionBase != null)
						{
							list.Add(solarSchoolActionBase);
						}
						if (specialRow.Value.FailAction != 0)
						{
							SolarSchoolActionBase solarSchoolActionBase2 = instance.CreateAction(specialRow.Value.FailAction);
							if (solarSchoolActionBase2 != null)
							{
								list.Add(solarSchoolActionBase2);
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060387A9 RID: 231337 RVA: 0x00FCC32C File Offset: 0x00FCA52C
		private bool IsAcceptDeadlinePassed(SolarSchoolBehavior row, int dayIndex)
		{
			return row.AcceptDeadline > 0 && dayIndex > row.AcceptDeadline;
		}

		// Token: 0x060387AA RID: 231338 RVA: 0x00FCC344 File Offset: 0x00FCA544
		private bool IsAppearDayReached(SolarSchoolBehavior row)
		{
			return row.AppearDay <= 0 || SolarSchoolGamePlayModel.Instance.TimeData.DayIndex >= row.AppearDay;
		}

		// Token: 0x060387AB RID: 231339 RVA: 0x00FCC370 File Offset: 0x00FCA570
		private unsafe void ValidateAppearDayConfig()
		{
			foreach (int num in this.GetAllSpecialBehaviorIds())
			{
				SolarSchoolBehavior? specialRow = this.GetSpecialRow(num);
				if (specialRow != null && specialRow.Value.AppearDay > 0 && specialRow.Value.AcceptDeadline > 0 && specialRow.Value.AppearDay > specialRow.Value.AcceptDeadline)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 特批配表错误：出现日晚于接取截止日，该特批永远不会出现";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("appearDay", specialRow.Value.AppearDay);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("acceptDeadline", specialRow.Value.AcceptDeadline);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
		}

		// Token: 0x060387AC RID: 231340 RVA: 0x00FCC4D0 File Offset: 0x00FCA6D0
		private unsafe void ValidateFinishDeadlineConfig()
		{
			int totalDay = SolarSchoolGamePlayModel.Instance.TotalDay;
			foreach (int num in this.GetAllSpecialBehaviorIds())
			{
				SolarSchoolBehavior? specialRow = this.GetSpecialRow(num);
				if (specialRow != null && specialRow.Value.FinishDeadline > 0)
				{
					if (specialRow.Value.FinishDeadline < specialRow.Value.AcceptDeadline)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.LRC;
						string message = "[SolarSchool] 特批配表错误：完成截止日早于接取截止日";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("finishDeadline", specialRow.Value.FinishDeadline);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("acceptDeadline", specialRow.Value.AcceptDeadline);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					if (totalDay > 0 && specialRow.Value.FinishDeadline > totalDay)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.SolarSchool;
						ELogAuthor author2 = ELogAuthor.LRC;
						string message2 = "[SolarSchool] 特批配表错误：完成截止日超过总天数";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("behaviorId", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("finishDeadline", specialRow.Value.FinishDeadline);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("totalDay", totalDay);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					}
				}
			}
		}

		// Token: 0x060387AD RID: 231341 RVA: 0x00FCC6D4 File Offset: 0x00FCA8D4
		private unsafe void ValidateUnlockTooLate()
		{
			int dayIndex = SolarSchoolGamePlayModel.Instance.TimeData.DayIndex;
			foreach (int num in this.GetAllSpecialBehaviorIds())
			{
				SolarSchoolBehavior? specialRow = this.GetSpecialRow(num);
				if (specialRow != null && this.GetState(num) == ESolarSchoolSpecialState.None && this.IsAcceptDeadlinePassed(specialRow.Value, dayIndex))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 特批配表错误：特批功能解锁晚于接取截止日，该特批永远不会出现";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("acceptDeadline", specialRow.Value.AcceptDeadline);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("解锁日", dayIndex);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
		}

		// Token: 0x060387AE RID: 231342 RVA: 0x00FCC7F8 File Offset: 0x00FCA9F8
		public ESolarSchoolSpecialState GetState(int behaviorId)
		{
			return this.PlayerData.GetSpecialState(behaviorId);
		}

		// Token: 0x060387AF RID: 231343 RVA: 0x00FCC808 File Offset: 0x00FCAA08
		public unsafe bool TryMarkFinished(int behaviorId)
		{
			if (this.GetState(behaviorId) != ESolarSchoolSpecialState.Accepted)
			{
				return false;
			}
			SolarSchoolBehavior? specialRow = this.GetSpecialRow(behaviorId);
			if (specialRow == null || specialRow.Value.FinishCount <= 0 || this.GetFinishedCount(behaviorId) < specialRow.Value.FinishCount)
			{
				return false;
			}
			this.PlayerData.SetSpecialState(behaviorId, ESolarSchoolSpecialState.Finished);
			SolarSchoolGamePlayModel.Instance.SummaryRecordData.RecordCompletedNotice();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 特批完成";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("完成次数", this.GetFinishedCount(behaviorId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("需要次数", specialRow.Value.FinishCount);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return true;
		}

		// Token: 0x060387B0 RID: 231344 RVA: 0x00FCC90C File Offset: 0x00FCAB0C
		public int GetAppearedBehaviorIdByRole(int roleId)
		{
			if (roleId == 0 || !this.IsUnlocked())
			{
				return 0;
			}
			int num = 0;
			foreach (int num2 in this.GetAllSpecialBehaviorIds())
			{
				if (this.GetState(num2) == ESolarSchoolSpecialState.Appeared)
				{
					SolarSchoolBehavior? specialRow = this.GetSpecialRow(num2);
					if (specialRow != null && specialRow.Value.BindRoleId == roleId && specialRow.Value.DeliverEntry == 2 && specialRow.Value.ShowInMap && (num == 0 || num2 < num))
					{
						num = num2;
					}
				}
			}
			return num;
		}

		// Token: 0x060387B1 RID: 231345 RVA: 0x00FCC9C4 File Offset: 0x00FCABC4
		public bool ShowAcceptEntry(int roleId)
		{
			return this.IsUnlocked() && SolarSchoolGamePlayModel.Instance.InstanceType == ESolarSchoolInstanceType.Normal && this.GetAppearedBehaviorIdByRole(roleId) != 0;
		}

		// Token: 0x060387B2 RID: 231346 RVA: 0x00FCC9E8 File Offset: 0x00FCABE8
		public int GetUnviewedTalkBehaviorIdByRole(int roleId)
		{
			int appearedBehaviorIdByRole = this.GetAppearedBehaviorIdByRole(roleId);
			if (appearedBehaviorIdByRole == 0 || this.PlayerData.IsSpecialTalkViewed(appearedBehaviorIdByRole))
			{
				return 0;
			}
			return appearedBehaviorIdByRole;
		}

		// Token: 0x060387B3 RID: 231347 RVA: 0x00FCCA11 File Offset: 0x00FCAC11
		public void MarkSpecialTalkViewed(int behaviorId)
		{
			this.PlayerData.MarkSpecialTalkViewed(behaviorId);
		}

		// Token: 0x060387B4 RID: 231348 RVA: 0x00FCCA1F File Offset: 0x00FCAC1F
		public bool HasUnviewedSpecialBehavior(int roleId)
		{
			return this.ShowAcceptEntry(roleId) && this.GetUnviewedTalkBehaviorIdByRole(roleId) != 0;
		}

		// Token: 0x060387B5 RID: 231349 RVA: 0x00FCCA38 File Offset: 0x00FCAC38
		public bool HasUnviewedSpecialBehaviorAtLocation(int locationId)
		{
			SolarSchoolLocationRole locationRole = SolarSchoolGamePlayModel.Instance.MapData.GetLocationRole(locationId);
			return this.HasUnviewedSpecialBehavior(locationRole.RoleId);
		}

		// Token: 0x060387B6 RID: 231350 RVA: 0x00FCCA62 File Offset: 0x00FCAC62
		public bool CanAccept(int behaviorId)
		{
			return this.GetAcceptFailType(behaviorId) == ESolarSchoolSpecialAcceptFailType.None;
		}

		// Token: 0x060387B7 RID: 231351 RVA: 0x00FCCA70 File Offset: 0x00FCAC70
		public ESolarSchoolSpecialAcceptFailType GetAcceptFailType(int behaviorId)
		{
			if (!this.IsUnlocked())
			{
				return ESolarSchoolSpecialAcceptFailType.NotUnlocked;
			}
			SolarSchoolBehavior? specialRow = this.GetSpecialRow(behaviorId);
			if (specialRow == null)
			{
				return ESolarSchoolSpecialAcceptFailType.ConfigMissing;
			}
			if (this.GetState(behaviorId) != ESolarSchoolSpecialState.Appeared)
			{
				return ESolarSchoolSpecialAcceptFailType.StateNotAppeared;
			}
			int dayIndex = SolarSchoolGamePlayModel.Instance.TimeData.DayIndex;
			if (this.IsAcceptDeadlinePassed(specialRow.Value, dayIndex))
			{
				return ESolarSchoolSpecialAcceptFailType.AcceptDeadlinePassed;
			}
			if (this.FindUnsatisfiedAcceptAttr(behaviorId) != null)
			{
				return ESolarSchoolSpecialAcceptFailType.AttrNotSatisfied;
			}
			return ESolarSchoolSpecialAcceptFailType.None;
		}

		// Token: 0x060387B8 RID: 231352 RVA: 0x00FCCADC File Offset: 0x00FCACDC
		public unsafe void LogAcceptFail(int behaviorId, string scene)
		{
			ESolarSchoolSpecialAcceptFailType acceptFailType = this.GetAcceptFailType(behaviorId);
			switch (acceptFailType)
			{
			case ESolarSchoolSpecialAcceptFailType.None:
				return;
			case ESolarSchoolSpecialAcceptFailType.NotUnlocked:
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] " + scene + "：特批功能未解锁";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dayIndex", SolarSchoolGamePlayModel.Instance.TimeData.DayIndex);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			case ESolarSchoolSpecialAcceptFailType.ConfigMissing:
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] " + scene + "：特批配表行不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("activityId", this.ActivityId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			case ESolarSchoolSpecialAcceptFailType.StateNotAppeared:
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SolarSchool;
				ELogAuthor author3 = ELogAuthor.LRC;
				string message3 = "[SolarSchool] " + scene + "：特批状态不是已出现";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("state", this.GetState(behaviorId));
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return;
			}
			case ESolarSchoolSpecialAcceptFailType.AcceptDeadlinePassed:
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.SolarSchool;
				ELogAuthor author4 = ELogAuthor.LRC;
				string message4 = "[SolarSchool] " + scene + "：已过接取截止日";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("acceptDeadline", this.GetAcceptDeadline(behaviorId));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("dayIndex", SolarSchoolGamePlayModel.Instance.TimeData.DayIndex);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
				return;
			}
			case ESolarSchoolSpecialAcceptFailType.AttrNotSatisfied:
			{
				SolarSchoolAttrRequire value = this.FindUnsatisfiedAcceptAttr(behaviorId).Value;
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.SolarSchool;
				ELogAuthor author5 = ELogAuthor.LRC;
				string message5 = "[SolarSchool] " + scene + "：接取属性不达标";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("attr", value.Attr);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("当前值", this.PlayerData.GetAttr(value.Attr));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("需求值", value.RequireValue);
				instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 4));
				return;
			}
			default:
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.SolarSchool;
				ELogAuthor author6 = ELogAuthor.LRC;
				string message6 = "[SolarSchool] " + scene + "：未处理的失败类型";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("failType", acceptFailType);
				instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 2));
				return;
			}
			}
		}

		// Token: 0x060387B9 RID: 231353 RVA: 0x00FCCE50 File Offset: 0x00FCB050
		public List<SolarSchoolAttrRequire> GetAcceptAttrRequireList(int behaviorId)
		{
			List<SolarSchoolAttrRequire> list = new List<SolarSchoolAttrRequire>();
			SolarSchoolBehavior? specialRow = this.GetSpecialRow(behaviorId);
			if (specialRow == null)
			{
				return list;
			}
			for (int i = 0; i < specialRow.Value.AttrRequireLength; i++)
			{
				DicIntInt? dicIntInt = specialRow.Value.AttrRequire(i);
				if (dicIntInt != null)
				{
					ESolarSchoolSecondAttr key = (ESolarSchoolSecondAttr)dicIntInt.Value.Key;
					if (key != ESolarSchoolSecondAttr.None)
					{
						list.Add(new SolarSchoolAttrRequire(key, dicIntInt.Value.Value));
					}
				}
			}
			return list;
		}

		// Token: 0x060387BA RID: 231354 RVA: 0x00FCCEE0 File Offset: 0x00FCB0E0
		private SolarSchoolAttrRequire? FindUnsatisfiedAcceptAttr(int behaviorId)
		{
			foreach (SolarSchoolAttrRequire solarSchoolAttrRequire in this.GetAcceptAttrRequireList(behaviorId))
			{
				if (this.PlayerData.GetAttr(solarSchoolAttrRequire.Attr) < solarSchoolAttrRequire.RequireValue)
				{
					return new SolarSchoolAttrRequire?(solarSchoolAttrRequire);
				}
			}
			return null;
		}

		// Token: 0x060387BB RID: 231355 RVA: 0x00FCCF5C File Offset: 0x00FCB15C
		public bool IsAcceptLimitReached()
		{
			return this.GetInProgressCount() >= this.GetAcceptMaxInProgress();
		}

		// Token: 0x060387BC RID: 231356 RVA: 0x00FCCF70 File Offset: 0x00FCB170
		public int GetInProgressCount()
		{
			int num = 0;
			foreach (int behaviorId in this.GetAllSpecialBehaviorIds())
			{
				if (this.GetState(behaviorId) == ESolarSchoolSpecialState.Accepted)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060387BD RID: 231357 RVA: 0x00FCCFD0 File Offset: 0x00FCB1D0
		public int GetAcceptMaxInProgress()
		{
			return SolarSchoolConfig.Instance.TryGetParamInt(this.ActivityId, "SpecialAcceptMaxInProgress").GetValueOrDefault(3);
		}

		// Token: 0x060387BE RID: 231358 RVA: 0x00FCCFFC File Offset: 0x00FCB1FC
		public bool NeedDeadlineWarning(int behaviorId)
		{
			SolarSchoolBehavior? specialRow = this.GetSpecialRow(behaviorId);
			if (specialRow == null || specialRow.Value.FinishCount <= 0)
			{
				return false;
			}
			int finishDeadline = this.GetFinishDeadline(behaviorId);
			if (finishDeadline <= 0)
			{
				return true;
			}
			int num = specialRow.Value.FinishCount - this.GetFinishedCount(behaviorId);
			return num > 0 && this.CountUsableTimes(specialRow.Value, finishDeadline) < num;
		}

		// Token: 0x060387BF RID: 231359 RVA: 0x00FCD06C File Offset: 0x00FCB26C
		public unsafe bool TryAccept(int behaviorId)
		{
			if (!this.CanAccept(behaviorId))
			{
				this.LogAcceptFail(behaviorId, "接取特批失败");
				return false;
			}
			SolarSchoolBehavior value = this.GetSpecialRow(behaviorId).Value;
			int num = this.CalcFinishDeadline(value);
			if (num <= 0)
			{
				return false;
			}
			int dayIndex = SolarSchoolGamePlayModel.Instance.TimeData.DayIndex;
			this.PlayerData.SetSpecialState(behaviorId, ESolarSchoolSpecialState.Accepted);
			this.UnregisterAppear(behaviorId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 特批接取成功";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("acceptedDayIndex", dayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("finishDeadline", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("需要次数", value.FinishCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("占用星期", string.Join<int>(",", value.GetOccupyDayOfWeekArray()));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if (value.AcceptAction != 0)
			{
				SolarSchoolGamePlayModel instance2 = SolarSchoolGamePlayModel.Instance;
				SolarSchoolActionBase solarSchoolActionBase = instance2.CreateAction(value.AcceptAction);
				if (solarSchoolActionBase != null && !instance2.TryInjectActionToCurrentTask(solarSchoolActionBase))
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.SolarSchool;
					ELogAuthor author2 = ELogAuthor.LRC;
					string message2 = "[SolarSchool] 特批接取 AVG 未投递：当前无可注入 Task";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("acceptAction", value.AcceptAction);
					instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
			}
			return true;
		}

		// Token: 0x060387C0 RID: 231360 RVA: 0x00FCD234 File Offset: 0x00FCB434
		public List<int> GetSchedulableBehaviorIds()
		{
			List<int> list = new List<int>();
			if (!this.IsUnlocked())
			{
				return list;
			}
			int dayIndex = SolarSchoolGamePlayModel.Instance.TimeData.DayIndex;
			foreach (int num in this.GetAllSpecialBehaviorIds())
			{
				if (this.GetState(num) == ESolarSchoolSpecialState.Accepted)
				{
					int finishDeadline = this.GetFinishDeadline(num);
					if (finishDeadline <= 0 || dayIndex <= finishDeadline)
					{
						SolarSchoolBehavior? specialRow = this.GetSpecialRow(num);
						if (specialRow != null && specialRow.Value.GetOccupyDayOfWeekArray().Length != 0)
						{
							list.Add(num);
						}
					}
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x060387C1 RID: 231361 RVA: 0x00FCD2F0 File Offset: 0x00FCB4F0
		public int GetFinishedCount(int behaviorId)
		{
			return this.PlayerData.GetCompletedCount(behaviorId);
		}

		// Token: 0x060387C2 RID: 231362 RVA: 0x00FCD300 File Offset: 0x00FCB500
		public int GetFinishDeadline(int behaviorId)
		{
			SolarSchoolBehavior? specialRow = this.GetSpecialRow(behaviorId);
			if (specialRow != null)
			{
				return this.CalcFinishDeadline(specialRow.Value);
			}
			return 0;
		}

		// Token: 0x060387C3 RID: 231363 RVA: 0x00FCD330 File Offset: 0x00FCB530
		public int GetAcceptDeadline(int behaviorId)
		{
			SolarSchoolBehavior? specialRow = this.GetSpecialRow(behaviorId);
			if (specialRow != null)
			{
				return specialRow.Value.AcceptDeadline;
			}
			return 0;
		}

		// Token: 0x060387C4 RID: 231364 RVA: 0x00FCD360 File Offset: 0x00FCB560
		private unsafe int CalcFinishDeadline(SolarSchoolBehavior row)
		{
			if (row.FinishDeadline > 0)
			{
				return row.FinishDeadline;
			}
			int[] occupyDayOfWeekArray = row.GetOccupyDayOfWeekArray();
			if (occupyDayOfWeekArray.Length == 0 || row.FinishValidWeek <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 特批配表错误：占用星期为空或完成有效周数未配，无法算完成截止日";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", row.BehaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("occupyCount", occupyDayOfWeekArray.Length);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("finishValidWeek", row.FinishValidWeek);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return 0;
			}
			int num = 0;
			foreach (int num2 in occupyDayOfWeekArray)
			{
				if (num2 < 1 || num2 > 5)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SolarSchool;
					ELogAuthor author2 = ELogAuthor.LRC;
					string message2 = "[SolarSchool] 特批配表错误：占用星期超出可排范围，该特批永远置入不进排期表";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("behaviorId", row.BehaviorId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("weekday", num2);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("可排星期上限", 5);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					return 0;
				}
				if (num2 > num)
				{
					num = num2;
				}
			}
			int totalDay = SolarSchoolGamePlayModel.Instance.TotalDay;
			if (totalDay <= 0)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SolarSchool;
				ELogAuthor author3 = ELogAuthor.LRC;
				string message3 = "[SolarSchool] 总天数读取失败，无法算完成截止日，检查 SolarSchoolParam 的 TotalDays 配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("behaviorId", row.BehaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("activityId", this.ActivityId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return 0;
			}
			int num3 = SolarSchoolGamePlayModel.Instance.TimeData.GetMondayDayIndex(row.AcceptDeadline) + 7;
			int num4 = 0;
			while (num3 + num - 1 <= totalDay)
			{
				if (this.IsValidWeek(num3, occupyDayOfWeekArray))
				{
					num4++;
					if (num4 >= row.FinishValidWeek)
					{
						return num3 + num - 1;
					}
				}
				num3 += 7;
			}
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.SolarSchool;
			ELogAuthor author4 = ELogAuthor.LRC;
			string message4 = "[SolarSchool] 特批配表错误：总天数内凑不满有效周，该特批不可能完成";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("behaviorId", row.BehaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("finishValidWeek", row.FinishValidWeek);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("已找到有效周", num4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("acceptDeadline", row.AcceptDeadline);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("totalDay", totalDay);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 5));
			return 0;
		}

		// Token: 0x060387C5 RID: 231365 RVA: 0x00FCD678 File Offset: 0x00FCB878
		private bool IsValidWeek(int mondayDayIndex, int[] occupy)
		{
			SolarSchoolScheduleData scheduleData = SolarSchoolGamePlayModel.Instance.ScheduleData;
			foreach (int num in occupy)
			{
				if (!scheduleData.IsNormalDayByDayIndex(mondayDayIndex + num - 1))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060387C6 RID: 231366 RVA: 0x00FCD6B4 File Offset: 0x00FCB8B4
		private int CountUsableTimes(SolarSchoolBehavior row, int finishDeadline)
		{
			int[] occupyDayOfWeekArray = row.GetOccupyDayOfWeekArray();
			if (occupyDayOfWeekArray.Length == 0)
			{
				return 0;
			}
			int num = 0;
			int num2 = int.MaxValue;
			foreach (int num3 in occupyDayOfWeekArray)
			{
				if (num3 > num)
				{
					num = num3;
				}
				if (num3 < num2)
				{
					num2 = num3;
				}
			}
			int currentMondayDayIndex = SolarSchoolGamePlayModel.Instance.TimeData.CurrentMondayDayIndex;
			int num4 = 0;
			int num5 = currentMondayDayIndex;
			while (num5 + num - 1 <= finishDeadline)
			{
				if (this.IsValidWeek(num5, occupyDayOfWeekArray) && (num5 != currentMondayDayIndex || this.IsFirstDayPlaceable(row, num2)))
				{
					num4++;
				}
				num5 += 7;
			}
			return num4 * occupyDayOfWeekArray.Length;
		}

		// Token: 0x060387C7 RID: 231367 RVA: 0x00FCD754 File Offset: 0x00FCB954
		private bool IsFirstDayPlaceable(SolarSchoolBehavior row, int firstWeekday)
		{
			ESolarSchoolTimeSlot[] availableSlots = SolarSchoolUtils.GetAvailableSlots(row);
			return availableSlots.Length != 1 || SolarSchoolGamePlayModel.Instance.TimeData.IsSlotAtOrAfterNow(firstWeekday, availableSlots[0]);
		}

		// Token: 0x060387C8 RID: 231368 RVA: 0x00FCD784 File Offset: 0x00FCB984
		private List<int> GetAllSpecialBehaviorIds()
		{
			List<int> list = new List<int>();
			IReadOnlyList<SolarSchoolBehavior> behaviorListByActivityId = SolarSchoolConfig.Instance.GetBehaviorListByActivityId(this.ActivityId);
			if (behaviorListByActivityId == null)
			{
				return list;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (SolarSchoolBehavior solarSchoolBehavior in behaviorListByActivityId)
			{
				if (solarSchoolBehavior.BehaviorType == 4 && hashSet.Add(solarSchoolBehavior.BehaviorId))
				{
					list.Add(solarSchoolBehavior.BehaviorId);
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x060387C9 RID: 231369 RVA: 0x00FCD818 File Offset: 0x00FCBA18
		private SolarSchoolBehavior? GetSpecialRow(int behaviorId)
		{
			return this.PlayerData.GetCurrentLevelRow(behaviorId);
		}

		// Token: 0x17006C19 RID: 27673
		// (get) Token: 0x060387CA RID: 231370 RVA: 0x00FCD826 File Offset: 0x00FCBA26
		public static SolarSchoolSpecialBehaviorCenter Instance
		{
			get
			{
				if (SolarSchoolSpecialBehaviorCenter._instance == null)
				{
					SolarSchoolSpecialBehaviorCenter._instance = new SolarSchoolSpecialBehaviorCenter();
					SolarSchoolSpecialBehaviorCenter._instance.OnInit();
				}
				return SolarSchoolSpecialBehaviorCenter._instance;
			}
		}

		// Token: 0x060387CB RID: 231371 RVA: 0x00FCD849 File Offset: 0x00FCBA49
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060387CC RID: 231372 RVA: 0x00FCD84B File Offset: 0x00FCBA4B
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolSpecialBehaviorCenter instance = SolarSchoolSpecialBehaviorCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SolarSchoolSpecialBehaviorCenter._instance = null;
		}

		// Token: 0x060387CD RID: 231373 RVA: 0x00FCD864 File Offset: 0x00FCBA64
		static SolarSchoolSpecialBehaviorCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolSpecialBehaviorCenter.CreateStaticDefaultValue), new Action(SolarSchoolSpecialBehaviorCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401DC41 RID: 121921
		private readonly Dictionary<int, long> AppearConditionHandleMap = new Dictionary<int, long>();

		// Token: 0x0401DC42 RID: 121922
		private int ActivityId;

		// Token: 0x0401DC43 RID: 121923
		private bool IsUnlockedLastRefresh;

		// Token: 0x0401DC44 RID: 121924
		[Nullable(2)]
		private static SolarSchoolSpecialBehaviorCenter _instance;
	}
}
