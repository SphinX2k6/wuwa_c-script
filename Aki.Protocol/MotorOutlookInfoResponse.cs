using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8A RID: 2698
	[NetMessage(EMessageId.MotorOutlookInfoResponse)]
	public sealed class MotorOutlookInfoResponse : IMessage<MotorOutlookInfoResponse>, IMessage, IEquatable<MotorOutlookInfoResponse>, IDeepCloneable<MotorOutlookInfoResponse>, IBufferMessage
	{
		// Token: 0x0600EB03 RID: 60163 RVA: 0x00224D02 File Offset: 0x00222F02
		[NullableContext(1)]
		public static MotorOutlookInfoResponse Create()
		{
			return new MotorOutlookInfoResponse();
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x0600EB04 RID: 60164 RVA: 0x00224D09 File Offset: 0x00222F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x0600EB05 RID: 60165 RVA: 0x00224D0C File Offset: 0x00222F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600EB06 RID: 60166 RVA: 0x00224D13 File Offset: 0x00222F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoResponse()
		{
		}

		// Token: 0x0600EB07 RID: 60167 RVA: 0x00224D1C File Offset: 0x00222F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoResponse(MotorOutlookInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorOutlook_ = ((other.motorOutlook_ != null) ? other.motorOutlook_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB08 RID: 60168 RVA: 0x00224D68 File Offset: 0x00222F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoResponse Clone()
		{
			return new MotorOutlookInfoResponse(this);
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x0600EB09 RID: 60169 RVA: 0x00224D70 File Offset: 0x00222F70
		// (set) Token: 0x0600EB0A RID: 60170 RVA: 0x00224D78 File Offset: 0x00222F78
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

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x0600EB0B RID: 60171 RVA: 0x00224D81 File Offset: 0x00222F81
		// (set) Token: 0x0600EB0C RID: 60172 RVA: 0x00224D89 File Offset: 0x00222F89
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

		// Token: 0x0600EB0D RID: 60173 RVA: 0x00224D92 File Offset: 0x00222F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookInfoResponse);
		}

		// Token: 0x0600EB0E RID: 60174 RVA: 0x00224DA0 File Offset: 0x00222FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.MotorOutlook, other.MotorOutlook) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB0F RID: 60175 RVA: 0x00224DF0 File Offset: 0x00222FF0
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

		// Token: 0x0600EB10 RID: 60176 RVA: 0x00224E4B File Offset: 0x0022304B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB11 RID: 60177 RVA: 0x00224E58 File Offset: 0x00223058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB12 RID: 60178 RVA: 0x00224E64 File Offset: 0x00223064
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
				output.WriteRawTag(50);
				output.WriteMessage(this.MotorOutlook);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB13 RID: 60179 RVA: 0x00224EC0 File Offset: 0x002230C0
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

		// Token: 0x0600EB14 RID: 60180 RVA: 0x00224F18 File Offset: 0x00223118
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

		// Token: 0x0600EB15 RID: 60181 RVA: 0x00224F80 File Offset: 0x00223180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x00224F8C File Offset: 0x0022318C
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
					if (num != 50U)
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

		// Token: 0x04005F5D RID: 24413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F5E RID: 24414
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04005F5F RID: 24415
		private ErrorCode errorCode_;

		// Token: 0x04005F60 RID: 24416
		public const int MotorOutlookFieldNumber = 6;

		// Token: 0x04005F61 RID: 24417
		private MotorOutlookPb motorOutlook_;
	}
}
