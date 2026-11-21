using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025E RID: 606
	[NetMessage(EMessageId.ChangePlayerTitleResponse)]
	public sealed class ChangePlayerTitleResponse : IMessage<ChangePlayerTitleResponse>, IMessage, IEquatable<ChangePlayerTitleResponse>, IDeepCloneable<ChangePlayerTitleResponse>, IBufferMessage
	{
		// Token: 0x06004078 RID: 16504 RVA: 0x0009EAED File Offset: 0x0009CCED
		[NullableContext(1)]
		public static ChangePlayerTitleResponse Create()
		{
			return new ChangePlayerTitleResponse();
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x0009EAF4 File Offset: 0x0009CCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x0009EAF7 File Offset: 0x0009CCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePlayerTitleResponse.Descriptor;
			}
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x0009EAFE File Offset: 0x0009CCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleResponse()
		{
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x0009EB06 File Offset: 0x0009CD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleResponse(ChangePlayerTitleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x0009EB2B File Offset: 0x0009CD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleResponse Clone()
		{
			return new ChangePlayerTitleResponse(this);
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x0009EB33 File Offset: 0x0009CD33
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x0009EB3B File Offset: 0x0009CD3B
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

		// Token: 0x06004080 RID: 16512 RVA: 0x0009EB44 File Offset: 0x0009CD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePlayerTitleResponse);
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x0009EB52 File Offset: 0x0009CD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePlayerTitleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0009EB80 File Offset: 0x0009CD80
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

		// Token: 0x06004083 RID: 16515 RVA: 0x0009EBC5 File Offset: 0x0009CDC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0009EBD2 File Offset: 0x0009CDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x0009EBDB File Offset: 0x0009CDDB
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

		// Token: 0x06004086 RID: 16518 RVA: 0x0009EC10 File Offset: 0x0009CE10
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

		// Token: 0x06004087 RID: 16519 RVA: 0x0009EC4E File Offset: 0x0009CE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangePlayerTitleResponse other)
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

		// Token: 0x06004088 RID: 16520 RVA: 0x0009EC7F File Offset: 0x0009CE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x0009EC88 File Offset: 0x0009CE88
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

		// Token: 0x04002DBD RID: 11709
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DBE RID: 11710
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002DBF RID: 11711
		private ErrorCode errorCode_;
	}
}
