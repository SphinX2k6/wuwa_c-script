using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133E RID: 4926
	[NetMessage(EMessageId.TeleportNotify)]
	public sealed class TeleportNotify : IMessage<TeleportNotify>, IMessage, IEquatable<TeleportNotify>, IDeepCloneable<TeleportNotify>, IBufferMessage
	{
		// Token: 0x0601A2A5 RID: 107173 RVA: 0x003CCA01 File Offset: 0x003CAC01
		[NullableContext(1)]
		public static TeleportNotify Create()
		{
			return new TeleportNotify();
		}

		// Token: 0x1700583A RID: 22586
		// (get) Token: 0x0601A2A6 RID: 107174 RVA: 0x003CCA08 File Offset: 0x003CAC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700583B RID: 22587
		// (get) Token: 0x0601A2A7 RID: 107175 RVA: 0x003CCA0B File Offset: 0x003CAC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportNotify.Descriptor;
			}
		}

		// Token: 0x0601A2A8 RID: 107176 RVA: 0x003CCA12 File Offset: 0x003CAC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportNotify()
		{
		}

		// Token: 0x0601A2A9 RID: 107177 RVA: 0x003CCA1C File Offset: 0x003CAC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportNotify(TeleportNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.mapId_ = other.mapId_;
			this.position_ = ((other.position_ != null) ? other.position_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.gravityDirection_ = ((other.gravityDirection_ != null) ? other.gravityDirection_.Clone() : null);
			this.reason_ = other.reason_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this.disableAutoFadeInScreen_ = other.disableAutoFadeInScreen_;
			this.transferEffectId_ = other.transferEffectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A2AA RID: 107178 RVA: 0x003CCB08 File Offset: 0x003CAD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportNotify Clone()
		{
			return new TeleportNotify(this);
		}

		// Token: 0x1700583C RID: 22588
		// (get) Token: 0x0601A2AB RID: 107179 RVA: 0x003CCB10 File Offset: 0x003CAD10
		// (set) Token: 0x0601A2AC RID: 107180 RVA: 0x003CCB18 File Offset: 0x003CAD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x1700583D RID: 22589
		// (get) Token: 0x0601A2AD RID: 107181 RVA: 0x003CCB21 File Offset: 0x003CAD21
		// (set) Token: 0x0601A2AE RID: 107182 RVA: 0x003CCB29 File Offset: 0x003CAD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Position
		{
			get
			{
				return this.position_;
			}
			set
			{
				this.position_ = value;
			}
		}

		// Token: 0x1700583E RID: 22590
		// (get) Token: 0x0601A2AF RID: 107183 RVA: 0x003CCB32 File Offset: 0x003CAD32
		// (set) Token: 0x0601A2B0 RID: 107184 RVA: 0x003CCB3A File Offset: 0x003CAD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x1700583F RID: 22591
		// (get) Token: 0x0601A2B1 RID: 107185 RVA: 0x003CCB43 File Offset: 0x003CAD43
		// (set) Token: 0x0601A2B2 RID: 107186 RVA: 0x003CCB4B File Offset: 0x003CAD4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector GravityDirection
		{
			get
			{
				return this.gravityDirection_;
			}
			set
			{
				this.gravityDirection_ = value;
			}
		}

		// Token: 0x17005840 RID: 22592
		// (get) Token: 0x0601A2B3 RID: 107187 RVA: 0x003CCB54 File Offset: 0x003CAD54
		// (set) Token: 0x0601A2B4 RID: 107188 RVA: 0x003CCB5C File Offset: 0x003CAD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportReason Reason
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

		// Token: 0x17005841 RID: 22593
		// (get) Token: 0x0601A2B5 RID: 107189 RVA: 0x003CCB65 File Offset: 0x003CAD65
		// (set) Token: 0x0601A2B6 RID: 107190 RVA: 0x003CCB6D File Offset: 0x003CAD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb GameCtx
		{
			get
			{
				return this.gameCtx_;
			}
			set
			{
				this.gameCtx_ = value;
			}
		}

		// Token: 0x17005842 RID: 22594
		// (get) Token: 0x0601A2B7 RID: 107191 RVA: 0x003CCB76 File Offset: 0x003CAD76
		// (set) Token: 0x0601A2B8 RID: 107192 RVA: 0x003CCB7E File Offset: 0x003CAD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb TransitionOption
		{
			get
			{
				return this.transitionOption_;
			}
			set
			{
				this.transitionOption_ = value;
			}
		}

		// Token: 0x17005843 RID: 22595
		// (get) Token: 0x0601A2B9 RID: 107193 RVA: 0x003CCB87 File Offset: 0x003CAD87
		// (set) Token: 0x0601A2BA RID: 107194 RVA: 0x003CCB8F File Offset: 0x003CAD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DisableAutoFadeInScreen
		{
			get
			{
				return this.disableAutoFadeInScreen_;
			}
			set
			{
				this.disableAutoFadeInScreen_ = value;
			}
		}

		// Token: 0x17005844 RID: 22596
		// (get) Token: 0x0601A2BB RID: 107195 RVA: 0x003CCB98 File Offset: 0x003CAD98
		// (set) Token: 0x0601A2BC RID: 107196 RVA: 0x003CCBB0 File Offset: 0x003CADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TransferEffectId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.transferEffectId_;
				}
				return TeleportNotify.TransferEffectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.transferEffectId_ = value;
			}
		}

		// Token: 0x17005845 RID: 22597
		// (get) Token: 0x0601A2BD RID: 107197 RVA: 0x003CCBC7 File Offset: 0x003CADC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTransferEffectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601A2BE RID: 107198 RVA: 0x003CCBD4 File Offset: 0x003CADD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTransferEffectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601A2BF RID: 107199 RVA: 0x003CCBE5 File Offset: 0x003CADE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportNotify);
		}

		// Token: 0x0601A2C0 RID: 107200 RVA: 0x003CCBF4 File Offset: 0x003CADF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportNotify other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this.GravityDirection, other.GravityDirection) && this.Reason == other.Reason && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this.TransitionOption, other.TransitionOption) && this.DisableAutoFadeInScreen == other.DisableAutoFadeInScreen && this.TransferEffectId == other.TransferEffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A2C1 RID: 107201 RVA: 0x003CCCC8 File Offset: 0x003CAEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.position_ != null)
			{
				num ^= this.Position.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.gravityDirection_ != null)
			{
				num ^= this.GravityDirection.GetHashCode();
			}
			if (this.Reason != TeleportReason.Transfer)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this.transitionOption_ != null)
			{
				num ^= this.TransitionOption.GetHashCode();
			}
			if (this.DisableAutoFadeInScreen)
			{
				num ^= this.DisableAutoFadeInScreen.GetHashCode();
			}
			if (this.HasTransferEffectId)
			{
				num ^= this.TransferEffectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A2C2 RID: 107202 RVA: 0x003CCDC6 File Offset: 0x003CAFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A2C3 RID: 107203 RVA: 0x003CCDD3 File Offset: 0x003CAFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2C4 RID: 107204 RVA: 0x003CCDDC File Offset: 0x003CAFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.position_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Position);
			}
			if (this.gravityDirection_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GravityDirection);
			}
			if (this.HasTransferEffectId)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TransferEffectId);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TransitionOption);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.GameCtx);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MapId);
			}
			if (this.Reason != TeleportReason.Transfer)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Reason);
			}
			if (this.DisableAutoFadeInScreen)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.DisableAutoFadeInScreen);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2C5 RID: 107205 RVA: 0x003CCEFC File Offset: 0x003CB0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this.position_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Position);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.gravityDirection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GravityDirection);
			}
			if (this.Reason != TeleportReason.Transfer)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this.transitionOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionOption);
			}
			if (this.DisableAutoFadeInScreen)
			{
				num += 2;
			}
			if (this.HasTransferEffectId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TransferEffectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A2C6 RID: 107206 RVA: 0x003CCFF0 File Offset: 0x003CB1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			if (other.position_ != null)
			{
				if (this.position_ == null)
				{
					this.Position = new Vector();
				}
				this.Position.MergeFrom(other.Position);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Vector();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.gravityDirection_ != null)
			{
				if (this.gravityDirection_ == null)
				{
					this.GravityDirection = new Vector();
				}
				this.GravityDirection.MergeFrom(other.GravityDirection);
			}
			if (other.Reason != TeleportReason.Transfer)
			{
				this.Reason = other.Reason;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			if (other.transitionOption_ != null)
			{
				if (this.transitionOption_ == null)
				{
					this.TransitionOption = new TransitionOptionPb();
				}
				this.TransitionOption.MergeFrom(other.TransitionOption);
			}
			if (other.DisableAutoFadeInScreen)
			{
				this.DisableAutoFadeInScreen = other.DisableAutoFadeInScreen;
			}
			if (other.HasTransferEffectId)
			{
				this.TransferEffectId = other.TransferEffectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A2C7 RID: 107207 RVA: 0x003CD144 File Offset: 0x003CB344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A2C8 RID: 107208 RVA: 0x003CD150 File Offset: 0x003CB350
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
				if (num <= 42U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							if (this.position_ == null)
							{
								this.Position = new Vector();
							}
							input.ReadMessage(this.Position);
							continue;
						}
						if (num == 18U)
						{
							if (this.gravityDirection_ == null)
							{
								this.GravityDirection = new Vector();
							}
							input.ReadMessage(this.GravityDirection);
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.TransferEffectId = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							if (this.transitionOption_ == null)
							{
								this.TransitionOption = new TransitionOptionPb();
							}
							input.ReadMessage(this.TransitionOption);
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 58U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
					if (num == 64U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Reason = (TeleportReason)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.DisableAutoFadeInScreen = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Vector();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400989D RID: 39069
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400989E RID: 39070
		private int _hasBits0;

		// Token: 0x0400989F RID: 39071
		public const int MapIdFieldNumber = 8;

		// Token: 0x040098A0 RID: 39072
		private int mapId_;

		// Token: 0x040098A1 RID: 39073
		public const int PositionFieldNumber = 1;

		// Token: 0x040098A2 RID: 39074
		private Vector position_;

		// Token: 0x040098A3 RID: 39075
		public const int RotationFieldNumber = 15;

		// Token: 0x040098A4 RID: 39076
		private Vector rotation_;

		// Token: 0x040098A5 RID: 39077
		public const int GravityDirectionFieldNumber = 2;

		// Token: 0x040098A6 RID: 39078
		private Vector gravityDirection_;

		// Token: 0x040098A7 RID: 39079
		public const int ReasonFieldNumber = 12;

		// Token: 0x040098A8 RID: 39080
		private TeleportReason reason_;

		// Token: 0x040098A9 RID: 39081
		public const int GameCtxFieldNumber = 7;

		// Token: 0x040098AA RID: 39082
		private GameCtxPb gameCtx_;

		// Token: 0x040098AB RID: 39083
		public const int TransitionOptionFieldNumber = 5;

		// Token: 0x040098AC RID: 39084
		private TransitionOptionPb transitionOption_;

		// Token: 0x040098AD RID: 39085
		public const int DisableAutoFadeInScreenFieldNumber = 13;

		// Token: 0x040098AE RID: 39086
		private bool disableAutoFadeInScreen_;

		// Token: 0x040098AF RID: 39087
		public const int TransferEffectIdFieldNumber = 4;

		// Token: 0x040098B0 RID: 39088
		private static readonly int TransferEffectIdDefaultValue;

		// Token: 0x040098B1 RID: 39089
		private int transferEffectId_;
	}
}
