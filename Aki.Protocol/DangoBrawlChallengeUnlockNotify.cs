using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000344 RID: 836
	[NetMessage(EMessageId.DangoBrawlChallengeUnlockNotify)]
	public sealed class DangoBrawlChallengeUnlockNotify : IMessage<DangoBrawlChallengeUnlockNotify>, IMessage, IEquatable<DangoBrawlChallengeUnlockNotify>, IDeepCloneable<DangoBrawlChallengeUnlockNotify>, IBufferMessage
	{
		// Token: 0x060053FA RID: 21498 RVA: 0x000CD0DE File Offset: 0x000CB2DE
		[NullableContext(1)]
		public static DangoBrawlChallengeUnlockNotify Create()
		{
			return new DangoBrawlChallengeUnlockNotify();
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x060053FB RID: 21499 RVA: 0x000CD0E5 File Offset: 0x000CB2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x000CD0E8 File Offset: 0x000CB2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlChallengeUnlockNotify.Descriptor;
			}
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x000CD0EF File Offset: 0x000CB2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeUnlockNotify()
		{
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x000CD102 File Offset: 0x000CB302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeUnlockNotify(DangoBrawlChallengeUnlockNotify other) : this()
		{
			this.challengeInfos_ = other.challengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x000CD12C File Offset: 0x000CB32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeUnlockNotify Clone()
		{
			return new DangoBrawlChallengeUnlockNotify(this);
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x000CD134 File Offset: 0x000CB334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlChallengeInfo> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x000CD13C File Offset: 0x000CB33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlChallengeUnlockNotify);
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x000CD14A File Offset: 0x000CB34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlChallengeUnlockNotify other)
		{
			return other != null && (other == this || (this.challengeInfos_.Equals(other.challengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x000CD180 File Offset: 0x000CB380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x000CD1B4 File Offset: 0x000CB3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x000CD1C1 File Offset: 0x000CB3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x000CD1CA File Offset: 0x000CB3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeInfos_.WriteTo(ref output, DangoBrawlChallengeUnlockNotify._repeated_challengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x000CD1F4 File Offset: 0x000CB3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeInfos_.CalculateSize(DangoBrawlChallengeUnlockNotify._repeated_challengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x000CD22D File Offset: 0x000CB42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlChallengeUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeInfos_.Add(other.challengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x000CD25B File Offset: 0x000CB45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x000CD264 File Offset: 0x000CB464
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challengeInfos_.AddEntriesFrom(ref input, DangoBrawlChallengeUnlockNotify._repeated_challengeInfos_codec);
				}
			}
		}

		// Token: 0x040033FB RID: 13307
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033FC RID: 13308
		public const int ChallengeInfosFieldNumber = 6;

		// Token: 0x040033FD RID: 13309
		private static readonly FieldCodec<DangoBrawlChallengeInfo> _repeated_challengeInfos_codec = FieldCodec.ForMessage<DangoBrawlChallengeInfo>(50U, DangoBrawlChallengeInfo.Parser);

		// Token: 0x040033FE RID: 13310
		private readonly RepeatedField<DangoBrawlChallengeInfo> challengeInfos_ = new RepeatedField<DangoBrawlChallengeInfo>();
	}
}
