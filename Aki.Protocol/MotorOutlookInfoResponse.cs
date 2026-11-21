using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A79 RID: 2681
	[NetMessage(EMessageId.MotorOutlookInfoResponse)]
	public sealed class MotorOutlookInfoResponse : IMessage<MotorOutlookInfoResponse>, IMessage, IEquatable<MotorOutlookInfoResponse>, IDeepCloneable<MotorOutlookInfoResponse>, IBufferMessage
	{
		// Token: 0x0600E9E9 RID: 59881 RVA: 0x00222B06 File Offset: 0x00220D06
		[NullableContext(1)]
		public static MotorOutlookInfoResponse Create()
		{
			return new MotorOutlookInfoResponse();
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0600E9EA RID: 59882 RVA: 0x00222B0D File Offset: 0x00220D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x0600E9EB RID: 59883 RVA: 0x00222B10 File Offset: 0x00220D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600E9EC RID: 59884 RVA: 0x00222B17 File Offset: 0x00220D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoResponse()
		{
		}

		// Token: 0x0600E9ED RID: 59885 RVA: 0x00222B20 File Offset: 0x00220D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoResponse(MotorOutlookInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorOutlook_ = ((other.motorOutlook_ != null) ? other.motorOutlook_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E9EE RID: 59886 RVA: 0x00222B6C File Offset: 0x00220D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoResponse Clone()
		{
			return new MotorOutlookInfoResponse(this);
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x0600E9EF RID: 59887 RVA: 0x00222B74 File Offset: 0x00220D74
		// (set) Token: 0x0600E9F0 RID: 59888 RVA: 0x00222B7C File Offset: 0x00220D7C
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

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x0600E9F1 RID: 59889 RVA: 0x00222B85 File Offset: 0x00220D85
		// (set) Token: 0x0600E9F2 RID: 59890 RVA: 0x00222B8D File Offset: 0x00220D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPb MotorOutlook
		{
			get
			{
				return this.motorOutlook_;
			}
			set
			{
				this.motorOutlook_ = value;
			}
		}

		// Token: 0x0600E9F3 RID: 59891 RVA: 0x00222B96 File Offset: 0x00220D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookInfoResponse);
		}

		// Token: 0x0600E9F4 RID: 59892 RVA: 0x00222BA4 File Offset: 0x00220DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.MotorOutlook, other.MotorOutlook) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9F5 RID: 59893 RVA: 0x00222BF4 File Offset: 0x00220DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.motorOutlook_ != null)
			{
				num ^= this.MotorOutlook.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E9F6 RID: 59894 RVA: 0x00222C4F File Offset: 0x00220E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9F7 RID: 59895 RVA: 0x00222C5C File Offset: 0x00220E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9F8 RID: 59896 RVA: 0x00222C68 File Offset: 0x00220E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.motorOutlook_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MotorOutlook);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E9F9 RID: 59897 RVA: 0x00222CC4 File Offset: 0x00220EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.motorOutlook_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlook);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E9FA RID: 59898 RVA: 0x00222D1C File Offset: 0x00220F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.motorOutlook_ != null)
			{
				if (this.motorOutlook_ == null)
				{
					this.MotorOutlook = new MotorOutlookPb();
				}
				this.MotorOutlook.MergeFrom(other.MotorOutlook);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E9FB RID: 59899 RVA: 0x00222D84 File Offset: 0x00220F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9FC RID: 59900 RVA: 0x00222D90 File Offset: 0x00220F90
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.motorOutlook_ == null)
						{
							this.MotorOutlook = new MotorOutlookPb();
						}
						input.ReadMessage(this.MotorOutlook);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005F66 RID: 24422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F67 RID: 24423
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04005F68 RID: 24424
		private ErrorCode errorCode_;

		// Token: 0x04005F69 RID: 24425
		public const int MotorOutlookFieldNumber = 10;

		// Token: 0x04005F6A RID: 24426
		private MotorOutlookPb motorOutlook_;
	}
}
