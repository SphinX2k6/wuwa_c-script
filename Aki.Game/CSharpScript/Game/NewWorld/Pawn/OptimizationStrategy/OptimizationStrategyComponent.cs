using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.NewWorld.Pawn.OptimizationStrategy
{
	// Token: 0x02007062 RID: 28770
	[NullableContext(1)]
	[Nullable(0)]
	public class OptimizationStrategyComponent : EntityComponent
	{
		// Token: 0x06046056 RID: 286806 RVA: 0x0117428C File Offset: 0x0117248C
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			object param = args.GetP1<CreateEntityData>().GetParam<OptimizationStrategyComponent>();
			if (param == null)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.LJM, "[OptimizationStrategyComponent] 初始化基础数据失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			PerformanceOptimizationComponent performanceOptimizationComponent = param as PerformanceOptimizationComponent;
			if (performanceOptimizationComponent == null)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.LJM, "[OptimizationStrategyComponent] 初始化数据失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.OptimizationTypeList = performanceOptimizationComponent.PerformanceOptimizationList;
			return true;
		}

		// Token: 0x06046057 RID: 286807 RVA: 0x011742FC File Offset: 0x011724FC
		protected override bool OnStart()
		{
			this.RangeComp = base.Entity.GetComponent<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>();
			if (this.RangeComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Optimization;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[OptimizationStrategyComponent] 组件缺失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RangeComponent", this.RangeComp != null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.BaseOptimizationStrategyList = new List<BaseOptimizationStrategy>();
			this.InitOptimizationStrategy();
			this.EnableOptimizationStrategy();
			if (!EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnMyPlayerEntityInOutRange)))
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnMyPlayerEntityInOutRange));
			}
			if (!EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnEntityInOutRangeLocal, new Action<bool, EntityHandle>(this.OnEntityInOutRangeLocal)))
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnEntityInOutRangeLocal, new Action<bool, EntityHandle>(this.OnEntityInOutRangeLocal));
			}
			this.OnSceneInteractionLoadCompleted();
			Log.Instance.Info(ELogModule.Optimization, ELogAuthor.LJM, "[OptimizationStrategyComponent] OnStart", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06046058 RID: 286808 RVA: 0x01174424 File Offset: 0x01172624
		private void InitOptimizationStrategy()
		{
			if (this.OptimizationTypeList == null || this.OptimizationTypeList.Count == 0)
			{
				return;
			}
			foreach (IPerformanceOptimization performanceOptimization in this.OptimizationTypeList)
			{
				this.AddOptimizationStrategy<EPerformanceOptimizationType>(performanceOptimization.Type);
			}
		}

		// Token: 0x06046059 RID: 286809 RVA: 0x01174494 File Offset: 0x01172694
		public void AddOptimizationStrategy<[Nullable(0)] T>(T type) where T : Enum
		{
			EPerformanceOptimizationType key = (EPerformanceOptimizationType)((object)type);
			if (!EPerformanceOptimizationMap.Map.ContainsKey(key))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Optimization;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[OptimizationStrategyComponent] 未找到对应的Profile";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			BaseOptimizationStrategy item = (BaseOptimizationStrategy)Activator.CreateInstance(EPerformanceOptimizationMap.Map[key]);
			this.BaseOptimizationStrategyList.Add(item);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Optimization;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[OptimizationStrategyComponent] AddOptimizationStrategy";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("type", type);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x0604605A RID: 286810 RVA: 0x0117453C File Offset: 0x0117273C
		private void EnableOptimizationStrategy()
		{
			foreach (BaseOptimizationStrategy baseOptimizationStrategy in this.BaseOptimizationStrategyList)
			{
				baseOptimizationStrategy.Enable();
			}
		}

		// Token: 0x0604605B RID: 286811 RVA: 0x0117458C File Offset: 0x0117278C
		private void MyPlayerEntityInOutRange(bool isEnterRange)
		{
			foreach (BaseOptimizationStrategy baseOptimizationStrategy in this.BaseOptimizationStrategyList)
			{
				baseOptimizationStrategy.MyPlayerEntityInOutRange(isEnterRange);
			}
		}

		// Token: 0x0604605C RID: 286812 RVA: 0x011745E0 File Offset: 0x011727E0
		private void EntityInOutRange(bool isEnterRange, EntityHandle handle)
		{
			foreach (BaseOptimizationStrategy baseOptimizationStrategy in this.BaseOptimizationStrategyList)
			{
				baseOptimizationStrategy.EntityInOutRange(isEnterRange, handle);
			}
		}

		// Token: 0x0604605D RID: 286813 RVA: 0x01174634 File Offset: 0x01172834
		private void DisableOptimizationStrategy()
		{
			foreach (BaseOptimizationStrategy baseOptimizationStrategy in this.BaseOptimizationStrategyList)
			{
				baseOptimizationStrategy.Disable();
			}
		}

		// Token: 0x0604605E RID: 286814 RVA: 0x01174684 File Offset: 0x01172884
		private void OnSceneInteractionLoadCompleted()
		{
			this.IsReady = true;
		}

		// Token: 0x0604605F RID: 286815 RVA: 0x0117468D File Offset: 0x0117288D
		private void OnMyPlayerEntityInOutRange(bool isEnter)
		{
			if (!this.IsReady)
			{
				return;
			}
			this.MyPlayerEntityInOutRange(isEnter);
		}

		// Token: 0x06046060 RID: 286816 RVA: 0x0117469F File Offset: 0x0117289F
		private void OnEntityInOutRangeLocal(bool isEnter, EntityHandle handle)
		{
			if (!this.IsReady)
			{
				return;
			}
			this.EntityInOutRange(isEnter, handle);
		}

		// Token: 0x06046061 RID: 286817 RVA: 0x011746B4 File Offset: 0x011728B4
		protected override bool OnEnd()
		{
			this.DisableOptimizationStrategy();
			this.BaseOptimizationStrategyList = null;
			this.IsReady = false;
			if (!EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnMyPlayerEntityInOutRange)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnMyPlayerEntityInOutRange));
			}
			if (!EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnEntityInOutRangeLocal, new Action<bool, EntityHandle>(this.OnEntityInOutRangeLocal)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnEntityInOutRangeLocal, new Action<bool, EntityHandle>(this.OnEntityInOutRangeLocal));
			}
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			Log.Instance.Info(ELogModule.Optimization, ELogAuthor.LJM, "[OptimizationStrategyComponent] OnEnd", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06046062 RID: 286818 RVA: 0x011747C4 File Offset: 0x011729C4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			OptimizationStrategyComponent optimizationStrategyComponent = (OptimizationStrategyComponent)componentTemplate;
			if (base.CanResetComponentProperty("RangeComp"))
			{
				if (optimizationStrategyComponent.RangeComp == null)
				{
					this.RangeComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>(this.RangeComp), "RangeComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BaseOptimizationStrategyList"))
			{
				if (optimizationStrategyComponent.BaseOptimizationStrategyList == null)
				{
					this.BaseOptimizationStrategyList = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<BaseOptimizationStrategy>>(this.BaseOptimizationStrategyList), "BaseOptimizationStrategyList"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsReady"))
			{
				this.IsReady = optimizationStrategyComponent.IsReady;
			}
			if (base.CanResetComponentProperty("OptimizationTypeList"))
			{
				if (optimizationStrategyComponent.OptimizationTypeList == null)
				{
					this.OptimizationTypeList = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<IPerformanceOptimization>>(this.OptimizationTypeList), "OptimizationTypeList"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024A86 RID: 150150
		[Nullable(2)]
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x04024A87 RID: 150151
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<BaseOptimizationStrategy> BaseOptimizationStrategyList;

		// Token: 0x04024A88 RID: 150152
		private bool IsReady;

		// Token: 0x04024A89 RID: 150153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPerformanceOptimization> OptimizationTypeList;
	}
}
