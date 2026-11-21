using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100D RID: 4109
	[NetMessage(EMessageId.RogueTowerTrialReChallengeResponse)]
	public sealed class RogueTowerTrialReChallengeResponse : IMessage<RogueTowerTrialReChallengeResponse>, IMessage, IEquatable<RogueTowerTrialReChallengeResponse>, IDeepCloneable<RogueTowerTrialReChallengeResponse>, IBufferMessage
	{
		// Token: 0x06015FF1 RID: 90097 RVA: 0x00333095 File Offset: 0x00331295
		[NullableContext(1)]
		public static RogueTowerTrialReChallengeResponse Create()
		{
			return new RogueTowerTrialReChallengeResponse();
		}

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x06015FF2 RID: 90098 RVA: 0x0033309C File Offset: 0x0033129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x06015FF3 RID: 90099 RVA: 0x0033309F File Offset: 0x0033129F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialReChallengeResponse.Descriptor;
			}
		}

		// Token: 0x06015FF4 RID: 90100 RVA: 0x003330A6 File Offset: 0x003312A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeResponse()
		{
		}

		// Token: 0x06015FF5 RID: 90101 RVA: 0x003330AE File Offset: 0x003312AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeResponse(RogueTowerTrialReChallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FF6 RID: 90102 RVA: 0x003330D3 File Offset: 0x003312D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeResponse Clone()
		{
			return new RogueTowerTrialReChallengeResponse(this);
		}

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x06015FF7 RID: 90103 RVA: 0x003330DB File Offset: 0x003312DB
		// (set) Token: 0x06015FF8 RID: 90104 RVA: 0x003330E3 File Offset: 0x003312E3
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

		// Token: 0x06015FF9 RID: 90105 RVA: 0x003330EC File Offset: 0x003312EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialReChallengeResponse);
		}

		// Token: 0x06015FFA RID: 90106 RVA: 0x003330FA File Offset: 0x003312FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialReChallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FFB RID: 90107 RVA: 0x00333128 File Offset: 0x00331328
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

		// Token: 0x06015FFC RID: 90108 RVA: 0x0033316D File Offset: 0x0033136D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FFD RID: 90109 RVA: 0x0033317A File Offset: 0x0033137A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FFE RID: 90110 RVA: 0x00333183 File Offset: 0x00331383
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

		// Token: 0x06015FFF RID: 90111 RVA: 0x003331B8 File Offset: 0x003313B8
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

		// Token: 0x06016000 RID: 90112 RVA: 0x003331F6 File Offset: 0x003313F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialReChallengeResponse other)
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

		// Token: 0x06016001 RID: 90113 RVA: 0x00333227 File Offset: 0x00331427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016002 RID: 90114 RVA: 0x00333230 File Offset: 0x00331430
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

		// Token: 0x0400845A RID: 33882
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400845B RID: 33883
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400845C RID: 33884
		private ErrorCode errorCode_;
	}
}
