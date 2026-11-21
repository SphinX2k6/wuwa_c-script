using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02005C56 RID: 23638
	public class LevelConditionListenerCheckEntitySelfDirection : LevelListenerBase
	{
		// Token: 0x0603A0C6 RID: 237766 RVA: 0x0105559B File Offset: 0x0105379B
		private void EventHandle()
		{
			TListenerCallbackFunc callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback(ClientEventContext.Create(EEventName.OnEntitySelfDirectionUpdate, Array.Empty<object>()), Array.Empty<object>());
		}

		// Token: 0x0603A0C7 RID: 237767 RVA: 0x010555C4 File Offset: 0x010537C4
		[NullableContext(1)]
		protected override void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
			EntityHandle entityHandle = LevelGamePlayUtils.GetEntityHandle(null, context);
			WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
			if (entityHandle == null || !entityHandle.Valid || (worldEntity == null || !worldEntity.Valid))
			{
				return;
			}
			if (!EventSystem.Instance.HasWithTarget(worldEntity, EEventName.OnEntitySelfDirectionUpdate, new Action(this.EventHandle)))
			{
				EventSystem.Instance.AddWithTargetUseHoldKey(this, worldEntity, EEventName.OnEntitySelfDirectionUpdate, new Action(this.EventHandle));
			}
		}

		// Token: 0x0603A0C8 RID: 237768 RVA: 0x01055645 File Offset: 0x01053845
		protected override void OnUnListen()
		{
			EventSystem.Instance.RemoveAllTargetUseKey(this);
		}
	}
}
