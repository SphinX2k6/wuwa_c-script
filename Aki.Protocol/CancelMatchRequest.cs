using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000236 RID: 566
	[NetMessage(EMessageId.CancelMatchRequest)]
	public sealed class CancelMatchRequest : IMessage<CancelMatchRequest>, IMessage, IEquatable<CancelMatchRequest>, IDeepCloneable<CancelMatchRequest>, IBufferMessage
	{
		// Token: 0x06003D6E RID: 15726 RVA: 0x00098AB5 File Offset: 0x00096CB5
		[NullableContext(1)]
		public static CancelMatchRequest Create()
		{
			return new CancelMatchRequest();
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06003D6F RID: 15727 RVA: 0x00098ABC File Offset: 0x00096CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x00098ABF File Offset: 0x00096CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchRequest.Descriptor;
			}
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00098AC6 File Offset: 0x00096CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchRequest()
		{
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x00098ACE File Offset: 0x00096CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchRequest(CancelMatchRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00098AE7 File Offset: 0x00096CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchRequest Clone()
		{
			return new CancelMatchRequest(this);
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00098AEF File Offset: 0x00096CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchRequest);
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x00098AFD File Offset: 0x00096CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMatchRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00098B1C File Offset: 0x00096D1C
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

		// Token: 0x06003D77 RID: 15735 RVA: 0x00098B42 File Offset: 0x00096D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00098B4F File Offset: 0x00096D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00098B58 File Offset: 0x00096D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00098B70 File Offset: 0x00096D70
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

		// Token: 0x06003D7B RID: 15739 RVA: 0x00098B96 File Offset: 0x00096D96
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

		// Token: 0x06003D7C RID: 15740 RVA: 0x00098BB3 File Offset: 0x00096DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x00098BBC File Offset: 0x00096DBC
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

		// Token: 0x04002D08 RID: 11528
		private UnknownFieldSet _unknownFields;
	}
}
