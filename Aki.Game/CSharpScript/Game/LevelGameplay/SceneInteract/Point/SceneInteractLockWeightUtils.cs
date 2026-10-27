using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point
{
	// Token: 0x02006A85 RID: 27269
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractLockWeightUtils
	{
		// Token: 0x06043C4A RID: 277578 RVA: 0x01096384 File Offset: 0x01094584
		[NullableContext(2)]
		public static double GetLockWeight(IExploreSkillSearchTargetCfg config, Vector location, [Nullable(1)] Vector charLoc)
		{
			if (config == null)
			{
				return 0.0;
			}
			IEnterScreenWeight enterScreenWeight = config as IEnterScreenWeight;
			if (enterScreenWeight == null)
			{
				IAngleWeight angleWeight = config as IAngleWeight;
				if (angleWeight != null)
				{
					if (config.Type == EExploreSkillSearchTargetCfg.AngleWeight)
					{
						return SceneInteractLockWeightUtils.CalcAngleWeight(angleWeight, location, charLoc);
					}
				}
			}
			else if (config.Type == EExploreSkillSearchTargetCfg.EnterScreenWeight)
			{
				return (double)enterScreenWeight.Weight;
			}
			return 0.0;
		}

		// Token: 0x06043C4B RID: 277579 RVA: 0x010963E4 File Offset: 0x010945E4
		public static string BuildLockWeightDebugText([Nullable(2)] IExploreSkillSearchTargetCfg config, [Nullable(2)] Vector location, Vector charLoc)
		{
			if (config == null)
			{
				return "无SearchTargetCfg -> W=0";
			}
			IEnterScreenWeight enterScreenWeight = config as IEnterScreenWeight;
			if (enterScreenWeight == null)
			{
				IAngleWeight angleWeight = config as IAngleWeight;
				if (angleWeight != null)
				{
					if (config.Type == EExploreSkillSearchTargetCfg.AngleWeight)
					{
						return SceneInteractLockWeightUtils.BuildAngleWeightDebugText(angleWeight, location, charLoc);
					}
				}
			}
			else if (config.Type == EExploreSkillSearchTargetCfg.EnterScreenWeight)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("固定权重 -> W=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(enterScreenWeight.Weight);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return "未知打分类型 -> W=0";
		}

		// Token: 0x06043C4C RID: 277580 RVA: 0x0109645C File Offset: 0x0109465C
		private static double CalcAngleWeight(IAngleWeight lockConfig, [Nullable(2)] Vector location, Vector charLoc)
		{
			if (location == null)
			{
				return -3.402823466E+38;
			}
			double dot = SceneInteractLockWeightUtils.CalcCameraDot(location, charLoc);
			int num = SceneInteractLockWeightUtils.MatchAngleIndex(lockConfig, dot);
			if (num < 0)
			{
				return -3.402823466E+38;
			}
			double dist = Vector.Dist(location, charLoc) / 100.0;
			return (double)lockConfig.AngleWeight[num].Weight * SceneInteractLockWeightUtils.CalcDistWeight(dist);
		}

		// Token: 0x06043C4D RID: 277581 RVA: 0x010964C0 File Offset: 0x010946C0
		private static string BuildAngleWeightDebugText(IAngleWeight lockConfig, [Nullable(2)] Vector location, Vector charLoc)
		{
			if (location == null)
			{
				return "无位置 -> W=-Max";
			}
			double num = SceneInteractLockWeightUtils.CalcCameraDot(location, charLoc);
			double value = Math.Acos(Math.Min(1.0, Math.Max(-1.0, num))) * 57.295780181884766;
			string value2 = string.Join(",", lockConfig.AngleWeight.ConvertAll<string>(delegate([Nullable(1)] IEntityAngleWeight v)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler2.AppendFormatted<int>(v.Angle);
				defaultInterpolatedStringHandler2.AppendLiteral("°:");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(v.Weight);
				return defaultInterpolatedStringHandler2.ToStringAndClear();
			}));
			int num2 = SceneInteractLockWeightUtils.MatchAngleIndex(lockConfig, num);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (num2 < 0)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendLiteral("夹角=");
				defaultInterpolatedStringHandler.AppendFormatted<double>(value, "F1");
				defaultInterpolatedStringHandler.AppendLiteral("° 超出区间[");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				defaultInterpolatedStringHandler.AppendLiteral("] -> W=-Max");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			IEntityAngleWeight entityAngleWeight = lockConfig.AngleWeight[num2];
			int weight = entityAngleWeight.Weight;
			double num3 = Vector.Dist(location, charLoc) / 100.0;
			double num4 = SceneInteractLockWeightUtils.CalcDistWeight(num3);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 11);
			defaultInterpolatedStringHandler.AppendLiteral("夹角=");
			defaultInterpolatedStringHandler.AppendFormatted<double>(value, "F1");
			defaultInterpolatedStringHandler.AppendLiteral("° 命中区间");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityAngleWeight.Angle);
			defaultInterpolatedStringHandler.AppendLiteral("° 角度权重=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(weight);
			defaultInterpolatedStringHandler.AppendLiteral(" [");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("]\n");
			defaultInterpolatedStringHandler.AppendLiteral("距离=");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num3, "F1");
			defaultInterpolatedStringHandler.AppendLiteral("m 距离权重=max(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(60);
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num3, "F1");
			defaultInterpolatedStringHandler.AppendLiteral(",1)=");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num4, "F1");
			defaultInterpolatedStringHandler.AppendLiteral(" -> W=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(weight);
			defaultInterpolatedStringHandler.AppendLiteral("x");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num4, "F1");
			defaultInterpolatedStringHandler.AppendLiteral("=");
			defaultInterpolatedStringHandler.AppendFormatted<double>((double)weight * num4, "F1");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06043C4E RID: 277582 RVA: 0x010966F4 File Offset: 0x010948F4
		private static double CalcCameraDot(Vector location, Vector charLoc)
		{
			Vector char2SelfDir = SceneInteractLockWeightUtils.Char2SelfDir;
			char2SelfDir.DeepCopy(location);
			char2SelfDir.SubtractionEqual(charLoc);
			char2SelfDir.Normalize(9.99999993922529E-09);
			Vector cameraDir = SceneInteractLockWeightUtils.CameraDir;
			CameraController.Instance.MainModel.CameraRotator.Vector(cameraDir);
			cameraDir.Normalize(9.99999993922529E-09);
			return Vector.DotProduct(char2SelfDir, cameraDir);
		}

		// Token: 0x06043C4F RID: 277583 RVA: 0x01096758 File Offset: 0x01094958
		private static int MatchAngleIndex(IAngleWeight lockConfig, double dot)
		{
			int result = -1;
			for (int i = 0; i < lockConfig.AngleWeight.Count; i++)
			{
				if (dot > Math.Cos((double)((float)lockConfig.AngleWeight[i].Angle * 0.017453292f)))
				{
					result = i;
				}
			}
			return result;
		}

		// Token: 0x06043C50 RID: 277584 RVA: 0x010967A1 File Offset: 0x010949A1
		private static double CalcDistWeight(double dist)
		{
			if (60.0 - dist >= 1.0)
			{
				return 60.0 - dist;
			}
			return 1.0;
		}

		// Token: 0x0402367B RID: 145019
		private const int DEFAULT_MAX_DISTANCE = 60;

		// Token: 0x0402367C RID: 145020
		[StaticVariableRuleIgnore]
		private static readonly Vector Char2SelfDir = Vector.Create();

		// Token: 0x0402367D RID: 145021
		[StaticVariableRuleIgnore]
		private static readonly Vector CameraDir = Vector.Create();
	}
}
