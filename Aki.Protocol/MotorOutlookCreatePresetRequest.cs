using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6E RID: 2670
	[NetMessage(EMessageId.MotorOutlookCreatePresetRequest)]
	public sealed class MotorOutlookCreatePresetRequest : IMessage<MotorOutlookCreatePresetRequest>, IMessage, IEquatable<MotorOutlookCreatePresetRequest>, IDeepCloneable<MotorOutlookCreatePresetRequest>, IBufferMessage
	{
		// Token: 0x0600E911 RID: 59665 RVA: 0x00220DE7 File Offset: 0x0021EFE7
		[NullableContext(1)]
		public static MotorOutlookCreatePresetRequest Create()
		{
			return new MotorOutlookCreatePresetRequest();
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x0600E912 RID: 59666 RVA: 0x00220DEE File Offset: 0x0021EFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0600E913 RID: 59667 RVA: 0x00220DF1 File Offset: 0x0021EFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookCreatePresetRequest.Descriptor;
			}
		}

		// Token: 0x0600E914 RID: 59668 RVA: 0x00220DF8 File Offset: 0x0021EFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetRequest()
		{
		}

		// Token: 0x0600E915 RID: 59669 RVA: 0x00220E0C File Offset: 0x0021F00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetRequest(MotorOutlookCreatePresetRequest other) : this()
		{
			this.preset_ = ((other.preset_ != null) ? other.preset_.Clone() : null);
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E916 RID: 59670 RVA: 0x00220E58 File Offset: 0x0021F058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetRequest Clone()
		{
			return new MotorOutlookCreatePresetRequest(this);
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0600E917 RID: 59671 RVA: 0x00220E60 File Offset: 0x0021F060
		// (set) Token: 0x0600E918 RID: 59672 RVA: 0x00220E68 File Offset: 0x0021F068
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

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0600E919 RID: 59673 RVA: 0x00220E71 File Offset: 0x0021F071
		// (set) Token: 0x0600E91A RID: 59674 RVA: 0x00220E79 File Offset: 0x0021F079
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

		// Token: 0x0600E91B RID: 59675 RVA: 0x00220E8C File Offset: 0x0021F08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookCreatePresetRequest);
		}

		// Token: 0x0600E91C RID: 59676 RVA: 0x00220E9C File Offset: 0x0021F09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookCreatePresetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Preset, other.Preset) && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E91D RID: 59677 RVA: 0x00220EF0 File Offset: 0x0021F0F0
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

		// Token: 0x0600E91E RID: 59678 RVA: 0x00220F47 File Offset: 0x0021F147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E91F RID: 59679 RVA: 0x00220F54 File Offset: 0x0021F154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E920 RID: 59680 RVA: 0x00220F60 File Offset: 0x0021F160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.preset_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Preset);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E921 RID: 59681 RVA: 0x00220FC0 File Offset: 0x0021F1C0
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

		// Token: 0x0600E922 RID: 59682 RVA: 0x0022101C File Offset: 0x0021F21C
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

		// Token: 0x0600E923 RID: 59683 RVA: 0x00221089 File Offset: 0x0021F289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E924 RID: 59684 RVA: 0x00221094 File Offset: 0x0021F294
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
				if (num != 34U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04005F30 RID: 24368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F31 RID: 24369
		public const int PresetFieldNumber = 4;

		// Token: 0x04005F32 RID: 24370
		private MotorOutlookEquippedPb preset_;

		// Token: 0x04005F33 RID: 24371
		public const int NameFieldNumber = 9;

		// Token: 0x04005F34 RID: 24372
		private string name_ = "";
	}
}
