using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000231 RID: 561
	[NetMessage(EMessageId.CancelMatchRequest)]
	public sealed class CancelMatchRequest : IMessage<CancelMatchRequest>, IMessage, IEquatable<CancelMatchRequest>, IDeepCloneable<CancelMatchRequest>, IBufferMessage
	{
		// Token: 0x06003CC9 RID: 15561 RVA: 0x00096E99 File Offset: 0x00095099
		[NullableContext(1)]
		public static CancelMatchRequest Create()
		{
			return new CancelMatchRequest();
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x00096EA0 File Offset: 0x000950A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x00096EA3 File Offset: 0x000950A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchRequest.Descriptor;
			}
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x00096EAA File Offset: 0x000950AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchRequest()
		{
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x00096EB2 File Offset: 0x000950B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchRequest(CancelMatchRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00096ECB File Offset: 0x000950CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchRequest Clone()
		{
			return new CancelMatchRequest(this);
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00096ED3 File Offset: 0x000950D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchRequest);
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00096EE1 File Offset: 0x000950E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMatchRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00096F00 File Offset: 0x00095100
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

		// Token: 0x06003CD2 RID: 15570 RVA: 0x00096F26 File Offset: 0x00095126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00096F33 File Offset: 0x00095133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x00096F3C File Offset: 0x0009513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00096F54 File Offset: 0x00095154
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

		// Token: 0x06003CD6 RID: 15574 RVA: 0x00096F7A File Offset: 0x0009517A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelMatchRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x00096F97 File Offset: 0x00095197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x00096FA0 File Offset: 0x000951A0
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

		// Token: 0x04002C86 RID: 11398
		private UnknownFieldSet _unknownFields;
	}
}
