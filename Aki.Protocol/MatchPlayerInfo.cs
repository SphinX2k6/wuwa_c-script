using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AB RID: 2475
	public sealed class MatchPlayerInfo : IMessage<MatchPlayerInfo>, IMessage, IEquatable<MatchPlayerInfo>, IDeepCloneable<MatchPlayerInfo>, IBufferMessage
	{
		// Token: 0x0600D977 RID: 55671 RVA: 0x001FF1AE File Offset: 0x001FD3AE
		[NullableContext(1)]
		public static MatchPlayerInfo Create()
		{
			return new MatchPlayerInfo();
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x0600D978 RID: 55672 RVA: 0x001FF1B5 File Offset: 0x001FD3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchPlayerInfo> Parser
		{
			get
			{
				return MatchPlayerInfo._parser;
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x0600D979 RID: 55673 RVA: 0x001FF1BC File Offset: 0x001FD3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x0600D97A RID: 55674 RVA: 0x001FF1BF File Offset: 0x001FD3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0600D97B RID: 55675 RVA: 0x001FF1C6 File Offset: 0x001FD3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchPlayerInfo()
		{
		}

		// Token: 0x0600D97C RID: 55676 RVA: 0x001FF1FC File Offset: 0x001FD3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchPlayerInfo(MatchPlayerInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.roleInfo_ = other.roleInfo_.Clone();
			this.playerName_ = other.playerName_;
			this.isConfirm_ = other.isConfirm_;
			this.isReady_ = other.isReady_;
			this.matchUiState_ = other.matchUiState_;
			this.psnOnlineId_ = other.psnOnlineId_;
			this.abyssLikeCount_ = other.abyssLikeCount_;
			this.xboxOnlineId_ = other.xboxOnlineId_;
			this.xboxUserId_ = other.xboxUserId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D97D RID: 55677 RVA: 0x001FF29D File Offset: 0x001FD49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchPlayerInfo Clone()
		{
			return new MatchPlayerInfo(this);
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x0600D97E RID: 55678 RVA: 0x001FF2A5 File Offset: 0x001FD4A5
		// (set) Token: 0x0600D97F RID: 55679 RVA: 0x001FF2AD File Offset: 0x001FD4AD
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

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x0600D980 RID: 55680 RVA: 0x001FF2B6 File Offset: 0x001FD4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MatchRoleInfo> RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x0600D981 RID: 55681 RVA: 0x001FF2BE File Offset: 0x001FD4BE
		// (set) Token: 0x0600D982 RID: 55682 RVA: 0x001FF2C6 File Offset: 0x001FD4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerName
		{
			get
			{
				return this.playerName_;
			}
			set
			{
				this.playerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x0600D983 RID: 55683 RVA: 0x001FF2D9 File Offset: 0x001FD4D9
		// (set) Token: 0x0600D984 RID: 55684 RVA: 0x001FF2E1 File Offset: 0x001FD4E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConfirm
		{
			get
			{
				return this.isConfirm_;
			}
			set
			{
				this.isConfirm_ = value;
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x0600D985 RID: 55685 RVA: 0x001FF2EA File Offset: 0x001FD4EA
		// (set) Token: 0x0600D986 RID: 55686 RVA: 0x001FF2F2 File Offset: 0x001FD4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReady
		{
			get
			{
				return this.isReady_;
			}
			set
			{
				this.isReady_ = value;
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x0600D987 RID: 55687 RVA: 0x001FF2FB File Offset: 0x001FD4FB
		// (set) Token: 0x0600D988 RID: 55688 RVA: 0x001FF303 File Offset: 0x001FD503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMatchPlayerUiState MatchUiState
		{
			get
			{
				return this.matchUiState_;
			}
			set
			{
				this.matchUiState_ = value;
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x0600D989 RID: 55689 RVA: 0x001FF30C File Offset: 0x001FD50C
		// (set) Token: 0x0600D98A RID: 55690 RVA: 0x001FF314 File Offset: 0x001FD514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnOnlineId
		{
			get
			{
				return this.psnOnlineId_;
			}
			set
			{
				this.psnOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x0600D98B RID: 55691 RVA: 0x001FF327 File Offset: 0x001FD527
		// (set) Token: 0x0600D98C RID: 55692 RVA: 0x001FF32F File Offset: 0x001FD52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AbyssLikeCount
		{
			get
			{
				return this.abyssLikeCount_;
			}
			set
			{
				this.abyssLikeCount_ = value;
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x0600D98D RID: 55693 RVA: 0x001FF338 File Offset: 0x001FD538
		// (set) Token: 0x0600D98E RID: 55694 RVA: 0x001FF340 File Offset: 0x001FD540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxOnlineId
		{
			get
			{
				return this.xboxOnlineId_;
			}
			set
			{
				this.xboxOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x0600D98F RID: 55695 RVA: 0x001FF353 File Offset: 0x001FD553
		// (set) Token: 0x0600D990 RID: 55696 RVA: 0x001FF35B File Offset: 0x001FD55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int XboxUserId
		{
			get
			{
				return this.xboxUserId_;
			}
			set
			{
				this.xboxUserId_ = value;
			}
		}

		// Token: 0x0600D991 RID: 55697 RVA: 0x001FF364 File Offset: 0x001FD564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchPlayerInfo);
		}

		// Token: 0x0600D992 RID: 55698 RVA: 0x001FF374 File Offset: 0x001FD574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.roleInfo_.Equals(other.roleInfo_) && !(this.PlayerName != other.PlayerName) && this.IsConfirm == other.IsConfirm && this.IsReady == other.IsReady && this.MatchUiState == other.MatchUiState && !(this.PsnOnlineId != other.PsnOnlineId) && this.AbyssLikeCount == other.AbyssLikeCount && !(this.XboxOnlineId != other.XboxOnlineId) && this.XboxUserId == other.XboxUserId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D993 RID: 55699 RVA: 0x001FF454 File Offset: 0x001FD654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.roleInfo_.GetHashCode();
			if (this.PlayerName.Length != 0)
			{
				num ^= this.PlayerName.GetHashCode();
			}
			if (this.IsConfirm)
			{
				num ^= this.IsConfirm.GetHashCode();
			}
			if (this.IsReady)
			{
				num ^= this.IsReady.GetHashCode();
			}
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				num ^= this.MatchUiState.GetHashCode();
			}
			if (this.PsnOnlineId.Length != 0)
			{
				num ^= this.PsnOnlineId.GetHashCode();
			}
			if (this.AbyssLikeCount != 0)
			{
				num ^= this.AbyssLikeCount.GetHashCode();
			}
			if (this.XboxOnlineId.Length != 0)
			{
				num ^= this.XboxOnlineId.GetHashCode();
			}
			if (this.XboxUserId != 0)
			{
				num ^= this.XboxUserId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D994 RID: 55700 RVA: 0x001FF575 File Offset: 0x001FD775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D995 RID: 55701 RVA: 0x001FF582 File Offset: 0x001FD782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D996 RID: 55702 RVA: 0x001FF58C File Offset: 0x001FD78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.roleInfo_.WriteTo(ref output, MatchPlayerInfo._repeated_roleInfo_codec);
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.PlayerName);
			}
			if (this.IsConfirm)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsConfirm);
			}
			if (this.IsReady)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsReady);
			}
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.MatchUiState);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.PsnOnlineId);
			}
			if (this.AbyssLikeCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.AbyssLikeCount);
			}
			if (this.XboxOnlineId.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.XboxOnlineId);
			}
			if (this.XboxUserId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.XboxUserId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D997 RID: 55703 RVA: 0x001FF6C8 File Offset: 0x001FD8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.roleInfo_.CalculateSize(MatchPlayerInfo._repeated_roleInfo_codec);
			if (this.PlayerName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PlayerName);
			}
			if (this.IsConfirm)
			{
				num += 2;
			}
			if (this.IsReady)
			{
				num += 2;
			}
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MatchUiState);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnOnlineId);
			}
			if (this.AbyssLikeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AbyssLikeCount);
			}
			if (this.XboxOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XboxOnlineId);
			}
			if (this.XboxUserId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.XboxUserId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D998 RID: 55704 RVA: 0x001FF7D0 File Offset: 0x001FD9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.roleInfo_.Add(other.roleInfo_);
			if (other.PlayerName.Length != 0)
			{
				this.PlayerName = other.PlayerName;
			}
			if (other.IsConfirm)
			{
				this.IsConfirm = other.IsConfirm;
			}
			if (other.IsReady)
			{
				this.IsReady = other.IsReady;
			}
			if (other.MatchUiState != EMatchPlayerUiState.Wait)
			{
				this.MatchUiState = other.MatchUiState;
			}
			if (other.PsnOnlineId.Length != 0)
			{
				this.PsnOnlineId = other.PsnOnlineId;
			}
			if (other.AbyssLikeCount != 0)
			{
				this.AbyssLikeCount = other.AbyssLikeCount;
			}
			if (other.XboxOnlineId.Length != 0)
			{
				this.XboxOnlineId = other.XboxOnlineId;
			}
			if (other.XboxUserId != 0)
			{
				this.XboxUserId = other.XboxUserId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D999 RID: 55705 RVA: 0x001FF8CC File Offset: 0x001FDACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D99A RID: 55706 RVA: 0x001FF8D8 File Offset: 0x001FDAD8
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
				if (num <= 40U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.PlayerId = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							this.roleInfo_.AddEntriesFrom(ref input, MatchPlayerInfo._repeated_roleInfo_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.PlayerName = input.ReadString();
							continue;
						}
						if (num == 32U)
						{
							this.IsConfirm = input.ReadBool();
							continue;
						}
						if (num == 40U)
						{
							this.IsReady = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 48U)
					{
						this.MatchUiState = (EMatchPlayerUiState)input.ReadEnum();
						continue;
					}
					if (num == 58U)
					{
						this.PsnOnlineId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.AbyssLikeCount = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.XboxOnlineId = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.XboxUserId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005ABF RID: 23231
		private static readonly MessageParser<MatchPlayerInfo> _parser = new MessageParser<MatchPlayerInfo>(() => new MatchPlayerInfo());

		// Token: 0x04005AC0 RID: 23232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AC1 RID: 23233
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005AC2 RID: 23234
		private int playerId_;

		// Token: 0x04005AC3 RID: 23235
		public const int RoleInfoFieldNumber = 2;

		// Token: 0x04005AC4 RID: 23236
		private static readonly FieldCodec<MatchRoleInfo> _repeated_roleInfo_codec = FieldCodec.ForMessage<MatchRoleInfo>(18U, MatchRoleInfo.Parser);

		// Token: 0x04005AC5 RID: 23237
		private readonly RepeatedField<MatchRoleInfo> roleInfo_ = new RepeatedField<MatchRoleInfo>();

		// Token: 0x04005AC6 RID: 23238
		public const int PlayerNameFieldNumber = 3;

		// Token: 0x04005AC7 RID: 23239
		private string playerName_ = "";

		// Token: 0x04005AC8 RID: 23240
		public const int IsConfirmFieldNumber = 4;

		// Token: 0x04005AC9 RID: 23241
		private bool isConfirm_;

		// Token: 0x04005ACA RID: 23242
		public const int IsReadyFieldNumber = 5;

		// Token: 0x04005ACB RID: 23243
		private bool isReady_;

		// Token: 0x04005ACC RID: 23244
		public const int MatchUiStateFieldNumber = 6;

		// Token: 0x04005ACD RID: 23245
		private EMatchPlayerUiState matchUiState_;

		// Token: 0x04005ACE RID: 23246
		public const int PsnOnlineIdFieldNumber = 7;

		// Token: 0x04005ACF RID: 23247
		private string psnOnlineId_ = "";

		// Token: 0x04005AD0 RID: 23248
		public const int AbyssLikeCountFieldNumber = 8;

		// Token: 0x04005AD1 RID: 23249
		private int abyssLikeCount_;

		// Token: 0x04005AD2 RID: 23250
		public const int XboxOnlineIdFieldNumber = 9;

		// Token: 0x04005AD3 RID: 23251
		private string xboxOnlineId_ = "";

		// Token: 0x04005AD4 RID: 23252
		public const int XboxUserIdFieldNumber = 10;

		// Token: 0x04005AD5 RID: 23253
		private int xboxUserId_;
	}
}
