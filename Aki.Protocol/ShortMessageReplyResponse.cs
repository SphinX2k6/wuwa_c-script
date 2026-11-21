using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001246 RID: 4678
	[NetMessage(EMessageId.ShortMessageReplyResponse)]
	public sealed class ShortMessageReplyResponse : IMessage<ShortMessageReplyResponse>, IMessage, IEquatable<ShortMessageReplyResponse>, IDeepCloneable<ShortMessageReplyResponse>, IBufferMessage
	{
		// Token: 0x06018FB2 RID: 102322 RVA: 0x003A458B File Offset: 0x003A278B
		[NullableContext(1)]
		public static ShortMessageReplyResponse Create()
		{
			return new ShortMessageReplyResponse();
		}

		// Token: 0x1700546C RID: 21612
		// (get) Token: 0x06018FB3 RID: 102323 RVA: 0x003A4592 File Offset: 0x003A2792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700546D RID: 21613
		// (get) Token: 0x06018FB4 RID: 102324 RVA: 0x003A4595 File Offset: 0x003A2795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReplyResponse.Descriptor;
			}
		}

		// Token: 0x06018FB5 RID: 102325 RVA: 0x003A459C File Offset: 0x003A279C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyResponse()
		{
		}

		// Token: 0x06018FB6 RID: 102326 RVA: 0x003A45A4 File Offset: 0x003A27A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyResponse(ShortMessageReplyResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FB7 RID: 102327 RVA: 0x003A45C9 File Offset: 0x003A27C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyResponse Clone()
		{
			return new ShortMessageReplyResponse(this);
		}

		// Token: 0x1700546E RID: 21614
		// (get) Token: 0x06018FB8 RID: 102328 RVA: 0x003A45D1 File Offset: 0x003A27D1
		// (set) Token: 0x06018FB9 RID: 102329 RVA: 0x003A45D9 File Offset: 0x003A27D9
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

		// Token: 0x06018FBA RID: 102330 RVA: 0x003A45E2 File Offset: 0x003A27E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReplyResponse);
		}

		// Token: 0x06018FBB RID: 102331 RVA: 0x003A45F0 File Offset: 0x003A27F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReplyResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FBC RID: 102332 RVA: 0x003A4620 File Offset: 0x003A2820
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

		// Token: 0x06018FBD RID: 102333 RVA: 0x003A4665 File Offset: 0x003A2865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FBE RID: 102334 RVA: 0x003A4672 File Offset: 0x003A2872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FBF RID: 102335 RVA: 0x003A467B File Offset: 0x003A287B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FC0 RID: 102336 RVA: 0x003A46B0 File Offset: 0x003A28B0
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

		// Token: 0x06018FC1 RID: 102337 RVA: 0x003A46EE File Offset: 0x003A28EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReplyResponse other)
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

		// Token: 0x06018FC2 RID: 102338 RVA: 0x003A471F File Offset: 0x003A291F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FC3 RID: 102339 RVA: 0x003A4728 File Offset: 0x003A2928
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009426 RID: 37926
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009427 RID: 37927
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04009428 RID: 37928
		private ErrorCode errCode_;
	}
}
