using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9D RID: 3997
	[NetMessage(EMessageId.RoguelikeGiveUpGainResponse)]
	public sealed class RoguelikeGiveUpGainResponse : IMessage<RoguelikeGiveUpGainResponse>, IMessage, IEquatable<RoguelikeGiveUpGainResponse>, IDeepCloneable<RoguelikeGiveUpGainResponse>, IBufferMessage
	{
		// Token: 0x06015601 RID: 87553 RVA: 0x0031A1D4 File Offset: 0x003183D4
		[NullableContext(1)]
		public static RoguelikeGiveUpGainResponse Create()
		{
			return new RoguelikeGiveUpGainResponse();
		}

		// Token: 0x1700473D RID: 18237
		// (get) Token: 0x06015602 RID: 87554 RVA: 0x0031A1DB File Offset: 0x003183DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700473E RID: 18238
		// (get) Token: 0x06015603 RID: 87555 RVA: 0x0031A1DE File Offset: 0x003183DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGiveUpGainResponse.Descriptor;
			}
		}

		// Token: 0x06015604 RID: 87556 RVA: 0x0031A1E5 File Offset: 0x003183E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainResponse()
		{
		}

		// Token: 0x06015605 RID: 87557 RVA: 0x0031A1F8 File Offset: 0x003183F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainResponse(RoguelikeGiveUpGainResponse other) : this()
		{
			this.bindId_ = other.bindId_;
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015606 RID: 87558 RVA: 0x0031A245 File Offset: 0x00318445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainResponse Clone()
		{
			return new RoguelikeGiveUpGainResponse(this);
		}

		// Token: 0x1700473F RID: 18239
		// (get) Token: 0x06015607 RID: 87559 RVA: 0x0031A24D File Offset: 0x0031844D
		// (set) Token: 0x06015608 RID: 87560 RVA: 0x0031A255 File Offset: 0x00318455
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

		// Token: 0x17004740 RID: 18240
		// (get) Token: 0x06015609 RID: 87561 RVA: 0x0031A25E File Offset: 0x0031845E
		// (set) Token: 0x0601560A RID: 87562 RVA: 0x0031A266 File Offset: 0x00318466
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

		// Token: 0x17004741 RID: 18241
		// (get) Token: 0x0601560B RID: 87563 RVA: 0x0031A26F File Offset: 0x0031846F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0601560C RID: 87564 RVA: 0x0031A277 File Offset: 0x00318477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGiveUpGainResponse);
		}

		// Token: 0x0601560D RID: 87565 RVA: 0x0031A288 File Offset: 0x00318488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGiveUpGainResponse other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601560E RID: 87566 RVA: 0x0031A2E8 File Offset: 0x003184E8
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

		// Token: 0x0601560F RID: 87567 RVA: 0x0031A354 File Offset: 0x00318554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015610 RID: 87568 RVA: 0x0031A361 File Offset: 0x00318561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015611 RID: 87569 RVA: 0x0031A36C File Offset: 0x0031856C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, RoguelikeGiveUpGainResponse._map_itemMap_codec);
			if (this.BindId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015612 RID: 87570 RVA: 0x0031A3D8 File Offset: 0x003185D8
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

		// Token: 0x06015613 RID: 87571 RVA: 0x0031A444 File Offset: 0x00318644
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

		// Token: 0x06015614 RID: 87572 RVA: 0x0031A4A5 File Offset: 0x003186A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015615 RID: 87573 RVA: 0x0031A4B0 File Offset: 0x003186B0
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
				if (num != 16U)
				{
					if (num != 66U)
					{
						if (num != 88U)
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
						this.itemMap_.AddEntriesFrom(ref input, RoguelikeGiveUpGainResponse._map_itemMap_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008098 RID: 32920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008099 RID: 32921
		public const int BindIdFieldNumber = 11;

		// Token: 0x0400809A RID: 32922
		private int bindId_;

		// Token: 0x0400809B RID: 32923
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400809C RID: 32924
		private ErrorCode errorCode_;

		// Token: 0x0400809D RID: 32925
		public const int ItemMapFieldNumber = 8;

		// Token: 0x0400809E RID: 32926
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x0400809F RID: 32927
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
