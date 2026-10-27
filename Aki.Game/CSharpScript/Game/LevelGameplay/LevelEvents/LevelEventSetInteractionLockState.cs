using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Interaction;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B75 RID: 27509
	public class LevelEventSetInteractionLockState : LevelEventBase
	{
		// Token: 0x06044240 RID: 279104 RVA: 0x010C9065 File Offset: 0x010C7265
		public LevelEventSetInteractionLockState(int id) : base(id)
		{
		}

		// Token: 0x06044241 RID: 279105 RVA: 0x010C9070 File Offset: 0x010C7270
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.WLJ, "参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SetInteractionLockState setInteractionLockState = inParams as SetInteractionLockState;
			if (setInteractionLockState == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.WLJ, "参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.WLJ, "此LevelEvent只能接受以EntityContext为上下文", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int? interactingEntity = InteractionModel.Instance.InteractingEntity;
			int? entityId = entityContext.EntityId;
			if (!(interactingEntity.GetValueOrDefault() == entityId.GetValueOrDefault() & interactingEntity != null == (entityId != null)))
			{
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.WLJ, "当前申请交互锁定的实体与记录的正在交互的实体不一致，可能是因为服务器重发，交互锁定行为不响应服务器重发", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "设置交互锁定状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IsLock", setInteractionLockState.IsLock);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (setInteractionLockState.IsLock)
			{
				InteractionModel.Instance.LockInteract(entityContext.EntityId);
				return;
			}
			InteractionModel.Instance.RecoverInteractFromLock();
		}
	}
}
