using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001417 RID: 5143
	public sealed class TowerDefencePassInfo : IMessage<TowerDefencePassInfo>, IMessage, IEquatable<TowerDefencePassInfo>, IDeepCloneable<TowerDefencePassInfo>, IBufferMessage
	{
		// Token: 0x0601B563 RID: 111971 RVA: 0x003F9B38 File Offset: 0x003F7D38
		[NullableContext(1)]
		public static TowerDefencePassInfo Create()
		{
			return new TowerDefencePassInfo();
		}

		// Token: 0x17005C89 RID: 23689
		// (get) Token: 0x0601B564 RID: 111972 RVA: 0x003F9B3F File Offset: 0x003F7D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C8A RID: 23690
		// (get) Token: 0x0601B565 RID: 111973 RVA: 0x003F9B42 File Offset: 0x003F7D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePassInfo.Descriptor;
			}
		}

		// Token: 0x0601B566 RID: 111974 RVA: 0x003F9B49 File Offset: 0x003F7D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassInfo()
		{
		}

		// Token: 0x0601B567 RID: 111975 RVA: 0x003F9B5C File Offset: 0x003F7D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassInfo(TowerDefencePassInfo other) : this()
		{
			this.playerPassInfo_ = other.playerPassInfo_.Clone();
			this.passTime_ = other.passTime_;
			this.ownerId_ = other.ownerId_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B568 RID: 111976 RVA: 0x003F9BB5 File Offset: 0x003F7DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassInfo Clone()
		{
			return new TowerDefencePassInfo(this);
		}

		// Token: 0x17005C8B RID: 23691
		// (get) Token: 0x0601B569 RID: 111977 RVA: 0x003F9BBD File Offset: 0x003F7DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefencePassPlayerInfo> PlayerPassInfo
		{
			get
			{
				return this.playerPassInfo_;
			}
		}

		// Token: 0x17005C8C RID: 23692
		// (get) Token: 0x0601B56A RID: 111978 RVA: 0x003F9BC5 File Offset: 0x003F7DC5
		// (set) Token: 0x0601B56B RID: 111979 RVA: 0x003F9BCD File Offset: 0x003F7DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x17005C8D RID: 23693
		// (get) Token: 0x0601B56C RID: 111980 RVA: 0x003F9BD6 File Offset: 0x003F7DD6
		// (set) Token: 0x0601B56D RID: 111981 RVA: 0x003F9BDE File Offset: 0x003F7DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OwnerId
		{
			get
			{
				return this.ownerId_;
			}
			set
			{
				this.ownerId_ = value;
			}
		}

		// Token: 0x17005C8E RID: 23694
		// (get) Token: 0x0601B56E RID: 111982 RVA: 0x003F9BE7 File Offset: 0x003F7DE7
		// (set) Token: 0x0601B56F RID: 111983 RVA: 0x003F9BEF File Offset: 0x003F7DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0601B570 RID: 111984 RVA: 0x003F9BF8 File Offset: 0x003F7DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePassInfo);
		}

		// Token: 0x0601B571 RID: 111985 RVA: 0x003F9C08 File Offset: 0x003F7E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePassInfo other)
		{
			return other != null && (other == this || (this.playerPassInfo_.Equals(other.playerPassInfo_) && this.PassTime == other.PassTime && this.OwnerId == other.OwnerId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B572 RID: 111986 RVA: 0x003F9C78 File Offset: 0x003F7E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerPassInfo_.GetHashCode();
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this.OwnerId != 0)
			{
				num ^= this.OwnerId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B573 RID: 111987 RVA: 0x003F9CF7 File Offset: 0x003F7EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B574 RID: 111988 RVA: 0x003F9D04 File Offset: 0x003F7F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B575 RID: 111989 RVA: 0x003F9D10 File Offset: 0x003F7F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerPassInfo_.WriteTo(ref output, TowerDefencePassInfo._repeated_playerPassInfo_codec);
			if (this.PassTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PassTime);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Score);
			}
			if (this.OwnerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B576 RID: 111990 RVA: 0x003F9D98 File Offset: 0x003F7F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerPassInfo_.CalculateSize(TowerDefencePassInfo._repeated_playerPassInfo_codec);
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this.OwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OwnerId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B577 RID: 111991 RVA: 0x003F9E1C File Offset: 0x003F801C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefencePassInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.playerPassInfo_.Add(other.playerPassInfo_);
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			if (other.OwnerId != 0)
			{
				this.OwnerId = other.OwnerId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B578 RID: 111992 RVA: 0x003F9E91 File Offset: 0x003F8091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B579 RID: 111993 RVA: 0x003F9E9C File Offset: 0x003F809C
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.playerPassInfo_.AddEntriesFrom(ref input, TowerDefencePassInfo._repeated_playerPassInfo_codec);
						continue;
					}
					if (num == 16U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.OwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009F3C RID: 40764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F3D RID: 40765
		public const int PlayerPassInfoFieldNumber = 1;

		// Token: 0x04009F3E RID: 40766
		private static readonly FieldCodec<TowerDefencePassPlayerInfo> _repeated_playerPassInfo_codec = FieldCodec.ForMessage<TowerDefencePassPlayerInfo>(10U, TowerDefencePassPlayerInfo.Parser);

		// Token: 0x04009F3F RID: 40767
		private readonly RepeatedField<TowerDefencePassPlayerInfo> playerPassInfo_ = new RepeatedField<TowerDefencePassPlayerInfo>();

		// Token: 0x04009F40 RID: 40768
		public const int PassTimeFieldNumber = 2;

		// Token: 0x04009F41 RID: 40769
		private int passTime_;

		// Token: 0x04009F42 RID: 40770
		public const int OwnerIdFieldNumber = 4;

		// Token: 0x04009F43 RID: 40771
		private int ownerId_;

		// Token: 0x04009F44 RID: 40772
		public const int ScoreFieldNumber = 3;

		// Token: 0x04009F45 RID: 40773
		private int score_;
	}
}
