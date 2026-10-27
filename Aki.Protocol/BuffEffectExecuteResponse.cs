using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FD RID: 509
	[NetMessage(EMessageId.BuffEffectExecuteResponse)]
	public sealed class BuffEffectExecuteResponse : IMessage<BuffEffectExecuteResponse>, IMessage, IEquatable<BuffEffectExecuteResponse>, IDeepCloneable<BuffEffectExecuteResponse>, IBufferMessage
	{
		// Token: 0x0600387C RID: 14460 RVA: 0x0008D287 File Offset: 0x0008B487
		[NullableContext(1)]
		public static BuffEffectExecuteResponse Create()
		{
			return new BuffEffectExecuteResponse();
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x0008D28E File Offset: 0x0008B48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x0008D291 File Offset: 0x0008B491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectExecuteResponse.Descriptor;
			}
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x0008D298 File Offset: 0x0008B498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteResponse()
		{
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0008D2A0 File Offset: 0x0008B4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteResponse(BuffEffectExecuteResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0008D2C5 File Offset: 0x0008B4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteResponse Clone()
		{
			return new BuffEffectExecuteResponse(this);
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x0008D2CD File Offset: 0x0008B4CD
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x0008D2D5 File Offset: 0x0008B4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x0008D2DE File Offset: 0x0008B4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectExecuteResponse);
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x0008D2EC File Offset: 0x0008B4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectExecuteResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x0008D31C File Offset: 0x0008B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x0008D361 File Offset: 0x0008B561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x0008D36E File Offset: 0x0008B56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x0008D377 File Offset: 0x0008B577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x0008D3AC File Offset: 0x0008B5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x0008D3EA File Offset: 0x0008B5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectExecuteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x0008D41B File Offset: 0x0008B61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x0008D424 File Offset: 0x0008B624
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002B3A RID: 11066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B3B RID: 11067
		public const int CodeFieldNumber = 6;

		// Token: 0x04002B3C RID: 11068
		private ErrorCode code_;
	}
}
