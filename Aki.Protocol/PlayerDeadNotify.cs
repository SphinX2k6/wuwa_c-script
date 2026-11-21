using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D78 RID: 3448
	[NetMessage(EMessageId.PlayerDeadNotify)]
	public sealed class PlayerDeadNotify : IMessage<PlayerDeadNotify>, IMessage, IEquatable<PlayerDeadNotify>, IDeepCloneable<PlayerDeadNotify>, IBufferMessage
	{
		// Token: 0x060129B0 RID: 76208 RVA: 0x002B707A File Offset: 0x002B527A
		[NullableContext(1)]
		public static PlayerDeadNotify Create()
		{
			return new PlayerDeadNotify();
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x060129B1 RID: 76209 RVA: 0x002B7081 File Offset: 0x002B5281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x060129B2 RID: 76210 RVA: 0x002B7084 File Offset: 0x002B5284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerDeadNotify.Descriptor;
			}
		}

		// Token: 0x060129B3 RID: 76211 RVA: 0x002B708B File Offset: 0x002B528B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDeadNotify()
		{
		}

		// Token: 0x060129B4 RID: 76212 RVA: 0x002B70A0 File Offset: 0x002B52A0
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

		// Token: 0x060129B5 RID: 76213 RVA: 0x002B711D File Offset: 0x002B531D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDeadNotify Clone()
		{
			return new PlayerDeadNotify(this);
		}

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x060129B6 RID: 76214 RVA: 0x002B7125 File Offset: 0x002B5325
		// (set) Token: 0x060129B7 RID: 76215 RVA: 0x002B712D File Offset: 0x002B532D
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

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x060129B8 RID: 76216 RVA: 0x002B7136 File Offset: 0x002B5336
		// (set) Token: 0x060129B9 RID: 76217 RVA: 0x002B713E File Offset: 0x002B533E
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

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x060129BA RID: 76218 RVA: 0x002B7147 File Offset: 0x002B5347
		// (set) Token: 0x060129BB RID: 76219 RVA: 0x002B714F File Offset: 0x002B534F
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

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x060129BC RID: 76220 RVA: 0x002B7158 File Offset: 0x002B5358
		// (set) Token: 0x060129BD RID: 76221 RVA: 0x002B7160 File Offset: 0x002B5360
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

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x060129BE RID: 76222 RVA: 0x002B7169 File Offset: 0x002B5369
		// (set) Token: 0x060129BF RID: 76223 RVA: 0x002B7171 File Offset: 0x002B5371
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

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x060129C0 RID: 76224 RVA: 0x002B717A File Offset: 0x002B537A
		// (set) Token: 0x060129C1 RID: 76225 RVA: 0x002B7182 File Offset: 0x002B5382
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

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x060129C2 RID: 76226 RVA: 0x002B718B File Offset: 0x002B538B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExtraDeadInfo> ExtraDeadInfos
		{
			get
			{
				return this.extraDeadInfos_;
			}
		}

		// Token: 0x060129C3 RID: 76227 RVA: 0x002B7193 File Offset: 0x002B5393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerDeadNotify);
		}

		// Token: 0x060129C4 RID: 76228 RVA: 0x002B71A4 File Offset: 0x002B53A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerDeadNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.DelaySeconds == other.DelaySeconds && this.IsAutoRevive == other.IsAutoRevive && this.ReviveId == other.ReviveId && this.IsLogin == other.IsLogin && this.IsShowRevive == other.IsShowRevive && this.extraDeadInfos_.Equals(other.extraDeadInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060129C5 RID: 76229 RVA: 0x002B7244 File Offset: 0x002B5444
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

		// Token: 0x060129C6 RID: 76230 RVA: 0x002B730E File Offset: 0x002B550E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060129C7 RID: 76231 RVA: 0x002B731B File Offset: 0x002B551B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060129C8 RID: 76232 RVA: 0x002B7324 File Offset: 0x002B5524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShowRevive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsShowRevive);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			this.extraDeadInfos_.WriteTo(ref output, PlayerDeadNotify._repeated_extraDeadInfos_codec);
			if (this.DelaySeconds != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DelaySeconds);
			}
			if (this.ReviveId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ReviveId);
			}
			if (this.IsLogin)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsLogin);
			}
			if (this.IsAutoRevive)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsAutoRevive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060129C9 RID: 76233 RVA: 0x002B7400 File Offset: 0x002B5600
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

		// Token: 0x060129CA RID: 76234 RVA: 0x002B74A8 File Offset: 0x002B56A8
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

		// Token: 0x060129CB RID: 76235 RVA: 0x002B7559 File Offset: 0x002B5759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060129CC RID: 76236 RVA: 0x002B7564 File Offset: 0x002B5764
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
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.IsShowRevive = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.extraDeadInfos_.AddEntriesFrom(ref input, PlayerDeadNotify._repeated_extraDeadInfos_codec);
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.DelaySeconds = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ReviveId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.IsLogin = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.IsAutoRevive = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040073CD RID: 29645
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073CE RID: 29646
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x040073CF RID: 29647
		private int playerId_;

		// Token: 0x040073D0 RID: 29648
		public const int DelaySecondsFieldNumber = 8;

		// Token: 0x040073D1 RID: 29649
		private int delaySeconds_;

		// Token: 0x040073D2 RID: 29650
		public const int IsAutoReviveFieldNumber = 15;

		// Token: 0x040073D3 RID: 29651
		private bool isAutoRevive_;

		// Token: 0x040073D4 RID: 29652
		public const int ReviveIdFieldNumber = 10;

		// Token: 0x040073D5 RID: 29653
		private int reviveId_;

		// Token: 0x040073D6 RID: 29654
		public const int IsLoginFieldNumber = 11;

		// Token: 0x040073D7 RID: 29655
		private bool isLogin_;

		// Token: 0x040073D8 RID: 29656
		public const int IsShowReviveFieldNumber = 2;

		// Token: 0x040073D9 RID: 29657
		private bool isShowRevive_;

		// Token: 0x040073DA RID: 29658
		public const int ExtraDeadInfosFieldNumber = 6;

		// Token: 0x040073DB RID: 29659
		private static readonly FieldCodec<ExtraDeadInfo> _repeated_extraDeadInfos_codec = FieldCodec.ForMessage<ExtraDeadInfo>(50U, ExtraDeadInfo.Parser);

		// Token: 0x040073DC RID: 29660
		private readonly RepeatedField<ExtraDeadInfo> extraDeadInfos_ = new RepeatedField<ExtraDeadInfo>();
	}
}
