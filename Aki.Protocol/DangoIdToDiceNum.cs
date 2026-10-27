using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037F RID: 895
	public sealed class DangoIdToDiceNum : IMessage<DangoIdToDiceNum>, IMessage, IEquatable<DangoIdToDiceNum>, IDeepCloneable<DangoIdToDiceNum>, IBufferMessage
	{
		// Token: 0x060058AC RID: 22700 RVA: 0x000D805D File Offset: 0x000D625D
		[NullableContext(1)]
		public static DangoIdToDiceNum Create()
		{
			return new DangoIdToDiceNum();
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x060058AD RID: 22701 RVA: 0x000D8064 File Offset: 0x000D6264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoIdToDiceNum> Parser
		{
			get
			{
				return DangoIdToDiceNum._parser;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x060058AE RID: 22702 RVA: 0x000D806B File Offset: 0x000D626B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x060058AF RID: 22703 RVA: 0x000D806E File Offset: 0x000D626E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoIdToDiceNum.Descriptor;
			}
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x000D8075 File Offset: 0x000D6275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoIdToDiceNum()
		{
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x000D807D File Offset: 0x000D627D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoIdToDiceNum(DangoIdToDiceNum other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.num_ = other.num_;
			this.diceId_ = other.diceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x000D80BA File Offset: 0x000D62BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoIdToDiceNum Clone()
		{
			return new DangoIdToDiceNum(this);
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x060058B3 RID: 22707 RVA: 0x000D80C2 File Offset: 0x000D62C2
		// (set) Token: 0x060058B4 RID: 22708 RVA: 0x000D80CA File Offset: 0x000D62CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x060058B5 RID: 22709 RVA: 0x000D80D3 File Offset: 0x000D62D3
		// (set) Token: 0x060058B6 RID: 22710 RVA: 0x000D80DB File Offset: 0x000D62DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x060058B7 RID: 22711 RVA: 0x000D80E4 File Offset: 0x000D62E4
		// (set) Token: 0x060058B8 RID: 22712 RVA: 0x000D80EC File Offset: 0x000D62EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiceId
		{
			get
			{
				return this.diceId_;
			}
			set
			{
				this.diceId_ = value;
			}
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x000D80F5 File Offset: 0x000D62F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoIdToDiceNum);
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x000D8104 File Offset: 0x000D6304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoIdToDiceNum other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.Num == other.Num && this.DiceId == other.DiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x000D8160 File Offset: 0x000D6360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.DiceId != 0)
			{
				num ^= this.DiceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x000D81D1 File Offset: 0x000D63D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x000D81DE File Offset: 0x000D63DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x000D81E8 File Offset: 0x000D63E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.DiceId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DiceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x000D825C File Offset: 0x000D645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.DiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x000D82CC File Offset: 0x000D64CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoIdToDiceNum other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.DiceId != 0)
			{
				this.DiceId = other.DiceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x000D8330 File Offset: 0x000D6530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x000D833C File Offset: 0x000D653C
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
							this.DiceId = input.ReadInt32();
						}
					}
					else
					{
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400351F RID: 13599
		private static readonly MessageParser<DangoIdToDiceNum> _parser = new MessageParser<DangoIdToDiceNum>(() => new DangoIdToDiceNum());

		// Token: 0x04003520 RID: 13600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003521 RID: 13601
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04003522 RID: 13602
		private int dangoId_;

		// Token: 0x04003523 RID: 13603
		public const int NumFieldNumber = 2;

		// Token: 0x04003524 RID: 13604
		private int num_;

		// Token: 0x04003525 RID: 13605
		public const int DiceIdFieldNumber = 3;

		// Token: 0x04003526 RID: 13606
		private int diceId_;
	}
}
