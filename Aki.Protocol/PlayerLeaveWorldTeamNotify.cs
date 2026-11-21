using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D87 RID: 3463
	[NetMessage(EMessageId.PlayerLeaveWorldTeamNotify)]
	public sealed class PlayerLeaveWorldTeamNotify : IMessage<PlayerLeaveWorldTeamNotify>, IMessage, IEquatable<PlayerLeaveWorldTeamNotify>, IDeepCloneable<PlayerLeaveWorldTeamNotify>, IBufferMessage
	{
		// Token: 0x06012B16 RID: 76566 RVA: 0x002BAD3D File Offset: 0x002B8F3D
		[NullableContext(1)]
		public static PlayerLeaveWorldTeamNotify Create()
		{
			return new PlayerLeaveWorldTeamNotify();
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x06012B17 RID: 76567 RVA: 0x002BAD44 File Offset: 0x002B8F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x06012B18 RID: 76568 RVA: 0x002BAD47 File Offset: 0x002B8F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLeaveWorldTeamNotify.Descriptor;
			}
		}

		// Token: 0x06012B19 RID: 76569 RVA: 0x002BAD4E File Offset: 0x002B8F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLeaveWorldTeamNotify()
		{
		}

		// Token: 0x06012B1A RID: 76570 RVA: 0x002BAD56 File Offset: 0x002B8F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLeaveWorldTeamNotify(PlayerLeaveWorldTeamNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B1B RID: 76571 RVA: 0x002BAD87 File Offset: 0x002B8F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLeaveWorldTeamNotify Clone()
		{
			return new PlayerLeaveWorldTeamNotify(this);
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x06012B1C RID: 76572 RVA: 0x002BAD8F File Offset: 0x002B8F8F
		// (set) Token: 0x06012B1D RID: 76573 RVA: 0x002BAD97 File Offset: 0x002B8F97
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

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x06012B1E RID: 76574 RVA: 0x002BADA0 File Offset: 0x002B8FA0
		// (set) Token: 0x06012B1F RID: 76575 RVA: 0x002BADA8 File Offset: 0x002B8FA8
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

		// Token: 0x06012B20 RID: 76576 RVA: 0x002BADB1 File Offset: 0x002B8FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLeaveWorldTeamNotify);
		}

		// Token: 0x06012B21 RID: 76577 RVA: 0x002BADBF File Offset: 0x002B8FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLeaveWorldTeamNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B22 RID: 76578 RVA: 0x002BAE00 File Offset: 0x002B9000
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

		// Token: 0x06012B23 RID: 76579 RVA: 0x002BAE5E File Offset: 0x002B905E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B24 RID: 76580 RVA: 0x002BAE6B File Offset: 0x002B906B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B25 RID: 76581 RVA: 0x002BAE74 File Offset: 0x002B9074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Reason != WorldTeamLeaveReason.Initiative)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B26 RID: 76582 RVA: 0x002BAED0 File Offset: 0x002B90D0
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

		// Token: 0x06012B27 RID: 76583 RVA: 0x002BAF28 File Offset: 0x002B9128
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

		// Token: 0x06012B28 RID: 76584 RVA: 0x002BAF78 File Offset: 0x002B9178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B29 RID: 76585 RVA: 0x002BAF84 File Offset: 0x002B9184
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
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = (WorldTeamLeaveReason)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400745B RID: 29787
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400745C RID: 29788
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x0400745D RID: 29789
		private int playerId_;

		// Token: 0x0400745E RID: 29790
		public const int ReasonFieldNumber = 15;

		// Token: 0x0400745F RID: 29791
		private WorldTeamLeaveReason reason_;
	}
}
