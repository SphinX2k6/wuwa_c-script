using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A5 RID: 5029
	[NetMessage(EMessageId.TeamTeleportStartNotify)]
	public sealed class TeamTeleportStartNotify : IMessage<TeamTeleportStartNotify>, IMessage, IEquatable<TeamTeleportStartNotify>, IDeepCloneable<TeamTeleportStartNotify>, IBufferMessage
	{
		// Token: 0x0601AC40 RID: 109632 RVA: 0x003E5D59 File Offset: 0x003E3F59
		[NullableContext(1)]
		public static TeamTeleportStartNotify Create()
		{
			return new TeamTeleportStartNotify();
		}

		// Token: 0x17005A9F RID: 23199
		// (get) Token: 0x0601AC41 RID: 109633 RVA: 0x003E5D60 File Offset: 0x003E3F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AA0 RID: 23200
		// (get) Token: 0x0601AC42 RID: 109634 RVA: 0x003E5D63 File Offset: 0x003E3F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamTeleportStartNotify.Descriptor;
			}
		}

		// Token: 0x0601AC43 RID: 109635 RVA: 0x003E5D6A File Offset: 0x003E3F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamTeleportStartNotify()
		{
		}

		// Token: 0x0601AC44 RID: 109636 RVA: 0x003E5D72 File Offset: 0x003E3F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamTeleportStartNotify(TeamTeleportStartNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.timeoutSec_ = other.timeoutSec_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC45 RID: 109637 RVA: 0x003E5DA3 File Offset: 0x003E3FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamTeleportStartNotify Clone()
		{
			return new TeamTeleportStartNotify(this);
		}

		// Token: 0x17005AA1 RID: 23201
		// (get) Token: 0x0601AC46 RID: 109638 RVA: 0x003E5DAB File Offset: 0x003E3FAB
		// (set) Token: 0x0601AC47 RID: 109639 RVA: 0x003E5DB3 File Offset: 0x003E3FB3
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

		// Token: 0x17005AA2 RID: 23202
		// (get) Token: 0x0601AC48 RID: 109640 RVA: 0x003E5DBC File Offset: 0x003E3FBC
		// (set) Token: 0x0601AC49 RID: 109641 RVA: 0x003E5DC4 File Offset: 0x003E3FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeoutSec
		{
			get
			{
				return this.timeoutSec_;
			}
			set
			{
				this.timeoutSec_ = value;
			}
		}

		// Token: 0x0601AC4A RID: 109642 RVA: 0x003E5DCD File Offset: 0x003E3FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamTeleportStartNotify);
		}

		// Token: 0x0601AC4B RID: 109643 RVA: 0x003E5DDB File Offset: 0x003E3FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamTeleportStartNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.TimeoutSec == other.TimeoutSec && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC4C RID: 109644 RVA: 0x003E5E1C File Offset: 0x003E401C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.TimeoutSec != 0)
			{
				num ^= this.TimeoutSec.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AC4D RID: 109645 RVA: 0x003E5E74 File Offset: 0x003E4074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC4E RID: 109646 RVA: 0x003E5E81 File Offset: 0x003E4081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC4F RID: 109647 RVA: 0x003E5E8C File Offset: 0x003E408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this.TimeoutSec != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TimeoutSec);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC50 RID: 109648 RVA: 0x003E5EE8 File Offset: 0x003E40E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.TimeoutSec != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeoutSec);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AC51 RID: 109649 RVA: 0x003E5F40 File Offset: 0x003E4140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamTeleportStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.TimeoutSec != 0)
			{
				this.TimeoutSec = other.TimeoutSec;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC52 RID: 109650 RVA: 0x003E5F90 File Offset: 0x003E4190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC53 RID: 109651 RVA: 0x003E5F9C File Offset: 0x003E419C
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
				if (num != 72U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TimeoutSec = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009CA5 RID: 40101
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CA6 RID: 40102
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x04009CA7 RID: 40103
		private int playerId_;

		// Token: 0x04009CA8 RID: 40104
		public const int TimeoutSecFieldNumber = 11;

		// Token: 0x04009CA9 RID: 40105
		private int timeoutSec_;
	}
}
