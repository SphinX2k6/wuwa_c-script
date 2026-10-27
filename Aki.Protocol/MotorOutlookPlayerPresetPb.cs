using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8E RID: 2702
	public sealed class MotorOutlookPlayerPresetPb : IMessage<MotorOutlookPlayerPresetPb>, IMessage, IEquatable<MotorOutlookPlayerPresetPb>, IDeepCloneable<MotorOutlookPlayerPresetPb>, IBufferMessage
	{
		// Token: 0x0600EB58 RID: 60248 RVA: 0x00225BA8 File Offset: 0x00223DA8
		[NullableContext(1)]
		public static MotorOutlookPlayerPresetPb Create()
		{
			return new MotorOutlookPlayerPresetPb();
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x0600EB59 RID: 60249 RVA: 0x00225BAF File Offset: 0x00223DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x0600EB5A RID: 60250 RVA: 0x00225BB2 File Offset: 0x00223DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookPlayerPresetPb.Descriptor;
			}
		}

		// Token: 0x0600EB5B RID: 60251 RVA: 0x00225BB9 File Offset: 0x00223DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPlayerPresetPb()
		{
		}

		// Token: 0x0600EB5C RID: 60252 RVA: 0x00225BCC File Offset: 0x00223DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPlayerPresetPb(MotorOutlookPlayerPresetPb other) : this()
		{
			this.plan_ = other.plan_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB5D RID: 60253 RVA: 0x00225BF6 File Offset: 0x00223DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPlayerPresetPb Clone()
		{
			return new MotorOutlookPlayerPresetPb(this);
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x0600EB5E RID: 60254 RVA: 0x00225BFE File Offset: 0x00223DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookPresetPlanPb> Plan
		{
			get
			{
				return this.plan_;
			}
		}

		// Token: 0x0600EB5F RID: 60255 RVA: 0x00225C06 File Offset: 0x00223E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookPlayerPresetPb);
		}

		// Token: 0x0600EB60 RID: 60256 RVA: 0x00225C14 File Offset: 0x00223E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookPlayerPresetPb other)
		{
			return other != null && (other == this || (this.plan_.Equals(other.plan_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB61 RID: 60257 RVA: 0x00225C48 File Offset: 0x00223E48
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

		// Token: 0x0600EB62 RID: 60258 RVA: 0x00225C7C File Offset: 0x00223E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB63 RID: 60259 RVA: 0x00225C89 File Offset: 0x00223E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB64 RID: 60260 RVA: 0x00225C92 File Offset: 0x00223E92
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

		// Token: 0x0600EB65 RID: 60261 RVA: 0x00225CBC File Offset: 0x00223EBC
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

		// Token: 0x0600EB66 RID: 60262 RVA: 0x00225CF5 File Offset: 0x00223EF5
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

		// Token: 0x0600EB67 RID: 60263 RVA: 0x00225D23 File Offset: 0x00223F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB68 RID: 60264 RVA: 0x00225D2C File Offset: 0x00223F2C
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

		// Token: 0x04005F7E RID: 24446
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F7F RID: 24447
		public const int PlanFieldNumber = 1;

		// Token: 0x04005F80 RID: 24448
		private static readonly FieldCodec<MotorOutlookPresetPlanPb> _repeated_plan_codec = FieldCodec.ForMessage<MotorOutlookPresetPlanPb>(10U, MotorOutlookPresetPlanPb.Parser);

		// Token: 0x04005F81 RID: 24449
		private readonly RepeatedField<MotorOutlookPresetPlanPb> plan_ = new RepeatedField<MotorOutlookPresetPlanPb>();
	}
}
