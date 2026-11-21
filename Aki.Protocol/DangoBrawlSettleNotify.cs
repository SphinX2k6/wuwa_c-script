using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000372 RID: 882
	[NetMessage(EMessageId.DangoBrawlSettleNotify)]
	public sealed class DangoBrawlSettleNotify : IMessage<DangoBrawlSettleNotify>, IMessage, IEquatable<DangoBrawlSettleNotify>, IDeepCloneable<DangoBrawlSettleNotify>, IBufferMessage
	{
		// Token: 0x060057F9 RID: 22521 RVA: 0x000D7155 File Offset: 0x000D5355
		[NullableContext(1)]
		public static DangoBrawlSettleNotify Create()
		{
			return new DangoBrawlSettleNotify();
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x060057FA RID: 22522 RVA: 0x000D715C File Offset: 0x000D535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x060057FB RID: 22523 RVA: 0x000D715F File Offset: 0x000D535F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSettleNotify.Descriptor;
			}
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x000D7166 File Offset: 0x000D5366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleNotify()
		{
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x000D717C File Offset: 0x000D537C
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

		// Token: 0x060057FE RID: 22526 RVA: 0x000D71E1 File Offset: 0x000D53E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleNotify Clone()
		{
			return new DangoBrawlSettleNotify(this);
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x060057FF RID: 22527 RVA: 0x000D71E9 File Offset: 0x000D53E9
		// (set) Token: 0x06005800 RID: 22528 RVA: 0x000D71F1 File Offset: 0x000D53F1
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

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06005801 RID: 22529 RVA: 0x000D71FA File Offset: 0x000D53FA
		// (set) Token: 0x06005802 RID: 22530 RVA: 0x000D7202 File Offset: 0x000D5402
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

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06005803 RID: 22531 RVA: 0x000D720B File Offset: 0x000D540B
		// (set) Token: 0x06005804 RID: 22532 RVA: 0x000D7213 File Offset: 0x000D5413
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

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06005805 RID: 22533 RVA: 0x000D721C File Offset: 0x000D541C
		// (set) Token: 0x06005806 RID: 22534 RVA: 0x000D7224 File Offset: 0x000D5424
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

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06005807 RID: 22535 RVA: 0x000D722D File Offset: 0x000D542D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardedItems
		{
			get
			{
				return this.rewardedItems_;
			}
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x000D7235 File Offset: 0x000D5435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSettleNotify);
		}

		// Token: 0x06005809 RID: 22537 RVA: 0x000D7244 File Offset: 0x000D5444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSettleNotify other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && this.WinCount == other.WinCount && this.LoseCount == other.LoseCount && this.FirstPass == other.FirstPass && this.RewardedItems.Equals(other.RewardedItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600580A RID: 22538 RVA: 0x000D72C4 File Offset: 0x000D54C4
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

		// Token: 0x0600580B RID: 22539 RVA: 0x000D735C File Offset: 0x000D555C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x000D7369 File Offset: 0x000D5569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x000D7374 File Offset: 0x000D5574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardedItems_.WriteTo(ref output, DangoBrawlSettleNotify._map_rewardedItems_codec);
			if (this.IsWin)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsWin);
			}
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LoseCount);
			}
			if (this.WinCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.WinCount);
			}
			if (this.FirstPass)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.FirstPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x000D7418 File Offset: 0x000D5618
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

		// Token: 0x0600580F RID: 22543 RVA: 0x000D749C File Offset: 0x000D569C
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

		// Token: 0x06005810 RID: 22544 RVA: 0x000D7525 File Offset: 0x000D5725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x000D7530 File Offset: 0x000D5730
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
				if (num <= 40U)
				{
					if (num == 10U)
					{
						this.rewardedItems_.AddEntriesFrom(ref input, DangoBrawlSettleNotify._map_rewardedItems_codec);
						continue;
					}
					if (num == 40U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.LoseCount = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.WinCount = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.FirstPass = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400354F RID: 13647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003550 RID: 13648
		public const int IsWinFieldNumber = 5;

		// Token: 0x04003551 RID: 13649
		private bool isWin_;

		// Token: 0x04003552 RID: 13650
		public const int WinCountFieldNumber = 8;

		// Token: 0x04003553 RID: 13651
		private int winCount_;

		// Token: 0x04003554 RID: 13652
		public const int LoseCountFieldNumber = 6;

		// Token: 0x04003555 RID: 13653
		private int loseCount_;

		// Token: 0x04003556 RID: 13654
		public const int FirstPassFieldNumber = 9;

		// Token: 0x04003557 RID: 13655
		private bool firstPass_;

		// Token: 0x04003558 RID: 13656
		public const int RewardedItemsFieldNumber = 1;

		// Token: 0x04003559 RID: 13657
		private static readonly MapField<int, int>.Codec _map_rewardedItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x0400355A RID: 13658
		private readonly MapField<int, int> rewardedItems_ = new MapField<int, int>();
	}
}
