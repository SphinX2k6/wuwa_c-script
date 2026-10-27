using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036E RID: 878
	[NetMessage(EMessageId.DangoBrawlShopBuyResponse)]
	public sealed class DangoBrawlShopBuyResponse : IMessage<DangoBrawlShopBuyResponse>, IMessage, IEquatable<DangoBrawlShopBuyResponse>, IDeepCloneable<DangoBrawlShopBuyResponse>, IBufferMessage
	{
		// Token: 0x06005760 RID: 22368 RVA: 0x000D56BE File Offset: 0x000D38BE
		[NullableContext(1)]
		public static DangoBrawlShopBuyResponse Create()
		{
			return new DangoBrawlShopBuyResponse();
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06005761 RID: 22369 RVA: 0x000D56C5 File Offset: 0x000D38C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x000D56C8 File Offset: 0x000D38C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x000D56CF File Offset: 0x000D38CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyResponse()
		{
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x000D56D7 File Offset: 0x000D38D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyResponse(DangoBrawlShopBuyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.useServerBagUpdate_ = other.useServerBagUpdate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x000D5708 File Offset: 0x000D3908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyResponse Clone()
		{
			return new DangoBrawlShopBuyResponse(this);
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x000D5710 File Offset: 0x000D3910
		// (set) Token: 0x06005767 RID: 22375 RVA: 0x000D5718 File Offset: 0x000D3918
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

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x000D5721 File Offset: 0x000D3921
		// (set) Token: 0x06005769 RID: 22377 RVA: 0x000D5729 File Offset: 0x000D3929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UseServerBagUpdate
		{
			get
			{
				return this.useServerBagUpdate_;
			}
			set
			{
				this.useServerBagUpdate_ = value;
			}
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x000D5732 File Offset: 0x000D3932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopBuyResponse);
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x000D5740 File Offset: 0x000D3940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopBuyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.UseServerBagUpdate == other.UseServerBagUpdate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x000D5780 File Offset: 0x000D3980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.UseServerBagUpdate)
			{
				num ^= this.UseServerBagUpdate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x000D57DE File Offset: 0x000D39DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x000D57EB File Offset: 0x000D39EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x000D57F4 File Offset: 0x000D39F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseServerBagUpdate)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.UseServerBagUpdate);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x000D5850 File Offset: 0x000D3A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.UseServerBagUpdate)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x000D589C File Offset: 0x000D3A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopBuyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.UseServerBagUpdate)
			{
				this.UseServerBagUpdate = other.UseServerBagUpdate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x000D58EC File Offset: 0x000D3AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x000D58F8 File Offset: 0x000D3AF8
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
				if (num != 80U)
				{
					if (num != 120U)
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
					this.UseServerBagUpdate = input.ReadBool();
				}
			}
		}

		// Token: 0x040034CD RID: 13517
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034CE RID: 13518
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040034CF RID: 13519
		private ErrorCode errorCode_;

		// Token: 0x040034D0 RID: 13520
		public const int UseServerBagUpdateFieldNumber = 10;

		// Token: 0x040034D1 RID: 13521
		private bool useServerBagUpdate_;
	}
}
