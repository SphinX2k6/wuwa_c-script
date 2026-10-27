using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C9D RID: 23709
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiPool
	{
		// Token: 0x0603BE5D RID: 245341 RVA: 0x00E4F508 File Offset: 0x00E4D708
		[NullableContext(0)]
		public UniTask<bool> Init()
		{
			BattleUiPool.<Init>d__16 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<BattleUiPool.<Init>d__16>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603BE5E RID: 245342 RVA: 0x00E4F54C File Offset: 0x00E4D74C
		private bool InitRoot()
		{
			UUIItem worldSpaceUiRootItem = UiLayer.Instance.WorldSpaceUiRootItem;
			if (worldSpaceUiRootItem == null || !worldSpaceUiRootItem.IsValid())
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "WorldSpaceUiRootItem为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.WorldRoot = worldSpaceUiRootItem;
			UUIItem layerRootUiItem = UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pool);
			if (layerRootUiItem == null || !layerRootUiItem.IsValid())
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "PoolRoot为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.PoolRoot = layerRootUiItem;
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			if (uiRootItem == null || !uiRootItem.IsValid())
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "UiRootItem为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.UiRoot = uiRootItem;
			this.DamageViewRoot = UiLayer.Instance.GetBattleViewUnit(0);
			return true;
		}

		// Token: 0x0603BE5F RID: 245343 RVA: 0x00E4F634 File Offset: 0x00E4D834
		[NullableContext(0)]
		private UniTask<bool> PreloadAllActor()
		{
			BattleUiPool.<PreloadAllActor>d__18 <PreloadAllActor>d__;
			<PreloadAllActor>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreloadAllActor>d__.<>4__this = this;
			<PreloadAllActor>d__.<>1__state = -1;
			<PreloadAllActor>d__.<>t__builder.Start<BattleUiPool.<PreloadAllActor>d__18>(ref <PreloadAllActor>d__);
			return <PreloadAllActor>d__.<>t__builder.Task;
		}

		// Token: 0x0603BE60 RID: 245344 RVA: 0x00E4F678 File Offset: 0x00E4D878
		[return: Nullable(0)]
		private UniTask<bool> PreloadActor(IPreLoad config, UUIItem parentItem)
		{
			BattleUiPool.<PreloadActor>d__19 <PreloadActor>d__;
			<PreloadActor>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreloadActor>d__.<>4__this = this;
			<PreloadActor>d__.config = config;
			<PreloadActor>d__.parentItem = parentItem;
			<PreloadActor>d__.<>1__state = -1;
			<PreloadActor>d__.<>t__builder.Start<BattleUiPool.<PreloadActor>d__19>(ref <PreloadActor>d__);
			return <PreloadActor>d__.<>t__builder.Task;
		}

		// Token: 0x0603BE61 RID: 245345 RVA: 0x00E4F6CC File Offset: 0x00E4D8CC
		[return: Nullable(2)]
		public AActor GetActor(string resourceId, USceneComponent parent, bool setParent)
		{
			BattleUiPoolElement battleUiPoolElement;
			if (!this.ActorMap.TryGetValue(resourceId, out battleUiPoolElement) || battleUiPoolElement.ActorList == null || battleUiPoolElement.ActorList.Count == 0)
			{
				return null;
			}
			if (battleUiPoolElement.ExistMulti)
			{
				if (battleUiPoolElement.ActorList.Count > 1)
				{
					AActor aactor = battleUiPoolElement.ActorList.Pop<AActor>();
					if (aactor != null && aactor.IsValid())
					{
						if (setParent)
						{
							aactor.K2_AttachRootComponentTo(parent, default(FName), EAttachLocation.KeepRelativeOffset, true);
						}
						return aactor;
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.HWR;
					string message = "BattleUiPool:Actor已无效";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("resourceId", resourceId);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				return LguiUtil.Instance.DuplicateActor(battleUiPoolElement.ActorList[0], parent);
			}
			AActor aactor2;
			if (!battleUiPoolElement.ActorList.TryPop(out aactor2) || aactor2 == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "BattleUiPool重复获取单一预制体";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("resourceId", resourceId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			if (setParent)
			{
				aactor2.K2_AttachRootComponentTo(parent, default(FName), EAttachLocation.KeepRelativeOffset, true);
			}
			return aactor2;
		}

		// Token: 0x0603BE62 RID: 245346 RVA: 0x00E4F7E0 File Offset: 0x00E4D9E0
		public bool RecycleActor(string resourceId, AActor actor, bool resetParent = false)
		{
			BattleUiPoolElement battleUiPoolElement;
			if (!this.ActorMap.TryGetValue(resourceId, out battleUiPoolElement))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "BattleUiPool没有缓存该预制体";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("resourceId", resourceId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			(actor.RootComponent as UUIItem).SetUIActive(false);
			if (resetParent)
			{
				actor.K2_AttachRootComponentTo(this.PoolRoot, default(FName), EAttachLocation.KeepRelativeOffset, true);
			}
			if (battleUiPoolElement.ExistMulti)
			{
				battleUiPoolElement.ActorList.Add(actor);
				return true;
			}
			if (battleUiPoolElement.Actor != actor)
			{
				if (actor.IsValid())
				{
					ULGUIBPLibrary.DestroyActorWithHierarchy(actor, true);
				}
				return false;
			}
			if (battleUiPoolElement.ActorList.Count != 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "BattleUiPool重复Recycle单一预制体";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("resourceId", resourceId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			battleUiPoolElement.ActorList.Add(actor);
			return true;
		}

		// Token: 0x0603BE63 RID: 245347 RVA: 0x00E4F8C4 File Offset: 0x00E4DAC4
		[return: Nullable(2)]
		public AActor GetSrcActor(string resourceId)
		{
			BattleUiPoolElement battleUiPoolElement;
			if (!this.ActorMap.TryGetValue(resourceId, out battleUiPoolElement) || battleUiPoolElement.Actor == null)
			{
				return null;
			}
			return battleUiPoolElement.Actor;
		}

		// Token: 0x0603BE64 RID: 245348 RVA: 0x00E4F8F1 File Offset: 0x00E4DAF1
		[return: Nullable(2)]
		public AActor GetHeadStateView(string resourceId)
		{
			return this.GetActor(resourceId, this.WorldRoot, false);
		}

		// Token: 0x0603BE65 RID: 245349 RVA: 0x00E4F901 File Offset: 0x00E4DB01
		public bool RecycleHeadStateView(string resourceId, AActor actor, bool resetParent = false)
		{
			return !this.Inited || this.RecycleActor(resourceId, actor, resetParent);
		}

		// Token: 0x0603BE66 RID: 245350 RVA: 0x00E4F916 File Offset: 0x00E4DB16
		[NullableContext(2)]
		public AActor GetDamageView()
		{
			return this.GetActor(this.damageViewConfig.ResourceId, this.DamageViewRoot, false);
		}

		// Token: 0x0603BE67 RID: 245351 RVA: 0x00E4F930 File Offset: 0x00E4DB30
		public bool RecycleDamageView(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleDamageView", actor, null);
				return true;
			}
			return this.RecycleActor(this.damageViewConfig.ResourceId, actor, false);
		}

		// Token: 0x0603BE68 RID: 245352 RVA: 0x00E4F961 File Offset: 0x00E4DB61
		[return: Nullable(2)]
		public AActor GetBuffItem(USceneComponent parentItem)
		{
			return this.GetActor(this.buffItemConfig.ResourceId, parentItem, true);
		}

		// Token: 0x0603BE69 RID: 245353 RVA: 0x00E4F976 File Offset: 0x00E4DB76
		public bool RecycleBuffItem(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleBuffItem", actor, null);
				return true;
			}
			return this.RecycleActor(this.buffItemConfig.ResourceId, actor, true);
		}

		// Token: 0x0603BE6A RID: 245354 RVA: 0x00E4F9A7 File Offset: 0x00E4DBA7
		[return: Nullable(2)]
		public AActor GetQuickHackBuffItem(USceneComponent parentItem)
		{
			return this.GetActor(this.quickHackBuffItemConfig.ResourceId, parentItem, true);
		}

		// Token: 0x0603BE6B RID: 245355 RVA: 0x00E4F9BC File Offset: 0x00E4DBBC
		public bool RecycleQuickHackBuffItem(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleQuickHackBuffItem", actor, null);
				return true;
			}
			return this.RecycleActor(this.quickHackBuffItemConfig.ResourceId, actor, true);
		}

		// Token: 0x0603BE6C RID: 245356 RVA: 0x00E4F9ED File Offset: 0x00E4DBED
		[return: Nullable(2)]
		public AActor GetEnvironmentItem(USceneComponent parentItem)
		{
			return this.GetActor(this.environmentItemConfig.ResourceId, parentItem, true);
		}

		// Token: 0x0603BE6D RID: 245357 RVA: 0x00E4FA02 File Offset: 0x00E4DC02
		public bool RecycleEnvironmentItem(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleEnvironmentItem", actor, null);
				return true;
			}
			return this.RecycleActor(this.environmentItemConfig.ResourceId, actor, true);
		}

		// Token: 0x0603BE6E RID: 245358 RVA: 0x00E4FA33 File Offset: 0x00E4DC33
		[return: Nullable(2)]
		public AActor GetWeaknessItem(USceneComponent parentItem)
		{
			return this.GetActor(this.weaknessItemConfig.ResourceId, parentItem, true);
		}

		// Token: 0x0603BE6F RID: 245359 RVA: 0x00E4FA48 File Offset: 0x00E4DC48
		public bool RecycleWeaknessItem(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleWeaknessItem", actor, null);
				return true;
			}
			return this.RecycleActor(this.weaknessItemConfig.ResourceId, actor, true);
		}

		// Token: 0x0603BE70 RID: 245360 RVA: 0x00E4FA7C File Offset: 0x00E4DC7C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<AActor> LoadActorNoCache(string path, UUIItem parentItem)
		{
			BattleUiPool.<LoadActorNoCache>d__35 <LoadActorNoCache>d__;
			<LoadActorNoCache>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<LoadActorNoCache>d__.<>4__this = this;
			<LoadActorNoCache>d__.path = path;
			<LoadActorNoCache>d__.parentItem = parentItem;
			<LoadActorNoCache>d__.<>1__state = -1;
			<LoadActorNoCache>d__.<>t__builder.Start<BattleUiPool.<LoadActorNoCache>d__35>(ref <LoadActorNoCache>d__);
			return <LoadActorNoCache>d__.<>t__builder.Task;
		}

		// Token: 0x0603BE71 RID: 245361 RVA: 0x00E4FAD0 File Offset: 0x00E4DCD0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<AActor> LoadActor(string path, USceneComponent parentItem)
		{
			BattleUiPool.<LoadActor>d__36 <LoadActor>d__;
			<LoadActor>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<LoadActor>d__.<>4__this = this;
			<LoadActor>d__.path = path;
			<LoadActor>d__.parentItem = parentItem;
			<LoadActor>d__.<>1__state = -1;
			<LoadActor>d__.<>t__builder.Start<BattleUiPool.<LoadActor>d__36>(ref <LoadActor>d__);
			return <LoadActor>d__.<>t__builder.Task;
		}

		// Token: 0x0603BE72 RID: 245362 RVA: 0x00E4FB24 File Offset: 0x00E4DD24
		private AActor GetActorFromPoolElement(BattleUiPoolElement poolElement, USceneComponent parentItem)
		{
			AActor aactor;
			if (poolElement.ActorList.TryPop(out aactor))
			{
				aactor.K2_AttachRootComponentTo(parentItem, default(FName), EAttachLocation.KeepRelativeOffset, true);
				return aactor;
			}
			return LguiUtil.Instance.DuplicateActor(poolElement.Actor, parentItem);
		}

		// Token: 0x0603BE73 RID: 245363 RVA: 0x00E4FB68 File Offset: 0x00E4DD68
		public bool RecycleActorByPath(string path, AActor actor, bool resetParent = false)
		{
			if (!this.Inited)
			{
				return true;
			}
			BattleUiPoolElement battleUiPoolElement;
			if (!this.ActorMap.TryGetValue(path, out battleUiPoolElement))
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleActorByPath", actor, null);
				return true;
			}
			battleUiPoolElement.ActorList.Add(actor);
			(actor.RootComponent as UUIItem).SetUIActive(false);
			if (resetParent)
			{
				actor.K2_AttachRootComponentTo(this.PoolRoot, default(FName), EAttachLocation.KeepRelativeOffset, true);
			}
			return true;
		}

		// Token: 0x0603BE74 RID: 245364 RVA: 0x00E4FBDC File Offset: 0x00E4DDDC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<AActor> LoadSingleActorByPath(string path, UUIItem parentItem)
		{
			BattleUiPool.<LoadSingleActorByPath>d__39 <LoadSingleActorByPath>d__;
			<LoadSingleActorByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<LoadSingleActorByPath>d__.<>4__this = this;
			<LoadSingleActorByPath>d__.path = path;
			<LoadSingleActorByPath>d__.parentItem = parentItem;
			<LoadSingleActorByPath>d__.<>1__state = -1;
			<LoadSingleActorByPath>d__.<>t__builder.Start<BattleUiPool.<LoadSingleActorByPath>d__39>(ref <LoadSingleActorByPath>d__);
			return <LoadSingleActorByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0603BE75 RID: 245365 RVA: 0x00E4FC30 File Offset: 0x00E4DE30
		public bool RecycleSingleActor(AActor actor, bool resetParent = false)
		{
			if (!this.Inited)
			{
				return true;
			}
			(actor.RootComponent as UUIItem).SetUIActive(false);
			if (resetParent)
			{
				actor.K2_AttachRootComponentTo(this.PoolRoot, default(FName), EAttachLocation.KeepRelativeOffset, true);
			}
			return true;
		}

		// Token: 0x0603BE76 RID: 245366 RVA: 0x00E4FC74 File Offset: 0x00E4DE74
		[return: Nullable(0)]
		public UniTask<bool> PreloadSingleActorByPath(string path, UUIItem parentItem)
		{
			BattleUiPool.<PreloadSingleActorByPath>d__41 <PreloadSingleActorByPath>d__;
			<PreloadSingleActorByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreloadSingleActorByPath>d__.<>4__this = this;
			<PreloadSingleActorByPath>d__.path = path;
			<PreloadSingleActorByPath>d__.parentItem = parentItem;
			<PreloadSingleActorByPath>d__.<>1__state = -1;
			<PreloadSingleActorByPath>d__.<>t__builder.Start<BattleUiPool.<PreloadSingleActorByPath>d__41>(ref <PreloadSingleActorByPath>d__);
			return <PreloadSingleActorByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0603BE77 RID: 245367 RVA: 0x00E4FCC8 File Offset: 0x00E4DEC8
		public void Clear()
		{
			this.UiPrefabLoadModule.Clear();
			foreach (BattleUiPoolElement battleUiPoolElement in this.ActorMap.Values)
			{
				battleUiPoolElement.Clear();
			}
			this.ActorMap.Clear();
			foreach (AActor actor in this.SingleActorMap.Values)
			{
				ActorSystem.Instance.Put("BattleUiPool.Clear", actor, null);
			}
			this.SingleActorMap.Clear();
			this.Inited = false;
			this.WorldRoot = null;
			this.PoolRoot = null;
			this.UiRoot = null;
		}

		// Token: 0x0603BE79 RID: 245369 RVA: 0x00E4FE90 File Offset: 0x00E4E090
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static BattleUiPool()
		{
			int num = 5;
			List<IPreLoad> list = new List<IPreLoad>(num);
			CollectionsMarshal.SetCount<IPreLoad>(list, num);
			Span<IPreLoad> span = CollectionsMarshal.AsSpan<IPreLoad>(list);
			int num2 = 0;
			*span[num2] = new BattleUiPool.PreLoadConfig
			{
				ResourceId = "UiItem_LittleMonsterState_Prefab",
				PreloadCount = 6
			};
			num2++;
			*span[num2] = new BattleUiPool.PreLoadConfig
			{
				ResourceId = "UiItem_MingsutiState_Prefab",
				PreloadCount = 1
			};
			num2++;
			*span[num2] = new BattleUiPool.PreLoadConfig
			{
				ResourceId = "UiItem_GuardianState_Prefab",
				PreloadCount = 1
			};
			num2++;
			*span[num2] = new BattleUiPool.PreLoadConfig
			{
				ResourceId = "UiItem_EliteMonsterState_Prefab",
				PreloadCount = 4
			};
			num2++;
			*span[num2] = new BattleUiPool.PreLoadConfig
			{
				ResourceId = "UiItem_DestructionState_Prefab",
				PreloadCount = 1
			};
			BattleUiPool.headStateConfigList = list;
		}

		// Token: 0x0401F3E6 RID: 127974
		[StaticVariableRuleIgnore]
		private static readonly List<IPreLoad> headStateConfigList;

		// Token: 0x0401F3E7 RID: 127975
		private readonly BattleUiPool.PreLoadConfig bossHeadStateConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_BossState_Prefab",
			PreloadCount = 0
		};

		// Token: 0x0401F3E8 RID: 127976
		private readonly BattleUiPool.PreLoadConfig damageViewConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_DamageView_Prefab",
			PreloadCount = 21
		};

		// Token: 0x0401F3E9 RID: 127977
		private readonly BattleUiPool.PreLoadConfig buffItemConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_BuffItem_Prefab",
			PreloadCount = 5
		};

		// Token: 0x0401F3EA RID: 127978
		private readonly BattleUiPool.PreLoadConfig environmentItemConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_BuffEnvironmentItem_Prefab",
			PreloadCount = 5
		};

		// Token: 0x0401F3EB RID: 127979
		private readonly BattleUiPool.PreLoadConfig weaknessItemConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_FightBossConcertoState",
			PreloadCount = 5
		};

		// Token: 0x0401F3EC RID: 127980
		private readonly BattleUiPool.PreLoadConfig quickHackBuffItemConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_QuickHack_BuffItem__Prefab",
			PreloadCount = 5
		};

		// Token: 0x0401F3ED RID: 127981
		private readonly Dictionary<string, BattleUiPoolElement> ActorMap = new Dictionary<string, BattleUiPoolElement>();

		// Token: 0x0401F3EE RID: 127982
		private readonly Dictionary<string, AActor> SingleActorMap = new Dictionary<string, AActor>();

		// Token: 0x0401F3EF RID: 127983
		private readonly UiPrefabLoadModule UiPrefabLoadModule = new UiPrefabLoadModule();

		// Token: 0x0401F3F0 RID: 127984
		private bool Inited;

		// Token: 0x0401F3F1 RID: 127985
		[Nullable(2)]
		private UUIItem WorldRoot;

		// Token: 0x0401F3F2 RID: 127986
		[Nullable(2)]
		private UUIItem PoolRoot;

		// Token: 0x0401F3F3 RID: 127987
		[Nullable(2)]
		private UUIItem UiRoot;

		// Token: 0x0401F3F4 RID: 127988
		[Nullable(2)]
		private UUIItem DamageViewRoot;

		// Token: 0x0200BE79 RID: 48761
		[Nullable(0)]
		private class PreLoadConfig : IPreLoad
		{
			// Token: 0x1700A25B RID: 41563
			// (get) Token: 0x06050054 RID: 327764 RVA: 0x0157153A File Offset: 0x0156F73A
			// (set) Token: 0x06050055 RID: 327765 RVA: 0x01571542 File Offset: 0x0156F742
			public string ResourceId { get; set; } = string.Empty;

			// Token: 0x1700A25C RID: 41564
			// (get) Token: 0x06050056 RID: 327766 RVA: 0x0157154B File Offset: 0x0156F74B
			// (set) Token: 0x06050057 RID: 327767 RVA: 0x01571553 File Offset: 0x0156F753
			public int PreloadCount { get; set; }
		}
	}
}
