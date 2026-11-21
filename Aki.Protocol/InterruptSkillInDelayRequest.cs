using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000823 RID: 2083
	[NetMessage(EMessageId.InterruptSkillInDelayRequest)]
	public sealed class InterruptSkillInDelayRequest : IMessage<InterruptSkillInDelayRequest>, IMessage, IEquatable<InterruptSkillInDelayRequest>, IDeepCloneable<InterruptSkillInDelayRequest>, IBufferMessage
	{
		// Token: 0x0600BA84 RID: 47748 RVA: 0x001BC9F5 File Offset: 0x001BABF5
		[NullableContext(1)]
		public static InterruptSkillInDelayRequest Create()
		{
			return new InterruptSkillInDelayRequest();
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x0600BA85 RID: 47749 RVA: 0x001BC9FC File Offset: 0x001BABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x0600BA86 RID: 47750 RVA: 0x001BC9FF File Offset: 0x001BABFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptSkillInDelayRequest.Descriptor;
			}
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x001BCA06 File Offset: 0x001BAC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayRequest()
		{
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x001BCA0E File Offset: 0x001BAC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayRequest(InterruptSkillInDelayRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA89 RID: 47753 RVA: 0x001BCA33 File Offset: 0x001BAC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayRequest Clone()
		{
			return new InterruptSkillInDelayRequest(this);
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x0600BA8A RID: 47754 RVA: 0x001BCA3B File Offset: 0x001BAC3B
		// (set) Token: 0x0600BA8B RID: 47755 RVA: 0x001BCA43 File Offset: 0x001BAC43
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

		// Token: 0x0600BA8C RID: 47756 RVA: 0x001BCA4C File Offset: 0x001BAC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptSkillInDelayRequest);
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x001BCA5A File Offset: 0x001BAC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptSkillInDelayRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x001BCA88 File Offset: 0x001BAC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA8F RID: 47759 RVA: 0x001BCAC7 File Offset: 0x001BACC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA90 RID: 47760 RVA: 0x001BCAD4 File Offset: 0x001BACD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA91 RID: 47761 RVA: 0x001BCADD File Offset: 0x001BACDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA92 RID: 47762 RVA: 0x001BCB10 File Offset: 0x001BAD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x001BCB4E File Offset: 0x001BAD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InterruptSkillInDelayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x001BCB7F File Offset: 0x001BAD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x001BCB88 File Offset: 0x001BAD88
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005258 RID: 21080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005259 RID: 21081
		public const int SkillIdFieldNumber = 4;

		// Token: 0x0400525A RID: 21082
		private long skillId_;
	}
}
