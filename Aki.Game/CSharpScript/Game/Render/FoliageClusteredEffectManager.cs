using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.ClusteredStuff;
using CSharpScript.Game.Render.DebugDraw;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045C2 RID: 17858
	[NullableContext(2)]
	[Nullable(0)]
	public class FoliageClusteredEffectManager : Singleton
	{
		// Token: 0x0602E0D4 RID: 188628 RVA: 0x00A9DA7F File Offset: 0x00A9BC7F
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

		// Token: 0x0602E0D5 RID: 188629 RVA: 0x00A9DABC File Offset: 0x00A9BCBC
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

		// Token: 0x0602E0D6 RID: 188630 RVA: 0x00A9DBBC File Offset: 0x00A9BDBC
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

		// Token: 0x0602E0D7 RID: 188631 RVA: 0x00A9DD09 File Offset: 0x00A9BF09
		public void BeginDebugDraw(FLinearColor color, float width)
		{
			this.DebugDrawHandle = DebugDrawManager.AddDebugBox(this.DetectBox, color, width);
		}

		// Token: 0x0602E0D8 RID: 188632 RVA: 0x00A9DD1E File Offset: 0x00A9BF1E
		public void EndDebugDraw()
		{
			DebugDrawManager.RemoveDebugDraw(this.DebugDrawHandle);
		}

		// Token: 0x170075A0 RID: 30112
		// (get) Token: 0x0602E0D9 RID: 188633 RVA: 0x00A9DD2B File Offset: 0x00A9BF2B
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

		// Token: 0x0602E0DA RID: 188634 RVA: 0x00A9DD4E File Offset: 0x00A9BF4E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E0DB RID: 188635 RVA: 0x00A9DD50 File Offset: 0x00A9BF50
		public static void ResetStaticDefaultValue()
		{
			FoliageClusteredEffectManager instance = FoliageClusteredEffectManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FoliageClusteredEffectManager._instance = null;
		}

		// Token: 0x0602E0DC RID: 188636 RVA: 0x00A9DD69 File Offset: 0x00A9BF69
		static FoliageClusteredEffectManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FoliageClusteredEffectManager.CreateStaticDefaultValue), new Action(FoliageClusteredEffectManager.ResetStaticDefaultValue));
		}

		// Token: 0x04018AA4 RID: 101028
		protected PDA_FoliageClusteredEffectConfig_C Config;

		// Token: 0x04018AA5 RID: 101029
		[Nullable(1)]
		protected string ConfigPath = "/Game/Aki/Effect/Setting/DA_FoliageClusteredEffectConfig.DA_FoliageClusteredEffectConfig";

		// Token: 0x04018AA6 RID: 101030
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<UFoliageType> FoliageTypes;

		// Token: 0x04018AA7 RID: 101031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<EffectClusteredStuffSettings> ClusteredEffects;

		// Token: 0x04018AA8 RID: 101032
		protected List<int> NumMin;

		// Token: 0x04018AA9 RID: 101033
		protected List<int> NumMax;

		// Token: 0x04018AAA RID: 101034
		protected Vector BoxExtend;

		// Token: 0x04018AAB RID: 101035
		protected bool Ready;

		// Token: 0x04018AAC RID: 101036
		protected List<double> Densities;

		// Token: 0x04018AAD RID: 101037
		protected int UpdateInterval = 5;

		// Token: 0x04018AAE RID: 101038
		protected int UpdateCounter;

		// Token: 0x04018AAF RID: 101039
		protected int UpdateIndex;

		// Token: 0x04018AB0 RID: 101040
		protected FBox DetectBox;

		// Token: 0x04018AB1 RID: 101041
		protected Vector TempVector;

		// Token: 0x04018AB2 RID: 101042
		public int DebugDrawHandle = -1;

		// Token: 0x04018AB3 RID: 101043
		private static FoliageClusteredEffectManager _instance;
	}
}
