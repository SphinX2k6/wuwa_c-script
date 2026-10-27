using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000898 RID: 2200
	[NetMessage(EMessageId.KurotatoGoldAddResponse)]
	public sealed class KurotatoGoldAddResponse : IMessage<KurotatoGoldAddResponse>, IMessage, IEquatable<KurotatoGoldAddResponse>, IDeepCloneable<KurotatoGoldAddResponse>, IBufferMessage
	{
		// Token: 0x0600C37D RID: 50045 RVA: 0x001CF9B9 File Offset: 0x001CDBB9
		[NullableContext(1)]
		public static KurotatoGoldAddResponse Create()
		{
			return new KurotatoGoldAddResponse();
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x0600C37E RID: 50046 RVA: 0x001CF9C0 File Offset: 0x001CDBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x0600C37F RID: 50047 RVA: 0x001CF9C3 File Offset: 0x001CDBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoGoldAddResponse.Descriptor;
			}
		}

		// Token: 0x0600C380 RID: 50048 RVA: 0x001CF9CA File Offset: 0x001CDBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddResponse()
		{
		}

		// Token: 0x0600C381 RID: 50049 RVA: 0x001CF9D2 File Offset: 0x001CDBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddResponse(KurotatoGoldAddResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C382 RID: 50050 RVA: 0x001CF9F7 File Offset: 0x001CDBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddResponse Clone()
		{
			return new KurotatoGoldAddResponse(this);
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x0600C383 RID: 50051 RVA: 0x001CF9FF File Offset: 0x001CDBFF
		// (set) Token: 0x0600C384 RID: 50052 RVA: 0x001CFA07 File Offset: 0x001CDC07
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

		// Token: 0x0600C385 RID: 50053 RVA: 0x001CFA10 File Offset: 0x001CDC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoGoldAddResponse);
		}

		// Token: 0x0600C386 RID: 50054 RVA: 0x001CFA1E File Offset: 0x001CDC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoGoldAddResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C387 RID: 50055 RVA: 0x001CFA4C File Offset: 0x001CDC4C
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

		// Token: 0x0600C388 RID: 50056 RVA: 0x001CFA91 File Offset: 0x001CDC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C389 RID: 50057 RVA: 0x001CFA9E File Offset: 0x001CDC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C38A RID: 50058 RVA: 0x001CFAA7 File Offset: 0x001CDCA7
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

		// Token: 0x0600C38B RID: 50059 RVA: 0x001CFAD8 File Offset: 0x001CDCD8
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

		// Token: 0x0600C38C RID: 50060 RVA: 0x001CFB16 File Offset: 0x001CDD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoGoldAddResponse other)
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

		// Token: 0x0600C38D RID: 50061 RVA: 0x001CFB47 File Offset: 0x001CDD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x001CFB50 File Offset: 0x001CDD50
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

		// Token: 0x0400546A RID: 21610
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400546B RID: 21611
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400546C RID: 21612
		private ErrorCode errorCode_;
	}
}
