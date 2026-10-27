using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F51 RID: 3921
	public sealed class RhythmTaskPb : IMessage<RhythmTaskPb>, IMessage, IEquatable<RhythmTaskPb>, IDeepCloneable<RhythmTaskPb>, IBufferMessage
	{
		// Token: 0x06014FA1 RID: 85921 RVA: 0x0030B145 File Offset: 0x00309345
		[NullableContext(1)]
		public static RhythmTaskPb Create()
		{
			return new RhythmTaskPb();
		}

		// Token: 0x170045C6 RID: 17862
		// (get) Token: 0x06014FA2 RID: 85922 RVA: 0x0030B14C File Offset: 0x0030934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmTaskPb> Parser
		{
			get
			{
				return RhythmTaskPb._parser;
			}
		}

		// Token: 0x170045C7 RID: 17863
		// (get) Token: 0x06014FA3 RID: 85923 RVA: 0x0030B153 File Offset: 0x00309353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045C8 RID: 17864
		// (get) Token: 0x06014FA4 RID: 85924 RVA: 0x0030B156 File Offset: 0x00309356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmTaskPb.Descriptor;
			}
		}

		// Token: 0x06014FA5 RID: 85925 RVA: 0x0030B15D File Offset: 0x0030935D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskPb()
		{
		}

		// Token: 0x06014FA6 RID: 85926 RVA: 0x0030B170 File Offset: 0x00309370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskPb(RhythmTaskPb other) : this()
		{
			this.taskType_ = other.taskType_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FA7 RID: 85927 RVA: 0x0030B1A6 File Offset: 0x003093A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskPb Clone()
		{
			return new RhythmTaskPb(this);
		}

		// Token: 0x170045C9 RID: 17865
		// (get) Token: 0x06014FA8 RID: 85928 RVA: 0x0030B1AE File Offset: 0x003093AE
		// (set) Token: 0x06014FA9 RID: 85929 RVA: 0x0030B1B6 File Offset: 0x003093B6
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

		// Token: 0x170045CA RID: 17866
		// (get) Token: 0x06014FAA RID: 85930 RVA: 0x0030B1BF File Offset: 0x003093BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06014FAB RID: 85931 RVA: 0x0030B1C7 File Offset: 0x003093C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmTaskPb);
		}

		// Token: 0x06014FAC RID: 85932 RVA: 0x0030B1D8 File Offset: 0x003093D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmTaskPb other)
		{
			return other != null && (other == this || (this.TaskType == other.TaskType && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FAD RID: 85933 RVA: 0x0030B228 File Offset: 0x00309428
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

		// Token: 0x06014FAE RID: 85934 RVA: 0x0030B27B File Offset: 0x0030947B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FAF RID: 85935 RVA: 0x0030B288 File Offset: 0x00309488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FB0 RID: 85936 RVA: 0x0030B294 File Offset: 0x00309494
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

		// Token: 0x06014FB1 RID: 85937 RVA: 0x0030B2E4 File Offset: 0x003094E4
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

		// Token: 0x06014FB2 RID: 85938 RVA: 0x0030B338 File Offset: 0x00309538
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

		// Token: 0x06014FB3 RID: 85939 RVA: 0x0030B385 File Offset: 0x00309585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FB4 RID: 85940 RVA: 0x0030B390 File Offset: 0x00309590
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

		// Token: 0x04007E72 RID: 32370
		private static readonly MessageParser<RhythmTaskPb> _parser = new MessageParser<RhythmTaskPb>(() => new RhythmTaskPb());

		// Token: 0x04007E73 RID: 32371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E74 RID: 32372
		public const int TaskTypeFieldNumber = 1;

		// Token: 0x04007E75 RID: 32373
		private RhythmTaskTypePb taskType_;

		// Token: 0x04007E76 RID: 32374
		public const int TaskFieldNumber = 2;

		// Token: 0x04007E77 RID: 32375
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(18U, ConditionTask.Parser);

		// Token: 0x04007E78 RID: 32376
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
