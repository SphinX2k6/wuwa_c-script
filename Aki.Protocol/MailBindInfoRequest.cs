using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095F RID: 2399
	[NetMessage(EMessageId.MailBindInfoRequest)]
	public sealed class MailBindInfoRequest : IMessage<MailBindInfoRequest>, IMessage, IEquatable<MailBindInfoRequest>, IDeepCloneable<MailBindInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D39C RID: 54172 RVA: 0x001F3038 File Offset: 0x001F1238
		[NullableContext(1)]
		public static MailBindInfoRequest Create()
		{
			return new MailBindInfoRequest();
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x0600D39D RID: 54173 RVA: 0x001F303F File Offset: 0x001F123F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x0600D39E RID: 54174 RVA: 0x001F3042 File Offset: 0x001F1242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D39F RID: 54175 RVA: 0x001F3049 File Offset: 0x001F1249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoRequest()
		{
		}

		// Token: 0x0600D3A0 RID: 54176 RVA: 0x001F3051 File Offset: 0x001F1251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoRequest(MailBindInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3A1 RID: 54177 RVA: 0x001F306A File Offset: 0x001F126A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoRequest Clone()
		{
			return new MailBindInfoRequest(this);
		}

		// Token: 0x0600D3A2 RID: 54178 RVA: 0x001F3072 File Offset: 0x001F1272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindInfoRequest);
		}

		// Token: 0x0600D3A3 RID: 54179 RVA: 0x001F3080 File Offset: 0x001F1280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D3A4 RID: 54180 RVA: 0x001F30A0 File Offset: 0x001F12A0
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

		// Token: 0x0600D3A5 RID: 54181 RVA: 0x001F30C6 File Offset: 0x001F12C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3A6 RID: 54182 RVA: 0x001F30D3 File Offset: 0x001F12D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3A7 RID: 54183 RVA: 0x001F30DC File Offset: 0x001F12DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3A8 RID: 54184 RVA: 0x001F30F4 File Offset: 0x001F12F4
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

		// Token: 0x0600D3A9 RID: 54185 RVA: 0x001F311A File Offset: 0x001F131A
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

		// Token: 0x0600D3AA RID: 54186 RVA: 0x001F3137 File Offset: 0x001F1337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3AB RID: 54187 RVA: 0x001F3140 File Offset: 0x001F1340
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

		// Token: 0x0400593F RID: 22847
		private UnknownFieldSet _unknownFields;
	}
}
