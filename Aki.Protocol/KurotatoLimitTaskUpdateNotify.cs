using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A6 RID: 2214
	[NetMessage(EMessageId.KurotatoLimitTaskUpdateNotify)]
	public sealed class KurotatoLimitTaskUpdateNotify : IMessage<KurotatoLimitTaskUpdateNotify>, IMessage, IEquatable<KurotatoLimitTaskUpdateNotify>, IDeepCloneable<KurotatoLimitTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C4AA RID: 50346 RVA: 0x001D2409 File Offset: 0x001D0609
		[NullableContext(1)]
		public static KurotatoLimitTaskUpdateNotify Create()
		{
			return new KurotatoLimitTaskUpdateNotify();
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x0600C4AB RID: 50347 RVA: 0x001D2410 File Offset: 0x001D0610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x0600C4AC RID: 50348 RVA: 0x001D2413 File Offset: 0x001D0613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLimitTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x001D241A File Offset: 0x001D061A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskUpdateNotify()
		{
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x001D242D File Offset: 0x001D062D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskUpdateNotify(KurotatoLimitTaskUpdateNotify other) : this()
		{
			this.limitTasks_ = other.limitTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x001D2457 File Offset: 0x001D0657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskUpdateNotify Clone()
		{
			return new KurotatoLimitTaskUpdateNotify(this);
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x0600C4B0 RID: 50352 RVA: 0x001D245F File Offset: 0x001D065F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> LimitTasks
		{
			get
			{
				return this.limitTasks_;
			}
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x001D2467 File Offset: 0x001D0667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLimitTaskUpdateNotify);
		}

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x001D2475 File Offset: 0x001D0675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLimitTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.limitTasks_.Equals(other.limitTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x001D24A8 File Offset: 0x001D06A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.limitTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4B4 RID: 50356 RVA: 0x001D24DC File Offset: 0x001D06DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x001D24E9 File Offset: 0x001D06E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4B6 RID: 50358 RVA: 0x001D24F2 File Offset: 0x001D06F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.limitTasks_.WriteTo(ref output, KurotatoLimitTaskUpdateNotify._repeated_limitTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x001D251C File Offset: 0x001D071C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.limitTasks_.CalculateSize(KurotatoLimitTaskUpdateNotify._repeated_limitTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x001D2555 File Offset: 0x001D0755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLimitTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.limitTasks_.Add(other.limitTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4B9 RID: 50361 RVA: 0x001D2583 File Offset: 0x001D0783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x001D258C File Offset: 0x001D078C
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.limitTasks_.AddEntriesFrom(ref input, KurotatoLimitTaskUpdateNotify._repeated_limitTasks_codec);
				}
			}
		}

		// Token: 0x040054C8 RID: 21704
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054C9 RID: 21705
		public const int LimitTasksFieldNumber = 13;

		// Token: 0x040054CA RID: 21706
		private static readonly FieldCodec<ConditionTask> _repeated_limitTasks_codec = FieldCodec.ForMessage<ConditionTask>(106U, ConditionTask.Parser);

		// Token: 0x040054CB RID: 21707
		private readonly RepeatedField<ConditionTask> limitTasks_ = new RepeatedField<ConditionTask>();
	}
}
