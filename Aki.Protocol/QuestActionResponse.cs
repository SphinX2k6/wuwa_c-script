using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E04 RID: 3588
	[NetMessage(EMessageId.QuestActionResponse)]
	public sealed class QuestActionResponse : IMessage<QuestActionResponse>, IMessage, IEquatable<QuestActionResponse>, IDeepCloneable<QuestActionResponse>, IBufferMessage
	{
		// Token: 0x060134A5 RID: 79013 RVA: 0x002CEDE1 File Offset: 0x002CCFE1
		[NullableContext(1)]
		public static QuestActionResponse Create()
		{
			return new QuestActionResponse();
		}

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x060134A6 RID: 79014 RVA: 0x002CEDE8 File Offset: 0x002CCFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x060134A7 RID: 79015 RVA: 0x002CEDEB File Offset: 0x002CCFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestActionResponse.Descriptor;
			}
		}

		// Token: 0x060134A8 RID: 79016 RVA: 0x002CEDF2 File Offset: 0x002CCFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionResponse()
		{
		}

		// Token: 0x060134A9 RID: 79017 RVA: 0x002CEDFA File Offset: 0x002CCFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionResponse(QuestActionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134AA RID: 79018 RVA: 0x002CEE1F File Offset: 0x002CD01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionResponse Clone()
		{
			return new QuestActionResponse(this);
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x060134AB RID: 79019 RVA: 0x002CEE27 File Offset: 0x002CD027
		// (set) Token: 0x060134AC RID: 79020 RVA: 0x002CEE2F File Offset: 0x002CD02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060134AD RID: 79021 RVA: 0x002CEE38 File Offset: 0x002CD038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestActionResponse);
		}

		// Token: 0x060134AE RID: 79022 RVA: 0x002CEE46 File Offset: 0x002CD046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestActionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134AF RID: 79023 RVA: 0x002CEE74 File Offset: 0x002CD074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060134B0 RID: 79024 RVA: 0x002CEEB9 File Offset: 0x002CD0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134B1 RID: 79025 RVA: 0x002CEEC6 File Offset: 0x002CD0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134B2 RID: 79026 RVA: 0x002CEECF File Offset: 0x002CD0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134B3 RID: 79027 RVA: 0x002CEF04 File Offset: 0x002CD104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060134B4 RID: 79028 RVA: 0x002CEF42 File Offset: 0x002CD142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestActionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060134B5 RID: 79029 RVA: 0x002CEF73 File Offset: 0x002CD173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134B6 RID: 79030 RVA: 0x002CEF7C File Offset: 0x002CD17C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007697 RID: 30359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007698 RID: 30360
		public const int ErrorIdFieldNumber = 11;

		// Token: 0x04007699 RID: 30361
		private ErrorCode errorId_;
	}
}
