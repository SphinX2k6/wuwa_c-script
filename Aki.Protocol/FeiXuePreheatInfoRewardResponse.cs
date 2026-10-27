using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000534 RID: 1332
	[NetMessage(EMessageId.FeiXuePreheatInfoRewardResponse)]
	public sealed class FeiXuePreheatInfoRewardResponse : IMessage<FeiXuePreheatInfoRewardResponse>, IMessage, IEquatable<FeiXuePreheatInfoRewardResponse>, IDeepCloneable<FeiXuePreheatInfoRewardResponse>, IBufferMessage
	{
		// Token: 0x06007CC0 RID: 31936 RVA: 0x0012E1DF File Offset: 0x0012C3DF
		[NullableContext(1)]
		public static FeiXuePreheatInfoRewardResponse Create()
		{
			return new FeiXuePreheatInfoRewardResponse();
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06007CC1 RID: 31937 RVA: 0x0012E1E6 File Offset: 0x0012C3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x0012E1E9 File Offset: 0x0012C3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatInfoRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007CC3 RID: 31939 RVA: 0x0012E1F0 File Offset: 0x0012C3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardResponse()
		{
		}

		// Token: 0x06007CC4 RID: 31940 RVA: 0x0012E1F8 File Offset: 0x0012C3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardResponse(FeiXuePreheatInfoRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CC5 RID: 31941 RVA: 0x0012E21D File Offset: 0x0012C41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardResponse Clone()
		{
			return new FeiXuePreheatInfoRewardResponse(this);
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06007CC6 RID: 31942 RVA: 0x0012E225 File Offset: 0x0012C425
		// (set) Token: 0x06007CC7 RID: 31943 RVA: 0x0012E22D File Offset: 0x0012C42D
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

		// Token: 0x06007CC8 RID: 31944 RVA: 0x0012E236 File Offset: 0x0012C436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatInfoRewardResponse);
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x0012E244 File Offset: 0x0012C444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatInfoRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x0012E274 File Offset: 0x0012C474
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

		// Token: 0x06007CCB RID: 31947 RVA: 0x0012E2B9 File Offset: 0x0012C4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x0012E2C6 File Offset: 0x0012C4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x0012E2CF File Offset: 0x0012C4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x0012E304 File Offset: 0x0012C504
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

		// Token: 0x06007CCF RID: 31951 RVA: 0x0012E342 File Offset: 0x0012C542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeiXuePreheatInfoRewardResponse other)
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

		// Token: 0x06007CD0 RID: 31952 RVA: 0x0012E373 File Offset: 0x0012C573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x0012E37C File Offset: 0x0012C57C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F85 RID: 16261
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F86 RID: 16262
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003F87 RID: 16263
		private ErrorCode errorCode_;
	}
}
