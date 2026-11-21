using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001014 RID: 4116
	[NetMessage(EMessageId.RogueTowerTrialSelectBossResponse)]
	public sealed class RogueTowerTrialSelectBossResponse : IMessage<RogueTowerTrialSelectBossResponse>, IMessage, IEquatable<RogueTowerTrialSelectBossResponse>, IDeepCloneable<RogueTowerTrialSelectBossResponse>, IBufferMessage
	{
		// Token: 0x0601607F RID: 90239 RVA: 0x003343DD File Offset: 0x003325DD
		[NullableContext(1)]
		public static RogueTowerTrialSelectBossResponse Create()
		{
			return new RogueTowerTrialSelectBossResponse();
		}

		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x06016080 RID: 90240 RVA: 0x003343E4 File Offset: 0x003325E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x06016081 RID: 90241 RVA: 0x003343E7 File Offset: 0x003325E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialSelectBossResponse.Descriptor;
			}
		}

		// Token: 0x06016082 RID: 90242 RVA: 0x003343EE File Offset: 0x003325EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossResponse()
		{
		}

		// Token: 0x06016083 RID: 90243 RVA: 0x003343F6 File Offset: 0x003325F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossResponse(RogueTowerTrialSelectBossResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016084 RID: 90244 RVA: 0x0033441B File Offset: 0x0033261B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossResponse Clone()
		{
			return new RogueTowerTrialSelectBossResponse(this);
		}

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x06016085 RID: 90245 RVA: 0x00334423 File Offset: 0x00332623
		// (set) Token: 0x06016086 RID: 90246 RVA: 0x0033442B File Offset: 0x0033262B
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

		// Token: 0x06016087 RID: 90247 RVA: 0x00334434 File Offset: 0x00332634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialSelectBossResponse);
		}

		// Token: 0x06016088 RID: 90248 RVA: 0x00334442 File Offset: 0x00332642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialSelectBossResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016089 RID: 90249 RVA: 0x00334470 File Offset: 0x00332670
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

		// Token: 0x0601608A RID: 90250 RVA: 0x003344B5 File Offset: 0x003326B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601608B RID: 90251 RVA: 0x003344C2 File Offset: 0x003326C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601608C RID: 90252 RVA: 0x003344CB File Offset: 0x003326CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601608D RID: 90253 RVA: 0x00334500 File Offset: 0x00332700
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

		// Token: 0x0601608E RID: 90254 RVA: 0x0033453E File Offset: 0x0033273E
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

		// Token: 0x0601608F RID: 90255 RVA: 0x0033456F File Offset: 0x0033276F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016090 RID: 90256 RVA: 0x00334578 File Offset: 0x00332778
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008481 RID: 33921
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008482 RID: 33922
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008483 RID: 33923
		private ErrorCode errorCode_;
	}
}
