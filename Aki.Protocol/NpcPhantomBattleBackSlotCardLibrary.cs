using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B68 RID: 2920
	public sealed class NpcPhantomBattleBackSlotCardLibrary : IMessage<NpcPhantomBattleBackSlotCardLibrary>, IMessage, IEquatable<NpcPhantomBattleBackSlotCardLibrary>, IDeepCloneable<NpcPhantomBattleBackSlotCardLibrary>, IBufferMessage
	{
		// Token: 0x0600FCFA RID: 64762 RVA: 0x0024D612 File Offset: 0x0024B812
		[NullableContext(1)]
		public static NpcPhantomBattleBackSlotCardLibrary Create()
		{
			return new NpcPhantomBattleBackSlotCardLibrary();
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600FCFB RID: 64763 RVA: 0x0024D619 File Offset: 0x0024B819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600FCFC RID: 64764 RVA: 0x0024D61C File Offset: 0x0024B81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleBackSlotCardLibrary.Descriptor;
			}
		}

		// Token: 0x0600FCFD RID: 64765 RVA: 0x0024D623 File Offset: 0x0024B823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackSlotCardLibrary()
		{
		}

		// Token: 0x0600FCFE RID: 64766 RVA: 0x0024D62B File Offset: 0x0024B82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackSlotCardLibrary(NpcPhantomBattleBackSlotCardLibrary other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FCFF RID: 64767 RVA: 0x0024D65C File Offset: 0x0024B85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackSlotCardLibrary Clone()
		{
			return new NpcPhantomBattleBackSlotCardLibrary(this);
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600FD00 RID: 64768 RVA: 0x0024D664 File Offset: 0x0024B864
		// (set) Token: 0x0600FD01 RID: 64769 RVA: 0x0024D66C File Offset: 0x0024B86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600FD02 RID: 64770 RVA: 0x0024D675 File Offset: 0x0024B875
		// (set) Token: 0x0600FD03 RID: 64771 RVA: 0x0024D67D File Offset: 0x0024B87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x0600FD04 RID: 64772 RVA: 0x0024D686 File Offset: 0x0024B886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleBackSlotCardLibrary);
		}

		// Token: 0x0600FD05 RID: 64773 RVA: 0x0024D694 File Offset: 0x0024B894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleBackSlotCardLibrary other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD06 RID: 64774 RVA: 0x0024D6D4 File Offset: 0x0024B8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD07 RID: 64775 RVA: 0x0024D72C File Offset: 0x0024B92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD08 RID: 64776 RVA: 0x0024D739 File Offset: 0x0024B939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD09 RID: 64777 RVA: 0x0024D744 File Offset: 0x0024B944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUId);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FD0A RID: 64778 RVA: 0x0024D79C File Offset: 0x0024B99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FD0B RID: 64779 RVA: 0x0024D7F4 File Offset: 0x0024B9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleBackSlotCardLibrary other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FD0C RID: 64780 RVA: 0x0024D844 File Offset: 0x0024BA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD0D RID: 64781 RVA: 0x0024D850 File Offset: 0x0024BA50
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
						this.CurCardLibraryNum = input.ReadInt32();
					}
				}
				else
				{
					this.CardUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064EB RID: 25835
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064EC RID: 25836
		public const int CardUIdFieldNumber = 1;

		// Token: 0x040064ED RID: 25837
		private int cardUId_;

		// Token: 0x040064EE RID: 25838
		public const int CurCardLibraryNumFieldNumber = 2;

		// Token: 0x040064EF RID: 25839
		private int curCardLibraryNum_;
	}
}
