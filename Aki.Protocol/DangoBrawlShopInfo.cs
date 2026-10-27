using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000371 RID: 881
	public sealed class DangoBrawlShopInfo : IMessage<DangoBrawlShopInfo>, IMessage, IEquatable<DangoBrawlShopInfo>, IDeepCloneable<DangoBrawlShopInfo>, IBufferMessage
	{
		// Token: 0x060057A0 RID: 22432 RVA: 0x000D601F File Offset: 0x000D421F
		[NullableContext(1)]
		public static DangoBrawlShopInfo Create()
		{
			return new DangoBrawlShopInfo();
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x000D6026 File Offset: 0x000D4226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x000D6029 File Offset: 0x000D4229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopInfo.Descriptor;
			}
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x000D6030 File Offset: 0x000D4230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo()
		{
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x000D6044 File Offset: 0x000D4244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo(DangoBrawlShopInfo other) : this()
		{
			this.slots_ = other.slots_.Clone();
			this.nextRefreshCost_ = other.nextRefreshCost_;
			this.manualRefreshCount_ = other.manualRefreshCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x000D6091 File Offset: 0x000D4291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo Clone()
		{
			return new DangoBrawlShopInfo(this);
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x000D6099 File Offset: 0x000D4299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlShopSlotInfo> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x060057A7 RID: 22439 RVA: 0x000D60A1 File Offset: 0x000D42A1
		// (set) Token: 0x060057A8 RID: 22440 RVA: 0x000D60A9 File Offset: 0x000D42A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextRefreshCost
		{
			get
			{
				return this.nextRefreshCost_;
			}
			set
			{
				this.nextRefreshCost_ = value;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x060057A9 RID: 22441 RVA: 0x000D60B2 File Offset: 0x000D42B2
		// (set) Token: 0x060057AA RID: 22442 RVA: 0x000D60BA File Offset: 0x000D42BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ManualRefreshCount
		{
			get
			{
				return this.manualRefreshCount_;
			}
			set
			{
				this.manualRefreshCount_ = value;
			}
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x000D60C3 File Offset: 0x000D42C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopInfo);
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x000D60D4 File Offset: 0x000D42D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopInfo other)
		{
			return other != null && (other == this || (this.slots_.Equals(other.slots_) && this.NextRefreshCost == other.NextRefreshCost && this.ManualRefreshCount == other.ManualRefreshCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x000D6134 File Offset: 0x000D4334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slots_.GetHashCode();
			if (this.NextRefreshCost != 0)
			{
				num ^= this.NextRefreshCost.GetHashCode();
			}
			if (this.ManualRefreshCount != 0)
			{
				num ^= this.ManualRefreshCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x000D619A File Offset: 0x000D439A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x000D61A7 File Offset: 0x000D43A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x000D61B0 File Offset: 0x000D43B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slots_.WriteTo(ref output, DangoBrawlShopInfo._repeated_slots_codec);
			if (this.NextRefreshCost != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NextRefreshCost);
			}
			if (this.ManualRefreshCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ManualRefreshCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x000D621C File Offset: 0x000D441C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slots_.CalculateSize(DangoBrawlShopInfo._repeated_slots_codec);
			if (this.NextRefreshCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextRefreshCost);
			}
			if (this.ManualRefreshCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ManualRefreshCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x000D6288 File Offset: 0x000D4488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.slots_.Add(other.slots_);
			if (other.NextRefreshCost != 0)
			{
				this.NextRefreshCost = other.NextRefreshCost;
			}
			if (other.ManualRefreshCount != 0)
			{
				this.ManualRefreshCount = other.ManualRefreshCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x000D62E9 File Offset: 0x000D44E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x000D62F4 File Offset: 0x000D44F4
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ManualRefreshCount = input.ReadInt32();
						}
					}
					else
					{
						this.NextRefreshCost = input.ReadInt32();
					}
				}
				else
				{
					this.slots_.AddEntriesFrom(ref input, DangoBrawlShopInfo._repeated_slots_codec);
				}
			}
		}

		// Token: 0x040034E1 RID: 13537
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034E2 RID: 13538
		public const int SlotsFieldNumber = 1;

		// Token: 0x040034E3 RID: 13539
		private static readonly FieldCodec<DangoBrawlShopSlotInfo> _repeated_slots_codec = FieldCodec.ForMessage<DangoBrawlShopSlotInfo>(10U, DangoBrawlShopSlotInfo.Parser);

		// Token: 0x040034E4 RID: 13540
		private readonly RepeatedField<DangoBrawlShopSlotInfo> slots_ = new RepeatedField<DangoBrawlShopSlotInfo>();

		// Token: 0x040034E5 RID: 13541
		public const int NextRefreshCostFieldNumber = 2;

		// Token: 0x040034E6 RID: 13542
		private int nextRefreshCost_;

		// Token: 0x040034E7 RID: 13543
		public const int ManualRefreshCountFieldNumber = 3;

		// Token: 0x040034E8 RID: 13544
		private int manualRefreshCount_;
	}
}
