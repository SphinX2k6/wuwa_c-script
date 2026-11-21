using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.Level
{
	// Token: 0x02005FDE RID: 24542
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritLevelModifier
	{
		// Token: 0x0603AF37 RID: 241463 RVA: 0x010A8E44 File Offset: 0x010A7044
		public UniTask RefreshAsync(string levelPrefabPath, bool isSelected, Vector location, Rotator rotation)
		{
			FindSunSpiritLevelModifier.<RefreshAsync>d__7 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.levelPrefabPath = levelPrefabPath;
			<RefreshAsync>d__.isSelected = isSelected;
			<RefreshAsync>d__.location = location;
			<RefreshAsync>d__.rotation = rotation;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<FindSunSpiritLevelModifier.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AF38 RID: 241464 RVA: 0x010A8EA8 File Offset: 0x010A70A8
		public void Clear()
		{
			TimerHandle triggerHandle = this.TriggerHandle;
			if (triggerHandle != null)
			{
				triggerHandle.Remove();
			}
			this.TriggerHandle = null;
			SceneInteractionManager.Get().DestroySceneInteraction(this.LevelHandleId);
		}

		// Token: 0x0603AF39 RID: 241465 RVA: 0x010A8ED4 File Offset: 0x010A70D4
		public void ResetState(bool isSelected)
		{
			TimerHandle triggerHandle = this.TriggerHandle;
			if (triggerHandle != null)
			{
				triggerHandle.Remove();
			}
			this.TriggerHandle = null;
			this.UpdateState(isSelected ? EModifierStateType.Selected : EModifierStateType.Common);
		}

		// Token: 0x0603AF3A RID: 241466 RVA: 0x010A8EFC File Offset: 0x010A70FC
		public void UpdateSelect(bool isSelected)
		{
			EModifierStateType emodifierStateType = isSelected ? EModifierStateType.Selected : EModifierStateType.Common;
			if (this.CurrentState == EModifierStateType.Trigger)
			{
				this.LastStateCache = new EModifierStateType?(emodifierStateType);
				return;
			}
			this.UpdateState(emodifierStateType);
		}

		// Token: 0x0603AF3B RID: 241467 RVA: 0x010A8F2E File Offset: 0x010A712E
		public void Trigger(int duration)
		{
			if (this.CurrentState == EModifierStateType.Trigger)
			{
				return;
			}
			this.UpdateState(EModifierStateType.Trigger);
			this.TriggerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.TriggerHandle = null;
				if (this.LastStateCache != null)
				{
					this.UpdateState(this.LastStateCache.Value);
					this.LastStateCache = null;
					return;
				}
				this.UpdateState(EModifierStateType.Selected);
			}, (float)duration, null, null, true, 1f);
		}

		// Token: 0x0603AF3C RID: 241468 RVA: 0x010A8F67 File Offset: 0x010A7167
		private void UpdateState(EModifierStateType type)
		{
			this.CurrentState = type;
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.LevelHandleId, this.GetLevelState(type), false, false, false);
		}

		// Token: 0x0603AF3D RID: 241469 RVA: 0x010A8F8B File Offset: 0x010A718B
		private EKuroSceneInteractionState GetLevelState(EModifierStateType type)
		{
			switch (type)
			{
			case EModifierStateType.Common:
				return EKuroSceneInteractionState.State1;
			case EModifierStateType.Selected:
				return EKuroSceneInteractionState.State2;
			case EModifierStateType.Trigger:
				return EKuroSceneInteractionState.State3;
			default:
				return EKuroSceneInteractionState.State1;
			}
		}

		// Token: 0x0401EFF2 RID: 126962
		private string PrefabPath = "";

		// Token: 0x0401EFF3 RID: 126963
		private int LevelHandleId;

		// Token: 0x0401EFF4 RID: 126964
		private readonly Vector Location = Vector.Create();

		// Token: 0x0401EFF5 RID: 126965
		private readonly Rotator Rotation = Rotator.Create();

		// Token: 0x0401EFF6 RID: 126966
		private EModifierStateType CurrentState;

		// Token: 0x0401EFF7 RID: 126967
		private EModifierStateType? LastStateCache;

		// Token: 0x0401EFF8 RID: 126968
		[Nullable(2)]
		private TimerHandle TriggerHandle;
	}
}
