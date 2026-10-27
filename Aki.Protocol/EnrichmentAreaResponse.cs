using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044A RID: 1098
	[NetMessage(EMessageId.EnrichmentAreaResponse)]
	public sealed class EnrichmentAreaResponse : IMessage<EnrichmentAreaResponse>, IMessage, IEquatable<EnrichmentAreaResponse>, IDeepCloneable<EnrichmentAreaResponse>, IBufferMessage
	{
		// Token: 0x060068F7 RID: 26871 RVA: 0x000FBF85 File Offset: 0x000FA185
		[NullableContext(1)]
		public static EnrichmentAreaResponse Create()
		{
			return new EnrichmentAreaResponse();
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x060068F8 RID: 26872 RVA: 0x000FBF8C File Offset: 0x000FA18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x060068F9 RID: 26873 RVA: 0x000FBF8F File Offset: 0x000FA18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnrichmentAreaResponse.Descriptor;
			}
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x000FBF96 File Offset: 0x000FA196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaResponse()
		{
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x000FBF9E File Offset: 0x000FA19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaResponse(EnrichmentAreaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x000FBFC3 File Offset: 0x000FA1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaResponse Clone()
		{
			return new EnrichmentAreaResponse(this);
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x060068FD RID: 26877 RVA: 0x000FBFCB File Offset: 0x000FA1CB
		// (set) Token: 0x060068FE RID: 26878 RVA: 0x000FBFD3 File Offset: 0x000FA1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x000FBFDC File Offset: 0x000FA1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnrichmentAreaResponse);
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x000FBFEA File Offset: 0x000FA1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnrichmentAreaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x000FC018 File Offset: 0x000FA218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x000FC05D File Offset: 0x000FA25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x000FC06A File Offset: 0x000FA26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x000FC073 File Offset: 0x000FA273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x000FC0A8 File Offset: 0x000FA2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x000FC0E6 File Offset: 0x000FA2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnrichmentAreaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x000FC117 File Offset: 0x000FA317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x000FC120 File Offset: 0x000FA320
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040039D9 RID: 14809
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039DA RID: 14810
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040039DB RID: 14811
		private ErrorCode errorCode_;
	}
}
