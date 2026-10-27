using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200001C RID: 28
	public sealed class AbyssChallengeResultPlayerInfo : IMessage<AbyssChallengeResultPlayerInfo>, IMessage, IEquatable<AbyssChallengeResultPlayerInfo>, IDeepCloneable<AbyssChallengeResultPlayerInfo>, IBufferMessage
	{
		// Token: 0x06001099 RID: 4249 RVA: 0x0002E4E4 File Offset: 0x0002C6E4
		[NullableContext(1)]
		public static AbyssChallengeResultPlayerInfo Create()
		{
			return new AbyssChallengeResultPlayerInfo();
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0002E4EB File Offset: 0x0002C6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssChallengeResultPlayerInfo> Parser
		{
			get
			{
				return AbyssChallengeResultPlayerInfo._parser;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0002E4F2 File Offset: 0x0002C6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x0002E4F5 File Offset: 0x0002C6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeResultPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0002E4FC File Offset: 0x0002C6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultPlayerInfo()
		{
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0002E510 File Offset: 0x0002C710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultPlayerInfo(AbyssChallengeResultPlayerInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.likeCount_ = other.likeCount_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0002E55D File Offset: 0x0002C75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultPlayerInfo Clone()
		{
			return new AbyssChallengeResultPlayerInfo(this);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0002E565 File Offset: 0x0002C765
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0002E56D File Offset: 0x0002C76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0002E576 File Offset: 0x0002C776
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x0002E57E File Offset: 0x0002C77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LikeCount
		{
			get
			{
				return this.likeCount_;
			}
			set
			{
				this.likeCount_ = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0002E587 File Offset: 0x0002C787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeResultRoleInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0002E58F File Offset: 0x0002C78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeResultPlayerInfo);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeResultPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.LikeCount == other.LikeCount && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0002E600 File Offset: 0x0002C800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.LikeCount != 0)
			{
				num ^= this.LikeCount.GetHashCode();
			}
			num ^= this.roleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0002E666 File Offset: 0x0002C866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0002E673 File Offset: 0x0002C873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0002E67C File Offset: 0x0002C87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.LikeCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LikeCount);
			}
			this.roleInfos_.WriteTo(ref output, AbyssChallengeResultPlayerInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0002E6E8 File Offset: 0x0002C8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.LikeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LikeCount);
			}
			num += this.roleInfos_.CalculateSize(AbyssChallengeResultPlayerInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0002E754 File Offset: 0x0002C954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeResultPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.LikeCount != 0)
			{
				this.LikeCount = other.LikeCount;
			}
			this.roleInfos_.Add(other.roleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0002E7B5 File Offset: 0x0002C9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0002E7C0 File Offset: 0x0002C9C0
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.roleInfos_.AddEntriesFrom(ref input, AbyssChallengeResultPlayerInfo._repeated_roleInfos_codec);
						}
					}
					else
					{
						this.LikeCount = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001F1D RID: 7965
		private static readonly MessageParser<AbyssChallengeResultPlayerInfo> _parser = new MessageParser<AbyssChallengeResultPlayerInfo>(() => new AbyssChallengeResultPlayerInfo());

		// Token: 0x04001F1E RID: 7966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F1F RID: 7967
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04001F20 RID: 7968
		private int playerId_;

		// Token: 0x04001F21 RID: 7969
		public const int LikeCountFieldNumber = 2;

		// Token: 0x04001F22 RID: 7970
		private int likeCount_;

		// Token: 0x04001F23 RID: 7971
		public const int RoleInfosFieldNumber = 4;

		// Token: 0x04001F24 RID: 7972
		private static readonly FieldCodec<AbyssChallengeResultRoleInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<AbyssChallengeResultRoleInfo>(34U, AbyssChallengeResultRoleInfo.Parser);

		// Token: 0x04001F25 RID: 7973
		private readonly RepeatedField<AbyssChallengeResultRoleInfo> roleInfos_ = new RepeatedField<AbyssChallengeResultRoleInfo>();
	}
}
