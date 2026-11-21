using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACC RID: 2764
	[NetMessage(EMessageId.MulFishingIllustratedRewardResponse)]
	public sealed class MulFishingIllustratedRewardResponse : IMessage<MulFishingIllustratedRewardResponse>, IMessage, IEquatable<MulFishingIllustratedRewardResponse>, IDeepCloneable<MulFishingIllustratedRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F0DD RID: 61661 RVA: 0x002333D9 File Offset: 0x002315D9
		[NullableContext(1)]
		public static MulFishingIllustratedRewardResponse Create()
		{
			return new MulFishingIllustratedRewardResponse();
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x0600F0DE RID: 61662 RVA: 0x002333E0 File Offset: 0x002315E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x0600F0DF RID: 61663 RVA: 0x002333E3 File Offset: 0x002315E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulFishingIllustratedRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F0E0 RID: 61664 RVA: 0x002333EA File Offset: 0x002315EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardResponse()
		{
		}

		// Token: 0x0600F0E1 RID: 61665 RVA: 0x002333FD File Offset: 0x002315FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardResponse(MulFishingIllustratedRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardId_ = other.rewardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0E2 RID: 61666 RVA: 0x00233433 File Offset: 0x00231633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardResponse Clone()
		{
			return new MulFishingIllustratedRewardResponse(this);
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x0600F0E3 RID: 61667 RVA: 0x0023343B File Offset: 0x0023163B
		// (set) Token: 0x0600F0E4 RID: 61668 RVA: 0x00233443 File Offset: 0x00231643
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

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x0600F0E5 RID: 61669 RVA: 0x0023344C File Offset: 0x0023164C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardId
		{
			get
			{
				return this.rewardId_;
			}
		}

		// Token: 0x0600F0E6 RID: 61670 RVA: 0x00233454 File Offset: 0x00231654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulFishingIllustratedRewardResponse);
		}

		// Token: 0x0600F0E7 RID: 61671 RVA: 0x00233464 File Offset: 0x00231664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulFishingIllustratedRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rewardId_.Equals(other.rewardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0E8 RID: 61672 RVA: 0x002334B4 File Offset: 0x002316B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.rewardId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F0E9 RID: 61673 RVA: 0x00233507 File Offset: 0x00231707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0EA RID: 61674 RVA: 0x00233514 File Offset: 0x00231714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0EB RID: 61675 RVA: 0x00233520 File Offset: 0x00231720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardId_.WriteTo(ref output, MulFishingIllustratedRewardResponse._repeated_rewardId_codec);
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

		// Token: 0x0600F0EC RID: 61676 RVA: 0x00233570 File Offset: 0x00231770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rewardId_.CalculateSize(MulFishingIllustratedRewardResponse._repeated_rewardId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F0ED RID: 61677 RVA: 0x002335C4 File Offset: 0x002317C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulFishingIllustratedRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rewardId_.Add(other.rewardId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F0EE RID: 61678 RVA: 0x00233611 File Offset: 0x00231811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0EF RID: 61679 RVA: 0x0023361C File Offset: 0x0023181C
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
				if (num != 16U && num != 18U)
				{
					if (num != 120U)
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
					this.rewardId_.AddEntriesFrom(ref input, MulFishingIllustratedRewardResponse._repeated_rewardId_codec);
				}
			}
		}

		// Token: 0x040061B5 RID: 25013
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061B6 RID: 25014
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040061B7 RID: 25015
		private ErrorCode errorCode_;

		// Token: 0x040061B8 RID: 25016
		public const int RewardIdFieldNumber = 2;

		// Token: 0x040061B9 RID: 25017
		private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040061BA RID: 25018
		private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();
	}
}
