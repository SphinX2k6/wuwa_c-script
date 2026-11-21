using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000387 RID: 903
	public sealed class DangoIdToDiceNum : IMessage<DangoIdToDiceNum>, IMessage, IEquatable<DangoIdToDiceNum>, IDeepCloneable<DangoIdToDiceNum>, IBufferMessage
	{
		// Token: 0x06005999 RID: 22937 RVA: 0x000DA6E5 File Offset: 0x000D88E5
		[NullableContext(1)]
		public static DangoIdToDiceNum Create()
		{
			return new DangoIdToDiceNum();
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x0600599A RID: 22938 RVA: 0x000DA6EC File Offset: 0x000D88EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoIdToDiceNum> Parser
		{
			get
			{
				return DangoIdToDiceNum._parser;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x0600599B RID: 22939 RVA: 0x000DA6F3 File Offset: 0x000D88F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600599C RID: 22940 RVA: 0x000DA6F6 File Offset: 0x000D88F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoIdToDiceNum.Descriptor;
			}
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x000DA6FD File Offset: 0x000D88FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoIdToDiceNum()
		{
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x000DA705 File Offset: 0x000D8905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoIdToDiceNum(DangoIdToDiceNum other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.num_ = other.num_;
			this.diceId_ = other.diceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x000DA742 File Offset: 0x000D8942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoIdToDiceNum Clone()
		{
			return new DangoIdToDiceNum(this);
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x000DA74A File Offset: 0x000D894A
		// (set) Token: 0x060059A1 RID: 22945 RVA: 0x000DA752 File Offset: 0x000D8952
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

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060059A2 RID: 22946 RVA: 0x000DA75B File Offset: 0x000D895B
		// (set) Token: 0x060059A3 RID: 22947 RVA: 0x000DA763 File Offset: 0x000D8963
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

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060059A4 RID: 22948 RVA: 0x000DA76C File Offset: 0x000D896C
		// (set) Token: 0x060059A5 RID: 22949 RVA: 0x000DA774 File Offset: 0x000D8974
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

		// Token: 0x060059A6 RID: 22950 RVA: 0x000DA77D File Offset: 0x000D897D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoIdToDiceNum);
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x000DA78C File Offset: 0x000D898C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoIdToDiceNum other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.Num == other.Num && this.DiceId == other.DiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x000DA7E8 File Offset: 0x000D89E8
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

		// Token: 0x060059A9 RID: 22953 RVA: 0x000DA859 File Offset: 0x000D8A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x000DA866 File Offset: 0x000D8A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x000DA870 File Offset: 0x000D8A70
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

		// Token: 0x060059AC RID: 22956 RVA: 0x000DA8E4 File Offset: 0x000D8AE4
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

		// Token: 0x060059AD RID: 22957 RVA: 0x000DA954 File Offset: 0x000D8B54
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

		// Token: 0x060059AE RID: 22958 RVA: 0x000DA9B8 File Offset: 0x000D8BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x000DA9C4 File Offset: 0x000D8BC4
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

		// Token: 0x040035BB RID: 13755
		private static readonly MessageParser<DangoIdToDiceNum> _parser = new MessageParser<DangoIdToDiceNum>(() => new DangoIdToDiceNum());

		// Token: 0x040035BC RID: 13756
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035BD RID: 13757
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040035BE RID: 13758
		private int dangoId_;

		// Token: 0x040035BF RID: 13759
		public const int NumFieldNumber = 2;

		// Token: 0x040035C0 RID: 13760
		private int num_;

		// Token: 0x040035C1 RID: 13761
		public const int DiceIdFieldNumber = 3;

		// Token: 0x040035C2 RID: 13762
		private int diceId_;
	}
}
