using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CB RID: 4811
	public sealed class SolarSchoolSummaryRecordDataPb : IMessage<SolarSchoolSummaryRecordDataPb>, IMessage, IEquatable<SolarSchoolSummaryRecordDataPb>, IDeepCloneable<SolarSchoolSummaryRecordDataPb>, IBufferMessage
	{
		// Token: 0x06019AE8 RID: 105192 RVA: 0x003BF4E9 File Offset: 0x003BD6E9
		[NullableContext(1)]
		public static SolarSchoolSummaryRecordDataPb Create()
		{
			return new SolarSchoolSummaryRecordDataPb();
		}

		// Token: 0x170056F9 RID: 22265
		// (get) Token: 0x06019AE9 RID: 105193 RVA: 0x003BF4F0 File Offset: 0x003BD6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056FA RID: 22266
		// (get) Token: 0x06019AEA RID: 105194 RVA: 0x003BF4F3 File Offset: 0x003BD6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSummaryRecordDataPb.Descriptor;
			}
		}

		// Token: 0x06019AEB RID: 105195 RVA: 0x003BF4FA File Offset: 0x003BD6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryRecordDataPb()
		{
		}

		// Token: 0x06019AEC RID: 105196 RVA: 0x003BF504 File Offset: 0x003BD704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryRecordDataPb(SolarSchoolSummaryRecordDataPb other) : this()
		{
			this.spanId_ = other.spanId_;
			this.monthSummary_ = ((other.monthSummary_ != null) ? other.monthSummary_.Clone() : null);
			this.totalSummary_ = ((other.totalSummary_ != null) ? other.totalSummary_.Clone() : null);
			this.monthSettled_ = other.monthSettled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019AED RID: 105197 RVA: 0x003BF578 File Offset: 0x003BD778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryRecordDataPb Clone()
		{
			return new SolarSchoolSummaryRecordDataPb(this);
		}

		// Token: 0x170056FB RID: 22267
		// (get) Token: 0x06019AEE RID: 105198 RVA: 0x003BF580 File Offset: 0x003BD780
		// (set) Token: 0x06019AEF RID: 105199 RVA: 0x003BF588 File Offset: 0x003BD788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpanId
		{
			get
			{
				return this.spanId_;
			}
			set
			{
				this.spanId_ = value;
			}
		}

		// Token: 0x170056FC RID: 22268
		// (get) Token: 0x06019AF0 RID: 105200 RVA: 0x003BF591 File Offset: 0x003BD791
		// (set) Token: 0x06019AF1 RID: 105201 RVA: 0x003BF599 File Offset: 0x003BD799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryDataPb MonthSummary
		{
			get
			{
				return this.monthSummary_;
			}
			set
			{
				this.monthSummary_ = value;
			}
		}

		// Token: 0x170056FD RID: 22269
		// (get) Token: 0x06019AF2 RID: 105202 RVA: 0x003BF5A2 File Offset: 0x003BD7A2
		// (set) Token: 0x06019AF3 RID: 105203 RVA: 0x003BF5AA File Offset: 0x003BD7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryDataPb TotalSummary
		{
			get
			{
				return this.totalSummary_;
			}
			set
			{
				this.totalSummary_ = value;
			}
		}

		// Token: 0x170056FE RID: 22270
		// (get) Token: 0x06019AF4 RID: 105204 RVA: 0x003BF5B3 File Offset: 0x003BD7B3
		// (set) Token: 0x06019AF5 RID: 105205 RVA: 0x003BF5BB File Offset: 0x003BD7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MonthSettled
		{
			get
			{
				return this.monthSettled_;
			}
			set
			{
				this.monthSettled_ = value;
			}
		}

		// Token: 0x06019AF6 RID: 105206 RVA: 0x003BF5C4 File Offset: 0x003BD7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSummaryRecordDataPb);
		}

		// Token: 0x06019AF7 RID: 105207 RVA: 0x003BF5D4 File Offset: 0x003BD7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSummaryRecordDataPb other)
		{
			return other != null && (other == this || (this.SpanId == other.SpanId && object.Equals(this.MonthSummary, other.MonthSummary) && object.Equals(this.TotalSummary, other.TotalSummary) && this.MonthSettled == other.MonthSettled && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019AF8 RID: 105208 RVA: 0x003BF648 File Offset: 0x003BD848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SpanId != 0)
			{
				num ^= this.SpanId.GetHashCode();
			}
			if (this.monthSummary_ != null)
			{
				num ^= this.MonthSummary.GetHashCode();
			}
			if (this.totalSummary_ != null)
			{
				num ^= this.TotalSummary.GetHashCode();
			}
			if (this.MonthSettled)
			{
				num ^= this.MonthSettled.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019AF9 RID: 105209 RVA: 0x003BF6CC File Offset: 0x003BD8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019AFA RID: 105210 RVA: 0x003BF6D9 File Offset: 0x003BD8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019AFB RID: 105211 RVA: 0x003BF6E4 File Offset: 0x003BD8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpanId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SpanId);
			}
			if (this.monthSummary_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MonthSummary);
			}
			if (this.totalSummary_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TotalSummary);
			}
			if (this.MonthSettled)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.MonthSettled);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019AFC RID: 105212 RVA: 0x003BF774 File Offset: 0x003BD974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SpanId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpanId);
			}
			if (this.monthSummary_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MonthSummary);
			}
			if (this.totalSummary_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TotalSummary);
			}
			if (this.MonthSettled)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019AFD RID: 105213 RVA: 0x003BF7F0 File Offset: 0x003BD9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSummaryRecordDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SpanId != 0)
			{
				this.SpanId = other.SpanId;
			}
			if (other.monthSummary_ != null)
			{
				if (this.monthSummary_ == null)
				{
					this.MonthSummary = new SolarSchoolSummaryDataPb();
				}
				this.MonthSummary.MergeFrom(other.MonthSummary);
			}
			if (other.totalSummary_ != null)
			{
				if (this.totalSummary_ == null)
				{
					this.TotalSummary = new SolarSchoolSummaryDataPb();
				}
				this.TotalSummary.MergeFrom(other.TotalSummary);
			}
			if (other.MonthSettled)
			{
				this.MonthSettled = other.MonthSettled;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019AFE RID: 105214 RVA: 0x003BF898 File Offset: 0x003BDA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019AFF RID: 105215 RVA: 0x003BF8A4 File Offset: 0x003BDAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.SpanId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.monthSummary_ == null)
						{
							this.MonthSummary = new SolarSchoolSummaryDataPb();
						}
						input.ReadMessage(this.MonthSummary);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.totalSummary_ == null)
						{
							this.TotalSummary = new SolarSchoolSummaryDataPb();
						}
						input.ReadMessage(this.TotalSummary);
						continue;
					}
					if (num == 32U)
					{
						this.MonthSettled = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040097B8 RID: 38840
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097B9 RID: 38841
		public const int SpanIdFieldNumber = 1;

		// Token: 0x040097BA RID: 38842
		private int spanId_;

		// Token: 0x040097BB RID: 38843
		public const int MonthSummaryFieldNumber = 2;

		// Token: 0x040097BC RID: 38844
		private SolarSchoolSummaryDataPb monthSummary_;

		// Token: 0x040097BD RID: 38845
		public const int TotalSummaryFieldNumber = 3;

		// Token: 0x040097BE RID: 38846
		private SolarSchoolSummaryDataPb totalSummary_;

		// Token: 0x040097BF RID: 38847
		public const int MonthSettledFieldNumber = 4;

		// Token: 0x040097C0 RID: 38848
		private bool monthSettled_;
	}
}
