using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000247 RID: 583
	[NetMessage(EMessageId.CertificateLevelRewardRequest)]
	public sealed class CertificateLevelRewardRequest : IMessage<CertificateLevelRewardRequest>, IMessage, IEquatable<CertificateLevelRewardRequest>, IDeepCloneable<CertificateLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x06003EB2 RID: 16050 RVA: 0x0009B1AD File Offset: 0x000993AD
		[NullableContext(1)]
		public static CertificateLevelRewardRequest Create()
		{
			return new CertificateLevelRewardRequest();
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x0009B1B4 File Offset: 0x000993B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06003EB4 RID: 16052 RVA: 0x0009B1B7 File Offset: 0x000993B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CertificateLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0009B1BE File Offset: 0x000993BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardRequest()
		{
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0009B1C6 File Offset: 0x000993C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardRequest(CertificateLevelRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0009B1DF File Offset: 0x000993DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardRequest Clone()
		{
			return new CertificateLevelRewardRequest(this);
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x0009B1E7 File Offset: 0x000993E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CertificateLevelRewardRequest);
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0009B1F5 File Offset: 0x000993F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CertificateLevelRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0009B214 File Offset: 0x00099414
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

		// Token: 0x06003EBB RID: 16059 RVA: 0x0009B23A File Offset: 0x0009943A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x0009B247 File Offset: 0x00099447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x0009B250 File Offset: 0x00099450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x0009B268 File Offset: 0x00099468
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

		// Token: 0x06003EBF RID: 16063 RVA: 0x0009B28E File Offset: 0x0009948E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CertificateLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0009B2AB File Offset: 0x000994AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x0009B2B4 File Offset: 0x000994B4
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

		// Token: 0x04002D4E RID: 11598
		private UnknownFieldSet _unknownFields;
	}
}
