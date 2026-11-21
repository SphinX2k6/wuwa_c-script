using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034E8 RID: 13544
	[NullableContext(1)]
	[Nullable(0)]
	public class RenderConfig : IStaticVariableResetter
	{
		// Token: 0x06022783 RID: 141187 RVA: 0x009C8088 File Offset: 0x009C6288
		static RenderConfig()
		{
			EKuroCharMeshPart[] array = new EKuroCharMeshPart[5];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.08BB5E5D6EAAC1049EDE0893D30ED022B1A4D9B5B48DB414871F51C9CB35283D).FieldHandle);
			RenderConfig.MeshPartsHeadArray = array;
			RenderConfig.MaterialControlBodyTypes = null;
			RenderConfig.EntityTypeToRenderPriorityMap = null;
			RenderConfig.SpecifiedTypeBodyNames = null;
			RenderConfig.UseRim = new FName("E_Rim_UseRim");
			RenderConfig.RimUseTex = new FName("E_Rim_UseTex");
			RenderConfig.RimChannel = new FName("E_Rim_Channel");
			RenderConfig.RimRange = new FName("E_Rim_RimRange");
			RenderConfig.RimColor = new FName("E_Rim_RimColor");
			RenderConfig.RimIntensity = new FName("E_Rim_Intensity");
			RenderConfig.UseDissolve = new FName("E_Dissolve_UseDissolve");
			RenderConfig.DissolveChannelSwitch = new FName("E_Dissolve_Channel");
			RenderConfig.DissolveProgress = new FName("E_Dissolve_Progress");
			RenderConfig.DissolveSmooth = new FName("E_Dissolve_Smooth");
			RenderConfig.DissolveMulti = new FName("E_Dissolve_Multi");
			RenderConfig.DissolveEmission = new FName("E_Dissolve_Emission");
			RenderConfig.OutlineUseTex = new FName("E_Outline_UseTex");
			RenderConfig.OutlineWidth = new FName("MaxOutlineWidth");
			RenderConfig.OutlineColor = new FName("E_Outline_EmissionColor");
			RenderConfig.OutlineColorIntensity = new FName("E_Outline_EmissionIntensity");
			RenderConfig.UseTexture = new FName("E_Tex_UseTex");
			RenderConfig.TextureUseMask = new FName("E_Tex_UseMask");
			RenderConfig.TextureMaskRange = new FName("E_Tex_MaskRange");
			RenderConfig.NoiseTexture = new FName("E_Tex_NoiseTex");
			RenderConfig.TextureUvSwitch = new FName("E_Tex_UVSwitch");
			RenderConfig.TextureUseScreenUv = new FName("E_Tex_UseScreenUV");
			RenderConfig.TextureScaleAndOffset = new FName("E_Tex_ScaleAndOffset");
			RenderConfig.TextureSpeed = new FName("E_Tex_Speed");
			RenderConfig.TextureColor = new FName("E_Tex_Color");
			RenderConfig.TextureRotation = new FName("E_Tex_Rotation");
			RenderConfig.BaseUseTex = new FName("E_Base_UseTex");
			RenderConfig.BaseColor = new FName("E_Base_Color");
			RenderConfig.BaseColorIntensity = new FName("E_Base_Intensity");
			RenderConfig.EmissionUseTex = new FName("E_Emission_UseTex");
			RenderConfig.EmissionColor = new FName("E_Emission_Color");
			RenderConfig.EmissionIntensity = new FName("E_Emission_Intensity");
			RenderConfig.UseHeadMaskHideEffect = new FName("E_UseHeadMaskHide");
			RenderConfig.DitherUseInRayTracing = new FName("E_UseInRayTracing");
			RenderConfig.UseDitherEffect = new FName("E_Dither_UseDither");
			RenderConfig.DitherValue = new FName("E_Dither_DitherValue");
			RenderConfig.DitherValueMainPass = new FName("E_Dither_DitherValue_MainPass");
			RenderConfig.UseDitherEffect2 = new FName("E_Dither_UseDither2");
			RenderConfig.DitherValue2 = new FName("E_Dither_DitherValue2");
			RenderConfig.CharacterAmbientColor = new FName("CharacterAmbientColor");
			RenderConfig.CharacterSkinAmbientColor = new FName("CharacterSkinAmbientColor");
			RenderConfig.EnableTransfer = new FName("E_Transfer_Enable");
			RenderConfig.TransferDensity = new FName("E_Transfer_Density");
			RenderConfig.TransferHardness = new FName("E_Transfer_Hardness");
			RenderConfig.TransferDirection = new FName("E_Transfer_Direction");
			RenderConfig.TransferHeight = new FName("E_Transfer_Height");
			RenderConfig.TransferOutlineColor = new FName("E_Transfer_OutlineColor");
			RenderConfig.MotionRange = new FName("E_MotionRange");
			RenderConfig.MotionOffset = new FName("E_Motion_Offset");
			RenderConfig.MotionNoiseSpeed = new FName("E_Motion_NoiseSpeed");
			RenderConfig.StarScarEnergyControl = new FName("XingHenControl");
			RenderConfig.TexMipOffset = new FName("Tex_Mip_Offset");
			RenderConfig.RootName = new FName("Root");
			RenderConfig.UIName = new FName("UI");
			RenderConfig.GlobalRainIntensity = new FName("GlobalRainIntensity");
			RenderConfig.GlobalSnowIntensity = new FName("GlobalSnowIntensity");
			RenderConfig.GlobalWindSpeed = new FName("GlobalWindSpeed");
			RenderConfig.GlobalGrassAO = new FName("GlobalGrassAO");
			RenderConfig.GlobalMainLightVector = new FName("GlobalSceneMainLightDirection");
			RenderConfig.GlobalLensFlareColorTint = new FName("GlobalLensFlareColorTint");
			RenderConfig.GlobalCharacterPreviousWP = new FName("GlobalCharacterPreviousWP");
			RenderConfig.GlobalCharacterWorldPosition = new FName("GlobalCharacterWorldPosition");
			RenderConfig.GlobalCharacterWeaponPosition = new FName("GlobalCharacterWeaponPosition");
			RenderConfig.GlobalCharacterWorldForwardDirection = new FName("GlobalCharacterWorldForwardDirection");
			RenderConfig.GlobalCharacterOnGround = new FName("GlobalCharacterOnGround");
			RenderConfig.GlobalCameraPosAndRadius = new FName("GlobalCameraPosAndRadius");
			RenderConfig.UseSocketTransform = new FName("UseSocketTransform");
			RenderConfig.UseClipboardTransform = new FName("UseClipboardTransform");
			RenderConfig.UseSocketTransform2 = new FName("使用插槽变换信息");
			RenderConfig.UseClipboardTransform2 = new FName("使用剪切板变换信息");
			RenderConfig.PhysicsActor = new FName("PhysicsActor");
			RenderConfig.WaterCollisionProfileName = new FName("水体");
			RenderConfig.UIShowBrightness = new FName("Lumin");
			RenderConfig.UIShowSaturation = new FName("Saturation");
			RenderConfig.UIShowContrast = new FName("Contrast");
			RenderConfig.GlobalTimeHour = new FName("GlobalTimeHour");
			RenderConfig.GlobalTimeMinutes = new FName("GlobalTimeMinutes");
			RenderConfig.GravityDirection = new FName("GravityDirection");
			RenderConfig.IsPlayerMale = new FName("IsPlayerMale");
			RenderConfig.E_Action_UseBaseColorScale = new FName("E_Action_UseBaseColorScale");
			RenderConfig.E_Action_BaseColorScale = new FName("E_Action_BaseColorScale");
			RenderConfig.E_Action_UseEmissionColor = new FName("E_Action_UseEmissionColor");
			RenderConfig.E_Action_EmissionColor = new FName("E_Action_EmissionColor");
			RenderConfig.E_Action_UseRimLight = new FName("E_Action_UseRimLight");
			RenderConfig.E_Action_RimLightColor = new FName("E_Action_RimLightColor");
			RenderConfig.E_Action_RimPower = new FName("E_Action_RimPower");
			RenderConfig.E_Action_UseEmissionChange = new FName("E_Action_UseEmissionChange");
			RenderConfig.E_Action_EmissionLightColorChangeColor = new FName("E_Action_EmissionLightColorChangeColor");
			RenderConfig.E_Action_EmissionLightColorChangeStrength = new FName("E_Action_EmissionLightColorChangeStrength");
			RenderConfig.E_Action_EmissionLightColorChangeProgress = new FName("E_Action_EmissionLightColorChangeProgress");
			RenderConfig.E_Action_UseDissolve = new FName("E_Action_UseDissolve");
			RenderConfig.E_Action_DissolveProgress = new FName("E_Action_DissolveProgress");
			RenderConfig.E_Action_DissolveAdjustment = new FName("E_Action_DissolveAdjustment");
			RenderConfig.E_Action_DissolveEdageWidth = new FName("E_Action_DissolveEdageWidth");
			RenderConfig.E_Action_DissolveEdageColor = new FName("E_Action_DissolveEdageColor");
			RenderConfig.E_Action_DissolveEdageStrength = new FName("E_Action_DissolveEdageStrength");
			RenderConfig.E_Action_DissolveTex_S_O = new FName("E_Action_DissolveTex_S_O");
			RenderConfig.E_Action_DissolveTexSpeed = new FName("E_Action_DissolveTexSpeed");
			RenderConfig.E_Tex_DissolveTexUVSwitch = new FName("E_Tex_DissolveTexUVSwitch");
			RenderConfig.E_Action_ScanningOutlineMixNoiseStrength = new FName("E_Action_ScanningOutlineMixNoiseStrength");
			RenderConfig.E_Action_GlobalBaseColorScale = new FName("E_Action_GlobalBaseColorScale");
			RenderConfig.E_Action_GlobalAddEmissionColor = new FName("E_Action_GlobalAddEmissionColor");
			RenderConfig.E_Action_ScanningOutline = new FName("E_Action_ScanningOutline");
			RenderConfig.E_Action_GlobalRimLight = new FName("E_Action_GlobalRimLight");
			RenderConfig.E_Action_UseScanning = new FName("E_Action_UseScanning");
			RenderConfig.E_Action_RimMix = new FName("E_Action_RimMix");
			RenderConfig.E_Action_ScanningOutlineStrength = new FName("E_Action_ScanningOutlineStrength");
			RenderConfig.E_Action_ScanningTex_S_O = new FName("E_Action_ScanningTex_S_O");
			RenderConfig.E_Action_ScanningOutlineColor = new FName("E_Action_ScanningOutlineColor");
			RenderConfig.E_Action_RimWidth = new FName("E_Action_RimWidth");
			RenderConfig.BrokenTex_S_O = new FName("BrokenTex_S_O");
			RenderConfig.OutlineTex_S_O = new FName("OutlineTex_S_O");
			RenderConfig.E_Action_VertexAnim_TimeDebug = new FName("E_Action_VertexAnim_TimeDebug");
			RenderConfig.E_Action_VertexAnim_Frame = new FName("E_Action_VertexAnim_Frame");
			RenderConfig.E_Action_PivotPainterTransform = new FName("E_Action_PivotPainterTransform");
			RenderConfig.E_Action_PivotPainter_FloatingThreshold = new FName("E_Action_PivotPainter_FloatingThreshold");
			RenderConfig.E_Action_UsePivotPainterWorldPositionOffset = new FName("E_Action_UsePivotPainterWorldPositionOffset");
			RenderConfig.E_Action_UseWPO = new FName("E_Action_UseWPO");
			RenderConfig.E_Action_DisableFoliageEffect = new FName("E_Action_DisableFoliageEffect");
			RenderConfig.E_Action_EnableFoliageEffect = new FName("E_Action_EnableFoliageEffect");
			RenderConfig.E_Action_RimLightColorSpecil = new FName("E_Action_RimLightColorSpecil");
			RenderConfig.E_Action_UseRimlightColorSpecil = new FName("E_Action_UseRimlightColorSpecil");
			RenderConfig.E_Action_RimlightColorStrength = new FName("E_Action_RimlightColorStrength");
			RenderConfig.E_Action_SimpleWPO_Normal = new FName("E_Action_SimpleWPO_Normal");
			RenderConfig.E_Action_SimpleWPO_Offset = new FName("E_Action_SimpleWPO_Offset");
			RenderConfig.E_Action_UseEmissionTex = new FName("E_Action_UseEmissionTex");
			RenderConfig.E_Action_EmissionTexStrength = new FName("E_Action_EmissionTexStrength");
			RenderConfig.E_Action_Simple_Uspeed = new FName("E_Action_Simple_Uspeed");
			RenderConfig.E_Action_Simple_Vspeed = new FName("E_Action_Simple_Vspeed");
			RenderConfig.E_Action_Simple_UseFlow = new FName("E_Action_Simple_UseFlow");
			RenderConfig.E_Action_UseQuanXiPinTu = new FName("E_Action_UseQuanXiPinTu");
			RenderConfig.E_Action_TransparencyQuanXiPinTu = new FName("E_Action_TransparencyQuanXiPinTu");
			RenderConfig.E_Action_TransparentColorQuanXiPinTu = new FName("E_Action_TransparentColorQuanXiPinTu");
			RenderConfig.E_Action_OpaqueColorQuanXiPinTu = new FName("E_Action_OpaqueColorQuanXiPinTu");
			RenderConfig.E_Action_UseQuanXiFengSuo = new FName("E_Action_UseQuanXiFengSuo");
			RenderConfig.E_Action_TransparencyQuanXiFengSuo = new FName("E_Action_TransparencyQuanXiFengSuo");
			RenderConfig.E_Action_TransparentColorQuanXiFengSuo = new FName("E_Action_TransparentColorQuanXiFengSuo");
			StaticVariableRegister.RegisterAndExecute(new Action(RenderConfig.CreateStaticDefaultValue), new Action(RenderConfig.ResetStaticDefaultValue));
		}

		// Token: 0x06022784 RID: 141188 RVA: 0x009C8A57 File Offset: 0x009C6C57
		public static string GenerateExtraMeshName(string sourceSkeletalName)
		{
			return sourceSkeletalName + "_ExtraMesh";
		}

		// Token: 0x06022785 RID: 141189 RVA: 0x009C8A64 File Offset: 0x009C6C64
		public static ECharacterBodyType GetBodyTypeByName(string bodyName)
		{
			if (RenderConfig.MaterialControlBodyTypes == null)
			{
				RenderConfig.MaterialControlBodyTypes = new Dictionary<string, ECharacterBodyType>
				{
					{
						"CharacterMesh0",
						ECharacterBodyType.Body
					},
					{
						"WeaponCase0",
						ECharacterBodyType.Weapon
					},
					{
						"WeaponCase1",
						ECharacterBodyType.Weapon
					},
					{
						"WeaponCase2",
						ECharacterBodyType.Weapon
					},
					{
						"WeaponCase3",
						ECharacterBodyType.Weapon
					},
					{
						"WeaponCase4",
						ECharacterBodyType.Weapon
					},
					{
						"HuluCase",
						ECharacterBodyType.Hulu
					},
					{
						"OtherCase0",
						ECharacterBodyType.Other
					},
					{
						"OtherCase1",
						ECharacterBodyType.Other
					},
					{
						"OtherCase2",
						ECharacterBodyType.Other
					},
					{
						"OtherCase3",
						ECharacterBodyType.Other
					},
					{
						"OtherCase4",
						ECharacterBodyType.Other
					}
				};
			}
			ECharacterBodyType result;
			if (!RenderConfig.MaterialControlBodyTypes.TryGetValue(bodyName, out result))
			{
				return ECharacterBodyType.Body;
			}
			return result;
		}

		// Token: 0x06022786 RID: 141190 RVA: 0x009C8B28 File Offset: 0x009C6D28
		public static EEntityTypePriority GetEntityRenderPriority(bool isBoss, EEntityType entityType)
		{
			if (isBoss)
			{
				return EEntityTypePriority.Boss;
			}
			if (RenderConfig.EntityTypeToRenderPriorityMap == null)
			{
				RenderConfig.EntityTypeToRenderPriorityMap = new Dictionary<EEntityType, EEntityTypePriority>
				{
					{
						EEntityType.Player,
						EEntityTypePriority.Player
					},
					{
						EEntityType.Npc,
						EEntityTypePriority.NPC
					},
					{
						EEntityType.Monster,
						EEntityTypePriority.Monster
					},
					{
						EEntityType.Vision,
						EEntityTypePriority.Vision
					},
					{
						EEntityType.Animal,
						EEntityTypePriority.Animal
					},
					{
						EEntityType.SceneItem,
						EEntityTypePriority.SceneItem
					},
					{
						EEntityType.Custom,
						EEntityTypePriority.Custom
					}
				};
			}
			EEntityTypePriority result;
			if (!RenderConfig.EntityTypeToRenderPriorityMap.TryGetValue(entityType, out result))
			{
				return EEntityTypePriority.None;
			}
			return result;
		}

		// Token: 0x06022787 RID: 141191 RVA: 0x009C8B98 File Offset: 0x009C6D98
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static string[] GetBodyNamesByBodyType(ECharacterBodySpecifiedType bodyType)
		{
			if (RenderConfig.SpecifiedTypeBodyNames == null)
			{
				RenderConfig.SpecifiedTypeBodyNames = new Dictionary<ECharacterBodySpecifiedType, string[]>
				{
					{
						ECharacterBodySpecifiedType.All,
						(string[])RenderConfig.MaterialControlAllCaseArray.Clone()
					},
					{
						ECharacterBodySpecifiedType.Body,
						(string[])RenderConfig.MaterialControlBodyCaseArray.Clone()
					},
					{
						ECharacterBodySpecifiedType.Weapon,
						(string[])RenderConfig.MaterialControlWeaponCaseArray.Clone()
					},
					{
						ECharacterBodySpecifiedType.Hulu,
						(string[])RenderConfig.MaterialControlHuluCaseArray.Clone()
					},
					{
						ECharacterBodySpecifiedType.Other,
						(string[])RenderConfig.MaterialControlOtherCaseArray.Clone()
					},
					{
						ECharacterBodySpecifiedType.WeaponAndHulu,
						(string[])RenderConfig.MaterialControlWeaponAndHuluCaseArray.Clone()
					},
					{
						ECharacterBodySpecifiedType.ExtraBody,
						(string[])RenderConfig.MaterialControlExtraBodyCaseArray.Clone()
					}
				};
			}
			string[] result;
			if (!RenderConfig.SpecifiedTypeBodyNames.TryGetValue(bodyType, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06022788 RID: 141192 RVA: 0x009C8C68 File Offset: 0x009C6E68
		public static ECharacterSlotType GetMaterialSlotType(string slotName)
		{
			if (slotName.StartsWith("MI_"))
			{
				return ECharacterSlotType.Body;
			}
			if (slotName.StartsWith("OL_"))
			{
				return ECharacterSlotType.Outline;
			}
			if (slotName.StartsWith("HETA_"))
			{
				return ECharacterSlotType.HairEyeTransparent;
			}
			if (slotName.StartsWith("HET_"))
			{
				return ECharacterSlotType.EyeMask;
			}
			if (slotName.StartsWith("FS_"))
			{
				return ECharacterSlotType.FaceShadow;
			}
			return ECharacterSlotType.Error;
		}

		// Token: 0x06022789 RID: 141193 RVA: 0x009C8CC4 File Offset: 0x009C6EC4
		public static ECharacterMeshPart GetMaterialPartType(string slotName)
		{
			string text = slotName.ToLower();
			if (text.Contains("bang"))
			{
				return ECharacterMeshPart.Bangs;
			}
			if (text.Contains("hair") || text.Contains("fur"))
			{
				return ECharacterMeshPart.Hair;
			}
			if (text.Contains("head"))
			{
				return ECharacterMeshPart.Head;
			}
			if (text.Contains("face"))
			{
				return ECharacterMeshPart.Face;
			}
			if (text.Contains("eye"))
			{
				return ECharacterMeshPart.Eye;
			}
			if (text.Contains("body"))
			{
				return ECharacterMeshPart.Body;
			}
			if (text.Contains("up"))
			{
				return ECharacterMeshPart.Up;
			}
			if (text.Contains("down"))
			{
				return ECharacterMeshPart.Down;
			}
			if (text.Contains("leg"))
			{
				return ECharacterMeshPart.Leg;
			}
			if (text.Contains("cloth"))
			{
				return ECharacterMeshPart.Cloth;
			}
			if (text.Contains("skirt"))
			{
				return ECharacterMeshPart.Skirt;
			}
			if (text.Contains("star"))
			{
				return ECharacterMeshPart.Star;
			}
			if (text.Contains("core"))
			{
				return ECharacterMeshPart.Core;
			}
			if (text.Contains("hand"))
			{
				return ECharacterMeshPart.Hand;
			}
			if (text.Contains("wing"))
			{
				return ECharacterMeshPart.Wings;
			}
			if (text.Contains("prop"))
			{
				return ECharacterMeshPart.Prop;
			}
			if (text.Contains("weapon"))
			{
				return ECharacterMeshPart.Weapon;
			}
			return ECharacterMeshPart.Error;
		}

		// Token: 0x0602278A RID: 141194 RVA: 0x009C8DEE File Offset: 0x009C6FEE
		public static void CreateStaticDefaultValue()
		{
			RenderConfig.UseMaterialContainerV2 = true;
			RenderConfig.UseCharUnrealCacheObject = true;
		}

		// Token: 0x0602278B RID: 141195 RVA: 0x009C8DFC File Offset: 0x009C6FFC
		public static void ResetStaticDefaultValue()
		{
			RenderConfig.UseMaterialContainerV2 = true;
			RenderConfig.UseCharUnrealCacheObject = true;
			RenderConfig.MaterialControlBodyTypes = null;
			RenderConfig.EntityTypeToRenderPriorityMap = null;
			RenderConfig.SpecifiedTypeBodyNames = null;
		}

		// Token: 0x0401300E RID: 77838
		public const int INVALID_SECTION_INDEX = 99999;

		// Token: 0x0401300F RID: 77839
		public static bool UseMaterialContainerV2;

		// Token: 0x04013010 RID: 77840
		public static bool UseCharUnrealCacheObject;

		// Token: 0x04013011 RID: 77841
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlAllCaseArray = new string[]
		{
			"CharacterMesh0",
			"WeaponCase0",
			"WeaponCase1",
			"WeaponCase2",
			"WeaponCase3",
			"WeaponCase4",
			"HuluCase",
			"OtherCase0",
			"OtherCase1",
			"OtherCase2",
			"OtherCase3",
			"OtherCase4",
			"GenericCase0",
			"GenericCase1",
			"GenericCase2",
			"GenericCase3",
			"GenericCase4"
		};

		// Token: 0x04013012 RID: 77842
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlBodyCaseArray = new string[]
		{
			"CharacterMesh0"
		};

		// Token: 0x04013013 RID: 77843
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlWeaponCaseArray = new string[]
		{
			"WeaponCase0",
			"WeaponCase1",
			"WeaponCase2",
			"WeaponCase3",
			"WeaponCase4"
		};

		// Token: 0x04013014 RID: 77844
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlHuluCaseArray = new string[]
		{
			"HuluCase"
		};

		// Token: 0x04013015 RID: 77845
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlWeaponAndHuluCaseArray = new string[]
		{
			"WeaponCase0",
			"WeaponCase1",
			"WeaponCase2",
			"WeaponCase3",
			"WeaponCase4",
			"HuluCase"
		};

		// Token: 0x04013016 RID: 77846
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlOtherCaseArray = new string[]
		{
			"OtherCase0",
			"OtherCase1",
			"OtherCase2",
			"OtherCase3",
			"OtherCase4"
		};

		// Token: 0x04013017 RID: 77847
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlExtraBodyCaseArray = new string[]
		{
			"CharacterMesh0_ExtraMesh"
		};

		// Token: 0x04013018 RID: 77848
		[StaticVariableRuleIgnore]
		public static readonly EKuroCharMeshPart[] MeshPartsHeadArray;

		// Token: 0x04013019 RID: 77849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, ECharacterBodyType> MaterialControlBodyTypes;

		// Token: 0x0401301A RID: 77850
		[Nullable(2)]
		private static Dictionary<EEntityType, EEntityTypePriority> EntityTypeToRenderPriorityMap;

		// Token: 0x0401301B RID: 77851
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<ECharacterBodySpecifiedType, string[]> SpecifiedTypeBodyNames;

		// Token: 0x0401301C RID: 77852
		public const string CharMaterialContainerDataPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/DA_CharacterMaterialContainerData.DA_CharacterMaterialContainerData";

		// Token: 0x0401301D RID: 77853
		public const string HolographicPath = "/Game/Aki/Effect/EffectGroup/Sequence/Common/DA_Fx_Group_Seq_Communicate.DA_Fx_Group_Seq_Communicate";

		// Token: 0x0401301E RID: 77854
		public const int RefErrorCount = 20;

		// Token: 0x0401301F RID: 77855
		public static readonly FName UseRim;

		// Token: 0x04013020 RID: 77856
		public static readonly FName RimUseTex;

		// Token: 0x04013021 RID: 77857
		public static readonly FName RimChannel;

		// Token: 0x04013022 RID: 77858
		public static readonly FName RimRange;

		// Token: 0x04013023 RID: 77859
		public static readonly FName RimColor;

		// Token: 0x04013024 RID: 77860
		public static readonly FName RimIntensity;

		// Token: 0x04013025 RID: 77861
		public static readonly FName UseDissolve;

		// Token: 0x04013026 RID: 77862
		public static readonly FName DissolveChannelSwitch;

		// Token: 0x04013027 RID: 77863
		public static readonly FName DissolveProgress;

		// Token: 0x04013028 RID: 77864
		public static readonly FName DissolveSmooth;

		// Token: 0x04013029 RID: 77865
		public static readonly FName DissolveMulti;

		// Token: 0x0401302A RID: 77866
		public static readonly FName DissolveEmission;

		// Token: 0x0401302B RID: 77867
		public static readonly FName OutlineUseTex;

		// Token: 0x0401302C RID: 77868
		public static readonly FName OutlineWidth;

		// Token: 0x0401302D RID: 77869
		public static readonly FName OutlineColor;

		// Token: 0x0401302E RID: 77870
		public static readonly FName OutlineColorIntensity;

		// Token: 0x0401302F RID: 77871
		public static readonly FName UseTexture;

		// Token: 0x04013030 RID: 77872
		public static readonly FName TextureUseMask;

		// Token: 0x04013031 RID: 77873
		public static readonly FName TextureMaskRange;

		// Token: 0x04013032 RID: 77874
		public static readonly FName NoiseTexture;

		// Token: 0x04013033 RID: 77875
		public static readonly FName TextureUvSwitch;

		// Token: 0x04013034 RID: 77876
		public static readonly FName TextureUseScreenUv;

		// Token: 0x04013035 RID: 77877
		public static readonly FName TextureScaleAndOffset;

		// Token: 0x04013036 RID: 77878
		public static readonly FName TextureSpeed;

		// Token: 0x04013037 RID: 77879
		public static readonly FName TextureColor;

		// Token: 0x04013038 RID: 77880
		public static readonly FName TextureRotation;

		// Token: 0x04013039 RID: 77881
		public static readonly FName BaseUseTex;

		// Token: 0x0401303A RID: 77882
		public static readonly FName BaseColor;

		// Token: 0x0401303B RID: 77883
		public static readonly FName BaseColorIntensity;

		// Token: 0x0401303C RID: 77884
		public static readonly FName EmissionUseTex;

		// Token: 0x0401303D RID: 77885
		public static readonly FName EmissionColor;

		// Token: 0x0401303E RID: 77886
		public static readonly FName EmissionIntensity;

		// Token: 0x0401303F RID: 77887
		public static readonly FName UseHeadMaskHideEffect;

		// Token: 0x04013040 RID: 77888
		public static readonly FName DitherUseInRayTracing;

		// Token: 0x04013041 RID: 77889
		public static readonly FName UseDitherEffect;

		// Token: 0x04013042 RID: 77890
		public static readonly FName DitherValue;

		// Token: 0x04013043 RID: 77891
		public static readonly FName DitherValueMainPass;

		// Token: 0x04013044 RID: 77892
		public static readonly FName UseDitherEffect2;

		// Token: 0x04013045 RID: 77893
		public static readonly FName DitherValue2;

		// Token: 0x04013046 RID: 77894
		public static readonly FName CharacterAmbientColor;

		// Token: 0x04013047 RID: 77895
		public static readonly FName CharacterSkinAmbientColor;

		// Token: 0x04013048 RID: 77896
		public static readonly FName EnableTransfer;

		// Token: 0x04013049 RID: 77897
		public static readonly FName TransferDensity;

		// Token: 0x0401304A RID: 77898
		public static readonly FName TransferHardness;

		// Token: 0x0401304B RID: 77899
		public static readonly FName TransferDirection;

		// Token: 0x0401304C RID: 77900
		public static readonly FName TransferHeight;

		// Token: 0x0401304D RID: 77901
		public static readonly FName TransferOutlineColor;

		// Token: 0x0401304E RID: 77902
		public static readonly FName MotionRange;

		// Token: 0x0401304F RID: 77903
		public static readonly FName MotionOffset;

		// Token: 0x04013050 RID: 77904
		public static readonly FName MotionNoiseSpeed;

		// Token: 0x04013051 RID: 77905
		public static readonly FName StarScarEnergyControl;

		// Token: 0x04013052 RID: 77906
		public static readonly FName TexMipOffset;

		// Token: 0x04013053 RID: 77907
		public static readonly FName RootName;

		// Token: 0x04013054 RID: 77908
		public static readonly FName UIName;

		// Token: 0x04013055 RID: 77909
		public static readonly FName GlobalRainIntensity;

		// Token: 0x04013056 RID: 77910
		public static readonly FName GlobalSnowIntensity;

		// Token: 0x04013057 RID: 77911
		public static readonly FName GlobalWindSpeed;

		// Token: 0x04013058 RID: 77912
		public static readonly FName GlobalGrassAO;

		// Token: 0x04013059 RID: 77913
		public static readonly FName GlobalMainLightVector;

		// Token: 0x0401305A RID: 77914
		public static readonly FName GlobalLensFlareColorTint;

		// Token: 0x0401305B RID: 77915
		public static readonly FName GlobalCharacterPreviousWP;

		// Token: 0x0401305C RID: 77916
		public static readonly FName GlobalCharacterWorldPosition;

		// Token: 0x0401305D RID: 77917
		public static readonly FName GlobalCharacterWeaponPosition;

		// Token: 0x0401305E RID: 77918
		public static readonly FName GlobalCharacterWorldForwardDirection;

		// Token: 0x0401305F RID: 77919
		public static readonly FName GlobalCharacterOnGround;

		// Token: 0x04013060 RID: 77920
		public static readonly FName GlobalCameraPosAndRadius;

		// Token: 0x04013061 RID: 77921
		public static readonly FName UseSocketTransform;

		// Token: 0x04013062 RID: 77922
		public static readonly FName UseClipboardTransform;

		// Token: 0x04013063 RID: 77923
		public static readonly FName UseSocketTransform2;

		// Token: 0x04013064 RID: 77924
		public static readonly FName UseClipboardTransform2;

		// Token: 0x04013065 RID: 77925
		public static readonly FName PhysicsActor;

		// Token: 0x04013066 RID: 77926
		public static readonly FName WaterCollisionProfileName;

		// Token: 0x04013067 RID: 77927
		public static readonly FName UIShowBrightness;

		// Token: 0x04013068 RID: 77928
		public static readonly FName UIShowSaturation;

		// Token: 0x04013069 RID: 77929
		public static readonly FName UIShowContrast;

		// Token: 0x0401306A RID: 77930
		public static readonly FName GlobalTimeHour;

		// Token: 0x0401306B RID: 77931
		public static readonly FName GlobalTimeMinutes;

		// Token: 0x0401306C RID: 77932
		public static readonly FName GravityDirection;

		// Token: 0x0401306D RID: 77933
		public static readonly FName IsPlayerMale;

		// Token: 0x0401306E RID: 77934
		public const int IdMaterialContainer = 1;

		// Token: 0x0401306F RID: 77935
		public const int IdMaterialController = 2;

		// Token: 0x04013070 RID: 77936
		public const int IdDitherEffect = 3;

		// Token: 0x04013071 RID: 77937
		public const int IdBadSignal = 4;

		// Token: 0x04013072 RID: 77938
		public const int IdSceneInteraction = 5;

		// Token: 0x04013073 RID: 77939
		public const int IdPropertyModifier = 6;

		// Token: 0x04013074 RID: 77940
		public const int IdComplexBroken = 7;

		// Token: 0x04013075 RID: 77941
		public const int IdNpcDitherEffect = 8;

		// Token: 0x04013076 RID: 77942
		public const int IdBodyEffect = 9;

		// Token: 0x04013077 RID: 77943
		public const int IdDecalShadow = 10;

		// Token: 0x04013078 RID: 77944
		public const int IdGrassInteraction = 11;

		// Token: 0x04013079 RID: 77945
		public const int IdExtraMesh = 12;

		// Token: 0x0401307A RID: 77946
		public const int IdMaterialContainerV2 = 13;

		// Token: 0x0401307B RID: 77947
		public const int IdMaterialControllerV2 = 14;

		// Token: 0x0401307C RID: 77948
		public const int IdEnviInteractionEffect = 15;

		// Token: 0x0401307D RID: 77949
		public const string EmptyMaterialPath = "/Game/Aki/Render/Shaders/Character/MI_Empty";

		// Token: 0x0401307E RID: 77950
		public static readonly FName E_Action_UseBaseColorScale;

		// Token: 0x0401307F RID: 77951
		public static readonly FName E_Action_BaseColorScale;

		// Token: 0x04013080 RID: 77952
		public static readonly FName E_Action_UseEmissionColor;

		// Token: 0x04013081 RID: 77953
		public static readonly FName E_Action_EmissionColor;

		// Token: 0x04013082 RID: 77954
		public static readonly FName E_Action_UseRimLight;

		// Token: 0x04013083 RID: 77955
		public static readonly FName E_Action_RimLightColor;

		// Token: 0x04013084 RID: 77956
		public static readonly FName E_Action_RimPower;

		// Token: 0x04013085 RID: 77957
		public static readonly FName E_Action_UseEmissionChange;

		// Token: 0x04013086 RID: 77958
		public static readonly FName E_Action_EmissionLightColorChangeColor;

		// Token: 0x04013087 RID: 77959
		public static readonly FName E_Action_EmissionLightColorChangeStrength;

		// Token: 0x04013088 RID: 77960
		public static readonly FName E_Action_EmissionLightColorChangeProgress;

		// Token: 0x04013089 RID: 77961
		public static readonly FName E_Action_UseDissolve;

		// Token: 0x0401308A RID: 77962
		public static readonly FName E_Action_DissolveProgress;

		// Token: 0x0401308B RID: 77963
		public static readonly FName E_Action_DissolveAdjustment;

		// Token: 0x0401308C RID: 77964
		public static readonly FName E_Action_DissolveEdageWidth;

		// Token: 0x0401308D RID: 77965
		public static readonly FName E_Action_DissolveEdageColor;

		// Token: 0x0401308E RID: 77966
		public static readonly FName E_Action_DissolveEdageStrength;

		// Token: 0x0401308F RID: 77967
		public static readonly FName E_Action_DissolveTex_S_O;

		// Token: 0x04013090 RID: 77968
		public static readonly FName E_Action_DissolveTexSpeed;

		// Token: 0x04013091 RID: 77969
		public static readonly FName E_Tex_DissolveTexUVSwitch;

		// Token: 0x04013092 RID: 77970
		public static readonly FName E_Action_ScanningOutlineMixNoiseStrength;

		// Token: 0x04013093 RID: 77971
		public static readonly FName E_Action_GlobalBaseColorScale;

		// Token: 0x04013094 RID: 77972
		public static readonly FName E_Action_GlobalAddEmissionColor;

		// Token: 0x04013095 RID: 77973
		public static readonly FName E_Action_ScanningOutline;

		// Token: 0x04013096 RID: 77974
		public static readonly FName E_Action_GlobalRimLight;

		// Token: 0x04013097 RID: 77975
		public static readonly FName E_Action_UseScanning;

		// Token: 0x04013098 RID: 77976
		public static readonly FName E_Action_RimMix;

		// Token: 0x04013099 RID: 77977
		public static readonly FName E_Action_ScanningOutlineStrength;

		// Token: 0x0401309A RID: 77978
		public static readonly FName E_Action_ScanningTex_S_O;

		// Token: 0x0401309B RID: 77979
		public static readonly FName E_Action_ScanningOutlineColor;

		// Token: 0x0401309C RID: 77980
		public static readonly FName E_Action_RimWidth;

		// Token: 0x0401309D RID: 77981
		public static readonly FName BrokenTex_S_O;

		// Token: 0x0401309E RID: 77982
		public static readonly FName OutlineTex_S_O;

		// Token: 0x0401309F RID: 77983
		public static readonly FName E_Action_VertexAnim_TimeDebug;

		// Token: 0x040130A0 RID: 77984
		public static readonly FName E_Action_VertexAnim_Frame;

		// Token: 0x040130A1 RID: 77985
		public static readonly FName E_Action_PivotPainterTransform;

		// Token: 0x040130A2 RID: 77986
		public static readonly FName E_Action_PivotPainter_FloatingThreshold;

		// Token: 0x040130A3 RID: 77987
		public static readonly FName E_Action_UsePivotPainterWorldPositionOffset;

		// Token: 0x040130A4 RID: 77988
		public static readonly FName E_Action_UseWPO;

		// Token: 0x040130A5 RID: 77989
		public static readonly FName E_Action_DisableFoliageEffect;

		// Token: 0x040130A6 RID: 77990
		public static readonly FName E_Action_EnableFoliageEffect;

		// Token: 0x040130A7 RID: 77991
		public static readonly FName E_Action_RimLightColorSpecil;

		// Token: 0x040130A8 RID: 77992
		public static readonly FName E_Action_UseRimlightColorSpecil;

		// Token: 0x040130A9 RID: 77993
		public static readonly FName E_Action_RimlightColorStrength;

		// Token: 0x040130AA RID: 77994
		public static readonly FName E_Action_SimpleWPO_Normal;

		// Token: 0x040130AB RID: 77995
		public static readonly FName E_Action_SimpleWPO_Offset;

		// Token: 0x040130AC RID: 77996
		public static readonly FName E_Action_UseEmissionTex;

		// Token: 0x040130AD RID: 77997
		public static readonly FName E_Action_EmissionTexStrength;

		// Token: 0x040130AE RID: 77998
		public static readonly FName E_Action_Simple_Uspeed;

		// Token: 0x040130AF RID: 77999
		public static readonly FName E_Action_Simple_Vspeed;

		// Token: 0x040130B0 RID: 78000
		public static readonly FName E_Action_Simple_UseFlow;

		// Token: 0x040130B1 RID: 78001
		public static readonly FName E_Action_UseQuanXiPinTu;

		// Token: 0x040130B2 RID: 78002
		public static readonly FName E_Action_TransparencyQuanXiPinTu;

		// Token: 0x040130B3 RID: 78003
		public static readonly FName E_Action_TransparentColorQuanXiPinTu;

		// Token: 0x040130B4 RID: 78004
		public static readonly FName E_Action_OpaqueColorQuanXiPinTu;

		// Token: 0x040130B5 RID: 78005
		public static readonly FName E_Action_UseQuanXiFengSuo;

		// Token: 0x040130B6 RID: 78006
		public static readonly FName E_Action_TransparencyQuanXiFengSuo;

		// Token: 0x040130B7 RID: 78007
		public static readonly FName E_Action_TransparentColorQuanXiFengSuo;
	}
}
