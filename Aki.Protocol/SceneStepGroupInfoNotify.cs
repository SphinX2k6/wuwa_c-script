using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C4 RID: 4548
	[NetMessage(EMessageId.SceneStepGroupInfoNotify)]
	public sealed class SceneStepGroupInfoNotify : IMessage<SceneStepGroupInfoNotify>, IMessage, IEquatable<SceneStepGroupInfoNotify>, IDeepCloneable<SceneStepGroupInfoNotify>, IBufferMessage
	{
		// Token: 0x0601848E RID: 99470 RVA: 0x00389099 File Offset: 0x00387299
		[NullableContext(1)]
		public static SceneStepGroupInfoNotify Create()
		{
			return new SceneStepGroupInfoNotify();
		}

		// Token: 0x170051D6 RID: 20950
		// (get) Token: 0x0601848F RID: 99471 RVA: 0x003890A0 File Offset: 0x003872A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051D7 RID: 20951
		// (get) Token: 0x06018490 RID: 99472 RVA: 0x003890A3 File Offset: 0x003872A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepGroupInfoNotify.Descriptor;
			}
		}

		// Token: 0x06018491 RID: 99473 RVA: 0x003890AA File Offset: 0x003872AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfoNotify()
		{
		}

		// Token: 0x06018492 RID: 99474 RVA: 0x003890BD File Offset: 0x003872BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfoNotify(SceneStepGroupInfoNotify other) : this()
		{
			this.stepGroupInfo_ = other.stepGroupInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018493 RID: 99475 RVA: 0x003890E7 File Offset: 0x003872E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfoNotify Clone()
		{
			return new SceneStepGroupInfoNotify(this);
		}

		// Token: 0x170051D8 RID: 20952
		// (get) Token: 0x06018494 RID: 99476 RVA: 0x003890EF File Offset: 0x003872EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepGroupInfo> StepGroupInfo
		{
			get
			{
				return this.stepGroupInfo_;
			}
		}

		// Token: 0x06018495 RID: 99477 RVA: 0x003890F7 File Offset: 0x003872F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepGroupInfoNotify);
		}

		// Token: 0x06018496 RID: 99478 RVA: 0x00389105 File Offset: 0x00387305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepGroupInfoNotify other)
		{
			return other != null && (other == this || (this.stepGroupInfo_.Equals(other.stepGroupInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018497 RID: 99479 RVA: 0x00389138 File Offset: 0x00387338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stepGroupInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018498 RID: 99480 RVA: 0x0038916C File Offset: 0x0038736C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018499 RID: 99481 RVA: 0x00389179 File Offset: 0x00387379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601849A RID: 99482 RVA: 0x00389182 File Offset: 0x00387382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stepGroupInfo_.WriteTo(ref output, SceneStepGroupInfoNotify._repeated_stepGroupInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601849B RID: 99483 RVA: 0x003891AC File Offset: 0x003873AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stepGroupInfo_.CalculateSize(SceneStepGroupInfoNotify._repeated_stepGroupInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601849C RID: 99484 RVA: 0x003891E5 File Offset: 0x003873E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneStepGroupInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.stepGroupInfo_.Add(other.stepGroupInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601849D RID: 99485 RVA: 0x00389213 File Offset: 0x00387413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601849E RID: 99486 RVA: 0x0038921C File Offset: 0x0038741C
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
					this.stepGroupInfo_.AddEntriesFrom(ref input, SceneStepGroupInfoNotify._repeated_stepGroupInfo_codec);
				}
			}
		}

		// Token: 0x0400905C RID: 36956
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400905D RID: 36957
		public const int StepGroupInfoFieldNumber = 13;

		// Token: 0x0400905E RID: 36958
		private static readonly FieldCodec<SceneStepGroupInfo> _repeated_stepGroupInfo_codec = FieldCodec.ForMessage<SceneStepGroupInfo>(106U, SceneStepGroupInfo.Parser);

		// Token: 0x0400905F RID: 36959
		private readonly RepeatedField<SceneStepGroupInfo> stepGroupInfo_ = new RepeatedField<SceneStepGroupInfo>();
	}
}
