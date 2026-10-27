using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC3 RID: 3011
	[NetMessage(EMessageId.PartComponentInitResponse)]
	public sealed class PartComponentInitResponse : IMessage<PartComponentInitResponse>, IMessage, IEquatable<PartComponentInitResponse>, IDeepCloneable<PartComponentInitResponse>, IBufferMessage
	{
		// Token: 0x06010509 RID: 66825 RVA: 0x002615F3 File Offset: 0x0025F7F3
		[NullableContext(1)]
		public static PartComponentInitResponse Create()
		{
			return new PartComponentInitResponse();
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0601050A RID: 66826 RVA: 0x002615FA File Offset: 0x0025F7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0601050B RID: 66827 RVA: 0x002615FD File Offset: 0x0025F7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartComponentInitResponse.Descriptor;
			}
		}

		// Token: 0x0601050C RID: 66828 RVA: 0x00261604 File Offset: 0x0025F804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitResponse()
		{
		}

		// Token: 0x0601050D RID: 66829 RVA: 0x0026160C File Offset: 0x0025F80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitResponse(PartComponentInitResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601050E RID: 66830 RVA: 0x00261625 File Offset: 0x0025F825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitResponse Clone()
		{
			return new PartComponentInitResponse(this);
		}

		// Token: 0x0601050F RID: 66831 RVA: 0x0026162D File Offset: 0x0025F82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartComponentInitResponse);
		}

		// Token: 0x06010510 RID: 66832 RVA: 0x0026163B File Offset: 0x0025F83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartComponentInitResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010511 RID: 66833 RVA: 0x0026165C File Offset: 0x0025F85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010512 RID: 66834 RVA: 0x00261682 File Offset: 0x0025F882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010513 RID: 66835 RVA: 0x0026168F File Offset: 0x0025F88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010514 RID: 66836 RVA: 0x00261698 File Offset: 0x0025F898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010515 RID: 66837 RVA: 0x002616B0 File Offset: 0x0025F8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010516 RID: 66838 RVA: 0x002616D6 File Offset: 0x0025F8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartComponentInitResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010517 RID: 66839 RVA: 0x002616F3 File Offset: 0x0025F8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010518 RID: 66840 RVA: 0x002616FC File Offset: 0x0025F8FC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040067B0 RID: 26544
		private UnknownFieldSet _unknownFields;
	}
}
