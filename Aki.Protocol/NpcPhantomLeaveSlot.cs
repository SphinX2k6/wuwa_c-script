using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B69 RID: 2921
	public sealed class NpcPhantomLeaveSlot : IMessage<NpcPhantomLeaveSlot>, IMessage, IEquatable<NpcPhantomLeaveSlot>, IDeepCloneable<NpcPhantomLeaveSlot>, IBufferMessage
	{
		// Token: 0x0600FD90 RID: 64912 RVA: 0x0025035A File Offset: 0x0024E55A
		[NullableContext(1)]
		public static NpcPhantomLeaveSlot Create()
		{
			return new NpcPhantomLeaveSlot();
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600FD91 RID: 64913 RVA: 0x00250361 File Offset: 0x0024E561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600FD92 RID: 64914 RVA: 0x00250364 File Offset: 0x0024E564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomLeaveSlot.Descriptor;
			}
		}

		// Token: 0x0600FD93 RID: 64915 RVA: 0x0025036B File Offset: 0x0024E56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomLeaveSlot()
		{
		}

		// Token: 0x0600FD94 RID: 64916 RVA: 0x00250373 File Offset: 0x0024E573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomLeaveSlot(NpcPhantomLeaveSlot other) : this()
		{
			this.fighterUId_ = other.fighterUId_;
			this.slotIndex_ = other.slotIndex_;
			this.handCardNum_ = other.handCardNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD95 RID: 64917 RVA: 0x002503B0 File Offset: 0x0024E5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomLeaveSlot Clone()
		{
			return new NpcPhantomLeaveSlot(this);
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600FD96 RID: 64918 RVA: 0x002503B8 File Offset: 0x0024E5B8
		// (set) Token: 0x0600FD97 RID: 64919 RVA: 0x002503C0 File Offset: 0x0024E5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
			set
			{
				this.fighterUId_ = value;
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600FD98 RID: 64920 RVA: 0x002503C9 File Offset: 0x0024E5C9
		// (set) Token: 0x0600FD99 RID: 64921 RVA: 0x002503D1 File Offset: 0x0024E5D1
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

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600FD9A RID: 64922 RVA: 0x002503DA File Offset: 0x0024E5DA
		// (set) Token: 0x0600FD9B RID: 64923 RVA: 0x002503E2 File Offset: 0x0024E5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x0600FD9C RID: 64924 RVA: 0x002503EB File Offset: 0x0024E5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomLeaveSlot);
		}

		// Token: 0x0600FD9D RID: 64925 RVA: 0x002503FC File Offset: 0x0024E5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomLeaveSlot other)
		{
			return other != null && (other == this || (this.FighterUId == other.FighterUId && this.SlotIndex == other.SlotIndex && this.HandCardNum == other.HandCardNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD9E RID: 64926 RVA: 0x00250458 File Offset: 0x0024E658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FighterUId != 0)
			{
				num ^= this.FighterUId.GetHashCode();
			}
			if (this.SlotIndex != 0)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD9F RID: 64927 RVA: 0x002504C9 File Offset: 0x0024E6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDA0 RID: 64928 RVA: 0x002504D6 File Offset: 0x0024E6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDA1 RID: 64929 RVA: 0x002504E0 File Offset: 0x0024E6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FighterUId);
			}
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SlotIndex);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HandCardNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FDA2 RID: 64930 RVA: 0x00250554 File Offset: 0x0024E754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FighterUId);
			}
			if (this.SlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndex);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FDA3 RID: 64931 RVA: 0x002505C4 File Offset: 0x0024E7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomLeaveSlot other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FighterUId != 0)
			{
				this.FighterUId = other.FighterUId;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FDA4 RID: 64932 RVA: 0x00250628 File Offset: 0x0024E828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDA5 RID: 64933 RVA: 0x00250634 File Offset: 0x0024E834
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HandCardNum = input.ReadInt32();
						}
					}
					else
					{
						this.SlotIndex = input.ReadInt32();
					}
				}
				else
				{
					this.FighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006589 RID: 25993
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400658A RID: 25994
		public const int FighterUIdFieldNumber = 1;

		// Token: 0x0400658B RID: 25995
		private int fighterUId_;

		// Token: 0x0400658C RID: 25996
		public const int SlotIndexFieldNumber = 2;

		// Token: 0x0400658D RID: 25997
		private int slotIndex_;

		// Token: 0x0400658E RID: 25998
		public const int HandCardNumFieldNumber = 3;

		// Token: 0x0400658F RID: 25999
		private int handCardNum_;
	}
}
