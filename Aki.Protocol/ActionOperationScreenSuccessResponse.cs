using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000075 RID: 117
	[NetMessage(EMessageId.ActionOperationScreenSuccessResponse)]
	public sealed class ActionOperationScreenSuccessResponse : IMessage<ActionOperationScreenSuccessResponse>, IMessage, IEquatable<ActionOperationScreenSuccessResponse>, IDeepCloneable<ActionOperationScreenSuccessResponse>, IBufferMessage
	{
		// Token: 0x060017DC RID: 6108 RVA: 0x0003EBA3 File Offset: 0x0003CDA3
		[NullableContext(1)]
		public static ActionOperationScreenSuccessResponse Create()
		{
			return new ActionOperationScreenSuccessResponse();
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0003EBAA File Offset: 0x0003CDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x0003EBAD File Offset: 0x0003CDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOperationScreenSuccessResponse.Descriptor;
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0003EBB4 File Offset: 0x0003CDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessResponse()
		{
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0003EBBC File Offset: 0x0003CDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessResponse(ActionOperationScreenSuccessResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0003EBE1 File Offset: 0x0003CDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessResponse Clone()
		{
			return new ActionOperationScreenSuccessResponse(this);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0003EBE9 File Offset: 0x0003CDE9
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x0003EBF1 File Offset: 0x0003CDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0003EBFA File Offset: 0x0003CDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOperationScreenSuccessResponse);
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0003EC08 File Offset: 0x0003CE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOperationScreenSuccessResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0003EC38 File Offset: 0x0003CE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0003EC7D File Offset: 0x0003CE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0003EC8A File Offset: 0x0003CE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0003EC93 File Offset: 0x0003CE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0003ECC8 File Offset: 0x0003CEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0003ED06 File Offset: 0x0003CF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionOperationScreenSuccessResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0003ED37 File Offset: 0x0003CF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0003ED40 File Offset: 0x0003CF40
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002154 RID: 8532
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002155 RID: 8533
		public const int CodeFieldNumber = 4;

		// Token: 0x04002156 RID: 8534
		private ErrorCode code_;
	}
}
