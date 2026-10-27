using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A82 RID: 2690
	[NetMessage(EMessageId.MotorOutlookDeletePresetResponse)]
	public sealed class MotorOutlookDeletePresetResponse : IMessage<MotorOutlookDeletePresetResponse>, IMessage, IEquatable<MotorOutlookDeletePresetResponse>, IDeepCloneable<MotorOutlookDeletePresetResponse>, IBufferMessage
	{
		// Token: 0x0600EA65 RID: 60005 RVA: 0x002237C5 File Offset: 0x002219C5
		[NullableContext(1)]
		public static MotorOutlookDeletePresetResponse Create()
		{
			return new MotorOutlookDeletePresetResponse();
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x0600EA66 RID: 60006 RVA: 0x002237CC File Offset: 0x002219CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0600EA67 RID: 60007 RVA: 0x002237CF File Offset: 0x002219CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookDeletePresetResponse.Descriptor;
			}
		}

		// Token: 0x0600EA68 RID: 60008 RVA: 0x002237D6 File Offset: 0x002219D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetResponse()
		{
		}

		// Token: 0x0600EA69 RID: 60009 RVA: 0x002237E0 File Offset: 0x002219E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetResponse(MotorOutlookDeletePresetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorOutlookPreset_ = ((other.motorOutlookPreset_ != null) ? other.motorOutlookPreset_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA6A RID: 60010 RVA: 0x0022382C File Offset: 0x00221A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetResponse Clone()
		{
			return new MotorOutlookDeletePresetResponse(this);
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x0600EA6B RID: 60011 RVA: 0x00223834 File Offset: 0x00221A34
		// (set) Token: 0x0600EA6C RID: 60012 RVA: 0x0022383C File Offset: 0x00221A3C
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

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x0600EA6D RID: 60013 RVA: 0x00223845 File Offset: 0x00221A45
		// (set) Token: 0x0600EA6E RID: 60014 RVA: 0x0022384D File Offset: 0x00221A4D
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

		// Token: 0x0600EA6F RID: 60015 RVA: 0x00223856 File Offset: 0x00221A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookDeletePresetResponse);
		}

		// Token: 0x0600EA70 RID: 60016 RVA: 0x00223864 File Offset: 0x00221A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookDeletePresetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.MotorOutlookPreset, other.MotorOutlookPreset) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA71 RID: 60017 RVA: 0x002238B4 File Offset: 0x00221AB4
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

		// Token: 0x0600EA72 RID: 60018 RVA: 0x0022390F File Offset: 0x00221B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA73 RID: 60019 RVA: 0x0022391C File Offset: 0x00221B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA74 RID: 60020 RVA: 0x00223928 File Offset: 0x00221B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.motorOutlookPreset_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.MotorOutlookPreset);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA75 RID: 60021 RVA: 0x00223984 File Offset: 0x00221B84
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

		// Token: 0x0600EA76 RID: 60022 RVA: 0x002239DC File Offset: 0x00221BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookDeletePresetResponse other)
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

		// Token: 0x0600EA77 RID: 60023 RVA: 0x00223A44 File Offset: 0x00221C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA78 RID: 60024 RVA: 0x00223A50 File Offset: 0x00221C50
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
				if (num != 72U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005F34 RID: 24372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F35 RID: 24373
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005F36 RID: 24374
		private ErrorCode errorCode_;

		// Token: 0x04005F37 RID: 24375
		public const int MotorOutlookPresetFieldNumber = 11;

		// Token: 0x04005F38 RID: 24376
		private MotorOutlookPlayerPresetPb motorOutlookPreset_;
	}
}
