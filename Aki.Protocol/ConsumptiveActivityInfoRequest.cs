using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E9 RID: 745
	[NetMessage(EMessageId.ConsumptiveActivityInfoRequest)]
	public sealed class ConsumptiveActivityInfoRequest : IMessage<ConsumptiveActivityInfoRequest>, IMessage, IEquatable<ConsumptiveActivityInfoRequest>, IDeepCloneable<ConsumptiveActivityInfoRequest>, IBufferMessage
	{
		// Token: 0x06004C08 RID: 19464 RVA: 0x000B9923 File Offset: 0x000B7B23
		[NullableContext(1)]
		public static ConsumptiveActivityInfoRequest Create()
		{
			return new ConsumptiveActivityInfoRequest();
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x000B992A File Offset: 0x000B7B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x000B992D File Offset: 0x000B7B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityInfoRequest.Descriptor;
			}
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x000B9934 File Offset: 0x000B7B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoRequest()
		{
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x000B993C File Offset: 0x000B7B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoRequest(ConsumptiveActivityInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x000B9955 File Offset: 0x000B7B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoRequest Clone()
		{
			return new ConsumptiveActivityInfoRequest(this);
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x000B995D File Offset: 0x000B7B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityInfoRequest);
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x000B996B File Offset: 0x000B7B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x000B998C File Offset: 0x000B7B8C
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

		// Token: 0x06004C11 RID: 19473 RVA: 0x000B99B2 File Offset: 0x000B7BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x000B99BF File Offset: 0x000B7BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x000B99C8 File Offset: 0x000B7BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x000B99E0 File Offset: 0x000B7BE0
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

		// Token: 0x06004C15 RID: 19477 RVA: 0x000B9A06 File Offset: 0x000B7C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x000B9A23 File Offset: 0x000B7C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x000B9A2C File Offset: 0x000B7C2C
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

		// Token: 0x0400313E RID: 12606
		private UnknownFieldSet _unknownFields;
	}
}
