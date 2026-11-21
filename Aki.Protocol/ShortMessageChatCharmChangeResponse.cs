using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123A RID: 4666
	[NetMessage(EMessageId.ShortMessageChatCharmChangeResponse)]
	public sealed class ShortMessageChatCharmChangeResponse : IMessage<ShortMessageChatCharmChangeResponse>, IMessage, IEquatable<ShortMessageChatCharmChangeResponse>, IDeepCloneable<ShortMessageChatCharmChangeResponse>, IBufferMessage
	{
		// Token: 0x06018EB9 RID: 102073 RVA: 0x003A20E9 File Offset: 0x003A02E9
		[NullableContext(1)]
		public static ShortMessageChatCharmChangeResponse Create()
		{
			return new ShortMessageChatCharmChangeResponse();
		}

		// Token: 0x17005433 RID: 21555
		// (get) Token: 0x06018EBA RID: 102074 RVA: 0x003A20F0 File Offset: 0x003A02F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005434 RID: 21556
		// (get) Token: 0x06018EBB RID: 102075 RVA: 0x003A20F3 File Offset: 0x003A02F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageChatCharmChangeResponse.Descriptor;
			}
		}

		// Token: 0x06018EBC RID: 102076 RVA: 0x003A20FA File Offset: 0x003A02FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeResponse()
		{
		}

		// Token: 0x06018EBD RID: 102077 RVA: 0x003A2102 File Offset: 0x003A0302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeResponse(ShortMessageChatCharmChangeResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018EBE RID: 102078 RVA: 0x003A2127 File Offset: 0x003A0327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeResponse Clone()
		{
			return new ShortMessageChatCharmChangeResponse(this);
		}

		// Token: 0x17005435 RID: 21557
		// (get) Token: 0x06018EBF RID: 102079 RVA: 0x003A212F File Offset: 0x003A032F
		// (set) Token: 0x06018EC0 RID: 102080 RVA: 0x003A2137 File Offset: 0x003A0337
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

		// Token: 0x06018EC1 RID: 102081 RVA: 0x003A2140 File Offset: 0x003A0340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageChatCharmChangeResponse);
		}

		// Token: 0x06018EC2 RID: 102082 RVA: 0x003A214E File Offset: 0x003A034E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageChatCharmChangeResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018EC3 RID: 102083 RVA: 0x003A217C File Offset: 0x003A037C
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

		// Token: 0x06018EC4 RID: 102084 RVA: 0x003A21C1 File Offset: 0x003A03C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018EC5 RID: 102085 RVA: 0x003A21CE File Offset: 0x003A03CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018EC6 RID: 102086 RVA: 0x003A21D7 File Offset: 0x003A03D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018EC7 RID: 102087 RVA: 0x003A220C File Offset: 0x003A040C
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

		// Token: 0x06018EC8 RID: 102088 RVA: 0x003A224A File Offset: 0x003A044A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageChatCharmChangeResponse other)
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

		// Token: 0x06018EC9 RID: 102089 RVA: 0x003A227B File Offset: 0x003A047B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018ECA RID: 102090 RVA: 0x003A2284 File Offset: 0x003A0484
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040093CE RID: 37838
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093CF RID: 37839
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x040093D0 RID: 37840
		private ErrorCode errCode_;
	}
}
