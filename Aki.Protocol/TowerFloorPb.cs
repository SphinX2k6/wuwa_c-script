using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B8 RID: 5048
	public sealed class TowerFloorPb : IMessage<TowerFloorPb>, IMessage, IEquatable<TowerFloorPb>, IDeepCloneable<TowerFloorPb>, IBufferMessage
	{
		// Token: 0x0601AC7C RID: 109692 RVA: 0x003E2255 File Offset: 0x003E0455
		[NullableContext(1)]
		public static TowerFloorPb Create()
		{
			return new TowerFloorPb();
		}

		// Token: 0x17005A51 RID: 23121
		// (get) Token: 0x0601AC7D RID: 109693 RVA: 0x003E225C File Offset: 0x003E045C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerFloorPb> Parser
		{
			get
			{
				return TowerFloorPb._parser;
			}
		}

		// Token: 0x17005A52 RID: 23122
		// (get) Token: 0x0601AC7E RID: 109694 RVA: 0x003E2263 File Offset: 0x003E0463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A53 RID: 23123
		// (get) Token: 0x0601AC7F RID: 109695 RVA: 0x003E2266 File Offset: 0x003E0466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerFloorPb.Descriptor;
			}
		}

		// Token: 0x0601AC80 RID: 109696 RVA: 0x003E226D File Offset: 0x003E046D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorPb()
		{
		}

		// Token: 0x0601AC81 RID: 109697 RVA: 0x003E228C File Offset: 0x003E048C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorPb(TowerFloorPb other) : this()
		{
			this.towerConfigId_ = other.towerConfigId_;
			this.star_ = other.star_;
			this.formation_ = other.formation_.Clone();
			this.starIndex_ = other.starIndex_.Clone();
			this.isQuickPass_ = other.isQuickPass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC82 RID: 109698 RVA: 0x003E22F6 File Offset: 0x003E04F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorPb Clone()
		{
			return new TowerFloorPb(this);
		}

		// Token: 0x17005A54 RID: 23124
		// (get) Token: 0x0601AC83 RID: 109699 RVA: 0x003E22FE File Offset: 0x003E04FE
		// (set) Token: 0x0601AC84 RID: 109700 RVA: 0x003E2306 File Offset: 0x003E0506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x17005A55 RID: 23125
		// (get) Token: 0x0601AC85 RID: 109701 RVA: 0x003E230F File Offset: 0x003E050F
		// (set) Token: 0x0601AC86 RID: 109702 RVA: 0x003E2317 File Offset: 0x003E0517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x17005A56 RID: 23126
		// (get) Token: 0x0601AC87 RID: 109703 RVA: 0x003E2320 File Offset: 0x003E0520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerRolePb> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x17005A57 RID: 23127
		// (get) Token: 0x0601AC88 RID: 109704 RVA: 0x003E2328 File Offset: 0x003E0528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StarIndex
		{
			get
			{
				return this.starIndex_;
			}
		}

		// Token: 0x17005A58 RID: 23128
		// (get) Token: 0x0601AC89 RID: 109705 RVA: 0x003E2330 File Offset: 0x003E0530
		// (set) Token: 0x0601AC8A RID: 109706 RVA: 0x003E2338 File Offset: 0x003E0538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsQuickPass
		{
			get
			{
				return this.isQuickPass_;
			}
			set
			{
				this.isQuickPass_ = value;
			}
		}

		// Token: 0x0601AC8B RID: 109707 RVA: 0x003E2341 File Offset: 0x003E0541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerFloorPb);
		}

		// Token: 0x0601AC8C RID: 109708 RVA: 0x003E2350 File Offset: 0x003E0550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerFloorPb other)
		{
			return other != null && (other == this || (this.TowerConfigId == other.TowerConfigId && this.Star == other.Star && this.formation_.Equals(other.formation_) && this.starIndex_.Equals(other.starIndex_) && this.IsQuickPass == other.IsQuickPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC8D RID: 109709 RVA: 0x003E23D4 File Offset: 0x003E05D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			if (this.Star != 0)
			{
				num ^= this.Star.GetHashCode();
			}
			num ^= this.formation_.GetHashCode();
			num ^= this.starIndex_.GetHashCode();
			if (this.IsQuickPass)
			{
				num ^= this.IsQuickPass.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AC8E RID: 109710 RVA: 0x003E2461 File Offset: 0x003E0661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC8F RID: 109711 RVA: 0x003E246E File Offset: 0x003E066E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC90 RID: 109712 RVA: 0x003E2478 File Offset: 0x003E0678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TowerConfigId);
			}
			if (this.Star != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Star);
			}
			this.formation_.WriteTo(ref output, TowerFloorPb._repeated_formation_codec);
			this.starIndex_.WriteTo(ref output, TowerFloorPb._repeated_starIndex_codec);
			if (this.IsQuickPass)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsQuickPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC91 RID: 109713 RVA: 0x003E2510 File Offset: 0x003E0710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			if (this.Star != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Star);
			}
			num += this.formation_.CalculateSize(TowerFloorPb._repeated_formation_codec);
			num += this.starIndex_.CalculateSize(TowerFloorPb._repeated_starIndex_codec);
			if (this.IsQuickPass)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AC92 RID: 109714 RVA: 0x003E2598 File Offset: 0x003E0798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerFloorPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			if (other.Star != 0)
			{
				this.Star = other.Star;
			}
			this.formation_.Add(other.formation_);
			this.starIndex_.Add(other.starIndex_);
			if (other.IsQuickPass)
			{
				this.IsQuickPass = other.IsQuickPass;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC93 RID: 109715 RVA: 0x003E261E File Offset: 0x003E081E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC94 RID: 109716 RVA: 0x003E2628 File Offset: 0x003E0828
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
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.TowerConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Star = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.formation_.AddEntriesFrom(ref input, TowerFloorPb._repeated_formation_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U || num == 42U)
					{
						this.starIndex_.AddEntriesFrom(ref input, TowerFloorPb._repeated_starIndex_codec);
						continue;
					}
					if (num == 48U)
					{
						this.IsQuickPass = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B79 RID: 39801
		private static readonly MessageParser<TowerFloorPb> _parser = new MessageParser<TowerFloorPb>(() => new TowerFloorPb());

		// Token: 0x04009B7A RID: 39802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B7B RID: 39803
		public const int TowerConfigIdFieldNumber = 1;

		// Token: 0x04009B7C RID: 39804
		private int towerConfigId_;

		// Token: 0x04009B7D RID: 39805
		public const int StarFieldNumber = 2;

		// Token: 0x04009B7E RID: 39806
		private int star_;

		// Token: 0x04009B7F RID: 39807
		public const int FormationFieldNumber = 4;

		// Token: 0x04009B80 RID: 39808
		private static readonly FieldCodec<TowerRolePb> _repeated_formation_codec = FieldCodec.ForMessage<TowerRolePb>(34U, TowerRolePb.Parser);

		// Token: 0x04009B81 RID: 39809
		private readonly RepeatedField<TowerRolePb> formation_ = new RepeatedField<TowerRolePb>();

		// Token: 0x04009B82 RID: 39810
		public const int StarIndexFieldNumber = 5;

		// Token: 0x04009B83 RID: 39811
		private static readonly FieldCodec<int> _repeated_starIndex_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04009B84 RID: 39812
		private readonly RepeatedField<int> starIndex_ = new RepeatedField<int>();

		// Token: 0x04009B85 RID: 39813
		public const int IsQuickPassFieldNumber = 6;

		// Token: 0x04009B86 RID: 39814
		private bool isQuickPass_;
	}
}
