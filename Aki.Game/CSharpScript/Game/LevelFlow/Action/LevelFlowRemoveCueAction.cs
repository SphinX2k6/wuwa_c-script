using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200611A RID: 24858
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowRemoveCueAction : LevelFlowActionBase
	{
		// Token: 0x0603B90C RID: 243980 RVA: 0x010E44EB File Offset: 0x010E26EB
		public LevelFlowRemoveCueAction Init(int entityId, List<long> cueIdList, bool isFloater = false)
		{
			this.EntityId = entityId;
			this.IsFloater = isFloater;
			this.CueIdList = cueIdList;
			return this;
		}

		// Token: 0x0603B90D RID: 243981 RVA: 0x010E4504 File Offset: 0x010E2704
		protected override void OnExecute()
		{
			EntityHandle entityHandle;
			if (this.IsFloater)
			{
				entityHandle = FollowUtils.GetPlayerFollowShooter(CreatureModel.Instance.GetPlayerId());
			}
			else
			{
				entityHandle = CreatureModel.Instance.GetEntityById(this.EntityId);
			}
			if (entityHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Entity加载超时或已被移除";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false);
				return;
			}
			WorldEntity entity = entityHandle.Entity;
			if (entity == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelFlow;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "未找到实体";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", this.EntityId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false);
				return;
			}
			BaseGameplayCueComponent component = entity.GetComponent<BaseGameplayCueComponent>();
			if (component == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.LevelFlow;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "实体没有BaseGameplayCueComponent";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("EntityId", this.EntityId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				base.FinishExecute(false);
				return;
			}
			foreach (long cueId in this.CueIdList)
			{
				component.RemoveCue(cueId);
			}
			base.FinishExecute(true);
		}

		// Token: 0x0401F69A RID: 128666
		public int EntityId;

		// Token: 0x0401F69B RID: 128667
		public bool IsFloater;

		// Token: 0x0401F69C RID: 128668
		public List<long> CueIdList = new List<long>();
	}
}
