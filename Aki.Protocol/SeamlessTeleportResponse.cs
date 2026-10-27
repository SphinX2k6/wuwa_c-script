using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A7 RID: 4519
	[NetMessage(EMessageId.SeamlessTeleportResponse)]
	public sealed class SeamlessTeleportResponse : IMessage<SeamlessTeleportResponse>, IMessage, IEquatable<SeamlessTeleportResponse>, IDeepCloneable<SeamlessTeleportResponse>, IBufferMessage
	{
		// Token: 0x06018148 RID: 98632 RVA: 0x0037F453 File Offset: 0x0037D653
		[NullableContext(1)]
		public static SeamlessTeleportResponse Create()
		{
			return new SeamlessTeleportResponse();
		}

		// Token: 0x170050F0 RID: 20720
		// (get) Token: 0x06018149 RID: 98633 RVA: 0x0037F45A File Offset: 0x0037D65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050F1 RID: 20721
		// (get) Token: 0x0601814A RID: 98634 RVA: 0x0037F45D File Offset: 0x0037D65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportResponse.Descriptor;
			}
		}

		// Token: 0x0601814B RID: 98635 RVA: 0x0037F464 File Offset: 0x0037D664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportResponse()
		{
		}

		// Token: 0x0601814C RID: 98636 RVA: 0x0037F46C File Offset: 0x0037D66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportResponse(SeamlessTeleportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601814D RID: 98637 RVA: 0x0037F491 File Offset: 0x0037D691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportResponse Clone()
		{
			return new SeamlessTeleportResponse(this);
		}

		// Token: 0x170050F2 RID: 20722
		// (get) Token: 0x0601814E RID: 98638 RVA: 0x0037F499 File Offset: 0x0037D699
		// (set) Token: 0x0601814F RID: 98639 RVA: 0x0037F4A1 File Offset: 0x0037D6A1
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

		// Token: 0x06018150 RID: 98640 RVA: 0x0037F4AA File Offset: 0x0037D6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportResponse);
		}

		// Token: 0x06018151 RID: 98641 RVA: 0x0037F4B8 File Offset: 0x0037D6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018152 RID: 98642 RVA: 0x0037F4E8 File Offset: 0x0037D6E8
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

		// Token: 0x06018153 RID: 98643 RVA: 0x0037F52D File Offset: 0x0037D72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018154 RID: 98644 RVA: 0x0037F53A File Offset: 0x0037D73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018155 RID: 98645 RVA: 0x0037F543 File Offset: 0x0037D743
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

		// Token: 0x06018156 RID: 98646 RVA: 0x0037F578 File Offset: 0x0037D778
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

		// Token: 0x06018157 RID: 98647 RVA: 0x0037F5B6 File Offset: 0x0037D7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportResponse other)
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

		// Token: 0x06018158 RID: 98648 RVA: 0x0037F5E7 File Offset: 0x0037D7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018159 RID: 98649 RVA: 0x0037F5F0 File Offset: 0x0037D7F0
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

		// Token: 0x04008E8A RID: 36490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E8B RID: 36491
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008E8C RID: 36492
		private ErrorCode errorCode_;
	}
}
