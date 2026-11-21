using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DC RID: 2268
	[NetMessage(EMessageId.LeaveMatchTeamNotify)]
	public sealed class LeaveMatchTeamNotify : IMessage<LeaveMatchTeamNotify>, IMessage, IEquatable<LeaveMatchTeamNotify>, IDeepCloneable<LeaveMatchTeamNotify>, IBufferMessage
	{
		// Token: 0x0600C8F4 RID: 51444 RVA: 0x001DB2A5 File Offset: 0x001D94A5
		[NullableContext(1)]
		public static LeaveMatchTeamNotify Create()
		{
			return new LeaveMatchTeamNotify();
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x0600C8F5 RID: 51445 RVA: 0x001DB2AC File Offset: 0x001D94AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x0600C8F6 RID: 51446 RVA: 0x001DB2AF File Offset: 0x001D94AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMatchTeamNotify.Descriptor;
			}
		}

		// Token: 0x0600C8F7 RID: 51447 RVA: 0x001DB2B6 File Offset: 0x001D94B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamNotify()
		{
		}

		// Token: 0x0600C8F8 RID: 51448 RVA: 0x001DB2BE File Offset: 0x001D94BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamNotify(LeaveMatchTeamNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.leaveReason_ = other.leaveReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x001DB2EF File Offset: 0x001D94EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamNotify Clone()
		{
			return new LeaveMatchTeamNotify(this);
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x0600C8FA RID: 51450 RVA: 0x001DB2F7 File Offset: 0x001D94F7
		// (set) Token: 0x0600C8FB RID: 51451 RVA: 0x001DB2FF File Offset: 0x001D94FF
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

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x0600C8FC RID: 51452 RVA: 0x001DB308 File Offset: 0x001D9508
		// (set) Token: 0x0600C8FD RID: 51453 RVA: 0x001DB310 File Offset: 0x001D9510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchPlayerLeaveReason LeaveReason
		{
			get
			{
				return this.leaveReason_;
			}
			set
			{
				this.leaveReason_ = value;
			}
		}

		// Token: 0x0600C8FE RID: 51454 RVA: 0x001DB319 File Offset: 0x001D9519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMatchTeamNotify);
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x001DB327 File Offset: 0x001D9527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMatchTeamNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.LeaveReason == other.LeaveReason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C900 RID: 51456 RVA: 0x001DB368 File Offset: 0x001D9568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.LeaveReason != MatchPlayerLeaveReason.NotConfirm)
			{
				num ^= this.LeaveReason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C901 RID: 51457 RVA: 0x001DB3C6 File Offset: 0x001D95C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C902 RID: 51458 RVA: 0x001DB3D3 File Offset: 0x001D95D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C903 RID: 51459 RVA: 0x001DB3DC File Offset: 0x001D95DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.LeaveReason != MatchPlayerLeaveReason.NotConfirm)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.LeaveReason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C904 RID: 51460 RVA: 0x001DB438 File Offset: 0x001D9638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.LeaveReason != MatchPlayerLeaveReason.NotConfirm)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LeaveReason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C905 RID: 51461 RVA: 0x001DB490 File Offset: 0x001D9690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveMatchTeamNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.LeaveReason != MatchPlayerLeaveReason.NotConfirm)
			{
				this.LeaveReason = other.LeaveReason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C906 RID: 51462 RVA: 0x001DB4E0 File Offset: 0x001D96E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C907 RID: 51463 RVA: 0x001DB4EC File Offset: 0x001D96EC
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
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LeaveReason = (MatchPlayerLeaveReason)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005619 RID: 22041
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400561A RID: 22042
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x0400561B RID: 22043
		private int playerId_;

		// Token: 0x0400561C RID: 22044
		public const int LeaveReasonFieldNumber = 15;

		// Token: 0x0400561D RID: 22045
		private MatchPlayerLeaveReason leaveReason_;
	}
}
