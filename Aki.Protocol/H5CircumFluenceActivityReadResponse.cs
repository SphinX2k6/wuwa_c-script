using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000719 RID: 1817
	[NetMessage(EMessageId.H5CircumFluenceActivityReadResponse)]
	public sealed class H5CircumFluenceActivityReadResponse : IMessage<H5CircumFluenceActivityReadResponse>, IMessage, IEquatable<H5CircumFluenceActivityReadResponse>, IDeepCloneable<H5CircumFluenceActivityReadResponse>, IBufferMessage
	{
		// Token: 0x0600A566 RID: 42342 RVA: 0x0018F206 File Offset: 0x0018D406
		[NullableContext(1)]
		public static H5CircumFluenceActivityReadResponse Create()
		{
			return new H5CircumFluenceActivityReadResponse();
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x0600A567 RID: 42343 RVA: 0x0018F20D File Offset: 0x0018D40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x0600A568 RID: 42344 RVA: 0x0018F210 File Offset: 0x0018D410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5CircumFluenceActivityReadResponse.Descriptor;
			}
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x0018F217 File Offset: 0x0018D417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadResponse()
		{
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x0018F21F File Offset: 0x0018D41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadResponse(H5CircumFluenceActivityReadResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A56B RID: 42347 RVA: 0x0018F238 File Offset: 0x0018D438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadResponse Clone()
		{
			return new H5CircumFluenceActivityReadResponse(this);
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x0018F240 File Offset: 0x0018D440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5CircumFluenceActivityReadResponse);
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x0018F24E File Offset: 0x0018D44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5CircumFluenceActivityReadResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A56E RID: 42350 RVA: 0x0018F26C File Offset: 0x0018D46C
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

		// Token: 0x0600A56F RID: 42351 RVA: 0x0018F292 File Offset: 0x0018D492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x0018F29F File Offset: 0x0018D49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x0018F2A8 File Offset: 0x0018D4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x0018F2C0 File Offset: 0x0018D4C0
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

		// Token: 0x0600A573 RID: 42355 RVA: 0x0018F2E6 File Offset: 0x0018D4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5CircumFluenceActivityReadResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x0018F303 File Offset: 0x0018D503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x0018F30C File Offset: 0x0018D50C
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

		// Token: 0x04004C61 RID: 19553
		private UnknownFieldSet _unknownFields;
	}
}
