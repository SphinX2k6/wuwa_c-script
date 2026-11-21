using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000245 RID: 581
	[NetMessage(EMessageId.CdKeyVerifyRequest)]
	public sealed class CdKeyVerifyRequest : IMessage<CdKeyVerifyRequest>, IMessage, IEquatable<CdKeyVerifyRequest>, IDeepCloneable<CdKeyVerifyRequest>, IBufferMessage
	{
		// Token: 0x06003E8E RID: 16014 RVA: 0x0009ADC5 File Offset: 0x00098FC5
		[NullableContext(1)]
		public static CdKeyVerifyRequest Create()
		{
			return new CdKeyVerifyRequest();
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x0009ADCC File Offset: 0x00098FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06003E90 RID: 16016 RVA: 0x0009ADCF File Offset: 0x00098FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CdKeyVerifyRequest.Descriptor;
			}
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x0009ADD6 File Offset: 0x00098FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyRequest()
		{
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x0009ADE9 File Offset: 0x00098FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyRequest(CdKeyVerifyRequest other) : this()
		{
			this.cdKey_ = other.cdKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x0009AE0E File Offset: 0x0009900E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyRequest Clone()
		{
			return new CdKeyVerifyRequest(this);
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06003E94 RID: 16020 RVA: 0x0009AE16 File Offset: 0x00099016
		// (set) Token: 0x06003E95 RID: 16021 RVA: 0x0009AE1E File Offset: 0x0009901E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CdKey
		{
			get
			{
				return this.cdKey_;
			}
			set
			{
				this.cdKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x0009AE31 File Offset: 0x00099031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CdKeyVerifyRequest);
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x0009AE3F File Offset: 0x0009903F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CdKeyVerifyRequest other)
		{
			return other != null && (other == this || (!(this.CdKey != other.CdKey) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x0009AE74 File Offset: 0x00099074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CdKey.Length != 0)
			{
				num ^= this.CdKey.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x0009AEB5 File Offset: 0x000990B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x0009AEC2 File Offset: 0x000990C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x0009AECB File Offset: 0x000990CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CdKey.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.CdKey);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x0009AF04 File Offset: 0x00099104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CdKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CdKey);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x0009AF47 File Offset: 0x00099147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CdKeyVerifyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CdKey.Length != 0)
			{
				this.CdKey = other.CdKey;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x0009AF7D File Offset: 0x0009917D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x0009AF88 File Offset: 0x00099188
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CdKey = input.ReadString();
				}
			}
		}

		// Token: 0x04002D48 RID: 11592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D49 RID: 11593
		public const int CdKeyFieldNumber = 1;

		// Token: 0x04002D4A RID: 11594
		private string cdKey_ = "";
	}
}
