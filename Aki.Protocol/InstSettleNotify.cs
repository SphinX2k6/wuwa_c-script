using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082C RID: 2092
	[NetMessage(EMessageId.InstSettleNotify)]
	public sealed class InstSettleNotify : IMessage<InstSettleNotify>, IMessage, IEquatable<InstSettleNotify>, IDeepCloneable<InstSettleNotify>, IBufferMessage
	{
		// Token: 0x0600BB07 RID: 47879 RVA: 0x001BDA9D File Offset: 0x001BBC9D
		[NullableContext(1)]
		public static InstSettleNotify Create()
		{
			return new InstSettleNotify();
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x0600BB08 RID: 47880 RVA: 0x001BDAA4 File Offset: 0x001BBCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x0600BB09 RID: 47881 RVA: 0x001BDAA7 File Offset: 0x001BBCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstSettleNotify.Descriptor;
			}
		}

		// Token: 0x0600BB0A RID: 47882 RVA: 0x001BDAAE File Offset: 0x001BBCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSettleNotify()
		{
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x001BDAC4 File Offset: 0x001BBCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSettleNotify(InstSettleNotify other) : this()
		{
			this.isSuccess_ = other.isSuccess_;
			this.rewardFailTips_ = other.rewardFailTips_;
			this.magnification_ = other.magnification_;
			this.from_ = other.from_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB0C RID: 47884 RVA: 0x001BDB29 File Offset: 0x001BBD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSettleNotify Clone()
		{
			return new InstSettleNotify(this);
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x0600BB0D RID: 47885 RVA: 0x001BDB31 File Offset: 0x001BBD31
		// (set) Token: 0x0600BB0E RID: 47886 RVA: 0x001BDB39 File Offset: 0x001BBD39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x0600BB0F RID: 47887 RVA: 0x001BDB42 File Offset: 0x001BBD42
		// (set) Token: 0x0600BB10 RID: 47888 RVA: 0x001BDB4A File Offset: 0x001BBD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RewardFailTips
		{
			get
			{
				return this.rewardFailTips_;
			}
			set
			{
				this.rewardFailTips_ = value;
			}
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x0600BB11 RID: 47889 RVA: 0x001BDB53 File Offset: 0x001BBD53
		// (set) Token: 0x0600BB12 RID: 47890 RVA: 0x001BDB5B File Offset: 0x001BBD5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Magnification
		{
			get
			{
				return this.magnification_;
			}
			set
			{
				this.magnification_ = value;
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x0600BB13 RID: 47891 RVA: 0x001BDB64 File Offset: 0x001BBD64
		// (set) Token: 0x0600BB14 RID: 47892 RVA: 0x001BDB6C File Offset: 0x001BBD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleDropFrom From
		{
			get
			{
				return this.from_;
			}
			set
			{
				this.from_ = value;
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x0600BB15 RID: 47893 RVA: 0x001BDB75 File Offset: 0x001BBD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RewardItemInfoList> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600BB16 RID: 47894 RVA: 0x001BDB7D File Offset: 0x001BBD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstSettleNotify);
		}

		// Token: 0x0600BB17 RID: 47895 RVA: 0x001BDB8C File Offset: 0x001BBD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstSettleNotify other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.RewardFailTips == other.RewardFailTips && this.Magnification == other.Magnification && this.From == other.From && this.RewardItems.Equals(other.RewardItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x001BDC0C File Offset: 0x001BBE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.RewardFailTips)
			{
				num ^= this.RewardFailTips.GetHashCode();
			}
			if (this.Magnification != 0)
			{
				num ^= this.Magnification.GetHashCode();
			}
			if (this.From != DoubleDropFrom.UnDefineDouble)
			{
				num ^= this.From.GetHashCode();
			}
			num ^= this.RewardItems.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB19 RID: 47897 RVA: 0x001BDCAA File Offset: 0x001BBEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB1A RID: 47898 RVA: 0x001BDCB7 File Offset: 0x001BBEB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x001BDCC0 File Offset: 0x001BBEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Magnification != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Magnification);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsSuccess);
			}
			if (this.From != DoubleDropFrom.UnDefineDouble)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.From);
			}
			this.rewardItems_.WriteTo(ref output, InstSettleNotify._map_rewardItems_codec);
			if (this.RewardFailTips)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.RewardFailTips);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x001BDD64 File Offset: 0x001BBF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.RewardFailTips)
			{
				num += 2;
			}
			if (this.Magnification != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Magnification);
			}
			if (this.From != DoubleDropFrom.UnDefineDouble)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.From);
			}
			num += this.rewardItems_.CalculateSize(InstSettleNotify._map_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB1D RID: 47901 RVA: 0x001BDDE8 File Offset: 0x001BBFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.RewardFailTips)
			{
				this.RewardFailTips = other.RewardFailTips;
			}
			if (other.Magnification != 0)
			{
				this.Magnification = other.Magnification;
			}
			if (other.From != DoubleDropFrom.UnDefineDouble)
			{
				this.From = other.From;
			}
			this.rewardItems_.MergeFrom(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB1E RID: 47902 RVA: 0x001BDE71 File Offset: 0x001BC071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB1F RID: 47903 RVA: 0x001BDE7C File Offset: 0x001BC07C
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
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.Magnification = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.From = (DoubleDropFrom)input.ReadEnum();
						continue;
					}
					if (num == 98U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, InstSettleNotify._map_rewardItems_codec);
						continue;
					}
					if (num == 112U)
					{
						this.RewardFailTips = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400522B RID: 21035
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400522C RID: 21036
		public const int IsSuccessFieldNumber = 6;

		// Token: 0x0400522D RID: 21037
		private bool isSuccess_;

		// Token: 0x0400522E RID: 21038
		public const int RewardFailTipsFieldNumber = 14;

		// Token: 0x0400522F RID: 21039
		private bool rewardFailTips_;

		// Token: 0x04005230 RID: 21040
		public const int MagnificationFieldNumber = 3;

		// Token: 0x04005231 RID: 21041
		private int magnification_;

		// Token: 0x04005232 RID: 21042
		public const int FromFieldNumber = 11;

		// Token: 0x04005233 RID: 21043
		private DoubleDropFrom from_;

		// Token: 0x04005234 RID: 21044
		public const int RewardItemsFieldNumber = 12;

		// Token: 0x04005235 RID: 21045
		private static readonly MapField<int, RewardItemInfoList>.Codec _map_rewardItems_codec = new MapField<int, RewardItemInfoList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RewardItemInfoList>(18U, RewardItemInfoList.Parser), 98U);

		// Token: 0x04005236 RID: 21046
		private readonly MapField<int, RewardItemInfoList> rewardItems_ = new MapField<int, RewardItemInfoList>();
	}
}
