using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B4 RID: 692
	[NetMessage(EMessageId.CombineEntitiesResponse)]
	public sealed class CombineEntitiesResponse : IMessage<CombineEntitiesResponse>, IMessage, IEquatable<CombineEntitiesResponse>, IDeepCloneable<CombineEntitiesResponse>, IBufferMessage
	{
		// Token: 0x06004790 RID: 18320 RVA: 0x000AFC7F File Offset: 0x000ADE7F
		[NullableContext(1)]
		public static CombineEntitiesResponse Create()
		{
			return new CombineEntitiesResponse();
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06004791 RID: 18321 RVA: 0x000AFC86 File Offset: 0x000ADE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x000AFC89 File Offset: 0x000ADE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombineEntitiesResponse.Descriptor;
			}
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x000AFC90 File Offset: 0x000ADE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesResponse()
		{
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x000AFC98 File Offset: 0x000ADE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesResponse(CombineEntitiesResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x000AFCBD File Offset: 0x000ADEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesResponse Clone()
		{
			return new CombineEntitiesResponse(this);
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x000AFCC5 File Offset: 0x000ADEC5
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x000AFCCD File Offset: 0x000ADECD
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

		// Token: 0x06004798 RID: 18328 RVA: 0x000AFCD6 File Offset: 0x000ADED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombineEntitiesResponse);
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x000AFCE4 File Offset: 0x000ADEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombineEntitiesResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x000AFD14 File Offset: 0x000ADF14
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

		// Token: 0x0600479B RID: 18331 RVA: 0x000AFD59 File Offset: 0x000ADF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x000AFD66 File Offset: 0x000ADF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x000AFD6F File Offset: 0x000ADF6F
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

		// Token: 0x0600479E RID: 18334 RVA: 0x000AFDA4 File Offset: 0x000ADFA4
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

		// Token: 0x0600479F RID: 18335 RVA: 0x000AFDE2 File Offset: 0x000ADFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombineEntitiesResponse other)
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

		// Token: 0x060047A0 RID: 18336 RVA: 0x000AFE13 File Offset: 0x000AE013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x000AFE1C File Offset: 0x000AE01C
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

		// Token: 0x04002FAB RID: 12203
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FAC RID: 12204
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002FAD RID: 12205
		private ErrorCode errorCode_;
	}
}
