using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B86 RID: 2950
	[NetMessage(EMessageId.OnlineMotorActivityLevelRequest)]
	public sealed class OnlineMotorActivityLevelRequest : IMessage<OnlineMotorActivityLevelRequest>, IMessage, IEquatable<OnlineMotorActivityLevelRequest>, IDeepCloneable<OnlineMotorActivityLevelRequest>, IBufferMessage
	{
		// Token: 0x06010051 RID: 65617 RVA: 0x00257285 File Offset: 0x00255485
		[NullableContext(1)]
		public static OnlineMotorActivityLevelRequest Create()
		{
			return new OnlineMotorActivityLevelRequest();
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x06010052 RID: 65618 RVA: 0x0025728C File Offset: 0x0025548C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x06010053 RID: 65619 RVA: 0x0025728F File Offset: 0x0025548F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorActivityLevelRequest.Descriptor;
			}
		}

		// Token: 0x06010054 RID: 65620 RVA: 0x00257296 File Offset: 0x00255496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelRequest()
		{
		}

		// Token: 0x06010055 RID: 65621 RVA: 0x002572A9 File Offset: 0x002554A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelRequest(OnlineMotorActivityLevelRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this.rewardType_ = other.rewardType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010056 RID: 65622 RVA: 0x002572DF File Offset: 0x002554DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelRequest Clone()
		{
			return new OnlineMotorActivityLevelRequest(this);
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x06010057 RID: 65623 RVA: 0x002572E7 File Offset: 0x002554E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x06010058 RID: 65624 RVA: 0x002572EF File Offset: 0x002554EF
		// (set) Token: 0x06010059 RID: 65625 RVA: 0x002572F7 File Offset: 0x002554F7
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

		// Token: 0x0601005A RID: 65626 RVA: 0x00257300 File Offset: 0x00255500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorActivityLevelRequest);
		}

		// Token: 0x0601005B RID: 65627 RVA: 0x00257310 File Offset: 0x00255510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorActivityLevelRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && this.RewardType == other.RewardType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601005C RID: 65628 RVA: 0x00257360 File Offset: 0x00255560
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

		// Token: 0x0601005D RID: 65629 RVA: 0x002573B3 File Offset: 0x002555B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601005E RID: 65630 RVA: 0x002573C0 File Offset: 0x002555C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601005F RID: 65631 RVA: 0x002573CC File Offset: 0x002555CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardType != OnlineMotorRewardType.LevelReward)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.RewardType);
			}
			this.rewardIds_.WriteTo(ref output, OnlineMotorActivityLevelRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010060 RID: 65632 RVA: 0x0025741C File Offset: 0x0025561C
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

		// Token: 0x06010061 RID: 65633 RVA: 0x00257470 File Offset: 0x00255670
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

		// Token: 0x06010062 RID: 65634 RVA: 0x002574BD File Offset: 0x002556BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010063 RID: 65635 RVA: 0x002574C8 File Offset: 0x002556C8
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
				if (num != 24U)
				{
					if (num != 40U && num != 42U)
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

		// Token: 0x0400669F RID: 26271
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066A0 RID: 26272
		public const int RewardIdsFieldNumber = 5;

		// Token: 0x040066A1 RID: 26273
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040066A2 RID: 26274
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();

		// Token: 0x040066A3 RID: 26275
		public const int RewardTypeFieldNumber = 3;

		// Token: 0x040066A4 RID: 26276
		private OnlineMotorRewardType rewardType_;
	}
}
