using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D88 RID: 3464
	[NetMessage(EMessageId.PlayerDeadNotify)]
	public sealed class PlayerDeadNotify : IMessage<PlayerDeadNotify>, IMessage, IEquatable<PlayerDeadNotify>, IDeepCloneable<PlayerDeadNotify>, IBufferMessage
	{
		// Token: 0x06012AAC RID: 76460 RVA: 0x002B8C9A File Offset: 0x002B6E9A
		[NullableContext(1)]
		public static PlayerDeadNotify Create()
		{
			return new PlayerDeadNotify();
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x06012AAD RID: 76461 RVA: 0x002B8CA1 File Offset: 0x002B6EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x06012AAE RID: 76462 RVA: 0x002B8CA4 File Offset: 0x002B6EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerDeadNotify.Descriptor;
			}
		}

		// Token: 0x06012AAF RID: 76463 RVA: 0x002B8CAB File Offset: 0x002B6EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDeadNotify()
		{
		}

		// Token: 0x06012AB0 RID: 76464 RVA: 0x002B8CC0 File Offset: 0x002B6EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDeadNotify(PlayerDeadNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.delaySeconds_ = other.delaySeconds_;
			this.isAutoRevive_ = other.isAutoRevive_;
			this.reviveId_ = other.reviveId_;
			this.isLogin_ = other.isLogin_;
			this.isShowRevive_ = other.isShowRevive_;
			this.extraDeadInfos_ = other.extraDeadInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012AB1 RID: 76465 RVA: 0x002B8D3D File Offset: 0x002B6F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDeadNotify Clone()
		{
			return new PlayerDeadNotify(this);
		}

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x06012AB2 RID: 76466 RVA: 0x002B8D45 File Offset: 0x002B6F45
		// (set) Token: 0x06012AB3 RID: 76467 RVA: 0x002B8D4D File Offset: 0x002B6F4D
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

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x06012AB4 RID: 76468 RVA: 0x002B8D56 File Offset: 0x002B6F56
		// (set) Token: 0x06012AB5 RID: 76469 RVA: 0x002B8D5E File Offset: 0x002B6F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DelaySeconds
		{
			get
			{
				return this.delaySeconds_;
			}
			set
			{
				this.delaySeconds_ = value;
			}
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x06012AB6 RID: 76470 RVA: 0x002B8D67 File Offset: 0x002B6F67
		// (set) Token: 0x06012AB7 RID: 76471 RVA: 0x002B8D6F File Offset: 0x002B6F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAutoRevive
		{
			get
			{
				return this.isAutoRevive_;
			}
			set
			{
				this.isAutoRevive_ = value;
			}
		}

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x06012AB8 RID: 76472 RVA: 0x002B8D78 File Offset: 0x002B6F78
		// (set) Token: 0x06012AB9 RID: 76473 RVA: 0x002B8D80 File Offset: 0x002B6F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveId
		{
			get
			{
				return this.reviveId_;
			}
			set
			{
				this.reviveId_ = value;
			}
		}

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x06012ABA RID: 76474 RVA: 0x002B8D89 File Offset: 0x002B6F89
		// (set) Token: 0x06012ABB RID: 76475 RVA: 0x002B8D91 File Offset: 0x002B6F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLogin
		{
			get
			{
				return this.isLogin_;
			}
			set
			{
				this.isLogin_ = value;
			}
		}

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x06012ABC RID: 76476 RVA: 0x002B8D9A File Offset: 0x002B6F9A
		// (set) Token: 0x06012ABD RID: 76477 RVA: 0x002B8DA2 File Offset: 0x002B6FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShowRevive
		{
			get
			{
				return this.isShowRevive_;
			}
			set
			{
				this.isShowRevive_ = value;
			}
		}

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x06012ABE RID: 76478 RVA: 0x002B8DAB File Offset: 0x002B6FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExtraDeadInfo> ExtraDeadInfos
		{
			get
			{
				return this.extraDeadInfos_;
			}
		}

		// Token: 0x06012ABF RID: 76479 RVA: 0x002B8DB3 File Offset: 0x002B6FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerDeadNotify);
		}

		// Token: 0x06012AC0 RID: 76480 RVA: 0x002B8DC4 File Offset: 0x002B6FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerDeadNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.DelaySeconds == other.DelaySeconds && this.IsAutoRevive == other.IsAutoRevive && this.ReviveId == other.ReviveId && this.IsLogin == other.IsLogin && this.IsShowRevive == other.IsShowRevive && this.extraDeadInfos_.Equals(other.extraDeadInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012AC1 RID: 76481 RVA: 0x002B8E64 File Offset: 0x002B7064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.DelaySeconds != 0)
			{
				num ^= this.DelaySeconds.GetHashCode();
			}
			if (this.IsAutoRevive)
			{
				num ^= this.IsAutoRevive.GetHashCode();
			}
			if (this.ReviveId != 0)
			{
				num ^= this.ReviveId.GetHashCode();
			}
			if (this.IsLogin)
			{
				num ^= this.IsLogin.GetHashCode();
			}
			if (this.IsShowRevive)
			{
				num ^= this.IsShowRevive.GetHashCode();
			}
			num ^= this.extraDeadInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012AC2 RID: 76482 RVA: 0x002B8F2E File Offset: 0x002B712E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012AC3 RID: 76483 RVA: 0x002B8F3B File Offset: 0x002B713B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012AC4 RID: 76484 RVA: 0x002B8F44 File Offset: 0x002B7144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsLogin)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsLogin);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IsAutoRevive)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsAutoRevive);
			}
			if (this.IsShowRevive)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsShowRevive);
			}
			if (this.DelaySeconds != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DelaySeconds);
			}
			if (this.ReviveId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ReviveId);
			}
			this.extraDeadInfos_.WriteTo(ref output, PlayerDeadNotify._repeated_extraDeadInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012AC5 RID: 76485 RVA: 0x002B9020 File Offset: 0x002B7220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.DelaySeconds != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DelaySeconds);
			}
			if (this.IsAutoRevive)
			{
				num += 2;
			}
			if (this.ReviveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveId);
			}
			if (this.IsLogin)
			{
				num += 2;
			}
			if (this.IsShowRevive)
			{
				num += 2;
			}
			num += this.extraDeadInfos_.CalculateSize(PlayerDeadNotify._repeated_extraDeadInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012AC6 RID: 76486 RVA: 0x002B90C8 File Offset: 0x002B72C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerDeadNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.DelaySeconds != 0)
			{
				this.DelaySeconds = other.DelaySeconds;
			}
			if (other.IsAutoRevive)
			{
				this.IsAutoRevive = other.IsAutoRevive;
			}
			if (other.ReviveId != 0)
			{
				this.ReviveId = other.ReviveId;
			}
			if (other.IsLogin)
			{
				this.IsLogin = other.IsLogin;
			}
			if (other.IsShowRevive)
			{
				this.IsShowRevive = other.IsShowRevive;
			}
			this.extraDeadInfos_.Add(other.extraDeadInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012AC7 RID: 76487 RVA: 0x002B9179 File Offset: 0x002B7379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012AC8 RID: 76488 RVA: 0x002B9184 File Offset: 0x002B7384
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
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.IsLogin = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.IsAutoRevive = input.ReadBool();
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 80U)
					{
						this.IsShowRevive = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.DelaySeconds = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ReviveId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.extraDeadInfos_.AddEntriesFrom(ref input, PlayerDeadNotify._repeated_extraDeadInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040073B5 RID: 29621
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073B6 RID: 29622
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x040073B7 RID: 29623
		private int playerId_;

		// Token: 0x040073B8 RID: 29624
		public const int DelaySecondsFieldNumber = 12;

		// Token: 0x040073B9 RID: 29625
		private int delaySeconds_;

		// Token: 0x040073BA RID: 29626
		public const int IsAutoReviveFieldNumber = 9;

		// Token: 0x040073BB RID: 29627
		private bool isAutoRevive_;

		// Token: 0x040073BC RID: 29628
		public const int ReviveIdFieldNumber = 13;

		// Token: 0x040073BD RID: 29629
		private int reviveId_;

		// Token: 0x040073BE RID: 29630
		public const int IsLoginFieldNumber = 1;

		// Token: 0x040073BF RID: 29631
		private bool isLogin_;

		// Token: 0x040073C0 RID: 29632
		public const int IsShowReviveFieldNumber = 10;

		// Token: 0x040073C1 RID: 29633
		private bool isShowRevive_;

		// Token: 0x040073C2 RID: 29634
		public const int ExtraDeadInfosFieldNumber = 14;

		// Token: 0x040073C3 RID: 29635
		private static readonly FieldCodec<ExtraDeadInfo> _repeated_extraDeadInfos_codec = FieldCodec.ForMessage<ExtraDeadInfo>(114U, ExtraDeadInfo.Parser);

		// Token: 0x040073C4 RID: 29636
		private readonly RepeatedField<ExtraDeadInfo> extraDeadInfos_ = new RepeatedField<ExtraDeadInfo>();
	}
}
