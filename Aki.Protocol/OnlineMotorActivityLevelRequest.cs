using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B96 RID: 2966
	[NetMessage(EMessageId.OnlineMotorActivityLevelRequest)]
	public sealed class OnlineMotorActivityLevelRequest : IMessage<OnlineMotorActivityLevelRequest>, IMessage, IEquatable<OnlineMotorActivityLevelRequest>, IDeepCloneable<OnlineMotorActivityLevelRequest>, IBufferMessage
	{
		// Token: 0x06010155 RID: 65877 RVA: 0x00259155 File Offset: 0x00257355
		[NullableContext(1)]
		public static OnlineMotorActivityLevelRequest Create()
		{
			return new OnlineMotorActivityLevelRequest();
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x06010156 RID: 65878 RVA: 0x0025915C File Offset: 0x0025735C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x06010157 RID: 65879 RVA: 0x0025915F File Offset: 0x0025735F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorActivityLevelRequest.Descriptor;
			}
		}

		// Token: 0x06010158 RID: 65880 RVA: 0x00259166 File Offset: 0x00257366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelRequest()
		{
		}

		// Token: 0x06010159 RID: 65881 RVA: 0x00259179 File Offset: 0x00257379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelRequest(OnlineMotorActivityLevelRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this.rewardType_ = other.rewardType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601015A RID: 65882 RVA: 0x002591AF File Offset: 0x002573AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelRequest Clone()
		{
			return new OnlineMotorActivityLevelRequest(this);
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0601015B RID: 65883 RVA: 0x002591B7 File Offset: 0x002573B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0601015C RID: 65884 RVA: 0x002591BF File Offset: 0x002573BF
		// (set) Token: 0x0601015D RID: 65885 RVA: 0x002591C7 File Offset: 0x002573C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorRewardType RewardType
		{
			get
			{
				return this.rewardType_;
			}
			set
			{
				this.rewardType_ = value;
			}
		}

		// Token: 0x0601015E RID: 65886 RVA: 0x002591D0 File Offset: 0x002573D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorActivityLevelRequest);
		}

		// Token: 0x0601015F RID: 65887 RVA: 0x002591E0 File Offset: 0x002573E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorActivityLevelRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && this.RewardType == other.RewardType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010160 RID: 65888 RVA: 0x00259230 File Offset: 0x00257430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardIds_.GetHashCode();
			if (this.RewardType != OnlineMotorRewardType.LevelReward)
			{
				num ^= this.RewardType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010161 RID: 65889 RVA: 0x00259283 File Offset: 0x00257483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010162 RID: 65890 RVA: 0x00259290 File Offset: 0x00257490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010163 RID: 65891 RVA: 0x0025929C File Offset: 0x0025749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardType != OnlineMotorRewardType.LevelReward)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.RewardType);
			}
			this.rewardIds_.WriteTo(ref output, OnlineMotorActivityLevelRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010164 RID: 65892 RVA: 0x002592EC File Offset: 0x002574EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(OnlineMotorActivityLevelRequest._repeated_rewardIds_codec);
			if (this.RewardType != OnlineMotorRewardType.LevelReward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RewardType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010165 RID: 65893 RVA: 0x00259340 File Offset: 0x00257540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorActivityLevelRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			if (other.RewardType != OnlineMotorRewardType.LevelReward)
			{
				this.RewardType = other.RewardType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010166 RID: 65894 RVA: 0x0025938D File Offset: 0x0025758D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010167 RID: 65895 RVA: 0x00259398 File Offset: 0x00257598
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
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardIds_.AddEntriesFrom(ref input, OnlineMotorActivityLevelRequest._repeated_rewardIds_codec);
					}
				}
				else
				{
					this.RewardType = (OnlineMotorRewardType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400668F RID: 26255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006690 RID: 26256
		public const int RewardIdsFieldNumber = 15;

		// Token: 0x04006691 RID: 26257
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04006692 RID: 26258
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();

		// Token: 0x04006693 RID: 26259
		public const int RewardTypeFieldNumber = 4;

		// Token: 0x04006694 RID: 26260
		private OnlineMotorRewardType rewardType_;
	}
}
