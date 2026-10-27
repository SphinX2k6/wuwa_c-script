using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D97 RID: 3479
	[NetMessage(EMessageId.PlayerLeaveWorldTeamNotify)]
	public sealed class PlayerLeaveWorldTeamNotify : IMessage<PlayerLeaveWorldTeamNotify>, IMessage, IEquatable<PlayerLeaveWorldTeamNotify>, IDeepCloneable<PlayerLeaveWorldTeamNotify>, IBufferMessage
	{
		// Token: 0x06012C12 RID: 76818 RVA: 0x002BC961 File Offset: 0x002BAB61
		[NullableContext(1)]
		public static PlayerLeaveWorldTeamNotify Create()
		{
			return new PlayerLeaveWorldTeamNotify();
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x06012C13 RID: 76819 RVA: 0x002BC968 File Offset: 0x002BAB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x06012C14 RID: 76820 RVA: 0x002BC96B File Offset: 0x002BAB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLeaveWorldTeamNotify.Descriptor;
			}
		}

		// Token: 0x06012C15 RID: 76821 RVA: 0x002BC972 File Offset: 0x002BAB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLeaveWorldTeamNotify()
		{
		}

		// Token: 0x06012C16 RID: 76822 RVA: 0x002BC97A File Offset: 0x002BAB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLeaveWorldTeamNotify(PlayerLeaveWorldTeamNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C17 RID: 76823 RVA: 0x002BC9AB File Offset: 0x002BABAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLeaveWorldTeamNotify Clone()
		{
			return new PlayerLeaveWorldTeamNotify(this);
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x06012C18 RID: 76824 RVA: 0x002BC9B3 File Offset: 0x002BABB3
		// (set) Token: 0x06012C19 RID: 76825 RVA: 0x002BC9BB File Offset: 0x002BABBB
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

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x06012C1A RID: 76826 RVA: 0x002BC9C4 File Offset: 0x002BABC4
		// (set) Token: 0x06012C1B RID: 76827 RVA: 0x002BC9CC File Offset: 0x002BABCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamLeaveReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x06012C1C RID: 76828 RVA: 0x002BC9D5 File Offset: 0x002BABD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLeaveWorldTeamNotify);
		}

		// Token: 0x06012C1D RID: 76829 RVA: 0x002BC9E3 File Offset: 0x002BABE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLeaveWorldTeamNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C1E RID: 76830 RVA: 0x002BCA24 File Offset: 0x002BAC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Reason != WorldTeamLeaveReason.Initiative)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012C1F RID: 76831 RVA: 0x002BCA82 File Offset: 0x002BAC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C20 RID: 76832 RVA: 0x002BCA8F File Offset: 0x002BAC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C21 RID: 76833 RVA: 0x002BCA98 File Offset: 0x002BAC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != WorldTeamLeaveReason.Initiative)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Reason);
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

		// Token: 0x06012C22 RID: 76834 RVA: 0x002BCAF4 File Offset: 0x002BACF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Reason != WorldTeamLeaveReason.Initiative)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C23 RID: 76835 RVA: 0x002BCB4C File Offset: 0x002BAD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerLeaveWorldTeamNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Reason != WorldTeamLeaveReason.Initiative)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C24 RID: 76836 RVA: 0x002BCB9C File Offset: 0x002BAD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C25 RID: 76837 RVA: 0x002BCBA8 File Offset: 0x002BADA8
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
					this.Reason = (WorldTeamLeaveReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007443 RID: 29763
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007444 RID: 29764
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x04007445 RID: 29765
		private int playerId_;

		// Token: 0x04007446 RID: 29766
		public const int ReasonFieldNumber = 3;

		// Token: 0x04007447 RID: 29767
		private WorldTeamLeaveReason reason_;
	}
}
