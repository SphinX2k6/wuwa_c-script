using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C5 RID: 4549
	public sealed class SceneStepInfo : IMessage<SceneStepInfo>, IMessage, IEquatable<SceneStepInfo>, IDeepCloneable<SceneStepInfo>, IBufferMessage
	{
		// Token: 0x060184A0 RID: 99488 RVA: 0x00389279 File Offset: 0x00387479
		[NullableContext(1)]
		public static SceneStepInfo Create()
		{
			return new SceneStepInfo();
		}

		// Token: 0x170051D9 RID: 20953
		// (get) Token: 0x060184A1 RID: 99489 RVA: 0x00389280 File Offset: 0x00387480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneStepInfo> Parser
		{
			get
			{
				return SceneStepInfo._parser;
			}
		}

		// Token: 0x170051DA RID: 20954
		// (get) Token: 0x060184A2 RID: 99490 RVA: 0x00389287 File Offset: 0x00387487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051DB RID: 20955
		// (get) Token: 0x060184A3 RID: 99491 RVA: 0x0038928A File Offset: 0x0038748A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepInfo.Descriptor;
			}
		}

		// Token: 0x060184A4 RID: 99492 RVA: 0x00389291 File Offset: 0x00387491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfo()
		{
		}

		// Token: 0x060184A5 RID: 99493 RVA: 0x003892B0 File Offset: 0x003874B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfo(SceneStepInfo other) : this()
		{
			this.stepId_ = other.stepId_;
			this.status_ = other.status_;
			this.progress_ = other.progress_.Clone();
			this.multiPlayerProgress_ = other.multiPlayerProgress_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060184A6 RID: 99494 RVA: 0x0038930E File Offset: 0x0038750E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfo Clone()
		{
			return new SceneStepInfo(this);
		}

		// Token: 0x170051DC RID: 20956
		// (get) Token: 0x060184A7 RID: 99495 RVA: 0x00389316 File Offset: 0x00387516
		// (set) Token: 0x060184A8 RID: 99496 RVA: 0x0038931E File Offset: 0x0038751E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StepId
		{
			get
			{
				return this.stepId_;
			}
			set
			{
				this.stepId_ = value;
			}
		}

		// Token: 0x170051DD RID: 20957
		// (get) Token: 0x060184A9 RID: 99497 RVA: 0x00389327 File Offset: 0x00387527
		// (set) Token: 0x060184AA RID: 99498 RVA: 0x0038932F File Offset: 0x0038752F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x170051DE RID: 20958
		// (get) Token: 0x060184AB RID: 99499 RVA: 0x00389338 File Offset: 0x00387538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepConditionProgress> Progress
		{
			get
			{
				return this.progress_;
			}
		}

		// Token: 0x170051DF RID: 20959
		// (get) Token: 0x060184AC RID: 99500 RVA: 0x00389340 File Offset: 0x00387540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepPlayerProgress> MultiPlayerProgress
		{
			get
			{
				return this.multiPlayerProgress_;
			}
		}

		// Token: 0x060184AD RID: 99501 RVA: 0x00389348 File Offset: 0x00387548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepInfo);
		}

		// Token: 0x060184AE RID: 99502 RVA: 0x00389358 File Offset: 0x00387558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepInfo other)
		{
			return other != null && (other == this || (this.StepId == other.StepId && this.Status == other.Status && this.progress_.Equals(other.progress_) && this.multiPlayerProgress_.Equals(other.multiPlayerProgress_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184AF RID: 99503 RVA: 0x003893CC File Offset: 0x003875CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StepId != 0)
			{
				num ^= this.StepId.GetHashCode();
			}
			if (this.Status != SceneStepStatus.Accepted)
			{
				num ^= this.Status.GetHashCode();
			}
			num ^= this.progress_.GetHashCode();
			num ^= this.multiPlayerProgress_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060184B0 RID: 99504 RVA: 0x00389446 File Offset: 0x00387646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184B1 RID: 99505 RVA: 0x00389453 File Offset: 0x00387653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184B2 RID: 99506 RVA: 0x0038945C File Offset: 0x0038765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StepId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StepId);
			}
			if (this.Status != SceneStepStatus.Accepted)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			this.progress_.WriteTo(ref output, SceneStepInfo._repeated_progress_codec);
			this.multiPlayerProgress_.WriteTo(ref output, SceneStepInfo._repeated_multiPlayerProgress_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060184B3 RID: 99507 RVA: 0x003894D8 File Offset: 0x003876D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StepId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StepId);
			}
			if (this.Status != SceneStepStatus.Accepted)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			num += this.progress_.CalculateSize(SceneStepInfo._repeated_progress_codec);
			num += this.multiPlayerProgress_.CalculateSize(SceneStepInfo._repeated_multiPlayerProgress_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060184B4 RID: 99508 RVA: 0x00389554 File Offset: 0x00387754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneStepInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StepId != 0)
			{
				this.StepId = other.StepId;
			}
			if (other.Status != SceneStepStatus.Accepted)
			{
				this.Status = other.Status;
			}
			this.progress_.Add(other.progress_);
			this.multiPlayerProgress_.Add(other.multiPlayerProgress_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060184B5 RID: 99509 RVA: 0x003895C6 File Offset: 0x003877C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184B6 RID: 99510 RVA: 0x003895D0 File Offset: 0x003877D0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.StepId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Status = (SceneStepStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.progress_.AddEntriesFrom(ref input, SceneStepInfo._repeated_progress_codec);
						continue;
					}
					if (num == 34U)
					{
						this.multiPlayerProgress_.AddEntriesFrom(ref input, SceneStepInfo._repeated_multiPlayerProgress_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009060 RID: 36960
		private static readonly MessageParser<SceneStepInfo> _parser = new MessageParser<SceneStepInfo>(() => new SceneStepInfo());

		// Token: 0x04009061 RID: 36961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009062 RID: 36962
		public const int StepIdFieldNumber = 1;

		// Token: 0x04009063 RID: 36963
		private int stepId_;

		// Token: 0x04009064 RID: 36964
		public const int StatusFieldNumber = 2;

		// Token: 0x04009065 RID: 36965
		private SceneStepStatus status_;

		// Token: 0x04009066 RID: 36966
		public const int ProgressFieldNumber = 3;

		// Token: 0x04009067 RID: 36967
		private static readonly FieldCodec<SceneStepConditionProgress> _repeated_progress_codec = FieldCodec.ForMessage<SceneStepConditionProgress>(26U, SceneStepConditionProgress.Parser);

		// Token: 0x04009068 RID: 36968
		private readonly RepeatedField<SceneStepConditionProgress> progress_ = new RepeatedField<SceneStepConditionProgress>();

		// Token: 0x04009069 RID: 36969
		public const int MultiPlayerProgressFieldNumber = 4;

		// Token: 0x0400906A RID: 36970
		private static readonly FieldCodec<SceneStepPlayerProgress> _repeated_multiPlayerProgress_codec = FieldCodec.ForMessage<SceneStepPlayerProgress>(34U, SceneStepPlayerProgress.Parser);

		// Token: 0x0400906B RID: 36971
		private readonly RepeatedField<SceneStepPlayerProgress> multiPlayerProgress_ = new RepeatedField<SceneStepPlayerProgress>();
	}
}
