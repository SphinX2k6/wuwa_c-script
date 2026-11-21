using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x020060FC RID: 24828
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowAddCueAction : LevelFlowActionBase
	{
		// Token: 0x0603B86C RID: 243820 RVA: 0x010DF273 File Offset: 0x010DD473
		public LevelFlowAddCueAction Init(int entityId, List<long> cueIdList, bool isFloater = false)
		{
			this.EntityId = entityId;
			this.CueIdList = cueIdList;
			this.IsFloater = isFloater;
			return this;
		}

		// Token: 0x0603B86D RID: 243821 RVA: 0x010DF28C File Offset: 0x010DD48C
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
				component.AddCue(cueId, null);
			}
			base.FinishExecute(true);
		}

		// Token: 0x0603B86E RID: 243822 RVA: 0x010DF3EC File Offset: 0x010DD5EC
		protected unsafe override void LogExecuteInfo()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", this.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("CueIdList", string.Join<long>(",", this.CueIdList));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x0401F650 RID: 128592
		public int EntityId;

		// Token: 0x0401F651 RID: 128593
		public bool IsFloater;

		// Token: 0x0401F652 RID: 128594
		public List<long> CueIdList = new List<long>();
	}
}
