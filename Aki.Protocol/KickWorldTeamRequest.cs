using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000881 RID: 2177
	[NetMessage(EMessageId.KickWorldTeamRequest)]
	public sealed class KickWorldTeamRequest : IMessage<KickWorldTeamRequest>, IMessage, IEquatable<KickWorldTeamRequest>, IDeepCloneable<KickWorldTeamRequest>, IBufferMessage
	{
		// Token: 0x0600C1CA RID: 49610 RVA: 0x001CC4D1 File Offset: 0x001CA6D1
		[NullableContext(1)]
		public static KickWorldTeamRequest Create()
		{
			return new KickWorldTeamRequest();
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x0600C1CB RID: 49611 RVA: 0x001CC4D8 File Offset: 0x001CA6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x0600C1CC RID: 49612 RVA: 0x001CC4DB File Offset: 0x001CA6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickWorldTeamRequest.Descriptor;
			}
		}

		// Token: 0x0600C1CD RID: 49613 RVA: 0x001CC4E2 File Offset: 0x001CA6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamRequest()
		{
		}

		// Token: 0x0600C1CE RID: 49614 RVA: 0x001CC4EA File Offset: 0x001CA6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamRequest(KickWorldTeamRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1CF RID: 49615 RVA: 0x001CC50F File Offset: 0x001CA70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamRequest Clone()
		{
			return new KickWorldTeamRequest(this);
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x0600C1D0 RID: 49616 RVA: 0x001CC517 File Offset: 0x001CA717
		// (set) Token: 0x0600C1D1 RID: 49617 RVA: 0x001CC51F File Offset: 0x001CA71F
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

		// Token: 0x0600C1D2 RID: 49618 RVA: 0x001CC528 File Offset: 0x001CA728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickWorldTeamRequest);
		}

		// Token: 0x0600C1D3 RID: 49619 RVA: 0x001CC536 File Offset: 0x001CA736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KickWorldTeamRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1D4 RID: 49620 RVA: 0x001CC564 File Offset: 0x001CA764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C1D5 RID: 49621 RVA: 0x001CC5A3 File Offset: 0x001CA7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x001CC5B0 File Offset: 0x001CA7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x001CC5B9 File Offset: 0x001CA7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x001CC5EC File Offset: 0x001CA7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x001CC62A File Offset: 0x001CA82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KickWorldTeamRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1DA RID: 49626 RVA: 0x001CC65B File Offset: 0x001CA85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x001CC664 File Offset: 0x001CA864
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005400 RID: 21504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005401 RID: 21505
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005402 RID: 21506
		private int playerId_;
	}
}
