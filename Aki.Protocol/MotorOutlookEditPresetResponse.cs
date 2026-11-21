using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A73 RID: 2675
	[NetMessage(EMessageId.MotorOutlookEditPresetResponse)]
	public sealed class MotorOutlookEditPresetResponse : IMessage<MotorOutlookEditPresetResponse>, IMessage, IEquatable<MotorOutlookEditPresetResponse>, IDeepCloneable<MotorOutlookEditPresetResponse>, IBufferMessage
	{
		// Token: 0x0600E971 RID: 59761 RVA: 0x00221AE4 File Offset: 0x0021FCE4
		[NullableContext(1)]
		public static MotorOutlookEditPresetResponse Create()
		{
			return new MotorOutlookEditPresetResponse();
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x0600E972 RID: 59762 RVA: 0x00221AEB File Offset: 0x0021FCEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x0600E973 RID: 59763 RVA: 0x00221AEE File Offset: 0x0021FCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookEditPresetResponse.Descriptor;
			}
		}

		// Token: 0x0600E974 RID: 59764 RVA: 0x00221AF5 File Offset: 0x0021FCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetResponse()
		{
		}

		// Token: 0x0600E975 RID: 59765 RVA: 0x00221B00 File Offset: 0x0021FD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetResponse(MotorOutlookEditPresetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorOutlookPreset_ = ((other.motorOutlookPreset_ != null) ? other.motorOutlookPreset_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E976 RID: 59766 RVA: 0x00221B4C File Offset: 0x0021FD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetResponse Clone()
		{
			return new MotorOutlookEditPresetResponse(this);
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x0600E977 RID: 59767 RVA: 0x00221B54 File Offset: 0x0021FD54
		// (set) Token: 0x0600E978 RID: 59768 RVA: 0x00221B5C File Offset: 0x0021FD5C
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

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x0600E979 RID: 59769 RVA: 0x00221B65 File Offset: 0x0021FD65
		// (set) Token: 0x0600E97A RID: 59770 RVA: 0x00221B6D File Offset: 0x0021FD6D
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

		// Token: 0x0600E97B RID: 59771 RVA: 0x00221B76 File Offset: 0x0021FD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookEditPresetResponse);
		}

		// Token: 0x0600E97C RID: 59772 RVA: 0x00221B84 File Offset: 0x0021FD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookEditPresetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.MotorOutlookPreset, other.MotorOutlookPreset) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E97D RID: 59773 RVA: 0x00221BD4 File Offset: 0x0021FDD4
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

		// Token: 0x0600E97E RID: 59774 RVA: 0x00221C2F File Offset: 0x0021FE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E97F RID: 59775 RVA: 0x00221C3C File Offset: 0x0021FE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E980 RID: 59776 RVA: 0x00221C48 File Offset: 0x0021FE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.motorOutlookPreset_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MotorOutlookPreset);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E981 RID: 59777 RVA: 0x00221CA4 File Offset: 0x0021FEA4
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

		// Token: 0x0600E982 RID: 59778 RVA: 0x00221CFC File Offset: 0x0021FEFC
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

		// Token: 0x0600E983 RID: 59779 RVA: 0x00221D64 File Offset: 0x0021FF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E984 RID: 59780 RVA: 0x00221D70 File Offset: 0x0021FF70
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
				if (num != 16U)
				{
					if (num != 50U)
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

		// Token: 0x04005F45 RID: 24389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F46 RID: 24390
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005F47 RID: 24391
		private ErrorCode errorCode_;

		// Token: 0x04005F48 RID: 24392
		public const int MotorOutlookPresetFieldNumber = 6;

		// Token: 0x04005F49 RID: 24393
		private MotorOutlookPlayerPresetPb motorOutlookPreset_;
	}
}
