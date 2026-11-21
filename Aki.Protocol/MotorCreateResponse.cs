using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A13 RID: 2579
	[NetMessage(EMessageId.MotorCreateResponse)]
	public sealed class MotorCreateResponse : IMessage<MotorCreateResponse>, IMessage, IEquatable<MotorCreateResponse>, IDeepCloneable<MotorCreateResponse>, IBufferMessage
	{
		// Token: 0x0600E1DC RID: 57820 RVA: 0x0021190D File Offset: 0x0020FB0D
		[NullableContext(1)]
		public static MotorCreateResponse Create()
		{
			return new MotorCreateResponse();
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0600E1DD RID: 57821 RVA: 0x00211914 File Offset: 0x0020FB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0600E1DE RID: 57822 RVA: 0x00211917 File Offset: 0x0020FB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorCreateResponse.Descriptor;
			}
		}

		// Token: 0x0600E1DF RID: 57823 RVA: 0x0021191E File Offset: 0x0020FB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateResponse()
		{
		}

		// Token: 0x0600E1E0 RID: 57824 RVA: 0x00211926 File Offset: 0x0020FB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateResponse(MotorCreateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1E1 RID: 57825 RVA: 0x0021194B File Offset: 0x0020FB4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateResponse Clone()
		{
			return new MotorCreateResponse(this);
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0600E1E2 RID: 57826 RVA: 0x00211953 File Offset: 0x0020FB53
		// (set) Token: 0x0600E1E3 RID: 57827 RVA: 0x0021195B File Offset: 0x0020FB5B
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

		// Token: 0x0600E1E4 RID: 57828 RVA: 0x00211964 File Offset: 0x0020FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorCreateResponse);
		}

		// Token: 0x0600E1E5 RID: 57829 RVA: 0x00211972 File Offset: 0x0020FB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorCreateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1E6 RID: 57830 RVA: 0x002119A0 File Offset: 0x0020FBA0
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

		// Token: 0x0600E1E7 RID: 57831 RVA: 0x002119E5 File Offset: 0x0020FBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E1E8 RID: 57832 RVA: 0x002119F2 File Offset: 0x0020FBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1E9 RID: 57833 RVA: 0x002119FB File Offset: 0x0020FBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600E1EA RID: 57834 RVA: 0x00211A30 File Offset: 0x0020FC30
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

		// Token: 0x0600E1EB RID: 57835 RVA: 0x00211A6E File Offset: 0x0020FC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorCreateResponse other)
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

		// Token: 0x0600E1EC RID: 57836 RVA: 0x00211A9F File Offset: 0x0020FC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1ED RID: 57837 RVA: 0x00211AA8 File Offset: 0x0020FCA8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005D25 RID: 23845
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D26 RID: 23846
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005D27 RID: 23847
		private ErrorCode errorCode_;
	}
}
