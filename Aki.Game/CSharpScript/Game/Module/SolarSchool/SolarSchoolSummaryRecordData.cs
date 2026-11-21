using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E5 RID: 22757
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolSummaryRecordData : SolarSchoolRecordBase
	{
		// Token: 0x17006B9F RID: 27551
		// (get) Token: 0x0603818D RID: 229773 RVA: 0x00FAE0E8 File Offset: 0x00FAC2E8
		public SolarSchoolSummaryData MonthSummaryData { get; } = new SolarSchoolSummaryData();

		// Token: 0x17006BA0 RID: 27552
		// (get) Token: 0x0603818E RID: 229774 RVA: 0x00FAE0F0 File Offset: 0x00FAC2F0
		public SolarSchoolSummaryData TotalSummaryData { get; } = new SolarSchoolSummaryData();

		// Token: 0x0603818F RID: 229775 RVA: 0x00FAE0F8 File Offset: 0x00FAC2F8
		public bool HasMonthSummary()
		{
			return this.MonthSettled;
		}

		// Token: 0x06038190 RID: 229776 RVA: 0x00FAE100 File Offset: 0x00FAC300
		protected override void OnInit(int activityId)
		{
			this.ActivityId = activityId;
			this.SpanId = 0;
			this.MonthSettled = false;
			this.CurrentSpan = null;
			this.MonthSummaryData.Clear();
			this.TotalSummaryData.Clear();
		}

		// Token: 0x06038191 RID: 229777 RVA: 0x00FAE13C File Offset: 0x00FAC33C
		public unsafe void EnsureCurrentMonthStarted(int dayIndex)
		{
			if (this.CurrentSpan == null && this.SpanId != 0)
			{
				this.CurrentSpan = SolarSchoolConfig.Instance.GetSpan(this.SpanId);
			}
			if (this.CurrentSpan != null)
			{
				if (dayIndex <= this.CurrentSpan.Value.EndDayIndex)
				{
					return;
				}
				if (!this.MonthSettled)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 月度区间过了月末仍未结算，直接切到下个月";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("spanId", this.SpanId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("endDayIndex", this.CurrentSpan.Value.EndDayIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("dayIndex", dayIndex);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				this.SpanId = 0;
				this.MonthSettled = false;
				this.CurrentSpan = null;
				this.MonthSummaryData.Clear();
			}
			SolarSchoolSpan? currentSpan = this.FindMonthSpan(dayIndex);
			if (currentSpan == null)
			{
				return;
			}
			this.SpanId = currentSpan.Value.Id;
			this.MonthSettled = false;
			this.CurrentSpan = currentSpan;
			this.MonthSummaryData.Clear();
		}

		// Token: 0x06038192 RID: 229778 RVA: 0x00FAE29F File Offset: 0x00FAC49F
		public void RecordAttrChange(ESolarSchoolSecondAttr attr, int value)
		{
			if (!SolarSchoolSummaryRecordData.IsSummaryAttr(attr) || value == 0)
			{
				return;
			}
			this.TotalSummaryData.AddAttrChange(attr, value);
			if (this.IsMonthRecording())
			{
				this.MonthSummaryData.AddAttrChange(attr, value);
			}
			if (attr == ESolarSchoolSecondAttr.Money && value > 0)
			{
				this.RecordGainedMoney(value);
			}
		}

		// Token: 0x06038193 RID: 229779 RVA: 0x00FAE2DE File Offset: 0x00FAC4DE
		private void RecordGainedMoney(int value)
		{
			this.TotalSummaryData.AddGainedMoney(value);
			if (this.IsMonthRecording())
			{
				this.MonthSummaryData.AddGainedMoney(value);
			}
		}

		// Token: 0x06038194 RID: 229780 RVA: 0x00FAE300 File Offset: 0x00FAC500
		public void RecordCompletedNotice()
		{
			this.TotalSummaryData.AddCompletedNoticeCount(1);
			if (this.IsMonthRecording())
			{
				this.MonthSummaryData.AddCompletedNoticeCount(1);
			}
		}

		// Token: 0x06038195 RID: 229781 RVA: 0x00FAE322 File Offset: 0x00FAC522
		public void RecordManualPurchase()
		{
			this.TotalSummaryData.AddManualPurchaseCount(1);
			if (this.IsMonthRecording())
			{
				this.MonthSummaryData.AddManualPurchaseCount(1);
			}
		}

		// Token: 0x06038196 RID: 229782 RVA: 0x00FAE344 File Offset: 0x00FAC544
		private bool IsMonthRecording()
		{
			return this.CurrentSpan != null && !this.MonthSettled;
		}

		// Token: 0x06038197 RID: 229783 RVA: 0x00FAE360 File Offset: 0x00FAC560
		public bool TrySettleMonth(int dayIndex)
		{
			if (this.CurrentSpan == null || this.MonthSettled)
			{
				return false;
			}
			SolarSchoolSpan value = this.CurrentSpan.Value;
			if (value.ModifierType != "MoonSummary" || value.EndDayIndex != dayIndex)
			{
				return false;
			}
			this.MonthSettled = true;
			SolarSchoolGamePlayModel.Instance.LogReporter.ReportStageSettle(ESolarSchoolStageSettleType.MonthSummary);
			return true;
		}

		// Token: 0x06038198 RID: 229784 RVA: 0x00FAE3C8 File Offset: 0x00FAC5C8
		private SolarSchoolSpan? FindMonthSpan(int dayIndex)
		{
			IReadOnlyList<SolarSchoolSpan> spanList = SolarSchoolConfig.Instance.GetSpanList(this.ActivityId);
			if (spanList == null)
			{
				return null;
			}
			SolarSchoolSpan? result = null;
			foreach (SolarSchoolSpan value in spanList)
			{
				if (!(value.ModifierType != "MoonSummary") && dayIndex >= value.StartDayIndex && dayIndex <= value.EndDayIndex && (result == null || value.Priority > result.Value.Priority))
				{
					result = new SolarSchoolSpan?(value);
				}
			}
			return result;
		}

		// Token: 0x06038199 RID: 229785 RVA: 0x00FAE484 File Offset: 0x00FAC684
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			gameData.Summary = new SolarSchoolSummaryRecordDataPb
			{
				SpanId = this.SpanId,
				MonthSummary = this.SerializeSummary(this.MonthSummaryData),
				TotalSummary = this.SerializeSummary(this.TotalSummaryData),
				MonthSettled = this.MonthSettled
			};
		}

		// Token: 0x0603819A RID: 229786 RVA: 0x00FAE4D8 File Offset: 0x00FAC6D8
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.SpanId = 0;
			this.MonthSettled = false;
			this.CurrentSpan = null;
			this.MonthSummaryData.Clear();
			this.TotalSummaryData.Clear();
			SolarSchoolSummaryRecordDataPb summary = gameData.Summary;
			if (summary == null)
			{
				return;
			}
			this.SpanId = summary.SpanId;
			this.MonthSettled = summary.MonthSettled;
			this.DeserializeSummary(summary.MonthSummary, this.MonthSummaryData);
			this.DeserializeSummary(summary.TotalSummary, this.TotalSummaryData);
		}

		// Token: 0x0603819B RID: 229787 RVA: 0x00FAE55C File Offset: 0x00FAC75C
		private SolarSchoolSummaryDataPb SerializeSummary(SolarSchoolSummaryData data)
		{
			SolarSchoolSummaryDataPb solarSchoolSummaryDataPb = new SolarSchoolSummaryDataPb
			{
				CompletedNoticeCount = data.CompletedNoticeCount,
				ManualPurchaseCount = data.ManualPurchaseCount,
				GainedMoney = data.GainedMoney
			};
			foreach (ESolarSchoolSecondAttr attr in SolarSchoolDefine.SummaryAttrs)
			{
				int attrChange = data.GetAttrChange(attr);
				if (attrChange != 0)
				{
					solarSchoolSummaryDataPb.Attr.Add(SolarSchoolSummaryRecordData.CreateAttrPb(attr, attrChange));
				}
			}
			return solarSchoolSummaryDataPb;
		}

		// Token: 0x0603819C RID: 229788 RVA: 0x00FAE5CC File Offset: 0x00FAC7CC
		private void DeserializeSummary([Nullable(2)] SolarSchoolSummaryDataPb pb, SolarSchoolSummaryData data)
		{
			data.Clear();
			if (pb == null)
			{
				return;
			}
			foreach (SolarSchoolAttrPb solarSchoolAttrPb in pb.Attr)
			{
				ESolarSchoolSecondAttr attrType = (ESolarSchoolSecondAttr)solarSchoolAttrPb.AttrType;
				if (SolarSchoolSummaryRecordData.IsSummaryAttr(attrType))
				{
					data.AddAttrChange(attrType, solarSchoolAttrPb.Value);
				}
			}
			data.AddCompletedNoticeCount(pb.CompletedNoticeCount);
			data.AddManualPurchaseCount(pb.ManualPurchaseCount);
			data.AddGainedMoney(pb.GainedMoney);
		}

		// Token: 0x0603819D RID: 229789 RVA: 0x00FAE65C File Offset: 0x00FAC85C
		private static SolarSchoolAttrPb CreateAttrPb(ESolarSchoolSecondAttr attr, int value)
		{
			return new SolarSchoolAttrPb
			{
				AttrType = (SolarSchoolAttrType)attr,
				Value = value
			};
		}

		// Token: 0x0603819E RID: 229790 RVA: 0x00FAE674 File Offset: 0x00FAC874
		private static bool IsSummaryAttr(ESolarSchoolSecondAttr attr)
		{
			ESolarSchoolSecondAttr[] summaryAttrs = SolarSchoolDefine.SummaryAttrs;
			for (int i = 0; i < summaryAttrs.Length; i++)
			{
				if (summaryAttrs[i] == attr)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0401D8D9 RID: 121049
		private int ActivityId;

		// Token: 0x0401D8DA RID: 121050
		private int SpanId;

		// Token: 0x0401D8DB RID: 121051
		private bool MonthSettled;

		// Token: 0x0401D8DC RID: 121052
		private SolarSchoolSpan? CurrentSpan;
	}
}
