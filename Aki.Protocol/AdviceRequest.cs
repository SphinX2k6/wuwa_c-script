using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CE RID: 206
	[NetMessage(EMessageId.AdviceRequest)]
	public sealed class AdviceRequest : IMessage<AdviceRequest>, IMessage, IEquatable<AdviceRequest>, IDeepCloneable<AdviceRequest>, IBufferMessage
	{
		// Token: 0x06002010 RID: 8208 RVA: 0x00056FE5 File Offset: 0x000551E5
		[NullableContext(1)]
		public static AdviceRequest Create()
		{
			return new AdviceRequest();
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x00056FEC File Offset: 0x000551EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x00056FEF File Offset: 0x000551EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceRequest.Descriptor;
			}
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00056FF6 File Offset: 0x000551F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceRequest()
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00056FFE File Offset: 0x000551FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceRequest(AdviceRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00057017 File Offset: 0x00055217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceRequest Clone()
		{
			return new AdviceRequest(this);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0005701F File Offset: 0x0005521F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceRequest);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0005702D File Offset: 0x0005522D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0005704C File Offset: 0x0005524C
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

		// Token: 0x06002019 RID: 8217 RVA: 0x00057072 File Offset: 0x00055272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0005707F File Offset: 0x0005527F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00057088 File Offset: 0x00055288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000570A0 File Offset: 0x000552A0
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

		// Token: 0x0600201D RID: 8221 RVA: 0x000570C6 File Offset: 0x000552C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000570E3 File Offset: 0x000552E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000570EC File Offset: 0x000552EC
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

		// Token: 0x04002432 RID: 9266
		private UnknownFieldSet _unknownFields;
	}
}
