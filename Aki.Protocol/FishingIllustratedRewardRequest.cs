using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054F RID: 1359
	[NetMessage(EMessageId.FishingIllustratedRewardRequest)]
	public sealed class FishingIllustratedRewardRequest : IMessage<FishingIllustratedRewardRequest>, IMessage, IEquatable<FishingIllustratedRewardRequest>, IDeepCloneable<FishingIllustratedRewardRequest>, IBufferMessage
	{
		// Token: 0x06007F3A RID: 32570 RVA: 0x00133F54 File Offset: 0x00132154
		[NullableContext(1)]
		public static FishingIllustratedRewardRequest Create()
		{
			return new FishingIllustratedRewardRequest();
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06007F3B RID: 32571 RVA: 0x00133F5B File Offset: 0x0013215B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06007F3C RID: 32572 RVA: 0x00133F5E File Offset: 0x0013215E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedRewardRequest.Descriptor;
			}
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x00133F65 File Offset: 0x00132165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardRequest()
		{
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x00133F6D File Offset: 0x0013216D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardRequest(FishingIllustratedRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x00133F92 File Offset: 0x00132192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardRequest Clone()
		{
			return new FishingIllustratedRewardRequest(this);
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06007F40 RID: 32576 RVA: 0x00133F9A File Offset: 0x0013219A
		// (set) Token: 0x06007F41 RID: 32577 RVA: 0x00133FA2 File Offset: 0x001321A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x00133FAB File Offset: 0x001321AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedRewardRequest);
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x00133FB9 File Offset: 0x001321B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedRewardRequest other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x00133FE8 File Offset: 0x001321E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x00134027 File Offset: 0x00132227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x00134034 File Offset: 0x00132234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x0013403D File Offset: 0x0013223D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x00134070 File Offset: 0x00132270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x001340AE File Offset: 0x001322AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x001340DF File Offset: 0x001322DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x001340E8 File Offset: 0x001322E8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040040AB RID: 16555
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040AC RID: 16556
		public const int RewardIdFieldNumber = 6;

		// Token: 0x040040AD RID: 16557
		private int rewardId_;
	}
}
