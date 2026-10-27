using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D9 RID: 2009
	[NetMessage(EMessageId.InfrFireNoticeRequest)]
	public sealed class InfrFireNoticeRequest : IMessage<InfrFireNoticeRequest>, IMessage, IEquatable<InfrFireNoticeRequest>, IDeepCloneable<InfrFireNoticeRequest>, IBufferMessage
	{
		// Token: 0x0600B476 RID: 46198 RVA: 0x001AF773 File Offset: 0x001AD973
		[NullableContext(1)]
		public static InfrFireNoticeRequest Create()
		{
			return new InfrFireNoticeRequest();
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x0600B477 RID: 46199 RVA: 0x001AF77A File Offset: 0x001AD97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x0600B478 RID: 46200 RVA: 0x001AF77D File Offset: 0x001AD97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFireNoticeRequest.Descriptor;
			}
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x001AF784 File Offset: 0x001AD984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeRequest()
		{
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x001AF78C File Offset: 0x001AD98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeRequest(InfrFireNoticeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x001AF7A5 File Offset: 0x001AD9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeRequest Clone()
		{
			return new InfrFireNoticeRequest(this);
		}

		// Token: 0x0600B47C RID: 46204 RVA: 0x001AF7AD File Offset: 0x001AD9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFireNoticeRequest);
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x001AF7BB File Offset: 0x001AD9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFireNoticeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x001AF7DC File Offset: 0x001AD9DC
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

		// Token: 0x0600B47F RID: 46207 RVA: 0x001AF802 File Offset: 0x001ADA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B480 RID: 46208 RVA: 0x001AF80F File Offset: 0x001ADA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x001AF818 File Offset: 0x001ADA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x001AF830 File Offset: 0x001ADA30
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

		// Token: 0x0600B483 RID: 46211 RVA: 0x001AF856 File Offset: 0x001ADA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrFireNoticeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x001AF873 File Offset: 0x001ADA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x001AF87C File Offset: 0x001ADA7C
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

		// Token: 0x0400504D RID: 20557
		private UnknownFieldSet _unknownFields;
	}
}
