using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E6 RID: 4582
	public sealed class SheriffZoneInfo : IMessage<SheriffZoneInfo>, IMessage, IEquatable<SheriffZoneInfo>, IDeepCloneable<SheriffZoneInfo>, IBufferMessage
	{
		// Token: 0x060186CA RID: 100042 RVA: 0x0038D171 File Offset: 0x0038B371
		[NullableContext(1)]
		public static SheriffZoneInfo Create()
		{
			return new SheriffZoneInfo();
		}

		// Token: 0x17005239 RID: 21049
		// (get) Token: 0x060186CB RID: 100043 RVA: 0x0038D178 File Offset: 0x0038B378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SheriffZoneInfo> Parser
		{
			get
			{
				return SheriffZoneInfo._parser;
			}
		}

		// Token: 0x1700523A RID: 21050
		// (get) Token: 0x060186CC RID: 100044 RVA: 0x0038D17F File Offset: 0x0038B37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700523B RID: 21051
		// (get) Token: 0x060186CD RID: 100045 RVA: 0x0038D182 File Offset: 0x0038B382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffZoneInfo.Descriptor;
			}
		}

		// Token: 0x060186CE RID: 100046 RVA: 0x0038D189 File Offset: 0x0038B389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfo()
		{
		}

		// Token: 0x060186CF RID: 100047 RVA: 0x0038D1A8 File Offset: 0x0038B3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfo(SheriffZoneInfo other) : this()
		{
			this.zoneId_ = other.zoneId_;
			this.anomalyInfos_ = other.anomalyInfos_.Clone();
			this.criminalInfos_ = other.criminalInfos_.Clone();
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060186D0 RID: 100048 RVA: 0x0038D206 File Offset: 0x0038B406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfo Clone()
		{
			return new SheriffZoneInfo(this);
		}

		// Token: 0x1700523C RID: 21052
		// (get) Token: 0x060186D1 RID: 100049 RVA: 0x0038D20E File Offset: 0x0038B40E
		// (set) Token: 0x060186D2 RID: 100050 RVA: 0x0038D216 File Offset: 0x0038B416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ZoneId
		{
			get
			{
				return this.zoneId_;
			}
			set
			{
				this.zoneId_ = value;
			}
		}

		// Token: 0x1700523D RID: 21053
		// (get) Token: 0x060186D3 RID: 100051 RVA: 0x0038D21F File Offset: 0x0038B41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffAnomalyInfo> AnomalyInfos
		{
			get
			{
				return this.anomalyInfos_;
			}
		}

		// Token: 0x1700523E RID: 21054
		// (get) Token: 0x060186D4 RID: 100052 RVA: 0x0038D227 File Offset: 0x0038B427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffCriminalInfo> CriminalInfos
		{
			get
			{
				return this.criminalInfos_;
			}
		}

		// Token: 0x1700523F RID: 21055
		// (get) Token: 0x060186D5 RID: 100053 RVA: 0x0038D22F File Offset: 0x0038B42F
		// (set) Token: 0x060186D6 RID: 100054 RVA: 0x0038D237 File Offset: 0x0038B437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x060186D7 RID: 100055 RVA: 0x0038D240 File Offset: 0x0038B440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffZoneInfo);
		}

		// Token: 0x060186D8 RID: 100056 RVA: 0x0038D250 File Offset: 0x0038B450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffZoneInfo other)
		{
			return other != null && (other == this || (this.ZoneId == other.ZoneId && this.anomalyInfos_.Equals(other.anomalyInfos_) && this.criminalInfos_.Equals(other.criminalInfos_) && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186D9 RID: 100057 RVA: 0x0038D2C4 File Offset: 0x0038B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ZoneId != 0)
			{
				num ^= this.ZoneId.GetHashCode();
			}
			num ^= this.anomalyInfos_.GetHashCode();
			num ^= this.criminalInfos_.GetHashCode();
			if (this.ItemCount != 0L)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060186DA RID: 100058 RVA: 0x0038D338 File Offset: 0x0038B538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060186DB RID: 100059 RVA: 0x0038D345 File Offset: 0x0038B545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060186DC RID: 100060 RVA: 0x0038D350 File Offset: 0x0038B550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ZoneId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ZoneId);
			}
			this.anomalyInfos_.WriteTo(ref output, SheriffZoneInfo._repeated_anomalyInfos_codec);
			this.criminalInfos_.WriteTo(ref output, SheriffZoneInfo._repeated_criminalInfos_codec);
			if (this.ItemCount != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060186DD RID: 100061 RVA: 0x0038D3CC File Offset: 0x0038B5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ZoneId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ZoneId);
			}
			num += this.anomalyInfos_.CalculateSize(SheriffZoneInfo._repeated_anomalyInfos_codec);
			num += this.criminalInfos_.CalculateSize(SheriffZoneInfo._repeated_criminalInfos_codec);
			if (this.ItemCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060186DE RID: 100062 RVA: 0x0038D448 File Offset: 0x0038B648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffZoneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ZoneId != 0)
			{
				this.ZoneId = other.ZoneId;
			}
			this.anomalyInfos_.Add(other.anomalyInfos_);
			this.criminalInfos_.Add(other.criminalInfos_);
			if (other.ItemCount != 0L)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060186DF RID: 100063 RVA: 0x0038D4BA File Offset: 0x0038B6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186E0 RID: 100064 RVA: 0x0038D4C4 File Offset: 0x0038B6C4
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
						this.ZoneId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.anomalyInfos_.AddEntriesFrom(ref input, SheriffZoneInfo._repeated_anomalyInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.criminalInfos_.AddEntriesFrom(ref input, SheriffZoneInfo._repeated_criminalInfos_codec);
						continue;
					}
					if (num == 32U)
					{
						this.ItemCount = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009065 RID: 36965
		private static readonly MessageParser<SheriffZoneInfo> _parser = new MessageParser<SheriffZoneInfo>(() => new SheriffZoneInfo());

		// Token: 0x04009066 RID: 36966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009067 RID: 36967
		public const int ZoneIdFieldNumber = 1;

		// Token: 0x04009068 RID: 36968
		private int zoneId_;

		// Token: 0x04009069 RID: 36969
		public const int AnomalyInfosFieldNumber = 2;

		// Token: 0x0400906A RID: 36970
		private static readonly FieldCodec<SheriffAnomalyInfo> _repeated_anomalyInfos_codec = FieldCodec.ForMessage<SheriffAnomalyInfo>(18U, SheriffAnomalyInfo.Parser);

		// Token: 0x0400906B RID: 36971
		private readonly RepeatedField<SheriffAnomalyInfo> anomalyInfos_ = new RepeatedField<SheriffAnomalyInfo>();

		// Token: 0x0400906C RID: 36972
		public const int CriminalInfosFieldNumber = 3;

		// Token: 0x0400906D RID: 36973
		private static readonly FieldCodec<SheriffCriminalInfo> _repeated_criminalInfos_codec = FieldCodec.ForMessage<SheriffCriminalInfo>(26U, SheriffCriminalInfo.Parser);

		// Token: 0x0400906E RID: 36974
		private readonly RepeatedField<SheriffCriminalInfo> criminalInfos_ = new RepeatedField<SheriffCriminalInfo>();

		// Token: 0x0400906F RID: 36975
		public const int ItemCountFieldNumber = 4;

		// Token: 0x04009070 RID: 36976
		private long itemCount_;
	}
}
