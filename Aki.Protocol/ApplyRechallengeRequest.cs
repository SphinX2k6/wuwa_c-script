using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000108 RID: 264
	[NetMessage(EMessageId.ApplyRechallengeRequest)]
	public sealed class ApplyRechallengeRequest : IMessage<ApplyRechallengeRequest>, IMessage, IEquatable<ApplyRechallengeRequest>, IDeepCloneable<ApplyRechallengeRequest>, IBufferMessage
	{
		// Token: 0x060024E4 RID: 9444 RVA: 0x00062B9F File Offset: 0x00060D9F
		[NullableContext(1)]
		public static ApplyRechallengeRequest Create()
		{
			return new ApplyRechallengeRequest();
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x00062BA6 File Offset: 0x00060DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x00062BA9 File Offset: 0x00060DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyRechallengeRequest.Descriptor;
			}
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00062BB0 File Offset: 0x00060DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeRequest()
		{
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00062BB8 File Offset: 0x00060DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeRequest(ApplyRechallengeRequest other) : this()
		{
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00062BDD File Offset: 0x00060DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeRequest Clone()
		{
			return new ApplyRechallengeRequest(this);
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x00062BE5 File Offset: 0x00060DE5
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00062BED File Offset: 0x00060DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00062BF6 File Offset: 0x00060DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyRechallengeRequest);
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00062C04 File Offset: 0x00060E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyRechallengeRequest other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00062C34 File Offset: 0x00060E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != ApplyRechallengeReason.Settle)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00062C79 File Offset: 0x00060E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00062C86 File Offset: 0x00060E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00062C8F File Offset: 0x00060E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != ApplyRechallengeReason.Settle)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00062CC4 File Offset: 0x00060EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != ApplyRechallengeReason.Settle)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00062D02 File Offset: 0x00060F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyRechallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != ApplyRechallengeReason.Settle)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00062D33 File Offset: 0x00060F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00062D3C File Offset: 0x00060F3C
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
					this.Reason = (ApplyRechallengeReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400259D RID: 9629
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400259E RID: 9630
		public const int ReasonFieldNumber = 6;

		// Token: 0x0400259F RID: 9631
		private ApplyRechallengeReason reason_;
	}
}
