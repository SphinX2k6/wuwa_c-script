using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003516 RID: 13590
	[NullableContext(1)]
	[Nullable(0)]
	public class RenderUtil : IStaticVariableResetter
	{
		// Token: 0x060229A0 RID: 141728 RVA: 0x009D86EE File Offset: 0x009D68EE
		static RenderUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RenderUtil.CreateStaticDefaultValue), new Action(RenderUtil.ResetStaticDefaultValue));
		}

		// Token: 0x060229A1 RID: 141729 RVA: 0x009D870D File Offset: 0x009D690D
		public static void CreateStaticDefaultValue()
		{
			RenderUtil.PsoSyncModeDepth = 0;
		}

		// Token: 0x060229A2 RID: 141730 RVA: 0x009D8715 File Offset: 0x009D6915
		public static void ResetStaticDefaultValue()
		{
			RenderUtil.PsoSyncModeDepth = 0;
		}

		// Token: 0x060229A3 RID: 141731 RVA: 0x009D8720 File Offset: 0x009D6920
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

		// Token: 0x060229A4 RID: 141732 RVA: 0x009D88F2 File Offset: 0x009D6AF2
		public static float GetFloat(FKuroCurveFloat curveFloat, float factor)
		{
			return UKuroCurveLibrary.GetValue_Float(curveFloat, factor);
		}

		// Token: 0x060229A5 RID: 141733 RVA: 0x009D88FC File Offset: 0x009D6AFC
		public static FLinearColor GetColor(FKuroCurveLinearColor curveColor, float factor)
		{
			return UKuroCurveLibrary.GetValue_LinearColor(curveColor, factor);
		}

		// Token: 0x060229A6 RID: 141734 RVA: 0x009D8908 File Offset: 0x009D6B08
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

		// Token: 0x060229A7 RID: 141735 RVA: 0x009D89C0 File Offset: 0x009D6BC0
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

		// Token: 0x060229A8 RID: 141736 RVA: 0x009D8A78 File Offset: 0x009D6C78
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

		// Token: 0x060229A9 RID: 141737 RVA: 0x009D8AB6 File Offset: 0x009D6CB6
		public static double Lerp(double a, double b, double alpha)
		{
			return a + alpha * (b - a);
		}

		// Token: 0x060229AA RID: 141738 RVA: 0x009D8ABF File Offset: 0x009D6CBF
		public static double Max(double a, double b)
		{
			if (a <= b)
			{
				return b;
			}
			return a;
		}

		// Token: 0x060229AB RID: 141739 RVA: 0x009D8AC8 File Offset: 0x009D6CC8
		public static double Min(double a, double b)
		{
			if (a >= b)
			{
				return b;
			}
			return a;
		}

		// Token: 0x060229AC RID: 141740 RVA: 0x009D8AD4 File Offset: 0x009D6CD4
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

		// Token: 0x060229AD RID: 141741 RVA: 0x009D8AF0 File Offset: 0x009D6CF0
		public static void LerpVector(FVectorDouble from, FVectorDouble to, double alpha, double[] ret)
		{
			double alpha2 = RenderUtil.Clamp(alpha, 0.0, 1.0);
			ret[0] = RenderUtil.Lerp(from.X, to.X, alpha2);
			ret[1] = RenderUtil.Lerp(from.Y, to.Y, alpha2);
			ret[2] = RenderUtil.Lerp(from.Z, to.Z, alpha2);
		}

		// Token: 0x060229AE RID: 141742 RVA: 0x009D8B55 File Offset: 0x009D6D55
		public static bool StringIsNullOrEmpty(string value)
		{
			return string.IsNullOrEmpty(value);
		}

		// Token: 0x060229AF RID: 141743 RVA: 0x009D8B60 File Offset: 0x009D6D60
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

		// Token: 0x060229B0 RID: 141744 RVA: 0x009D8C27 File Offset: 0x009D6E27
		public static void OpenToonSceneShadow()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.ToonSceneShadowIntensity 1", null);
		}

		// Token: 0x060229B1 RID: 141745 RVA: 0x009D8C41 File Offset: 0x009D6E41
		public static void CloseToonSceneShadow()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.ToonSceneShadowIntensity 0", null);
		}

		// Token: 0x060229B2 RID: 141746 RVA: 0x009D8C5B File Offset: 0x009D6E5B
		public static void OpenMobileSpotLightShadow()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.EnableKuroSpotlightsShadow 1", null);
		}

		// Token: 0x060229B3 RID: 141747 RVA: 0x009D8C75 File Offset: 0x009D6E75
		public static void CloseMobileSpotLightShadow()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.EnableKuroSpotlightsShadow 0", null);
		}

		// Token: 0x060229B4 RID: 141748 RVA: 0x009D8C8F File Offset: 0x009D6E8F
		public static void CloseVelocityScreenSizeCull()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.VelocityScreenSizeCull 0", null);
		}

		// Token: 0x060229B5 RID: 141749 RVA: 0x009D8CA9 File Offset: 0x009D6EA9
		public static void EnableVelocityScreenSizeCull()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.VelocityScreenSizeCull 0.01", null);
		}

		// Token: 0x060229B6 RID: 141750 RVA: 0x009D8CC4 File Offset: 0x009D6EC4
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

		// Token: 0x060229B7 RID: 141751 RVA: 0x009D8D68 File Offset: 0x009D6F68
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

		// Token: 0x060229B8 RID: 141752 RVA: 0x009D8E11 File Offset: 0x009D7011
		public static void SetNeedRenderKuroToonDepth()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.NeedRenderKuroToonDepth 1", null);
		}

		// Token: 0x060229B9 RID: 141753 RVA: 0x009D8E23 File Offset: 0x009D7023
		public static void UnsetNeedRenderKuroToonDepth()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.NeedRenderKuroToonDepth 0", null);
		}

		// Token: 0x040132A3 RID: 78499
		private static int PsoSyncModeDepth;
	}
}
