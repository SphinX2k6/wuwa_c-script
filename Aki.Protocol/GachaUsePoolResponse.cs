using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A3 RID: 1699
	[NetMessage(EMessageId.GachaUsePoolResponse)]
	public sealed class GachaUsePoolResponse : IMessage<GachaUsePoolResponse>, IMessage, IEquatable<GachaUsePoolResponse>, IDeepCloneable<GachaUsePoolResponse>, IBufferMessage
	{
		// Token: 0x06009B78 RID: 39800 RVA: 0x00176FEF File Offset: 0x001751EF
		[NullableContext(1)]
		public static GachaUsePoolResponse Create()
		{
			return new GachaUsePoolResponse();
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06009B79 RID: 39801 RVA: 0x00176FF6 File Offset: 0x001751F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06009B7A RID: 39802 RVA: 0x00176FF9 File Offset: 0x001751F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaUsePoolResponse.Descriptor;
			}
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x00177000 File Offset: 0x00175200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolResponse()
		{
		}

		// Token: 0x06009B7C RID: 39804 RVA: 0x00177008 File Offset: 0x00175208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolResponse(GachaUsePoolResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B7D RID: 39805 RVA: 0x0017702D File Offset: 0x0017522D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolResponse Clone()
		{
			return new GachaUsePoolResponse(this);
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06009B7E RID: 39806 RVA: 0x00177035 File Offset: 0x00175235
		// (set) Token: 0x06009B7F RID: 39807 RVA: 0x0017703D File Offset: 0x0017523D
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

		// Token: 0x06009B80 RID: 39808 RVA: 0x00177046 File Offset: 0x00175246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaUsePoolResponse);
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x00177054 File Offset: 0x00175254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaUsePoolResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x00177084 File Offset: 0x00175284
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

		// Token: 0x06009B83 RID: 39811 RVA: 0x001770C9 File Offset: 0x001752C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x001770D6 File Offset: 0x001752D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x001770DF File Offset: 0x001752DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x00177114 File Offset: 0x00175314
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

		// Token: 0x06009B87 RID: 39815 RVA: 0x00177152 File Offset: 0x00175352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaUsePoolResponse other)
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

		// Token: 0x06009B88 RID: 39816 RVA: 0x00177183 File Offset: 0x00175383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x0017718C File Offset: 0x0017538C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004965 RID: 18789
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004966 RID: 18790
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004967 RID: 18791
		private ErrorCode errorCode_;
	}
}
