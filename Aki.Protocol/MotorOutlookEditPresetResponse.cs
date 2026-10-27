using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A84 RID: 2692
	[NetMessage(EMessageId.MotorOutlookEditPresetResponse)]
	public sealed class MotorOutlookEditPresetResponse : IMessage<MotorOutlookEditPresetResponse>, IMessage, IEquatable<MotorOutlookEditPresetResponse>, IDeepCloneable<MotorOutlookEditPresetResponse>, IBufferMessage
	{
		// Token: 0x0600EA8B RID: 60043 RVA: 0x00223CE0 File Offset: 0x00221EE0
		[NullableContext(1)]
		public static MotorOutlookEditPresetResponse Create()
		{
			return new MotorOutlookEditPresetResponse();
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x0600EA8C RID: 60044 RVA: 0x00223CE7 File Offset: 0x00221EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x0600EA8D RID: 60045 RVA: 0x00223CEA File Offset: 0x00221EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookEditPresetResponse.Descriptor;
			}
		}

		// Token: 0x0600EA8E RID: 60046 RVA: 0x00223CF1 File Offset: 0x00221EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetResponse()
		{
		}

		// Token: 0x0600EA8F RID: 60047 RVA: 0x00223CFC File Offset: 0x00221EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetResponse(MotorOutlookEditPresetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorOutlookPreset_ = ((other.motorOutlookPreset_ != null) ? other.motorOutlookPreset_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA90 RID: 60048 RVA: 0x00223D48 File Offset: 0x00221F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetResponse Clone()
		{
			return new MotorOutlookEditPresetResponse(this);
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x0600EA91 RID: 60049 RVA: 0x00223D50 File Offset: 0x00221F50
		// (set) Token: 0x0600EA92 RID: 60050 RVA: 0x00223D58 File Offset: 0x00221F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x00223D61 File Offset: 0x00221F61
		// (set) Token: 0x0600EA94 RID: 60052 RVA: 0x00223D69 File Offset: 0x00221F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPlayerPresetPb MotorOutlookPreset
		{
			get
			{
				return this.motorOutlookPreset_;
			}
			set
			{
				this.motorOutlookPreset_ = value;
			}
		}

		// Token: 0x0600EA95 RID: 60053 RVA: 0x00223D72 File Offset: 0x00221F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookEditPresetResponse);
		}

		// Token: 0x0600EA96 RID: 60054 RVA: 0x00223D80 File Offset: 0x00221F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookEditPresetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.MotorOutlookPreset, other.MotorOutlookPreset) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA97 RID: 60055 RVA: 0x00223DD0 File Offset: 0x00221FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.motorOutlookPreset_ != null)
			{
				num ^= this.MotorOutlookPreset.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA98 RID: 60056 RVA: 0x00223E2B File Offset: 0x0022202B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA99 RID: 60057 RVA: 0x00223E38 File Offset: 0x00222038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA9A RID: 60058 RVA: 0x00223E44 File Offset: 0x00222044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookPreset_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.MotorOutlookPreset);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA9B RID: 60059 RVA: 0x00223EA0 File Offset: 0x002220A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.motorOutlookPreset_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookPreset);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA9C RID: 60060 RVA: 0x00223EF8 File Offset: 0x002220F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookEditPresetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.motorOutlookPreset_ != null)
			{
				if (this.motorOutlookPreset_ == null)
				{
					this.MotorOutlookPreset = new MotorOutlookPlayerPresetPb();
				}
				this.MotorOutlookPreset.MergeFrom(other.MotorOutlookPreset);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA9D RID: 60061 RVA: 0x00223F60 File Offset: 0x00222160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA9E RID: 60062 RVA: 0x00223F6C File Offset: 0x0022216C
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
				if (num != 42U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.motorOutlookPreset_ == null)
					{
						this.MotorOutlookPreset = new MotorOutlookPlayerPresetPb();
					}
					input.ReadMessage(this.MotorOutlookPreset);
				}
			}
		}

		// Token: 0x04005F3C RID: 24380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F3D RID: 24381
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005F3E RID: 24382
		private ErrorCode errorCode_;

		// Token: 0x04005F3F RID: 24383
		public const int MotorOutlookPresetFieldNumber = 5;

		// Token: 0x04005F40 RID: 24384
		private MotorOutlookPlayerPresetPb motorOutlookPreset_;
	}
}
