using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000207 RID: 519
	public sealed class BuffSelection : IMessage<BuffSelection>, IMessage, IEquatable<BuffSelection>, IDeepCloneable<BuffSelection>, IBufferMessage
	{
		// Token: 0x06003943 RID: 14659 RVA: 0x0008EC6C File Offset: 0x0008CE6C
		[NullableContext(1)]
		public static BuffSelection Create()
		{
			return new BuffSelection();
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06003944 RID: 14660 RVA: 0x0008EC73 File Offset: 0x0008CE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuffSelection> Parser
		{
			get
			{
				return BuffSelection._parser;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x0008EC7A File Offset: 0x0008CE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x0008EC7D File Offset: 0x0008CE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffSelection.Descriptor;
			}
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x0008EC84 File Offset: 0x0008CE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffSelection()
		{
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x0008EC8C File Offset: 0x0008CE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffSelection(BuffSelection other) : this()
		{
			this.buffId_ = other.buffId_;
			this.slot_ = other.slot_;
			this.buffSelectionStatus_ = other.buffSelectionStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x0008ECC9 File Offset: 0x0008CEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffSelection Clone()
		{
			return new BuffSelection(this);
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x0008ECD1 File Offset: 0x0008CED1
		// (set) Token: 0x0600394B RID: 14667 RVA: 0x0008ECD9 File Offset: 0x0008CED9
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

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x0008ECE2 File Offset: 0x0008CEE2
		// (set) Token: 0x0600394D RID: 14669 RVA: 0x0008ECEA File Offset: 0x0008CEEA
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

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x0008ECF3 File Offset: 0x0008CEF3
		// (set) Token: 0x0600394F RID: 14671 RVA: 0x0008ECFB File Offset: 0x0008CEFB
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

		// Token: 0x06003950 RID: 14672 RVA: 0x0008ED04 File Offset: 0x0008CF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffSelection);
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x0008ED14 File Offset: 0x0008CF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffSelection other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.Slot == other.Slot && this.BuffSelectionStatus == other.BuffSelectionStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0008ED70 File Offset: 0x0008CF70
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

		// Token: 0x06003953 RID: 14675 RVA: 0x0008EDE7 File Offset: 0x0008CFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0008EDF4 File Offset: 0x0008CFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x0008EE00 File Offset: 0x0008D000
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

		// Token: 0x06003956 RID: 14678 RVA: 0x0008EE74 File Offset: 0x0008D074
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

		// Token: 0x06003957 RID: 14679 RVA: 0x0008EEE4 File Offset: 0x0008D0E4
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

		// Token: 0x06003958 RID: 14680 RVA: 0x0008EF48 File Offset: 0x0008D148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0008EF54 File Offset: 0x0008D154
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

		// Token: 0x04002B6E RID: 11118
		private static readonly MessageParser<BuffSelection> _parser = new MessageParser<BuffSelection>(() => new BuffSelection());

		// Token: 0x04002B6F RID: 11119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B70 RID: 11120
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04002B71 RID: 11121
		private int buffId_;

		// Token: 0x04002B72 RID: 11122
		public const int SlotFieldNumber = 2;

		// Token: 0x04002B73 RID: 11123
		private int slot_;

		// Token: 0x04002B74 RID: 11124
		public const int BuffSelectionStatusFieldNumber = 3;

		// Token: 0x04002B75 RID: 11125
		private BossRushBuffSelectionStatus buffSelectionStatus_;
	}
}
