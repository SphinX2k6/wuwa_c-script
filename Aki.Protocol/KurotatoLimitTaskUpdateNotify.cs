using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000895 RID: 2197
	[NetMessage(EMessageId.KurotatoLimitTaskUpdateNotify)]
	public sealed class KurotatoLimitTaskUpdateNotify : IMessage<KurotatoLimitTaskUpdateNotify>, IMessage, IEquatable<KurotatoLimitTaskUpdateNotify>, IDeepCloneable<KurotatoLimitTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C38E RID: 50062 RVA: 0x001D0129 File Offset: 0x001CE329
		[NullableContext(1)]
		public static KurotatoLimitTaskUpdateNotify Create()
		{
			return new KurotatoLimitTaskUpdateNotify();
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x0600C38F RID: 50063 RVA: 0x001D0130 File Offset: 0x001CE330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x0600C390 RID: 50064 RVA: 0x001D0133 File Offset: 0x001CE333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLimitTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x001D013A File Offset: 0x001CE33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskUpdateNotify()
		{
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x001D014D File Offset: 0x001CE34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskUpdateNotify(KurotatoLimitTaskUpdateNotify other) : this()
		{
			this.limitTasks_ = other.limitTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x001D0177 File Offset: 0x001CE377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskUpdateNotify Clone()
		{
			return new KurotatoLimitTaskUpdateNotify(this);
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x0600C394 RID: 50068 RVA: 0x001D017F File Offset: 0x001CE37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> LimitTasks
		{
			get
			{
				return this.limitTasks_;
			}
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x001D0187 File Offset: 0x001CE387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLimitTaskUpdateNotify);
		}

		// Token: 0x0600C396 RID: 50070 RVA: 0x001D0195 File Offset: 0x001CE395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLimitTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.limitTasks_.Equals(other.limitTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C397 RID: 50071 RVA: 0x001D01C8 File Offset: 0x001CE3C8
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

		// Token: 0x0600C398 RID: 50072 RVA: 0x001D01FC File Offset: 0x001CE3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x001D0209 File Offset: 0x001CE409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C39A RID: 50074 RVA: 0x001D0212 File Offset: 0x001CE412
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

		// Token: 0x0600C39B RID: 50075 RVA: 0x001D023C File Offset: 0x001CE43C
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

		// Token: 0x0600C39C RID: 50076 RVA: 0x001D0275 File Offset: 0x001CE475
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

		// Token: 0x0600C39D RID: 50077 RVA: 0x001D02A3 File Offset: 0x001CE4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x001D02AC File Offset: 0x001CE4AC
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

		// Token: 0x040054CF RID: 21711
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054D0 RID: 21712
		public const int LimitTasksFieldNumber = 13;

		// Token: 0x040054D1 RID: 21713
		private static readonly FieldCodec<ConditionTask> _repeated_limitTasks_codec = FieldCodec.ForMessage<ConditionTask>(106U, ConditionTask.Parser);

		// Token: 0x040054D2 RID: 21714
		private readonly RepeatedField<ConditionTask> limitTasks_ = new RepeatedField<ConditionTask>();
	}
}
