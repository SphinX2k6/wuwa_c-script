using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001504 RID: 5380
	[NetMessage(EMessageId.UnOpenedAreaPullbackResponse)]
	public sealed class UnOpenedAreaPullbackResponse : IMessage<UnOpenedAreaPullbackResponse>, IMessage, IEquatable<UnOpenedAreaPullbackResponse>, IDeepCloneable<UnOpenedAreaPullbackResponse>, IBufferMessage
	{
		// Token: 0x0601C83A RID: 116794 RVA: 0x004223B0 File Offset: 0x004205B0
		[NullableContext(1)]
		public static UnOpenedAreaPullbackResponse Create()
		{
			return new UnOpenedAreaPullbackResponse();
		}

		// Token: 0x1700607A RID: 24698
		// (get) Token: 0x0601C83B RID: 116795 RVA: 0x004223B7 File Offset: 0x004205B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700607B RID: 24699
		// (get) Token: 0x0601C83C RID: 116796 RVA: 0x004223BA File Offset: 0x004205BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnOpenedAreaPullbackResponse.Descriptor;
			}
		}

		// Token: 0x0601C83D RID: 116797 RVA: 0x004223C1 File Offset: 0x004205C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackResponse()
		{
		}

		// Token: 0x0601C83E RID: 116798 RVA: 0x004223C9 File Offset: 0x004205C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackResponse(UnOpenedAreaPullbackResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C83F RID: 116799 RVA: 0x004223EE File Offset: 0x004205EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackResponse Clone()
		{
			return new UnOpenedAreaPullbackResponse(this);
		}

		// Token: 0x1700607C RID: 24700
		// (get) Token: 0x0601C840 RID: 116800 RVA: 0x004223F6 File Offset: 0x004205F6
		// (set) Token: 0x0601C841 RID: 116801 RVA: 0x004223FE File Offset: 0x004205FE
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

		// Token: 0x0601C842 RID: 116802 RVA: 0x00422407 File Offset: 0x00420607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnOpenedAreaPullbackResponse);
		}

		// Token: 0x0601C843 RID: 116803 RVA: 0x00422415 File Offset: 0x00420615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnOpenedAreaPullbackResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C844 RID: 116804 RVA: 0x00422444 File Offset: 0x00420644
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

		// Token: 0x0601C845 RID: 116805 RVA: 0x00422489 File Offset: 0x00420689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C846 RID: 116806 RVA: 0x00422496 File Offset: 0x00420696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C847 RID: 116807 RVA: 0x0042249F File Offset: 0x0042069F
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

		// Token: 0x0601C848 RID: 116808 RVA: 0x004224D4 File Offset: 0x004206D4
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

		// Token: 0x0601C849 RID: 116809 RVA: 0x00422512 File Offset: 0x00420712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnOpenedAreaPullbackResponse other)
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

		// Token: 0x0601C84A RID: 116810 RVA: 0x00422543 File Offset: 0x00420743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C84B RID: 116811 RVA: 0x0042254C File Offset: 0x0042074C
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

		// Token: 0x0400A477 RID: 42103
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A478 RID: 42104
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A479 RID: 42105
		private ErrorCode errorCode_;
	}
}
