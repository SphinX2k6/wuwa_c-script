using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067B RID: 1659
	[NetMessage(EMessageId.FunPlayChallengeAwardRequest)]
	public sealed class FunPlayChallengeAwardRequest : IMessage<FunPlayChallengeAwardRequest>, IMessage, IEquatable<FunPlayChallengeAwardRequest>, IDeepCloneable<FunPlayChallengeAwardRequest>, IBufferMessage
	{
		// Token: 0x06009801 RID: 38913 RVA: 0x0016E621 File Offset: 0x0016C821
		[NullableContext(1)]
		public static FunPlayChallengeAwardRequest Create()
		{
			return new FunPlayChallengeAwardRequest();
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x06009802 RID: 38914 RVA: 0x0016E628 File Offset: 0x0016C828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x06009803 RID: 38915 RVA: 0x0016E62B File Offset: 0x0016C82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeAwardRequest.Descriptor;
			}
		}

		// Token: 0x06009804 RID: 38916 RVA: 0x0016E632 File Offset: 0x0016C832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardRequest()
		{
		}

		// Token: 0x06009805 RID: 38917 RVA: 0x0016E63A File Offset: 0x0016C83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardRequest(FunPlayChallengeAwardRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009806 RID: 38918 RVA: 0x0016E65F File Offset: 0x0016C85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardRequest Clone()
		{
			return new FunPlayChallengeAwardRequest(this);
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06009807 RID: 38919 RVA: 0x0016E667 File Offset: 0x0016C867
		// (set) Token: 0x06009808 RID: 38920 RVA: 0x0016E66F File Offset: 0x0016C86F
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

		// Token: 0x06009809 RID: 38921 RVA: 0x0016E678 File Offset: 0x0016C878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeAwardRequest);
		}

		// Token: 0x0600980A RID: 38922 RVA: 0x0016E686 File Offset: 0x0016C886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeAwardRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x0016E6B4 File Offset: 0x0016C8B4
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

		// Token: 0x0600980C RID: 38924 RVA: 0x0016E6F3 File Offset: 0x0016C8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600980D RID: 38925 RVA: 0x0016E700 File Offset: 0x0016C900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600980E RID: 38926 RVA: 0x0016E709 File Offset: 0x0016C909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600980F RID: 38927 RVA: 0x0016E73C File Offset: 0x0016C93C
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

		// Token: 0x06009810 RID: 38928 RVA: 0x0016E77A File Offset: 0x0016C97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayChallengeAwardRequest other)
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

		// Token: 0x06009811 RID: 38929 RVA: 0x0016E7AB File Offset: 0x0016C9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009812 RID: 38930 RVA: 0x0016E7B4 File Offset: 0x0016C9B4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004823 RID: 18467
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004824 RID: 18468
		public const int ChallengeIdFieldNumber = 5;

		// Token: 0x04004825 RID: 18469
		private int challengeId_;
	}
}
