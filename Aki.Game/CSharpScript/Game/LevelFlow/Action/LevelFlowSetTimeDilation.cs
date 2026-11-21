using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006120 RID: 24864
	public class LevelFlowSetTimeDilation : LevelFlowActionBase
	{
		// Token: 0x0603B924 RID: 244004 RVA: 0x010E4E6B File Offset: 0x010E306B
		[NullableContext(1)]
		public LevelFlowSetTimeDilation Init(int entityId, float timeDilation)
		{
			this.EntityId = entityId;
			this.TimeDilation = timeDilation;
			return this;
		}

		// Token: 0x0603B925 RID: 244005 RVA: 0x010E4E7C File Offset: 0x010E307C
		protected override void OnExecute()
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.EntityId);
			if (entityById != null && entityById.Valid)
			{
				WorldEntity entity = entityById.Entity;
				if (entity != null && entity.Valid)
				{
					entityById.Entity.SetTimeDilation(this.TimeDilation);
					base.FinishExecute(true);
					return;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "LevelFlowSetTimeDilation 实体不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.EntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
		}

		// Token: 0x0603B926 RID: 244006 RVA: 0x010E4F18 File Offset: 0x010E3118
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
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TimeDilation", this.TimeDilation);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x0401F6A5 RID: 128677
		private int EntityId;

		// Token: 0x0401F6A6 RID: 128678
		private float TimeDilation = 1f;
	}
}
