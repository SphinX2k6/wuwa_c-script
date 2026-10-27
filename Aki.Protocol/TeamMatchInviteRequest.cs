using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001329 RID: 4905
	[NetMessage(EMessageId.TeamMatchInviteRequest)]
	public sealed class TeamMatchInviteRequest : IMessage<TeamMatchInviteRequest>, IMessage, IEquatable<TeamMatchInviteRequest>, IDeepCloneable<TeamMatchInviteRequest>, IBufferMessage
	{
		// Token: 0x0601A105 RID: 106757 RVA: 0x003C94D4 File Offset: 0x003C76D4
		[NullableContext(1)]
		public static TeamMatchInviteRequest Create()
		{
			return new TeamMatchInviteRequest();
		}

		// Token: 0x170057E8 RID: 22504
		// (get) Token: 0x0601A106 RID: 106758 RVA: 0x003C94DB File Offset: 0x003C76DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057E9 RID: 22505
		// (get) Token: 0x0601A107 RID: 106759 RVA: 0x003C94DE File Offset: 0x003C76DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchInviteRequest.Descriptor;
			}
		}

		// Token: 0x0601A108 RID: 106760 RVA: 0x003C94E5 File Offset: 0x003C76E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRequest()
		{
		}

		// Token: 0x0601A109 RID: 106761 RVA: 0x003C94ED File Offset: 0x003C76ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRequest(TeamMatchInviteRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A10A RID: 106762 RVA: 0x003C9512 File Offset: 0x003C7712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRequest Clone()
		{
			return new TeamMatchInviteRequest(this);
		}

		// Token: 0x170057EA RID: 22506
		// (get) Token: 0x0601A10B RID: 106763 RVA: 0x003C951A File Offset: 0x003C771A
		// (set) Token: 0x0601A10C RID: 106764 RVA: 0x003C9522 File Offset: 0x003C7722
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

		// Token: 0x0601A10D RID: 106765 RVA: 0x003C952B File Offset: 0x003C772B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchInviteRequest);
		}

		// Token: 0x0601A10E RID: 106766 RVA: 0x003C9539 File Offset: 0x003C7739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchInviteRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A10F RID: 106767 RVA: 0x003C9568 File Offset: 0x003C7768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A110 RID: 106768 RVA: 0x003C95A7 File Offset: 0x003C77A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A111 RID: 106769 RVA: 0x003C95B4 File Offset: 0x003C77B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A112 RID: 106770 RVA: 0x003C95BD File Offset: 0x003C77BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A113 RID: 106771 RVA: 0x003C95F0 File Offset: 0x003C77F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A114 RID: 106772 RVA: 0x003C962E File Offset: 0x003C782E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchInviteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A115 RID: 106773 RVA: 0x003C965F File Offset: 0x003C785F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A116 RID: 106774 RVA: 0x003C9668 File Offset: 0x003C7868
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009835 RID: 38965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009836 RID: 38966
		public const int InstIdFieldNumber = 5;

		// Token: 0x04009837 RID: 38967
		private int instId_;
	}
}
