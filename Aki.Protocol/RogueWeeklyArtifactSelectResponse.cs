using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101D RID: 4125
	[NetMessage(EMessageId.RogueWeeklyArtifactSelectResponse)]
	public sealed class RogueWeeklyArtifactSelectResponse : IMessage<RogueWeeklyArtifactSelectResponse>, IMessage, IEquatable<RogueWeeklyArtifactSelectResponse>, IDeepCloneable<RogueWeeklyArtifactSelectResponse>, IBufferMessage
	{
		// Token: 0x0601612E RID: 90414 RVA: 0x0033597C File Offset: 0x00333B7C
		[NullableContext(1)]
		public static RogueWeeklyArtifactSelectResponse Create()
		{
			return new RogueWeeklyArtifactSelectResponse();
		}

		// Token: 0x170049CB RID: 18891
		// (get) Token: 0x0601612F RID: 90415 RVA: 0x00335983 File Offset: 0x00333B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049CC RID: 18892
		// (get) Token: 0x06016130 RID: 90416 RVA: 0x00335986 File Offset: 0x00333B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyArtifactSelectResponse.Descriptor;
			}
		}

		// Token: 0x06016131 RID: 90417 RVA: 0x0033598D File Offset: 0x00333B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectResponse()
		{
		}

		// Token: 0x06016132 RID: 90418 RVA: 0x00335995 File Offset: 0x00333B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectResponse(RogueWeeklyArtifactSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016133 RID: 90419 RVA: 0x003359BA File Offset: 0x00333BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectResponse Clone()
		{
			return new RogueWeeklyArtifactSelectResponse(this);
		}

		// Token: 0x170049CD RID: 18893
		// (get) Token: 0x06016134 RID: 90420 RVA: 0x003359C2 File Offset: 0x00333BC2
		// (set) Token: 0x06016135 RID: 90421 RVA: 0x003359CA File Offset: 0x00333BCA
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

		// Token: 0x06016136 RID: 90422 RVA: 0x003359D3 File Offset: 0x00333BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyArtifactSelectResponse);
		}

		// Token: 0x06016137 RID: 90423 RVA: 0x003359E1 File Offset: 0x00333BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyArtifactSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016138 RID: 90424 RVA: 0x00335A10 File Offset: 0x00333C10
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

		// Token: 0x06016139 RID: 90425 RVA: 0x00335A55 File Offset: 0x00333C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601613A RID: 90426 RVA: 0x00335A62 File Offset: 0x00333C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601613B RID: 90427 RVA: 0x00335A6B File Offset: 0x00333C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601613C RID: 90428 RVA: 0x00335AA0 File Offset: 0x00333CA0
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

		// Token: 0x0601613D RID: 90429 RVA: 0x00335ADE File Offset: 0x00333CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyArtifactSelectResponse other)
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

		// Token: 0x0601613E RID: 90430 RVA: 0x00335B0F File Offset: 0x00333D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601613F RID: 90431 RVA: 0x00335B18 File Offset: 0x00333D18
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040084A9 RID: 33961
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084AA RID: 33962
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040084AB RID: 33963
		private ErrorCode errorCode_;
	}
}
