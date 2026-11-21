using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.NewWorld.Pawn.OptimizationStrategy
{
	// Token: 0x020061E3 RID: 25059
	[NullableContext(1)]
	[Nullable(0)]
	public class OptimizationStrategyComponent : EntityComponent
	{
		// Token: 0x0603C24F RID: 246351 RVA: 0x0111DE8C File Offset: 0x0111C08C
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

		// Token: 0x0603C250 RID: 246352 RVA: 0x0111DEFC File Offset: 0x0111C0FC
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

		// Token: 0x0603C251 RID: 246353 RVA: 0x0111E024 File Offset: 0x0111C224
		private void InitOptimizationStrategy()
		{
			if (this.OptimizationTypeList == null || this.OptimizationTypeList.Count == 0)
			{
				return;
			}
			foreach (IPerformanceOptimization performanceOptimization in this.OptimizationTypeList)
			{
				this.AddOptimizationStrategy(performanceOptimization.Type);
			}
		}

		// Token: 0x0603C252 RID: 246354 RVA: 0x0111E094 File Offset: 0x0111C294
		public void AddOptimizationStrategy(EPerformanceOptimizationType type)
		{
			Type type2;
			if (!EPerformanceOptimizationMap.Map.TryGetValue(type, out type2))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Optimization;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[OptimizationStrategyComponent] 未找到对应的Profile";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			BaseOptimizationStrategy item = (BaseOptimizationStrategy)Activator.CreateInstance(type2);
			this.BaseOptimizationStrategyList.Add(item);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Optimization;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[OptimizationStrategyComponent] AddOptimizationStrategy";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("type", type);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x0603C253 RID: 246355 RVA: 0x0111E12C File Offset: 0x0111C32C
		private void EnableOptimizationStrategy()
		{
			foreach (BaseOptimizationStrategy baseOptimizationStrategy in this.BaseOptimizationStrategyList)
			{
				baseOptimizationStrategy.Enable();
			}
		}

		// Token: 0x0603C254 RID: 246356 RVA: 0x0111E17C File Offset: 0x0111C37C
		private void MyPlayerEntityInOutRange(bool isEnterRange)
		{
			foreach (BaseOptimizationStrategy baseOptimizationStrategy in this.BaseOptimizationStrategyList)
			{
				baseOptimizationStrategy.MyPlayerEntityInOutRange(isEnterRange);
			}
		}

		// Token: 0x0603C255 RID: 246357 RVA: 0x0111E1D0 File Offset: 0x0111C3D0
		private void EntityInOutRange(bool isEnterRange, EntityHandle handle)
		{
			foreach (BaseOptimizationStrategy baseOptimizationStrategy in this.BaseOptimizationStrategyList)
			{
				baseOptimizationStrategy.EntityInOutRange(isEnterRange, handle);
			}
		}

		// Token: 0x0603C256 RID: 246358 RVA: 0x0111E224 File Offset: 0x0111C424
		private void DisableOptimizationStrategy()
		{
			foreach (BaseOptimizationStrategy baseOptimizationStrategy in this.BaseOptimizationStrategyList)
			{
				baseOptimizationStrategy.Disable();
			}
		}

		// Token: 0x0603C257 RID: 246359 RVA: 0x0111E274 File Offset: 0x0111C474
		private void OnSceneInteractionLoadCompleted()
		{
			this.IsReady = true;
		}

		// Token: 0x0603C258 RID: 246360 RVA: 0x0111E27D File Offset: 0x0111C47D
		private void OnMyPlayerEntityInOutRange(bool isEnter)
		{
			if (!this.IsReady)
			{
				return;
			}
			this.MyPlayerEntityInOutRange(isEnter);
		}

		// Token: 0x0603C259 RID: 246361 RVA: 0x0111E28F File Offset: 0x0111C48F
		private void OnEntityInOutRangeLocal(bool isEnter, EntityHandle handle)
		{
			if (!this.IsReady)
			{
				return;
			}
			this.EntityInOutRange(isEnter, handle);
		}

		// Token: 0x0603C25A RID: 246362 RVA: 0x0111E2A4 File Offset: 0x0111C4A4
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

		// Token: 0x0603C25B RID: 246363 RVA: 0x0111E3B4 File Offset: 0x0111C5B4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			OptimizationStrategyComponent optimizationStrategyComponent = (OptimizationStrategyComponent)componentTemplate;
			if (optimizationStrategyComponent.RangeComp == null)
			{
				this.RangeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RangeComp), "RangeComp"))
			{
				return false;
			}
			if (optimizationStrategyComponent.BaseOptimizationStrategyList == null)
			{
				this.BaseOptimizationStrategyList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BaseOptimizationStrategyList), "BaseOptimizationStrategyList"))
			{
				return false;
			}
			this.IsReady = optimizationStrategyComponent.IsReady;
			if (optimizationStrategyComponent.OptimizationTypeList == null)
			{
				this.OptimizationTypeList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OptimizationTypeList), "OptimizationTypeList"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700717F RID: 29055
		// (get) Token: 0x0603C25C RID: 246364 RVA: 0x0111E461 File Offset: 0x0111C661
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007180 RID: 29056
		// (get) Token: 0x0603C25D RID: 246365 RVA: 0x0111E464 File Offset: 0x0111C664
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FD3C RID: 130364
		[Nullable(2)]
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x0401FD3D RID: 130365
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<BaseOptimizationStrategy> BaseOptimizationStrategyList;

		// Token: 0x0401FD3E RID: 130366
		private bool IsReady;

		// Token: 0x0401FD3F RID: 130367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPerformanceOptimization> OptimizationTypeList;
	}
}
