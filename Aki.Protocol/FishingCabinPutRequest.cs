using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000535 RID: 1333
	[NetMessage(EMessageId.FishingCabinPutRequest)]
	public sealed class FishingCabinPutRequest : IMessage<FishingCabinPutRequest>, IMessage, IEquatable<FishingCabinPutRequest>, IDeepCloneable<FishingCabinPutRequest>, IBufferMessage
	{
		// Token: 0x06007D34 RID: 32052 RVA: 0x0012FAD4 File Offset: 0x0012DCD4
		[NullableContext(1)]
		public static FishingCabinPutRequest Create()
		{
			return new FishingCabinPutRequest();
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06007D35 RID: 32053 RVA: 0x0012FADB File Offset: 0x0012DCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06007D36 RID: 32054 RVA: 0x0012FADE File Offset: 0x0012DCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCabinPutRequest.Descriptor;
			}
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x0012FAE5 File Offset: 0x0012DCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutRequest()
		{
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x0012FB04 File Offset: 0x0012DD04
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

		// Token: 0x06007D39 RID: 32057 RVA: 0x0012FB6E File Offset: 0x0012DD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutRequest Clone()
		{
			return new FishingCabinPutRequest(this);
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06007D3A RID: 32058 RVA: 0x0012FB76 File Offset: 0x0012DD76
		// (set) Token: 0x06007D3B RID: 32059 RVA: 0x0012FB7E File Offset: 0x0012DD7E
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

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06007D3C RID: 32060 RVA: 0x0012FB87 File Offset: 0x0012DD87
		// (set) Token: 0x06007D3D RID: 32061 RVA: 0x0012FB8F File Offset: 0x0012DD8F
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

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06007D3E RID: 32062 RVA: 0x0012FB98 File Offset: 0x0012DD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> LeftFishingItems
		{
			get
			{
				return this.leftFishingItems_;
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06007D3F RID: 32063 RVA: 0x0012FBA0 File Offset: 0x0012DDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> RightFishingItems
		{
			get
			{
				return this.rightFishingItems_;
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06007D40 RID: 32064 RVA: 0x0012FBA8 File Offset: 0x0012DDA8
		// (set) Token: 0x06007D41 RID: 32065 RVA: 0x0012FBB0 File Offset: 0x0012DDB0
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

		// Token: 0x06007D42 RID: 32066 RVA: 0x0012FBB9 File Offset: 0x0012DDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCabinPutRequest);
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x0012FBC8 File Offset: 0x0012DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCabinPutRequest other)
		{
			return other != null && (other == this || (this.CabinType == other.CabinType && this.Id == other.Id && this.leftFishingItems_.Equals(other.leftFishingItems_) && this.rightFishingItems_.Equals(other.rightFishingItems_) && this.RemoveIncrId == other.RemoveIncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x0012FC4C File Offset: 0x0012DE4C
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

		// Token: 0x06007D45 RID: 32069 RVA: 0x0012FCDF File Offset: 0x0012DEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D46 RID: 32070 RVA: 0x0012FCEC File Offset: 0x0012DEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x0012FCF8 File Offset: 0x0012DEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CabinType != CabinType.ShipCabin)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.CabinType);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this.RemoveIncrId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RemoveIncrId);
			}
			this.rightFishingItems_.WriteTo(ref output, FishingCabinPutRequest._repeated_rightFishingItems_codec);
			this.leftFishingItems_.WriteTo(ref output, FishingCabinPutRequest._repeated_leftFishingItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x0012FD90 File Offset: 0x0012DF90
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

		// Token: 0x06007D49 RID: 32073 RVA: 0x0012FE24 File Offset: 0x0012E024
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

		// Token: 0x06007D4A RID: 32074 RVA: 0x0012FEAA File Offset: 0x0012E0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x0012FEB4 File Offset: 0x0012E0B4
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.CabinType = (CabinType)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.Id = input.ReadInt32();
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
					if (num == 82U)
					{
						this.rightFishingItems_.AddEntriesFrom(ref input, FishingCabinPutRequest._repeated_rightFishingItems_codec);
						continue;
					}
					if (num == 122U)
					{
						this.leftFishingItems_.AddEntriesFrom(ref input, FishingCabinPutRequest._repeated_leftFishingItems_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400401A RID: 16410
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400401B RID: 16411
		public const int CabinTypeFieldNumber = 3;

		// Token: 0x0400401C RID: 16412
		private CabinType cabinType_;

		// Token: 0x0400401D RID: 16413
		public const int IdFieldNumber = 7;

		// Token: 0x0400401E RID: 16414
		private int id_;

		// Token: 0x0400401F RID: 16415
		public const int LeftFishingItemsFieldNumber = 15;

		// Token: 0x04004020 RID: 16416
		private static readonly FieldCodec<FishingItemInfo> _repeated_leftFishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(122U, FishingItemInfo.Parser);

		// Token: 0x04004021 RID: 16417
		private readonly RepeatedField<FishingItemInfo> leftFishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04004022 RID: 16418
		public const int RightFishingItemsFieldNumber = 10;

		// Token: 0x04004023 RID: 16419
		private static readonly FieldCodec<FishingItemInfo> _repeated_rightFishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(82U, FishingItemInfo.Parser);

		// Token: 0x04004024 RID: 16420
		private readonly RepeatedField<FishingItemInfo> rightFishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04004025 RID: 16421
		public const int RemoveIncrIdFieldNumber = 8;

		// Token: 0x04004026 RID: 16422
		private int removeIncrId_;
	}
}
