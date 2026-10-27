using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F9F RID: 28575
	public class LevelFlowSetTimeDilation : LevelFlowActionBase
	{
		// Token: 0x06045776 RID: 284534 RVA: 0x0113B067 File Offset: 0x01139267
		[NullableContext(1)]
		public LevelFlowSetTimeDilation Init(int entityId, float timeDilation)
		{
			this.EntityId = entityId;
			this.TimeDilation = timeDilation;
			return this;
		}

		// Token: 0x06045777 RID: 284535 RVA: 0x0113B078 File Offset: 0x01139278
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

		// Token: 0x06045778 RID: 284536 RVA: 0x0113B114 File Offset: 0x01139314
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

		// Token: 0x040243F0 RID: 148464
		private int EntityId;

		// Token: 0x040243F1 RID: 148465
		private float TimeDilation = 1f;
	}
}
