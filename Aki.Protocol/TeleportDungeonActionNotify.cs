using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001335 RID: 4917
	[NetMessage(EMessageId.TeleportDungeonActionNotify)]
	public sealed class TeleportDungeonActionNotify : IMessage<TeleportDungeonActionNotify>, IMessage, IEquatable<TeleportDungeonActionNotify>, IDeepCloneable<TeleportDungeonActionNotify>, IBufferMessage
	{
		// Token: 0x0601A1F1 RID: 106993 RVA: 0x003CB2A8 File Offset: 0x003C94A8
		[NullableContext(1)]
		public static TeleportDungeonActionNotify Create()
		{
			return new TeleportDungeonActionNotify();
		}

		// Token: 0x17005816 RID: 22550
		// (get) Token: 0x0601A1F2 RID: 106994 RVA: 0x003CB2AF File Offset: 0x003C94AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005817 RID: 22551
		// (get) Token: 0x0601A1F3 RID: 106995 RVA: 0x003CB2B2 File Offset: 0x003C94B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDungeonActionNotify.Descriptor;
			}
		}

		// Token: 0x0601A1F4 RID: 106996 RVA: 0x003CB2B9 File Offset: 0x003C94B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionNotify()
		{
		}

		// Token: 0x0601A1F5 RID: 106997 RVA: 0x003CB2C4 File Offset: 0x003C94C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionNotify(TeleportDungeonActionNotify other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.incId_ = other.incId_;
			this.dungeonId_ = other.dungeonId_;
			this.isRegroup_ = other.isRegroup_;
			this.isNeedSecondaryConfirmation_ = other.isNeedSecondaryConfirmation_;
			this.continueLastInst_ = other.continueLastInst_;
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1F6 RID: 106998 RVA: 0x003CB34C File Offset: 0x003C954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionNotify Clone()
		{
			return new TeleportDungeonActionNotify(this);
		}

		// Token: 0x17005818 RID: 22552
		// (get) Token: 0x0601A1F7 RID: 106999 RVA: 0x003CB354 File Offset: 0x003C9554
		// (set) Token: 0x0601A1F8 RID: 107000 RVA: 0x003CB35C File Offset: 0x003C955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x17005819 RID: 22553
		// (get) Token: 0x0601A1F9 RID: 107001 RVA: 0x003CB365 File Offset: 0x003C9565
		// (set) Token: 0x0601A1FA RID: 107002 RVA: 0x003CB36D File Offset: 0x003C956D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700581A RID: 22554
		// (get) Token: 0x0601A1FB RID: 107003 RVA: 0x003CB376 File Offset: 0x003C9576
		// (set) Token: 0x0601A1FC RID: 107004 RVA: 0x003CB37E File Offset: 0x003C957E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DungeonId
		{
			get
			{
				return this.dungeonId_;
			}
			set
			{
				this.dungeonId_ = value;
			}
		}

		// Token: 0x1700581B RID: 22555
		// (get) Token: 0x0601A1FD RID: 107005 RVA: 0x003CB387 File Offset: 0x003C9587
		// (set) Token: 0x0601A1FE RID: 107006 RVA: 0x003CB38F File Offset: 0x003C958F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRegroup
		{
			get
			{
				return this.isRegroup_;
			}
			set
			{
				this.isRegroup_ = value;
			}
		}

		// Token: 0x1700581C RID: 22556
		// (get) Token: 0x0601A1FF RID: 107007 RVA: 0x003CB398 File Offset: 0x003C9598
		// (set) Token: 0x0601A200 RID: 107008 RVA: 0x003CB3A0 File Offset: 0x003C95A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNeedSecondaryConfirmation
		{
			get
			{
				return this.isNeedSecondaryConfirmation_;
			}
			set
			{
				this.isNeedSecondaryConfirmation_ = value;
			}
		}

		// Token: 0x1700581D RID: 22557
		// (get) Token: 0x0601A201 RID: 107009 RVA: 0x003CB3A9 File Offset: 0x003C95A9
		// (set) Token: 0x0601A202 RID: 107010 RVA: 0x003CB3B1 File Offset: 0x003C95B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueLastInst
		{
			get
			{
				return this.continueLastInst_;
			}
			set
			{
				this.continueLastInst_ = value;
			}
		}

		// Token: 0x1700581E RID: 22558
		// (get) Token: 0x0601A203 RID: 107011 RVA: 0x003CB3BA File Offset: 0x003C95BA
		// (set) Token: 0x0601A204 RID: 107012 RVA: 0x003CB3C2 File Offset: 0x003C95C2
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

		// Token: 0x0601A205 RID: 107013 RVA: 0x003CB3CB File Offset: 0x003C95CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDungeonActionNotify);
		}

		// Token: 0x0601A206 RID: 107014 RVA: 0x003CB3DC File Offset: 0x003C95DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDungeonActionNotify other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.IncId == other.IncId && this.DungeonId == other.DungeonId && this.IsRegroup == other.IsRegroup && this.IsNeedSecondaryConfirmation == other.IsNeedSecondaryConfirmation && this.ContinueLastInst == other.ContinueLastInst && object.Equals(this.TransitionOption, other.TransitionOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A207 RID: 107015 RVA: 0x003CB47C File Offset: 0x003C967C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.DungeonId != 0)
			{
				num ^= this.DungeonId.GetHashCode();
			}
			if (this.IsRegroup)
			{
				num ^= this.IsRegroup.GetHashCode();
			}
			if (this.IsNeedSecondaryConfirmation)
			{
				num ^= this.IsNeedSecondaryConfirmation.GetHashCode();
			}
			if (this.ContinueLastInst)
			{
				num ^= this.ContinueLastInst.GetHashCode();
			}
			if (this.transitionOption_ != null)
			{
				num ^= this.TransitionOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A208 RID: 107016 RVA: 0x003CB54E File Offset: 0x003C974E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A209 RID: 107017 RVA: 0x003CB55B File Offset: 0x003C975B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A20A RID: 107018 RVA: 0x003CB564 File Offset: 0x003C9764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsRegroup)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsRegroup);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncId);
			}
			if (this.ContinueLastInst)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ContinueLastInst);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.DungeonId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.DungeonId);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.TransitionOption);
			}
			if (this.IsNeedSecondaryConfirmation)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsNeedSecondaryConfirmation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A20B RID: 107019 RVA: 0x003CB648 File Offset: 0x003C9848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.DungeonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DungeonId);
			}
			if (this.IsRegroup)
			{
				num += 2;
			}
			if (this.IsNeedSecondaryConfirmation)
			{
				num += 2;
			}
			if (this.ContinueLastInst)
			{
				num += 2;
			}
			if (this.transitionOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A20C RID: 107020 RVA: 0x003CB6F4 File Offset: 0x003C98F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDungeonActionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.DungeonId != 0)
			{
				this.DungeonId = other.DungeonId;
			}
			if (other.IsRegroup)
			{
				this.IsRegroup = other.IsRegroup;
			}
			if (other.IsNeedSecondaryConfirmation)
			{
				this.IsNeedSecondaryConfirmation = other.IsNeedSecondaryConfirmation;
			}
			if (other.ContinueLastInst)
			{
				this.ContinueLastInst = other.ContinueLastInst;
			}
			if (other.transitionOption_ != null)
			{
				if (this.transitionOption_ == null)
				{
					this.TransitionOption = new TransitionOptionPb();
				}
				this.TransitionOption.MergeFrom(other.TransitionOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A20D RID: 107021 RVA: 0x003CB7C0 File Offset: 0x003C99C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A20E RID: 107022 RVA: 0x003CB7CC File Offset: 0x003C99CC
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.IsRegroup = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ContinueLastInst = input.ReadBool();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 56U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.DungeonId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.transitionOption_ == null)
						{
							this.TransitionOption = new TransitionOptionPb();
						}
						input.ReadMessage(this.TransitionOption);
						continue;
					}
					if (num == 104U)
					{
						this.IsNeedSecondaryConfirmation = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400986F RID: 39023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009870 RID: 39024
		public const int HostPlayerIdFieldNumber = 7;

		// Token: 0x04009871 RID: 39025
		private int hostPlayerId_;

		// Token: 0x04009872 RID: 39026
		public const int IncIdFieldNumber = 3;

		// Token: 0x04009873 RID: 39027
		private int incId_;

		// Token: 0x04009874 RID: 39028
		public const int DungeonIdFieldNumber = 11;

		// Token: 0x04009875 RID: 39029
		private int dungeonId_;

		// Token: 0x04009876 RID: 39030
		public const int IsRegroupFieldNumber = 1;

		// Token: 0x04009877 RID: 39031
		private bool isRegroup_;

		// Token: 0x04009878 RID: 39032
		public const int IsNeedSecondaryConfirmationFieldNumber = 13;

		// Token: 0x04009879 RID: 39033
		private bool isNeedSecondaryConfirmation_;

		// Token: 0x0400987A RID: 39034
		public const int ContinueLastInstFieldNumber = 6;

		// Token: 0x0400987B RID: 39035
		private bool continueLastInst_;

		// Token: 0x0400987C RID: 39036
		public const int TransitionOptionFieldNumber = 12;

		// Token: 0x0400987D RID: 39037
		private TransitionOptionPb transitionOption_;
	}
}
