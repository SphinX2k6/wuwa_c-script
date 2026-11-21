using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B87 RID: 15239
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class SkinConfig : ConfigBase
	{
		// Token: 0x060270DC RID: 159964 RVA: 0x00AEED2C File Offset: 0x00AECF2C
		public WeaponSkin GetWeaponSkinConfig(int id)
		{
			return ConfigWeaponSkinById.GetConfig(id, true).Value;
		}

		// Token: 0x060270DD RID: 159965 RVA: 0x00AEED48 File Offset: 0x00AECF48
		public IReadOnlyList<WeaponSkin> GetWeaponSkinConfigListByType(int type)
		{
			return ConfigWeaponSkinByType.GetConfigList(type, true);
		}

		// Token: 0x060270DE RID: 159966 RVA: 0x00AEED51 File Offset: 0x00AECF51
		public string GetDefaultWeaponSkinIconPath()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalWeaponSkinIcon");
		}

		// Token: 0x060270DF RID: 159967 RVA: 0x00AEED5D File Offset: 0x00AECF5D
		public string GetDefaultWeaponSkinName()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalWeaponSkinName");
		}

		// Token: 0x060270E0 RID: 159968 RVA: 0x00AEED69 File Offset: 0x00AECF69
		public string GetDefaultWeaponSkinDescription()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalWeaponSkinDescription");
		}

		// Token: 0x060270E1 RID: 159969 RVA: 0x00AEED75 File Offset: 0x00AECF75
		public string GetDefaultFlySkinIconPath(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalParaglidingSkinIcon");
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalSoarWingIcon");
			}
			return "";
		}

		// Token: 0x060270E2 RID: 159970 RVA: 0x00AEED99 File Offset: 0x00AECF99
		public string GetDefaultFlySkinName(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalParaglidingSkinName");
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalSoarWingSkinName");
			}
			return "";
		}

		// Token: 0x060270E3 RID: 159971 RVA: 0x00AEEDBD File Offset: 0x00AECFBD
		public string GetDefaultFlySkinDescription(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalParaglidingSkinDescription");
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalSoarWingSkinDescription");
			}
			return "";
		}

		// Token: 0x060270E4 RID: 159972 RVA: 0x00AEEDE1 File Offset: 0x00AECFE1
		public string GetDefaultFlySkinTypeDescription(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalParaglidingSkinTypeDesc");
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalSoarWingSkinTypeDesc");
			}
			return "";
		}

		// Token: 0x060270E5 RID: 159973 RVA: 0x00AEEE05 File Offset: 0x00AED005
		public string GetDefaultFlySkinStandAnimPath(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalParaglidingSkinStandAnim");
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return ConfigCommonParamById.GetStringConfig("OriginalSoarWingSkinStandAnim");
			}
			return "";
		}

		// Token: 0x060270E6 RID: 159974 RVA: 0x00AEEE2C File Offset: 0x00AED02C
		public int GetDefaultFlySkinModelId(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return ConfigCommonParamById.GetIntConfig("OriginalParaglidingSkinModelId").Value;
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return ConfigCommonParamById.GetIntConfig("OriginalSoarWingSkinModelId").Value;
			}
			return 0;
		}

		// Token: 0x060270E7 RID: 159975 RVA: 0x00AEEE68 File Offset: 0x00AED068
		[NullableContext(2)]
		public float[] GetFlySkinModelOffsetTransform(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("ParaglidingSkinOffsetTransform");
				if (floatArrayConfig != null)
				{
					return NoLinq.ToArray<float>(floatArrayConfig);
				}
				return null;
			}
			else
			{
				if (skinType != EFlySkinType.SoarWing)
				{
					return null;
				}
				IReadOnlyList<float> floatArrayConfig2 = ConfigCommonParamById.GetFloatArrayConfig("SoarWingSkinOffsetTransform");
				if (floatArrayConfig2 != null)
				{
					return NoLinq.ToArray<float>(floatArrayConfig2);
				}
				return null;
			}
		}

		// Token: 0x060270E8 RID: 159976 RVA: 0x00AEEEAB File Offset: 0x00AED0AB
		public string GetFlySkinModelCameraId(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return ConfigCommonParamById.GetStringConfig("ParaglidingSkinCameraId");
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return ConfigCommonParamById.GetStringConfig("SoarWingSkinCameraId");
			}
			return "";
		}

		// Token: 0x060270E9 RID: 159977 RVA: 0x00AEEECF File Offset: 0x00AED0CF
		public string GetFlySkinTabName(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return "Text_ParaglidingSkinTab_Text";
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return "Text_SoarWingSkinTab_Text";
			}
			return "";
		}

		// Token: 0x060270EA RID: 159978 RVA: 0x00AEEEE9 File Offset: 0x00AED0E9
		public string GetFlySkinBottomIconResourceId(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return "T_IconParagliding";
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return "T_IconSoarWing";
			}
			return "";
		}

		// Token: 0x060270EB RID: 159979 RVA: 0x00AEEF03 File Offset: 0x00AED103
		public string GetFlySkinEquipBtnTextId(EFlySkinType skinType, bool canEquip)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				if (!canEquip)
				{
					return "GliderSkin_EquipmentStatus_IsEquipped";
				}
				return "GliderSkin_EquipmentStatus_Equip";
			}
			else
			{
				if (skinType != EFlySkinType.SoarWing)
				{
					return "";
				}
				if (!canEquip)
				{
					return "SoarWingSkin_EquipmentStatus_IsEquipped";
				}
				return "SoarWingSkin_EquipmentStatus_Equip";
			}
		}

		// Token: 0x060270EC RID: 159980 RVA: 0x00AEEF2F File Offset: 0x00AED12F
		public string GetFlySkinSpawnEffectId(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return "GliderEffect";
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return "SoarWingEffect";
			}
			return "";
		}

		// Token: 0x060270ED RID: 159981 RVA: 0x00AEEF49 File Offset: 0x00AED149
		public string GetFlySkinSpawnMaterialController(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return "GliderMaterialController";
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return "SoarWingMaterialController";
			}
			return "";
		}

		// Token: 0x060270EE RID: 159982 RVA: 0x00AEEF63 File Offset: 0x00AED163
		public RoleSkin? GetRoleSkinConfig(int itemId)
		{
			return ConfigRoleSkinById.GetConfig(itemId, true);
		}

		// Token: 0x060270EF RID: 159983 RVA: 0x00AEEF6C File Offset: 0x00AED16C
		[NullableContext(2)]
		public string GetRoleSkinConfigValueByParam(int itemId, string param, [Nullable(1)] string tag)
		{
			RoleSkin? roleSkinConfig = this.GetRoleSkinConfig(itemId);
			if (roleSkinConfig == null || string.IsNullOrEmpty(param))
			{
				return null;
			}
			if (param != null)
			{
				int length = param.Length;
				if (length != 4)
				{
					if (length != 9)
					{
						switch (length)
						{
						case 12:
							if (param == "RoleHeadIcon")
							{
								return roleSkinConfig.Value.RoleHeadIcon;
							}
							break;
						case 15:
							if (param == "RoleHeadIconBig")
							{
								return roleSkinConfig.Value.RoleHeadIconBig;
							}
							break;
						case 17:
						{
							char c = param[0];
							if (c != 'F')
							{
								if (c == 'R')
								{
									if (param == "RoleHeadIconLarge")
									{
										return roleSkinConfig.Value.RoleHeadIconLarge;
									}
								}
							}
							else if (param == "FormationRoleCard")
							{
								return roleSkinConfig.Value.FormationRoleCard;
							}
							break;
						}
						case 18:
							if (param == "RoleHeadIconCircle")
							{
								return roleSkinConfig.Value.RoleHeadIconCircle;
							}
							break;
						}
					}
					else if (param == "RoleStand")
					{
						return roleSkinConfig.Value.RoleStand;
					}
				}
				else if (param == "Card")
				{
					return roleSkinConfig.Value.Card;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiImageSetting;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "配置的表格字段查询到的资源路径不是字符串类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置的表格字段", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060270F0 RID: 159984 RVA: 0x00AEF10E File Offset: 0x00AED30E
		[NullableContext(2)]
		public IReadOnlyList<RoleSkin> GetRoleSkinConfigList(int roleId)
		{
			return ConfigRoleSkinByRoleId.GetConfigList(roleId, true);
		}

		// Token: 0x060270F1 RID: 159985 RVA: 0x00AEF118 File Offset: 0x00AED318
		public int GetSkinDetailButtonGap()
		{
			return ConfigCommonParamById.GetIntConfig("SkinDetailButtonGap").Value;
		}

		// Token: 0x060270F2 RID: 159986 RVA: 0x00AEF138 File Offset: 0x00AED338
		public int GetSkinDetailButtonSwitchGap()
		{
			return ConfigCommonParamById.GetIntConfig("SkinDetailButtonSwitchGap").Value;
		}

		// Token: 0x060270F3 RID: 159987 RVA: 0x00AEF157 File Offset: 0x00AED357
		public RoleSkin? GetSkinConfigByRoleIdAndGroupId(int roleId, int groupId)
		{
			return ConfigRoleSkinByRoleIdAndGroupId.GetConfig(roleId, groupId, true);
		}

		// Token: 0x060270F4 RID: 159988 RVA: 0x00AEF161 File Offset: 0x00AED361
		public FlySkinConfig? GetFlySkinConfig(int itemId)
		{
			return ConfigFlySkinConfigById.GetConfig(itemId, true);
		}

		// Token: 0x060270F5 RID: 159989 RVA: 0x00AEF16A File Offset: 0x00AED36A
		public IReadOnlyList<FlySkinConfig> GetFlySkinConfigListByType(EFlySkinType type)
		{
			return ConfigFlySkinConfigByType.GetConfigList((int)type, true);
		}

		// Token: 0x060270F6 RID: 159990 RVA: 0x00AEF173 File Offset: 0x00AED373
		[NullableContext(2)]
		public IReadOnlyList<RoleSkin> GetSkinGroupList(int skinGroupId)
		{
			return ConfigRoleSkinByGroupId.GetConfigList(skinGroupId, true);
		}

		// Token: 0x060270F7 RID: 159991 RVA: 0x00AEF17C File Offset: 0x00AED37C
		public CalabashSkin GetCalabashSkinConfig(int itemId)
		{
			return ConfigCalabashSkinById.GetConfig(itemId, true).Value;
		}

		// Token: 0x060270F8 RID: 159992 RVA: 0x00AEF198 File Offset: 0x00AED398
		public IReadOnlyList<CalabashSkin> GetCalabashSkinConfigList()
		{
			return ConfigCalabashSkinAll.GetConfigList(true);
		}

		// Token: 0x060270F9 RID: 159993 RVA: 0x00AEF1A0 File Offset: 0x00AED3A0
		public string GetDefaultCalabashSkinIconPath()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalCalabashSkinIcon");
		}

		// Token: 0x060270FA RID: 159994 RVA: 0x00AEF1AC File Offset: 0x00AED3AC
		public string GetDefaultCalabashSkinName()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalCalabashSkinName");
		}

		// Token: 0x060270FB RID: 159995 RVA: 0x00AEF1B8 File Offset: 0x00AED3B8
		public string GetDefaultCalabashSkinDescription()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalCalabashSkinDescription");
		}

		// Token: 0x060270FC RID: 159996 RVA: 0x00AEF1C4 File Offset: 0x00AED3C4
		public CalabashTransform GetCalabashTransformById(int transformId)
		{
			return ConfigCalabashTransformById.GetConfig(transformId, true).Value;
		}

		// Token: 0x060270FD RID: 159997 RVA: 0x00AEF1E0 File Offset: 0x00AED3E0
		public int GetCalabashSkinFailRequestCd()
		{
			return ConfigCommonParamById.GetIntConfig("CalabashSkinFailRequestCd").Value;
		}

		// Token: 0x060270FE RID: 159998 RVA: 0x00AEF200 File Offset: 0x00AED400
		public bool GetCalabashSkinNeedStopRotate()
		{
			return ConfigCommonParamById.GetBoolConfig("CalabashSkinNeedStopRotate").Value;
		}

		// Token: 0x060270FF RID: 159999 RVA: 0x00AEF21F File Offset: 0x00AED41F
		public MotorSkinShow? GetMotorSkinShowConfig(int id)
		{
			return ConfigMotorSkinShowById.GetConfig(id, true);
		}

		// Token: 0x06027100 RID: 160000 RVA: 0x00AEF228 File Offset: 0x00AED428
		public MotorGiftQuality? GetMotorSkinGiftQualityConfig(int qualityId)
		{
			return ConfigMotorGiftQualityByQualityId.GetConfig(qualityId, true);
		}

		// Token: 0x17004FF8 RID: 20472
		// (get) Token: 0x06027101 RID: 160001 RVA: 0x00AEF231 File Offset: 0x00AED431
		public static SkinConfig Instance
		{
			get
			{
				return SkinConfig._Instance;
			}
		}

		// Token: 0x06027102 RID: 160002 RVA: 0x00AEF238 File Offset: 0x00AED438
		public static SkinConfig GetOrCreateInstance()
		{
			if (SkinConfig._Instance == null)
			{
				SkinConfig.CreateInstance();
			}
			return SkinConfig._Instance;
		}

		// Token: 0x06027103 RID: 160003 RVA: 0x00AEF24C File Offset: 0x00AED44C
		public static bool CreateInstance()
		{
			if (SkinConfig._Instance != null)
			{
				return true;
			}
			SkinConfig._Instance = new SkinConfig();
			return true;
		}

		// Token: 0x06027104 RID: 160004 RVA: 0x00AEF262 File Offset: 0x00AED462
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027105 RID: 160005 RVA: 0x00AEF264 File Offset: 0x00AED464
		public static void ResetStaticDefaultValue()
		{
			SkinConfig._Instance = null;
		}

		// Token: 0x06027106 RID: 160006 RVA: 0x00AEF26C File Offset: 0x00AED46C
		static SkinConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkinConfig.CreateStaticDefaultValue), new Action(SkinConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040154E5 RID: 87269
		[Nullable(2)]
		private static SkinConfig _Instance;
	}
}
