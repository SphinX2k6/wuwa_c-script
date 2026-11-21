using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B1 RID: 5041
	[NetMessage(EMessageId.TeleportNotify)]
	public sealed class TeleportNotify : IMessage<TeleportNotify>, IMessage, IEquatable<TeleportNotify>, IDeepCloneable<TeleportNotify>, IBufferMessage
	{
		// Token: 0x0601AD2C RID: 109868 RVA: 0x003E7B35 File Offset: 0x003E5D35
		[NullableContext(1)]
		public static TeleportNotify Create()
		{
			return new TeleportNotify();
		}

		// Token: 0x17005ACD RID: 23245
		// (get) Token: 0x0601AD2D RID: 109869 RVA: 0x003E7B3C File Offset: 0x003E5D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ACE RID: 23246
		// (get) Token: 0x0601AD2E RID: 109870 RVA: 0x003E7B3F File Offset: 0x003E5D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportNotify.Descriptor;
			}
		}

		// Token: 0x0601AD2F RID: 109871 RVA: 0x003E7B46 File Offset: 0x003E5D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportNotify()
		{
		}

		// Token: 0x0601AD30 RID: 109872 RVA: 0x003E7B50 File Offset: 0x003E5D50
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

		// Token: 0x0601AD31 RID: 109873 RVA: 0x003E7C3C File Offset: 0x003E5E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportNotify Clone()
		{
			return new TeleportNotify(this);
		}

		// Token: 0x17005ACF RID: 23247
		// (get) Token: 0x0601AD32 RID: 109874 RVA: 0x003E7C44 File Offset: 0x003E5E44
		// (set) Token: 0x0601AD33 RID: 109875 RVA: 0x003E7C4C File Offset: 0x003E5E4C
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

		// Token: 0x17005AD0 RID: 23248
		// (get) Token: 0x0601AD34 RID: 109876 RVA: 0x003E7C55 File Offset: 0x003E5E55
		// (set) Token: 0x0601AD35 RID: 109877 RVA: 0x003E7C5D File Offset: 0x003E5E5D
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

		// Token: 0x17005AD1 RID: 23249
		// (get) Token: 0x0601AD36 RID: 109878 RVA: 0x003E7C66 File Offset: 0x003E5E66
		// (set) Token: 0x0601AD37 RID: 109879 RVA: 0x003E7C6E File Offset: 0x003E5E6E
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

		// Token: 0x17005AD2 RID: 23250
		// (get) Token: 0x0601AD38 RID: 109880 RVA: 0x003E7C77 File Offset: 0x003E5E77
		// (set) Token: 0x0601AD39 RID: 109881 RVA: 0x003E7C7F File Offset: 0x003E5E7F
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

		// Token: 0x17005AD3 RID: 23251
		// (get) Token: 0x0601AD3A RID: 109882 RVA: 0x003E7C88 File Offset: 0x003E5E88
		// (set) Token: 0x0601AD3B RID: 109883 RVA: 0x003E7C90 File Offset: 0x003E5E90
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

		// Token: 0x17005AD4 RID: 23252
		// (get) Token: 0x0601AD3C RID: 109884 RVA: 0x003E7C99 File Offset: 0x003E5E99
		// (set) Token: 0x0601AD3D RID: 109885 RVA: 0x003E7CA1 File Offset: 0x003E5EA1
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

		// Token: 0x17005AD5 RID: 23253
		// (get) Token: 0x0601AD3E RID: 109886 RVA: 0x003E7CAA File Offset: 0x003E5EAA
		// (set) Token: 0x0601AD3F RID: 109887 RVA: 0x003E7CB2 File Offset: 0x003E5EB2
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

		// Token: 0x17005AD6 RID: 23254
		// (get) Token: 0x0601AD40 RID: 109888 RVA: 0x003E7CBB File Offset: 0x003E5EBB
		// (set) Token: 0x0601AD41 RID: 109889 RVA: 0x003E7CC3 File Offset: 0x003E5EC3
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

		// Token: 0x17005AD7 RID: 23255
		// (get) Token: 0x0601AD42 RID: 109890 RVA: 0x003E7CCC File Offset: 0x003E5ECC
		// (set) Token: 0x0601AD43 RID: 109891 RVA: 0x003E7CE4 File Offset: 0x003E5EE4
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

		// Token: 0x17005AD8 RID: 23256
		// (get) Token: 0x0601AD44 RID: 109892 RVA: 0x003E7CFB File Offset: 0x003E5EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTransferEffectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601AD45 RID: 109893 RVA: 0x003E7D08 File Offset: 0x003E5F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTransferEffectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601AD46 RID: 109894 RVA: 0x003E7D19 File Offset: 0x003E5F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportNotify);
		}

		// Token: 0x0601AD47 RID: 109895 RVA: 0x003E7D28 File Offset: 0x003E5F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportNotify other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this.GravityDirection, other.GravityDirection) && this.Reason == other.Reason && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this.TransitionOption, other.TransitionOption) && this.DisableAutoFadeInScreen == other.DisableAutoFadeInScreen && this.TransferEffectId == other.TransferEffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD48 RID: 109896 RVA: 0x003E7DFC File Offset: 0x003E5FFC
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

		// Token: 0x0601AD49 RID: 109897 RVA: 0x003E7EFA File Offset: 0x003E60FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD4A RID: 109898 RVA: 0x003E7F07 File Offset: 0x003E6107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD4B RID: 109899 RVA: 0x003E7F10 File Offset: 0x003E6110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasTransferEffectId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TransferEffectId);
			}
			if (this.position_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Position);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TransitionOption);
			}
			if (this.Reason != TeleportReason.Transfer)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Reason);
			}
			if (this.gravityDirection_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.GravityDirection);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GameCtx);
			}
			if (this.DisableAutoFadeInScreen)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.DisableAutoFadeInScreen);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Rotation);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD4C RID: 109900 RVA: 0x003E802C File Offset: 0x003E622C
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

		// Token: 0x0601AD4D RID: 109901 RVA: 0x003E8120 File Offset: 0x003E6320
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

		// Token: 0x0601AD4E RID: 109902 RVA: 0x003E8274 File Offset: 0x003E6474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD4F RID: 109903 RVA: 0x003E8280 File Offset: 0x003E6480
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
				if (num <= 56U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.TransferEffectId = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							if (this.position_ == null)
							{
								this.Position = new Vector();
							}
							input.ReadMessage(this.Position);
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							if (this.transitionOption_ == null)
							{
								this.TransitionOption = new TransitionOptionPb();
							}
							input.ReadMessage(this.TransitionOption);
							continue;
						}
						if (num == 56U)
						{
							this.Reason = (TeleportReason)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 66U)
					{
						if (this.gravityDirection_ == null)
						{
							this.GravityDirection = new Vector();
						}
						input.ReadMessage(this.GravityDirection);
						continue;
					}
					if (num == 74U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.DisableAutoFadeInScreen = input.ReadBool();
						continue;
					}
					if (num == 106U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Vector();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 120U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009CDF RID: 40159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CE0 RID: 40160
		private int _hasBits0;

		// Token: 0x04009CE1 RID: 40161
		public const int MapIdFieldNumber = 15;

		// Token: 0x04009CE2 RID: 40162
		private int mapId_;

		// Token: 0x04009CE3 RID: 40163
		public const int PositionFieldNumber = 2;

		// Token: 0x04009CE4 RID: 40164
		private Vector position_;

		// Token: 0x04009CE5 RID: 40165
		public const int RotationFieldNumber = 13;

		// Token: 0x04009CE6 RID: 40166
		private Vector rotation_;

		// Token: 0x04009CE7 RID: 40167
		public const int GravityDirectionFieldNumber = 8;

		// Token: 0x04009CE8 RID: 40168
		private Vector gravityDirection_;

		// Token: 0x04009CE9 RID: 40169
		public const int ReasonFieldNumber = 7;

		// Token: 0x04009CEA RID: 40170
		private TeleportReason reason_;

		// Token: 0x04009CEB RID: 40171
		public const int GameCtxFieldNumber = 9;

		// Token: 0x04009CEC RID: 40172
		private GameCtxPb gameCtx_;

		// Token: 0x04009CED RID: 40173
		public const int TransitionOptionFieldNumber = 5;

		// Token: 0x04009CEE RID: 40174
		private TransitionOptionPb transitionOption_;

		// Token: 0x04009CEF RID: 40175
		public const int DisableAutoFadeInScreenFieldNumber = 12;

		// Token: 0x04009CF0 RID: 40176
		private bool disableAutoFadeInScreen_;

		// Token: 0x04009CF1 RID: 40177
		public const int TransferEffectIdFieldNumber = 1;

		// Token: 0x04009CF2 RID: 40178
		private static readonly int TransferEffectIdDefaultValue;

		// Token: 0x04009CF3 RID: 40179
		private int transferEffectId_;
	}
}
