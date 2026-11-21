using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C3 RID: 4547
	public sealed class SceneStepGroupInfo : IMessage<SceneStepGroupInfo>, IMessage, IEquatable<SceneStepGroupInfo>, IDeepCloneable<SceneStepGroupInfo>, IBufferMessage
	{
		// Token: 0x06018479 RID: 99449 RVA: 0x00388DCF File Offset: 0x00386FCF
		[NullableContext(1)]
		public static SceneStepGroupInfo Create()
		{
			return new SceneStepGroupInfo();
		}

		// Token: 0x170051D1 RID: 20945
		// (get) Token: 0x0601847A RID: 99450 RVA: 0x00388DD6 File Offset: 0x00386FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneStepGroupInfo> Parser
		{
			get
			{
				return SceneStepGroupInfo._parser;
			}
		}

		// Token: 0x170051D2 RID: 20946
		// (get) Token: 0x0601847B RID: 99451 RVA: 0x00388DDD File Offset: 0x00386FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051D3 RID: 20947
		// (get) Token: 0x0601847C RID: 99452 RVA: 0x00388DE0 File Offset: 0x00386FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepGroupInfo.Descriptor;
			}
		}

		// Token: 0x0601847D RID: 99453 RVA: 0x00388DE7 File Offset: 0x00386FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfo()
		{
		}

		// Token: 0x0601847E RID: 99454 RVA: 0x00388DFA File Offset: 0x00386FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfo(SceneStepGroupInfo other) : this()
		{
			this.stepGroupId_ = other.stepGroupId_;
			this.steps_ = other.steps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601847F RID: 99455 RVA: 0x00388E30 File Offset: 0x00387030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfo Clone()
		{
			return new SceneStepGroupInfo(this);
		}

		// Token: 0x170051D4 RID: 20948
		// (get) Token: 0x06018480 RID: 99456 RVA: 0x00388E38 File Offset: 0x00387038
		// (set) Token: 0x06018481 RID: 99457 RVA: 0x00388E40 File Offset: 0x00387040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StepGroupId
		{
			get
			{
				return this.stepGroupId_;
			}
			set
			{
				this.stepGroupId_ = value;
			}
		}

		// Token: 0x170051D5 RID: 20949
		// (get) Token: 0x06018482 RID: 99458 RVA: 0x00388E49 File Offset: 0x00387049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepInfo> Steps
		{
			get
			{
				return this.steps_;
			}
		}

		// Token: 0x06018483 RID: 99459 RVA: 0x00388E51 File Offset: 0x00387051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepGroupInfo);
		}

		// Token: 0x06018484 RID: 99460 RVA: 0x00388E60 File Offset: 0x00387060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepGroupInfo other)
		{
			return other != null && (other == this || (this.StepGroupId == other.StepGroupId && this.steps_.Equals(other.steps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018485 RID: 99461 RVA: 0x00388EB0 File Offset: 0x003870B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StepGroupId != 0)
			{
				num ^= this.StepGroupId.GetHashCode();
			}
			num ^= this.steps_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018486 RID: 99462 RVA: 0x00388EFD File Offset: 0x003870FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018487 RID: 99463 RVA: 0x00388F0A File Offset: 0x0038710A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018488 RID: 99464 RVA: 0x00388F14 File Offset: 0x00387114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StepGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StepGroupId);
			}
			this.steps_.WriteTo(ref output, SceneStepGroupInfo._repeated_steps_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018489 RID: 99465 RVA: 0x00388F64 File Offset: 0x00387164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StepGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StepGroupId);
			}
			num += this.steps_.CalculateSize(SceneStepGroupInfo._repeated_steps_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601848A RID: 99466 RVA: 0x00388FB8 File Offset: 0x003871B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneStepGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StepGroupId != 0)
			{
				this.StepGroupId = other.StepGroupId;
			}
			this.steps_.Add(other.steps_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601848B RID: 99467 RVA: 0x00389005 File Offset: 0x00387205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601848C RID: 99468 RVA: 0x00389010 File Offset: 0x00387210
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
						this.steps_.AddEntriesFrom(ref input, SceneStepGroupInfo._repeated_steps_codec);
					}
				}
				else
				{
					this.StepGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009055 RID: 36949
		private static readonly MessageParser<SceneStepGroupInfo> _parser = new MessageParser<SceneStepGroupInfo>(() => new SceneStepGroupInfo());

		// Token: 0x04009056 RID: 36950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009057 RID: 36951
		public const int StepGroupIdFieldNumber = 1;

		// Token: 0x04009058 RID: 36952
		private int stepGroupId_;

		// Token: 0x04009059 RID: 36953
		public const int StepsFieldNumber = 2;

		// Token: 0x0400905A RID: 36954
		private static readonly FieldCodec<SceneStepInfo> _repeated_steps_codec = FieldCodec.ForMessage<SceneStepInfo>(18U, SceneStepInfo.Parser);

		// Token: 0x0400905B RID: 36955
		private readonly RepeatedField<SceneStepInfo> steps_ = new RepeatedField<SceneStepInfo>();
	}
}
