using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001326 RID: 4902
	[NetMessage(EMessageId.SunSpiritActionOperationNotify)]
	public sealed class SunSpiritActionOperationNotify : IMessage<SunSpiritActionOperationNotify>, IMessage, IEquatable<SunSpiritActionOperationNotify>, IDeepCloneable<SunSpiritActionOperationNotify>, IBufferMessage
	{
		// Token: 0x0601A21C RID: 107036 RVA: 0x003CEF2F File Offset: 0x003CD12F
		[NullableContext(1)]
		public static SunSpiritActionOperationNotify Create()
		{
			return new SunSpiritActionOperationNotify();
		}

		// Token: 0x17005879 RID: 22649
		// (get) Token: 0x0601A21D RID: 107037 RVA: 0x003CEF36 File Offset: 0x003CD136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700587A RID: 22650
		// (get) Token: 0x0601A21E RID: 107038 RVA: 0x003CEF39 File Offset: 0x003CD139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritActionOperationNotify.Descriptor;
			}
		}

		// Token: 0x0601A21F RID: 107039 RVA: 0x003CEF40 File Offset: 0x003CD140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationNotify()
		{
		}

		// Token: 0x0601A220 RID: 107040 RVA: 0x003CEF54 File Offset: 0x003CD154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationNotify(SunSpiritActionOperationNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.index_ = other.index_;
			this.operationType_ = other.operationType_;
			this.entityId_ = other.entityId_;
			this.takeUpInfo_ = other.takeUpInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A221 RID: 107041 RVA: 0x003CEFC5 File Offset: 0x003CD1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationNotify Clone()
		{
			return new SunSpiritActionOperationNotify(this);
		}

		// Token: 0x1700587B RID: 22651
		// (get) Token: 0x0601A222 RID: 107042 RVA: 0x003CEFCD File Offset: 0x003CD1CD
		// (set) Token: 0x0601A223 RID: 107043 RVA: 0x003CEFD5 File Offset: 0x003CD1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700587C RID: 22652
		// (get) Token: 0x0601A224 RID: 107044 RVA: 0x003CEFDE File Offset: 0x003CD1DE
		// (set) Token: 0x0601A225 RID: 107045 RVA: 0x003CEFE6 File Offset: 0x003CD1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700587D RID: 22653
		// (get) Token: 0x0601A226 RID: 107046 RVA: 0x003CEFEF File Offset: 0x003CD1EF
		// (set) Token: 0x0601A227 RID: 107047 RVA: 0x003CEFF7 File Offset: 0x003CD1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700587E RID: 22654
		// (get) Token: 0x0601A228 RID: 107048 RVA: 0x003CF000 File Offset: 0x003CD200
		// (set) Token: 0x0601A229 RID: 107049 RVA: 0x003CF008 File Offset: 0x003CD208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritOperationType OperationType
		{
			get
			{
				return this.operationType_;
			}
			set
			{
				this.operationType_ = value;
			}
		}

		// Token: 0x1700587F RID: 22655
		// (get) Token: 0x0601A22A RID: 107050 RVA: 0x003CF011 File Offset: 0x003CD211
		// (set) Token: 0x0601A22B RID: 107051 RVA: 0x003CF019 File Offset: 0x003CD219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005880 RID: 22656
		// (get) Token: 0x0601A22C RID: 107052 RVA: 0x003CF022 File Offset: 0x003CD222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SunSpiritPb> TakeUpInfo
		{
			get
			{
				return this.takeUpInfo_;
			}
		}

		// Token: 0x0601A22D RID: 107053 RVA: 0x003CF02A File Offset: 0x003CD22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritActionOperationNotify);
		}

		// Token: 0x0601A22E RID: 107054 RVA: 0x003CF038 File Offset: 0x003CD238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritActionOperationNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Index == other.Index && this.OperationType == other.OperationType && this.EntityId == other.EntityId && this.takeUpInfo_.Equals(other.takeUpInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A22F RID: 107055 RVA: 0x003CF0C8 File Offset: 0x003CD2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.OperationType != SunSpiritOperationType.Fly)
			{
				num ^= this.OperationType.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.takeUpInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A230 RID: 107056 RVA: 0x003CF17F File Offset: 0x003CD37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A231 RID: 107057 RVA: 0x003CF18C File Offset: 0x003CD38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A232 RID: 107058 RVA: 0x003CF198 File Offset: 0x003CD398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			this.takeUpInfo_.WriteTo(ref output, SunSpiritActionOperationNotify._repeated_takeUpInfo_codec);
			if (this.OperationType != SunSpiritOperationType.Fly)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.OperationType);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Index);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A233 RID: 107059 RVA: 0x003CF258 File Offset: 0x003CD458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.OperationType != SunSpiritOperationType.Fly)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OperationType);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.takeUpInfo_.CalculateSize(SunSpiritActionOperationNotify._repeated_takeUpInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A234 RID: 107060 RVA: 0x003CF30C File Offset: 0x003CD50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritActionOperationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.OperationType != SunSpiritOperationType.Fly)
			{
				this.OperationType = other.OperationType;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.takeUpInfo_.Add(other.takeUpInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A235 RID: 107061 RVA: 0x003CF3A9 File Offset: 0x003CD5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A236 RID: 107062 RVA: 0x003CF3B4 File Offset: 0x003CD5B4
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
				if (num <= 58U)
				{
					if (num == 8U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 58U)
					{
						this.takeUpInfo_.AddEntriesFrom(ref input, SunSpiritActionOperationNotify._repeated_takeUpInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.OperationType = (SunSpiritOperationType)input.ReadEnum();
						continue;
					}
					if (num == 80U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040099BC RID: 39356
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099BD RID: 39357
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040099BE RID: 39358
		private int playerId_;

		// Token: 0x040099BF RID: 39359
		public const int IncIdFieldNumber = 11;

		// Token: 0x040099C0 RID: 39360
		private int incId_;

		// Token: 0x040099C1 RID: 39361
		public const int IndexFieldNumber = 10;

		// Token: 0x040099C2 RID: 39362
		private int index_;

		// Token: 0x040099C3 RID: 39363
		public const int OperationTypeFieldNumber = 9;

		// Token: 0x040099C4 RID: 39364
		private SunSpiritOperationType operationType_;

		// Token: 0x040099C5 RID: 39365
		public const int EntityIdFieldNumber = 3;

		// Token: 0x040099C6 RID: 39366
		private long entityId_;

		// Token: 0x040099C7 RID: 39367
		public const int TakeUpInfoFieldNumber = 7;

		// Token: 0x040099C8 RID: 39368
		private static readonly FieldCodec<SunSpiritPb> _repeated_takeUpInfo_codec = FieldCodec.ForMessage<SunSpiritPb>(58U, SunSpiritPb.Parser);

		// Token: 0x040099C9 RID: 39369
		private readonly RepeatedField<SunSpiritPb> takeUpInfo_ = new RepeatedField<SunSpiritPb>();
	}
}
