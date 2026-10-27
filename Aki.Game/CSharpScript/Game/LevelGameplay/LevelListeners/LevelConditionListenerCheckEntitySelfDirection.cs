using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02006ADE RID: 27358
	public class LevelConditionListenerCheckEntitySelfDirection : LevelListenerBase
	{
		// Token: 0x06043F74 RID: 278388 RVA: 0x010ABD23 File Offset: 0x010A9F23
		private void EventHandle()
		{
			TListenerCallbackFunc callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback(ClientEventContext.Create(EEventName.OnEntitySelfDirectionUpdate, Array.Empty<object>()), Array.Empty<object>());
		}

		// Token: 0x06043F75 RID: 278389 RVA: 0x010ABD4C File Offset: 0x010A9F4C
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

		// Token: 0x06043F76 RID: 278390 RVA: 0x010ABDCD File Offset: 0x010A9FCD
		protected override void OnUnListen()
		{
			EventSystem.Instance.RemoveAllTargetUseKey(this);
		}
	}
}
