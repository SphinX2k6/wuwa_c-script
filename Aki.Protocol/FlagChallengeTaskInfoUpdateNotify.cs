using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059E RID: 1438
	[NetMessage(EMessageId.FlagChallengeTaskInfoUpdateNotify)]
	public sealed class FlagChallengeTaskInfoUpdateNotify : IMessage<FlagChallengeTaskInfoUpdateNotify>, IMessage, IEquatable<FlagChallengeTaskInfoUpdateNotify>, IDeepCloneable<FlagChallengeTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008513 RID: 34067 RVA: 0x00140123 File Offset: 0x0013E323
		[NullableContext(1)]
		public static FlagChallengeTaskInfoUpdateNotify Create()
		{
			return new FlagChallengeTaskInfoUpdateNotify();
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06008514 RID: 34068 RVA: 0x0014012A File Offset: 0x0013E32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06008515 RID: 34069 RVA: 0x0014012D File Offset: 0x0013E32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008516 RID: 34070 RVA: 0x00140134 File Offset: 0x0013E334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTaskInfoUpdateNotify()
		{
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x00140147 File Offset: 0x0013E347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTaskInfoUpdateNotify(FlagChallengeTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x00140171 File Offset: 0x0013E371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTaskInfoUpdateNotify Clone()
		{
			return new FlagChallengeTaskInfoUpdateNotify(this);
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06008519 RID: 34073 RVA: 0x00140179 File Offset: 0x0013E379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x00140181 File Offset: 0x0013E381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeTaskInfoUpdateNotify);
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x0014018F File Offset: 0x0013E38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x001401C4 File Offset: 0x0013E3C4
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

		// Token: 0x0600851D RID: 34077 RVA: 0x001401F8 File Offset: 0x0013E3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x00140205 File Offset: 0x0013E405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600851F RID: 34079 RVA: 0x0014020E File Offset: 0x0013E40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, FlagChallengeTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008520 RID: 34080 RVA: 0x00140238 File Offset: 0x0013E438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(FlagChallengeTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008521 RID: 34081 RVA: 0x00140271 File Offset: 0x0013E471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008522 RID: 34082 RVA: 0x0014029F File Offset: 0x0013E49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x001402A8 File Offset: 0x0013E4A8
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, FlagChallengeTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x040041E5 RID: 16869
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041E6 RID: 16870
		public const int ConditionTasksFieldNumber = 13;

		// Token: 0x040041E7 RID: 16871
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(106U, ConditionTask.Parser);

		// Token: 0x040041E8 RID: 16872
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
