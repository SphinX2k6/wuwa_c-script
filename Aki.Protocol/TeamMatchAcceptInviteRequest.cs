using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001392 RID: 5010
	[NetMessage(EMessageId.TeamMatchAcceptInviteRequest)]
	public sealed class TeamMatchAcceptInviteRequest : IMessage<TeamMatchAcceptInviteRequest>, IMessage, IEquatable<TeamMatchAcceptInviteRequest>, IDeepCloneable<TeamMatchAcceptInviteRequest>, IBufferMessage
	{
		// Token: 0x0601AAC5 RID: 109253 RVA: 0x003E2D38 File Offset: 0x003E0F38
		[NullableContext(1)]
		public static TeamMatchAcceptInviteRequest Create()
		{
			return new TeamMatchAcceptInviteRequest();
		}

		// Token: 0x17005A52 RID: 23122
		// (get) Token: 0x0601AAC6 RID: 109254 RVA: 0x003E2D3F File Offset: 0x003E0F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A53 RID: 23123
		// (get) Token: 0x0601AAC7 RID: 109255 RVA: 0x003E2D42 File Offset: 0x003E0F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchAcceptInviteRequest.Descriptor;
			}
		}

		// Token: 0x0601AAC8 RID: 109256 RVA: 0x003E2D49 File Offset: 0x003E0F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteRequest()
		{
		}

		// Token: 0x0601AAC9 RID: 109257 RVA: 0x003E2D51 File Offset: 0x003E0F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteRequest(TeamMatchAcceptInviteRequest other) : this()
		{
			this.acceptResult_ = other.acceptResult_;
			this.hostId_ = other.hostId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AACA RID: 109258 RVA: 0x003E2D8E File Offset: 0x003E0F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteRequest Clone()
		{
			return new TeamMatchAcceptInviteRequest(this);
		}

		// Token: 0x17005A54 RID: 23124
		// (get) Token: 0x0601AACB RID: 109259 RVA: 0x003E2D96 File Offset: 0x003E0F96
		// (set) Token: 0x0601AACC RID: 109260 RVA: 0x003E2D9E File Offset: 0x003E0F9E
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

		// Token: 0x17005A55 RID: 23125
		// (get) Token: 0x0601AACD RID: 109261 RVA: 0x003E2DA7 File Offset: 0x003E0FA7
		// (set) Token: 0x0601AACE RID: 109262 RVA: 0x003E2DAF File Offset: 0x003E0FAF
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

		// Token: 0x17005A56 RID: 23126
		// (get) Token: 0x0601AACF RID: 109263 RVA: 0x003E2DB8 File Offset: 0x003E0FB8
		// (set) Token: 0x0601AAD0 RID: 109264 RVA: 0x003E2DC0 File Offset: 0x003E0FC0
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

		// Token: 0x0601AAD1 RID: 109265 RVA: 0x003E2DC9 File Offset: 0x003E0FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchAcceptInviteRequest);
		}

		// Token: 0x0601AAD2 RID: 109266 RVA: 0x003E2DD8 File Offset: 0x003E0FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchAcceptInviteRequest other)
		{
			return other != null && (other == this || (this.AcceptResult == other.AcceptResult && this.HostId == other.HostId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AAD3 RID: 109267 RVA: 0x003E2E34 File Offset: 0x003E1034
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

		// Token: 0x0601AAD4 RID: 109268 RVA: 0x003E2EAB File Offset: 0x003E10AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AAD5 RID: 109269 RVA: 0x003E2EB8 File Offset: 0x003E10B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAD6 RID: 109270 RVA: 0x003E2EC4 File Offset: 0x003E10C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.AcceptResult);
			}
			if (this.HostId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.HostId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AAD7 RID: 109271 RVA: 0x003E2F3C File Offset: 0x003E113C
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

		// Token: 0x0601AAD8 RID: 109272 RVA: 0x003E2FAC File Offset: 0x003E11AC
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

		// Token: 0x0601AAD9 RID: 109273 RVA: 0x003E3010 File Offset: 0x003E1210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AADA RID: 109274 RVA: 0x003E301C File Offset: 0x003E121C
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
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstId = input.ReadInt32();
						}
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
		}

		// Token: 0x04009C43 RID: 40003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C44 RID: 40004
		public const int AcceptResultFieldNumber = 3;

		// Token: 0x04009C45 RID: 40005
		private EMatchAcceptInviteResult acceptResult_;

		// Token: 0x04009C46 RID: 40006
		public const int HostIdFieldNumber = 10;

		// Token: 0x04009C47 RID: 40007
		private int hostId_;

		// Token: 0x04009C48 RID: 40008
		public const int InstIdFieldNumber = 13;

		// Token: 0x04009C49 RID: 40009
		private int instId_;
	}
}
