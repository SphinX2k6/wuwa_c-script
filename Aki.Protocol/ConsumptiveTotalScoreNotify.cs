using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F3 RID: 755
	[NetMessage(EMessageId.ConsumptiveTotalScoreNotify)]
	public sealed class ConsumptiveTotalScoreNotify : IMessage<ConsumptiveTotalScoreNotify>, IMessage, IEquatable<ConsumptiveTotalScoreNotify>, IDeepCloneable<ConsumptiveTotalScoreNotify>, IBufferMessage
	{
		// Token: 0x06004CD2 RID: 19666 RVA: 0x000BB4A2 File Offset: 0x000B96A2
		[NullableContext(1)]
		public static ConsumptiveTotalScoreNotify Create()
		{
			return new ConsumptiveTotalScoreNotify();
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06004CD3 RID: 19667 RVA: 0x000BB4A9 File Offset: 0x000B96A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x000BB4AC File Offset: 0x000B96AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTotalScoreNotify.Descriptor;
			}
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x000BB4B3 File Offset: 0x000B96B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTotalScoreNotify()
		{
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x000BB4BB File Offset: 0x000B96BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTotalScoreNotify(ConsumptiveTotalScoreNotify other) : this()
		{
			this.totalScore_ = other.totalScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CD7 RID: 19671 RVA: 0x000BB4E0 File Offset: 0x000B96E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTotalScoreNotify Clone()
		{
			return new ConsumptiveTotalScoreNotify(this);
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x000BB4E8 File Offset: 0x000B96E8
		// (set) Token: 0x06004CD9 RID: 19673 RVA: 0x000BB4F0 File Offset: 0x000B96F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalScore
		{
			get
			{
				return this.totalScore_;
			}
			set
			{
				this.totalScore_ = value;
			}
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x000BB4F9 File Offset: 0x000B96F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTotalScoreNotify);
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x000BB507 File Offset: 0x000B9707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTotalScoreNotify other)
		{
			return other != null && (other == this || (this.TotalScore == other.TotalScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x000BB538 File Offset: 0x000B9738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x000BB577 File Offset: 0x000B9777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x000BB584 File Offset: 0x000B9784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x000BB58D File Offset: 0x000B978D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x000BB5C0 File Offset: 0x000B97C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x000BB5FE File Offset: 0x000B97FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveTotalScoreNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x000BB62F File Offset: 0x000B982F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x000BB638 File Offset: 0x000B9838
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TotalScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003173 RID: 12659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003174 RID: 12660
		public const int TotalScoreFieldNumber = 8;

		// Token: 0x04003175 RID: 12661
		private int totalScore_;
	}
}
