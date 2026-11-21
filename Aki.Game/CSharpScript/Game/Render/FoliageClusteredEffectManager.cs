using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.ClusteredStuff;
using CSharpScript.Game.Render.DebugDraw;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034EA RID: 13546
	[NullableContext(2)]
	[Nullable(0)]
	public class FoliageClusteredEffectManager : Singleton
	{
		// Token: 0x060227BF RID: 141247 RVA: 0x009C9D47 File Offset: 0x009C7F47
		protected override bool OnInit()
		{
			this.Ready = false;
			this.UpdateCounter = 0;
			this.UpdateIndex = 0;
			ResourceSystem.Instance.LoadAsync<PDA_FoliageClusteredEffectConfig_C>(this.ConfigPath, delegate([Nullable(2)] PDA_FoliageClusteredEffectConfig_C result, string _)
			{
				if (result == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderEffect;
					ELogAuthor author = ELogAuthor.LSY;
					string message = "植被特效找不到配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置路径", this.ConfigPath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.Config = result;
				this.CacheFromConfig();
				this.Ready = true;
			}, 100, "js_undefined");
			return true;
		}

		// Token: 0x060227C0 RID: 141248 RVA: 0x009C9D84 File Offset: 0x009C7F84
		public void CacheFromConfig()
		{
			this.FoliageTypes = new List<UFoliageType>();
			this.ClusteredEffects = new List<EffectClusteredStuffSettings>();
			this.NumMin = new List<int>();
			this.NumMax = new List<int>();
			this.Densities = new List<double>();
			this.BoxExtend = Vector.Create(this.Config.BoxExtend);
			for (int i = 0; i < this.Config.SettingsData.Num(); i++)
			{
				SFoliageClusteredEffectEntry sfoliageClusteredEffectEntry = this.Config.SettingsData.Get(i);
				this.FoliageTypes.Add(sfoliageClusteredEffectEntry.FoliageType);
				this.ClusteredEffects.Add(sfoliageClusteredEffectEntry.EffectSetting);
				this.NumMin.Add(sfoliageClusteredEffectEntry.NumMin);
				this.NumMax.Add(sfoliageClusteredEffectEntry.NumMax);
				this.Densities.Add(0.0);
			}
			this.DetectBox = new FBox();
			this.TempVector = Vector.Create();
		}

		// Token: 0x060227C1 RID: 141249 RVA: 0x009C9E84 File Offset: 0x009C8084
		public void Tick(double deltaSeconds)
		{
			if (!this.Ready || this.FoliageTypes.Count == 0)
			{
				return;
			}
			this.UpdateCounter--;
			if (this.UpdateCounter > 0)
			{
				return;
			}
			this.UpdateCounter = this.UpdateInterval;
			RenderDataManager.Instance.GetCurrentCharacterPosition().Subtraction(this.BoxExtend, this.TempVector);
			this.DetectBox.Min = this.TempVector.ToUeVectorOld();
			RenderDataManager.Instance.GetCurrentCharacterPosition().Addition(this.BoxExtend, this.TempVector);
			this.DetectBox.Max = this.TempVector.ToUeVectorOld();
			int overlappingBoxCountForAllFoliageActors = UKuroRenderingRuntimeBPPluginBPLibrary.GetOverlappingBoxCountForAllFoliageActors(GlobalData.World, this.FoliageTypes[this.UpdateIndex], this.DetectBox, this.NumMax[this.UpdateIndex]);
			this.Densities[this.UpdateIndex] = (double)MathUtils.Instance.Clamp((overlappingBoxCountForAllFoliageActors - this.NumMin[this.UpdateIndex]) / (this.NumMax[this.UpdateIndex] - this.NumMin[this.UpdateIndex]), 0, 1);
			this.UpdateIndex = (this.UpdateIndex + 1) % this.FoliageTypes.Count;
		}

		// Token: 0x060227C2 RID: 141250 RVA: 0x009C9FD1 File Offset: 0x009C81D1
		public void BeginDebugDraw(FLinearColor color, float width)
		{
			this.DebugDrawHandle = DebugDrawManager.AddDebugBox(this.DetectBox, color, width);
		}

		// Token: 0x060227C3 RID: 141251 RVA: 0x009C9FE6 File Offset: 0x009C81E6
		public void EndDebugDraw()
		{
			DebugDrawManager.RemoveDebugDraw(this.DebugDrawHandle);
		}

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x060227C4 RID: 141252 RVA: 0x009C9FF3 File Offset: 0x009C81F3
		[Nullable(1)]
		public static FoliageClusteredEffectManager Instance
		{
			[NullableContext(1)]
			get
			{
				if (FoliageClusteredEffectManager._instance == null)
				{
					FoliageClusteredEffectManager._instance = new FoliageClusteredEffectManager();
					FoliageClusteredEffectManager._instance.OnInit();
				}
				return FoliageClusteredEffectManager._instance;
			}
		}

		// Token: 0x060227C5 RID: 141253 RVA: 0x009CA016 File Offset: 0x009C8216
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060227C6 RID: 141254 RVA: 0x009CA018 File Offset: 0x009C8218
		public static void ResetStaticDefaultValue()
		{
			FoliageClusteredEffectManager instance = FoliageClusteredEffectManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FoliageClusteredEffectManager._instance = null;
		}

		// Token: 0x060227C7 RID: 141255 RVA: 0x009CA031 File Offset: 0x009C8231
		static FoliageClusteredEffectManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FoliageClusteredEffectManager.CreateStaticDefaultValue), new Action(FoliageClusteredEffectManager.ResetStaticDefaultValue));
		}

		// Token: 0x040130DF RID: 78047
		protected PDA_FoliageClusteredEffectConfig_C Config;

		// Token: 0x040130E0 RID: 78048
		[Nullable(1)]
		protected string ConfigPath = "/Game/Aki/Effect/Setting/DA_FoliageClusteredEffectConfig.DA_FoliageClusteredEffectConfig";

		// Token: 0x040130E1 RID: 78049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<UFoliageType> FoliageTypes;

		// Token: 0x040130E2 RID: 78050
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<EffectClusteredStuffSettings> ClusteredEffects;

		// Token: 0x040130E3 RID: 78051
		protected List<int> NumMin;

		// Token: 0x040130E4 RID: 78052
		protected List<int> NumMax;

		// Token: 0x040130E5 RID: 78053
		protected Vector BoxExtend;

		// Token: 0x040130E6 RID: 78054
		protected bool Ready;

		// Token: 0x040130E7 RID: 78055
		protected List<double> Densities;

		// Token: 0x040130E8 RID: 78056
		protected int UpdateInterval = 5;

		// Token: 0x040130E9 RID: 78057
		protected int UpdateCounter;

		// Token: 0x040130EA RID: 78058
		protected int UpdateIndex;

		// Token: 0x040130EB RID: 78059
		protected FBox DetectBox;

		// Token: 0x040130EC RID: 78060
		protected Vector TempVector;

		// Token: 0x040130ED RID: 78061
		public int DebugDrawHandle = -1;

		// Token: 0x040130EE RID: 78062
		private static FoliageClusteredEffectManager _instance;
	}
}
