using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001024 RID: 4132
	[NetMessage(EMessageId.RogueTowerTrialSelectBossResponse)]
	public sealed class RogueTowerTrialSelectBossResponse : IMessage<RogueTowerTrialSelectBossResponse>, IMessage, IEquatable<RogueTowerTrialSelectBossResponse>, IDeepCloneable<RogueTowerTrialSelectBossResponse>, IBufferMessage
	{
		// Token: 0x06016164 RID: 90468 RVA: 0x00335A9D File Offset: 0x00333C9D
		[NullableContext(1)]
		public static RogueTowerTrialSelectBossResponse Create()
		{
			return new RogueTowerTrialSelectBossResponse();
		}

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x06016165 RID: 90469 RVA: 0x00335AA4 File Offset: 0x00333CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x06016166 RID: 90470 RVA: 0x00335AA7 File Offset: 0x00333CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialSelectBossResponse.Descriptor;
			}
		}

		// Token: 0x06016167 RID: 90471 RVA: 0x00335AAE File Offset: 0x00333CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossResponse()
		{
		}

		// Token: 0x06016168 RID: 90472 RVA: 0x00335AB6 File Offset: 0x00333CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossResponse(RogueTowerTrialSelectBossResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016169 RID: 90473 RVA: 0x00335ADB File Offset: 0x00333CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossResponse Clone()
		{
			return new RogueTowerTrialSelectBossResponse(this);
		}

		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x0601616A RID: 90474 RVA: 0x00335AE3 File Offset: 0x00333CE3
		// (set) Token: 0x0601616B RID: 90475 RVA: 0x00335AEB File Offset: 0x00333CEB
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

		// Token: 0x0601616C RID: 90476 RVA: 0x00335AF4 File Offset: 0x00333CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialSelectBossResponse);
		}

		// Token: 0x0601616D RID: 90477 RVA: 0x00335B02 File Offset: 0x00333D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialSelectBossResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601616E RID: 90478 RVA: 0x00335B30 File Offset: 0x00333D30
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

		// Token: 0x0601616F RID: 90479 RVA: 0x00335B75 File Offset: 0x00333D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016170 RID: 90480 RVA: 0x00335B82 File Offset: 0x00333D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016171 RID: 90481 RVA: 0x00335B8B File Offset: 0x00333D8B
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

		// Token: 0x06016172 RID: 90482 RVA: 0x00335BC0 File Offset: 0x00333DC0
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

		// Token: 0x06016173 RID: 90483 RVA: 0x00335BFE File Offset: 0x00333DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialSelectBossResponse other)
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

		// Token: 0x06016174 RID: 90484 RVA: 0x00335C2F File Offset: 0x00333E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016175 RID: 90485 RVA: 0x00335C38 File Offset: 0x00333E38
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

		// Token: 0x04008457 RID: 33879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008458 RID: 33880
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008459 RID: 33881
		private ErrorCode errorCode_;
	}
}
