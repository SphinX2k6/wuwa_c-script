using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A9 RID: 2473
	[NetMessage(EMessageId.MatchFailNotify)]
	public sealed class MatchFailNotify : IMessage<MatchFailNotify>, IMessage, IEquatable<MatchFailNotify>, IDeepCloneable<MatchFailNotify>, IBufferMessage
	{
		// Token: 0x0600D955 RID: 55637 RVA: 0x001FEE95 File Offset: 0x001FD095
		[NullableContext(1)]
		public static MatchFailNotify Create()
		{
			return new MatchFailNotify();
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x0600D956 RID: 55638 RVA: 0x001FEE9C File Offset: 0x001FD09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x0600D957 RID: 55639 RVA: 0x001FEE9F File Offset: 0x001FD09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchFailNotify.Descriptor;
			}
		}

		// Token: 0x0600D958 RID: 55640 RVA: 0x001FEEA6 File Offset: 0x001FD0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchFailNotify()
		{
		}

		// Token: 0x0600D959 RID: 55641 RVA: 0x001FEEAE File Offset: 0x001FD0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchFailNotify(MatchFailNotify other) : this()
		{
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D95A RID: 55642 RVA: 0x001FEED3 File Offset: 0x001FD0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchFailNotify Clone()
		{
			return new MatchFailNotify(this);
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x0600D95B RID: 55643 RVA: 0x001FEEDB File Offset: 0x001FD0DB
		// (set) Token: 0x0600D95C RID: 55644 RVA: 0x001FEEE3 File Offset: 0x001FD0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchFailReason Reason
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

		// Token: 0x0600D95D RID: 55645 RVA: 0x001FEEEC File Offset: 0x001FD0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchFailNotify);
		}

		// Token: 0x0600D95E RID: 55646 RVA: 0x001FEEFA File Offset: 0x001FD0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchFailNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D95F RID: 55647 RVA: 0x001FEF28 File Offset: 0x001FD128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != MatchFailReason.TimeOut)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D960 RID: 55648 RVA: 0x001FEF6D File Offset: 0x001FD16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D961 RID: 55649 RVA: 0x001FEF7A File Offset: 0x001FD17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D962 RID: 55650 RVA: 0x001FEF83 File Offset: 0x001FD183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != MatchFailReason.TimeOut)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D963 RID: 55651 RVA: 0x001FEFB8 File Offset: 0x001FD1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != MatchFailReason.TimeOut)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D964 RID: 55652 RVA: 0x001FEFF6 File Offset: 0x001FD1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchFailNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != MatchFailReason.TimeOut)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D965 RID: 55653 RVA: 0x001FF027 File Offset: 0x001FD227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D966 RID: 55654 RVA: 0x001FF030 File Offset: 0x001FD230
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
					this.Reason = (MatchFailReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005ABB RID: 23227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ABC RID: 23228
		public const int ReasonFieldNumber = 2;

		// Token: 0x04005ABD RID: 23229
		private MatchFailReason reason_;
	}
}
