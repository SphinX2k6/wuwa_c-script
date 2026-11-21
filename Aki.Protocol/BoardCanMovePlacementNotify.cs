using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B9 RID: 441
	[NetMessage(EMessageId.BoardCanMovePlacementNotify)]
	public sealed class BoardCanMovePlacementNotify : IMessage<BoardCanMovePlacementNotify>, IMessage, IEquatable<BoardCanMovePlacementNotify>, IDeepCloneable<BoardCanMovePlacementNotify>, IBufferMessage
	{
		// Token: 0x06003348 RID: 13128 RVA: 0x0008220F File Offset: 0x0008040F
		[NullableContext(1)]
		public static BoardCanMovePlacementNotify Create()
		{
			return new BoardCanMovePlacementNotify();
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x00082216 File Offset: 0x00080416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600334A RID: 13130 RVA: 0x00082219 File Offset: 0x00080419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardCanMovePlacementNotify.Descriptor;
			}
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00082220 File Offset: 0x00080420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardCanMovePlacementNotify()
		{
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00082228 File Offset: 0x00080428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardCanMovePlacementNotify(BoardCanMovePlacementNotify other) : this()
		{
			this.boardEntityId_ = other.boardEntityId_;
			this.canMove_ = other.canMove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00082259 File Offset: 0x00080459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardCanMovePlacementNotify Clone()
		{
			return new BoardCanMovePlacementNotify(this);
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600334E RID: 13134 RVA: 0x00082261 File Offset: 0x00080461
		// (set) Token: 0x0600334F RID: 13135 RVA: 0x00082269 File Offset: 0x00080469
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

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06003350 RID: 13136 RVA: 0x00082272 File Offset: 0x00080472
		// (set) Token: 0x06003351 RID: 13137 RVA: 0x0008227A File Offset: 0x0008047A
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

		// Token: 0x06003352 RID: 13138 RVA: 0x00082283 File Offset: 0x00080483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardCanMovePlacementNotify);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x00082291 File Offset: 0x00080491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardCanMovePlacementNotify other)
		{
			return other != null && (other == this || (this.BoardEntityId == other.BoardEntityId && this.CanMove == other.CanMove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000822D0 File Offset: 0x000804D0
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

		// Token: 0x06003355 RID: 13141 RVA: 0x00082328 File Offset: 0x00080528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x00082335 File Offset: 0x00080535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x00082340 File Offset: 0x00080540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.BoardEntityId);
			}
			if (this.CanMove)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.CanMove);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x0008239C File Offset: 0x0008059C
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

		// Token: 0x06003359 RID: 13145 RVA: 0x000823E8 File Offset: 0x000805E8
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

		// Token: 0x0600335A RID: 13146 RVA: 0x00082438 File Offset: 0x00080638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00082444 File Offset: 0x00080644
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
				if (num != 96U)
				{
					if (num != 112U)
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

		// Token: 0x04002A04 RID: 10756
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A05 RID: 10757
		public const int BoardEntityIdFieldNumber = 12;

		// Token: 0x04002A06 RID: 10758
		private long boardEntityId_;

		// Token: 0x04002A07 RID: 10759
		public const int CanMoveFieldNumber = 14;

		// Token: 0x04002A08 RID: 10760
		private bool canMove_;
	}
}
