using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA1 RID: 3489
	[NetMessage(EMessageId.PlayerTeleportStateNotify)]
	public sealed class PlayerTeleportStateNotify : IMessage<PlayerTeleportStateNotify>, IMessage, IEquatable<PlayerTeleportStateNotify>, IDeepCloneable<PlayerTeleportStateNotify>, IBufferMessage
	{
		// Token: 0x06012D32 RID: 77106 RVA: 0x002BF96C File Offset: 0x002BDB6C
		[NullableContext(1)]
		public static PlayerTeleportStateNotify Create()
		{
			return new PlayerTeleportStateNotify();
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x06012D33 RID: 77107 RVA: 0x002BF973 File Offset: 0x002BDB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x06012D34 RID: 77108 RVA: 0x002BF976 File Offset: 0x002BDB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTeleportStateNotify.Descriptor;
			}
		}

		// Token: 0x06012D35 RID: 77109 RVA: 0x002BF97D File Offset: 0x002BDB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTeleportStateNotify()
		{
		}

		// Token: 0x06012D36 RID: 77110 RVA: 0x002BF988 File Offset: 0x002BDB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTeleportStateNotify(PlayerTeleportStateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.teleportState_ = other.teleportState_;
			this.curRolePosInfo_ = ((other.curRolePosInfo_ != null) ? other.curRolePosInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D37 RID: 77111 RVA: 0x002BF9E0 File Offset: 0x002BDBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTeleportStateNotify Clone()
		{
			return new PlayerTeleportStateNotify(this);
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x06012D38 RID: 77112 RVA: 0x002BF9E8 File Offset: 0x002BDBE8
		// (set) Token: 0x06012D39 RID: 77113 RVA: 0x002BF9F0 File Offset: 0x002BDBF0
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

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x06012D3A RID: 77114 RVA: 0x002BF9F9 File Offset: 0x002BDBF9
		// (set) Token: 0x06012D3B RID: 77115 RVA: 0x002BFA01 File Offset: 0x002BDC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EPlayerTeleportState TeleportState
		{
			get
			{
				return this.teleportState_;
			}
			set
			{
				this.teleportState_ = value;
			}
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x06012D3C RID: 77116 RVA: 0x002BFA0A File Offset: 0x002BDC0A
		// (set) Token: 0x06012D3D RID: 77117 RVA: 0x002BFA12 File Offset: 0x002BDC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfo CurRolePosInfo
		{
			get
			{
				return this.curRolePosInfo_;
			}
			set
			{
				this.curRolePosInfo_ = value;
			}
		}

		// Token: 0x06012D3E RID: 77118 RVA: 0x002BFA1B File Offset: 0x002BDC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTeleportStateNotify);
		}

		// Token: 0x06012D3F RID: 77119 RVA: 0x002BFA2C File Offset: 0x002BDC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTeleportStateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.TeleportState == other.TeleportState && object.Equals(this.CurRolePosInfo, other.CurRolePosInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D40 RID: 77120 RVA: 0x002BFA8C File Offset: 0x002BDC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.TeleportState != EPlayerTeleportState.Default)
			{
				num ^= this.TeleportState.GetHashCode();
			}
			if (this.curRolePosInfo_ != null)
			{
				num ^= this.CurRolePosInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D41 RID: 77121 RVA: 0x002BFB00 File Offset: 0x002BDD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D42 RID: 77122 RVA: 0x002BFB0D File Offset: 0x002BDD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D43 RID: 77123 RVA: 0x002BFB18 File Offset: 0x002BDD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curRolePosInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CurRolePosInfo);
			}
			if (this.TeleportState != EPlayerTeleportState.Default)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.TeleportState);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D44 RID: 77124 RVA: 0x002BFB90 File Offset: 0x002BDD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.TeleportState != EPlayerTeleportState.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TeleportState);
			}
			if (this.curRolePosInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurRolePosInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D45 RID: 77125 RVA: 0x002BFC00 File Offset: 0x002BDE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerTeleportStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.TeleportState != EPlayerTeleportState.Default)
			{
				this.TeleportState = other.TeleportState;
			}
			if (other.curRolePosInfo_ != null)
			{
				if (this.curRolePosInfo_ == null)
				{
					this.CurRolePosInfo = new EntitySimplyMoveInfo();
				}
				this.CurRolePosInfo.MergeFrom(other.CurRolePosInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D46 RID: 77126 RVA: 0x002BFC7C File Offset: 0x002BDE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D47 RID: 77127 RVA: 0x002BFC88 File Offset: 0x002BDE88
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
				if (num != 42U)
				{
					if (num != 64U)
					{
						if (num != 88U)
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
						this.TeleportState = (EPlayerTeleportState)input.ReadEnum();
					}
				}
				else
				{
					if (this.curRolePosInfo_ == null)
					{
						this.CurRolePosInfo = new EntitySimplyMoveInfo();
					}
					input.ReadMessage(this.CurRolePosInfo);
				}
			}
		}

		// Token: 0x040074FF RID: 29951
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007500 RID: 29952
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x04007501 RID: 29953
		private int playerId_;

		// Token: 0x04007502 RID: 29954
		public const int TeleportStateFieldNumber = 8;

		// Token: 0x04007503 RID: 29955
		private EPlayerTeleportState teleportState_;

		// Token: 0x04007504 RID: 29956
		public const int CurRolePosInfoFieldNumber = 5;

		// Token: 0x04007505 RID: 29957
		private EntitySimplyMoveInfo curRolePosInfo_;
	}
}
