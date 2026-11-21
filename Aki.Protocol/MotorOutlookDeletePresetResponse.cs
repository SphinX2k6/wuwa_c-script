using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A71 RID: 2673
	[NetMessage(EMessageId.MotorOutlookDeletePresetResponse)]
	public sealed class MotorOutlookDeletePresetResponse : IMessage<MotorOutlookDeletePresetResponse>, IMessage, IEquatable<MotorOutlookDeletePresetResponse>, IDeepCloneable<MotorOutlookDeletePresetResponse>, IBufferMessage
	{
		// Token: 0x0600E94B RID: 59723 RVA: 0x002215CD File Offset: 0x0021F7CD
		[NullableContext(1)]
		public static MotorOutlookDeletePresetResponse Create()
		{
			return new MotorOutlookDeletePresetResponse();
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x0600E94C RID: 59724 RVA: 0x002215D4 File Offset: 0x0021F7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x0600E94D RID: 59725 RVA: 0x002215D7 File Offset: 0x0021F7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookDeletePresetResponse.Descriptor;
			}
		}

		// Token: 0x0600E94E RID: 59726 RVA: 0x002215DE File Offset: 0x0021F7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetResponse()
		{
		}

		// Token: 0x0600E94F RID: 59727 RVA: 0x002215E8 File Offset: 0x0021F7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetResponse(MotorOutlookDeletePresetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorOutlookPreset_ = ((other.motorOutlookPreset_ != null) ? other.motorOutlookPreset_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E950 RID: 59728 RVA: 0x00221634 File Offset: 0x0021F834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetResponse Clone()
		{
			return new MotorOutlookDeletePresetResponse(this);
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0600E951 RID: 59729 RVA: 0x0022163C File Offset: 0x0021F83C
		// (set) Token: 0x0600E952 RID: 59730 RVA: 0x00221644 File Offset: 0x0021F844
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

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x0600E953 RID: 59731 RVA: 0x0022164D File Offset: 0x0021F84D
		// (set) Token: 0x0600E954 RID: 59732 RVA: 0x00221655 File Offset: 0x0021F855
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

		// Token: 0x0600E955 RID: 59733 RVA: 0x0022165E File Offset: 0x0021F85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookDeletePresetResponse);
		}

		// Token: 0x0600E956 RID: 59734 RVA: 0x0022166C File Offset: 0x0021F86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookDeletePresetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.MotorOutlookPreset, other.MotorOutlookPreset) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E957 RID: 59735 RVA: 0x002216BC File Offset: 0x0021F8BC
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

		// Token: 0x0600E958 RID: 59736 RVA: 0x00221717 File Offset: 0x0021F917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E959 RID: 59737 RVA: 0x00221724 File Offset: 0x0021F924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E95A RID: 59738 RVA: 0x00221730 File Offset: 0x0021F930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.motorOutlookPreset_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.MotorOutlookPreset);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x00221788 File Offset: 0x0021F988
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

		// Token: 0x0600E95C RID: 59740 RVA: 0x002217E0 File Offset: 0x0021F9E0
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

		// Token: 0x0600E95D RID: 59741 RVA: 0x00221848 File Offset: 0x0021FA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x00221854 File Offset: 0x0021FA54
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
				if (num != 8U)
				{
					if (num != 74U)
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

		// Token: 0x04005F3D RID: 24381
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F3E RID: 24382
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04005F3F RID: 24383
		private ErrorCode errorCode_;

		// Token: 0x04005F40 RID: 24384
		public const int MotorOutlookPresetFieldNumber = 9;

		// Token: 0x04005F41 RID: 24385
		private MotorOutlookPlayerPresetPb motorOutlookPreset_;
	}
}
