using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E3 RID: 227
	[NetMessage(EMessageId.AnimalDestroyResponse)]
	public sealed class AnimalDestroyResponse : IMessage<AnimalDestroyResponse>, IMessage, IEquatable<AnimalDestroyResponse>, IDeepCloneable<AnimalDestroyResponse>, IBufferMessage
	{
		// Token: 0x060021AD RID: 8621 RVA: 0x0005A411 File Offset: 0x00058611
		[NullableContext(1)]
		public static AnimalDestroyResponse Create()
		{
			return new AnimalDestroyResponse();
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x0005A418 File Offset: 0x00058618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x0005A41B File Offset: 0x0005861B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDestroyResponse.Descriptor;
			}
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0005A422 File Offset: 0x00058622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyResponse()
		{
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0005A42A File Offset: 0x0005862A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyResponse(AnimalDestroyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0005A44F File Offset: 0x0005864F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyResponse Clone()
		{
			return new AnimalDestroyResponse(this);
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0005A457 File Offset: 0x00058657
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x0005A45F File Offset: 0x0005865F
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

		// Token: 0x060021B5 RID: 8629 RVA: 0x0005A468 File Offset: 0x00058668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDestroyResponse);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0005A476 File Offset: 0x00058676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDestroyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0005A4A4 File Offset: 0x000586A4
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

		// Token: 0x060021B8 RID: 8632 RVA: 0x0005A4E9 File Offset: 0x000586E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0005A4F6 File Offset: 0x000586F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0005A4FF File Offset: 0x000586FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0005A530 File Offset: 0x00058730
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

		// Token: 0x060021BC RID: 8636 RVA: 0x0005A56E File Offset: 0x0005876E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDestroyResponse other)
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

		// Token: 0x060021BD RID: 8637 RVA: 0x0005A59F File Offset: 0x0005879F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0005A5A8 File Offset: 0x000587A8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400249D RID: 9373
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400249E RID: 9374
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400249F RID: 9375
		private ErrorCode errorCode_;
	}
}
