using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B67 RID: 2919
	public sealed class NpcPhantomBattleSlotInsteadInfo : IMessage<NpcPhantomBattleSlotInsteadInfo>, IMessage, IEquatable<NpcPhantomBattleSlotInsteadInfo>, IDeepCloneable<NpcPhantomBattleSlotInsteadInfo>, IBufferMessage
	{
		// Token: 0x0600FD66 RID: 64870 RVA: 0x0024FD82 File Offset: 0x0024DF82
		[NullableContext(1)]
		public static NpcPhantomBattleSlotInsteadInfo Create()
		{
			return new NpcPhantomBattleSlotInsteadInfo();
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600FD67 RID: 64871 RVA: 0x0024FD89 File Offset: 0x0024DF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600FD68 RID: 64872 RVA: 0x0024FD8C File Offset: 0x0024DF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleSlotInsteadInfo.Descriptor;
			}
		}

		// Token: 0x0600FD69 RID: 64873 RVA: 0x0024FD93 File Offset: 0x0024DF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleSlotInsteadInfo()
		{
		}

		// Token: 0x0600FD6A RID: 64874 RVA: 0x0024FD9B File Offset: 0x0024DF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleSlotInsteadInfo(NpcPhantomBattleSlotInsteadInfo other) : this()
		{
			this.slotIndexA_ = other.slotIndexA_;
			this.slotIndexB_ = other.slotIndexB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD6B RID: 64875 RVA: 0x0024FDCC File Offset: 0x0024DFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleSlotInsteadInfo Clone()
		{
			return new NpcPhantomBattleSlotInsteadInfo(this);
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600FD6C RID: 64876 RVA: 0x0024FDD4 File Offset: 0x0024DFD4
		// (set) Token: 0x0600FD6D RID: 64877 RVA: 0x0024FDDC File Offset: 0x0024DFDC
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

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600FD6E RID: 64878 RVA: 0x0024FDE5 File Offset: 0x0024DFE5
		// (set) Token: 0x0600FD6F RID: 64879 RVA: 0x0024FDED File Offset: 0x0024DFED
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

		// Token: 0x0600FD70 RID: 64880 RVA: 0x0024FDF6 File Offset: 0x0024DFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleSlotInsteadInfo);
		}

		// Token: 0x0600FD71 RID: 64881 RVA: 0x0024FE04 File Offset: 0x0024E004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleSlotInsteadInfo other)
		{
			return other != null && (other == this || (this.SlotIndexA == other.SlotIndexA && this.SlotIndexB == other.SlotIndexB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD72 RID: 64882 RVA: 0x0024FE44 File Offset: 0x0024E044
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

		// Token: 0x0600FD73 RID: 64883 RVA: 0x0024FE9C File Offset: 0x0024E09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD74 RID: 64884 RVA: 0x0024FEA9 File Offset: 0x0024E0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD75 RID: 64885 RVA: 0x0024FEB4 File Offset: 0x0024E0B4
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

		// Token: 0x0600FD76 RID: 64886 RVA: 0x0024FF0C File Offset: 0x0024E10C
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

		// Token: 0x0600FD77 RID: 64887 RVA: 0x0024FF64 File Offset: 0x0024E164
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

		// Token: 0x0600FD78 RID: 64888 RVA: 0x0024FFB4 File Offset: 0x0024E1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD79 RID: 64889 RVA: 0x0024FFC0 File Offset: 0x0024E1C0
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

		// Token: 0x0400657D RID: 25981
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400657E RID: 25982
		public const int SlotIndexAFieldNumber = 1;

		// Token: 0x0400657F RID: 25983
		private int slotIndexA_;

		// Token: 0x04006580 RID: 25984
		public const int SlotIndexBFieldNumber = 2;

		// Token: 0x04006581 RID: 25985
		private int slotIndexB_;
	}
}
