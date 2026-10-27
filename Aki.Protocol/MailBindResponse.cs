using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000973 RID: 2419
	[NetMessage(EMessageId.MailBindResponse)]
	public sealed class MailBindResponse : IMessage<MailBindResponse>, IMessage, IEquatable<MailBindResponse>, IDeepCloneable<MailBindResponse>, IBufferMessage
	{
		// Token: 0x0600D4E8 RID: 54504 RVA: 0x001F56BA File Offset: 0x001F38BA
		[NullableContext(1)]
		public static MailBindResponse Create()
		{
			return new MailBindResponse();
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0600D4E9 RID: 54505 RVA: 0x001F56C1 File Offset: 0x001F38C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600D4EA RID: 54506 RVA: 0x001F56C4 File Offset: 0x001F38C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindResponse.Descriptor;
			}
		}

		// Token: 0x0600D4EB RID: 54507 RVA: 0x001F56CB File Offset: 0x001F38CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindResponse()
		{
		}

		// Token: 0x0600D4EC RID: 54508 RVA: 0x001F56D3 File Offset: 0x001F38D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindResponse(MailBindResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4ED RID: 54509 RVA: 0x001F56EC File Offset: 0x001F38EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindResponse Clone()
		{
			return new MailBindResponse(this);
		}

		// Token: 0x0600D4EE RID: 54510 RVA: 0x001F56F4 File Offset: 0x001F38F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindResponse);
		}

		// Token: 0x0600D4EF RID: 54511 RVA: 0x001F5702 File Offset: 0x001F3902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D4F0 RID: 54512 RVA: 0x001F5720 File Offset: 0x001F3920
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

		// Token: 0x0600D4F1 RID: 54513 RVA: 0x001F5746 File Offset: 0x001F3946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4F2 RID: 54514 RVA: 0x001F5753 File Offset: 0x001F3953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4F3 RID: 54515 RVA: 0x001F575C File Offset: 0x001F395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4F4 RID: 54516 RVA: 0x001F5774 File Offset: 0x001F3974
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

		// Token: 0x0600D4F5 RID: 54517 RVA: 0x001F579A File Offset: 0x001F399A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4F6 RID: 54518 RVA: 0x001F57B7 File Offset: 0x001F39B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4F7 RID: 54519 RVA: 0x001F57C0 File Offset: 0x001F39C0
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

		// Token: 0x0400593B RID: 22843
		private UnknownFieldSet _unknownFields;
	}
}
