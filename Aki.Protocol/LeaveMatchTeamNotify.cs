using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008ED RID: 2285
	[NetMessage(EMessageId.LeaveMatchTeamNotify)]
	public sealed class LeaveMatchTeamNotify : IMessage<LeaveMatchTeamNotify>, IMessage, IEquatable<LeaveMatchTeamNotify>, IDeepCloneable<LeaveMatchTeamNotify>, IBufferMessage
	{
		// Token: 0x0600CA10 RID: 51728 RVA: 0x001DD581 File Offset: 0x001DB781
		[NullableContext(1)]
		public static LeaveMatchTeamNotify Create()
		{
			return new LeaveMatchTeamNotify();
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x0600CA11 RID: 51729 RVA: 0x001DD588 File Offset: 0x001DB788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x0600CA12 RID: 51730 RVA: 0x001DD58B File Offset: 0x001DB78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMatchTeamNotify.Descriptor;
			}
		}

		// Token: 0x0600CA13 RID: 51731 RVA: 0x001DD592 File Offset: 0x001DB792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamNotify()
		{
		}

		// Token: 0x0600CA14 RID: 51732 RVA: 0x001DD59A File Offset: 0x001DB79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamNotify(LeaveMatchTeamNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.leaveReason_ = other.leaveReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA15 RID: 51733 RVA: 0x001DD5CB File Offset: 0x001DB7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamNotify Clone()
		{
			return new LeaveMatchTeamNotify(this);
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x0600CA16 RID: 51734 RVA: 0x001DD5D3 File Offset: 0x001DB7D3
		// (set) Token: 0x0600CA17 RID: 51735 RVA: 0x001DD5DB File Offset: 0x001DB7DB
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

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x0600CA18 RID: 51736 RVA: 0x001DD5E4 File Offset: 0x001DB7E4
		// (set) Token: 0x0600CA19 RID: 51737 RVA: 0x001DD5EC File Offset: 0x001DB7EC
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

		// Token: 0x0600CA1A RID: 51738 RVA: 0x001DD5F5 File Offset: 0x001DB7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMatchTeamNotify);
		}

		// Token: 0x0600CA1B RID: 51739 RVA: 0x001DD603 File Offset: 0x001DB803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMatchTeamNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.LeaveReason == other.LeaveReason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA1C RID: 51740 RVA: 0x001DD644 File Offset: 0x001DB844
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

		// Token: 0x0600CA1D RID: 51741 RVA: 0x001DD6A2 File Offset: 0x001DB8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA1E RID: 51742 RVA: 0x001DD6AF File Offset: 0x001DB8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA1F RID: 51743 RVA: 0x001DD6B8 File Offset: 0x001DB8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
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

		// Token: 0x0600CA20 RID: 51744 RVA: 0x001DD714 File Offset: 0x001DB914
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

		// Token: 0x0600CA21 RID: 51745 RVA: 0x001DD76C File Offset: 0x001DB96C
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

		// Token: 0x0600CA22 RID: 51746 RVA: 0x001DD7BC File Offset: 0x001DB9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x001DD7C8 File Offset: 0x001DB9C8
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
				if (num != 40U)
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

		// Token: 0x04005612 RID: 22034
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005613 RID: 22035
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04005614 RID: 22036
		private int playerId_;

		// Token: 0x04005615 RID: 22037
		public const int LeaveReasonFieldNumber = 15;

		// Token: 0x04005616 RID: 22038
		private MatchPlayerLeaveReason leaveReason_;
	}
}
