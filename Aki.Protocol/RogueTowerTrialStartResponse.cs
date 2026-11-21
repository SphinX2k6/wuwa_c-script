using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001016 RID: 4118
	[NetMessage(EMessageId.RogueTowerTrialStartResponse)]
	public sealed class RogueTowerTrialStartResponse : IMessage<RogueTowerTrialStartResponse>, IMessage, IEquatable<RogueTowerTrialStartResponse>, IDeepCloneable<RogueTowerTrialStartResponse>, IBufferMessage
	{
		// Token: 0x060160A5 RID: 90277 RVA: 0x00334858 File Offset: 0x00332A58
		[NullableContext(1)]
		public static RogueTowerTrialStartResponse Create()
		{
			return new RogueTowerTrialStartResponse();
		}

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x060160A6 RID: 90278 RVA: 0x0033485F File Offset: 0x00332A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x060160A7 RID: 90279 RVA: 0x00334862 File Offset: 0x00332A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialStartResponse.Descriptor;
			}
		}

		// Token: 0x060160A8 RID: 90280 RVA: 0x00334869 File Offset: 0x00332A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartResponse()
		{
		}

		// Token: 0x060160A9 RID: 90281 RVA: 0x00334871 File Offset: 0x00332A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartResponse(RogueTowerTrialStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160AA RID: 90282 RVA: 0x00334896 File Offset: 0x00332A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartResponse Clone()
		{
			return new RogueTowerTrialStartResponse(this);
		}

		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x060160AB RID: 90283 RVA: 0x0033489E File Offset: 0x00332A9E
		// (set) Token: 0x060160AC RID: 90284 RVA: 0x003348A6 File Offset: 0x00332AA6
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

		// Token: 0x060160AD RID: 90285 RVA: 0x003348AF File Offset: 0x00332AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialStartResponse);
		}

		// Token: 0x060160AE RID: 90286 RVA: 0x003348BD File Offset: 0x00332ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060160AF RID: 90287 RVA: 0x003348EC File Offset: 0x00332AEC
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

		// Token: 0x060160B0 RID: 90288 RVA: 0x00334931 File Offset: 0x00332B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160B1 RID: 90289 RVA: 0x0033493E File Offset: 0x00332B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160B2 RID: 90290 RVA: 0x00334947 File Offset: 0x00332B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060160B3 RID: 90291 RVA: 0x0033497C File Offset: 0x00332B7C
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

		// Token: 0x060160B4 RID: 90292 RVA: 0x003349BA File Offset: 0x00332BBA
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

		// Token: 0x060160B5 RID: 90293 RVA: 0x003349EB File Offset: 0x00332BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160B6 RID: 90294 RVA: 0x003349F4 File Offset: 0x00332BF4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008489 RID: 33929
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400848A RID: 33930
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400848B RID: 33931
		private ErrorCode errorCode_;
	}
}
