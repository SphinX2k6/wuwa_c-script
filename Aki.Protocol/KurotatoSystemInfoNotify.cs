using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C4 RID: 2244
	[NetMessage(EMessageId.KurotatoSystemInfoNotify)]
	public sealed class KurotatoSystemInfoNotify : IMessage<KurotatoSystemInfoNotify>, IMessage, IEquatable<KurotatoSystemInfoNotify>, IDeepCloneable<KurotatoSystemInfoNotify>, IBufferMessage
	{
		// Token: 0x0600C72A RID: 50986 RVA: 0x001D7A68 File Offset: 0x001D5C68
		[NullableContext(1)]
		public static KurotatoSystemInfoNotify Create()
		{
			return new KurotatoSystemInfoNotify();
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600C72B RID: 50987 RVA: 0x001D7A6F File Offset: 0x001D5C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x0600C72C RID: 50988 RVA: 0x001D7A72 File Offset: 0x001D5C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSystemInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600C72D RID: 50989 RVA: 0x001D7A79 File Offset: 0x001D5C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSystemInfoNotify()
		{
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x001D7AA4 File Offset: 0x001D5CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSystemInfoNotify(KurotatoSystemInfoNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.variableKeyNames_ = other.variableKeyNames_.Clone();
			this.itemPanelPbData_ = ((other.itemPanelPbData_ != null) ? other.itemPanelPbData_.Clone() : null);
			this.weaponPanelPbData_ = ((other.weaponPanelPbData_ != null) ? other.weaponPanelPbData_.Clone() : null);
			this.propertyValues_ = other.propertyValues_.Clone();
			this.lockedPropertyValues_ = other.lockedPropertyValues_.Clone();
			this.characterId_ = other.characterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C72F RID: 50991 RVA: 0x001D7B4B File Offset: 0x001D5D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSystemInfoNotify Clone()
		{
			return new KurotatoSystemInfoNotify(this);
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x0600C730 RID: 50992 RVA: 0x001D7B53 File Offset: 0x001D5D53
		// (set) Token: 0x0600C731 RID: 50993 RVA: 0x001D7B5B File Offset: 0x001D5D5B
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

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x0600C732 RID: 50994 RVA: 0x001D7B64 File Offset: 0x001D5D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> VariableKeyNames
		{
			get
			{
				return this.variableKeyNames_;
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x0600C733 RID: 50995 RVA: 0x001D7B6C File Offset: 0x001D5D6C
		// (set) Token: 0x0600C734 RID: 50996 RVA: 0x001D7B74 File Offset: 0x001D5D74
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

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x0600C735 RID: 50997 RVA: 0x001D7B7D File Offset: 0x001D5D7D
		// (set) Token: 0x0600C736 RID: 50998 RVA: 0x001D7B85 File Offset: 0x001D5D85
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

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x0600C737 RID: 50999 RVA: 0x001D7B8E File Offset: 0x001D5D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyValues
		{
			get
			{
				return this.propertyValues_;
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x0600C738 RID: 51000 RVA: 0x001D7B96 File Offset: 0x001D5D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LockedPropertyValues
		{
			get
			{
				return this.lockedPropertyValues_;
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600C739 RID: 51001 RVA: 0x001D7B9E File Offset: 0x001D5D9E
		// (set) Token: 0x0600C73A RID: 51002 RVA: 0x001D7BA6 File Offset: 0x001D5DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CharacterId
		{
			get
			{
				return this.characterId_;
			}
			set
			{
				this.characterId_ = value;
			}
		}

		// Token: 0x0600C73B RID: 51003 RVA: 0x001D7BAF File Offset: 0x001D5DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSystemInfoNotify);
		}

		// Token: 0x0600C73C RID: 51004 RVA: 0x001D7BC0 File Offset: 0x001D5DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSystemInfoNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.VariableKeyNames.Equals(other.VariableKeyNames) && object.Equals(this.ItemPanelPbData, other.ItemPanelPbData) && object.Equals(this.WeaponPanelPbData, other.WeaponPanelPbData) && this.PropertyValues.Equals(other.PropertyValues) && this.LockedPropertyValues.Equals(other.LockedPropertyValues) && this.CharacterId == other.CharacterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C73D RID: 51005 RVA: 0x001D7C74 File Offset: 0x001D5E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.VariableKeyNames.GetHashCode();
			if (this.itemPanelPbData_ != null)
			{
				num ^= this.ItemPanelPbData.GetHashCode();
			}
			if (this.weaponPanelPbData_ != null)
			{
				num ^= this.WeaponPanelPbData.GetHashCode();
			}
			num ^= this.PropertyValues.GetHashCode();
			num ^= this.LockedPropertyValues.GetHashCode();
			if (this.CharacterId != 0)
			{
				num ^= this.CharacterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C73E RID: 51006 RVA: 0x001D7D22 File Offset: 0x001D5F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C73F RID: 51007 RVA: 0x001D7D2F File Offset: 0x001D5F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C740 RID: 51008 RVA: 0x001D7D38 File Offset: 0x001D5F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.variableKeyNames_.WriteTo(ref output, KurotatoSystemInfoNotify._map_variableKeyNames_codec);
			if (this.weaponPanelPbData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.WeaponPanelPbData);
			}
			if (this.itemPanelPbData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ItemPanelPbData);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LevelId);
			}
			if (this.CharacterId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CharacterId);
			}
			this.lockedPropertyValues_.WriteTo(ref output, KurotatoSystemInfoNotify._map_lockedPropertyValues_codec);
			this.propertyValues_.WriteTo(ref output, KurotatoSystemInfoNotify._map_propertyValues_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C741 RID: 51009 RVA: 0x001D7DFC File Offset: 0x001D5FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.variableKeyNames_.CalculateSize(KurotatoSystemInfoNotify._map_variableKeyNames_codec);
			if (this.itemPanelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemPanelPbData);
			}
			if (this.weaponPanelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WeaponPanelPbData);
			}
			num += this.propertyValues_.CalculateSize(KurotatoSystemInfoNotify._map_propertyValues_codec);
			num += this.lockedPropertyValues_.CalculateSize(KurotatoSystemInfoNotify._map_lockedPropertyValues_codec);
			if (this.CharacterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CharacterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C742 RID: 51010 RVA: 0x001D7EBC File Offset: 0x001D60BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSystemInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.variableKeyNames_.MergeFrom(other.variableKeyNames_);
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
			this.propertyValues_.MergeFrom(other.propertyValues_);
			this.lockedPropertyValues_.MergeFrom(other.lockedPropertyValues_);
			if (other.CharacterId != 0)
			{
				this.CharacterId = other.CharacterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C743 RID: 51011 RVA: 0x001D7F97 File Offset: 0x001D6197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C744 RID: 51012 RVA: 0x001D7FA0 File Offset: 0x001D61A0
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.variableKeyNames_.AddEntriesFrom(ref input, KurotatoSystemInfoNotify._map_variableKeyNames_codec);
						continue;
					}
					if (num == 18U)
					{
						if (this.weaponPanelPbData_ == null)
						{
							this.WeaponPanelPbData = new KurotatoWeaponPanelPbData();
						}
						input.ReadMessage(this.WeaponPanelPbData);
						continue;
					}
					if (num == 26U)
					{
						if (this.itemPanelPbData_ == null)
						{
							this.ItemPanelPbData = new KurotatoItemPanelPbData();
						}
						input.ReadMessage(this.ItemPanelPbData);
						continue;
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CharacterId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.lockedPropertyValues_.AddEntriesFrom(ref input, KurotatoSystemInfoNotify._map_lockedPropertyValues_codec);
						continue;
					}
					if (num == 90U)
					{
						this.propertyValues_.AddEntriesFrom(ref input, KurotatoSystemInfoNotify._map_propertyValues_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055B0 RID: 21936
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055B1 RID: 21937
		public const int LevelIdFieldNumber = 6;

		// Token: 0x040055B2 RID: 21938
		private int levelId_;

		// Token: 0x040055B3 RID: 21939
		public const int VariableKeyNamesFieldNumber = 1;

		// Token: 0x040055B4 RID: 21940
		private static readonly MapField<string, string>.Codec _map_variableKeyNames_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 10U);

		// Token: 0x040055B5 RID: 21941
		private readonly MapField<string, string> variableKeyNames_ = new MapField<string, string>();

		// Token: 0x040055B6 RID: 21942
		public const int ItemPanelPbDataFieldNumber = 3;

		// Token: 0x040055B7 RID: 21943
		private KurotatoItemPanelPbData itemPanelPbData_;

		// Token: 0x040055B8 RID: 21944
		public const int WeaponPanelPbDataFieldNumber = 2;

		// Token: 0x040055B9 RID: 21945
		private KurotatoWeaponPanelPbData weaponPanelPbData_;

		// Token: 0x040055BA RID: 21946
		public const int PropertyValuesFieldNumber = 11;

		// Token: 0x040055BB RID: 21947
		private static readonly MapField<int, int>.Codec _map_propertyValues_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 90U);

		// Token: 0x040055BC RID: 21948
		private readonly MapField<int, int> propertyValues_ = new MapField<int, int>();

		// Token: 0x040055BD RID: 21949
		public const int LockedPropertyValuesFieldNumber = 10;

		// Token: 0x040055BE RID: 21950
		private static readonly MapField<int, int>.Codec _map_lockedPropertyValues_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 82U);

		// Token: 0x040055BF RID: 21951
		private readonly MapField<int, int> lockedPropertyValues_ = new MapField<int, int>();

		// Token: 0x040055C0 RID: 21952
		public const int CharacterIdFieldNumber = 8;

		// Token: 0x040055C1 RID: 21953
		private int characterId_;
	}
}
