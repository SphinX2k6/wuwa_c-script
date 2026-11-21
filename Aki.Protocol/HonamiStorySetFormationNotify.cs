using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000790 RID: 1936
	[NetMessage(EMessageId.HonamiStorySetFormationNotify)]
	public sealed class HonamiStorySetFormationNotify : IMessage<HonamiStorySetFormationNotify>, IMessage, IEquatable<HonamiStorySetFormationNotify>, IDeepCloneable<HonamiStorySetFormationNotify>, IBufferMessage
	{
		// Token: 0x0600AEF9 RID: 44793 RVA: 0x001A4465 File Offset: 0x001A2665
		[NullableContext(1)]
		public static HonamiStorySetFormationNotify Create()
		{
			return new HonamiStorySetFormationNotify();
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x001A446C File Offset: 0x001A266C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x0600AEFB RID: 44795 RVA: 0x001A446F File Offset: 0x001A266F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySetFormationNotify.Descriptor;
			}
		}

		// Token: 0x0600AEFC RID: 44796 RVA: 0x001A4476 File Offset: 0x001A2676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySetFormationNotify()
		{
		}

		// Token: 0x0600AEFD RID: 44797 RVA: 0x001A448C File Offset: 0x001A268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySetFormationNotify(HonamiStorySetFormationNotify other) : this()
		{
			this.equipRack_ = ((other.equipRack_ != null) ? other.equipRack_.Clone() : null);
			this.honamiStoryRackInfos_ = other.honamiStoryRackInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x001A44DD File Offset: 0x001A26DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySetFormationNotify Clone()
		{
			return new HonamiStorySetFormationNotify(this);
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x0600AEFF RID: 44799 RVA: 0x001A44E5 File Offset: 0x001A26E5
		// (set) Token: 0x0600AF00 RID: 44800 RVA: 0x001A44ED File Offset: 0x001A26ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo EquipRack
		{
			get
			{
				return this.equipRack_;
			}
			set
			{
				this.equipRack_ = value;
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x0600AF01 RID: 44801 RVA: 0x001A44F6 File Offset: 0x001A26F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryRackInfo> HonamiStoryRackInfos
		{
			get
			{
				return this.honamiStoryRackInfos_;
			}
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x001A44FE File Offset: 0x001A26FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySetFormationNotify);
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x001A450C File Offset: 0x001A270C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySetFormationNotify other)
		{
			return other != null && (other == this || (object.Equals(this.EquipRack, other.EquipRack) && this.honamiStoryRackInfos_.Equals(other.honamiStoryRackInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF04 RID: 44804 RVA: 0x001A4560 File Offset: 0x001A2760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.equipRack_ != null)
			{
				num ^= this.EquipRack.GetHashCode();
			}
			num ^= this.honamiStoryRackInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x001A45AA File Offset: 0x001A27AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF06 RID: 44806 RVA: 0x001A45B7 File Offset: 0x001A27B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF07 RID: 44807 RVA: 0x001A45C0 File Offset: 0x001A27C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.equipRack_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.EquipRack);
			}
			this.honamiStoryRackInfos_.WriteTo(ref output, HonamiStorySetFormationNotify._repeated_honamiStoryRackInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF08 RID: 44808 RVA: 0x001A4610 File Offset: 0x001A2810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.equipRack_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EquipRack);
			}
			num += this.honamiStoryRackInfos_.CalculateSize(HonamiStorySetFormationNotify._repeated_honamiStoryRackInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF09 RID: 44809 RVA: 0x001A4664 File Offset: 0x001A2864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStorySetFormationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.equipRack_ != null)
			{
				if (this.equipRack_ == null)
				{
					this.EquipRack = new HonamiStoryBagInfo();
				}
				this.EquipRack.MergeFrom(other.EquipRack);
			}
			this.honamiStoryRackInfos_.Add(other.honamiStoryRackInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF0A RID: 44810 RVA: 0x001A46C9 File Offset: 0x001A28C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x001A46D4 File Offset: 0x001A28D4
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
				if (num != 90U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.honamiStoryRackInfos_.AddEntriesFrom(ref input, HonamiStorySetFormationNotify._repeated_honamiStoryRackInfos_codec);
					}
				}
				else
				{
					if (this.equipRack_ == null)
					{
						this.EquipRack = new HonamiStoryBagInfo();
					}
					input.ReadMessage(this.EquipRack);
				}
			}
		}

		// Token: 0x04004F32 RID: 20274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F33 RID: 20275
		public const int EquipRackFieldNumber = 11;

		// Token: 0x04004F34 RID: 20276
		private HonamiStoryBagInfo equipRack_;

		// Token: 0x04004F35 RID: 20277
		public const int HonamiStoryRackInfosFieldNumber = 15;

		// Token: 0x04004F36 RID: 20278
		private static readonly FieldCodec<HonamiStoryRackInfo> _repeated_honamiStoryRackInfos_codec = FieldCodec.ForMessage<HonamiStoryRackInfo>(122U, HonamiStoryRackInfo.Parser);

		// Token: 0x04004F37 RID: 20279
		private readonly RepeatedField<HonamiStoryRackInfo> honamiStoryRackInfos_ = new RepeatedField<HonamiStoryRackInfo>();
	}
}
