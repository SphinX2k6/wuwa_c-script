using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000818 RID: 2072
	[NetMessage(EMessageId.InstSettleNotify)]
	public sealed class InstSettleNotify : IMessage<InstSettleNotify>, IMessage, IEquatable<InstSettleNotify>, IDeepCloneable<InstSettleNotify>, IBufferMessage
	{
		// Token: 0x0600B9B1 RID: 47537 RVA: 0x001BB061 File Offset: 0x001B9261
		[NullableContext(1)]
		public static InstSettleNotify Create()
		{
			return new InstSettleNotify();
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x0600B9B2 RID: 47538 RVA: 0x001BB068 File Offset: 0x001B9268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x0600B9B3 RID: 47539 RVA: 0x001BB06B File Offset: 0x001B926B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstSettleNotify.Descriptor;
			}
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x001BB072 File Offset: 0x001B9272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSettleNotify()
		{
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x001BB088 File Offset: 0x001B9288
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

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x001BB0ED File Offset: 0x001B92ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSettleNotify Clone()
		{
			return new InstSettleNotify(this);
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x0600B9B7 RID: 47543 RVA: 0x001BB0F5 File Offset: 0x001B92F5
		// (set) Token: 0x0600B9B8 RID: 47544 RVA: 0x001BB0FD File Offset: 0x001B92FD
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

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x0600B9B9 RID: 47545 RVA: 0x001BB106 File Offset: 0x001B9306
		// (set) Token: 0x0600B9BA RID: 47546 RVA: 0x001BB10E File Offset: 0x001B930E
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

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x0600B9BB RID: 47547 RVA: 0x001BB117 File Offset: 0x001B9317
		// (set) Token: 0x0600B9BC RID: 47548 RVA: 0x001BB11F File Offset: 0x001B931F
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

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x0600B9BD RID: 47549 RVA: 0x001BB128 File Offset: 0x001B9328
		// (set) Token: 0x0600B9BE RID: 47550 RVA: 0x001BB130 File Offset: 0x001B9330
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

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x0600B9BF RID: 47551 RVA: 0x001BB139 File Offset: 0x001B9339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RewardItemInfoList> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600B9C0 RID: 47552 RVA: 0x001BB141 File Offset: 0x001B9341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstSettleNotify);
		}

		// Token: 0x0600B9C1 RID: 47553 RVA: 0x001BB150 File Offset: 0x001B9350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstSettleNotify other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.RewardFailTips == other.RewardFailTips && this.Magnification == other.Magnification && this.From == other.From && this.RewardItems.Equals(other.RewardItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x001BB1D0 File Offset: 0x001B93D0
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

		// Token: 0x0600B9C3 RID: 47555 RVA: 0x001BB26E File Offset: 0x001B946E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9C4 RID: 47556 RVA: 0x001BB27B File Offset: 0x001B947B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x001BB284 File Offset: 0x001B9484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.From != DoubleDropFrom.UnDefineDouble)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.From);
			}
			this.rewardItems_.WriteTo(ref output, InstSettleNotify._map_rewardItems_codec);
			if (this.RewardFailTips)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.RewardFailTips);
			}
			if (this.Magnification != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Magnification);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsSuccess);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9C6 RID: 47558 RVA: 0x001BB328 File Offset: 0x001B9528
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

		// Token: 0x0600B9C7 RID: 47559 RVA: 0x001BB3AC File Offset: 0x001B95AC
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

		// Token: 0x0600B9C8 RID: 47560 RVA: 0x001BB435 File Offset: 0x001B9635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9C9 RID: 47561 RVA: 0x001BB440 File Offset: 0x001B9640
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.From = (DoubleDropFrom)input.ReadEnum();
						continue;
					}
					if (num == 42U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, InstSettleNotify._map_rewardItems_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.RewardFailTips = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.Magnification = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005224 RID: 21028
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005225 RID: 21029
		public const int IsSuccessFieldNumber = 12;

		// Token: 0x04005226 RID: 21030
		private bool isSuccess_;

		// Token: 0x04005227 RID: 21031
		public const int RewardFailTipsFieldNumber = 6;

		// Token: 0x04005228 RID: 21032
		private bool rewardFailTips_;

		// Token: 0x04005229 RID: 21033
		public const int MagnificationFieldNumber = 11;

		// Token: 0x0400522A RID: 21034
		private int magnification_;

		// Token: 0x0400522B RID: 21035
		public const int FromFieldNumber = 2;

		// Token: 0x0400522C RID: 21036
		private DoubleDropFrom from_;

		// Token: 0x0400522D RID: 21037
		public const int RewardItemsFieldNumber = 5;

		// Token: 0x0400522E RID: 21038
		private static readonly MapField<int, RewardItemInfoList>.Codec _map_rewardItems_codec = new MapField<int, RewardItemInfoList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RewardItemInfoList>(18U, RewardItemInfoList.Parser), 42U);

		// Token: 0x0400522F RID: 21039
		private readonly MapField<int, RewardItemInfoList> rewardItems_ = new MapField<int, RewardItemInfoList>();
	}
}
