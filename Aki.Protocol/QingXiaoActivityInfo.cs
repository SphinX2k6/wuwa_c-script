using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEA RID: 3562
	public sealed class QingXiaoActivityInfo : IMessage<QingXiaoActivityInfo>, IMessage, IEquatable<QingXiaoActivityInfo>, IDeepCloneable<QingXiaoActivityInfo>, IBufferMessage
	{
		// Token: 0x06013302 RID: 78594 RVA: 0x002CC02E File Offset: 0x002CA22E
		[NullableContext(1)]
		public static QingXiaoActivityInfo Create()
		{
			return new QingXiaoActivityInfo();
		}

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x06013303 RID: 78595 RVA: 0x002CC035 File Offset: 0x002CA235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x06013304 RID: 78596 RVA: 0x002CC038 File Offset: 0x002CA238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QingXiaoActivityInfo.Descriptor;
			}
		}

		// Token: 0x06013305 RID: 78597 RVA: 0x002CC03F File Offset: 0x002CA23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoActivityInfo()
		{
		}

		// Token: 0x06013306 RID: 78598 RVA: 0x002CC052 File Offset: 0x002CA252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoActivityInfo(QingXiaoActivityInfo other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013307 RID: 78599 RVA: 0x002CC07C File Offset: 0x002CA27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoActivityInfo Clone()
		{
			return new QingXiaoActivityInfo(this);
		}

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x06013308 RID: 78600 RVA: 0x002CC084 File Offset: 0x002CA284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x06013309 RID: 78601 RVA: 0x002CC08C File Offset: 0x002CA28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QingXiaoActivityInfo);
		}

		// Token: 0x0601330A RID: 78602 RVA: 0x002CC09A File Offset: 0x002CA29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QingXiaoActivityInfo other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601330B RID: 78603 RVA: 0x002CC0D0 File Offset: 0x002CA2D0
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

		// Token: 0x0601330C RID: 78604 RVA: 0x002CC104 File Offset: 0x002CA304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601330D RID: 78605 RVA: 0x002CC111 File Offset: 0x002CA311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601330E RID: 78606 RVA: 0x002CC11A File Offset: 0x002CA31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, QingXiaoActivityInfo._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601330F RID: 78607 RVA: 0x002CC144 File Offset: 0x002CA344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(QingXiaoActivityInfo._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013310 RID: 78608 RVA: 0x002CC17D File Offset: 0x002CA37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QingXiaoActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013311 RID: 78609 RVA: 0x002CC1AB File Offset: 0x002CA3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013312 RID: 78610 RVA: 0x002CC1B4 File Offset: 0x002CA3B4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, QingXiaoActivityInfo._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04007695 RID: 30357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007696 RID: 30358
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04007697 RID: 30359
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04007698 RID: 30360
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
