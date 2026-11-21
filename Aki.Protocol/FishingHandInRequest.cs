using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000549 RID: 1353
	[NetMessage(EMessageId.FishingHandInRequest)]
	public sealed class FishingHandInRequest : IMessage<FishingHandInRequest>, IMessage, IEquatable<FishingHandInRequest>, IDeepCloneable<FishingHandInRequest>, IBufferMessage
	{
		// Token: 0x06007EB7 RID: 32439 RVA: 0x00132AFE File Offset: 0x00130CFE
		[NullableContext(1)]
		public static FishingHandInRequest Create()
		{
			return new FishingHandInRequest();
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06007EB8 RID: 32440 RVA: 0x00132B05 File Offset: 0x00130D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x00132B08 File Offset: 0x00130D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingHandInRequest.Descriptor;
			}
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x00132B0F File Offset: 0x00130D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInRequest()
		{
		}

		// Token: 0x06007EBB RID: 32443 RVA: 0x00132B30 File Offset: 0x00130D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInRequest(FishingHandInRequest other) : this()
		{
			this.id_ = other.id_;
			this.leftFishingItems_ = other.leftFishingItems_.Clone();
			this.rightFishingItems_ = other.rightFishingItems_.Clone();
			this.removeIncrId_ = other.removeIncrId_;
			this.actionIncrId_ = other.actionIncrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EBC RID: 32444 RVA: 0x00132B9A File Offset: 0x00130D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInRequest Clone()
		{
			return new FishingHandInRequest(this);
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06007EBD RID: 32445 RVA: 0x00132BA2 File Offset: 0x00130DA2
		// (set) Token: 0x06007EBE RID: 32446 RVA: 0x00132BAA File Offset: 0x00130DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06007EBF RID: 32447 RVA: 0x00132BB3 File Offset: 0x00130DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> LeftFishingItems
		{
			get
			{
				return this.leftFishingItems_;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x00132BBB File Offset: 0x00130DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> RightFishingItems
		{
			get
			{
				return this.rightFishingItems_;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06007EC1 RID: 32449 RVA: 0x00132BC3 File Offset: 0x00130DC3
		// (set) Token: 0x06007EC2 RID: 32450 RVA: 0x00132BCB File Offset: 0x00130DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemoveIncrId
		{
			get
			{
				return this.removeIncrId_;
			}
			set
			{
				this.removeIncrId_ = value;
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06007EC3 RID: 32451 RVA: 0x00132BD4 File Offset: 0x00130DD4
		// (set) Token: 0x06007EC4 RID: 32452 RVA: 0x00132BDC File Offset: 0x00130DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionIncrId
		{
			get
			{
				return this.actionIncrId_;
			}
			set
			{
				this.actionIncrId_ = value;
			}
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x00132BE5 File Offset: 0x00130DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingHandInRequest);
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x00132BF4 File Offset: 0x00130DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingHandInRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.leftFishingItems_.Equals(other.leftFishingItems_) && this.rightFishingItems_.Equals(other.rightFishingItems_) && this.RemoveIncrId == other.RemoveIncrId && this.ActionIncrId == other.ActionIncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x00132C78 File Offset: 0x00130E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.leftFishingItems_.GetHashCode();
			num ^= this.rightFishingItems_.GetHashCode();
			if (this.RemoveIncrId != 0)
			{
				num ^= this.RemoveIncrId.GetHashCode();
			}
			if (this.ActionIncrId != 0)
			{
				num ^= this.ActionIncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x00132D05 File Offset: 0x00130F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007EC9 RID: 32457 RVA: 0x00132D12 File Offset: 0x00130F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007ECA RID: 32458 RVA: 0x00132D1C File Offset: 0x00130F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionIncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActionIncrId);
			}
			this.rightFishingItems_.WriteTo(ref output, FishingHandInRequest._repeated_rightFishingItems_codec);
			if (this.RemoveIncrId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RemoveIncrId);
			}
			this.leftFishingItems_.WriteTo(ref output, FishingHandInRequest._repeated_leftFishingItems_codec);
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007ECB RID: 32459 RVA: 0x00132DB4 File Offset: 0x00130FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.leftFishingItems_.CalculateSize(FishingHandInRequest._repeated_leftFishingItems_codec);
			num += this.rightFishingItems_.CalculateSize(FishingHandInRequest._repeated_rightFishingItems_codec);
			if (this.RemoveIncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemoveIncrId);
			}
			if (this.ActionIncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionIncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x00132E48 File Offset: 0x00131048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingHandInRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.leftFishingItems_.Add(other.leftFishingItems_);
			this.rightFishingItems_.Add(other.rightFishingItems_);
			if (other.RemoveIncrId != 0)
			{
				this.RemoveIncrId = other.RemoveIncrId;
			}
			if (other.ActionIncrId != 0)
			{
				this.ActionIncrId = other.ActionIncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007ECD RID: 32461 RVA: 0x00132ECE File Offset: 0x001310CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007ECE RID: 32462 RVA: 0x00132ED8 File Offset: 0x001310D8
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
						this.ActionIncrId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.rightFishingItems_.AddEntriesFrom(ref input, FishingHandInRequest._repeated_rightFishingItems_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.RemoveIncrId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.leftFishingItems_.AddEntriesFrom(ref input, FishingHandInRequest._repeated_leftFishingItems_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400407A RID: 16506
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400407B RID: 16507
		public const int IdFieldNumber = 15;

		// Token: 0x0400407C RID: 16508
		private int id_;

		// Token: 0x0400407D RID: 16509
		public const int LeftFishingItemsFieldNumber = 14;

		// Token: 0x0400407E RID: 16510
		private static readonly FieldCodec<FishingItemInfo> _repeated_leftFishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(114U, FishingItemInfo.Parser);

		// Token: 0x0400407F RID: 16511
		private readonly RepeatedField<FishingItemInfo> leftFishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04004080 RID: 16512
		public const int RightFishingItemsFieldNumber = 5;

		// Token: 0x04004081 RID: 16513
		private static readonly FieldCodec<FishingItemInfo> _repeated_rightFishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(42U, FishingItemInfo.Parser);

		// Token: 0x04004082 RID: 16514
		private readonly RepeatedField<FishingItemInfo> rightFishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04004083 RID: 16515
		public const int RemoveIncrIdFieldNumber = 7;

		// Token: 0x04004084 RID: 16516
		private int removeIncrId_;

		// Token: 0x04004085 RID: 16517
		public const int ActionIncrIdFieldNumber = 2;

		// Token: 0x04004086 RID: 16518
		private int actionIncrId_;
	}
}
