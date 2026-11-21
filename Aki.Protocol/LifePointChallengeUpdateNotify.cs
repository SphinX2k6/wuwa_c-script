using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000908 RID: 2312
	[NetMessage(EMessageId.LifePointChallengeUpdateNotify)]
	public sealed class LifePointChallengeUpdateNotify : IMessage<LifePointChallengeUpdateNotify>, IMessage, IEquatable<LifePointChallengeUpdateNotify>, IDeepCloneable<LifePointChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600CC6A RID: 52330 RVA: 0x001E24F5 File Offset: 0x001E06F5
		[NullableContext(1)]
		public static LifePointChallengeUpdateNotify Create()
		{
			return new LifePointChallengeUpdateNotify();
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x0600CC6B RID: 52331 RVA: 0x001E24FC File Offset: 0x001E06FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x0600CC6C RID: 52332 RVA: 0x001E24FF File Offset: 0x001E06FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x001E2506 File Offset: 0x001E0706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeUpdateNotify()
		{
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x001E2519 File Offset: 0x001E0719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeUpdateNotify(LifePointChallengeUpdateNotify other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC6F RID: 52335 RVA: 0x001E2543 File Offset: 0x001E0743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeUpdateNotify Clone()
		{
			return new LifePointChallengeUpdateNotify(this);
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x0600CC70 RID: 52336 RVA: 0x001E254B File Offset: 0x001E074B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifePointChallengeData> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600CC71 RID: 52337 RVA: 0x001E2553 File Offset: 0x001E0753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeUpdateNotify);
		}

		// Token: 0x0600CC72 RID: 52338 RVA: 0x001E2561 File Offset: 0x001E0761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC73 RID: 52339 RVA: 0x001E2594 File Offset: 0x001E0794
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

		// Token: 0x0600CC74 RID: 52340 RVA: 0x001E25C8 File Offset: 0x001E07C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC75 RID: 52341 RVA: 0x001E25D5 File Offset: 0x001E07D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC76 RID: 52342 RVA: 0x001E25DE File Offset: 0x001E07DE
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

		// Token: 0x0600CC77 RID: 52343 RVA: 0x001E2608 File Offset: 0x001E0808
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

		// Token: 0x0600CC78 RID: 52344 RVA: 0x001E2641 File Offset: 0x001E0841
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

		// Token: 0x0600CC79 RID: 52345 RVA: 0x001E266F File Offset: 0x001E086F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x001E2678 File Offset: 0x001E0878
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challenges_.AddEntriesFrom(ref input, LifePointChallengeUpdateNotify._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04005702 RID: 22274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005703 RID: 22275
		public const int ChallengesFieldNumber = 14;

		// Token: 0x04005704 RID: 22276
		private static readonly FieldCodec<LifePointChallengeData> _repeated_challenges_codec = FieldCodec.ForMessage<LifePointChallengeData>(114U, LifePointChallengeData.Parser);

		// Token: 0x04005705 RID: 22277
		private readonly RepeatedField<LifePointChallengeData> challenges_ = new RepeatedField<LifePointChallengeData>();
	}
}
