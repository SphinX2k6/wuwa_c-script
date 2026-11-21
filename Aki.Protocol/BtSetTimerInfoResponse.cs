using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F8 RID: 504
	[NetMessage(EMessageId.BtSetTimerInfoResponse)]
	public sealed class BtSetTimerInfoResponse : IMessage<BtSetTimerInfoResponse>, IMessage, IEquatable<BtSetTimerInfoResponse>, IDeepCloneable<BtSetTimerInfoResponse>, IBufferMessage
	{
		// Token: 0x0600384A RID: 14410 RVA: 0x0008CFF4 File Offset: 0x0008B1F4
		[NullableContext(1)]
		public static BtSetTimerInfoResponse Create()
		{
			return new BtSetTimerInfoResponse();
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600384B RID: 14411 RVA: 0x0008CFFB File Offset: 0x0008B1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600384C RID: 14412 RVA: 0x0008CFFE File Offset: 0x0008B1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtSetTimerInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x0008D005 File Offset: 0x0008B205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoResponse()
		{
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x0008D00D File Offset: 0x0008B20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoResponse(BtSetTimerInfoResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x0008D032 File Offset: 0x0008B232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoResponse Clone()
		{
			return new BtSetTimerInfoResponse(this);
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x0008D03A File Offset: 0x0008B23A
		// (set) Token: 0x06003851 RID: 14417 RVA: 0x0008D042 File Offset: 0x0008B242
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

		// Token: 0x06003852 RID: 14418 RVA: 0x0008D04B File Offset: 0x0008B24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtSetTimerInfoResponse);
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x0008D059 File Offset: 0x0008B259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtSetTimerInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x0008D088 File Offset: 0x0008B288
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

		// Token: 0x06003855 RID: 14421 RVA: 0x0008D0CD File Offset: 0x0008B2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x0008D0DA File Offset: 0x0008B2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x0008D0E3 File Offset: 0x0008B2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x0008D118 File Offset: 0x0008B318
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

		// Token: 0x06003859 RID: 14425 RVA: 0x0008D156 File Offset: 0x0008B356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtSetTimerInfoResponse other)
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

		// Token: 0x0600385A RID: 14426 RVA: 0x0008D187 File Offset: 0x0008B387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x0008D190 File Offset: 0x0008B390
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002B7A RID: 11130
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B7B RID: 11131
		public const int ErrorIdFieldNumber = 8;

		// Token: 0x04002B7C RID: 11132
		private ErrorCode errorId_;
	}
}
