using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055E RID: 1374
	[NetMessage(EMessageId.FishingHandInRequest)]
	public sealed class FishingHandInRequest : IMessage<FishingHandInRequest>, IMessage, IEquatable<FishingHandInRequest>, IDeepCloneable<FishingHandInRequest>, IBufferMessage
	{
		// Token: 0x0600801F RID: 32799 RVA: 0x001356FE File Offset: 0x001338FE
		[NullableContext(1)]
		public static FishingHandInRequest Create()
		{
			return new FishingHandInRequest();
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06008020 RID: 32800 RVA: 0x00135705 File Offset: 0x00133905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06008021 RID: 32801 RVA: 0x00135708 File Offset: 0x00133908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingHandInRequest.Descriptor;
			}
		}

		// Token: 0x06008022 RID: 32802 RVA: 0x0013570F File Offset: 0x0013390F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInRequest()
		{
		}

		// Token: 0x06008023 RID: 32803 RVA: 0x00135730 File Offset: 0x00133930
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

		// Token: 0x06008024 RID: 32804 RVA: 0x0013579A File Offset: 0x0013399A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInRequest Clone()
		{
			return new FishingHandInRequest(this);
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x001357A2 File Offset: 0x001339A2
		// (set) Token: 0x06008026 RID: 32806 RVA: 0x001357AA File Offset: 0x001339AA
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

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06008027 RID: 32807 RVA: 0x001357B3 File Offset: 0x001339B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> LeftFishingItems
		{
			get
			{
				return this.leftFishingItems_;
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06008028 RID: 32808 RVA: 0x001357BB File Offset: 0x001339BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> RightFishingItems
		{
			get
			{
				return this.rightFishingItems_;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06008029 RID: 32809 RVA: 0x001357C3 File Offset: 0x001339C3
		// (set) Token: 0x0600802A RID: 32810 RVA: 0x001357CB File Offset: 0x001339CB
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

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600802B RID: 32811 RVA: 0x001357D4 File Offset: 0x001339D4
		// (set) Token: 0x0600802C RID: 32812 RVA: 0x001357DC File Offset: 0x001339DC
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

		// Token: 0x0600802D RID: 32813 RVA: 0x001357E5 File Offset: 0x001339E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingHandInRequest);
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x001357F4 File Offset: 0x001339F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingHandInRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.leftFishingItems_.Equals(other.leftFishingItems_) && this.rightFishingItems_.Equals(other.rightFishingItems_) && this.RemoveIncrId == other.RemoveIncrId && this.ActionIncrId == other.ActionIncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x00135878 File Offset: 0x00133A78
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

		// Token: 0x06008030 RID: 32816 RVA: 0x00135905 File Offset: 0x00133B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x00135912 File Offset: 0x00133B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008032 RID: 32818 RVA: 0x0013591C File Offset: 0x00133B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.leftFishingItems_.WriteTo(ref output, FishingHandInRequest._repeated_leftFishingItems_codec);
			if (this.RemoveIncrId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RemoveIncrId);
			}
			if (this.ActionIncrId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActionIncrId);
			}
			this.rightFishingItems_.WriteTo(ref output, FishingHandInRequest._repeated_rightFishingItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008033 RID: 32819 RVA: 0x001359B4 File Offset: 0x00133BB4
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

		// Token: 0x06008034 RID: 32820 RVA: 0x00135A48 File Offset: 0x00133C48
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

		// Token: 0x06008035 RID: 32821 RVA: 0x00135ACE File Offset: 0x00133CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x00135AD8 File Offset: 0x00133CD8
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
				if (num <= 58U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						this.leftFishingItems_.AddEntriesFrom(ref input, FishingHandInRequest._repeated_leftFishingItems_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.RemoveIncrId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ActionIncrId = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						this.rightFishingItems_.AddEntriesFrom(ref input, FishingHandInRequest._repeated_rightFishingItems_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004084 RID: 16516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004085 RID: 16517
		public const int IdFieldNumber = 1;

		// Token: 0x04004086 RID: 16518
		private int id_;

		// Token: 0x04004087 RID: 16519
		public const int LeftFishingItemsFieldNumber = 7;

		// Token: 0x04004088 RID: 16520
		private static readonly FieldCodec<FishingItemInfo> _repeated_leftFishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(58U, FishingItemInfo.Parser);

		// Token: 0x04004089 RID: 16521
		private readonly RepeatedField<FishingItemInfo> leftFishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x0400408A RID: 16522
		public const int RightFishingItemsFieldNumber = 10;

		// Token: 0x0400408B RID: 16523
		private static readonly FieldCodec<FishingItemInfo> _repeated_rightFishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(82U, FishingItemInfo.Parser);

		// Token: 0x0400408C RID: 16524
		private readonly RepeatedField<FishingItemInfo> rightFishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x0400408D RID: 16525
		public const int RemoveIncrIdFieldNumber = 8;

		// Token: 0x0400408E RID: 16526
		private int removeIncrId_;

		// Token: 0x0400408F RID: 16527
		public const int ActionIncrIdFieldNumber = 9;

		// Token: 0x04004090 RID: 16528
		private int actionIncrId_;
	}
}
