using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045B8 RID: 17848
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialControlDataCacheMgr : Singleton
	{
		// Token: 0x0602E053 RID: 188499 RVA: 0x00A9A1D8 File Offset: 0x00A983D8
		public CharMaterialControlDataCacheMgr()
		{
			this.TickTime = (GlobalData.IsPlayInEditor ? this.TickTimeIntervalEditor : this.TickTimeInterval);
			this.TickStat = Stat.Create("CharMaterialControlDataCacheMgr.Tick", "", "");
		}

		// Token: 0x0602E054 RID: 188500 RVA: 0x00A9A262 File Offset: 0x00A98462
		protected override bool OnInit()
		{
			TickSystem.Instance.Add(new Action<float>(this.Tick), "CharMaterialControlDataCacheMgr.Tick", ETickingGroup.TG_EndPhysics, false, 0, false);
			return true;
		}

		// Token: 0x0602E055 RID: 188501 RVA: 0x00A9A288 File Offset: 0x00A98488
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

		// Token: 0x0602E056 RID: 188502 RVA: 0x00A9A2F0 File Offset: 0x00A984F0
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

		// Token: 0x0602E057 RID: 188503 RVA: 0x00A9A38C File Offset: 0x00A9858C
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

		// Token: 0x17007598 RID: 30104
		// (get) Token: 0x0602E058 RID: 188504 RVA: 0x00A9A4DC File Offset: 0x00A986DC
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

		// Token: 0x0602E059 RID: 188505 RVA: 0x00A9A4FF File Offset: 0x00A986FF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E05A RID: 188506 RVA: 0x00A9A501 File Offset: 0x00A98701
		public static void ResetStaticDefaultValue()
		{
			CharMaterialControlDataCacheMgr instance = CharMaterialControlDataCacheMgr._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CharMaterialControlDataCacheMgr._instance = null;
		}

		// Token: 0x0602E05B RID: 188507 RVA: 0x00A9A51A File Offset: 0x00A9871A
		static CharMaterialControlDataCacheMgr()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharMaterialControlDataCacheMgr.CreateStaticDefaultValue), new Action(CharMaterialControlDataCacheMgr.ResetStaticDefaultValue));
		}

		// Token: 0x04018989 RID: 100745
		protected readonly Dictionary<string, CharMaterialControlDataCache> DataCacheMap = new Dictionary<string, CharMaterialControlDataCache>();

		// Token: 0x0401898A RID: 100746
		protected readonly Dictionary<string, float> DataCacheGcCountDownTime = new Dictionary<string, float>();

		// Token: 0x0401898B RID: 100747
		protected readonly List<string> WaitingRemoveDataCacheNames = new List<string>();

		// Token: 0x0401898C RID: 100748
		[Nullable(2)]
		private readonly Stat TickStat;

		// Token: 0x0401898D RID: 100749
		private float TickTime;

		// Token: 0x0401898E RID: 100750
		private readonly float GcTimeInterval = 60000f;

		// Token: 0x0401898F RID: 100751
		private readonly float GcTimeIntervalEditor;

		// Token: 0x04018990 RID: 100752
		private readonly float TickTimeInterval = 10000f;

		// Token: 0x04018991 RID: 100753
		private readonly float TickTimeIntervalEditor = 10f;

		// Token: 0x04018992 RID: 100754
		[Nullable(2)]
		private static CharMaterialControlDataCacheMgr _instance;
	}
}
