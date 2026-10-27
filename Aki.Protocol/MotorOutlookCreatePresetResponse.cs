using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A80 RID: 2688
	[NetMessage(EMessageId.MotorOutlookCreatePresetResponse)]
	public sealed class MotorOutlookCreatePresetResponse : IMessage<MotorOutlookCreatePresetResponse>, IMessage, IEquatable<MotorOutlookCreatePresetResponse>, IDeepCloneable<MotorOutlookCreatePresetResponse>, IBufferMessage
	{
		// Token: 0x0600EA3F RID: 59967 RVA: 0x002232F7 File Offset: 0x002214F7
		[NullableContext(1)]
		public static MotorOutlookCreatePresetResponse Create()
		{
			return new MotorOutlookCreatePresetResponse();
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0600EA40 RID: 59968 RVA: 0x002232FE File Offset: 0x002214FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0600EA41 RID: 59969 RVA: 0x00223301 File Offset: 0x00221501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookCreatePresetResponse.Descriptor;
			}
		}

		// Token: 0x0600EA42 RID: 59970 RVA: 0x00223308 File Offset: 0x00221508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetResponse()
		{
		}

		// Token: 0x0600EA43 RID: 59971 RVA: 0x00223310 File Offset: 0x00221510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetResponse(MotorOutlookCreatePresetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorOutlookPreset_ = ((other.motorOutlookPreset_ != null) ? other.motorOutlookPreset_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA44 RID: 59972 RVA: 0x0022335C File Offset: 0x0022155C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookCreatePresetResponse Clone()
		{
			return new MotorOutlookCreatePresetResponse(this);
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x0600EA45 RID: 59973 RVA: 0x00223364 File Offset: 0x00221564
		// (set) Token: 0x0600EA46 RID: 59974 RVA: 0x0022336C File Offset: 0x0022156C
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

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0600EA47 RID: 59975 RVA: 0x00223375 File Offset: 0x00221575
		// (set) Token: 0x0600EA48 RID: 59976 RVA: 0x0022337D File Offset: 0x0022157D
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

		// Token: 0x0600EA49 RID: 59977 RVA: 0x00223386 File Offset: 0x00221586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookCreatePresetResponse);
		}

		// Token: 0x0600EA4A RID: 59978 RVA: 0x00223394 File Offset: 0x00221594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookCreatePresetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.MotorOutlookPreset, other.MotorOutlookPreset) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA4B RID: 59979 RVA: 0x002233E4 File Offset: 0x002215E4
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

		// Token: 0x0600EA4C RID: 59980 RVA: 0x0022343F File Offset: 0x0022163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA4D RID: 59981 RVA: 0x0022344C File Offset: 0x0022164C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA4E RID: 59982 RVA: 0x00223458 File Offset: 0x00221658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.motorOutlookPreset_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MotorOutlookPreset);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA4F RID: 59983 RVA: 0x002234B4 File Offset: 0x002216B4
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

		// Token: 0x0600EA50 RID: 59984 RVA: 0x0022350C File Offset: 0x0022170C
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

		// Token: 0x0600EA51 RID: 59985 RVA: 0x00223574 File Offset: 0x00221774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA52 RID: 59986 RVA: 0x00223580 File Offset: 0x00221780
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
				if (num != 40U)
				{
					if (num != 114U)
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

		// Token: 0x04005F2C RID: 24364
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F2D RID: 24365
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04005F2E RID: 24366
		private ErrorCode errorCode_;

		// Token: 0x04005F2F RID: 24367
		public const int MotorOutlookPresetFieldNumber = 14;

		// Token: 0x04005F30 RID: 24368
		private MotorOutlookPlayerPresetPb motorOutlookPreset_;
	}
}
