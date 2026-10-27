using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BC RID: 2492
	public sealed class MatchPlayerInfo : IMessage<MatchPlayerInfo>, IMessage, IEquatable<MatchPlayerInfo>, IDeepCloneable<MatchPlayerInfo>, IBufferMessage
	{
		// Token: 0x0600DA91 RID: 55953 RVA: 0x002013A2 File Offset: 0x001FF5A2
		[NullableContext(1)]
		public static MatchPlayerInfo Create()
		{
			return new MatchPlayerInfo();
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x0600DA92 RID: 55954 RVA: 0x002013A9 File Offset: 0x001FF5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchPlayerInfo> Parser
		{
			get
			{
				return MatchPlayerInfo._parser;
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0600DA93 RID: 55955 RVA: 0x002013B0 File Offset: 0x001FF5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x0600DA94 RID: 55956 RVA: 0x002013B3 File Offset: 0x001FF5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0600DA95 RID: 55957 RVA: 0x002013BA File Offset: 0x001FF5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchPlayerInfo()
		{
		}

		// Token: 0x0600DA96 RID: 55958 RVA: 0x002013F0 File Offset: 0x001FF5F0
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

		// Token: 0x0600DA97 RID: 55959 RVA: 0x00201491 File Offset: 0x001FF691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchPlayerInfo Clone()
		{
			return new MatchPlayerInfo(this);
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0600DA98 RID: 55960 RVA: 0x00201499 File Offset: 0x001FF699
		// (set) Token: 0x0600DA99 RID: 55961 RVA: 0x002014A1 File Offset: 0x001FF6A1
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

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x0600DA9A RID: 55962 RVA: 0x002014AA File Offset: 0x001FF6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MatchRoleInfo> RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x002014B2 File Offset: 0x001FF6B2
		// (set) Token: 0x0600DA9C RID: 55964 RVA: 0x002014BA File Offset: 0x001FF6BA
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

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x0600DA9D RID: 55965 RVA: 0x002014CD File Offset: 0x001FF6CD
		// (set) Token: 0x0600DA9E RID: 55966 RVA: 0x002014D5 File Offset: 0x001FF6D5
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

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x0600DA9F RID: 55967 RVA: 0x002014DE File Offset: 0x001FF6DE
		// (set) Token: 0x0600DAA0 RID: 55968 RVA: 0x002014E6 File Offset: 0x001FF6E6
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

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x0600DAA1 RID: 55969 RVA: 0x002014EF File Offset: 0x001FF6EF
		// (set) Token: 0x0600DAA2 RID: 55970 RVA: 0x002014F7 File Offset: 0x001FF6F7
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

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x0600DAA3 RID: 55971 RVA: 0x00201500 File Offset: 0x001FF700
		// (set) Token: 0x0600DAA4 RID: 55972 RVA: 0x00201508 File Offset: 0x001FF708
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

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x0600DAA5 RID: 55973 RVA: 0x0020151B File Offset: 0x001FF71B
		// (set) Token: 0x0600DAA6 RID: 55974 RVA: 0x00201523 File Offset: 0x001FF723
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

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x0600DAA7 RID: 55975 RVA: 0x0020152C File Offset: 0x001FF72C
		// (set) Token: 0x0600DAA8 RID: 55976 RVA: 0x00201534 File Offset: 0x001FF734
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

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x0600DAA9 RID: 55977 RVA: 0x00201547 File Offset: 0x001FF747
		// (set) Token: 0x0600DAAA RID: 55978 RVA: 0x0020154F File Offset: 0x001FF74F
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

		// Token: 0x0600DAAB RID: 55979 RVA: 0x00201558 File Offset: 0x001FF758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchPlayerInfo);
		}

		// Token: 0x0600DAAC RID: 55980 RVA: 0x00201568 File Offset: 0x001FF768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.roleInfo_.Equals(other.roleInfo_) && !(this.PlayerName != other.PlayerName) && this.IsConfirm == other.IsConfirm && this.IsReady == other.IsReady && this.MatchUiState == other.MatchUiState && !(this.PsnOnlineId != other.PsnOnlineId) && this.AbyssLikeCount == other.AbyssLikeCount && !(this.XboxOnlineId != other.XboxOnlineId) && this.XboxUserId == other.XboxUserId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAAD RID: 55981 RVA: 0x00201648 File Offset: 0x001FF848
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

		// Token: 0x0600DAAE RID: 55982 RVA: 0x00201769 File Offset: 0x001FF969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DAAF RID: 55983 RVA: 0x00201776 File Offset: 0x001FF976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DAB0 RID: 55984 RVA: 0x00201780 File Offset: 0x001FF980
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

		// Token: 0x0600DAB1 RID: 55985 RVA: 0x002018BC File Offset: 0x001FFABC
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

		// Token: 0x0600DAB2 RID: 55986 RVA: 0x002019C4 File Offset: 0x001FFBC4
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

		// Token: 0x0600DAB3 RID: 55987 RVA: 0x00201AC0 File Offset: 0x001FFCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAB4 RID: 55988 RVA: 0x00201ACC File Offset: 0x001FFCCC
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

		// Token: 0x04005AB6 RID: 23222
		private static readonly MessageParser<MatchPlayerInfo> _parser = new MessageParser<MatchPlayerInfo>(() => new MatchPlayerInfo());

		// Token: 0x04005AB7 RID: 23223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AB8 RID: 23224
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005AB9 RID: 23225
		private int playerId_;

		// Token: 0x04005ABA RID: 23226
		public const int RoleInfoFieldNumber = 2;

		// Token: 0x04005ABB RID: 23227
		private static readonly FieldCodec<MatchRoleInfo> _repeated_roleInfo_codec = FieldCodec.ForMessage<MatchRoleInfo>(18U, MatchRoleInfo.Parser);

		// Token: 0x04005ABC RID: 23228
		private readonly RepeatedField<MatchRoleInfo> roleInfo_ = new RepeatedField<MatchRoleInfo>();

		// Token: 0x04005ABD RID: 23229
		public const int PlayerNameFieldNumber = 3;

		// Token: 0x04005ABE RID: 23230
		private string playerName_ = "";

		// Token: 0x04005ABF RID: 23231
		public const int IsConfirmFieldNumber = 4;

		// Token: 0x04005AC0 RID: 23232
		private bool isConfirm_;

		// Token: 0x04005AC1 RID: 23233
		public const int IsReadyFieldNumber = 5;

		// Token: 0x04005AC2 RID: 23234
		private bool isReady_;

		// Token: 0x04005AC3 RID: 23235
		public const int MatchUiStateFieldNumber = 6;

		// Token: 0x04005AC4 RID: 23236
		private EMatchPlayerUiState matchUiState_;

		// Token: 0x04005AC5 RID: 23237
		public const int PsnOnlineIdFieldNumber = 7;

		// Token: 0x04005AC6 RID: 23238
		private string psnOnlineId_ = "";

		// Token: 0x04005AC7 RID: 23239
		public const int AbyssLikeCountFieldNumber = 8;

		// Token: 0x04005AC8 RID: 23240
		private int abyssLikeCount_;

		// Token: 0x04005AC9 RID: 23241
		public const int XboxOnlineIdFieldNumber = 9;

		// Token: 0x04005ACA RID: 23242
		private string xboxOnlineId_ = "";

		// Token: 0x04005ACB RID: 23243
		public const int XboxUserIdFieldNumber = 10;

		// Token: 0x04005ACC RID: 23244
		private int xboxUserId_;
	}
}
