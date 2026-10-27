using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EA RID: 490
	[NetMessage(EMessageId.BtGiveUpResponse)]
	public sealed class BtGiveUpResponse : IMessage<BtGiveUpResponse>, IMessage, IEquatable<BtGiveUpResponse>, IDeepCloneable<BtGiveUpResponse>, IBufferMessage
	{
		// Token: 0x060036DF RID: 14047 RVA: 0x000896B6 File Offset: 0x000878B6
		[NullableContext(1)]
		public static BtGiveUpResponse Create()
		{
			return new BtGiveUpResponse();
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x000896BD File Offset: 0x000878BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060036E1 RID: 14049 RVA: 0x000896C0 File Offset: 0x000878C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtGiveUpResponse.Descriptor;
			}
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x000896C7 File Offset: 0x000878C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpResponse()
		{
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x000896CF File Offset: 0x000878CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpResponse(BtGiveUpResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x000896F4 File Offset: 0x000878F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpResponse Clone()
		{
			return new BtGiveUpResponse(this);
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060036E5 RID: 14053 RVA: 0x000896FC File Offset: 0x000878FC
		// (set) Token: 0x060036E6 RID: 14054 RVA: 0x00089704 File Offset: 0x00087904
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

		// Token: 0x060036E7 RID: 14055 RVA: 0x0008970D File Offset: 0x0008790D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtGiveUpResponse);
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x0008971B File Offset: 0x0008791B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtGiveUpResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x0008974C File Offset: 0x0008794C
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

		// Token: 0x060036EA RID: 14058 RVA: 0x00089791 File Offset: 0x00087991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x0008979E File Offset: 0x0008799E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x000897A7 File Offset: 0x000879A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x000897DC File Offset: 0x000879DC
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

		// Token: 0x060036EE RID: 14062 RVA: 0x0008981A File Offset: 0x00087A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtGiveUpResponse other)
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

		// Token: 0x060036EF RID: 14063 RVA: 0x0008984B File Offset: 0x00087A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00089854 File Offset: 0x00087A54
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002ABA RID: 10938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ABB RID: 10939
		public const int ErrorIdFieldNumber = 9;

		// Token: 0x04002ABC RID: 10940
		private ErrorCode errorId_;
	}
}
