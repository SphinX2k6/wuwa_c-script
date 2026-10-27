using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001200 RID: 4608
	[NetMessage(EMessageId.ShortMessageChatThemeChangeResponse)]
	public sealed class ShortMessageChatThemeChangeResponse : IMessage<ShortMessageChatThemeChangeResponse>, IMessage, IEquatable<ShortMessageChatThemeChangeResponse>, IDeepCloneable<ShortMessageChatThemeChangeResponse>, IBufferMessage
	{
		// Token: 0x06018903 RID: 100611 RVA: 0x00392601 File Offset: 0x00390801
		[NullableContext(1)]
		public static ShortMessageChatThemeChangeResponse Create()
		{
			return new ShortMessageChatThemeChangeResponse();
		}

		// Token: 0x170052BC RID: 21180
		// (get) Token: 0x06018904 RID: 100612 RVA: 0x00392608 File Offset: 0x00390808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052BD RID: 21181
		// (get) Token: 0x06018905 RID: 100613 RVA: 0x0039260B File Offset: 0x0039080B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageChatThemeChangeResponse.Descriptor;
			}
		}

		// Token: 0x06018906 RID: 100614 RVA: 0x00392612 File Offset: 0x00390812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeResponse()
		{
		}

		// Token: 0x06018907 RID: 100615 RVA: 0x0039261A File Offset: 0x0039081A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeResponse(ShortMessageChatThemeChangeResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018908 RID: 100616 RVA: 0x0039263F File Offset: 0x0039083F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeResponse Clone()
		{
			return new ShortMessageChatThemeChangeResponse(this);
		}

		// Token: 0x170052BE RID: 21182
		// (get) Token: 0x06018909 RID: 100617 RVA: 0x00392647 File Offset: 0x00390847
		// (set) Token: 0x0601890A RID: 100618 RVA: 0x0039264F File Offset: 0x0039084F
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

		// Token: 0x0601890B RID: 100619 RVA: 0x00392658 File Offset: 0x00390858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageChatThemeChangeResponse);
		}

		// Token: 0x0601890C RID: 100620 RVA: 0x00392666 File Offset: 0x00390866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageChatThemeChangeResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601890D RID: 100621 RVA: 0x00392694 File Offset: 0x00390894
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

		// Token: 0x0601890E RID: 100622 RVA: 0x003926D9 File Offset: 0x003908D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601890F RID: 100623 RVA: 0x003926E6 File Offset: 0x003908E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018910 RID: 100624 RVA: 0x003926EF File Offset: 0x003908EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018911 RID: 100625 RVA: 0x00392724 File Offset: 0x00390924
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

		// Token: 0x06018912 RID: 100626 RVA: 0x00392762 File Offset: 0x00390962
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

		// Token: 0x06018913 RID: 100627 RVA: 0x00392793 File Offset: 0x00390993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018914 RID: 100628 RVA: 0x0039279C File Offset: 0x0039099C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009123 RID: 37155
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009124 RID: 37156
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04009125 RID: 37157
		private ErrorCode errCode_;
	}
}
