using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F32 RID: 3890
	public sealed class RewardGainingPanelInfo : IMessage<RewardGainingPanelInfo>, IMessage, IEquatable<RewardGainingPanelInfo>, IDeepCloneable<RewardGainingPanelInfo>, IBufferMessage
	{
		// Token: 0x06014D0C RID: 85260 RVA: 0x003051A2 File Offset: 0x003033A2
		[NullableContext(1)]
		public static RewardGainingPanelInfo Create()
		{
			return new RewardGainingPanelInfo();
		}

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x06014D0D RID: 85261 RVA: 0x003051A9 File Offset: 0x003033A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x06014D0E RID: 85262 RVA: 0x003051AC File Offset: 0x003033AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardGainingPanelInfo.Descriptor;
			}
		}

		// Token: 0x06014D0F RID: 85263 RVA: 0x003051B3 File Offset: 0x003033B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo()
		{
		}

		// Token: 0x06014D10 RID: 85264 RVA: 0x003051C8 File Offset: 0x003033C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo(RewardGainingPanelInfo other) : this()
		{
			this.gainingGroupIds_ = other.gainingGroupIds_.Clone();
			this.refreshCost_ = other.refreshCost_;
			this.remainRefreshTimes_ = other.remainRefreshTimes_;
			this.totalRefreshTimes_ = other.totalRefreshTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D11 RID: 85265 RVA: 0x00305221 File Offset: 0x00303421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo Clone()
		{
			return new RewardGainingPanelInfo(this);
		}

		// Token: 0x17004533 RID: 17715
		// (get) Token: 0x06014D12 RID: 85266 RVA: 0x00305229 File Offset: 0x00303429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainingGroupIds
		{
			get
			{
				return this.gainingGroupIds_;
			}
		}

		// Token: 0x17004534 RID: 17716
		// (get) Token: 0x06014D13 RID: 85267 RVA: 0x00305231 File Offset: 0x00303431
		// (set) Token: 0x06014D14 RID: 85268 RVA: 0x00305239 File Offset: 0x00303439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCost
		{
			get
			{
				return this.refreshCost_;
			}
			set
			{
				this.refreshCost_ = value;
			}
		}

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x06014D15 RID: 85269 RVA: 0x00305242 File Offset: 0x00303442
		// (set) Token: 0x06014D16 RID: 85270 RVA: 0x0030524A File Offset: 0x0030344A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainRefreshTimes
		{
			get
			{
				return this.remainRefreshTimes_;
			}
			set
			{
				this.remainRefreshTimes_ = value;
			}
		}

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x06014D17 RID: 85271 RVA: 0x00305253 File Offset: 0x00303453
		// (set) Token: 0x06014D18 RID: 85272 RVA: 0x0030525B File Offset: 0x0030345B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalRefreshTimes
		{
			get
			{
				return this.totalRefreshTimes_;
			}
			set
			{
				this.totalRefreshTimes_ = value;
			}
		}

		// Token: 0x06014D19 RID: 85273 RVA: 0x00305264 File Offset: 0x00303464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardGainingPanelInfo);
		}

		// Token: 0x06014D1A RID: 85274 RVA: 0x00305274 File Offset: 0x00303474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardGainingPanelInfo other)
		{
			return other != null && (other == this || (this.gainingGroupIds_.Equals(other.gainingGroupIds_) && this.RefreshCost == other.RefreshCost && this.RemainRefreshTimes == other.RemainRefreshTimes && this.TotalRefreshTimes == other.TotalRefreshTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D1B RID: 85275 RVA: 0x003052E4 File Offset: 0x003034E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gainingGroupIds_.GetHashCode();
			if (this.RefreshCost != 0)
			{
				num ^= this.RefreshCost.GetHashCode();
			}
			if (this.RemainRefreshTimes != 0)
			{
				num ^= this.RemainRefreshTimes.GetHashCode();
			}
			if (this.TotalRefreshTimes != 0)
			{
				num ^= this.TotalRefreshTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014D1C RID: 85276 RVA: 0x00305363 File Offset: 0x00303563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D1D RID: 85277 RVA: 0x00305370 File Offset: 0x00303570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D1E RID: 85278 RVA: 0x0030537C File Offset: 0x0030357C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gainingGroupIds_.WriteTo(ref output, RewardGainingPanelInfo._repeated_gainingGroupIds_codec);
			if (this.RefreshCost != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RefreshCost);
			}
			if (this.RemainRefreshTimes != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RemainRefreshTimes);
			}
			if (this.TotalRefreshTimes != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalRefreshTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D1F RID: 85279 RVA: 0x00305404 File Offset: 0x00303604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gainingGroupIds_.CalculateSize(RewardGainingPanelInfo._repeated_gainingGroupIds_codec);
			if (this.RefreshCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCost);
			}
			if (this.RemainRefreshTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainRefreshTimes);
			}
			if (this.TotalRefreshTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalRefreshTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014D20 RID: 85280 RVA: 0x00305488 File Offset: 0x00303688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RewardGainingPanelInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.gainingGroupIds_.Add(other.gainingGroupIds_);
			if (other.RefreshCost != 0)
			{
				this.RefreshCost = other.RefreshCost;
			}
			if (other.RemainRefreshTimes != 0)
			{
				this.RemainRefreshTimes = other.RemainRefreshTimes;
			}
			if (other.TotalRefreshTimes != 0)
			{
				this.TotalRefreshTimes = other.TotalRefreshTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014D21 RID: 85281 RVA: 0x003054FD File Offset: 0x003036FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D22 RID: 85282 RVA: 0x00305508 File Offset: 0x00303708
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.gainingGroupIds_.AddEntriesFrom(ref input, RewardGainingPanelInfo._repeated_gainingGroupIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U)
					{
						this.RefreshCost = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.RemainRefreshTimes = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.TotalRefreshTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D9D RID: 32157
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D9E RID: 32158
		public const int GainingGroupIdsFieldNumber = 1;

		// Token: 0x04007D9F RID: 32159
		private static readonly FieldCodec<int> _repeated_gainingGroupIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007DA0 RID: 32160
		private readonly RepeatedField<int> gainingGroupIds_ = new RepeatedField<int>();

		// Token: 0x04007DA1 RID: 32161
		public const int RefreshCostFieldNumber = 2;

		// Token: 0x04007DA2 RID: 32162
		private int refreshCost_;

		// Token: 0x04007DA3 RID: 32163
		public const int RemainRefreshTimesFieldNumber = 3;

		// Token: 0x04007DA4 RID: 32164
		private int remainRefreshTimes_;

		// Token: 0x04007DA5 RID: 32165
		public const int TotalRefreshTimesFieldNumber = 4;

		// Token: 0x04007DA6 RID: 32166
		private int totalRefreshTimes_;
	}
}
