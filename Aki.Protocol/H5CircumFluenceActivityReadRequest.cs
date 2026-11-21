using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000718 RID: 1816
	[NetMessage(EMessageId.H5CircumFluenceActivityReadRequest)]
	public sealed class H5CircumFluenceActivityReadRequest : IMessage<H5CircumFluenceActivityReadRequest>, IMessage, IEquatable<H5CircumFluenceActivityReadRequest>, IDeepCloneable<H5CircumFluenceActivityReadRequest>, IBufferMessage
	{
		// Token: 0x0600A556 RID: 42326 RVA: 0x0018F0CC File Offset: 0x0018D2CC
		[NullableContext(1)]
		public static H5CircumFluenceActivityReadRequest Create()
		{
			return new H5CircumFluenceActivityReadRequest();
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600A557 RID: 42327 RVA: 0x0018F0D3 File Offset: 0x0018D2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x0600A558 RID: 42328 RVA: 0x0018F0D6 File Offset: 0x0018D2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5CircumFluenceActivityReadRequest.Descriptor;
			}
		}

		// Token: 0x0600A559 RID: 42329 RVA: 0x0018F0DD File Offset: 0x0018D2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadRequest()
		{
		}

		// Token: 0x0600A55A RID: 42330 RVA: 0x0018F0E5 File Offset: 0x0018D2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadRequest(H5CircumFluenceActivityReadRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A55B RID: 42331 RVA: 0x0018F0FE File Offset: 0x0018D2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadRequest Clone()
		{
			return new H5CircumFluenceActivityReadRequest(this);
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x0018F106 File Offset: 0x0018D306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5CircumFluenceActivityReadRequest);
		}

		// Token: 0x0600A55D RID: 42333 RVA: 0x0018F114 File Offset: 0x0018D314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5CircumFluenceActivityReadRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A55E RID: 42334 RVA: 0x0018F134 File Offset: 0x0018D334
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

		// Token: 0x0600A55F RID: 42335 RVA: 0x0018F15A File Offset: 0x0018D35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A560 RID: 42336 RVA: 0x0018F167 File Offset: 0x0018D367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A561 RID: 42337 RVA: 0x0018F170 File Offset: 0x0018D370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A562 RID: 42338 RVA: 0x0018F188 File Offset: 0x0018D388
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

		// Token: 0x0600A563 RID: 42339 RVA: 0x0018F1AE File Offset: 0x0018D3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5CircumFluenceActivityReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x0018F1CB File Offset: 0x0018D3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A565 RID: 42341 RVA: 0x0018F1D4 File Offset: 0x0018D3D4
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

		// Token: 0x04004C60 RID: 19552
		private UnknownFieldSet _unknownFields;
	}
}
