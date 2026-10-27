using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F5 RID: 4341
	public sealed class RoverRogueChooseData : IMessage<RoverRogueChooseData>, IMessage, IEquatable<RoverRogueChooseData>, IDeepCloneable<RoverRogueChooseData>, IBufferMessage
	{
		// Token: 0x06017261 RID: 94817 RVA: 0x0035C041 File Offset: 0x0035A241
		[NullableContext(1)]
		public static RoverRogueChooseData Create()
		{
			return new RoverRogueChooseData();
		}

		// Token: 0x17004D8E RID: 19854
		// (get) Token: 0x06017262 RID: 94818 RVA: 0x0035C048 File Offset: 0x0035A248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D8F RID: 19855
		// (get) Token: 0x06017263 RID: 94819 RVA: 0x0035C04B File Offset: 0x0035A24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueChooseData.Descriptor;
			}
		}

		// Token: 0x06017264 RID: 94820 RVA: 0x0035C052 File Offset: 0x0035A252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseData()
		{
		}

		// Token: 0x06017265 RID: 94821 RVA: 0x0035C068 File Offset: 0x0035A268
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

		// Token: 0x06017266 RID: 94822 RVA: 0x0035C0F1 File Offset: 0x0035A2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseData Clone()
		{
			return new RoverRogueChooseData(this);
		}

		// Token: 0x17004D90 RID: 19856
		// (get) Token: 0x06017267 RID: 94823 RVA: 0x0035C0F9 File Offset: 0x0035A2F9
		// (set) Token: 0x06017268 RID: 94824 RVA: 0x0035C101 File Offset: 0x0035A301
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

		// Token: 0x17004D91 RID: 19857
		// (get) Token: 0x06017269 RID: 94825 RVA: 0x0035C10A File Offset: 0x0035A30A
		// (set) Token: 0x0601726A RID: 94826 RVA: 0x0035C112 File Offset: 0x0035A312
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

		// Token: 0x17004D92 RID: 19858
		// (get) Token: 0x0601726B RID: 94827 RVA: 0x0035C11B File Offset: 0x0035A31B
		// (set) Token: 0x0601726C RID: 94828 RVA: 0x0035C123 File Offset: 0x0035A323
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

		// Token: 0x17004D93 RID: 19859
		// (get) Token: 0x0601726D RID: 94829 RVA: 0x0035C12C File Offset: 0x0035A32C
		// (set) Token: 0x0601726E RID: 94830 RVA: 0x0035C134 File Offset: 0x0035A334
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

		// Token: 0x17004D94 RID: 19860
		// (get) Token: 0x0601726F RID: 94831 RVA: 0x0035C13D File Offset: 0x0035A33D
		// (set) Token: 0x06017270 RID: 94832 RVA: 0x0035C145 File Offset: 0x0035A345
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

		// Token: 0x17004D95 RID: 19861
		// (get) Token: 0x06017271 RID: 94833 RVA: 0x0035C14E File Offset: 0x0035A34E
		// (set) Token: 0x06017272 RID: 94834 RVA: 0x0035C156 File Offset: 0x0035A356
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

		// Token: 0x17004D96 RID: 19862
		// (get) Token: 0x06017273 RID: 94835 RVA: 0x0035C15F File Offset: 0x0035A35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x17004D97 RID: 19863
		// (get) Token: 0x06017274 RID: 94836 RVA: 0x0035C167 File Offset: 0x0035A367
		// (set) Token: 0x06017275 RID: 94837 RVA: 0x0035C16F File Offset: 0x0035A36F
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

		// Token: 0x06017276 RID: 94838 RVA: 0x0035C178 File Offset: 0x0035A378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueChooseData);
		}

		// Token: 0x06017277 RID: 94839 RVA: 0x0035C188 File Offset: 0x0035A388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueChooseData other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Type == other.Type && this.Layer == other.Layer && this.IsSelect == other.IsSelect && this.MaxTime == other.MaxTime && this.UseTime == other.UseTime && this.entries_.Equals(other.entries_) && this.RefreshCost == other.RefreshCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017278 RID: 94840 RVA: 0x0035C238 File Offset: 0x0035A438
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

		// Token: 0x06017279 RID: 94841 RVA: 0x0035C321 File Offset: 0x0035A521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601727A RID: 94842 RVA: 0x0035C32E File Offset: 0x0035A52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601727B RID: 94843 RVA: 0x0035C338 File Offset: 0x0035A538
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

		// Token: 0x0601727C RID: 94844 RVA: 0x0035C430 File Offset: 0x0035A630
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

		// Token: 0x0601727D RID: 94845 RVA: 0x0035C508 File Offset: 0x0035A708
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

		// Token: 0x0601727E RID: 94846 RVA: 0x0035C5CD File Offset: 0x0035A7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601727F RID: 94847 RVA: 0x0035C5D8 File Offset: 0x0035A7D8
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

		// Token: 0x040089AF RID: 35247
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089B0 RID: 35248
		public const int BindIdFieldNumber = 1;

		// Token: 0x040089B1 RID: 35249
		private int bindId_;

		// Token: 0x040089B2 RID: 35250
		public const int TypeFieldNumber = 2;

		// Token: 0x040089B3 RID: 35251
		private RoverRogueGainOperateType type_;

		// Token: 0x040089B4 RID: 35252
		public const int LayerFieldNumber = 3;

		// Token: 0x040089B5 RID: 35253
		private int layer_;

		// Token: 0x040089B6 RID: 35254
		public const int IsSelectFieldNumber = 4;

		// Token: 0x040089B7 RID: 35255
		private bool isSelect_;

		// Token: 0x040089B8 RID: 35256
		public const int MaxTimeFieldNumber = 5;

		// Token: 0x040089B9 RID: 35257
		private int maxTime_;

		// Token: 0x040089BA RID: 35258
		public const int UseTimeFieldNumber = 6;

		// Token: 0x040089BB RID: 35259
		private int useTime_;

		// Token: 0x040089BC RID: 35260
		public const int EntriesFieldNumber = 7;

		// Token: 0x040089BD RID: 35261
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_entries_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(58U, RoverRogueGainEntry.Parser);

		// Token: 0x040089BE RID: 35262
		private readonly RepeatedField<RoverRogueGainEntry> entries_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x040089BF RID: 35263
		public const int RefreshCostFieldNumber = 8;

		// Token: 0x040089C0 RID: 35264
		private int refreshCost_;
	}
}
