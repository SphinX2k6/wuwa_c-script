using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA8 RID: 3496
	[NetMessage(EMessageId.PlayerReviveNotify)]
	public sealed class PlayerReviveNotify : IMessage<PlayerReviveNotify>, IMessage, IEquatable<PlayerReviveNotify>, IDeepCloneable<PlayerReviveNotify>, IBufferMessage
	{
		// Token: 0x06012D56 RID: 77142 RVA: 0x002BF065 File Offset: 0x002BD265
		[NullableContext(1)]
		public static PlayerReviveNotify Create()
		{
			return new PlayerReviveNotify();
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x06012D57 RID: 77143 RVA: 0x002BF06C File Offset: 0x002BD26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x06012D58 RID: 77144 RVA: 0x002BF06F File Offset: 0x002BD26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReviveNotify.Descriptor;
			}
		}

		// Token: 0x06012D59 RID: 77145 RVA: 0x002BF076 File Offset: 0x002BD276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReviveNotify()
		{
		}

		// Token: 0x06012D5A RID: 77146 RVA: 0x002BF0A0 File Offset: 0x002BD2A0
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

		// Token: 0x06012D5B RID: 77147 RVA: 0x002BF187 File Offset: 0x002BD387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReviveNotify Clone()
		{
			return new PlayerReviveNotify(this);
		}

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x06012D5C RID: 77148 RVA: 0x002BF18F File Offset: 0x002BD38F
		// (set) Token: 0x06012D5D RID: 77149 RVA: 0x002BF197 File Offset: 0x002BD397
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

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x06012D5E RID: 77150 RVA: 0x002BF1A0 File Offset: 0x002BD3A0
		// (set) Token: 0x06012D5F RID: 77151 RVA: 0x002BF1A8 File Offset: 0x002BD3A8
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

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x06012D60 RID: 77152 RVA: 0x002BF1B1 File Offset: 0x002BD3B1
		// (set) Token: 0x06012D61 RID: 77153 RVA: 0x002BF1B9 File Offset: 0x002BD3B9
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

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x06012D62 RID: 77154 RVA: 0x002BF1C2 File Offset: 0x002BD3C2
		// (set) Token: 0x06012D63 RID: 77155 RVA: 0x002BF1CA File Offset: 0x002BD3CA
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

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x06012D64 RID: 77156 RVA: 0x002BF1D3 File Offset: 0x002BD3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ReviveRoleInformation> ReviveRoleInfos
		{
			get
			{
				return this.reviveRoleInfos_;
			}
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x06012D65 RID: 77157 RVA: 0x002BF1DB File Offset: 0x002BD3DB
		// (set) Token: 0x06012D66 RID: 77158 RVA: 0x002BF1E3 File Offset: 0x002BD3E3
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

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x06012D67 RID: 77159 RVA: 0x002BF1EC File Offset: 0x002BD3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> RollbackSubLevel
		{
			get
			{
				return this.rollbackSubLevel_;
			}
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x06012D68 RID: 77160 RVA: 0x002BF1F4 File Offset: 0x002BD3F4
		// (set) Token: 0x06012D69 RID: 77161 RVA: 0x002BF1FC File Offset: 0x002BD3FC
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

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x06012D6A RID: 77162 RVA: 0x002BF205 File Offset: 0x002BD405
		// (set) Token: 0x06012D6B RID: 77163 RVA: 0x002BF20D File Offset: 0x002BD40D
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

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x06012D6C RID: 77164 RVA: 0x002BF216 File Offset: 0x002BD416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> RollbackHideSubLevel
		{
			get
			{
				return this.rollbackHideSubLevel_;
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x06012D6D RID: 77165 RVA: 0x002BF21E File Offset: 0x002BD41E
		// (set) Token: 0x06012D6E RID: 77166 RVA: 0x002BF226 File Offset: 0x002BD426
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

		// Token: 0x06012D6F RID: 77167 RVA: 0x002BF22F File Offset: 0x002BD42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReviveNotify);
		}

		// Token: 0x06012D70 RID: 77168 RVA: 0x002BF240 File Offset: 0x002BD440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReviveNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ReviveType == other.ReviveType && object.Equals(this.Location, other.Location) && object.Equals(this.Rotator, other.Rotator) && this.reviveRoleInfos_.Equals(other.reviveRoleInfos_) && this.NeedRollbackSubLevel == other.NeedRollbackSubLevel && this.rollbackSubLevel_.Equals(other.rollbackSubLevel_) && this.TeleportId == other.TeleportId && this.NeedLoading == other.NeedLoading && this.rollbackHideSubLevel_.Equals(other.rollbackHideSubLevel_) && object.Equals(this.Gravity, other.Gravity) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D71 RID: 77169 RVA: 0x002BF338 File Offset: 0x002BD538
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

		// Token: 0x06012D72 RID: 77170 RVA: 0x002BF447 File Offset: 0x002BD647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D73 RID: 77171 RVA: 0x002BF454 File Offset: 0x002BD654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D74 RID: 77172 RVA: 0x002BF460 File Offset: 0x002BD660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotator_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Rotator);
			}
			if (this.TeleportId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TeleportId);
			}
			this.reviveRoleInfos_.WriteTo(ref output, PlayerReviveNotify._repeated_reviveRoleInfos_codec);
			this.rollbackSubLevel_.WriteTo(ref output, PlayerReviveNotify._repeated_rollbackSubLevel_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this.NeedRollbackSubLevel)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.NeedRollbackSubLevel);
			}
			if (this.ReviveType != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ReviveType);
			}
			if (this.gravity_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Gravity);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Location);
			}
			this.rollbackHideSubLevel_.WriteTo(ref output, PlayerReviveNotify._repeated_rollbackHideSubLevel_codec);
			if (this.NeedLoading)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.NeedLoading);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D75 RID: 77173 RVA: 0x002BF594 File Offset: 0x002BD794
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

		// Token: 0x06012D76 RID: 77174 RVA: 0x002BF69C File Offset: 0x002BD89C
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

		// Token: 0x06012D77 RID: 77175 RVA: 0x002BF7DF File Offset: 0x002BD9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D78 RID: 77176 RVA: 0x002BF7E8 File Offset: 0x002BD9E8
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
				if (num <= 48U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.rotator_ == null)
							{
								this.Rotator = new Rotator();
							}
							input.ReadMessage(this.Rotator);
							continue;
						}
						if (num == 16U)
						{
							this.TeleportId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.reviveRoleInfos_.AddEntriesFrom(ref input, PlayerReviveNotify._repeated_reviveRoleInfos_codec);
							continue;
						}
						if (num == 42U)
						{
							this.rollbackSubLevel_.AddEntriesFrom(ref input, PlayerReviveNotify._repeated_rollbackSubLevel_codec);
							continue;
						}
						if (num == 48U)
						{
							this.PlayerId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 72U)
					{
						this.NeedRollbackSubLevel = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.ReviveType = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.gravity_ == null)
						{
							this.Gravity = new Vector();
						}
						input.ReadMessage(this.Gravity);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 106U)
					{
						this.rollbackHideSubLevel_.AddEntriesFrom(ref input, PlayerReviveNotify._repeated_rollbackHideSubLevel_codec);
						continue;
					}
					if (num == 112U)
					{
						this.NeedLoading = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007489 RID: 29833
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400748A RID: 29834
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x0400748B RID: 29835
		private int playerId_;

		// Token: 0x0400748C RID: 29836
		public const int ReviveTypeFieldNumber = 10;

		// Token: 0x0400748D RID: 29837
		private int reviveType_;

		// Token: 0x0400748E RID: 29838
		public const int LocationFieldNumber = 12;

		// Token: 0x0400748F RID: 29839
		private Vector location_;

		// Token: 0x04007490 RID: 29840
		public const int RotatorFieldNumber = 1;

		// Token: 0x04007491 RID: 29841
		private Rotator rotator_;

		// Token: 0x04007492 RID: 29842
		public const int ReviveRoleInfosFieldNumber = 4;

		// Token: 0x04007493 RID: 29843
		private static readonly FieldCodec<ReviveRoleInformation> _repeated_reviveRoleInfos_codec = FieldCodec.ForMessage<ReviveRoleInformation>(34U, ReviveRoleInformation.Parser);

		// Token: 0x04007494 RID: 29844
		private readonly RepeatedField<ReviveRoleInformation> reviveRoleInfos_ = new RepeatedField<ReviveRoleInformation>();

		// Token: 0x04007495 RID: 29845
		public const int NeedRollbackSubLevelFieldNumber = 9;

		// Token: 0x04007496 RID: 29846
		private bool needRollbackSubLevel_;

		// Token: 0x04007497 RID: 29847
		public const int RollbackSubLevelFieldNumber = 5;

		// Token: 0x04007498 RID: 29848
		private static readonly FieldCodec<string> _repeated_rollbackSubLevel_codec = FieldCodec.ForString(42U);

		// Token: 0x04007499 RID: 29849
		private readonly RepeatedField<string> rollbackSubLevel_ = new RepeatedField<string>();

		// Token: 0x0400749A RID: 29850
		public const int TeleportIdFieldNumber = 2;

		// Token: 0x0400749B RID: 29851
		private int teleportId_;

		// Token: 0x0400749C RID: 29852
		public const int NeedLoadingFieldNumber = 14;

		// Token: 0x0400749D RID: 29853
		private bool needLoading_;

		// Token: 0x0400749E RID: 29854
		public const int RollbackHideSubLevelFieldNumber = 13;

		// Token: 0x0400749F RID: 29855
		private static readonly FieldCodec<string> _repeated_rollbackHideSubLevel_codec = FieldCodec.ForString(106U);

		// Token: 0x040074A0 RID: 29856
		private readonly RepeatedField<string> rollbackHideSubLevel_ = new RepeatedField<string>();

		// Token: 0x040074A1 RID: 29857
		public const int GravityFieldNumber = 11;

		// Token: 0x040074A2 RID: 29858
		private Vector gravity_;
	}
}
