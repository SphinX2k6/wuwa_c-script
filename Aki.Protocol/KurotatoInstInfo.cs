using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000888 RID: 2184
	public sealed class KurotatoInstInfo : IMessage<KurotatoInstInfo>, IMessage, IEquatable<KurotatoInstInfo>, IDeepCloneable<KurotatoInstInfo>, IBufferMessage
	{
		// Token: 0x0600C273 RID: 49779 RVA: 0x001CD8B1 File Offset: 0x001CBAB1
		[NullableContext(1)]
		public static KurotatoInstInfo Create()
		{
			return new KurotatoInstInfo();
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x0600C274 RID: 49780 RVA: 0x001CD8B8 File Offset: 0x001CBAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoInstInfo> Parser
		{
			get
			{
				return KurotatoInstInfo._parser;
			}
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x0600C275 RID: 49781 RVA: 0x001CD8BF File Offset: 0x001CBABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x0600C276 RID: 49782 RVA: 0x001CD8C2 File Offset: 0x001CBAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoInstInfo.Descriptor;
			}
		}

		// Token: 0x0600C277 RID: 49783 RVA: 0x001CD8C9 File Offset: 0x001CBAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoInstInfo()
		{
		}

		// Token: 0x0600C278 RID: 49784 RVA: 0x001CD8DC File Offset: 0x001CBADC
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

		// Token: 0x0600C279 RID: 49785 RVA: 0x001CD99D File Offset: 0x001CBB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoInstInfo Clone()
		{
			return new KurotatoInstInfo(this);
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x0600C27A RID: 49786 RVA: 0x001CD9A5 File Offset: 0x001CBBA5
		// (set) Token: 0x0600C27B RID: 49787 RVA: 0x001CD9AD File Offset: 0x001CBBAD
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

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x0600C27C RID: 49788 RVA: 0x001CD9B6 File Offset: 0x001CBBB6
		// (set) Token: 0x0600C27D RID: 49789 RVA: 0x001CD9BE File Offset: 0x001CBBBE
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

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x0600C27E RID: 49790 RVA: 0x001CD9C7 File Offset: 0x001CBBC7
		// (set) Token: 0x0600C27F RID: 49791 RVA: 0x001CD9CF File Offset: 0x001CBBCF
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

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x0600C280 RID: 49792 RVA: 0x001CD9D8 File Offset: 0x001CBBD8
		// (set) Token: 0x0600C281 RID: 49793 RVA: 0x001CD9E0 File Offset: 0x001CBBE0
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

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x0600C282 RID: 49794 RVA: 0x001CD9E9 File Offset: 0x001CBBE9
		// (set) Token: 0x0600C283 RID: 49795 RVA: 0x001CD9F1 File Offset: 0x001CBBF1
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

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x0600C284 RID: 49796 RVA: 0x001CD9FA File Offset: 0x001CBBFA
		// (set) Token: 0x0600C285 RID: 49797 RVA: 0x001CDA02 File Offset: 0x001CBC02
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

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x0600C286 RID: 49798 RVA: 0x001CDA0B File Offset: 0x001CBC0B
		// (set) Token: 0x0600C287 RID: 49799 RVA: 0x001CDA13 File Offset: 0x001CBC13
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

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x0600C288 RID: 49800 RVA: 0x001CDA1C File Offset: 0x001CBC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyMap
		{
			get
			{
				return this.propertyMap_;
			}
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x0600C289 RID: 49801 RVA: 0x001CDA24 File Offset: 0x001CBC24
		// (set) Token: 0x0600C28A RID: 49802 RVA: 0x001CDA2C File Offset: 0x001CBC2C
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

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x0600C28B RID: 49803 RVA: 0x001CDA35 File Offset: 0x001CBC35
		// (set) Token: 0x0600C28C RID: 49804 RVA: 0x001CDA3D File Offset: 0x001CBC3D
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

		// Token: 0x0600C28D RID: 49805 RVA: 0x001CDA46 File Offset: 0x001CBC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoInstInfo);
		}

		// Token: 0x0600C28E RID: 49806 RVA: 0x001CDA54 File Offset: 0x001CBC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoInstInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.CurWave == other.CurWave && this.RoleId == other.RoleId && this.RoleLevel == other.RoleLevel && this.RoleExp == other.RoleExp && object.Equals(this.ItemPanelPbData, other.ItemPanelPbData) && object.Equals(this.WeaponPanelPbData, other.WeaponPanelPbData) && this.PropertyMap.Equals(other.PropertyMap) && this.SaveTimestamp == other.SaveTimestamp && this.WaveType == other.WaveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C28F RID: 49807 RVA: 0x001CDB2C File Offset: 0x001CBD2C
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

		// Token: 0x0600C290 RID: 49808 RVA: 0x001CDC3B File Offset: 0x001CBE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C291 RID: 49809 RVA: 0x001CDC48 File Offset: 0x001CBE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C292 RID: 49810 RVA: 0x001CDC54 File Offset: 0x001CBE54
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

		// Token: 0x0600C293 RID: 49811 RVA: 0x001CDD84 File Offset: 0x001CBF84
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

		// Token: 0x0600C294 RID: 49812 RVA: 0x001CDE98 File Offset: 0x001CC098
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

		// Token: 0x0600C295 RID: 49813 RVA: 0x001CDFB5 File Offset: 0x001CC1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C296 RID: 49814 RVA: 0x001CDFC0 File Offset: 0x001CC1C0
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

		// Token: 0x04005474 RID: 21620
		private static readonly MessageParser<KurotatoInstInfo> _parser = new MessageParser<KurotatoInstInfo>(() => new KurotatoInstInfo());

		// Token: 0x04005475 RID: 21621
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005476 RID: 21622
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005477 RID: 21623
		private int levelId_;

		// Token: 0x04005478 RID: 21624
		public const int CurWaveFieldNumber = 2;

		// Token: 0x04005479 RID: 21625
		private int curWave_;

		// Token: 0x0400547A RID: 21626
		public const int RoleIdFieldNumber = 3;

		// Token: 0x0400547B RID: 21627
		private int roleId_;

		// Token: 0x0400547C RID: 21628
		public const int RoleLevelFieldNumber = 4;

		// Token: 0x0400547D RID: 21629
		private int roleLevel_;

		// Token: 0x0400547E RID: 21630
		public const int RoleExpFieldNumber = 5;

		// Token: 0x0400547F RID: 21631
		private int roleExp_;

		// Token: 0x04005480 RID: 21632
		public const int ItemPanelPbDataFieldNumber = 6;

		// Token: 0x04005481 RID: 21633
		private KurotatoItemPanelPbData itemPanelPbData_;

		// Token: 0x04005482 RID: 21634
		public const int WeaponPanelPbDataFieldNumber = 7;

		// Token: 0x04005483 RID: 21635
		private KurotatoWeaponPanelPbData weaponPanelPbData_;

		// Token: 0x04005484 RID: 21636
		public const int PropertyMapFieldNumber = 8;

		// Token: 0x04005485 RID: 21637
		private static readonly MapField<int, int>.Codec _map_propertyMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x04005486 RID: 21638
		private readonly MapField<int, int> propertyMap_ = new MapField<int, int>();

		// Token: 0x04005487 RID: 21639
		public const int SaveTimestampFieldNumber = 9;

		// Token: 0x04005488 RID: 21640
		private long saveTimestamp_;

		// Token: 0x04005489 RID: 21641
		public const int WaveTypeFieldNumber = 10;

		// Token: 0x0400548A RID: 21642
		private int waveType_;
	}
}
