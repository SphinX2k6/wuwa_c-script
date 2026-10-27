using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB1 RID: 3505
	[NetMessage(EMessageId.PlayerTeleportStateNotify)]
	public sealed class PlayerTeleportStateNotify : IMessage<PlayerTeleportStateNotify>, IMessage, IEquatable<PlayerTeleportStateNotify>, IDeepCloneable<PlayerTeleportStateNotify>, IBufferMessage
	{
		// Token: 0x06012E2E RID: 77358 RVA: 0x002C1590 File Offset: 0x002BF790
		[NullableContext(1)]
		public static PlayerTeleportStateNotify Create()
		{
			return new PlayerTeleportStateNotify();
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x06012E2F RID: 77359 RVA: 0x002C1597 File Offset: 0x002BF797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x06012E30 RID: 77360 RVA: 0x002C159A File Offset: 0x002BF79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTeleportStateNotify.Descriptor;
			}
		}

		// Token: 0x06012E31 RID: 77361 RVA: 0x002C15A1 File Offset: 0x002BF7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTeleportStateNotify()
		{
		}

		// Token: 0x06012E32 RID: 77362 RVA: 0x002C15AC File Offset: 0x002BF7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTeleportStateNotify(PlayerTeleportStateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.teleportState_ = other.teleportState_;
			this.curRolePosInfo_ = ((other.curRolePosInfo_ != null) ? other.curRolePosInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E33 RID: 77363 RVA: 0x002C1604 File Offset: 0x002BF804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTeleportStateNotify Clone()
		{
			return new PlayerTeleportStateNotify(this);
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x06012E34 RID: 77364 RVA: 0x002C160C File Offset: 0x002BF80C
		// (set) Token: 0x06012E35 RID: 77365 RVA: 0x002C1614 File Offset: 0x002BF814
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

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x06012E36 RID: 77366 RVA: 0x002C161D File Offset: 0x002BF81D
		// (set) Token: 0x06012E37 RID: 77367 RVA: 0x002C1625 File Offset: 0x002BF825
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

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x06012E38 RID: 77368 RVA: 0x002C162E File Offset: 0x002BF82E
		// (set) Token: 0x06012E39 RID: 77369 RVA: 0x002C1636 File Offset: 0x002BF836
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

		// Token: 0x06012E3A RID: 77370 RVA: 0x002C163F File Offset: 0x002BF83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTeleportStateNotify);
		}

		// Token: 0x06012E3B RID: 77371 RVA: 0x002C1650 File Offset: 0x002BF850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTeleportStateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.TeleportState == other.TeleportState && object.Equals(this.CurRolePosInfo, other.CurRolePosInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E3C RID: 77372 RVA: 0x002C16B0 File Offset: 0x002BF8B0
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

		// Token: 0x06012E3D RID: 77373 RVA: 0x002C1724 File Offset: 0x002BF924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E3E RID: 77374 RVA: 0x002C1731 File Offset: 0x002BF931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E3F RID: 77375 RVA: 0x002C173C File Offset: 0x002BF93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this.curRolePosInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CurRolePosInfo);
			}
			if (this.TeleportState != EPlayerTeleportState.Default)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.TeleportState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E40 RID: 77376 RVA: 0x002C17B4 File Offset: 0x002BF9B4
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

		// Token: 0x06012E41 RID: 77377 RVA: 0x002C1824 File Offset: 0x002BFA24
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

		// Token: 0x06012E42 RID: 77378 RVA: 0x002C18A0 File Offset: 0x002BFAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E43 RID: 77379 RVA: 0x002C18AC File Offset: 0x002BFAAC
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
				if (num != 48U)
				{
					if (num != 74U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040074E7 RID: 29927
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074E8 RID: 29928
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x040074E9 RID: 29929
		private int playerId_;

		// Token: 0x040074EA RID: 29930
		public const int TeleportStateFieldNumber = 11;

		// Token: 0x040074EB RID: 29931
		private EPlayerTeleportState teleportState_;

		// Token: 0x040074EC RID: 29932
		public const int CurRolePosInfoFieldNumber = 9;

		// Token: 0x040074ED RID: 29933
		private EntitySimplyMoveInfo curRolePosInfo_;
	}
}
