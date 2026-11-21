using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000911 RID: 2321
	[NetMessage(EMessageId.LineCrossActivityUpdateNotify)]
	public sealed class LineCrossActivityUpdateNotify : IMessage<LineCrossActivityUpdateNotify>, IMessage, IEquatable<LineCrossActivityUpdateNotify>, IDeepCloneable<LineCrossActivityUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600CD26 RID: 52518 RVA: 0x001E4015 File Offset: 0x001E2215
		[NullableContext(1)]
		public static LineCrossActivityUpdateNotify Create()
		{
			return new LineCrossActivityUpdateNotify();
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600CD27 RID: 52519 RVA: 0x001E401C File Offset: 0x001E221C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600CD28 RID: 52520 RVA: 0x001E401F File Offset: 0x001E221F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossActivityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600CD29 RID: 52521 RVA: 0x001E4026 File Offset: 0x001E2226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityUpdateNotify()
		{
		}

		// Token: 0x0600CD2A RID: 52522 RVA: 0x001E4039 File Offset: 0x001E2239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityUpdateNotify(LineCrossActivityUpdateNotify other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD2B RID: 52523 RVA: 0x001E4063 File Offset: 0x001E2263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityUpdateNotify Clone()
		{
			return new LineCrossActivityUpdateNotify(this);
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600CD2C RID: 52524 RVA: 0x001E406B File Offset: 0x001E226B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineCrossChallengeData> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x001E4073 File Offset: 0x001E2273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossActivityUpdateNotify);
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x001E4081 File Offset: 0x001E2281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossActivityUpdateNotify other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x001E40B4 File Offset: 0x001E22B4
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

		// Token: 0x0600CD30 RID: 52528 RVA: 0x001E40E8 File Offset: 0x001E22E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD31 RID: 52529 RVA: 0x001E40F5 File Offset: 0x001E22F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD32 RID: 52530 RVA: 0x001E40FE File Offset: 0x001E22FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, LineCrossActivityUpdateNotify._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD33 RID: 52531 RVA: 0x001E4128 File Offset: 0x001E2328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(LineCrossActivityUpdateNotify._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD34 RID: 52532 RVA: 0x001E4161 File Offset: 0x001E2361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineCrossActivityUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD35 RID: 52533 RVA: 0x001E418F File Offset: 0x001E238F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD36 RID: 52534 RVA: 0x001E4198 File Offset: 0x001E2398
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
					this.challenges_.AddEntriesFrom(ref input, LineCrossActivityUpdateNotify._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04005737 RID: 22327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005738 RID: 22328
		public const int ChallengesFieldNumber = 6;

		// Token: 0x04005739 RID: 22329
		private static readonly FieldCodec<LineCrossChallengeData> _repeated_challenges_codec = FieldCodec.ForMessage<LineCrossChallengeData>(50U, LineCrossChallengeData.Parser);

		// Token: 0x0400573A RID: 22330
		private readonly RepeatedField<LineCrossChallengeData> challenges_ = new RepeatedField<LineCrossChallengeData>();
	}
}
