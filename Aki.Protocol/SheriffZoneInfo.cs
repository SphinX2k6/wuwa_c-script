using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001221 RID: 4641
	public sealed class SheriffZoneInfo : IMessage<SheriffZoneInfo>, IMessage, IEquatable<SheriffZoneInfo>, IDeepCloneable<SheriffZoneInfo>, IBufferMessage
	{
		// Token: 0x06018C8E RID: 101518 RVA: 0x0039CCDD File Offset: 0x0039AEDD
		[NullableContext(1)]
		public static SheriffZoneInfo Create()
		{
			return new SheriffZoneInfo();
		}

		// Token: 0x170053B1 RID: 21425
		// (get) Token: 0x06018C8F RID: 101519 RVA: 0x0039CCE4 File Offset: 0x0039AEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SheriffZoneInfo> Parser
		{
			get
			{
				return SheriffZoneInfo._parser;
			}
		}

		// Token: 0x170053B2 RID: 21426
		// (get) Token: 0x06018C90 RID: 101520 RVA: 0x0039CCEB File Offset: 0x0039AEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053B3 RID: 21427
		// (get) Token: 0x06018C91 RID: 101521 RVA: 0x0039CCEE File Offset: 0x0039AEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffZoneInfo.Descriptor;
			}
		}

		// Token: 0x06018C92 RID: 101522 RVA: 0x0039CCF5 File Offset: 0x0039AEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfo()
		{
		}

		// Token: 0x06018C93 RID: 101523 RVA: 0x0039CD14 File Offset: 0x0039AF14
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

		// Token: 0x06018C94 RID: 101524 RVA: 0x0039CD72 File Offset: 0x0039AF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfo Clone()
		{
			return new SheriffZoneInfo(this);
		}

		// Token: 0x170053B4 RID: 21428
		// (get) Token: 0x06018C95 RID: 101525 RVA: 0x0039CD7A File Offset: 0x0039AF7A
		// (set) Token: 0x06018C96 RID: 101526 RVA: 0x0039CD82 File Offset: 0x0039AF82
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

		// Token: 0x170053B5 RID: 21429
		// (get) Token: 0x06018C97 RID: 101527 RVA: 0x0039CD8B File Offset: 0x0039AF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffAnomalyInfo> AnomalyInfos
		{
			get
			{
				return this.anomalyInfos_;
			}
		}

		// Token: 0x170053B6 RID: 21430
		// (get) Token: 0x06018C98 RID: 101528 RVA: 0x0039CD93 File Offset: 0x0039AF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffCriminalInfo> CriminalInfos
		{
			get
			{
				return this.criminalInfos_;
			}
		}

		// Token: 0x170053B7 RID: 21431
		// (get) Token: 0x06018C99 RID: 101529 RVA: 0x0039CD9B File Offset: 0x0039AF9B
		// (set) Token: 0x06018C9A RID: 101530 RVA: 0x0039CDA3 File Offset: 0x0039AFA3
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

		// Token: 0x06018C9B RID: 101531 RVA: 0x0039CDAC File Offset: 0x0039AFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffZoneInfo);
		}

		// Token: 0x06018C9C RID: 101532 RVA: 0x0039CDBC File Offset: 0x0039AFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffZoneInfo other)
		{
			return other != null && (other == this || (this.ZoneId == other.ZoneId && this.anomalyInfos_.Equals(other.anomalyInfos_) && this.criminalInfos_.Equals(other.criminalInfos_) && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C9D RID: 101533 RVA: 0x0039CE30 File Offset: 0x0039B030
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

		// Token: 0x06018C9E RID: 101534 RVA: 0x0039CEA4 File Offset: 0x0039B0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C9F RID: 101535 RVA: 0x0039CEB1 File Offset: 0x0039B0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CA0 RID: 101536 RVA: 0x0039CEBC File Offset: 0x0039B0BC
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

		// Token: 0x06018CA1 RID: 101537 RVA: 0x0039CF38 File Offset: 0x0039B138
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

		// Token: 0x06018CA2 RID: 101538 RVA: 0x0039CFB4 File Offset: 0x0039B1B4
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

		// Token: 0x06018CA3 RID: 101539 RVA: 0x0039D026 File Offset: 0x0039B226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CA4 RID: 101540 RVA: 0x0039D030 File Offset: 0x0039B230
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

		// Token: 0x0400930F RID: 37647
		private static readonly MessageParser<SheriffZoneInfo> _parser = new MessageParser<SheriffZoneInfo>(() => new SheriffZoneInfo());

		// Token: 0x04009310 RID: 37648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009311 RID: 37649
		public const int ZoneIdFieldNumber = 1;

		// Token: 0x04009312 RID: 37650
		private int zoneId_;

		// Token: 0x04009313 RID: 37651
		public const int AnomalyInfosFieldNumber = 2;

		// Token: 0x04009314 RID: 37652
		private static readonly FieldCodec<SheriffAnomalyInfo> _repeated_anomalyInfos_codec = FieldCodec.ForMessage<SheriffAnomalyInfo>(18U, SheriffAnomalyInfo.Parser);

		// Token: 0x04009315 RID: 37653
		private readonly RepeatedField<SheriffAnomalyInfo> anomalyInfos_ = new RepeatedField<SheriffAnomalyInfo>();

		// Token: 0x04009316 RID: 37654
		public const int CriminalInfosFieldNumber = 3;

		// Token: 0x04009317 RID: 37655
		private static readonly FieldCodec<SheriffCriminalInfo> _repeated_criminalInfos_codec = FieldCodec.ForMessage<SheriffCriminalInfo>(26U, SheriffCriminalInfo.Parser);

		// Token: 0x04009318 RID: 37656
		private readonly RepeatedField<SheriffCriminalInfo> criminalInfos_ = new RepeatedField<SheriffCriminalInfo>();

		// Token: 0x04009319 RID: 37657
		public const int ItemCountFieldNumber = 4;

		// Token: 0x0400931A RID: 37658
		private long itemCount_;
	}
}
