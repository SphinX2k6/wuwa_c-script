using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138F RID: 5007
	[NetMessage(EMessageId.TeamChallengeRequest)]
	public sealed class TeamChallengeRequest : IMessage<TeamChallengeRequest>, IMessage, IEquatable<TeamChallengeRequest>, IDeepCloneable<TeamChallengeRequest>, IBufferMessage
	{
		// Token: 0x0601AA89 RID: 109193 RVA: 0x003E257A File Offset: 0x003E077A
		[NullableContext(1)]
		public static TeamChallengeRequest Create()
		{
			return new TeamChallengeRequest();
		}

		// Token: 0x17005A46 RID: 23110
		// (get) Token: 0x0601AA8A RID: 109194 RVA: 0x003E2581 File Offset: 0x003E0781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A47 RID: 23111
		// (get) Token: 0x0601AA8B RID: 109195 RVA: 0x003E2584 File Offset: 0x003E0784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamChallengeRequest.Descriptor;
			}
		}

		// Token: 0x0601AA8C RID: 109196 RVA: 0x003E258B File Offset: 0x003E078B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeRequest()
		{
		}

		// Token: 0x0601AA8D RID: 109197 RVA: 0x003E2593 File Offset: 0x003E0793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeRequest(TeamChallengeRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.isInviteTeammate_ = other.isInviteTeammate_;
			this.instEnterId_ = other.instEnterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA8E RID: 109198 RVA: 0x003E25D0 File Offset: 0x003E07D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeRequest Clone()
		{
			return new TeamChallengeRequest(this);
		}

		// Token: 0x17005A48 RID: 23112
		// (get) Token: 0x0601AA8F RID: 109199 RVA: 0x003E25D8 File Offset: 0x003E07D8
		// (set) Token: 0x0601AA90 RID: 109200 RVA: 0x003E25E0 File Offset: 0x003E07E0
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

		// Token: 0x17005A49 RID: 23113
		// (get) Token: 0x0601AA91 RID: 109201 RVA: 0x003E25E9 File Offset: 0x003E07E9
		// (set) Token: 0x0601AA92 RID: 109202 RVA: 0x003E25F1 File Offset: 0x003E07F1
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

		// Token: 0x17005A4A RID: 23114
		// (get) Token: 0x0601AA93 RID: 109203 RVA: 0x003E25FA File Offset: 0x003E07FA
		// (set) Token: 0x0601AA94 RID: 109204 RVA: 0x003E2602 File Offset: 0x003E0802
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

		// Token: 0x0601AA95 RID: 109205 RVA: 0x003E260B File Offset: 0x003E080B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamChallengeRequest);
		}

		// Token: 0x0601AA96 RID: 109206 RVA: 0x003E261C File Offset: 0x003E081C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamChallengeRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsInviteTeammate == other.IsInviteTeammate && this.InstEnterId == other.InstEnterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA97 RID: 109207 RVA: 0x003E2678 File Offset: 0x003E0878
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

		// Token: 0x0601AA98 RID: 109208 RVA: 0x003E26E9 File Offset: 0x003E08E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA99 RID: 109209 RVA: 0x003E26F6 File Offset: 0x003E08F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA9A RID: 109210 RVA: 0x003E2700 File Offset: 0x003E0900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			if (this.InstEnterId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.InstEnterId);
			}
			if (this.IsInviteTeammate)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsInviteTeammate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA9B RID: 109211 RVA: 0x003E2778 File Offset: 0x003E0978
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

		// Token: 0x0601AA9C RID: 109212 RVA: 0x003E27DC File Offset: 0x003E09DC
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

		// Token: 0x0601AA9D RID: 109213 RVA: 0x003E2840 File Offset: 0x003E0A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA9E RID: 109214 RVA: 0x003E284C File Offset: 0x003E0A4C
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsInviteTeammate = input.ReadBool();
						}
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
		}

		// Token: 0x04009C34 RID: 39988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C35 RID: 39989
		public const int InstIdFieldNumber = 2;

		// Token: 0x04009C36 RID: 39990
		private int instId_;

		// Token: 0x04009C37 RID: 39991
		public const int IsInviteTeammateFieldNumber = 10;

		// Token: 0x04009C38 RID: 39992
		private bool isInviteTeammate_;

		// Token: 0x04009C39 RID: 39993
		public const int InstEnterIdFieldNumber = 5;

		// Token: 0x04009C3A RID: 39994
		private int instEnterId_;
	}
}
