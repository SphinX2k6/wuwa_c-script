using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033C RID: 828
	[NetMessage(EMessageId.DangoBrawlChallengeUnlockNotify)]
	public sealed class DangoBrawlChallengeUnlockNotify : IMessage<DangoBrawlChallengeUnlockNotify>, IMessage, IEquatable<DangoBrawlChallengeUnlockNotify>, IDeepCloneable<DangoBrawlChallengeUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600530D RID: 21261 RVA: 0x000CAA5A File Offset: 0x000C8C5A
		[NullableContext(1)]
		public static DangoBrawlChallengeUnlockNotify Create()
		{
			return new DangoBrawlChallengeUnlockNotify();
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x0600530E RID: 21262 RVA: 0x000CAA61 File Offset: 0x000C8C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x0600530F RID: 21263 RVA: 0x000CAA64 File Offset: 0x000C8C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlChallengeUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x000CAA6B File Offset: 0x000C8C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeUnlockNotify()
		{
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x000CAA7E File Offset: 0x000C8C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeUnlockNotify(DangoBrawlChallengeUnlockNotify other) : this()
		{
			this.challengeInfos_ = other.challengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x000CAAA8 File Offset: 0x000C8CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeUnlockNotify Clone()
		{
			return new DangoBrawlChallengeUnlockNotify(this);
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06005313 RID: 21267 RVA: 0x000CAAB0 File Offset: 0x000C8CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlChallengeInfo> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x000CAAB8 File Offset: 0x000C8CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlChallengeUnlockNotify);
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x000CAAC6 File Offset: 0x000C8CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlChallengeUnlockNotify other)
		{
			return other != null && (other == this || (this.challengeInfos_.Equals(other.challengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x000CAAFC File Offset: 0x000C8CFC
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

		// Token: 0x06005317 RID: 21271 RVA: 0x000CAB30 File Offset: 0x000C8D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x000CAB3D File Offset: 0x000C8D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x000CAB46 File Offset: 0x000C8D46
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

		// Token: 0x0600531A RID: 21274 RVA: 0x000CAB70 File Offset: 0x000C8D70
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

		// Token: 0x0600531B RID: 21275 RVA: 0x000CABA9 File Offset: 0x000C8DA9
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

		// Token: 0x0600531C RID: 21276 RVA: 0x000CABD7 File Offset: 0x000C8DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x000CABE0 File Offset: 0x000C8DE0
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challengeInfos_.AddEntriesFrom(ref input, DangoBrawlChallengeUnlockNotify._repeated_challengeInfos_codec);
				}
			}
		}

		// Token: 0x0400335F RID: 13151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003360 RID: 13152
		public const int ChallengeInfosFieldNumber = 4;

		// Token: 0x04003361 RID: 13153
		private static readonly FieldCodec<DangoBrawlChallengeInfo> _repeated_challengeInfos_codec = FieldCodec.ForMessage<DangoBrawlChallengeInfo>(34U, DangoBrawlChallengeInfo.Parser);

		// Token: 0x04003362 RID: 13154
		private readonly RepeatedField<DangoBrawlChallengeInfo> challengeInfos_ = new RepeatedField<DangoBrawlChallengeInfo>();
	}
}
