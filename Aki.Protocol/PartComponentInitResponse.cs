using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB3 RID: 2995
	[NetMessage(EMessageId.PartComponentInitResponse)]
	public sealed class PartComponentInitResponse : IMessage<PartComponentInitResponse>, IMessage, IEquatable<PartComponentInitResponse>, IDeepCloneable<PartComponentInitResponse>, IBufferMessage
	{
		// Token: 0x06010405 RID: 66565 RVA: 0x0025F73B File Offset: 0x0025D93B
		[NullableContext(1)]
		public static PartComponentInitResponse Create()
		{
			return new PartComponentInitResponse();
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x06010406 RID: 66566 RVA: 0x0025F742 File Offset: 0x0025D942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x06010407 RID: 66567 RVA: 0x0025F745 File Offset: 0x0025D945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartComponentInitResponse.Descriptor;
			}
		}

		// Token: 0x06010408 RID: 66568 RVA: 0x0025F74C File Offset: 0x0025D94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitResponse()
		{
		}

		// Token: 0x06010409 RID: 66569 RVA: 0x0025F754 File Offset: 0x0025D954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitResponse(PartComponentInitResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601040A RID: 66570 RVA: 0x0025F76D File Offset: 0x0025D96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitResponse Clone()
		{
			return new PartComponentInitResponse(this);
		}

		// Token: 0x0601040B RID: 66571 RVA: 0x0025F775 File Offset: 0x0025D975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartComponentInitResponse);
		}

		// Token: 0x0601040C RID: 66572 RVA: 0x0025F783 File Offset: 0x0025D983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartComponentInitResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601040D RID: 66573 RVA: 0x0025F7A4 File Offset: 0x0025D9A4
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

		// Token: 0x0601040E RID: 66574 RVA: 0x0025F7CA File Offset: 0x0025D9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601040F RID: 66575 RVA: 0x0025F7D7 File Offset: 0x0025D9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010410 RID: 66576 RVA: 0x0025F7E0 File Offset: 0x0025D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010411 RID: 66577 RVA: 0x0025F7F8 File Offset: 0x0025D9F8
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

		// Token: 0x06010412 RID: 66578 RVA: 0x0025F81E File Offset: 0x0025DA1E
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

		// Token: 0x06010413 RID: 66579 RVA: 0x0025F83B File Offset: 0x0025DA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010414 RID: 66580 RVA: 0x0025F844 File Offset: 0x0025DA44
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

		// Token: 0x040067C0 RID: 26560
		private UnknownFieldSet _unknownFields;
	}
}
