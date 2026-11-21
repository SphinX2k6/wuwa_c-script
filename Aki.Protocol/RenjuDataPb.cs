using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F06 RID: 3846
	public sealed class RenjuDataPb : IMessage<RenjuDataPb>, IMessage, IEquatable<RenjuDataPb>, IDeepCloneable<RenjuDataPb>, IBufferMessage
	{
		// Token: 0x060149E5 RID: 84453 RVA: 0x002FEC27 File Offset: 0x002FCE27
		[NullableContext(1)]
		public static RenjuDataPb Create()
		{
			return new RenjuDataPb();
		}

		// Token: 0x1700448E RID: 17550
		// (get) Token: 0x060149E6 RID: 84454 RVA: 0x002FEC2E File Offset: 0x002FCE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700448F RID: 17551
		// (get) Token: 0x060149E7 RID: 84455 RVA: 0x002FEC31 File Offset: 0x002FCE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuDataPb.Descriptor;
			}
		}

		// Token: 0x060149E8 RID: 84456 RVA: 0x002FEC38 File Offset: 0x002FCE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuDataPb()
		{
		}

		// Token: 0x060149E9 RID: 84457 RVA: 0x002FEC40 File Offset: 0x002FCE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuDataPb(RenjuDataPb other) : this()
		{
			this.moveCount_ = other.moveCount_;
			this.lastMoveEntityConfigId_ = other.lastMoveEntityConfigId_;
			this.winner_ = other.winner_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149EA RID: 84458 RVA: 0x002FEC7D File Offset: 0x002FCE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuDataPb Clone()
		{
			return new RenjuDataPb(this);
		}

		// Token: 0x17004490 RID: 17552
		// (get) Token: 0x060149EB RID: 84459 RVA: 0x002FEC85 File Offset: 0x002FCE85
		// (set) Token: 0x060149EC RID: 84460 RVA: 0x002FEC8D File Offset: 0x002FCE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveCount
		{
			get
			{
				return this.moveCount_;
			}
			set
			{
				this.moveCount_ = value;
			}
		}

		// Token: 0x17004491 RID: 17553
		// (get) Token: 0x060149ED RID: 84461 RVA: 0x002FEC96 File Offset: 0x002FCE96
		// (set) Token: 0x060149EE RID: 84462 RVA: 0x002FEC9E File Offset: 0x002FCE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastMoveEntityConfigId
		{
			get
			{
				return this.lastMoveEntityConfigId_;
			}
			set
			{
				this.lastMoveEntityConfigId_ = value;
			}
		}

		// Token: 0x17004492 RID: 17554
		// (get) Token: 0x060149EF RID: 84463 RVA: 0x002FECA7 File Offset: 0x002FCEA7
		// (set) Token: 0x060149F0 RID: 84464 RVA: 0x002FECAF File Offset: 0x002FCEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Winner
		{
			get
			{
				return this.winner_;
			}
			set
			{
				this.winner_ = value;
			}
		}

		// Token: 0x060149F1 RID: 84465 RVA: 0x002FECB8 File Offset: 0x002FCEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuDataPb);
		}

		// Token: 0x060149F2 RID: 84466 RVA: 0x002FECC8 File Offset: 0x002FCEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuDataPb other)
		{
			return other != null && (other == this || (this.MoveCount == other.MoveCount && this.LastMoveEntityConfigId == other.LastMoveEntityConfigId && this.Winner == other.Winner && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149F3 RID: 84467 RVA: 0x002FED24 File Offset: 0x002FCF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MoveCount != 0)
			{
				num ^= this.MoveCount.GetHashCode();
			}
			if (this.LastMoveEntityConfigId != 0)
			{
				num ^= this.LastMoveEntityConfigId.GetHashCode();
			}
			if (this.Winner != 0)
			{
				num ^= this.Winner.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060149F4 RID: 84468 RVA: 0x002FED95 File Offset: 0x002FCF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149F5 RID: 84469 RVA: 0x002FEDA2 File Offset: 0x002FCFA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149F6 RID: 84470 RVA: 0x002FEDAC File Offset: 0x002FCFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoveCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MoveCount);
			}
			if (this.LastMoveEntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LastMoveEntityConfigId);
			}
			if (this.Winner != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Winner);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060149F7 RID: 84471 RVA: 0x002FEE20 File Offset: 0x002FD020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MoveCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveCount);
			}
			if (this.LastMoveEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastMoveEntityConfigId);
			}
			if (this.Winner != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Winner);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060149F8 RID: 84472 RVA: 0x002FEE90 File Offset: 0x002FD090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MoveCount != 0)
			{
				this.MoveCount = other.MoveCount;
			}
			if (other.LastMoveEntityConfigId != 0)
			{
				this.LastMoveEntityConfigId = other.LastMoveEntityConfigId;
			}
			if (other.Winner != 0)
			{
				this.Winner = other.Winner;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060149F9 RID: 84473 RVA: 0x002FEEF4 File Offset: 0x002FD0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149FA RID: 84474 RVA: 0x002FEF00 File Offset: 0x002FD100
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
							this.Winner = input.ReadInt32();
						}
					}
					else
					{
						this.LastMoveEntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.MoveCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D29 RID: 32041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D2A RID: 32042
		public const int MoveCountFieldNumber = 1;

		// Token: 0x04007D2B RID: 32043
		private int moveCount_;

		// Token: 0x04007D2C RID: 32044
		public const int LastMoveEntityConfigIdFieldNumber = 2;

		// Token: 0x04007D2D RID: 32045
		private int lastMoveEntityConfigId_;

		// Token: 0x04007D2E RID: 32046
		public const int WinnerFieldNumber = 3;

		// Token: 0x04007D2F RID: 32047
		private int winner_;
	}
}
