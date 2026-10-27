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
		// Token: 0x060010B0 RID: 4272 RVA: 0x0002E85C File Offset: 0x0002CA5C
		[NullableContext(1)]
		public static AbyssChallengeResultRoleInfo Create()
		{
			return new AbyssChallengeResultRoleInfo();
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0002E863 File Offset: 0x0002CA63
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
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0002E86A File Offset: 0x0002CA6A
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
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0002E86D File Offset: 0x0002CA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeResultRoleInfo.Descriptor;
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0002E874 File Offset: 0x0002CA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultRoleInfo()
		{
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0002E888 File Offset: 0x0002CA88
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

		// Token: 0x060010B6 RID: 4278 RVA: 0x0002E8FD File Offset: 0x0002CAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultRoleInfo Clone()
		{
			return new AbyssChallengeResultRoleInfo(this);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0002E905 File Offset: 0x0002CB05
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x0002E90D File Offset: 0x0002CB0D
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
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0002E916 File Offset: 0x0002CB16
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x0002E91E File Offset: 0x0002CB1E
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
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0002E927 File Offset: 0x0002CB27
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0002E92F File Offset: 0x0002CB2F
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
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x0002E938 File Offset: 0x0002CB38
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x0002E940 File Offset: 0x0002CB40
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
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0002E949 File Offset: 0x0002CB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeRoleHonor> OtherHonor
		{
			get
			{
				return this.otherHonor_;
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0002E951 File Offset: 0x0002CB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeResultRoleInfo);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0002E960 File Offset: 0x0002CB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeResultRoleInfo other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.RoleLevel == other.RoleLevel && this.LittleRoleId == other.LittleRoleId && object.Equals(this.MainHonor, other.MainHonor) && this.otherHonor_.Equals(other.otherHonor_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
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

		// Token: 0x060010C3 RID: 4291 RVA: 0x0002EA79 File Offset: 0x0002CC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0002EA86 File Offset: 0x0002CC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0002EA90 File Offset: 0x0002CC90
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

		// Token: 0x060010C6 RID: 4294 RVA: 0x0002EB34 File Offset: 0x0002CD34
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

		// Token: 0x060010C7 RID: 4295 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
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

		// Token: 0x060010C8 RID: 4296 RVA: 0x0002EC71 File Offset: 0x0002CE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0002EC7C File Offset: 0x0002CE7C
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

		// Token: 0x04001F26 RID: 7974
		private static readonly MessageParser<AbyssChallengeResultRoleInfo> _parser = new MessageParser<AbyssChallengeResultRoleInfo>(() => new AbyssChallengeResultRoleInfo());

		// Token: 0x04001F27 RID: 7975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F28 RID: 7976
		public const int RoleSkinIdFieldNumber = 1;

		// Token: 0x04001F29 RID: 7977
		private int roleSkinId_;

		// Token: 0x04001F2A RID: 7978
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x04001F2B RID: 7979
		private int roleLevel_;

		// Token: 0x04001F2C RID: 7980
		public const int LittleRoleIdFieldNumber = 3;

		// Token: 0x04001F2D RID: 7981
		private int littleRoleId_;

		// Token: 0x04001F2E RID: 7982
		public const int MainHonorFieldNumber = 4;

		// Token: 0x04001F2F RID: 7983
		private AbyssChallengeRoleHonor mainHonor_;

		// Token: 0x04001F30 RID: 7984
		public const int OtherHonorFieldNumber = 5;

		// Token: 0x04001F31 RID: 7985
		private static readonly FieldCodec<AbyssChallengeRoleHonor> _repeated_otherHonor_codec = FieldCodec.ForMessage<AbyssChallengeRoleHonor>(42U, AbyssChallengeRoleHonor.Parser);

		// Token: 0x04001F32 RID: 7986
		private readonly RepeatedField<AbyssChallengeRoleHonor> otherHonor_ = new RepeatedField<AbyssChallengeRoleHonor>();
	}
}
