using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000335 RID: 821
	[NetMessage(EMessageId.DangoBrawlBagOperateResponse)]
	public sealed class DangoBrawlBagOperateResponse : IMessage<DangoBrawlBagOperateResponse>, IMessage, IEquatable<DangoBrawlBagOperateResponse>, IDeepCloneable<DangoBrawlBagOperateResponse>, IBufferMessage
	{
		// Token: 0x06005279 RID: 21113 RVA: 0x000C960D File Offset: 0x000C780D
		[NullableContext(1)]
		public static DangoBrawlBagOperateResponse Create()
		{
			return new DangoBrawlBagOperateResponse();
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x000C9614 File Offset: 0x000C7814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x000C9617 File Offset: 0x000C7817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagOperateResponse.Descriptor;
			}
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x000C961E File Offset: 0x000C781E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateResponse()
		{
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x000C9626 File Offset: 0x000C7826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateResponse(DangoBrawlBagOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x000C964B File Offset: 0x000C784B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateResponse Clone()
		{
			return new DangoBrawlBagOperateResponse(this);
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600527F RID: 21119 RVA: 0x000C9653 File Offset: 0x000C7853
		// (set) Token: 0x06005280 RID: 21120 RVA: 0x000C965B File Offset: 0x000C785B
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

		// Token: 0x06005281 RID: 21121 RVA: 0x000C9664 File Offset: 0x000C7864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagOperateResponse);
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x000C9672 File Offset: 0x000C7872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x000C96A0 File Offset: 0x000C78A0
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

		// Token: 0x06005284 RID: 21124 RVA: 0x000C96E5 File Offset: 0x000C78E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x000C96F2 File Offset: 0x000C78F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x000C96FB File Offset: 0x000C78FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x000C9730 File Offset: 0x000C7930
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

		// Token: 0x06005288 RID: 21128 RVA: 0x000C976E File Offset: 0x000C796E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBagOperateResponse other)
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

		// Token: 0x06005289 RID: 21129 RVA: 0x000C979F File Offset: 0x000C799F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x000C97A8 File Offset: 0x000C79A8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003337 RID: 13111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003338 RID: 13112
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04003339 RID: 13113
		private ErrorCode errorCode_;
	}
}
