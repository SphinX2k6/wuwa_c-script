using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000974 RID: 2420
	[NetMessage(EMessageId.MailBindRewardRequest)]
	public sealed class MailBindRewardRequest : IMessage<MailBindRewardRequest>, IMessage, IEquatable<MailBindRewardRequest>, IDeepCloneable<MailBindRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D4F8 RID: 54520 RVA: 0x001F57F2 File Offset: 0x001F39F2
		[NullableContext(1)]
		public static MailBindRewardRequest Create()
		{
			return new MailBindRewardRequest();
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600D4F9 RID: 54521 RVA: 0x001F57F9 File Offset: 0x001F39F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x0600D4FA RID: 54522 RVA: 0x001F57FC File Offset: 0x001F39FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D4FB RID: 54523 RVA: 0x001F5803 File Offset: 0x001F3A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardRequest()
		{
		}

		// Token: 0x0600D4FC RID: 54524 RVA: 0x001F580B File Offset: 0x001F3A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardRequest(MailBindRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4FD RID: 54525 RVA: 0x001F5824 File Offset: 0x001F3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardRequest Clone()
		{
			return new MailBindRewardRequest(this);
		}

		// Token: 0x0600D4FE RID: 54526 RVA: 0x001F582C File Offset: 0x001F3A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindRewardRequest);
		}

		// Token: 0x0600D4FF RID: 54527 RVA: 0x001F583A File Offset: 0x001F3A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D500 RID: 54528 RVA: 0x001F5858 File Offset: 0x001F3A58
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

		// Token: 0x0600D501 RID: 54529 RVA: 0x001F587E File Offset: 0x001F3A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D502 RID: 54530 RVA: 0x001F588B File Offset: 0x001F3A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D503 RID: 54531 RVA: 0x001F5894 File Offset: 0x001F3A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D504 RID: 54532 RVA: 0x001F58AC File Offset: 0x001F3AAC
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

		// Token: 0x0600D505 RID: 54533 RVA: 0x001F58D2 File Offset: 0x001F3AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D506 RID: 54534 RVA: 0x001F58EF File Offset: 0x001F3AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D507 RID: 54535 RVA: 0x001F58F8 File Offset: 0x001F3AF8
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

		// Token: 0x0400593C RID: 22844
		private UnknownFieldSet _unknownFields;
	}
}
