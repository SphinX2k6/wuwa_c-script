using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AF RID: 2479
	public sealed class MatchTeamInfo : IMessage<MatchTeamInfo>, IMessage, IEquatable<MatchTeamInfo>, IDeepCloneable<MatchTeamInfo>, IBufferMessage
	{
		// Token: 0x0600D9ED RID: 55789 RVA: 0x00200913 File Offset: 0x001FEB13
		[NullableContext(1)]
		public static MatchTeamInfo Create()
		{
			return new MatchTeamInfo();
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x0600D9EE RID: 55790 RVA: 0x0020091A File Offset: 0x001FEB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x0600D9EF RID: 55791 RVA: 0x0020091D File Offset: 0x001FEB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchTeamInfo.Descriptor;
			}
		}

		// Token: 0x0600D9F0 RID: 55792 RVA: 0x00200924 File Offset: 0x001FEB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamInfo()
		{
		}

		// Token: 0x0600D9F1 RID: 55793 RVA: 0x00200938 File Offset: 0x001FEB38
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

		// Token: 0x0600D9F2 RID: 55794 RVA: 0x002009BD File Offset: 0x001FEBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamInfo Clone()
		{
			return new MatchTeamInfo(this);
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x0600D9F3 RID: 55795 RVA: 0x002009C5 File Offset: 0x001FEBC5
		// (set) Token: 0x0600D9F4 RID: 55796 RVA: 0x002009CD File Offset: 0x001FEBCD
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

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x0600D9F5 RID: 55797 RVA: 0x002009D6 File Offset: 0x001FEBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MatchPlayerInfo> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x0600D9F6 RID: 55798 RVA: 0x002009DE File Offset: 0x001FEBDE
		// (set) Token: 0x0600D9F7 RID: 55799 RVA: 0x002009E6 File Offset: 0x001FEBE6
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

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x0600D9F8 RID: 55800 RVA: 0x002009EF File Offset: 0x001FEBEF
		// (set) Token: 0x0600D9F9 RID: 55801 RVA: 0x002009F7 File Offset: 0x001FEBF7
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

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x0600D9FA RID: 55802 RVA: 0x00200A00 File Offset: 0x001FEC00
		// (set) Token: 0x0600D9FB RID: 55803 RVA: 0x00200A08 File Offset: 0x001FEC08
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

		// Token: 0x0600D9FC RID: 55804 RVA: 0x00200A11 File Offset: 0x001FEC11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchTeamInfo);
		}

		// Token: 0x0600D9FD RID: 55805 RVA: 0x00200A20 File Offset: 0x001FEC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchTeamInfo other)
		{
			return other != null && (other == this || (this.HostId == other.HostId && this.playerInfos_.Equals(other.playerInfos_) && this.TeamState == other.TeamState && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9FE RID: 55806 RVA: 0x00200AA8 File Offset: 0x001FECA8
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

		// Token: 0x0600D9FF RID: 55807 RVA: 0x00200B40 File Offset: 0x001FED40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA00 RID: 55808 RVA: 0x00200B4D File Offset: 0x001FED4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA01 RID: 55809 RVA: 0x00200B58 File Offset: 0x001FED58
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

		// Token: 0x0600DA02 RID: 55810 RVA: 0x00200BFC File Offset: 0x001FEDFC
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

		// Token: 0x0600DA03 RID: 55811 RVA: 0x00200C98 File Offset: 0x001FEE98
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

		// Token: 0x0600DA04 RID: 55812 RVA: 0x00200D51 File Offset: 0x001FEF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA05 RID: 55813 RVA: 0x00200D5C File Offset: 0x001FEF5C
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

		// Token: 0x04005AFB RID: 23291
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AFC RID: 23292
		public const int HostIdFieldNumber = 1;

		// Token: 0x04005AFD RID: 23293
		private int hostId_;

		// Token: 0x04005AFE RID: 23294
		public const int PlayerInfosFieldNumber = 2;

		// Token: 0x04005AFF RID: 23295
		private static readonly FieldCodec<MatchPlayerInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<MatchPlayerInfo>(18U, MatchPlayerInfo.Parser);

		// Token: 0x04005B00 RID: 23296
		private readonly RepeatedField<MatchPlayerInfo> playerInfos_ = new RepeatedField<MatchPlayerInfo>();

		// Token: 0x04005B01 RID: 23297
		public const int TeamStateFieldNumber = 3;

		// Token: 0x04005B02 RID: 23298
		private MatchTeamState teamState_;

		// Token: 0x04005B03 RID: 23299
		public const int LocationFieldNumber = 4;

		// Token: 0x04005B04 RID: 23300
		private Vector location_;

		// Token: 0x04005B05 RID: 23301
		public const int RotationFieldNumber = 5;

		// Token: 0x04005B06 RID: 23302
		private Rotator rotation_;
	}
}
