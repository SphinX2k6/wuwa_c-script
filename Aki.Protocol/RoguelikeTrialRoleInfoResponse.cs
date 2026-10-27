using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC7 RID: 4039
	[NetMessage(EMessageId.RoguelikeTrialRoleInfoResponse)]
	public sealed class RoguelikeTrialRoleInfoResponse : IMessage<RoguelikeTrialRoleInfoResponse>, IMessage, IEquatable<RoguelikeTrialRoleInfoResponse>, IDeepCloneable<RoguelikeTrialRoleInfoResponse>, IBufferMessage
	{
		// Token: 0x06015977 RID: 88439 RVA: 0x0032244C File Offset: 0x0032064C
		[NullableContext(1)]
		public static RoguelikeTrialRoleInfoResponse Create()
		{
			return new RoguelikeTrialRoleInfoResponse();
		}

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x06015978 RID: 88440 RVA: 0x00322453 File Offset: 0x00320653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x06015979 RID: 88441 RVA: 0x00322456 File Offset: 0x00320656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTrialRoleInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601597A RID: 88442 RVA: 0x0032245D File Offset: 0x0032065D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoResponse()
		{
		}

		// Token: 0x0601597B RID: 88443 RVA: 0x0032247C File Offset: 0x0032067C
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

		// Token: 0x0601597C RID: 88444 RVA: 0x003224FE File Offset: 0x003206FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoResponse Clone()
		{
			return new RoguelikeTrialRoleInfoResponse(this);
		}

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x0601597D RID: 88445 RVA: 0x00322506 File Offset: 0x00320706
		// (set) Token: 0x0601597E RID: 88446 RVA: 0x0032250E File Offset: 0x0032070E
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

		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x0601597F RID: 88447 RVA: 0x00322517 File Offset: 0x00320717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ValidTrialRoleIds
		{
			get
			{
				return this.validTrialRoleIds_;
			}
		}

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x06015980 RID: 88448 RVA: 0x0032251F File Offset: 0x0032071F
		// (set) Token: 0x06015981 RID: 88449 RVA: 0x00322527 File Offset: 0x00320727
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

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x06015982 RID: 88450 RVA: 0x00322530 File Offset: 0x00320730
		// (set) Token: 0x06015983 RID: 88451 RVA: 0x00322538 File Offset: 0x00320738
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

		// Token: 0x17004805 RID: 18437
		// (get) Token: 0x06015984 RID: 88452 RVA: 0x00322541 File Offset: 0x00320741
		// (set) Token: 0x06015985 RID: 88453 RVA: 0x00322549 File Offset: 0x00320749
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

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x06015986 RID: 88454 RVA: 0x00322552 File Offset: 0x00320752
		// (set) Token: 0x06015987 RID: 88455 RVA: 0x0032255A File Offset: 0x0032075A
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

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x06015988 RID: 88456 RVA: 0x00322563 File Offset: 0x00320763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueInstRoleData> RogueInstRoleDatas
		{
			get
			{
				return this.rogueInstRoleDatas_;
			}
		}

		// Token: 0x06015989 RID: 88457 RVA: 0x0032256B File Offset: 0x0032076B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTrialRoleInfoResponse);
		}

		// Token: 0x0601598A RID: 88458 RVA: 0x0032257C File Offset: 0x0032077C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTrialRoleInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.validTrialRoleIds_.Equals(other.validTrialRoleIds_) && this.AddLevel == other.AddLevel && this.MaxLevel == other.MaxLevel && this.RoleLevel == other.RoleLevel && this.WeaponLevel == other.WeaponLevel && this.rogueInstRoleDatas_.Equals(other.rogueInstRoleDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601598B RID: 88459 RVA: 0x00322620 File Offset: 0x00320820
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

		// Token: 0x0601598C RID: 88460 RVA: 0x003226E5 File Offset: 0x003208E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601598D RID: 88461 RVA: 0x003226F2 File Offset: 0x003208F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601598E RID: 88462 RVA: 0x003226FC File Offset: 0x003208FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueInstRoleDatas_.WriteTo(ref output, RoguelikeTrialRoleInfoResponse._repeated_rogueInstRoleDatas_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.MaxLevel != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MaxLevel);
			}
			if (this.AddLevel != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AddLevel);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.WeaponLevel != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.WeaponLevel);
			}
			this.validTrialRoleIds_.WriteTo(ref output, RoguelikeTrialRoleInfoResponse._repeated_validTrialRoleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601598F RID: 88463 RVA: 0x003227CC File Offset: 0x003209CC
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

		// Token: 0x06015990 RID: 88464 RVA: 0x00322890 File Offset: 0x00320A90
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

		// Token: 0x06015991 RID: 88465 RVA: 0x0032293E File Offset: 0x00320B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015992 RID: 88466 RVA: 0x00322948 File Offset: 0x00320B48
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
				if (num <= 96U)
				{
					if (num <= 24U)
					{
						if (num == 10U)
						{
							this.rogueInstRoleDatas_.AddEntriesFrom(ref input, RoguelikeTrialRoleInfoResponse._repeated_rogueInstRoleDatas_codec);
							continue;
						}
						if (num == 24U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.MaxLevel = input.ReadInt32();
							continue;
						}
						if (num == 96U)
						{
							this.AddLevel = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 112U)
				{
					if (num == 104U)
					{
						this.RoleLevel = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.WeaponLevel = input.ReadInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.validTrialRoleIds_.AddEntriesFrom(ref input, RoguelikeTrialRoleInfoResponse._repeated_validTrialRoleIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040081B1 RID: 33201
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081B2 RID: 33202
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040081B3 RID: 33203
		private ErrorCode errorCode_;

		// Token: 0x040081B4 RID: 33204
		public const int ValidTrialRoleIdsFieldNumber = 15;

		// Token: 0x040081B5 RID: 33205
		private static readonly FieldCodec<int> _repeated_validTrialRoleIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040081B6 RID: 33206
		private readonly RepeatedField<int> validTrialRoleIds_ = new RepeatedField<int>();

		// Token: 0x040081B7 RID: 33207
		public const int AddLevelFieldNumber = 12;

		// Token: 0x040081B8 RID: 33208
		private int addLevel_;

		// Token: 0x040081B9 RID: 33209
		public const int MaxLevelFieldNumber = 11;

		// Token: 0x040081BA RID: 33210
		private int maxLevel_;

		// Token: 0x040081BB RID: 33211
		public const int RoleLevelFieldNumber = 13;

		// Token: 0x040081BC RID: 33212
		private int roleLevel_;

		// Token: 0x040081BD RID: 33213
		public const int WeaponLevelFieldNumber = 14;

		// Token: 0x040081BE RID: 33214
		private int weaponLevel_;

		// Token: 0x040081BF RID: 33215
		public const int RogueInstRoleDatasFieldNumber = 1;

		// Token: 0x040081C0 RID: 33216
		private static readonly FieldCodec<RogueInstRoleData> _repeated_rogueInstRoleDatas_codec = FieldCodec.ForMessage<RogueInstRoleData>(10U, RogueInstRoleData.Parser);

		// Token: 0x040081C1 RID: 33217
		private readonly RepeatedField<RogueInstRoleData> rogueInstRoleDatas_ = new RepeatedField<RogueInstRoleData>();
	}
}
