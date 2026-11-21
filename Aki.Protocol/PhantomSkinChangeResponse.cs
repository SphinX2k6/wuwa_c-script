using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF8 RID: 3320
	[NetMessage(EMessageId.PhantomSkinChangeResponse)]
	public sealed class PhantomSkinChangeResponse : IMessage<PhantomSkinChangeResponse>, IMessage, IEquatable<PhantomSkinChangeResponse>, IDeepCloneable<PhantomSkinChangeResponse>, IBufferMessage
	{
		// Token: 0x06011F77 RID: 73591 RVA: 0x002A0DAA File Offset: 0x0029EFAA
		[NullableContext(1)]
		public static PhantomSkinChangeResponse Create()
		{
			return new PhantomSkinChangeResponse();
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x06011F78 RID: 73592 RVA: 0x002A0DB1 File Offset: 0x0029EFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x06011F79 RID: 73593 RVA: 0x002A0DB4 File Offset: 0x0029EFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSkinChangeResponse.Descriptor;
			}
		}

		// Token: 0x06011F7A RID: 73594 RVA: 0x002A0DBB File Offset: 0x0029EFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeResponse()
		{
		}

		// Token: 0x06011F7B RID: 73595 RVA: 0x002A0DC3 File Offset: 0x0029EFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeResponse(PhantomSkinChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F7C RID: 73596 RVA: 0x002A0DE8 File Offset: 0x0029EFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeResponse Clone()
		{
			return new PhantomSkinChangeResponse(this);
		}

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x06011F7D RID: 73597 RVA: 0x002A0DF0 File Offset: 0x0029EFF0
		// (set) Token: 0x06011F7E RID: 73598 RVA: 0x002A0DF8 File Offset: 0x0029EFF8
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

		// Token: 0x06011F7F RID: 73599 RVA: 0x002A0E01 File Offset: 0x0029F001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSkinChangeResponse);
		}

		// Token: 0x06011F80 RID: 73600 RVA: 0x002A0E0F File Offset: 0x0029F00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSkinChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F81 RID: 73601 RVA: 0x002A0E40 File Offset: 0x0029F040
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

		// Token: 0x06011F82 RID: 73602 RVA: 0x002A0E85 File Offset: 0x0029F085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F83 RID: 73603 RVA: 0x002A0E92 File Offset: 0x0029F092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F84 RID: 73604 RVA: 0x002A0E9B File Offset: 0x0029F09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06011F85 RID: 73605 RVA: 0x002A0ED0 File Offset: 0x0029F0D0
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

		// Token: 0x06011F86 RID: 73606 RVA: 0x002A0F0E File Offset: 0x0029F10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSkinChangeResponse other)
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

		// Token: 0x06011F87 RID: 73607 RVA: 0x002A0F3F File Offset: 0x0029F13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F88 RID: 73608 RVA: 0x002A0F48 File Offset: 0x0029F148
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040070FB RID: 28923
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070FC RID: 28924
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040070FD RID: 28925
		private ErrorCode errorCode_;
	}
}
