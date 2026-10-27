using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200002A RID: 42
	[NetMessage(EMessageId.AbyssLikeResponse)]
	public sealed class AbyssLikeResponse : IMessage<AbyssLikeResponse>, IMessage, IEquatable<AbyssLikeResponse>, IDeepCloneable<AbyssLikeResponse>, IBufferMessage
	{
		// Token: 0x060011DD RID: 4573 RVA: 0x00031951 File Offset: 0x0002FB51
		[NullableContext(1)]
		public static AbyssLikeResponse Create()
		{
			return new AbyssLikeResponse();
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00031958 File Offset: 0x0002FB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0003195B File Offset: 0x0002FB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLikeResponse.Descriptor;
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00031962 File Offset: 0x0002FB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeResponse()
		{
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0003196A File Offset: 0x0002FB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeResponse(AbyssLikeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0003198F File Offset: 0x0002FB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeResponse Clone()
		{
			return new AbyssLikeResponse(this);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00031997 File Offset: 0x0002FB97
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0003199F File Offset: 0x0002FB9F
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

		// Token: 0x060011E5 RID: 4581 RVA: 0x000319A8 File Offset: 0x0002FBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLikeResponse);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000319B6 File Offset: 0x0002FBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLikeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000319E4 File Offset: 0x0002FBE4
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

		// Token: 0x060011E8 RID: 4584 RVA: 0x00031A29 File Offset: 0x0002FC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00031A36 File Offset: 0x0002FC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00031A3F File Offset: 0x0002FC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00031A74 File Offset: 0x0002FC74
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

		// Token: 0x060011EC RID: 4588 RVA: 0x00031AB2 File Offset: 0x0002FCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLikeResponse other)
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

		// Token: 0x060011ED RID: 4589 RVA: 0x00031AE3 File Offset: 0x0002FCE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00031AEC File Offset: 0x0002FCEC
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001FA4 RID: 8100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FA5 RID: 8101
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04001FA6 RID: 8102
		private ErrorCode errorCode_;
	}
}
