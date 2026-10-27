using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118B RID: 4491
	public sealed class SceneStepInfo : IMessage<SceneStepInfo>, IMessage, IEquatable<SceneStepInfo>, IDeepCloneable<SceneStepInfo>, IBufferMessage
	{
		// Token: 0x06017EFF RID: 98047 RVA: 0x00379F35 File Offset: 0x00378135
		[NullableContext(1)]
		public static SceneStepInfo Create()
		{
			return new SceneStepInfo();
		}

		// Token: 0x1700506D RID: 20589
		// (get) Token: 0x06017F00 RID: 98048 RVA: 0x00379F3C File Offset: 0x0037813C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneStepInfo> Parser
		{
			get
			{
				return SceneStepInfo._parser;
			}
		}

		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x06017F01 RID: 98049 RVA: 0x00379F43 File Offset: 0x00378143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700506F RID: 20591
		// (get) Token: 0x06017F02 RID: 98050 RVA: 0x00379F46 File Offset: 0x00378146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepInfo.Descriptor;
			}
		}

		// Token: 0x06017F03 RID: 98051 RVA: 0x00379F4D File Offset: 0x0037814D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfo()
		{
		}

		// Token: 0x06017F04 RID: 98052 RVA: 0x00379F6C File Offset: 0x0037816C
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

		// Token: 0x06017F05 RID: 98053 RVA: 0x00379FCA File Offset: 0x003781CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepInfo Clone()
		{
			return new SceneStepInfo(this);
		}

		// Token: 0x17005070 RID: 20592
		// (get) Token: 0x06017F06 RID: 98054 RVA: 0x00379FD2 File Offset: 0x003781D2
		// (set) Token: 0x06017F07 RID: 98055 RVA: 0x00379FDA File Offset: 0x003781DA
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

		// Token: 0x17005071 RID: 20593
		// (get) Token: 0x06017F08 RID: 98056 RVA: 0x00379FE3 File Offset: 0x003781E3
		// (set) Token: 0x06017F09 RID: 98057 RVA: 0x00379FEB File Offset: 0x003781EB
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

		// Token: 0x17005072 RID: 20594
		// (get) Token: 0x06017F0A RID: 98058 RVA: 0x00379FF4 File Offset: 0x003781F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepConditionProgress> Progress
		{
			get
			{
				return this.progress_;
			}
		}

		// Token: 0x17005073 RID: 20595
		// (get) Token: 0x06017F0B RID: 98059 RVA: 0x00379FFC File Offset: 0x003781FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepPlayerProgress> MultiPlayerProgress
		{
			get
			{
				return this.multiPlayerProgress_;
			}
		}

		// Token: 0x06017F0C RID: 98060 RVA: 0x0037A004 File Offset: 0x00378204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepInfo);
		}

		// Token: 0x06017F0D RID: 98061 RVA: 0x0037A014 File Offset: 0x00378214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepInfo other)
		{
			return other != null && (other == this || (this.StepId == other.StepId && this.Status == other.Status && this.progress_.Equals(other.progress_) && this.multiPlayerProgress_.Equals(other.multiPlayerProgress_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F0E RID: 98062 RVA: 0x0037A088 File Offset: 0x00378288
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

		// Token: 0x06017F0F RID: 98063 RVA: 0x0037A102 File Offset: 0x00378302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F10 RID: 98064 RVA: 0x0037A10F File Offset: 0x0037830F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F11 RID: 98065 RVA: 0x0037A118 File Offset: 0x00378318
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

		// Token: 0x06017F12 RID: 98066 RVA: 0x0037A194 File Offset: 0x00378394
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

		// Token: 0x06017F13 RID: 98067 RVA: 0x0037A210 File Offset: 0x00378410
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

		// Token: 0x06017F14 RID: 98068 RVA: 0x0037A282 File Offset: 0x00378482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F15 RID: 98069 RVA: 0x0037A28C File Offset: 0x0037848C
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

		// Token: 0x04008DCD RID: 36301
		private static readonly MessageParser<SceneStepInfo> _parser = new MessageParser<SceneStepInfo>(() => new SceneStepInfo());

		// Token: 0x04008DCE RID: 36302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DCF RID: 36303
		public const int StepIdFieldNumber = 1;

		// Token: 0x04008DD0 RID: 36304
		private int stepId_;

		// Token: 0x04008DD1 RID: 36305
		public const int StatusFieldNumber = 2;

		// Token: 0x04008DD2 RID: 36306
		private SceneStepStatus status_;

		// Token: 0x04008DD3 RID: 36307
		public const int ProgressFieldNumber = 3;

		// Token: 0x04008DD4 RID: 36308
		private static readonly FieldCodec<SceneStepConditionProgress> _repeated_progress_codec = FieldCodec.ForMessage<SceneStepConditionProgress>(26U, SceneStepConditionProgress.Parser);

		// Token: 0x04008DD5 RID: 36309
		private readonly RepeatedField<SceneStepConditionProgress> progress_ = new RepeatedField<SceneStepConditionProgress>();

		// Token: 0x04008DD6 RID: 36310
		public const int MultiPlayerProgressFieldNumber = 4;

		// Token: 0x04008DD7 RID: 36311
		private static readonly FieldCodec<SceneStepPlayerProgress> _repeated_multiPlayerProgress_codec = FieldCodec.ForMessage<SceneStepPlayerProgress>(34U, SceneStepPlayerProgress.Parser);

		// Token: 0x04008DD8 RID: 36312
		private readonly RepeatedField<SceneStepPlayerProgress> multiPlayerProgress_ = new RepeatedField<SceneStepPlayerProgress>();
	}
}
