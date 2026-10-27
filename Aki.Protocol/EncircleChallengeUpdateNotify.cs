using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043D RID: 1085
	[NetMessage(EMessageId.EncircleChallengeUpdateNotify)]
	public sealed class EncircleChallengeUpdateNotify : IMessage<EncircleChallengeUpdateNotify>, IMessage, IEquatable<EncircleChallengeUpdateNotify>, IDeepCloneable<EncircleChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x060067E5 RID: 26597 RVA: 0x000F963D File Offset: 0x000F783D
		[NullableContext(1)]
		public static EncircleChallengeUpdateNotify Create()
		{
			return new EncircleChallengeUpdateNotify();
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x060067E6 RID: 26598 RVA: 0x000F9644 File Offset: 0x000F7844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x060067E7 RID: 26599 RVA: 0x000F9647 File Offset: 0x000F7847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x000F964E File Offset: 0x000F784E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeUpdateNotify()
		{
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x000F9661 File Offset: 0x000F7861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeUpdateNotify(EncircleChallengeUpdateNotify other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x000F968B File Offset: 0x000F788B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeUpdateNotify Clone()
		{
			return new EncircleChallengeUpdateNotify(this);
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x060067EB RID: 26603 RVA: 0x000F9693 File Offset: 0x000F7893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EncircleChallengePb> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x000F969B File Offset: 0x000F789B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeUpdateNotify);
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x000F96A9 File Offset: 0x000F78A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x000F96DC File Offset: 0x000F78DC
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

		// Token: 0x060067EF RID: 26607 RVA: 0x000F9710 File Offset: 0x000F7910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x000F971D File Offset: 0x000F791D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x000F9726 File Offset: 0x000F7926
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

		// Token: 0x060067F2 RID: 26610 RVA: 0x000F9750 File Offset: 0x000F7950
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

		// Token: 0x060067F3 RID: 26611 RVA: 0x000F9789 File Offset: 0x000F7989
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

		// Token: 0x060067F4 RID: 26612 RVA: 0x000F97B7 File Offset: 0x000F79B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x000F97C0 File Offset: 0x000F79C0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challenges_.AddEntriesFrom(ref input, EncircleChallengeUpdateNotify._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04003987 RID: 14727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003988 RID: 14728
		public const int ChallengesFieldNumber = 15;

		// Token: 0x04003989 RID: 14729
		private static readonly FieldCodec<EncircleChallengePb> _repeated_challenges_codec = FieldCodec.ForMessage<EncircleChallengePb>(122U, EncircleChallengePb.Parser);

		// Token: 0x0400398A RID: 14730
		private readonly RepeatedField<EncircleChallengePb> challenges_ = new RepeatedField<EncircleChallengePb>();
	}
}
