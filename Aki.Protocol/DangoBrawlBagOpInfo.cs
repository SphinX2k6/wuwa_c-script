using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033E RID: 830
	public sealed class DangoBrawlBagOpInfo : IMessage<DangoBrawlBagOpInfo>, IMessage, IEquatable<DangoBrawlBagOpInfo>, IDeepCloneable<DangoBrawlBagOpInfo>, IBufferMessage
	{
		// Token: 0x06005378 RID: 21368 RVA: 0x000CBE71 File Offset: 0x000CA071
		[NullableContext(1)]
		public static DangoBrawlBagOpInfo Create()
		{
			return new DangoBrawlBagOpInfo();
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06005379 RID: 21369 RVA: 0x000CBE78 File Offset: 0x000CA078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlBagOpInfo> Parser
		{
			get
			{
				return DangoBrawlBagOpInfo._parser;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x000CBE7F File Offset: 0x000CA07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x000CBE82 File Offset: 0x000CA082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagOpInfo.Descriptor;
			}
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x000CBE89 File Offset: 0x000CA089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOpInfo()
		{
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x000CBE94 File Offset: 0x000CA094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOpInfo(DangoBrawlBagOpInfo other) : this()
		{
			this.opType_ = other.opType_;
			this.fromUid_ = other.fromUid_;
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x000CBEEC File Offset: 0x000CA0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOpInfo Clone()
		{
			return new DangoBrawlBagOpInfo(this);
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x0600537F RID: 21375 RVA: 0x000CBEF4 File Offset: 0x000CA0F4
		// (set) Token: 0x06005380 RID: 21376 RVA: 0x000CBEFC File Offset: 0x000CA0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOpType OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06005381 RID: 21377 RVA: 0x000CBF05 File Offset: 0x000CA105
		// (set) Token: 0x06005382 RID: 21378 RVA: 0x000CBF0D File Offset: 0x000CA10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromUid
		{
			get
			{
				return this.fromUid_;
			}
			set
			{
				this.fromUid_ = value;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06005383 RID: 21379 RVA: 0x000CBF16 File Offset: 0x000CA116
		// (set) Token: 0x06005384 RID: 21380 RVA: 0x000CBF1E File Offset: 0x000CA11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagSlotInfo Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x000CBF27 File Offset: 0x000CA127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagOpInfo);
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x000CBF38 File Offset: 0x000CA138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagOpInfo other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && this.FromUid == other.FromUid && object.Equals(this.Slot, other.Slot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x000CBF98 File Offset: 0x000CA198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpType != DangoBrawlBagOpType.NormalChange)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this.FromUid != 0)
			{
				num ^= this.FromUid.GetHashCode();
			}
			if (this.slot_ != null)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x000CC00C File Offset: 0x000CA20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x000CC019 File Offset: 0x000CA219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x000CC024 File Offset: 0x000CA224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpType != DangoBrawlBagOpType.NormalChange)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.OpType);
			}
			if (this.FromUid != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FromUid);
			}
			if (this.slot_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Slot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x000CC098 File Offset: 0x000CA298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpType != DangoBrawlBagOpType.NormalChange)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpType);
			}
			if (this.FromUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FromUid);
			}
			if (this.slot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x000CC108 File Offset: 0x000CA308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBagOpInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpType != DangoBrawlBagOpType.NormalChange)
			{
				this.OpType = other.OpType;
			}
			if (other.FromUid != 0)
			{
				this.FromUid = other.FromUid;
			}
			if (other.slot_ != null)
			{
				if (this.slot_ == null)
				{
					this.Slot = new DangoBrawlBagSlotInfo();
				}
				this.Slot.MergeFrom(other.Slot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x000CC184 File Offset: 0x000CA384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x000CC190 File Offset: 0x000CA390
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.slot_ == null)
							{
								this.Slot = new DangoBrawlBagSlotInfo();
							}
							input.ReadMessage(this.Slot);
						}
					}
					else
					{
						this.FromUid = input.ReadInt32();
					}
				}
				else
				{
					this.OpType = (DangoBrawlBagOpType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040033D6 RID: 13270
		private static readonly MessageParser<DangoBrawlBagOpInfo> _parser = new MessageParser<DangoBrawlBagOpInfo>(() => new DangoBrawlBagOpInfo());

		// Token: 0x040033D7 RID: 13271
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033D8 RID: 13272
		public const int OpTypeFieldNumber = 1;

		// Token: 0x040033D9 RID: 13273
		private DangoBrawlBagOpType opType_;

		// Token: 0x040033DA RID: 13274
		public const int FromUidFieldNumber = 2;

		// Token: 0x040033DB RID: 13275
		private int fromUid_;

		// Token: 0x040033DC RID: 13276
		public const int SlotFieldNumber = 3;

		// Token: 0x040033DD RID: 13277
		private DangoBrawlBagSlotInfo slot_;
	}
}
