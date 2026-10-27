using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000919 RID: 2329
	[NetMessage(EMessageId.LifePointChallengeUpdateNotify)]
	public sealed class LifePointChallengeUpdateNotify : IMessage<LifePointChallengeUpdateNotify>, IMessage, IEquatable<LifePointChallengeUpdateNotify>, IDeepCloneable<LifePointChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600CD86 RID: 52614 RVA: 0x001E47C5 File Offset: 0x001E29C5
		[NullableContext(1)]
		public static LifePointChallengeUpdateNotify Create()
		{
			return new LifePointChallengeUpdateNotify();
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x0600CD87 RID: 52615 RVA: 0x001E47CC File Offset: 0x001E29CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x0600CD88 RID: 52616 RVA: 0x001E47CF File Offset: 0x001E29CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600CD89 RID: 52617 RVA: 0x001E47D6 File Offset: 0x001E29D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeUpdateNotify()
		{
		}

		// Token: 0x0600CD8A RID: 52618 RVA: 0x001E47E9 File Offset: 0x001E29E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeUpdateNotify(LifePointChallengeUpdateNotify other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD8B RID: 52619 RVA: 0x001E4813 File Offset: 0x001E2A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeUpdateNotify Clone()
		{
			return new LifePointChallengeUpdateNotify(this);
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x0600CD8C RID: 52620 RVA: 0x001E481B File Offset: 0x001E2A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifePointChallengeData> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600CD8D RID: 52621 RVA: 0x001E4823 File Offset: 0x001E2A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeUpdateNotify);
		}

		// Token: 0x0600CD8E RID: 52622 RVA: 0x001E4831 File Offset: 0x001E2A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD8F RID: 52623 RVA: 0x001E4864 File Offset: 0x001E2A64
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

		// Token: 0x0600CD90 RID: 52624 RVA: 0x001E4898 File Offset: 0x001E2A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD91 RID: 52625 RVA: 0x001E48A5 File Offset: 0x001E2AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD92 RID: 52626 RVA: 0x001E48AE File Offset: 0x001E2AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, LifePointChallengeUpdateNotify._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD93 RID: 52627 RVA: 0x001E48D8 File Offset: 0x001E2AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(LifePointChallengeUpdateNotify._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD94 RID: 52628 RVA: 0x001E4911 File Offset: 0x001E2B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifePointChallengeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD95 RID: 52629 RVA: 0x001E493F File Offset: 0x001E2B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD96 RID: 52630 RVA: 0x001E4948 File Offset: 0x001E2B48
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challenges_.AddEntriesFrom(ref input, LifePointChallengeUpdateNotify._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x040056FB RID: 22267
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056FC RID: 22268
		public const int ChallengesFieldNumber = 11;

		// Token: 0x040056FD RID: 22269
		private static readonly FieldCodec<LifePointChallengeData> _repeated_challenges_codec = FieldCodec.ForMessage<LifePointChallengeData>(90U, LifePointChallengeData.Parser);

		// Token: 0x040056FE RID: 22270
		private readonly RepeatedField<LifePointChallengeData> challenges_ = new RepeatedField<LifePointChallengeData>();
	}
}
