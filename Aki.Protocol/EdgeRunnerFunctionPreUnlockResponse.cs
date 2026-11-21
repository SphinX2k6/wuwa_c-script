using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040B RID: 1035
	[NetMessage(EMessageId.EdgeRunnerFunctionPreUnlockResponse)]
	public sealed class EdgeRunnerFunctionPreUnlockResponse : IMessage<EdgeRunnerFunctionPreUnlockResponse>, IMessage, IEquatable<EdgeRunnerFunctionPreUnlockResponse>, IDeepCloneable<EdgeRunnerFunctionPreUnlockResponse>, IBufferMessage
	{
		// Token: 0x06006429 RID: 25641 RVA: 0x000F1C4D File Offset: 0x000EFE4D
		[NullableContext(1)]
		public static EdgeRunnerFunctionPreUnlockResponse Create()
		{
			return new EdgeRunnerFunctionPreUnlockResponse();
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x0600642A RID: 25642 RVA: 0x000F1C54 File Offset: 0x000EFE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x000F1C57 File Offset: 0x000EFE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerFunctionPreUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x000F1C5E File Offset: 0x000EFE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockResponse()
		{
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x000F1C66 File Offset: 0x000EFE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockResponse(EdgeRunnerFunctionPreUnlockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600642E RID: 25646 RVA: 0x000F1C8B File Offset: 0x000EFE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockResponse Clone()
		{
			return new EdgeRunnerFunctionPreUnlockResponse(this);
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x000F1C93 File Offset: 0x000EFE93
		// (set) Token: 0x06006430 RID: 25648 RVA: 0x000F1C9B File Offset: 0x000EFE9B
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

		// Token: 0x06006431 RID: 25649 RVA: 0x000F1CA4 File Offset: 0x000EFEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerFunctionPreUnlockResponse);
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x000F1CB2 File Offset: 0x000EFEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerFunctionPreUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x000F1CE0 File Offset: 0x000EFEE0
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

		// Token: 0x06006434 RID: 25652 RVA: 0x000F1D25 File Offset: 0x000EFF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x000F1D32 File Offset: 0x000EFF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x000F1D3B File Offset: 0x000EFF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x000F1D70 File Offset: 0x000EFF70
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

		// Token: 0x06006438 RID: 25656 RVA: 0x000F1DAE File Offset: 0x000EFFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerFunctionPreUnlockResponse other)
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

		// Token: 0x06006439 RID: 25657 RVA: 0x000F1DDF File Offset: 0x000EFFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x000F1DE8 File Offset: 0x000EFFE8
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040038E0 RID: 14560
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038E1 RID: 14561
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x040038E2 RID: 14562
		private ErrorCode errCode_;
	}
}
