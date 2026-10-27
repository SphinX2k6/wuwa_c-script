using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001136 RID: 4406
	[NetMessage(EMessageId.RTimeStopAnimResponse)]
	public sealed class RTimeStopAnimResponse : IMessage<RTimeStopAnimResponse>, IMessage, IEquatable<RTimeStopAnimResponse>, IDeepCloneable<RTimeStopAnimResponse>, IBufferMessage
	{
		// Token: 0x060177FE RID: 96254 RVA: 0x00369BFC File Offset: 0x00367DFC
		[NullableContext(1)]
		public static RTimeStopAnimResponse Create()
		{
			return new RTimeStopAnimResponse();
		}

		// Token: 0x17004EE0 RID: 20192
		// (get) Token: 0x060177FF RID: 96255 RVA: 0x00369C03 File Offset: 0x00367E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EE1 RID: 20193
		// (get) Token: 0x06017800 RID: 96256 RVA: 0x00369C06 File Offset: 0x00367E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopAnimResponse.Descriptor;
			}
		}

		// Token: 0x06017801 RID: 96257 RVA: 0x00369C0D File Offset: 0x00367E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimResponse()
		{
		}

		// Token: 0x06017802 RID: 96258 RVA: 0x00369C15 File Offset: 0x00367E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimResponse(RTimeStopAnimResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017803 RID: 96259 RVA: 0x00369C3A File Offset: 0x00367E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimResponse Clone()
		{
			return new RTimeStopAnimResponse(this);
		}

		// Token: 0x17004EE2 RID: 20194
		// (get) Token: 0x06017804 RID: 96260 RVA: 0x00369C42 File Offset: 0x00367E42
		// (set) Token: 0x06017805 RID: 96261 RVA: 0x00369C4A File Offset: 0x00367E4A
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

		// Token: 0x06017806 RID: 96262 RVA: 0x00369C53 File Offset: 0x00367E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopAnimResponse);
		}

		// Token: 0x06017807 RID: 96263 RVA: 0x00369C61 File Offset: 0x00367E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopAnimResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017808 RID: 96264 RVA: 0x00369C90 File Offset: 0x00367E90
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

		// Token: 0x06017809 RID: 96265 RVA: 0x00369CD5 File Offset: 0x00367ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601780A RID: 96266 RVA: 0x00369CE2 File Offset: 0x00367EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601780B RID: 96267 RVA: 0x00369CEB File Offset: 0x00367EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0601780C RID: 96268 RVA: 0x00369D20 File Offset: 0x00367F20
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

		// Token: 0x0601780D RID: 96269 RVA: 0x00369D5E File Offset: 0x00367F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopAnimResponse other)
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

		// Token: 0x0601780E RID: 96270 RVA: 0x00369D8F File Offset: 0x00367F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601780F RID: 96271 RVA: 0x00369D98 File Offset: 0x00367F98
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008BAE RID: 35758
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BAF RID: 35759
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008BB0 RID: 35760
		private ErrorCode errorCode_;
	}
}
