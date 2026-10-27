using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E20 RID: 3616
	[NetMessage(EMessageId.QuestReadyForGiveUpResponse)]
	public sealed class QuestReadyForGiveUpResponse : IMessage<QuestReadyForGiveUpResponse>, IMessage, IEquatable<QuestReadyForGiveUpResponse>, IDeepCloneable<QuestReadyForGiveUpResponse>, IBufferMessage
	{
		// Token: 0x060136C1 RID: 79553 RVA: 0x002D2F4D File Offset: 0x002D114D
		[NullableContext(1)]
		public static QuestReadyForGiveUpResponse Create()
		{
			return new QuestReadyForGiveUpResponse();
		}

		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x060136C2 RID: 79554 RVA: 0x002D2F54 File Offset: 0x002D1154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x060136C3 RID: 79555 RVA: 0x002D2F57 File Offset: 0x002D1157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReadyForGiveUpResponse.Descriptor;
			}
		}

		// Token: 0x060136C4 RID: 79556 RVA: 0x002D2F5E File Offset: 0x002D115E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpResponse()
		{
		}

		// Token: 0x060136C5 RID: 79557 RVA: 0x002D2F66 File Offset: 0x002D1166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpResponse(QuestReadyForGiveUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136C6 RID: 79558 RVA: 0x002D2F8B File Offset: 0x002D118B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpResponse Clone()
		{
			return new QuestReadyForGiveUpResponse(this);
		}

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x060136C7 RID: 79559 RVA: 0x002D2F93 File Offset: 0x002D1193
		// (set) Token: 0x060136C8 RID: 79560 RVA: 0x002D2F9B File Offset: 0x002D119B
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

		// Token: 0x060136C9 RID: 79561 RVA: 0x002D2FA4 File Offset: 0x002D11A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReadyForGiveUpResponse);
		}

		// Token: 0x060136CA RID: 79562 RVA: 0x002D2FB2 File Offset: 0x002D11B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReadyForGiveUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136CB RID: 79563 RVA: 0x002D2FE0 File Offset: 0x002D11E0
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

		// Token: 0x060136CC RID: 79564 RVA: 0x002D3025 File Offset: 0x002D1225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136CD RID: 79565 RVA: 0x002D3032 File Offset: 0x002D1232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136CE RID: 79566 RVA: 0x002D303B File Offset: 0x002D123B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060136CF RID: 79567 RVA: 0x002D3070 File Offset: 0x002D1270
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

		// Token: 0x060136D0 RID: 79568 RVA: 0x002D30AE File Offset: 0x002D12AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReadyForGiveUpResponse other)
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

		// Token: 0x060136D1 RID: 79569 RVA: 0x002D30DF File Offset: 0x002D12DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136D2 RID: 79570 RVA: 0x002D30E8 File Offset: 0x002D12E8
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007717 RID: 30487
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007718 RID: 30488
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007719 RID: 30489
		private ErrorCode errorCode_;
	}
}
