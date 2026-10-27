using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001322 RID: 4898
	[NetMessage(EMessageId.TeamChallengeRequest)]
	public sealed class TeamChallengeRequest : IMessage<TeamChallengeRequest>, IMessage, IEquatable<TeamChallengeRequest>, IDeepCloneable<TeamChallengeRequest>, IBufferMessage
	{
		// Token: 0x0601A079 RID: 106617 RVA: 0x003C82C2 File Offset: 0x003C64C2
		[NullableContext(1)]
		public static TeamChallengeRequest Create()
		{
			return new TeamChallengeRequest();
		}

		// Token: 0x170057CC RID: 22476
		// (get) Token: 0x0601A07A RID: 106618 RVA: 0x003C82C9 File Offset: 0x003C64C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057CD RID: 22477
		// (get) Token: 0x0601A07B RID: 106619 RVA: 0x003C82CC File Offset: 0x003C64CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamChallengeRequest.Descriptor;
			}
		}

		// Token: 0x0601A07C RID: 106620 RVA: 0x003C82D3 File Offset: 0x003C64D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeRequest()
		{
		}

		// Token: 0x0601A07D RID: 106621 RVA: 0x003C82DB File Offset: 0x003C64DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeRequest(TeamChallengeRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.isInviteTeammate_ = other.isInviteTeammate_;
			this.instEnterId_ = other.instEnterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A07E RID: 106622 RVA: 0x003C8318 File Offset: 0x003C6518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeRequest Clone()
		{
			return new TeamChallengeRequest(this);
		}

		// Token: 0x170057CE RID: 22478
		// (get) Token: 0x0601A07F RID: 106623 RVA: 0x003C8320 File Offset: 0x003C6520
		// (set) Token: 0x0601A080 RID: 106624 RVA: 0x003C8328 File Offset: 0x003C6528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170057CF RID: 22479
		// (get) Token: 0x0601A081 RID: 106625 RVA: 0x003C8331 File Offset: 0x003C6531
		// (set) Token: 0x0601A082 RID: 106626 RVA: 0x003C8339 File Offset: 0x003C6539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInviteTeammate
		{
			get
			{
				return this.isInviteTeammate_;
			}
			set
			{
				this.isInviteTeammate_ = value;
			}
		}

		// Token: 0x170057D0 RID: 22480
		// (get) Token: 0x0601A083 RID: 106627 RVA: 0x003C8342 File Offset: 0x003C6542
		// (set) Token: 0x0601A084 RID: 106628 RVA: 0x003C834A File Offset: 0x003C654A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstEnterId
		{
			get
			{
				return this.instEnterId_;
			}
			set
			{
				this.instEnterId_ = value;
			}
		}

		// Token: 0x0601A085 RID: 106629 RVA: 0x003C8353 File Offset: 0x003C6553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamChallengeRequest);
		}

		// Token: 0x0601A086 RID: 106630 RVA: 0x003C8364 File Offset: 0x003C6564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamChallengeRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsInviteTeammate == other.IsInviteTeammate && this.InstEnterId == other.InstEnterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A087 RID: 106631 RVA: 0x003C83C0 File Offset: 0x003C65C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.IsInviteTeammate)
			{
				num ^= this.IsInviteTeammate.GetHashCode();
			}
			if (this.InstEnterId != 0)
			{
				num ^= this.InstEnterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A088 RID: 106632 RVA: 0x003C8431 File Offset: 0x003C6631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A089 RID: 106633 RVA: 0x003C843E File Offset: 0x003C663E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A08A RID: 106634 RVA: 0x003C8448 File Offset: 0x003C6648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsInviteTeammate)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsInviteTeammate);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this.InstEnterId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstEnterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A08B RID: 106635 RVA: 0x003C84BC File Offset: 0x003C66BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.IsInviteTeammate)
			{
				num += 2;
			}
			if (this.InstEnterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstEnterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A08C RID: 106636 RVA: 0x003C8520 File Offset: 0x003C6720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamChallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.IsInviteTeammate)
			{
				this.IsInviteTeammate = other.IsInviteTeammate;
			}
			if (other.InstEnterId != 0)
			{
				this.InstEnterId = other.InstEnterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A08D RID: 106637 RVA: 0x003C8584 File Offset: 0x003C6784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A08E RID: 106638 RVA: 0x003C8590 File Offset: 0x003C6790
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
				if (num != 8U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstEnterId = input.ReadInt32();
						}
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.IsInviteTeammate = input.ReadBool();
				}
			}
		}

		// Token: 0x04009812 RID: 38930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009813 RID: 38931
		public const int InstIdFieldNumber = 14;

		// Token: 0x04009814 RID: 38932
		private int instId_;

		// Token: 0x04009815 RID: 38933
		public const int IsInviteTeammateFieldNumber = 1;

		// Token: 0x04009816 RID: 38934
		private bool isInviteTeammate_;

		// Token: 0x04009817 RID: 38935
		public const int InstEnterIdFieldNumber = 15;

		// Token: 0x04009818 RID: 38936
		private int instEnterId_;
	}
}
