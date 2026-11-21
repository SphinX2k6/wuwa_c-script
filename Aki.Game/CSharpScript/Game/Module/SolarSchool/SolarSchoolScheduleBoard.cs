using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058DE RID: 22750
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScheduleBoard
	{
		// Token: 0x060380CE RID: 229582 RVA: 0x00FAAA40 File Offset: 0x00FA8C40
		private bool TryIndex(int weekday, ESolarSchoolTimeSlot slot, out int weekdayIndex, out int slotIndex)
		{
			weekdayIndex = weekday - 1;
			slotIndex = ((slot == ESolarSchoolTimeSlot.Day) ? 0 : ((slot == ESolarSchoolTimeSlot.Dusk) ? 1 : -1));
			return weekdayIndex >= 0 && weekdayIndex < 5 && slotIndex >= 0;
		}

		// Token: 0x060380CF RID: 229583 RVA: 0x00FAAA70 File Offset: 0x00FA8C70
		public void Clear()
		{
			Array.Clear(this.Cells, 0, this.Cells.Length);
			Array.Clear(this.InstanceIds, 0, this.InstanceIds.Length);
			Array.Clear(this.SkippedWeekdays, 0, this.SkippedWeekdays.Length);
		}

		// Token: 0x060380D0 RID: 229584 RVA: 0x00FAAABC File Offset: 0x00FA8CBC
		public void CopyFrom(SolarSchoolScheduleBoard source)
		{
			if (source == null)
			{
				return;
			}
			Array.Copy(source.Cells, this.Cells, this.Cells.Length);
			Array.Copy(source.InstanceIds, this.InstanceIds, this.InstanceIds.Length);
			Array.Copy(source.SkippedWeekdays, this.SkippedWeekdays, this.SkippedWeekdays.Length);
		}

		// Token: 0x060380D1 RID: 229585 RVA: 0x00FAAB1C File Offset: 0x00FA8D1C
		public bool ContentEquals(SolarSchoolScheduleBoard other)
		{
			if (other == null)
			{
				return false;
			}
			for (int i = 0; i < 5; i++)
			{
				if (this.InstanceIds[i] != other.InstanceIds[i] || this.SkippedWeekdays[i] != other.SkippedWeekdays[i])
				{
					return false;
				}
				for (int j = 0; j < 2; j++)
				{
					SolarSchoolSlotCell solarSchoolSlotCell = this.Cells[i, j];
					SolarSchoolSlotCell solarSchoolSlotCell2 = other.Cells[i, j];
					if (solarSchoolSlotCell.BehaviorId != solarSchoolSlotCell2.BehaviorId || solarSchoolSlotCell.ReplacedLowBehaviorId != solarSchoolSlotCell2.ReplacedLowBehaviorId || solarSchoolSlotCell.FirstWeekday != solarSchoolSlotCell2.FirstWeekday || solarSchoolSlotCell.FromPlayerExecute != solarSchoolSlotCell2.FromPlayerExecute)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060380D2 RID: 229586 RVA: 0x00FAABCC File Offset: 0x00FA8DCC
		public void RestoreCell(int weekday, ESolarSchoolTimeSlot slot, SolarSchoolSlotCell cell)
		{
			int num;
			int num2;
			if (this.TryIndex(weekday, slot, out num, out num2))
			{
				this.Cells[num, num2] = cell;
			}
		}

		// Token: 0x060380D3 RID: 229587 RVA: 0x00FAABF5 File Offset: 0x00FA8DF5
		public void SetInstanceId(int weekday, int instanceId)
		{
			if (weekday < 1 || weekday > 5)
			{
				return;
			}
			this.InstanceIds[weekday - 1] = instanceId;
		}

		// Token: 0x060380D4 RID: 229588 RVA: 0x00FAAC0B File Offset: 0x00FA8E0B
		public int GetInstanceId(int weekday)
		{
			if (weekday < 1 || weekday > 5)
			{
				return 0;
			}
			return this.InstanceIds[weekday - 1];
		}

		// Token: 0x060380D5 RID: 229589 RVA: 0x00FAAC24 File Offset: 0x00FA8E24
		public bool IsNormalDay(int weekday)
		{
			int instanceId = this.GetInstanceId(weekday);
			return instanceId == 0 || instanceId == 1;
		}

		// Token: 0x060380D6 RID: 229590 RVA: 0x00FAAC42 File Offset: 0x00FA8E42
		public void SetSkippedDay(int weekday, bool isSkipped)
		{
			if (weekday < 1 || weekday > 5)
			{
				return;
			}
			this.SkippedWeekdays[weekday - 1] = isSkipped;
		}

		// Token: 0x060380D7 RID: 229591 RVA: 0x00FAAC58 File Offset: 0x00FA8E58
		public bool IsSkippedDay(int weekday)
		{
			return weekday >= 1 && weekday <= 5 && this.SkippedWeekdays[weekday - 1];
		}

		// Token: 0x060380D8 RID: 229592 RVA: 0x00FAAC70 File Offset: 0x00FA8E70
		public SolarSchoolSlotCell GetCell(int weekday, ESolarSchoolTimeSlot slot)
		{
			int num;
			int num2;
			if (!this.TryIndex(weekday, slot, out num, out num2))
			{
				return default(SolarSchoolSlotCell);
			}
			return this.Cells[num, num2];
		}

		// Token: 0x060380D9 RID: 229593 RVA: 0x00FAACA2 File Offset: 0x00FA8EA2
		public int GetScheduledBehaviorId(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.GetCell(weekday, slot).BehaviorId;
		}

		// Token: 0x060380DA RID: 229594 RVA: 0x00FAACB4 File Offset: 0x00FA8EB4
		public bool IsSlotScheduled(int weekday, ESolarSchoolTimeSlot slot)
		{
			SolarSchoolSlotCell cell = this.GetCell(weekday, slot);
			return cell.BehaviorId != 0 && !cell.FromPlayerExecute;
		}

		// Token: 0x060380DB RID: 229595 RVA: 0x00FAACE0 File Offset: 0x00FA8EE0
		public ESolarSchoolBehaviorType? GetSlotBehaviorType(int weekday, ESolarSchoolTimeSlot slot)
		{
			int scheduledBehaviorId = this.GetScheduledBehaviorId(weekday, slot);
			if (scheduledBehaviorId == 0)
			{
				return null;
			}
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			return SolarSchoolConfig.Instance.GetBehaviorType(activityId, scheduledBehaviorId);
		}

		// Token: 0x060380DC RID: 229596 RVA: 0x00FAAD1C File Offset: 0x00FA8F1C
		public bool HasPlayerScheduledBehavior()
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					if (this.Cells[i, j].BehaviorId != 0)
					{
						ESolarSchoolBehaviorType? slotBehaviorTypeByIndex = this.GetSlotBehaviorTypeByIndex(i, j);
						if (slotBehaviorTypeByIndex == null)
						{
							goto IL_41;
						}
						ESolarSchoolBehaviorType valueOrDefault = slotBehaviorTypeByIndex.GetValueOrDefault();
						if (valueOrDefault - ESolarSchoolBehaviorType.Normal > 1)
						{
							goto IL_41;
						}
						bool flag = true;
						IL_44:
						if (flag)
						{
							return true;
						}
						goto IL_4A;
						IL_41:
						flag = false;
						goto IL_44;
					}
					IL_4A:;
				}
			}
			return false;
		}

		// Token: 0x060380DD RID: 229597 RVA: 0x00FAAD84 File Offset: 0x00FA8F84
		private bool CheckDateValid(SolarSchoolSlotCell cell, ESolarSchoolTimeSlot slot)
		{
			return cell.FirstWeekday > 0 && this.IsSlotAtOrAfterNow(cell.FirstWeekday, slot);
		}

		// Token: 0x060380DE RID: 229598 RVA: 0x00FAADA0 File Offset: 0x00FA8FA0
		private bool CanModifySlot(int weekday, ESolarSchoolTimeSlot slot, out ESolarSchoolBehaviorType? type)
		{
			type = this.GetSlotBehaviorType(weekday, slot);
			ESolarSchoolBehaviorType? esolarSchoolBehaviorType = type;
			if (esolarSchoolBehaviorType != null)
			{
				ESolarSchoolBehaviorType valueOrDefault = esolarSchoolBehaviorType.GetValueOrDefault();
				if (valueOrDefault != ESolarSchoolBehaviorType.Normal)
				{
					return valueOrDefault == ESolarSchoolBehaviorType.Special && this.CheckDateValid(this.GetCell(weekday, slot), slot);
				}
			}
			return this.IsSlotAtOrAfterNow(weekday, slot);
		}

		// Token: 0x060380DF RID: 229599 RVA: 0x00FAAE04 File Offset: 0x00FA9004
		public void PrefillBehavior(int weekday, ESolarSchoolTimeSlot slot, int behaviorId)
		{
			int num;
			int num2;
			if (!this.TryIndex(weekday, slot, out num, out num2) || behaviorId == 0)
			{
				return;
			}
			this.Cells[num, num2] = new SolarSchoolSlotCell
			{
				BehaviorId = behaviorId
			};
		}

		// Token: 0x060380E0 RID: 229600 RVA: 0x00FAAE44 File Offset: 0x00FA9044
		public void RecordExecutedBehavior(int weekday, ESolarSchoolTimeSlot slot, int behaviorId)
		{
			int num;
			int num2;
			if (!this.TryIndex(weekday, slot, out num, out num2) || behaviorId == 0)
			{
				return;
			}
			if (this.Cells[num, num2].BehaviorId != 0)
			{
				return;
			}
			this.Cells[num, num2] = new SolarSchoolSlotCell
			{
				BehaviorId = behaviorId,
				FromPlayerExecute = true
			};
		}

		// Token: 0x060380E1 RID: 229601 RVA: 0x00FAAEA0 File Offset: 0x00FA90A0
		public unsafe bool SetNormalBehavior(int weekday, ESolarSchoolTimeSlot slot, int behaviorId)
		{
			int num;
			int num2;
			if (!this.TryIndex(weekday, slot, out num, out num2))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 排期格非法(星期非 1~5 或非白天/放学后列)";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("weekday", weekday);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("slot", slot);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ESolarSchoolBehaviorType? esolarSchoolBehaviorType;
			if (!this.CanModifySlot(weekday, slot, out esolarSchoolBehaviorType))
			{
				return false;
			}
			if (esolarSchoolBehaviorType.GetValueOrDefault() == ESolarSchoolBehaviorType.Special)
			{
				this.RemoveSpecialBehavior(this.Cells[num, num2].BehaviorId, false);
			}
			this.Cells[num, num2] = ((behaviorId == 0) ? default(SolarSchoolSlotCell) : new SolarSchoolSlotCell
			{
				BehaviorId = behaviorId
			});
			return true;
		}

		// Token: 0x060380E2 RID: 229602 RVA: 0x00FAAF80 File Offset: 0x00FA9180
		public unsafe bool CanSetSpecialBehavior(int specialBehaviorId, ESolarSchoolTimeSlot slot, int[] weekdays, out int firstWeekday)
		{
			firstWeekday = 0;
			if (specialBehaviorId == 0 || weekdays == null || weekdays.Length == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 置入特批参数非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("specialBehaviorId", specialBehaviorId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			firstWeekday = int.MaxValue;
			foreach (int num in weekdays)
			{
				int num2;
				int num3;
				if (!this.TryIndex(num, slot, out num2, out num3))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SolarSchool;
					ELogAuthor author2 = ELogAuthor.LRC;
					string message2 = "[SolarSchool] 置入特批：格非法";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("specialBehaviorId", specialBehaviorId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("weekday", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("slot", slot);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return false;
				}
				if (num < firstWeekday)
				{
					firstWeekday = num;
				}
			}
			if (!this.IsSlotAtOrAfterNow(firstWeekday, slot))
			{
				return false;
			}
			foreach (int weekday in weekdays)
			{
				if (!this.IsNormalDay(weekday))
				{
					return false;
				}
				ESolarSchoolBehaviorType? slotBehaviorType = this.GetSlotBehaviorType(weekday, slot);
				if (slotBehaviorType.GetValueOrDefault() == ESolarSchoolBehaviorType.Fixed)
				{
					return false;
				}
				if (slotBehaviorType.GetValueOrDefault() == ESolarSchoolBehaviorType.Special && !this.CheckDateValid(this.GetCell(weekday, slot), slot))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060380E3 RID: 229603 RVA: 0x00FAB0F4 File Offset: 0x00FA92F4
		public unsafe bool SetSpecialBehavior(int specialBehaviorId, ESolarSchoolTimeSlot slot, int[] weekdays, bool isPreview = false)
		{
			int num;
			if (!this.CanSetSpecialBehavior(specialBehaviorId, slot, weekdays, out num))
			{
				return false;
			}
			foreach (int weekday in weekdays)
			{
				int num2;
				int num3;
				this.TryIndex(weekday, slot, out num2, out num3);
				SolarSchoolSlotCell solarSchoolSlotCell = this.Cells[num2, num3];
				if (solarSchoolSlotCell.FirstWeekday > 0)
				{
					this.RemoveSpecialBehavior(solarSchoolSlotCell.BehaviorId, isPreview);
				}
			}
			foreach (int weekday2 in weekdays)
			{
				int num4;
				int num5;
				this.TryIndex(weekday2, slot, out num4, out num5);
				int replacedLowBehaviorId = (this.GetSlotBehaviorType(weekday2, slot).GetValueOrDefault() == ESolarSchoolBehaviorType.Low) ? this.Cells[num4, num5].BehaviorId : 0;
				this.Cells[num4, num5] = new SolarSchoolSlotCell
				{
					BehaviorId = specialBehaviorId,
					ReplacedLowBehaviorId = replacedLowBehaviorId,
					FirstWeekday = num
				};
			}
			if (!isPreview)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 置入特批";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("specialBehaviorId", specialBehaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("slot", slot);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("firstWeekday", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("weekdays", string.Join<int>(",", weekdays));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			return true;
		}

		// Token: 0x060380E4 RID: 229604 RVA: 0x00FAB288 File Offset: 0x00FA9488
		public unsafe bool RemoveSpecialBehavior(int specialBehaviorId, bool isPreview = false)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			if (SolarSchoolConfig.Instance.GetBehaviorType(activityId, specialBehaviorId).GetValueOrDefault() != ESolarSchoolBehaviorType.Special)
			{
				return false;
			}
			int num = 0;
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					SolarSchoolSlotCell solarSchoolSlotCell = this.Cells[i, j];
					if (solarSchoolSlotCell.BehaviorId == specialBehaviorId)
					{
						if (!this.CheckDateValid(solarSchoolSlotCell, this.SlotByIndex(j)))
						{
							return false;
						}
						this.Cells[i, j] = ((solarSchoolSlotCell.ReplacedLowBehaviorId != 0) ? new SolarSchoolSlotCell
						{
							BehaviorId = solarSchoolSlotCell.ReplacedLowBehaviorId
						} : default(SolarSchoolSlotCell));
						num++;
					}
				}
			}
			if (!isPreview)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 移除特批";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("specialBehaviorId", specialBehaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("clearedCells", num);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return true;
		}

		// Token: 0x060380E5 RID: 229605 RVA: 0x00FAB3B4 File Offset: 0x00FA95B4
		public unsafe void ResetEditable()
		{
			HashSet<int> hashSet = new HashSet<int>();
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					SolarSchoolSlotCell solarSchoolSlotCell = this.Cells[i, j];
					if (solarSchoolSlotCell.BehaviorId != 0 && this.GetSlotBehaviorTypeByIndex(i, j).GetValueOrDefault() == ESolarSchoolBehaviorType.Special && this.CheckDateValid(solarSchoolSlotCell, this.SlotByIndex(j)))
					{
						hashSet.Add(solarSchoolSlotCell.BehaviorId);
					}
				}
			}
			foreach (int specialBehaviorId in hashSet)
			{
				this.RemoveSpecialBehavior(specialBehaviorId, false);
			}
			int num = this.ClearNormalFromNow();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 重置排期";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("clearedSpecials", hashSet.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("clearedNormal", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x060380E6 RID: 229606 RVA: 0x00FAB4E4 File Offset: 0x00FA96E4
		public int ClearNormalFromNow()
		{
			int num = 0;
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					int weekday = i + 1;
					ESolarSchoolTimeSlot slot = this.SlotByIndex(j);
					if (this.GetSlotBehaviorType(weekday, slot).GetValueOrDefault() == ESolarSchoolBehaviorType.Normal && this.IsSlotAtOrAfterNow(weekday, slot))
					{
						this.Cells[i, j] = default(SolarSchoolSlotCell);
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060380E7 RID: 229607 RVA: 0x00FAB550 File Offset: 0x00FA9750
		public bool CanRemoveSlot(int weekday, ESolarSchoolTimeSlot slot)
		{
			ESolarSchoolBehaviorType? slotBehaviorType = this.GetSlotBehaviorType(weekday, slot);
			if (slotBehaviorType != null)
			{
				ESolarSchoolBehaviorType valueOrDefault = slotBehaviorType.GetValueOrDefault();
				if (valueOrDefault == ESolarSchoolBehaviorType.Normal)
				{
					return this.IsSlotAtOrAfterNow(weekday, slot);
				}
				if (valueOrDefault == ESolarSchoolBehaviorType.Special)
				{
					return this.CheckDateValid(this.GetCell(weekday, slot), slot);
				}
			}
			return false;
		}

		// Token: 0x060380E8 RID: 229608 RVA: 0x00FAB59B File Offset: 0x00FA979B
		public bool IsSlotAtOrAfterNow(int weekday, ESolarSchoolTimeSlot slot)
		{
			return SolarSchoolGamePlayModel.Instance.TimeData.IsSlotAtOrAfterNow(weekday, slot);
		}

		// Token: 0x060380E9 RID: 229609 RVA: 0x00FAB5AE File Offset: 0x00FA97AE
		private ESolarSchoolTimeSlot SlotByIndex(int slotIndex)
		{
			if (slotIndex != 0)
			{
				return ESolarSchoolTimeSlot.Dusk;
			}
			return ESolarSchoolTimeSlot.Day;
		}

		// Token: 0x060380EA RID: 229610 RVA: 0x00FAB5B6 File Offset: 0x00FA97B6
		private int IndexBySlot(ESolarSchoolTimeSlot slot)
		{
			return (slot != ESolarSchoolTimeSlot.Day) ? 1 : 0;
		}

		// Token: 0x060380EB RID: 229611 RVA: 0x00FAB5BF File Offset: 0x00FA97BF
		private ESolarSchoolBehaviorType? GetSlotBehaviorTypeByIndex(int weekdayIndex, int slotIndex)
		{
			return this.GetSlotBehaviorType(weekdayIndex + 1, this.SlotByIndex(slotIndex));
		}

		// Token: 0x060380EC RID: 229612 RVA: 0x00FAB5D4 File Offset: 0x00FA97D4
		private int GetMaxFatigue()
		{
			SolarSchoolAttr? attrConfig = SolarSchoolGamePlayModel.Instance.GetAttrConfig(ESolarSchoolSecondAttr.Fatigue);
			if (attrConfig == null)
			{
				return int.MaxValue;
			}
			return attrConfig.GetValueOrDefault().MaxValue;
		}

		// Token: 0x060380ED RID: 229613 RVA: 0x00FAB60C File Offset: 0x00FA980C
		private int GetMinFatigue()
		{
			SolarSchoolAttr? attrConfig = SolarSchoolGamePlayModel.Instance.GetAttrConfig(ESolarSchoolSecondAttr.Fatigue);
			if (attrConfig == null)
			{
				return 0;
			}
			return attrConfig.GetValueOrDefault().MinValue;
		}

		// Token: 0x060380EE RID: 229614 RVA: 0x00FAB640 File Offset: 0x00FA9840
		private int GetSlotFatigueDelta(int weekday, ESolarSchoolTimeSlot slot)
		{
			int scheduledBehaviorId = this.GetScheduledBehaviorId(weekday, slot);
			if (scheduledBehaviorId != 0)
			{
				return SolarSchoolGamePlayModel.Instance.GetBehaviorFatigueDelta(scheduledBehaviorId);
			}
			return 0;
		}

		// Token: 0x060380EF RID: 229615 RVA: 0x00FAB666 File Offset: 0x00FA9866
		private SolarSchoolScheduleBoard CreatePreview()
		{
			SolarSchoolScheduleBoard solarSchoolScheduleBoard = new SolarSchoolScheduleBoard();
			solarSchoolScheduleBoard.CopyFrom(this);
			return solarSchoolScheduleBoard;
		}

		// Token: 0x060380F0 RID: 229616 RVA: 0x00FAB674 File Offset: 0x00FA9874
		private int AccumulateFatigue(out int overflowWeekday, out ESolarSchoolTimeSlot overflowSlot)
		{
			int maxFatigue = this.GetMaxFatigue();
			int minFatigue = this.GetMinFatigue();
			int num = SolarSchoolGamePlayModel.Instance.PlayerData.GetAttr(ESolarSchoolSecondAttr.Fatigue);
			overflowWeekday = 0;
			overflowSlot = ESolarSchoolTimeSlot.None;
			for (int i = 1; i <= 5; i++)
			{
				if (this.IsNormalDay(i))
				{
					for (int j = 0; j < 2; j++)
					{
						ESolarSchoolTimeSlot esolarSchoolTimeSlot = this.SlotByIndex(j);
						if (this.IsSlotAtOrAfterNow(i, esolarSchoolTimeSlot))
						{
							num += this.GetSlotFatigueDelta(i, esolarSchoolTimeSlot);
							if (num > maxFatigue && overflowWeekday == 0)
							{
								overflowWeekday = i;
								overflowSlot = esolarSchoolTimeSlot;
							}
							num = Math.Clamp(num, minFatigue, maxFatigue);
						}
					}
				}
			}
			return num;
		}

		// Token: 0x060380F1 RID: 229617 RVA: 0x00FAB708 File Offset: 0x00FA9908
		public int GetProjectedFatigue()
		{
			int num;
			ESolarSchoolTimeSlot esolarSchoolTimeSlot;
			return this.AccumulateFatigue(out num, out esolarSchoolTimeSlot);
		}

		// Token: 0x060380F2 RID: 229618 RVA: 0x00FAB720 File Offset: 0x00FA9920
		public Dictionary<ESolarSchoolSecondAttr, int> GetProjectedAttrDeltas()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			Dictionary<ESolarSchoolSecondAttr, int> dictionary = new Dictionary<ESolarSchoolSecondAttr, int>();
			for (int i = 1; i <= 5; i++)
			{
				if (this.IsNormalDay(i))
				{
					for (int j = 0; j < 2; j++)
					{
						ESolarSchoolTimeSlot slot = this.SlotByIndex(j);
						if (this.IsSlotAtOrAfterNow(i, slot))
						{
							int scheduledBehaviorId = this.GetScheduledBehaviorId(i, slot);
							if (scheduledBehaviorId != 0)
							{
								SolarSchoolBehavior? currentLevelRow = instance.PlayerData.GetCurrentLevelRow(scheduledBehaviorId);
								if (currentLevelRow != null)
								{
									foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in instance.GetBehaviorSuccessAttrDeltas(currentLevelRow.Value))
									{
										ESolarSchoolSecondAttr item = valueTuple.Item1;
										int item2 = valueTuple.Item2;
										dictionary[item] = dictionary.GetValueOrDefault(item, 0) + item2;
									}
								}
							}
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x060380F3 RID: 229619 RVA: 0x00FAB814 File Offset: 0x00FA9A14
		private bool IsOverflow(out int overflowWeekday, out ESolarSchoolTimeSlot overflowSlot)
		{
			this.AccumulateFatigue(out overflowWeekday, out overflowSlot);
			return overflowWeekday != 0;
		}

		// Token: 0x060380F4 RID: 229620 RVA: 0x00FAB824 File Offset: 0x00FA9A24
		public bool CanPlaceNormal(int behaviorId, int weekday, ESolarSchoolTimeSlot slot)
		{
			SolarSchoolScheduleBoard solarSchoolScheduleBoard = this.CreatePreview();
			int num;
			ESolarSchoolTimeSlot esolarSchoolTimeSlot;
			return !solarSchoolScheduleBoard.SetNormalBehavior(weekday, slot, behaviorId) || !solarSchoolScheduleBoard.IsOverflow(out num, out esolarSchoolTimeSlot);
		}

		// Token: 0x060380F5 RID: 229621 RVA: 0x00FAB854 File Offset: 0x00FA9A54
		public bool CanPlaceSpecial(int behaviorId, ESolarSchoolTimeSlot slot, int[] weekdays)
		{
			if (weekdays == null || weekdays.Length == 0)
			{
				return true;
			}
			SolarSchoolScheduleBoard solarSchoolScheduleBoard = this.CreatePreview();
			int num;
			ESolarSchoolTimeSlot esolarSchoolTimeSlot;
			return !solarSchoolScheduleBoard.SetSpecialBehavior(behaviorId, slot, weekdays, true) || !solarSchoolScheduleBoard.IsOverflow(out num, out esolarSchoolTimeSlot);
		}

		// Token: 0x060380F6 RID: 229622 RVA: 0x00FAB88C File Offset: 0x00FA9A8C
		public unsafe int TrimOverflow()
		{
			int num = 0;
			int limitWeekday;
			ESolarSchoolTimeSlot limitSlot;
			while (this.IsOverflow(out limitWeekday, out limitSlot) && this.TryRemoveLatestCostlySlot(limitWeekday, limitSlot))
			{
				num++;
			}
			if (num > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 疲劳超标，裁剪排期";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("trimmedCount", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("projectedFatigue", this.GetProjectedFatigue());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("maxFatigue", this.GetMaxFatigue());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			return num;
		}

		// Token: 0x060380F7 RID: 229623 RVA: 0x00FAB948 File Offset: 0x00FA9B48
		private bool TryRemoveLatestCostlySlot(int limitWeekday, ESolarSchoolTimeSlot limitSlot)
		{
			for (int i = limitWeekday; i >= 1; i--)
			{
				if (this.IsNormalDay(i))
				{
					int j = (i == limitWeekday) ? this.IndexBySlot(limitSlot) : 1;
					while (j >= 0)
					{
						ESolarSchoolTimeSlot slot = this.SlotByIndex(j);
						if (this.CanRemoveSlot(i, slot) && this.GetSlotFatigueDelta(i, slot) > 0)
						{
							if (this.GetSlotBehaviorType(i, slot).GetValueOrDefault() != ESolarSchoolBehaviorType.Special)
							{
								return this.SetNormalBehavior(i, slot, 0);
							}
							return this.RemoveSpecialBehavior(this.GetScheduledBehaviorId(i, slot), false);
						}
						else
						{
							j--;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0401D8B4 RID: 121012
		private readonly SolarSchoolSlotCell[,] Cells = new SolarSchoolSlotCell[5, 2];

		// Token: 0x0401D8B5 RID: 121013
		private readonly int[] InstanceIds = new int[5];

		// Token: 0x0401D8B6 RID: 121014
		private readonly bool[] SkippedWeekdays = new bool[5];
	}
}
