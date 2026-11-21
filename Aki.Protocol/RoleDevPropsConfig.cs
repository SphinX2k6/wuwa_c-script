using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001058 RID: 4184
	public sealed class RoleDevPropsConfig : IMessage<RoleDevPropsConfig>, IMessage, IEquatable<RoleDevPropsConfig>, IDeepCloneable<RoleDevPropsConfig>, IBufferMessage
	{
		// Token: 0x0601661C RID: 91676 RVA: 0x0034133C File Offset: 0x0033F53C
		[NullableContext(1)]
		public static RoleDevPropsConfig Create()
		{
			return new RoleDevPropsConfig();
		}

		// Token: 0x17004AE8 RID: 19176
		// (get) Token: 0x0601661D RID: 91677 RVA: 0x00341343 File Offset: 0x0033F543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleDevPropsConfig> Parser
		{
			get
			{
				return RoleDevPropsConfig._parser;
			}
		}

		// Token: 0x17004AE9 RID: 19177
		// (get) Token: 0x0601661E RID: 91678 RVA: 0x0034134A File Offset: 0x0033F54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AEA RID: 19178
		// (get) Token: 0x0601661F RID: 91679 RVA: 0x0034134D File Offset: 0x0033F54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevPropsConfig.Descriptor;
			}
		}

		// Token: 0x06016620 RID: 91680 RVA: 0x00341354 File Offset: 0x0033F554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsConfig()
		{
		}

		// Token: 0x06016621 RID: 91681 RVA: 0x00341368 File Offset: 0x0033F568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsConfig(RoleDevPropsConfig other) : this()
		{
			this.id_ = other.id_;
			this.prospectBeginTime_ = other.prospectBeginTime_;
			this.prospectEndTime_ = other.prospectEndTime_;
			this.typeId_ = other.typeId_;
			this.gachaId_ = other.gachaId_;
			this.specialGachaPair_ = other.specialGachaPair_.Clone();
			this.sortId_ = other.sortId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016622 RID: 91682 RVA: 0x003413E5 File Offset: 0x0033F5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsConfig Clone()
		{
			return new RoleDevPropsConfig(this);
		}

		// Token: 0x17004AEB RID: 19179
		// (get) Token: 0x06016623 RID: 91683 RVA: 0x003413ED File Offset: 0x0033F5ED
		// (set) Token: 0x06016624 RID: 91684 RVA: 0x003413F5 File Offset: 0x0033F5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004AEC RID: 19180
		// (get) Token: 0x06016625 RID: 91685 RVA: 0x003413FE File Offset: 0x0033F5FE
		// (set) Token: 0x06016626 RID: 91686 RVA: 0x00341406 File Offset: 0x0033F606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ProspectBeginTime
		{
			get
			{
				return this.prospectBeginTime_;
			}
			set
			{
				this.prospectBeginTime_ = value;
			}
		}

		// Token: 0x17004AED RID: 19181
		// (get) Token: 0x06016627 RID: 91687 RVA: 0x0034140F File Offset: 0x0033F60F
		// (set) Token: 0x06016628 RID: 91688 RVA: 0x00341417 File Offset: 0x0033F617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ProspectEndTime
		{
			get
			{
				return this.prospectEndTime_;
			}
			set
			{
				this.prospectEndTime_ = value;
			}
		}

		// Token: 0x17004AEE RID: 19182
		// (get) Token: 0x06016629 RID: 91689 RVA: 0x00341420 File Offset: 0x0033F620
		// (set) Token: 0x0601662A RID: 91690 RVA: 0x00341428 File Offset: 0x0033F628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TypeId
		{
			get
			{
				return this.typeId_;
			}
			set
			{
				this.typeId_ = value;
			}
		}

		// Token: 0x17004AEF RID: 19183
		// (get) Token: 0x0601662B RID: 91691 RVA: 0x00341431 File Offset: 0x0033F631
		// (set) Token: 0x0601662C RID: 91692 RVA: 0x00341439 File Offset: 0x0033F639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17004AF0 RID: 19184
		// (get) Token: 0x0601662D RID: 91693 RVA: 0x00341442 File Offset: 0x0033F642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpecialGachaPair> SpecialGachaPair
		{
			get
			{
				return this.specialGachaPair_;
			}
		}

		// Token: 0x17004AF1 RID: 19185
		// (get) Token: 0x0601662E RID: 91694 RVA: 0x0034144A File Offset: 0x0033F64A
		// (set) Token: 0x0601662F RID: 91695 RVA: 0x00341452 File Offset: 0x0033F652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SortId
		{
			get
			{
				return this.sortId_;
			}
			set
			{
				this.sortId_ = value;
			}
		}

		// Token: 0x06016630 RID: 91696 RVA: 0x0034145B File Offset: 0x0033F65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevPropsConfig);
		}

		// Token: 0x06016631 RID: 91697 RVA: 0x0034146C File Offset: 0x0033F66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevPropsConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ProspectBeginTime == other.ProspectBeginTime && this.ProspectEndTime == other.ProspectEndTime && this.TypeId == other.TypeId && this.GachaId == other.GachaId && this.specialGachaPair_.Equals(other.specialGachaPair_) && this.SortId == other.SortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016632 RID: 91698 RVA: 0x0034150C File Offset: 0x0033F70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ProspectBeginTime != 0L)
			{
				num ^= this.ProspectBeginTime.GetHashCode();
			}
			if (this.ProspectEndTime != 0L)
			{
				num ^= this.ProspectEndTime.GetHashCode();
			}
			if (this.TypeId != 0)
			{
				num ^= this.TypeId.GetHashCode();
			}
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			num ^= this.specialGachaPair_.GetHashCode();
			if (this.SortId != 0)
			{
				num ^= this.SortId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016633 RID: 91699 RVA: 0x003415D6 File Offset: 0x0033F7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016634 RID: 91700 RVA: 0x003415E3 File Offset: 0x0033F7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016635 RID: 91701 RVA: 0x003415EC File Offset: 0x0033F7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.ProspectBeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ProspectBeginTime);
			}
			if (this.ProspectEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ProspectEndTime);
			}
			if (this.TypeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TypeId);
			}
			if (this.GachaId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GachaId);
			}
			this.specialGachaPair_.WriteTo(ref output, RoleDevPropsConfig._repeated_specialGachaPair_codec);
			if (this.SortId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016636 RID: 91702 RVA: 0x003416C8 File Offset: 0x0033F8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ProspectBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ProspectBeginTime);
			}
			if (this.ProspectEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ProspectEndTime);
			}
			if (this.TypeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TypeId);
			}
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			num += this.specialGachaPair_.CalculateSize(RoleDevPropsConfig._repeated_specialGachaPair_codec);
			if (this.SortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SortId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016637 RID: 91703 RVA: 0x00341794 File Offset: 0x0033F994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDevPropsConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ProspectBeginTime != 0L)
			{
				this.ProspectBeginTime = other.ProspectBeginTime;
			}
			if (other.ProspectEndTime != 0L)
			{
				this.ProspectEndTime = other.ProspectEndTime;
			}
			if (other.TypeId != 0)
			{
				this.TypeId = other.TypeId;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			this.specialGachaPair_.Add(other.specialGachaPair_);
			if (other.SortId != 0)
			{
				this.SortId = other.SortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016638 RID: 91704 RVA: 0x00341845 File Offset: 0x0033FA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016639 RID: 91705 RVA: 0x00341850 File Offset: 0x0033FA50
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
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ProspectBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.ProspectEndTime = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.TypeId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.GachaId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.specialGachaPair_.AddEntriesFrom(ref input, RoleDevPropsConfig._repeated_specialGachaPair_codec);
						continue;
					}
					if (num == 56U)
					{
						this.SortId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400864C RID: 34380
		private static readonly MessageParser<RoleDevPropsConfig> _parser = new MessageParser<RoleDevPropsConfig>(() => new RoleDevPropsConfig());

		// Token: 0x0400864D RID: 34381
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400864E RID: 34382
		public const int IdFieldNumber = 1;

		// Token: 0x0400864F RID: 34383
		private int id_;

		// Token: 0x04008650 RID: 34384
		public const int ProspectBeginTimeFieldNumber = 2;

		// Token: 0x04008651 RID: 34385
		private long prospectBeginTime_;

		// Token: 0x04008652 RID: 34386
		public const int ProspectEndTimeFieldNumber = 3;

		// Token: 0x04008653 RID: 34387
		private long prospectEndTime_;

		// Token: 0x04008654 RID: 34388
		public const int TypeIdFieldNumber = 4;

		// Token: 0x04008655 RID: 34389
		private int typeId_;

		// Token: 0x04008656 RID: 34390
		public const int GachaIdFieldNumber = 5;

		// Token: 0x04008657 RID: 34391
		private int gachaId_;

		// Token: 0x04008658 RID: 34392
		public const int SpecialGachaPairFieldNumber = 6;

		// Token: 0x04008659 RID: 34393
		private static readonly FieldCodec<SpecialGachaPair> _repeated_specialGachaPair_codec = FieldCodec.ForMessage<SpecialGachaPair>(50U, Aki.Protocol.SpecialGachaPair.Parser);

		// Token: 0x0400865A RID: 34394
		private readonly RepeatedField<SpecialGachaPair> specialGachaPair_ = new RepeatedField<SpecialGachaPair>();

		// Token: 0x0400865B RID: 34395
		public const int SortIdFieldNumber = 7;

		// Token: 0x0400865C RID: 34396
		private int sortId_;
	}
}
