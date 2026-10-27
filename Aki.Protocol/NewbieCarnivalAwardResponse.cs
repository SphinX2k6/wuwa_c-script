using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B01 RID: 2817
	[NetMessage(EMessageId.NewbieCarnivalAwardResponse)]
	public sealed class NewbieCarnivalAwardResponse : IMessage<NewbieCarnivalAwardResponse>, IMessage, IEquatable<NewbieCarnivalAwardResponse>, IDeepCloneable<NewbieCarnivalAwardResponse>, IBufferMessage
	{
		// Token: 0x0600F4DC RID: 62684 RVA: 0x0023BD74 File Offset: 0x00239F74
		[NullableContext(1)]
		public static NewbieCarnivalAwardResponse Create()
		{
			return new NewbieCarnivalAwardResponse();
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600F4DD RID: 62685 RVA: 0x0023BD7B File Offset: 0x00239F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600F4DE RID: 62686 RVA: 0x0023BD7E File Offset: 0x00239F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalAwardResponse.Descriptor;
			}
		}

		// Token: 0x0600F4DF RID: 62687 RVA: 0x0023BD85 File Offset: 0x00239F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardResponse()
		{
		}

		// Token: 0x0600F4E0 RID: 62688 RVA: 0x0023BD8D File Offset: 0x00239F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardResponse(NewbieCarnivalAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4E1 RID: 62689 RVA: 0x0023BDB2 File Offset: 0x00239FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardResponse Clone()
		{
			return new NewbieCarnivalAwardResponse(this);
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600F4E2 RID: 62690 RVA: 0x0023BDBA File Offset: 0x00239FBA
		// (set) Token: 0x0600F4E3 RID: 62691 RVA: 0x0023BDC2 File Offset: 0x00239FC2
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

		// Token: 0x0600F4E4 RID: 62692 RVA: 0x0023BDCB File Offset: 0x00239FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalAwardResponse);
		}

		// Token: 0x0600F4E5 RID: 62693 RVA: 0x0023BDD9 File Offset: 0x00239FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4E6 RID: 62694 RVA: 0x0023BE08 File Offset: 0x0023A008
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

		// Token: 0x0600F4E7 RID: 62695 RVA: 0x0023BE4D File Offset: 0x0023A04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4E8 RID: 62696 RVA: 0x0023BE5A File Offset: 0x0023A05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4E9 RID: 62697 RVA: 0x0023BE63 File Offset: 0x0023A063
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

		// Token: 0x0600F4EA RID: 62698 RVA: 0x0023BE98 File Offset: 0x0023A098
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

		// Token: 0x0600F4EB RID: 62699 RVA: 0x0023BED6 File Offset: 0x0023A0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalAwardResponse other)
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

		// Token: 0x0600F4EC RID: 62700 RVA: 0x0023BF07 File Offset: 0x0023A107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4ED RID: 62701 RVA: 0x0023BF10 File Offset: 0x0023A110
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

		// Token: 0x0400628C RID: 25228
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400628D RID: 25229
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400628E RID: 25230
		private ErrorCode errorCode_;
	}
}
