using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B7 RID: 4791
	[NetMessage(EMessageId.SunSpiritActionOperationNotify)]
	public sealed class SunSpiritActionOperationNotify : IMessage<SunSpiritActionOperationNotify>, IMessage, IEquatable<SunSpiritActionOperationNotify>, IDeepCloneable<SunSpiritActionOperationNotify>, IBufferMessage
	{
		// Token: 0x060197E6 RID: 104422 RVA: 0x003B47EF File Offset: 0x003B29EF
		[NullableContext(1)]
		public static SunSpiritActionOperationNotify Create()
		{
			return new SunSpiritActionOperationNotify();
		}

		// Token: 0x170055F8 RID: 22008
		// (get) Token: 0x060197E7 RID: 104423 RVA: 0x003B47F6 File Offset: 0x003B29F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055F9 RID: 22009
		// (get) Token: 0x060197E8 RID: 104424 RVA: 0x003B47F9 File Offset: 0x003B29F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritActionOperationNotify.Descriptor;
			}
		}

		// Token: 0x060197E9 RID: 104425 RVA: 0x003B4800 File Offset: 0x003B2A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationNotify()
		{
		}

		// Token: 0x060197EA RID: 104426 RVA: 0x003B4814 File Offset: 0x003B2A14
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

		// Token: 0x060197EB RID: 104427 RVA: 0x003B4885 File Offset: 0x003B2A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationNotify Clone()
		{
			return new SunSpiritActionOperationNotify(this);
		}

		// Token: 0x170055FA RID: 22010
		// (get) Token: 0x060197EC RID: 104428 RVA: 0x003B488D File Offset: 0x003B2A8D
		// (set) Token: 0x060197ED RID: 104429 RVA: 0x003B4895 File Offset: 0x003B2A95
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

		// Token: 0x170055FB RID: 22011
		// (get) Token: 0x060197EE RID: 104430 RVA: 0x003B489E File Offset: 0x003B2A9E
		// (set) Token: 0x060197EF RID: 104431 RVA: 0x003B48A6 File Offset: 0x003B2AA6
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

		// Token: 0x170055FC RID: 22012
		// (get) Token: 0x060197F0 RID: 104432 RVA: 0x003B48AF File Offset: 0x003B2AAF
		// (set) Token: 0x060197F1 RID: 104433 RVA: 0x003B48B7 File Offset: 0x003B2AB7
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

		// Token: 0x170055FD RID: 22013
		// (get) Token: 0x060197F2 RID: 104434 RVA: 0x003B48C0 File Offset: 0x003B2AC0
		// (set) Token: 0x060197F3 RID: 104435 RVA: 0x003B48C8 File Offset: 0x003B2AC8
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

		// Token: 0x170055FE RID: 22014
		// (get) Token: 0x060197F4 RID: 104436 RVA: 0x003B48D1 File Offset: 0x003B2AD1
		// (set) Token: 0x060197F5 RID: 104437 RVA: 0x003B48D9 File Offset: 0x003B2AD9
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

		// Token: 0x170055FF RID: 22015
		// (get) Token: 0x060197F6 RID: 104438 RVA: 0x003B48E2 File Offset: 0x003B2AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SunSpiritPb> TakeUpInfo
		{
			get
			{
				return this.takeUpInfo_;
			}
		}

		// Token: 0x060197F7 RID: 104439 RVA: 0x003B48EA File Offset: 0x003B2AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritActionOperationNotify);
		}

		// Token: 0x060197F8 RID: 104440 RVA: 0x003B48F8 File Offset: 0x003B2AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritActionOperationNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Index == other.Index && this.OperationType == other.OperationType && this.EntityId == other.EntityId && this.takeUpInfo_.Equals(other.takeUpInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060197F9 RID: 104441 RVA: 0x003B4988 File Offset: 0x003B2B88
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

		// Token: 0x060197FA RID: 104442 RVA: 0x003B4A3F File Offset: 0x003B2C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197FB RID: 104443 RVA: 0x003B4A4C File Offset: 0x003B2C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197FC RID: 104444 RVA: 0x003B4A58 File Offset: 0x003B2C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OperationType != SunSpiritOperationType.Fly)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.OperationType);
			}
			this.takeUpInfo_.WriteTo(ref output, SunSpiritActionOperationNotify._repeated_takeUpInfo_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Index);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197FD RID: 104445 RVA: 0x003B4B18 File Offset: 0x003B2D18
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

		// Token: 0x060197FE RID: 104446 RVA: 0x003B4BCC File Offset: 0x003B2DCC
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

		// Token: 0x060197FF RID: 104447 RVA: 0x003B4C69 File Offset: 0x003B2E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019800 RID: 104448 RVA: 0x003B4C74 File Offset: 0x003B2E74
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
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.OperationType = (SunSpiritOperationType)input.ReadEnum();
						continue;
					}
					if (num == 50U)
					{
						this.takeUpInfo_.AddEntriesFrom(ref input, SunSpiritActionOperationNotify._repeated_takeUpInfo_codec);
						continue;
					}
					if (num == 56U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009592 RID: 38290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009593 RID: 38291
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x04009594 RID: 38292
		private int playerId_;

		// Token: 0x04009595 RID: 38293
		public const int IncIdFieldNumber = 9;

		// Token: 0x04009596 RID: 38294
		private int incId_;

		// Token: 0x04009597 RID: 38295
		public const int IndexFieldNumber = 8;

		// Token: 0x04009598 RID: 38296
		private int index_;

		// Token: 0x04009599 RID: 38297
		public const int OperationTypeFieldNumber = 2;

		// Token: 0x0400959A RID: 38298
		private SunSpiritOperationType operationType_;

		// Token: 0x0400959B RID: 38299
		public const int EntityIdFieldNumber = 7;

		// Token: 0x0400959C RID: 38300
		private long entityId_;

		// Token: 0x0400959D RID: 38301
		public const int TakeUpInfoFieldNumber = 6;

		// Token: 0x0400959E RID: 38302
		private static readonly FieldCodec<SunSpiritPb> _repeated_takeUpInfo_codec = FieldCodec.ForMessage<SunSpiritPb>(50U, SunSpiritPb.Parser);

		// Token: 0x0400959F RID: 38303
		private readonly RepeatedField<SunSpiritPb> takeUpInfo_ = new RepeatedField<SunSpiritPb>();
	}
}
