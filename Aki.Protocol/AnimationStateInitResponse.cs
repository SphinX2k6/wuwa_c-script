using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F5 RID: 245
	[NetMessage(EMessageId.AnimationStateInitResponse)]
	public sealed class AnimationStateInitResponse : IMessage<AnimationStateInitResponse>, IMessage, IEquatable<AnimationStateInitResponse>, IDeepCloneable<AnimationStateInitResponse>, IBufferMessage
	{
		// Token: 0x0600232E RID: 9006 RVA: 0x0005E012 File Offset: 0x0005C212
		[NullableContext(1)]
		public static AnimationStateInitResponse Create()
		{
			return new AnimationStateInitResponse();
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x0005E019 File Offset: 0x0005C219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x0005E01C File Offset: 0x0005C21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateInitResponse.Descriptor;
			}
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0005E023 File Offset: 0x0005C223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitResponse()
		{
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0005E02B File Offset: 0x0005C22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitResponse(AnimationStateInitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0005E050 File Offset: 0x0005C250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitResponse Clone()
		{
			return new AnimationStateInitResponse(this);
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x0005E058 File Offset: 0x0005C258
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x0005E060 File Offset: 0x0005C260
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

		// Token: 0x06002336 RID: 9014 RVA: 0x0005E069 File Offset: 0x0005C269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateInitResponse);
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0005E077 File Offset: 0x0005C277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateInitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0005E0A8 File Offset: 0x0005C2A8
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

		// Token: 0x06002339 RID: 9017 RVA: 0x0005E0ED File Offset: 0x0005C2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0005E0FA File Offset: 0x0005C2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0005E103 File Offset: 0x0005C303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0005E138 File Offset: 0x0005C338
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

		// Token: 0x0600233D RID: 9021 RVA: 0x0005E176 File Offset: 0x0005C376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateInitResponse other)
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

		// Token: 0x0600233E RID: 9022 RVA: 0x0005E1A7 File Offset: 0x0005C3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0005E1B0 File Offset: 0x0005C3B0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002529 RID: 9513
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400252A RID: 9514
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400252B RID: 9515
		private ErrorCode errorCode_;
	}
}
