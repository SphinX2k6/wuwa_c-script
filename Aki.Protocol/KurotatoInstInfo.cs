using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000899 RID: 2201
	public sealed class KurotatoInstInfo : IMessage<KurotatoInstInfo>, IMessage, IEquatable<KurotatoInstInfo>, IDeepCloneable<KurotatoInstInfo>, IBufferMessage
	{
		// Token: 0x0600C38F RID: 50063 RVA: 0x001CFB94 File Offset: 0x001CDD94
		[NullableContext(1)]
		public static KurotatoInstInfo Create()
		{
			return new KurotatoInstInfo();
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x0600C390 RID: 50064 RVA: 0x001CFB9B File Offset: 0x001CDD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoInstInfo> Parser
		{
			get
			{
				return KurotatoInstInfo._parser;
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x0600C391 RID: 50065 RVA: 0x001CFBA2 File Offset: 0x001CDDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x0600C392 RID: 50066 RVA: 0x001CFBA5 File Offset: 0x001CDDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoInstInfo.Descriptor;
			}
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x001CFBAC File Offset: 0x001CDDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoInstInfo()
		{
		}

		// Token: 0x0600C394 RID: 50068 RVA: 0x001CFBC0 File Offset: 0x001CDDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoInstInfo(KurotatoInstInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.curWave_ = other.curWave_;
			this.roleId_ = other.roleId_;
			this.roleLevel_ = other.roleLevel_;
			this.roleExp_ = other.roleExp_;
			this.itemPanelPbData_ = ((other.itemPanelPbData_ != null) ? other.itemPanelPbData_.Clone() : null);
			this.weaponPanelPbData_ = ((other.weaponPanelPbData_ != null) ? other.weaponPanelPbData_.Clone() : null);
			this.propertyMap_ = other.propertyMap_.Clone();
			this.saveTimestamp_ = other.saveTimestamp_;
			this.waveType_ = other.waveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x001CFC81 File Offset: 0x001CDE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoInstInfo Clone()
		{
			return new KurotatoInstInfo(this);
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x0600C396 RID: 50070 RVA: 0x001CFC89 File Offset: 0x001CDE89
		// (set) Token: 0x0600C397 RID: 50071 RVA: 0x001CFC91 File Offset: 0x001CDE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600C398 RID: 50072 RVA: 0x001CFC9A File Offset: 0x001CDE9A
		// (set) Token: 0x0600C399 RID: 50073 RVA: 0x001CFCA2 File Offset: 0x001CDEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWave
		{
			get
			{
				return this.curWave_;
			}
			set
			{
				this.curWave_ = value;
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x0600C39A RID: 50074 RVA: 0x001CFCAB File Offset: 0x001CDEAB
		// (set) Token: 0x0600C39B RID: 50075 RVA: 0x001CFCB3 File Offset: 0x001CDEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600C39C RID: 50076 RVA: 0x001CFCBC File Offset: 0x001CDEBC
		// (set) Token: 0x0600C39D RID: 50077 RVA: 0x001CFCC4 File Offset: 0x001CDEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x0600C39E RID: 50078 RVA: 0x001CFCCD File Offset: 0x001CDECD
		// (set) Token: 0x0600C39F RID: 50079 RVA: 0x001CFCD5 File Offset: 0x001CDED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleExp
		{
			get
			{
				return this.roleExp_;
			}
			set
			{
				this.roleExp_ = value;
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x0600C3A0 RID: 50080 RVA: 0x001CFCDE File Offset: 0x001CDEDE
		// (set) Token: 0x0600C3A1 RID: 50081 RVA: 0x001CFCE6 File Offset: 0x001CDEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData ItemPanelPbData
		{
			get
			{
				return this.itemPanelPbData_;
			}
			set
			{
				this.itemPanelPbData_ = value;
			}
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x0600C3A2 RID: 50082 RVA: 0x001CFCEF File Offset: 0x001CDEEF
		// (set) Token: 0x0600C3A3 RID: 50083 RVA: 0x001CFCF7 File Offset: 0x001CDEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData WeaponPanelPbData
		{
			get
			{
				return this.weaponPanelPbData_;
			}
			set
			{
				this.weaponPanelPbData_ = value;
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x0600C3A4 RID: 50084 RVA: 0x001CFD00 File Offset: 0x001CDF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyMap
		{
			get
			{
				return this.propertyMap_;
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x0600C3A5 RID: 50085 RVA: 0x001CFD08 File Offset: 0x001CDF08
		// (set) Token: 0x0600C3A6 RID: 50086 RVA: 0x001CFD10 File Offset: 0x001CDF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SaveTimestamp
		{
			get
			{
				return this.saveTimestamp_;
			}
			set
			{
				this.saveTimestamp_ = value;
			}
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x0600C3A7 RID: 50087 RVA: 0x001CFD19 File Offset: 0x001CDF19
		// (set) Token: 0x0600C3A8 RID: 50088 RVA: 0x001CFD21 File Offset: 0x001CDF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveType
		{
			get
			{
				return this.waveType_;
			}
			set
			{
				this.waveType_ = value;
			}
		}

		// Token: 0x0600C3A9 RID: 50089 RVA: 0x001CFD2A File Offset: 0x001CDF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoInstInfo);
		}

		// Token: 0x0600C3AA RID: 50090 RVA: 0x001CFD38 File Offset: 0x001CDF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoInstInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.CurWave == other.CurWave && this.RoleId == other.RoleId && this.RoleLevel == other.RoleLevel && this.RoleExp == other.RoleExp && object.Equals(this.ItemPanelPbData, other.ItemPanelPbData) && object.Equals(this.WeaponPanelPbData, other.WeaponPanelPbData) && this.PropertyMap.Equals(other.PropertyMap) && this.SaveTimestamp == other.SaveTimestamp && this.WaveType == other.WaveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x001CFE10 File Offset: 0x001CE010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.CurWave != 0)
			{
				num ^= this.CurWave.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.RoleExp != 0)
			{
				num ^= this.RoleExp.GetHashCode();
			}
			if (this.itemPanelPbData_ != null)
			{
				num ^= this.ItemPanelPbData.GetHashCode();
			}
			if (this.weaponPanelPbData_ != null)
			{
				num ^= this.WeaponPanelPbData.GetHashCode();
			}
			num ^= this.PropertyMap.GetHashCode();
			if (this.SaveTimestamp != 0L)
			{
				num ^= this.SaveTimestamp.GetHashCode();
			}
			if (this.WaveType != 0)
			{
				num ^= this.WaveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3AC RID: 50092 RVA: 0x001CFF1F File Offset: 0x001CE11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x001CFF2C File Offset: 0x001CE12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x001CFF38 File Offset: 0x001CE138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.CurWave != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurWave);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.RoleExp != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleExp);
			}
			if (this.itemPanelPbData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ItemPanelPbData);
			}
			if (this.weaponPanelPbData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.WeaponPanelPbData);
			}
			this.propertyMap_.WriteTo(ref output, KurotatoInstInfo._map_propertyMap_codec);
			if (this.SaveTimestamp != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.SaveTimestamp);
			}
			if (this.WaveType != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.WaveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x001D0068 File Offset: 0x001CE268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.CurWave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWave);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.RoleExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleExp);
			}
			if (this.itemPanelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemPanelPbData);
			}
			if (this.weaponPanelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WeaponPanelPbData);
			}
			num += this.propertyMap_.CalculateSize(KurotatoInstInfo._map_propertyMap_codec);
			if (this.SaveTimestamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SaveTimestamp);
			}
			if (this.WaveType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x001D017C File Offset: 0x001CE37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoInstInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.CurWave != 0)
			{
				this.CurWave = other.CurWave;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.RoleExp != 0)
			{
				this.RoleExp = other.RoleExp;
			}
			if (other.itemPanelPbData_ != null)
			{
				if (this.itemPanelPbData_ == null)
				{
					this.ItemPanelPbData = new KurotatoItemPanelPbData();
				}
				this.ItemPanelPbData.MergeFrom(other.ItemPanelPbData);
			}
			if (other.weaponPanelPbData_ != null)
			{
				if (this.weaponPanelPbData_ == null)
				{
					this.WeaponPanelPbData = new KurotatoWeaponPanelPbData();
				}
				this.WeaponPanelPbData.MergeFrom(other.WeaponPanelPbData);
			}
			this.propertyMap_.MergeFrom(other.propertyMap_);
			if (other.SaveTimestamp != 0L)
			{
				this.SaveTimestamp = other.SaveTimestamp;
			}
			if (other.WaveType != 0)
			{
				this.WaveType = other.WaveType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3B1 RID: 50097 RVA: 0x001D0299 File Offset: 0x001CE499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3B2 RID: 50098 RVA: 0x001D02A4 File Offset: 0x001CE4A4
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
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.LevelId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.CurWave = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.RoleId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.RoleLevel = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.RoleExp = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						if (this.itemPanelPbData_ == null)
						{
							this.ItemPanelPbData = new KurotatoItemPanelPbData();
						}
						input.ReadMessage(this.ItemPanelPbData);
						continue;
					}
					if (num == 58U)
					{
						if (this.weaponPanelPbData_ == null)
						{
							this.WeaponPanelPbData = new KurotatoWeaponPanelPbData();
						}
						input.ReadMessage(this.WeaponPanelPbData);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.propertyMap_.AddEntriesFrom(ref input, KurotatoInstInfo._map_propertyMap_codec);
						continue;
					}
					if (num == 72U)
					{
						this.SaveTimestamp = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.WaveType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400546D RID: 21613
		private static readonly MessageParser<KurotatoInstInfo> _parser = new MessageParser<KurotatoInstInfo>(() => new KurotatoInstInfo());

		// Token: 0x0400546E RID: 21614
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400546F RID: 21615
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005470 RID: 21616
		private int levelId_;

		// Token: 0x04005471 RID: 21617
		public const int CurWaveFieldNumber = 2;

		// Token: 0x04005472 RID: 21618
		private int curWave_;

		// Token: 0x04005473 RID: 21619
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04005474 RID: 21620
		private int roleId_;

		// Token: 0x04005475 RID: 21621
		public const int RoleLevelFieldNumber = 4;

		// Token: 0x04005476 RID: 21622
		private int roleLevel_;

		// Token: 0x04005477 RID: 21623
		public const int RoleExpFieldNumber = 5;

		// Token: 0x04005478 RID: 21624
		private int roleExp_;

		// Token: 0x04005479 RID: 21625
		public const int ItemPanelPbDataFieldNumber = 6;

		// Token: 0x0400547A RID: 21626
		private KurotatoItemPanelPbData itemPanelPbData_;

		// Token: 0x0400547B RID: 21627
		public const int WeaponPanelPbDataFieldNumber = 7;

		// Token: 0x0400547C RID: 21628
		private KurotatoWeaponPanelPbData weaponPanelPbData_;

		// Token: 0x0400547D RID: 21629
		public const int PropertyMapFieldNumber = 8;

		// Token: 0x0400547E RID: 21630
		private static readonly MapField<int, int>.Codec _map_propertyMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x0400547F RID: 21631
		private readonly MapField<int, int> propertyMap_ = new MapField<int, int>();

		// Token: 0x04005480 RID: 21632
		public const int SaveTimestampFieldNumber = 9;

		// Token: 0x04005481 RID: 21633
		private long saveTimestamp_;

		// Token: 0x04005482 RID: 21634
		public const int WaveTypeFieldNumber = 10;

		// Token: 0x04005483 RID: 21635
		private int waveType_;
	}
}
