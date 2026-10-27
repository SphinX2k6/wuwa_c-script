using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8F RID: 2703
	public sealed class MotorOutlookPresetPlanPb : IMessage<MotorOutlookPresetPlanPb>, IMessage, IEquatable<MotorOutlookPresetPlanPb>, IDeepCloneable<MotorOutlookPresetPlanPb>, IBufferMessage
	{
		// Token: 0x0600EB6A RID: 60266 RVA: 0x00225D89 File Offset: 0x00223F89
		[NullableContext(1)]
		public static MotorOutlookPresetPlanPb Create()
		{
			return new MotorOutlookPresetPlanPb();
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x0600EB6B RID: 60267 RVA: 0x00225D90 File Offset: 0x00223F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOutlookPresetPlanPb> Parser
		{
			get
			{
				return MotorOutlookPresetPlanPb._parser;
			}
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x0600EB6C RID: 60268 RVA: 0x00225D97 File Offset: 0x00223F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x0600EB6D RID: 60269 RVA: 0x00225D9A File Offset: 0x00223F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookPresetPlanPb.Descriptor;
			}
		}

		// Token: 0x0600EB6E RID: 60270 RVA: 0x00225DA1 File Offset: 0x00223FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPresetPlanPb()
		{
		}

		// Token: 0x0600EB6F RID: 60271 RVA: 0x00225DB4 File Offset: 0x00223FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPresetPlanPb(MotorOutlookPresetPlanPb other) : this()
		{
			this.preset_ = ((other.preset_ != null) ? other.preset_.Clone() : null);
			this.name_ = other.name_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x00225E0C File Offset: 0x0022400C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPresetPlanPb Clone()
		{
			return new MotorOutlookPresetPlanPb(this);
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0600EB71 RID: 60273 RVA: 0x00225E14 File Offset: 0x00224014
		// (set) Token: 0x0600EB72 RID: 60274 RVA: 0x00225E1C File Offset: 0x0022401C
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

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600EB73 RID: 60275 RVA: 0x00225E25 File Offset: 0x00224025
		// (set) Token: 0x0600EB74 RID: 60276 RVA: 0x00225E2D File Offset: 0x0022402D
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

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0600EB75 RID: 60277 RVA: 0x00225E40 File Offset: 0x00224040
		// (set) Token: 0x0600EB76 RID: 60278 RVA: 0x00225E48 File Offset: 0x00224048
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

		// Token: 0x0600EB77 RID: 60279 RVA: 0x00225E51 File Offset: 0x00224051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookPresetPlanPb);
		}

		// Token: 0x0600EB78 RID: 60280 RVA: 0x00225E60 File Offset: 0x00224060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookPresetPlanPb other)
		{
			return other != null && (other == this || (object.Equals(this.Preset, other.Preset) && !(this.Name != other.Name) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB79 RID: 60281 RVA: 0x00225EC4 File Offset: 0x002240C4
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

		// Token: 0x0600EB7A RID: 60282 RVA: 0x00225F34 File Offset: 0x00224134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB7B RID: 60283 RVA: 0x00225F41 File Offset: 0x00224141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x00225F4C File Offset: 0x0022414C
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

		// Token: 0x0600EB7D RID: 60285 RVA: 0x00225FC8 File Offset: 0x002241C8
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

		// Token: 0x0600EB7E RID: 60286 RVA: 0x0022603C File Offset: 0x0022423C
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

		// Token: 0x0600EB7F RID: 60287 RVA: 0x002260BD File Offset: 0x002242BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB80 RID: 60288 RVA: 0x002260C8 File Offset: 0x002242C8
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

		// Token: 0x04005F82 RID: 24450
		private static readonly MessageParser<MotorOutlookPresetPlanPb> _parser = new MessageParser<MotorOutlookPresetPlanPb>(() => new MotorOutlookPresetPlanPb());

		// Token: 0x04005F83 RID: 24451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F84 RID: 24452
		public const int PresetFieldNumber = 1;

		// Token: 0x04005F85 RID: 24453
		private MotorOutlookEquippedPb preset_;

		// Token: 0x04005F86 RID: 24454
		public const int NameFieldNumber = 2;

		// Token: 0x04005F87 RID: 24455
		private string name_ = "";

		// Token: 0x04005F88 RID: 24456
		public const int IdFieldNumber = 3;

		// Token: 0x04005F89 RID: 24457
		private int id_;
	}
}
