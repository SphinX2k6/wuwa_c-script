using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045B7 RID: 17847
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlDataCache
	{
		// Token: 0x0602E052 RID: 188498 RVA: 0x00A994C0 File Offset: 0x00A976C0
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

		// Token: 0x04018935 RID: 100661
		public PD_CharacterControllerData_C Data;

		// Token: 0x04018936 RID: 100662
		public string DataName;

		// Token: 0x04018937 RID: 100663
		public int RefCount;

		// Token: 0x04018938 RID: 100664
		public Stat StatCharMaterialControlCacheData;

		// Token: 0x04018939 RID: 100665
		public Stat StatCharMaterialControlUpdate;

		// Token: 0x0401893A RID: 100666
		public float WholeLoopTime;

		// Token: 0x0401893B RID: 100667
		public float DataLoopEnd;

		// Token: 0x0401893C RID: 100668
		public float DataLoopStart;

		// Token: 0x0401893D RID: 100669
		public float DataLoopTime;

		// Token: 0x0401893E RID: 100670
		public bool IgnoreTimeDilation;

		// Token: 0x0401893F RID: 100671
		public bool MaskOriginEffect;

		// Token: 0x04018940 RID: 100672
		public ECharacterControllerType? DataType;

		// Token: 0x04018941 RID: 100673
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<string> OtherCases;

		// Token: 0x04018942 RID: 100674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<string> WeaponCases;

		// Token: 0x04018943 RID: 100675
		public ECharacterMeshPart[] SpecifiedParts;

		// Token: 0x04018944 RID: 100676
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] CustomPartNames;

		// Token: 0x04018945 RID: 100677
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] CustomExcludePartNames;

		// Token: 0x04018946 RID: 100678
		public bool HiddenAfterEffect;

		// Token: 0x04018947 RID: 100679
		public ECharacterBodySpecifiedType? SpecifiedBodyType;

		// Token: 0x04018948 RID: 100680
		public ECharacterSlotSpecifiedType? SpecifiedSlotType;

		// Token: 0x04018949 RID: 100681
		public ECharacterControllerApplyType? MaterialModifyType;

		// Token: 0x0401894A RID: 100682
		public bool UseRim;

		// Token: 0x0401894B RID: 100683
		public CharMaterialControlFloatGroup RimRange;

		// Token: 0x0401894C RID: 100684
		public CharMaterialControlColorGroup RimColor;

		// Token: 0x0401894D RID: 100685
		public CharMaterialControlFloatGroup RimIntensity;

		// Token: 0x0401894E RID: 100686
		public int RimUseTex;

		// Token: 0x0401894F RID: 100687
		public FLinearColor? RimChannel;

		// Token: 0x04018950 RID: 100688
		public bool RimRevertProperty;

		// Token: 0x04018951 RID: 100689
		public bool UseDissolve;

		// Token: 0x04018952 RID: 100690
		public FLinearColor? DissolveChannel;

		// Token: 0x04018953 RID: 100691
		public CharMaterialControlFloatGroup DissolveProgress;

		// Token: 0x04018954 RID: 100692
		public CharMaterialControlFloatGroup DissolveSmooth;

		// Token: 0x04018955 RID: 100693
		public CharMaterialControlFloatGroup DissolveColorIntensity;

		// Token: 0x04018956 RID: 100694
		public CharMaterialControlColorGroup DissolveColor;

		// Token: 0x04018957 RID: 100695
		public bool DissolveRevertProperty;

		// Token: 0x04018958 RID: 100696
		public bool UseOutline;

		// Token: 0x04018959 RID: 100697
		public bool OutlineRevertProperty;

		// Token: 0x0401895A RID: 100698
		public float OutlineUseTex;

		// Token: 0x0401895B RID: 100699
		public bool UseOuterOutlineEffect;

		// Token: 0x0401895C RID: 100700
		public CharMaterialControlFloatGroup OutlineWidth;

		// Token: 0x0401895D RID: 100701
		public CharMaterialControlColorGroup OutlineColor;

		// Token: 0x0401895E RID: 100702
		public CharMaterialControlFloatGroup OutlineIntensity;

		// Token: 0x0401895F RID: 100703
		public UMaterialInterface ReplaceMaterialInterface;

		// Token: 0x04018960 RID: 100704
		public bool UseParameterModify;

		// Token: 0x04018961 RID: 100705
		public FName[] ColorParameterNames;

		// Token: 0x04018962 RID: 100706
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlColorGroup[] ColorParameterValues;

		// Token: 0x04018963 RID: 100707
		public FName[] FloatParameterNames;

		// Token: 0x04018964 RID: 100708
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlFloatGroup[] FloatParameterValues;

		// Token: 0x04018965 RID: 100709
		public bool RevertMaterial;

		// Token: 0x04018966 RID: 100710
		public CharMaterialControlColorGroup BaseColor;

		// Token: 0x04018967 RID: 100711
		public CharMaterialControlColorGroup EmissionColor;

		// Token: 0x04018968 RID: 100712
		public CharMaterialControlFloatGroup EmissionIntensity;

		// Token: 0x04018969 RID: 100713
		public CharMaterialControlFloatGroup BaseColorIntensity;

		// Token: 0x0401896A RID: 100714
		public float BaseUseTex;

		// Token: 0x0401896B RID: 100715
		public float EmissionUseTex;

		// Token: 0x0401896C RID: 100716
		public bool UseColor;

		// Token: 0x0401896D RID: 100717
		public bool ColorRevertProperty;

		// Token: 0x0401896E RID: 100718
		public bool UseTextureSample;

		// Token: 0x0401896F RID: 100719
		public UTexture2D MaskTexture;

		// Token: 0x04018970 RID: 100720
		public FLinearColor? UvSelection;

		// Token: 0x04018971 RID: 100721
		public float UseScreenUv;

		// Token: 0x04018972 RID: 100722
		public CharMaterialControlColorGroup TextureScaleAndOffset;

		// Token: 0x04018973 RID: 100723
		public CharMaterialControlColorGroup TextureSpeed;

		// Token: 0x04018974 RID: 100724
		public CharMaterialControlColorGroup TextureColorTint;

		// Token: 0x04018975 RID: 100725
		public CharMaterialControlFloatGroup Rotation;

		// Token: 0x04018976 RID: 100726
		public float UseAlphaToMask;

		// Token: 0x04018977 RID: 100727
		public CharMaterialControlFloatGroup TextureMaskRange;

		// Token: 0x04018978 RID: 100728
		public bool TextureSampleRevertProperty;

		// Token: 0x04018979 RID: 100729
		public bool UseMotionOffset;

		// Token: 0x0401897A RID: 100730
		public float MotionAffectVertexRange;

		// Token: 0x0401897B RID: 100731
		public float MotionOffsetLength;

		// Token: 0x0401897C RID: 100732
		public CharMaterialControlFloatGroup MotionNoiseSpeed;

		// Token: 0x0401897D RID: 100733
		public bool MotionOffsetRevertProperty;

		// Token: 0x0401897E RID: 100734
		public bool UseDitherEffect;

		// Token: 0x0401897F RID: 100735
		public CharMaterialControlFloatGroup DitherValue;

		// Token: 0x04018980 RID: 100736
		public bool DitherRevertProperty;

		// Token: 0x04018981 RID: 100737
		public bool UseCustomMaterialEffect;

		// Token: 0x04018982 RID: 100738
		public bool CustomRevertProperty;

		// Token: 0x04018983 RID: 100739
		public FName[] CustomColorParameterNames;

		// Token: 0x04018984 RID: 100740
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlColorGroup[] CustomColorParameterValues;

		// Token: 0x04018985 RID: 100741
		public FName[] CustomFloatParameterNames;

		// Token: 0x04018986 RID: 100742
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlFloatGroup[] CustomFloatParameterValues;

		// Token: 0x04018987 RID: 100743
		public FName[] CustomTextureParameterNames;

		// Token: 0x04018988 RID: 100744
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialControlTextureGroup[] CustomTextureParameterValues;
	}
}
