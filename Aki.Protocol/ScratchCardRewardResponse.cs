using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A1 RID: 4513
	[NetMessage(EMessageId.ScratchCardRewardResponse)]
	public sealed class ScratchCardRewardResponse : IMessage<ScratchCardRewardResponse>, IMessage, IEquatable<ScratchCardRewardResponse>, IDeepCloneable<ScratchCardRewardResponse>, IBufferMessage
	{
		// Token: 0x060180BA RID: 98490 RVA: 0x0037DB27 File Offset: 0x0037BD27
		[NullableContext(1)]
		public static ScratchCardRewardResponse Create()
		{
			return new ScratchCardRewardResponse();
		}

		// Token: 0x170050CB RID: 20683
		// (get) Token: 0x060180BB RID: 98491 RVA: 0x0037DB2E File Offset: 0x0037BD2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050CC RID: 20684
		// (get) Token: 0x060180BC RID: 98492 RVA: 0x0037DB31 File Offset: 0x0037BD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardRewardResponse.Descriptor;
			}
		}

		// Token: 0x060180BD RID: 98493 RVA: 0x0037DB38 File Offset: 0x0037BD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardResponse()
		{
		}

		// Token: 0x060180BE RID: 98494 RVA: 0x0037DB64 File Offset: 0x0037BD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardResponse(ScratchCardRewardResponse other) : this()
		{
			this.openType_ = other.openType_;
			this.openIndex_ = other.openIndex_.Clone();
			this.itemMap_ = other.itemMap_.Clone();
			this.leftRewardItem_ = other.leftRewardItem_.Clone();
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060180BF RID: 98495 RVA: 0x0037DBD3 File Offset: 0x0037BDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardResponse Clone()
		{
			return new ScratchCardRewardResponse(this);
		}

		// Token: 0x170050CD RID: 20685
		// (get) Token: 0x060180C0 RID: 98496 RVA: 0x0037DBDB File Offset: 0x0037BDDB
		// (set) Token: 0x060180C1 RID: 98497 RVA: 0x0037DBE3 File Offset: 0x0037BDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OpenType
		{
			get
			{
				return this.openType_;
			}
			set
			{
				this.openType_ = value;
			}
		}

		// Token: 0x170050CE RID: 20686
		// (get) Token: 0x060180C2 RID: 98498 RVA: 0x0037DBEC File Offset: 0x0037BDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ScratchCardRewardData> OpenIndex
		{
			get
			{
				return this.openIndex_;
			}
		}

		// Token: 0x170050CF RID: 20687
		// (get) Token: 0x060180C3 RID: 98499 RVA: 0x0037DBF4 File Offset: 0x0037BDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x170050D0 RID: 20688
		// (get) Token: 0x060180C4 RID: 98500 RVA: 0x0037DBFC File Offset: 0x0037BDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LeftRewardItem
		{
			get
			{
				return this.leftRewardItem_;
			}
		}

		// Token: 0x170050D1 RID: 20689
		// (get) Token: 0x060180C5 RID: 98501 RVA: 0x0037DC04 File Offset: 0x0037BE04
		// (set) Token: 0x060180C6 RID: 98502 RVA: 0x0037DC0C File Offset: 0x0037BE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x060180C7 RID: 98503 RVA: 0x0037DC15 File Offset: 0x0037BE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardRewardResponse);
		}

		// Token: 0x060180C8 RID: 98504 RVA: 0x0037DC24 File Offset: 0x0037BE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardRewardResponse other)
		{
			return other != null && (other == this || (this.OpenType == other.OpenType && this.OpenIndex.Equals(other.OpenIndex) && this.ItemMap.Equals(other.ItemMap) && this.LeftRewardItem.Equals(other.LeftRewardItem) && this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060180C9 RID: 98505 RVA: 0x0037DCAC File Offset: 0x0037BEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpenType != 0)
			{
				num ^= this.OpenType.GetHashCode();
			}
			num ^= this.OpenIndex.GetHashCode();
			num ^= this.ItemMap.GetHashCode();
			num ^= this.LeftRewardItem.GetHashCode();
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060180CA RID: 98506 RVA: 0x0037DD34 File Offset: 0x0037BF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060180CB RID: 98507 RVA: 0x0037DD41 File Offset: 0x0037BF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180CC RID: 98508 RVA: 0x0037DD4C File Offset: 0x0037BF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpenType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OpenType);
			}
			this.itemMap_.WriteTo(ref output, ScratchCardRewardResponse._map_itemMap_codec);
			this.leftRewardItem_.WriteTo(ref output, ScratchCardRewardResponse._map_leftRewardItem_codec);
			this.openIndex_.WriteTo(ref output, ScratchCardRewardResponse._map_openIndex_codec);
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060180CD RID: 98509 RVA: 0x0037DDD8 File Offset: 0x0037BFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpenType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OpenType);
			}
			num += this.openIndex_.CalculateSize(ScratchCardRewardResponse._map_openIndex_codec);
			num += this.itemMap_.CalculateSize(ScratchCardRewardResponse._map_itemMap_codec);
			num += this.leftRewardItem_.CalculateSize(ScratchCardRewardResponse._map_leftRewardItem_codec);
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060180CE RID: 98510 RVA: 0x0037DE68 File Offset: 0x0037C068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpenType != 0)
			{
				this.OpenType = other.OpenType;
			}
			this.openIndex_.MergeFrom(other.openIndex_);
			this.itemMap_.MergeFrom(other.itemMap_);
			this.leftRewardItem_.MergeFrom(other.leftRewardItem_);
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060180CF RID: 98511 RVA: 0x0037DEEB File Offset: 0x0037C0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180D0 RID: 98512 RVA: 0x0037DEF4 File Offset: 0x0037C0F4
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
					if (num == 24U)
					{
						this.OpenType = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.itemMap_.AddEntriesFrom(ref input, ScratchCardRewardResponse._map_itemMap_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.leftRewardItem_.AddEntriesFrom(ref input, ScratchCardRewardResponse._map_leftRewardItem_codec);
						continue;
					}
					if (num == 114U)
					{
						this.openIndex_.AddEntriesFrom(ref input, ScratchCardRewardResponse._map_openIndex_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Error = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008E52 RID: 36434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E53 RID: 36435
		public const int OpenTypeFieldNumber = 3;

		// Token: 0x04008E54 RID: 36436
		private int openType_;

		// Token: 0x04008E55 RID: 36437
		public const int OpenIndexFieldNumber = 14;

		// Token: 0x04008E56 RID: 36438
		private static readonly MapField<int, ScratchCardRewardData>.Codec _map_openIndex_codec = new MapField<int, ScratchCardRewardData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ScratchCardRewardData>(18U, ScratchCardRewardData.Parser), 114U);

		// Token: 0x04008E57 RID: 36439
		private readonly MapField<int, ScratchCardRewardData> openIndex_ = new MapField<int, ScratchCardRewardData>();

		// Token: 0x04008E58 RID: 36440
		public const int ItemMapFieldNumber = 5;

		// Token: 0x04008E59 RID: 36441
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04008E5A RID: 36442
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();

		// Token: 0x04008E5B RID: 36443
		public const int LeftRewardItemFieldNumber = 9;

		// Token: 0x04008E5C RID: 36444
		private static readonly MapField<int, int>.Codec _map_leftRewardItem_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04008E5D RID: 36445
		private readonly MapField<int, int> leftRewardItem_ = new MapField<int, int>();

		// Token: 0x04008E5E RID: 36446
		public const int ErrorFieldNumber = 15;

		// Token: 0x04008E5F RID: 36447
		private ErrorCode error_;
	}
}
