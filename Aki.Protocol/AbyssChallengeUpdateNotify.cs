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
		// Token: 0x06001149 RID: 4425 RVA: 0x00030361 File Offset: 0x0002E561
		[NullableContext(1)]
		public static AbyssChallengeUpdateNotify Create()
		{
			return new AbyssChallengeUpdateNotify();
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00030368 File Offset: 0x0002E568
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
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0003036B File Offset: 0x0002E56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00030372 File Offset: 0x0002E572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUpdateNotify()
		{
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00030390 File Offset: 0x0002E590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUpdateNotify(AbyssChallengeUpdateNotify other) : this()
		{
			this.unlockChallengeIds_ = other.unlockChallengeIds_.Clone();
			this.challengeInfos_ = other.challengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x000303CB File Offset: 0x0002E5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUpdateNotify Clone()
		{
			return new AbyssChallengeUpdateNotify(this);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000303D3 File Offset: 0x0002E5D3
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
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x000303DB File Offset: 0x0002E5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallenge> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x000303E3 File Offset: 0x0002E5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeUpdateNotify);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x000303F4 File Offset: 0x0002E5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockChallengeIds_.Equals(other.unlockChallengeIds_) && this.challengeInfos_.Equals(other.challengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00030448 File Offset: 0x0002E648
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

		// Token: 0x06001154 RID: 4436 RVA: 0x0003048A File Offset: 0x0002E68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00030497 File Offset: 0x0002E697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x000304A0 File Offset: 0x0002E6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockChallengeIds_.WriteTo(ref output, AbyssChallengeUpdateNotify._repeated_unlockChallengeIds_codec);
			this.challengeInfos_.WriteTo(ref output, AbyssChallengeUpdateNotify._repeated_challengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x000304D8 File Offset: 0x0002E6D8
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

		// Token: 0x06001158 RID: 4440 RVA: 0x00030524 File Offset: 0x0002E724
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

		// Token: 0x06001159 RID: 4441 RVA: 0x00030563 File Offset: 0x0002E763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0003056C File Offset: 0x0002E76C
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
				if (num != 56U && num != 58U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.challengeInfos_.AddEntriesFrom(ref input, AbyssChallengeUpdateNotify._repeated_challengeInfos_codec);
					}
				}
				else
				{
					this.unlockChallengeIds_.AddEntriesFrom(ref input, AbyssChallengeUpdateNotify._repeated_unlockChallengeIds_codec);
				}
			}
		}

		// Token: 0x04001F6B RID: 8043
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F6C RID: 8044
		public const int UnlockChallengeIdsFieldNumber = 7;

		// Token: 0x04001F6D RID: 8045
		private static readonly FieldCodec<int> _repeated_unlockChallengeIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04001F6E RID: 8046
		private readonly RepeatedField<int> unlockChallengeIds_ = new RepeatedField<int>();

		// Token: 0x04001F6F RID: 8047
		public const int ChallengeInfosFieldNumber = 14;

		// Token: 0x04001F70 RID: 8048
		private static readonly FieldCodec<AbyssChallenge> _repeated_challengeInfos_codec = FieldCodec.ForMessage<AbyssChallenge>(114U, AbyssChallenge.Parser);

		// Token: 0x04001F71 RID: 8049
		private readonly RepeatedField<AbyssChallenge> challengeInfos_ = new RepeatedField<AbyssChallenge>();
	}
}
