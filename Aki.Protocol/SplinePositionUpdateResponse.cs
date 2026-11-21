using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E0 RID: 4832
	[NetMessage(EMessageId.SplinePositionUpdateResponse)]
	public sealed class SplinePositionUpdateResponse : IMessage<SplinePositionUpdateResponse>, IMessage, IEquatable<SplinePositionUpdateResponse>, IDeepCloneable<SplinePositionUpdateResponse>, IBufferMessage
	{
		// Token: 0x06019C9A RID: 105626 RVA: 0x003C30C9 File Offset: 0x003C12C9
		[NullableContext(1)]
		public static SplinePositionUpdateResponse Create()
		{
			return new SplinePositionUpdateResponse();
		}

		// Token: 0x17005756 RID: 22358
		// (get) Token: 0x06019C9B RID: 105627 RVA: 0x003C30D0 File Offset: 0x003C12D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005757 RID: 22359
		// (get) Token: 0x06019C9C RID: 105628 RVA: 0x003C30D3 File Offset: 0x003C12D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplinePositionUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06019C9D RID: 105629 RVA: 0x003C30DA File Offset: 0x003C12DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateResponse()
		{
		}

		// Token: 0x06019C9E RID: 105630 RVA: 0x003C30E2 File Offset: 0x003C12E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateResponse(SplinePositionUpdateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C9F RID: 105631 RVA: 0x003C3107 File Offset: 0x003C1307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateResponse Clone()
		{
			return new SplinePositionUpdateResponse(this);
		}

		// Token: 0x17005758 RID: 22360
		// (get) Token: 0x06019CA0 RID: 105632 RVA: 0x003C310F File Offset: 0x003C130F
		// (set) Token: 0x06019CA1 RID: 105633 RVA: 0x003C3117 File Offset: 0x003C1317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06019CA2 RID: 105634 RVA: 0x003C3120 File Offset: 0x003C1320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplinePositionUpdateResponse);
		}

		// Token: 0x06019CA3 RID: 105635 RVA: 0x003C312E File Offset: 0x003C132E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplinePositionUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019CA4 RID: 105636 RVA: 0x003C315C File Offset: 0x003C135C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019CA5 RID: 105637 RVA: 0x003C31A1 File Offset: 0x003C13A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CA6 RID: 105638 RVA: 0x003C31AE File Offset: 0x003C13AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CA7 RID: 105639 RVA: 0x003C31B7 File Offset: 0x003C13B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019CA8 RID: 105640 RVA: 0x003C31EC File Offset: 0x003C13EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019CA9 RID: 105641 RVA: 0x003C322A File Offset: 0x003C142A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplinePositionUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019CAA RID: 105642 RVA: 0x003C325B File Offset: 0x003C145B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CAB RID: 105643 RVA: 0x003C3264 File Offset: 0x003C1464
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009833 RID: 38963
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009834 RID: 38964
		public const int ErrCodeFieldNumber = 9;

		// Token: 0x04009835 RID: 38965
		private ErrorCode errCode_;
	}
}
