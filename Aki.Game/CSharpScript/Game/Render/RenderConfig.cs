using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045C0 RID: 17856
	[NullableContext(1)]
	[Nullable(0)]
	public class RenderConfig : IStaticVariableResetter
	{
		// Token: 0x0602E099 RID: 188569 RVA: 0x00A9BE64 File Offset: 0x00A9A064
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

		// Token: 0x0602E09A RID: 188570 RVA: 0x00A9C833 File Offset: 0x00A9AA33
		public static string GenerateExtraMeshName(string sourceSkeletalName)
		{
			return sourceSkeletalName + "_ExtraMesh";
		}

		// Token: 0x0602E09B RID: 188571 RVA: 0x00A9C840 File Offset: 0x00A9AA40
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

		// Token: 0x0602E09C RID: 188572 RVA: 0x00A9C904 File Offset: 0x00A9AB04
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

		// Token: 0x0602E09D RID: 188573 RVA: 0x00A9C974 File Offset: 0x00A9AB74
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
						RenderConfig.MaterialControlAllCaseArray.ToArray<string>()
					},
					{
						ECharacterBodySpecifiedType.Body,
						RenderConfig.MaterialControlBodyCaseArray.ToArray<string>()
					},
					{
						ECharacterBodySpecifiedType.Weapon,
						RenderConfig.MaterialControlWeaponCaseArray.ToArray<string>()
					},
					{
						ECharacterBodySpecifiedType.Hulu,
						RenderConfig.MaterialControlHuluCaseArray.ToArray<string>()
					},
					{
						ECharacterBodySpecifiedType.Other,
						RenderConfig.MaterialControlOtherCaseArray.ToArray<string>()
					},
					{
						ECharacterBodySpecifiedType.WeaponAndHulu,
						RenderConfig.MaterialControlWeaponAndHuluCaseArray.ToArray<string>()
					},
					{
						ECharacterBodySpecifiedType.ExtraBody,
						RenderConfig.MaterialControlExtraBodyCaseArray.ToArray<string>()
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

		// Token: 0x0602E09E RID: 188574 RVA: 0x00A9CA20 File Offset: 0x00A9AC20
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

		// Token: 0x0602E09F RID: 188575 RVA: 0x00A9CA7C File Offset: 0x00A9AC7C
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

		// Token: 0x0602E0A0 RID: 188576 RVA: 0x00A9CBA6 File Offset: 0x00A9ADA6
		public static void CreateStaticDefaultValue()
		{
			RenderConfig.UseMaterialContainerV2 = true;
			RenderConfig.UseCharUnrealCacheObject = true;
		}

		// Token: 0x0602E0A1 RID: 188577 RVA: 0x00A9CBB4 File Offset: 0x00A9ADB4
		public static void ResetStaticDefaultValue()
		{
			RenderConfig.UseMaterialContainerV2 = true;
			RenderConfig.UseCharUnrealCacheObject = true;
			RenderConfig.MaterialControlBodyTypes = null;
			RenderConfig.EntityTypeToRenderPriorityMap = null;
			RenderConfig.SpecifiedTypeBodyNames = null;
		}

		// Token: 0x040189D3 RID: 100819
		public const int INVALID_SECTION_INDEX = 99999;

		// Token: 0x040189D4 RID: 100820
		public static bool UseMaterialContainerV2;

		// Token: 0x040189D5 RID: 100821
		public static bool UseCharUnrealCacheObject;

		// Token: 0x040189D6 RID: 100822
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

		// Token: 0x040189D7 RID: 100823
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlBodyCaseArray = new string[]
		{
			"CharacterMesh0"
		};

		// Token: 0x040189D8 RID: 100824
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlWeaponCaseArray = new string[]
		{
			"WeaponCase0",
			"WeaponCase1",
			"WeaponCase2",
			"WeaponCase3",
			"WeaponCase4"
		};

		// Token: 0x040189D9 RID: 100825
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlHuluCaseArray = new string[]
		{
			"HuluCase"
		};

		// Token: 0x040189DA RID: 100826
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

		// Token: 0x040189DB RID: 100827
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlOtherCaseArray = new string[]
		{
			"OtherCase0",
			"OtherCase1",
			"OtherCase2",
			"OtherCase3",
			"OtherCase4"
		};

		// Token: 0x040189DC RID: 100828
		[StaticVariableRuleIgnore]
		public static readonly string[] MaterialControlExtraBodyCaseArray = new string[]
		{
			"CharacterMesh0_ExtraMesh"
		};

		// Token: 0x040189DD RID: 100829
		[StaticVariableRuleIgnore]
		public static readonly EKuroCharMeshPart[] MeshPartsHeadArray;

		// Token: 0x040189DE RID: 100830
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, ECharacterBodyType> MaterialControlBodyTypes;

		// Token: 0x040189DF RID: 100831
		[Nullable(2)]
		private static Dictionary<EEntityType, EEntityTypePriority> EntityTypeToRenderPriorityMap;

		// Token: 0x040189E0 RID: 100832
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<ECharacterBodySpecifiedType, string[]> SpecifiedTypeBodyNames;

		// Token: 0x040189E1 RID: 100833
		public const string CharMaterialContainerDataPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/DA_CharacterMaterialContainerData.DA_CharacterMaterialContainerData";

		// Token: 0x040189E2 RID: 100834
		public const string HolographicPath = "/Game/Aki/Effect/EffectGroup/Sequence/Common/DA_Fx_Group_Seq_Communicate.DA_Fx_Group_Seq_Communicate";

		// Token: 0x040189E3 RID: 100835
		public const int RefErrorCount = 20;

		// Token: 0x040189E4 RID: 100836
		public static readonly FName UseRim;

		// Token: 0x040189E5 RID: 100837
		public static readonly FName RimUseTex;

		// Token: 0x040189E6 RID: 100838
		public static readonly FName RimChannel;

		// Token: 0x040189E7 RID: 100839
		public static readonly FName RimRange;

		// Token: 0x040189E8 RID: 100840
		public static readonly FName RimColor;

		// Token: 0x040189E9 RID: 100841
		public static readonly FName RimIntensity;

		// Token: 0x040189EA RID: 100842
		public static readonly FName UseDissolve;

		// Token: 0x040189EB RID: 100843
		public static readonly FName DissolveChannelSwitch;

		// Token: 0x040189EC RID: 100844
		public static readonly FName DissolveProgress;

		// Token: 0x040189ED RID: 100845
		public static readonly FName DissolveSmooth;

		// Token: 0x040189EE RID: 100846
		public static readonly FName DissolveMulti;

		// Token: 0x040189EF RID: 100847
		public static readonly FName DissolveEmission;

		// Token: 0x040189F0 RID: 100848
		public static readonly FName OutlineUseTex;

		// Token: 0x040189F1 RID: 100849
		public static readonly FName OutlineWidth;

		// Token: 0x040189F2 RID: 100850
		public static readonly FName OutlineColor;

		// Token: 0x040189F3 RID: 100851
		public static readonly FName OutlineColorIntensity;

		// Token: 0x040189F4 RID: 100852
		public static readonly FName UseTexture;

		// Token: 0x040189F5 RID: 100853
		public static readonly FName TextureUseMask;

		// Token: 0x040189F6 RID: 100854
		public static readonly FName TextureMaskRange;

		// Token: 0x040189F7 RID: 100855
		public static readonly FName NoiseTexture;

		// Token: 0x040189F8 RID: 100856
		public static readonly FName TextureUvSwitch;

		// Token: 0x040189F9 RID: 100857
		public static readonly FName TextureUseScreenUv;

		// Token: 0x040189FA RID: 100858
		public static readonly FName TextureScaleAndOffset;

		// Token: 0x040189FB RID: 100859
		public static readonly FName TextureSpeed;

		// Token: 0x040189FC RID: 100860
		public static readonly FName TextureColor;

		// Token: 0x040189FD RID: 100861
		public static readonly FName TextureRotation;

		// Token: 0x040189FE RID: 100862
		public static readonly FName BaseUseTex;

		// Token: 0x040189FF RID: 100863
		public static readonly FName BaseColor;

		// Token: 0x04018A00 RID: 100864
		public static readonly FName BaseColorIntensity;

		// Token: 0x04018A01 RID: 100865
		public static readonly FName EmissionUseTex;

		// Token: 0x04018A02 RID: 100866
		public static readonly FName EmissionColor;

		// Token: 0x04018A03 RID: 100867
		public static readonly FName EmissionIntensity;

		// Token: 0x04018A04 RID: 100868
		public static readonly FName UseHeadMaskHideEffect;

		// Token: 0x04018A05 RID: 100869
		public static readonly FName DitherUseInRayTracing;

		// Token: 0x04018A06 RID: 100870
		public static readonly FName UseDitherEffect;

		// Token: 0x04018A07 RID: 100871
		public static readonly FName DitherValue;

		// Token: 0x04018A08 RID: 100872
		public static readonly FName DitherValueMainPass;

		// Token: 0x04018A09 RID: 100873
		public static readonly FName UseDitherEffect2;

		// Token: 0x04018A0A RID: 100874
		public static readonly FName DitherValue2;

		// Token: 0x04018A0B RID: 100875
		public static readonly FName CharacterAmbientColor;

		// Token: 0x04018A0C RID: 100876
		public static readonly FName CharacterSkinAmbientColor;

		// Token: 0x04018A0D RID: 100877
		public static readonly FName EnableTransfer;

		// Token: 0x04018A0E RID: 100878
		public static readonly FName TransferDensity;

		// Token: 0x04018A0F RID: 100879
		public static readonly FName TransferHardness;

		// Token: 0x04018A10 RID: 100880
		public static readonly FName TransferDirection;

		// Token: 0x04018A11 RID: 100881
		public static readonly FName TransferHeight;

		// Token: 0x04018A12 RID: 100882
		public static readonly FName TransferOutlineColor;

		// Token: 0x04018A13 RID: 100883
		public static readonly FName MotionRange;

		// Token: 0x04018A14 RID: 100884
		public static readonly FName MotionOffset;

		// Token: 0x04018A15 RID: 100885
		public static readonly FName MotionNoiseSpeed;

		// Token: 0x04018A16 RID: 100886
		public static readonly FName StarScarEnergyControl;

		// Token: 0x04018A17 RID: 100887
		public static readonly FName TexMipOffset;

		// Token: 0x04018A18 RID: 100888
		public static readonly FName RootName;

		// Token: 0x04018A19 RID: 100889
		public static readonly FName UIName;

		// Token: 0x04018A1A RID: 100890
		public static readonly FName GlobalRainIntensity;

		// Token: 0x04018A1B RID: 100891
		public static readonly FName GlobalSnowIntensity;

		// Token: 0x04018A1C RID: 100892
		public static readonly FName GlobalWindSpeed;

		// Token: 0x04018A1D RID: 100893
		public static readonly FName GlobalGrassAO;

		// Token: 0x04018A1E RID: 100894
		public static readonly FName GlobalMainLightVector;

		// Token: 0x04018A1F RID: 100895
		public static readonly FName GlobalLensFlareColorTint;

		// Token: 0x04018A20 RID: 100896
		public static readonly FName GlobalCharacterPreviousWP;

		// Token: 0x04018A21 RID: 100897
		public static readonly FName GlobalCharacterWorldPosition;

		// Token: 0x04018A22 RID: 100898
		public static readonly FName GlobalCharacterWeaponPosition;

		// Token: 0x04018A23 RID: 100899
		public static readonly FName GlobalCharacterWorldForwardDirection;

		// Token: 0x04018A24 RID: 100900
		public static readonly FName GlobalCharacterOnGround;

		// Token: 0x04018A25 RID: 100901
		public static readonly FName GlobalCameraPosAndRadius;

		// Token: 0x04018A26 RID: 100902
		public static readonly FName UseSocketTransform;

		// Token: 0x04018A27 RID: 100903
		public static readonly FName UseClipboardTransform;

		// Token: 0x04018A28 RID: 100904
		public static readonly FName UseSocketTransform2;

		// Token: 0x04018A29 RID: 100905
		public static readonly FName UseClipboardTransform2;

		// Token: 0x04018A2A RID: 100906
		public static readonly FName PhysicsActor;

		// Token: 0x04018A2B RID: 100907
		public static readonly FName WaterCollisionProfileName;

		// Token: 0x04018A2C RID: 100908
		public static readonly FName UIShowBrightness;

		// Token: 0x04018A2D RID: 100909
		public static readonly FName UIShowSaturation;

		// Token: 0x04018A2E RID: 100910
		public static readonly FName UIShowContrast;

		// Token: 0x04018A2F RID: 100911
		public static readonly FName GlobalTimeHour;

		// Token: 0x04018A30 RID: 100912
		public static readonly FName GlobalTimeMinutes;

		// Token: 0x04018A31 RID: 100913
		public static readonly FName GravityDirection;

		// Token: 0x04018A32 RID: 100914
		public static readonly FName IsPlayerMale;

		// Token: 0x04018A33 RID: 100915
		public const int IdMaterialContainer = 1;

		// Token: 0x04018A34 RID: 100916
		public const int IdMaterialController = 2;

		// Token: 0x04018A35 RID: 100917
		public const int IdDitherEffect = 3;

		// Token: 0x04018A36 RID: 100918
		public const int IdBadSignal = 4;

		// Token: 0x04018A37 RID: 100919
		public const int IdSceneInteraction = 5;

		// Token: 0x04018A38 RID: 100920
		public const int IdPropertyModifier = 6;

		// Token: 0x04018A39 RID: 100921
		public const int IdComplexBroken = 7;

		// Token: 0x04018A3A RID: 100922
		public const int IdNpcDitherEffect = 8;

		// Token: 0x04018A3B RID: 100923
		public const int IdBodyEffect = 9;

		// Token: 0x04018A3C RID: 100924
		public const int IdDecalShadow = 10;

		// Token: 0x04018A3D RID: 100925
		public const int IdGrassInteraction = 11;

		// Token: 0x04018A3E RID: 100926
		public const int IdExtraMesh = 12;

		// Token: 0x04018A3F RID: 100927
		public const int IdMaterialContainerV2 = 13;

		// Token: 0x04018A40 RID: 100928
		public const int IdMaterialControllerV2 = 14;

		// Token: 0x04018A41 RID: 100929
		public const int IdEnviInteractionEffect = 15;

		// Token: 0x04018A42 RID: 100930
		public const string EmptyMaterialPath = "/Game/Aki/Render/Shaders/Character/MI_Empty";

		// Token: 0x04018A43 RID: 100931
		public static readonly FName E_Action_UseBaseColorScale;

		// Token: 0x04018A44 RID: 100932
		public static readonly FName E_Action_BaseColorScale;

		// Token: 0x04018A45 RID: 100933
		public static readonly FName E_Action_UseEmissionColor;

		// Token: 0x04018A46 RID: 100934
		public static readonly FName E_Action_EmissionColor;

		// Token: 0x04018A47 RID: 100935
		public static readonly FName E_Action_UseRimLight;

		// Token: 0x04018A48 RID: 100936
		public static readonly FName E_Action_RimLightColor;

		// Token: 0x04018A49 RID: 100937
		public static readonly FName E_Action_RimPower;

		// Token: 0x04018A4A RID: 100938
		public static readonly FName E_Action_UseEmissionChange;

		// Token: 0x04018A4B RID: 100939
		public static readonly FName E_Action_EmissionLightColorChangeColor;

		// Token: 0x04018A4C RID: 100940
		public static readonly FName E_Action_EmissionLightColorChangeStrength;

		// Token: 0x04018A4D RID: 100941
		public static readonly FName E_Action_EmissionLightColorChangeProgress;

		// Token: 0x04018A4E RID: 100942
		public static readonly FName E_Action_UseDissolve;

		// Token: 0x04018A4F RID: 100943
		public static readonly FName E_Action_DissolveProgress;

		// Token: 0x04018A50 RID: 100944
		public static readonly FName E_Action_DissolveAdjustment;

		// Token: 0x04018A51 RID: 100945
		public static readonly FName E_Action_DissolveEdageWidth;

		// Token: 0x04018A52 RID: 100946
		public static readonly FName E_Action_DissolveEdageColor;

		// Token: 0x04018A53 RID: 100947
		public static readonly FName E_Action_DissolveEdageStrength;

		// Token: 0x04018A54 RID: 100948
		public static readonly FName E_Action_DissolveTex_S_O;

		// Token: 0x04018A55 RID: 100949
		public static readonly FName E_Action_DissolveTexSpeed;

		// Token: 0x04018A56 RID: 100950
		public static readonly FName E_Tex_DissolveTexUVSwitch;

		// Token: 0x04018A57 RID: 100951
		public static readonly FName E_Action_ScanningOutlineMixNoiseStrength;

		// Token: 0x04018A58 RID: 100952
		public static readonly FName E_Action_GlobalBaseColorScale;

		// Token: 0x04018A59 RID: 100953
		public static readonly FName E_Action_GlobalAddEmissionColor;

		// Token: 0x04018A5A RID: 100954
		public static readonly FName E_Action_ScanningOutline;

		// Token: 0x04018A5B RID: 100955
		public static readonly FName E_Action_GlobalRimLight;

		// Token: 0x04018A5C RID: 100956
		public static readonly FName E_Action_UseScanning;

		// Token: 0x04018A5D RID: 100957
		public static readonly FName E_Action_RimMix;

		// Token: 0x04018A5E RID: 100958
		public static readonly FName E_Action_ScanningOutlineStrength;

		// Token: 0x04018A5F RID: 100959
		public static readonly FName E_Action_ScanningTex_S_O;

		// Token: 0x04018A60 RID: 100960
		public static readonly FName E_Action_ScanningOutlineColor;

		// Token: 0x04018A61 RID: 100961
		public static readonly FName E_Action_RimWidth;

		// Token: 0x04018A62 RID: 100962
		public static readonly FName BrokenTex_S_O;

		// Token: 0x04018A63 RID: 100963
		public static readonly FName OutlineTex_S_O;

		// Token: 0x04018A64 RID: 100964
		public static readonly FName E_Action_VertexAnim_TimeDebug;

		// Token: 0x04018A65 RID: 100965
		public static readonly FName E_Action_VertexAnim_Frame;

		// Token: 0x04018A66 RID: 100966
		public static readonly FName E_Action_PivotPainterTransform;

		// Token: 0x04018A67 RID: 100967
		public static readonly FName E_Action_PivotPainter_FloatingThreshold;

		// Token: 0x04018A68 RID: 100968
		public static readonly FName E_Action_UsePivotPainterWorldPositionOffset;

		// Token: 0x04018A69 RID: 100969
		public static readonly FName E_Action_UseWPO;

		// Token: 0x04018A6A RID: 100970
		public static readonly FName E_Action_DisableFoliageEffect;

		// Token: 0x04018A6B RID: 100971
		public static readonly FName E_Action_EnableFoliageEffect;

		// Token: 0x04018A6C RID: 100972
		public static readonly FName E_Action_RimLightColorSpecil;

		// Token: 0x04018A6D RID: 100973
		public static readonly FName E_Action_UseRimlightColorSpecil;

		// Token: 0x04018A6E RID: 100974
		public static readonly FName E_Action_RimlightColorStrength;

		// Token: 0x04018A6F RID: 100975
		public static readonly FName E_Action_SimpleWPO_Normal;

		// Token: 0x04018A70 RID: 100976
		public static readonly FName E_Action_SimpleWPO_Offset;

		// Token: 0x04018A71 RID: 100977
		public static readonly FName E_Action_UseEmissionTex;

		// Token: 0x04018A72 RID: 100978
		public static readonly FName E_Action_EmissionTexStrength;

		// Token: 0x04018A73 RID: 100979
		public static readonly FName E_Action_Simple_Uspeed;

		// Token: 0x04018A74 RID: 100980
		public static readonly FName E_Action_Simple_Vspeed;

		// Token: 0x04018A75 RID: 100981
		public static readonly FName E_Action_Simple_UseFlow;

		// Token: 0x04018A76 RID: 100982
		public static readonly FName E_Action_UseQuanXiPinTu;

		// Token: 0x04018A77 RID: 100983
		public static readonly FName E_Action_TransparencyQuanXiPinTu;

		// Token: 0x04018A78 RID: 100984
		public static readonly FName E_Action_TransparentColorQuanXiPinTu;

		// Token: 0x04018A79 RID: 100985
		public static readonly FName E_Action_OpaqueColorQuanXiPinTu;

		// Token: 0x04018A7A RID: 100986
		public static readonly FName E_Action_UseQuanXiFengSuo;

		// Token: 0x04018A7B RID: 100987
		public static readonly FName E_Action_TransparencyQuanXiFengSuo;

		// Token: 0x04018A7C RID: 100988
		public static readonly FName E_Action_TransparentColorQuanXiFengSuo;
	}
}
