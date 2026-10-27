using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7F RID: 2687
	[NetMessage(EMessageId.MotorOutlookCreatePresetRequest)]
	public sealed class MotorOutlookCreatePresetRequest : IMessage<MotorOutlookCreatePresetRequest>, IMessage, IEquatable<MotorOutlookCreatePresetRequest>, IDeepCloneable<MotorOutlookCreatePresetRequest>, IBufferMessage
	{
		// Token: 0x0600EA2B RID: 59947 RVA: 0x00222FDF File Offset: 0x002211DF
		[NullableContext(1)]
		public static MotorOutlookCreatePresetRequest Create()
		{
			return new MotorOutlookCreatePresetRequest();
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0600EA2C RID: 59948 RVA: 0x00222FE6 File Offset: 0x002211E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0600EA2D RID: 59949 RVA: 0x00222FE9 File Offset: 0x002211E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookCreatePresetRequest.Descriptor;
			}
		}

		// Token: 0x0600EA2E RID: 59950 RVA: 0x00222FF0 File Offset: 0x002211F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetRequest()
		{
		}

		// Token: 0x0600EA2F RID: 59951 RVA: 0x00223004 File Offset: 0x00221204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetRequest(MotorOutlookCreatePresetRequest other) : this()
		{
			this.preset_ = ((other.preset_ != null) ? other.preset_.Clone() : null);
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA30 RID: 59952 RVA: 0x00223050 File Offset: 0x00221250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetRequest Clone()
		{
			return new MotorOutlookCreatePresetRequest(this);
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600EA31 RID: 59953 RVA: 0x00223058 File Offset: 0x00221258
		// (set) Token: 0x0600EA32 RID: 59954 RVA: 0x00223060 File Offset: 0x00221260
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

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0600EA33 RID: 59955 RVA: 0x00223069 File Offset: 0x00221269
		// (set) Token: 0x0600EA34 RID: 59956 RVA: 0x00223071 File Offset: 0x00221271
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

		// Token: 0x0600EA35 RID: 59957 RVA: 0x00223084 File Offset: 0x00221284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookCreatePresetRequest);
		}

		// Token: 0x0600EA36 RID: 59958 RVA: 0x00223094 File Offset: 0x00221294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookCreatePresetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Preset, other.Preset) && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA37 RID: 59959 RVA: 0x002230E8 File Offset: 0x002212E8
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA38 RID: 59960 RVA: 0x0022313F File Offset: 0x0022133F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA39 RID: 59961 RVA: 0x0022314C File Offset: 0x0022134C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA3A RID: 59962 RVA: 0x00223158 File Offset: 0x00221358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this.preset_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Preset);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA3B RID: 59963 RVA: 0x002231B8 File Offset: 0x002213B8
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA3C RID: 59964 RVA: 0x00223214 File Offset: 0x00221414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookCreatePresetRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA3D RID: 59965 RVA: 0x00223281 File Offset: 0x00221481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA3E RID: 59966 RVA: 0x0022328C File Offset: 0x0022148C
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04005F27 RID: 24359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F28 RID: 24360
		public const int PresetFieldNumber = 12;

		// Token: 0x04005F29 RID: 24361
		private MotorOutlookEquippedPb preset_;

		// Token: 0x04005F2A RID: 24362
		public const int NameFieldNumber = 1;

		// Token: 0x04005F2B RID: 24363
		private string name_ = "";
	}
}
