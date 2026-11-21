using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000228 RID: 552
	[NetMessage(EMessageId.CalabashMsgRequest)]
	public sealed class CalabashMsgRequest : IMessage<CalabashMsgRequest>, IMessage, IEquatable<CalabashMsgRequest>, IDeepCloneable<CalabashMsgRequest>, IBufferMessage
	{
		// Token: 0x06003C54 RID: 15444 RVA: 0x0009645A File Offset: 0x0009465A
		[NullableContext(1)]
		public static CalabashMsgRequest Create()
		{
			return new CalabashMsgRequest();
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06003C55 RID: 15445 RVA: 0x00096461 File Offset: 0x00094661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x00096464 File Offset: 0x00094664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashMsgRequest.Descriptor;
			}
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x0009646B File Offset: 0x0009466B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgRequest()
		{
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x00096473 File Offset: 0x00094673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgRequest(CalabashMsgRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x0009648C File Offset: 0x0009468C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgRequest Clone()
		{
			return new CalabashMsgRequest(this);
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x00096494 File Offset: 0x00094694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashMsgRequest);
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x000964A2 File Offset: 0x000946A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashMsgRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000964C0 File Offset: 0x000946C0
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

		// Token: 0x06003C5D RID: 15453 RVA: 0x000964E6 File Offset: 0x000946E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x000964F3 File Offset: 0x000946F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x000964FC File Offset: 0x000946FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x00096514 File Offset: 0x00094714
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

		// Token: 0x06003C61 RID: 15457 RVA: 0x0009653A File Offset: 0x0009473A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashMsgRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x00096557 File Offset: 0x00094757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x00096560 File Offset: 0x00094760
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

		// Token: 0x04002CBF RID: 11455
		private UnknownFieldSet _unknownFields;
	}
}
