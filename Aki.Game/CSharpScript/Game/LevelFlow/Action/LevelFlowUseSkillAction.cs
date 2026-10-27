using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FA5 RID: 28581
	public class LevelFlowUseSkillAction : LevelFlowActionBase
	{
		// Token: 0x0604578B RID: 284555 RVA: 0x0113BBAF File Offset: 0x01139DAF
		[NullableContext(1)]
		public LevelFlowUseSkillAction Init(int entityId, int skillId)
		{
			this.EntityId = entityId;
			this.SkillId = skillId;
			return this;
		}

		// Token: 0x0604578C RID: 284556 RVA: 0x0113BBC0 File Offset: 0x01139DC0
		protected override void OnExecute()
		{
			BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(this.EntityId);
			if (component == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 1);
				defaultInterpolatedStringHandler.AppendLiteral("LevelFlowUseSkillAction OnExecute entityId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.EntityId);
				defaultInterpolatedStringHandler.AppendLiteral(" not found BaseSkillComponent");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			component.BeginSkillAsync(this.SkillId, new SkillParam
			{
				Reason = "LevelFlowUseSkillAction"
			});
			base.FinishExecute(true);
		}

		// Token: 0x0604578D RID: 284557 RVA: 0x0113BC60 File Offset: 0x01139E60
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
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SkillId", this.SkillId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x040243FE RID: 148478
		private int EntityId;

		// Token: 0x040243FF RID: 148479
		private int SkillId;
	}
}
