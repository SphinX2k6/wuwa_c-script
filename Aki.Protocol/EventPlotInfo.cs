using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C7 RID: 1223
	public sealed class EventPlotInfo : IMessage<EventPlotInfo>, IMessage, IEquatable<EventPlotInfo>, IDeepCloneable<EventPlotInfo>, IBufferMessage
	{
		// Token: 0x06007494 RID: 29844 RVA: 0x0011DD65 File Offset: 0x0011BF65
		[NullableContext(1)]
		public static EventPlotInfo Create()
		{
			return new EventPlotInfo();
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06007495 RID: 29845 RVA: 0x0011DD6C File Offset: 0x0011BF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06007496 RID: 29846 RVA: 0x0011DD6F File Offset: 0x0011BF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EventPlotInfo.Descriptor;
			}
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x0011DD76 File Offset: 0x0011BF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventPlotInfo()
		{
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x0011DD8C File Offset: 0x0011BF8C
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

		// Token: 0x06007499 RID: 29849 RVA: 0x0011DDFD File Offset: 0x0011BFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventPlotInfo Clone()
		{
			return new EventPlotInfo(this);
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x0600749A RID: 29850 RVA: 0x0011DE05 File Offset: 0x0011C005
		// (set) Token: 0x0600749B RID: 29851 RVA: 0x0011DE0D File Offset: 0x0011C00D
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

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x0600749C RID: 29852 RVA: 0x0011DE16 File Offset: 0x0011C016
		// (set) Token: 0x0600749D RID: 29853 RVA: 0x0011DE1E File Offset: 0x0011C01E
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

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x0600749E RID: 29854 RVA: 0x0011DE27 File Offset: 0x0011C027
		// (set) Token: 0x0600749F RID: 29855 RVA: 0x0011DE2F File Offset: 0x0011C02F
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

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x060074A0 RID: 29856 RVA: 0x0011DE38 File Offset: 0x0011C038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EventOption> Options
		{
			get
			{
				return this.options_;
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x0011DE40 File Offset: 0x0011C040
		// (set) Token: 0x060074A2 RID: 29858 RVA: 0x0011DE48 File Offset: 0x0011C048
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

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x060074A3 RID: 29859 RVA: 0x0011DE51 File Offset: 0x0011C051
		// (set) Token: 0x060074A4 RID: 29860 RVA: 0x0011DE59 File Offset: 0x0011C059
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

		// Token: 0x060074A5 RID: 29861 RVA: 0x0011DE62 File Offset: 0x0011C062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EventPlotInfo);
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x0011DE70 File Offset: 0x0011C070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EventPlotInfo other)
		{
			return other != null && (other == this || (this.PlotId == other.PlotId && this.StepId == other.StepId && this.StepState == other.StepState && this.options_.Equals(other.options_) && this.ModifyImage == other.ModifyImage && this.ModifyBgm == other.ModifyBgm && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x0011DF00 File Offset: 0x0011C100
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

		// Token: 0x060074A8 RID: 29864 RVA: 0x0011DFB7 File Offset: 0x0011C1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x0011DFC4 File Offset: 0x0011C1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x0011DFD0 File Offset: 0x0011C1D0
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

		// Token: 0x060074AB RID: 29867 RVA: 0x0011E090 File Offset: 0x0011C290
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

		// Token: 0x060074AC RID: 29868 RVA: 0x0011E144 File Offset: 0x0011C344
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

		// Token: 0x060074AD RID: 29869 RVA: 0x0011E1E1 File Offset: 0x0011C3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x0011E1EC File Offset: 0x0011C3EC
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

		// Token: 0x04003DC9 RID: 15817
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DCA RID: 15818
		public const int PlotIdFieldNumber = 1;

		// Token: 0x04003DCB RID: 15819
		private int plotId_;

		// Token: 0x04003DCC RID: 15820
		public const int StepIdFieldNumber = 2;

		// Token: 0x04003DCD RID: 15821
		private int stepId_;

		// Token: 0x04003DCE RID: 15822
		public const int StepStateFieldNumber = 3;

		// Token: 0x04003DCF RID: 15823
		private StepState stepState_;

		// Token: 0x04003DD0 RID: 15824
		public const int OptionsFieldNumber = 4;

		// Token: 0x04003DD1 RID: 15825
		private static readonly FieldCodec<EventOption> _repeated_options_codec = FieldCodec.ForMessage<EventOption>(34U, EventOption.Parser);

		// Token: 0x04003DD2 RID: 15826
		private readonly RepeatedField<EventOption> options_ = new RepeatedField<EventOption>();

		// Token: 0x04003DD3 RID: 15827
		public const int ModifyImageFieldNumber = 5;

		// Token: 0x04003DD4 RID: 15828
		private int modifyImage_;

		// Token: 0x04003DD5 RID: 15829
		public const int ModifyBgmFieldNumber = 6;

		// Token: 0x04003DD6 RID: 15830
		private int modifyBgm_;
	}
}
