using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000370 RID: 880
	[NetMessage(EMessageId.DangoBrawlShopComposeResponse)]
	public sealed class DangoBrawlShopComposeResponse : IMessage<DangoBrawlShopComposeResponse>, IMessage, IEquatable<DangoBrawlShopComposeResponse>, IDeepCloneable<DangoBrawlShopComposeResponse>, IBufferMessage
	{
		// Token: 0x0600578C RID: 22412 RVA: 0x000D5D85 File Offset: 0x000D3F85
		[NullableContext(1)]
		public static DangoBrawlShopComposeResponse Create()
		{
			return new DangoBrawlShopComposeResponse();
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x0600578D RID: 22413 RVA: 0x000D5D8C File Offset: 0x000D3F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x000D5D8F File Offset: 0x000D3F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopComposeResponse.Descriptor;
			}
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x000D5D96 File Offset: 0x000D3F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeResponse()
		{
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x000D5D9E File Offset: 0x000D3F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeResponse(DangoBrawlShopComposeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newItemUid_ = other.newItemUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x000D5DCF File Offset: 0x000D3FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeResponse Clone()
		{
			return new DangoBrawlShopComposeResponse(this);
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06005792 RID: 22418 RVA: 0x000D5DD7 File Offset: 0x000D3FD7
		// (set) Token: 0x06005793 RID: 22419 RVA: 0x000D5DDF File Offset: 0x000D3FDF
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

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06005794 RID: 22420 RVA: 0x000D5DE8 File Offset: 0x000D3FE8
		// (set) Token: 0x06005795 RID: 22421 RVA: 0x000D5DF0 File Offset: 0x000D3FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewItemUid
		{
			get
			{
				return this.newItemUid_;
			}
			set
			{
				this.newItemUid_ = value;
			}
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x000D5DF9 File Offset: 0x000D3FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopComposeResponse);
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x000D5E07 File Offset: 0x000D4007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopComposeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NewItemUid == other.NewItemUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x000D5E48 File Offset: 0x000D4048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NewItemUid != 0)
			{
				num ^= this.NewItemUid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x000D5EA6 File Offset: 0x000D40A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x000D5EB3 File Offset: 0x000D40B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x000D5EBC File Offset: 0x000D40BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.NewItemUid != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.NewItemUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x000D5F14 File Offset: 0x000D4114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NewItemUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewItemUid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x000D5F6C File Offset: 0x000D416C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopComposeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NewItemUid != 0)
			{
				this.NewItemUid = other.NewItemUid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x000D5FBC File Offset: 0x000D41BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x000D5FC8 File Offset: 0x000D41C8
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
				if (num != 8U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NewItemUid = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040034DC RID: 13532
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034DD RID: 13533
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040034DE RID: 13534
		private ErrorCode errorCode_;

		// Token: 0x040034DF RID: 13535
		public const int NewItemUidFieldNumber = 8;

		// Token: 0x040034E0 RID: 13536
		private int newItemUid_;
	}
}
