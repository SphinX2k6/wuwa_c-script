using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A99 RID: 2713
	[NetMessage(EMessageId.MotorParkourStartNotify)]
	public sealed class MotorParkourStartNotify : IMessage<MotorParkourStartNotify>, IMessage, IEquatable<MotorParkourStartNotify>, IDeepCloneable<MotorParkourStartNotify>, IBufferMessage
	{
		// Token: 0x0600EC36 RID: 60470 RVA: 0x00227AAB File Offset: 0x00225CAB
		[NullableContext(1)]
		public static MotorParkourStartNotify Create()
		{
			return new MotorParkourStartNotify();
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x0600EC37 RID: 60471 RVA: 0x00227AB2 File Offset: 0x00225CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x0600EC38 RID: 60472 RVA: 0x00227AB5 File Offset: 0x00225CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourStartNotify.Descriptor;
			}
		}

		// Token: 0x0600EC39 RID: 60473 RVA: 0x00227ABC File Offset: 0x00225CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourStartNotify()
		{
		}

		// Token: 0x0600EC3A RID: 60474 RVA: 0x00227ACF File Offset: 0x00225CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourStartNotify(MotorParkourStartNotify other) : this()
		{
			this.variableKeyNames_ = other.variableKeyNames_.Clone();
			this.flowTime_ = other.flowTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC3B RID: 60475 RVA: 0x00227B05 File Offset: 0x00225D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourStartNotify Clone()
		{
			return new MotorParkourStartNotify(this);
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x0600EC3C RID: 60476 RVA: 0x00227B0D File Offset: 0x00225D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> VariableKeyNames
		{
			get
			{
				return this.variableKeyNames_;
			}
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x0600EC3D RID: 60477 RVA: 0x00227B15 File Offset: 0x00225D15
		// (set) Token: 0x0600EC3E RID: 60478 RVA: 0x00227B1D File Offset: 0x00225D1D
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

		// Token: 0x0600EC3F RID: 60479 RVA: 0x00227B26 File Offset: 0x00225D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourStartNotify);
		}

		// Token: 0x0600EC40 RID: 60480 RVA: 0x00227B34 File Offset: 0x00225D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourStartNotify other)
		{
			return other != null && (other == this || (this.VariableKeyNames.Equals(other.VariableKeyNames) && this.FlowTime == other.FlowTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC41 RID: 60481 RVA: 0x00227B84 File Offset: 0x00225D84
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

		// Token: 0x0600EC42 RID: 60482 RVA: 0x00227BD1 File Offset: 0x00225DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC43 RID: 60483 RVA: 0x00227BDE File Offset: 0x00225DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC44 RID: 60484 RVA: 0x00227BE8 File Offset: 0x00225DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.FlowTime);
			}
			this.variableKeyNames_.WriteTo(ref output, MotorParkourStartNotify._map_variableKeyNames_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC45 RID: 60485 RVA: 0x00227C38 File Offset: 0x00225E38
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

		// Token: 0x0600EC46 RID: 60486 RVA: 0x00227C8C File Offset: 0x00225E8C
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

		// Token: 0x0600EC47 RID: 60487 RVA: 0x00227CD9 File Offset: 0x00225ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC48 RID: 60488 RVA: 0x00227CE4 File Offset: 0x00225EE4
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
				if (num != 80U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.variableKeyNames_.AddEntriesFrom(ref input, MotorParkourStartNotify._map_variableKeyNames_codec);
					}
				}
				else
				{
					this.FlowTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005FC6 RID: 24518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FC7 RID: 24519
		public const int VariableKeyNamesFieldNumber = 15;

		// Token: 0x04005FC8 RID: 24520
		private static readonly MapField<string, string>.Codec _map_variableKeyNames_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 122U);

		// Token: 0x04005FC9 RID: 24521
		private readonly MapField<string, string> variableKeyNames_ = new MapField<string, string>();

		// Token: 0x04005FCA RID: 24522
		public const int FlowTimeFieldNumber = 10;

		// Token: 0x04005FCB RID: 24523
		private long flowTime_;
	}
}
