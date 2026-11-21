using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AA RID: 2218
	[NetMessage(EMessageId.KurotatoScoreTaskReceiveRequest)]
	public sealed class KurotatoScoreTaskReceiveRequest : IMessage<KurotatoScoreTaskReceiveRequest>, IMessage, IEquatable<KurotatoScoreTaskReceiveRequest>, IDeepCloneable<KurotatoScoreTaskReceiveRequest>, IBufferMessage
	{
		// Token: 0x0600C51F RID: 50463 RVA: 0x001D3051 File Offset: 0x001D1251
		[NullableContext(1)]
		public static KurotatoScoreTaskReceiveRequest Create()
		{
			return new KurotatoScoreTaskReceiveRequest();
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x0600C520 RID: 50464 RVA: 0x001D3058 File Offset: 0x001D1258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x0600C521 RID: 50465 RVA: 0x001D305B File Offset: 0x001D125B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoScoreTaskReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0600C522 RID: 50466 RVA: 0x001D3062 File Offset: 0x001D1262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveRequest()
		{
		}

		// Token: 0x0600C523 RID: 50467 RVA: 0x001D3075 File Offset: 0x001D1275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveRequest(KurotatoScoreTaskReceiveRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C524 RID: 50468 RVA: 0x001D309F File Offset: 0x001D129F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveRequest Clone()
		{
			return new KurotatoScoreTaskReceiveRequest(this);
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x0600C525 RID: 50469 RVA: 0x001D30A7 File Offset: 0x001D12A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600C526 RID: 50470 RVA: 0x001D30AF File Offset: 0x001D12AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoScoreTaskReceiveRequest);
		}

		// Token: 0x0600C527 RID: 50471 RVA: 0x001D30BD File Offset: 0x001D12BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoScoreTaskReceiveRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C528 RID: 50472 RVA: 0x001D30F0 File Offset: 0x001D12F0
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

		// Token: 0x0600C529 RID: 50473 RVA: 0x001D3124 File Offset: 0x001D1324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x001D3131 File Offset: 0x001D1331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C52B RID: 50475 RVA: 0x001D313A File Offset: 0x001D133A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, KurotatoScoreTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C52C RID: 50476 RVA: 0x001D3164 File Offset: 0x001D1364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(KurotatoScoreTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C52D RID: 50477 RVA: 0x001D319D File Offset: 0x001D139D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoScoreTaskReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C52E RID: 50478 RVA: 0x001D31CB File Offset: 0x001D13CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C52F RID: 50479 RVA: 0x001D31D4 File Offset: 0x001D13D4
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, KurotatoScoreTaskReceiveRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x0400552C RID: 21804
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400552D RID: 21805
		public const int TaskIdsFieldNumber = 15;

		// Token: 0x0400552E RID: 21806
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400552F RID: 21807
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
