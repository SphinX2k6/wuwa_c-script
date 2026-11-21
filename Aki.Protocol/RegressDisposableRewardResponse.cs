using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED0 RID: 3792
	[NetMessage(EMessageId.RegressDisposableRewardResponse)]
	public sealed class RegressDisposableRewardResponse : IMessage<RegressDisposableRewardResponse>, IMessage, IEquatable<RegressDisposableRewardResponse>, IDeepCloneable<RegressDisposableRewardResponse>, IBufferMessage
	{
		// Token: 0x060145B5 RID: 83381 RVA: 0x002F61EA File Offset: 0x002F43EA
		[NullableContext(1)]
		public static RegressDisposableRewardResponse Create()
		{
			return new RegressDisposableRewardResponse();
		}

		// Token: 0x170043BA RID: 17338
		// (get) Token: 0x060145B6 RID: 83382 RVA: 0x002F61F1 File Offset: 0x002F43F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043BB RID: 17339
		// (get) Token: 0x060145B7 RID: 83383 RVA: 0x002F61F4 File Offset: 0x002F43F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressDisposableRewardResponse.Descriptor;
			}
		}

		// Token: 0x060145B8 RID: 83384 RVA: 0x002F61FB File Offset: 0x002F43FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardResponse()
		{
		}

		// Token: 0x060145B9 RID: 83385 RVA: 0x002F6203 File Offset: 0x002F4403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardResponse(RegressDisposableRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145BA RID: 83386 RVA: 0x002F6228 File Offset: 0x002F4428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardResponse Clone()
		{
			return new RegressDisposableRewardResponse(this);
		}

		// Token: 0x170043BC RID: 17340
		// (get) Token: 0x060145BB RID: 83387 RVA: 0x002F6230 File Offset: 0x002F4430
		// (set) Token: 0x060145BC RID: 83388 RVA: 0x002F6238 File Offset: 0x002F4438
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

		// Token: 0x060145BD RID: 83389 RVA: 0x002F6241 File Offset: 0x002F4441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressDisposableRewardResponse);
		}

		// Token: 0x060145BE RID: 83390 RVA: 0x002F624F File Offset: 0x002F444F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressDisposableRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060145BF RID: 83391 RVA: 0x002F6280 File Offset: 0x002F4480
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

		// Token: 0x060145C0 RID: 83392 RVA: 0x002F62C5 File Offset: 0x002F44C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145C1 RID: 83393 RVA: 0x002F62D2 File Offset: 0x002F44D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145C2 RID: 83394 RVA: 0x002F62DB File Offset: 0x002F44DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145C3 RID: 83395 RVA: 0x002F6310 File Offset: 0x002F4510
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

		// Token: 0x060145C4 RID: 83396 RVA: 0x002F634E File Offset: 0x002F454E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressDisposableRewardResponse other)
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

		// Token: 0x060145C5 RID: 83397 RVA: 0x002F637F File Offset: 0x002F457F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145C6 RID: 83398 RVA: 0x002F6388 File Offset: 0x002F4588
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C1A RID: 31770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C1B RID: 31771
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007C1C RID: 31772
		private ErrorCode errorCode_;
	}
}
