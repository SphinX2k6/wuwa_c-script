using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A19 RID: 2585
	public sealed class MotorDecalActivityData : IMessage<MotorDecalActivityData>, IMessage, IEquatable<MotorDecalActivityData>, IDeepCloneable<MotorDecalActivityData>, IBufferMessage
	{
		// Token: 0x0600E248 RID: 57928 RVA: 0x002124BC File Offset: 0x002106BC
		[NullableContext(1)]
		public static MotorDecalActivityData Create()
		{
			return new MotorDecalActivityData();
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0600E249 RID: 57929 RVA: 0x002124C3 File Offset: 0x002106C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0600E24A RID: 57930 RVA: 0x002124C6 File Offset: 0x002106C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalActivityData.Descriptor;
			}
		}

		// Token: 0x0600E24B RID: 57931 RVA: 0x002124CD File Offset: 0x002106CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalActivityData()
		{
		}

		// Token: 0x0600E24C RID: 57932 RVA: 0x002124E0 File Offset: 0x002106E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalActivityData(MotorDecalActivityData other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E24D RID: 57933 RVA: 0x0021250A File Offset: 0x0021070A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalActivityData Clone()
		{
			return new MotorDecalActivityData(this);
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x0600E24E RID: 57934 RVA: 0x00212512 File Offset: 0x00210712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600E24F RID: 57935 RVA: 0x0021251A File Offset: 0x0021071A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalActivityData);
		}

		// Token: 0x0600E250 RID: 57936 RVA: 0x00212528 File Offset: 0x00210728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalActivityData other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E251 RID: 57937 RVA: 0x0021255C File Offset: 0x0021075C
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

		// Token: 0x0600E252 RID: 57938 RVA: 0x00212590 File Offset: 0x00210790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E253 RID: 57939 RVA: 0x0021259D File Offset: 0x0021079D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E254 RID: 57940 RVA: 0x002125A6 File Offset: 0x002107A6
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

		// Token: 0x0600E255 RID: 57941 RVA: 0x002125D0 File Offset: 0x002107D0
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

		// Token: 0x0600E256 RID: 57942 RVA: 0x00212609 File Offset: 0x00210809
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

		// Token: 0x0600E257 RID: 57943 RVA: 0x00212637 File Offset: 0x00210837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E258 RID: 57944 RVA: 0x00212640 File Offset: 0x00210840
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

		// Token: 0x04005D38 RID: 23864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D39 RID: 23865
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04005D3A RID: 23866
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04005D3B RID: 23867
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
