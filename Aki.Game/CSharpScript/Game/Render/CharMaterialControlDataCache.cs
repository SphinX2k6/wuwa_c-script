using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034DF RID: 13535
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlDataCache
	{
		// Token: 0x0602273C RID: 141116 RVA: 0x009C56E0 File Offset: 0x009C38E0
		[NullableContext(1)]
		public unsafe CharMaterialControlDataCache(string dataName, PD_CharacterControllerData_C data)
		{
			this.Data = data;
			this.DataName = dataName;
			string empty = string.Empty;
			<>y__InlineArray2<string> <>y__InlineArray = default(<>y__InlineArray2<string>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<string>, string>(ref <>y__InlineArray, 0) = "Render_CharMaterialControlUpdate_";
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<string>, string>(ref <>y__InlineArray, 1) = dataName;
			this.StatCharMaterialControlUpdate = Stat.CreateNoFlameGraph(string.Join(empty, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<string>, string>(<>y__InlineArray, 2)), "", "");
			string empty2 = string.Empty;
			<>y__InlineArray2<string> <>y__InlineArray2 = default(<>y__InlineArray2<string>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<string>, string>(ref <>y__InlineArray2, 0) = "Render_CharMaterialControlCacheData_";
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<string>, string>(ref <>y__InlineArray2, 1) = dataName;
			this.StatCharMaterialControlCacheData = Stat.CreateNoFlameGraph(string.Join(empty2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<string>, string>(<>y__InlineArray2, 2)), "", "");
			this.RefCount = 0;
			this.MaskOriginEffect = data.MaskOriginEffect;
			this.DataType = new ECharacterControllerType?(data.DataType);
			SMaterialControllerLoopTime loopTime = data.LoopTime;
			this.DataLoopEnd = loopTime.End;
			this.DataLoopStart = loopTime.Start;
			this.DataLoopTime = loopTime.Loop;
			this.WholeLoopTime = this.DataLoopStart + this.DataLoopTime + this.DataLoopEnd;
			this.IgnoreTimeDilation = data.IgnoreTimeDilation;
			this.SpecifiedBodyType = new ECharacterBodySpecifiedType?(data.SpecifiedBodyType);
			this.SpecifiedSlotType = new ECharacterSlotSpecifiedType?(data.SpecifiedSlotType);
			this.MaterialModifyType = new ECharacterControllerApplyType?(data.MaterialModifyType);
			TArray<string> otherCases = data.OtherCases;
			int num = otherCases.Num();
			if (num > 0)
			{
				this.OtherCases = new HashSet<string>();
				for (int i = 0; i < num; i++)
				{
					this.OtherCases.Add(otherCases.Get(i));
				}
			}
			TArray<string> weaponCases = data.WeaponCases;
			num = weaponCases.Num();
			if (num > 0)
			{
				this.WeaponCases = new HashSet<string>();
				for (int j = 0; j < num; j++)
				{
					this.WeaponCases.Add(weaponCases.Get(j));
				}
			}
			TArray<TEnumAsByte<ECharacterMeshPart>> specifiedParts = data.SpecifiedParts;
			num = specifiedParts.Num();
			if (num > 0)
			{
				this.SpecifiedParts = new ECharacterMeshPart[num];
				for (int k = 0; k < num; k++)
				{
					this.SpecifiedParts[k] = specifiedParts.Get(k);
				}
			}
			TArray<string> customPartNames = data.CustomPartNames;
			num = customPartNames.Num();
			if (num > 0)
			{
				this.CustomPartNames = new string[num];
				for (int l = 0; l < num; l++)
				{
					this.CustomPartNames[l] = customPartNames.Get(l);
				}
			}
			TArray<string> customExcludePartNames = data.CustomExcludePartNames;
			num = customExcludePartNames.Num();
			if (num > 0)
			{
				this.CustomExcludePartNames = new string[num];
				for (int m = 0; m < num; m++)
				{
					this.CustomExcludePartNames[m] = customExcludePartNames.Get(m);
				}
			}
			this.UseRim = data.UseRim;
			if (this.UseRim)
			{
				this.RimUseTex = ((data.RimUseTex > false) ? 1 : 0);
				this.RimChannel = new FLinearColor?(RenderUtil.GetSelectedChannel(data.RimChannel));
				this.RimRevertProperty = data.RimRevertProperty_DEPRECATED;
				SMaterialControllerFloatGroup rimRange = data.RimRange;
				this.RimRange = new CharMaterialControlFloatGroup(rimRange.End, rimRange.Loop, rimRange.Start);
				SMaterialControllerColorGroup rimColor = data.RimColor;
				this.RimColor = new CharMaterialControlColorGroup(rimColor.End, rimColor.Loop, rimColor.Start);
				SMaterialControllerFloatGroup rimIntensity = data.RimIntensity;
				this.RimIntensity = new CharMaterialControlFloatGroup(rimIntensity.End, rimIntensity.Loop, rimIntensity.Start);
			}
			this.UseDissolve = data.UseDissolve;
			if (this.UseDissolve)
			{
				if (data.DissolveChannel == ECharacterControllerChannelSwitch.RGB)
				{
					this.DissolveChannel = new FLinearColor?(new FLinearColor(1f, 0f, 0f, 0f));
				}
				else
				{
					this.DissolveChannel = new FLinearColor?(RenderUtil.GetSelectedChannel(data.DissolveChannel));
				}
				SMaterialControllerFloatGroup dissolveProgress = data.DissolveProgress;
				this.DissolveProgress = new CharMaterialControlFloatGroup(dissolveProgress.End, dissolveProgress.Loop, dissolveProgress.Start);
				SMaterialControllerFloatGroup dissolveSmooth = data.DissolveSmooth;
				this.DissolveSmooth = new CharMaterialControlFloatGroup(dissolveSmooth.End, dissolveSmooth.Loop, dissolveSmooth.Start);
				SMaterialControllerFloatGroup dissolveColorIntensity = data.DissolveColorIntensity;
				this.DissolveColorIntensity = new CharMaterialControlFloatGroup(dissolveColorIntensity.End, dissolveColorIntensity.Loop, dissolveColorIntensity.Start);
				SMaterialControllerColorGroup dissolveColor = data.DissolveColor;
				this.DissolveColor = new CharMaterialControlColorGroup(dissolveColor.End, dissolveColor.Loop, dissolveColor.Start);
				this.DissolveRevertProperty = data.DissolveRevertProperty_DEPRECATED;
			}
			this.UseOutline = data.UseOutline;
			if (this.UseOutline)
			{
				this.OutlineRevertProperty = data.OutlineRevertProperty_DEPRECATED;
				this.OutlineUseTex = (data.OutlineUseTex > false);
				this.UseOuterOutlineEffect = data.UseOuterOutlineEffect;
				SMaterialControllerFloatGroup outlineWidth = data.OutlineWidth;
				this.OutlineWidth = new CharMaterialControlFloatGroup(outlineWidth.End, outlineWidth.Loop, outlineWidth.Start);
				SMaterialControllerColorGroup outlineColor = data.OutlineColor;
				this.OutlineColor = new CharMaterialControlColorGroup(outlineColor.End, outlineColor.Loop, outlineColor.Start);
				SMaterialControllerFloatGroup outlineIntensity = data.OutlineIntensity;
				this.OutlineIntensity = new CharMaterialControlFloatGroup(outlineIntensity.End, outlineIntensity.Loop, outlineIntensity.Start);
			}
			if (GlobalData.IsEs3 && data.MobileUseDifferentMaterial && data.ReplaceMaterialMobile != null)
			{
				this.ReplaceMaterialInterface = data.ReplaceMaterialMobile;
			}
			else
			{
				this.ReplaceMaterialInterface = data.ReplaceMaterial;
			}
			if (this.ReplaceMaterialInterface != null)
			{
				this.UseParameterModify = data.UseParameterModify;
				this.RevertMaterial = data.RevertMaterial_DEPRECATED;
				TArray<SMaterialControllerColorParameter> colorParameters = data.ColorParameters;
				num = colorParameters.Num();
				if (num > 0)
				{
					this.ColorParameterNames = new FName[num];
					List<CharMaterialControlColorGroup> list = new List<CharMaterialControlColorGroup>();
					List<FName> list2 = new List<FName>();
					for (int n = 0; n < num; n++)
					{
						SMaterialControllerColorParameter smaterialControllerColorParameter = colorParameters.Get(n);
						if (!smaterialControllerColorParameter.ParameterName.Equals(FNameUtil.NONE))
						{
							list2.Add(smaterialControllerColorParameter.ParameterName);
							SMaterialControllerColorGroup parameterValue = smaterialControllerColorParameter.ParameterValue;
							list.Add(new CharMaterialControlColorGroup(parameterValue.End, parameterValue.Loop, parameterValue.Start));
						}
					}
					this.ColorParameterNames = list2.ToArray();
					this.ColorParameterValues = list.ToArray();
				}
				TArray<SMaterialControllerFloatParameter> floatParameters = data.FloatParameters;
				num = floatParameters.Num();
				if (num > 0)
				{
					this.FloatParameterNames = new FName[num];
					List<CharMaterialControlFloatGroup> list3 = new List<CharMaterialControlFloatGroup>();
					List<FName> list4 = new List<FName>();
					for (int num2 = 0; num2 < num; num2++)
					{
						SMaterialControllerFloatParameter smaterialControllerFloatParameter = floatParameters.Get(num2);
						if (!smaterialControllerFloatParameter.ParameterName.Equals(FNameUtil.NONE))
						{
							list4.Add(smaterialControllerFloatParameter.ParameterName);
							SMaterialControllerFloatGroup parameterValue2 = smaterialControllerFloatParameter.ParameterValue;
							list3.Add(new CharMaterialControlFloatGroup(parameterValue2.End, parameterValue2.Loop, parameterValue2.Start));
						}
					}
					this.FloatParameterNames = list4.ToArray();
					this.FloatParameterValues = list3.ToArray();
				}
			}
			this.UseColor = data.UseColor;
			if (this.UseColor)
			{
				SMaterialControllerColorGroup baseColor = data.BaseColor;
				this.BaseColor = new CharMaterialControlColorGroup(baseColor.End, baseColor.Loop, baseColor.Start);
				SMaterialControllerColorGroup emissionColor = data.EmissionColor;
				this.EmissionColor = new CharMaterialControlColorGroup(emissionColor.End, emissionColor.Loop, emissionColor.Start);
				SMaterialControllerFloatGroup emissionIntensity = data.EmissionIntensity;
				this.EmissionIntensity = new CharMaterialControlFloatGroup(emissionIntensity.End, emissionIntensity.Loop, emissionIntensity.Start);
				SMaterialControllerFloatGroup baseColorIntensity = data.BaseColorIntensity;
				this.BaseColorIntensity = new CharMaterialControlFloatGroup(baseColorIntensity.End, baseColorIntensity.Loop, baseColorIntensity.Start);
				this.BaseUseTex = (data.BaseUseTex > false);
				this.EmissionUseTex = (data.EmissionUseTex > false);
				this.ColorRevertProperty = data.ColorRevertProperty_DEPRECATED;
			}
			this.UseTextureSample = data.UseTextureSample;
			if (this.UseTextureSample)
			{
				this.MaskTexture = data.MaskTexture;
				this.UseScreenUv = 0f;
				switch (data.UVSelection)
				{
				case AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController.ECharacterControllerUVSwitch.UV1:
					this.UvSelection = new FLinearColor?(new FLinearColor(1f, 0f, 0f, 0f));
					break;
				case AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController.ECharacterControllerUVSwitch.UV2:
					this.UvSelection = new FLinearColor?(new FLinearColor(0f, 1f, 0f, 0f));
					break;
				case AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController.ECharacterControllerUVSwitch.UV3:
					this.UvSelection = new FLinearColor?(new FLinearColor(0f, 0f, 1f, 0f));
					break;
				case AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController.ECharacterControllerUVSwitch.UV4:
					this.UvSelection = new FLinearColor?(new FLinearColor(0f, 0f, 0f, 1f));
					break;
				case AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController.ECharacterControllerUVSwitch.ScreenUV:
					this.UseScreenUv = 1f;
					this.UvSelection = new FLinearColor?(new FLinearColor(0f, 0f, 0f, 0f));
					break;
				default:
					this.UvSelection = new FLinearColor?(new FLinearColor(0f, 0f, 0f, 0f));
					break;
				}
				SMaterialControllerColorGroup textureScaleAndOffset = data.TextureScaleAndOffset;
				this.TextureScaleAndOffset = new CharMaterialControlColorGroup(textureScaleAndOffset.End, textureScaleAndOffset.Loop, textureScaleAndOffset.Start);
				SMaterialControllerColorGroup textureSpeed = data.TextureSpeed;
				this.TextureSpeed = new CharMaterialControlColorGroup(textureSpeed.End, textureSpeed.Loop, textureSpeed.Start);
				SMaterialControllerColorGroup textureColorTint = data.TextureColorTint;
				this.TextureColorTint = new CharMaterialControlColorGroup(textureColorTint.End, textureColorTint.Loop, textureColorTint.Start);
				SMaterialControllerFloatGroup rotation = data.Rotation;
				this.Rotation = new CharMaterialControlFloatGroup(rotation.End, rotation.Loop, rotation.Start);
				SMaterialControllerFloatGroup textureMaskRange = data.TextureMaskRange;
				this.TextureMaskRange = new CharMaterialControlFloatGroup(textureMaskRange.End, textureMaskRange.Loop, textureMaskRange.Start);
				this.UseAlphaToMask = (data.UseAlphaToMask > false);
				this.TextureSampleRevertProperty = data.TextureSampleRevertProperty;
			}
			this.UseMotionOffset = data.UseMotionOffset;
			if (this.UseMotionOffset)
			{
				this.MotionAffectVertexRange = data.MotionAffectVertexRange;
				this.MotionOffsetLength = data.MotionOffsetLength;
				SMaterialControllerFloatGroup motionNoiseSpeed = data.MotionNoiseSpeed;
				this.MotionNoiseSpeed = new CharMaterialControlFloatGroup(motionNoiseSpeed.End, motionNoiseSpeed.Loop, motionNoiseSpeed.Start);
				this.MotionOffsetRevertProperty = data.MotionOffsetRevertProperty_DEPRECATED;
			}
			this.UseDitherEffect = data.UseDitherEffect;
			if (this.UseDitherEffect)
			{
				SMaterialControllerFloatGroup ditherValue = data.DitherValue;
				this.DitherValue = new CharMaterialControlFloatGroup(ditherValue.End, ditherValue.Loop, ditherValue.Start);
				this.DitherRevertProperty = data.DitherRevertProperty_DEPRECATED;
			}
			this.UseCustomMaterialEffect = data.UseCustomMaterialEffect;
			if (this.UseCustomMaterialEffect)
			{
				this.CustomRevertProperty = data.CustomRevertProperty_DEPRECATED;
				TArray<SMaterialControllerColorParameter> customColorParameters = data.CustomColorParameters;
				num = customColorParameters.Num();
				if (num > 0)
				{
					List<FName> list5 = new List<FName>();
					List<CharMaterialControlColorGroup> list6 = new List<CharMaterialControlColorGroup>();
					for (int num3 = 0; num3 < num; num3++)
					{
						SMaterialControllerColorParameter smaterialControllerColorParameter2 = customColorParameters.Get(num3);
						if (!smaterialControllerColorParameter2.ParameterName.Equals(FNameUtil.NONE))
						{
							list5.Add(smaterialControllerColorParameter2.ParameterName);
							SMaterialControllerColorGroup parameterValue3 = smaterialControllerColorParameter2.ParameterValue;
							list6.Add(new CharMaterialControlColorGroup(parameterValue3.End, parameterValue3.Loop, parameterValue3.Start));
						}
					}
					this.CustomColorParameterNames = list5.ToArray();
					this.CustomColorParameterValues = list6.ToArray();
				}
				TArray<SMaterialControllerFloatParameter> customFloatParameters = data.CustomFloatParameters;
				num = customFloatParameters.Num();
				if (num > 0)
				{
					List<FName> list7 = new List<FName>();
					List<CharMaterialControlFloatGroup> list8 = new List<CharMaterialControlFloatGroup>();
					for (int num4 = 0; num4 < num; num4++)
					{
						SMaterialControllerFloatParameter smaterialControllerFloatParameter2 = customFloatParameters.Get(num4);
						if (!smaterialControllerFloatParameter2.ParameterName.Equals(FNameUtil.NONE))
						{
							list7.Add(smaterialControllerFloatParameter2.ParameterName);
							SMaterialControllerFloatGroup parameterValue4 = smaterialControllerFloatParameter2.ParameterValue;
							list8.Add(new CharMaterialControlFloatGroup(parameterValue4.End, parameterValue4.Loop, parameterValue4.Start));
						}
					}
					this.CustomFloatParameterNames = list7.ToArray();
					this.CustomFloatParameterValues = list8.ToArray();
				}
				TArray<SMaterialControllerTextureParameter> customTextureParameters = data.CustomTextureParameters;
				num = customTextureParameters.Num();
				if (num > 0)
				{
					List<FName> list9 = new List<FName>();
					List<CharMaterialControlTextureGroup> list10 = new List<CharMaterialControlTextureGroup>();
					for (int num5 = 0; num5 < num; num5++)
					{
						SMaterialControllerTextureParameter smaterialControllerTextureParameter = customTextureParameters.Get(num5);
						if (!smaterialControllerTextureParameter.ParameterName.Equals(FNameUtil.NONE))
						{
							list9.Add(smaterialControllerTextureParameter.ParameterName);
							SMaterialControllerTextureGroup parameterValue5 = smaterialControllerTextureParameter.ParameterValue;
							list10.Add(new CharMaterialControlTextureGroup(parameterValue5.End, parameterValue5.Loop, parameterValue5.Start));
						}
					}
					this.CustomTextureParameterNames = list9.ToArray();
					this.CustomTextureParameterValues = list10.ToArray();
				}
			}
			this.HiddenAfterEffect = data.HiddenAfterEffect;
		}

		// Token: 0x04012F70 RID: 77680
		public PD_CharacterControllerData_C Data;

		// Token: 0x04012F71 RID: 77681
		public string DataName;

		// Token: 0x04012F72 RID: 77682
		public int RefCount;

		// Token: 0x04012F73 RID: 77683
		public Stat StatCharMaterialControlCacheData;

		// Token: 0x04012F74 RID: 77684
		public Stat StatCharMaterialControlUpdate;

		// Token: 0x04012F75 RID: 77685
		public float WholeLoopTime;

		// Token: 0x04012F76 RID: 77686
		public float DataLoopEnd;

		// Token: 0x04012F77 RID: 77687
		public float DataLoopStart;

		// Token: 0x04012F78 RID: 77688
		public float DataLoopTime;

		// Token: 0x04012F79 RID: 77689
		public bool IgnoreTimeDilation;

		// Token: 0x04012F7A RID: 77690
		public bool MaskOriginEffect;

		// Token: 0x04012F7B RID: 77691
		public ECharacterControllerType? DataType;

		// Token: 0x04012F7C RID: 77692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<string> OtherCases;

		// Token: 0x04012F7D RID: 77693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<string> WeaponCases;

		// Token: 0x04012F7E RID: 77694
		public ECharacterMeshPart[] SpecifiedParts;

		// Token: 0x04012F7F RID: 77695
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] CustomPartNames;

		// Token: 0x04012F80 RID: 77696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] CustomExcludePartNames;

		// Token: 0x04012F81 RID: 77697
		public bool HiddenAfterEffect;

		// Token: 0x04012F82 RID: 77698
		public ECharacterBodySpecifiedType? SpecifiedBodyType;

		// Token: 0x04012F83 RID: 77699
		public ECharacterSlotSpecifiedType? SpecifiedSlotType;

		// Token: 0x04012F84 RID: 77700
		public ECharacterControllerApplyType? MaterialModifyType;

		// Token: 0x04012F85 RID: 77701
		public bool UseRim;

		// Token: 0x04012F86 RID: 77702
		public CharMaterialControlFloatGroup RimRange;

		// Token: 0x04012F87 RID: 77703
		public CharMaterialControlColorGroup RimColor;

		// Token: 0x04012F88 RID: 77704
		public CharMaterialControlFloatGroup RimIntensity;

		// Token: 0x04012F89 RID: 77705
		public int RimUseTex;

		// Token: 0x04012F8A RID: 77706
		public FLinearColor? RimChannel;

		// Token: 0x04012F8B RID: 77707
		public bool RimRevertProperty;

		// Token: 0x04012F8C RID: 77708
		public bool UseDissolve;

		// Token: 0x04012F8D RID: 77709
		public FLinearColor? DissolveChannel;

		// Token: 0x04012F8E RID: 77710
		public CharMaterialControlFloatGroup DissolveProgress;

		// Token: 0x04012F8F RID: 77711
		public CharMaterialControlFloatGroup DissolveSmooth;

		// Token: 0x04012F90 RID: 77712
		public CharMaterialControlFloatGroup DissolveColorIntensity;

		// Token: 0x04012F91 RID: 77713
		public CharMaterialControlColorGroup DissolveColor;

		// Token: 0x04012F92 RID: 77714
		public bool DissolveRevertProperty;

		// Token: 0x04012F93 RID: 77715
		public bool UseOutline;

		// Token: 0x04012F94 RID: 77716
		public bool OutlineRevertProperty;

		// Token: 0x04012F95 RID: 77717
		public float OutlineUseTex;

		// Token: 0x04012F96 RID: 77718
		public bool UseOuterOutlineEffect;

		// Token: 0x04012F97 RID: 77719
		public CharMaterialControlFloatGroup OutlineWidth;

		// Token: 0x04012F98 RID: 77720
		public CharMaterialControlColorGroup OutlineColor;

		// Token: 0x04012F99 RID: 77721
		public CharMaterialControlFloatGroup OutlineIntensity;

		// Token: 0x04012F9A RID: 77722
		public UMaterialInterface ReplaceMaterialInterface;

		// Token: 0x04012F9B RID: 77723
		public bool UseParameterModify;

		// Token: 0x04012F9C RID: 77724
		public FName[] ColorParameterNames;

		// Token: 0x04012F9D RID: 77725
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlColorGroup[] ColorParameterValues;

		// Token: 0x04012F9E RID: 77726
		public FName[] FloatParameterNames;

		// Token: 0x04012F9F RID: 77727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlFloatGroup[] FloatParameterValues;

		// Token: 0x04012FA0 RID: 77728
		public bool RevertMaterial;

		// Token: 0x04012FA1 RID: 77729
		public CharMaterialControlColorGroup BaseColor;

		// Token: 0x04012FA2 RID: 77730
		public CharMaterialControlColorGroup EmissionColor;

		// Token: 0x04012FA3 RID: 77731
		public CharMaterialControlFloatGroup EmissionIntensity;

		// Token: 0x04012FA4 RID: 77732
		public CharMaterialControlFloatGroup BaseColorIntensity;

		// Token: 0x04012FA5 RID: 77733
		public float BaseUseTex;

		// Token: 0x04012FA6 RID: 77734
		public float EmissionUseTex;

		// Token: 0x04012FA7 RID: 77735
		public bool UseColor;

		// Token: 0x04012FA8 RID: 77736
		public bool ColorRevertProperty;

		// Token: 0x04012FA9 RID: 77737
		public bool UseTextureSample;

		// Token: 0x04012FAA RID: 77738
		public UTexture2D MaskTexture;

		// Token: 0x04012FAB RID: 77739
		public FLinearColor? UvSelection;

		// Token: 0x04012FAC RID: 77740
		public float UseScreenUv;

		// Token: 0x04012FAD RID: 77741
		public CharMaterialControlColorGroup TextureScaleAndOffset;

		// Token: 0x04012FAE RID: 77742
		public CharMaterialControlColorGroup TextureSpeed;

		// Token: 0x04012FAF RID: 77743
		public CharMaterialControlColorGroup TextureColorTint;

		// Token: 0x04012FB0 RID: 77744
		public CharMaterialControlFloatGroup Rotation;

		// Token: 0x04012FB1 RID: 77745
		public float UseAlphaToMask;

		// Token: 0x04012FB2 RID: 77746
		public CharMaterialControlFloatGroup TextureMaskRange;

		// Token: 0x04012FB3 RID: 77747
		public bool TextureSampleRevertProperty;

		// Token: 0x04012FB4 RID: 77748
		public bool UseMotionOffset;

		// Token: 0x04012FB5 RID: 77749
		public float MotionAffectVertexRange;

		// Token: 0x04012FB6 RID: 77750
		public float MotionOffsetLength;

		// Token: 0x04012FB7 RID: 77751
		public CharMaterialControlFloatGroup MotionNoiseSpeed;

		// Token: 0x04012FB8 RID: 77752
		public bool MotionOffsetRevertProperty;

		// Token: 0x04012FB9 RID: 77753
		public bool UseDitherEffect;

		// Token: 0x04012FBA RID: 77754
		public CharMaterialControlFloatGroup DitherValue;

		// Token: 0x04012FBB RID: 77755
		public bool DitherRevertProperty;

		// Token: 0x04012FBC RID: 77756
		public bool UseCustomMaterialEffect;

		// Token: 0x04012FBD RID: 77757
		public bool CustomRevertProperty;

		// Token: 0x04012FBE RID: 77758
		public FName[] CustomColorParameterNames;

		// Token: 0x04012FBF RID: 77759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlColorGroup[] CustomColorParameterValues;

		// Token: 0x04012FC0 RID: 77760
		public FName[] CustomFloatParameterNames;

		// Token: 0x04012FC1 RID: 77761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlFloatGroup[] CustomFloatParameterValues;

		// Token: 0x04012FC2 RID: 77762
		public FName[] CustomTextureParameterNames;

		// Token: 0x04012FC3 RID: 77763
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlTextureGroup[] CustomTextureParameterValues;
	}
}
