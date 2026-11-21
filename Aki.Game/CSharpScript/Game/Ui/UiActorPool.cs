using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035F9 RID: 13817
	[NullableContext(1)]
	[Nullable(0)]
	public class UiActorPool : Singleton
	{
		// Token: 0x060232F1 RID: 144113 RVA: 0x009FEDF0 File Offset: 0x009FCFF0
		private UiActorFactory TryGetFactory(string path)
		{
			UiActorFactory uiActorFactory;
			if (!this.FactoryMap.TryGetValue(path, out uiActorFactory))
			{
				uiActorFactory = new UiActorFactory(path, this.PoolRootActor);
				this.FactoryMap[path] = uiActorFactory;
			}
			return uiActorFactory;
		}

		// Token: 0x060232F2 RID: 144114 RVA: 0x009FEE28 File Offset: 0x009FD028
		[return: Nullable(2)]
		private UiActorFactory GetFactory(string path)
		{
			UiActorFactory result;
			this.FactoryMap.TryGetValue(path, out result);
			return result;
		}

		// Token: 0x060232F3 RID: 144115 RVA: 0x009FEE48 File Offset: 0x009FD048
		public UniTask Init()
		{
			UiActorPool.<Init>d__8 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<UiActorPool.<Init>d__8>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060232F4 RID: 144116 RVA: 0x009FEE8C File Offset: 0x009FD08C
		private UniTask PreloadActor()
		{
			UiActorPool.<PreloadActor>d__9 <PreloadActor>d__;
			<PreloadActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadActor>d__.<>4__this = this;
			<PreloadActor>d__.<>1__state = -1;
			<PreloadActor>d__.<>t__builder.Start<UiActorPool.<PreloadActor>d__9>(ref <PreloadActor>d__);
			return <PreloadActor>d__.<>t__builder.Task;
		}

		// Token: 0x060232F5 RID: 144117 RVA: 0x009FEED0 File Offset: 0x009FD0D0
		public void Tick(float deltaTime)
		{
			int num = 1;
			foreach (UiActorFactory uiActorFactory in this.FactoryMap.Values)
			{
				num = uiActorFactory.GarbageCollect(num);
				if (num <= 0)
				{
					break;
				}
			}
		}

		// Token: 0x060232F6 RID: 144118 RVA: 0x009FEF30 File Offset: 0x009FD130
		public void ClearPool()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, UiActorFactory> keyValuePair in this.FactoryMap)
			{
				if (!keyValuePair.Value.IsKeepWhileCleaning)
				{
					keyValuePair.Value.Clear();
					list.Add(keyValuePair.Key);
				}
			}
			foreach (string key in list)
			{
				this.FactoryMap.Remove(key);
			}
		}

		// Token: 0x060232F7 RID: 144119 RVA: 0x009FEFF0 File Offset: 0x009FD1F0
		public void SetKeepWhileCleaning(string path, bool isKeepWhileCleaning)
		{
			if (!this.IsOpenPool)
			{
				return;
			}
			this.TryGetFactory(path).IsKeepWhileCleaning = isKeepWhileCleaning;
		}

		// Token: 0x060232F8 RID: 144120 RVA: 0x009FF008 File Offset: 0x009FD208
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UiPoolActor> GetAsync(string path, [Nullable(2)] UUIItem parent = null)
		{
			UiActorPool.<GetAsync>d__13 <GetAsync>d__;
			<GetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiPoolActor>.Create();
			<GetAsync>d__.<>4__this = this;
			<GetAsync>d__.path = path;
			<GetAsync>d__.parent = parent;
			<GetAsync>d__.<>1__state = -1;
			<GetAsync>d__.<>t__builder.Start<UiActorPool.<GetAsync>d__13>(ref <GetAsync>d__);
			return <GetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060232F9 RID: 144121 RVA: 0x009FF05C File Offset: 0x009FD25C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<UiPoolActor> LoadUiPoolActor(string path, [Nullable(2)] UUIItem parent = null)
		{
			UiActorPool.<LoadUiPoolActor>d__14 <LoadUiPoolActor>d__;
			<LoadUiPoolActor>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiPoolActor>.Create();
			<LoadUiPoolActor>d__.path = path;
			<LoadUiPoolActor>d__.parent = parent;
			<LoadUiPoolActor>d__.<>1__state = -1;
			<LoadUiPoolActor>d__.<>t__builder.Start<UiActorPool.<LoadUiPoolActor>d__14>(ref <LoadUiPoolActor>d__);
			return <LoadUiPoolActor>d__.<>t__builder.Task;
		}

		// Token: 0x060232FA RID: 144122 RVA: 0x009FF0A8 File Offset: 0x009FD2A8
		public void RecycleAsync([Nullable(2)] UiPoolActor uiPoolActor, string path)
		{
			UiActorFactory factory = this.GetFactory(path);
			if (factory == null)
			{
				if (((uiPoolActor != null) ? uiPoolActor.Actor : null) != null)
				{
					uiPoolActor.Clear();
				}
				return;
			}
			factory.Release(uiPoolActor);
		}

		// Token: 0x1700492E RID: 18734
		// (get) Token: 0x060232FB RID: 144123 RVA: 0x009FF0DD File Offset: 0x009FD2DD
		public static UiActorPool Instance
		{
			get
			{
				if (UiActorPool._instance == null)
				{
					UiActorPool._instance = new UiActorPool();
					UiActorPool._instance.OnInit();
				}
				return UiActorPool._instance;
			}
		}

		// Token: 0x060232FC RID: 144124 RVA: 0x009FF100 File Offset: 0x009FD300
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060232FD RID: 144125 RVA: 0x009FF102 File Offset: 0x009FD302
		public static void ResetStaticDefaultValue()
		{
			UiActorPool instance = UiActorPool._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiActorPool._instance = null;
		}

		// Token: 0x060232FE RID: 144126 RVA: 0x009FF11B File Offset: 0x009FD31B
		static UiActorPool()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiActorPool.CreateStaticDefaultValue), new Action(UiActorPool.ResetStaticDefaultValue));
		}

		// Token: 0x04013DA7 RID: 81319
		private const int TICK_GARBAGE_MAXCOUNT = 1;

		// Token: 0x04013DA8 RID: 81320
		private readonly Dictionary<string, UiActorFactory> FactoryMap = new Dictionary<string, UiActorFactory>();

		// Token: 0x04013DA9 RID: 81321
		private readonly Stat StatTick = Stat.Create("UiActorPool.Tick", "", "");

		// Token: 0x04013DAA RID: 81322
		[Nullable(2)]
		private UUIItem PoolRootActor;

		// Token: 0x04013DAB RID: 81323
		public Dictionary<string, Func<int>> PrepareConfigMap = new Dictionary<string, Func<int>>();

		// Token: 0x04013DAC RID: 81324
		public bool IsOpenPool = true;

		// Token: 0x04013DAD RID: 81325
		[Nullable(2)]
		private static UiActorPool _instance;
	}
}
