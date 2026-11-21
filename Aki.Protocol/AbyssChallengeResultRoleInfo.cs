using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200001D RID: 29
	public sealed class AbyssChallengeResultRoleInfo : IMessage<AbyssChallengeResultRoleInfo>, IMessage, IEquatable<AbyssChallengeResultRoleInfo>, IDeepCloneable<AbyssChallengeResultRoleInfo>, IBufferMessage
	{
		// Token: 0x060010DB RID: 4315 RVA: 0x0002EE10 File Offset: 0x0002D010
		[NullableContext(1)]
		public static AbyssChallengeResultRoleInfo Create()
		{
			return new AbyssChallengeResultRoleInfo();
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0002EE17 File Offset: 0x0002D017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssChallengeResultRoleInfo> Parser
		{
			get
			{
				return AbyssChallengeResultRoleInfo._parser;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0002EE1E File Offset: 0x0002D01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0002EE21 File Offset: 0x0002D021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeResultRoleInfo.Descriptor;
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0002EE28 File Offset: 0x0002D028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultRoleInfo()
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0002EE3C File Offset: 0x0002D03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultRoleInfo(AbyssChallengeResultRoleInfo other) : this()
		{
			this.roleSkinId_ = other.roleSkinId_;
			this.roleLevel_ = other.roleLevel_;
			this.littleRoleId_ = other.littleRoleId_;
			this.mainHonor_ = ((other.mainHonor_ != null) ? other.mainHonor_.Clone() : null);
			this.otherHonor_ = other.otherHonor_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0002EEB1 File Offset: 0x0002D0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultRoleInfo Clone()
		{
			return new AbyssChallengeResultRoleInfo(this);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x0002EEB9 File Offset: 0x0002D0B9
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x0002EEC1 File Offset: 0x0002D0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0002EECA File Offset: 0x0002D0CA
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x0002EED2 File Offset: 0x0002D0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0002EEDB File Offset: 0x0002D0DB
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0002EEE3 File Offset: 0x0002D0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LittleRoleId
		{
			get
			{
				return this.littleRoleId_;
			}
			set
			{
				this.littleRoleId_ = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0002EEEC File Offset: 0x0002D0EC
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x0002EEF4 File Offset: 0x0002D0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoleHonor MainHonor
		{
			get
			{
				return this.mainHonor_;
			}
			set
			{
				this.mainHonor_ = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0002EEFD File Offset: 0x0002D0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeRoleHonor> OtherHonor
		{
			get
			{
				return this.otherHonor_;
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0002EF05 File Offset: 0x0002D105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeResultRoleInfo);
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0002EF14 File Offset: 0x0002D114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeResultRoleInfo other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.RoleLevel == other.RoleLevel && this.LittleRoleId == other.LittleRoleId && object.Equals(this.MainHonor, other.MainHonor) && this.otherHonor_.Equals(other.otherHonor_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0002EF98 File Offset: 0x0002D198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.LittleRoleId != 0)
			{
				num ^= this.LittleRoleId.GetHashCode();
			}
			if (this.mainHonor_ != null)
			{
				num ^= this.MainHonor.GetHashCode();
			}
			num ^= this.otherHonor_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0002F02D File Offset: 0x0002D22D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0002F03A File Offset: 0x0002D23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0002F044 File Offset: 0x0002D244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.LittleRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LittleRoleId);
			}
			if (this.mainHonor_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MainHonor);
			}
			this.otherHonor_.WriteTo(ref output, AbyssChallengeResultRoleInfo._repeated_otherHonor_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.LittleRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LittleRoleId);
			}
			if (this.mainHonor_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MainHonor);
			}
			num += this.otherHonor_.CalculateSize(AbyssChallengeResultRoleInfo._repeated_otherHonor_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0002F184 File Offset: 0x0002D384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeResultRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.LittleRoleId != 0)
			{
				this.LittleRoleId = other.LittleRoleId;
			}
			if (other.mainHonor_ != null)
			{
				if (this.mainHonor_ == null)
				{
					this.MainHonor = new AbyssChallengeRoleHonor();
				}
				this.MainHonor.MergeFrom(other.MainHonor);
			}
			this.otherHonor_.Add(other.otherHonor_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0002F225 File Offset: 0x0002D425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0002F230 File Offset: 0x0002D430
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoleSkinId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RoleLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.LittleRoleId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.mainHonor_ == null)
						{
							this.MainHonor = new AbyssChallengeRoleHonor();
						}
						input.ReadMessage(this.MainHonor);
						continue;
					}
					if (num == 42U)
					{
						this.otherHonor_.AddEntriesFrom(ref input, AbyssChallengeResultRoleInfo._repeated_otherHonor_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F7C RID: 8060
		private static readonly MessageParser<AbyssChallengeResultRoleInfo> _parser = new MessageParser<AbyssChallengeResultRoleInfo>(() => new AbyssChallengeResultRoleInfo());

		// Token: 0x04001F7D RID: 8061
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F7E RID: 8062
		public const int RoleSkinIdFieldNumber = 1;

		// Token: 0x04001F7F RID: 8063
		private int roleSkinId_;

		// Token: 0x04001F80 RID: 8064
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x04001F81 RID: 8065
		private int roleLevel_;

		// Token: 0x04001F82 RID: 8066
		public const int LittleRoleIdFieldNumber = 3;

		// Token: 0x04001F83 RID: 8067
		private int littleRoleId_;

		// Token: 0x04001F84 RID: 8068
		public const int MainHonorFieldNumber = 4;

		// Token: 0x04001F85 RID: 8069
		private AbyssChallengeRoleHonor mainHonor_;

		// Token: 0x04001F86 RID: 8070
		public const int OtherHonorFieldNumber = 5;

		// Token: 0x04001F87 RID: 8071
		private static readonly FieldCodec<AbyssChallengeRoleHonor> _repeated_otherHonor_codec = FieldCodec.ForMessage<AbyssChallengeRoleHonor>(42U, AbyssChallengeRoleHonor.Parser);

		// Token: 0x04001F88 RID: 8072
		private readonly RepeatedField<AbyssChallengeRoleHonor> otherHonor_ = new RepeatedField<AbyssChallengeRoleHonor>();
	}
}
