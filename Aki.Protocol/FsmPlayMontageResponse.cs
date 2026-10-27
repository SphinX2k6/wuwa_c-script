using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066F RID: 1647
	[NetMessage(EMessageId.FsmPlayMontageResponse)]
	public sealed class FsmPlayMontageResponse : IMessage<FsmPlayMontageResponse>, IMessage, IEquatable<FsmPlayMontageResponse>, IDeepCloneable<FsmPlayMontageResponse>, IBufferMessage
	{
		// Token: 0x06009711 RID: 38673 RVA: 0x0016C747 File Offset: 0x0016A947
		[NullableContext(1)]
		public static FsmPlayMontageResponse Create()
		{
			return new FsmPlayMontageResponse();
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06009712 RID: 38674 RVA: 0x0016C74E File Offset: 0x0016A94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x06009713 RID: 38675 RVA: 0x0016C751 File Offset: 0x0016A951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmPlayMontageResponse.Descriptor;
			}
		}

		// Token: 0x06009714 RID: 38676 RVA: 0x0016C758 File Offset: 0x0016A958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageResponse()
		{
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x0016C760 File Offset: 0x0016A960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageResponse(FsmPlayMontageResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x0016C785 File Offset: 0x0016A985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageResponse Clone()
		{
			return new FsmPlayMontageResponse(this);
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x06009717 RID: 38679 RVA: 0x0016C78D File Offset: 0x0016A98D
		// (set) Token: 0x06009718 RID: 38680 RVA: 0x0016C795 File Offset: 0x0016A995
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

		// Token: 0x06009719 RID: 38681 RVA: 0x0016C79E File Offset: 0x0016A99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmPlayMontageResponse);
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x0016C7AC File Offset: 0x0016A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmPlayMontageResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x0016C7DC File Offset: 0x0016A9DC
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

		// Token: 0x0600971C RID: 38684 RVA: 0x0016C821 File Offset: 0x0016AA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x0016C82E File Offset: 0x0016AA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x0016C837 File Offset: 0x0016AA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x0016C86C File Offset: 0x0016AA6C
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

		// Token: 0x06009720 RID: 38688 RVA: 0x0016C8AA File Offset: 0x0016AAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmPlayMontageResponse other)
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

		// Token: 0x06009721 RID: 38689 RVA: 0x0016C8DB File Offset: 0x0016AADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009722 RID: 38690 RVA: 0x0016C8E4 File Offset: 0x0016AAE4
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040047E4 RID: 18404
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047E5 RID: 18405
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040047E6 RID: 18406
		private ErrorCode errorCode_;
	}
}
