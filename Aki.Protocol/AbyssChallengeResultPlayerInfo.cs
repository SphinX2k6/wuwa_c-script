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
		// Token: 0x060010C4 RID: 4292 RVA: 0x0002EA98 File Offset: 0x0002CC98
		[NullableContext(1)]
		public static AbyssChallengeResultPlayerInfo Create()
		{
			return new AbyssChallengeResultPlayerInfo();
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0002EA9F File Offset: 0x0002CC9F
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
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0002EAA6 File Offset: 0x0002CCA6
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
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0002EAA9 File Offset: 0x0002CCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeResultPlayerInfo.Descriptor;
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0002EAB0 File Offset: 0x0002CCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultPlayerInfo()
		{
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultPlayerInfo(AbyssChallengeResultPlayerInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.likeCount_ = other.likeCount_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0002EB11 File Offset: 0x0002CD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultPlayerInfo Clone()
		{
			return new AbyssChallengeResultPlayerInfo(this);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0002EB19 File Offset: 0x0002CD19
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x0002EB21 File Offset: 0x0002CD21
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
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0002EB2A File Offset: 0x0002CD2A
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0002EB32 File Offset: 0x0002CD32
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
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0002EB3B File Offset: 0x0002CD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeResultRoleInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0002EB43 File Offset: 0x0002CD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeResultPlayerInfo);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0002EB54 File Offset: 0x0002CD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeResultPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.LikeCount == other.LikeCount && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0002EBB4 File Offset: 0x0002CDB4
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

		// Token: 0x060010D3 RID: 4307 RVA: 0x0002EC1A File Offset: 0x0002CE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0002EC27 File Offset: 0x0002CE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0002EC30 File Offset: 0x0002CE30
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

		// Token: 0x060010D6 RID: 4310 RVA: 0x0002EC9C File Offset: 0x0002CE9C
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

		// Token: 0x060010D7 RID: 4311 RVA: 0x0002ED08 File Offset: 0x0002CF08
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

		// Token: 0x060010D8 RID: 4312 RVA: 0x0002ED69 File Offset: 0x0002CF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0002ED74 File Offset: 0x0002CF74
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

		// Token: 0x04001F73 RID: 8051
		private static readonly MessageParser<AbyssChallengeResultPlayerInfo> _parser = new MessageParser<AbyssChallengeResultPlayerInfo>(() => new AbyssChallengeResultPlayerInfo());

		// Token: 0x04001F74 RID: 8052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F75 RID: 8053
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04001F76 RID: 8054
		private int playerId_;

		// Token: 0x04001F77 RID: 8055
		public const int LikeCountFieldNumber = 2;

		// Token: 0x04001F78 RID: 8056
		private int likeCount_;

		// Token: 0x04001F79 RID: 8057
		public const int RoleInfosFieldNumber = 4;

		// Token: 0x04001F7A RID: 8058
		private static readonly FieldCodec<AbyssChallengeResultRoleInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<AbyssChallengeResultRoleInfo>(34U, AbyssChallengeResultRoleInfo.Parser);

		// Token: 0x04001F7B RID: 8059
		private readonly RepeatedField<AbyssChallengeResultRoleInfo> roleInfos_ = new RepeatedField<AbyssChallengeResultRoleInfo>();
	}
}
