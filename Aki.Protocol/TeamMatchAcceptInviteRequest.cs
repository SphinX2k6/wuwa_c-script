using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001325 RID: 4901
	[NetMessage(EMessageId.TeamMatchAcceptInviteRequest)]
	public sealed class TeamMatchAcceptInviteRequest : IMessage<TeamMatchAcceptInviteRequest>, IMessage, IEquatable<TeamMatchAcceptInviteRequest>, IDeepCloneable<TeamMatchAcceptInviteRequest>, IBufferMessage
	{
		// Token: 0x0601A0B5 RID: 106677 RVA: 0x003C8A7C File Offset: 0x003C6C7C
		[NullableContext(1)]
		public static TeamMatchAcceptInviteRequest Create()
		{
			return new TeamMatchAcceptInviteRequest();
		}

		// Token: 0x170057D8 RID: 22488
		// (get) Token: 0x0601A0B6 RID: 106678 RVA: 0x003C8A83 File Offset: 0x003C6C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057D9 RID: 22489
		// (get) Token: 0x0601A0B7 RID: 106679 RVA: 0x003C8A86 File Offset: 0x003C6C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchAcceptInviteRequest.Descriptor;
			}
		}

		// Token: 0x0601A0B8 RID: 106680 RVA: 0x003C8A8D File Offset: 0x003C6C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteRequest()
		{
		}

		// Token: 0x0601A0B9 RID: 106681 RVA: 0x003C8A95 File Offset: 0x003C6C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteRequest(TeamMatchAcceptInviteRequest other) : this()
		{
			this.acceptResult_ = other.acceptResult_;
			this.hostId_ = other.hostId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0BA RID: 106682 RVA: 0x003C8AD2 File Offset: 0x003C6CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteRequest Clone()
		{
			return new TeamMatchAcceptInviteRequest(this);
		}

		// Token: 0x170057DA RID: 22490
		// (get) Token: 0x0601A0BB RID: 106683 RVA: 0x003C8ADA File Offset: 0x003C6CDA
		// (set) Token: 0x0601A0BC RID: 106684 RVA: 0x003C8AE2 File Offset: 0x003C6CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMatchAcceptInviteResult AcceptResult
		{
			get
			{
				return this.acceptResult_;
			}
			set
			{
				this.acceptResult_ = value;
			}
		}

		// Token: 0x170057DB RID: 22491
		// (get) Token: 0x0601A0BD RID: 106685 RVA: 0x003C8AEB File Offset: 0x003C6CEB
		// (set) Token: 0x0601A0BE RID: 106686 RVA: 0x003C8AF3 File Offset: 0x003C6CF3
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

		// Token: 0x170057DC RID: 22492
		// (get) Token: 0x0601A0BF RID: 106687 RVA: 0x003C8AFC File Offset: 0x003C6CFC
		// (set) Token: 0x0601A0C0 RID: 106688 RVA: 0x003C8B04 File Offset: 0x003C6D04
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

		// Token: 0x0601A0C1 RID: 106689 RVA: 0x003C8B0D File Offset: 0x003C6D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchAcceptInviteRequest);
		}

		// Token: 0x0601A0C2 RID: 106690 RVA: 0x003C8B1C File Offset: 0x003C6D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchAcceptInviteRequest other)
		{
			return other != null && (other == this || (this.AcceptResult == other.AcceptResult && this.HostId == other.HostId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0C3 RID: 106691 RVA: 0x003C8B78 File Offset: 0x003C6D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				num ^= this.AcceptResult.GetHashCode();
			}
			if (this.HostId != 0)
			{
				num ^= this.HostId.GetHashCode();
			}
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

		// Token: 0x0601A0C4 RID: 106692 RVA: 0x003C8BEF File Offset: 0x003C6DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0C5 RID: 106693 RVA: 0x003C8BFC File Offset: 0x003C6DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0C6 RID: 106694 RVA: 0x003C8C08 File Offset: 0x003C6E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.InstId);
			}
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.AcceptResult);
			}
			if (this.HostId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.HostId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A0C7 RID: 106695 RVA: 0x003C8C80 File Offset: 0x003C6E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AcceptResult);
			}
			if (this.HostId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostId);
			}
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

		// Token: 0x0601A0C8 RID: 106696 RVA: 0x003C8CF0 File Offset: 0x003C6EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchAcceptInviteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				this.AcceptResult = other.AcceptResult;
			}
			if (other.HostId != 0)
			{
				this.HostId = other.HostId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A0C9 RID: 106697 RVA: 0x003C8D54 File Offset: 0x003C6F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0CA RID: 106698 RVA: 0x003C8D60 File Offset: 0x003C6F60
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
				if (num != 24U)
				{
					if (num != 56U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HostId = input.ReadInt32();
						}
					}
					else
					{
						this.AcceptResult = (EMatchAcceptInviteResult)input.ReadEnum();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009821 RID: 38945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009822 RID: 38946
		public const int AcceptResultFieldNumber = 7;

		// Token: 0x04009823 RID: 38947
		private EMatchAcceptInviteResult acceptResult_;

		// Token: 0x04009824 RID: 38948
		public const int HostIdFieldNumber = 13;

		// Token: 0x04009825 RID: 38949
		private int hostId_;

		// Token: 0x04009826 RID: 38950
		public const int InstIdFieldNumber = 3;

		// Token: 0x04009827 RID: 38951
		private int instId_;
	}
}
