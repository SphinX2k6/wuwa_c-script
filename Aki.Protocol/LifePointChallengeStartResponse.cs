using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000907 RID: 2311
	[NetMessage(EMessageId.LifePointChallengeStartResponse)]
	public sealed class LifePointChallengeStartResponse : IMessage<LifePointChallengeStartResponse>, IMessage, IEquatable<LifePointChallengeStartResponse>, IDeepCloneable<LifePointChallengeStartResponse>, IBufferMessage
	{
		// Token: 0x0600CC58 RID: 52312 RVA: 0x001E2315 File Offset: 0x001E0515
		[NullableContext(1)]
		public static LifePointChallengeStartResponse Create()
		{
			return new LifePointChallengeStartResponse();
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x0600CC59 RID: 52313 RVA: 0x001E231C File Offset: 0x001E051C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x0600CC5A RID: 52314 RVA: 0x001E231F File Offset: 0x001E051F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeStartResponse.Descriptor;
			}
		}

		// Token: 0x0600CC5B RID: 52315 RVA: 0x001E2326 File Offset: 0x001E0526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartResponse()
		{
		}

		// Token: 0x0600CC5C RID: 52316 RVA: 0x001E232E File Offset: 0x001E052E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartResponse(LifePointChallengeStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC5D RID: 52317 RVA: 0x001E2353 File Offset: 0x001E0553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartResponse Clone()
		{
			return new LifePointChallengeStartResponse(this);
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x0600CC5E RID: 52318 RVA: 0x001E235B File Offset: 0x001E055B
		// (set) Token: 0x0600CC5F RID: 52319 RVA: 0x001E2363 File Offset: 0x001E0563
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

		// Token: 0x0600CC60 RID: 52320 RVA: 0x001E236C File Offset: 0x001E056C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeStartResponse);
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x001E237A File Offset: 0x001E057A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC62 RID: 52322 RVA: 0x001E23A8 File Offset: 0x001E05A8
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

		// Token: 0x0600CC63 RID: 52323 RVA: 0x001E23ED File Offset: 0x001E05ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC64 RID: 52324 RVA: 0x001E23FA File Offset: 0x001E05FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC65 RID: 52325 RVA: 0x001E2403 File Offset: 0x001E0603
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

		// Token: 0x0600CC66 RID: 52326 RVA: 0x001E2438 File Offset: 0x001E0638
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

		// Token: 0x0600CC67 RID: 52327 RVA: 0x001E2476 File Offset: 0x001E0676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifePointChallengeStartResponse other)
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

		// Token: 0x0600CC68 RID: 52328 RVA: 0x001E24A7 File Offset: 0x001E06A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC69 RID: 52329 RVA: 0x001E24B0 File Offset: 0x001E06B0
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

		// Token: 0x040056FF RID: 22271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005700 RID: 22272
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005701 RID: 22273
		private ErrorCode errorCode_;
	}
}
