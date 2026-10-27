using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000490 RID: 1168
	public sealed class EntityFsmComponentPb : IMessage<EntityFsmComponentPb>, IMessage, IEquatable<EntityFsmComponentPb>, IDeepCloneable<EntityFsmComponentPb>, IBufferMessage
	{
		// Token: 0x06006FA9 RID: 28585 RVA: 0x001120E6 File Offset: 0x001102E6
		[NullableContext(1)]
		public static EntityFsmComponentPb Create()
		{
			return new EntityFsmComponentPb();
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06006FAA RID: 28586 RVA: 0x001120ED File Offset: 0x001102ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06006FAB RID: 28587 RVA: 0x001120F0 File Offset: 0x001102F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFsmComponentPb.Descriptor;
			}
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x001120F7 File Offset: 0x001102F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFsmComponentPb()
		{
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x00112118 File Offset: 0x00110318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFsmComponentPb(EntityFsmComponentPb other) : this()
		{
			this.fsms_ = other.fsms_.Clone();
			this.hashCode_ = other.hashCode_;
			this.commonHashCode_ = other.commonHashCode_;
			this.blackBoard_ = other.blackBoard_.Clone();
			this.fsmCustomBlackboardDatas_ = ((other.fsmCustomBlackboardDatas_ != null) ? other.fsmCustomBlackboardDatas_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x00112192 File Offset: 0x00110392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFsmComponentPb Clone()
		{
			return new EntityFsmComponentPb(this);
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06006FAF RID: 28591 RVA: 0x0011219A File Offset: 0x0011039A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFsm> Fsms
		{
			get
			{
				return this.fsms_;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06006FB0 RID: 28592 RVA: 0x001121A2 File Offset: 0x001103A2
		// (set) Token: 0x06006FB1 RID: 28593 RVA: 0x001121AA File Offset: 0x001103AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HashCode
		{
			get
			{
				return this.hashCode_;
			}
			set
			{
				this.hashCode_ = value;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06006FB2 RID: 28594 RVA: 0x001121B3 File Offset: 0x001103B3
		// (set) Token: 0x06006FB3 RID: 28595 RVA: 0x001121BB File Offset: 0x001103BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CommonHashCode
		{
			get
			{
				return this.commonHashCode_;
			}
			set
			{
				this.commonHashCode_ = value;
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06006FB4 RID: 28596 RVA: 0x001121C4 File Offset: 0x001103C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFsmBlackBoard> BlackBoard
		{
			get
			{
				return this.blackBoard_;
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06006FB5 RID: 28597 RVA: 0x001121CC File Offset: 0x001103CC
		// (set) Token: 0x06006FB6 RID: 28598 RVA: 0x001121D4 File Offset: 0x001103D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas FsmCustomBlackboardDatas
		{
			get
			{
				return this.fsmCustomBlackboardDatas_;
			}
			set
			{
				this.fsmCustomBlackboardDatas_ = value;
			}
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x001121DD File Offset: 0x001103DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFsmComponentPb);
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x001121EC File Offset: 0x001103EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFsmComponentPb other)
		{
			return other != null && (other == this || (this.fsms_.Equals(other.fsms_) && this.HashCode == other.HashCode && this.CommonHashCode == other.CommonHashCode && this.blackBoard_.Equals(other.blackBoard_) && object.Equals(this.FsmCustomBlackboardDatas, other.FsmCustomBlackboardDatas) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x00112274 File Offset: 0x00110474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fsms_.GetHashCode();
			if (this.HashCode != 0)
			{
				num ^= this.HashCode.GetHashCode();
			}
			if (this.CommonHashCode != 0)
			{
				num ^= this.CommonHashCode.GetHashCode();
			}
			num ^= this.blackBoard_.GetHashCode();
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				num ^= this.FsmCustomBlackboardDatas.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x001122FE File Offset: 0x001104FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x0011230B File Offset: 0x0011050B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x00112314 File Offset: 0x00110514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fsms_.WriteTo(ref output, EntityFsmComponentPb._repeated_fsms_codec);
			if (this.HashCode != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HashCode);
			}
			if (this.CommonHashCode != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CommonHashCode);
			}
			this.blackBoard_.WriteTo(ref output, EntityFsmComponentPb._repeated_blackBoard_codec);
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FsmCustomBlackboardDatas);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x001123AC File Offset: 0x001105AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fsms_.CalculateSize(EntityFsmComponentPb._repeated_fsms_codec);
			if (this.HashCode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HashCode);
			}
			if (this.CommonHashCode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CommonHashCode);
			}
			num += this.blackBoard_.CalculateSize(EntityFsmComponentPb._repeated_blackBoard_codec);
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FsmCustomBlackboardDatas);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x00112440 File Offset: 0x00110640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityFsmComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.fsms_.Add(other.fsms_);
			if (other.HashCode != 0)
			{
				this.HashCode = other.HashCode;
			}
			if (other.CommonHashCode != 0)
			{
				this.CommonHashCode = other.CommonHashCode;
			}
			this.blackBoard_.Add(other.blackBoard_);
			if (other.fsmCustomBlackboardDatas_ != null)
			{
				if (this.fsmCustomBlackboardDatas_ == null)
				{
					this.FsmCustomBlackboardDatas = new FsmCustomBlackboardDatas();
				}
				this.FsmCustomBlackboardDatas.MergeFrom(other.FsmCustomBlackboardDatas);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x001124DE File Offset: 0x001106DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x001124E8 File Offset: 0x001106E8
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.fsms_.AddEntriesFrom(ref input, EntityFsmComponentPb._repeated_fsms_codec);
						continue;
					}
					if (num == 16U)
					{
						this.HashCode = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CommonHashCode = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.blackBoard_.AddEntriesFrom(ref input, EntityFsmComponentPb._repeated_blackBoard_codec);
						continue;
					}
					if (num == 42U)
					{
						if (this.fsmCustomBlackboardDatas_ == null)
						{
							this.FsmCustomBlackboardDatas = new FsmCustomBlackboardDatas();
						}
						input.ReadMessage(this.FsmCustomBlackboardDatas);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003BFC RID: 15356
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BFD RID: 15357
		public const int FsmsFieldNumber = 1;

		// Token: 0x04003BFE RID: 15358
		private static readonly FieldCodec<DFsm> _repeated_fsms_codec = FieldCodec.ForMessage<DFsm>(10U, DFsm.Parser);

		// Token: 0x04003BFF RID: 15359
		private readonly RepeatedField<DFsm> fsms_ = new RepeatedField<DFsm>();

		// Token: 0x04003C00 RID: 15360
		public const int HashCodeFieldNumber = 2;

		// Token: 0x04003C01 RID: 15361
		private int hashCode_;

		// Token: 0x04003C02 RID: 15362
		public const int CommonHashCodeFieldNumber = 3;

		// Token: 0x04003C03 RID: 15363
		private int commonHashCode_;

		// Token: 0x04003C04 RID: 15364
		public const int BlackBoardFieldNumber = 4;

		// Token: 0x04003C05 RID: 15365
		private static readonly FieldCodec<DFsmBlackBoard> _repeated_blackBoard_codec = FieldCodec.ForMessage<DFsmBlackBoard>(34U, DFsmBlackBoard.Parser);

		// Token: 0x04003C06 RID: 15366
		private readonly RepeatedField<DFsmBlackBoard> blackBoard_ = new RepeatedField<DFsmBlackBoard>();

		// Token: 0x04003C07 RID: 15367
		public const int FsmCustomBlackboardDatasFieldNumber = 5;

		// Token: 0x04003C08 RID: 15368
		private FsmCustomBlackboardDatas fsmCustomBlackboardDatas_;
	}
}
