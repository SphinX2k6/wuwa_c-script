using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D5 RID: 2261
	[NetMessage(EMessageId.KurotatoSystemInfoNotify)]
	public sealed class KurotatoSystemInfoNotify : IMessage<KurotatoSystemInfoNotify>, IMessage, IEquatable<KurotatoSystemInfoNotify>, IDeepCloneable<KurotatoSystemInfoNotify>, IBufferMessage
	{
		// Token: 0x0600C846 RID: 51270 RVA: 0x001D9D4C File Offset: 0x001D7F4C
		[NullableContext(1)]
		public static KurotatoSystemInfoNotify Create()
		{
			return new KurotatoSystemInfoNotify();
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x0600C847 RID: 51271 RVA: 0x001D9D53 File Offset: 0x001D7F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x0600C848 RID: 51272 RVA: 0x001D9D56 File Offset: 0x001D7F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSystemInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x001D9D5D File Offset: 0x001D7F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSystemInfoNotify()
		{
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x001D9D88 File Offset: 0x001D7F88
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

		// Token: 0x0600C84B RID: 51275 RVA: 0x001D9E2F File Offset: 0x001D802F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSystemInfoNotify Clone()
		{
			return new KurotatoSystemInfoNotify(this);
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x0600C84C RID: 51276 RVA: 0x001D9E37 File Offset: 0x001D8037
		// (set) Token: 0x0600C84D RID: 51277 RVA: 0x001D9E3F File Offset: 0x001D803F
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

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600C84E RID: 51278 RVA: 0x001D9E48 File Offset: 0x001D8048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> VariableKeyNames
		{
			get
			{
				return this.variableKeyNames_;
			}
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x0600C84F RID: 51279 RVA: 0x001D9E50 File Offset: 0x001D8050
		// (set) Token: 0x0600C850 RID: 51280 RVA: 0x001D9E58 File Offset: 0x001D8058
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

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x0600C851 RID: 51281 RVA: 0x001D9E61 File Offset: 0x001D8061
		// (set) Token: 0x0600C852 RID: 51282 RVA: 0x001D9E69 File Offset: 0x001D8069
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

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x0600C853 RID: 51283 RVA: 0x001D9E72 File Offset: 0x001D8072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyValues
		{
			get
			{
				return this.propertyValues_;
			}
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x0600C854 RID: 51284 RVA: 0x001D9E7A File Offset: 0x001D807A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LockedPropertyValues
		{
			get
			{
				return this.lockedPropertyValues_;
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x0600C855 RID: 51285 RVA: 0x001D9E82 File Offset: 0x001D8082
		// (set) Token: 0x0600C856 RID: 51286 RVA: 0x001D9E8A File Offset: 0x001D808A
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

		// Token: 0x0600C857 RID: 51287 RVA: 0x001D9E93 File Offset: 0x001D8093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSystemInfoNotify);
		}

		// Token: 0x0600C858 RID: 51288 RVA: 0x001D9EA4 File Offset: 0x001D80A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSystemInfoNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.VariableKeyNames.Equals(other.VariableKeyNames) && object.Equals(this.ItemPanelPbData, other.ItemPanelPbData) && object.Equals(this.WeaponPanelPbData, other.WeaponPanelPbData) && this.PropertyValues.Equals(other.PropertyValues) && this.LockedPropertyValues.Equals(other.LockedPropertyValues) && this.CharacterId == other.CharacterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C859 RID: 51289 RVA: 0x001D9F58 File Offset: 0x001D8158
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

		// Token: 0x0600C85A RID: 51290 RVA: 0x001DA006 File Offset: 0x001D8206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C85B RID: 51291 RVA: 0x001DA013 File Offset: 0x001D8213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C85C RID: 51292 RVA: 0x001DA01C File Offset: 0x001D821C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.weaponPanelPbData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.WeaponPanelPbData);
			}
			this.lockedPropertyValues_.WriteTo(ref output, KurotatoSystemInfoNotify._map_lockedPropertyValues_codec);
			this.propertyValues_.WriteTo(ref output, KurotatoSystemInfoNotify._map_propertyValues_codec);
			if (this.CharacterId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CharacterId);
			}
			if (this.itemPanelPbData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ItemPanelPbData);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LevelId);
			}
			this.variableKeyNames_.WriteTo(ref output, KurotatoSystemInfoNotify._map_variableKeyNames_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C85D RID: 51293 RVA: 0x001DA0E0 File Offset: 0x001D82E0
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

		// Token: 0x0600C85E RID: 51294 RVA: 0x001DA1A0 File Offset: 0x001D83A0
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

		// Token: 0x0600C85F RID: 51295 RVA: 0x001DA27B File Offset: 0x001D847B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C860 RID: 51296 RVA: 0x001DA284 File Offset: 0x001D8484
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
						if (this.weaponPanelPbData_ == null)
						{
							this.WeaponPanelPbData = new KurotatoWeaponPanelPbData();
						}
						input.ReadMessage(this.WeaponPanelPbData);
						continue;
					}
					if (num == 18U)
					{
						this.lockedPropertyValues_.AddEntriesFrom(ref input, KurotatoSystemInfoNotify._map_lockedPropertyValues_codec);
						continue;
					}
					if (num == 26U)
					{
						this.propertyValues_.AddEntriesFrom(ref input, KurotatoSystemInfoNotify._map_propertyValues_codec);
						continue;
					}
				}
				else if (num <= 58U)
				{
					if (num == 40U)
					{
						this.CharacterId = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.itemPanelPbData_ == null)
						{
							this.ItemPanelPbData = new KurotatoItemPanelPbData();
						}
						input.ReadMessage(this.ItemPanelPbData);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.variableKeyNames_.AddEntriesFrom(ref input, KurotatoSystemInfoNotify._map_variableKeyNames_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055A9 RID: 21929
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055AA RID: 21930
		public const int LevelIdFieldNumber = 11;

		// Token: 0x040055AB RID: 21931
		private int levelId_;

		// Token: 0x040055AC RID: 21932
		public const int VariableKeyNamesFieldNumber = 14;

		// Token: 0x040055AD RID: 21933
		private static readonly MapField<string, string>.Codec _map_variableKeyNames_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 114U);

		// Token: 0x040055AE RID: 21934
		private readonly MapField<string, string> variableKeyNames_ = new MapField<string, string>();

		// Token: 0x040055AF RID: 21935
		public const int ItemPanelPbDataFieldNumber = 7;

		// Token: 0x040055B0 RID: 21936
		private KurotatoItemPanelPbData itemPanelPbData_;

		// Token: 0x040055B1 RID: 21937
		public const int WeaponPanelPbDataFieldNumber = 1;

		// Token: 0x040055B2 RID: 21938
		private KurotatoWeaponPanelPbData weaponPanelPbData_;

		// Token: 0x040055B3 RID: 21939
		public const int PropertyValuesFieldNumber = 3;

		// Token: 0x040055B4 RID: 21940
		private static readonly MapField<int, int>.Codec _map_propertyValues_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040055B5 RID: 21941
		private readonly MapField<int, int> propertyValues_ = new MapField<int, int>();

		// Token: 0x040055B6 RID: 21942
		public const int LockedPropertyValuesFieldNumber = 2;

		// Token: 0x040055B7 RID: 21943
		private static readonly MapField<int, int>.Codec _map_lockedPropertyValues_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040055B8 RID: 21944
		private readonly MapField<int, int> lockedPropertyValues_ = new MapField<int, int>();

		// Token: 0x040055B9 RID: 21945
		public const int CharacterIdFieldNumber = 5;

		// Token: 0x040055BA RID: 21946
		private int characterId_;
	}
}
