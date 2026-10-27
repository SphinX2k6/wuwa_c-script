using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DE RID: 1246
	public sealed class EventPlotInfo : IMessage<EventPlotInfo>, IMessage, IEquatable<EventPlotInfo>, IDeepCloneable<EventPlotInfo>, IBufferMessage
	{
		// Token: 0x06007624 RID: 30244 RVA: 0x00120E7D File Offset: 0x0011F07D
		[NullableContext(1)]
		public static EventPlotInfo Create()
		{
			return new EventPlotInfo();
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06007625 RID: 30245 RVA: 0x00120E84 File Offset: 0x0011F084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06007626 RID: 30246 RVA: 0x00120E87 File Offset: 0x0011F087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EventPlotInfo.Descriptor;
			}
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x00120E8E File Offset: 0x0011F08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventPlotInfo()
		{
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00120EA4 File Offset: 0x0011F0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventPlotInfo(EventPlotInfo other) : this()
		{
			this.plotId_ = other.plotId_;
			this.stepId_ = other.stepId_;
			this.stepState_ = other.stepState_;
			this.options_ = other.options_.Clone();
			this.modifyImage_ = other.modifyImage_;
			this.modifyBgm_ = other.modifyBgm_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x00120F15 File Offset: 0x0011F115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventPlotInfo Clone()
		{
			return new EventPlotInfo(this);
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x0600762A RID: 30250 RVA: 0x00120F1D File Offset: 0x0011F11D
		// (set) Token: 0x0600762B RID: 30251 RVA: 0x00120F25 File Offset: 0x0011F125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlotId
		{
			get
			{
				return this.plotId_;
			}
			set
			{
				this.plotId_ = value;
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x0600762C RID: 30252 RVA: 0x00120F2E File Offset: 0x0011F12E
		// (set) Token: 0x0600762D RID: 30253 RVA: 0x00120F36 File Offset: 0x0011F136
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

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x0600762E RID: 30254 RVA: 0x00120F3F File Offset: 0x0011F13F
		// (set) Token: 0x0600762F RID: 30255 RVA: 0x00120F47 File Offset: 0x0011F147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StepState StepState
		{
			get
			{
				return this.stepState_;
			}
			set
			{
				this.stepState_ = value;
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x00120F50 File Offset: 0x0011F150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EventOption> Options
		{
			get
			{
				return this.options_;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06007631 RID: 30257 RVA: 0x00120F58 File Offset: 0x0011F158
		// (set) Token: 0x06007632 RID: 30258 RVA: 0x00120F60 File Offset: 0x0011F160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ModifyImage
		{
			get
			{
				return this.modifyImage_;
			}
			set
			{
				this.modifyImage_ = value;
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06007633 RID: 30259 RVA: 0x00120F69 File Offset: 0x0011F169
		// (set) Token: 0x06007634 RID: 30260 RVA: 0x00120F71 File Offset: 0x0011F171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ModifyBgm
		{
			get
			{
				return this.modifyBgm_;
			}
			set
			{
				this.modifyBgm_ = value;
			}
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00120F7A File Offset: 0x0011F17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EventPlotInfo);
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00120F88 File Offset: 0x0011F188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EventPlotInfo other)
		{
			return other != null && (other == this || (this.PlotId == other.PlotId && this.StepId == other.StepId && this.StepState == other.StepState && this.options_.Equals(other.options_) && this.ModifyImage == other.ModifyImage && this.ModifyBgm == other.ModifyBgm && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00121018 File Offset: 0x0011F218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlotId != 0)
			{
				num ^= this.PlotId.GetHashCode();
			}
			if (this.StepId != 0)
			{
				num ^= this.StepId.GetHashCode();
			}
			if (this.StepState != StepState.NotInit)
			{
				num ^= this.StepState.GetHashCode();
			}
			num ^= this.options_.GetHashCode();
			if (this.ModifyImage != 0)
			{
				num ^= this.ModifyImage.GetHashCode();
			}
			if (this.ModifyBgm != 0)
			{
				num ^= this.ModifyBgm.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x001210CF File Offset: 0x0011F2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x001210DC File Offset: 0x0011F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x001210E8 File Offset: 0x0011F2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlotId);
			}
			if (this.StepId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StepId);
			}
			if (this.StepState != StepState.NotInit)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.StepState);
			}
			this.options_.WriteTo(ref output, EventPlotInfo._repeated_options_codec);
			if (this.ModifyImage != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ModifyImage);
			}
			if (this.ModifyBgm != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ModifyBgm);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x001211A8 File Offset: 0x0011F3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlotId);
			}
			if (this.StepId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StepId);
			}
			if (this.StepState != StepState.NotInit)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.StepState);
			}
			num += this.options_.CalculateSize(EventPlotInfo._repeated_options_codec);
			if (this.ModifyImage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ModifyImage);
			}
			if (this.ModifyBgm != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ModifyBgm);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x0012125C File Offset: 0x0011F45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EventPlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlotId != 0)
			{
				this.PlotId = other.PlotId;
			}
			if (other.StepId != 0)
			{
				this.StepId = other.StepId;
			}
			if (other.StepState != StepState.NotInit)
			{
				this.StepState = other.StepState;
			}
			this.options_.Add(other.options_);
			if (other.ModifyImage != 0)
			{
				this.ModifyImage = other.ModifyImage;
			}
			if (other.ModifyBgm != 0)
			{
				this.ModifyBgm = other.ModifyBgm;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x001212F9 File Offset: 0x0011F4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00121304 File Offset: 0x0011F504
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.PlotId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.StepId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.StepState = (StepState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.options_.AddEntriesFrom(ref input, EventPlotInfo._repeated_options_codec);
						continue;
					}
					if (num == 40U)
					{
						this.ModifyImage = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ModifyBgm = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003DDD RID: 15837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DDE RID: 15838
		public const int PlotIdFieldNumber = 1;

		// Token: 0x04003DDF RID: 15839
		private int plotId_;

		// Token: 0x04003DE0 RID: 15840
		public const int StepIdFieldNumber = 2;

		// Token: 0x04003DE1 RID: 15841
		private int stepId_;

		// Token: 0x04003DE2 RID: 15842
		public const int StepStateFieldNumber = 3;

		// Token: 0x04003DE3 RID: 15843
		private StepState stepState_;

		// Token: 0x04003DE4 RID: 15844
		public const int OptionsFieldNumber = 4;

		// Token: 0x04003DE5 RID: 15845
		private static readonly FieldCodec<EventOption> _repeated_options_codec = FieldCodec.ForMessage<EventOption>(34U, EventOption.Parser);

		// Token: 0x04003DE6 RID: 15846
		private readonly RepeatedField<EventOption> options_ = new RepeatedField<EventOption>();

		// Token: 0x04003DE7 RID: 15847
		public const int ModifyImageFieldNumber = 5;

		// Token: 0x04003DE8 RID: 15848
		private int modifyImage_;

		// Token: 0x04003DE9 RID: 15849
		public const int ModifyBgmFieldNumber = 6;

		// Token: 0x04003DEA RID: 15850
		private int modifyBgm_;
	}
}
