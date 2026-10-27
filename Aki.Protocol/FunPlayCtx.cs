using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000680 RID: 1664
	public sealed class FunPlayCtx : IMessage<FunPlayCtx>, IMessage, IEquatable<FunPlayCtx>, IDeepCloneable<FunPlayCtx>, IBufferMessage
	{
		// Token: 0x06009868 RID: 39016 RVA: 0x0016F3AE File Offset: 0x0016D5AE
		[NullableContext(1)]
		public static FunPlayCtx Create()
		{
			return new FunPlayCtx();
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x0016F3B5 File Offset: 0x0016D5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x0600986A RID: 39018 RVA: 0x0016F3B8 File Offset: 0x0016D5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayCtx.Descriptor;
			}
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x0016F3BF File Offset: 0x0016D5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayCtx()
		{
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x0016F3C7 File Offset: 0x0016D5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayCtx(FunPlayCtx other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x0016F3EC File Offset: 0x0016D5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayCtx Clone()
		{
			return new FunPlayCtx(this);
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x0600986E RID: 39022 RVA: 0x0016F3F4 File Offset: 0x0016D5F4
		// (set) Token: 0x0600986F RID: 39023 RVA: 0x0016F3FC File Offset: 0x0016D5FC
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

		// Token: 0x06009870 RID: 39024 RVA: 0x0016F405 File Offset: 0x0016D605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayCtx);
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x0016F413 File Offset: 0x0016D613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayCtx other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x0016F444 File Offset: 0x0016D644
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

		// Token: 0x06009873 RID: 39027 RVA: 0x0016F483 File Offset: 0x0016D683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x0016F490 File Offset: 0x0016D690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x0016F499 File Offset: 0x0016D699
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

		// Token: 0x06009876 RID: 39030 RVA: 0x0016F4CC File Offset: 0x0016D6CC
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

		// Token: 0x06009877 RID: 39031 RVA: 0x0016F50A File Offset: 0x0016D70A
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

		// Token: 0x06009878 RID: 39032 RVA: 0x0016F53B File Offset: 0x0016D73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x0016F544 File Offset: 0x0016D744
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

		// Token: 0x04004841 RID: 18497
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004842 RID: 18498
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04004843 RID: 18499
		private int challengeId_;
	}
}
