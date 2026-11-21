using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CB RID: 1227
	[NetMessage(EMessageId.ExchangeRewardInfoRequest)]
	public sealed class ExchangeRewardInfoRequest : IMessage<ExchangeRewardInfoRequest>, IMessage, IEquatable<ExchangeRewardInfoRequest>, IDeepCloneable<ExchangeRewardInfoRequest>, IBufferMessage
	{
		// Token: 0x060074EA RID: 29930 RVA: 0x0011E9C4 File Offset: 0x0011CBC4
		[NullableContext(1)]
		public static ExchangeRewardInfoRequest Create()
		{
			return new ExchangeRewardInfoRequest();
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x0011E9CB File Offset: 0x0011CBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x060074EC RID: 29932 RVA: 0x0011E9CE File Offset: 0x0011CBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRewardInfoRequest.Descriptor;
			}
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x0011E9D5 File Offset: 0x0011CBD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoRequest()
		{
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x0011E9DD File Offset: 0x0011CBDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoRequest(ExchangeRewardInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x0011E9F6 File Offset: 0x0011CBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoRequest Clone()
		{
			return new ExchangeRewardInfoRequest(this);
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x0011E9FE File Offset: 0x0011CBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRewardInfoRequest);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x0011EA0C File Offset: 0x0011CC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRewardInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x0011EA2C File Offset: 0x0011CC2C
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

		// Token: 0x060074F3 RID: 29939 RVA: 0x0011EA52 File Offset: 0x0011CC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x0011EA5F File Offset: 0x0011CC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x0011EA68 File Offset: 0x0011CC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x0011EA80 File Offset: 0x0011CC80
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

		// Token: 0x060074F7 RID: 29943 RVA: 0x0011EAA6 File Offset: 0x0011CCA6
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

		// Token: 0x060074F8 RID: 29944 RVA: 0x0011EAC3 File Offset: 0x0011CCC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x0011EACC File Offset: 0x0011CCCC
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

		// Token: 0x04003DE5 RID: 15845
		private UnknownFieldSet _unknownFields;
	}
}
