using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7D RID: 2685
	public sealed class MotorOutlookPlayerPresetPb : IMessage<MotorOutlookPlayerPresetPb>, IMessage, IEquatable<MotorOutlookPlayerPresetPb>, IDeepCloneable<MotorOutlookPlayerPresetPb>, IBufferMessage
	{
		// Token: 0x0600EA3E RID: 59966 RVA: 0x002239AC File Offset: 0x00221BAC
		[NullableContext(1)]
		public static MotorOutlookPlayerPresetPb Create()
		{
			return new MotorOutlookPlayerPresetPb();
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0600EA3F RID: 59967 RVA: 0x002239B3 File Offset: 0x00221BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600EA40 RID: 59968 RVA: 0x002239B6 File Offset: 0x00221BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookPlayerPresetPb.Descriptor;
			}
		}

		// Token: 0x0600EA41 RID: 59969 RVA: 0x002239BD File Offset: 0x00221BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPlayerPresetPb()
		{
		}

		// Token: 0x0600EA42 RID: 59970 RVA: 0x002239D0 File Offset: 0x00221BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPlayerPresetPb(MotorOutlookPlayerPresetPb other) : this()
		{
			this.plan_ = other.plan_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA43 RID: 59971 RVA: 0x002239FA File Offset: 0x00221BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPlayerPresetPb Clone()
		{
			return new MotorOutlookPlayerPresetPb(this);
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0600EA44 RID: 59972 RVA: 0x00223A02 File Offset: 0x00221C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookPresetPlanPb> Plan
		{
			get
			{
				return this.plan_;
			}
		}

		// Token: 0x0600EA45 RID: 59973 RVA: 0x00223A0A File Offset: 0x00221C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookPlayerPresetPb);
		}

		// Token: 0x0600EA46 RID: 59974 RVA: 0x00223A18 File Offset: 0x00221C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookPlayerPresetPb other)
		{
			return other != null && (other == this || (this.plan_.Equals(other.plan_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA47 RID: 59975 RVA: 0x00223A4C File Offset: 0x00221C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.plan_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA48 RID: 59976 RVA: 0x00223A80 File Offset: 0x00221C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA49 RID: 59977 RVA: 0x00223A8D File Offset: 0x00221C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA4A RID: 59978 RVA: 0x00223A96 File Offset: 0x00221C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.plan_.WriteTo(ref output, MotorOutlookPlayerPresetPb._repeated_plan_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA4B RID: 59979 RVA: 0x00223AC0 File Offset: 0x00221CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.plan_.CalculateSize(MotorOutlookPlayerPresetPb._repeated_plan_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA4C RID: 59980 RVA: 0x00223AF9 File Offset: 0x00221CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookPlayerPresetPb other)
		{
			if (other == null)
			{
				return;
			}
			this.plan_.Add(other.plan_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA4D RID: 59981 RVA: 0x00223B27 File Offset: 0x00221D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA4E RID: 59982 RVA: 0x00223B30 File Offset: 0x00221D30
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.plan_.AddEntriesFrom(ref input, MotorOutlookPlayerPresetPb._repeated_plan_codec);
				}
			}
		}

		// Token: 0x04005F87 RID: 24455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F88 RID: 24456
		public const int PlanFieldNumber = 1;

		// Token: 0x04005F89 RID: 24457
		private static readonly FieldCodec<MotorOutlookPresetPlanPb> _repeated_plan_codec = FieldCodec.ForMessage<MotorOutlookPresetPlanPb>(10U, MotorOutlookPresetPlanPb.Parser);

		// Token: 0x04005F8A RID: 24458
		private readonly RepeatedField<MotorOutlookPresetPlanPb> plan_ = new RepeatedField<MotorOutlookPresetPlanPb>();
	}
}
