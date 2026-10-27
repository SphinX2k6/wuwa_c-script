using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045ED RID: 17901
	[NullableContext(1)]
	[Nullable(0)]
	public class RenderUtil : IStaticVariableResetter
	{
		// Token: 0x0602E2AB RID: 189099 RVA: 0x00AABF52 File Offset: 0x00AAA152
		static RenderUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RenderUtil.CreateStaticDefaultValue), new Action(RenderUtil.ResetStaticDefaultValue));
		}

		// Token: 0x0602E2AC RID: 189100 RVA: 0x00AABF71 File Offset: 0x00AAA171
		public static void CreateStaticDefaultValue()
		{
			RenderUtil.PsoSyncModeDepth = 0;
		}

		// Token: 0x0602E2AD RID: 189101 RVA: 0x00AABF79 File Offset: 0x00AAA179
		public static void ResetStaticDefaultValue()
		{
			RenderUtil.PsoSyncModeDepth = 0;
		}

		// Token: 0x0602E2AE RID: 189102 RVA: 0x00AABF84 File Offset: 0x00AAA184
		public static CharRenderBase[] GetRenderComps(ECharacterRenderingType renderType, bool useMaterialContainerV2, bool monsterUseBodyEffect)
		{
			List<CharRenderBase> list = new List<CharRenderBase>();
			if (useMaterialContainerV2)
			{
				list.Add(new CharMaterialControllerV2());
				list.Add(new CharMaterialContainerV2());
			}
			else
			{
				list.Add(new CharMaterialController());
				list.Add(new CharMaterialContainer());
			}
			switch (renderType)
			{
			case ECharacterRenderingType.LocalPlayer:
				list.Add(new CharDitherEffect());
				list.Add(new CharSceneInteraction());
				list.Add(new CharPropertyModifier());
				list.Add(new CharBodyEffect());
				list.Add(new CharDecalShadow());
				list.Add(new CharGrassInteraction());
				list.Add(new CharEnviInteractionEffect());
				break;
			case ECharacterRenderingType.RemotePlayer:
				list.Add(new CharDitherEffect());
				list.Add(new CharSceneInteraction());
				list.Add(new CharPropertyModifier());
				list.Add(new CharBodyEffect());
				list.Add(new CharDecalShadow());
				list.Add(new CharGrassInteraction());
				list.Add(new CharEnviInteractionEffect());
				break;
			case ECharacterRenderingType.Monster:
				list.Add(new CharDitherEffect());
				list.Add(new CharSceneInteraction());
				list.Add(new CharPropertyModifier());
				list.Add(new CharDecalShadow());
				list.Add(new CharGrassInteraction());
				if (monsterUseBodyEffect)
				{
					list.Add(new CharBodyEffect());
				}
				break;
			case ECharacterRenderingType.Npc:
				list.Add(new CharDitherEffect());
				list.Add(new CharDecalShadow());
				list.Add(new CharGrassInteraction());
				break;
			case ECharacterRenderingType.Pet:
				list.Add(new CharDitherEffect());
				list.Add(new CharSceneInteraction());
				list.Add(new CharDecalShadow());
				break;
			case ECharacterRenderingType.UI:
				list.Add(new CharDitherEffect());
				break;
			case ECharacterRenderingType.Default:
				list.Add(new CharDitherEffect());
				break;
			case ECharacterRenderingType.Effect:
				list.Add(new CharDitherEffect());
				break;
			}
			return list.ToArray();
		}

		// Token: 0x0602E2AF RID: 189103 RVA: 0x00AAC156 File Offset: 0x00AAA356
		public static float GetFloat(FKuroCurveFloat curveFloat, float factor)
		{
			return UKuroCurveLibrary.GetValue_Float(curveFloat, factor);
		}

		// Token: 0x0602E2B0 RID: 189104 RVA: 0x00AAC160 File Offset: 0x00AAA360
		public static FLinearColor GetColor(FKuroCurveLinearColor curveColor, float factor)
		{
			return UKuroCurveLibrary.GetValue_LinearColor(curveColor, factor);
		}

		// Token: 0x0602E2B1 RID: 189105 RVA: 0x00AAC16C File Offset: 0x00AAA36C
		public static float GetFloatFromGroup(CharMaterialControlFloatGroup floatInfo, InterpolateFactor factor)
		{
			switch (factor.Type)
			{
			case EInterpolateRangeType.Start:
				if (floatInfo.StartConstant != null)
				{
					return floatInfo.StartConstant.Value;
				}
				return RenderUtil.GetFloat(floatInfo.Start, factor.Factor);
			case EInterpolateRangeType.Loop:
				if (floatInfo.LoopConstant != null)
				{
					return floatInfo.LoopConstant.Value;
				}
				return RenderUtil.GetFloat(floatInfo.Loop, factor.Factor);
			case EInterpolateRangeType.End:
				if (floatInfo.EndConstant != null)
				{
					return floatInfo.EndConstant.Value;
				}
				return RenderUtil.GetFloat(floatInfo.End, factor.Factor);
			default:
				return floatInfo.Loop.Constant;
			}
		}

		// Token: 0x0602E2B2 RID: 189106 RVA: 0x00AAC224 File Offset: 0x00AAA424
		public static FLinearColor GetColorFromGroup(CharMaterialControlColorGroup colorInfo, InterpolateFactor factor)
		{
			switch (factor.Type)
			{
			case EInterpolateRangeType.Start:
				if (colorInfo.StartConstant != null)
				{
					return colorInfo.StartConstant.Value;
				}
				return RenderUtil.GetColor(colorInfo.Start, factor.Factor);
			case EInterpolateRangeType.Loop:
				if (colorInfo.LoopConstant != null)
				{
					return colorInfo.LoopConstant.Value;
				}
				return RenderUtil.GetColor(colorInfo.Loop, factor.Factor);
			case EInterpolateRangeType.End:
				if (colorInfo.EndConstant != null)
				{
					return colorInfo.EndConstant.Value;
				}
				return RenderUtil.GetColor(colorInfo.End, factor.Factor);
			default:
				return colorInfo.Loop.Constant;
			}
		}

		// Token: 0x0602E2B3 RID: 189107 RVA: 0x00AAC2DC File Offset: 0x00AAA4DC
		[return: Nullable(2)]
		public static UTexture2D GetTextureFromGroup(CharMaterialControlTextureGroup textureInfo, InterpolateFactor factor)
		{
			switch (factor.Type)
			{
			case EInterpolateRangeType.Start:
				return textureInfo.Start;
			case EInterpolateRangeType.Loop:
				return textureInfo.Loop;
			case EInterpolateRangeType.End:
				return textureInfo.End;
			default:
				return null;
			}
		}

		// Token: 0x0602E2B4 RID: 189108 RVA: 0x00AAC31A File Offset: 0x00AAA51A
		public static double Lerp(double a, double b, double alpha)
		{
			return a + alpha * (b - a);
		}

		// Token: 0x0602E2B5 RID: 189109 RVA: 0x00AAC323 File Offset: 0x00AAA523
		public static double Max(double a, double b)
		{
			if (a <= b)
			{
				return b;
			}
			return a;
		}

		// Token: 0x0602E2B6 RID: 189110 RVA: 0x00AAC32C File Offset: 0x00AAA52C
		public static double Min(double a, double b)
		{
			if (a >= b)
			{
				return b;
			}
			return a;
		}

		// Token: 0x0602E2B7 RID: 189111 RVA: 0x00AAC338 File Offset: 0x00AAA538
		public static double Clamp(double value, double min, double max)
		{
			double num = value;
			if (num <= min)
			{
				num = min;
			}
			if (num >= max)
			{
				num = max;
			}
			return num;
		}

		// Token: 0x0602E2B8 RID: 189112 RVA: 0x00AAC354 File Offset: 0x00AAA554
		public static void LerpVector(FVectorDouble from, FVectorDouble to, double alpha, double[] ret)
		{
			double alpha2 = RenderUtil.Clamp(alpha, 0.0, 1.0);
			ret[0] = RenderUtil.Lerp(from.X, to.X, alpha2);
			ret[1] = RenderUtil.Lerp(from.Y, to.Y, alpha2);
			ret[2] = RenderUtil.Lerp(from.Z, to.Z, alpha2);
		}

		// Token: 0x0602E2B9 RID: 189113 RVA: 0x00AAC3B9 File Offset: 0x00AAA5B9
		public static bool StringIsNullOrEmpty(string value)
		{
			return string.IsNullOrEmpty(value);
		}

		// Token: 0x0602E2BA RID: 189114 RVA: 0x00AAC3C4 File Offset: 0x00AAA5C4
		public static FLinearColor GetSelectedChannel(ECharacterControllerChannelSwitch channel)
		{
			switch (channel)
			{
			case ECharacterControllerChannelSwitch.RGB:
				return new FLinearColor(-1f, 0f, 0f, 0f);
			case ECharacterControllerChannelSwitch.R:
				return new FLinearColor(1f, 0f, 0f, 0f);
			case ECharacterControllerChannelSwitch.G:
				return new FLinearColor(0f, 1f, 0f, 0f);
			case ECharacterControllerChannelSwitch.B:
				return new FLinearColor(0f, 0f, 1f, 0f);
			case ECharacterControllerChannelSwitch.A:
				return new FLinearColor(0f, 0f, 0f, 1f);
			default:
				return new FLinearColor(0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x0602E2BB RID: 189115 RVA: 0x00AAC48B File Offset: 0x00AAA68B
		public static void OpenToonSceneShadow()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.ToonSceneShadowIntensity 1", null);
		}

		// Token: 0x0602E2BC RID: 189116 RVA: 0x00AAC4A5 File Offset: 0x00AAA6A5
		public static void CloseToonSceneShadow()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.ToonSceneShadowIntensity 0", null);
		}

		// Token: 0x0602E2BD RID: 189117 RVA: 0x00AAC4BF File Offset: 0x00AAA6BF
		public static void OpenMobileSpotLightShadow()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.EnableKuroSpotlightsShadow 1", null);
		}

		// Token: 0x0602E2BE RID: 189118 RVA: 0x00AAC4D9 File Offset: 0x00AAA6D9
		public static void CloseMobileSpotLightShadow()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.EnableKuroSpotlightsShadow 0", null);
		}

		// Token: 0x0602E2BF RID: 189119 RVA: 0x00AAC4F3 File Offset: 0x00AAA6F3
		public static void CloseVelocityScreenSizeCull()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.VelocityScreenSizeCull 0", null);
		}

		// Token: 0x0602E2C0 RID: 189120 RVA: 0x00AAC50D File Offset: 0x00AAA70D
		public static void EnableVelocityScreenSizeCull()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.VelocityScreenSizeCull 0.01", null);
		}

		// Token: 0x0602E2C1 RID: 189121 RVA: 0x00AAC528 File Offset: 0x00AAA728
		public static void BeginPSOSyncMode()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			RenderUtil.PsoSyncModeDepth++;
			if (RenderUtil.PsoSyncModeDepth > 1)
			{
				return;
			}
			Log.Instance.Info(ELogModule.RenderUtil, ELogAuthor.ZBK, "Begin pso sync mode", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.PSO.CompilationMode 1", null);
			if (Info.Instance.PlatformType == ESourcePlatformType.Android)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.OpenGL.ProgramBinarySyncCreate 1", null);
				return;
			}
			if (Info.Instance.PlatformType == ESourcePlatformType.Windows)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DX11AsyncCompileShader 0", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DX12PSOStreaming 0", null);
			}
		}

		// Token: 0x0602E2C2 RID: 189122 RVA: 0x00AAC5CC File Offset: 0x00AAA7CC
		public static void EndPSOSyncMode()
		{
			if (RenderUtil.PsoSyncModeDepth <= 0)
			{
				return;
			}
			RenderUtil.PsoSyncModeDepth--;
			if (RenderUtil.PsoSyncModeDepth > 0 || GlobalData.World == null)
			{
				return;
			}
			Log.Instance.Info(ELogModule.RenderUtil, ELogAuthor.ZBK, "End pso sync mode", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.PSO.CompilationMode 3", null);
			if (Info.Instance.PlatformType == ESourcePlatformType.Android)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.OpenGL.ProgramBinarySyncCreate 0", null);
				return;
			}
			if (Info.Instance.PlatformType == ESourcePlatformType.Windows)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DX11AsyncCompileShader 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DX12PSOStreaming 1", null);
			}
		}

		// Token: 0x0602E2C3 RID: 189123 RVA: 0x00AAC675 File Offset: 0x00AAA875
		public static void SetNeedRenderKuroToonDepth()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.NeedRenderKuroToonDepth 1", null);
		}

		// Token: 0x0602E2C4 RID: 189124 RVA: 0x00AAC687 File Offset: 0x00AAA887
		public static void UnsetNeedRenderKuroToonDepth()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.NeedRenderKuroToonDepth 0", null);
		}

		// Token: 0x04018C64 RID: 101476
		private static int PsoSyncModeDepth;
	}
}
