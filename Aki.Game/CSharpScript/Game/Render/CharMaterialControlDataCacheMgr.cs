using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034E0 RID: 13536
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialControlDataCacheMgr : Singleton
	{
		// Token: 0x0602273D RID: 141117 RVA: 0x009C63F8 File Offset: 0x009C45F8
		public CharMaterialControlDataCacheMgr()
		{
			this.TickTime = (GlobalData.IsPlayInEditor ? this.TickTimeIntervalEditor : this.TickTimeInterval);
			this.TickStat = Stat.Create("CharMaterialControlDataCacheMgr.Tick", "", "");
		}

		// Token: 0x0602273E RID: 141118 RVA: 0x009C6482 File Offset: 0x009C4682
		protected override bool OnInit()
		{
			TickSystem.Instance.Add(new Action<float>(this.Tick), "CharMaterialControlDataCacheMgr.Tick", ETickingGroup.TG_EndPhysics, false, 0, false);
			return true;
		}

		// Token: 0x0602273F RID: 141119 RVA: 0x009C64A8 File Offset: 0x009C46A8
		[NullableContext(2)]
		public CharMaterialControlDataCache GetOrCreateDataCache(PD_CharacterControllerData_C data)
		{
			if (data == null)
			{
				return null;
			}
			string name = data.GetName();
			CharMaterialControlDataCache charMaterialControlDataCache;
			if (!this.DataCacheMap.TryGetValue(name, out charMaterialControlDataCache))
			{
				charMaterialControlDataCache = new CharMaterialControlDataCache(name, data);
				this.DataCacheMap[name] = charMaterialControlDataCache;
			}
			charMaterialControlDataCache.RefCount++;
			if (this.DataCacheGcCountDownTime.ContainsKey(name))
			{
				this.DataCacheGcCountDownTime.Remove(name);
			}
			return charMaterialControlDataCache;
		}

		// Token: 0x06022740 RID: 141120 RVA: 0x009C6510 File Offset: 0x009C4710
		public void RecycleDataCache(string dataName)
		{
			CharMaterialControlDataCache charMaterialControlDataCache;
			if (!this.DataCacheMap.TryGetValue(dataName, out charMaterialControlDataCache))
			{
				Log.Instance.Error(ELogModule.RenderCharacter, ELogAuthor.ZJF, "RecycleDataCache: dataCache不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			charMaterialControlDataCache.RefCount--;
			if (charMaterialControlDataCache.RefCount <= 0)
			{
				float value = GlobalData.IsPlayInEditor ? this.GcTimeIntervalEditor : this.GcTimeInterval;
				this.DataCacheGcCountDownTime[dataName] = value;
				if (charMaterialControlDataCache.RefCount < 0)
				{
					Log.Instance.Error(ELogModule.RenderCharacter, ELogAuthor.ZJF, "RecycleDataCache: dataCache引用计数出错", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}

		// Token: 0x06022741 RID: 141121 RVA: 0x009C65AC File Offset: 0x009C47AC
		private void Tick(float deltaTime)
		{
			this.TickTime -= deltaTime;
			if (this.TickTime > 0f)
			{
				return;
			}
			float num = GlobalData.IsPlayInEditor ? this.TickTimeIntervalEditor : this.TickTimeInterval;
			float num2 = num - this.TickTime;
			foreach (string text in new List<string>(this.DataCacheGcCountDownTime.Keys))
			{
				float num3 = this.DataCacheGcCountDownTime[text] - num2;
				if (num3 <= 0f)
				{
					this.WaitingRemoveDataCacheNames.Add(text);
				}
				else
				{
					this.DataCacheGcCountDownTime[text] = num3;
				}
			}
			if (this.WaitingRemoveDataCacheNames.Count > 0)
			{
				foreach (string key in this.WaitingRemoveDataCacheNames)
				{
					this.DataCacheGcCountDownTime.Remove(key);
					if (this.DataCacheMap.ContainsKey(key))
					{
						this.DataCacheMap.Remove(key);
					}
				}
				this.WaitingRemoveDataCacheNames.Clear();
			}
			this.TickTime = num;
		}

		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x06022742 RID: 141122 RVA: 0x009C66FC File Offset: 0x009C48FC
		public static CharMaterialControlDataCacheMgr Instance
		{
			get
			{
				if (CharMaterialControlDataCacheMgr._instance == null)
				{
					CharMaterialControlDataCacheMgr._instance = new CharMaterialControlDataCacheMgr();
					CharMaterialControlDataCacheMgr._instance.OnInit();
				}
				return CharMaterialControlDataCacheMgr._instance;
			}
		}

		// Token: 0x06022743 RID: 141123 RVA: 0x009C671F File Offset: 0x009C491F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022744 RID: 141124 RVA: 0x009C6721 File Offset: 0x009C4921
		public static void ResetStaticDefaultValue()
		{
			CharMaterialControlDataCacheMgr instance = CharMaterialControlDataCacheMgr._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CharMaterialControlDataCacheMgr._instance = null;
		}

		// Token: 0x06022745 RID: 141125 RVA: 0x009C673A File Offset: 0x009C493A
		static CharMaterialControlDataCacheMgr()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharMaterialControlDataCacheMgr.CreateStaticDefaultValue), new Action(CharMaterialControlDataCacheMgr.ResetStaticDefaultValue));
		}

		// Token: 0x04012FC4 RID: 77764
		protected readonly Dictionary<string, CharMaterialControlDataCache> DataCacheMap = new Dictionary<string, CharMaterialControlDataCache>();

		// Token: 0x04012FC5 RID: 77765
		protected readonly Dictionary<string, float> DataCacheGcCountDownTime = new Dictionary<string, float>();

		// Token: 0x04012FC6 RID: 77766
		protected readonly List<string> WaitingRemoveDataCacheNames = new List<string>();

		// Token: 0x04012FC7 RID: 77767
		[Nullable(2)]
		private readonly Stat TickStat;

		// Token: 0x04012FC8 RID: 77768
		private float TickTime;

		// Token: 0x04012FC9 RID: 77769
		private readonly float GcTimeInterval = 60000f;

		// Token: 0x04012FCA RID: 77770
		private readonly float GcTimeIntervalEditor;

		// Token: 0x04012FCB RID: 77771
		private readonly float TickTimeInterval = 10000f;

		// Token: 0x04012FCC RID: 77772
		private readonly float TickTimeIntervalEditor = 10f;

		// Token: 0x04012FCD RID: 77773
		[Nullable(2)]
		private static CharMaterialControlDataCacheMgr _instance;
	}
}
