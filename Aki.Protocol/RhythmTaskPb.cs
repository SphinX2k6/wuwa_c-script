using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F41 RID: 3905
	public sealed class RhythmTaskPb : IMessage<RhythmTaskPb>, IMessage, IEquatable<RhythmTaskPb>, IDeepCloneable<RhythmTaskPb>, IBufferMessage
	{
		// Token: 0x06014EBC RID: 85692 RVA: 0x00309A89 File Offset: 0x00307C89
		[NullableContext(1)]
		public static RhythmTaskPb Create()
		{
			return new RhythmTaskPb();
		}

		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x06014EBD RID: 85693 RVA: 0x00309A90 File Offset: 0x00307C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmTaskPb> Parser
		{
			get
			{
				return RhythmTaskPb._parser;
			}
		}

		// Token: 0x1700459D RID: 17821
		// (get) Token: 0x06014EBE RID: 85694 RVA: 0x00309A97 File Offset: 0x00307C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x06014EBF RID: 85695 RVA: 0x00309A9A File Offset: 0x00307C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmTaskPb.Descriptor;
			}
		}

		// Token: 0x06014EC0 RID: 85696 RVA: 0x00309AA1 File Offset: 0x00307CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskPb()
		{
		}

		// Token: 0x06014EC1 RID: 85697 RVA: 0x00309AB4 File Offset: 0x00307CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskPb(RhythmTaskPb other) : this()
		{
			this.taskType_ = other.taskType_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014EC2 RID: 85698 RVA: 0x00309AEA File Offset: 0x00307CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskPb Clone()
		{
			return new RhythmTaskPb(this);
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x06014EC3 RID: 85699 RVA: 0x00309AF2 File Offset: 0x00307CF2
		// (set) Token: 0x06014EC4 RID: 85700 RVA: 0x00309AFA File Offset: 0x00307CFA
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

		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x06014EC5 RID: 85701 RVA: 0x00309B03 File Offset: 0x00307D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06014EC6 RID: 85702 RVA: 0x00309B0B File Offset: 0x00307D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmTaskPb);
		}

		// Token: 0x06014EC7 RID: 85703 RVA: 0x00309B1C File Offset: 0x00307D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmTaskPb other)
		{
			return other != null && (other == this || (this.TaskType == other.TaskType && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014EC8 RID: 85704 RVA: 0x00309B6C File Offset: 0x00307D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskType != RhythmTaskTypePb.Resident)
			{
				num ^= this.TaskType.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014EC9 RID: 85705 RVA: 0x00309BBF File Offset: 0x00307DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014ECA RID: 85706 RVA: 0x00309BCC File Offset: 0x00307DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014ECB RID: 85707 RVA: 0x00309BD8 File Offset: 0x00307DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskType != RhythmTaskTypePb.Resident)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.TaskType);
			}
			this.task_.WriteTo(ref output, RhythmTaskPb._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014ECC RID: 85708 RVA: 0x00309C28 File Offset: 0x00307E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskType != RhythmTaskTypePb.Resident)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TaskType);
			}
			num += this.task_.CalculateSize(RhythmTaskPb._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014ECD RID: 85709 RVA: 0x00309C7C File Offset: 0x00307E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmTaskPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskType != RhythmTaskTypePb.Resident)
			{
				this.TaskType = other.TaskType;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014ECE RID: 85710 RVA: 0x00309CC9 File Offset: 0x00307EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014ECF RID: 85711 RVA: 0x00309CD4 File Offset: 0x00307ED4
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.task_.AddEntriesFrom(ref input, RhythmTaskPb._repeated_task_codec);
					}
				}
				else
				{
					this.TaskType = (RhythmTaskTypePb)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007E9C RID: 32412
		private static readonly MessageParser<RhythmTaskPb> _parser = new MessageParser<RhythmTaskPb>(() => new RhythmTaskPb());

		// Token: 0x04007E9D RID: 32413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E9E RID: 32414
		public const int TaskTypeFieldNumber = 1;

		// Token: 0x04007E9F RID: 32415
		private RhythmTaskTypePb taskType_;

		// Token: 0x04007EA0 RID: 32416
		public const int TaskFieldNumber = 2;

		// Token: 0x04007EA1 RID: 32417
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(18U, ConditionTask.Parser);

		// Token: 0x04007EA2 RID: 32418
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
