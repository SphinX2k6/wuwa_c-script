using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E1 RID: 1249
	[NetMessage(EMessageId.ExchangeRewardInfoRequest)]
	public sealed class ExchangeRewardInfoRequest : IMessage<ExchangeRewardInfoRequest>, IMessage, IEquatable<ExchangeRewardInfoRequest>, IDeepCloneable<ExchangeRewardInfoRequest>, IBufferMessage
	{
		// Token: 0x06007666 RID: 30310 RVA: 0x00121848 File Offset: 0x0011FA48
		[NullableContext(1)]
		public static ExchangeRewardInfoRequest Create()
		{
			return new ExchangeRewardInfoRequest();
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06007667 RID: 30311 RVA: 0x0012184F File Offset: 0x0011FA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x00121852 File Offset: 0x0011FA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRewardInfoRequest.Descriptor;
			}
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x00121859 File Offset: 0x0011FA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoRequest()
		{
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00121861 File Offset: 0x0011FA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoRequest(ExchangeRewardInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x0012187A File Offset: 0x0011FA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoRequest Clone()
		{
			return new ExchangeRewardInfoRequest(this);
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00121882 File Offset: 0x0011FA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRewardInfoRequest);
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00121890 File Offset: 0x0011FA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRewardInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x001218B0 File Offset: 0x0011FAB0
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

		// Token: 0x0600766F RID: 30319 RVA: 0x001218D6 File Offset: 0x0011FAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x001218E3 File Offset: 0x0011FAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x001218EC File Offset: 0x0011FAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x00121904 File Offset: 0x0011FB04
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

		// Token: 0x06007673 RID: 30323 RVA: 0x0012192A File Offset: 0x0011FB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeRewardInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00121947 File Offset: 0x0011FB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x00121950 File Offset: 0x0011FB50
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

		// Token: 0x04003DF4 RID: 15860
		private UnknownFieldSet _unknownFields;
	}
}
