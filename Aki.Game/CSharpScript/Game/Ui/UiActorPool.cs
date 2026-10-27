using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046C8 RID: 18120
	[NullableContext(1)]
	[Nullable(0)]
	public class UiActorPool : Singleton
	{
		// Token: 0x0602EBA5 RID: 191397 RVA: 0x00AD045C File Offset: 0x00ACE65C
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

		// Token: 0x0602EBA6 RID: 191398 RVA: 0x00AD0494 File Offset: 0x00ACE694
		[return: Nullable(2)]
		private UiActorFactory GetFactory(string path)
		{
			UiActorFactory result;
			this.FactoryMap.TryGetValue(path, out result);
			return result;
		}

		// Token: 0x0602EBA7 RID: 191399 RVA: 0x00AD04B4 File Offset: 0x00ACE6B4
		public UniTask Init()
		{
			UiActorPool.<Init>d__8 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<UiActorPool.<Init>d__8>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBA8 RID: 191400 RVA: 0x00AD04F8 File Offset: 0x00ACE6F8
		private UniTask PreloadActor()
		{
			UiActorPool.<PreloadActor>d__9 <PreloadActor>d__;
			<PreloadActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadActor>d__.<>4__this = this;
			<PreloadActor>d__.<>1__state = -1;
			<PreloadActor>d__.<>t__builder.Start<UiActorPool.<PreloadActor>d__9>(ref <PreloadActor>d__);
			return <PreloadActor>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBA9 RID: 191401 RVA: 0x00AD053C File Offset: 0x00ACE73C
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

		// Token: 0x0602EBAA RID: 191402 RVA: 0x00AD059C File Offset: 0x00ACE79C
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

		// Token: 0x0602EBAB RID: 191403 RVA: 0x00AD065C File Offset: 0x00ACE85C
		public void SetKeepWhileCleaning(string path, bool isKeepWhileCleaning)
		{
			if (!this.IsOpenPool)
			{
				return;
			}
			this.TryGetFactory(path).IsKeepWhileCleaning = isKeepWhileCleaning;
		}

		// Token: 0x0602EBAC RID: 191404 RVA: 0x00AD0674 File Offset: 0x00ACE874
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

		// Token: 0x0602EBAD RID: 191405 RVA: 0x00AD06C8 File Offset: 0x00ACE8C8
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

		// Token: 0x0602EBAE RID: 191406 RVA: 0x00AD0714 File Offset: 0x00ACE914
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

		// Token: 0x17007672 RID: 30322
		// (get) Token: 0x0602EBAF RID: 191407 RVA: 0x00AD0749 File Offset: 0x00ACE949
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

		// Token: 0x0602EBB0 RID: 191408 RVA: 0x00AD076C File Offset: 0x00ACE96C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EBB1 RID: 191409 RVA: 0x00AD076E File Offset: 0x00ACE96E
		public static void ResetStaticDefaultValue()
		{
			UiActorPool instance = UiActorPool._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiActorPool._instance = null;
		}

		// Token: 0x0602EBB2 RID: 191410 RVA: 0x00AD0787 File Offset: 0x00ACE987
		static UiActorPool()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiActorPool.CreateStaticDefaultValue), new Action(UiActorPool.ResetStaticDefaultValue));
		}

		// Token: 0x04019700 RID: 104192
		private const int TICK_GARBAGE_MAXCOUNT = 1;

		// Token: 0x04019701 RID: 104193
		private readonly Dictionary<string, UiActorFactory> FactoryMap = new Dictionary<string, UiActorFactory>();

		// Token: 0x04019702 RID: 104194
		private readonly Stat StatTick = Stat.Create("UiActorPool.Tick", "", "");

		// Token: 0x04019703 RID: 104195
		[Nullable(2)]
		private UUIItem PoolRootActor;

		// Token: 0x04019704 RID: 104196
		public Dictionary<string, Func<int>> PrepareConfigMap = new Dictionary<string, Func<int>>();

		// Token: 0x04019705 RID: 104197
		public bool IsOpenPool = true;

		// Token: 0x04019706 RID: 104198
		[Nullable(2)]
		private static UiActorPool _instance;
	}
}
