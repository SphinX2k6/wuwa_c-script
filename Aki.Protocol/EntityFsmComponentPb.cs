using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000479 RID: 1145
	public sealed class EntityFsmComponentPb : IMessage<EntityFsmComponentPb>, IMessage, IEquatable<EntityFsmComponentPb>, IDeepCloneable<EntityFsmComponentPb>, IBufferMessage
	{
		// Token: 0x06006E1B RID: 28187 RVA: 0x0010F072 File Offset: 0x0010D272
		[NullableContext(1)]
		public static EntityFsmComponentPb Create()
		{
			return new EntityFsmComponentPb();
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x0010F079 File Offset: 0x0010D279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06006E1D RID: 28189 RVA: 0x0010F07C File Offset: 0x0010D27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFsmComponentPb.Descriptor;
			}
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x0010F083 File Offset: 0x0010D283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFsmComponentPb()
		{
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x0010F0A4 File Offset: 0x0010D2A4
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

		// Token: 0x06006E20 RID: 28192 RVA: 0x0010F11E File Offset: 0x0010D31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFsmComponentPb Clone()
		{
			return new EntityFsmComponentPb(this);
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06006E21 RID: 28193 RVA: 0x0010F126 File Offset: 0x0010D326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFsm> Fsms
		{
			get
			{
				return this.fsms_;
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x0010F12E File Offset: 0x0010D32E
		// (set) Token: 0x06006E23 RID: 28195 RVA: 0x0010F136 File Offset: 0x0010D336
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

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06006E24 RID: 28196 RVA: 0x0010F13F File Offset: 0x0010D33F
		// (set) Token: 0x06006E25 RID: 28197 RVA: 0x0010F147 File Offset: 0x0010D347
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

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06006E26 RID: 28198 RVA: 0x0010F150 File Offset: 0x0010D350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFsmBlackBoard> BlackBoard
		{
			get
			{
				return this.blackBoard_;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06006E27 RID: 28199 RVA: 0x0010F158 File Offset: 0x0010D358
		// (set) Token: 0x06006E28 RID: 28200 RVA: 0x0010F160 File Offset: 0x0010D360
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

		// Token: 0x06006E29 RID: 28201 RVA: 0x0010F169 File Offset: 0x0010D369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFsmComponentPb);
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x0010F178 File Offset: 0x0010D378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFsmComponentPb other)
		{
			return other != null && (other == this || (this.fsms_.Equals(other.fsms_) && this.HashCode == other.HashCode && this.CommonHashCode == other.CommonHashCode && this.blackBoard_.Equals(other.blackBoard_) && object.Equals(this.FsmCustomBlackboardDatas, other.FsmCustomBlackboardDatas) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x0010F200 File Offset: 0x0010D400
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

		// Token: 0x06006E2C RID: 28204 RVA: 0x0010F28A File Offset: 0x0010D48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x0010F297 File Offset: 0x0010D497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E2E RID: 28206 RVA: 0x0010F2A0 File Offset: 0x0010D4A0
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

		// Token: 0x06006E2F RID: 28207 RVA: 0x0010F338 File Offset: 0x0010D538
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

		// Token: 0x06006E30 RID: 28208 RVA: 0x0010F3CC File Offset: 0x0010D5CC
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

		// Token: 0x06006E31 RID: 28209 RVA: 0x0010F46A File Offset: 0x0010D66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x0010F474 File Offset: 0x0010D674
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

		// Token: 0x04003BEA RID: 15338
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BEB RID: 15339
		public const int FsmsFieldNumber = 1;

		// Token: 0x04003BEC RID: 15340
		private static readonly FieldCodec<DFsm> _repeated_fsms_codec = FieldCodec.ForMessage<DFsm>(10U, DFsm.Parser);

		// Token: 0x04003BED RID: 15341
		private readonly RepeatedField<DFsm> fsms_ = new RepeatedField<DFsm>();

		// Token: 0x04003BEE RID: 15342
		public const int HashCodeFieldNumber = 2;

		// Token: 0x04003BEF RID: 15343
		private int hashCode_;

		// Token: 0x04003BF0 RID: 15344
		public const int CommonHashCodeFieldNumber = 3;

		// Token: 0x04003BF1 RID: 15345
		private int commonHashCode_;

		// Token: 0x04003BF2 RID: 15346
		public const int BlackBoardFieldNumber = 4;

		// Token: 0x04003BF3 RID: 15347
		private static readonly FieldCodec<DFsmBlackBoard> _repeated_blackBoard_codec = FieldCodec.ForMessage<DFsmBlackBoard>(34U, DFsmBlackBoard.Parser);

		// Token: 0x04003BF4 RID: 15348
		private readonly RepeatedField<DFsmBlackBoard> blackBoard_ = new RepeatedField<DFsmBlackBoard>();

		// Token: 0x04003BF5 RID: 15349
		public const int FsmCustomBlackboardDatasFieldNumber = 5;

		// Token: 0x04003BF6 RID: 15350
		private FsmCustomBlackboardDatas fsmCustomBlackboardDatas_;
	}
}
