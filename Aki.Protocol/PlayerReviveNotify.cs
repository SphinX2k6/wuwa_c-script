using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D98 RID: 3480
	[NetMessage(EMessageId.PlayerReviveNotify)]
	public sealed class PlayerReviveNotify : IMessage<PlayerReviveNotify>, IMessage, IEquatable<PlayerReviveNotify>, IDeepCloneable<PlayerReviveNotify>, IBufferMessage
	{
		// Token: 0x06012C5A RID: 76890 RVA: 0x002BD441 File Offset: 0x002BB641
		[NullableContext(1)]
		public static PlayerReviveNotify Create()
		{
			return new PlayerReviveNotify();
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x06012C5B RID: 76891 RVA: 0x002BD448 File Offset: 0x002BB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x06012C5C RID: 76892 RVA: 0x002BD44B File Offset: 0x002BB64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReviveNotify.Descriptor;
			}
		}

		// Token: 0x06012C5D RID: 76893 RVA: 0x002BD452 File Offset: 0x002BB652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReviveNotify()
		{
		}

		// Token: 0x06012C5E RID: 76894 RVA: 0x002BD47C File Offset: 0x002BB67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReviveNotify(PlayerReviveNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.reviveType_ = other.reviveType_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotator_ = ((other.rotator_ != null) ? other.rotator_.Clone() : null);
			this.reviveRoleInfos_ = other.reviveRoleInfos_.Clone();
			this.needRollbackSubLevel_ = other.needRollbackSubLevel_;
			this.rollbackSubLevel_ = other.rollbackSubLevel_.Clone();
			this.teleportId_ = other.teleportId_;
			this.needLoading_ = other.needLoading_;
			this.rollbackHideSubLevel_ = other.rollbackHideSubLevel_.Clone();
			this.gravity_ = ((other.gravity_ != null) ? other.gravity_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C5F RID: 76895 RVA: 0x002BD563 File Offset: 0x002BB763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReviveNotify Clone()
		{
			return new PlayerReviveNotify(this);
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x06012C60 RID: 76896 RVA: 0x002BD56B File Offset: 0x002BB76B
		// (set) Token: 0x06012C61 RID: 76897 RVA: 0x002BD573 File Offset: 0x002BB773
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

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x06012C62 RID: 76898 RVA: 0x002BD57C File Offset: 0x002BB77C
		// (set) Token: 0x06012C63 RID: 76899 RVA: 0x002BD584 File Offset: 0x002BB784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveType
		{
			get
			{
				return this.reviveType_;
			}
			set
			{
				this.reviveType_ = value;
			}
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x06012C64 RID: 76900 RVA: 0x002BD58D File Offset: 0x002BB78D
		// (set) Token: 0x06012C65 RID: 76901 RVA: 0x002BD595 File Offset: 0x002BB795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x06012C66 RID: 76902 RVA: 0x002BD59E File Offset: 0x002BB79E
		// (set) Token: 0x06012C67 RID: 76903 RVA: 0x002BD5A6 File Offset: 0x002BB7A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotator
		{
			get
			{
				return this.rotator_;
			}
			set
			{
				this.rotator_ = value;
			}
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x06012C68 RID: 76904 RVA: 0x002BD5AF File Offset: 0x002BB7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ReviveRoleInformation> ReviveRoleInfos
		{
			get
			{
				return this.reviveRoleInfos_;
			}
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x06012C69 RID: 76905 RVA: 0x002BD5B7 File Offset: 0x002BB7B7
		// (set) Token: 0x06012C6A RID: 76906 RVA: 0x002BD5BF File Offset: 0x002BB7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedRollbackSubLevel
		{
			get
			{
				return this.needRollbackSubLevel_;
			}
			set
			{
				this.needRollbackSubLevel_ = value;
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x06012C6B RID: 76907 RVA: 0x002BD5C8 File Offset: 0x002BB7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> RollbackSubLevel
		{
			get
			{
				return this.rollbackSubLevel_;
			}
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x06012C6C RID: 76908 RVA: 0x002BD5D0 File Offset: 0x002BB7D0
		// (set) Token: 0x06012C6D RID: 76909 RVA: 0x002BD5D8 File Offset: 0x002BB7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeleportId
		{
			get
			{
				return this.teleportId_;
			}
			set
			{
				this.teleportId_ = value;
			}
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x06012C6E RID: 76910 RVA: 0x002BD5E1 File Offset: 0x002BB7E1
		// (set) Token: 0x06012C6F RID: 76911 RVA: 0x002BD5E9 File Offset: 0x002BB7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedLoading
		{
			get
			{
				return this.needLoading_;
			}
			set
			{
				this.needLoading_ = value;
			}
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x06012C70 RID: 76912 RVA: 0x002BD5F2 File Offset: 0x002BB7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> RollbackHideSubLevel
		{
			get
			{
				return this.rollbackHideSubLevel_;
			}
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x06012C71 RID: 76913 RVA: 0x002BD5FA File Offset: 0x002BB7FA
		// (set) Token: 0x06012C72 RID: 76914 RVA: 0x002BD602 File Offset: 0x002BB802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Gravity
		{
			get
			{
				return this.gravity_;
			}
			set
			{
				this.gravity_ = value;
			}
		}

		// Token: 0x06012C73 RID: 76915 RVA: 0x002BD60B File Offset: 0x002BB80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReviveNotify);
		}

		// Token: 0x06012C74 RID: 76916 RVA: 0x002BD61C File Offset: 0x002BB81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReviveNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ReviveType == other.ReviveType && object.Equals(this.Location, other.Location) && object.Equals(this.Rotator, other.Rotator) && this.reviveRoleInfos_.Equals(other.reviveRoleInfos_) && this.NeedRollbackSubLevel == other.NeedRollbackSubLevel && this.rollbackSubLevel_.Equals(other.rollbackSubLevel_) && this.TeleportId == other.TeleportId && this.NeedLoading == other.NeedLoading && this.rollbackHideSubLevel_.Equals(other.rollbackHideSubLevel_) && object.Equals(this.Gravity, other.Gravity) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C75 RID: 76917 RVA: 0x002BD714 File Offset: 0x002BB914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.ReviveType != 0)
			{
				num ^= this.ReviveType.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotator_ != null)
			{
				num ^= this.Rotator.GetHashCode();
			}
			num ^= this.reviveRoleInfos_.GetHashCode();
			if (this.NeedRollbackSubLevel)
			{
				num ^= this.NeedRollbackSubLevel.GetHashCode();
			}
			num ^= this.rollbackSubLevel_.GetHashCode();
			if (this.TeleportId != 0)
			{
				num ^= this.TeleportId.GetHashCode();
			}
			if (this.NeedLoading)
			{
				num ^= this.NeedLoading.GetHashCode();
			}
			num ^= this.rollbackHideSubLevel_.GetHashCode();
			if (this.gravity_ != null)
			{
				num ^= this.Gravity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012C76 RID: 76918 RVA: 0x002BD823 File Offset: 0x002BBA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C77 RID: 76919 RVA: 0x002BD830 File Offset: 0x002BBA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C78 RID: 76920 RVA: 0x002BD83C File Offset: 0x002BBA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Location);
			}
			this.rollbackSubLevel_.WriteTo(ref output, PlayerReviveNotify._repeated_rollbackSubLevel_codec);
			if (this.NeedLoading)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.NeedLoading);
			}
			this.reviveRoleInfos_.WriteTo(ref output, PlayerReviveNotify._repeated_reviveRoleInfos_codec);
			this.rollbackHideSubLevel_.WriteTo(ref output, PlayerReviveNotify._repeated_rollbackHideSubLevel_codec);
			if (this.NeedRollbackSubLevel)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.NeedRollbackSubLevel);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			if (this.rotator_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Rotator);
			}
			if (this.ReviveType != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ReviveType);
			}
			if (this.gravity_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Gravity);
			}
			if (this.TeleportId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C79 RID: 76921 RVA: 0x002BD970 File Offset: 0x002BBB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.ReviveType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveType);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotator_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotator);
			}
			num += this.reviveRoleInfos_.CalculateSize(PlayerReviveNotify._repeated_reviveRoleInfos_codec);
			if (this.NeedRollbackSubLevel)
			{
				num += 2;
			}
			num += this.rollbackSubLevel_.CalculateSize(PlayerReviveNotify._repeated_rollbackSubLevel_codec);
			if (this.TeleportId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TeleportId);
			}
			if (this.NeedLoading)
			{
				num += 2;
			}
			num += this.rollbackHideSubLevel_.CalculateSize(PlayerReviveNotify._repeated_rollbackHideSubLevel_codec);
			if (this.gravity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Gravity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C7A RID: 76922 RVA: 0x002BDA78 File Offset: 0x002BBC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReviveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.ReviveType != 0)
			{
				this.ReviveType = other.ReviveType;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotator_ != null)
			{
				if (this.rotator_ == null)
				{
					this.Rotator = new Rotator();
				}
				this.Rotator.MergeFrom(other.Rotator);
			}
			this.reviveRoleInfos_.Add(other.reviveRoleInfos_);
			if (other.NeedRollbackSubLevel)
			{
				this.NeedRollbackSubLevel = other.NeedRollbackSubLevel;
			}
			this.rollbackSubLevel_.Add(other.rollbackSubLevel_);
			if (other.TeleportId != 0)
			{
				this.TeleportId = other.TeleportId;
			}
			if (other.NeedLoading)
			{
				this.NeedLoading = other.NeedLoading;
			}
			this.rollbackHideSubLevel_.Add(other.rollbackHideSubLevel_);
			if (other.gravity_ != null)
			{
				if (this.gravity_ == null)
				{
					this.Gravity = new Vector();
				}
				this.Gravity.MergeFrom(other.Gravity);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C7B RID: 76923 RVA: 0x002BDBBB File Offset: 0x002BBDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C7C RID: 76924 RVA: 0x002BDBC4 File Offset: 0x002BBDC4
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
				if (num <= 50U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
							continue;
						}
						if (num == 18U)
						{
							this.rollbackSubLevel_.AddEntriesFrom(ref input, PlayerReviveNotify._repeated_rollbackSubLevel_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.NeedLoading = input.ReadBool();
							continue;
						}
						if (num == 42U)
						{
							this.reviveRoleInfos_.AddEntriesFrom(ref input, PlayerReviveNotify._repeated_reviveRoleInfos_codec);
							continue;
						}
						if (num == 50U)
						{
							this.rollbackHideSubLevel_.AddEntriesFrom(ref input, PlayerReviveNotify._repeated_rollbackHideSubLevel_codec);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 56U)
					{
						this.NeedRollbackSubLevel = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						if (this.rotator_ == null)
						{
							this.Rotator = new Rotator();
						}
						input.ReadMessage(this.Rotator);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ReviveType = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.gravity_ == null)
						{
							this.Gravity = new Vector();
						}
						input.ReadMessage(this.Gravity);
						continue;
					}
					if (num == 120U)
					{
						this.TeleportId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040074A1 RID: 29857
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074A2 RID: 29858
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x040074A3 RID: 29859
		private int playerId_;

		// Token: 0x040074A4 RID: 29860
		public const int ReviveTypeFieldNumber = 11;

		// Token: 0x040074A5 RID: 29861
		private int reviveType_;

		// Token: 0x040074A6 RID: 29862
		public const int LocationFieldNumber = 1;

		// Token: 0x040074A7 RID: 29863
		private Vector location_;

		// Token: 0x040074A8 RID: 29864
		public const int RotatorFieldNumber = 10;

		// Token: 0x040074A9 RID: 29865
		private Rotator rotator_;

		// Token: 0x040074AA RID: 29866
		public const int ReviveRoleInfosFieldNumber = 5;

		// Token: 0x040074AB RID: 29867
		private static readonly FieldCodec<ReviveRoleInformation> _repeated_reviveRoleInfos_codec = FieldCodec.ForMessage<ReviveRoleInformation>(42U, ReviveRoleInformation.Parser);

		// Token: 0x040074AC RID: 29868
		private readonly RepeatedField<ReviveRoleInformation> reviveRoleInfos_ = new RepeatedField<ReviveRoleInformation>();

		// Token: 0x040074AD RID: 29869
		public const int NeedRollbackSubLevelFieldNumber = 7;

		// Token: 0x040074AE RID: 29870
		private bool needRollbackSubLevel_;

		// Token: 0x040074AF RID: 29871
		public const int RollbackSubLevelFieldNumber = 2;

		// Token: 0x040074B0 RID: 29872
		private static readonly FieldCodec<string> _repeated_rollbackSubLevel_codec = FieldCodec.ForString(18U);

		// Token: 0x040074B1 RID: 29873
		private readonly RepeatedField<string> rollbackSubLevel_ = new RepeatedField<string>();

		// Token: 0x040074B2 RID: 29874
		public const int TeleportIdFieldNumber = 15;

		// Token: 0x040074B3 RID: 29875
		private int teleportId_;

		// Token: 0x040074B4 RID: 29876
		public const int NeedLoadingFieldNumber = 3;

		// Token: 0x040074B5 RID: 29877
		private bool needLoading_;

		// Token: 0x040074B6 RID: 29878
		public const int RollbackHideSubLevelFieldNumber = 6;

		// Token: 0x040074B7 RID: 29879
		private static readonly FieldCodec<string> _repeated_rollbackHideSubLevel_codec = FieldCodec.ForString(50U);

		// Token: 0x040074B8 RID: 29880
		private readonly RepeatedField<string> rollbackHideSubLevel_ = new RepeatedField<string>();

		// Token: 0x040074B9 RID: 29881
		public const int GravityFieldNumber = 14;

		// Token: 0x040074BA RID: 29882
		private Vector gravity_;
	}
}
