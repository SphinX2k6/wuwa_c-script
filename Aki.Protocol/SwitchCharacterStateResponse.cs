using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FC RID: 4860
	[NetMessage(EMessageId.SwitchCharacterStateResponse)]
	public sealed class SwitchCharacterStateResponse : IMessage<SwitchCharacterStateResponse>, IMessage, IEquatable<SwitchCharacterStateResponse>, IDeepCloneable<SwitchCharacterStateResponse>, IBufferMessage
	{
		// Token: 0x06019D68 RID: 105832 RVA: 0x003C142B File Offset: 0x003BF62B
		[NullableContext(1)]
		public static SwitchCharacterStateResponse Create()
		{
			return new SwitchCharacterStateResponse();
		}

		// Token: 0x17005724 RID: 22308
		// (get) Token: 0x06019D69 RID: 105833 RVA: 0x003C1432 File Offset: 0x003BF632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005725 RID: 22309
		// (get) Token: 0x06019D6A RID: 105834 RVA: 0x003C1435 File Offset: 0x003BF635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchCharacterStateResponse.Descriptor;
			}
		}

		// Token: 0x06019D6B RID: 105835 RVA: 0x003C143C File Offset: 0x003BF63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateResponse()
		{
		}

		// Token: 0x06019D6C RID: 105836 RVA: 0x003C1444 File Offset: 0x003BF644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateResponse(SwitchCharacterStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D6D RID: 105837 RVA: 0x003C1469 File Offset: 0x003BF669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateResponse Clone()
		{
			return new SwitchCharacterStateResponse(this);
		}

		// Token: 0x17005726 RID: 22310
		// (get) Token: 0x06019D6E RID: 105838 RVA: 0x003C1471 File Offset: 0x003BF671
		// (set) Token: 0x06019D6F RID: 105839 RVA: 0x003C1479 File Offset: 0x003BF679
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

		// Token: 0x06019D70 RID: 105840 RVA: 0x003C1482 File Offset: 0x003BF682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchCharacterStateResponse);
		}

		// Token: 0x06019D71 RID: 105841 RVA: 0x003C1490 File Offset: 0x003BF690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchCharacterStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D72 RID: 105842 RVA: 0x003C14C0 File Offset: 0x003BF6C0
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

		// Token: 0x06019D73 RID: 105843 RVA: 0x003C1505 File Offset: 0x003BF705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D74 RID: 105844 RVA: 0x003C1512 File Offset: 0x003BF712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D75 RID: 105845 RVA: 0x003C151B File Offset: 0x003BF71B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D76 RID: 105846 RVA: 0x003C154C File Offset: 0x003BF74C
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

		// Token: 0x06019D77 RID: 105847 RVA: 0x003C158A File Offset: 0x003BF78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchCharacterStateResponse other)
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

		// Token: 0x06019D78 RID: 105848 RVA: 0x003C15BB File Offset: 0x003BF7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D79 RID: 105849 RVA: 0x003C15C4 File Offset: 0x003BF7C4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009727 RID: 38695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009728 RID: 38696
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04009729 RID: 38697
		private ErrorCode errorCode_;
	}
}
