using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A26 RID: 2598
	public sealed class MotorCycleIpActivityData : IMessage<MotorCycleIpActivityData>, IMessage, IEquatable<MotorCycleIpActivityData>, IDeepCloneable<MotorCycleIpActivityData>, IBufferMessage
	{
		// Token: 0x0600E31A RID: 58138 RVA: 0x00213EAD File Offset: 0x002120AD
		[NullableContext(1)]
		public static MotorCycleIpActivityData Create()
		{
			return new MotorCycleIpActivityData();
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0600E31B RID: 58139 RVA: 0x00213EB4 File Offset: 0x002120B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0600E31C RID: 58140 RVA: 0x00213EB7 File Offset: 0x002120B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorCycleIpActivityData.Descriptor;
			}
		}

		// Token: 0x0600E31D RID: 58141 RVA: 0x00213EBE File Offset: 0x002120BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleIpActivityData()
		{
		}

		// Token: 0x0600E31E RID: 58142 RVA: 0x00213ED1 File Offset: 0x002120D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleIpActivityData(MotorCycleIpActivityData other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E31F RID: 58143 RVA: 0x00213EFB File Offset: 0x002120FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleIpActivityData Clone()
		{
			return new MotorCycleIpActivityData(this);
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0600E320 RID: 58144 RVA: 0x00213F03 File Offset: 0x00212103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600E321 RID: 58145 RVA: 0x00213F0B File Offset: 0x0021210B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorCycleIpActivityData);
		}

		// Token: 0x0600E322 RID: 58146 RVA: 0x00213F19 File Offset: 0x00212119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorCycleIpActivityData other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E323 RID: 58147 RVA: 0x00213F4C File Offset: 0x0021214C
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

		// Token: 0x0600E324 RID: 58148 RVA: 0x00213F80 File Offset: 0x00212180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E325 RID: 58149 RVA: 0x00213F8D File Offset: 0x0021218D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E326 RID: 58150 RVA: 0x00213F96 File Offset: 0x00212196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, MotorCycleIpActivityData._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E327 RID: 58151 RVA: 0x00213FC0 File Offset: 0x002121C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(MotorCycleIpActivityData._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E328 RID: 58152 RVA: 0x00213FF9 File Offset: 0x002121F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorCycleIpActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E329 RID: 58153 RVA: 0x00214027 File Offset: 0x00212227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E32A RID: 58154 RVA: 0x00214030 File Offset: 0x00212230
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
					this.conditionTasks_.AddEntriesFrom(ref input, MotorCycleIpActivityData._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04005D22 RID: 23842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D23 RID: 23843
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04005D24 RID: 23844
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04005D25 RID: 23845
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
