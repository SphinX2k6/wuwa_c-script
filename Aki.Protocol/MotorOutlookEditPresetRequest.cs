using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A83 RID: 2691
	[NetMessage(EMessageId.MotorOutlookEditPresetRequest)]
	public sealed class MotorOutlookEditPresetRequest : IMessage<MotorOutlookEditPresetRequest>, IMessage, IEquatable<MotorOutlookEditPresetRequest>, IDeepCloneable<MotorOutlookEditPresetRequest>, IBufferMessage
	{
		// Token: 0x0600EA79 RID: 60025 RVA: 0x00223ABB File Offset: 0x00221CBB
		[NullableContext(1)]
		public static MotorOutlookEditPresetRequest Create()
		{
			return new MotorOutlookEditPresetRequest();
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0600EA7A RID: 60026 RVA: 0x00223AC2 File Offset: 0x00221CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0600EA7B RID: 60027 RVA: 0x00223AC5 File Offset: 0x00221CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookEditPresetRequest.Descriptor;
			}
		}

		// Token: 0x0600EA7C RID: 60028 RVA: 0x00223ACC File Offset: 0x00221CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetRequest()
		{
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x00223AD4 File Offset: 0x00221CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetRequest(MotorOutlookEditPresetRequest other) : this()
		{
			this.presetPlan_ = ((other.presetPlan_ != null) ? other.presetPlan_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x00223B09 File Offset: 0x00221D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetRequest Clone()
		{
			return new MotorOutlookEditPresetRequest(this);
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0600EA7F RID: 60031 RVA: 0x00223B11 File Offset: 0x00221D11
		// (set) Token: 0x0600EA80 RID: 60032 RVA: 0x00223B19 File Offset: 0x00221D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPresetPlanPb PresetPlan
		{
			get
			{
				return this.presetPlan_;
			}
			set
			{
				this.presetPlan_ = value;
			}
		}

		// Token: 0x0600EA81 RID: 60033 RVA: 0x00223B22 File Offset: 0x00221D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookEditPresetRequest);
		}

		// Token: 0x0600EA82 RID: 60034 RVA: 0x00223B30 File Offset: 0x00221D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookEditPresetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PresetPlan, other.PresetPlan) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA83 RID: 60035 RVA: 0x00223B64 File Offset: 0x00221D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.presetPlan_ != null)
			{
				num ^= this.PresetPlan.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA84 RID: 60036 RVA: 0x00223BA0 File Offset: 0x00221DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA85 RID: 60037 RVA: 0x00223BAD File Offset: 0x00221DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA86 RID: 60038 RVA: 0x00223BB6 File Offset: 0x00221DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.presetPlan_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PresetPlan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA87 RID: 60039 RVA: 0x00223BE8 File Offset: 0x00221DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.presetPlan_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PresetPlan);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA88 RID: 60040 RVA: 0x00223C28 File Offset: 0x00221E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookEditPresetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.presetPlan_ != null)
			{
				if (this.presetPlan_ == null)
				{
					this.PresetPlan = new MotorOutlookPresetPlanPb();
				}
				this.PresetPlan.MergeFrom(other.PresetPlan);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA89 RID: 60041 RVA: 0x00223C7C File Offset: 0x00221E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA8A RID: 60042 RVA: 0x00223C88 File Offset: 0x00221E88
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.presetPlan_ == null)
					{
						this.PresetPlan = new MotorOutlookPresetPlanPb();
					}
					input.ReadMessage(this.PresetPlan);
				}
			}
		}

		// Token: 0x04005F39 RID: 24377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F3A RID: 24378
		public const int PresetPlanFieldNumber = 6;

		// Token: 0x04005F3B RID: 24379
		private MotorOutlookPresetPlanPb presetPlan_;
	}
}
