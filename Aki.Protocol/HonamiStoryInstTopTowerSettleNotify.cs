using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000769 RID: 1897
	[NetMessage(EMessageId.HonamiStoryInstTopTowerSettleNotify)]
	public sealed class HonamiStoryInstTopTowerSettleNotify : IMessage<HonamiStoryInstTopTowerSettleNotify>, IMessage, IEquatable<HonamiStoryInstTopTowerSettleNotify>, IDeepCloneable<HonamiStoryInstTopTowerSettleNotify>, IBufferMessage
	{
		// Token: 0x0600ABE8 RID: 44008 RVA: 0x0019DDDE File Offset: 0x0019BFDE
		[NullableContext(1)]
		public static HonamiStoryInstTopTowerSettleNotify Create()
		{
			return new HonamiStoryInstTopTowerSettleNotify();
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x0600ABE9 RID: 44009 RVA: 0x0019DDE5 File Offset: 0x0019BFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x0600ABEA RID: 44010 RVA: 0x0019DDE8 File Offset: 0x0019BFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstTopTowerSettleNotify.Descriptor;
			}
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x0019DDEF File Offset: 0x0019BFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstTopTowerSettleNotify()
		{
		}

		// Token: 0x0600ABEC RID: 44012 RVA: 0x0019DE04 File Offset: 0x0019C004
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

		// Token: 0x0600ABED RID: 44013 RVA: 0x0019DE5D File Offset: 0x0019C05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstTopTowerSettleNotify Clone()
		{
			return new HonamiStoryInstTopTowerSettleNotify(this);
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600ABEE RID: 44014 RVA: 0x0019DE65 File Offset: 0x0019C065
		// (set) Token: 0x0600ABEF RID: 44015 RVA: 0x0019DE6D File Offset: 0x0019C06D
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

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600ABF0 RID: 44016 RVA: 0x0019DE76 File Offset: 0x0019C076
		// (set) Token: 0x0600ABF1 RID: 44017 RVA: 0x0019DE7E File Offset: 0x0019C07E
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

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600ABF2 RID: 44018 RVA: 0x0019DE87 File Offset: 0x0019C087
		// (set) Token: 0x0600ABF3 RID: 44019 RVA: 0x0019DE8F File Offset: 0x0019C08F
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

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x0600ABF4 RID: 44020 RVA: 0x0019DE98 File Offset: 0x0019C098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItem> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x0019DEA0 File Offset: 0x0019C0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstTopTowerSettleNotify);
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x0019DEB0 File Offset: 0x0019C0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstTopTowerSettleNotify other)
		{
			return other != null && (other == this || (this.UseTime == other.UseTime && this.DangerLevel == other.DangerLevel && this.PassFloor == other.PassFloor && this.rewardItems_.Equals(other.rewardItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x0019DF20 File Offset: 0x0019C120
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

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x0019DF9F File Offset: 0x0019C19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABF9 RID: 44025 RVA: 0x0019DFAC File Offset: 0x0019C1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABFA RID: 44026 RVA: 0x0019DFB8 File Offset: 0x0019C1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseTime != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UseTime);
			}
			if (this.PassFloor != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PassFloor);
			}
			this.rewardItems_.WriteTo(ref output, HonamiStoryInstTopTowerSettleNotify._repeated_rewardItems_codec);
			if (this.DangerLevel != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DangerLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABFB RID: 44027 RVA: 0x0019E040 File Offset: 0x0019C240
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

		// Token: 0x0600ABFC RID: 44028 RVA: 0x0019E0C4 File Offset: 0x0019C2C4
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

		// Token: 0x0600ABFD RID: 44029 RVA: 0x0019E139 File Offset: 0x0019C339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x0019E144 File Offset: 0x0019C344
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
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.UseTime = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.PassFloor = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, HonamiStoryInstTopTowerSettleNotify._repeated_rewardItems_codec);
						continue;
					}
					if (num == 104U)
					{
						this.DangerLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E5B RID: 20059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E5C RID: 20060
		public const int UseTimeFieldNumber = 4;

		// Token: 0x04004E5D RID: 20061
		private int useTime_;

		// Token: 0x04004E5E RID: 20062
		public const int DangerLevelFieldNumber = 13;

		// Token: 0x04004E5F RID: 20063
		private int dangerLevel_;

		// Token: 0x04004E60 RID: 20064
		public const int PassFloorFieldNumber = 6;

		// Token: 0x04004E61 RID: 20065
		private int passFloor_;

		// Token: 0x04004E62 RID: 20066
		public const int RewardItemsFieldNumber = 7;

		// Token: 0x04004E63 RID: 20067
		private static readonly FieldCodec<RewardItem> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItem>(58U, RewardItem.Parser);

		// Token: 0x04004E64 RID: 20068
		private readonly RepeatedField<RewardItem> rewardItems_ = new RepeatedField<RewardItem>();
	}
}
