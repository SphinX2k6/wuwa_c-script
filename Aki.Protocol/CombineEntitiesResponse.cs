using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BA RID: 698
	[NetMessage(EMessageId.CombineEntitiesResponse)]
	public sealed class CombineEntitiesResponse : IMessage<CombineEntitiesResponse>, IMessage, IEquatable<CombineEntitiesResponse>, IDeepCloneable<CombineEntitiesResponse>, IBufferMessage
	{
		// Token: 0x06004857 RID: 18519 RVA: 0x000B1E83 File Offset: 0x000B0083
		[NullableContext(1)]
		public static CombineEntitiesResponse Create()
		{
			return new CombineEntitiesResponse();
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x000B1E8A File Offset: 0x000B008A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x000B1E8D File Offset: 0x000B008D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombineEntitiesResponse.Descriptor;
			}
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x000B1E94 File Offset: 0x000B0094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesResponse()
		{
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x000B1E9C File Offset: 0x000B009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesResponse(CombineEntitiesResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x000B1EC1 File Offset: 0x000B00C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesResponse Clone()
		{
			return new CombineEntitiesResponse(this);
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x000B1EC9 File Offset: 0x000B00C9
		// (set) Token: 0x0600485E RID: 18526 RVA: 0x000B1ED1 File Offset: 0x000B00D1
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

		// Token: 0x0600485F RID: 18527 RVA: 0x000B1EDA File Offset: 0x000B00DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombineEntitiesResponse);
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x000B1EE8 File Offset: 0x000B00E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombineEntitiesResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x000B1F18 File Offset: 0x000B0118
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

		// Token: 0x06004862 RID: 18530 RVA: 0x000B1F5D File Offset: 0x000B015D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x000B1F6A File Offset: 0x000B016A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x000B1F73 File Offset: 0x000B0173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x000B1FA8 File Offset: 0x000B01A8
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

		// Token: 0x06004866 RID: 18534 RVA: 0x000B1FE6 File Offset: 0x000B01E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombineEntitiesResponse other)
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

		// Token: 0x06004867 RID: 18535 RVA: 0x000B2017 File Offset: 0x000B0217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x000B2020 File Offset: 0x000B0220
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400303E RID: 12350
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400303F RID: 12351
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04003040 RID: 12352
		private ErrorCode errorCode_;
	}
}
