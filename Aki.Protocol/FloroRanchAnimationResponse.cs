using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000594 RID: 1428
	[NetMessage(EMessageId.FloroRanchAnimationResponse)]
	public sealed class FloroRanchAnimationResponse : IMessage<FloroRanchAnimationResponse>, IMessage, IEquatable<FloroRanchAnimationResponse>, IDeepCloneable<FloroRanchAnimationResponse>, IBufferMessage
	{
		// Token: 0x0600848D RID: 33933 RVA: 0x0013F365 File Offset: 0x0013D565
		[NullableContext(1)]
		public static FloroRanchAnimationResponse Create()
		{
			return new FloroRanchAnimationResponse();
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x0600848E RID: 33934 RVA: 0x0013F36C File Offset: 0x0013D56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x0600848F RID: 33935 RVA: 0x0013F36F File Offset: 0x0013D56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchAnimationResponse.Descriptor;
			}
		}

		// Token: 0x06008490 RID: 33936 RVA: 0x0013F376 File Offset: 0x0013D576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationResponse()
		{
		}

		// Token: 0x06008491 RID: 33937 RVA: 0x0013F37E File Offset: 0x0013D57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationResponse(FloroRanchAnimationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x0013F3A3 File Offset: 0x0013D5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationResponse Clone()
		{
			return new FloroRanchAnimationResponse(this);
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06008493 RID: 33939 RVA: 0x0013F3AB File Offset: 0x0013D5AB
		// (set) Token: 0x06008494 RID: 33940 RVA: 0x0013F3B3 File Offset: 0x0013D5B3
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

		// Token: 0x06008495 RID: 33941 RVA: 0x0013F3BC File Offset: 0x0013D5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchAnimationResponse);
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x0013F3CA File Offset: 0x0013D5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchAnimationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008497 RID: 33943 RVA: 0x0013F3F8 File Offset: 0x0013D5F8
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

		// Token: 0x06008498 RID: 33944 RVA: 0x0013F43D File Offset: 0x0013D63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008499 RID: 33945 RVA: 0x0013F44A File Offset: 0x0013D64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x0013F453 File Offset: 0x0013D653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x0013F488 File Offset: 0x0013D688
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

		// Token: 0x0600849C RID: 33948 RVA: 0x0013F4C6 File Offset: 0x0013D6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchAnimationResponse other)
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

		// Token: 0x0600849D RID: 33949 RVA: 0x0013F4F7 File Offset: 0x0013D6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600849E RID: 33950 RVA: 0x0013F500 File Offset: 0x0013D700
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400421A RID: 16922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400421B RID: 16923
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400421C RID: 16924
		private ErrorCode errorCode_;
	}
}
