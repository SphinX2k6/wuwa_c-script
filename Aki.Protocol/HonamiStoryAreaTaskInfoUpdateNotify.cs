using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000753 RID: 1875
	[NetMessage(EMessageId.HonamiStoryAreaTaskInfoUpdateNotify)]
	public sealed class HonamiStoryAreaTaskInfoUpdateNotify : IMessage<HonamiStoryAreaTaskInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryAreaTaskInfoUpdateNotify>, IDeepCloneable<HonamiStoryAreaTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AA19 RID: 43545 RVA: 0x00199CED File Offset: 0x00197EED
		[NullableContext(1)]
		public static HonamiStoryAreaTaskInfoUpdateNotify Create()
		{
			return new HonamiStoryAreaTaskInfoUpdateNotify();
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x0600AA1A RID: 43546 RVA: 0x00199CF4 File Offset: 0x00197EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x0600AA1B RID: 43547 RVA: 0x00199CF7 File Offset: 0x00197EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x00199CFE File Offset: 0x00197EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x00199D11 File Offset: 0x00197F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoUpdateNotify(HonamiStoryAreaTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x00199D3B File Offset: 0x00197F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoUpdateNotify Clone()
		{
			return new HonamiStoryAreaTaskInfoUpdateNotify(this);
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x0600AA1F RID: 43551 RVA: 0x00199D43 File Offset: 0x00197F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600AA20 RID: 43552 RVA: 0x00199D4B File Offset: 0x00197F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaTaskInfoUpdateNotify);
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x00199D59 File Offset: 0x00197F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA22 RID: 43554 RVA: 0x00199D8C File Offset: 0x00197F8C
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

		// Token: 0x0600AA23 RID: 43555 RVA: 0x00199DC0 File Offset: 0x00197FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x00199DCD File Offset: 0x00197FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x00199DD6 File Offset: 0x00197FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, HonamiStoryAreaTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x00199E00 File Offset: 0x00198000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(HonamiStoryAreaTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x00199E39 File Offset: 0x00198039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x00199E67 File Offset: 0x00198067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x00199E70 File Offset: 0x00198070
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, HonamiStoryAreaTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04004DCC RID: 19916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DCD RID: 19917
		public const int ConditionTasksFieldNumber = 2;

		// Token: 0x04004DCE RID: 19918
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(18U, ConditionTask.Parser);

		// Token: 0x04004DCF RID: 19919
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
