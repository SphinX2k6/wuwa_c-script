using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001026 RID: 4134
	[NetMessage(EMessageId.RogueTowerTrialStartResponse)]
	public sealed class RogueTowerTrialStartResponse : IMessage<RogueTowerTrialStartResponse>, IMessage, IEquatable<RogueTowerTrialStartResponse>, IDeepCloneable<RogueTowerTrialStartResponse>, IBufferMessage
	{
		// Token: 0x0601618A RID: 90506 RVA: 0x00335F18 File Offset: 0x00334118
		[NullableContext(1)]
		public static RogueTowerTrialStartResponse Create()
		{
			return new RogueTowerTrialStartResponse();
		}

		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x0601618B RID: 90507 RVA: 0x00335F1F File Offset: 0x0033411F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049DB RID: 18907
		// (get) Token: 0x0601618C RID: 90508 RVA: 0x00335F22 File Offset: 0x00334122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialStartResponse.Descriptor;
			}
		}

		// Token: 0x0601618D RID: 90509 RVA: 0x00335F29 File Offset: 0x00334129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartResponse()
		{
		}

		// Token: 0x0601618E RID: 90510 RVA: 0x00335F31 File Offset: 0x00334131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartResponse(RogueTowerTrialStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601618F RID: 90511 RVA: 0x00335F56 File Offset: 0x00334156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartResponse Clone()
		{
			return new RogueTowerTrialStartResponse(this);
		}

		// Token: 0x170049DC RID: 18908
		// (get) Token: 0x06016190 RID: 90512 RVA: 0x00335F5E File Offset: 0x0033415E
		// (set) Token: 0x06016191 RID: 90513 RVA: 0x00335F66 File Offset: 0x00334166
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

		// Token: 0x06016192 RID: 90514 RVA: 0x00335F6F File Offset: 0x0033416F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialStartResponse);
		}

		// Token: 0x06016193 RID: 90515 RVA: 0x00335F7D File Offset: 0x0033417D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016194 RID: 90516 RVA: 0x00335FAC File Offset: 0x003341AC
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

		// Token: 0x06016195 RID: 90517 RVA: 0x00335FF1 File Offset: 0x003341F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016196 RID: 90518 RVA: 0x00335FFE File Offset: 0x003341FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016197 RID: 90519 RVA: 0x00336007 File Offset: 0x00334207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016198 RID: 90520 RVA: 0x0033603C File Offset: 0x0033423C
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

		// Token: 0x06016199 RID: 90521 RVA: 0x0033607A File Offset: 0x0033427A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialStartResponse other)
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

		// Token: 0x0601619A RID: 90522 RVA: 0x003360AB File Offset: 0x003342AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601619B RID: 90523 RVA: 0x003360B4 File Offset: 0x003342B4
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400845F RID: 33887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008460 RID: 33888
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04008461 RID: 33889
		private ErrorCode errorCode_;
	}
}
