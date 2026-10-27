using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076C RID: 1900
	[NetMessage(EMessageId.HonamiStoryBagOperateResponse)]
	public sealed class HonamiStoryBagOperateResponse : IMessage<HonamiStoryBagOperateResponse>, IMessage, IEquatable<HonamiStoryBagOperateResponse>, IDeepCloneable<HonamiStoryBagOperateResponse>, IBufferMessage
	{
		// Token: 0x0600ABD6 RID: 43990 RVA: 0x0019D4F0 File Offset: 0x0019B6F0
		[NullableContext(1)]
		public static HonamiStoryBagOperateResponse Create()
		{
			return new HonamiStoryBagOperateResponse();
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x0600ABD7 RID: 43991 RVA: 0x0019D4F7 File Offset: 0x0019B6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x0600ABD8 RID: 43992 RVA: 0x0019D4FA File Offset: 0x0019B6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagOperateResponse.Descriptor;
			}
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x0019D501 File Offset: 0x0019B701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateResponse()
		{
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x0019D509 File Offset: 0x0019B709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateResponse(HonamiStoryBagOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x0019D52E File Offset: 0x0019B72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateResponse Clone()
		{
			return new HonamiStoryBagOperateResponse(this);
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x0600ABDC RID: 43996 RVA: 0x0019D536 File Offset: 0x0019B736
		// (set) Token: 0x0600ABDD RID: 43997 RVA: 0x0019D53E File Offset: 0x0019B73E
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

		// Token: 0x0600ABDE RID: 43998 RVA: 0x0019D547 File Offset: 0x0019B747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagOperateResponse);
		}

		// Token: 0x0600ABDF RID: 43999 RVA: 0x0019D555 File Offset: 0x0019B755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x0019D584 File Offset: 0x0019B784
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

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x0019D5C9 File Offset: 0x0019B7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x0019D5D6 File Offset: 0x0019B7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x0019D5DF File Offset: 0x0019B7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x0019D614 File Offset: 0x0019B814
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

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x0019D652 File Offset: 0x0019B852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagOperateResponse other)
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

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x0019D683 File Offset: 0x0019B883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x0019D68C File Offset: 0x0019B88C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004DF2 RID: 19954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DF3 RID: 19955
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004DF4 RID: 19956
		private ErrorCode errorCode_;
	}
}
