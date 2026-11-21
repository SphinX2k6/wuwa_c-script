using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000239 RID: 569
	[NetMessage(EMessageId.CancelQuestFocusModeResponse)]
	public sealed class CancelQuestFocusModeResponse : IMessage<CancelQuestFocusModeResponse>, IMessage, IEquatable<CancelQuestFocusModeResponse>, IDeepCloneable<CancelQuestFocusModeResponse>, IBufferMessage
	{
		// Token: 0x06003DA2 RID: 15778 RVA: 0x00098FA9 File Offset: 0x000971A9
		[NullableContext(1)]
		public static CancelQuestFocusModeResponse Create()
		{
			return new CancelQuestFocusModeResponse();
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x00098FB0 File Offset: 0x000971B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x00098FB3 File Offset: 0x000971B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelQuestFocusModeResponse.Descriptor;
			}
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00098FBA File Offset: 0x000971BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeResponse()
		{
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00098FC2 File Offset: 0x000971C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeResponse(CancelQuestFocusModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00098FE7 File Offset: 0x000971E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeResponse Clone()
		{
			return new CancelQuestFocusModeResponse(this);
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06003DA8 RID: 15784 RVA: 0x00098FEF File Offset: 0x000971EF
		// (set) Token: 0x06003DA9 RID: 15785 RVA: 0x00098FF7 File Offset: 0x000971F7
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

		// Token: 0x06003DAA RID: 15786 RVA: 0x00099000 File Offset: 0x00097200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelQuestFocusModeResponse);
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x0009900E File Offset: 0x0009720E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelQuestFocusModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x0009903C File Offset: 0x0009723C
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

		// Token: 0x06003DAD RID: 15789 RVA: 0x00099081 File Offset: 0x00097281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x0009908E File Offset: 0x0009728E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00099097 File Offset: 0x00097297
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

		// Token: 0x06003DB0 RID: 15792 RVA: 0x000990CC File Offset: 0x000972CC
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

		// Token: 0x06003DB1 RID: 15793 RVA: 0x0009910A File Offset: 0x0009730A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelQuestFocusModeResponse other)
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

		// Token: 0x06003DB2 RID: 15794 RVA: 0x0009913B File Offset: 0x0009733B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00099144 File Offset: 0x00097344
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

		// Token: 0x04002D0F RID: 11535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D10 RID: 11536
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002D11 RID: 11537
		private ErrorCode errorCode_;
	}
}
