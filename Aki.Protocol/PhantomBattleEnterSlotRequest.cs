using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C83 RID: 3203
	[NetMessage(EMessageId.PhantomBattleEnterSlotRequest)]
	public sealed class PhantomBattleEnterSlotRequest : IMessage<PhantomBattleEnterSlotRequest>, IMessage, IEquatable<PhantomBattleEnterSlotRequest>, IDeepCloneable<PhantomBattleEnterSlotRequest>, IBufferMessage
	{
		// Token: 0x060115D4 RID: 71124 RVA: 0x0028B646 File Offset: 0x00289846
		[NullableContext(1)]
		public static PhantomBattleEnterSlotRequest Create()
		{
			return new PhantomBattleEnterSlotRequest();
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x060115D5 RID: 71125 RVA: 0x0028B64D File Offset: 0x0028984D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x060115D6 RID: 71126 RVA: 0x0028B650 File Offset: 0x00289850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEnterSlotRequest.Descriptor;
			}
		}

		// Token: 0x060115D7 RID: 71127 RVA: 0x0028B657 File Offset: 0x00289857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotRequest()
		{
		}

		// Token: 0x060115D8 RID: 71128 RVA: 0x0028B65F File Offset: 0x0028985F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotRequest(PhantomBattleEnterSlotRequest other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this.slotIndex_ = other.slotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060115D9 RID: 71129 RVA: 0x0028B690 File Offset: 0x00289890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotRequest Clone()
		{
			return new PhantomBattleEnterSlotRequest(this);
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x060115DA RID: 71130 RVA: 0x0028B698 File Offset: 0x00289898
		// (set) Token: 0x060115DB RID: 71131 RVA: 0x0028B6A0 File Offset: 0x002898A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x060115DC RID: 71132 RVA: 0x0028B6A9 File Offset: 0x002898A9
		// (set) Token: 0x060115DD RID: 71133 RVA: 0x0028B6B1 File Offset: 0x002898B1
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

		// Token: 0x060115DE RID: 71134 RVA: 0x0028B6BA File Offset: 0x002898BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEnterSlotRequest);
		}

		// Token: 0x060115DF RID: 71135 RVA: 0x0028B6C8 File Offset: 0x002898C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEnterSlotRequest other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.SlotIndex == other.SlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060115E0 RID: 71136 RVA: 0x0028B708 File Offset: 0x00289908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
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

		// Token: 0x060115E1 RID: 71137 RVA: 0x0028B760 File Offset: 0x00289960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060115E2 RID: 71138 RVA: 0x0028B76D File Offset: 0x0028996D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060115E3 RID: 71139 RVA: 0x0028B778 File Offset: 0x00289978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SlotIndex);
			}
			if (this.CardUid != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060115E4 RID: 71140 RVA: 0x0028B7D4 File Offset: 0x002899D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
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

		// Token: 0x060115E5 RID: 71141 RVA: 0x0028B82C File Offset: 0x00289A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleEnterSlotRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060115E6 RID: 71142 RVA: 0x0028B87C File Offset: 0x00289A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060115E7 RID: 71143 RVA: 0x0028B888 File Offset: 0x00289A88
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CardUid = input.ReadInt32();
					}
				}
				else
				{
					this.SlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006DB9 RID: 28089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DBA RID: 28090
		public const int CardUidFieldNumber = 9;

		// Token: 0x04006DBB RID: 28091
		private int cardUid_;

		// Token: 0x04006DBC RID: 28092
		public const int SlotIndexFieldNumber = 5;

		// Token: 0x04006DBD RID: 28093
		private int slotIndex_;
	}
}
