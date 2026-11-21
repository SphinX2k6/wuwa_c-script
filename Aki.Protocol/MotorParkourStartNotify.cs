using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A88 RID: 2696
	[NetMessage(EMessageId.MotorParkourStartNotify)]
	public sealed class MotorParkourStartNotify : IMessage<MotorParkourStartNotify>, IMessage, IEquatable<MotorParkourStartNotify>, IDeepCloneable<MotorParkourStartNotify>, IBufferMessage
	{
		// Token: 0x0600EB1C RID: 60188 RVA: 0x002258B3 File Offset: 0x00223AB3
		[NullableContext(1)]
		public static MotorParkourStartNotify Create()
		{
			return new MotorParkourStartNotify();
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x0600EB1D RID: 60189 RVA: 0x002258BA File Offset: 0x00223ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x0600EB1E RID: 60190 RVA: 0x002258BD File Offset: 0x00223ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourStartNotify.Descriptor;
			}
		}

		// Token: 0x0600EB1F RID: 60191 RVA: 0x002258C4 File Offset: 0x00223AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourStartNotify()
		{
		}

		// Token: 0x0600EB20 RID: 60192 RVA: 0x002258D7 File Offset: 0x00223AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourStartNotify(MotorParkourStartNotify other) : this()
		{
			this.variableKeyNames_ = other.variableKeyNames_.Clone();
			this.flowTime_ = other.flowTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB21 RID: 60193 RVA: 0x0022590D File Offset: 0x00223B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourStartNotify Clone()
		{
			return new MotorParkourStartNotify(this);
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x0600EB22 RID: 60194 RVA: 0x00225915 File Offset: 0x00223B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> VariableKeyNames
		{
			get
			{
				return this.variableKeyNames_;
			}
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x0600EB23 RID: 60195 RVA: 0x0022591D File Offset: 0x00223B1D
		// (set) Token: 0x0600EB24 RID: 60196 RVA: 0x00225925 File Offset: 0x00223B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowTime
		{
			get
			{
				return this.flowTime_;
			}
			set
			{
				this.flowTime_ = value;
			}
		}

		// Token: 0x0600EB25 RID: 60197 RVA: 0x0022592E File Offset: 0x00223B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourStartNotify);
		}

		// Token: 0x0600EB26 RID: 60198 RVA: 0x0022593C File Offset: 0x00223B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourStartNotify other)
		{
			return other != null && (other == this || (this.VariableKeyNames.Equals(other.VariableKeyNames) && this.FlowTime == other.FlowTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB27 RID: 60199 RVA: 0x0022598C File Offset: 0x00223B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.VariableKeyNames.GetHashCode();
			if (this.FlowTime != 0L)
			{
				num ^= this.FlowTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EB28 RID: 60200 RVA: 0x002259D9 File Offset: 0x00223BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB29 RID: 60201 RVA: 0x002259E6 File Offset: 0x00223BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB2A RID: 60202 RVA: 0x002259F0 File Offset: 0x00223BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.variableKeyNames_.WriteTo(ref output, MotorParkourStartNotify._map_variableKeyNames_codec);
			if (this.FlowTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.FlowTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB2B RID: 60203 RVA: 0x00225A40 File Offset: 0x00223C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.variableKeyNames_.CalculateSize(MotorParkourStartNotify._map_variableKeyNames_codec);
			if (this.FlowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EB2C RID: 60204 RVA: 0x00225A94 File Offset: 0x00223C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.variableKeyNames_.MergeFrom(other.variableKeyNames_);
			if (other.FlowTime != 0L)
			{
				this.FlowTime = other.FlowTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EB2D RID: 60205 RVA: 0x00225AE1 File Offset: 0x00223CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB2E RID: 60206 RVA: 0x00225AEC File Offset: 0x00223CEC
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
				if (num != 26U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FlowTime = input.ReadInt64();
					}
				}
				else
				{
					this.variableKeyNames_.AddEntriesFrom(ref input, MotorParkourStartNotify._map_variableKeyNames_codec);
				}
			}
		}

		// Token: 0x04005FCF RID: 24527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FD0 RID: 24528
		public const int VariableKeyNamesFieldNumber = 3;

		// Token: 0x04005FD1 RID: 24529
		private static readonly MapField<string, string>.Codec _map_variableKeyNames_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 26U);

		// Token: 0x04005FD2 RID: 24530
		private readonly MapField<string, string> variableKeyNames_ = new MapField<string, string>();

		// Token: 0x04005FD3 RID: 24531
		public const int FlowTimeFieldNumber = 15;

		// Token: 0x04005FD4 RID: 24532
		private long flowTime_;
	}
}
