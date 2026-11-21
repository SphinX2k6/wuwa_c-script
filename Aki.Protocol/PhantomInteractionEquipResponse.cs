using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC8 RID: 3272
	[NetMessage(EMessageId.PhantomInteractionEquipResponse)]
	public sealed class PhantomInteractionEquipResponse : IMessage<PhantomInteractionEquipResponse>, IMessage, IEquatable<PhantomInteractionEquipResponse>, IDeepCloneable<PhantomInteractionEquipResponse>, IBufferMessage
	{
		// Token: 0x06011BB7 RID: 72631 RVA: 0x00298B21 File Offset: 0x00296D21
		[NullableContext(1)]
		public static PhantomInteractionEquipResponse Create()
		{
			return new PhantomInteractionEquipResponse();
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x06011BB8 RID: 72632 RVA: 0x00298B28 File Offset: 0x00296D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x06011BB9 RID: 72633 RVA: 0x00298B2B File Offset: 0x00296D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionEquipResponse.Descriptor;
			}
		}

		// Token: 0x06011BBA RID: 72634 RVA: 0x00298B32 File Offset: 0x00296D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipResponse()
		{
		}

		// Token: 0x06011BBB RID: 72635 RVA: 0x00298B3A File Offset: 0x00296D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipResponse(PhantomInteractionEquipResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BBC RID: 72636 RVA: 0x00298B5F File Offset: 0x00296D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipResponse Clone()
		{
			return new PhantomInteractionEquipResponse(this);
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x06011BBD RID: 72637 RVA: 0x00298B67 File Offset: 0x00296D67
		// (set) Token: 0x06011BBE RID: 72638 RVA: 0x00298B6F File Offset: 0x00296D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06011BBF RID: 72639 RVA: 0x00298B78 File Offset: 0x00296D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionEquipResponse);
		}

		// Token: 0x06011BC0 RID: 72640 RVA: 0x00298B86 File Offset: 0x00296D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionEquipResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BC1 RID: 72641 RVA: 0x00298BB4 File Offset: 0x00296DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011BC2 RID: 72642 RVA: 0x00298BF9 File Offset: 0x00296DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BC3 RID: 72643 RVA: 0x00298C06 File Offset: 0x00296E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BC4 RID: 72644 RVA: 0x00298C0F File Offset: 0x00296E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BC5 RID: 72645 RVA: 0x00298C44 File Offset: 0x00296E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011BC6 RID: 72646 RVA: 0x00298C82 File Offset: 0x00296E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomInteractionEquipResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011BC7 RID: 72647 RVA: 0x00298CB3 File Offset: 0x00296EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BC8 RID: 72648 RVA: 0x00298CBC File Offset: 0x00296EBC
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006FD8 RID: 28632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FD9 RID: 28633
		public const int CodeFieldNumber = 10;

		// Token: 0x04006FDA RID: 28634
		private ErrorCode code_;
	}
}
