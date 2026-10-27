using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036A RID: 874
	[NetMessage(EMessageId.DangoBrawlSettleNotify)]
	public sealed class DangoBrawlSettleNotify : IMessage<DangoBrawlSettleNotify>, IMessage, IEquatable<DangoBrawlSettleNotify>, IDeepCloneable<DangoBrawlSettleNotify>, IBufferMessage
	{
		// Token: 0x0600570C RID: 22284 RVA: 0x000D4ACD File Offset: 0x000D2CCD
		[NullableContext(1)]
		public static DangoBrawlSettleNotify Create()
		{
			return new DangoBrawlSettleNotify();
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x0600570D RID: 22285 RVA: 0x000D4AD4 File Offset: 0x000D2CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x000D4AD7 File Offset: 0x000D2CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSettleNotify.Descriptor;
			}
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x000D4ADE File Offset: 0x000D2CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleNotify()
		{
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x000D4AF4 File Offset: 0x000D2CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleNotify(DangoBrawlSettleNotify other) : this()
		{
			this.isWin_ = other.isWin_;
			this.winCount_ = other.winCount_;
			this.loseCount_ = other.loseCount_;
			this.firstPass_ = other.firstPass_;
			this.rewardedItems_ = other.rewardedItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x000D4B59 File Offset: 0x000D2D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleNotify Clone()
		{
			return new DangoBrawlSettleNotify(this);
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x000D4B61 File Offset: 0x000D2D61
		// (set) Token: 0x06005713 RID: 22291 RVA: 0x000D4B69 File Offset: 0x000D2D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06005714 RID: 22292 RVA: 0x000D4B72 File Offset: 0x000D2D72
		// (set) Token: 0x06005715 RID: 22293 RVA: 0x000D4B7A File Offset: 0x000D2D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WinCount
		{
			get
			{
				return this.winCount_;
			}
			set
			{
				this.winCount_ = value;
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x000D4B83 File Offset: 0x000D2D83
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x000D4B8B File Offset: 0x000D2D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoseCount
		{
			get
			{
				return this.loseCount_;
			}
			set
			{
				this.loseCount_ = value;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06005718 RID: 22296 RVA: 0x000D4B94 File Offset: 0x000D2D94
		// (set) Token: 0x06005719 RID: 22297 RVA: 0x000D4B9C File Offset: 0x000D2D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FirstPass
		{
			get
			{
				return this.firstPass_;
			}
			set
			{
				this.firstPass_ = value;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x0600571A RID: 22298 RVA: 0x000D4BA5 File Offset: 0x000D2DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardedItems
		{
			get
			{
				return this.rewardedItems_;
			}
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x000D4BAD File Offset: 0x000D2DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSettleNotify);
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x000D4BBC File Offset: 0x000D2DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSettleNotify other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && this.WinCount == other.WinCount && this.LoseCount == other.LoseCount && this.FirstPass == other.FirstPass && this.RewardedItems.Equals(other.RewardedItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x000D4C3C File Offset: 0x000D2E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.WinCount != 0)
			{
				num ^= this.WinCount.GetHashCode();
			}
			if (this.LoseCount != 0)
			{
				num ^= this.LoseCount.GetHashCode();
			}
			if (this.FirstPass)
			{
				num ^= this.FirstPass.GetHashCode();
			}
			num ^= this.RewardedItems.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x000D4CD4 File Offset: 0x000D2ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x000D4CE1 File Offset: 0x000D2EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x000D4CEC File Offset: 0x000D2EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsWin)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsWin);
			}
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LoseCount);
			}
			if (this.WinCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WinCount);
			}
			if (this.FirstPass)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.FirstPass);
			}
			this.rewardedItems_.WriteTo(ref output, DangoBrawlSettleNotify._map_rewardedItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x000D4D90 File Offset: 0x000D2F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.WinCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WinCount);
			}
			if (this.LoseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoseCount);
			}
			if (this.FirstPass)
			{
				num += 2;
			}
			num += this.rewardedItems_.CalculateSize(DangoBrawlSettleNotify._map_rewardedItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x000D4E14 File Offset: 0x000D3014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.WinCount != 0)
			{
				this.WinCount = other.WinCount;
			}
			if (other.LoseCount != 0)
			{
				this.LoseCount = other.LoseCount;
			}
			if (other.FirstPass)
			{
				this.FirstPass = other.FirstPass;
			}
			this.rewardedItems_.MergeFrom(other.rewardedItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x000D4E9D File Offset: 0x000D309D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x000D4EA8 File Offset: 0x000D30A8
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.LoseCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.WinCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.FirstPass = input.ReadBool();
						continue;
					}
					if (num == 66U)
					{
						this.rewardedItems_.AddEntriesFrom(ref input, DangoBrawlSettleNotify._map_rewardedItems_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034B3 RID: 13491
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034B4 RID: 13492
		public const int IsWinFieldNumber = 1;

		// Token: 0x040034B5 RID: 13493
		private bool isWin_;

		// Token: 0x040034B6 RID: 13494
		public const int WinCountFieldNumber = 4;

		// Token: 0x040034B7 RID: 13495
		private int winCount_;

		// Token: 0x040034B8 RID: 13496
		public const int LoseCountFieldNumber = 3;

		// Token: 0x040034B9 RID: 13497
		private int loseCount_;

		// Token: 0x040034BA RID: 13498
		public const int FirstPassFieldNumber = 5;

		// Token: 0x040034BB RID: 13499
		private bool firstPass_;

		// Token: 0x040034BC RID: 13500
		public const int RewardedItemsFieldNumber = 8;

		// Token: 0x040034BD RID: 13501
		private static readonly MapField<int, int>.Codec _map_rewardedItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x040034BE RID: 13502
		private readonly MapField<int, int> rewardedItems_ = new MapField<int, int>();
	}
}
