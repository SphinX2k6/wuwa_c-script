using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034F9 RID: 13561
	[NullableContext(1)]
	[Nullable(0)]
	public class UltraSkillEffectStateWatcher
	{
		// Token: 0x17004860 RID: 18528
		// (get) Token: 0x06022817 RID: 141335 RVA: 0x009CB1C5 File Offset: 0x009C93C5
		private static int UltraSkillTagId
		{
			get
			{
				return GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"];
			}
		}

		// Token: 0x06022818 RID: 141336 RVA: 0x009CB1D8 File Offset: 0x009C93D8
		public void Init()
		{
			if (this.Initialized)
			{
				return;
			}
			this.Initialized = true;
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			EventSystem.Instance.Add(EEventName.OnSequenceCameraStatus, new Action<bool, string>(this.OnSequenceCameraStatus));
			this.RefreshUltraSkillListeners();
		}

		// Token: 0x06022819 RID: 141337 RVA: 0x009CB234 File Offset: 0x009C9434
		public void Clear()
		{
			if (!this.Initialized)
			{
				return;
			}
			this.Initialized = false;
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			EventSystem.Instance.Remove(EEventName.OnSequenceCameraStatus, new Action<bool, string>(this.OnSequenceCameraStatus));
			foreach (int entityId in new List<int>(this.UltraSkillTagCallbacks.Keys))
			{
				this.UnregisterUltraSkillListener(entityId);
			}
			this.UltraSkillTagCallbacks.Clear();
			this.UltraSkillEntityIds.Clear();
		}

		// Token: 0x0602281A RID: 141338 RVA: 0x009CB2F0 File Offset: 0x009C94F0
		private void OnUpdateSceneTeam()
		{
			this.RefreshUltraSkillListeners();
		}

		// Token: 0x0602281B RID: 141339 RVA: 0x009CB2F8 File Offset: 0x009C94F8
		private void OnSequenceCameraStatus(bool status, string cameraName)
		{
			if (status || cameraName != "MainCamera")
			{
				return;
			}
			foreach (int entityId in this.UltraSkillEntityIds)
			{
				EffectSystem.Instance.SetEntityUltraSkillState(entityId, false);
			}
			this.UltraSkillEntityIds.Clear();
		}

		// Token: 0x0602281C RID: 141340 RVA: 0x009CB36C File Offset: 0x009C956C
		private void RefreshUltraSkillListeners()
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			if (instance == null)
			{
				return;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (SceneTeamItem sceneTeamItem in instance.GetTeamItems(false))
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				if (sceneTeamItem.IsMyRole() && entityHandle != null)
				{
					hashSet.Add(entityHandle.Id);
				}
			}
			foreach (int num in new List<int>(this.UltraSkillTagCallbacks.Keys))
			{
				if (!hashSet.Contains(num))
				{
					this.UnregisterUltraSkillListener(num);
				}
			}
			foreach (int num2 in hashSet)
			{
				if (!this.UltraSkillTagCallbacks.ContainsKey(num2))
				{
					this.RegisterUltraSkillListener(num2);
				}
			}
		}

		// Token: 0x0602281D RID: 141341 RVA: 0x009CB490 File Offset: 0x009C9690
		private void RegisterUltraSkillListener(int entityId)
		{
			UltraSkillEffectStateWatcher.<>c__DisplayClass10_0 CS$<>8__locals1 = new UltraSkillEffectStateWatcher.<>c__DisplayClass10_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.entityId = entityId;
			Entity entity = EntitySystem.Instance.Get(CS$<>8__locals1.entityId);
			RoleTagComponent roleTagComponent = (entity != null) ? entity.GetComponent<RoleTagComponent>() : null;
			if (roleTagComponent == null)
			{
				return;
			}
			roleTagComponent.AddTagAddOrRemoveListener(UltraSkillEffectStateWatcher.UltraSkillTagId, new BaseTagComponent.TTagSwitchedCallback(CS$<>8__locals1.<RegisterUltraSkillListener>g__Callback|0), null);
			this.UltraSkillTagCallbacks[CS$<>8__locals1.entityId] = new BaseTagComponent.TTagSwitchedCallback(CS$<>8__locals1.<RegisterUltraSkillListener>g__Callback|0);
			if (roleTagComponent.HasTag(UltraSkillEffectStateWatcher.UltraSkillTagId))
			{
				this.UltraSkillEntityIds.Add(CS$<>8__locals1.entityId);
			}
			EffectSystem.Instance.SetEntityUltraSkillState(CS$<>8__locals1.entityId, roleTagComponent.HasTag(UltraSkillEffectStateWatcher.UltraSkillTagId));
		}

		// Token: 0x0602281E RID: 141342 RVA: 0x009CB544 File Offset: 0x009C9744
		private void UnregisterUltraSkillListener(int entityId)
		{
			BaseTagComponent.TTagSwitchedCallback callback;
			if (!this.UltraSkillTagCallbacks.TryGetValue(entityId, out callback))
			{
				return;
			}
			this.UltraSkillTagCallbacks.Remove(entityId);
			this.UltraSkillEntityIds.Remove(entityId);
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity != null)
			{
				RoleTagComponent component = entity.GetComponent<RoleTagComponent>();
				if (component != null)
				{
					component.RemoveTagAddOrRemoveListener(UltraSkillEffectStateWatcher.UltraSkillTagId, callback);
				}
			}
			EffectSystem.Instance.SetEntityUltraSkillState(entityId, false);
		}

		// Token: 0x0401313C RID: 78140
		private readonly Dictionary<int, BaseTagComponent.TTagSwitchedCallback> UltraSkillTagCallbacks = new Dictionary<int, BaseTagComponent.TTagSwitchedCallback>();

		// Token: 0x0401313D RID: 78141
		private readonly HashSet<int> UltraSkillEntityIds = new HashSet<int>();

		// Token: 0x0401313E RID: 78142
		private bool Initialized;
	}
}
