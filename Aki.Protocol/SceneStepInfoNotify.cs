using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118C RID: 4492
	[NetMessage(EMessageId.SceneStepInfoNotify)]
	public sealed class SceneStepInfoNotify : IMessage<SceneStepInfoNotify>, IMessage, IEquatable<SceneStepInfoNotify>, IDeepCloneable<SceneStepInfoNotify>, IBufferMessage
	{
		// Token: 0x06017F17 RID: 98071 RVA: 0x0037A358 File Offset: 0x00378558
		[NullableContext(1)]
		public static SceneStepInfoNotify Create()
		{
			return new SceneStepInfoNotify();
		}

		// Token: 0x17005074 RID: 20596
		// (get) Token: 0x06017F18 RID: 98072 RVA: 0x0037A35F File Offset: 0x0037855F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005075 RID: 20597
		// (get) Token: 0x06017F19 RID: 98073 RVA: 0x0037A362 File Offset: 0x00378562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepInfoNotify.Descriptor;
			}
		}

		// Token: 0x06017F1A RID: 98074 RVA: 0x0037A369 File Offset: 0x00378569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfoNotify()
		{
		}

		// Token: 0x06017F1B RID: 98075 RVA: 0x0037A374 File Offset: 0x00378574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfoNotify(SceneStepInfoNotify other) : this()
		{
			this.stepGroupId_ = other.stepGroupId_;
			this.stepInfo_ = ((other.stepInfo_ != null) ? other.stepInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F1C RID: 98076 RVA: 0x0037A3C0 File Offset: 0x003785C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfoNotify Clone()
		{
			return new SceneStepInfoNotify(this);
		}

		// Token: 0x17005076 RID: 20598
		// (get) Token: 0x06017F1D RID: 98077 RVA: 0x0037A3C8 File Offset: 0x003785C8
		// (set) Token: 0x06017F1E RID: 98078 RVA: 0x0037A3D0 File Offset: 0x003785D0
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

		// Token: 0x17005077 RID: 20599
		// (get) Token: 0x06017F1F RID: 98079 RVA: 0x0037A3D9 File Offset: 0x003785D9
		// (set) Token: 0x06017F20 RID: 98080 RVA: 0x0037A3E1 File Offset: 0x003785E1
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

		// Token: 0x06017F21 RID: 98081 RVA: 0x0037A3EA File Offset: 0x003785EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepInfoNotify);
		}

		// Token: 0x06017F22 RID: 98082 RVA: 0x0037A3F8 File Offset: 0x003785F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepInfoNotify other)
		{
			return other != null && (other == this || (this.StepGroupId == other.StepGroupId && object.Equals(this.StepInfo, other.StepInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F23 RID: 98083 RVA: 0x0037A448 File Offset: 0x00378648
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

		// Token: 0x06017F24 RID: 98084 RVA: 0x0037A49D File Offset: 0x0037869D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F25 RID: 98085 RVA: 0x0037A4AA File Offset: 0x003786AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F26 RID: 98086 RVA: 0x0037A4B4 File Offset: 0x003786B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StepGroupId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.StepGroupId);
			}
			if (this.stepInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.StepInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F27 RID: 98087 RVA: 0x0037A510 File Offset: 0x00378710
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

		// Token: 0x06017F28 RID: 98088 RVA: 0x0037A568 File Offset: 0x00378768
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

		// Token: 0x06017F29 RID: 98089 RVA: 0x0037A5D0 File Offset: 0x003787D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F2A RID: 98090 RVA: 0x0037A5DC File Offset: 0x003787DC
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
				if (num != 104U)
				{
					if (num != 114U)
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

		// Token: 0x04008DD9 RID: 36313
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DDA RID: 36314
		public const int StepGroupIdFieldNumber = 13;

		// Token: 0x04008DDB RID: 36315
		private int stepGroupId_;

		// Token: 0x04008DDC RID: 36316
		public const int StepInfoFieldNumber = 14;

		// Token: 0x04008DDD RID: 36317
		private SceneStepInfo stepInfo_;
	}
}
