using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C0 RID: 2496
	public sealed class MatchTeamInfo : IMessage<MatchTeamInfo>, IMessage, IEquatable<MatchTeamInfo>, IDeepCloneable<MatchTeamInfo>, IBufferMessage
	{
		// Token: 0x0600DB07 RID: 56071 RVA: 0x00202B07 File Offset: 0x00200D07
		[NullableContext(1)]
		public static MatchTeamInfo Create()
		{
			return new MatchTeamInfo();
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x0600DB08 RID: 56072 RVA: 0x00202B0E File Offset: 0x00200D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x0600DB09 RID: 56073 RVA: 0x00202B11 File Offset: 0x00200D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchTeamInfo.Descriptor;
			}
		}

		// Token: 0x0600DB0A RID: 56074 RVA: 0x00202B18 File Offset: 0x00200D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamInfo()
		{
		}

		// Token: 0x0600DB0B RID: 56075 RVA: 0x00202B2C File Offset: 0x00200D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamInfo(MatchTeamInfo other) : this()
		{
			this.hostId_ = other.hostId_;
			this.playerInfos_ = other.playerInfos_.Clone();
			this.teamState_ = other.teamState_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB0C RID: 56076 RVA: 0x00202BB1 File Offset: 0x00200DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamInfo Clone()
		{
			return new MatchTeamInfo(this);
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x0600DB0D RID: 56077 RVA: 0x00202BB9 File Offset: 0x00200DB9
		// (set) Token: 0x0600DB0E RID: 56078 RVA: 0x00202BC1 File Offset: 0x00200DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostId
		{
			get
			{
				return this.hostId_;
			}
			set
			{
				this.hostId_ = value;
			}
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x0600DB0F RID: 56079 RVA: 0x00202BCA File Offset: 0x00200DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MatchPlayerInfo> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x0600DB10 RID: 56080 RVA: 0x00202BD2 File Offset: 0x00200DD2
		// (set) Token: 0x0600DB11 RID: 56081 RVA: 0x00202BDA File Offset: 0x00200DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamState TeamState
		{
			get
			{
				return this.teamState_;
			}
			set
			{
				this.teamState_ = value;
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x0600DB12 RID: 56082 RVA: 0x00202BE3 File Offset: 0x00200DE3
		// (set) Token: 0x0600DB13 RID: 56083 RVA: 0x00202BEB File Offset: 0x00200DEB
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

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x0600DB14 RID: 56084 RVA: 0x00202BF4 File Offset: 0x00200DF4
		// (set) Token: 0x0600DB15 RID: 56085 RVA: 0x00202BFC File Offset: 0x00200DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x0600DB16 RID: 56086 RVA: 0x00202C05 File Offset: 0x00200E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchTeamInfo);
		}

		// Token: 0x0600DB17 RID: 56087 RVA: 0x00202C14 File Offset: 0x00200E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchTeamInfo other)
		{
			return other != null && (other == this || (this.HostId == other.HostId && this.playerInfos_.Equals(other.playerInfos_) && this.TeamState == other.TeamState && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB18 RID: 56088 RVA: 0x00202C9C File Offset: 0x00200E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostId != 0)
			{
				num ^= this.HostId.GetHashCode();
			}
			num ^= this.playerInfos_.GetHashCode();
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				num ^= this.TeamState.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB19 RID: 56089 RVA: 0x00202D34 File Offset: 0x00200F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB1A RID: 56090 RVA: 0x00202D41 File Offset: 0x00200F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB1B RID: 56091 RVA: 0x00202D4C File Offset: 0x00200F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HostId);
			}
			this.playerInfos_.WriteTo(ref output, MatchTeamInfo._repeated_playerInfos_codec);
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.TeamState);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB1C RID: 56092 RVA: 0x00202DF0 File Offset: 0x00200FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostId);
			}
			num += this.playerInfos_.CalculateSize(MatchTeamInfo._repeated_playerInfos_codec);
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TeamState);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB1D RID: 56093 RVA: 0x00202E8C File Offset: 0x0020108C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchTeamInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostId != 0)
			{
				this.HostId = other.HostId;
			}
			this.playerInfos_.Add(other.playerInfos_);
			if (other.TeamState != MatchTeamState.WaiteConfirm)
			{
				this.TeamState = other.TeamState;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB1E RID: 56094 RVA: 0x00202F45 File Offset: 0x00201145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB1F RID: 56095 RVA: 0x00202F50 File Offset: 0x00201150
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.HostId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.playerInfos_.AddEntriesFrom(ref input, MatchTeamInfo._repeated_playerInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TeamState = (MatchTeamState)input.ReadEnum();
						continue;
					}
					if (num == 34U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 42U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005AF2 RID: 23282
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AF3 RID: 23283
		public const int HostIdFieldNumber = 1;

		// Token: 0x04005AF4 RID: 23284
		private int hostId_;

		// Token: 0x04005AF5 RID: 23285
		public const int PlayerInfosFieldNumber = 2;

		// Token: 0x04005AF6 RID: 23286
		private static readonly FieldCodec<MatchPlayerInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<MatchPlayerInfo>(18U, MatchPlayerInfo.Parser);

		// Token: 0x04005AF7 RID: 23287
		private readonly RepeatedField<MatchPlayerInfo> playerInfos_ = new RepeatedField<MatchPlayerInfo>();

		// Token: 0x04005AF8 RID: 23288
		public const int TeamStateFieldNumber = 3;

		// Token: 0x04005AF9 RID: 23289
		private MatchTeamState teamState_;

		// Token: 0x04005AFA RID: 23290
		public const int LocationFieldNumber = 4;

		// Token: 0x04005AFB RID: 23291
		private Vector location_;

		// Token: 0x04005AFC RID: 23292
		public const int RotationFieldNumber = 5;

		// Token: 0x04005AFD RID: 23293
		private Rotator rotation_;
	}
}
