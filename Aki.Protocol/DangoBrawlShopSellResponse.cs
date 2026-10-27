using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000377 RID: 887
	[NetMessage(EMessageId.DangoBrawlShopSellResponse)]
	public sealed class DangoBrawlShopSellResponse : IMessage<DangoBrawlShopSellResponse>, IMessage, IEquatable<DangoBrawlShopSellResponse>, IDeepCloneable<DangoBrawlShopSellResponse>, IBufferMessage
	{
		// Token: 0x06005816 RID: 22550 RVA: 0x000D6F66 File Offset: 0x000D5166
		[NullableContext(1)]
		public static DangoBrawlShopSellResponse Create()
		{
			return new DangoBrawlShopSellResponse();
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06005817 RID: 22551 RVA: 0x000D6F6D File Offset: 0x000D516D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x000D6F70 File Offset: 0x000D5170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopSellResponse.Descriptor;
			}
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x000D6F77 File Offset: 0x000D5177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellResponse()
		{
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x000D6F7F File Offset: 0x000D517F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellResponse(DangoBrawlShopSellResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x000D6FA4 File Offset: 0x000D51A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellResponse Clone()
		{
			return new DangoBrawlShopSellResponse(this);
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x000D6FAC File Offset: 0x000D51AC
		// (set) Token: 0x0600581D RID: 22557 RVA: 0x000D6FB4 File Offset: 0x000D51B4
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

		// Token: 0x0600581E RID: 22558 RVA: 0x000D6FBD File Offset: 0x000D51BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopSellResponse);
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x000D6FCB File Offset: 0x000D51CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopSellResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x000D6FFC File Offset: 0x000D51FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06005821 RID: 22561 RVA: 0x000D7041 File Offset: 0x000D5241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x000D704E File Offset: 0x000D524E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x000D7057 File Offset: 0x000D5257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x000D708C File Offset: 0x000D528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06005825 RID: 22565 RVA: 0x000D70CA File Offset: 0x000D52CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopSellResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x000D70FB File Offset: 0x000D52FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x000D7104 File Offset: 0x000D5304
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040034FF RID: 13567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003500 RID: 13568
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04003501 RID: 13569
		private ErrorCode errorCode_;
	}
}
