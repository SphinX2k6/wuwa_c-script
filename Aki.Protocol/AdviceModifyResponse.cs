using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CC RID: 204
	[NetMessage(EMessageId.AdviceModifyResponse)]
	public sealed class AdviceModifyResponse : IMessage<AdviceModifyResponse>, IMessage, IEquatable<AdviceModifyResponse>, IDeepCloneable<AdviceModifyResponse>, IBufferMessage
	{
		// Token: 0x06001FB5 RID: 8117 RVA: 0x00056150 File Offset: 0x00054350
		[NullableContext(1)]
		public static AdviceModifyResponse Create()
		{
			return new AdviceModifyResponse();
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00056157 File Offset: 0x00054357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0005615A File Offset: 0x0005435A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceModifyResponse.Descriptor;
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00056161 File Offset: 0x00054361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyResponse()
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00056169 File Offset: 0x00054369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyResponse(AdviceModifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x0005618E File Offset: 0x0005438E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyResponse Clone()
		{
			return new AdviceModifyResponse(this);
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x00056196 File Offset: 0x00054396
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0005619E File Offset: 0x0005439E
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

		// Token: 0x06001FBD RID: 8125 RVA: 0x000561A7 File Offset: 0x000543A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceModifyResponse);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x000561B5 File Offset: 0x000543B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceModifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000561E4 File Offset: 0x000543E4
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

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00056229 File Offset: 0x00054429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00056236 File Offset: 0x00054436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0005623F File Offset: 0x0005443F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00056274 File Offset: 0x00054474
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

		// Token: 0x06001FC4 RID: 8132 RVA: 0x000562B2 File Offset: 0x000544B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceModifyResponse other)
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

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000562E3 File Offset: 0x000544E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000562EC File Offset: 0x000544EC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040023CC RID: 9164
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023CD RID: 9165
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040023CE RID: 9166
		private ErrorCode errorCode_;
	}
}
