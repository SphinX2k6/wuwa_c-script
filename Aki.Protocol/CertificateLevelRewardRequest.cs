using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000242 RID: 578
	[NetMessage(EMessageId.CertificateLevelRewardRequest)]
	public sealed class CertificateLevelRewardRequest : IMessage<CertificateLevelRewardRequest>, IMessage, IEquatable<CertificateLevelRewardRequest>, IDeepCloneable<CertificateLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x06003E0D RID: 15885 RVA: 0x00099591 File Offset: 0x00097791
		[NullableContext(1)]
		public static CertificateLevelRewardRequest Create()
		{
			return new CertificateLevelRewardRequest();
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x00099598 File Offset: 0x00097798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06003E0F RID: 15887 RVA: 0x0009959B File Offset: 0x0009779B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CertificateLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x000995A2 File Offset: 0x000977A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardRequest()
		{
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x000995AA File Offset: 0x000977AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardRequest(CertificateLevelRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x000995C3 File Offset: 0x000977C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardRequest Clone()
		{
			return new CertificateLevelRewardRequest(this);
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x000995CB File Offset: 0x000977CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CertificateLevelRewardRequest);
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x000995D9 File Offset: 0x000977D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CertificateLevelRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x000995F8 File Offset: 0x000977F8
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

		// Token: 0x06003E16 RID: 15894 RVA: 0x0009961E File Offset: 0x0009781E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0009962B File Offset: 0x0009782B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x00099634 File Offset: 0x00097834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x0009964C File Offset: 0x0009784C
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

		// Token: 0x06003E1A RID: 15898 RVA: 0x00099672 File Offset: 0x00097872
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

		// Token: 0x06003E1B RID: 15899 RVA: 0x0009968F File Offset: 0x0009788F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00099698 File Offset: 0x00097898
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

		// Token: 0x04002CCC RID: 11468
		private UnknownFieldSet _unknownFields;
	}
}
