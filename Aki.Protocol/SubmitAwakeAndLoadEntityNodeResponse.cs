using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A1 RID: 4769
	[NetMessage(EMessageId.SubmitAwakeAndLoadEntityNodeResponse)]
	public sealed class SubmitAwakeAndLoadEntityNodeResponse : IMessage<SubmitAwakeAndLoadEntityNodeResponse>, IMessage, IEquatable<SubmitAwakeAndLoadEntityNodeResponse>, IDeepCloneable<SubmitAwakeAndLoadEntityNodeResponse>, IBufferMessage
	{
		// Token: 0x06019622 RID: 103970 RVA: 0x003B08E2 File Offset: 0x003AEAE2
		[NullableContext(1)]
		public static SubmitAwakeAndLoadEntityNodeResponse Create()
		{
			return new SubmitAwakeAndLoadEntityNodeResponse();
		}

		// Token: 0x1700559A RID: 21914
		// (get) Token: 0x06019623 RID: 103971 RVA: 0x003B08E9 File Offset: 0x003AEAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700559B RID: 21915
		// (get) Token: 0x06019624 RID: 103972 RVA: 0x003B08EC File Offset: 0x003AEAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitAwakeAndLoadEntityNodeResponse.Descriptor;
			}
		}

		// Token: 0x06019625 RID: 103973 RVA: 0x003B08F3 File Offset: 0x003AEAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeResponse()
		{
		}

		// Token: 0x06019626 RID: 103974 RVA: 0x003B08FB File Offset: 0x003AEAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeResponse(SubmitAwakeAndLoadEntityNodeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019627 RID: 103975 RVA: 0x003B0920 File Offset: 0x003AEB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeResponse Clone()
		{
			return new SubmitAwakeAndLoadEntityNodeResponse(this);
		}

		// Token: 0x1700559C RID: 21916
		// (get) Token: 0x06019628 RID: 103976 RVA: 0x003B0928 File Offset: 0x003AEB28
		// (set) Token: 0x06019629 RID: 103977 RVA: 0x003B0930 File Offset: 0x003AEB30
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

		// Token: 0x0601962A RID: 103978 RVA: 0x003B0939 File Offset: 0x003AEB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitAwakeAndLoadEntityNodeResponse);
		}

		// Token: 0x0601962B RID: 103979 RVA: 0x003B0947 File Offset: 0x003AEB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitAwakeAndLoadEntityNodeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601962C RID: 103980 RVA: 0x003B0978 File Offset: 0x003AEB78
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

		// Token: 0x0601962D RID: 103981 RVA: 0x003B09BD File Offset: 0x003AEBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601962E RID: 103982 RVA: 0x003B09CA File Offset: 0x003AEBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601962F RID: 103983 RVA: 0x003B09D3 File Offset: 0x003AEBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019630 RID: 103984 RVA: 0x003B0A08 File Offset: 0x003AEC08
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

		// Token: 0x06019631 RID: 103985 RVA: 0x003B0A46 File Offset: 0x003AEC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitAwakeAndLoadEntityNodeResponse other)
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

		// Token: 0x06019632 RID: 103986 RVA: 0x003B0A77 File Offset: 0x003AEC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019633 RID: 103987 RVA: 0x003B0A80 File Offset: 0x003AEC80
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009514 RID: 38164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009515 RID: 38165
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04009516 RID: 38166
		private ErrorCode errorCode_;
	}
}
