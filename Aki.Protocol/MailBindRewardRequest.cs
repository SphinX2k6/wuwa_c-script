using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000963 RID: 2403
	[NetMessage(EMessageId.MailBindRewardRequest)]
	public sealed class MailBindRewardRequest : IMessage<MailBindRewardRequest>, IMessage, IEquatable<MailBindRewardRequest>, IDeepCloneable<MailBindRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D3DE RID: 54238 RVA: 0x001F360A File Offset: 0x001F180A
		[NullableContext(1)]
		public static MailBindRewardRequest Create()
		{
			return new MailBindRewardRequest();
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0600D3DF RID: 54239 RVA: 0x001F3611 File Offset: 0x001F1811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0600D3E0 RID: 54240 RVA: 0x001F3614 File Offset: 0x001F1814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D3E1 RID: 54241 RVA: 0x001F361B File Offset: 0x001F181B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardRequest()
		{
		}

		// Token: 0x0600D3E2 RID: 54242 RVA: 0x001F3623 File Offset: 0x001F1823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardRequest(MailBindRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3E3 RID: 54243 RVA: 0x001F363C File Offset: 0x001F183C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardRequest Clone()
		{
			return new MailBindRewardRequest(this);
		}

		// Token: 0x0600D3E4 RID: 54244 RVA: 0x001F3644 File Offset: 0x001F1844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindRewardRequest);
		}

		// Token: 0x0600D3E5 RID: 54245 RVA: 0x001F3652 File Offset: 0x001F1852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D3E6 RID: 54246 RVA: 0x001F3670 File Offset: 0x001F1870
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

		// Token: 0x0600D3E7 RID: 54247 RVA: 0x001F3696 File Offset: 0x001F1896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3E8 RID: 54248 RVA: 0x001F36A3 File Offset: 0x001F18A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3E9 RID: 54249 RVA: 0x001F36AC File Offset: 0x001F18AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3EA RID: 54250 RVA: 0x001F36C4 File Offset: 0x001F18C4
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

		// Token: 0x0600D3EB RID: 54251 RVA: 0x001F36EA File Offset: 0x001F18EA
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

		// Token: 0x0600D3EC RID: 54252 RVA: 0x001F3707 File Offset: 0x001F1907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3ED RID: 54253 RVA: 0x001F3710 File Offset: 0x001F1910
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

		// Token: 0x04005945 RID: 22853
		private UnknownFieldSet _unknownFields;
	}
}
