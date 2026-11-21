using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001248 RID: 4680
	[NetMessage(EMessageId.ShortMessageShowChangeResponse)]
	public sealed class ShortMessageShowChangeResponse : IMessage<ShortMessageShowChangeResponse>, IMessage, IEquatable<ShortMessageShowChangeResponse>, IDeepCloneable<ShortMessageShowChangeResponse>, IBufferMessage
	{
		// Token: 0x06018FD8 RID: 102360 RVA: 0x003A4A08 File Offset: 0x003A2C08
		[NullableContext(1)]
		public static ShortMessageShowChangeResponse Create()
		{
			return new ShortMessageShowChangeResponse();
		}

		// Token: 0x17005473 RID: 21619
		// (get) Token: 0x06018FD9 RID: 102361 RVA: 0x003A4A0F File Offset: 0x003A2C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005474 RID: 21620
		// (get) Token: 0x06018FDA RID: 102362 RVA: 0x003A4A12 File Offset: 0x003A2C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageShowChangeResponse.Descriptor;
			}
		}

		// Token: 0x06018FDB RID: 102363 RVA: 0x003A4A19 File Offset: 0x003A2C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeResponse()
		{
		}

		// Token: 0x06018FDC RID: 102364 RVA: 0x003A4A21 File Offset: 0x003A2C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeResponse(ShortMessageShowChangeResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FDD RID: 102365 RVA: 0x003A4A46 File Offset: 0x003A2C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeResponse Clone()
		{
			return new ShortMessageShowChangeResponse(this);
		}

		// Token: 0x17005475 RID: 21621
		// (get) Token: 0x06018FDE RID: 102366 RVA: 0x003A4A4E File Offset: 0x003A2C4E
		// (set) Token: 0x06018FDF RID: 102367 RVA: 0x003A4A56 File Offset: 0x003A2C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06018FE0 RID: 102368 RVA: 0x003A4A5F File Offset: 0x003A2C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageShowChangeResponse);
		}

		// Token: 0x06018FE1 RID: 102369 RVA: 0x003A4A6D File Offset: 0x003A2C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageShowChangeResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FE2 RID: 102370 RVA: 0x003A4A9C File Offset: 0x003A2C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018FE3 RID: 102371 RVA: 0x003A4AE1 File Offset: 0x003A2CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FE4 RID: 102372 RVA: 0x003A4AEE File Offset: 0x003A2CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FE5 RID: 102373 RVA: 0x003A4AF7 File Offset: 0x003A2CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FE6 RID: 102374 RVA: 0x003A4B2C File Offset: 0x003A2D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018FE7 RID: 102375 RVA: 0x003A4B6A File Offset: 0x003A2D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageShowChangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018FE8 RID: 102376 RVA: 0x003A4B9B File Offset: 0x003A2D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FE9 RID: 102377 RVA: 0x003A4BA4 File Offset: 0x003A2DA4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400942E RID: 37934
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400942F RID: 37935
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04009430 RID: 37936
		private ErrorCode errCode_;
	}
}
