using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.Level
{
	// Token: 0x02006E5D RID: 28253
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritLevelModifier
	{
		// Token: 0x06044DAA RID: 282026 RVA: 0x010FE8E4 File Offset: 0x010FCAE4
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

		// Token: 0x06044DAB RID: 282027 RVA: 0x010FE948 File Offset: 0x010FCB48
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

		// Token: 0x06044DAC RID: 282028 RVA: 0x010FE974 File Offset: 0x010FCB74
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

		// Token: 0x06044DAD RID: 282029 RVA: 0x010FE99C File Offset: 0x010FCB9C
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

		// Token: 0x06044DAE RID: 282030 RVA: 0x010FE9CE File Offset: 0x010FCBCE
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

		// Token: 0x06044DAF RID: 282031 RVA: 0x010FEA07 File Offset: 0x010FCC07
		private void UpdateState(EModifierStateType type)
		{
			this.CurrentState = type;
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.LevelHandleId, this.GetLevelState(type), false, false, false);
		}

		// Token: 0x06044DB0 RID: 282032 RVA: 0x010FEA2B File Offset: 0x010FCC2B
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

		// Token: 0x04023D3D RID: 146749
		private string PrefabPath = "";

		// Token: 0x04023D3E RID: 146750
		private int LevelHandleId;

		// Token: 0x04023D3F RID: 146751
		private readonly Vector Location = Vector.Create();

		// Token: 0x04023D40 RID: 146752
		private readonly Rotator Rotation = Rotator.Create();

		// Token: 0x04023D41 RID: 146753
		private EModifierStateType CurrentState;

		// Token: 0x04023D42 RID: 146754
		private EModifierStateType? LastStateCache;

		// Token: 0x04023D43 RID: 146755
		[Nullable(2)]
		private TimerHandle TriggerHandle;
	}
}
