using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200611E RID: 24862
	public class LevelFlowSetClientEntityVisible : LevelFlowActionBase
	{
		// Token: 0x0603B91D RID: 243997 RVA: 0x010E49FF File Offset: 0x010E2BFF
		[NullableContext(1)]
		public LevelFlowSetClientEntityVisible Init(SetEntityClientVisible param)
		{
			this.Param = param;
			return this;
		}

		// Token: 0x0603B91E RID: 243998 RVA: 0x010E4A0C File Offset: 0x010E2C0C
		protected override void OnExecute()
		{
			SetEntityClientVisible param = this.Param;
			if (param == null)
			{
				global::Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			if (param.EntityIds == null || param.EntityIds.Count == 0)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "目标Entity未配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			foreach (int num in param.EntityIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
				WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
				if (worldEntity == null || !worldEntity.Valid)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.CH;
					string message = "目标Entity不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", num);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					CreatureController.Instance.SetEntityEnable(worldEntity, param.Visible, "LevelEventSetClientEntityVisible", true);
				}
			}
			base.FinishExecute(true);
		}

		// Token: 0x0603B91F RID: 243999 RVA: 0x010E4B40 File Offset: 0x010E2D40
		protected unsafe override void LogExecuteInfo()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "EntityIds";
			SetEntityClientVisible param = this.Param;
			ptr = new ValueTuple<string, object>(item, (((param != null) ? param.EntityIds : null) != null) ? string.Join<int>(",", this.Param.EntityIds) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item2 = "Visible";
			SetEntityClientVisible param2 = this.Param;
			ptr2 = new ValueTuple<string, object>(item2, (param2 != null) ? new bool?(param2.Visible) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x0401F6A2 RID: 128674
		[Nullable(2)]
		private SetEntityClientVisible Param;
	}
}
