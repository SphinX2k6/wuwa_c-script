using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000426 RID: 1062
	[NetMessage(EMessageId.EncircleChallengeUpdateNotify)]
	public sealed class EncircleChallengeUpdateNotify : IMessage<EncircleChallengeUpdateNotify>, IMessage, IEquatable<EncircleChallengeUpdateNotify>, IDeepCloneable<EncircleChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x06006655 RID: 26197 RVA: 0x000F64C1 File Offset: 0x000F46C1
		[NullableContext(1)]
		public static EncircleChallengeUpdateNotify Create()
		{
			return new EncircleChallengeUpdateNotify();
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06006656 RID: 26198 RVA: 0x000F64C8 File Offset: 0x000F46C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x000F64CB File Offset: 0x000F46CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x000F64D2 File Offset: 0x000F46D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeUpdateNotify()
		{
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x000F64E5 File Offset: 0x000F46E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeUpdateNotify(EncircleChallengeUpdateNotify other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x000F650F File Offset: 0x000F470F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeUpdateNotify Clone()
		{
			return new EncircleChallengeUpdateNotify(this);
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x000F6517 File Offset: 0x000F4717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EncircleChallengePb> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x000F651F File Offset: 0x000F471F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeUpdateNotify);
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x000F652D File Offset: 0x000F472D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x000F6560 File Offset: 0x000F4760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challenges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x000F6594 File Offset: 0x000F4794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x000F65A1 File Offset: 0x000F47A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x000F65AA File Offset: 0x000F47AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, EncircleChallengeUpdateNotify._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x000F65D4 File Offset: 0x000F47D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(EncircleChallengeUpdateNotify._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x000F660D File Offset: 0x000F480D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleChallengeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x000F663B File Offset: 0x000F483B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x000F6644 File Offset: 0x000F4844
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
					this.challenges_.AddEntriesFrom(ref input, EncircleChallengeUpdateNotify._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04003974 RID: 14708
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003975 RID: 14709
		public const int ChallengesFieldNumber = 4;

		// Token: 0x04003976 RID: 14710
		private static readonly FieldCodec<EncircleChallengePb> _repeated_challenges_codec = FieldCodec.ForMessage<EncircleChallengePb>(34U, EncircleChallengePb.Parser);

		// Token: 0x04003977 RID: 14711
		private readonly RepeatedField<EncircleChallengePb> challenges_ = new RepeatedField<EncircleChallengePb>();
	}
}
