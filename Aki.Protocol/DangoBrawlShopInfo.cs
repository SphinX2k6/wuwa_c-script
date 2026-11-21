using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000379 RID: 889
	public sealed class DangoBrawlShopInfo : IMessage<DangoBrawlShopInfo>, IMessage, IEquatable<DangoBrawlShopInfo>, IDeepCloneable<DangoBrawlShopInfo>, IBufferMessage
	{
		// Token: 0x0600588D RID: 22669 RVA: 0x000D86A7 File Offset: 0x000D68A7
		[NullableContext(1)]
		public static DangoBrawlShopInfo Create()
		{
			return new DangoBrawlShopInfo();
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600588E RID: 22670 RVA: 0x000D86AE File Offset: 0x000D68AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x0600588F RID: 22671 RVA: 0x000D86B1 File Offset: 0x000D68B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopInfo.Descriptor;
			}
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x000D86B8 File Offset: 0x000D68B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo()
		{
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x000D86CC File Offset: 0x000D68CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo(DangoBrawlShopInfo other) : this()
		{
			this.slots_ = other.slots_.Clone();
			this.nextRefreshCost_ = other.nextRefreshCost_;
			this.manualRefreshCount_ = other.manualRefreshCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x000D8719 File Offset: 0x000D6919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo Clone()
		{
			return new DangoBrawlShopInfo(this);
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06005893 RID: 22675 RVA: 0x000D8721 File Offset: 0x000D6921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlShopSlotInfo> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06005894 RID: 22676 RVA: 0x000D8729 File Offset: 0x000D6929
		// (set) Token: 0x06005895 RID: 22677 RVA: 0x000D8731 File Offset: 0x000D6931
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

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06005896 RID: 22678 RVA: 0x000D873A File Offset: 0x000D693A
		// (set) Token: 0x06005897 RID: 22679 RVA: 0x000D8742 File Offset: 0x000D6942
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

		// Token: 0x06005898 RID: 22680 RVA: 0x000D874B File Offset: 0x000D694B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopInfo);
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x000D875C File Offset: 0x000D695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopInfo other)
		{
			return other != null && (other == this || (this.slots_.Equals(other.slots_) && this.NextRefreshCost == other.NextRefreshCost && this.ManualRefreshCount == other.ManualRefreshCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x000D87BC File Offset: 0x000D69BC
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

		// Token: 0x0600589B RID: 22683 RVA: 0x000D8822 File Offset: 0x000D6A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x000D882F File Offset: 0x000D6A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x000D8838 File Offset: 0x000D6A38
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

		// Token: 0x0600589E RID: 22686 RVA: 0x000D88A4 File Offset: 0x000D6AA4
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

		// Token: 0x0600589F RID: 22687 RVA: 0x000D8910 File Offset: 0x000D6B10
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

		// Token: 0x060058A0 RID: 22688 RVA: 0x000D8971 File Offset: 0x000D6B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x000D897C File Offset: 0x000D6B7C
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

		// Token: 0x0400357D RID: 13693
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400357E RID: 13694
		public const int SlotsFieldNumber = 1;

		// Token: 0x0400357F RID: 13695
		private static readonly FieldCodec<DangoBrawlShopSlotInfo> _repeated_slots_codec = FieldCodec.ForMessage<DangoBrawlShopSlotInfo>(10U, DangoBrawlShopSlotInfo.Parser);

		// Token: 0x04003580 RID: 13696
		private readonly RepeatedField<DangoBrawlShopSlotInfo> slots_ = new RepeatedField<DangoBrawlShopSlotInfo>();

		// Token: 0x04003581 RID: 13697
		public const int NextRefreshCostFieldNumber = 2;

		// Token: 0x04003582 RID: 13698
		private int nextRefreshCost_;

		// Token: 0x04003583 RID: 13699
		public const int ManualRefreshCountFieldNumber = 3;

		// Token: 0x04003584 RID: 13700
		private int manualRefreshCount_;
	}
}
