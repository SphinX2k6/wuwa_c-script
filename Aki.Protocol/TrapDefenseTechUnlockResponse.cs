using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CC RID: 5324
	[NetMessage(EMessageId.TrapDefenseTechUnlockResponse)]
	public sealed class TrapDefenseTechUnlockResponse : IMessage<TrapDefenseTechUnlockResponse>, IMessage, IEquatable<TrapDefenseTechUnlockResponse>, IDeepCloneable<TrapDefenseTechUnlockResponse>, IBufferMessage
	{
		// Token: 0x0601C3E1 RID: 115681 RVA: 0x0041964D File Offset: 0x0041784D
		[NullableContext(1)]
		public static TrapDefenseTechUnlockResponse Create()
		{
			return new TrapDefenseTechUnlockResponse();
		}

		// Token: 0x17005F98 RID: 24472
		// (get) Token: 0x0601C3E2 RID: 115682 RVA: 0x00419654 File Offset: 0x00417854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F99 RID: 24473
		// (get) Token: 0x0601C3E3 RID: 115683 RVA: 0x00419657 File Offset: 0x00417857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0601C3E4 RID: 115684 RVA: 0x0041965E File Offset: 0x0041785E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockResponse()
		{
		}

		// Token: 0x0601C3E5 RID: 115685 RVA: 0x00419666 File Offset: 0x00417866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockResponse(TrapDefenseTechUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3E6 RID: 115686 RVA: 0x0041968B File Offset: 0x0041788B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockResponse Clone()
		{
			return new TrapDefenseTechUnlockResponse(this);
		}

		// Token: 0x17005F9A RID: 24474
		// (get) Token: 0x0601C3E7 RID: 115687 RVA: 0x00419693 File Offset: 0x00417893
		// (set) Token: 0x0601C3E8 RID: 115688 RVA: 0x0041969B File Offset: 0x0041789B
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

		// Token: 0x0601C3E9 RID: 115689 RVA: 0x004196A4 File Offset: 0x004178A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechUnlockResponse);
		}

		// Token: 0x0601C3EA RID: 115690 RVA: 0x004196B2 File Offset: 0x004178B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3EB RID: 115691 RVA: 0x004196E0 File Offset: 0x004178E0
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

		// Token: 0x0601C3EC RID: 115692 RVA: 0x00419725 File Offset: 0x00417925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3ED RID: 115693 RVA: 0x00419732 File Offset: 0x00417932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3EE RID: 115694 RVA: 0x0041973B File Offset: 0x0041793B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3EF RID: 115695 RVA: 0x00419770 File Offset: 0x00417970
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

		// Token: 0x0601C3F0 RID: 115696 RVA: 0x004197AE File Offset: 0x004179AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechUnlockResponse other)
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

		// Token: 0x0601C3F1 RID: 115697 RVA: 0x004197DF File Offset: 0x004179DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3F2 RID: 115698 RVA: 0x004197E8 File Offset: 0x004179E8
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A349 RID: 41801
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A34A RID: 41802
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A34B RID: 41803
		private ErrorCode errorCode_;
	}
}
