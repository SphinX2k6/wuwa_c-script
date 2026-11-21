using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FD RID: 509
	public sealed class BuffConsumerComponentPb : IMessage<BuffConsumerComponentPb>, IMessage, IEquatable<BuffConsumerComponentPb>, IDeepCloneable<BuffConsumerComponentPb>, IBufferMessage
	{
		// Token: 0x060038B8 RID: 14520 RVA: 0x0008E08F File Offset: 0x0008C28F
		[NullableContext(1)]
		public static BuffConsumerComponentPb Create()
		{
			return new BuffConsumerComponentPb();
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x0008E096 File Offset: 0x0008C296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x0008E099 File Offset: 0x0008C299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffConsumerComponentPb.Descriptor;
			}
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x0008E0A0 File Offset: 0x0008C2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffConsumerComponentPb()
		{
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x0008E0A8 File Offset: 0x0008C2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffConsumerComponentPb(BuffConsumerComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0008E0CD File Offset: 0x0008C2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffConsumerComponentPb Clone()
		{
			return new BuffConsumerComponentPb(this);
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x0008E0D5 File Offset: 0x0008C2D5
		// (set) Token: 0x060038BF RID: 14527 RVA: 0x0008E0DD File Offset: 0x0008C2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x0008E0E6 File Offset: 0x0008C2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffConsumerComponentPb);
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x0008E0F4 File Offset: 0x0008C2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffConsumerComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x0008E124 File Offset: 0x0008C324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0008E163 File Offset: 0x0008C363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0008E170 File Offset: 0x0008C370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x0008E179 File Offset: 0x0008C379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x0008E1AC File Offset: 0x0008C3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x0008E1EA File Offset: 0x0008C3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffConsumerComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x0008E21B File Offset: 0x0008C41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x0008E224 File Offset: 0x0008C424
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
					this.ContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002B9E RID: 11166
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B9F RID: 11167
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04002BA0 RID: 11168
		private long contextId_;
	}
}
