using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D5 RID: 213
	[NetMessage(EMessageId.AdviceVoteResponse)]
	public sealed class AdviceVoteResponse : IMessage<AdviceVoteResponse>, IMessage, IEquatable<AdviceVoteResponse>, IDeepCloneable<AdviceVoteResponse>, IBufferMessage
	{
		// Token: 0x06002093 RID: 8339 RVA: 0x00057F2C File Offset: 0x0005612C
		[NullableContext(1)]
		public static AdviceVoteResponse Create()
		{
			return new AdviceVoteResponse();
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x00057F33 File Offset: 0x00056133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x00057F36 File Offset: 0x00056136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceVoteResponse.Descriptor;
			}
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00057F3D File Offset: 0x0005613D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteResponse()
		{
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00057F45 File Offset: 0x00056145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteResponse(AdviceVoteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00057F6A File Offset: 0x0005616A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteResponse Clone()
		{
			return new AdviceVoteResponse(this);
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x00057F72 File Offset: 0x00056172
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x00057F7A File Offset: 0x0005617A
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

		// Token: 0x0600209B RID: 8347 RVA: 0x00057F83 File Offset: 0x00056183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceVoteResponse);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00057F91 File Offset: 0x00056191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceVoteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00057FC0 File Offset: 0x000561C0
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

		// Token: 0x0600209E RID: 8350 RVA: 0x00058005 File Offset: 0x00056205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00058012 File Offset: 0x00056212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0005801B File Offset: 0x0005621B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00058050 File Offset: 0x00056250
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

		// Token: 0x060020A2 RID: 8354 RVA: 0x0005808E File Offset: 0x0005628E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceVoteResponse other)
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

		// Token: 0x060020A3 RID: 8355 RVA: 0x000580BF File Offset: 0x000562BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000580C8 File Offset: 0x000562C8
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002450 RID: 9296
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002451 RID: 9297
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002452 RID: 9298
		private ErrorCode errorCode_;
	}
}
