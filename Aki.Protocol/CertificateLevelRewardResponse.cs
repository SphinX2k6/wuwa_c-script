using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000248 RID: 584
	[NetMessage(EMessageId.CertificateLevelRewardResponse)]
	public sealed class CertificateLevelRewardResponse : IMessage<CertificateLevelRewardResponse>, IMessage, IEquatable<CertificateLevelRewardResponse>, IDeepCloneable<CertificateLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x06003EC2 RID: 16066 RVA: 0x0009B2E6 File Offset: 0x000994E6
		[NullableContext(1)]
		public static CertificateLevelRewardResponse Create()
		{
			return new CertificateLevelRewardResponse();
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06003EC3 RID: 16067 RVA: 0x0009B2ED File Offset: 0x000994ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x0009B2F0 File Offset: 0x000994F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CertificateLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0009B2F7 File Offset: 0x000994F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardResponse()
		{
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x0009B2FF File Offset: 0x000994FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardResponse(CertificateLevelRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0009B324 File Offset: 0x00099524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardResponse Clone()
		{
			return new CertificateLevelRewardResponse(this);
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x0009B32C File Offset: 0x0009952C
		// (set) Token: 0x06003EC9 RID: 16073 RVA: 0x0009B334 File Offset: 0x00099534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0009B33D File Offset: 0x0009953D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CertificateLevelRewardResponse);
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x0009B34B File Offset: 0x0009954B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CertificateLevelRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0009B37C File Offset: 0x0009957C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0009B3C1 File Offset: 0x000995C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x0009B3CE File Offset: 0x000995CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0009B3D7 File Offset: 0x000995D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x0009B40C File Offset: 0x0009960C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0009B44A File Offset: 0x0009964A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CertificateLevelRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0009B47B File Offset: 0x0009967B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0009B484 File Offset: 0x00099684
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D4F RID: 11599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D50 RID: 11600
		public const int CodeFieldNumber = 2;

		// Token: 0x04002D51 RID: 11601
		private ErrorCode code_;
	}
}
