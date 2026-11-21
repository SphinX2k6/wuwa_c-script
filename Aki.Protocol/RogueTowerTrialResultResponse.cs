using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001011 RID: 4113
	[NetMessage(EMessageId.RogueTowerTrialResultResponse)]
	public sealed class RogueTowerTrialResultResponse : IMessage<RogueTowerTrialResultResponse>, IMessage, IEquatable<RogueTowerTrialResultResponse>, IDeepCloneable<RogueTowerTrialResultResponse>, IBufferMessage
	{
		// Token: 0x06016047 RID: 90183 RVA: 0x00333D31 File Offset: 0x00331F31
		[NullableContext(1)]
		public static RogueTowerTrialResultResponse Create()
		{
			return new RogueTowerTrialResultResponse();
		}

		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x06016048 RID: 90184 RVA: 0x00333D38 File Offset: 0x00331F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x06016049 RID: 90185 RVA: 0x00333D3B File Offset: 0x00331F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialResultResponse.Descriptor;
			}
		}

		// Token: 0x0601604A RID: 90186 RVA: 0x00333D42 File Offset: 0x00331F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultResponse()
		{
		}

		// Token: 0x0601604B RID: 90187 RVA: 0x00333D4C File Offset: 0x00331F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultResponse(RogueTowerTrialResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueTowerTrialResultInfo_ = ((other.rogueTowerTrialResultInfo_ != null) ? other.rogueTowerTrialResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601604C RID: 90188 RVA: 0x00333D98 File Offset: 0x00331F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultResponse Clone()
		{
			return new RogueTowerTrialResultResponse(this);
		}

		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x0601604D RID: 90189 RVA: 0x00333DA0 File Offset: 0x00331FA0
		// (set) Token: 0x0601604E RID: 90190 RVA: 0x00333DA8 File Offset: 0x00331FA8
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

		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x0601604F RID: 90191 RVA: 0x00333DB1 File Offset: 0x00331FB1
		// (set) Token: 0x06016050 RID: 90192 RVA: 0x00333DB9 File Offset: 0x00331FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultInfo RogueTowerTrialResultInfo
		{
			get
			{
				return this.rogueTowerTrialResultInfo_;
			}
			set
			{
				this.rogueTowerTrialResultInfo_ = value;
			}
		}

		// Token: 0x06016051 RID: 90193 RVA: 0x00333DC2 File Offset: 0x00331FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialResultResponse);
		}

		// Token: 0x06016052 RID: 90194 RVA: 0x00333DD0 File Offset: 0x00331FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueTowerTrialResultInfo, other.RogueTowerTrialResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016053 RID: 90195 RVA: 0x00333E20 File Offset: 0x00332020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.rogueTowerTrialResultInfo_ != null)
			{
				num ^= this.RogueTowerTrialResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016054 RID: 90196 RVA: 0x00333E7B File Offset: 0x0033207B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016055 RID: 90197 RVA: 0x00333E88 File Offset: 0x00332088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016056 RID: 90198 RVA: 0x00333E94 File Offset: 0x00332094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rogueTowerTrialResultInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueTowerTrialResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016057 RID: 90199 RVA: 0x00333EEC File Offset: 0x003320EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.rogueTowerTrialResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTowerTrialResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016058 RID: 90200 RVA: 0x00333F44 File Offset: 0x00332144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.rogueTowerTrialResultInfo_ != null)
			{
				if (this.rogueTowerTrialResultInfo_ == null)
				{
					this.RogueTowerTrialResultInfo = new RogueTowerTrialResultInfo();
				}
				this.RogueTowerTrialResultInfo.MergeFrom(other.RogueTowerTrialResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016059 RID: 90201 RVA: 0x00333FAC File Offset: 0x003321AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601605A RID: 90202 RVA: 0x00333FB8 File Offset: 0x003321B8
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
				if (num != 8U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueTowerTrialResultInfo_ == null)
						{
							this.RogueTowerTrialResultInfo = new RogueTowerTrialResultInfo();
						}
						input.ReadMessage(this.RogueTowerTrialResultInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008475 RID: 33909
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008476 RID: 33910
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008477 RID: 33911
		private ErrorCode errorCode_;

		// Token: 0x04008478 RID: 33912
		public const int RogueTowerTrialResultInfoFieldNumber = 5;

		// Token: 0x04008479 RID: 33913
		private RogueTowerTrialResultInfo rogueTowerTrialResultInfo_;
	}
}
