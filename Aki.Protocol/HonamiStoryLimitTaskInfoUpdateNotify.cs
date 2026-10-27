using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000788 RID: 1928
	[NetMessage(EMessageId.HonamiStoryLimitTaskInfoUpdateNotify)]
	public sealed class HonamiStoryLimitTaskInfoUpdateNotify : IMessage<HonamiStoryLimitTaskInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryLimitTaskInfoUpdateNotify>, IDeepCloneable<HonamiStoryLimitTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AE25 RID: 44581 RVA: 0x001A27E4 File Offset: 0x001A09E4
		[NullableContext(1)]
		public static HonamiStoryLimitTaskInfoUpdateNotify Create()
		{
			return new HonamiStoryLimitTaskInfoUpdateNotify();
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x0600AE26 RID: 44582 RVA: 0x001A27EB File Offset: 0x001A09EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x0600AE27 RID: 44583 RVA: 0x001A27EE File Offset: 0x001A09EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLimitTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AE28 RID: 44584 RVA: 0x001A27F5 File Offset: 0x001A09F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0600AE29 RID: 44585 RVA: 0x001A2808 File Offset: 0x001A0A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskInfoUpdateNotify(HonamiStoryLimitTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE2A RID: 44586 RVA: 0x001A2832 File Offset: 0x001A0A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskInfoUpdateNotify Clone()
		{
			return new HonamiStoryLimitTaskInfoUpdateNotify(this);
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x0600AE2B RID: 44587 RVA: 0x001A283A File Offset: 0x001A0A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600AE2C RID: 44588 RVA: 0x001A2842 File Offset: 0x001A0A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLimitTaskInfoUpdateNotify);
		}

		// Token: 0x0600AE2D RID: 44589 RVA: 0x001A2850 File Offset: 0x001A0A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLimitTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE2E RID: 44590 RVA: 0x001A2884 File Offset: 0x001A0A84
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

		// Token: 0x0600AE2F RID: 44591 RVA: 0x001A28B8 File Offset: 0x001A0AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE30 RID: 44592 RVA: 0x001A28C5 File Offset: 0x001A0AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE31 RID: 44593 RVA: 0x001A28CE File Offset: 0x001A0ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, HonamiStoryLimitTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE32 RID: 44594 RVA: 0x001A28F8 File Offset: 0x001A0AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(HonamiStoryLimitTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE33 RID: 44595 RVA: 0x001A2931 File Offset: 0x001A0B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLimitTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x001A295F File Offset: 0x001A0B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE35 RID: 44597 RVA: 0x001A2968 File Offset: 0x001A0B68
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, HonamiStoryLimitTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04004EA6 RID: 20134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EA7 RID: 20135
		public const int ConditionTasksFieldNumber = 5;

		// Token: 0x04004EA8 RID: 20136
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(42U, ConditionTask.Parser);

		// Token: 0x04004EA9 RID: 20137
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
