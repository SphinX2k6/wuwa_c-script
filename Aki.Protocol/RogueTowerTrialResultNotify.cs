using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101F RID: 4127
	[NetMessage(EMessageId.RogueTowerTrialResultNotify)]
	public sealed class RogueTowerTrialResultNotify : IMessage<RogueTowerTrialResultNotify>, IMessage, IEquatable<RogueTowerTrialResultNotify>, IDeepCloneable<RogueTowerTrialResultNotify>, IBufferMessage
	{
		// Token: 0x06016106 RID: 90374 RVA: 0x00334F21 File Offset: 0x00333121
		[NullableContext(1)]
		public static RogueTowerTrialResultNotify Create()
		{
			return new RogueTowerTrialResultNotify();
		}

		// Token: 0x170049C2 RID: 18882
		// (get) Token: 0x06016107 RID: 90375 RVA: 0x00334F28 File Offset: 0x00333128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049C3 RID: 18883
		// (get) Token: 0x06016108 RID: 90376 RVA: 0x00334F2B File Offset: 0x0033312B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialResultNotify.Descriptor;
			}
		}

		// Token: 0x06016109 RID: 90377 RVA: 0x00334F32 File Offset: 0x00333132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultNotify()
		{
		}

		// Token: 0x0601610A RID: 90378 RVA: 0x00334F3C File Offset: 0x0033313C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultNotify(RogueTowerTrialResultNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueTowerTrialResultInfo_ = ((other.rogueTowerTrialResultInfo_ != null) ? other.rogueTowerTrialResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601610B RID: 90379 RVA: 0x00334F88 File Offset: 0x00333188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultNotify Clone()
		{
			return new RogueTowerTrialResultNotify(this);
		}

		// Token: 0x170049C4 RID: 18884
		// (get) Token: 0x0601610C RID: 90380 RVA: 0x00334F90 File Offset: 0x00333190
		// (set) Token: 0x0601610D RID: 90381 RVA: 0x00334F98 File Offset: 0x00333198
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

		// Token: 0x170049C5 RID: 18885
		// (get) Token: 0x0601610E RID: 90382 RVA: 0x00334FA1 File Offset: 0x003331A1
		// (set) Token: 0x0601610F RID: 90383 RVA: 0x00334FA9 File Offset: 0x003331A9
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

		// Token: 0x06016110 RID: 90384 RVA: 0x00334FB2 File Offset: 0x003331B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialResultNotify);
		}

		// Token: 0x06016111 RID: 90385 RVA: 0x00334FC0 File Offset: 0x003331C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialResultNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueTowerTrialResultInfo, other.RogueTowerTrialResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016112 RID: 90386 RVA: 0x00335010 File Offset: 0x00333210
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

		// Token: 0x06016113 RID: 90387 RVA: 0x0033506B File Offset: 0x0033326B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016114 RID: 90388 RVA: 0x00335078 File Offset: 0x00333278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016115 RID: 90389 RVA: 0x00335084 File Offset: 0x00333284
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
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueTowerTrialResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016116 RID: 90390 RVA: 0x003350DC File Offset: 0x003332DC
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

		// Token: 0x06016117 RID: 90391 RVA: 0x00335134 File Offset: 0x00333334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialResultNotify other)
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

		// Token: 0x06016118 RID: 90392 RVA: 0x0033519C File Offset: 0x0033339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016119 RID: 90393 RVA: 0x003351A8 File Offset: 0x003333A8
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
					if (num != 58U)
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

		// Token: 0x04008443 RID: 33859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008444 RID: 33860
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008445 RID: 33861
		private ErrorCode errorCode_;

		// Token: 0x04008446 RID: 33862
		public const int RogueTowerTrialResultInfoFieldNumber = 7;

		// Token: 0x04008447 RID: 33863
		private RogueTowerTrialResultInfo rogueTowerTrialResultInfo_;
	}
}
