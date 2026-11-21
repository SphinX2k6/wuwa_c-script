using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CE RID: 2510
	[NetMessage(EMessageId.MixDrinkSettleResponse)]
	public sealed class MixDrinkSettleResponse : IMessage<MixDrinkSettleResponse>, IMessage, IEquatable<MixDrinkSettleResponse>, IDeepCloneable<MixDrinkSettleResponse>, IBufferMessage
	{
		// Token: 0x0600DC5D RID: 56413 RVA: 0x00205BAE File Offset: 0x00203DAE
		[NullableContext(1)]
		public static MixDrinkSettleResponse Create()
		{
			return new MixDrinkSettleResponse();
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x0600DC5E RID: 56414 RVA: 0x00205BB5 File Offset: 0x00203DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x0600DC5F RID: 56415 RVA: 0x00205BB8 File Offset: 0x00203DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkSettleResponse.Descriptor;
			}
		}

		// Token: 0x0600DC60 RID: 56416 RVA: 0x00205BBF File Offset: 0x00203DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleResponse()
		{
		}

		// Token: 0x0600DC61 RID: 56417 RVA: 0x00205BC7 File Offset: 0x00203DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleResponse(MixDrinkSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC62 RID: 56418 RVA: 0x00205BEC File Offset: 0x00203DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleResponse Clone()
		{
			return new MixDrinkSettleResponse(this);
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x0600DC63 RID: 56419 RVA: 0x00205BF4 File Offset: 0x00203DF4
		// (set) Token: 0x0600DC64 RID: 56420 RVA: 0x00205BFC File Offset: 0x00203DFC
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

		// Token: 0x0600DC65 RID: 56421 RVA: 0x00205C05 File Offset: 0x00203E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkSettleResponse);
		}

		// Token: 0x0600DC66 RID: 56422 RVA: 0x00205C13 File Offset: 0x00203E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC67 RID: 56423 RVA: 0x00205C44 File Offset: 0x00203E44
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

		// Token: 0x0600DC68 RID: 56424 RVA: 0x00205C89 File Offset: 0x00203E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC69 RID: 56425 RVA: 0x00205C96 File Offset: 0x00203E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC6A RID: 56426 RVA: 0x00205C9F File Offset: 0x00203E9F
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

		// Token: 0x0600DC6B RID: 56427 RVA: 0x00205CD4 File Offset: 0x00203ED4
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

		// Token: 0x0600DC6C RID: 56428 RVA: 0x00205D12 File Offset: 0x00203F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkSettleResponse other)
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

		// Token: 0x0600DC6D RID: 56429 RVA: 0x00205D43 File Offset: 0x00203F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC6E RID: 56430 RVA: 0x00205D4C File Offset: 0x00203F4C
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

		// Token: 0x04005B9E RID: 23454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B9F RID: 23455
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005BA0 RID: 23456
		private ErrorCode errorCode_;
	}
}
