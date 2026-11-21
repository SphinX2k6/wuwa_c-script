using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001215 RID: 4629
	[NetMessage(EMessageId.SetPlayerYuXueModeResponse)]
	public sealed class SetPlayerYuXueModeResponse : IMessage<SetPlayerYuXueModeResponse>, IMessage, IEquatable<SetPlayerYuXueModeResponse>, IDeepCloneable<SetPlayerYuXueModeResponse>, IBufferMessage
	{
		// Token: 0x06018B91 RID: 101265 RVA: 0x0039A9B1 File Offset: 0x00398BB1
		[NullableContext(1)]
		public static SetPlayerYuXueModeResponse Create()
		{
			return new SetPlayerYuXueModeResponse();
		}

		// Token: 0x17005379 RID: 21369
		// (get) Token: 0x06018B92 RID: 101266 RVA: 0x0039A9B8 File Offset: 0x00398BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700537A RID: 21370
		// (get) Token: 0x06018B93 RID: 101267 RVA: 0x0039A9BB File Offset: 0x00398BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetPlayerYuXueModeResponse.Descriptor;
			}
		}

		// Token: 0x06018B94 RID: 101268 RVA: 0x0039A9C2 File Offset: 0x00398BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeResponse()
		{
		}

		// Token: 0x06018B95 RID: 101269 RVA: 0x0039A9CA File Offset: 0x00398BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeResponse(SetPlayerYuXueModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B96 RID: 101270 RVA: 0x0039A9EF File Offset: 0x00398BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeResponse Clone()
		{
			return new SetPlayerYuXueModeResponse(this);
		}

		// Token: 0x1700537B RID: 21371
		// (get) Token: 0x06018B97 RID: 101271 RVA: 0x0039A9F7 File Offset: 0x00398BF7
		// (set) Token: 0x06018B98 RID: 101272 RVA: 0x0039A9FF File Offset: 0x00398BFF
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

		// Token: 0x06018B99 RID: 101273 RVA: 0x0039AA08 File Offset: 0x00398C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetPlayerYuXueModeResponse);
		}

		// Token: 0x06018B9A RID: 101274 RVA: 0x0039AA16 File Offset: 0x00398C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetPlayerYuXueModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B9B RID: 101275 RVA: 0x0039AA44 File Offset: 0x00398C44
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

		// Token: 0x06018B9C RID: 101276 RVA: 0x0039AA89 File Offset: 0x00398C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B9D RID: 101277 RVA: 0x0039AA96 File Offset: 0x00398C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B9E RID: 101278 RVA: 0x0039AA9F File Offset: 0x00398C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B9F RID: 101279 RVA: 0x0039AAD4 File Offset: 0x00398CD4
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

		// Token: 0x06018BA0 RID: 101280 RVA: 0x0039AB12 File Offset: 0x00398D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetPlayerYuXueModeResponse other)
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

		// Token: 0x06018BA1 RID: 101281 RVA: 0x0039AB43 File Offset: 0x00398D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BA2 RID: 101282 RVA: 0x0039AB4C File Offset: 0x00398D4C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040092BE RID: 37566
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092BF RID: 37567
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040092C0 RID: 37568
		private ErrorCode errorCode_;
	}
}
