using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF0 RID: 3568
	[NetMessage(EMessageId.PsnSettingUpdateResponse)]
	public sealed class PsnSettingUpdateResponse : IMessage<PsnSettingUpdateResponse>, IMessage, IEquatable<PsnSettingUpdateResponse>, IDeepCloneable<PsnSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601330B RID: 78603 RVA: 0x002CB5C1 File Offset: 0x002C97C1
		[NullableContext(1)]
		public static PsnSettingUpdateResponse Create()
		{
			return new PsnSettingUpdateResponse();
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x0601330C RID: 78604 RVA: 0x002CB5C8 File Offset: 0x002C97C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x0601330D RID: 78605 RVA: 0x002CB5CB File Offset: 0x002C97CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PsnSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601330E RID: 78606 RVA: 0x002CB5D2 File Offset: 0x002C97D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateResponse()
		{
		}

		// Token: 0x0601330F RID: 78607 RVA: 0x002CB5DA File Offset: 0x002C97DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateResponse(PsnSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013310 RID: 78608 RVA: 0x002CB5FF File Offset: 0x002C97FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateResponse Clone()
		{
			return new PsnSettingUpdateResponse(this);
		}

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x06013311 RID: 78609 RVA: 0x002CB607 File Offset: 0x002C9807
		// (set) Token: 0x06013312 RID: 78610 RVA: 0x002CB60F File Offset: 0x002C980F
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

		// Token: 0x06013313 RID: 78611 RVA: 0x002CB618 File Offset: 0x002C9818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PsnSettingUpdateResponse);
		}

		// Token: 0x06013314 RID: 78612 RVA: 0x002CB626 File Offset: 0x002C9826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PsnSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013315 RID: 78613 RVA: 0x002CB654 File Offset: 0x002C9854
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

		// Token: 0x06013316 RID: 78614 RVA: 0x002CB699 File Offset: 0x002C9899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013317 RID: 78615 RVA: 0x002CB6A6 File Offset: 0x002C98A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013318 RID: 78616 RVA: 0x002CB6AF File Offset: 0x002C98AF
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

		// Token: 0x06013319 RID: 78617 RVA: 0x002CB6E4 File Offset: 0x002C98E4
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

		// Token: 0x0601331A RID: 78618 RVA: 0x002CB722 File Offset: 0x002C9922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PsnSettingUpdateResponse other)
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

		// Token: 0x0601331B RID: 78619 RVA: 0x002CB753 File Offset: 0x002C9953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601331C RID: 78620 RVA: 0x002CB75C File Offset: 0x002C995C
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

		// Token: 0x04007621 RID: 30241
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007622 RID: 30242
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007623 RID: 30243
		private ErrorCode errorCode_;
	}
}
