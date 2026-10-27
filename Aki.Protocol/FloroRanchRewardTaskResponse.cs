using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DE RID: 1502
	[NetMessage(EMessageId.FloroRanchRewardTaskResponse)]
	public sealed class FloroRanchRewardTaskResponse : IMessage<FloroRanchRewardTaskResponse>, IMessage, IEquatable<FloroRanchRewardTaskResponse>, IDeepCloneable<FloroRanchRewardTaskResponse>, IBufferMessage
	{
		// Token: 0x06008AED RID: 35565 RVA: 0x0014FCF4 File Offset: 0x0014DEF4
		[NullableContext(1)]
		public static FloroRanchRewardTaskResponse Create()
		{
			return new FloroRanchRewardTaskResponse();
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06008AEE RID: 35566 RVA: 0x0014FCFB File Offset: 0x0014DEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06008AEF RID: 35567 RVA: 0x0014FCFE File Offset: 0x0014DEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRewardTaskResponse.Descriptor;
			}
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x0014FD05 File Offset: 0x0014DF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskResponse()
		{
		}

		// Token: 0x06008AF1 RID: 35569 RVA: 0x0014FD0D File Offset: 0x0014DF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskResponse(FloroRanchRewardTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x0014FD32 File Offset: 0x0014DF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskResponse Clone()
		{
			return new FloroRanchRewardTaskResponse(this);
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06008AF3 RID: 35571 RVA: 0x0014FD3A File Offset: 0x0014DF3A
		// (set) Token: 0x06008AF4 RID: 35572 RVA: 0x0014FD42 File Offset: 0x0014DF42
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

		// Token: 0x06008AF5 RID: 35573 RVA: 0x0014FD4B File Offset: 0x0014DF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRewardTaskResponse);
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x0014FD59 File Offset: 0x0014DF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRewardTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x0014FD88 File Offset: 0x0014DF88
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

		// Token: 0x06008AF8 RID: 35576 RVA: 0x0014FDCD File Offset: 0x0014DFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x0014FDDA File Offset: 0x0014DFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x0014FDE3 File Offset: 0x0014DFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x0014FE18 File Offset: 0x0014E018
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

		// Token: 0x06008AFC RID: 35580 RVA: 0x0014FE56 File Offset: 0x0014E056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchRewardTaskResponse other)
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

		// Token: 0x06008AFD RID: 35581 RVA: 0x0014FE87 File Offset: 0x0014E087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x0014FE90 File Offset: 0x0014E090
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004426 RID: 17446
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004427 RID: 17447
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004428 RID: 17448
		private ErrorCode errorCode_;
	}
}
