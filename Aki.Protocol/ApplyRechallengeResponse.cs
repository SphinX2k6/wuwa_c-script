using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000109 RID: 265
	[NetMessage(EMessageId.ApplyRechallengeResponse)]
	public sealed class ApplyRechallengeResponse : IMessage<ApplyRechallengeResponse>, IMessage, IEquatable<ApplyRechallengeResponse>, IDeepCloneable<ApplyRechallengeResponse>, IBufferMessage
	{
		// Token: 0x060024F6 RID: 9462 RVA: 0x00062D81 File Offset: 0x00060F81
		[NullableContext(1)]
		public static ApplyRechallengeResponse Create()
		{
			return new ApplyRechallengeResponse();
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x00062D88 File Offset: 0x00060F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x00062D8B File Offset: 0x00060F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyRechallengeResponse.Descriptor;
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00062D92 File Offset: 0x00060F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeResponse()
		{
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00062D9A File Offset: 0x00060F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeResponse(ApplyRechallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00062DBF File Offset: 0x00060FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeResponse Clone()
		{
			return new ApplyRechallengeResponse(this);
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x00062DC7 File Offset: 0x00060FC7
		// (set) Token: 0x060024FD RID: 9469 RVA: 0x00062DCF File Offset: 0x00060FCF
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

		// Token: 0x060024FE RID: 9470 RVA: 0x00062DD8 File Offset: 0x00060FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyRechallengeResponse);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x00062DE6 File Offset: 0x00060FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyRechallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x00062E14 File Offset: 0x00061014
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

		// Token: 0x06002501 RID: 9473 RVA: 0x00062E59 File Offset: 0x00061059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00062E66 File Offset: 0x00061066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00062E6F File Offset: 0x0006106F
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

		// Token: 0x06002504 RID: 9476 RVA: 0x00062EA0 File Offset: 0x000610A0
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

		// Token: 0x06002505 RID: 9477 RVA: 0x00062EDE File Offset: 0x000610DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyRechallengeResponse other)
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

		// Token: 0x06002506 RID: 9478 RVA: 0x00062F0F File Offset: 0x0006110F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00062F18 File Offset: 0x00061118
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

		// Token: 0x040025A0 RID: 9632
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025A1 RID: 9633
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040025A2 RID: 9634
		private ErrorCode errorCode_;
	}
}
