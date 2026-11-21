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
	// Token: 0x02004C7F RID: 19583
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiPool
	{
		// Token: 0x06030DB0 RID: 200112 RVA: 0x00D9FB90 File Offset: 0x00D9DD90
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

		// Token: 0x06030DB1 RID: 200113 RVA: 0x00D9FBD4 File Offset: 0x00D9DDD4
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

		// Token: 0x06030DB2 RID: 200114 RVA: 0x00D9FCBC File Offset: 0x00D9DEBC
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

		// Token: 0x06030DB3 RID: 200115 RVA: 0x00D9FD00 File Offset: 0x00D9DF00
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

		// Token: 0x06030DB4 RID: 200116 RVA: 0x00D9FD54 File Offset: 0x00D9DF54
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

		// Token: 0x06030DB5 RID: 200117 RVA: 0x00D9FE68 File Offset: 0x00D9E068
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

		// Token: 0x06030DB6 RID: 200118 RVA: 0x00D9FF4C File Offset: 0x00D9E14C
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

		// Token: 0x06030DB7 RID: 200119 RVA: 0x00D9FF79 File Offset: 0x00D9E179
		[return: Nullable(2)]
		public AActor GetHeadStateView(string resourceId)
		{
			return this.GetActor(resourceId, this.WorldRoot, false);
		}

		// Token: 0x06030DB8 RID: 200120 RVA: 0x00D9FF89 File Offset: 0x00D9E189
		public bool RecycleHeadStateView(string resourceId, AActor actor, bool resetParent = false)
		{
			return !this.Inited || this.RecycleActor(resourceId, actor, resetParent);
		}

		// Token: 0x06030DB9 RID: 200121 RVA: 0x00D9FF9E File Offset: 0x00D9E19E
		[NullableContext(2)]
		public AActor GetDamageView()
		{
			return this.GetActor(this.damageViewConfig.ResourceId, this.DamageViewRoot, false);
		}

		// Token: 0x06030DBA RID: 200122 RVA: 0x00D9FFB8 File Offset: 0x00D9E1B8
		public bool RecycleDamageView(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleDamageView", actor, null);
				return true;
			}
			return this.RecycleActor(this.damageViewConfig.ResourceId, actor, false);
		}

		// Token: 0x06030DBB RID: 200123 RVA: 0x00D9FFE9 File Offset: 0x00D9E1E9
		[return: Nullable(2)]
		public AActor GetBuffItem(USceneComponent parentItem)
		{
			return this.GetActor(this.buffItemConfig.ResourceId, parentItem, true);
		}

		// Token: 0x06030DBC RID: 200124 RVA: 0x00D9FFFE File Offset: 0x00D9E1FE
		public bool RecycleBuffItem(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleBuffItem", actor, null);
				return true;
			}
			return this.RecycleActor(this.buffItemConfig.ResourceId, actor, true);
		}

		// Token: 0x06030DBD RID: 200125 RVA: 0x00DA002F File Offset: 0x00D9E22F
		[return: Nullable(2)]
		public AActor GetQuickHackBuffItem(USceneComponent parentItem)
		{
			return this.GetActor(this.quickHackBuffItemConfig.ResourceId, parentItem, true);
		}

		// Token: 0x06030DBE RID: 200126 RVA: 0x00DA0044 File Offset: 0x00D9E244
		public bool RecycleQuickHackBuffItem(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleQuickHackBuffItem", actor, null);
				return true;
			}
			return this.RecycleActor(this.quickHackBuffItemConfig.ResourceId, actor, true);
		}

		// Token: 0x06030DBF RID: 200127 RVA: 0x00DA0075 File Offset: 0x00D9E275
		[return: Nullable(2)]
		public AActor GetEnvironmentItem(USceneComponent parentItem)
		{
			return this.GetActor(this.environmentItemConfig.ResourceId, parentItem, true);
		}

		// Token: 0x06030DC0 RID: 200128 RVA: 0x00DA008A File Offset: 0x00D9E28A
		public bool RecycleEnvironmentItem(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleEnvironmentItem", actor, null);
				return true;
			}
			return this.RecycleActor(this.environmentItemConfig.ResourceId, actor, true);
		}

		// Token: 0x06030DC1 RID: 200129 RVA: 0x00DA00BB File Offset: 0x00D9E2BB
		[return: Nullable(2)]
		public AActor GetWeaknessItem(USceneComponent parentItem)
		{
			return this.GetActor(this.weaknessItemConfig.ResourceId, parentItem, true);
		}

		// Token: 0x06030DC2 RID: 200130 RVA: 0x00DA00D0 File Offset: 0x00D9E2D0
		public bool RecycleWeaknessItem(AActor actor)
		{
			if (!this.Inited)
			{
				ActorSystem.Instance.Put("BattleUiPool.RecycleWeaknessItem", actor, null);
				return true;
			}
			return this.RecycleActor(this.weaknessItemConfig.ResourceId, actor, true);
		}

		// Token: 0x06030DC3 RID: 200131 RVA: 0x00DA0104 File Offset: 0x00D9E304
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

		// Token: 0x06030DC4 RID: 200132 RVA: 0x00DA0158 File Offset: 0x00D9E358
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

		// Token: 0x06030DC5 RID: 200133 RVA: 0x00DA01AC File Offset: 0x00D9E3AC
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

		// Token: 0x06030DC6 RID: 200134 RVA: 0x00DA01F0 File Offset: 0x00D9E3F0
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

		// Token: 0x06030DC7 RID: 200135 RVA: 0x00DA0264 File Offset: 0x00D9E464
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

		// Token: 0x06030DC8 RID: 200136 RVA: 0x00DA02B8 File Offset: 0x00D9E4B8
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

		// Token: 0x06030DC9 RID: 200137 RVA: 0x00DA02FC File Offset: 0x00D9E4FC
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

		// Token: 0x06030DCA RID: 200138 RVA: 0x00DA0350 File Offset: 0x00D9E550
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

		// Token: 0x06030DCC RID: 200140 RVA: 0x00DA0518 File Offset: 0x00D9E718
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

		// Token: 0x04019E9F RID: 106143
		[StaticVariableRuleIgnore]
		private static readonly List<IPreLoad> headStateConfigList;

		// Token: 0x04019EA0 RID: 106144
		private readonly BattleUiPool.PreLoadConfig bossHeadStateConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_BossState_Prefab",
			PreloadCount = 0
		};

		// Token: 0x04019EA1 RID: 106145
		private readonly BattleUiPool.PreLoadConfig damageViewConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_DamageView_Prefab",
			PreloadCount = 21
		};

		// Token: 0x04019EA2 RID: 106146
		private readonly BattleUiPool.PreLoadConfig buffItemConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_BuffItem_Prefab",
			PreloadCount = 5
		};

		// Token: 0x04019EA3 RID: 106147
		private readonly BattleUiPool.PreLoadConfig environmentItemConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_BuffEnvironmentItem_Prefab",
			PreloadCount = 5
		};

		// Token: 0x04019EA4 RID: 106148
		private readonly BattleUiPool.PreLoadConfig weaknessItemConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_FightBossConcertoState",
			PreloadCount = 5
		};

		// Token: 0x04019EA5 RID: 106149
		private readonly BattleUiPool.PreLoadConfig quickHackBuffItemConfig = new BattleUiPool.PreLoadConfig
		{
			ResourceId = "UiItem_QuickHack_BuffItem__Prefab",
			PreloadCount = 5
		};

		// Token: 0x04019EA6 RID: 106150
		private readonly Dictionary<string, BattleUiPoolElement> ActorMap = new Dictionary<string, BattleUiPoolElement>();

		// Token: 0x04019EA7 RID: 106151
		private readonly Dictionary<string, AActor> SingleActorMap = new Dictionary<string, AActor>();

		// Token: 0x04019EA8 RID: 106152
		private readonly UiPrefabLoadModule UiPrefabLoadModule = new UiPrefabLoadModule();

		// Token: 0x04019EA9 RID: 106153
		private bool Inited;

		// Token: 0x04019EAA RID: 106154
		[Nullable(2)]
		private UUIItem WorldRoot;

		// Token: 0x04019EAB RID: 106155
		[Nullable(2)]
		private UUIItem PoolRoot;

		// Token: 0x04019EAC RID: 106156
		[Nullable(2)]
		private UUIItem UiRoot;

		// Token: 0x04019EAD RID: 106157
		[Nullable(2)]
		private UUIItem DamageViewRoot;

		// Token: 0x0200A87F RID: 43135
		[Nullable(0)]
		private class PreLoadConfig : IPreLoad
		{
			// Token: 0x170079F8 RID: 31224
			// (get) Token: 0x06046596 RID: 288150 RVA: 0x0152A8CA File Offset: 0x01528ACA
			// (set) Token: 0x06046597 RID: 288151 RVA: 0x0152A8D2 File Offset: 0x01528AD2
			public string ResourceId { get; set; } = string.Empty;

			// Token: 0x170079F9 RID: 31225
			// (get) Token: 0x06046598 RID: 288152 RVA: 0x0152A8DB File Offset: 0x01528ADB
			// (set) Token: 0x06046599 RID: 288153 RVA: 0x0152A8E3 File Offset: 0x01528AE3
			public int PreloadCount { get; set; }
		}
	}
}
