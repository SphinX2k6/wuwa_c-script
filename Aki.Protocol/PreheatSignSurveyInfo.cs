using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC0 RID: 3520
	public sealed class PreheatSignSurveyInfo : IMessage<PreheatSignSurveyInfo>, IMessage, IEquatable<PreheatSignSurveyInfo>, IDeepCloneable<PreheatSignSurveyInfo>, IBufferMessage
	{
		// Token: 0x06012FAA RID: 77738 RVA: 0x002C4CDB File Offset: 0x002C2EDB
		[NullableContext(1)]
		public static PreheatSignSurveyInfo Create()
		{
			return new PreheatSignSurveyInfo();
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x06012FAB RID: 77739 RVA: 0x002C4CE2 File Offset: 0x002C2EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x06012FAC RID: 77740 RVA: 0x002C4CE5 File Offset: 0x002C2EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignSurveyInfo.Descriptor;
			}
		}

		// Token: 0x06012FAD RID: 77741 RVA: 0x002C4CEC File Offset: 0x002C2EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfo()
		{
		}

		// Token: 0x06012FAE RID: 77742 RVA: 0x002C4CF4 File Offset: 0x002C2EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfo(PreheatSignSurveyInfo other) : this()
		{
			this.supportNum_ = other.supportNum_;
			this.opposeNum_ = other.opposeNum_;
			this.answerStatus_ = other.answerStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FAF RID: 77743 RVA: 0x002C4D31 File Offset: 0x002C2F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfo Clone()
		{
			return new PreheatSignSurveyInfo(this);
		}

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x06012FB0 RID: 77744 RVA: 0x002C4D39 File Offset: 0x002C2F39
		// (set) Token: 0x06012FB1 RID: 77745 RVA: 0x002C4D41 File Offset: 0x002C2F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SupportNum
		{
			get
			{
				return this.supportNum_;
			}
			set
			{
				this.supportNum_ = value;
			}
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x06012FB2 RID: 77746 RVA: 0x002C4D4A File Offset: 0x002C2F4A
		// (set) Token: 0x06012FB3 RID: 77747 RVA: 0x002C4D52 File Offset: 0x002C2F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpposeNum
		{
			get
			{
				return this.opposeNum_;
			}
			set
			{
				this.opposeNum_ = value;
			}
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x06012FB4 RID: 77748 RVA: 0x002C4D5B File Offset: 0x002C2F5B
		// (set) Token: 0x06012FB5 RID: 77749 RVA: 0x002C4D63 File Offset: 0x002C2F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AnswerStatus
		{
			get
			{
				return this.answerStatus_;
			}
			set
			{
				this.answerStatus_ = value;
			}
		}

		// Token: 0x06012FB6 RID: 77750 RVA: 0x002C4D6C File Offset: 0x002C2F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignSurveyInfo);
		}

		// Token: 0x06012FB7 RID: 77751 RVA: 0x002C4D7C File Offset: 0x002C2F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignSurveyInfo other)
		{
			return other != null && (other == this || (this.SupportNum == other.SupportNum && this.OpposeNum == other.OpposeNum && this.AnswerStatus == other.AnswerStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FB8 RID: 77752 RVA: 0x002C4DD8 File Offset: 0x002C2FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SupportNum != 0L)
			{
				num ^= this.SupportNum.GetHashCode();
			}
			if (this.OpposeNum != 0L)
			{
				num ^= this.OpposeNum.GetHashCode();
			}
			if (this.AnswerStatus)
			{
				num ^= this.AnswerStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012FB9 RID: 77753 RVA: 0x002C4E49 File Offset: 0x002C3049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FBA RID: 77754 RVA: 0x002C4E56 File Offset: 0x002C3056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FBB RID: 77755 RVA: 0x002C4E60 File Offset: 0x002C3060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SupportNum != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SupportNum);
			}
			if (this.OpposeNum != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OpposeNum);
			}
			if (this.AnswerStatus)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.AnswerStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012FBC RID: 77756 RVA: 0x002C4ED4 File Offset: 0x002C30D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SupportNum != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SupportNum);
			}
			if (this.OpposeNum != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpposeNum);
			}
			if (this.AnswerStatus)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012FBD RID: 77757 RVA: 0x002C4F38 File Offset: 0x002C3138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignSurveyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SupportNum != 0L)
			{
				this.SupportNum = other.SupportNum;
			}
			if (other.OpposeNum != 0L)
			{
				this.OpposeNum = other.OpposeNum;
			}
			if (other.AnswerStatus)
			{
				this.AnswerStatus = other.AnswerStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012FBE RID: 77758 RVA: 0x002C4F9C File Offset: 0x002C319C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FBF RID: 77759 RVA: 0x002C4FA8 File Offset: 0x002C31A8
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
							this.AnswerStatus = input.ReadBool();
						}
					}
					else
					{
						this.OpposeNum = input.ReadInt64();
					}
				}
				else
				{
					this.SupportNum = input.ReadInt64();
				}
			}
		}

		// Token: 0x040075AC RID: 30124
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075AD RID: 30125
		public const int SupportNumFieldNumber = 1;

		// Token: 0x040075AE RID: 30126
		private long supportNum_;

		// Token: 0x040075AF RID: 30127
		public const int OpposeNumFieldNumber = 2;

		// Token: 0x040075B0 RID: 30128
		private long opposeNum_;

		// Token: 0x040075B1 RID: 30129
		public const int AnswerStatusFieldNumber = 3;

		// Token: 0x040075B2 RID: 30130
		private bool answerStatus_;
	}
}
