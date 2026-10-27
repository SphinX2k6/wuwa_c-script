using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B5 RID: 437
	[NetMessage(EMessageId.BoardCanMovePlacementNotify)]
	public sealed class BoardCanMovePlacementNotify : IMessage<BoardCanMovePlacementNotify>, IMessage, IEquatable<BoardCanMovePlacementNotify>, IDeepCloneable<BoardCanMovePlacementNotify>, IBufferMessage
	{
		// Token: 0x060032BB RID: 12987 RVA: 0x00080AA3 File Offset: 0x0007ECA3
		[NullableContext(1)]
		public static BoardCanMovePlacementNotify Create()
		{
			return new BoardCanMovePlacementNotify();
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x00080AAA File Offset: 0x0007ECAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060032BD RID: 12989 RVA: 0x00080AAD File Offset: 0x0007ECAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardCanMovePlacementNotify.Descriptor;
			}
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x00080AB4 File Offset: 0x0007ECB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardCanMovePlacementNotify()
		{
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x00080ABC File Offset: 0x0007ECBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardCanMovePlacementNotify(BoardCanMovePlacementNotify other) : this()
		{
			this.boardEntityId_ = other.boardEntityId_;
			this.canMove_ = other.canMove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00080AED File Offset: 0x0007ECED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardCanMovePlacementNotify Clone()
		{
			return new BoardCanMovePlacementNotify(this);
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x00080AF5 File Offset: 0x0007ECF5
		// (set) Token: 0x060032C2 RID: 12994 RVA: 0x00080AFD File Offset: 0x0007ECFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BoardEntityId
		{
			get
			{
				return this.boardEntityId_;
			}
			set
			{
				this.boardEntityId_ = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060032C3 RID: 12995 RVA: 0x00080B06 File Offset: 0x0007ED06
		// (set) Token: 0x060032C4 RID: 12996 RVA: 0x00080B0E File Offset: 0x0007ED0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanMove
		{
			get
			{
				return this.canMove_;
			}
			set
			{
				this.canMove_ = value;
			}
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00080B17 File Offset: 0x0007ED17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardCanMovePlacementNotify);
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00080B25 File Offset: 0x0007ED25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardCanMovePlacementNotify other)
		{
			return other != null && (other == this || (this.BoardEntityId == other.BoardEntityId && this.CanMove == other.CanMove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00080B64 File Offset: 0x0007ED64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BoardEntityId != 0L)
			{
				num ^= this.BoardEntityId.GetHashCode();
			}
			if (this.CanMove)
			{
				num ^= this.CanMove.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00080BBC File Offset: 0x0007EDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x00080BC9 File Offset: 0x0007EDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x00080BD4 File Offset: 0x0007EDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BoardEntityId);
			}
			if (this.CanMove)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.CanMove);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x00080C2C File Offset: 0x0007EE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BoardEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BoardEntityId);
			}
			if (this.CanMove)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x00080C78 File Offset: 0x0007EE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoardCanMovePlacementNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BoardEntityId != 0L)
			{
				this.BoardEntityId = other.BoardEntityId;
			}
			if (other.CanMove)
			{
				this.CanMove = other.CanMove;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00080CC8 File Offset: 0x0007EEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00080CD4 File Offset: 0x0007EED4
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CanMove = input.ReadBool();
					}
				}
				else
				{
					this.BoardEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002989 RID: 10633
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400298A RID: 10634
		public const int BoardEntityIdFieldNumber = 1;

		// Token: 0x0400298B RID: 10635
		private long boardEntityId_;

		// Token: 0x0400298C RID: 10636
		public const int CanMoveFieldNumber = 7;

		// Token: 0x0400298D RID: 10637
		private bool canMove_;
	}
}
