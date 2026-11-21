using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C2 RID: 4546
	public sealed class SceneStepConditionProgress : IMessage<SceneStepConditionProgress>, IMessage, IEquatable<SceneStepConditionProgress>, IDeepCloneable<SceneStepConditionProgress>, IBufferMessage
	{
		// Token: 0x06018463 RID: 99427 RVA: 0x00388B16 File Offset: 0x00386D16
		[NullableContext(1)]
		public static SceneStepConditionProgress Create()
		{
			return new SceneStepConditionProgress();
		}

		// Token: 0x170051CC RID: 20940
		// (get) Token: 0x06018464 RID: 99428 RVA: 0x00388B1D File Offset: 0x00386D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneStepConditionProgress> Parser
		{
			get
			{
				return SceneStepConditionProgress._parser;
			}
		}

		// Token: 0x170051CD RID: 20941
		// (get) Token: 0x06018465 RID: 99429 RVA: 0x00388B24 File Offset: 0x00386D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051CE RID: 20942
		// (get) Token: 0x06018466 RID: 99430 RVA: 0x00388B27 File Offset: 0x00386D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepConditionProgress.Descriptor;
			}
		}

		// Token: 0x06018467 RID: 99431 RVA: 0x00388B2E File Offset: 0x00386D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepConditionProgress()
		{
		}

		// Token: 0x06018468 RID: 99432 RVA: 0x00388B36 File Offset: 0x00386D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepConditionProgress(SceneStepConditionProgress other) : this()
		{
			this.conditionId_ = other.conditionId_;
			this.progressNum_ = other.progressNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018469 RID: 99433 RVA: 0x00388B67 File Offset: 0x00386D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepConditionProgress Clone()
		{
			return new SceneStepConditionProgress(this);
		}

		// Token: 0x170051CF RID: 20943
		// (get) Token: 0x0601846A RID: 99434 RVA: 0x00388B6F File Offset: 0x00386D6F
		// (set) Token: 0x0601846B RID: 99435 RVA: 0x00388B77 File Offset: 0x00386D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionId
		{
			get
			{
				return this.conditionId_;
			}
			set
			{
				this.conditionId_ = value;
			}
		}

		// Token: 0x170051D0 RID: 20944
		// (get) Token: 0x0601846C RID: 99436 RVA: 0x00388B80 File Offset: 0x00386D80
		// (set) Token: 0x0601846D RID: 99437 RVA: 0x00388B88 File Offset: 0x00386D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ProgressNum
		{
			get
			{
				return this.progressNum_;
			}
			set
			{
				this.progressNum_ = value;
			}
		}

		// Token: 0x0601846E RID: 99438 RVA: 0x00388B91 File Offset: 0x00386D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepConditionProgress);
		}

		// Token: 0x0601846F RID: 99439 RVA: 0x00388B9F File Offset: 0x00386D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepConditionProgress other)
		{
			return other != null && (other == this || (this.ConditionId == other.ConditionId && this.ProgressNum == other.ProgressNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018470 RID: 99440 RVA: 0x00388BE0 File Offset: 0x00386DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionId != 0)
			{
				num ^= this.ConditionId.GetHashCode();
			}
			if (this.ProgressNum != 0)
			{
				num ^= this.ProgressNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018471 RID: 99441 RVA: 0x00388C38 File Offset: 0x00386E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018472 RID: 99442 RVA: 0x00388C45 File Offset: 0x00386E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018473 RID: 99443 RVA: 0x00388C50 File Offset: 0x00386E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConditionId);
			}
			if (this.ProgressNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ProgressNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018474 RID: 99444 RVA: 0x00388CA8 File Offset: 0x00386EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionId);
			}
			if (this.ProgressNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProgressNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018475 RID: 99445 RVA: 0x00388D00 File Offset: 0x00386F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneStepConditionProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionId != 0)
			{
				this.ConditionId = other.ConditionId;
			}
			if (other.ProgressNum != 0)
			{
				this.ProgressNum = other.ProgressNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018476 RID: 99446 RVA: 0x00388D50 File Offset: 0x00386F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018477 RID: 99447 RVA: 0x00388D5C File Offset: 0x00386F5C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ProgressNum = input.ReadInt32();
					}
				}
				else
				{
					this.ConditionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400904F RID: 36943
		private static readonly MessageParser<SceneStepConditionProgress> _parser = new MessageParser<SceneStepConditionProgress>(() => new SceneStepConditionProgress());

		// Token: 0x04009050 RID: 36944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009051 RID: 36945
		public const int ConditionIdFieldNumber = 1;

		// Token: 0x04009052 RID: 36946
		private int conditionId_;

		// Token: 0x04009053 RID: 36947
		public const int ProgressNumFieldNumber = 2;

		// Token: 0x04009054 RID: 36948
		private int progressNum_;
	}
}
