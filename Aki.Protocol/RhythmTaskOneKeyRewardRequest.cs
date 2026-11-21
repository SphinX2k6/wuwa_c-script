using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3F RID: 3903
	[NetMessage(EMessageId.RhythmTaskOneKeyRewardRequest)]
	public sealed class RhythmTaskOneKeyRewardRequest : IMessage<RhythmTaskOneKeyRewardRequest>, IMessage, IEquatable<RhythmTaskOneKeyRewardRequest>, IDeepCloneable<RhythmTaskOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x06014E96 RID: 85654 RVA: 0x003095F5 File Offset: 0x003077F5
		[NullableContext(1)]
		public static RhythmTaskOneKeyRewardRequest Create()
		{
			return new RhythmTaskOneKeyRewardRequest();
		}

		// Token: 0x17004595 RID: 17813
		// (get) Token: 0x06014E97 RID: 85655 RVA: 0x003095FC File Offset: 0x003077FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x06014E98 RID: 85656 RVA: 0x003095FF File Offset: 0x003077FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmTaskOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x06014E99 RID: 85657 RVA: 0x00309606 File Offset: 0x00307806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardRequest()
		{
		}

		// Token: 0x06014E9A RID: 85658 RVA: 0x00309619 File Offset: 0x00307819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardRequest(RhythmTaskOneKeyRewardRequest other) : this()
		{
			this.taskType_ = other.taskType_;
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E9B RID: 85659 RVA: 0x0030964F File Offset: 0x0030784F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardRequest Clone()
		{
			return new RhythmTaskOneKeyRewardRequest(this);
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x06014E9C RID: 85660 RVA: 0x00309657 File Offset: 0x00307857
		// (set) Token: 0x06014E9D RID: 85661 RVA: 0x0030965F File Offset: 0x0030785F
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

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x06014E9E RID: 85662 RVA: 0x00309668 File Offset: 0x00307868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x06014E9F RID: 85663 RVA: 0x00309670 File Offset: 0x00307870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmTaskOneKeyRewardRequest);
		}

		// Token: 0x06014EA0 RID: 85664 RVA: 0x00309680 File Offset: 0x00307880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmTaskOneKeyRewardRequest other)
		{
			return other != null && (other == this || (this.TaskType == other.TaskType && this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014EA1 RID: 85665 RVA: 0x003096D0 File Offset: 0x003078D0
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

		// Token: 0x06014EA2 RID: 85666 RVA: 0x00309723 File Offset: 0x00307923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014EA3 RID: 85667 RVA: 0x00309730 File Offset: 0x00307930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014EA4 RID: 85668 RVA: 0x0030973C File Offset: 0x0030793C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskType != RhythmTaskTypePb.Resident)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.TaskType);
			}
			this.taskId_.WriteTo(ref output, RhythmTaskOneKeyRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014EA5 RID: 85669 RVA: 0x0030978C File Offset: 0x0030798C
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

		// Token: 0x06014EA6 RID: 85670 RVA: 0x003097E0 File Offset: 0x003079E0
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

		// Token: 0x06014EA7 RID: 85671 RVA: 0x0030982D File Offset: 0x00307A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014EA8 RID: 85672 RVA: 0x00309838 File Offset: 0x00307A38
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
					if (num != 64U && num != 66U)
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

		// Token: 0x04007E93 RID: 32403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E94 RID: 32404
		public const int TaskTypeFieldNumber = 5;

		// Token: 0x04007E95 RID: 32405
		private RhythmTaskTypePb taskType_;

		// Token: 0x04007E96 RID: 32406
		public const int TaskIdFieldNumber = 8;

		// Token: 0x04007E97 RID: 32407
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007E98 RID: 32408
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
