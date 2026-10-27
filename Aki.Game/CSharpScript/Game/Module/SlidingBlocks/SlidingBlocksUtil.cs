using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using Aki.TDConfigMgr.Quest.Fb;
using Aki.TDConfigMgr.Wrapper.Out;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B83 RID: 19331
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidingBlocksUtil : IStaticVariableResetter
	{
		// Token: 0x06032192 RID: 205202 RVA: 0x00BA238E File Offset: 0x00BA058E
		static SlidingBlocksUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SlidingBlocksUtil.CreateStaticDefaultValue), new Action(SlidingBlocksUtil.ResetStaticDefaultValue));
		}

		// Token: 0x06032193 RID: 205203 RVA: 0x00BA23C8 File Offset: 0x00BA05C8
		[NullableContext(2)]
		private static Aki.TDConfigMgr.Quest.ITetrisBoard LoadTetrisBoardFromFb(int id)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
			defaultInterpolatedStringHandler.AppendFormatted(UBlueprintPathsLibrary.ProjectContentDir());
			defaultInterpolatedStringHandler.AppendLiteral("Aki/Config/UniverseEditorConfig/TetrisBoards/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(id);
			defaultInterpolatedStringHandler.AppendLiteral(".bytes");
			ByteBuffer byteBuffer = FbFileLoader.LoadBytes(defaultInterpolatedStringHandler.ToStringAndClear());
			if (byteBuffer == null)
			{
				return null;
			}
			return QuestReadHelper.ReadTCsvTetrisBoardData_Data(Aki.UniverseEditor.Interface.Fbs.Quest.TCsvTetrisBoardData.GetRootAsTCsvTetrisBoardData(byteBuffer));
		}

		// Token: 0x06032194 RID: 205204 RVA: 0x00BA2428 File Offset: 0x00BA0628
		public static string GetCoordKey(double x, double y)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(x);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(y);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06032195 RID: 205205 RVA: 0x00BA2464 File Offset: 0x00BA0664
		public static void FillMinoMapByIndexGridConfig(Vector2D gridSize, IReadOnlyList<Aki.TDConfigMgr.Quest.ITetrisSingleIndexGrid> gridsConfig, Action<string, double, double> callback)
		{
			foreach (Aki.TDConfigMgr.Quest.ITetrisSingleIndexGrid tetrisSingleIndexGrid in gridsConfig)
			{
				double floatCoord = Math.Floor((double)tetrisSingleIndexGrid.Index / gridSize.X);
				double floatCoord2 = (double)tetrisSingleIndexGrid.Index % gridSize.X;
				Aki.TDConfigMgr.Quest.ITetrisSingleBlock block = tetrisSingleIndexGrid.Value.Block;
				if (!StringUtils.IsBlank((block != null) ? block.StyleName : null))
				{
					double arg = SlidingBlocksUtil.ConvertConfigCoordToSmooth(floatCoord2);
					double arg2 = SlidingBlocksUtil.ConvertConfigCoordToSmooth(floatCoord);
					callback(tetrisSingleIndexGrid.Value.Block.StyleName, arg, arg2);
				}
			}
		}

		// Token: 0x06032196 RID: 205206 RVA: 0x00BA2510 File Offset: 0x00BA0710
		public static void FillMinoMapByGridConfig(IReadOnlyList<Aki.TDConfigMgr.Quest.ITetrisSingleGrid> gridsConfig, float boardSizeX, Action<string, double, double> callback)
		{
			int num = 0;
			int num2 = 0;
			foreach (Aki.TDConfigMgr.Quest.ITetrisSingleGrid tetrisSingleGrid in gridsConfig)
			{
				Aki.TDConfigMgr.Quest.ITetrisSingleBlock block = tetrisSingleGrid.Block;
				if (!StringUtils.IsBlank((block != null) ? block.StyleName : null))
				{
					double arg = SlidingBlocksUtil.ConvertConfigCoordToSmooth((double)num2);
					double arg2 = SlidingBlocksUtil.ConvertConfigCoordToSmooth((double)num);
					callback(tetrisSingleGrid.Block.StyleName, arg, arg2);
				}
				num2++;
				if ((float)num2 > boardSizeX - 1f)
				{
					num++;
					num2 = 0;
				}
			}
		}

		// Token: 0x06032197 RID: 205207 RVA: 0x00BA25AC File Offset: 0x00BA07AC
		[return: Nullable(2)]
		public static ITetrominoConfig GetTetrominoConfigByShapeName(string shapeName)
		{
			TetrisShapeConfig? config = ConfigTetrisShapeConfigByName.GetConfig(shapeName, true);
			if (config == null)
			{
				return null;
			}
			Aki.TDConfigMgr.Quest.ITetrisBoard tetrisBoard = WrapperSetting.UseFb ? SlidingBlocksUtil.TetrisBoardFbLru.Get(config.Value.Id) : Json.Parse<Aki.TDConfigMgr.Quest.ITetrisBoard>(config.Value.Shape, null);
			if (tetrisBoard == null)
			{
				return null;
			}
			return new TetrominoConfig
			{
				ShapeName = config.Value.Name,
				Type = Enum.Parse<SlidingBlocksDefine.ETetrominoType>(config.Value.LogicType),
				Board = tetrisBoard
			};
		}

		// Token: 0x06032198 RID: 205208 RVA: 0x00BA2644 File Offset: 0x00BA0844
		public static SlidingBlocksDefine.ETetrominoRotateState ConvertToTetrisRotationState(ETetrisRotation config)
		{
			SlidingBlocksDefine.ETetrominoRotateState result = SlidingBlocksDefine.ETetrominoRotateState.角度0;
			switch (config)
			{
			case ETetrisRotation.Origin:
				result = SlidingBlocksDefine.ETetrominoRotateState.角度0;
				break;
			case ETetrisRotation.Clockwise90:
				result = SlidingBlocksDefine.ETetrominoRotateState.角度90;
				break;
			case ETetrisRotation.Clockwise180:
				result = SlidingBlocksDefine.ETetrominoRotateState.角度180;
				break;
			case ETetrisRotation.Clockwise270:
				result = SlidingBlocksDefine.ETetrominoRotateState.角度270;
				break;
			}
			return result;
		}

		// Token: 0x06032199 RID: 205209 RVA: 0x00BA267C File Offset: 0x00BA087C
		[return: Nullable(2)]
		public static AActor CreateDynamicCube(string styleName, double smoothX, double smoothY, Transform originTransform, [Nullable(2)] UStaticMesh boxMesh)
		{
			if (boxMesh == null || !boxMesh.IsValid())
			{
				return null;
			}
			Transform transformByCoord = SlidingBlocksUtil.GetTransformByCoord(smoothX, smoothY, originTransform, null);
			AActor cubeActor = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
			AActor cubeActor3 = cubeActor;
			if (cubeActor3 == null || !cubeActor3.IsValid())
			{
				ActorSystem.Instance.Put("SlidingBlocksController.CreateDynamicCube fail", cubeActor, null);
				return null;
			}
			cubeActor.AddComponentByClass(USceneComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName));
			AActor cubeActor2 = cubeActor;
			FTransformDouble ftransformDouble = transformByCoord.ToUeTransform();
			cubeActor2.D_K2_SetActorTransform(ftransformDouble, false, null, true);
			UStaticMeshComponent staticMeshComp = cubeActor.AddComponentByClass(UStaticMeshComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UStaticMeshComponent;
			UStaticMeshComponent staticMeshComp2 = staticMeshComp;
			if (staticMeshComp2 != null && staticMeshComp2.IsValid())
			{
				staticMeshComp.SetStaticMesh(boxMesh);
				TetrisStyleConfig? config = ConfigTetrisStyleConfigByName.GetConfig(styleName, true);
				if (config != null)
				{
					if (ResourceSystem.Instance.CheckAssetLoaded<UMaterialInterface>(config.Value.MaterialPath))
					{
						UMaterialInterface loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UMaterialInterface>(config.Value.MaterialPath);
						UMaterialInstanceDynamic material = UKismetMaterialLibrary.CreateDynamicMaterialInstance(cubeActor, loadedAsset, default(FName), EMIDCreationFlags.None);
						staticMeshComp.SetMaterial(0, material);
					}
					else
					{
						ResourceSystem.Instance.LoadAsync<UMaterialInterface>(config.Value.MaterialPath, delegate([Nullable(2)] UMaterialInterface ret, string _)
						{
							UMaterialInstanceDynamic material2 = UKismetMaterialLibrary.CreateDynamicMaterialInstance(cubeActor, ret, default(FName), EMIDCreationFlags.None);
							staticMeshComp.SetMaterial(0, material2);
						}, 100, "js_undefined");
					}
				}
			}
			return cubeActor;
		}

		// Token: 0x0603219A RID: 205210 RVA: 0x00BA2846 File Offset: 0x00BA0A46
		public static bool DestroyCube(AActor cubeActor)
		{
			return ActorSystem.Instance.Put("SlidingBlocksUtil.DestroyCube", cubeActor, null);
		}

		// Token: 0x0603219B RID: 205211 RVA: 0x00BA285C File Offset: 0x00BA0A5C
		public static global::Vector GetWorldLocationByCoord(double smoothX, double smoothY, Transform originTransform, [Nullable(2)] global::Vector @out = null)
		{
			Bp_Tetris_C setting = SlidingBlocksGlobal.Setting;
			float num = ((setting != null) ? setting.CubeSize : 1.8f) * 100f;
			global::Vector tempVector = SlidingBlocksUtil._tempVector;
			if (tempVector != null)
			{
				tempVector.Set(smoothX * (double)num, 0.0, -smoothY * (double)num);
			}
			global::Vector vector = @out ?? global::Vector.Create();
			if (SlidingBlocksUtil._tempVector != null)
			{
				originTransform.TransformPosition(SlidingBlocksUtil._tempVector, vector);
			}
			return vector;
		}

		// Token: 0x0603219C RID: 205212 RVA: 0x00BA28C8 File Offset: 0x00BA0AC8
		public static Transform GetTransformByCoord(double smoothX, double smoothY, Transform originTransform, [Nullable(2)] Transform @out = null)
		{
			Transform transform = @out ?? Transform.Create();
			SlidingBlocksUtil.GetWorldLocationByCoord(smoothX, smoothY, originTransform, transform.GetLocation());
			transform.SetRotation(originTransform.GetRotation());
			float cubeSize = SlidingBlocksGlobal.Setting.CubeSize;
			transform.SetScale3D(global::Vector.Create((double)cubeSize, (double)cubeSize, (double)cubeSize));
			return transform;
		}

		// Token: 0x0603219D RID: 205213 RVA: 0x00BA2918 File Offset: 0x00BA0B18
		public static double ConvertConfigCoordToSmooth(double floatCoord)
		{
			return floatCoord + 0.5;
		}

		// Token: 0x0603219E RID: 205214 RVA: 0x00BA2925 File Offset: 0x00BA0B25
		public static double StandardSmoothCoordToCellCenter(double floatCoord)
		{
			return Math.Floor(floatCoord) + 0.5;
		}

		// Token: 0x0603219F RID: 205215 RVA: 0x00BA2938 File Offset: 0x00BA0B38
		public static double MapToHalfInteger(double x)
		{
			double num = x + 0.5;
			double num2 = Math.Floor(num);
			if (num2.Equals(num))
			{
				return x;
			}
			return num2 + 0.5;
		}

		// Token: 0x060321A0 RID: 205216 RVA: 0x00BA296F File Offset: 0x00BA0B6F
		public static void CreateStaticDefaultValue()
		{
			SlidingBlocksUtil._tempVector = global::Vector.Create();
		}

		// Token: 0x060321A1 RID: 205217 RVA: 0x00BA297B File Offset: 0x00BA0B7B
		public static void ResetStaticDefaultValue()
		{
			SlidingBlocksUtil._tempVector = null;
			SlidingBlocksUtil.TetrisBoardFbLru.Clear();
		}

		// Token: 0x0401AB1A RID: 109338
		[Nullable(2)]
		private static global::Vector _tempVector;

		// Token: 0x0401AB1B RID: 109339
		[StaticVariableRuleIgnore]
		private static readonly CacheLru<int, Aki.TDConfigMgr.Quest.ITetrisBoard> TetrisBoardFbLru = new CacheLru<int, Aki.TDConfigMgr.Quest.ITetrisBoard>(50, new Func<int, Aki.TDConfigMgr.Quest.ITetrisBoard>(SlidingBlocksUtil.LoadTetrisBoardFromFb));
	}
}
