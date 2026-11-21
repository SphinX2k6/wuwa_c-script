using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000961 RID: 2401
	[NetMessage(EMessageId.MailBindRequest)]
	public sealed class MailBindRequest : IMessage<MailBindRequest>, IMessage, IEquatable<MailBindRequest>, IDeepCloneable<MailBindRequest>, IBufferMessage
	{
		// Token: 0x0600D3BE RID: 54206 RVA: 0x001F3398 File Offset: 0x001F1598
		[NullableContext(1)]
		public static MailBindRequest Create()
		{
			return new MailBindRequest();
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x0600D3BF RID: 54207 RVA: 0x001F339F File Offset: 0x001F159F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x0600D3C0 RID: 54208 RVA: 0x001F33A2 File Offset: 0x001F15A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindRequest.Descriptor;
			}
		}

		// Token: 0x0600D3C1 RID: 54209 RVA: 0x001F33A9 File Offset: 0x001F15A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRequest()
		{
		}

		// Token: 0x0600D3C2 RID: 54210 RVA: 0x001F33B1 File Offset: 0x001F15B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRequest(MailBindRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3C3 RID: 54211 RVA: 0x001F33CA File Offset: 0x001F15CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRequest Clone()
		{
			return new MailBindRequest(this);
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x001F33D2 File Offset: 0x001F15D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindRequest);
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x001F33E0 File Offset: 0x001F15E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D3C6 RID: 54214 RVA: 0x001F3400 File Offset: 0x001F1600
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

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x001F3426 File Offset: 0x001F1626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3C8 RID: 54216 RVA: 0x001F3433 File Offset: 0x001F1633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3C9 RID: 54217 RVA: 0x001F343C File Offset: 0x001F163C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3CA RID: 54218 RVA: 0x001F3454 File Offset: 0x001F1654
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

		// Token: 0x0600D3CB RID: 54219 RVA: 0x001F347A File Offset: 0x001F167A
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

		// Token: 0x0600D3CC RID: 54220 RVA: 0x001F3497 File Offset: 0x001F1697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3CD RID: 54221 RVA: 0x001F34A0 File Offset: 0x001F16A0
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

		// Token: 0x04005943 RID: 22851
		private UnknownFieldSet _unknownFields;
	}
}
