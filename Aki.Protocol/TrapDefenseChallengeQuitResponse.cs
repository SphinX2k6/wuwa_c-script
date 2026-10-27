using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001419 RID: 5145
	[NetMessage(EMessageId.TrapDefenseChallengeQuitResponse)]
	public sealed class TrapDefenseChallengeQuitResponse : IMessage<TrapDefenseChallengeQuitResponse>, IMessage, IEquatable<TrapDefenseChallengeQuitResponse>, IDeepCloneable<TrapDefenseChallengeQuitResponse>, IBufferMessage
	{
		// Token: 0x0601B45E RID: 111710 RVA: 0x003F3B95 File Offset: 0x003F1D95
		[NullableContext(1)]
		public static TrapDefenseChallengeQuitResponse Create()
		{
			return new TrapDefenseChallengeQuitResponse();
		}

		// Token: 0x17005C01 RID: 23553
		// (get) Token: 0x0601B45F RID: 111711 RVA: 0x003F3B9C File Offset: 0x003F1D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C02 RID: 23554
		// (get) Token: 0x0601B460 RID: 111712 RVA: 0x003F3B9F File Offset: 0x003F1D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeQuitResponse.Descriptor;
			}
		}

		// Token: 0x0601B461 RID: 111713 RVA: 0x003F3BA6 File Offset: 0x003F1DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitResponse()
		{
		}

		// Token: 0x0601B462 RID: 111714 RVA: 0x003F3BAE File Offset: 0x003F1DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitResponse(TrapDefenseChallengeQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B463 RID: 111715 RVA: 0x003F3BD3 File Offset: 0x003F1DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitResponse Clone()
		{
			return new TrapDefenseChallengeQuitResponse(this);
		}

		// Token: 0x17005C03 RID: 23555
		// (get) Token: 0x0601B464 RID: 111716 RVA: 0x003F3BDB File Offset: 0x003F1DDB
		// (set) Token: 0x0601B465 RID: 111717 RVA: 0x003F3BE3 File Offset: 0x003F1DE3
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

		// Token: 0x0601B466 RID: 111718 RVA: 0x003F3BEC File Offset: 0x003F1DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeQuitResponse);
		}

		// Token: 0x0601B467 RID: 111719 RVA: 0x003F3BFA File Offset: 0x003F1DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B468 RID: 111720 RVA: 0x003F3C28 File Offset: 0x003F1E28
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

		// Token: 0x0601B469 RID: 111721 RVA: 0x003F3C6D File Offset: 0x003F1E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B46A RID: 111722 RVA: 0x003F3C7A File Offset: 0x003F1E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B46B RID: 111723 RVA: 0x003F3C83 File Offset: 0x003F1E83
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

		// Token: 0x0601B46C RID: 111724 RVA: 0x003F3CB8 File Offset: 0x003F1EB8
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

		// Token: 0x0601B46D RID: 111725 RVA: 0x003F3CF6 File Offset: 0x003F1EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseChallengeQuitResponse other)
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

		// Token: 0x0601B46E RID: 111726 RVA: 0x003F3D27 File Offset: 0x003F1F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B46F RID: 111727 RVA: 0x003F3D30 File Offset: 0x003F1F30
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

		// Token: 0x04009DB5 RID: 40373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DB6 RID: 40374
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009DB7 RID: 40375
		private ErrorCode errorCode_;
	}
}
