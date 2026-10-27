using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A4 RID: 5028
	public sealed class TowerDefencePassInfo : IMessage<TowerDefencePassInfo>, IMessage, IEquatable<TowerDefencePassInfo>, IDeepCloneable<TowerDefencePassInfo>, IBufferMessage
	{
		// Token: 0x0601AAD8 RID: 109272 RVA: 0x003DE875 File Offset: 0x003DCA75
		[NullableContext(1)]
		public static TowerDefencePassInfo Create()
		{
			return new TowerDefencePassInfo();
		}

		// Token: 0x170059F4 RID: 23028
		// (get) Token: 0x0601AAD9 RID: 109273 RVA: 0x003DE87C File Offset: 0x003DCA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059F5 RID: 23029
		// (get) Token: 0x0601AADA RID: 109274 RVA: 0x003DE87F File Offset: 0x003DCA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePassInfo.Descriptor;
			}
		}

		// Token: 0x0601AADB RID: 109275 RVA: 0x003DE886 File Offset: 0x003DCA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassInfo()
		{
		}

		// Token: 0x0601AADC RID: 109276 RVA: 0x003DE89C File Offset: 0x003DCA9C
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

		// Token: 0x0601AADD RID: 109277 RVA: 0x003DE8F5 File Offset: 0x003DCAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassInfo Clone()
		{
			return new TowerDefencePassInfo(this);
		}

		// Token: 0x170059F6 RID: 23030
		// (get) Token: 0x0601AADE RID: 109278 RVA: 0x003DE8FD File Offset: 0x003DCAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefencePassPlayerInfo> PlayerPassInfo
		{
			get
			{
				return this.playerPassInfo_;
			}
		}

		// Token: 0x170059F7 RID: 23031
		// (get) Token: 0x0601AADF RID: 109279 RVA: 0x003DE905 File Offset: 0x003DCB05
		// (set) Token: 0x0601AAE0 RID: 109280 RVA: 0x003DE90D File Offset: 0x003DCB0D
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

		// Token: 0x170059F8 RID: 23032
		// (get) Token: 0x0601AAE1 RID: 109281 RVA: 0x003DE916 File Offset: 0x003DCB16
		// (set) Token: 0x0601AAE2 RID: 109282 RVA: 0x003DE91E File Offset: 0x003DCB1E
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

		// Token: 0x170059F9 RID: 23033
		// (get) Token: 0x0601AAE3 RID: 109283 RVA: 0x003DE927 File Offset: 0x003DCB27
		// (set) Token: 0x0601AAE4 RID: 109284 RVA: 0x003DE92F File Offset: 0x003DCB2F
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

		// Token: 0x0601AAE5 RID: 109285 RVA: 0x003DE938 File Offset: 0x003DCB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePassInfo);
		}

		// Token: 0x0601AAE6 RID: 109286 RVA: 0x003DE948 File Offset: 0x003DCB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePassInfo other)
		{
			return other != null && (other == this || (this.playerPassInfo_.Equals(other.playerPassInfo_) && this.PassTime == other.PassTime && this.OwnerId == other.OwnerId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AAE7 RID: 109287 RVA: 0x003DE9B8 File Offset: 0x003DCBB8
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

		// Token: 0x0601AAE8 RID: 109288 RVA: 0x003DEA37 File Offset: 0x003DCC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AAE9 RID: 109289 RVA: 0x003DEA44 File Offset: 0x003DCC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAEA RID: 109290 RVA: 0x003DEA50 File Offset: 0x003DCC50
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

		// Token: 0x0601AAEB RID: 109291 RVA: 0x003DEAD8 File Offset: 0x003DCCD8
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

		// Token: 0x0601AAEC RID: 109292 RVA: 0x003DEB5C File Offset: 0x003DCD5C
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

		// Token: 0x0601AAED RID: 109293 RVA: 0x003DEBD1 File Offset: 0x003DCDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AAEE RID: 109294 RVA: 0x003DEBDC File Offset: 0x003DCDDC
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

		// Token: 0x04009AF5 RID: 39669
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AF6 RID: 39670
		public const int PlayerPassInfoFieldNumber = 1;

		// Token: 0x04009AF7 RID: 39671
		private static readonly FieldCodec<TowerDefencePassPlayerInfo> _repeated_playerPassInfo_codec = FieldCodec.ForMessage<TowerDefencePassPlayerInfo>(10U, TowerDefencePassPlayerInfo.Parser);

		// Token: 0x04009AF8 RID: 39672
		private readonly RepeatedField<TowerDefencePassPlayerInfo> playerPassInfo_ = new RepeatedField<TowerDefencePassPlayerInfo>();

		// Token: 0x04009AF9 RID: 39673
		public const int PassTimeFieldNumber = 2;

		// Token: 0x04009AFA RID: 39674
		private int passTime_;

		// Token: 0x04009AFB RID: 39675
		public const int OwnerIdFieldNumber = 4;

		// Token: 0x04009AFC RID: 39676
		private int ownerId_;

		// Token: 0x04009AFD RID: 39677
		public const int ScoreFieldNumber = 3;

		// Token: 0x04009AFE RID: 39678
		private int score_;
	}
}
