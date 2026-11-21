using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7E RID: 2686
	public sealed class MotorOutlookPresetPlanPb : IMessage<MotorOutlookPresetPlanPb>, IMessage, IEquatable<MotorOutlookPresetPlanPb>, IDeepCloneable<MotorOutlookPresetPlanPb>, IBufferMessage
	{
		// Token: 0x0600EA50 RID: 59984 RVA: 0x00223B8D File Offset: 0x00221D8D
		[NullableContext(1)]
		public static MotorOutlookPresetPlanPb Create()
		{
			return new MotorOutlookPresetPlanPb();
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0600EA51 RID: 59985 RVA: 0x00223B94 File Offset: 0x00221D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOutlookPresetPlanPb> Parser
		{
			get
			{
				return MotorOutlookPresetPlanPb._parser;
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0600EA52 RID: 59986 RVA: 0x00223B9B File Offset: 0x00221D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x0600EA53 RID: 59987 RVA: 0x00223B9E File Offset: 0x00221D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookPresetPlanPb.Descriptor;
			}
		}

		// Token: 0x0600EA54 RID: 59988 RVA: 0x00223BA5 File Offset: 0x00221DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPresetPlanPb()
		{
		}

		// Token: 0x0600EA55 RID: 59989 RVA: 0x00223BB8 File Offset: 0x00221DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPresetPlanPb(MotorOutlookPresetPlanPb other) : this()
		{
			this.preset_ = ((other.preset_ != null) ? other.preset_.Clone() : null);
			this.name_ = other.name_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA56 RID: 59990 RVA: 0x00223C10 File Offset: 0x00221E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPresetPlanPb Clone()
		{
			return new MotorOutlookPresetPlanPb(this);
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x00223C18 File Offset: 0x00221E18
		// (set) Token: 0x0600EA58 RID: 59992 RVA: 0x00223C20 File Offset: 0x00221E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb Preset
		{
			get
			{
				return this.preset_;
			}
			set
			{
				this.preset_ = value;
			}
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x00223C29 File Offset: 0x00221E29
		// (set) Token: 0x0600EA5A RID: 59994 RVA: 0x00223C31 File Offset: 0x00221E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600EA5B RID: 59995 RVA: 0x00223C44 File Offset: 0x00221E44
		// (set) Token: 0x0600EA5C RID: 59996 RVA: 0x00223C4C File Offset: 0x00221E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600EA5D RID: 59997 RVA: 0x00223C55 File Offset: 0x00221E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookPresetPlanPb);
		}

		// Token: 0x0600EA5E RID: 59998 RVA: 0x00223C64 File Offset: 0x00221E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookPresetPlanPb other)
		{
			return other != null && (other == this || (object.Equals(this.Preset, other.Preset) && !(this.Name != other.Name) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA5F RID: 59999 RVA: 0x00223CC8 File Offset: 0x00221EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.preset_ != null)
			{
				num ^= this.Preset.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA60 RID: 60000 RVA: 0x00223D38 File Offset: 0x00221F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA61 RID: 60001 RVA: 0x00223D45 File Offset: 0x00221F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA62 RID: 60002 RVA: 0x00223D50 File Offset: 0x00221F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.preset_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Preset);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA63 RID: 60003 RVA: 0x00223DCC File Offset: 0x00221FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.preset_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Preset);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x00223E40 File Offset: 0x00222040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookPresetPlanPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.preset_ != null)
			{
				if (this.preset_ == null)
				{
					this.Preset = new MotorOutlookEquippedPb();
				}
				this.Preset.MergeFrom(other.Preset);
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA65 RID: 60005 RVA: 0x00223EC1 File Offset: 0x002220C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA66 RID: 60006 RVA: 0x00223ECC File Offset: 0x002220CC
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadInt32();
						}
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					if (this.preset_ == null)
					{
						this.Preset = new MotorOutlookEquippedPb();
					}
					input.ReadMessage(this.Preset);
				}
			}
		}

		// Token: 0x04005F8B RID: 24459
		private static readonly MessageParser<MotorOutlookPresetPlanPb> _parser = new MessageParser<MotorOutlookPresetPlanPb>(() => new MotorOutlookPresetPlanPb());

		// Token: 0x04005F8C RID: 24460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F8D RID: 24461
		public const int PresetFieldNumber = 1;

		// Token: 0x04005F8E RID: 24462
		private MotorOutlookEquippedPb preset_;

		// Token: 0x04005F8F RID: 24463
		public const int NameFieldNumber = 2;

		// Token: 0x04005F90 RID: 24464
		private string name_ = "";

		// Token: 0x04005F91 RID: 24465
		public const int IdFieldNumber = 3;

		// Token: 0x04005F92 RID: 24466
		private int id_;
	}
}
