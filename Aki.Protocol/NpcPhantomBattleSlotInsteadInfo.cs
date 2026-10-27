using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B77 RID: 2935
	public sealed class NpcPhantomBattleSlotInsteadInfo : IMessage<NpcPhantomBattleSlotInsteadInfo>, IMessage, IEquatable<NpcPhantomBattleSlotInsteadInfo>, IDeepCloneable<NpcPhantomBattleSlotInsteadInfo>, IBufferMessage
	{
		// Token: 0x0600FE6A RID: 65130 RVA: 0x00251C52 File Offset: 0x0024FE52
		[NullableContext(1)]
		public static NpcPhantomBattleSlotInsteadInfo Create()
		{
			return new NpcPhantomBattleSlotInsteadInfo();
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600FE6B RID: 65131 RVA: 0x00251C59 File Offset: 0x0024FE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600FE6C RID: 65132 RVA: 0x00251C5C File Offset: 0x0024FE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleSlotInsteadInfo.Descriptor;
			}
		}

		// Token: 0x0600FE6D RID: 65133 RVA: 0x00251C63 File Offset: 0x0024FE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleSlotInsteadInfo()
		{
		}

		// Token: 0x0600FE6E RID: 65134 RVA: 0x00251C6B File Offset: 0x0024FE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleSlotInsteadInfo(NpcPhantomBattleSlotInsteadInfo other) : this()
		{
			this.slotIndexA_ = other.slotIndexA_;
			this.slotIndexB_ = other.slotIndexB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE6F RID: 65135 RVA: 0x00251C9C File Offset: 0x0024FE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleSlotInsteadInfo Clone()
		{
			return new NpcPhantomBattleSlotInsteadInfo(this);
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600FE70 RID: 65136 RVA: 0x00251CA4 File Offset: 0x0024FEA4
		// (set) Token: 0x0600FE71 RID: 65137 RVA: 0x00251CAC File Offset: 0x0024FEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndexA
		{
			get
			{
				return this.slotIndexA_;
			}
			set
			{
				this.slotIndexA_ = value;
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600FE72 RID: 65138 RVA: 0x00251CB5 File Offset: 0x0024FEB5
		// (set) Token: 0x0600FE73 RID: 65139 RVA: 0x00251CBD File Offset: 0x0024FEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndexB
		{
			get
			{
				return this.slotIndexB_;
			}
			set
			{
				this.slotIndexB_ = value;
			}
		}

		// Token: 0x0600FE74 RID: 65140 RVA: 0x00251CC6 File Offset: 0x0024FEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleSlotInsteadInfo);
		}

		// Token: 0x0600FE75 RID: 65141 RVA: 0x00251CD4 File Offset: 0x0024FED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleSlotInsteadInfo other)
		{
			return other != null && (other == this || (this.SlotIndexA == other.SlotIndexA && this.SlotIndexB == other.SlotIndexB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE76 RID: 65142 RVA: 0x00251D14 File Offset: 0x0024FF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotIndexA != 0)
			{
				num ^= this.SlotIndexA.GetHashCode();
			}
			if (this.SlotIndexB != 0)
			{
				num ^= this.SlotIndexB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FE77 RID: 65143 RVA: 0x00251D6C File Offset: 0x0024FF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE78 RID: 65144 RVA: 0x00251D79 File Offset: 0x0024FF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE79 RID: 65145 RVA: 0x00251D84 File Offset: 0x0024FF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndexA != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotIndexA);
			}
			if (this.SlotIndexB != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SlotIndexB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FE7A RID: 65146 RVA: 0x00251DDC File Offset: 0x0024FFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotIndexA != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndexA);
			}
			if (this.SlotIndexB != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndexB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FE7B RID: 65147 RVA: 0x00251E34 File Offset: 0x00250034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleSlotInsteadInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotIndexA != 0)
			{
				this.SlotIndexA = other.SlotIndexA;
			}
			if (other.SlotIndexB != 0)
			{
				this.SlotIndexB = other.SlotIndexB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FE7C RID: 65148 RVA: 0x00251E84 File Offset: 0x00250084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE7D RID: 65149 RVA: 0x00251E90 File Offset: 0x00250090
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SlotIndexB = input.ReadInt32();
					}
				}
				else
				{
					this.SlotIndexA = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400656D RID: 25965
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400656E RID: 25966
		public const int SlotIndexAFieldNumber = 1;

		// Token: 0x0400656F RID: 25967
		private int slotIndexA_;

		// Token: 0x04006570 RID: 25968
		public const int SlotIndexBFieldNumber = 2;

		// Token: 0x04006571 RID: 25969
		private int slotIndexB_;
	}
}
