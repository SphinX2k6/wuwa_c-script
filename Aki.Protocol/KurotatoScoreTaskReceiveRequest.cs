using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BB RID: 2235
	[NetMessage(EMessageId.KurotatoScoreTaskReceiveRequest)]
	public sealed class KurotatoScoreTaskReceiveRequest : IMessage<KurotatoScoreTaskReceiveRequest>, IMessage, IEquatable<KurotatoScoreTaskReceiveRequest>, IDeepCloneable<KurotatoScoreTaskReceiveRequest>, IBufferMessage
	{
		// Token: 0x0600C63B RID: 50747 RVA: 0x001D5339 File Offset: 0x001D3539
		[NullableContext(1)]
		public static KurotatoScoreTaskReceiveRequest Create()
		{
			return new KurotatoScoreTaskReceiveRequest();
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x0600C63C RID: 50748 RVA: 0x001D5340 File Offset: 0x001D3540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x0600C63D RID: 50749 RVA: 0x001D5343 File Offset: 0x001D3543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoScoreTaskReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0600C63E RID: 50750 RVA: 0x001D534A File Offset: 0x001D354A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveRequest()
		{
		}

		// Token: 0x0600C63F RID: 50751 RVA: 0x001D535D File Offset: 0x001D355D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveRequest(KurotatoScoreTaskReceiveRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C640 RID: 50752 RVA: 0x001D5387 File Offset: 0x001D3587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveRequest Clone()
		{
			return new KurotatoScoreTaskReceiveRequest(this);
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x0600C641 RID: 50753 RVA: 0x001D538F File Offset: 0x001D358F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600C642 RID: 50754 RVA: 0x001D5397 File Offset: 0x001D3597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoScoreTaskReceiveRequest);
		}

		// Token: 0x0600C643 RID: 50755 RVA: 0x001D53A5 File Offset: 0x001D35A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoScoreTaskReceiveRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C644 RID: 50756 RVA: 0x001D53D8 File Offset: 0x001D35D8
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

		// Token: 0x0600C645 RID: 50757 RVA: 0x001D540C File Offset: 0x001D360C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C646 RID: 50758 RVA: 0x001D5419 File Offset: 0x001D3619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C647 RID: 50759 RVA: 0x001D5422 File Offset: 0x001D3622
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

		// Token: 0x0600C648 RID: 50760 RVA: 0x001D544C File Offset: 0x001D364C
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

		// Token: 0x0600C649 RID: 50761 RVA: 0x001D5485 File Offset: 0x001D3685
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

		// Token: 0x0600C64A RID: 50762 RVA: 0x001D54B3 File Offset: 0x001D36B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x001D54BC File Offset: 0x001D36BC
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, KurotatoScoreTaskReceiveRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04005525 RID: 21797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005526 RID: 21798
		public const int TaskIdsFieldNumber = 13;

		// Token: 0x04005527 RID: 21799
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04005528 RID: 21800
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
