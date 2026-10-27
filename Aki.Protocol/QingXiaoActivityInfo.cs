using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFA RID: 3578
	public sealed class QingXiaoActivityInfo : IMessage<QingXiaoActivityInfo>, IMessage, IEquatable<QingXiaoActivityInfo>, IDeepCloneable<QingXiaoActivityInfo>, IBufferMessage
	{
		// Token: 0x060133E7 RID: 78823 RVA: 0x002CD6F2 File Offset: 0x002CB8F2
		[NullableContext(1)]
		public static QingXiaoActivityInfo Create()
		{
			return new QingXiaoActivityInfo();
		}

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x060133E8 RID: 78824 RVA: 0x002CD6F9 File Offset: 0x002CB8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x060133E9 RID: 78825 RVA: 0x002CD6FC File Offset: 0x002CB8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QingXiaoActivityInfo.Descriptor;
			}
		}

		// Token: 0x060133EA RID: 78826 RVA: 0x002CD703 File Offset: 0x002CB903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoActivityInfo()
		{
		}

		// Token: 0x060133EB RID: 78827 RVA: 0x002CD716 File Offset: 0x002CB916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoActivityInfo(QingXiaoActivityInfo other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133EC RID: 78828 RVA: 0x002CD740 File Offset: 0x002CB940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoActivityInfo Clone()
		{
			return new QingXiaoActivityInfo(this);
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x060133ED RID: 78829 RVA: 0x002CD748 File Offset: 0x002CB948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x060133EE RID: 78830 RVA: 0x002CD750 File Offset: 0x002CB950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QingXiaoActivityInfo);
		}

		// Token: 0x060133EF RID: 78831 RVA: 0x002CD75E File Offset: 0x002CB95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QingXiaoActivityInfo other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133F0 RID: 78832 RVA: 0x002CD794 File Offset: 0x002CB994
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

		// Token: 0x060133F1 RID: 78833 RVA: 0x002CD7C8 File Offset: 0x002CB9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133F2 RID: 78834 RVA: 0x002CD7D5 File Offset: 0x002CB9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133F3 RID: 78835 RVA: 0x002CD7DE File Offset: 0x002CB9DE
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

		// Token: 0x060133F4 RID: 78836 RVA: 0x002CD808 File Offset: 0x002CBA08
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

		// Token: 0x060133F5 RID: 78837 RVA: 0x002CD841 File Offset: 0x002CBA41
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

		// Token: 0x060133F6 RID: 78838 RVA: 0x002CD86F File Offset: 0x002CBA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133F7 RID: 78839 RVA: 0x002CD878 File Offset: 0x002CBA78
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

		// Token: 0x0400766B RID: 30315
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400766C RID: 30316
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x0400766D RID: 30317
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x0400766E RID: 30318
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
