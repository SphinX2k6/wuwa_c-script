using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000970 RID: 2416
	[NetMessage(EMessageId.MailBindInfoRequest)]
	public sealed class MailBindInfoRequest : IMessage<MailBindInfoRequest>, IMessage, IEquatable<MailBindInfoRequest>, IDeepCloneable<MailBindInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D4B6 RID: 54454 RVA: 0x001F5220 File Offset: 0x001F3420
		[NullableContext(1)]
		public static MailBindInfoRequest Create()
		{
			return new MailBindInfoRequest();
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0600D4B7 RID: 54455 RVA: 0x001F5227 File Offset: 0x001F3427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x0600D4B8 RID: 54456 RVA: 0x001F522A File Offset: 0x001F342A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D4B9 RID: 54457 RVA: 0x001F5231 File Offset: 0x001F3431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoRequest()
		{
		}

		// Token: 0x0600D4BA RID: 54458 RVA: 0x001F5239 File Offset: 0x001F3439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoRequest(MailBindInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4BB RID: 54459 RVA: 0x001F5252 File Offset: 0x001F3452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoRequest Clone()
		{
			return new MailBindInfoRequest(this);
		}

		// Token: 0x0600D4BC RID: 54460 RVA: 0x001F525A File Offset: 0x001F345A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindInfoRequest);
		}

		// Token: 0x0600D4BD RID: 54461 RVA: 0x001F5268 File Offset: 0x001F3468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D4BE RID: 54462 RVA: 0x001F5288 File Offset: 0x001F3488
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

		// Token: 0x0600D4BF RID: 54463 RVA: 0x001F52AE File Offset: 0x001F34AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4C0 RID: 54464 RVA: 0x001F52BB File Offset: 0x001F34BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4C1 RID: 54465 RVA: 0x001F52C4 File Offset: 0x001F34C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4C2 RID: 54466 RVA: 0x001F52DC File Offset: 0x001F34DC
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

		// Token: 0x0600D4C3 RID: 54467 RVA: 0x001F5302 File Offset: 0x001F3502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4C4 RID: 54468 RVA: 0x001F531F File Offset: 0x001F351F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x001F5328 File Offset: 0x001F3528
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

		// Token: 0x04005936 RID: 22838
		private UnknownFieldSet _unknownFields;
	}
}
