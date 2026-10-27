using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001332 RID: 4914
	[NetMessage(EMessageId.TeamTeleportStartNotify)]
	public sealed class TeamTeleportStartNotify : IMessage<TeamTeleportStartNotify>, IMessage, IEquatable<TeamTeleportStartNotify>, IDeepCloneable<TeamTeleportStartNotify>, IBufferMessage
	{
		// Token: 0x0601A1B9 RID: 106937 RVA: 0x003CAC24 File Offset: 0x003C8E24
		[NullableContext(1)]
		public static TeamTeleportStartNotify Create()
		{
			return new TeamTeleportStartNotify();
		}

		// Token: 0x1700580C RID: 22540
		// (get) Token: 0x0601A1BA RID: 106938 RVA: 0x003CAC2B File Offset: 0x003C8E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700580D RID: 22541
		// (get) Token: 0x0601A1BB RID: 106939 RVA: 0x003CAC2E File Offset: 0x003C8E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamTeleportStartNotify.Descriptor;
			}
		}

		// Token: 0x0601A1BC RID: 106940 RVA: 0x003CAC35 File Offset: 0x003C8E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamTeleportStartNotify()
		{
		}

		// Token: 0x0601A1BD RID: 106941 RVA: 0x003CAC3D File Offset: 0x003C8E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamTeleportStartNotify(TeamTeleportStartNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.timeoutSec_ = other.timeoutSec_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1BE RID: 106942 RVA: 0x003CAC6E File Offset: 0x003C8E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamTeleportStartNotify Clone()
		{
			return new TeamTeleportStartNotify(this);
		}

		// Token: 0x1700580E RID: 22542
		// (get) Token: 0x0601A1BF RID: 106943 RVA: 0x003CAC76 File Offset: 0x003C8E76
		// (set) Token: 0x0601A1C0 RID: 106944 RVA: 0x003CAC7E File Offset: 0x003C8E7E
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

		// Token: 0x1700580F RID: 22543
		// (get) Token: 0x0601A1C1 RID: 106945 RVA: 0x003CAC87 File Offset: 0x003C8E87
		// (set) Token: 0x0601A1C2 RID: 106946 RVA: 0x003CAC8F File Offset: 0x003C8E8F
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

		// Token: 0x0601A1C3 RID: 106947 RVA: 0x003CAC98 File Offset: 0x003C8E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamTeleportStartNotify);
		}

		// Token: 0x0601A1C4 RID: 106948 RVA: 0x003CACA6 File Offset: 0x003C8EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamTeleportStartNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.TimeoutSec == other.TimeoutSec && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A1C5 RID: 106949 RVA: 0x003CACE4 File Offset: 0x003C8EE4
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

		// Token: 0x0601A1C6 RID: 106950 RVA: 0x003CAD3C File Offset: 0x003C8F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1C7 RID: 106951 RVA: 0x003CAD49 File Offset: 0x003C8F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1C8 RID: 106952 RVA: 0x003CAD54 File Offset: 0x003C8F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeoutSec != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TimeoutSec);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1C9 RID: 106953 RVA: 0x003CADB0 File Offset: 0x003C8FB0
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

		// Token: 0x0601A1CA RID: 106954 RVA: 0x003CAE08 File Offset: 0x003C9008
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

		// Token: 0x0601A1CB RID: 106955 RVA: 0x003CAE58 File Offset: 0x003C9058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1CC RID: 106956 RVA: 0x003CAE64 File Offset: 0x003C9064
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.TimeoutSec = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009863 RID: 39011
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009864 RID: 39012
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x04009865 RID: 39013
		private int playerId_;

		// Token: 0x04009866 RID: 39014
		public const int TimeoutSecFieldNumber = 2;

		// Token: 0x04009867 RID: 39015
		private int timeoutSec_;
	}
}
