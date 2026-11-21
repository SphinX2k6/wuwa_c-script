using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000023 RID: 35
	[NetMessage(EMessageId.AbyssChallengeUpdateNotify)]
	public sealed class AbyssChallengeUpdateNotify : IMessage<AbyssChallengeUpdateNotify>, IMessage, IEquatable<AbyssChallengeUpdateNotify>, IDeepCloneable<AbyssChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001174 RID: 4468 RVA: 0x00030915 File Offset: 0x0002EB15
		[NullableContext(1)]
		public static AbyssChallengeUpdateNotify Create()
		{
			return new AbyssChallengeUpdateNotify();
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0003091C File Offset: 0x0002EB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x0003091F File Offset: 0x0002EB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00030926 File Offset: 0x0002EB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUpdateNotify()
		{
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00030944 File Offset: 0x0002EB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUpdateNotify(AbyssChallengeUpdateNotify other) : this()
		{
			this.unlockChallengeIds_ = other.unlockChallengeIds_.Clone();
			this.challengeInfos_ = other.challengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0003097F File Offset: 0x0002EB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUpdateNotify Clone()
		{
			return new AbyssChallengeUpdateNotify(this);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00030987 File Offset: 0x0002EB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockChallengeIds
		{
			get
			{
				return this.unlockChallengeIds_;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0003098F File Offset: 0x0002EB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallenge> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00030997 File Offset: 0x0002EB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeUpdateNotify);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000309A8 File Offset: 0x0002EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockChallengeIds_.Equals(other.unlockChallengeIds_) && this.challengeInfos_.Equals(other.challengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000309FC File Offset: 0x0002EBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockChallengeIds_.GetHashCode();
			num ^= this.challengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00030A3E File Offset: 0x0002EC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00030A4B File Offset: 0x0002EC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00030A54 File Offset: 0x0002EC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeInfos_.WriteTo(ref output, AbyssChallengeUpdateNotify._repeated_challengeInfos_codec);
			this.unlockChallengeIds_.WriteTo(ref output, AbyssChallengeUpdateNotify._repeated_unlockChallengeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00030A8C File Offset: 0x0002EC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockChallengeIds_.CalculateSize(AbyssChallengeUpdateNotify._repeated_unlockChallengeIds_codec);
			num += this.challengeInfos_.CalculateSize(AbyssChallengeUpdateNotify._repeated_challengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockChallengeIds_.Add(other.unlockChallengeIds_);
			this.challengeInfos_.Add(other.challengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00030B17 File Offset: 0x0002ED17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00030B20 File Offset: 0x0002ED20
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
				if (num != 42U)
				{
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unlockChallengeIds_.AddEntriesFrom(ref input, AbyssChallengeUpdateNotify._repeated_unlockChallengeIds_codec);
					}
				}
				else
				{
					this.challengeInfos_.AddEntriesFrom(ref input, AbyssChallengeUpdateNotify._repeated_challengeInfos_codec);
				}
			}
		}

		// Token: 0x04001FC1 RID: 8129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FC2 RID: 8130
		public const int UnlockChallengeIdsFieldNumber = 6;

		// Token: 0x04001FC3 RID: 8131
		private static readonly FieldCodec<int> _repeated_unlockChallengeIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04001FC4 RID: 8132
		private readonly RepeatedField<int> unlockChallengeIds_ = new RepeatedField<int>();

		// Token: 0x04001FC5 RID: 8133
		public const int ChallengeInfosFieldNumber = 5;

		// Token: 0x04001FC6 RID: 8134
		private static readonly FieldCodec<AbyssChallenge> _repeated_challengeInfos_codec = FieldCodec.ForMessage<AbyssChallenge>(42U, AbyssChallenge.Parser);

		// Token: 0x04001FC7 RID: 8135
		private readonly RepeatedField<AbyssChallenge> challengeInfos_ = new RepeatedField<AbyssChallenge>();
	}
}
