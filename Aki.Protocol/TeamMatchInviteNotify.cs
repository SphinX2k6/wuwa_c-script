using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001395 RID: 5013
	[NetMessage(EMessageId.TeamMatchInviteNotify)]
	public sealed class TeamMatchInviteNotify : IMessage<TeamMatchInviteNotify>, IMessage, IEquatable<TeamMatchInviteNotify>, IDeepCloneable<TeamMatchInviteNotify>, IBufferMessage
	{
		// Token: 0x0601AB01 RID: 109313 RVA: 0x003E34F8 File Offset: 0x003E16F8
		[NullableContext(1)]
		public static TeamMatchInviteNotify Create()
		{
			return new TeamMatchInviteNotify();
		}

		// Token: 0x17005A5E RID: 23134
		// (get) Token: 0x0601AB02 RID: 109314 RVA: 0x003E34FF File Offset: 0x003E16FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A5F RID: 23135
		// (get) Token: 0x0601AB03 RID: 109315 RVA: 0x003E3502 File Offset: 0x003E1702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchInviteNotify.Descriptor;
			}
		}

		// Token: 0x0601AB04 RID: 109316 RVA: 0x003E3509 File Offset: 0x003E1709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteNotify()
		{
		}

		// Token: 0x0601AB05 RID: 109317 RVA: 0x003E3511 File Offset: 0x003E1711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteNotify(TeamMatchInviteNotify other) : this()
		{
			this.hostId_ = other.hostId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB06 RID: 109318 RVA: 0x003E3542 File Offset: 0x003E1742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteNotify Clone()
		{
			return new TeamMatchInviteNotify(this);
		}

		// Token: 0x17005A60 RID: 23136
		// (get) Token: 0x0601AB07 RID: 109319 RVA: 0x003E354A File Offset: 0x003E174A
		// (set) Token: 0x0601AB08 RID: 109320 RVA: 0x003E3552 File Offset: 0x003E1752
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

		// Token: 0x17005A61 RID: 23137
		// (get) Token: 0x0601AB09 RID: 109321 RVA: 0x003E355B File Offset: 0x003E175B
		// (set) Token: 0x0601AB0A RID: 109322 RVA: 0x003E3563 File Offset: 0x003E1763
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

		// Token: 0x0601AB0B RID: 109323 RVA: 0x003E356C File Offset: 0x003E176C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchInviteNotify);
		}

		// Token: 0x0601AB0C RID: 109324 RVA: 0x003E357A File Offset: 0x003E177A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchInviteNotify other)
		{
			return other != null && (other == this || (this.HostId == other.HostId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB0D RID: 109325 RVA: 0x003E35B8 File Offset: 0x003E17B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601AB0E RID: 109326 RVA: 0x003E3610 File Offset: 0x003E1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB0F RID: 109327 RVA: 0x003E361D File Offset: 0x003E181D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB10 RID: 109328 RVA: 0x003E3628 File Offset: 0x003E1828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			if (this.HostId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.HostId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB11 RID: 109329 RVA: 0x003E3684 File Offset: 0x003E1884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601AB12 RID: 109330 RVA: 0x003E36DC File Offset: 0x003E18DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchInviteNotify other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0601AB13 RID: 109331 RVA: 0x003E372C File Offset: 0x003E192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB14 RID: 109332 RVA: 0x003E3738 File Offset: 0x003E1938
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
					if (num != 112U)
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
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C52 RID: 40018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C53 RID: 40019
		public const int HostIdFieldNumber = 14;

		// Token: 0x04009C54 RID: 40020
		private int hostId_;

		// Token: 0x04009C55 RID: 40021
		public const int InstIdFieldNumber = 4;

		// Token: 0x04009C56 RID: 40022
		private int instId_;
	}
}
