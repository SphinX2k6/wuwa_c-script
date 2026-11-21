using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB7 RID: 4023
	[NetMessage(EMessageId.RoguelikeTrialRoleInfoResponse)]
	public sealed class RoguelikeTrialRoleInfoResponse : IMessage<RoguelikeTrialRoleInfoResponse>, IMessage, IEquatable<RoguelikeTrialRoleInfoResponse>, IDeepCloneable<RoguelikeTrialRoleInfoResponse>, IBufferMessage
	{
		// Token: 0x06015892 RID: 88210 RVA: 0x00320D98 File Offset: 0x0031EF98
		[NullableContext(1)]
		public static RoguelikeTrialRoleInfoResponse Create()
		{
			return new RoguelikeTrialRoleInfoResponse();
		}

		// Token: 0x170047D5 RID: 18389
		// (get) Token: 0x06015893 RID: 88211 RVA: 0x00320D9F File Offset: 0x0031EF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047D6 RID: 18390
		// (get) Token: 0x06015894 RID: 88212 RVA: 0x00320DA2 File Offset: 0x0031EFA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTrialRoleInfoResponse.Descriptor;
			}
		}

		// Token: 0x06015895 RID: 88213 RVA: 0x00320DA9 File Offset: 0x0031EFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoResponse()
		{
		}

		// Token: 0x06015896 RID: 88214 RVA: 0x00320DC8 File Offset: 0x0031EFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoResponse(RoguelikeTrialRoleInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.validTrialRoleIds_ = other.validTrialRoleIds_.Clone();
			this.addLevel_ = other.addLevel_;
			this.maxLevel_ = other.maxLevel_;
			this.roleLevel_ = other.roleLevel_;
			this.weaponLevel_ = other.weaponLevel_;
			this.rogueInstRoleDatas_ = other.rogueInstRoleDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015897 RID: 88215 RVA: 0x00320E4A File Offset: 0x0031F04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoResponse Clone()
		{
			return new RoguelikeTrialRoleInfoResponse(this);
		}

		// Token: 0x170047D7 RID: 18391
		// (get) Token: 0x06015898 RID: 88216 RVA: 0x00320E52 File Offset: 0x0031F052
		// (set) Token: 0x06015899 RID: 88217 RVA: 0x00320E5A File Offset: 0x0031F05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170047D8 RID: 18392
		// (get) Token: 0x0601589A RID: 88218 RVA: 0x00320E63 File Offset: 0x0031F063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ValidTrialRoleIds
		{
			get
			{
				return this.validTrialRoleIds_;
			}
		}

		// Token: 0x170047D9 RID: 18393
		// (get) Token: 0x0601589B RID: 88219 RVA: 0x00320E6B File Offset: 0x0031F06B
		// (set) Token: 0x0601589C RID: 88220 RVA: 0x00320E73 File Offset: 0x0031F073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddLevel
		{
			get
			{
				return this.addLevel_;
			}
			set
			{
				this.addLevel_ = value;
			}
		}

		// Token: 0x170047DA RID: 18394
		// (get) Token: 0x0601589D RID: 88221 RVA: 0x00320E7C File Offset: 0x0031F07C
		// (set) Token: 0x0601589E RID: 88222 RVA: 0x00320E84 File Offset: 0x0031F084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLevel
		{
			get
			{
				return this.maxLevel_;
			}
			set
			{
				this.maxLevel_ = value;
			}
		}

		// Token: 0x170047DB RID: 18395
		// (get) Token: 0x0601589F RID: 88223 RVA: 0x00320E8D File Offset: 0x0031F08D
		// (set) Token: 0x060158A0 RID: 88224 RVA: 0x00320E95 File Offset: 0x0031F095
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

		// Token: 0x170047DC RID: 18396
		// (get) Token: 0x060158A1 RID: 88225 RVA: 0x00320E9E File Offset: 0x0031F09E
		// (set) Token: 0x060158A2 RID: 88226 RVA: 0x00320EA6 File Offset: 0x0031F0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponLevel
		{
			get
			{
				return this.weaponLevel_;
			}
			set
			{
				this.weaponLevel_ = value;
			}
		}

		// Token: 0x170047DD RID: 18397
		// (get) Token: 0x060158A3 RID: 88227 RVA: 0x00320EAF File Offset: 0x0031F0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueInstRoleData> RogueInstRoleDatas
		{
			get
			{
				return this.rogueInstRoleDatas_;
			}
		}

		// Token: 0x060158A4 RID: 88228 RVA: 0x00320EB7 File Offset: 0x0031F0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTrialRoleInfoResponse);
		}

		// Token: 0x060158A5 RID: 88229 RVA: 0x00320EC8 File Offset: 0x0031F0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTrialRoleInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.validTrialRoleIds_.Equals(other.validTrialRoleIds_) && this.AddLevel == other.AddLevel && this.MaxLevel == other.MaxLevel && this.RoleLevel == other.RoleLevel && this.WeaponLevel == other.WeaponLevel && this.rogueInstRoleDatas_.Equals(other.rogueInstRoleDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158A6 RID: 88230 RVA: 0x00320F6C File Offset: 0x0031F16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.validTrialRoleIds_.GetHashCode();
			if (this.AddLevel != 0)
			{
				num ^= this.AddLevel.GetHashCode();
			}
			if (this.MaxLevel != 0)
			{
				num ^= this.MaxLevel.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.WeaponLevel != 0)
			{
				num ^= this.WeaponLevel.GetHashCode();
			}
			num ^= this.rogueInstRoleDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060158A7 RID: 88231 RVA: 0x00321031 File Offset: 0x0031F231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158A8 RID: 88232 RVA: 0x0032103E File Offset: 0x0031F23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158A9 RID: 88233 RVA: 0x00321048 File Offset: 0x0031F248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AddLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AddLevel);
			}
			this.validTrialRoleIds_.WriteTo(ref output, RoguelikeTrialRoleInfoResponse._repeated_validTrialRoleIds_codec);
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.MaxLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxLevel);
			}
			if (this.WeaponLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponLevel);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rogueInstRoleDatas_.WriteTo(ref output, RoguelikeTrialRoleInfoResponse._repeated_rogueInstRoleDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060158AA RID: 88234 RVA: 0x00321118 File Offset: 0x0031F318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.validTrialRoleIds_.CalculateSize(RoguelikeTrialRoleInfoResponse._repeated_validTrialRoleIds_codec);
			if (this.AddLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddLevel);
			}
			if (this.MaxLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLevel);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.WeaponLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponLevel);
			}
			num += this.rogueInstRoleDatas_.CalculateSize(RoguelikeTrialRoleInfoResponse._repeated_rogueInstRoleDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060158AB RID: 88235 RVA: 0x003211DC File Offset: 0x0031F3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTrialRoleInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.validTrialRoleIds_.Add(other.validTrialRoleIds_);
			if (other.AddLevel != 0)
			{
				this.AddLevel = other.AddLevel;
			}
			if (other.MaxLevel != 0)
			{
				this.MaxLevel = other.MaxLevel;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.WeaponLevel != 0)
			{
				this.WeaponLevel = other.WeaponLevel;
			}
			this.rogueInstRoleDatas_.Add(other.rogueInstRoleDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060158AC RID: 88236 RVA: 0x0032128A File Offset: 0x0031F48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158AD RID: 88237 RVA: 0x00321294 File Offset: 0x0031F494
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.AddLevel = input.ReadInt32();
							continue;
						}
						if (num != 16U)
						{
							goto IL_48;
						}
					}
					else if (num != 18U)
					{
						if (num != 32U)
						{
							goto IL_48;
						}
						this.RoleLevel = input.ReadInt32();
						continue;
					}
					this.validTrialRoleIds_.AddEntriesFrom(ref input, RoguelikeTrialRoleInfoResponse._repeated_validTrialRoleIds_codec);
					continue;
				}
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.MaxLevel = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.WeaponLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 114U)
					{
						this.rogueInstRoleDatas_.AddEntriesFrom(ref input, RoguelikeTrialRoleInfoResponse._repeated_rogueInstRoleDatas_codec);
						continue;
					}
				}
				IL_48:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040081DB RID: 33243
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081DC RID: 33244
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040081DD RID: 33245
		private ErrorCode errorCode_;

		// Token: 0x040081DE RID: 33246
		public const int ValidTrialRoleIdsFieldNumber = 2;

		// Token: 0x040081DF RID: 33247
		private static readonly FieldCodec<int> _repeated_validTrialRoleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040081E0 RID: 33248
		private readonly RepeatedField<int> validTrialRoleIds_ = new RepeatedField<int>();

		// Token: 0x040081E1 RID: 33249
		public const int AddLevelFieldNumber = 1;

		// Token: 0x040081E2 RID: 33250
		private int addLevel_;

		// Token: 0x040081E3 RID: 33251
		public const int MaxLevelFieldNumber = 5;

		// Token: 0x040081E4 RID: 33252
		private int maxLevel_;

		// Token: 0x040081E5 RID: 33253
		public const int RoleLevelFieldNumber = 4;

		// Token: 0x040081E6 RID: 33254
		private int roleLevel_;

		// Token: 0x040081E7 RID: 33255
		public const int WeaponLevelFieldNumber = 6;

		// Token: 0x040081E8 RID: 33256
		private int weaponLevel_;

		// Token: 0x040081E9 RID: 33257
		public const int RogueInstRoleDatasFieldNumber = 14;

		// Token: 0x040081EA RID: 33258
		private static readonly FieldCodec<RogueInstRoleData> _repeated_rogueInstRoleDatas_codec = FieldCodec.ForMessage<RogueInstRoleData>(114U, RogueInstRoleData.Parser);

		// Token: 0x040081EB RID: 33259
		private readonly RepeatedField<RogueInstRoleData> rogueInstRoleDatas_ = new RepeatedField<RogueInstRoleData>();
	}
}
