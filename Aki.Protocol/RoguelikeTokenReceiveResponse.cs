using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC5 RID: 4037
	[NetMessage(EMessageId.RoguelikeTokenReceiveResponse)]
	public sealed class RoguelikeTokenReceiveResponse : IMessage<RoguelikeTokenReceiveResponse>, IMessage, IEquatable<RoguelikeTokenReceiveResponse>, IDeepCloneable<RoguelikeTokenReceiveResponse>, IBufferMessage
	{
		// Token: 0x0601594E RID: 88398 RVA: 0x00321E2C File Offset: 0x0032002C
		[NullableContext(1)]
		public static RoguelikeTokenReceiveResponse Create()
		{
			return new RoguelikeTokenReceiveResponse();
		}

		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x0601594F RID: 88399 RVA: 0x00321E33 File Offset: 0x00320033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x06015950 RID: 88400 RVA: 0x00321E36 File Offset: 0x00320036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTokenReceiveResponse.Descriptor;
			}
		}

		// Token: 0x06015951 RID: 88401 RVA: 0x00321E3D File Offset: 0x0032003D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveResponse()
		{
		}

		// Token: 0x06015952 RID: 88402 RVA: 0x00321E50 File Offset: 0x00320050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveResponse(RoguelikeTokenReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015953 RID: 88403 RVA: 0x00321E86 File Offset: 0x00320086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveResponse Clone()
		{
			return new RoguelikeTokenReceiveResponse(this);
		}

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x06015954 RID: 88404 RVA: 0x00321E8E File Offset: 0x0032008E
		// (set) Token: 0x06015955 RID: 88405 RVA: 0x00321E96 File Offset: 0x00320096
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

		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x06015956 RID: 88406 RVA: 0x00321E9F File Offset: 0x0032009F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06015957 RID: 88407 RVA: 0x00321EA7 File Offset: 0x003200A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTokenReceiveResponse);
		}

		// Token: 0x06015958 RID: 88408 RVA: 0x00321EB8 File Offset: 0x003200B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTokenReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015959 RID: 88409 RVA: 0x00321F08 File Offset: 0x00320108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601595A RID: 88410 RVA: 0x00321F5B File Offset: 0x0032015B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601595B RID: 88411 RVA: 0x00321F68 File Offset: 0x00320168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601595C RID: 88412 RVA: 0x00321F74 File Offset: 0x00320174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, RoguelikeTokenReceiveResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601595D RID: 88413 RVA: 0x00321FC4 File Offset: 0x003201C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(RoguelikeTokenReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601595E RID: 88414 RVA: 0x00322018 File Offset: 0x00320218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTokenReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601595F RID: 88415 RVA: 0x00322065 File Offset: 0x00320265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015960 RID: 88416 RVA: 0x00322070 File Offset: 0x00320270
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
				if (num != 10U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, RoguelikeTokenReceiveResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x040081A2 RID: 33186
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081A3 RID: 33187
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040081A4 RID: 33188
		private ErrorCode errorCode_;

		// Token: 0x040081A5 RID: 33189
		public const int ItemMapFieldNumber = 1;

		// Token: 0x040081A6 RID: 33190
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x040081A7 RID: 33191
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
