using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123C RID: 4668
	[NetMessage(EMessageId.ShortMessageChatThemeChangeResponse)]
	public sealed class ShortMessageChatThemeChangeResponse : IMessage<ShortMessageChatThemeChangeResponse>, IMessage, IEquatable<ShortMessageChatThemeChangeResponse>, IDeepCloneable<ShortMessageChatThemeChangeResponse>, IBufferMessage
	{
		// Token: 0x06018EDD RID: 102109 RVA: 0x003A24A0 File Offset: 0x003A06A0
		[NullableContext(1)]
		public static ShortMessageChatThemeChangeResponse Create()
		{
			return new ShortMessageChatThemeChangeResponse();
		}

		// Token: 0x17005439 RID: 21561
		// (get) Token: 0x06018EDE RID: 102110 RVA: 0x003A24A7 File Offset: 0x003A06A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700543A RID: 21562
		// (get) Token: 0x06018EDF RID: 102111 RVA: 0x003A24AA File Offset: 0x003A06AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageChatThemeChangeResponse.Descriptor;
			}
		}

		// Token: 0x06018EE0 RID: 102112 RVA: 0x003A24B1 File Offset: 0x003A06B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeResponse()
		{
		}

		// Token: 0x06018EE1 RID: 102113 RVA: 0x003A24B9 File Offset: 0x003A06B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeResponse(ShortMessageChatThemeChangeResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018EE2 RID: 102114 RVA: 0x003A24DE File Offset: 0x003A06DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeResponse Clone()
		{
			return new ShortMessageChatThemeChangeResponse(this);
		}

		// Token: 0x1700543B RID: 21563
		// (get) Token: 0x06018EE3 RID: 102115 RVA: 0x003A24E6 File Offset: 0x003A06E6
		// (set) Token: 0x06018EE4 RID: 102116 RVA: 0x003A24EE File Offset: 0x003A06EE
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

		// Token: 0x06018EE5 RID: 102117 RVA: 0x003A24F7 File Offset: 0x003A06F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageChatThemeChangeResponse);
		}

		// Token: 0x06018EE6 RID: 102118 RVA: 0x003A2505 File Offset: 0x003A0705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageChatThemeChangeResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018EE7 RID: 102119 RVA: 0x003A2534 File Offset: 0x003A0734
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

		// Token: 0x06018EE8 RID: 102120 RVA: 0x003A2579 File Offset: 0x003A0779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018EE9 RID: 102121 RVA: 0x003A2586 File Offset: 0x003A0786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018EEA RID: 102122 RVA: 0x003A258F File Offset: 0x003A078F
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

		// Token: 0x06018EEB RID: 102123 RVA: 0x003A25C4 File Offset: 0x003A07C4
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

		// Token: 0x06018EEC RID: 102124 RVA: 0x003A2602 File Offset: 0x003A0802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageChatThemeChangeResponse other)
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

		// Token: 0x06018EED RID: 102125 RVA: 0x003A2633 File Offset: 0x003A0833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018EEE RID: 102126 RVA: 0x003A263C File Offset: 0x003A083C
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

		// Token: 0x040093D4 RID: 37844
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093D5 RID: 37845
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x040093D6 RID: 37846
		private ErrorCode errCode_;
	}
}
