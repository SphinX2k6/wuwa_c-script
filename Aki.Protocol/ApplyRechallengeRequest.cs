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
		// Token: 0x0600251B RID: 9499 RVA: 0x0006367B File Offset: 0x0006187B
		[NullableContext(1)]
		public static ApplyRechallengeRequest Create()
		{
			return new ApplyRechallengeRequest();
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x00063682 File Offset: 0x00061882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x00063685 File Offset: 0x00061885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyRechallengeRequest.Descriptor;
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x0006368C File Offset: 0x0006188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeRequest()
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00063694 File Offset: 0x00061894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeRequest(ApplyRechallengeRequest other) : this()
		{
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000636B9 File Offset: 0x000618B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeRequest Clone()
		{
			return new ApplyRechallengeRequest(this);
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x000636C1 File Offset: 0x000618C1
		// (set) Token: 0x06002522 RID: 9506 RVA: 0x000636C9 File Offset: 0x000618C9
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

		// Token: 0x06002523 RID: 9507 RVA: 0x000636D2 File Offset: 0x000618D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyRechallengeRequest);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000636E0 File Offset: 0x000618E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyRechallengeRequest other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00063710 File Offset: 0x00061910
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

		// Token: 0x06002526 RID: 9510 RVA: 0x00063755 File Offset: 0x00061955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00063762 File Offset: 0x00061962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0006376B File Offset: 0x0006196B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != ApplyRechallengeReason.Settle)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000637A0 File Offset: 0x000619A0
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

		// Token: 0x0600252A RID: 9514 RVA: 0x000637DE File Offset: 0x000619DE
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

		// Token: 0x0600252B RID: 9515 RVA: 0x0006380F File Offset: 0x00061A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00063818 File Offset: 0x00061A18
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Reason = (ApplyRechallengeReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x040025FC RID: 9724
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025FD RID: 9725
		public const int ReasonFieldNumber = 12;

		// Token: 0x040025FE RID: 9726
		private ApplyRechallengeReason reason_;
	}
}
