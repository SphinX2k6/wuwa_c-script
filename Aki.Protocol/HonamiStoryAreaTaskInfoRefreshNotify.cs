using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000752 RID: 1874
	[NetMessage(EMessageId.HonamiStoryAreaTaskInfoRefreshNotify)]
	public sealed class HonamiStoryAreaTaskInfoRefreshNotify : IMessage<HonamiStoryAreaTaskInfoRefreshNotify>, IMessage, IEquatable<HonamiStoryAreaTaskInfoRefreshNotify>, IDeepCloneable<HonamiStoryAreaTaskInfoRefreshNotify>, IBufferMessage
	{
		// Token: 0x0600AA07 RID: 43527 RVA: 0x00199B0D File Offset: 0x00197D0D
		[NullableContext(1)]
		public static HonamiStoryAreaTaskInfoRefreshNotify Create()
		{
			return new HonamiStoryAreaTaskInfoRefreshNotify();
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x0600AA08 RID: 43528 RVA: 0x00199B14 File Offset: 0x00197D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x0600AA09 RID: 43529 RVA: 0x00199B17 File Offset: 0x00197D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaTaskInfoRefreshNotify.Descriptor;
			}
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x00199B1E File Offset: 0x00197D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoRefreshNotify()
		{
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x00199B31 File Offset: 0x00197D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoRefreshNotify(HonamiStoryAreaTaskInfoRefreshNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x00199B5B File Offset: 0x00197D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoRefreshNotify Clone()
		{
			return new HonamiStoryAreaTaskInfoRefreshNotify(this);
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x0600AA0D RID: 43533 RVA: 0x00199B63 File Offset: 0x00197D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x00199B6B File Offset: 0x00197D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaTaskInfoRefreshNotify);
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x00199B79 File Offset: 0x00197D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaTaskInfoRefreshNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x00199BAC File Offset: 0x00197DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x00199BE0 File Offset: 0x00197DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x00199BED File Offset: 0x00197DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x00199BF6 File Offset: 0x00197DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, HonamiStoryAreaTaskInfoRefreshNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x00199C20 File Offset: 0x00197E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(HonamiStoryAreaTaskInfoRefreshNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x00199C59 File Offset: 0x00197E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaTaskInfoRefreshNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x00199C87 File Offset: 0x00197E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x00199C90 File Offset: 0x00197E90
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, HonamiStoryAreaTaskInfoRefreshNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04004DC8 RID: 19912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DC9 RID: 19913
		public const int ConditionTasksFieldNumber = 12;

		// Token: 0x04004DCA RID: 19914
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(98U, ConditionTask.Parser);

		// Token: 0x04004DCB RID: 19915
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
