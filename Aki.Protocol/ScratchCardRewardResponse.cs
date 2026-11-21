using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DB RID: 4571
	[NetMessage(EMessageId.ScratchCardRewardResponse)]
	public sealed class ScratchCardRewardResponse : IMessage<ScratchCardRewardResponse>, IMessage, IEquatable<ScratchCardRewardResponse>, IDeepCloneable<ScratchCardRewardResponse>, IBufferMessage
	{
		// Token: 0x0601865B RID: 99931 RVA: 0x0038CE6C File Offset: 0x0038B06C
		[NullableContext(1)]
		public static ScratchCardRewardResponse Create()
		{
			return new ScratchCardRewardResponse();
		}

		// Token: 0x17005237 RID: 21047
		// (get) Token: 0x0601865C RID: 99932 RVA: 0x0038CE73 File Offset: 0x0038B073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005238 RID: 21048
		// (get) Token: 0x0601865D RID: 99933 RVA: 0x0038CE76 File Offset: 0x0038B076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601865E RID: 99934 RVA: 0x0038CE7D File Offset: 0x0038B07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardResponse()
		{
		}

		// Token: 0x0601865F RID: 99935 RVA: 0x0038CEA8 File Offset: 0x0038B0A8
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

		// Token: 0x06018660 RID: 99936 RVA: 0x0038CF17 File Offset: 0x0038B117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardResponse Clone()
		{
			return new ScratchCardRewardResponse(this);
		}

		// Token: 0x17005239 RID: 21049
		// (get) Token: 0x06018661 RID: 99937 RVA: 0x0038CF1F File Offset: 0x0038B11F
		// (set) Token: 0x06018662 RID: 99938 RVA: 0x0038CF27 File Offset: 0x0038B127
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

		// Token: 0x1700523A RID: 21050
		// (get) Token: 0x06018663 RID: 99939 RVA: 0x0038CF30 File Offset: 0x0038B130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ScratchCardRewardData> OpenIndex
		{
			get
			{
				return this.openIndex_;
			}
		}

		// Token: 0x1700523B RID: 21051
		// (get) Token: 0x06018664 RID: 99940 RVA: 0x0038CF38 File Offset: 0x0038B138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x1700523C RID: 21052
		// (get) Token: 0x06018665 RID: 99941 RVA: 0x0038CF40 File Offset: 0x0038B140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LeftRewardItem
		{
			get
			{
				return this.leftRewardItem_;
			}
		}

		// Token: 0x1700523D RID: 21053
		// (get) Token: 0x06018666 RID: 99942 RVA: 0x0038CF48 File Offset: 0x0038B148
		// (set) Token: 0x06018667 RID: 99943 RVA: 0x0038CF50 File Offset: 0x0038B150
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

		// Token: 0x06018668 RID: 99944 RVA: 0x0038CF59 File Offset: 0x0038B159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardRewardResponse);
		}

		// Token: 0x06018669 RID: 99945 RVA: 0x0038CF68 File Offset: 0x0038B168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardRewardResponse other)
		{
			return other != null && (other == this || (this.OpenType == other.OpenType && this.OpenIndex.Equals(other.OpenIndex) && this.ItemMap.Equals(other.ItemMap) && this.LeftRewardItem.Equals(other.LeftRewardItem) && this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601866A RID: 99946 RVA: 0x0038CFF0 File Offset: 0x0038B1F0
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

		// Token: 0x0601866B RID: 99947 RVA: 0x0038D078 File Offset: 0x0038B278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601866C RID: 99948 RVA: 0x0038D085 File Offset: 0x0038B285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601866D RID: 99949 RVA: 0x0038D090 File Offset: 0x0038B290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, ScratchCardRewardResponse._map_itemMap_codec);
			if (this.OpenType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.OpenType);
			}
			this.openIndex_.WriteTo(ref output, ScratchCardRewardResponse._map_openIndex_codec);
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Error);
			}
			this.leftRewardItem_.WriteTo(ref output, ScratchCardRewardResponse._map_leftRewardItem_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601866E RID: 99950 RVA: 0x0038D11C File Offset: 0x0038B31C
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

		// Token: 0x0601866F RID: 99951 RVA: 0x0038D1AC File Offset: 0x0038B3AC
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

		// Token: 0x06018670 RID: 99952 RVA: 0x0038D22F File Offset: 0x0038B42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018671 RID: 99953 RVA: 0x0038D238 File Offset: 0x0038B438
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
					if (num == 18U)
					{
						this.itemMap_.AddEntriesFrom(ref input, ScratchCardRewardResponse._map_itemMap_codec);
						continue;
					}
					if (num == 56U)
					{
						this.OpenType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.openIndex_.AddEntriesFrom(ref input, ScratchCardRewardResponse._map_openIndex_codec);
						continue;
					}
					if (num == 96U)
					{
						this.Error = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 106U)
					{
						this.leftRewardItem_.AddEntriesFrom(ref input, ScratchCardRewardResponse._map_leftRewardItem_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040090E5 RID: 37093
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090E6 RID: 37094
		public const int OpenTypeFieldNumber = 7;

		// Token: 0x040090E7 RID: 37095
		private int openType_;

		// Token: 0x040090E8 RID: 37096
		public const int OpenIndexFieldNumber = 10;

		// Token: 0x040090E9 RID: 37097
		private static readonly MapField<int, ScratchCardRewardData>.Codec _map_openIndex_codec = new MapField<int, ScratchCardRewardData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ScratchCardRewardData>(18U, ScratchCardRewardData.Parser), 82U);

		// Token: 0x040090EA RID: 37098
		private readonly MapField<int, ScratchCardRewardData> openIndex_ = new MapField<int, ScratchCardRewardData>();

		// Token: 0x040090EB RID: 37099
		public const int ItemMapFieldNumber = 2;

		// Token: 0x040090EC RID: 37100
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040090ED RID: 37101
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();

		// Token: 0x040090EE RID: 37102
		public const int LeftRewardItemFieldNumber = 13;

		// Token: 0x040090EF RID: 37103
		private static readonly MapField<int, int>.Codec _map_leftRewardItem_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x040090F0 RID: 37104
		private readonly MapField<int, int> leftRewardItem_ = new MapField<int, int>();

		// Token: 0x040090F1 RID: 37105
		public const int ErrorFieldNumber = 12;

		// Token: 0x040090F2 RID: 37106
		private ErrorCode error_;
	}
}
