using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02004BDD RID: 19421
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class SkinConfig : ConfigBase
	{
		// Token: 0x0603234B RID: 205643 RVA: 0x00BAAA74 File Offset: 0x00BA8C74
		public WeaponSkin GetWeaponSkinConfig(int id)
		{
			return ConfigWeaponSkinById.GetConfig(id, true).Value;
		}

		// Token: 0x0603234C RID: 205644 RVA: 0x00BAAA90 File Offset: 0x00BA8C90
		public IReadOnlyList<WeaponSkin> GetWeaponSkinConfigListByType(int type)
		{
			return ConfigWeaponSkinByType.GetConfigList(type, true);
		}

		// Token: 0x0603234D RID: 205645 RVA: 0x00BAAA99 File Offset: 0x00BA8C99
		public string GetDefaultWeaponSkinIconPath()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalWeaponSkinIcon");
		}

		// Token: 0x0603234E RID: 205646 RVA: 0x00BAAAA5 File Offset: 0x00BA8CA5
		public string GetDefaultWeaponSkinName()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalWeaponSkinName");
		}

		// Token: 0x0603234F RID: 205647 RVA: 0x00BAAAB1 File Offset: 0x00BA8CB1
		public string GetDefaultWeaponSkinDescription()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalWeaponSkinDescription");
		}

		// Token: 0x06032350 RID: 205648 RVA: 0x00BAAABD File Offset: 0x00BA8CBD
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

		// Token: 0x06032351 RID: 205649 RVA: 0x00BAAAE1 File Offset: 0x00BA8CE1
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

		// Token: 0x06032352 RID: 205650 RVA: 0x00BAAB05 File Offset: 0x00BA8D05
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

		// Token: 0x06032353 RID: 205651 RVA: 0x00BAAB29 File Offset: 0x00BA8D29
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

		// Token: 0x06032354 RID: 205652 RVA: 0x00BAAB4D File Offset: 0x00BA8D4D
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

		// Token: 0x06032355 RID: 205653 RVA: 0x00BAAB74 File Offset: 0x00BA8D74
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

		// Token: 0x06032356 RID: 205654 RVA: 0x00BAABAF File Offset: 0x00BA8DAF
		[NullableContext(2)]
		public float[] GetFlySkinModelOffsetTransform(EFlySkinType skinType)
		{
			if (skinType == EFlySkinType.Paragliding)
			{
				return ConfigCommonParamById.GetFloatArrayConfig("ParaglidingSkinOffsetTransform").ToArray<float>();
			}
			if (skinType == EFlySkinType.SoarWing)
			{
				return ConfigCommonParamById.GetFloatArrayConfig("SoarWingSkinOffsetTransform").ToArray<float>();
			}
			return null;
		}

		// Token: 0x06032357 RID: 205655 RVA: 0x00BAABD9 File Offset: 0x00BA8DD9
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

		// Token: 0x06032358 RID: 205656 RVA: 0x00BAABFD File Offset: 0x00BA8DFD
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

		// Token: 0x06032359 RID: 205657 RVA: 0x00BAAC17 File Offset: 0x00BA8E17
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

		// Token: 0x0603235A RID: 205658 RVA: 0x00BAAC31 File Offset: 0x00BA8E31
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

		// Token: 0x0603235B RID: 205659 RVA: 0x00BAAC5D File Offset: 0x00BA8E5D
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

		// Token: 0x0603235C RID: 205660 RVA: 0x00BAAC77 File Offset: 0x00BA8E77
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

		// Token: 0x0603235D RID: 205661 RVA: 0x00BAAC91 File Offset: 0x00BA8E91
		public RoleSkin? GetRoleSkinConfig(int itemId)
		{
			return ConfigRoleSkinById.GetConfig(itemId, true);
		}

		// Token: 0x0603235E RID: 205662 RVA: 0x00BAAC9C File Offset: 0x00BA8E9C
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

		// Token: 0x0603235F RID: 205663 RVA: 0x00BAAE3E File Offset: 0x00BA903E
		[NullableContext(2)]
		public IReadOnlyList<RoleSkin> GetRoleSkinConfigList(int roleId)
		{
			return ConfigRoleSkinByRoleId.GetConfigList(roleId, true);
		}

		// Token: 0x06032360 RID: 205664 RVA: 0x00BAAE48 File Offset: 0x00BA9048
		public int GetSkinDetailButtonGap()
		{
			return ConfigCommonParamById.GetIntConfig("SkinDetailButtonGap").Value;
		}

		// Token: 0x06032361 RID: 205665 RVA: 0x00BAAE68 File Offset: 0x00BA9068
		public int GetSkinDetailButtonSwitchGap()
		{
			return ConfigCommonParamById.GetIntConfig("SkinDetailButtonSwitchGap").Value;
		}

		// Token: 0x06032362 RID: 205666 RVA: 0x00BAAE87 File Offset: 0x00BA9087
		public RoleSkin? GetSkinConfigByRoleIdAndGroupId(int roleId, int groupId)
		{
			return ConfigRoleSkinByRoleIdAndGroupId.GetConfig(roleId, groupId, true);
		}

		// Token: 0x06032363 RID: 205667 RVA: 0x00BAAE91 File Offset: 0x00BA9091
		public FlySkinConfig? GetFlySkinConfig(int itemId)
		{
			return ConfigFlySkinConfigById.GetConfig(itemId, true);
		}

		// Token: 0x06032364 RID: 205668 RVA: 0x00BAAE9A File Offset: 0x00BA909A
		public IReadOnlyList<FlySkinConfig> GetFlySkinConfigListByType(EFlySkinType type)
		{
			return ConfigFlySkinConfigByType.GetConfigList((int)type, true);
		}

		// Token: 0x06032365 RID: 205669 RVA: 0x00BAAEA3 File Offset: 0x00BA90A3
		[NullableContext(2)]
		public IReadOnlyList<RoleSkin> GetSkinGroupList(int skinGroupId)
		{
			return ConfigRoleSkinByGroupId.GetConfigList(skinGroupId, true);
		}

		// Token: 0x06032366 RID: 205670 RVA: 0x00BAAEAC File Offset: 0x00BA90AC
		public CalabashSkin GetCalabashSkinConfig(int itemId)
		{
			return ConfigCalabashSkinById.GetConfig(itemId, true).Value;
		}

		// Token: 0x06032367 RID: 205671 RVA: 0x00BAAEC8 File Offset: 0x00BA90C8
		public IReadOnlyList<CalabashSkin> GetCalabashSkinConfigList()
		{
			return ConfigCalabashSkinAll.GetConfigList(true);
		}

		// Token: 0x06032368 RID: 205672 RVA: 0x00BAAED0 File Offset: 0x00BA90D0
		public string GetDefaultCalabashSkinIconPath()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalCalabashSkinIcon");
		}

		// Token: 0x06032369 RID: 205673 RVA: 0x00BAAEDC File Offset: 0x00BA90DC
		public string GetDefaultCalabashSkinName()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalCalabashSkinName");
		}

		// Token: 0x0603236A RID: 205674 RVA: 0x00BAAEE8 File Offset: 0x00BA90E8
		public string GetDefaultCalabashSkinDescription()
		{
			return ConfigCommonParamById.GetStringConfig("OriginalCalabashSkinDescription");
		}

		// Token: 0x0603236B RID: 205675 RVA: 0x00BAAEF4 File Offset: 0x00BA90F4
		public CalabashTransform GetCalabashTransformById(int transformId)
		{
			return ConfigCalabashTransformById.GetConfig(transformId, true).Value;
		}

		// Token: 0x0603236C RID: 205676 RVA: 0x00BAAF10 File Offset: 0x00BA9110
		public int GetCalabashSkinFailRequestCd()
		{
			return ConfigCommonParamById.GetIntConfig("CalabashSkinFailRequestCd").Value;
		}

		// Token: 0x0603236D RID: 205677 RVA: 0x00BAAF30 File Offset: 0x00BA9130
		public bool GetCalabashSkinNeedStopRotate()
		{
			return ConfigCommonParamById.GetBoolConfig("CalabashSkinNeedStopRotate").Value;
		}

		// Token: 0x0603236E RID: 205678 RVA: 0x00BAAF4F File Offset: 0x00BA914F
		public MotorSkinShow? GetMotorSkinShowConfig(int id)
		{
			return ConfigMotorSkinShowById.GetConfig(id, true);
		}

		// Token: 0x0603236F RID: 205679 RVA: 0x00BAAF58 File Offset: 0x00BA9158
		public MotorGiftQuality? GetMotorSkinGiftQualityConfig(int qualityId)
		{
			return ConfigMotorGiftQualityByQualityId.GetConfig(qualityId, true);
		}

		// Token: 0x17007C4E RID: 31822
		// (get) Token: 0x06032370 RID: 205680 RVA: 0x00BAAF61 File Offset: 0x00BA9161
		public static SkinConfig Instance
		{
			get
			{
				return SkinConfig._Instance;
			}
		}

		// Token: 0x06032371 RID: 205681 RVA: 0x00BAAF68 File Offset: 0x00BA9168
		public static SkinConfig GetOrCreateInstance()
		{
			if (SkinConfig._Instance == null)
			{
				SkinConfig.CreateInstance();
			}
			return SkinConfig._Instance;
		}

		// Token: 0x06032372 RID: 205682 RVA: 0x00BAAF7C File Offset: 0x00BA917C
		public static bool CreateInstance()
		{
			if (SkinConfig._Instance != null)
			{
				return true;
			}
			SkinConfig._Instance = new SkinConfig();
			return true;
		}

		// Token: 0x06032373 RID: 205683 RVA: 0x00BAAF92 File Offset: 0x00BA9192
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032374 RID: 205684 RVA: 0x00BAAF94 File Offset: 0x00BA9194
		public static void ResetStaticDefaultValue()
		{
			SkinConfig._Instance = null;
		}

		// Token: 0x06032375 RID: 205685 RVA: 0x00BAAF9C File Offset: 0x00BA919C
		static SkinConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkinConfig.CreateStaticDefaultValue), new Action(SkinConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401AB90 RID: 109456
		[Nullable(2)]
		private static SkinConfig _Instance;
	}
}
