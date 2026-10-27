using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001440 RID: 5184
	[NetMessage(EMessageId.TrapDefenseRewardGainingGroupsNotify)]
	public sealed class TrapDefenseRewardGainingGroupsNotify : IMessage<TrapDefenseRewardGainingGroupsNotify>, IMessage, IEquatable<TrapDefenseRewardGainingGroupsNotify>, IDeepCloneable<TrapDefenseRewardGainingGroupsNotify>, IBufferMessage
	{
		// Token: 0x0601B75C RID: 112476 RVA: 0x003F9EE6 File Offset: 0x003F80E6
		[NullableContext(1)]
		public static TrapDefenseRewardGainingGroupsNotify Create()
		{
			return new TrapDefenseRewardGainingGroupsNotify();
		}

		// Token: 0x17005C9A RID: 23706
		// (get) Token: 0x0601B75D RID: 112477 RVA: 0x003F9EED File Offset: 0x003F80ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C9B RID: 23707
		// (get) Token: 0x0601B75E RID: 112478 RVA: 0x003F9EF0 File Offset: 0x003F80F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRewardGainingGroupsNotify.Descriptor;
			}
		}

		// Token: 0x0601B75F RID: 112479 RVA: 0x003F9EF7 File Offset: 0x003F80F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardGainingGroupsNotify()
		{
		}

		// Token: 0x0601B760 RID: 112480 RVA: 0x003F9EFF File Offset: 0x003F80FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardGainingGroupsNotify(TrapDefenseRewardGainingGroupsNotify other) : this()
		{
			this.rewardInfo_ = ((other.rewardInfo_ != null) ? other.rewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B761 RID: 112481 RVA: 0x003F9F34 File Offset: 0x003F8134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardGainingGroupsNotify Clone()
		{
			return new TrapDefenseRewardGainingGroupsNotify(this);
		}

		// Token: 0x17005C9C RID: 23708
		// (get) Token: 0x0601B762 RID: 112482 RVA: 0x003F9F3C File Offset: 0x003F813C
		// (set) Token: 0x0601B763 RID: 112483 RVA: 0x003F9F44 File Offset: 0x003F8144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo RewardInfo
		{
			get
			{
				return this.rewardInfo_;
			}
			set
			{
				this.rewardInfo_ = value;
			}
		}

		// Token: 0x0601B764 RID: 112484 RVA: 0x003F9F4D File Offset: 0x003F814D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRewardGainingGroupsNotify);
		}

		// Token: 0x0601B765 RID: 112485 RVA: 0x003F9F5B File Offset: 0x003F815B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRewardGainingGroupsNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfo, other.RewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B766 RID: 112486 RVA: 0x003F9F90 File Offset: 0x003F8190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardInfo_ != null)
			{
				num ^= this.RewardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B767 RID: 112487 RVA: 0x003F9FCC File Offset: 0x003F81CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B768 RID: 112488 RVA: 0x003F9FD9 File Offset: 0x003F81D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B769 RID: 112489 RVA: 0x003F9FE2 File Offset: 0x003F81E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B76A RID: 112490 RVA: 0x003FA014 File Offset: 0x003F8214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B76B RID: 112491 RVA: 0x003FA054 File Offset: 0x003F8254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRewardGainingGroupsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardInfo_ != null)
			{
				if (this.rewardInfo_ == null)
				{
					this.RewardInfo = new RewardGainingPanelInfo();
				}
				this.RewardInfo.MergeFrom(other.RewardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B76C RID: 112492 RVA: 0x003FA0A8 File Offset: 0x003F82A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B76D RID: 112493 RVA: 0x003FA0B4 File Offset: 0x003F82B4
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rewardInfo_ == null)
					{
						this.RewardInfo = new RewardGainingPanelInfo();
					}
					input.ReadMessage(this.RewardInfo);
				}
			}
		}

		// Token: 0x04009E7A RID: 40570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E7B RID: 40571
		public const int RewardInfoFieldNumber = 2;

		// Token: 0x04009E7C RID: 40572
		private RewardGainingPanelInfo rewardInfo_;
	}
}
