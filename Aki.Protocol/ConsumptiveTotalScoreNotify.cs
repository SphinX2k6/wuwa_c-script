using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EC RID: 748
	[NetMessage(EMessageId.ConsumptiveTotalScoreNotify)]
	public sealed class ConsumptiveTotalScoreNotify : IMessage<ConsumptiveTotalScoreNotify>, IMessage, IEquatable<ConsumptiveTotalScoreNotify>, IDeepCloneable<ConsumptiveTotalScoreNotify>, IBufferMessage
	{
		// Token: 0x06004BF9 RID: 19449 RVA: 0x000B90BA File Offset: 0x000B72BA
		[NullableContext(1)]
		public static ConsumptiveTotalScoreNotify Create()
		{
			return new ConsumptiveTotalScoreNotify();
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x000B90C1 File Offset: 0x000B72C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x000B90C4 File Offset: 0x000B72C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTotalScoreNotify.Descriptor;
			}
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x000B90CB File Offset: 0x000B72CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTotalScoreNotify()
		{
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x000B90D3 File Offset: 0x000B72D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTotalScoreNotify(ConsumptiveTotalScoreNotify other) : this()
		{
			this.totalScore_ = other.totalScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x000B90F8 File Offset: 0x000B72F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTotalScoreNotify Clone()
		{
			return new ConsumptiveTotalScoreNotify(this);
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06004BFF RID: 19455 RVA: 0x000B9100 File Offset: 0x000B7300
		// (set) Token: 0x06004C00 RID: 19456 RVA: 0x000B9108 File Offset: 0x000B7308
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

		// Token: 0x06004C01 RID: 19457 RVA: 0x000B9111 File Offset: 0x000B7311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTotalScoreNotify);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x000B911F File Offset: 0x000B731F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTotalScoreNotify other)
		{
			return other != null && (other == this || (this.TotalScore == other.TotalScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x000B9150 File Offset: 0x000B7350
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

		// Token: 0x06004C04 RID: 19460 RVA: 0x000B918F File Offset: 0x000B738F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x000B919C File Offset: 0x000B739C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x000B91A5 File Offset: 0x000B73A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x000B91D8 File Offset: 0x000B73D8
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

		// Token: 0x06004C08 RID: 19464 RVA: 0x000B9216 File Offset: 0x000B7416
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

		// Token: 0x06004C09 RID: 19465 RVA: 0x000B9247 File Offset: 0x000B7447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x000B9250 File Offset: 0x000B7450
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TotalScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x040030DC RID: 12508
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030DD RID: 12509
		public const int TotalScoreFieldNumber = 12;

		// Token: 0x040030DE RID: 12510
		private int totalScore_;
	}
}
