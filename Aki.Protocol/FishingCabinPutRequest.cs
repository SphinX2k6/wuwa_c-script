using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054A RID: 1354
	[NetMessage(EMessageId.FishingCabinPutRequest)]
	public sealed class FishingCabinPutRequest : IMessage<FishingCabinPutRequest>, IMessage, IEquatable<FishingCabinPutRequest>, IDeepCloneable<FishingCabinPutRequest>, IBufferMessage
	{
		// Token: 0x06007E9C RID: 32412 RVA: 0x001326D8 File Offset: 0x001308D8
		[NullableContext(1)]
		public static FishingCabinPutRequest Create()
		{
			return new FishingCabinPutRequest();
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06007E9D RID: 32413 RVA: 0x001326DF File Offset: 0x001308DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x001326E2 File Offset: 0x001308E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCabinPutRequest.Descriptor;
			}
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x001326E9 File Offset: 0x001308E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutRequest()
		{
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x00132708 File Offset: 0x00130908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutRequest(FishingCabinPutRequest other) : this()
		{
			this.cabinType_ = other.cabinType_;
			this.id_ = other.id_;
			this.leftFishingItems_ = other.leftFishingItems_.Clone();
			this.rightFishingItems_ = other.rightFishingItems_.Clone();
			this.removeIncrId_ = other.removeIncrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x00132772 File Offset: 0x00130972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutRequest Clone()
		{
			return new FishingCabinPutRequest(this);
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06007EA2 RID: 32418 RVA: 0x0013277A File Offset: 0x0013097A
		// (set) Token: 0x06007EA3 RID: 32419 RVA: 0x00132782 File Offset: 0x00130982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CabinType CabinType
		{
			get
			{
				return this.cabinType_;
			}
			set
			{
				this.cabinType_ = value;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06007EA4 RID: 32420 RVA: 0x0013278B File Offset: 0x0013098B
		// (set) Token: 0x06007EA5 RID: 32421 RVA: 0x00132793 File Offset: 0x00130993
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

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x0013279C File Offset: 0x0013099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> LeftFishingItems
		{
			get
			{
				return this.leftFishingItems_;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06007EA7 RID: 32423 RVA: 0x001327A4 File Offset: 0x001309A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> RightFishingItems
		{
			get
			{
				return this.rightFishingItems_;
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06007EA8 RID: 32424 RVA: 0x001327AC File Offset: 0x001309AC
		// (set) Token: 0x06007EA9 RID: 32425 RVA: 0x001327B4 File Offset: 0x001309B4
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

		// Token: 0x06007EAA RID: 32426 RVA: 0x001327BD File Offset: 0x001309BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCabinPutRequest);
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x001327CC File Offset: 0x001309CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCabinPutRequest other)
		{
			return other != null && (other == this || (this.CabinType == other.CabinType && this.Id == other.Id && this.leftFishingItems_.Equals(other.leftFishingItems_) && this.rightFishingItems_.Equals(other.rightFishingItems_) && this.RemoveIncrId == other.RemoveIncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x00132850 File Offset: 0x00130A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CabinType != CabinType.ShipCabin)
			{
				num ^= this.CabinType.GetHashCode();
			}
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x001328E3 File Offset: 0x00130AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x001328F0 File Offset: 0x00130AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x001328FC File Offset: 0x00130AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rightFishingItems_.WriteTo(ref output, FishingCabinPutRequest._repeated_rightFishingItems_codec);
			this.leftFishingItems_.WriteTo(ref output, FishingCabinPutRequest._repeated_leftFishingItems_codec);
			if (this.RemoveIncrId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RemoveIncrId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this.CabinType != CabinType.ShipCabin)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.CabinType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x00132994 File Offset: 0x00130B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CabinType != CabinType.ShipCabin)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CabinType);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.leftFishingItems_.CalculateSize(FishingCabinPutRequest._repeated_leftFishingItems_codec);
			num += this.rightFishingItems_.CalculateSize(FishingCabinPutRequest._repeated_rightFishingItems_codec);
			if (this.RemoveIncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemoveIncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x00132A28 File Offset: 0x00130C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCabinPutRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CabinType != CabinType.ShipCabin)
			{
				this.CabinType = other.CabinType;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x00132AAE File Offset: 0x00130CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x00132AB8 File Offset: 0x00130CB8
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
				if (num <= 50U)
				{
					if (num == 10U)
					{
						this.rightFishingItems_.AddEntriesFrom(ref input, FishingCabinPutRequest._repeated_rightFishingItems_codec);
						continue;
					}
					if (num == 50U)
					{
						this.leftFishingItems_.AddEntriesFrom(ref input, FishingCabinPutRequest._repeated_leftFishingItems_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.RemoveIncrId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.CabinType = (CabinType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004024 RID: 16420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004025 RID: 16421
		public const int CabinTypeFieldNumber = 13;

		// Token: 0x04004026 RID: 16422
		private CabinType cabinType_;

		// Token: 0x04004027 RID: 16423
		public const int IdFieldNumber = 10;

		// Token: 0x04004028 RID: 16424
		private int id_;

		// Token: 0x04004029 RID: 16425
		public const int LeftFishingItemsFieldNumber = 6;

		// Token: 0x0400402A RID: 16426
		private static readonly FieldCodec<FishingItemInfo> _repeated_leftFishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(50U, FishingItemInfo.Parser);

		// Token: 0x0400402B RID: 16427
		private readonly RepeatedField<FishingItemInfo> leftFishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x0400402C RID: 16428
		public const int RightFishingItemsFieldNumber = 1;

		// Token: 0x0400402D RID: 16429
		private static readonly FieldCodec<FishingItemInfo> _repeated_rightFishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(10U, FishingItemInfo.Parser);

		// Token: 0x0400402E RID: 16430
		private readonly RepeatedField<FishingItemInfo> rightFishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x0400402F RID: 16431
		public const int RemoveIncrIdFieldNumber = 9;

		// Token: 0x04004030 RID: 16432
		private int removeIncrId_;
	}
}
