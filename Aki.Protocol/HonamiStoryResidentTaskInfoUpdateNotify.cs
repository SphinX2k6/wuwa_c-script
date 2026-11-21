using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000785 RID: 1925
	[NetMessage(EMessageId.HonamiStoryResidentTaskInfoUpdateNotify)]
	public sealed class HonamiStoryResidentTaskInfoUpdateNotify : IMessage<HonamiStoryResidentTaskInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryResidentTaskInfoUpdateNotify>, IDeepCloneable<HonamiStoryResidentTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AE1D RID: 44573 RVA: 0x001A27F4 File Offset: 0x001A09F4
		[NullableContext(1)]
		public static HonamiStoryResidentTaskInfoUpdateNotify Create()
		{
			return new HonamiStoryResidentTaskInfoUpdateNotify();
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x0600AE1E RID: 44574 RVA: 0x001A27FB File Offset: 0x001A09FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x0600AE1F RID: 44575 RVA: 0x001A27FE File Offset: 0x001A09FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryResidentTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x001A2805 File Offset: 0x001A0A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x001A2818 File Offset: 0x001A0A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskInfoUpdateNotify(HonamiStoryResidentTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x001A2842 File Offset: 0x001A0A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskInfoUpdateNotify Clone()
		{
			return new HonamiStoryResidentTaskInfoUpdateNotify(this);
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x0600AE23 RID: 44579 RVA: 0x001A284A File Offset: 0x001A0A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600AE24 RID: 44580 RVA: 0x001A2852 File Offset: 0x001A0A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryResidentTaskInfoUpdateNotify);
		}

		// Token: 0x0600AE25 RID: 44581 RVA: 0x001A2860 File Offset: 0x001A0A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryResidentTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE26 RID: 44582 RVA: 0x001A2894 File Offset: 0x001A0A94
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

		// Token: 0x0600AE27 RID: 44583 RVA: 0x001A28C8 File Offset: 0x001A0AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE28 RID: 44584 RVA: 0x001A28D5 File Offset: 0x001A0AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE29 RID: 44585 RVA: 0x001A28DE File Offset: 0x001A0ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, HonamiStoryResidentTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE2A RID: 44586 RVA: 0x001A2908 File Offset: 0x001A0B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(HonamiStoryResidentTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE2B RID: 44587 RVA: 0x001A2941 File Offset: 0x001A0B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryResidentTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE2C RID: 44588 RVA: 0x001A296F File Offset: 0x001A0B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE2D RID: 44589 RVA: 0x001A2978 File Offset: 0x001A0B78
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, HonamiStoryResidentTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04004EF4 RID: 20212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EF5 RID: 20213
		public const int ConditionTasksFieldNumber = 15;

		// Token: 0x04004EF6 RID: 20214
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(122U, ConditionTask.Parser);

		// Token: 0x04004EF7 RID: 20215
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
