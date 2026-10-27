using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CE RID: 4558
	[NetMessage(EMessageId.SetClientGlobalVarResponse)]
	public sealed class SetClientGlobalVarResponse : IMessage<SetClientGlobalVarResponse>, IMessage, IEquatable<SetClientGlobalVarResponse>, IDeepCloneable<SetClientGlobalVarResponse>, IBufferMessage
	{
		// Token: 0x060184FE RID: 99582 RVA: 0x00389B2B File Offset: 0x00387D2B
		[NullableContext(1)]
		public static SetClientGlobalVarResponse Create()
		{
			return new SetClientGlobalVarResponse();
		}

		// Token: 0x170051E2 RID: 20962
		// (get) Token: 0x060184FF RID: 99583 RVA: 0x00389B32 File Offset: 0x00387D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051E3 RID: 20963
		// (get) Token: 0x06018500 RID: 99584 RVA: 0x00389B35 File Offset: 0x00387D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetClientGlobalVarResponse.Descriptor;
			}
		}

		// Token: 0x06018501 RID: 99585 RVA: 0x00389B3C File Offset: 0x00387D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarResponse()
		{
		}

		// Token: 0x06018502 RID: 99586 RVA: 0x00389B44 File Offset: 0x00387D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarResponse(SetClientGlobalVarResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018503 RID: 99587 RVA: 0x00389B69 File Offset: 0x00387D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarResponse Clone()
		{
			return new SetClientGlobalVarResponse(this);
		}

		// Token: 0x170051E4 RID: 20964
		// (get) Token: 0x06018504 RID: 99588 RVA: 0x00389B71 File Offset: 0x00387D71
		// (set) Token: 0x06018505 RID: 99589 RVA: 0x00389B79 File Offset: 0x00387D79
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

		// Token: 0x06018506 RID: 99590 RVA: 0x00389B82 File Offset: 0x00387D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetClientGlobalVarResponse);
		}

		// Token: 0x06018507 RID: 99591 RVA: 0x00389B90 File Offset: 0x00387D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetClientGlobalVarResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018508 RID: 99592 RVA: 0x00389BC0 File Offset: 0x00387DC0
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

		// Token: 0x06018509 RID: 99593 RVA: 0x00389C05 File Offset: 0x00387E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601850A RID: 99594 RVA: 0x00389C12 File Offset: 0x00387E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601850B RID: 99595 RVA: 0x00389C1B File Offset: 0x00387E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601850C RID: 99596 RVA: 0x00389C50 File Offset: 0x00387E50
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

		// Token: 0x0601850D RID: 99597 RVA: 0x00389C8E File Offset: 0x00387E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetClientGlobalVarResponse other)
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

		// Token: 0x0601850E RID: 99598 RVA: 0x00389CBF File Offset: 0x00387EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601850F RID: 99599 RVA: 0x00389CC8 File Offset: 0x00387EC8
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FFC RID: 36860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FFD RID: 36861
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x04008FFE RID: 36862
		private ErrorCode errorId_;
	}
}
