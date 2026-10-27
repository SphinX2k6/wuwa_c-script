using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A30 RID: 2608
	public sealed class MotorDevelopActivityData : IMessage<MotorDevelopActivityData>, IMessage, IEquatable<MotorDevelopActivityData>, IDeepCloneable<MotorDevelopActivityData>, IBufferMessage
	{
		// Token: 0x0600E3D2 RID: 58322 RVA: 0x002153B4 File Offset: 0x002135B4
		[NullableContext(1)]
		public static MotorDevelopActivityData Create()
		{
			return new MotorDevelopActivityData();
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0600E3D3 RID: 58323 RVA: 0x002153BB File Offset: 0x002135BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0600E3D4 RID: 58324 RVA: 0x002153BE File Offset: 0x002135BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDevelopActivityData.Descriptor;
			}
		}

		// Token: 0x0600E3D5 RID: 58325 RVA: 0x002153C5 File Offset: 0x002135C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopActivityData()
		{
		}

		// Token: 0x0600E3D6 RID: 58326 RVA: 0x002153D8 File Offset: 0x002135D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopActivityData(MotorDevelopActivityData other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3D7 RID: 58327 RVA: 0x00215402 File Offset: 0x00213602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopActivityData Clone()
		{
			return new MotorDevelopActivityData(this);
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x0021540A File Offset: 0x0021360A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600E3D9 RID: 58329 RVA: 0x00215412 File Offset: 0x00213612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDevelopActivityData);
		}

		// Token: 0x0600E3DA RID: 58330 RVA: 0x00215420 File Offset: 0x00213620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDevelopActivityData other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3DB RID: 58331 RVA: 0x00215454 File Offset: 0x00213654
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

		// Token: 0x0600E3DC RID: 58332 RVA: 0x00215488 File Offset: 0x00213688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3DD RID: 58333 RVA: 0x00215495 File Offset: 0x00213695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3DE RID: 58334 RVA: 0x0021549E File Offset: 0x0021369E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, MotorDevelopActivityData._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3DF RID: 58335 RVA: 0x002154C8 File Offset: 0x002136C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(MotorDevelopActivityData._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3E0 RID: 58336 RVA: 0x00215501 File Offset: 0x00213701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDevelopActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3E1 RID: 58337 RVA: 0x0021552F File Offset: 0x0021372F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3E2 RID: 58338 RVA: 0x00215538 File Offset: 0x00213738
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
					this.task_.AddEntriesFrom(ref input, MotorDevelopActivityData._repeated_task_codec);
				}
			}
		}

		// Token: 0x04005D47 RID: 23879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D48 RID: 23880
		public const int TaskFieldNumber = 1;

		// Token: 0x04005D49 RID: 23881
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04005D4A RID: 23882
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
