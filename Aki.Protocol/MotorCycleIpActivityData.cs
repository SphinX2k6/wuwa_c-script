using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A15 RID: 2581
	public sealed class MotorCycleIpActivityData : IMessage<MotorCycleIpActivityData>, IMessage, IEquatable<MotorCycleIpActivityData>, IDeepCloneable<MotorCycleIpActivityData>, IBufferMessage
	{
		// Token: 0x0600E200 RID: 57856 RVA: 0x00211CB9 File Offset: 0x0020FEB9
		[NullableContext(1)]
		public static MotorCycleIpActivityData Create()
		{
			return new MotorCycleIpActivityData();
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0600E201 RID: 57857 RVA: 0x00211CC0 File Offset: 0x0020FEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0600E202 RID: 57858 RVA: 0x00211CC3 File Offset: 0x0020FEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorCycleIpActivityData.Descriptor;
			}
		}

		// Token: 0x0600E203 RID: 57859 RVA: 0x00211CCA File Offset: 0x0020FECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleIpActivityData()
		{
		}

		// Token: 0x0600E204 RID: 57860 RVA: 0x00211CDD File Offset: 0x0020FEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleIpActivityData(MotorCycleIpActivityData other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E205 RID: 57861 RVA: 0x00211D07 File Offset: 0x0020FF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleIpActivityData Clone()
		{
			return new MotorCycleIpActivityData(this);
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0600E206 RID: 57862 RVA: 0x00211D0F File Offset: 0x0020FF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600E207 RID: 57863 RVA: 0x00211D17 File Offset: 0x0020FF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorCycleIpActivityData);
		}

		// Token: 0x0600E208 RID: 57864 RVA: 0x00211D25 File Offset: 0x0020FF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorCycleIpActivityData other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E209 RID: 57865 RVA: 0x00211D58 File Offset: 0x0020FF58
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

		// Token: 0x0600E20A RID: 57866 RVA: 0x00211D8C File Offset: 0x0020FF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E20B RID: 57867 RVA: 0x00211D99 File Offset: 0x0020FF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E20C RID: 57868 RVA: 0x00211DA2 File Offset: 0x0020FFA2
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

		// Token: 0x0600E20D RID: 57869 RVA: 0x00211DCC File Offset: 0x0020FFCC
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

		// Token: 0x0600E20E RID: 57870 RVA: 0x00211E05 File Offset: 0x00210005
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

		// Token: 0x0600E20F RID: 57871 RVA: 0x00211E33 File Offset: 0x00210033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E210 RID: 57872 RVA: 0x00211E3C File Offset: 0x0021003C
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

		// Token: 0x04005D2B RID: 23851
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D2C RID: 23852
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04005D2D RID: 23853
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04005D2E RID: 23854
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
