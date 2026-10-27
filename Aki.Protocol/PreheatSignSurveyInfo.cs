using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD0 RID: 3536
	public sealed class PreheatSignSurveyInfo : IMessage<PreheatSignSurveyInfo>, IMessage, IEquatable<PreheatSignSurveyInfo>, IDeepCloneable<PreheatSignSurveyInfo>, IBufferMessage
	{
		// Token: 0x0601308F RID: 77967 RVA: 0x002C639B File Offset: 0x002C459B
		[NullableContext(1)]
		public static PreheatSignSurveyInfo Create()
		{
			return new PreheatSignSurveyInfo();
		}

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x06013090 RID: 77968 RVA: 0x002C63A2 File Offset: 0x002C45A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x06013091 RID: 77969 RVA: 0x002C63A5 File Offset: 0x002C45A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignSurveyInfo.Descriptor;
			}
		}

		// Token: 0x06013092 RID: 77970 RVA: 0x002C63AC File Offset: 0x002C45AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfo()
		{
		}

		// Token: 0x06013093 RID: 77971 RVA: 0x002C63B4 File Offset: 0x002C45B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfo(PreheatSignSurveyInfo other) : this()
		{
			this.supportNum_ = other.supportNum_;
			this.opposeNum_ = other.opposeNum_;
			this.answerStatus_ = other.answerStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013094 RID: 77972 RVA: 0x002C63F1 File Offset: 0x002C45F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfo Clone()
		{
			return new PreheatSignSurveyInfo(this);
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x06013095 RID: 77973 RVA: 0x002C63F9 File Offset: 0x002C45F9
		// (set) Token: 0x06013096 RID: 77974 RVA: 0x002C6401 File Offset: 0x002C4601
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

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x06013097 RID: 77975 RVA: 0x002C640A File Offset: 0x002C460A
		// (set) Token: 0x06013098 RID: 77976 RVA: 0x002C6412 File Offset: 0x002C4612
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

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x06013099 RID: 77977 RVA: 0x002C641B File Offset: 0x002C461B
		// (set) Token: 0x0601309A RID: 77978 RVA: 0x002C6423 File Offset: 0x002C4623
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

		// Token: 0x0601309B RID: 77979 RVA: 0x002C642C File Offset: 0x002C462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignSurveyInfo);
		}

		// Token: 0x0601309C RID: 77980 RVA: 0x002C643C File Offset: 0x002C463C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignSurveyInfo other)
		{
			return other != null && (other == this || (this.SupportNum == other.SupportNum && this.OpposeNum == other.OpposeNum && this.AnswerStatus == other.AnswerStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601309D RID: 77981 RVA: 0x002C6498 File Offset: 0x002C4698
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

		// Token: 0x0601309E RID: 77982 RVA: 0x002C6509 File Offset: 0x002C4709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601309F RID: 77983 RVA: 0x002C6516 File Offset: 0x002C4716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130A0 RID: 77984 RVA: 0x002C6520 File Offset: 0x002C4720
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

		// Token: 0x060130A1 RID: 77985 RVA: 0x002C6594 File Offset: 0x002C4794
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

		// Token: 0x060130A2 RID: 77986 RVA: 0x002C65F8 File Offset: 0x002C47F8
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

		// Token: 0x060130A3 RID: 77987 RVA: 0x002C665C File Offset: 0x002C485C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130A4 RID: 77988 RVA: 0x002C6668 File Offset: 0x002C4868
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

		// Token: 0x04007582 RID: 30082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007583 RID: 30083
		public const int SupportNumFieldNumber = 1;

		// Token: 0x04007584 RID: 30084
		private long supportNum_;

		// Token: 0x04007585 RID: 30085
		public const int OpposeNumFieldNumber = 2;

		// Token: 0x04007586 RID: 30086
		private long opposeNum_;

		// Token: 0x04007587 RID: 30087
		public const int AnswerStatusFieldNumber = 3;

		// Token: 0x04007588 RID: 30088
		private bool answerStatus_;
	}
}
