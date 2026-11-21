using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A52 RID: 2642
	[NetMessage(EMessageId.MotorFightScoreNotify)]
	public sealed class MotorFightScoreNotify : IMessage<MotorFightScoreNotify>, IMessage, IEquatable<MotorFightScoreNotify>, IDeepCloneable<MotorFightScoreNotify>, IBufferMessage
	{
		// Token: 0x0600E6E4 RID: 59108 RVA: 0x0021C510 File Offset: 0x0021A710
		[NullableContext(1)]
		public static MotorFightScoreNotify Create()
		{
			return new MotorFightScoreNotify();
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x0600E6E5 RID: 59109 RVA: 0x0021C517 File Offset: 0x0021A717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x0600E6E6 RID: 59110 RVA: 0x0021C51A File Offset: 0x0021A71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightScoreNotify.Descriptor;
			}
		}

		// Token: 0x0600E6E7 RID: 59111 RVA: 0x0021C521 File Offset: 0x0021A721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreNotify()
		{
		}

		// Token: 0x0600E6E8 RID: 59112 RVA: 0x0021C529 File Offset: 0x0021A729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreNotify(MotorFightScoreNotify other) : this()
		{
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6E9 RID: 59113 RVA: 0x0021C54E File Offset: 0x0021A74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreNotify Clone()
		{
			return new MotorFightScoreNotify(this);
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600E6EA RID: 59114 RVA: 0x0021C556 File Offset: 0x0021A756
		// (set) Token: 0x0600E6EB RID: 59115 RVA: 0x0021C55E File Offset: 0x0021A75E
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

		// Token: 0x0600E6EC RID: 59116 RVA: 0x0021C567 File Offset: 0x0021A767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightScoreNotify);
		}

		// Token: 0x0600E6ED RID: 59117 RVA: 0x0021C575 File Offset: 0x0021A775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightScoreNotify other)
		{
			return other != null && (other == this || (this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6EE RID: 59118 RVA: 0x0021C5A4 File Offset: 0x0021A7A4
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

		// Token: 0x0600E6EF RID: 59119 RVA: 0x0021C5E3 File Offset: 0x0021A7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x0021C5F0 File Offset: 0x0021A7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6F1 RID: 59121 RVA: 0x0021C5F9 File Offset: 0x0021A7F9
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

		// Token: 0x0600E6F2 RID: 59122 RVA: 0x0021C62C File Offset: 0x0021A82C
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

		// Token: 0x0600E6F3 RID: 59123 RVA: 0x0021C66A File Offset: 0x0021A86A
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

		// Token: 0x0600E6F4 RID: 59124 RVA: 0x0021C69B File Offset: 0x0021A89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6F5 RID: 59125 RVA: 0x0021C6A4 File Offset: 0x0021A8A4
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

		// Token: 0x04005E94 RID: 24212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E95 RID: 24213
		public const int ScoreFieldNumber = 13;

		// Token: 0x04005E96 RID: 24214
		private int score_;
	}
}
