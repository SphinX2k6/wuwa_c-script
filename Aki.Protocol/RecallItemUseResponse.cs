using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB1 RID: 3761
	[NetMessage(EMessageId.RecallItemUseResponse)]
	public sealed class RecallItemUseResponse : IMessage<RecallItemUseResponse>, IMessage, IEquatable<RecallItemUseResponse>, IDeepCloneable<RecallItemUseResponse>, IBufferMessage
	{
		// Token: 0x060142EB RID: 82667 RVA: 0x002EFC40 File Offset: 0x002EDE40
		[NullableContext(1)]
		public static RecallItemUseResponse Create()
		{
			return new RecallItemUseResponse();
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x060142EC RID: 82668 RVA: 0x002EFC47 File Offset: 0x002EDE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x060142ED RID: 82669 RVA: 0x002EFC4A File Offset: 0x002EDE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemUseResponse.Descriptor;
			}
		}

		// Token: 0x060142EE RID: 82670 RVA: 0x002EFC51 File Offset: 0x002EDE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseResponse()
		{
		}

		// Token: 0x060142EF RID: 82671 RVA: 0x002EFC59 File Offset: 0x002EDE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseResponse(RecallItemUseResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142F0 RID: 82672 RVA: 0x002EFC7E File Offset: 0x002EDE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseResponse Clone()
		{
			return new RecallItemUseResponse(this);
		}

		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x060142F1 RID: 82673 RVA: 0x002EFC86 File Offset: 0x002EDE86
		// (set) Token: 0x060142F2 RID: 82674 RVA: 0x002EFC8E File Offset: 0x002EDE8E
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

		// Token: 0x060142F3 RID: 82675 RVA: 0x002EFC97 File Offset: 0x002EDE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemUseResponse);
		}

		// Token: 0x060142F4 RID: 82676 RVA: 0x002EFCA5 File Offset: 0x002EDEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemUseResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142F5 RID: 82677 RVA: 0x002EFCD4 File Offset: 0x002EDED4
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

		// Token: 0x060142F6 RID: 82678 RVA: 0x002EFD19 File Offset: 0x002EDF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142F7 RID: 82679 RVA: 0x002EFD26 File Offset: 0x002EDF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142F8 RID: 82680 RVA: 0x002EFD2F File Offset: 0x002EDF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142F9 RID: 82681 RVA: 0x002EFD64 File Offset: 0x002EDF64
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

		// Token: 0x060142FA RID: 82682 RVA: 0x002EFDA2 File Offset: 0x002EDFA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemUseResponse other)
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

		// Token: 0x060142FB RID: 82683 RVA: 0x002EFDD3 File Offset: 0x002EDFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142FC RID: 82684 RVA: 0x002EFDDC File Offset: 0x002EDFDC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007AE7 RID: 31463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AE8 RID: 31464
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04007AE9 RID: 31465
		private ErrorCode errCode_;
	}
}
