using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000824 RID: 2084
	[NetMessage(EMessageId.InterruptSkillInDelayResponse)]
	public sealed class InterruptSkillInDelayResponse : IMessage<InterruptSkillInDelayResponse>, IMessage, IEquatable<InterruptSkillInDelayResponse>, IDeepCloneable<InterruptSkillInDelayResponse>, IBufferMessage
	{
		// Token: 0x0600BA96 RID: 47766 RVA: 0x001BCBCD File Offset: 0x001BADCD
		[NullableContext(1)]
		public static InterruptSkillInDelayResponse Create()
		{
			return new InterruptSkillInDelayResponse();
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x0600BA97 RID: 47767 RVA: 0x001BCBD4 File Offset: 0x001BADD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x001BCBD7 File Offset: 0x001BADD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptSkillInDelayResponse.Descriptor;
			}
		}

		// Token: 0x0600BA99 RID: 47769 RVA: 0x001BCBDE File Offset: 0x001BADDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayResponse()
		{
		}

		// Token: 0x0600BA9A RID: 47770 RVA: 0x001BCBE6 File Offset: 0x001BADE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayResponse(InterruptSkillInDelayResponse other) : this()
		{
			this.skillId_ = other.skillId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA9B RID: 47771 RVA: 0x001BCC17 File Offset: 0x001BAE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayResponse Clone()
		{
			return new InterruptSkillInDelayResponse(this);
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x0600BA9C RID: 47772 RVA: 0x001BCC1F File Offset: 0x001BAE1F
		// (set) Token: 0x0600BA9D RID: 47773 RVA: 0x001BCC27 File Offset: 0x001BAE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x0600BA9E RID: 47774 RVA: 0x001BCC30 File Offset: 0x001BAE30
		// (set) Token: 0x0600BA9F RID: 47775 RVA: 0x001BCC38 File Offset: 0x001BAE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600BAA0 RID: 47776 RVA: 0x001BCC41 File Offset: 0x001BAE41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptSkillInDelayResponse);
		}

		// Token: 0x0600BAA1 RID: 47777 RVA: 0x001BCC4F File Offset: 0x001BAE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptSkillInDelayResponse other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAA2 RID: 47778 RVA: 0x001BCC90 File Offset: 0x001BAE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BAA3 RID: 47779 RVA: 0x001BCCEE File Offset: 0x001BAEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BAA4 RID: 47780 RVA: 0x001BCCFB File Offset: 0x001BAEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BAA5 RID: 47781 RVA: 0x001BCD04 File Offset: 0x001BAF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SkillId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BAA6 RID: 47782 RVA: 0x001BCD60 File Offset: 0x001BAF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BAA7 RID: 47783 RVA: 0x001BCDB8 File Offset: 0x001BAFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InterruptSkillInDelayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BAA8 RID: 47784 RVA: 0x001BCE08 File Offset: 0x001BB008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAA9 RID: 47785 RVA: 0x001BCE14 File Offset: 0x001BB014
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400525B RID: 21083
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400525C RID: 21084
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400525D RID: 21085
		private long skillId_;

		// Token: 0x0400525E RID: 21086
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400525F RID: 21087
		private ErrorCode errorCode_;
	}
}
