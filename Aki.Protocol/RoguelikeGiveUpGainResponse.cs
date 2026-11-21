using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8D RID: 3981
	[NetMessage(EMessageId.RoguelikeGiveUpGainResponse)]
	public sealed class RoguelikeGiveUpGainResponse : IMessage<RoguelikeGiveUpGainResponse>, IMessage, IEquatable<RoguelikeGiveUpGainResponse>, IDeepCloneable<RoguelikeGiveUpGainResponse>, IBufferMessage
	{
		// Token: 0x0601551C RID: 87324 RVA: 0x00318B2C File Offset: 0x00316D2C
		[NullableContext(1)]
		public static RoguelikeGiveUpGainResponse Create()
		{
			return new RoguelikeGiveUpGainResponse();
		}

		// Token: 0x17004713 RID: 18195
		// (get) Token: 0x0601551D RID: 87325 RVA: 0x00318B33 File Offset: 0x00316D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004714 RID: 18196
		// (get) Token: 0x0601551E RID: 87326 RVA: 0x00318B36 File Offset: 0x00316D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGiveUpGainResponse.Descriptor;
			}
		}

		// Token: 0x0601551F RID: 87327 RVA: 0x00318B3D File Offset: 0x00316D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainResponse()
		{
		}

		// Token: 0x06015520 RID: 87328 RVA: 0x00318B50 File Offset: 0x00316D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainResponse(RoguelikeGiveUpGainResponse other) : this()
		{
			this.bindId_ = other.bindId_;
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015521 RID: 87329 RVA: 0x00318B9D File Offset: 0x00316D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainResponse Clone()
		{
			return new RoguelikeGiveUpGainResponse(this);
		}

		// Token: 0x17004715 RID: 18197
		// (get) Token: 0x06015522 RID: 87330 RVA: 0x00318BA5 File Offset: 0x00316DA5
		// (set) Token: 0x06015523 RID: 87331 RVA: 0x00318BAD File Offset: 0x00316DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x17004716 RID: 18198
		// (get) Token: 0x06015524 RID: 87332 RVA: 0x00318BB6 File Offset: 0x00316DB6
		// (set) Token: 0x06015525 RID: 87333 RVA: 0x00318BBE File Offset: 0x00316DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17004717 RID: 18199
		// (get) Token: 0x06015526 RID: 87334 RVA: 0x00318BC7 File Offset: 0x00316DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06015527 RID: 87335 RVA: 0x00318BCF File Offset: 0x00316DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGiveUpGainResponse);
		}

		// Token: 0x06015528 RID: 87336 RVA: 0x00318BE0 File Offset: 0x00316DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGiveUpGainResponse other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015529 RID: 87337 RVA: 0x00318C40 File Offset: 0x00316E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601552A RID: 87338 RVA: 0x00318CAC File Offset: 0x00316EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601552B RID: 87339 RVA: 0x00318CB9 File Offset: 0x00316EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601552C RID: 87340 RVA: 0x00318CC4 File Offset: 0x00316EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, RoguelikeGiveUpGainResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.BindId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601552D RID: 87341 RVA: 0x00318D30 File Offset: 0x00316F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(RoguelikeGiveUpGainResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601552E RID: 87342 RVA: 0x00318D9C File Offset: 0x00316F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeGiveUpGainResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601552F RID: 87343 RVA: 0x00318DFD File Offset: 0x00316FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015530 RID: 87344 RVA: 0x00318E08 File Offset: 0x00317008
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
				if (num != 50U)
				{
					if (num != 56U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BindId = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, RoguelikeGiveUpGainResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x040080C2 RID: 32962
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080C3 RID: 32963
		public const int BindIdFieldNumber = 8;

		// Token: 0x040080C4 RID: 32964
		private int bindId_;

		// Token: 0x040080C5 RID: 32965
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040080C6 RID: 32966
		private ErrorCode errorCode_;

		// Token: 0x040080C7 RID: 32967
		public const int ItemMapFieldNumber = 6;

		// Token: 0x040080C8 RID: 32968
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x040080C9 RID: 32969
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
