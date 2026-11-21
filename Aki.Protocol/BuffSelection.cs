using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020C RID: 524
	public sealed class BuffSelection : IMessage<BuffSelection>, IMessage, IEquatable<BuffSelection>, IDeepCloneable<BuffSelection>, IBufferMessage
	{
		// Token: 0x060039E8 RID: 14824 RVA: 0x0009087C File Offset: 0x0008EA7C
		[NullableContext(1)]
		public static BuffSelection Create()
		{
			return new BuffSelection();
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060039E9 RID: 14825 RVA: 0x00090883 File Offset: 0x0008EA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuffSelection> Parser
		{
			get
			{
				return BuffSelection._parser;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x0009088A File Offset: 0x0008EA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060039EB RID: 14827 RVA: 0x0009088D File Offset: 0x0008EA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffSelection.Descriptor;
			}
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x00090894 File Offset: 0x0008EA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffSelection()
		{
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x0009089C File Offset: 0x0008EA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffSelection(BuffSelection other) : this()
		{
			this.buffId_ = other.buffId_;
			this.slot_ = other.slot_;
			this.buffSelectionStatus_ = other.buffSelectionStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x000908D9 File Offset: 0x0008EAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffSelection Clone()
		{
			return new BuffSelection(this);
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060039EF RID: 14831 RVA: 0x000908E1 File Offset: 0x0008EAE1
		// (set) Token: 0x060039F0 RID: 14832 RVA: 0x000908E9 File Offset: 0x0008EAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060039F1 RID: 14833 RVA: 0x000908F2 File Offset: 0x0008EAF2
		// (set) Token: 0x060039F2 RID: 14834 RVA: 0x000908FA File Offset: 0x0008EAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Slot
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

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x00090903 File Offset: 0x0008EB03
		// (set) Token: 0x060039F4 RID: 14836 RVA: 0x0009090B File Offset: 0x0008EB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffSelectionStatus BuffSelectionStatus
		{
			get
			{
				return this.buffSelectionStatus_;
			}
			set
			{
				this.buffSelectionStatus_ = value;
			}
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x00090914 File Offset: 0x0008EB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffSelection);
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00090924 File Offset: 0x0008EB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffSelection other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.Slot == other.Slot && this.BuffSelectionStatus == other.BuffSelectionStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x00090980 File Offset: 0x0008EB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.Slot != 0)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.BuffSelectionStatus != BossRushBuffSelectionStatus.BuffEmpty)
			{
				num ^= this.BuffSelectionStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x000909F7 File Offset: 0x0008EBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00090A04 File Offset: 0x0008EC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00090A10 File Offset: 0x0008EC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffId);
			}
			if (this.Slot != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Slot);
			}
			if (this.BuffSelectionStatus != BossRushBuffSelectionStatus.BuffEmpty)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.BuffSelectionStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x00090A84 File Offset: 0x0008EC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffId);
			}
			if (this.Slot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Slot);
			}
			if (this.BuffSelectionStatus != BossRushBuffSelectionStatus.BuffEmpty)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BuffSelectionStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00090AF4 File Offset: 0x0008ECF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffSelection other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0)
			{
				this.BuffId = other.BuffId;
			}
			if (other.Slot != 0)
			{
				this.Slot = other.Slot;
			}
			if (other.BuffSelectionStatus != BossRushBuffSelectionStatus.BuffEmpty)
			{
				this.BuffSelectionStatus = other.BuffSelectionStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x00090B58 File Offset: 0x0008ED58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x00090B64 File Offset: 0x0008ED64
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
							this.BuffSelectionStatus = (BossRushBuffSelectionStatus)input.ReadEnum();
						}
					}
					else
					{
						this.Slot = input.ReadInt32();
					}
				}
				else
				{
					this.BuffId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BF0 RID: 11248
		private static readonly MessageParser<BuffSelection> _parser = new MessageParser<BuffSelection>(() => new BuffSelection());

		// Token: 0x04002BF1 RID: 11249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BF2 RID: 11250
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04002BF3 RID: 11251
		private int buffId_;

		// Token: 0x04002BF4 RID: 11252
		public const int SlotFieldNumber = 2;

		// Token: 0x04002BF5 RID: 11253
		private int slot_;

		// Token: 0x04002BF6 RID: 11254
		public const int BuffSelectionStatusFieldNumber = 3;

		// Token: 0x04002BF7 RID: 11255
		private BossRushBuffSelectionStatus buffSelectionStatus_;
	}
}
