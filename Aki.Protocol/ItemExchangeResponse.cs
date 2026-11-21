using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083E RID: 2110
	[NetMessage(EMessageId.ItemExchangeResponse)]
	public sealed class ItemExchangeResponse : IMessage<ItemExchangeResponse>, IMessage, IEquatable<ItemExchangeResponse>, IDeepCloneable<ItemExchangeResponse>, IBufferMessage
	{
		// Token: 0x0600BCA1 RID: 48289 RVA: 0x001C0DB0 File Offset: 0x001BEFB0
		[NullableContext(1)]
		public static ItemExchangeResponse Create()
		{
			return new ItemExchangeResponse();
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x0600BCA2 RID: 48290 RVA: 0x001C0DB7 File Offset: 0x001BEFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x0600BCA3 RID: 48291 RVA: 0x001C0DBA File Offset: 0x001BEFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeResponse.Descriptor;
			}
		}

		// Token: 0x0600BCA4 RID: 48292 RVA: 0x001C0DC1 File Offset: 0x001BEFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeResponse()
		{
		}

		// Token: 0x0600BCA5 RID: 48293 RVA: 0x001C0DC9 File Offset: 0x001BEFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeResponse(ItemExchangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x001C0E06 File Offset: 0x001BF006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeResponse Clone()
		{
			return new ItemExchangeResponse(this);
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x0600BCA7 RID: 48295 RVA: 0x001C0E0E File Offset: 0x001BF00E
		// (set) Token: 0x0600BCA8 RID: 48296 RVA: 0x001C0E16 File Offset: 0x001BF016
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

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x0600BCA9 RID: 48297 RVA: 0x001C0E1F File Offset: 0x001BF01F
		// (set) Token: 0x0600BCAA RID: 48298 RVA: 0x001C0E27 File Offset: 0x001BF027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x0600BCAB RID: 48299 RVA: 0x001C0E30 File Offset: 0x001BF030
		// (set) Token: 0x0600BCAC RID: 48300 RVA: 0x001C0E38 File Offset: 0x001BF038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x001C0E41 File Offset: 0x001BF041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeResponse);
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x001C0E50 File Offset: 0x001BF050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x001C0EAC File Offset: 0x001BF0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x001C0F23 File Offset: 0x001BF123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCB1 RID: 48305 RVA: 0x001C0F30 File Offset: 0x001BF130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x001C0F3C File Offset: 0x001BF13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCB3 RID: 48307 RVA: 0x001C0FB4 File Offset: 0x001BF1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x001C1024 File Offset: 0x001BF224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemExchangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x001C1088 File Offset: 0x001BF288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x001C1094 File Offset: 0x001BF294
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
				if (num != 32U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemCount = input.ReadInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040052E2 RID: 21218
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052E3 RID: 21219
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040052E4 RID: 21220
		private ErrorCode errorCode_;

		// Token: 0x040052E5 RID: 21221
		public const int ItemIdFieldNumber = 10;

		// Token: 0x040052E6 RID: 21222
		private int itemId_;

		// Token: 0x040052E7 RID: 21223
		public const int ItemCountFieldNumber = 13;

		// Token: 0x040052E8 RID: 21224
		private int itemCount_;
	}
}
