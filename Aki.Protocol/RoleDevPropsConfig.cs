using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001068 RID: 4200
	public sealed class RoleDevPropsConfig : IMessage<RoleDevPropsConfig>, IMessage, IEquatable<RoleDevPropsConfig>, IDeepCloneable<RoleDevPropsConfig>, IBufferMessage
	{
		// Token: 0x06016701 RID: 91905 RVA: 0x00342A10 File Offset: 0x00340C10
		[NullableContext(1)]
		public static RoleDevPropsConfig Create()
		{
			return new RoleDevPropsConfig();
		}

		// Token: 0x17004B12 RID: 19218
		// (get) Token: 0x06016702 RID: 91906 RVA: 0x00342A17 File Offset: 0x00340C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleDevPropsConfig> Parser
		{
			get
			{
				return RoleDevPropsConfig._parser;
			}
		}

		// Token: 0x17004B13 RID: 19219
		// (get) Token: 0x06016703 RID: 91907 RVA: 0x00342A1E File Offset: 0x00340C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B14 RID: 19220
		// (get) Token: 0x06016704 RID: 91908 RVA: 0x00342A21 File Offset: 0x00340C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevPropsConfig.Descriptor;
			}
		}

		// Token: 0x06016705 RID: 91909 RVA: 0x00342A28 File Offset: 0x00340C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsConfig()
		{
		}

		// Token: 0x06016706 RID: 91910 RVA: 0x00342A3C File Offset: 0x00340C3C
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

		// Token: 0x06016707 RID: 91911 RVA: 0x00342AB9 File Offset: 0x00340CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsConfig Clone()
		{
			return new RoleDevPropsConfig(this);
		}

		// Token: 0x17004B15 RID: 19221
		// (get) Token: 0x06016708 RID: 91912 RVA: 0x00342AC1 File Offset: 0x00340CC1
		// (set) Token: 0x06016709 RID: 91913 RVA: 0x00342AC9 File Offset: 0x00340CC9
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

		// Token: 0x17004B16 RID: 19222
		// (get) Token: 0x0601670A RID: 91914 RVA: 0x00342AD2 File Offset: 0x00340CD2
		// (set) Token: 0x0601670B RID: 91915 RVA: 0x00342ADA File Offset: 0x00340CDA
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

		// Token: 0x17004B17 RID: 19223
		// (get) Token: 0x0601670C RID: 91916 RVA: 0x00342AE3 File Offset: 0x00340CE3
		// (set) Token: 0x0601670D RID: 91917 RVA: 0x00342AEB File Offset: 0x00340CEB
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

		// Token: 0x17004B18 RID: 19224
		// (get) Token: 0x0601670E RID: 91918 RVA: 0x00342AF4 File Offset: 0x00340CF4
		// (set) Token: 0x0601670F RID: 91919 RVA: 0x00342AFC File Offset: 0x00340CFC
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

		// Token: 0x17004B19 RID: 19225
		// (get) Token: 0x06016710 RID: 91920 RVA: 0x00342B05 File Offset: 0x00340D05
		// (set) Token: 0x06016711 RID: 91921 RVA: 0x00342B0D File Offset: 0x00340D0D
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

		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x06016712 RID: 91922 RVA: 0x00342B16 File Offset: 0x00340D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpecialGachaPair> SpecialGachaPair
		{
			get
			{
				return this.specialGachaPair_;
			}
		}

		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x06016713 RID: 91923 RVA: 0x00342B1E File Offset: 0x00340D1E
		// (set) Token: 0x06016714 RID: 91924 RVA: 0x00342B26 File Offset: 0x00340D26
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

		// Token: 0x06016715 RID: 91925 RVA: 0x00342B2F File Offset: 0x00340D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevPropsConfig);
		}

		// Token: 0x06016716 RID: 91926 RVA: 0x00342B40 File Offset: 0x00340D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevPropsConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ProspectBeginTime == other.ProspectBeginTime && this.ProspectEndTime == other.ProspectEndTime && this.TypeId == other.TypeId && this.GachaId == other.GachaId && this.specialGachaPair_.Equals(other.specialGachaPair_) && this.SortId == other.SortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016717 RID: 91927 RVA: 0x00342BE0 File Offset: 0x00340DE0
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

		// Token: 0x06016718 RID: 91928 RVA: 0x00342CAA File Offset: 0x00340EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016719 RID: 91929 RVA: 0x00342CB7 File Offset: 0x00340EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601671A RID: 91930 RVA: 0x00342CC0 File Offset: 0x00340EC0
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

		// Token: 0x0601671B RID: 91931 RVA: 0x00342D9C File Offset: 0x00340F9C
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

		// Token: 0x0601671C RID: 91932 RVA: 0x00342E68 File Offset: 0x00341068
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

		// Token: 0x0601671D RID: 91933 RVA: 0x00342F19 File Offset: 0x00341119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601671E RID: 91934 RVA: 0x00342F24 File Offset: 0x00341124
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

		// Token: 0x04008622 RID: 34338
		private static readonly MessageParser<RoleDevPropsConfig> _parser = new MessageParser<RoleDevPropsConfig>(() => new RoleDevPropsConfig());

		// Token: 0x04008623 RID: 34339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008624 RID: 34340
		public const int IdFieldNumber = 1;

		// Token: 0x04008625 RID: 34341
		private int id_;

		// Token: 0x04008626 RID: 34342
		public const int ProspectBeginTimeFieldNumber = 2;

		// Token: 0x04008627 RID: 34343
		private long prospectBeginTime_;

		// Token: 0x04008628 RID: 34344
		public const int ProspectEndTimeFieldNumber = 3;

		// Token: 0x04008629 RID: 34345
		private long prospectEndTime_;

		// Token: 0x0400862A RID: 34346
		public const int TypeIdFieldNumber = 4;

		// Token: 0x0400862B RID: 34347
		private int typeId_;

		// Token: 0x0400862C RID: 34348
		public const int GachaIdFieldNumber = 5;

		// Token: 0x0400862D RID: 34349
		private int gachaId_;

		// Token: 0x0400862E RID: 34350
		public const int SpecialGachaPairFieldNumber = 6;

		// Token: 0x0400862F RID: 34351
		private static readonly FieldCodec<SpecialGachaPair> _repeated_specialGachaPair_codec = FieldCodec.ForMessage<SpecialGachaPair>(50U, Aki.Protocol.SpecialGachaPair.Parser);

		// Token: 0x04008630 RID: 34352
		private readonly RepeatedField<SpecialGachaPair> specialGachaPair_ = new RepeatedField<SpecialGachaPair>();

		// Token: 0x04008631 RID: 34353
		public const int SortIdFieldNumber = 7;

		// Token: 0x04008632 RID: 34354
		private int sortId_;
	}
}
