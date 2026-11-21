using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063A RID: 1594
	[NetMessage(EMessageId.FriendApplyHandleResponse)]
	public sealed class FriendApplyHandleResponse : IMessage<FriendApplyHandleResponse>, IMessage, IEquatable<FriendApplyHandleResponse>, IDeepCloneable<FriendApplyHandleResponse>, IBufferMessage
	{
		// Token: 0x0600931C RID: 37660 RVA: 0x001641D0 File Offset: 0x001623D0
		[NullableContext(1)]
		public static FriendApplyHandleResponse Create()
		{
			return new FriendApplyHandleResponse();
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x0600931D RID: 37661 RVA: 0x001641D7 File Offset: 0x001623D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x0600931E RID: 37662 RVA: 0x001641DA File Offset: 0x001623DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyHandleResponse.Descriptor;
			}
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x001641E1 File Offset: 0x001623E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleResponse()
		{
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x001641F4 File Offset: 0x001623F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleResponse(FriendApplyHandleResponse other) : this()
		{
			this.handledMap_ = other.handledMap_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x0016422A File Offset: 0x0016242A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleResponse Clone()
		{
			return new FriendApplyHandleResponse(this);
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06009322 RID: 37666 RVA: 0x00164232 File Offset: 0x00162432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ErrorCode> HandledMap
		{
			get
			{
				return this.handledMap_;
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06009323 RID: 37667 RVA: 0x0016423A File Offset: 0x0016243A
		// (set) Token: 0x06009324 RID: 37668 RVA: 0x00164242 File Offset: 0x00162442
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

		// Token: 0x06009325 RID: 37669 RVA: 0x0016424B File Offset: 0x0016244B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyHandleResponse);
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x0016425C File Offset: 0x0016245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyHandleResponse other)
		{
			return other != null && (other == this || (this.HandledMap.Equals(other.HandledMap) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x001642AC File Offset: 0x001624AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.HandledMap.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x001642FF File Offset: 0x001624FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009329 RID: 37673 RVA: 0x0016430C File Offset: 0x0016250C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600932A RID: 37674 RVA: 0x00164318 File Offset: 0x00162518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.handledMap_.WriteTo(ref output, FriendApplyHandleResponse._map_handledMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600932B RID: 37675 RVA: 0x00164368 File Offset: 0x00162568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.handledMap_.CalculateSize(FriendApplyHandleResponse._map_handledMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600932C RID: 37676 RVA: 0x001643BC File Offset: 0x001625BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplyHandleResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.handledMap_.MergeFrom(other.handledMap_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600932D RID: 37677 RVA: 0x00164409 File Offset: 0x00162609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x00164414 File Offset: 0x00162614
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
				if (num != 24U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.handledMap_.AddEntriesFrom(ref input, FriendApplyHandleResponse._map_handledMap_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004721 RID: 18209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004722 RID: 18210
		public const int HandledMapFieldNumber = 8;

		// Token: 0x04004723 RID: 18211
		private static readonly MapField<int, ErrorCode>.Codec _map_handledMap_codec = new MapField<int, ErrorCode>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<ErrorCode>(16U, (ErrorCode x) => (int)x, (int x) => (ErrorCode)x, ErrorCode.Success), 66U);

		// Token: 0x04004724 RID: 18212
		private readonly MapField<int, ErrorCode> handledMap_ = new MapField<int, ErrorCode>();

		// Token: 0x04004725 RID: 18213
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004726 RID: 18214
		private ErrorCode errorCode_;
	}
}
