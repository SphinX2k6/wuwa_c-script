using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000336 RID: 822
	public sealed class DangoBrawlBagOpInfo : IMessage<DangoBrawlBagOpInfo>, IMessage, IEquatable<DangoBrawlBagOpInfo>, IDeepCloneable<DangoBrawlBagOpInfo>, IBufferMessage
	{
		// Token: 0x0600528B RID: 21131 RVA: 0x000C97ED File Offset: 0x000C79ED
		[NullableContext(1)]
		public static DangoBrawlBagOpInfo Create()
		{
			return new DangoBrawlBagOpInfo();
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600528C RID: 21132 RVA: 0x000C97F4 File Offset: 0x000C79F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlBagOpInfo> Parser
		{
			get
			{
				return DangoBrawlBagOpInfo._parser;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x000C97FB File Offset: 0x000C79FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x000C97FE File Offset: 0x000C79FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagOpInfo.Descriptor;
			}
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x000C9805 File Offset: 0x000C7A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOpInfo()
		{
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x000C9810 File Offset: 0x000C7A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOpInfo(DangoBrawlBagOpInfo other) : this()
		{
			this.opType_ = other.opType_;
			this.fromUid_ = other.fromUid_;
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x000C9868 File Offset: 0x000C7A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOpInfo Clone()
		{
			return new DangoBrawlBagOpInfo(this);
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06005292 RID: 21138 RVA: 0x000C9870 File Offset: 0x000C7A70
		// (set) Token: 0x06005293 RID: 21139 RVA: 0x000C9878 File Offset: 0x000C7A78
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

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06005294 RID: 21140 RVA: 0x000C9881 File Offset: 0x000C7A81
		// (set) Token: 0x06005295 RID: 21141 RVA: 0x000C9889 File Offset: 0x000C7A89
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

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06005296 RID: 21142 RVA: 0x000C9892 File Offset: 0x000C7A92
		// (set) Token: 0x06005297 RID: 21143 RVA: 0x000C989A File Offset: 0x000C7A9A
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

		// Token: 0x06005298 RID: 21144 RVA: 0x000C98A3 File Offset: 0x000C7AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagOpInfo);
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x000C98B4 File Offset: 0x000C7AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagOpInfo other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && this.FromUid == other.FromUid && object.Equals(this.Slot, other.Slot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x000C9914 File Offset: 0x000C7B14
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

		// Token: 0x0600529B RID: 21147 RVA: 0x000C9988 File Offset: 0x000C7B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x000C9995 File Offset: 0x000C7B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x000C99A0 File Offset: 0x000C7BA0
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

		// Token: 0x0600529E RID: 21150 RVA: 0x000C9A14 File Offset: 0x000C7C14
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

		// Token: 0x0600529F RID: 21151 RVA: 0x000C9A84 File Offset: 0x000C7C84
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

		// Token: 0x060052A0 RID: 21152 RVA: 0x000C9B00 File Offset: 0x000C7D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x000C9B0C File Offset: 0x000C7D0C
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

		// Token: 0x0400333A RID: 13114
		private static readonly MessageParser<DangoBrawlBagOpInfo> _parser = new MessageParser<DangoBrawlBagOpInfo>(() => new DangoBrawlBagOpInfo());

		// Token: 0x0400333B RID: 13115
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400333C RID: 13116
		public const int OpTypeFieldNumber = 1;

		// Token: 0x0400333D RID: 13117
		private DangoBrawlBagOpType opType_;

		// Token: 0x0400333E RID: 13118
		public const int FromUidFieldNumber = 2;

		// Token: 0x0400333F RID: 13119
		private int fromUid_;

		// Token: 0x04003340 RID: 13120
		public const int SlotFieldNumber = 3;

		// Token: 0x04003341 RID: 13121
		private DangoBrawlBagSlotInfo slot_;
	}
}
