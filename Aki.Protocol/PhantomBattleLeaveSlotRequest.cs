using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C94 RID: 3220
	[NetMessage(EMessageId.PhantomBattleLeaveSlotRequest)]
	public sealed class PhantomBattleLeaveSlotRequest : IMessage<PhantomBattleLeaveSlotRequest>, IMessage, IEquatable<PhantomBattleLeaveSlotRequest>, IDeepCloneable<PhantomBattleLeaveSlotRequest>, IBufferMessage
	{
		// Token: 0x06011744 RID: 71492 RVA: 0x0028EBE9 File Offset: 0x0028CDE9
		[NullableContext(1)]
		public static PhantomBattleLeaveSlotRequest Create()
		{
			return new PhantomBattleLeaveSlotRequest();
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x06011745 RID: 71493 RVA: 0x0028EBF0 File Offset: 0x0028CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x06011746 RID: 71494 RVA: 0x0028EBF3 File Offset: 0x0028CDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleLeaveSlotRequest.Descriptor;
			}
		}

		// Token: 0x06011747 RID: 71495 RVA: 0x0028EBFA File Offset: 0x0028CDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotRequest()
		{
		}

		// Token: 0x06011748 RID: 71496 RVA: 0x0028EC02 File Offset: 0x0028CE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotRequest(PhantomBattleLeaveSlotRequest other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011749 RID: 71497 RVA: 0x0028EC27 File Offset: 0x0028CE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotRequest Clone()
		{
			return new PhantomBattleLeaveSlotRequest(this);
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0601174A RID: 71498 RVA: 0x0028EC2F File Offset: 0x0028CE2F
		// (set) Token: 0x0601174B RID: 71499 RVA: 0x0028EC37 File Offset: 0x0028CE37
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

		// Token: 0x0601174C RID: 71500 RVA: 0x0028EC40 File Offset: 0x0028CE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleLeaveSlotRequest);
		}

		// Token: 0x0601174D RID: 71501 RVA: 0x0028EC4E File Offset: 0x0028CE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleLeaveSlotRequest other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601174E RID: 71502 RVA: 0x0028EC7C File Offset: 0x0028CE7C
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

		// Token: 0x0601174F RID: 71503 RVA: 0x0028ECBB File Offset: 0x0028CEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011750 RID: 71504 RVA: 0x0028ECC8 File Offset: 0x0028CEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011751 RID: 71505 RVA: 0x0028ECD1 File Offset: 0x0028CED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011752 RID: 71506 RVA: 0x0028ED04 File Offset: 0x0028CF04
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

		// Token: 0x06011753 RID: 71507 RVA: 0x0028ED42 File Offset: 0x0028CF42
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

		// Token: 0x06011754 RID: 71508 RVA: 0x0028ED73 File Offset: 0x0028CF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011755 RID: 71509 RVA: 0x0028ED7C File Offset: 0x0028CF7C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E2C RID: 28204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E2D RID: 28205
		public const int SlotIndexFieldNumber = 5;

		// Token: 0x04006E2E RID: 28206
		private int slotIndex_;
	}
}
