using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118A RID: 4490
	[NetMessage(EMessageId.SceneStepGroupInfoNotify)]
	public sealed class SceneStepGroupInfoNotify : IMessage<SceneStepGroupInfoNotify>, IMessage, IEquatable<SceneStepGroupInfoNotify>, IDeepCloneable<SceneStepGroupInfoNotify>, IBufferMessage
	{
		// Token: 0x06017EED RID: 98029 RVA: 0x00379D55 File Offset: 0x00377F55
		[NullableContext(1)]
		public static SceneStepGroupInfoNotify Create()
		{
			return new SceneStepGroupInfoNotify();
		}

		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x06017EEE RID: 98030 RVA: 0x00379D5C File Offset: 0x00377F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700506B RID: 20587
		// (get) Token: 0x06017EEF RID: 98031 RVA: 0x00379D5F File Offset: 0x00377F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepGroupInfoNotify.Descriptor;
			}
		}

		// Token: 0x06017EF0 RID: 98032 RVA: 0x00379D66 File Offset: 0x00377F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfoNotify()
		{
		}

		// Token: 0x06017EF1 RID: 98033 RVA: 0x00379D79 File Offset: 0x00377F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfoNotify(SceneStepGroupInfoNotify other) : this()
		{
			this.stepGroupInfo_ = other.stepGroupInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EF2 RID: 98034 RVA: 0x00379DA3 File Offset: 0x00377FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfoNotify Clone()
		{
			return new SceneStepGroupInfoNotify(this);
		}

		// Token: 0x1700506C RID: 20588
		// (get) Token: 0x06017EF3 RID: 98035 RVA: 0x00379DAB File Offset: 0x00377FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepGroupInfo> StepGroupInfo
		{
			get
			{
				return this.stepGroupInfo_;
			}
		}

		// Token: 0x06017EF4 RID: 98036 RVA: 0x00379DB3 File Offset: 0x00377FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepGroupInfoNotify);
		}

		// Token: 0x06017EF5 RID: 98037 RVA: 0x00379DC1 File Offset: 0x00377FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepGroupInfoNotify other)
		{
			return other != null && (other == this || (this.stepGroupInfo_.Equals(other.stepGroupInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017EF6 RID: 98038 RVA: 0x00379DF4 File Offset: 0x00377FF4
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

		// Token: 0x06017EF7 RID: 98039 RVA: 0x00379E28 File Offset: 0x00378028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017EF8 RID: 98040 RVA: 0x00379E35 File Offset: 0x00378035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017EF9 RID: 98041 RVA: 0x00379E3E File Offset: 0x0037803E
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

		// Token: 0x06017EFA RID: 98042 RVA: 0x00379E68 File Offset: 0x00378068
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

		// Token: 0x06017EFB RID: 98043 RVA: 0x00379EA1 File Offset: 0x003780A1
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

		// Token: 0x06017EFC RID: 98044 RVA: 0x00379ECF File Offset: 0x003780CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017EFD RID: 98045 RVA: 0x00379ED8 File Offset: 0x003780D8
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stepGroupInfo_.AddEntriesFrom(ref input, SceneStepGroupInfoNotify._repeated_stepGroupInfo_codec);
				}
			}
		}

		// Token: 0x04008DC9 RID: 36297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DCA RID: 36298
		public const int StepGroupInfoFieldNumber = 5;

		// Token: 0x04008DCB RID: 36299
		private static readonly FieldCodec<SceneStepGroupInfo> _repeated_stepGroupInfo_codec = FieldCodec.ForMessage<SceneStepGroupInfo>(42U, SceneStepGroupInfo.Parser);

		// Token: 0x04008DCC RID: 36300
		private readonly RepeatedField<SceneStepGroupInfo> stepGroupInfo_ = new RepeatedField<SceneStepGroupInfo>();
	}
}
