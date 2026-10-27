using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B2 RID: 2226
	[NetMessage(EMessageId.KurotatoResTaskReceiveRequest)]
	public sealed class KurotatoResTaskReceiveRequest : IMessage<KurotatoResTaskReceiveRequest>, IMessage, IEquatable<KurotatoResTaskReceiveRequest>, IDeepCloneable<KurotatoResTaskReceiveRequest>, IBufferMessage
	{
		// Token: 0x0600C58F RID: 50575 RVA: 0x001D3F17 File Offset: 0x001D2117
		[NullableContext(1)]
		public static KurotatoResTaskReceiveRequest Create()
		{
			return new KurotatoResTaskReceiveRequest();
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x0600C590 RID: 50576 RVA: 0x001D3F1E File Offset: 0x001D211E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x0600C591 RID: 50577 RVA: 0x001D3F21 File Offset: 0x001D2121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoResTaskReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0600C592 RID: 50578 RVA: 0x001D3F28 File Offset: 0x001D2128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveRequest()
		{
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x001D3F3B File Offset: 0x001D213B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveRequest(KurotatoResTaskReceiveRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C594 RID: 50580 RVA: 0x001D3F65 File Offset: 0x001D2165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveRequest Clone()
		{
			return new KurotatoResTaskReceiveRequest(this);
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x0600C595 RID: 50581 RVA: 0x001D3F6D File Offset: 0x001D216D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600C596 RID: 50582 RVA: 0x001D3F75 File Offset: 0x001D2175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoResTaskReceiveRequest);
		}

		// Token: 0x0600C597 RID: 50583 RVA: 0x001D3F83 File Offset: 0x001D2183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoResTaskReceiveRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C598 RID: 50584 RVA: 0x001D3FB8 File Offset: 0x001D21B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C599 RID: 50585 RVA: 0x001D3FEC File Offset: 0x001D21EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C59A RID: 50586 RVA: 0x001D3FF9 File Offset: 0x001D21F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C59B RID: 50587 RVA: 0x001D4002 File Offset: 0x001D2202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, KurotatoResTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C59C RID: 50588 RVA: 0x001D402C File Offset: 0x001D222C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(KurotatoResTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C59D RID: 50589 RVA: 0x001D4065 File Offset: 0x001D2265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoResTaskReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C59E RID: 50590 RVA: 0x001D4093 File Offset: 0x001D2293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C59F RID: 50591 RVA: 0x001D409C File Offset: 0x001D229C
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, KurotatoResTaskReceiveRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040054FD RID: 21757
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054FE RID: 21758
		public const int TaskIdsFieldNumber = 11;

		// Token: 0x040054FF RID: 21759
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005500 RID: 21760
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
