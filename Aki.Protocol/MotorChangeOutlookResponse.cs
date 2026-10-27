using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A22 RID: 2594
	[NetMessage(EMessageId.MotorChangeOutlookResponse)]
	public sealed class MotorChangeOutlookResponse : IMessage<MotorChangeOutlookResponse>, IMessage, IEquatable<MotorChangeOutlookResponse>, IDeepCloneable<MotorChangeOutlookResponse>, IBufferMessage
	{
		// Token: 0x0600E2D2 RID: 58066 RVA: 0x00213754 File Offset: 0x00211954
		[NullableContext(1)]
		public static MotorChangeOutlookResponse Create()
		{
			return new MotorChangeOutlookResponse();
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0600E2D3 RID: 58067 RVA: 0x0021375B File Offset: 0x0021195B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0600E2D4 RID: 58068 RVA: 0x0021375E File Offset: 0x0021195E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorChangeOutlookResponse.Descriptor;
			}
		}

		// Token: 0x0600E2D5 RID: 58069 RVA: 0x00213765 File Offset: 0x00211965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookResponse()
		{
		}

		// Token: 0x0600E2D6 RID: 58070 RVA: 0x0021376D File Offset: 0x0021196D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookResponse(MotorChangeOutlookResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2D7 RID: 58071 RVA: 0x00213792 File Offset: 0x00211992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookResponse Clone()
		{
			return new MotorChangeOutlookResponse(this);
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x0600E2D8 RID: 58072 RVA: 0x0021379A File Offset: 0x0021199A
		// (set) Token: 0x0600E2D9 RID: 58073 RVA: 0x002137A2 File Offset: 0x002119A2
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

		// Token: 0x0600E2DA RID: 58074 RVA: 0x002137AB File Offset: 0x002119AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorChangeOutlookResponse);
		}

		// Token: 0x0600E2DB RID: 58075 RVA: 0x002137B9 File Offset: 0x002119B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorChangeOutlookResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2DC RID: 58076 RVA: 0x002137E8 File Offset: 0x002119E8
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

		// Token: 0x0600E2DD RID: 58077 RVA: 0x0021382D File Offset: 0x00211A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2DE RID: 58078 RVA: 0x0021383A File Offset: 0x00211A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2DF RID: 58079 RVA: 0x00213843 File Offset: 0x00211A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2E0 RID: 58080 RVA: 0x00213878 File Offset: 0x00211A78
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

		// Token: 0x0600E2E1 RID: 58081 RVA: 0x002138B6 File Offset: 0x00211AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorChangeOutlookResponse other)
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

		// Token: 0x0600E2E2 RID: 58082 RVA: 0x002138E7 File Offset: 0x00211AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2E3 RID: 58083 RVA: 0x002138F0 File Offset: 0x00211AF0
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005D16 RID: 23830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D17 RID: 23831
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005D18 RID: 23832
		private ErrorCode errorCode_;
	}
}
