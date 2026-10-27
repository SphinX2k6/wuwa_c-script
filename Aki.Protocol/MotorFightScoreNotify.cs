using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A63 RID: 2659
	[NetMessage(EMessageId.MotorFightScoreNotify)]
	public sealed class MotorFightScoreNotify : IMessage<MotorFightScoreNotify>, IMessage, IEquatable<MotorFightScoreNotify>, IDeepCloneable<MotorFightScoreNotify>, IBufferMessage
	{
		// Token: 0x0600E7FE RID: 59390 RVA: 0x0021E704 File Offset: 0x0021C904
		[NullableContext(1)]
		public static MotorFightScoreNotify Create()
		{
			return new MotorFightScoreNotify();
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x0600E7FF RID: 59391 RVA: 0x0021E70B File Offset: 0x0021C90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x0600E800 RID: 59392 RVA: 0x0021E70E File Offset: 0x0021C90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightScoreNotify.Descriptor;
			}
		}

		// Token: 0x0600E801 RID: 59393 RVA: 0x0021E715 File Offset: 0x0021C915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreNotify()
		{
		}

		// Token: 0x0600E802 RID: 59394 RVA: 0x0021E71D File Offset: 0x0021C91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreNotify(MotorFightScoreNotify other) : this()
		{
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E803 RID: 59395 RVA: 0x0021E742 File Offset: 0x0021C942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreNotify Clone()
		{
			return new MotorFightScoreNotify(this);
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600E804 RID: 59396 RVA: 0x0021E74A File Offset: 0x0021C94A
		// (set) Token: 0x0600E805 RID: 59397 RVA: 0x0021E752 File Offset: 0x0021C952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0600E806 RID: 59398 RVA: 0x0021E75B File Offset: 0x0021C95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightScoreNotify);
		}

		// Token: 0x0600E807 RID: 59399 RVA: 0x0021E769 File Offset: 0x0021C969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightScoreNotify other)
		{
			return other != null && (other == this || (this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E808 RID: 59400 RVA: 0x0021E798 File Offset: 0x0021C998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E809 RID: 59401 RVA: 0x0021E7D7 File Offset: 0x0021C9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E80A RID: 59402 RVA: 0x0021E7E4 File Offset: 0x0021C9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E80B RID: 59403 RVA: 0x0021E7ED File Offset: 0x0021C9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Score != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E80C RID: 59404 RVA: 0x0021E820 File Offset: 0x0021CA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E80D RID: 59405 RVA: 0x0021E85E File Offset: 0x0021CA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightScoreNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E80E RID: 59406 RVA: 0x0021E88F File Offset: 0x0021CA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E80F RID: 59407 RVA: 0x0021E898 File Offset: 0x0021CA98
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Score = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E8B RID: 24203
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E8C RID: 24204
		public const int ScoreFieldNumber = 13;

		// Token: 0x04005E8D RID: 24205
		private int score_;
	}
}
