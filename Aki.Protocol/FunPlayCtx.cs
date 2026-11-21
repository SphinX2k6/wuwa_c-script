using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066C RID: 1644
	public sealed class FunPlayCtx : IMessage<FunPlayCtx>, IMessage, IEquatable<FunPlayCtx>, IDeepCloneable<FunPlayCtx>, IBufferMessage
	{
		// Token: 0x06009712 RID: 38674 RVA: 0x0016C97F File Offset: 0x0016AB7F
		[NullableContext(1)]
		public static FunPlayCtx Create()
		{
			return new FunPlayCtx();
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06009713 RID: 38675 RVA: 0x0016C986 File Offset: 0x0016AB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x06009714 RID: 38676 RVA: 0x0016C989 File Offset: 0x0016AB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayCtx.Descriptor;
			}
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x0016C990 File Offset: 0x0016AB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayCtx()
		{
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x0016C998 File Offset: 0x0016AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayCtx(FunPlayCtx other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x0016C9BD File Offset: 0x0016ABBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayCtx Clone()
		{
			return new FunPlayCtx(this);
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06009718 RID: 38680 RVA: 0x0016C9C5 File Offset: 0x0016ABC5
		// (set) Token: 0x06009719 RID: 38681 RVA: 0x0016C9CD File Offset: 0x0016ABCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x0016C9D6 File Offset: 0x0016ABD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayCtx);
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x0016C9E4 File Offset: 0x0016ABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayCtx other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x0016CA14 File Offset: 0x0016AC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x0016CA53 File Offset: 0x0016AC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x0016CA60 File Offset: 0x0016AC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x0016CA69 File Offset: 0x0016AC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009720 RID: 38688 RVA: 0x0016CA9C File Offset: 0x0016AC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009721 RID: 38689 RVA: 0x0016CADA File Offset: 0x0016ACDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009722 RID: 38690 RVA: 0x0016CB0B File Offset: 0x0016AD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009723 RID: 38691 RVA: 0x0016CB14 File Offset: 0x0016AD14
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400483A RID: 18490
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400483B RID: 18491
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400483C RID: 18492
		private int challengeId_;
	}
}
