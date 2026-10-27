using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001691 RID: 5777
	[NetMessage(EMessageId.CheatInputResponse)]
	public sealed class CheatInputResponse : IMessage<CheatInputResponse>, IMessage, IEquatable<CheatInputResponse>, IDeepCloneable<CheatInputResponse>, IBufferMessage
	{
		// Token: 0x0601CF19 RID: 118553 RVA: 0x0043C0E5 File Offset: 0x0043A2E5
		[NullableContext(1)]
		public static CheatInputResponse Create()
		{
			return new CheatInputResponse();
		}

		// Token: 0x17006229 RID: 25129
		// (get) Token: 0x0601CF1A RID: 118554 RVA: 0x0043C0EC File Offset: 0x0043A2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700622A RID: 25130
		// (get) Token: 0x0601CF1B RID: 118555 RVA: 0x0043C0EF File Offset: 0x0043A2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheatInputResponse.Descriptor;
			}
		}

		// Token: 0x0601CF1C RID: 118556 RVA: 0x0043C0F6 File Offset: 0x0043A2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputResponse()
		{
		}

		// Token: 0x0601CF1D RID: 118557 RVA: 0x0043C0FE File Offset: 0x0043A2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputResponse(CheatInputResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF1E RID: 118558 RVA: 0x0043C123 File Offset: 0x0043A323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputResponse Clone()
		{
			return new CheatInputResponse(this);
		}

		// Token: 0x1700622B RID: 25131
		// (get) Token: 0x0601CF1F RID: 118559 RVA: 0x0043C12B File Offset: 0x0043A32B
		// (set) Token: 0x0601CF20 RID: 118560 RVA: 0x0043C133 File Offset: 0x0043A333
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

		// Token: 0x0601CF21 RID: 118561 RVA: 0x0043C13C File Offset: 0x0043A33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheatInputResponse);
		}

		// Token: 0x0601CF22 RID: 118562 RVA: 0x0043C14A File Offset: 0x0043A34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheatInputResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF23 RID: 118563 RVA: 0x0043C178 File Offset: 0x0043A378
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

		// Token: 0x0601CF24 RID: 118564 RVA: 0x0043C1BD File Offset: 0x0043A3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF25 RID: 118565 RVA: 0x0043C1CA File Offset: 0x0043A3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF26 RID: 118566 RVA: 0x0043C1D3 File Offset: 0x0043A3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF27 RID: 118567 RVA: 0x0043C208 File Offset: 0x0043A408
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

		// Token: 0x0601CF28 RID: 118568 RVA: 0x0043C246 File Offset: 0x0043A446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheatInputResponse other)
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

		// Token: 0x0601CF29 RID: 118569 RVA: 0x0043C277 File Offset: 0x0043A477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF2A RID: 118570 RVA: 0x0043C280 File Offset: 0x0043A480
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C369 RID: 50025
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C36A RID: 50026
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400C36B RID: 50027
		private ErrorCode errorCode_;
	}
}
