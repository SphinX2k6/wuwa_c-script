using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001328 RID: 4904
	[NetMessage(EMessageId.TeamMatchInviteNotify)]
	public sealed class TeamMatchInviteNotify : IMessage<TeamMatchInviteNotify>, IMessage, IEquatable<TeamMatchInviteNotify>, IDeepCloneable<TeamMatchInviteNotify>, IBufferMessage
	{
		// Token: 0x0601A0F1 RID: 106737 RVA: 0x003C923C File Offset: 0x003C743C
		[NullableContext(1)]
		public static TeamMatchInviteNotify Create()
		{
			return new TeamMatchInviteNotify();
		}

		// Token: 0x170057E4 RID: 22500
		// (get) Token: 0x0601A0F2 RID: 106738 RVA: 0x003C9243 File Offset: 0x003C7443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057E5 RID: 22501
		// (get) Token: 0x0601A0F3 RID: 106739 RVA: 0x003C9246 File Offset: 0x003C7446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchInviteNotify.Descriptor;
			}
		}

		// Token: 0x0601A0F4 RID: 106740 RVA: 0x003C924D File Offset: 0x003C744D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteNotify()
		{
		}

		// Token: 0x0601A0F5 RID: 106741 RVA: 0x003C9255 File Offset: 0x003C7455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteNotify(TeamMatchInviteNotify other) : this()
		{
			this.hostId_ = other.hostId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0F6 RID: 106742 RVA: 0x003C9286 File Offset: 0x003C7486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteNotify Clone()
		{
			return new TeamMatchInviteNotify(this);
		}

		// Token: 0x170057E6 RID: 22502
		// (get) Token: 0x0601A0F7 RID: 106743 RVA: 0x003C928E File Offset: 0x003C748E
		// (set) Token: 0x0601A0F8 RID: 106744 RVA: 0x003C9296 File Offset: 0x003C7496
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

		// Token: 0x170057E7 RID: 22503
		// (get) Token: 0x0601A0F9 RID: 106745 RVA: 0x003C929F File Offset: 0x003C749F
		// (set) Token: 0x0601A0FA RID: 106746 RVA: 0x003C92A7 File Offset: 0x003C74A7
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

		// Token: 0x0601A0FB RID: 106747 RVA: 0x003C92B0 File Offset: 0x003C74B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchInviteNotify);
		}

		// Token: 0x0601A0FC RID: 106748 RVA: 0x003C92BE File Offset: 0x003C74BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchInviteNotify other)
		{
			return other != null && (other == this || (this.HostId == other.HostId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0FD RID: 106749 RVA: 0x003C92FC File Offset: 0x003C74FC
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

		// Token: 0x0601A0FE RID: 106750 RVA: 0x003C9354 File Offset: 0x003C7554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0FF RID: 106751 RVA: 0x003C9361 File Offset: 0x003C7561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A100 RID: 106752 RVA: 0x003C936C File Offset: 0x003C756C
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
				output.WriteRawTag(88);
				output.WriteInt32(this.HostId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A101 RID: 106753 RVA: 0x003C93C8 File Offset: 0x003C75C8
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

		// Token: 0x0601A102 RID: 106754 RVA: 0x003C9420 File Offset: 0x003C7620
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

		// Token: 0x0601A103 RID: 106755 RVA: 0x003C9470 File Offset: 0x003C7670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A104 RID: 106756 RVA: 0x003C947C File Offset: 0x003C767C
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
					if (num != 88U)
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

		// Token: 0x04009830 RID: 38960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009831 RID: 38961
		public const int HostIdFieldNumber = 11;

		// Token: 0x04009832 RID: 38962
		private int hostId_;

		// Token: 0x04009833 RID: 38963
		public const int InstIdFieldNumber = 4;

		// Token: 0x04009834 RID: 38964
		private int instId_;
	}
}
