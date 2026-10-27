using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4F RID: 3919
	[NetMessage(EMessageId.RhythmTaskOneKeyRewardRequest)]
	public sealed class RhythmTaskOneKeyRewardRequest : IMessage<RhythmTaskOneKeyRewardRequest>, IMessage, IEquatable<RhythmTaskOneKeyRewardRequest>, IDeepCloneable<RhythmTaskOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x06014F7B RID: 85883 RVA: 0x0030ACB1 File Offset: 0x00308EB1
		[NullableContext(1)]
		public static RhythmTaskOneKeyRewardRequest Create()
		{
			return new RhythmTaskOneKeyRewardRequest();
		}

		// Token: 0x170045BF RID: 17855
		// (get) Token: 0x06014F7C RID: 85884 RVA: 0x0030ACB8 File Offset: 0x00308EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045C0 RID: 17856
		// (get) Token: 0x06014F7D RID: 85885 RVA: 0x0030ACBB File Offset: 0x00308EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmTaskOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x06014F7E RID: 85886 RVA: 0x0030ACC2 File Offset: 0x00308EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardRequest()
		{
		}

		// Token: 0x06014F7F RID: 85887 RVA: 0x0030ACD5 File Offset: 0x00308ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardRequest(RhythmTaskOneKeyRewardRequest other) : this()
		{
			this.taskType_ = other.taskType_;
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F80 RID: 85888 RVA: 0x0030AD0B File Offset: 0x00308F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardRequest Clone()
		{
			return new RhythmTaskOneKeyRewardRequest(this);
		}

		// Token: 0x170045C1 RID: 17857
		// (get) Token: 0x06014F81 RID: 85889 RVA: 0x0030AD13 File Offset: 0x00308F13
		// (set) Token: 0x06014F82 RID: 85890 RVA: 0x0030AD1B File Offset: 0x00308F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskTypePb TaskType
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

		// Token: 0x170045C2 RID: 17858
		// (get) Token: 0x06014F83 RID: 85891 RVA: 0x0030AD24 File Offset: 0x00308F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x06014F84 RID: 85892 RVA: 0x0030AD2C File Offset: 0x00308F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmTaskOneKeyRewardRequest);
		}

		// Token: 0x06014F85 RID: 85893 RVA: 0x0030AD3C File Offset: 0x00308F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmTaskOneKeyRewardRequest other)
		{
			return other != null && (other == this || (this.TaskType == other.TaskType && this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F86 RID: 85894 RVA: 0x0030AD8C File Offset: 0x00308F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskType != RhythmTaskTypePb.Resident)
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

		// Token: 0x06014F87 RID: 85895 RVA: 0x0030ADDF File Offset: 0x00308FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F88 RID: 85896 RVA: 0x0030ADEC File Offset: 0x00308FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F89 RID: 85897 RVA: 0x0030ADF8 File Offset: 0x00308FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskType != RhythmTaskTypePb.Resident)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.TaskType);
			}
			this.taskId_.WriteTo(ref output, RhythmTaskOneKeyRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F8A RID: 85898 RVA: 0x0030AE48 File Offset: 0x00309048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskType != RhythmTaskTypePb.Resident)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TaskType);
			}
			num += this.taskId_.CalculateSize(RhythmTaskOneKeyRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014F8B RID: 85899 RVA: 0x0030AE9C File Offset: 0x0030909C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmTaskOneKeyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskType != RhythmTaskTypePb.Resident)
			{
				this.TaskType = other.TaskType;
			}
			this.taskId_.Add(other.taskId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014F8C RID: 85900 RVA: 0x0030AEE9 File Offset: 0x003090E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F8D RID: 85901 RVA: 0x0030AEF4 File Offset: 0x003090F4
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
				if (num != 56U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskId_.AddEntriesFrom(ref input, RhythmTaskOneKeyRewardRequest._repeated_taskId_codec);
					}
				}
				else
				{
					this.TaskType = (RhythmTaskTypePb)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007E69 RID: 32361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E6A RID: 32362
		public const int TaskTypeFieldNumber = 7;

		// Token: 0x04007E6B RID: 32363
		private RhythmTaskTypePb taskType_;

		// Token: 0x04007E6C RID: 32364
		public const int TaskIdFieldNumber = 15;

		// Token: 0x04007E6D RID: 32365
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04007E6E RID: 32366
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
