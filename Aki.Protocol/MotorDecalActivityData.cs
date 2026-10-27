using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2A RID: 2602
	public sealed class MotorDecalActivityData : IMessage<MotorDecalActivityData>, IMessage, IEquatable<MotorDecalActivityData>, IDeepCloneable<MotorDecalActivityData>, IBufferMessage
	{
		// Token: 0x0600E362 RID: 58210 RVA: 0x002146B0 File Offset: 0x002128B0
		[NullableContext(1)]
		public static MotorDecalActivityData Create()
		{
			return new MotorDecalActivityData();
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0600E363 RID: 58211 RVA: 0x002146B7 File Offset: 0x002128B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x0600E364 RID: 58212 RVA: 0x002146BA File Offset: 0x002128BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalActivityData.Descriptor;
			}
		}

		// Token: 0x0600E365 RID: 58213 RVA: 0x002146C1 File Offset: 0x002128C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalActivityData()
		{
		}

		// Token: 0x0600E366 RID: 58214 RVA: 0x002146D4 File Offset: 0x002128D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalActivityData(MotorDecalActivityData other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E367 RID: 58215 RVA: 0x002146FE File Offset: 0x002128FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalActivityData Clone()
		{
			return new MotorDecalActivityData(this);
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0600E368 RID: 58216 RVA: 0x00214706 File Offset: 0x00212906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600E369 RID: 58217 RVA: 0x0021470E File Offset: 0x0021290E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalActivityData);
		}

		// Token: 0x0600E36A RID: 58218 RVA: 0x0021471C File Offset: 0x0021291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalActivityData other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E36B RID: 58219 RVA: 0x00214750 File Offset: 0x00212950
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

		// Token: 0x0600E36C RID: 58220 RVA: 0x00214784 File Offset: 0x00212984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E36D RID: 58221 RVA: 0x00214791 File Offset: 0x00212991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E36E RID: 58222 RVA: 0x0021479A File Offset: 0x0021299A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, MotorDecalActivityData._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E36F RID: 58223 RVA: 0x002147C4 File Offset: 0x002129C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(MotorDecalActivityData._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E370 RID: 58224 RVA: 0x002147FD File Offset: 0x002129FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E371 RID: 58225 RVA: 0x0021482B File Offset: 0x00212A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E372 RID: 58226 RVA: 0x00214834 File Offset: 0x00212A34
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
					this.conditionTasks_.AddEntriesFrom(ref input, MotorDecalActivityData._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04005D2F RID: 23855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D30 RID: 23856
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04005D31 RID: 23857
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04005D32 RID: 23858
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
