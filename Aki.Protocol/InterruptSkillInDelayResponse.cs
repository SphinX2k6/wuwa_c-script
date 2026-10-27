using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000838 RID: 2104
	[NetMessage(EMessageId.InterruptSkillInDelayResponse)]
	public sealed class InterruptSkillInDelayResponse : IMessage<InterruptSkillInDelayResponse>, IMessage, IEquatable<InterruptSkillInDelayResponse>, IDeepCloneable<InterruptSkillInDelayResponse>, IBufferMessage
	{
		// Token: 0x0600BBEC RID: 48108 RVA: 0x001BF609 File Offset: 0x001BD809
		[NullableContext(1)]
		public static InterruptSkillInDelayResponse Create()
		{
			return new InterruptSkillInDelayResponse();
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x0600BBED RID: 48109 RVA: 0x001BF610 File Offset: 0x001BD810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x0600BBEE RID: 48110 RVA: 0x001BF613 File Offset: 0x001BD813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptSkillInDelayResponse.Descriptor;
			}
		}

		// Token: 0x0600BBEF RID: 48111 RVA: 0x001BF61A File Offset: 0x001BD81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayResponse()
		{
		}

		// Token: 0x0600BBF0 RID: 48112 RVA: 0x001BF622 File Offset: 0x001BD822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayResponse(InterruptSkillInDelayResponse other) : this()
		{
			this.skillId_ = other.skillId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBF1 RID: 48113 RVA: 0x001BF653 File Offset: 0x001BD853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayResponse Clone()
		{
			return new InterruptSkillInDelayResponse(this);
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x001BF65B File Offset: 0x001BD85B
		// (set) Token: 0x0600BBF3 RID: 48115 RVA: 0x001BF663 File Offset: 0x001BD863
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

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x001BF66C File Offset: 0x001BD86C
		// (set) Token: 0x0600BBF5 RID: 48117 RVA: 0x001BF674 File Offset: 0x001BD874
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

		// Token: 0x0600BBF6 RID: 48118 RVA: 0x001BF67D File Offset: 0x001BD87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptSkillInDelayResponse);
		}

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x001BF68B File Offset: 0x001BD88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptSkillInDelayResponse other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x001BF6CC File Offset: 0x001BD8CC
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

		// Token: 0x0600BBF9 RID: 48121 RVA: 0x001BF72A File Offset: 0x001BD92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBFA RID: 48122 RVA: 0x001BF737 File Offset: 0x001BD937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x001BF740 File Offset: 0x001BD940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.SkillId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBFC RID: 48124 RVA: 0x001BF79C File Offset: 0x001BD99C
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

		// Token: 0x0600BBFD RID: 48125 RVA: 0x001BF7F4 File Offset: 0x001BD9F4
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

		// Token: 0x0600BBFE RID: 48126 RVA: 0x001BF844 File Offset: 0x001BDA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x001BF850 File Offset: 0x001BDA50
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
				if (num != 16U)
				{
					if (num != 32U)
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

		// Token: 0x04005262 RID: 21090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005263 RID: 21091
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04005264 RID: 21092
		private long skillId_;

		// Token: 0x04005265 RID: 21093
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005266 RID: 21094
		private ErrorCode errorCode_;
	}
}
