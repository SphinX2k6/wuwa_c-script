using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112F RID: 4399
	public sealed class RoverRogueChooseData : IMessage<RoverRogueChooseData>, IMessage, IEquatable<RoverRogueChooseData>, IDeepCloneable<RoverRogueChooseData>, IBufferMessage
	{
		// Token: 0x06017802 RID: 96258 RVA: 0x0036B399 File Offset: 0x00369599
		[NullableContext(1)]
		public static RoverRogueChooseData Create()
		{
			return new RoverRogueChooseData();
		}

		// Token: 0x17004EFA RID: 20218
		// (get) Token: 0x06017803 RID: 96259 RVA: 0x0036B3A0 File Offset: 0x003695A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EFB RID: 20219
		// (get) Token: 0x06017804 RID: 96260 RVA: 0x0036B3A3 File Offset: 0x003695A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueChooseData.Descriptor;
			}
		}

		// Token: 0x06017805 RID: 96261 RVA: 0x0036B3AA File Offset: 0x003695AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseData()
		{
		}

		// Token: 0x06017806 RID: 96262 RVA: 0x0036B3C0 File Offset: 0x003695C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseData(RoverRogueChooseData other) : this()
		{
			this.bindId_ = other.bindId_;
			this.type_ = other.type_;
			this.layer_ = other.layer_;
			this.isSelect_ = other.isSelect_;
			this.maxTime_ = other.maxTime_;
			this.useTime_ = other.useTime_;
			this.entries_ = other.entries_.Clone();
			this.refreshCost_ = other.refreshCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017807 RID: 96263 RVA: 0x0036B449 File Offset: 0x00369649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseData Clone()
		{
			return new RoverRogueChooseData(this);
		}

		// Token: 0x17004EFC RID: 20220
		// (get) Token: 0x06017808 RID: 96264 RVA: 0x0036B451 File Offset: 0x00369651
		// (set) Token: 0x06017809 RID: 96265 RVA: 0x0036B459 File Offset: 0x00369659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x17004EFD RID: 20221
		// (get) Token: 0x0601780A RID: 96266 RVA: 0x0036B462 File Offset: 0x00369662
		// (set) Token: 0x0601780B RID: 96267 RVA: 0x0036B46A File Offset: 0x0036966A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainOperateType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17004EFE RID: 20222
		// (get) Token: 0x0601780C RID: 96268 RVA: 0x0036B473 File Offset: 0x00369673
		// (set) Token: 0x0601780D RID: 96269 RVA: 0x0036B47B File Offset: 0x0036967B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Layer
		{
			get
			{
				return this.layer_;
			}
			set
			{
				this.layer_ = value;
			}
		}

		// Token: 0x17004EFF RID: 20223
		// (get) Token: 0x0601780E RID: 96270 RVA: 0x0036B484 File Offset: 0x00369684
		// (set) Token: 0x0601780F RID: 96271 RVA: 0x0036B48C File Offset: 0x0036968C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x17004F00 RID: 20224
		// (get) Token: 0x06017810 RID: 96272 RVA: 0x0036B495 File Offset: 0x00369695
		// (set) Token: 0x06017811 RID: 96273 RVA: 0x0036B49D File Offset: 0x0036969D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxTime
		{
			get
			{
				return this.maxTime_;
			}
			set
			{
				this.maxTime_ = value;
			}
		}

		// Token: 0x17004F01 RID: 20225
		// (get) Token: 0x06017812 RID: 96274 RVA: 0x0036B4A6 File Offset: 0x003696A6
		// (set) Token: 0x06017813 RID: 96275 RVA: 0x0036B4AE File Offset: 0x003696AE
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

		// Token: 0x17004F02 RID: 20226
		// (get) Token: 0x06017814 RID: 96276 RVA: 0x0036B4B7 File Offset: 0x003696B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x17004F03 RID: 20227
		// (get) Token: 0x06017815 RID: 96277 RVA: 0x0036B4BF File Offset: 0x003696BF
		// (set) Token: 0x06017816 RID: 96278 RVA: 0x0036B4C7 File Offset: 0x003696C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCost
		{
			get
			{
				return this.refreshCost_;
			}
			set
			{
				this.refreshCost_ = value;
			}
		}

		// Token: 0x06017817 RID: 96279 RVA: 0x0036B4D0 File Offset: 0x003696D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueChooseData);
		}

		// Token: 0x06017818 RID: 96280 RVA: 0x0036B4E0 File Offset: 0x003696E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueChooseData other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Type == other.Type && this.Layer == other.Layer && this.IsSelect == other.IsSelect && this.MaxTime == other.MaxTime && this.UseTime == other.UseTime && this.entries_.Equals(other.entries_) && this.RefreshCost == other.RefreshCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017819 RID: 96281 RVA: 0x0036B590 File Offset: 0x00369790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this.Type != RoverRogueGainOperateType.RoverRogueBlessSelect)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Layer != 0)
			{
				num ^= this.Layer.GetHashCode();
			}
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this.MaxTime != 0)
			{
				num ^= this.MaxTime.GetHashCode();
			}
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			num ^= this.entries_.GetHashCode();
			if (this.RefreshCost != 0)
			{
				num ^= this.RefreshCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601781A RID: 96282 RVA: 0x0036B679 File Offset: 0x00369879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601781B RID: 96283 RVA: 0x0036B686 File Offset: 0x00369886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601781C RID: 96284 RVA: 0x0036B690 File Offset: 0x00369890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BindId);
			}
			if (this.Type != RoverRogueGainOperateType.RoverRogueBlessSelect)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.Layer != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Layer);
			}
			if (this.IsSelect)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSelect);
			}
			if (this.MaxTime != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxTime);
			}
			if (this.UseTime != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UseTime);
			}
			this.entries_.WriteTo(ref output, RoverRogueChooseData._repeated_entries_codec);
			if (this.RefreshCost != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RefreshCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601781D RID: 96285 RVA: 0x0036B788 File Offset: 0x00369988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this.Type != RoverRogueGainOperateType.RoverRogueBlessSelect)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Layer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Layer);
			}
			if (this.IsSelect)
			{
				num += 2;
			}
			if (this.MaxTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxTime);
			}
			if (this.UseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			num += this.entries_.CalculateSize(RoverRogueChooseData._repeated_entries_codec);
			if (this.RefreshCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601781E RID: 96286 RVA: 0x0036B860 File Offset: 0x00369A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueChooseData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			if (other.Type != RoverRogueGainOperateType.RoverRogueBlessSelect)
			{
				this.Type = other.Type;
			}
			if (other.Layer != 0)
			{
				this.Layer = other.Layer;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			if (other.MaxTime != 0)
			{
				this.MaxTime = other.MaxTime;
			}
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			this.entries_.Add(other.entries_);
			if (other.RefreshCost != 0)
			{
				this.RefreshCost = other.RefreshCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601781F RID: 96287 RVA: 0x0036B925 File Offset: 0x00369B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017820 RID: 96288 RVA: 0x0036B930 File Offset: 0x00369B30
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.BindId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Type = (RoverRogueGainOperateType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Layer = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.IsSelect = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.MaxTime = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.UseTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.entries_.AddEntriesFrom(ref input, RoverRogueChooseData._repeated_entries_codec);
						continue;
					}
					if (num == 64U)
					{
						this.RefreshCost = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008C42 RID: 35906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C43 RID: 35907
		public const int BindIdFieldNumber = 1;

		// Token: 0x04008C44 RID: 35908
		private int bindId_;

		// Token: 0x04008C45 RID: 35909
		public const int TypeFieldNumber = 2;

		// Token: 0x04008C46 RID: 35910
		private RoverRogueGainOperateType type_;

		// Token: 0x04008C47 RID: 35911
		public const int LayerFieldNumber = 3;

		// Token: 0x04008C48 RID: 35912
		private int layer_;

		// Token: 0x04008C49 RID: 35913
		public const int IsSelectFieldNumber = 4;

		// Token: 0x04008C4A RID: 35914
		private bool isSelect_;

		// Token: 0x04008C4B RID: 35915
		public const int MaxTimeFieldNumber = 5;

		// Token: 0x04008C4C RID: 35916
		private int maxTime_;

		// Token: 0x04008C4D RID: 35917
		public const int UseTimeFieldNumber = 6;

		// Token: 0x04008C4E RID: 35918
		private int useTime_;

		// Token: 0x04008C4F RID: 35919
		public const int EntriesFieldNumber = 7;

		// Token: 0x04008C50 RID: 35920
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_entries_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(58U, RoverRogueGainEntry.Parser);

		// Token: 0x04008C51 RID: 35921
		private readonly RepeatedField<RoverRogueGainEntry> entries_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008C52 RID: 35922
		public const int RefreshCostFieldNumber = 8;

		// Token: 0x04008C53 RID: 35923
		private int refreshCost_;
	}
}
