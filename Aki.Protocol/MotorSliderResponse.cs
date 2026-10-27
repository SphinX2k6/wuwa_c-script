using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA0 RID: 2720
	[NetMessage(EMessageId.MotorSliderResponse)]
	public sealed class MotorSliderResponse : IMessage<MotorSliderResponse>, IMessage, IEquatable<MotorSliderResponse>, IDeepCloneable<MotorSliderResponse>, IBufferMessage
	{
		// Token: 0x0600ECD1 RID: 60625 RVA: 0x002292AC File Offset: 0x002274AC
		[NullableContext(1)]
		public static MotorSliderResponse Create()
		{
			return new MotorSliderResponse();
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x0600ECD2 RID: 60626 RVA: 0x002292B3 File Offset: 0x002274B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x0600ECD3 RID: 60627 RVA: 0x002292B6 File Offset: 0x002274B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSliderResponse.Descriptor;
			}
		}

		// Token: 0x0600ECD4 RID: 60628 RVA: 0x002292BD File Offset: 0x002274BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderResponse()
		{
		}

		// Token: 0x0600ECD5 RID: 60629 RVA: 0x002292C5 File Offset: 0x002274C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderResponse(MotorSliderResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECD6 RID: 60630 RVA: 0x002292EA File Offset: 0x002274EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderResponse Clone()
		{
			return new MotorSliderResponse(this);
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x0600ECD7 RID: 60631 RVA: 0x002292F2 File Offset: 0x002274F2
		// (set) Token: 0x0600ECD8 RID: 60632 RVA: 0x002292FA File Offset: 0x002274FA
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

		// Token: 0x0600ECD9 RID: 60633 RVA: 0x00229303 File Offset: 0x00227503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSliderResponse);
		}

		// Token: 0x0600ECDA RID: 60634 RVA: 0x00229311 File Offset: 0x00227511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSliderResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECDB RID: 60635 RVA: 0x00229340 File Offset: 0x00227540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ECDC RID: 60636 RVA: 0x00229385 File Offset: 0x00227585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECDD RID: 60637 RVA: 0x00229392 File Offset: 0x00227592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECDE RID: 60638 RVA: 0x0022939B File Offset: 0x0022759B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ECDF RID: 60639 RVA: 0x002293D0 File Offset: 0x002275D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ECE0 RID: 60640 RVA: 0x0022940E File Offset: 0x0022760E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorSliderResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ECE1 RID: 60641 RVA: 0x0022943F File Offset: 0x0022763F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECE2 RID: 60642 RVA: 0x00229448 File Offset: 0x00227648
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005FFC RID: 24572
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FFD RID: 24573
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005FFE RID: 24574
		private ErrorCode errorCode_;
	}
}
