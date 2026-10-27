using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B79 RID: 2937
	public sealed class NpcPhantomLeaveSlot : IMessage<NpcPhantomLeaveSlot>, IMessage, IEquatable<NpcPhantomLeaveSlot>, IDeepCloneable<NpcPhantomLeaveSlot>, IBufferMessage
	{
		// Token: 0x0600FE94 RID: 65172 RVA: 0x0025222A File Offset: 0x0025042A
		[NullableContext(1)]
		public static NpcPhantomLeaveSlot Create()
		{
			return new NpcPhantomLeaveSlot();
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600FE95 RID: 65173 RVA: 0x00252231 File Offset: 0x00250431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600FE96 RID: 65174 RVA: 0x00252234 File Offset: 0x00250434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomLeaveSlot.Descriptor;
			}
		}

		// Token: 0x0600FE97 RID: 65175 RVA: 0x0025223B File Offset: 0x0025043B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomLeaveSlot()
		{
		}

		// Token: 0x0600FE98 RID: 65176 RVA: 0x00252243 File Offset: 0x00250443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomLeaveSlot(NpcPhantomLeaveSlot other) : this()
		{
			this.fighterUId_ = other.fighterUId_;
			this.slotIndex_ = other.slotIndex_;
			this.handCardNum_ = other.handCardNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE99 RID: 65177 RVA: 0x00252280 File Offset: 0x00250480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomLeaveSlot Clone()
		{
			return new NpcPhantomLeaveSlot(this);
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600FE9A RID: 65178 RVA: 0x00252288 File Offset: 0x00250488
		// (set) Token: 0x0600FE9B RID: 65179 RVA: 0x00252290 File Offset: 0x00250490
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

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600FE9C RID: 65180 RVA: 0x00252299 File Offset: 0x00250499
		// (set) Token: 0x0600FE9D RID: 65181 RVA: 0x002522A1 File Offset: 0x002504A1
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

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600FE9E RID: 65182 RVA: 0x002522AA File Offset: 0x002504AA
		// (set) Token: 0x0600FE9F RID: 65183 RVA: 0x002522B2 File Offset: 0x002504B2
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

		// Token: 0x0600FEA0 RID: 65184 RVA: 0x002522BB File Offset: 0x002504BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomLeaveSlot);
		}

		// Token: 0x0600FEA1 RID: 65185 RVA: 0x002522CC File Offset: 0x002504CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomLeaveSlot other)
		{
			return other != null && (other == this || (this.FighterUId == other.FighterUId && this.SlotIndex == other.SlotIndex && this.HandCardNum == other.HandCardNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FEA2 RID: 65186 RVA: 0x00252328 File Offset: 0x00250528
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

		// Token: 0x0600FEA3 RID: 65187 RVA: 0x00252399 File Offset: 0x00250599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FEA4 RID: 65188 RVA: 0x002523A6 File Offset: 0x002505A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FEA5 RID: 65189 RVA: 0x002523B0 File Offset: 0x002505B0
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

		// Token: 0x0600FEA6 RID: 65190 RVA: 0x00252424 File Offset: 0x00250624
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

		// Token: 0x0600FEA7 RID: 65191 RVA: 0x00252494 File Offset: 0x00250694
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

		// Token: 0x0600FEA8 RID: 65192 RVA: 0x002524F8 File Offset: 0x002506F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FEA9 RID: 65193 RVA: 0x00252504 File Offset: 0x00250704
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

		// Token: 0x04006579 RID: 25977
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400657A RID: 25978
		public const int FighterUIdFieldNumber = 1;

		// Token: 0x0400657B RID: 25979
		private int fighterUId_;

		// Token: 0x0400657C RID: 25980
		public const int SlotIndexFieldNumber = 2;

		// Token: 0x0400657D RID: 25981
		private int slotIndex_;

		// Token: 0x0400657E RID: 25982
		public const int HandCardNumFieldNumber = 3;

		// Token: 0x0400657F RID: 25983
		private int handCardNum_;
	}
}
