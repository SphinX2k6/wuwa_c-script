using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B58 RID: 2904
	public sealed class NpcPhantomBattleBackSlotCardLibrary : IMessage<NpcPhantomBattleBackSlotCardLibrary>, IMessage, IEquatable<NpcPhantomBattleBackSlotCardLibrary>, IDeepCloneable<NpcPhantomBattleBackSlotCardLibrary>, IBufferMessage
	{
		// Token: 0x0600FBF6 RID: 64502 RVA: 0x0024B742 File Offset: 0x00249942
		[NullableContext(1)]
		public static NpcPhantomBattleBackSlotCardLibrary Create()
		{
			return new NpcPhantomBattleBackSlotCardLibrary();
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600FBF7 RID: 64503 RVA: 0x0024B749 File Offset: 0x00249949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600FBF8 RID: 64504 RVA: 0x0024B74C File Offset: 0x0024994C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleBackSlotCardLibrary.Descriptor;
			}
		}

		// Token: 0x0600FBF9 RID: 64505 RVA: 0x0024B753 File Offset: 0x00249953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackSlotCardLibrary()
		{
		}

		// Token: 0x0600FBFA RID: 64506 RVA: 0x0024B75B File Offset: 0x0024995B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackSlotCardLibrary(NpcPhantomBattleBackSlotCardLibrary other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBFB RID: 64507 RVA: 0x0024B78C File Offset: 0x0024998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackSlotCardLibrary Clone()
		{
			return new NpcPhantomBattleBackSlotCardLibrary(this);
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600FBFC RID: 64508 RVA: 0x0024B794 File Offset: 0x00249994
		// (set) Token: 0x0600FBFD RID: 64509 RVA: 0x0024B79C File Offset: 0x0024999C
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

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600FBFE RID: 64510 RVA: 0x0024B7A5 File Offset: 0x002499A5
		// (set) Token: 0x0600FBFF RID: 64511 RVA: 0x0024B7AD File Offset: 0x002499AD
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

		// Token: 0x0600FC00 RID: 64512 RVA: 0x0024B7B6 File Offset: 0x002499B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleBackSlotCardLibrary);
		}

		// Token: 0x0600FC01 RID: 64513 RVA: 0x0024B7C4 File Offset: 0x002499C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleBackSlotCardLibrary other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC02 RID: 64514 RVA: 0x0024B804 File Offset: 0x00249A04
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

		// Token: 0x0600FC03 RID: 64515 RVA: 0x0024B85C File Offset: 0x00249A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC04 RID: 64516 RVA: 0x0024B869 File Offset: 0x00249A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC05 RID: 64517 RVA: 0x0024B874 File Offset: 0x00249A74
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

		// Token: 0x0600FC06 RID: 64518 RVA: 0x0024B8CC File Offset: 0x00249ACC
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

		// Token: 0x0600FC07 RID: 64519 RVA: 0x0024B924 File Offset: 0x00249B24
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

		// Token: 0x0600FC08 RID: 64520 RVA: 0x0024B974 File Offset: 0x00249B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC09 RID: 64521 RVA: 0x0024B980 File Offset: 0x00249B80
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

		// Token: 0x040064FB RID: 25851
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064FC RID: 25852
		public const int CardUIdFieldNumber = 1;

		// Token: 0x040064FD RID: 25853
		private int cardUId_;

		// Token: 0x040064FE RID: 25854
		public const int CurCardLibraryNumFieldNumber = 2;

		// Token: 0x040064FF RID: 25855
		private int curCardLibraryNum_;
	}
}
