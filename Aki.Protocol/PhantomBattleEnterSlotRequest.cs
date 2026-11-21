using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C73 RID: 3187
	[NetMessage(EMessageId.PhantomBattleEnterSlotRequest)]
	public sealed class PhantomBattleEnterSlotRequest : IMessage<PhantomBattleEnterSlotRequest>, IMessage, IEquatable<PhantomBattleEnterSlotRequest>, IDeepCloneable<PhantomBattleEnterSlotRequest>, IBufferMessage
	{
		// Token: 0x060114D4 RID: 70868 RVA: 0x002898D6 File Offset: 0x00287AD6
		[NullableContext(1)]
		public static PhantomBattleEnterSlotRequest Create()
		{
			return new PhantomBattleEnterSlotRequest();
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x060114D5 RID: 70869 RVA: 0x002898DD File Offset: 0x00287ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x060114D6 RID: 70870 RVA: 0x002898E0 File Offset: 0x00287AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEnterSlotRequest.Descriptor;
			}
		}

		// Token: 0x060114D7 RID: 70871 RVA: 0x002898E7 File Offset: 0x00287AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotRequest()
		{
		}

		// Token: 0x060114D8 RID: 70872 RVA: 0x002898EF File Offset: 0x00287AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotRequest(PhantomBattleEnterSlotRequest other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this.slotIndex_ = other.slotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060114D9 RID: 70873 RVA: 0x00289920 File Offset: 0x00287B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotRequest Clone()
		{
			return new PhantomBattleEnterSlotRequest(this);
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x060114DA RID: 70874 RVA: 0x00289928 File Offset: 0x00287B28
		// (set) Token: 0x060114DB RID: 70875 RVA: 0x00289930 File Offset: 0x00287B30
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

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x060114DC RID: 70876 RVA: 0x00289939 File Offset: 0x00287B39
		// (set) Token: 0x060114DD RID: 70877 RVA: 0x00289941 File Offset: 0x00287B41
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

		// Token: 0x060114DE RID: 70878 RVA: 0x0028994A File Offset: 0x00287B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEnterSlotRequest);
		}

		// Token: 0x060114DF RID: 70879 RVA: 0x00289958 File Offset: 0x00287B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEnterSlotRequest other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.SlotIndex == other.SlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060114E0 RID: 70880 RVA: 0x00289998 File Offset: 0x00287B98
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

		// Token: 0x060114E1 RID: 70881 RVA: 0x002899F0 File Offset: 0x00287BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114E2 RID: 70882 RVA: 0x002899FD File Offset: 0x00287BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114E3 RID: 70883 RVA: 0x00289A08 File Offset: 0x00287C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CardUid);
			}
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060114E4 RID: 70884 RVA: 0x00289A64 File Offset: 0x00287C64
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

		// Token: 0x060114E5 RID: 70885 RVA: 0x00289ABC File Offset: 0x00287CBC
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

		// Token: 0x060114E6 RID: 70886 RVA: 0x00289B0C File Offset: 0x00287D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060114E7 RID: 70887 RVA: 0x00289B18 File Offset: 0x00287D18
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
				if (num != 64U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SlotIndex = input.ReadInt32();
					}
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006DCD RID: 28109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DCE RID: 28110
		public const int CardUidFieldNumber = 8;

		// Token: 0x04006DCF RID: 28111
		private int cardUid_;

		// Token: 0x04006DD0 RID: 28112
		public const int SlotIndexFieldNumber = 11;

		// Token: 0x04006DD1 RID: 28113
		private int slotIndex_;
	}
}
