using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F22 RID: 3874
	public sealed class RewardGainingPanelInfo : IMessage<RewardGainingPanelInfo>, IMessage, IEquatable<RewardGainingPanelInfo>, IDeepCloneable<RewardGainingPanelInfo>, IBufferMessage
	{
		// Token: 0x06014C27 RID: 85031 RVA: 0x00303AE6 File Offset: 0x00301CE6
		[NullableContext(1)]
		public static RewardGainingPanelInfo Create()
		{
			return new RewardGainingPanelInfo();
		}

		// Token: 0x17004507 RID: 17671
		// (get) Token: 0x06014C28 RID: 85032 RVA: 0x00303AED File Offset: 0x00301CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004508 RID: 17672
		// (get) Token: 0x06014C29 RID: 85033 RVA: 0x00303AF0 File Offset: 0x00301CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardGainingPanelInfo.Descriptor;
			}
		}

		// Token: 0x06014C2A RID: 85034 RVA: 0x00303AF7 File Offset: 0x00301CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo()
		{
		}

		// Token: 0x06014C2B RID: 85035 RVA: 0x00303B0C File Offset: 0x00301D0C
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

		// Token: 0x06014C2C RID: 85036 RVA: 0x00303B65 File Offset: 0x00301D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo Clone()
		{
			return new RewardGainingPanelInfo(this);
		}

		// Token: 0x17004509 RID: 17673
		// (get) Token: 0x06014C2D RID: 85037 RVA: 0x00303B6D File Offset: 0x00301D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainingGroupIds
		{
			get
			{
				return this.gainingGroupIds_;
			}
		}

		// Token: 0x1700450A RID: 17674
		// (get) Token: 0x06014C2E RID: 85038 RVA: 0x00303B75 File Offset: 0x00301D75
		// (set) Token: 0x06014C2F RID: 85039 RVA: 0x00303B7D File Offset: 0x00301D7D
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

		// Token: 0x1700450B RID: 17675
		// (get) Token: 0x06014C30 RID: 85040 RVA: 0x00303B86 File Offset: 0x00301D86
		// (set) Token: 0x06014C31 RID: 85041 RVA: 0x00303B8E File Offset: 0x00301D8E
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

		// Token: 0x1700450C RID: 17676
		// (get) Token: 0x06014C32 RID: 85042 RVA: 0x00303B97 File Offset: 0x00301D97
		// (set) Token: 0x06014C33 RID: 85043 RVA: 0x00303B9F File Offset: 0x00301D9F
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

		// Token: 0x06014C34 RID: 85044 RVA: 0x00303BA8 File Offset: 0x00301DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardGainingPanelInfo);
		}

		// Token: 0x06014C35 RID: 85045 RVA: 0x00303BB8 File Offset: 0x00301DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardGainingPanelInfo other)
		{
			return other != null && (other == this || (this.gainingGroupIds_.Equals(other.gainingGroupIds_) && this.RefreshCost == other.RefreshCost && this.RemainRefreshTimes == other.RemainRefreshTimes && this.TotalRefreshTimes == other.TotalRefreshTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C36 RID: 85046 RVA: 0x00303C28 File Offset: 0x00301E28
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

		// Token: 0x06014C37 RID: 85047 RVA: 0x00303CA7 File Offset: 0x00301EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C38 RID: 85048 RVA: 0x00303CB4 File Offset: 0x00301EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C39 RID: 85049 RVA: 0x00303CC0 File Offset: 0x00301EC0
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

		// Token: 0x06014C3A RID: 85050 RVA: 0x00303D48 File Offset: 0x00301F48
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

		// Token: 0x06014C3B RID: 85051 RVA: 0x00303DCC File Offset: 0x00301FCC
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

		// Token: 0x06014C3C RID: 85052 RVA: 0x00303E41 File Offset: 0x00302041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C3D RID: 85053 RVA: 0x00303E4C File Offset: 0x0030204C
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

		// Token: 0x04007DC7 RID: 32199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DC8 RID: 32200
		public const int GainingGroupIdsFieldNumber = 1;

		// Token: 0x04007DC9 RID: 32201
		private static readonly FieldCodec<int> _repeated_gainingGroupIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007DCA RID: 32202
		private readonly RepeatedField<int> gainingGroupIds_ = new RepeatedField<int>();

		// Token: 0x04007DCB RID: 32203
		public const int RefreshCostFieldNumber = 2;

		// Token: 0x04007DCC RID: 32204
		private int refreshCost_;

		// Token: 0x04007DCD RID: 32205
		public const int RemainRefreshTimesFieldNumber = 3;

		// Token: 0x04007DCE RID: 32206
		private int remainRefreshTimes_;

		// Token: 0x04007DCF RID: 32207
		public const int TotalRefreshTimesFieldNumber = 4;

		// Token: 0x04007DD0 RID: 32208
		private int totalRefreshTimes_;
	}
}
