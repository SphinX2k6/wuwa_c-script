using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6F RID: 2671
	[NetMessage(EMessageId.MotorFightTaskUpdateNotify)]
	public sealed class MotorFightTaskUpdateNotify : IMessage<MotorFightTaskUpdateNotify>, IMessage, IEquatable<MotorFightTaskUpdateNotify>, IDeepCloneable<MotorFightTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E8EC RID: 59628 RVA: 0x002204D5 File Offset: 0x0021E6D5
		[NullableContext(1)]
		public static MotorFightTaskUpdateNotify Create()
		{
			return new MotorFightTaskUpdateNotify();
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0600E8ED RID: 59629 RVA: 0x002204DC File Offset: 0x0021E6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x002204DF File Offset: 0x0021E6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E8EF RID: 59631 RVA: 0x002204E6 File Offset: 0x0021E6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTaskUpdateNotify()
		{
		}

		// Token: 0x0600E8F0 RID: 59632 RVA: 0x002204F9 File Offset: 0x0021E6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTaskUpdateNotify(MotorFightTaskUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8F1 RID: 59633 RVA: 0x00220523 File Offset: 0x0021E723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTaskUpdateNotify Clone()
		{
			return new MotorFightTaskUpdateNotify(this);
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0600E8F2 RID: 59634 RVA: 0x0022052B File Offset: 0x0021E72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600E8F3 RID: 59635 RVA: 0x00220533 File Offset: 0x0021E733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTaskUpdateNotify);
		}

		// Token: 0x0600E8F4 RID: 59636 RVA: 0x00220541 File Offset: 0x0021E741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8F5 RID: 59637 RVA: 0x00220574 File Offset: 0x0021E774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E8F6 RID: 59638 RVA: 0x002205A8 File Offset: 0x0021E7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8F7 RID: 59639 RVA: 0x002205B5 File Offset: 0x0021E7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8F8 RID: 59640 RVA: 0x002205BE File Offset: 0x0021E7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, MotorFightTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E8F9 RID: 59641 RVA: 0x002205E8 File Offset: 0x0021E7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(MotorFightTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8FA RID: 59642 RVA: 0x00220621 File Offset: 0x0021E821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8FB RID: 59643 RVA: 0x0022064F File Offset: 0x0021E84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8FC RID: 59644 RVA: 0x00220658 File Offset: 0x0021E858
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, MotorFightTaskUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x04005EC7 RID: 24263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EC8 RID: 24264
		public const int TaskFieldNumber = 10;

		// Token: 0x04005EC9 RID: 24265
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(82U, ConditionTask.Parser);

		// Token: 0x04005ECA RID: 24266
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
