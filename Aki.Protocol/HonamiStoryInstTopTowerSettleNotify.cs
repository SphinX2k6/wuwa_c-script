using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077D RID: 1917
	[NetMessage(EMessageId.HonamiStoryInstTopTowerSettleNotify)]
	public sealed class HonamiStoryInstTopTowerSettleNotify : IMessage<HonamiStoryInstTopTowerSettleNotify>, IMessage, IEquatable<HonamiStoryInstTopTowerSettleNotify>, IDeepCloneable<HonamiStoryInstTopTowerSettleNotify>, IBufferMessage
	{
		// Token: 0x0600AD3E RID: 44350 RVA: 0x001A0806 File Offset: 0x0019EA06
		[NullableContext(1)]
		public static HonamiStoryInstTopTowerSettleNotify Create()
		{
			return new HonamiStoryInstTopTowerSettleNotify();
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x0600AD3F RID: 44351 RVA: 0x001A080D File Offset: 0x0019EA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x0600AD40 RID: 44352 RVA: 0x001A0810 File Offset: 0x0019EA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstTopTowerSettleNotify.Descriptor;
			}
		}

		// Token: 0x0600AD41 RID: 44353 RVA: 0x001A0817 File Offset: 0x0019EA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstTopTowerSettleNotify()
		{
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x001A082C File Offset: 0x0019EA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstTopTowerSettleNotify(HonamiStoryInstTopTowerSettleNotify other) : this()
		{
			this.useTime_ = other.useTime_;
			this.dangerLevel_ = other.dangerLevel_;
			this.passFloor_ = other.passFloor_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x001A0885 File Offset: 0x0019EA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstTopTowerSettleNotify Clone()
		{
			return new HonamiStoryInstTopTowerSettleNotify(this);
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x0600AD44 RID: 44356 RVA: 0x001A088D File Offset: 0x0019EA8D
		// (set) Token: 0x0600AD45 RID: 44357 RVA: 0x001A0895 File Offset: 0x0019EA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseTime
		{
			get
			{
				return this.useTime_;
			}
			set
			{
				this.useTime_ = value;
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x0600AD46 RID: 44358 RVA: 0x001A089E File Offset: 0x0019EA9E
		// (set) Token: 0x0600AD47 RID: 44359 RVA: 0x001A08A6 File Offset: 0x0019EAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangerLevel
		{
			get
			{
				return this.dangerLevel_;
			}
			set
			{
				this.dangerLevel_ = value;
			}
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x0600AD48 RID: 44360 RVA: 0x001A08AF File Offset: 0x0019EAAF
		// (set) Token: 0x0600AD49 RID: 44361 RVA: 0x001A08B7 File Offset: 0x0019EAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassFloor
		{
			get
			{
				return this.passFloor_;
			}
			set
			{
				this.passFloor_ = value;
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x0600AD4A RID: 44362 RVA: 0x001A08C0 File Offset: 0x0019EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItem> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600AD4B RID: 44363 RVA: 0x001A08C8 File Offset: 0x0019EAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstTopTowerSettleNotify);
		}

		// Token: 0x0600AD4C RID: 44364 RVA: 0x001A08D8 File Offset: 0x0019EAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstTopTowerSettleNotify other)
		{
			return other != null && (other == this || (this.UseTime == other.UseTime && this.DangerLevel == other.DangerLevel && this.PassFloor == other.PassFloor && this.rewardItems_.Equals(other.rewardItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD4D RID: 44365 RVA: 0x001A0948 File Offset: 0x0019EB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			if (this.DangerLevel != 0)
			{
				num ^= this.DangerLevel.GetHashCode();
			}
			if (this.PassFloor != 0)
			{
				num ^= this.PassFloor.GetHashCode();
			}
			num ^= this.rewardItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x001A09C7 File Offset: 0x0019EBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD4F RID: 44367 RVA: 0x001A09D4 File Offset: 0x0019EBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD50 RID: 44368 RVA: 0x001A09E0 File Offset: 0x0019EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardItems_.WriteTo(ref output, HonamiStoryInstTopTowerSettleNotify._repeated_rewardItems_codec);
			if (this.UseTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.UseTime);
			}
			if (this.DangerLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DangerLevel);
			}
			if (this.PassFloor != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PassFloor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD51 RID: 44369 RVA: 0x001A0A68 File Offset: 0x0019EC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			if (this.DangerLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangerLevel);
			}
			if (this.PassFloor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassFloor);
			}
			num += this.rewardItems_.CalculateSize(HonamiStoryInstTopTowerSettleNotify._repeated_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD52 RID: 44370 RVA: 0x001A0AEC File Offset: 0x0019ECEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryInstTopTowerSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			if (other.DangerLevel != 0)
			{
				this.DangerLevel = other.DangerLevel;
			}
			if (other.PassFloor != 0)
			{
				this.PassFloor = other.PassFloor;
			}
			this.rewardItems_.Add(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD53 RID: 44371 RVA: 0x001A0B61 File Offset: 0x0019ED61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x001A0B6C File Offset: 0x0019ED6C
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, HonamiStoryInstTopTowerSettleNotify._repeated_rewardItems_codec);
						continue;
					}
					if (num == 24U)
					{
						this.UseTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.DangerLevel = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.PassFloor = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E62 RID: 20066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E63 RID: 20067
		public const int UseTimeFieldNumber = 3;

		// Token: 0x04004E64 RID: 20068
		private int useTime_;

		// Token: 0x04004E65 RID: 20069
		public const int DangerLevelFieldNumber = 7;

		// Token: 0x04004E66 RID: 20070
		private int dangerLevel_;

		// Token: 0x04004E67 RID: 20071
		public const int PassFloorFieldNumber = 8;

		// Token: 0x04004E68 RID: 20072
		private int passFloor_;

		// Token: 0x04004E69 RID: 20073
		public const int RewardItemsFieldNumber = 1;

		// Token: 0x04004E6A RID: 20074
		private static readonly FieldCodec<RewardItem> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItem>(10U, RewardItem.Parser);

		// Token: 0x04004E6B RID: 20075
		private readonly RepeatedField<RewardItem> rewardItems_ = new RepeatedField<RewardItem>();
	}
}
