using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121D RID: 4637
	public sealed class SheriffAnomalyInfo : IMessage<SheriffAnomalyInfo>, IMessage, IEquatable<SheriffAnomalyInfo>, IDeepCloneable<SheriffAnomalyInfo>, IBufferMessage
	{
		// Token: 0x06018C34 RID: 101428 RVA: 0x0039BFB4 File Offset: 0x0039A1B4
		[NullableContext(1)]
		public static SheriffAnomalyInfo Create()
		{
			return new SheriffAnomalyInfo();
		}

		// Token: 0x1700539B RID: 21403
		// (get) Token: 0x06018C35 RID: 101429 RVA: 0x0039BFBB File Offset: 0x0039A1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SheriffAnomalyInfo> Parser
		{
			get
			{
				return SheriffAnomalyInfo._parser;
			}
		}

		// Token: 0x1700539C RID: 21404
		// (get) Token: 0x06018C36 RID: 101430 RVA: 0x0039BFC2 File Offset: 0x0039A1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700539D RID: 21405
		// (get) Token: 0x06018C37 RID: 101431 RVA: 0x0039BFC5 File Offset: 0x0039A1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffAnomalyInfo.Descriptor;
			}
		}

		// Token: 0x06018C38 RID: 101432 RVA: 0x0039BFCC File Offset: 0x0039A1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfo()
		{
		}

		// Token: 0x06018C39 RID: 101433 RVA: 0x0039BFEC File Offset: 0x0039A1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfo(SheriffAnomalyInfo other) : this()
		{
			this.anomalyId_ = other.anomalyId_;
			this.clueIds_ = other.clueIds_.Clone();
			this.progressIds_ = other.progressIds_.Clone();
			this.endingId_ = other.endingId_;
			this.completeTime_ = other.completeTime_;
			this.isActivated_ = other.isActivated_;
			this.isUnlocked_ = other.isUnlocked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C3A RID: 101434 RVA: 0x0039C06E File Offset: 0x0039A26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfo Clone()
		{
			return new SheriffAnomalyInfo(this);
		}

		// Token: 0x1700539E RID: 21406
		// (get) Token: 0x06018C3B RID: 101435 RVA: 0x0039C076 File Offset: 0x0039A276
		// (set) Token: 0x06018C3C RID: 101436 RVA: 0x0039C07E File Offset: 0x0039A27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AnomalyId
		{
			get
			{
				return this.anomalyId_;
			}
			set
			{
				this.anomalyId_ = value;
			}
		}

		// Token: 0x1700539F RID: 21407
		// (get) Token: 0x06018C3D RID: 101437 RVA: 0x0039C087 File Offset: 0x0039A287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ClueIds
		{
			get
			{
				return this.clueIds_;
			}
		}

		// Token: 0x170053A0 RID: 21408
		// (get) Token: 0x06018C3E RID: 101438 RVA: 0x0039C08F File Offset: 0x0039A28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ProgressIds
		{
			get
			{
				return this.progressIds_;
			}
		}

		// Token: 0x170053A1 RID: 21409
		// (get) Token: 0x06018C3F RID: 101439 RVA: 0x0039C097 File Offset: 0x0039A297
		// (set) Token: 0x06018C40 RID: 101440 RVA: 0x0039C09F File Offset: 0x0039A29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndingId
		{
			get
			{
				return this.endingId_;
			}
			set
			{
				this.endingId_ = value;
			}
		}

		// Token: 0x170053A2 RID: 21410
		// (get) Token: 0x06018C41 RID: 101441 RVA: 0x0039C0A8 File Offset: 0x0039A2A8
		// (set) Token: 0x06018C42 RID: 101442 RVA: 0x0039C0B0 File Offset: 0x0039A2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CompleteTime
		{
			get
			{
				return this.completeTime_;
			}
			set
			{
				this.completeTime_ = value;
			}
		}

		// Token: 0x170053A3 RID: 21411
		// (get) Token: 0x06018C43 RID: 101443 RVA: 0x0039C0B9 File Offset: 0x0039A2B9
		// (set) Token: 0x06018C44 RID: 101444 RVA: 0x0039C0C1 File Offset: 0x0039A2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActivated
		{
			get
			{
				return this.isActivated_;
			}
			set
			{
				this.isActivated_ = value;
			}
		}

		// Token: 0x170053A4 RID: 21412
		// (get) Token: 0x06018C45 RID: 101445 RVA: 0x0039C0CA File Offset: 0x0039A2CA
		// (set) Token: 0x06018C46 RID: 101446 RVA: 0x0039C0D2 File Offset: 0x0039A2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlocked
		{
			get
			{
				return this.isUnlocked_;
			}
			set
			{
				this.isUnlocked_ = value;
			}
		}

		// Token: 0x06018C47 RID: 101447 RVA: 0x0039C0DB File Offset: 0x0039A2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffAnomalyInfo);
		}

		// Token: 0x06018C48 RID: 101448 RVA: 0x0039C0EC File Offset: 0x0039A2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffAnomalyInfo other)
		{
			return other != null && (other == this || (this.AnomalyId == other.AnomalyId && this.clueIds_.Equals(other.clueIds_) && this.progressIds_.Equals(other.progressIds_) && this.EndingId == other.EndingId && this.CompleteTime == other.CompleteTime && this.IsActivated == other.IsActivated && this.IsUnlocked == other.IsUnlocked && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C49 RID: 101449 RVA: 0x0039C190 File Offset: 0x0039A390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AnomalyId != 0)
			{
				num ^= this.AnomalyId.GetHashCode();
			}
			num ^= this.clueIds_.GetHashCode();
			num ^= this.progressIds_.GetHashCode();
			if (this.EndingId != 0)
			{
				num ^= this.EndingId.GetHashCode();
			}
			if (this.CompleteTime != 0L)
			{
				num ^= this.CompleteTime.GetHashCode();
			}
			if (this.IsActivated)
			{
				num ^= this.IsActivated.GetHashCode();
			}
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018C4A RID: 101450 RVA: 0x0039C24F File Offset: 0x0039A44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C4B RID: 101451 RVA: 0x0039C25C File Offset: 0x0039A45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C4C RID: 101452 RVA: 0x0039C268 File Offset: 0x0039A468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AnomalyId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AnomalyId);
			}
			this.clueIds_.WriteTo(ref output, SheriffAnomalyInfo._repeated_clueIds_codec);
			this.progressIds_.WriteTo(ref output, SheriffAnomalyInfo._repeated_progressIds_codec);
			if (this.EndingId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EndingId);
			}
			if (this.CompleteTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CompleteTime);
			}
			if (this.IsActivated)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsActivated);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUnlocked);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C4D RID: 101453 RVA: 0x0039C338 File Offset: 0x0039A538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AnomalyId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AnomalyId);
			}
			num += this.clueIds_.CalculateSize(SheriffAnomalyInfo._repeated_clueIds_codec);
			num += this.progressIds_.CalculateSize(SheriffAnomalyInfo._repeated_progressIds_codec);
			if (this.EndingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndingId);
			}
			if (this.CompleteTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CompleteTime);
			}
			if (this.IsActivated)
			{
				num += 2;
			}
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018C4E RID: 101454 RVA: 0x0039C3E4 File Offset: 0x0039A5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffAnomalyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AnomalyId != 0)
			{
				this.AnomalyId = other.AnomalyId;
			}
			this.clueIds_.Add(other.clueIds_);
			this.progressIds_.Add(other.progressIds_);
			if (other.EndingId != 0)
			{
				this.EndingId = other.EndingId;
			}
			if (other.CompleteTime != 0L)
			{
				this.CompleteTime = other.CompleteTime;
			}
			if (other.IsActivated)
			{
				this.IsActivated = other.IsActivated;
			}
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018C4F RID: 101455 RVA: 0x0039C492 File Offset: 0x0039A692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C50 RID: 101456 RVA: 0x0039C49C File Offset: 0x0039A69C
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
				if (num <= 24U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.AnomalyId = input.ReadInt32();
							continue;
						}
						if (num != 16U)
						{
							goto IL_4D;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U)
						{
							goto IL_4D;
						}
						goto IL_82;
					}
					this.clueIds_.AddEntriesFrom(ref input, SheriffAnomalyInfo._repeated_clueIds_codec);
					continue;
				}
				if (num <= 32U)
				{
					if (num == 26U)
					{
						goto IL_82;
					}
					if (num == 32U)
					{
						this.EndingId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.CompleteTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.IsActivated = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.IsUnlocked = input.ReadBool();
						continue;
					}
				}
				IL_4D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_82:
				this.progressIds_.AddEntriesFrom(ref input, SheriffAnomalyInfo._repeated_progressIds_codec);
			}
		}

		// Token: 0x040092ED RID: 37613
		private static readonly MessageParser<SheriffAnomalyInfo> _parser = new MessageParser<SheriffAnomalyInfo>(() => new SheriffAnomalyInfo());

		// Token: 0x040092EE RID: 37614
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092EF RID: 37615
		public const int AnomalyIdFieldNumber = 1;

		// Token: 0x040092F0 RID: 37616
		private int anomalyId_;

		// Token: 0x040092F1 RID: 37617
		public const int ClueIdsFieldNumber = 2;

		// Token: 0x040092F2 RID: 37618
		private static readonly FieldCodec<int> _repeated_clueIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040092F3 RID: 37619
		private readonly RepeatedField<int> clueIds_ = new RepeatedField<int>();

		// Token: 0x040092F4 RID: 37620
		public const int ProgressIdsFieldNumber = 3;

		// Token: 0x040092F5 RID: 37621
		private static readonly FieldCodec<int> _repeated_progressIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040092F6 RID: 37622
		private readonly RepeatedField<int> progressIds_ = new RepeatedField<int>();

		// Token: 0x040092F7 RID: 37623
		public const int EndingIdFieldNumber = 4;

		// Token: 0x040092F8 RID: 37624
		private int endingId_;

		// Token: 0x040092F9 RID: 37625
		public const int CompleteTimeFieldNumber = 5;

		// Token: 0x040092FA RID: 37626
		private long completeTime_;

		// Token: 0x040092FB RID: 37627
		public const int IsActivatedFieldNumber = 6;

		// Token: 0x040092FC RID: 37628
		private bool isActivated_;

		// Token: 0x040092FD RID: 37629
		public const int IsUnlockedFieldNumber = 7;

		// Token: 0x040092FE RID: 37630
		private bool isUnlocked_;
	}
}
