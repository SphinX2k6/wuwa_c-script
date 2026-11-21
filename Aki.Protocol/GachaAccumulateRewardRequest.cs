using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000678 RID: 1656
	[NetMessage(EMessageId.GachaAccumulateRewardRequest)]
	public sealed class GachaAccumulateRewardRequest : IMessage<GachaAccumulateRewardRequest>, IMessage, IEquatable<GachaAccumulateRewardRequest>, IDeepCloneable<GachaAccumulateRewardRequest>, IBufferMessage
	{
		// Token: 0x06009814 RID: 38932 RVA: 0x0016EF2F File Offset: 0x0016D12F
		[NullableContext(1)]
		public static GachaAccumulateRewardRequest Create()
		{
			return new GachaAccumulateRewardRequest();
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06009815 RID: 38933 RVA: 0x0016EF36 File Offset: 0x0016D136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06009816 RID: 38934 RVA: 0x0016EF39 File Offset: 0x0016D139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x0016EF40 File Offset: 0x0016D140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardRequest()
		{
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x0016EF60 File Offset: 0x0016D160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardRequest(GachaAccumulateRewardRequest other) : this()
		{
			this.gachaAccumulateId_ = other.gachaAccumulateId_;
			this.rewardId_ = other.rewardId_.Clone();
			this.selectedId_ = other.selectedId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x0016EFB2 File Offset: 0x0016D1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardRequest Clone()
		{
			return new GachaAccumulateRewardRequest(this);
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x0600981A RID: 38938 RVA: 0x0016EFBA File Offset: 0x0016D1BA
		// (set) Token: 0x0600981B RID: 38939 RVA: 0x0016EFC2 File Offset: 0x0016D1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaAccumulateId
		{
			get
			{
				return this.gachaAccumulateId_;
			}
			set
			{
				this.gachaAccumulateId_ = value;
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600981C RID: 38940 RVA: 0x0016EFCB File Offset: 0x0016D1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardId
		{
			get
			{
				return this.rewardId_;
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x0600981D RID: 38941 RVA: 0x0016EFD3 File Offset: 0x0016D1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedId
		{
			get
			{
				return this.selectedId_;
			}
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x0016EFDB File Offset: 0x0016D1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateRewardRequest);
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x0016EFEC File Offset: 0x0016D1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateRewardRequest other)
		{
			return other != null && (other == this || (this.GachaAccumulateId == other.GachaAccumulateId && this.rewardId_.Equals(other.rewardId_) && this.selectedId_.Equals(other.selectedId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x0016F050 File Offset: 0x0016D250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaAccumulateId != 0)
			{
				num ^= this.GachaAccumulateId.GetHashCode();
			}
			num ^= this.rewardId_.GetHashCode();
			num ^= this.selectedId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009821 RID: 38945 RVA: 0x0016F0AB File Offset: 0x0016D2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009822 RID: 38946 RVA: 0x0016F0B8 File Offset: 0x0016D2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009823 RID: 38947 RVA: 0x0016F0C4 File Offset: 0x0016D2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardId_.WriteTo(ref output, GachaAccumulateRewardRequest._repeated_rewardId_codec);
			if (this.GachaAccumulateId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GachaAccumulateId);
			}
			this.selectedId_.WriteTo(ref output, GachaAccumulateRewardRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x0016F124 File Offset: 0x0016D324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaAccumulateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaAccumulateId);
			}
			num += this.rewardId_.CalculateSize(GachaAccumulateRewardRequest._repeated_rewardId_codec);
			num += this.selectedId_.CalculateSize(GachaAccumulateRewardRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009825 RID: 38949 RVA: 0x0016F188 File Offset: 0x0016D388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaAccumulateId != 0)
			{
				this.GachaAccumulateId = other.GachaAccumulateId;
			}
			this.rewardId_.Add(other.rewardId_);
			this.selectedId_.Add(other.selectedId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x0016F1E6 File Offset: 0x0016D3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x0016F1F0 File Offset: 0x0016D3F0
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
				if (num <= 66U)
				{
					if (num == 64U || num == 66U)
					{
						this.rewardId_.AddEntriesFrom(ref input, GachaAccumulateRewardRequest._repeated_rewardId_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.GachaAccumulateId = input.ReadInt32();
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.selectedId_.AddEntriesFrom(ref input, GachaAccumulateRewardRequest._repeated_selectedId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400488D RID: 18573
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400488E RID: 18574
		public const int GachaAccumulateIdFieldNumber = 11;

		// Token: 0x0400488F RID: 18575
		private int gachaAccumulateId_;

		// Token: 0x04004890 RID: 18576
		public const int RewardIdFieldNumber = 8;

		// Token: 0x04004891 RID: 18577
		private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04004892 RID: 18578
		private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

		// Token: 0x04004893 RID: 18579
		public const int SelectedIdFieldNumber = 14;

		// Token: 0x04004894 RID: 18580
		private static readonly FieldCodec<int> _repeated_selectedId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04004895 RID: 18581
		private readonly RepeatedField<int> selectedId_ = new RepeatedField<int>();
	}
}
