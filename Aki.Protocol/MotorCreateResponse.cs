using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A24 RID: 2596
	[NetMessage(EMessageId.MotorCreateResponse)]
	public sealed class MotorCreateResponse : IMessage<MotorCreateResponse>, IMessage, IEquatable<MotorCreateResponse>, IDeepCloneable<MotorCreateResponse>, IBufferMessage
	{
		// Token: 0x0600E2F6 RID: 58102 RVA: 0x00213B01 File Offset: 0x00211D01
		[NullableContext(1)]
		public static MotorCreateResponse Create()
		{
			return new MotorCreateResponse();
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x00213B08 File Offset: 0x00211D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0600E2F8 RID: 58104 RVA: 0x00213B0B File Offset: 0x00211D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorCreateResponse.Descriptor;
			}
		}

		// Token: 0x0600E2F9 RID: 58105 RVA: 0x00213B12 File Offset: 0x00211D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateResponse()
		{
		}

		// Token: 0x0600E2FA RID: 58106 RVA: 0x00213B1A File Offset: 0x00211D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateResponse(MotorCreateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2FB RID: 58107 RVA: 0x00213B3F File Offset: 0x00211D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateResponse Clone()
		{
			return new MotorCreateResponse(this);
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0600E2FC RID: 58108 RVA: 0x00213B47 File Offset: 0x00211D47
		// (set) Token: 0x0600E2FD RID: 58109 RVA: 0x00213B4F File Offset: 0x00211D4F
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

		// Token: 0x0600E2FE RID: 58110 RVA: 0x00213B58 File Offset: 0x00211D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorCreateResponse);
		}

		// Token: 0x0600E2FF RID: 58111 RVA: 0x00213B66 File Offset: 0x00211D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorCreateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E300 RID: 58112 RVA: 0x00213B94 File Offset: 0x00211D94
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

		// Token: 0x0600E301 RID: 58113 RVA: 0x00213BD9 File Offset: 0x00211DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E302 RID: 58114 RVA: 0x00213BE6 File Offset: 0x00211DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E303 RID: 58115 RVA: 0x00213BEF File Offset: 0x00211DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E304 RID: 58116 RVA: 0x00213C24 File Offset: 0x00211E24
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

		// Token: 0x0600E305 RID: 58117 RVA: 0x00213C62 File Offset: 0x00211E62
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

		// Token: 0x0600E306 RID: 58118 RVA: 0x00213C93 File Offset: 0x00211E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E307 RID: 58119 RVA: 0x00213C9C File Offset: 0x00211E9C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005D1C RID: 23836
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D1D RID: 23837
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005D1E RID: 23838
		private ErrorCode errorCode_;
	}
}
