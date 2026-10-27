using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E00 RID: 28160
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class GuaranteeController : ControllerBase
	{
		// Token: 0x06044B2B RID: 281387 RVA: 0x010F4D34 File Offset: 0x010F2F34
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.AddGuaranteeAction));
			EventSystem.Instance.Add<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.RemGuaranteeAction));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.ExecSceneGuaranteeActions));
			return true;
		}

		// Token: 0x06044B2C RID: 281388 RVA: 0x010F4D98 File Offset: 0x010F2F98
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.AddGuaranteeAction, new <>f__AnonymousDelegate1<string, GeneralContext, GuaranteeActionInfo, bool?>(this.AddGuaranteeAction));
			EventSystem.Instance.Remove(EEventName.RemGuaranteeAction, new <>f__AnonymousDelegate1<string, GeneralContext, GuaranteeActionInfo, bool?>(this.RemGuaranteeAction));
			EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.ExecSceneGuaranteeActions));
			LevelGeneralModel instance = LevelGeneralModel.Instance;
			Dictionary<EntityHandle, List<GuaranteeActionInfo>> dictionary = (instance != null) ? instance.GetEntityGuaranteeActionInfos() : null;
			if (dictionary != null)
			{
				foreach (EntityHandle entityHandle in dictionary.Keys)
				{
					if (entityHandle != null && entityHandle.Valid && EventSystem.Instance.HasWithTarget(entityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ExecEntityGuaranteeActions)))
					{
						EventSystem.Instance.RemoveWithTarget(entityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ExecEntityGuaranteeActions));
					}
				}
				LevelGeneralModel instance2 = LevelGeneralModel.Instance;
				if (instance2 != null)
				{
					instance2.ClearEntityGuaranteeActionInfos();
				}
			}
			return true;
		}

		// Token: 0x06044B2D RID: 281389 RVA: 0x010F4EA8 File Offset: 0x010F30A8
		public void ExecSceneGuaranteeActions()
		{
			LevelGeneralModel instance = LevelGeneralModel.Instance;
			List<GuaranteeActionInfo> list = (instance != null) ? instance.RemoveSceneGuaranteeActionInfos() : null;
			if (list != null && list.Count > 0)
			{
				list.Reverse();
				List<GuaranteeActionInfo> list2 = list;
				this.ExecuteActions(list2, GuaranteeContext.Create(null, EGuaranteeReason.Unknown));
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "场景保底行为已全部完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("保底行为列表", list2);
				instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06044B2E RID: 281390 RVA: 0x010F4F18 File Offset: 0x010F3118
		public void ExecEntityGuaranteeActions(ERemoveEntityType removeType, EntityHandle handle)
		{
			LevelGeneralModel instance = LevelGeneralModel.Instance;
			List<GuaranteeActionInfo> list = (instance != null) ? instance.RemoveEntityGuaranteeActionInfos(handle) : null;
			if (handle != null && handle.Valid && EventSystem.Instance.HasWithTarget(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ExecEntityGuaranteeActions)))
			{
				EventSystem.Instance.RemoveWithTarget(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ExecEntityGuaranteeActions));
			}
			if (list != null && list.Count > 0)
			{
				list.Reverse();
				List<GuaranteeActionInfo> actionInfos = list;
				this.ExecuteActions(actionInfos, GuaranteeContext.Create(null, EGuaranteeReason.Unknown));
			}
		}

		// Token: 0x06044B2F RID: 281391 RVA: 0x010F4FA8 File Offset: 0x010F31A8
		private void AddGuaranteeAction(string instigatorName, [Nullable(2)] GeneralContext instigatorContext, GuaranteeActionInfo guaranteeActionInfo, bool? bNeedGuaranteeInQuest = false)
		{
			this.UpdateGuaranteeActions(instigatorName, instigatorContext, true, guaranteeActionInfo, bNeedGuaranteeInQuest.GetValueOrDefault());
		}

		// Token: 0x06044B30 RID: 281392 RVA: 0x010F4FBB File Offset: 0x010F31BB
		private void RemGuaranteeAction(string instigatorName, [Nullable(2)] GeneralContext instigatorContext, GuaranteeActionInfo guaranteeActionInfo, bool? bNeedGuaranteeInQuest = false)
		{
			this.UpdateGuaranteeActions(instigatorName, instigatorContext, false, guaranteeActionInfo, bNeedGuaranteeInQuest.GetValueOrDefault());
		}

		// Token: 0x06044B31 RID: 281393 RVA: 0x010F4FD0 File Offset: 0x010F31D0
		private unsafe void UpdateGuaranteeActions(string instigatorName, [Nullable(2)] GeneralContext instigatorContext, bool isAdd, GuaranteeActionInfo guaranteeActionInfo, bool bNeedGuaranteeInQuest)
		{
			if (instigatorContext == null || instigatorContext.Type.GetValueOrDefault() == EGeneralContextType.Guarantee)
			{
				return;
			}
			if (guaranteeActionInfo == null)
			{
				return;
			}
			EGuaranteeAction name = guaranteeActionInfo.Name;
			if (instigatorContext.Type.GetValueOrDefault() != EGeneralContextType.Entity)
			{
				EActionFilterMode actionFilterMode = GuaranteeActionCenter.Instance.GetActionFilterMode(guaranteeActionInfo.Name);
				LevelGeneralModel instance = LevelGeneralModel.Instance;
				if (isAdd)
				{
					if (!instance.HasSceneGuaranteeActionInfo(guaranteeActionInfo, actionFilterMode))
					{
						instance.AddSceneGuaranteeActionInfo(guaranteeActionInfo);
						Log instance2 = Log.Instance;
						ELogModule module = ELogModule.LevelEvent;
						ELogAuthor author = ELogAuthor.ZYL;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
						defaultInterpolatedStringHandler.AppendLiteral("添加场景保底行为：");
						defaultInterpolatedStringHandler.AppendFormatted<EGuaranteeAction>(guaranteeActionInfo.Name);
						string message = defaultInterpolatedStringHandler.ToStringAndClear();
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("触发行为", instigatorName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionInfo", guaranteeActionInfo);
						instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return;
					}
				}
				else
				{
					instance.PopSceneGuaranteeActionInfo(guaranteeActionInfo);
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.LevelEvent;
					ELogAuthor author2 = ELogAuthor.ZYL;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("移除场景保底行为：");
					defaultInterpolatedStringHandler.AppendFormatted<EGuaranteeAction>(guaranteeActionInfo.Name);
					string message2 = defaultInterpolatedStringHandler.ToStringAndClear();
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("触发行为", instigatorName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ActionInfo", guaranteeActionInfo);
					instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				return;
			}
			EntityContext entityContext = instigatorContext as EntityContext;
			if (entityContext == null || entityContext.EntityId == null)
			{
				return;
			}
			EActionFilterMode actionFilterMode2 = GuaranteeActionCenter.Instance.GetActionFilterMode(guaranteeActionInfo.Name);
			LevelGeneralModel instance4 = LevelGeneralModel.Instance;
			if (isAdd)
			{
				if (!instance4.HasEntityGuaranteeActionInfo(entityContext.EntityId, guaranteeActionInfo, actionFilterMode2))
				{
					instance4.AddEntityGuaranteeActionInfo(entityContext.EntityId, guaranteeActionInfo);
					EntityHandle handle = CharacterModel.Instance.GetHandle(entityContext.EntityId.GetValueOrDefault());
					if (handle != null && handle.Valid && !EventSystem.Instance.HasWithTarget(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ExecEntityGuaranteeActions)))
					{
						EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ExecEntityGuaranteeActions));
						return;
					}
				}
			}
			else
			{
				EntityHandle handle2 = CharacterModel.Instance.GetHandle(entityContext.EntityId.GetValueOrDefault());
				if (handle2 != null && handle2.Valid && EventSystem.Instance.HasWithTarget(handle2, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ExecEntityGuaranteeActions)))
				{
					EventSystem.Instance.RemoveWithTarget(handle2, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ExecEntityGuaranteeActions));
				}
				instance4.PopEntityGuaranteeActionInfo(entityContext.EntityId, guaranteeActionInfo);
			}
		}

		// Token: 0x06044B32 RID: 281394 RVA: 0x010F5284 File Offset: 0x010F3484
		public unsafe void ExecuteActions(List<GuaranteeActionInfo> actionInfos, GuaranteeContext context)
		{
			if (context == null)
			{
				return;
			}
			foreach (GuaranteeActionInfo guaranteeActionInfo in actionInfos)
			{
				EGuaranteeAction name = guaranteeActionInfo.Name;
				GuaranteeActionBase guaranteeAction = GuaranteeActionCenter.Instance.GetGuaranteeAction(name);
				if (guaranteeAction != null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "执行保底行为：";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionName", name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionInfo", guaranteeActionInfo);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					guaranteeAction.Execute(guaranteeActionInfo, context);
				}
			}
		}

		// Token: 0x170099EB RID: 39403
		// (get) Token: 0x06044B33 RID: 281395 RVA: 0x010F5350 File Offset: 0x010F3550
		public static GuaranteeController Instance
		{
			get
			{
				return GuaranteeController._Instance;
			}
		}

		// Token: 0x06044B34 RID: 281396 RVA: 0x010F5357 File Offset: 0x010F3557
		public static GuaranteeController GetOrCreateInstance()
		{
			if (GuaranteeController._Instance == null)
			{
				GuaranteeController.CreateInstance();
			}
			return GuaranteeController._Instance;
		}

		// Token: 0x06044B35 RID: 281397 RVA: 0x010F536B File Offset: 0x010F356B
		public static bool CreateInstance()
		{
			if (GuaranteeController._Instance != null)
			{
				return true;
			}
			GuaranteeController._Instance = new GuaranteeController();
			return true;
		}

		// Token: 0x06044B36 RID: 281398 RVA: 0x010F5381 File Offset: 0x010F3581
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044B37 RID: 281399 RVA: 0x010F5383 File Offset: 0x010F3583
		public static void ResetStaticDefaultValue()
		{
			GuaranteeController._Instance = null;
		}

		// Token: 0x06044B38 RID: 281400 RVA: 0x010F538B File Offset: 0x010F358B
		static GuaranteeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuaranteeController.CreateStaticDefaultValue), new Action(GuaranteeController.ResetStaticDefaultValue));
		}

		// Token: 0x04023BCC RID: 146380
		[Nullable(2)]
		private static GuaranteeController _Instance;
	}
}
