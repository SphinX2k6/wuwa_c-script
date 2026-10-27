using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064E RID: 1614
	[NetMessage(EMessageId.FriendApplyHandleResponse)]
	public sealed class FriendApplyHandleResponse : IMessage<FriendApplyHandleResponse>, IMessage, IEquatable<FriendApplyHandleResponse>, IDeepCloneable<FriendApplyHandleResponse>, IBufferMessage
	{
		// Token: 0x06009472 RID: 38002 RVA: 0x00166C00 File Offset: 0x00164E00
		[NullableContext(1)]
		public static FriendApplyHandleResponse Create()
		{
			return new FriendApplyHandleResponse();
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06009473 RID: 38003 RVA: 0x00166C07 File Offset: 0x00164E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06009474 RID: 38004 RVA: 0x00166C0A File Offset: 0x00164E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyHandleResponse.Descriptor;
			}
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x00166C11 File Offset: 0x00164E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleResponse()
		{
		}

		// Token: 0x06009476 RID: 38006 RVA: 0x00166C24 File Offset: 0x00164E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleResponse(FriendApplyHandleResponse other) : this()
		{
			this.handledMap_ = other.handledMap_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009477 RID: 38007 RVA: 0x00166C5A File Offset: 0x00164E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleResponse Clone()
		{
			return new FriendApplyHandleResponse(this);
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06009478 RID: 38008 RVA: 0x00166C62 File Offset: 0x00164E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ErrorCode> HandledMap
		{
			get
			{
				return this.handledMap_;
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x00166C6A File Offset: 0x00164E6A
		// (set) Token: 0x0600947A RID: 38010 RVA: 0x00166C72 File Offset: 0x00164E72
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

		// Token: 0x0600947B RID: 38011 RVA: 0x00166C7B File Offset: 0x00164E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyHandleResponse);
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x00166C8C File Offset: 0x00164E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyHandleResponse other)
		{
			return other != null && (other == this || (this.HandledMap.Equals(other.HandledMap) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x00166CDC File Offset: 0x00164EDC
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

		// Token: 0x0600947E RID: 38014 RVA: 0x00166D2F File Offset: 0x00164F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x00166D3C File Offset: 0x00164F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x00166D48 File Offset: 0x00164F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.handledMap_.WriteTo(ref output, FriendApplyHandleResponse._map_handledMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x00166D98 File Offset: 0x00164F98
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

		// Token: 0x06009482 RID: 38018 RVA: 0x00166DEC File Offset: 0x00164FEC
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

		// Token: 0x06009483 RID: 38019 RVA: 0x00166E39 File Offset: 0x00165039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x00166E44 File Offset: 0x00165044
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
				if (num != 18U)
				{
					if (num != 32U)
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
					this.handledMap_.AddEntriesFrom(ref input, FriendApplyHandleResponse._map_handledMap_codec);
				}
			}
		}

		// Token: 0x04004728 RID: 18216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004729 RID: 18217
		public const int HandledMapFieldNumber = 2;

		// Token: 0x0400472A RID: 18218
		private static readonly MapField<int, ErrorCode>.Codec _map_handledMap_codec = new MapField<int, ErrorCode>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<ErrorCode>(16U, (ErrorCode x) => (int)x, (int x) => (ErrorCode)x, ErrorCode.Success), 18U);

		// Token: 0x0400472B RID: 18219
		private readonly MapField<int, ErrorCode> handledMap_ = new MapField<int, ErrorCode>();

		// Token: 0x0400472C RID: 18220
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400472D RID: 18221
		private ErrorCode errorCode_;
	}
}
