using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000972 RID: 2418
	[NetMessage(EMessageId.MailBindRequest)]
	public sealed class MailBindRequest : IMessage<MailBindRequest>, IMessage, IEquatable<MailBindRequest>, IDeepCloneable<MailBindRequest>, IBufferMessage
	{
		// Token: 0x0600D4D8 RID: 54488 RVA: 0x001F5580 File Offset: 0x001F3780
		[NullableContext(1)]
		public static MailBindRequest Create()
		{
			return new MailBindRequest();
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0600D4D9 RID: 54489 RVA: 0x001F5587 File Offset: 0x001F3787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x0600D4DA RID: 54490 RVA: 0x001F558A File Offset: 0x001F378A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindRequest.Descriptor;
			}
		}

		// Token: 0x0600D4DB RID: 54491 RVA: 0x001F5591 File Offset: 0x001F3791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRequest()
		{
		}

		// Token: 0x0600D4DC RID: 54492 RVA: 0x001F5599 File Offset: 0x001F3799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRequest(MailBindRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4DD RID: 54493 RVA: 0x001F55B2 File Offset: 0x001F37B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRequest Clone()
		{
			return new MailBindRequest(this);
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x001F55BA File Offset: 0x001F37BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindRequest);
		}

		// Token: 0x0600D4DF RID: 54495 RVA: 0x001F55C8 File Offset: 0x001F37C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D4E0 RID: 54496 RVA: 0x001F55E8 File Offset: 0x001F37E8
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

		// Token: 0x0600D4E1 RID: 54497 RVA: 0x001F560E File Offset: 0x001F380E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4E2 RID: 54498 RVA: 0x001F561B File Offset: 0x001F381B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4E3 RID: 54499 RVA: 0x001F5624 File Offset: 0x001F3824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4E4 RID: 54500 RVA: 0x001F563C File Offset: 0x001F383C
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

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x001F5662 File Offset: 0x001F3862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x001F567F File Offset: 0x001F387F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4E7 RID: 54503 RVA: 0x001F5688 File Offset: 0x001F3888
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

		// Token: 0x0400593A RID: 22842
		private UnknownFieldSet _unknownFields;
	}
}
