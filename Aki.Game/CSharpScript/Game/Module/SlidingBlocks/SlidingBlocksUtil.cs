using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using Aki.TDConfigMgr.Quest.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;
using CSharpScript.Game.Common;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B2D RID: 15149
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidingBlocksUtil : IStaticVariableResetter
	{
		// Token: 0x06026F23 RID: 159523 RVA: 0x00AE6536 File Offset: 0x00AE4736
		static SlidingBlocksUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SlidingBlocksUtil.CreateStaticDefaultValue), new Action(SlidingBlocksUtil.ResetStaticDefaultValue));
		}

		// Token: 0x06026F24 RID: 159524 RVA: 0x00AE6570 File Offset: 0x00AE4770
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

		// Token: 0x06026F25 RID: 159525 RVA: 0x00AE65D0 File Offset: 0x00AE47D0
		public static string GetCoordKey(double x, double y)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(x);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(y);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06026F26 RID: 159526 RVA: 0x00AE660C File Offset: 0x00AE480C
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

		// Token: 0x06026F27 RID: 159527 RVA: 0x00AE66B8 File Offset: 0x00AE48B8
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

		// Token: 0x06026F28 RID: 159528 RVA: 0x00AE6754 File Offset: 0x00AE4954
		[return: Nullable(2)]
		public static ITetrominoConfig GetTetrominoConfigByShapeName(string shapeName)
		{
			TetrisShapeConfig? config = ConfigTetrisShapeConfigByName.GetConfig(shapeName, true);
			if (config == null)
			{
				return null;
			}
			Aki.TDConfigMgr.Quest.ITetrisBoard tetrisBoard = SlidingBlocksUtil.TetrisBoardFbLru.Get(config.Value.Id);
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

		// Token: 0x06026F29 RID: 159529 RVA: 0x00AE67D0 File Offset: 0x00AE49D0
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

		// Token: 0x06026F2A RID: 159530 RVA: 0x00AE6808 File Offset: 0x00AE4A08
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

		// Token: 0x06026F2B RID: 159531 RVA: 0x00AE69D2 File Offset: 0x00AE4BD2
		public static bool DestroyCube(AActor cubeActor)
		{
			return ActorSystem.Instance.Put("SlidingBlocksUtil.DestroyCube", cubeActor, null);
		}

		// Token: 0x06026F2C RID: 159532 RVA: 0x00AE69E8 File Offset: 0x00AE4BE8
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

		// Token: 0x06026F2D RID: 159533 RVA: 0x00AE6A54 File Offset: 0x00AE4C54
		public static Transform GetTransformByCoord(double smoothX, double smoothY, Transform originTransform, [Nullable(2)] Transform @out = null)
		{
			Transform transform = @out ?? Transform.Create();
			SlidingBlocksUtil.GetWorldLocationByCoord(smoothX, smoothY, originTransform, transform.GetLocation());
			transform.SetRotation(originTransform.GetRotation());
			float cubeSize = SlidingBlocksGlobal.Setting.CubeSize;
			transform.SetScale3D(global::Vector.Create((double)cubeSize, (double)cubeSize, (double)cubeSize));
			return transform;
		}

		// Token: 0x06026F2E RID: 159534 RVA: 0x00AE6AA4 File Offset: 0x00AE4CA4
		public static double ConvertConfigCoordToSmooth(double floatCoord)
		{
			return floatCoord + 0.5;
		}

		// Token: 0x06026F2F RID: 159535 RVA: 0x00AE6AB1 File Offset: 0x00AE4CB1
		public static double StandardSmoothCoordToCellCenter(double floatCoord)
		{
			return Math.Floor(floatCoord) + 0.5;
		}

		// Token: 0x06026F30 RID: 159536 RVA: 0x00AE6AC4 File Offset: 0x00AE4CC4
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

		// Token: 0x06026F31 RID: 159537 RVA: 0x00AE6AFB File Offset: 0x00AE4CFB
		public static void CreateStaticDefaultValue()
		{
			SlidingBlocksUtil._tempVector = global::Vector.Create();
		}

		// Token: 0x06026F32 RID: 159538 RVA: 0x00AE6B07 File Offset: 0x00AE4D07
		public static void ResetStaticDefaultValue()
		{
			SlidingBlocksUtil._tempVector = null;
			SlidingBlocksUtil.TetrisBoardFbLru.Clear();
		}

		// Token: 0x0401546E RID: 87150
		[Nullable(2)]
		private static global::Vector _tempVector;

		// Token: 0x0401546F RID: 87151
		[StaticVariableRuleIgnore]
		private static readonly CacheLru<int, Aki.TDConfigMgr.Quest.ITetrisBoard> TetrisBoardFbLru = new CacheLru<int, Aki.TDConfigMgr.Quest.ITetrisBoard>(50, new Func<int, Aki.TDConfigMgr.Quest.ITetrisBoard>(SlidingBlocksUtil.LoadTetrisBoardFromFb));
	}
}
