using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000712 RID: 1810
	[NetMessage(EMessageId.GuideInfoRequest)]
	public sealed class GuideInfoRequest : IMessage<GuideInfoRequest>, IMessage, IEquatable<GuideInfoRequest>, IDeepCloneable<GuideInfoRequest>, IBufferMessage
	{
		// Token: 0x0600A4E4 RID: 42212 RVA: 0x0018E2F9 File Offset: 0x0018C4F9
		[NullableContext(1)]
		public static GuideInfoRequest Create()
		{
			return new GuideInfoRequest();
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x0600A4E5 RID: 42213 RVA: 0x0018E300 File Offset: 0x0018C500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x0600A4E6 RID: 42214 RVA: 0x0018E303 File Offset: 0x0018C503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x0018E30A File Offset: 0x0018C50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoRequest()
		{
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x0018E312 File Offset: 0x0018C512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoRequest(GuideInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x0018E32B File Offset: 0x0018C52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoRequest Clone()
		{
			return new GuideInfoRequest(this);
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x0018E333 File Offset: 0x0018C533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideInfoRequest);
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x0018E341 File Offset: 0x0018C541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A4EC RID: 42220 RVA: 0x0018E360 File Offset: 0x0018C560
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

		// Token: 0x0600A4ED RID: 42221 RVA: 0x0018E386 File Offset: 0x0018C586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4EE RID: 42222 RVA: 0x0018E393 File Offset: 0x0018C593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4EF RID: 42223 RVA: 0x0018E39C File Offset: 0x0018C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4F0 RID: 42224 RVA: 0x0018E3B4 File Offset: 0x0018C5B4
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

		// Token: 0x0600A4F1 RID: 42225 RVA: 0x0018E3DA File Offset: 0x0018C5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x0018E3F7 File Offset: 0x0018C5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x0018E400 File Offset: 0x0018C600
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

		// Token: 0x04004C46 RID: 19526
		private UnknownFieldSet _unknownFields;
	}
}
