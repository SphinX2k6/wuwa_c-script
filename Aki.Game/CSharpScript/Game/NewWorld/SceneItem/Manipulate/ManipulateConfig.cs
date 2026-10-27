using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Manipulate;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071DC RID: 29148
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ManipulateConfig : ConfigBase
	{
		// Token: 0x06047571 RID: 292209 RVA: 0x012239B0 File Offset: 0x01221BB0
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

		// Token: 0x17009DF7 RID: 40439
		// (get) Token: 0x06047572 RID: 292210 RVA: 0x01223BC8 File Offset: 0x01221DC8
		public string[] ManipulatePrecastLines
		{
			get
			{
				return this.ManipulatePrecastLinesValue;
			}
		}

		// Token: 0x17009DF8 RID: 40440
		// (get) Token: 0x06047573 RID: 292211 RVA: 0x01223BD0 File Offset: 0x01221DD0
		public float DisconnectDistance
		{
			get
			{
				return this.DisconnectDistanceValue;
			}
		}

		// Token: 0x17009DF9 RID: 40441
		// (get) Token: 0x06047574 RID: 292212 RVA: 0x01223BD8 File Offset: 0x01221DD8
		public float SearchRange
		{
			get
			{
				return this.SearchRangeValue;
			}
		}

		// Token: 0x17009DFA RID: 40442
		// (get) Token: 0x06047575 RID: 292213 RVA: 0x01223BE0 File Offset: 0x01221DE0
		public string PushEffectPath
		{
			get
			{
				return this.PushEffectPathValue;
			}
		}

		// Token: 0x17009DFB RID: 40443
		// (get) Token: 0x06047576 RID: 292214 RVA: 0x01223BE8 File Offset: 0x01221DE8
		public List<float> SearchAnglesCos
		{
			get
			{
				return this.SearchAngleCosValue;
			}
		}

		// Token: 0x17009DFC RID: 40444
		// (get) Token: 0x06047577 RID: 292215 RVA: 0x01223BF0 File Offset: 0x01221DF0
		public List<float> SearchAnglesWeight
		{
			get
			{
				return this.SearchAngleWeightValue;
			}
		}

		// Token: 0x17009DFD RID: 40445
		// (get) Token: 0x06047578 RID: 292216 RVA: 0x01223BF8 File Offset: 0x01221DF8
		public float PrecastTime
		{
			get
			{
				return this.PrecastTimeValue;
			}
		}

		// Token: 0x17009DFE RID: 40446
		// (get) Token: 0x06047579 RID: 292217 RVA: 0x01223C00 File Offset: 0x01221E00
		public float DontUseLineDistance
		{
			get
			{
				return this.DontUseLineDistanceValue;
			}
		}

		// Token: 0x17009DFF RID: 40447
		// (get) Token: 0x0604757A RID: 292218 RVA: 0x01223C08 File Offset: 0x01221E08
		public string CommonItemLine
		{
			get
			{
				return this.CommonItemLineValue;
			}
		}

		// Token: 0x17009E00 RID: 40448
		// (get) Token: 0x0604757B RID: 292219 RVA: 0x01223C10 File Offset: 0x01221E10
		public string LineFxNsPath
		{
			get
			{
				return this.LineFxNsPathValue;
			}
		}

		// Token: 0x17009E01 RID: 40449
		// (get) Token: 0x0604757C RID: 292220 RVA: 0x01223C18 File Offset: 0x01221E18
		public string MatControllerDaPath
		{
			get
			{
				return this.MatControllerDaPathValue;
			}
		}

		// Token: 0x17009E02 RID: 40450
		// (get) Token: 0x0604757D RID: 292221 RVA: 0x01223C20 File Offset: 0x01221E20
		public string HandFxPath
		{
			get
			{
				return this.HandFxPathValue;
			}
		}

		// Token: 0x17009E03 RID: 40451
		// (get) Token: 0x0604757E RID: 292222 RVA: 0x01223C28 File Offset: 0x01221E28
		public float ItemMass
		{
			get
			{
				return this.ItemMassValue;
			}
		}

		// Token: 0x17009E04 RID: 40452
		// (get) Token: 0x0604757F RID: 292223 RVA: 0x01223C30 File Offset: 0x01221E30
		public float ItemLinearDamping
		{
			get
			{
				return this.ItemLinearDampingValue;
			}
		}

		// Token: 0x17009E05 RID: 40453
		// (get) Token: 0x06047580 RID: 292224 RVA: 0x01223C38 File Offset: 0x01221E38
		public float ItemAngularDampling
		{
			get
			{
				return this.ItemAngularDampingValue;
			}
		}

		// Token: 0x06047581 RID: 292225 RVA: 0x01223C40 File Offset: 0x01221E40
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

		// Token: 0x06047582 RID: 292226 RVA: 0x01223CA8 File Offset: 0x01221EA8
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

		// Token: 0x06047583 RID: 292227 RVA: 0x01223D10 File Offset: 0x01221F10
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

		// Token: 0x06047584 RID: 292228 RVA: 0x01223DFC File Offset: 0x01221FFC
		protected override bool OnClear()
		{
			this.ManipulatePrecastLinesValue = null;
			this.PushEffectPathValue = null;
			return true;
		}

		// Token: 0x06047585 RID: 292229 RVA: 0x01223E10 File Offset: 0x01222010
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

		// Token: 0x17009E06 RID: 40454
		// (get) Token: 0x06047586 RID: 292230 RVA: 0x01223ECE File Offset: 0x012220CE
		public static ManipulateConfig Instance
		{
			get
			{
				return ManipulateConfig._Instance;
			}
		}

		// Token: 0x06047587 RID: 292231 RVA: 0x01223ED5 File Offset: 0x012220D5
		public static ManipulateConfig GetOrCreateInstance()
		{
			if (ManipulateConfig._Instance == null)
			{
				ManipulateConfig.CreateInstance();
			}
			return ManipulateConfig._Instance;
		}

		// Token: 0x06047588 RID: 292232 RVA: 0x01223EE9 File Offset: 0x012220E9
		public static bool CreateInstance()
		{
			if (ManipulateConfig._Instance != null)
			{
				return true;
			}
			ManipulateConfig._Instance = new ManipulateConfig();
			return true;
		}

		// Token: 0x06047589 RID: 292233 RVA: 0x01223EFF File Offset: 0x012220FF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604758A RID: 292234 RVA: 0x01223F01 File Offset: 0x01222101
		public static void ResetStaticDefaultValue()
		{
			ManipulateConfig._Instance = null;
		}

		// Token: 0x0604758B RID: 292235 RVA: 0x01223F09 File Offset: 0x01222109
		static ManipulateConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ManipulateConfig.CreateStaticDefaultValue), new Action(ManipulateConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04025819 RID: 153625
		private const int SECOND_TO_MICROSECOND = 1000;

		// Token: 0x0402581A RID: 153626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private string[] ManipulatePrecastLinesValue;

		// Token: 0x0402581B RID: 153627
		private float DisconnectDistanceValue;

		// Token: 0x0402581C RID: 153628
		private float SearchRangeValue;

		// Token: 0x0402581D RID: 153629
		[Nullable(2)]
		private string PushEffectPathValue;

		// Token: 0x0402581E RID: 153630
		private List<float> SearchAngleCosValue = new List<float>();

		// Token: 0x0402581F RID: 153631
		private List<float> SearchAngleWeightValue = new List<float>();

		// Token: 0x04025820 RID: 153632
		private float PrecastTimeValue;

		// Token: 0x04025821 RID: 153633
		private float DontUseLineDistanceValue;

		// Token: 0x04025822 RID: 153634
		private string CommonItemLineValue = "";

		// Token: 0x04025823 RID: 153635
		private string LineFxNsPathValue = "";

		// Token: 0x04025824 RID: 153636
		private string HandFxPathValue = "";

		// Token: 0x04025825 RID: 153637
		private string MatControllerDaPathValue = "";

		// Token: 0x04025826 RID: 153638
		private float ItemMassValue;

		// Token: 0x04025827 RID: 153639
		private float ItemLinearDampingValue;

		// Token: 0x04025828 RID: 153640
		private float ItemAngularDampingValue;

		// Token: 0x04025829 RID: 153641
		[Nullable(2)]
		private static ManipulateConfig _Instance;
	}
}
