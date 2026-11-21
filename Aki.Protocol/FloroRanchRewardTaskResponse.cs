using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C9 RID: 1481
	[NetMessage(EMessageId.FloroRanchRewardTaskResponse)]
	public sealed class FloroRanchRewardTaskResponse : IMessage<FloroRanchRewardTaskResponse>, IMessage, IEquatable<FloroRanchRewardTaskResponse>, IDeepCloneable<FloroRanchRewardTaskResponse>, IBufferMessage
	{
		// Token: 0x06008985 RID: 35205 RVA: 0x0014D0DC File Offset: 0x0014B2DC
		[NullableContext(1)]
		public static FloroRanchRewardTaskResponse Create()
		{
			return new FloroRanchRewardTaskResponse();
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06008986 RID: 35206 RVA: 0x0014D0E3 File Offset: 0x0014B2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06008987 RID: 35207 RVA: 0x0014D0E6 File Offset: 0x0014B2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRewardTaskResponse.Descriptor;
			}
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x0014D0ED File Offset: 0x0014B2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskResponse()
		{
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x0014D0F5 File Offset: 0x0014B2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskResponse(FloroRanchRewardTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x0014D11A File Offset: 0x0014B31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskResponse Clone()
		{
			return new FloroRanchRewardTaskResponse(this);
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x0600898B RID: 35211 RVA: 0x0014D122 File Offset: 0x0014B322
		// (set) Token: 0x0600898C RID: 35212 RVA: 0x0014D12A File Offset: 0x0014B32A
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

		// Token: 0x0600898D RID: 35213 RVA: 0x0014D133 File Offset: 0x0014B333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRewardTaskResponse);
		}

		// Token: 0x0600898E RID: 35214 RVA: 0x0014D141 File Offset: 0x0014B341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRewardTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600898F RID: 35215 RVA: 0x0014D170 File Offset: 0x0014B370
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

		// Token: 0x06008990 RID: 35216 RVA: 0x0014D1B5 File Offset: 0x0014B3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008991 RID: 35217 RVA: 0x0014D1C2 File Offset: 0x0014B3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x0014D1CB File Offset: 0x0014B3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x0014D200 File Offset: 0x0014B400
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

		// Token: 0x06008994 RID: 35220 RVA: 0x0014D23E File Offset: 0x0014B43E
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

		// Token: 0x06008995 RID: 35221 RVA: 0x0014D26F File Offset: 0x0014B46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x0014D278 File Offset: 0x0014B478
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400441C RID: 17436
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400441D RID: 17437
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400441E RID: 17438
		private ErrorCode errorCode_;
	}
}
