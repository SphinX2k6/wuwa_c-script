using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016AD RID: 5805
	[NetMessage(EMessageId.AiControlSwitchResponse)]
	public sealed class AiControlSwitchResponse : IMessage<AiControlSwitchResponse>, IMessage, IEquatable<AiControlSwitchResponse>, IDeepCloneable<AiControlSwitchResponse>, IBufferMessage
	{
		// Token: 0x0601D161 RID: 119137 RVA: 0x004419E1 File Offset: 0x0043FBE1
		[NullableContext(1)]
		public static AiControlSwitchResponse Create()
		{
			return new AiControlSwitchResponse();
		}

		// Token: 0x170062AF RID: 25263
		// (get) Token: 0x0601D162 RID: 119138 RVA: 0x004419E8 File Offset: 0x0043FBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062B0 RID: 25264
		// (get) Token: 0x0601D163 RID: 119139 RVA: 0x004419EB File Offset: 0x0043FBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiControlSwitchResponse.Descriptor;
			}
		}

		// Token: 0x0601D164 RID: 119140 RVA: 0x004419F2 File Offset: 0x0043FBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchResponse()
		{
		}

		// Token: 0x0601D165 RID: 119141 RVA: 0x004419FA File Offset: 0x0043FBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchResponse(AiControlSwitchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D166 RID: 119142 RVA: 0x00441A1F File Offset: 0x0043FC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchResponse Clone()
		{
			return new AiControlSwitchResponse(this);
		}

		// Token: 0x170062B1 RID: 25265
		// (get) Token: 0x0601D167 RID: 119143 RVA: 0x00441A27 File Offset: 0x0043FC27
		// (set) Token: 0x0601D168 RID: 119144 RVA: 0x00441A2F File Offset: 0x0043FC2F
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

		// Token: 0x0601D169 RID: 119145 RVA: 0x00441A38 File Offset: 0x0043FC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiControlSwitchResponse);
		}

		// Token: 0x0601D16A RID: 119146 RVA: 0x00441A46 File Offset: 0x0043FC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiControlSwitchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D16B RID: 119147 RVA: 0x00441A74 File Offset: 0x0043FC74
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

		// Token: 0x0601D16C RID: 119148 RVA: 0x00441AB9 File Offset: 0x0043FCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D16D RID: 119149 RVA: 0x00441AC6 File Offset: 0x0043FCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D16E RID: 119150 RVA: 0x00441ACF File Offset: 0x0043FCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D16F RID: 119151 RVA: 0x00441B04 File Offset: 0x0043FD04
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

		// Token: 0x0601D170 RID: 119152 RVA: 0x00441B42 File Offset: 0x0043FD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiControlSwitchResponse other)
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

		// Token: 0x0601D171 RID: 119153 RVA: 0x00441B73 File Offset: 0x0043FD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D172 RID: 119154 RVA: 0x00441B7C File Offset: 0x0043FD7C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C437 RID: 50231
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C438 RID: 50232
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400C439 RID: 50233
		private ErrorCode errorCode_;
	}
}
