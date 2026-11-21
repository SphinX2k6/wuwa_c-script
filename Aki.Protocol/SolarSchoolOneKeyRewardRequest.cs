using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B6 RID: 4790
	[NetMessage(EMessageId.SolarSchoolOneKeyRewardRequest)]
	public sealed class SolarSchoolOneKeyRewardRequest : IMessage<SolarSchoolOneKeyRewardRequest>, IMessage, IEquatable<SolarSchoolOneKeyRewardRequest>, IDeepCloneable<SolarSchoolOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x06019912 RID: 104722 RVA: 0x003BAA41 File Offset: 0x003B8C41
		[NullableContext(1)]
		public static SolarSchoolOneKeyRewardRequest Create()
		{
			return new SolarSchoolOneKeyRewardRequest();
		}

		// Token: 0x17005688 RID: 22152
		// (get) Token: 0x06019913 RID: 104723 RVA: 0x003BAA48 File Offset: 0x003B8C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005689 RID: 22153
		// (get) Token: 0x06019914 RID: 104724 RVA: 0x003BAA4B File Offset: 0x003B8C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019915 RID: 104725 RVA: 0x003BAA52 File Offset: 0x003B8C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyRewardRequest()
		{
		}

		// Token: 0x06019916 RID: 104726 RVA: 0x003BAA65 File Offset: 0x003B8C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyRewardRequest(SolarSchoolOneKeyRewardRequest other) : this()
		{
			this.taskType_ = other.taskType_;
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019917 RID: 104727 RVA: 0x003BAA9B File Offset: 0x003B8C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyRewardRequest Clone()
		{
			return new SolarSchoolOneKeyRewardRequest(this);
		}

		// Token: 0x1700568A RID: 22154
		// (get) Token: 0x06019918 RID: 104728 RVA: 0x003BAAA3 File Offset: 0x003B8CA3
		// (set) Token: 0x06019919 RID: 104729 RVA: 0x003BAAAB File Offset: 0x003B8CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskType TaskType
		{
			get
			{
				return this.taskType_;
			}
			set
			{
				this.taskType_ = value;
			}
		}

		// Token: 0x1700568B RID: 22155
		// (get) Token: 0x0601991A RID: 104730 RVA: 0x003BAAB4 File Offset: 0x003B8CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x0601991B RID: 104731 RVA: 0x003BAABC File Offset: 0x003B8CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolOneKeyRewardRequest);
		}

		// Token: 0x0601991C RID: 104732 RVA: 0x003BAACC File Offset: 0x003B8CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolOneKeyRewardRequest other)
		{
			return other != null && (other == this || (this.TaskType == other.TaskType && this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601991D RID: 104733 RVA: 0x003BAB1C File Offset: 0x003B8D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskType != SolarSchoolTaskType.SolarSchoolResident)
			{
				num ^= this.TaskType.GetHashCode();
			}
			num ^= this.taskId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601991E RID: 104734 RVA: 0x003BAB6F File Offset: 0x003B8D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601991F RID: 104735 RVA: 0x003BAB7C File Offset: 0x003B8D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019920 RID: 104736 RVA: 0x003BAB88 File Offset: 0x003B8D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskType != SolarSchoolTaskType.SolarSchoolResident)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.TaskType);
			}
			this.taskId_.WriteTo(ref output, SolarSchoolOneKeyRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019921 RID: 104737 RVA: 0x003BABD8 File Offset: 0x003B8DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskType != SolarSchoolTaskType.SolarSchoolResident)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TaskType);
			}
			num += this.taskId_.CalculateSize(SolarSchoolOneKeyRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019922 RID: 104738 RVA: 0x003BAC2C File Offset: 0x003B8E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolOneKeyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskType != SolarSchoolTaskType.SolarSchoolResident)
			{
				this.TaskType = other.TaskType;
			}
			this.taskId_.Add(other.taskId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019923 RID: 104739 RVA: 0x003BAC79 File Offset: 0x003B8E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019924 RID: 104740 RVA: 0x003BAC84 File Offset: 0x003B8E84
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
				if (num != 40U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskId_.AddEntriesFrom(ref input, SolarSchoolOneKeyRewardRequest._repeated_taskId_codec);
					}
				}
				else
				{
					this.TaskType = (SolarSchoolTaskType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400970A RID: 38666
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400970B RID: 38667
		public const int TaskTypeFieldNumber = 5;

		// Token: 0x0400970C RID: 38668
		private SolarSchoolTaskType taskType_;

		// Token: 0x0400970D RID: 38669
		public const int TaskIdFieldNumber = 15;

		// Token: 0x0400970E RID: 38670
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400970F RID: 38671
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
