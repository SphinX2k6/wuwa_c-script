using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001021 RID: 4129
	[NetMessage(EMessageId.RogueTowerTrialResultResponse)]
	public sealed class RogueTowerTrialResultResponse : IMessage<RogueTowerTrialResultResponse>, IMessage, IEquatable<RogueTowerTrialResultResponse>, IDeepCloneable<RogueTowerTrialResultResponse>, IBufferMessage
	{
		// Token: 0x0601612C RID: 90412 RVA: 0x003353ED File Offset: 0x003335ED
		[NullableContext(1)]
		public static RogueTowerTrialResultResponse Create()
		{
			return new RogueTowerTrialResultResponse();
		}

		// Token: 0x170049C9 RID: 18889
		// (get) Token: 0x0601612D RID: 90413 RVA: 0x003353F4 File Offset: 0x003335F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049CA RID: 18890
		// (get) Token: 0x0601612E RID: 90414 RVA: 0x003353F7 File Offset: 0x003335F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialResultResponse.Descriptor;
			}
		}

		// Token: 0x0601612F RID: 90415 RVA: 0x003353FE File Offset: 0x003335FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultResponse()
		{
		}

		// Token: 0x06016130 RID: 90416 RVA: 0x00335408 File Offset: 0x00333608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultResponse(RogueTowerTrialResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueTowerTrialResultInfo_ = ((other.rogueTowerTrialResultInfo_ != null) ? other.rogueTowerTrialResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016131 RID: 90417 RVA: 0x00335454 File Offset: 0x00333654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultResponse Clone()
		{
			return new RogueTowerTrialResultResponse(this);
		}

		// Token: 0x170049CB RID: 18891
		// (get) Token: 0x06016132 RID: 90418 RVA: 0x0033545C File Offset: 0x0033365C
		// (set) Token: 0x06016133 RID: 90419 RVA: 0x00335464 File Offset: 0x00333664
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

		// Token: 0x170049CC RID: 18892
		// (get) Token: 0x06016134 RID: 90420 RVA: 0x0033546D File Offset: 0x0033366D
		// (set) Token: 0x06016135 RID: 90421 RVA: 0x00335475 File Offset: 0x00333675
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

		// Token: 0x06016136 RID: 90422 RVA: 0x0033547E File Offset: 0x0033367E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialResultResponse);
		}

		// Token: 0x06016137 RID: 90423 RVA: 0x0033548C File Offset: 0x0033368C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueTowerTrialResultInfo, other.RogueTowerTrialResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016138 RID: 90424 RVA: 0x003354DC File Offset: 0x003336DC
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

		// Token: 0x06016139 RID: 90425 RVA: 0x00335537 File Offset: 0x00333737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601613A RID: 90426 RVA: 0x00335544 File Offset: 0x00333744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601613B RID: 90427 RVA: 0x00335550 File Offset: 0x00333750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTowerTrialResultInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueTowerTrialResultInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601613C RID: 90428 RVA: 0x003355AC File Offset: 0x003337AC
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

		// Token: 0x0601613D RID: 90429 RVA: 0x00335604 File Offset: 0x00333804
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

		// Token: 0x0601613E RID: 90430 RVA: 0x0033566C File Offset: 0x0033386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601613F RID: 90431 RVA: 0x00335678 File Offset: 0x00333878
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
				if (num != 34U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x0400844B RID: 33867
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400844C RID: 33868
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400844D RID: 33869
		private ErrorCode errorCode_;

		// Token: 0x0400844E RID: 33870
		public const int RogueTowerTrialResultInfoFieldNumber = 4;

		// Token: 0x0400844F RID: 33871
		private RogueTowerTrialResultInfo rogueTowerTrialResultInfo_;
	}
}
