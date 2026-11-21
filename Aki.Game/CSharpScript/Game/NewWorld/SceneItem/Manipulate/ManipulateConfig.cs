using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Manipulate;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x02006291 RID: 25233
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ManipulateConfig : ConfigBase
	{
		// Token: 0x0603CE73 RID: 249459 RVA: 0x0117D7E4 File Offset: 0x0117B9E4
		protected override bool OnInit()
		{
			this.ManipulatePrecastLinesValue = new string[]
			{
				"Manipulate_Precast_Line_L",
				"Manipulate_Precast_Line_R",
				"Manipulate_Precast_Line_F",
				"Manipulate_Precast_Line_B"
			};
			this.DisconnectDistanceValue = (float)ConfigCommonParamById.GetIntConfig("ManipulatableItemDisconnectDistance").GetValueOrDefault();
			this.SearchRangeValue = (float)ConfigCommonParamById.GetIntConfig("ManipulatableItemSearchRange").GetValueOrDefault();
			this.PushEffectPathValue = ConfigCommonParamById.GetStringConfig("ManipulatableItemPushFXAsset");
			this.SearchAngleCosValue = new List<float>();
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("ManipulatebleItemSearchAngle");
			if (intArrayConfig != null)
			{
				foreach (int num in intArrayConfig)
				{
					this.SearchAngleCosValue.Add((float)num);
				}
			}
			this.SearchAngleWeightValue = new List<float>();
			IReadOnlyList<int> intArrayConfig2 = ConfigCommonParamById.GetIntArrayConfig("ManipulatebleItemSearchAngleWeight");
			if (intArrayConfig2 != null)
			{
				foreach (int num2 in intArrayConfig2)
				{
					this.SearchAngleWeightValue.Add((float)num2);
				}
			}
			this.PrecastTimeValue = ConfigCommonParamById.GetFloatConfig("ManipulatePrecastTime").GetValueOrDefault() * 1000f;
			this.DontUseLineDistanceValue = (float)ConfigCommonParamById.GetIntConfig("ManipulateDontUseLineDistance").GetValueOrDefault();
			this.CommonItemLineValue = (ConfigCommonParamById.GetStringConfig("ManipulateItemLine_Common") ?? "");
			this.LineFxNsPathValue = (ConfigCommonParamById.GetStringConfig("ManipulatableItemLineNiagaraSystemAssetPath") ?? "");
			this.HandFxPathValue = (ConfigCommonParamById.GetStringConfig("ManipulatableItemHandFXAssetPath") ?? "");
			this.MatControllerDaPathValue = (ConfigCommonParamById.GetStringConfig("MatControllerDAPath") ?? "");
			this.ItemMassValue = ConfigCommonParamById.GetFloatConfig("ManipulatableItemMass").GetValueOrDefault();
			this.ItemLinearDampingValue = ConfigCommonParamById.GetFloatConfig("ManipulatableItemLinearDamping").GetValueOrDefault();
			this.ItemAngularDampingValue = ConfigCommonParamById.GetFloatConfig("ManipulatableItemAngularDamping").GetValueOrDefault();
			return true;
		}

		// Token: 0x1700734E RID: 29518
		// (get) Token: 0x0603CE74 RID: 249460 RVA: 0x0117D9FC File Offset: 0x0117BBFC
		public string[] ManipulatePrecastLines
		{
			get
			{
				return this.ManipulatePrecastLinesValue;
			}
		}

		// Token: 0x1700734F RID: 29519
		// (get) Token: 0x0603CE75 RID: 249461 RVA: 0x0117DA04 File Offset: 0x0117BC04
		public float DisconnectDistance
		{
			get
			{
				return this.DisconnectDistanceValue;
			}
		}

		// Token: 0x17007350 RID: 29520
		// (get) Token: 0x0603CE76 RID: 249462 RVA: 0x0117DA0C File Offset: 0x0117BC0C
		public float SearchRange
		{
			get
			{
				return this.SearchRangeValue;
			}
		}

		// Token: 0x17007351 RID: 29521
		// (get) Token: 0x0603CE77 RID: 249463 RVA: 0x0117DA14 File Offset: 0x0117BC14
		public string PushEffectPath
		{
			get
			{
				return this.PushEffectPathValue;
			}
		}

		// Token: 0x17007352 RID: 29522
		// (get) Token: 0x0603CE78 RID: 249464 RVA: 0x0117DA1C File Offset: 0x0117BC1C
		public List<float> SearchAnglesCos
		{
			get
			{
				return this.SearchAngleCosValue;
			}
		}

		// Token: 0x17007353 RID: 29523
		// (get) Token: 0x0603CE79 RID: 249465 RVA: 0x0117DA24 File Offset: 0x0117BC24
		public List<float> SearchAnglesWeight
		{
			get
			{
				return this.SearchAngleWeightValue;
			}
		}

		// Token: 0x17007354 RID: 29524
		// (get) Token: 0x0603CE7A RID: 249466 RVA: 0x0117DA2C File Offset: 0x0117BC2C
		public float PrecastTime
		{
			get
			{
				return this.PrecastTimeValue;
			}
		}

		// Token: 0x17007355 RID: 29525
		// (get) Token: 0x0603CE7B RID: 249467 RVA: 0x0117DA34 File Offset: 0x0117BC34
		public float DontUseLineDistance
		{
			get
			{
				return this.DontUseLineDistanceValue;
			}
		}

		// Token: 0x17007356 RID: 29526
		// (get) Token: 0x0603CE7C RID: 249468 RVA: 0x0117DA3C File Offset: 0x0117BC3C
		public string CommonItemLine
		{
			get
			{
				return this.CommonItemLineValue;
			}
		}

		// Token: 0x17007357 RID: 29527
		// (get) Token: 0x0603CE7D RID: 249469 RVA: 0x0117DA44 File Offset: 0x0117BC44
		public string LineFxNsPath
		{
			get
			{
				return this.LineFxNsPathValue;
			}
		}

		// Token: 0x17007358 RID: 29528
		// (get) Token: 0x0603CE7E RID: 249470 RVA: 0x0117DA4C File Offset: 0x0117BC4C
		public string MatControllerDaPath
		{
			get
			{
				return this.MatControllerDaPathValue;
			}
		}

		// Token: 0x17007359 RID: 29529
		// (get) Token: 0x0603CE7F RID: 249471 RVA: 0x0117DA54 File Offset: 0x0117BC54
		public string HandFxPath
		{
			get
			{
				return this.HandFxPathValue;
			}
		}

		// Token: 0x1700735A RID: 29530
		// (get) Token: 0x0603CE80 RID: 249472 RVA: 0x0117DA5C File Offset: 0x0117BC5C
		public float ItemMass
		{
			get
			{
				return this.ItemMassValue;
			}
		}

		// Token: 0x1700735B RID: 29531
		// (get) Token: 0x0603CE81 RID: 249473 RVA: 0x0117DA64 File Offset: 0x0117BC64
		public float ItemLinearDamping
		{
			get
			{
				return this.ItemLinearDampingValue;
			}
		}

		// Token: 0x1700735C RID: 29532
		// (get) Token: 0x0603CE82 RID: 249474 RVA: 0x0117DA6C File Offset: 0x0117BC6C
		public float ItemAngularDampling
		{
			get
			{
				return this.ItemAngularDampingValue;
			}
		}

		// Token: 0x0603CE83 RID: 249475 RVA: 0x0117DA74 File Offset: 0x0117BC74
		public FVector? GetPrecastLineValue(string rowName, float time)
		{
			SManipulateConfig dataTableRowFromName = DataTableUtil.GetDataTableRowFromName<SManipulateConfig>(EDataTable.ManipulatePrecast, rowName);
			if (dataTableRowFromName == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.CH;
				string message = "加载失败，Manipulate Precast表中没有该项";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Row Name", rowName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new FVector?(this.GetLocationByTime(dataTableRowFromName.ManipulatePoints, dataTableRowFromName.Duration, time));
		}

		// Token: 0x0603CE84 RID: 249476 RVA: 0x0117DADC File Offset: 0x0117BCDC
		public FVector? GetItemLineValue(string rowName, float time)
		{
			SManipulateConfig dataTableRowFromName = DataTableUtil.GetDataTableRowFromName<SManipulateConfig>(EDataTable.ManipulateItem, rowName);
			if (dataTableRowFromName == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.CH;
				string message = "加载失败，Manipulate Item表中没有该项";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Row Name", rowName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new FVector?(this.GetLocationByTime(dataTableRowFromName.ManipulatePoints, dataTableRowFromName.Duration, time));
		}

		// Token: 0x0603CE85 RID: 249477 RVA: 0x0117DB44 File Offset: 0x0117BD44
		private FVector GetLocationByTime(TArray<SManipulatePointInfo> points, float duration, float time)
		{
			int num = points.Num();
			float num2 = (float)(num - 1) / duration;
			if (time <= 0f)
			{
				return points[0].Location;
			}
			if (time >= 1f)
			{
				return points[num - 1].Location;
			}
			float num3 = time * num2;
			int num4 = (int)Math.Floor((double)num3);
			SManipulatePointInfo smanipulatePointInfo = points[num4];
			int index = num4 + 1;
			SManipulatePointInfo smanipulatePointInfo2 = points[index];
			if (!(smanipulatePointInfo.PointType != ESplinePointType.Constant))
			{
				return smanipulatePointInfo.Location;
			}
			float num5 = num3 - (float)num4;
			if (smanipulatePointInfo.PointType == ESplinePointType.Linear)
			{
				FVector result = new FVector();
				MathUtils.Instance.LerpVectorOld(smanipulatePointInfo.Location, smanipulatePointInfo2.Location, num5, ref result);
				return result;
			}
			return this.CubicInterp(smanipulatePointInfo.Location, smanipulatePointInfo.LeaveTangent, smanipulatePointInfo2.Location, smanipulatePointInfo2.ArriveTangent, num5);
		}

		// Token: 0x0603CE86 RID: 249478 RVA: 0x0117DC30 File Offset: 0x0117BE30
		protected override bool OnClear()
		{
			this.ManipulatePrecastLinesValue = null;
			this.PushEffectPathValue = null;
			return true;
		}

		// Token: 0x0603CE87 RID: 249479 RVA: 0x0117DC44 File Offset: 0x0117BE44
		private FVector CubicInterp(FVector p0, FVector t0, FVector p1, FVector t1, float a)
		{
			float num = a * a;
			float num2 = num * a;
			float num3 = 2f * num2 - 3f * num + 1f;
			float num4 = num2 - 2f * num + a;
			float num5 = num2 - num;
			float num6 = -2f * num2 + 3f * num;
			global::Vector vector = global::Vector.Create(p0).MultiplyEqual((double)num3);
			global::Vector inB = global::Vector.Create(t0).MultiplyEqual((double)num4);
			global::Vector inB2 = global::Vector.Create(t1).MultiplyEqual((double)num5);
			global::Vector inB3 = global::Vector.Create(p1).MultiplyEqual((double)num6);
			vector.AdditionEqual(inB).AdditionEqual(inB2).AdditionEqual(inB3);
			return vector.ToUeVectorOld();
		}

		// Token: 0x1700735D RID: 29533
		// (get) Token: 0x0603CE88 RID: 249480 RVA: 0x0117DD02 File Offset: 0x0117BF02
		public static ManipulateConfig Instance
		{
			get
			{
				return ManipulateConfig._Instance;
			}
		}

		// Token: 0x0603CE89 RID: 249481 RVA: 0x0117DD09 File Offset: 0x0117BF09
		public static ManipulateConfig GetOrCreateInstance()
		{
			if (ManipulateConfig._Instance == null)
			{
				ManipulateConfig.CreateInstance();
			}
			return ManipulateConfig._Instance;
		}

		// Token: 0x0603CE8A RID: 249482 RVA: 0x0117DD1D File Offset: 0x0117BF1D
		public static bool CreateInstance()
		{
			if (ManipulateConfig._Instance != null)
			{
				return true;
			}
			ManipulateConfig._Instance = new ManipulateConfig();
			return true;
		}

		// Token: 0x0603CE8B RID: 249483 RVA: 0x0117DD33 File Offset: 0x0117BF33
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE8C RID: 249484 RVA: 0x0117DD35 File Offset: 0x0117BF35
		public static void ResetStaticDefaultValue()
		{
			ManipulateConfig._Instance = null;
		}

		// Token: 0x0603CE8D RID: 249485 RVA: 0x0117DD3D File Offset: 0x0117BF3D
		static ManipulateConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ManipulateConfig.CreateStaticDefaultValue), new Action(ManipulateConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04020488 RID: 132232
		private const int SECOND_TO_MICROSECOND = 1000;

		// Token: 0x04020489 RID: 132233
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private string[] ManipulatePrecastLinesValue;

		// Token: 0x0402048A RID: 132234
		private float DisconnectDistanceValue;

		// Token: 0x0402048B RID: 132235
		private float SearchRangeValue;

		// Token: 0x0402048C RID: 132236
		[Nullable(2)]
		private string PushEffectPathValue;

		// Token: 0x0402048D RID: 132237
		private List<float> SearchAngleCosValue = new List<float>();

		// Token: 0x0402048E RID: 132238
		private List<float> SearchAngleWeightValue = new List<float>();

		// Token: 0x0402048F RID: 132239
		private float PrecastTimeValue;

		// Token: 0x04020490 RID: 132240
		private float DontUseLineDistanceValue;

		// Token: 0x04020491 RID: 132241
		private string CommonItemLineValue = "";

		// Token: 0x04020492 RID: 132242
		private string LineFxNsPathValue = "";

		// Token: 0x04020493 RID: 132243
		private string HandFxPathValue = "";

		// Token: 0x04020494 RID: 132244
		private string MatControllerDaPathValue = "";

		// Token: 0x04020495 RID: 132245
		private float ItemMassValue;

		// Token: 0x04020496 RID: 132246
		private float ItemLinearDampingValue;

		// Token: 0x04020497 RID: 132247
		private float ItemAngularDampingValue;

		// Token: 0x04020498 RID: 132248
		[Nullable(2)]
		private static ManipulateConfig _Instance;
	}
}
