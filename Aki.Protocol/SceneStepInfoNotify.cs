using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C6 RID: 4550
	[NetMessage(EMessageId.SceneStepInfoNotify)]
	public sealed class SceneStepInfoNotify : IMessage<SceneStepInfoNotify>, IMessage, IEquatable<SceneStepInfoNotify>, IDeepCloneable<SceneStepInfoNotify>, IBufferMessage
	{
		// Token: 0x060184B8 RID: 99512 RVA: 0x0038969C File Offset: 0x0038789C
		[NullableContext(1)]
		public static SceneStepInfoNotify Create()
		{
			return new SceneStepInfoNotify();
		}

		// Token: 0x170051E0 RID: 20960
		// (get) Token: 0x060184B9 RID: 99513 RVA: 0x003896A3 File Offset: 0x003878A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051E1 RID: 20961
		// (get) Token: 0x060184BA RID: 99514 RVA: 0x003896A6 File Offset: 0x003878A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepInfoNotify.Descriptor;
			}
		}

		// Token: 0x060184BB RID: 99515 RVA: 0x003896AD File Offset: 0x003878AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfoNotify()
		{
		}

		// Token: 0x060184BC RID: 99516 RVA: 0x003896B8 File Offset: 0x003878B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfoNotify(SceneStepInfoNotify other) : this()
		{
			this.stepGroupId_ = other.stepGroupId_;
			this.stepInfo_ = ((other.stepInfo_ != null) ? other.stepInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060184BD RID: 99517 RVA: 0x00389704 File Offset: 0x00387904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfoNotify Clone()
		{
			return new SceneStepInfoNotify(this);
		}

		// Token: 0x170051E2 RID: 20962
		// (get) Token: 0x060184BE RID: 99518 RVA: 0x0038970C File Offset: 0x0038790C
		// (set) Token: 0x060184BF RID: 99519 RVA: 0x00389714 File Offset: 0x00387914
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

		// Token: 0x170051E3 RID: 20963
		// (get) Token: 0x060184C0 RID: 99520 RVA: 0x0038971D File Offset: 0x0038791D
		// (set) Token: 0x060184C1 RID: 99521 RVA: 0x00389725 File Offset: 0x00387925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfo StepInfo
		{
			get
			{
				return this.stepInfo_;
			}
			set
			{
				this.stepInfo_ = value;
			}
		}

		// Token: 0x060184C2 RID: 99522 RVA: 0x0038972E File Offset: 0x0038792E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepInfoNotify);
		}

		// Token: 0x060184C3 RID: 99523 RVA: 0x0038973C File Offset: 0x0038793C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepInfoNotify other)
		{
			return other != null && (other == this || (this.StepGroupId == other.StepGroupId && object.Equals(this.StepInfo, other.StepInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184C4 RID: 99524 RVA: 0x0038978C File Offset: 0x0038798C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StepGroupId != 0)
			{
				num ^= this.StepGroupId.GetHashCode();
			}
			if (this.stepInfo_ != null)
			{
				num ^= this.StepInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060184C5 RID: 99525 RVA: 0x003897E1 File Offset: 0x003879E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184C6 RID: 99526 RVA: 0x003897EE File Offset: 0x003879EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184C7 RID: 99527 RVA: 0x003897F8 File Offset: 0x003879F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StepGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StepGroupId);
			}
			if (this.stepInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.StepInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060184C8 RID: 99528 RVA: 0x00389850 File Offset: 0x00387A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StepGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StepGroupId);
			}
			if (this.stepInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StepInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060184C9 RID: 99529 RVA: 0x003898A8 File Offset: 0x00387AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneStepInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StepGroupId != 0)
			{
				this.StepGroupId = other.StepGroupId;
			}
			if (other.stepInfo_ != null)
			{
				if (this.stepInfo_ == null)
				{
					this.StepInfo = new SceneStepInfo();
				}
				this.StepInfo.MergeFrom(other.StepInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060184CA RID: 99530 RVA: 0x00389910 File Offset: 0x00387B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184CB RID: 99531 RVA: 0x0038991C File Offset: 0x00387B1C
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
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.stepInfo_ == null)
						{
							this.StepInfo = new SceneStepInfo();
						}
						input.ReadMessage(this.StepInfo);
					}
				}
				else
				{
					this.StepGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400906C RID: 36972
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400906D RID: 36973
		public const int StepGroupIdFieldNumber = 1;

		// Token: 0x0400906E RID: 36974
		private int stepGroupId_;

		// Token: 0x0400906F RID: 36975
		public const int StepInfoFieldNumber = 6;

		// Token: 0x04009070 RID: 36976
		private SceneStepInfo stepInfo_;
	}
}
