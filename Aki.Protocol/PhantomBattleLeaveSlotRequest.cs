using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C84 RID: 3204
	[NetMessage(EMessageId.PhantomBattleLeaveSlotRequest)]
	public sealed class PhantomBattleLeaveSlotRequest : IMessage<PhantomBattleLeaveSlotRequest>, IMessage, IEquatable<PhantomBattleLeaveSlotRequest>, IDeepCloneable<PhantomBattleLeaveSlotRequest>, IBufferMessage
	{
		// Token: 0x06011644 RID: 71236 RVA: 0x0028CE7D File Offset: 0x0028B07D
		[NullableContext(1)]
		public static PhantomBattleLeaveSlotRequest Create()
		{
			return new PhantomBattleLeaveSlotRequest();
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x06011645 RID: 71237 RVA: 0x0028CE84 File Offset: 0x0028B084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x06011646 RID: 71238 RVA: 0x0028CE87 File Offset: 0x0028B087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleLeaveSlotRequest.Descriptor;
			}
		}

		// Token: 0x06011647 RID: 71239 RVA: 0x0028CE8E File Offset: 0x0028B08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotRequest()
		{
		}

		// Token: 0x06011648 RID: 71240 RVA: 0x0028CE96 File Offset: 0x0028B096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotRequest(PhantomBattleLeaveSlotRequest other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011649 RID: 71241 RVA: 0x0028CEBB File Offset: 0x0028B0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotRequest Clone()
		{
			return new PhantomBattleLeaveSlotRequest(this);
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0601164A RID: 71242 RVA: 0x0028CEC3 File Offset: 0x0028B0C3
		// (set) Token: 0x0601164B RID: 71243 RVA: 0x0028CECB File Offset: 0x0028B0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x0601164C RID: 71244 RVA: 0x0028CED4 File Offset: 0x0028B0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleLeaveSlotRequest);
		}

		// Token: 0x0601164D RID: 71245 RVA: 0x0028CEE2 File Offset: 0x0028B0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleLeaveSlotRequest other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601164E RID: 71246 RVA: 0x0028CF10 File Offset: 0x0028B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotIndex != 0)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601164F RID: 71247 RVA: 0x0028CF4F File Offset: 0x0028B14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011650 RID: 71248 RVA: 0x0028CF5C File Offset: 0x0028B15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011651 RID: 71249 RVA: 0x0028CF65 File Offset: 0x0028B165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011652 RID: 71250 RVA: 0x0028CF98 File Offset: 0x0028B198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011653 RID: 71251 RVA: 0x0028CFD6 File Offset: 0x0028B1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleLeaveSlotRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011654 RID: 71252 RVA: 0x0028D007 File Offset: 0x0028B207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011655 RID: 71253 RVA: 0x0028D010 File Offset: 0x0028B210
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E40 RID: 28224
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E41 RID: 28225
		public const int SlotIndexFieldNumber = 4;

		// Token: 0x04006E42 RID: 28226
		private int slotIndex_;
	}
}
