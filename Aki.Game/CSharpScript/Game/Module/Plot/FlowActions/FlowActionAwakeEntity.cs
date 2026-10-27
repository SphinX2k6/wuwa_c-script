using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050A8 RID: 20648
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowActionAwakeEntity : FlowActionServerAction
	{
		// Token: 0x06034E96 RID: 216726 RVA: 0x00C881C4 File Offset: 0x00C863C4
		protected unsafe override void OnExecute()
		{
			if (AutoRunModel.Instance.IsInLogicTreeGmMode())
			{
				base.FinishExecute(true, true);
				return;
			}
			if (this.ActionInfo.Params == null)
			{
				base.FinishExecute(true, true);
				return;
			}
			AwakeEntity awakeEntity = this.ActionInfo.Params as AwakeEntity;
			if (((awakeEntity != null) ? awakeEntity.EntityIds : null) == null || awakeEntity.EntityIds.Count == 0)
			{
				base.FinishExecute(true, true);
				return;
			}
			bool flag = false;
			List<int> list = new List<int>();
			foreach (int num in awakeEntity.EntityIds)
			{
				bool? flag2 = FlowActionUtils.CheckEntityInAoi(num);
				bool flag3 = false;
				if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "剧情中唤醒实体过远，请检查配置";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("pbDataId", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("flow", this.Context.FormatId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("id", this.ActionInfo.ActionId);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					flag = true;
				}
				else
				{
					list.Add(num);
				}
			}
			if (!flag)
			{
				this.AwakeEntity(awakeEntity.EntityIds);
				return;
			}
			base.RequestServerAction(false, null);
			if (list.Count == 0)
			{
				base.FinishExecute(true, true);
				return;
			}
			this.AwakeEntity(list);
		}

		// Token: 0x06034E97 RID: 216727 RVA: 0x00C8836C File Offset: 0x00C8656C
		private void AwakeEntity(List<int> entityIds)
		{
			if (entityIds.Count == 0)
			{
				return;
			}
			foreach (int pbDataId in entityIds)
			{
				CreatureController.Instance.RecoverDensityEntity(pbDataId, "Plot");
			}
			this.AwakeEntityIds = entityIds;
			this.Task = WaitEntityTask.CreateWithPbDataId("FlowActionAwakeEntity.OnExecute", entityIds, new Action<bool?>(this.OnEntityReady), 20000, false, false);
		}

		// Token: 0x06034E98 RID: 216728 RVA: 0x00C883F8 File Offset: 0x00C865F8
		private void OnEntityReady(bool? result)
		{
			this.Task = null;
			if (!result.GetValueOrDefault())
			{
				FlowController.Instance.LogError("加载实体失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (this.AwakeEntityIds != null)
			{
				List<int> list = new List<int>();
				foreach (int num in this.AwakeEntityIds)
				{
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
					if (entityByPbDataId == null)
					{
						list.Add(num);
					}
					else
					{
						CreatureController.Instance.SetEntityEnable(entityByPbDataId.Entity, true, "FlowActionAwakeEntity.OnEntityReady", false);
					}
				}
				if (list.Count > 0)
				{
					FlowController instance = FlowController.Instance;
					string text = "AwakeEntity失败的实体列表";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataIds", list);
					instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			this.AwakeEntityIds = null;
			base.RecordAction(null);
			base.FinishExecute(true, true);
		}

		// Token: 0x06034E99 RID: 216729 RVA: 0x00C884F4 File Offset: 0x00C866F4
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06034E9A RID: 216730 RVA: 0x00C884FC File Offset: 0x00C866FC
		protected override void OnInterruptExecute()
		{
			WaitEntityTask task = this.Task;
			if (task != null)
			{
				task.Cancel();
			}
			this.Task = null;
			this.AwakeEntityIds = null;
			base.FinishExecute(true, true);
		}

		// Token: 0x06034E9B RID: 216731 RVA: 0x00C88528 File Offset: 0x00C86728
		protected override void OnRollback(ActionRecord actionRecord, FlowContext context)
		{
			foreach (int pbDataId in (actionRecord.ActionInfo.Params as AwakeEntity).EntityIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
				if (entityByPbDataId != null && entityByPbDataId.IsInit)
				{
					CreatureController.Instance.SetEntityEnable(entityByPbDataId.Entity, false, "FlowActionAwakeEntity.OnRollback", false);
				}
			}
		}

		// Token: 0x0401C2FE RID: 115454
		[Nullable(2)]
		public WaitEntityTask Task;

		// Token: 0x0401C2FF RID: 115455
		[Nullable(2)]
		private List<int> AwakeEntityIds;
	}
}
