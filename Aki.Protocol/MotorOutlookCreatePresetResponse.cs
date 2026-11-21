using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6F RID: 2671
	[NetMessage(EMessageId.MotorOutlookCreatePresetResponse)]
	public sealed class MotorOutlookCreatePresetResponse : IMessage<MotorOutlookCreatePresetResponse>, IMessage, IEquatable<MotorOutlookCreatePresetResponse>, IDeepCloneable<MotorOutlookCreatePresetResponse>, IBufferMessage
	{
		// Token: 0x0600E925 RID: 59685 RVA: 0x002210FF File Offset: 0x0021F2FF
		[NullableContext(1)]
		public static MotorOutlookCreatePresetResponse Create()
		{
			return new MotorOutlookCreatePresetResponse();
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x0600E926 RID: 59686 RVA: 0x00221106 File Offset: 0x0021F306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x0600E927 RID: 59687 RVA: 0x00221109 File Offset: 0x0021F309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookCreatePresetResponse.Descriptor;
			}
		}

		// Token: 0x0600E928 RID: 59688 RVA: 0x00221110 File Offset: 0x0021F310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetResponse()
		{
		}

		// Token: 0x0600E929 RID: 59689 RVA: 0x00221118 File Offset: 0x0021F318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetResponse(MotorOutlookCreatePresetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorOutlookPreset_ = ((other.motorOutlookPreset_ != null) ? other.motorOutlookPreset_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E92A RID: 59690 RVA: 0x00221164 File Offset: 0x0021F364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetResponse Clone()
		{
			return new MotorOutlookCreatePresetResponse(this);
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x0600E92B RID: 59691 RVA: 0x0022116C File Offset: 0x0021F36C
		// (set) Token: 0x0600E92C RID: 59692 RVA: 0x00221174 File Offset: 0x0021F374
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

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x0600E92D RID: 59693 RVA: 0x0022117D File Offset: 0x0021F37D
		// (set) Token: 0x0600E92E RID: 59694 RVA: 0x00221185 File Offset: 0x0021F385
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

		// Token: 0x0600E92F RID: 59695 RVA: 0x0022118E File Offset: 0x0021F38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookCreatePresetResponse);
		}

		// Token: 0x0600E930 RID: 59696 RVA: 0x0022119C File Offset: 0x0021F39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookCreatePresetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.MotorOutlookPreset, other.MotorOutlookPreset) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E931 RID: 59697 RVA: 0x002211EC File Offset: 0x0021F3EC
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

		// Token: 0x0600E932 RID: 59698 RVA: 0x00221247 File Offset: 0x0021F447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E933 RID: 59699 RVA: 0x00221254 File Offset: 0x0021F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E934 RID: 59700 RVA: 0x00221260 File Offset: 0x0021F460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookPreset_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.MotorOutlookPreset);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E935 RID: 59701 RVA: 0x002212BC File Offset: 0x0021F4BC
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

		// Token: 0x0600E936 RID: 59702 RVA: 0x00221314 File Offset: 0x0021F514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookCreatePresetResponse other)
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

		// Token: 0x0600E937 RID: 59703 RVA: 0x0022137C File Offset: 0x0021F57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E938 RID: 59704 RVA: 0x00221388 File Offset: 0x0021F588
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
				if (num != 74U)
				{
					if (num != 96U)
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

		// Token: 0x04005F35 RID: 24373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F36 RID: 24374
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04005F37 RID: 24375
		private ErrorCode errorCode_;

		// Token: 0x04005F38 RID: 24376
		public const int MotorOutlookPresetFieldNumber = 9;

		// Token: 0x04005F39 RID: 24377
		private MotorOutlookPlayerPresetPb motorOutlookPreset_;
	}
}
