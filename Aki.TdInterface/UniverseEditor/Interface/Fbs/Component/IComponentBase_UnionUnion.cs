using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553C RID: 21820
	public class IComponentBase_UnionUnion
	{
		// Token: 0x17009C02 RID: 39938
		// (get) Token: 0x06022835 RID: 141365 RVA: 0x004C106E File Offset: 0x004BF26E
		// (set) Token: 0x06022836 RID: 141366 RVA: 0x004C1076 File Offset: 0x004BF276
		public IComponentBase_Union Type { get; set; }

		// Token: 0x17009C03 RID: 39939
		// (get) Token: 0x06022837 RID: 141367 RVA: 0x004C107F File Offset: 0x004BF27F
		// (set) Token: 0x06022838 RID: 141368 RVA: 0x004C1087 File Offset: 0x004BF287
		public object Value { get; set; }

		// Token: 0x06022839 RID: 141369 RVA: 0x004C1090 File Offset: 0x004BF290
		public IComponentBase_UnionUnion()
		{
			this.Type = IComponentBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602283A RID: 141370 RVA: 0x004C10A6 File Offset: 0x004BF2A6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602283B RID: 141371 RVA: 0x004C10B8 File Offset: 0x004BF2B8
		public IComponentBaseT AsIComponentBase()
		{
			return this.As<IComponentBaseT>();
		}

		// Token: 0x0602283C RID: 141372 RVA: 0x004C10C0 File Offset: 0x004BF2C0
		public static IComponentBase_UnionUnion FromIComponentBase(IComponentBaseT _icomponentbase)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IComponentBase,
				Value = _icomponentbase
			};
		}

		// Token: 0x0602283D RID: 141373 RVA: 0x004C10D5 File Offset: 0x004BF2D5
		public IUnUseComponentT AsIUnUseComponent()
		{
			return this.As<IUnUseComponentT>();
		}

		// Token: 0x0602283E RID: 141374 RVA: 0x004C10DD File Offset: 0x004BF2DD
		public static IComponentBase_UnionUnion FromIUnUseComponent(IUnUseComponentT _iunusecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IUnUseComponent,
				Value = _iunusecomponent
			};
		}

		// Token: 0x0602283F RID: 141375 RVA: 0x004C10F2 File Offset: 0x004BF2F2
		public IInteractiveComponentT AsIInteractiveComponent()
		{
			return this.As<IInteractiveComponentT>();
		}

		// Token: 0x06022840 RID: 141376 RVA: 0x004C10FA File Offset: 0x004BF2FA
		public static IComponentBase_UnionUnion FromIInteractiveComponent(IInteractiveComponentT _iinteractivecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInteractiveComponent,
				Value = _iinteractivecomponent
			};
		}

		// Token: 0x06022841 RID: 141377 RVA: 0x004C110F File Offset: 0x004BF30F
		public ISwitcherComponentT AsISwitcherComponent()
		{
			return this.As<ISwitcherComponentT>();
		}

		// Token: 0x06022842 RID: 141378 RVA: 0x004C1117 File Offset: 0x004BF317
		public static IComponentBase_UnionUnion FromISwitcherComponent(ISwitcherComponentT _iswitchercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISwitcherComponent,
				Value = _iswitchercomponent
			};
		}

		// Token: 0x06022843 RID: 141379 RVA: 0x004C112C File Offset: 0x004BF32C
		public IRotatorComponentT AsIRotatorComponent()
		{
			return this.As<IRotatorComponentT>();
		}

		// Token: 0x06022844 RID: 141380 RVA: 0x004C1134 File Offset: 0x004BF334
		public static IComponentBase_UnionUnion FromIRotatorComponent(IRotatorComponentT _irotatorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRotatorComponent,
				Value = _irotatorcomponent
			};
		}

		// Token: 0x06022845 RID: 141381 RVA: 0x004C1149 File Offset: 0x004BF349
		public IBehaviorFlowComponentT AsIBehaviorFlowComponent()
		{
			return this.As<IBehaviorFlowComponentT>();
		}

		// Token: 0x06022846 RID: 141382 RVA: 0x004C1151 File Offset: 0x004BF351
		public static IComponentBase_UnionUnion FromIBehaviorFlowComponent(IBehaviorFlowComponentT _ibehaviorflowcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBehaviorFlowComponent,
				Value = _ibehaviorflowcomponent
			};
		}

		// Token: 0x06022847 RID: 141383 RVA: 0x004C1166 File Offset: 0x004BF366
		public IFlowComponentT AsIFlowComponent()
		{
			return this.As<IFlowComponentT>();
		}

		// Token: 0x06022848 RID: 141384 RVA: 0x004C116E File Offset: 0x004BF36E
		public static IComponentBase_UnionUnion FromIFlowComponent(IFlowComponentT _iflowcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFlowComponent,
				Value = _iflowcomponent
			};
		}

		// Token: 0x06022849 RID: 141385 RVA: 0x004C1183 File Offset: 0x004BF383
		public ITriggerUe5ComponentT AsITriggerUe5Component()
		{
			return this.As<ITriggerUe5ComponentT>();
		}

		// Token: 0x0602284A RID: 141386 RVA: 0x004C118B File Offset: 0x004BF38B
		public static IComponentBase_UnionUnion FromITriggerUe5Component(ITriggerUe5ComponentT _itriggerue5component)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITriggerUe5Component,
				Value = _itriggerue5component
			};
		}

		// Token: 0x0602284B RID: 141387 RVA: 0x004C11A0 File Offset: 0x004BF3A0
		public IMoveComponentT AsIMoveComponent()
		{
			return this.As<IMoveComponentT>();
		}

		// Token: 0x0602284C RID: 141388 RVA: 0x004C11A8 File Offset: 0x004BF3A8
		public static IComponentBase_UnionUnion FromIMoveComponent(IMoveComponentT _imovecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMoveComponent,
				Value = _imovecomponent
			};
		}

		// Token: 0x0602284D RID: 141389 RVA: 0x004C11BE File Offset: 0x004BF3BE
		public IActorStateComponentT AsIActorStateComponent()
		{
			return this.As<IActorStateComponentT>();
		}

		// Token: 0x0602284E RID: 141390 RVA: 0x004C11C6 File Offset: 0x004BF3C6
		public static IComponentBase_UnionUnion FromIActorStateComponent(IActorStateComponentT _iactorstatecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IActorStateComponent,
				Value = _iactorstatecomponent
			};
		}

		// Token: 0x0602284F RID: 141391 RVA: 0x004C11DC File Offset: 0x004BF3DC
		public ICalculateComponentT AsICalculateComponent()
		{
			return this.As<ICalculateComponentT>();
		}

		// Token: 0x06022850 RID: 141392 RVA: 0x004C11E4 File Offset: 0x004BF3E4
		public static IComponentBase_UnionUnion FromICalculateComponent(ICalculateComponentT _icalculatecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICalculateComponent,
				Value = _icalculatecomponent
			};
		}

		// Token: 0x06022851 RID: 141393 RVA: 0x004C11FA File Offset: 0x004BF3FA
		public IRefreshGroupT AsIRefreshGroup()
		{
			return this.As<IRefreshGroupT>();
		}

		// Token: 0x06022852 RID: 141394 RVA: 0x004C1202 File Offset: 0x004BF402
		public static IComponentBase_UnionUnion FromIRefreshGroup(IRefreshGroupT _irefreshgroup)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRefreshGroup,
				Value = _irefreshgroup
			};
		}

		// Token: 0x06022853 RID: 141395 RVA: 0x004C1218 File Offset: 0x004BF418
		public IRefreshSingleComponentT AsIRefreshSingleComponent()
		{
			return this.As<IRefreshSingleComponentT>();
		}

		// Token: 0x06022854 RID: 141396 RVA: 0x004C1220 File Offset: 0x004BF420
		public static IComponentBase_UnionUnion FromIRefreshSingleComponent(IRefreshSingleComponentT _irefreshsinglecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRefreshSingleComponent,
				Value = _irefreshsinglecomponent
			};
		}

		// Token: 0x06022855 RID: 141397 RVA: 0x004C1236 File Offset: 0x004BF436
		public IRotatorComponent2T AsIRotatorComponent2()
		{
			return this.As<IRotatorComponent2T>();
		}

		// Token: 0x06022856 RID: 141398 RVA: 0x004C123E File Offset: 0x004BF43E
		public static IComponentBase_UnionUnion FromIRotatorComponent2(IRotatorComponent2T _irotatorcomponent2)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRotatorComponent2,
				Value = _irotatorcomponent2
			};
		}

		// Token: 0x06022857 RID: 141399 RVA: 0x004C1254 File Offset: 0x004BF454
		public ISphereFactoryComponentT AsISphereFactoryComponent()
		{
			return this.As<ISphereFactoryComponentT>();
		}

		// Token: 0x06022858 RID: 141400 RVA: 0x004C125C File Offset: 0x004BF45C
		public static IComponentBase_UnionUnion FromISphereFactoryComponent(ISphereFactoryComponentT _ispherefactorycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISphereFactoryComponent,
				Value = _ispherefactorycomponent
			};
		}

		// Token: 0x06022859 RID: 141401 RVA: 0x004C1272 File Offset: 0x004BF472
		public ISpringComponentT AsISpringComponent()
		{
			return this.As<ISpringComponentT>();
		}

		// Token: 0x0602285A RID: 141402 RVA: 0x004C127A File Offset: 0x004BF47A
		public static IComponentBase_UnionUnion FromISpringComponent(ISpringComponentT _ispringcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISpringComponent,
				Value = _ispringcomponent
			};
		}

		// Token: 0x0602285B RID: 141403 RVA: 0x004C1290 File Offset: 0x004BF490
		public ITrampleUe5ComponentT AsITrampleUe5Component()
		{
			return this.As<ITrampleUe5ComponentT>();
		}

		// Token: 0x0602285C RID: 141404 RVA: 0x004C1298 File Offset: 0x004BF498
		public static IComponentBase_UnionUnion FromITrampleUe5Component(ITrampleUe5ComponentT _itrampleue5component)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITrampleUe5Component,
				Value = _itrampleue5component
			};
		}

		// Token: 0x0602285D RID: 141405 RVA: 0x004C12AE File Offset: 0x004BF4AE
		public IUndergroundComponentT AsIUndergroundComponent()
		{
			return this.As<IUndergroundComponentT>();
		}

		// Token: 0x0602285E RID: 141406 RVA: 0x004C12B6 File Offset: 0x004BF4B6
		public static IComponentBase_UnionUnion FromIUndergroundComponent(IUndergroundComponentT _iundergroundcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IUndergroundComponent,
				Value = _iundergroundcomponent
			};
		}

		// Token: 0x0602285F RID: 141407 RVA: 0x004C12CC File Offset: 0x004BF4CC
		public IGrabComponentT AsIGrabComponent()
		{
			return this.As<IGrabComponentT>();
		}

		// Token: 0x06022860 RID: 141408 RVA: 0x004C12D4 File Offset: 0x004BF4D4
		public static IComponentBase_UnionUnion FromIGrabComponent(IGrabComponentT _igrabcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGrabComponent,
				Value = _igrabcomponent
			};
		}

		// Token: 0x06022861 RID: 141409 RVA: 0x004C12EA File Offset: 0x004BF4EA
		public IInteractComponentT AsIInteractComponent()
		{
			return this.As<IInteractComponentT>();
		}

		// Token: 0x06022862 RID: 141410 RVA: 0x004C12F2 File Offset: 0x004BF4F2
		public static IComponentBase_UnionUnion FromIInteractComponent(IInteractComponentT _iinteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInteractComponent,
				Value = _iinteractcomponent
			};
		}

		// Token: 0x06022863 RID: 141411 RVA: 0x004C1308 File Offset: 0x004BF508
		public IVarComponentT AsIVarComponent()
		{
			return this.As<IVarComponentT>();
		}

		// Token: 0x06022864 RID: 141412 RVA: 0x004C1310 File Offset: 0x004BF510
		public static IComponentBase_UnionUnion FromIVarComponent(IVarComponentT _ivarcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVarComponent,
				Value = _ivarcomponent
			};
		}

		// Token: 0x06022865 RID: 141413 RVA: 0x004C1326 File Offset: 0x004BF526
		public IPatrolT AsIPatrol()
		{
			return this.As<IPatrolT>();
		}

		// Token: 0x06022866 RID: 141414 RVA: 0x004C132E File Offset: 0x004BF52E
		public static IComponentBase_UnionUnion FromIPatrol(IPatrolT _ipatrol)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPatrol,
				Value = _ipatrol
			};
		}

		// Token: 0x06022867 RID: 141415 RVA: 0x004C1344 File Offset: 0x004BF544
		public IAiComponentT AsIAiComponent()
		{
			return this.As<IAiComponentT>();
		}

		// Token: 0x06022868 RID: 141416 RVA: 0x004C134C File Offset: 0x004BF54C
		public static IComponentBase_UnionUnion FromIAiComponent(IAiComponentT _iaicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAiComponent,
				Value = _iaicomponent
			};
		}

		// Token: 0x06022869 RID: 141417 RVA: 0x004C1362 File Offset: 0x004BF562
		public IAttributeComponentT AsIAttributeComponent()
		{
			return this.As<IAttributeComponentT>();
		}

		// Token: 0x0602286A RID: 141418 RVA: 0x004C136A File Offset: 0x004BF56A
		public static IComponentBase_UnionUnion FromIAttributeComponent(IAttributeComponentT _iattributecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAttributeComponent,
				Value = _iattributecomponent
			};
		}

		// Token: 0x0602286B RID: 141419 RVA: 0x004C1380 File Offset: 0x004BF580
		public IEditCustomAoiComponentT AsIEditCustomAoiComponent()
		{
			return this.As<IEditCustomAoiComponentT>();
		}

		// Token: 0x0602286C RID: 141420 RVA: 0x004C1388 File Offset: 0x004BF588
		public static IComponentBase_UnionUnion FromIEditCustomAoiComponent(IEditCustomAoiComponentT _ieditcustomaoicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEditCustomAoiComponent,
				Value = _ieditcustomaoicomponent
			};
		}

		// Token: 0x0602286D RID: 141421 RVA: 0x004C139E File Offset: 0x004BF59E
		public IBaseInfoComponentT AsIBaseInfoComponent()
		{
			return this.As<IBaseInfoComponentT>();
		}

		// Token: 0x0602286E RID: 141422 RVA: 0x004C13A6 File Offset: 0x004BF5A6
		public static IComponentBase_UnionUnion FromIBaseInfoComponent(IBaseInfoComponentT _ibaseinfocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBaseInfoComponent,
				Value = _ibaseinfocomponent
			};
		}

		// Token: 0x0602286F RID: 141423 RVA: 0x004C13BC File Offset: 0x004BF5BC
		public IRewardComponentT AsIRewardComponent()
		{
			return this.As<IRewardComponentT>();
		}

		// Token: 0x06022870 RID: 141424 RVA: 0x004C13C4 File Offset: 0x004BF5C4
		public static IComponentBase_UnionUnion FromIRewardComponent(IRewardComponentT _irewardcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRewardComponent,
				Value = _irewardcomponent
			};
		}

		// Token: 0x06022871 RID: 141425 RVA: 0x004C13DA File Offset: 0x004BF5DA
		public IDynamicEntityRewardComponentT AsIDynamicEntityRewardComponent()
		{
			return this.As<IDynamicEntityRewardComponentT>();
		}

		// Token: 0x06022872 RID: 141426 RVA: 0x004C13E2 File Offset: 0x004BF5E2
		public static IComponentBase_UnionUnion FromIDynamicEntityRewardComponent(IDynamicEntityRewardComponentT _idynamicentityrewardcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicEntityRewardComponent,
				Value = _idynamicentityrewardcomponent
			};
		}

		// Token: 0x06022873 RID: 141427 RVA: 0x004C13F8 File Offset: 0x004BF5F8
		public IIndependentSystemRewardComponentT AsIIndependentSystemRewardComponent()
		{
			return this.As<IIndependentSystemRewardComponentT>();
		}

		// Token: 0x06022874 RID: 141428 RVA: 0x004C1400 File Offset: 0x004BF600
		public static IComponentBase_UnionUnion FromIIndependentSystemRewardComponent(IIndependentSystemRewardComponentT _iindependentsystemrewardcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IIndependentSystemRewardComponent,
				Value = _iindependentsystemrewardcomponent
			};
		}

		// Token: 0x06022875 RID: 141429 RVA: 0x004C1416 File Offset: 0x004BF616
		public IRefreshComponentT AsIRefreshComponent()
		{
			return this.As<IRefreshComponentT>();
		}

		// Token: 0x06022876 RID: 141430 RVA: 0x004C141E File Offset: 0x004BF61E
		public static IComponentBase_UnionUnion FromIRefreshComponent(IRefreshComponentT _irefreshcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRefreshComponent,
				Value = _irefreshcomponent
			};
		}

		// Token: 0x06022877 RID: 141431 RVA: 0x004C1434 File Offset: 0x004BF634
		public IRefreshGroupComponentT AsIRefreshGroupComponent()
		{
			return this.As<IRefreshGroupComponentT>();
		}

		// Token: 0x06022878 RID: 141432 RVA: 0x004C143C File Offset: 0x004BF63C
		public static IComponentBase_UnionUnion FromIRefreshGroupComponent(IRefreshGroupComponentT _irefreshgroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRefreshGroupComponent,
				Value = _irefreshgroupcomponent
			};
		}

		// Token: 0x06022879 RID: 141433 RVA: 0x004C1452 File Offset: 0x004BF652
		public IEntityBatchRefreshComponentT AsIEntityBatchRefreshComponent()
		{
			return this.As<IEntityBatchRefreshComponentT>();
		}

		// Token: 0x0602287A RID: 141434 RVA: 0x004C145A File Offset: 0x004BF65A
		public static IComponentBase_UnionUnion FromIEntityBatchRefreshComponent(IEntityBatchRefreshComponentT _ientitybatchrefreshcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityBatchRefreshComponent,
				Value = _ientitybatchrefreshcomponent
			};
		}

		// Token: 0x0602287B RID: 141435 RVA: 0x004C1470 File Offset: 0x004BF670
		public ITreasureBoxComponentT AsITreasureBoxComponent()
		{
			return this.As<ITreasureBoxComponentT>();
		}

		// Token: 0x0602287C RID: 141436 RVA: 0x004C1478 File Offset: 0x004BF678
		public static IComponentBase_UnionUnion FromITreasureBoxComponent(ITreasureBoxComponentT _itreasureboxcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITreasureBoxComponent,
				Value = _itreasureboxcomponent
			};
		}

		// Token: 0x0602287D RID: 141437 RVA: 0x004C148E File Offset: 0x004BF68E
		public ITriggerComponentT AsITriggerComponent()
		{
			return this.As<ITriggerComponentT>();
		}

		// Token: 0x0602287E RID: 141438 RVA: 0x004C1496 File Offset: 0x004BF696
		public static IComponentBase_UnionUnion FromITriggerComponent(ITriggerComponentT _itriggercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITriggerComponent,
				Value = _itriggercomponent
			};
		}

		// Token: 0x0602287F RID: 141439 RVA: 0x004C14AC File Offset: 0x004BF6AC
		public IEntityStateComponentT AsIEntityStateComponent()
		{
			return this.As<IEntityStateComponentT>();
		}

		// Token: 0x06022880 RID: 141440 RVA: 0x004C14B4 File Offset: 0x004BF6B4
		public static IComponentBase_UnionUnion FromIEntityStateComponent(IEntityStateComponentT _ientitystatecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityStateComponent,
				Value = _ientitystatecomponent
			};
		}

		// Token: 0x06022881 RID: 141441 RVA: 0x004C14CA File Offset: 0x004BF6CA
		public ISceneItemAttributeComponentT AsISceneItemAttributeComponent()
		{
			return this.As<ISceneItemAttributeComponentT>();
		}

		// Token: 0x06022882 RID: 141442 RVA: 0x004C14D2 File Offset: 0x004BF6D2
		public static IComponentBase_UnionUnion FromISceneItemAttributeComponent(ISceneItemAttributeComponentT _isceneitemattributecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemAttributeComponent,
				Value = _isceneitemattributecomponent
			};
		}

		// Token: 0x06022883 RID: 141443 RVA: 0x004C14E8 File Offset: 0x004BF6E8
		public IEntityAudioComponentT AsIEntityAudioComponent()
		{
			return this.As<IEntityAudioComponentT>();
		}

		// Token: 0x06022884 RID: 141444 RVA: 0x004C14F0 File Offset: 0x004BF6F0
		public static IComponentBase_UnionUnion FromIEntityAudioComponent(IEntityAudioComponentT _ientityaudiocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityAudioComponent,
				Value = _ientityaudiocomponent
			};
		}

		// Token: 0x06022885 RID: 141445 RVA: 0x004C1506 File Offset: 0x004BF706
		public IEntityStateAudioComponentT AsIEntityStateAudioComponent()
		{
			return this.As<IEntityStateAudioComponentT>();
		}

		// Token: 0x06022886 RID: 141446 RVA: 0x004C150E File Offset: 0x004BF70E
		public static IComponentBase_UnionUnion FromIEntityStateAudioComponent(IEntityStateAudioComponentT _ientitystateaudiocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityStateAudioComponent,
				Value = _ientitystateaudiocomponent
			};
		}

		// Token: 0x06022887 RID: 141447 RVA: 0x004C1524 File Offset: 0x004BF724
		public IEntityCustomAudioComponentT AsIEntityCustomAudioComponent()
		{
			return this.As<IEntityCustomAudioComponentT>();
		}

		// Token: 0x06022888 RID: 141448 RVA: 0x004C152C File Offset: 0x004BF72C
		public static IComponentBase_UnionUnion FromIEntityCustomAudioComponent(IEntityCustomAudioComponentT _ientitycustomaudiocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityCustomAudioComponent,
				Value = _ientitycustomaudiocomponent
			};
		}

		// Token: 0x06022889 RID: 141449 RVA: 0x004C1542 File Offset: 0x004BF742
		public ITrampleComponentT AsITrampleComponent()
		{
			return this.As<ITrampleComponentT>();
		}

		// Token: 0x0602288A RID: 141450 RVA: 0x004C154A File Offset: 0x004BF74A
		public static IComponentBase_UnionUnion FromITrampleComponent(ITrampleComponentT _itramplecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITrampleComponent,
				Value = _itramplecomponent
			};
		}

		// Token: 0x0602288B RID: 141451 RVA: 0x004C1560 File Offset: 0x004BF760
		public IEntityGroupComponentT AsIEntityGroupComponent()
		{
			return this.As<IEntityGroupComponentT>();
		}

		// Token: 0x0602288C RID: 141452 RVA: 0x004C1568 File Offset: 0x004BF768
		public static IComponentBase_UnionUnion FromIEntityGroupComponent(IEntityGroupComponentT _ientitygroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityGroupComponent,
				Value = _ientitygroupcomponent
			};
		}

		// Token: 0x0602288D RID: 141453 RVA: 0x004C157E File Offset: 0x004BF77E
		public IHookLockPointT AsIHookLockPoint()
		{
			return this.As<IHookLockPointT>();
		}

		// Token: 0x0602288E RID: 141454 RVA: 0x004C1586 File Offset: 0x004BF786
		public static IComponentBase_UnionUnion FromIHookLockPoint(IHookLockPointT _ihooklockpoint)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHookLockPoint,
				Value = _ihooklockpoint
			};
		}

		// Token: 0x0602288F RID: 141455 RVA: 0x004C159C File Offset: 0x004BF79C
		public IRoleMotionInteractComponentT AsIRoleMotionInteractComponent()
		{
			return this.As<IRoleMotionInteractComponentT>();
		}

		// Token: 0x06022890 RID: 141456 RVA: 0x004C15A4 File Offset: 0x004BF7A4
		public static IComponentBase_UnionUnion FromIRoleMotionInteractComponent(IRoleMotionInteractComponentT _irolemotioninteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRoleMotionInteractComponent,
				Value = _irolemotioninteractcomponent
			};
		}

		// Token: 0x06022891 RID: 141457 RVA: 0x004C15BA File Offset: 0x004BF7BA
		public IHookFetchComponentT AsIHookFetchComponent()
		{
			return this.As<IHookFetchComponentT>();
		}

		// Token: 0x06022892 RID: 141458 RVA: 0x004C15C2 File Offset: 0x004BF7C2
		public static IComponentBase_UnionUnion FromIHookFetchComponent(IHookFetchComponentT _ihookfetchcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHookFetchComponent,
				Value = _ihookfetchcomponent
			};
		}

		// Token: 0x06022893 RID: 141459 RVA: 0x004C15D8 File Offset: 0x004BF7D8
		public IItemFoundationT AsIItemFoundation()
		{
			return this.As<IItemFoundationT>();
		}

		// Token: 0x06022894 RID: 141460 RVA: 0x004C15E0 File Offset: 0x004BF7E0
		public static IComponentBase_UnionUnion FromIItemFoundation(IItemFoundationT _iitemfoundation)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IItemFoundation,
				Value = _iitemfoundation
			};
		}

		// Token: 0x06022895 RID: 141461 RVA: 0x004C15F6 File Offset: 0x004BF7F6
		public IResetEntitiesPosComponentT AsIResetEntitiesPosComponent()
		{
			return this.As<IResetEntitiesPosComponentT>();
		}

		// Token: 0x06022896 RID: 141462 RVA: 0x004C15FE File Offset: 0x004BF7FE
		public static IComponentBase_UnionUnion FromIResetEntitiesPosComponent(IResetEntitiesPosComponentT _iresetentitiesposcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IResetEntitiesPosComponent,
				Value = _iresetentitiesposcomponent
			};
		}

		// Token: 0x06022897 RID: 141463 RVA: 0x004C1614 File Offset: 0x004BF814
		public IResetSelfPosComponentT AsIResetSelfPosComponent()
		{
			return this.As<IResetSelfPosComponentT>();
		}

		// Token: 0x06022898 RID: 141464 RVA: 0x004C161C File Offset: 0x004BF81C
		public static IComponentBase_UnionUnion FromIResetSelfPosComponent(IResetSelfPosComponentT _iresetselfposcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IResetSelfPosComponent,
				Value = _iresetselfposcomponent
			};
		}

		// Token: 0x06022899 RID: 141465 RVA: 0x004C1632 File Offset: 0x004BF832
		public ICollectComponentT AsICollectComponent()
		{
			return this.As<ICollectComponentT>();
		}

		// Token: 0x0602289A RID: 141466 RVA: 0x004C163A File Offset: 0x004BF83A
		public static IComponentBase_UnionUnion FromICollectComponent(ICollectComponentT _icollectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICollectComponent,
				Value = _icollectcomponent
			};
		}

		// Token: 0x0602289B RID: 141467 RVA: 0x004C1650 File Offset: 0x004BF850
		public ITeleControl2T AsITeleControl2()
		{
			return this.As<ITeleControl2T>();
		}

		// Token: 0x0602289C RID: 141468 RVA: 0x004C1658 File Offset: 0x004BF858
		public static IComponentBase_UnionUnion FromITeleControl2(ITeleControl2T _itelecontrol2)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITeleControl2,
				Value = _itelecontrol2
			};
		}

		// Token: 0x0602289D RID: 141469 RVA: 0x004C166E File Offset: 0x004BF86E
		public IItemFoundation2T AsIItemFoundation2()
		{
			return this.As<IItemFoundation2T>();
		}

		// Token: 0x0602289E RID: 141470 RVA: 0x004C1676 File Offset: 0x004BF876
		public static IComponentBase_UnionUnion FromIItemFoundation2(IItemFoundation2T _iitemfoundation2)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IItemFoundation2,
				Value = _iitemfoundation2
			};
		}

		// Token: 0x0602289F RID: 141471 RVA: 0x004C168C File Offset: 0x004BF88C
		public IPullingFoundationT AsIPullingFoundation()
		{
			return this.As<IPullingFoundationT>();
		}

		// Token: 0x060228A0 RID: 141472 RVA: 0x004C1694 File Offset: 0x004BF894
		public static IComponentBase_UnionUnion FromIPullingFoundation(IPullingFoundationT _ipullingfoundation)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPullingFoundation,
				Value = _ipullingfoundation
			};
		}

		// Token: 0x060228A1 RID: 141473 RVA: 0x004C16AA File Offset: 0x004BF8AA
		public ILevelPlayComponentT AsILevelPlayComponent()
		{
			return this.As<ILevelPlayComponentT>();
		}

		// Token: 0x060228A2 RID: 141474 RVA: 0x004C16B2 File Offset: 0x004BF8B2
		public static IComponentBase_UnionUnion FromILevelPlayComponent(ILevelPlayComponentT _ilevelplaycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelPlayComponent,
				Value = _ilevelplaycomponent
			};
		}

		// Token: 0x060228A3 RID: 141475 RVA: 0x004C16C8 File Offset: 0x004BF8C8
		public IDynamicLevelPlayComponentT AsIDynamicLevelPlayComponent()
		{
			return this.As<IDynamicLevelPlayComponentT>();
		}

		// Token: 0x060228A4 RID: 141476 RVA: 0x004C16D0 File Offset: 0x004BF8D0
		public static IComponentBase_UnionUnion FromIDynamicLevelPlayComponent(IDynamicLevelPlayComponentT _idynamiclevelplaycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicLevelPlayComponent,
				Value = _idynamiclevelplaycomponent
			};
		}

		// Token: 0x060228A5 RID: 141477 RVA: 0x004C16E6 File Offset: 0x004BF8E6
		public IVisionComponentT AsIVisionComponent()
		{
			return this.As<IVisionComponentT>();
		}

		// Token: 0x060228A6 RID: 141478 RVA: 0x004C16EE File Offset: 0x004BF8EE
		public static IComponentBase_UnionUnion FromIVisionComponent(IVisionComponentT _ivisioncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVisionComponent,
				Value = _ivisioncomponent
			};
		}

		// Token: 0x060228A7 RID: 141479 RVA: 0x004C1704 File Offset: 0x004BF904
		public IVisionCaptureComponentT AsIVisionCaptureComponent()
		{
			return this.As<IVisionCaptureComponentT>();
		}

		// Token: 0x060228A8 RID: 141480 RVA: 0x004C170C File Offset: 0x004BF90C
		public static IComponentBase_UnionUnion FromIVisionCaptureComponent(IVisionCaptureComponentT _ivisioncapturecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVisionCaptureComponent,
				Value = _ivisioncapturecomponent
			};
		}

		// Token: 0x060228A9 RID: 141481 RVA: 0x004C1722 File Offset: 0x004BF922
		public IAdsorbComponentT AsIAdsorbComponent()
		{
			return this.As<IAdsorbComponentT>();
		}

		// Token: 0x060228AA RID: 141482 RVA: 0x004C172A File Offset: 0x004BF92A
		public static IComponentBase_UnionUnion FromIAdsorbComponent(IAdsorbComponentT _iadsorbcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAdsorbComponent,
				Value = _iadsorbcomponent
			};
		}

		// Token: 0x060228AB RID: 141483 RVA: 0x004C1740 File Offset: 0x004BF940
		public ITeleportComponentT AsITeleportComponent()
		{
			return this.As<ITeleportComponentT>();
		}

		// Token: 0x060228AC RID: 141484 RVA: 0x004C1748 File Offset: 0x004BF948
		public static IComponentBase_UnionUnion FromITeleportComponent(ITeleportComponentT _iteleportcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITeleportComponent,
				Value = _iteleportcomponent
			};
		}

		// Token: 0x060228AD RID: 141485 RVA: 0x004C175E File Offset: 0x004BF95E
		public ISpawnMonsterComponentT AsISpawnMonsterComponent()
		{
			return this.As<ISpawnMonsterComponentT>();
		}

		// Token: 0x060228AE RID: 141486 RVA: 0x004C1766 File Offset: 0x004BF966
		public static IComponentBase_UnionUnion FromISpawnMonsterComponent(ISpawnMonsterComponentT _ispawnmonstercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISpawnMonsterComponent,
				Value = _ispawnmonstercomponent
			};
		}

		// Token: 0x060228AF RID: 141487 RVA: 0x004C177C File Offset: 0x004BF97C
		public IHitComponentBaseT AsIHitComponentBase()
		{
			return this.As<IHitComponentBaseT>();
		}

		// Token: 0x060228B0 RID: 141488 RVA: 0x004C1784 File Offset: 0x004BF984
		public static IComponentBase_UnionUnion FromIHitComponentBase(IHitComponentBaseT _ihitcomponentbase)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHitComponentBase,
				Value = _ihitcomponentbase
			};
		}

		// Token: 0x060228B1 RID: 141489 RVA: 0x004C179A File Offset: 0x004BF99A
		public IDestructibleItemT AsIDestructibleItem()
		{
			return this.As<IDestructibleItemT>();
		}

		// Token: 0x060228B2 RID: 141490 RVA: 0x004C17A2 File Offset: 0x004BF9A2
		public static IComponentBase_UnionUnion FromIDestructibleItem(IDestructibleItemT _idestructibleitem)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDestructibleItem,
				Value = _idestructibleitem
			};
		}

		// Token: 0x060228B3 RID: 141491 RVA: 0x004C17B8 File Offset: 0x004BF9B8
		public ITargetGearComponentT AsITargetGearComponent()
		{
			return this.As<ITargetGearComponentT>();
		}

		// Token: 0x060228B4 RID: 141492 RVA: 0x004C17C0 File Offset: 0x004BF9C0
		public static IComponentBase_UnionUnion FromITargetGearComponent(ITargetGearComponentT _itargetgearcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITargetGearComponent,
				Value = _itargetgearcomponent
			};
		}

		// Token: 0x060228B5 RID: 141493 RVA: 0x004C17D6 File Offset: 0x004BF9D6
		public IProgressBarControlComponentT AsIProgressBarControlComponent()
		{
			return this.As<IProgressBarControlComponentT>();
		}

		// Token: 0x060228B6 RID: 141494 RVA: 0x004C17DE File Offset: 0x004BF9DE
		public static IComponentBase_UnionUnion FromIProgressBarControlComponent(IProgressBarControlComponentT _iprogressbarcontrolcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IProgressBarControlComponent,
				Value = _iprogressbarcontrolcomponent
			};
		}

		// Token: 0x060228B7 RID: 141495 RVA: 0x004C17F4 File Offset: 0x004BF9F4
		public IHitComponentT AsIHitComponent()
		{
			return this.As<IHitComponentT>();
		}

		// Token: 0x060228B8 RID: 141496 RVA: 0x004C17FC File Offset: 0x004BF9FC
		public static IComponentBase_UnionUnion FromIHitComponent(IHitComponentT _ihitcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHitComponent,
				Value = _ihitcomponent
			};
		}

		// Token: 0x060228B9 RID: 141497 RVA: 0x004C1812 File Offset: 0x004BFA12
		public ITargetGearGroupComponentT AsITargetGearGroupComponent()
		{
			return this.As<ITargetGearGroupComponentT>();
		}

		// Token: 0x060228BA RID: 141498 RVA: 0x004C181A File Offset: 0x004BFA1A
		public static IComponentBase_UnionUnion FromITargetGearGroupComponent(ITargetGearGroupComponentT _itargetgeargroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITargetGearGroupComponent,
				Value = _itargetgeargroupcomponent
			};
		}

		// Token: 0x060228BB RID: 141499 RVA: 0x004C1830 File Offset: 0x004BFA30
		public INpcPerformComponentT AsINpcPerformComponent()
		{
			return this.As<INpcPerformComponentT>();
		}

		// Token: 0x060228BC RID: 141500 RVA: 0x004C1838 File Offset: 0x004BFA38
		public static IComponentBase_UnionUnion FromINpcPerformComponent(INpcPerformComponentT _inpcperformcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INpcPerformComponent,
				Value = _inpcperformcomponent
			};
		}

		// Token: 0x060228BD RID: 141501 RVA: 0x004C184E File Offset: 0x004BFA4E
		public IInteractGearComponentT AsIInteractGearComponent()
		{
			return this.As<IInteractGearComponentT>();
		}

		// Token: 0x060228BE RID: 141502 RVA: 0x004C1856 File Offset: 0x004BFA56
		public static IComponentBase_UnionUnion FromIInteractGearComponent(IInteractGearComponentT _iinteractgearcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInteractGearComponent,
				Value = _iinteractgearcomponent
			};
		}

		// Token: 0x060228BF RID: 141503 RVA: 0x004C186C File Offset: 0x004BFA6C
		public ILiftComponentT AsILiftComponent()
		{
			return this.As<ILiftComponentT>();
		}

		// Token: 0x060228C0 RID: 141504 RVA: 0x004C1874 File Offset: 0x004BFA74
		public static IComponentBase_UnionUnion FromILiftComponent(ILiftComponentT _iliftcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILiftComponent,
				Value = _iliftcomponent
			};
		}

		// Token: 0x060228C1 RID: 141505 RVA: 0x004C188A File Offset: 0x004BFA8A
		public IConveyorBeltComponentT AsIConveyorBeltComponent()
		{
			return this.As<IConveyorBeltComponentT>();
		}

		// Token: 0x060228C2 RID: 141506 RVA: 0x004C1892 File Offset: 0x004BFA92
		public static IComponentBase_UnionUnion FromIConveyorBeltComponent(IConveyorBeltComponentT _iconveyorbeltcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IConveyorBeltComponent,
				Value = _iconveyorbeltcomponent
			};
		}

		// Token: 0x060228C3 RID: 141507 RVA: 0x004C18A8 File Offset: 0x004BFAA8
		public IFollowTrackComponentT AsIFollowTrackComponent()
		{
			return this.As<IFollowTrackComponentT>();
		}

		// Token: 0x060228C4 RID: 141508 RVA: 0x004C18B0 File Offset: 0x004BFAB0
		public static IComponentBase_UnionUnion FromIFollowTrackComponent(IFollowTrackComponentT _ifollowtrackcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFollowTrackComponent,
				Value = _ifollowtrackcomponent
			};
		}

		// Token: 0x060228C5 RID: 141509 RVA: 0x004C18C6 File Offset: 0x004BFAC6
		public ISceneItemLifeCycleComponentT AsISceneItemLifeCycleComponent()
		{
			return this.As<ISceneItemLifeCycleComponentT>();
		}

		// Token: 0x060228C6 RID: 141510 RVA: 0x004C18CE File Offset: 0x004BFACE
		public static IComponentBase_UnionUnion FromISceneItemLifeCycleComponent(ISceneItemLifeCycleComponentT _isceneitemlifecyclecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemLifeCycleComponent,
				Value = _isceneitemlifecyclecomponent
			};
		}

		// Token: 0x060228C7 RID: 141511 RVA: 0x004C18E4 File Offset: 0x004BFAE4
		public IFightInteractComponentT AsIFightInteractComponent()
		{
			return this.As<IFightInteractComponentT>();
		}

		// Token: 0x060228C8 RID: 141512 RVA: 0x004C18EC File Offset: 0x004BFAEC
		public static IComponentBase_UnionUnion FromIFightInteractComponent(IFightInteractComponentT _ifightinteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFightInteractComponent,
				Value = _ifightinteractcomponent
			};
		}

		// Token: 0x060228C9 RID: 141513 RVA: 0x004C1902 File Offset: 0x004BFB02
		public IBubbleComponentT AsIBubbleComponent()
		{
			return this.As<IBubbleComponentT>();
		}

		// Token: 0x060228CA RID: 141514 RVA: 0x004C190A File Offset: 0x004BFB0A
		public static IComponentBase_UnionUnion FromIBubbleComponent(IBubbleComponentT _ibubblecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBubbleComponent,
				Value = _ibubblecomponent
			};
		}

		// Token: 0x060228CB RID: 141515 RVA: 0x004C1920 File Offset: 0x004BFB20
		public INearbyTrackingComponentT AsINearbyTrackingComponent()
		{
			return this.As<INearbyTrackingComponentT>();
		}

		// Token: 0x060228CC RID: 141516 RVA: 0x004C1928 File Offset: 0x004BFB28
		public static IComponentBase_UnionUnion FromINearbyTrackingComponent(INearbyTrackingComponentT _inearbytrackingcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INearbyTrackingComponent,
				Value = _inearbytrackingcomponent
			};
		}

		// Token: 0x060228CD RID: 141517 RVA: 0x004C193E File Offset: 0x004BFB3E
		public IEntityPackageComponentT AsIEntityPackageComponent()
		{
			return this.As<IEntityPackageComponentT>();
		}

		// Token: 0x060228CE RID: 141518 RVA: 0x004C1946 File Offset: 0x004BFB46
		public static IComponentBase_UnionUnion FromIEntityPackageComponent(IEntityPackageComponentT _ientitypackagecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityPackageComponent,
				Value = _ientitypackagecomponent
			};
		}

		// Token: 0x060228CF RID: 141519 RVA: 0x004C195C File Offset: 0x004BFB5C
		public ISkyboxComponentT AsISkyboxComponent()
		{
			return this.As<ISkyboxComponentT>();
		}

		// Token: 0x060228D0 RID: 141520 RVA: 0x004C1964 File Offset: 0x004BFB64
		public static IComponentBase_UnionUnion FromISkyboxComponent(ISkyboxComponentT _iskyboxcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISkyboxComponent,
				Value = _iskyboxcomponent
			};
		}

		// Token: 0x060228D1 RID: 141521 RVA: 0x004C197A File Offset: 0x004BFB7A
		public IStateHintComponentT AsIStateHintComponent()
		{
			return this.As<IStateHintComponentT>();
		}

		// Token: 0x060228D2 RID: 141522 RVA: 0x004C1982 File Offset: 0x004BFB82
		public static IComponentBase_UnionUnion FromIStateHintComponent(IStateHintComponentT _istatehintcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IStateHintComponent,
				Value = _istatehintcomponent
			};
		}

		// Token: 0x060228D3 RID: 141523 RVA: 0x004C1998 File Offset: 0x004BFB98
		public IEntityVisibleComponentT AsIEntityVisibleComponent()
		{
			return this.As<IEntityVisibleComponentT>();
		}

		// Token: 0x060228D4 RID: 141524 RVA: 0x004C19A0 File Offset: 0x004BFBA0
		public static IComponentBase_UnionUnion FromIEntityVisibleComponent(IEntityVisibleComponentT _ientityvisiblecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityVisibleComponent,
				Value = _ientityvisiblecomponent
			};
		}

		// Token: 0x060228D5 RID: 141525 RVA: 0x004C19B6 File Offset: 0x004BFBB6
		public ICombinedVisibleGroupComponentT AsICombinedVisibleGroupComponent()
		{
			return this.As<ICombinedVisibleGroupComponentT>();
		}

		// Token: 0x060228D6 RID: 141526 RVA: 0x004C19BE File Offset: 0x004BFBBE
		public static IComponentBase_UnionUnion FromICombinedVisibleGroupComponent(ICombinedVisibleGroupComponentT _icombinedvisiblegroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICombinedVisibleGroupComponent,
				Value = _icombinedvisiblegroupcomponent
			};
		}

		// Token: 0x060228D7 RID: 141527 RVA: 0x004C19D4 File Offset: 0x004BFBD4
		public IWeaponComponentT AsIWeaponComponent()
		{
			return this.As<IWeaponComponentT>();
		}

		// Token: 0x060228D8 RID: 141528 RVA: 0x004C19DC File Offset: 0x004BFBDC
		public static IComponentBase_UnionUnion FromIWeaponComponent(IWeaponComponentT _iweaponcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IWeaponComponent,
				Value = _iweaponcomponent
			};
		}

		// Token: 0x060228D9 RID: 141529 RVA: 0x004C19F2 File Offset: 0x004BFBF2
		public IDungeonEntryComponentT AsIDungeonEntryComponent()
		{
			return this.As<IDungeonEntryComponentT>();
		}

		// Token: 0x060228DA RID: 141530 RVA: 0x004C19FA File Offset: 0x004BFBFA
		public static IComponentBase_UnionUnion FromIDungeonEntryComponent(IDungeonEntryComponentT _idungeonentrycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDungeonEntryComponent,
				Value = _idungeonentrycomponent
			};
		}

		// Token: 0x060228DB RID: 141531 RVA: 0x004C1A10 File Offset: 0x004BFC10
		public IResurrectionComponentT AsIResurrectionComponent()
		{
			return this.As<IResurrectionComponentT>();
		}

		// Token: 0x060228DC RID: 141532 RVA: 0x004C1A18 File Offset: 0x004BFC18
		public static IComponentBase_UnionUnion FromIResurrectionComponent(IResurrectionComponentT _iresurrectioncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IResurrectionComponent,
				Value = _iresurrectioncomponent
			};
		}

		// Token: 0x060228DD RID: 141533 RVA: 0x004C1A2E File Offset: 0x004BFC2E
		public IBuffProducerComponentT AsIBuffProducerComponent()
		{
			return this.As<IBuffProducerComponentT>();
		}

		// Token: 0x060228DE RID: 141534 RVA: 0x004C1A36 File Offset: 0x004BFC36
		public static IComponentBase_UnionUnion FromIBuffProducerComponent(IBuffProducerComponentT _ibuffproducercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBuffProducerComponent,
				Value = _ibuffproducercomponent
			};
		}

		// Token: 0x060228DF RID: 141535 RVA: 0x004C1A4C File Offset: 0x004BFC4C
		public IBuffConsumerComponentT AsIBuffConsumerComponent()
		{
			return this.As<IBuffConsumerComponentT>();
		}

		// Token: 0x060228E0 RID: 141536 RVA: 0x004C1A54 File Offset: 0x004BFC54
		public static IComponentBase_UnionUnion FromIBuffConsumerComponent(IBuffConsumerComponentT _ibuffconsumercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBuffConsumerComponent,
				Value = _ibuffconsumercomponent
			};
		}

		// Token: 0x060228E1 RID: 141537 RVA: 0x004C1A6A File Offset: 0x004BFC6A
		public IGuideLineCreatorComponentT AsIGuideLineCreatorComponent()
		{
			return this.As<IGuideLineCreatorComponentT>();
		}

		// Token: 0x060228E2 RID: 141538 RVA: 0x004C1A72 File Offset: 0x004BFC72
		public static IComponentBase_UnionUnion FromIGuideLineCreatorComponent(IGuideLineCreatorComponentT _iguidelinecreatorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGuideLineCreatorComponent,
				Value = _iguidelinecreatorcomponent
			};
		}

		// Token: 0x060228E3 RID: 141539 RVA: 0x004C1A88 File Offset: 0x004BFC88
		public IInteractAudioComponentT AsIInteractAudioComponent()
		{
			return this.As<IInteractAudioComponentT>();
		}

		// Token: 0x060228E4 RID: 141540 RVA: 0x004C1A90 File Offset: 0x004BFC90
		public static IComponentBase_UnionUnion FromIInteractAudioComponent(IInteractAudioComponentT _iinteractaudiocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInteractAudioComponent,
				Value = _iinteractaudiocomponent
			};
		}

		// Token: 0x060228E5 RID: 141541 RVA: 0x004C1AA6 File Offset: 0x004BFCA6
		public IDropComponentT AsIDropComponent()
		{
			return this.As<IDropComponentT>();
		}

		// Token: 0x060228E6 RID: 141542 RVA: 0x004C1AAE File Offset: 0x004BFCAE
		public static IComponentBase_UnionUnion FromIDropComponent(IDropComponentT _idropcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDropComponent,
				Value = _idropcomponent
			};
		}

		// Token: 0x060228E7 RID: 141543 RVA: 0x004C1AC4 File Offset: 0x004BFCC4
		public IVisionItemComponentT AsIVisionItemComponent()
		{
			return this.As<IVisionItemComponentT>();
		}

		// Token: 0x060228E8 RID: 141544 RVA: 0x004C1ACC File Offset: 0x004BFCCC
		public static IComponentBase_UnionUnion FromIVisionItemComponent(IVisionItemComponentT _ivisionitemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVisionItemComponent,
				Value = _ivisionitemcomponent
			};
		}

		// Token: 0x060228E9 RID: 141545 RVA: 0x004C1AE2 File Offset: 0x004BFCE2
		public IAdviseItemComponentT AsIAdviseItemComponent()
		{
			return this.As<IAdviseItemComponentT>();
		}

		// Token: 0x060228EA RID: 141546 RVA: 0x004C1AEA File Offset: 0x004BFCEA
		public static IComponentBase_UnionUnion FromIAdviseItemComponent(IAdviseItemComponentT _iadviseitemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAdviseItemComponent,
				Value = _iadviseitemcomponent
			};
		}

		// Token: 0x060228EB RID: 141547 RVA: 0x004C1B00 File Offset: 0x004BFD00
		public IMonsterComponentT AsIMonsterComponent()
		{
			return this.As<IMonsterComponentT>();
		}

		// Token: 0x060228EC RID: 141548 RVA: 0x004C1B08 File Offset: 0x004BFD08
		public static IComponentBase_UnionUnion FromIMonsterComponent(IMonsterComponentT _imonstercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMonsterComponent,
				Value = _imonstercomponent
			};
		}

		// Token: 0x060228ED RID: 141549 RVA: 0x004C1B1E File Offset: 0x004BFD1E
		public ICombatComponentT AsICombatComponent()
		{
			return this.As<ICombatComponentT>();
		}

		// Token: 0x060228EE RID: 141550 RVA: 0x004C1B26 File Offset: 0x004BFD26
		public static IComponentBase_UnionUnion FromICombatComponent(ICombatComponentT _icombatcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICombatComponent,
				Value = _icombatcomponent
			};
		}

		// Token: 0x060228EF RID: 141551 RVA: 0x004C1B3C File Offset: 0x004BFD3C
		public IEntityListComponentT AsIEntityListComponent()
		{
			return this.As<IEntityListComponentT>();
		}

		// Token: 0x060228F0 RID: 141552 RVA: 0x004C1B44 File Offset: 0x004BFD44
		public static IComponentBase_UnionUnion FromIEntityListComponent(IEntityListComponentT _ientitylistcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityListComponent,
				Value = _ientitylistcomponent
			};
		}

		// Token: 0x060228F1 RID: 141553 RVA: 0x004C1B5A File Offset: 0x004BFD5A
		public IAnimalComponentT AsIAnimalComponent()
		{
			return this.As<IAnimalComponentT>();
		}

		// Token: 0x060228F2 RID: 141554 RVA: 0x004C1B62 File Offset: 0x004BFD62
		public static IComponentBase_UnionUnion FromIAnimalComponent(IAnimalComponentT _ianimalcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAnimalComponent,
				Value = _ianimalcomponent
			};
		}

		// Token: 0x060228F3 RID: 141555 RVA: 0x004C1B78 File Offset: 0x004BFD78
		public ISceneItemMovementComponentT AsISceneItemMovementComponent()
		{
			return this.As<ISceneItemMovementComponentT>();
		}

		// Token: 0x060228F4 RID: 141556 RVA: 0x004C1B80 File Offset: 0x004BFD80
		public static IComponentBase_UnionUnion FromISceneItemMovementComponent(ISceneItemMovementComponentT _isceneitemmovementcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemMovementComponent,
				Value = _isceneitemmovementcomponent
			};
		}

		// Token: 0x060228F5 RID: 141557 RVA: 0x004C1B96 File Offset: 0x004BFD96
		public IRangeComponentT AsIRangeComponent()
		{
			return this.As<IRangeComponentT>();
		}

		// Token: 0x060228F6 RID: 141558 RVA: 0x004C1B9E File Offset: 0x004BFD9E
		public static IComponentBase_UnionUnion FromIRangeComponent(IRangeComponentT _irangecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRangeComponent,
				Value = _irangecomponent
			};
		}

		// Token: 0x060228F7 RID: 141559 RVA: 0x004C1BB4 File Offset: 0x004BFDB4
		public IExtraRangeComponentT AsIExtraRangeComponent()
		{
			return this.As<IExtraRangeComponentT>();
		}

		// Token: 0x060228F8 RID: 141560 RVA: 0x004C1BBC File Offset: 0x004BFDBC
		public static IComponentBase_UnionUnion FromIExtraRangeComponent(IExtraRangeComponentT _iextrarangecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IExtraRangeComponent,
				Value = _iextrarangecomponent
			};
		}

		// Token: 0x060228F9 RID: 141561 RVA: 0x004C1BD2 File Offset: 0x004BFDD2
		public ITimelineTrackControlComponentT AsITimelineTrackControlComponent()
		{
			return this.As<ITimelineTrackControlComponentT>();
		}

		// Token: 0x060228FA RID: 141562 RVA: 0x004C1BDA File Offset: 0x004BFDDA
		public static IComponentBase_UnionUnion FromITimelineTrackControlComponent(ITimelineTrackControlComponentT _itimelinetrackcontrolcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITimelineTrackControlComponent,
				Value = _itimelinetrackcontrolcomponent
			};
		}

		// Token: 0x060228FB RID: 141563 RVA: 0x004C1BF0 File Offset: 0x004BFDF0
		public ISplineComponentT AsISplineComponent()
		{
			return this.As<ISplineComponentT>();
		}

		// Token: 0x060228FC RID: 141564 RVA: 0x004C1BF8 File Offset: 0x004BFDF8
		public static IComponentBase_UnionUnion FromISplineComponent(ISplineComponentT _isplinecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISplineComponent,
				Value = _isplinecomponent
			};
		}

		// Token: 0x060228FD RID: 141565 RVA: 0x004C1C0E File Offset: 0x004BFE0E
		public IAirWallSpawnerComponentT AsIAirWallSpawnerComponent()
		{
			return this.As<IAirWallSpawnerComponentT>();
		}

		// Token: 0x060228FE RID: 141566 RVA: 0x004C1C16 File Offset: 0x004BFE16
		public static IComponentBase_UnionUnion FromIAirWallSpawnerComponent(IAirWallSpawnerComponentT _iairwallspawnercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAirWallSpawnerComponent,
				Value = _iairwallspawnercomponent
			};
		}

		// Token: 0x060228FF RID: 141567 RVA: 0x004C1C2C File Offset: 0x004BFE2C
		public ISceneActorRefComponentT AsISceneActorRefComponent()
		{
			return this.As<ISceneActorRefComponentT>();
		}

		// Token: 0x06022900 RID: 141568 RVA: 0x004C1C34 File Offset: 0x004BFE34
		public static IComponentBase_UnionUnion FromISceneActorRefComponent(ISceneActorRefComponentT _isceneactorrefcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneActorRefComponent,
				Value = _isceneactorrefcomponent
			};
		}

		// Token: 0x06022901 RID: 141569 RVA: 0x004C1C4A File Offset: 0x004BFE4A
		public ISceneBulletComponentT AsISceneBulletComponent()
		{
			return this.As<ISceneBulletComponentT>();
		}

		// Token: 0x06022902 RID: 141570 RVA: 0x004C1C52 File Offset: 0x004BFE52
		public static IComponentBase_UnionUnion FromISceneBulletComponent(ISceneBulletComponentT _iscenebulletcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneBulletComponent,
				Value = _iscenebulletcomponent
			};
		}

		// Token: 0x06022903 RID: 141571 RVA: 0x004C1C68 File Offset: 0x004BFE68
		public ITurntableControlComponentT AsITurntableControlComponent()
		{
			return this.As<ITurntableControlComponentT>();
		}

		// Token: 0x06022904 RID: 141572 RVA: 0x004C1C70 File Offset: 0x004BFE70
		public static IComponentBase_UnionUnion FromITurntableControlComponent(ITurntableControlComponentT _iturntablecontrolcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITurntableControlComponent,
				Value = _iturntablecontrolcomponent
			};
		}

		// Token: 0x06022905 RID: 141573 RVA: 0x004C1C86 File Offset: 0x004BFE86
		public IConditionListenerComponentT AsIConditionListenerComponent()
		{
			return this.As<IConditionListenerComponentT>();
		}

		// Token: 0x06022906 RID: 141574 RVA: 0x004C1C8E File Offset: 0x004BFE8E
		public static IComponentBase_UnionUnion FromIConditionListenerComponent(IConditionListenerComponentT _iconditionlistenercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IConditionListenerComponent,
				Value = _iconditionlistenercomponent
			};
		}

		// Token: 0x06022907 RID: 141575 RVA: 0x004C1CA4 File Offset: 0x004BFEA4
		public IAttachTargetComponentT AsIAttachTargetComponent()
		{
			return this.As<IAttachTargetComponentT>();
		}

		// Token: 0x06022908 RID: 141576 RVA: 0x004C1CAC File Offset: 0x004BFEAC
		public static IComponentBase_UnionUnion FromIAttachTargetComponent(IAttachTargetComponentT _iattachtargetcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAttachTargetComponent,
				Value = _iattachtargetcomponent
			};
		}

		// Token: 0x06022909 RID: 141577 RVA: 0x004C1CC2 File Offset: 0x004BFEC2
		public IReboundComponentT AsIReboundComponent()
		{
			return this.As<IReboundComponentT>();
		}

		// Token: 0x0602290A RID: 141578 RVA: 0x004C1CCA File Offset: 0x004BFECA
		public static IComponentBase_UnionUnion FromIReboundComponent(IReboundComponentT _ireboundcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IReboundComponent,
				Value = _ireboundcomponent
			};
		}

		// Token: 0x0602290B RID: 141579 RVA: 0x004C1CE0 File Offset: 0x004BFEE0
		public IJigsawItemT AsIJigsawItem()
		{
			return this.As<IJigsawItemT>();
		}

		// Token: 0x0602290C RID: 141580 RVA: 0x004C1CE8 File Offset: 0x004BFEE8
		public static IComponentBase_UnionUnion FromIJigsawItem(IJigsawItemT _ijigsawitem)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IJigsawItem,
				Value = _ijigsawitem
			};
		}

		// Token: 0x0602290D RID: 141581 RVA: 0x004C1CFE File Offset: 0x004BFEFE
		public IJigsawFoundationT AsIJigsawFoundation()
		{
			return this.As<IJigsawFoundationT>();
		}

		// Token: 0x0602290E RID: 141582 RVA: 0x004C1D06 File Offset: 0x004BFF06
		public static IComponentBase_UnionUnion FromIJigsawFoundation(IJigsawFoundationT _ijigsawfoundation)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IJigsawFoundation,
				Value = _ijigsawfoundation
			};
		}

		// Token: 0x0602290F RID: 141583 RVA: 0x004C1D1C File Offset: 0x004BFF1C
		public ILevelAIComponentT AsILevelAIComponent()
		{
			return this.As<ILevelAIComponentT>();
		}

		// Token: 0x06022910 RID: 141584 RVA: 0x004C1D24 File Offset: 0x004BFF24
		public static IComponentBase_UnionUnion FromILevelAIComponent(ILevelAIComponentT _ilevelaicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelAIComponent,
				Value = _ilevelaicomponent
			};
		}

		// Token: 0x06022911 RID: 141585 RVA: 0x004C1D3A File Offset: 0x004BFF3A
		public ILevitateMagnetComponentT AsILevitateMagnetComponent()
		{
			return this.As<ILevitateMagnetComponentT>();
		}

		// Token: 0x06022912 RID: 141586 RVA: 0x004C1D42 File Offset: 0x004BFF42
		public static IComponentBase_UnionUnion FromILevitateMagnetComponent(ILevitateMagnetComponentT _ilevitatemagnetcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevitateMagnetComponent,
				Value = _ilevitatemagnetcomponent
			};
		}

		// Token: 0x06022913 RID: 141587 RVA: 0x004C1D58 File Offset: 0x004BFF58
		public IPhotoTargetComponentT AsIPhotoTargetComponent()
		{
			return this.As<IPhotoTargetComponentT>();
		}

		// Token: 0x06022914 RID: 141588 RVA: 0x004C1D60 File Offset: 0x004BFF60
		public static IComponentBase_UnionUnion FromIPhotoTargetComponent(IPhotoTargetComponentT _iphototargetcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPhotoTargetComponent,
				Value = _iphototargetcomponent
			};
		}

		// Token: 0x06022915 RID: 141589 RVA: 0x004C1D76 File Offset: 0x004BFF76
		public IAiAlertNotifyComponentT AsIAiAlertNotifyComponent()
		{
			return this.As<IAiAlertNotifyComponentT>();
		}

		// Token: 0x06022916 RID: 141590 RVA: 0x004C1D7E File Offset: 0x004BFF7E
		public static IComponentBase_UnionUnion FromIAiAlertNotifyComponent(IAiAlertNotifyComponentT _iaialertnotifycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAiAlertNotifyComponent,
				Value = _iaialertnotifycomponent
			};
		}

		// Token: 0x06022917 RID: 141591 RVA: 0x004C1D94 File Offset: 0x004BFF94
		public IMonsterGachaItemComponentT AsIMonsterGachaItemComponent()
		{
			return this.As<IMonsterGachaItemComponentT>();
		}

		// Token: 0x06022918 RID: 141592 RVA: 0x004C1D9C File Offset: 0x004BFF9C
		public static IComponentBase_UnionUnion FromIMonsterGachaItemComponent(IMonsterGachaItemComponentT _imonstergachaitemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMonsterGachaItemComponent,
				Value = _imonstergachaitemcomponent
			};
		}

		// Token: 0x06022919 RID: 141593 RVA: 0x004C1DB2 File Offset: 0x004BFFB2
		public IMonsterGachaBaseComponentT AsIMonsterGachaBaseComponent()
		{
			return this.As<IMonsterGachaBaseComponentT>();
		}

		// Token: 0x0602291A RID: 141594 RVA: 0x004C1DBA File Offset: 0x004BFFBA
		public static IComponentBase_UnionUnion FromIMonsterGachaBaseComponent(IMonsterGachaBaseComponentT _imonstergachabasecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMonsterGachaBaseComponent,
				Value = _imonstergachabasecomponent
			};
		}

		// Token: 0x0602291B RID: 141595 RVA: 0x004C1DD0 File Offset: 0x004BFFD0
		public IDynamicTeleportComponentT AsIDynamicTeleportComponent()
		{
			return this.As<IDynamicTeleportComponentT>();
		}

		// Token: 0x0602291C RID: 141596 RVA: 0x004C1DD8 File Offset: 0x004BFFD8
		public static IComponentBase_UnionUnion FromIDynamicTeleportComponent(IDynamicTeleportComponentT _idynamicteleportcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicTeleportComponent,
				Value = _idynamicteleportcomponent
			};
		}

		// Token: 0x0602291D RID: 141597 RVA: 0x004C1DEE File Offset: 0x004BFFEE
		public IExploreSkillInteractComponentT AsIExploreSkillInteractComponent()
		{
			return this.As<IExploreSkillInteractComponentT>();
		}

		// Token: 0x0602291E RID: 141598 RVA: 0x004C1DF6 File Offset: 0x004BFFF6
		public static IComponentBase_UnionUnion FromIExploreSkillInteractComponent(IExploreSkillInteractComponentT _iexploreskillinteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IExploreSkillInteractComponent,
				Value = _iexploreskillinteractcomponent
			};
		}

		// Token: 0x0602291F RID: 141599 RVA: 0x004C1E0C File Offset: 0x004C000C
		public IExploreSkillInteractGroupComponentT AsIExploreSkillInteractGroupComponent()
		{
			return this.As<IExploreSkillInteractGroupComponentT>();
		}

		// Token: 0x06022920 RID: 141600 RVA: 0x004C1E14 File Offset: 0x004C0014
		public static IComponentBase_UnionUnion FromIExploreSkillInteractGroupComponent(IExploreSkillInteractGroupComponentT _iexploreskillinteractgroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IExploreSkillInteractGroupComponent,
				Value = _iexploreskillinteractgroupcomponent
			};
		}

		// Token: 0x06022921 RID: 141601 RVA: 0x004C1E2A File Offset: 0x004C002A
		public IFanComponentT AsIFanComponent()
		{
			return this.As<IFanComponentT>();
		}

		// Token: 0x06022922 RID: 141602 RVA: 0x004C1E32 File Offset: 0x004C0032
		public static IComponentBase_UnionUnion FromIFanComponent(IFanComponentT _ifancomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFanComponent,
				Value = _ifancomponent
			};
		}

		// Token: 0x06022923 RID: 141603 RVA: 0x004C1E48 File Offset: 0x004C0048
		public IPasserbyNpcSpawnComponentT AsIPasserbyNpcSpawnComponent()
		{
			return this.As<IPasserbyNpcSpawnComponentT>();
		}

		// Token: 0x06022924 RID: 141604 RVA: 0x004C1E50 File Offset: 0x004C0050
		public static IComponentBase_UnionUnion FromIPasserbyNpcSpawnComponent(IPasserbyNpcSpawnComponentT _ipasserbynpcspawncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPasserbyNpcSpawnComponent,
				Value = _ipasserbynpcspawncomponent
			};
		}

		// Token: 0x06022925 RID: 141605 RVA: 0x004C1E66 File Offset: 0x004C0066
		public IModelComponentT AsIModelComponent()
		{
			return this.As<IModelComponentT>();
		}

		// Token: 0x06022926 RID: 141606 RVA: 0x004C1E6E File Offset: 0x004C006E
		public static IComponentBase_UnionUnion FromIModelComponent(IModelComponentT _imodelcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IModelComponent,
				Value = _imodelcomponent
			};
		}

		// Token: 0x06022927 RID: 141607 RVA: 0x004C1E84 File Offset: 0x004C0084
		public IEntityBundleComponentT AsIEntityBundleComponent()
		{
			return this.As<IEntityBundleComponentT>();
		}

		// Token: 0x06022928 RID: 141608 RVA: 0x004C1E8C File Offset: 0x004C008C
		public static IComponentBase_UnionUnion FromIEntityBundleComponent(IEntityBundleComponentT _ientitybundlecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityBundleComponent,
				Value = _ientitybundlecomponent
			};
		}

		// Token: 0x06022929 RID: 141609 RVA: 0x004C1EA2 File Offset: 0x004C00A2
		public IBeamCastComponentT AsIBeamCastComponent()
		{
			return this.As<IBeamCastComponentT>();
		}

		// Token: 0x0602292A RID: 141610 RVA: 0x004C1EAA File Offset: 0x004C00AA
		public static IComponentBase_UnionUnion FromIBeamCastComponent(IBeamCastComponentT _ibeamcastcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBeamCastComponent,
				Value = _ibeamcastcomponent
			};
		}

		// Token: 0x0602292B RID: 141611 RVA: 0x004C1EC0 File Offset: 0x004C00C0
		public IBeamReceiveComponentT AsIBeamReceiveComponent()
		{
			return this.As<IBeamReceiveComponentT>();
		}

		// Token: 0x0602292C RID: 141612 RVA: 0x004C1EC8 File Offset: 0x004C00C8
		public static IComponentBase_UnionUnion FromIBeamReceiveComponent(IBeamReceiveComponentT _ibeamreceivecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBeamReceiveComponent,
				Value = _ibeamreceivecomponent
			};
		}

		// Token: 0x0602292D RID: 141613 RVA: 0x004C1EDE File Offset: 0x004C00DE
		public ITimeStopComponentT AsITimeStopComponent()
		{
			return this.As<ITimeStopComponentT>();
		}

		// Token: 0x0602292E RID: 141614 RVA: 0x004C1EE6 File Offset: 0x004C00E6
		public static IComponentBase_UnionUnion FromITimeStopComponent(ITimeStopComponentT _itimestopcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITimeStopComponent,
				Value = _itimestopcomponent
			};
		}

		// Token: 0x0602292F RID: 141615 RVA: 0x004C1EFC File Offset: 0x004C00FC
		public IPortalComponentT AsIPortalComponent()
		{
			return this.As<IPortalComponentT>();
		}

		// Token: 0x06022930 RID: 141616 RVA: 0x004C1F04 File Offset: 0x004C0104
		public static IComponentBase_UnionUnion FromIPortalComponent(IPortalComponentT _iportalcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPortalComponent,
				Value = _iportalcomponent
			};
		}

		// Token: 0x06022931 RID: 141617 RVA: 0x004C1F1A File Offset: 0x004C011A
		public IDynamicPortalCreatorComponentT AsIDynamicPortalCreatorComponent()
		{
			return this.As<IDynamicPortalCreatorComponentT>();
		}

		// Token: 0x06022932 RID: 141618 RVA: 0x004C1F22 File Offset: 0x004C0122
		public static IComponentBase_UnionUnion FromIDynamicPortalCreatorComponent(IDynamicPortalCreatorComponentT _idynamicportalcreatorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicPortalCreatorComponent,
				Value = _idynamicportalcreatorcomponent
			};
		}

		// Token: 0x06022933 RID: 141619 RVA: 0x004C1F38 File Offset: 0x004C0138
		public INoRenderPortalComponentT AsINoRenderPortalComponent()
		{
			return this.As<INoRenderPortalComponentT>();
		}

		// Token: 0x06022934 RID: 141620 RVA: 0x004C1F40 File Offset: 0x004C0140
		public static IComponentBase_UnionUnion FromINoRenderPortalComponent(INoRenderPortalComponentT _inorenderportalcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INoRenderPortalComponent,
				Value = _inorenderportalcomponent
			};
		}

		// Token: 0x06022935 RID: 141621 RVA: 0x004C1F56 File Offset: 0x004C0156
		public IEffectAreaComponentT AsIEffectAreaComponent()
		{
			return this.As<IEffectAreaComponentT>();
		}

		// Token: 0x06022936 RID: 141622 RVA: 0x004C1F5E File Offset: 0x004C015E
		public static IComponentBase_UnionUnion FromIEffectAreaComponent(IEffectAreaComponentT _ieffectareacomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEffectAreaComponent,
				Value = _ieffectareacomponent
			};
		}

		// Token: 0x06022937 RID: 141623 RVA: 0x004C1F74 File Offset: 0x004C0174
		public IPhysicsConstraintComponentT AsIPhysicsConstraintComponent()
		{
			return this.As<IPhysicsConstraintComponentT>();
		}

		// Token: 0x06022938 RID: 141624 RVA: 0x004C1F7C File Offset: 0x004C017C
		public static IComponentBase_UnionUnion FromIPhysicsConstraintComponent(IPhysicsConstraintComponentT _iphysicsconstraintcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPhysicsConstraintComponent,
				Value = _iphysicsconstraintcomponent
			};
		}

		// Token: 0x06022939 RID: 141625 RVA: 0x004C1F92 File Offset: 0x004C0192
		public IFollowDecorationComponentT AsIFollowDecorationComponent()
		{
			return this.As<IFollowDecorationComponentT>();
		}

		// Token: 0x0602293A RID: 141626 RVA: 0x004C1F9A File Offset: 0x004C019A
		public static IComponentBase_UnionUnion FromIFollowDecorationComponent(IFollowDecorationComponentT _ifollowdecorationcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFollowDecorationComponent,
				Value = _ifollowdecorationcomponent
			};
		}

		// Token: 0x0602293B RID: 141627 RVA: 0x004C1FB3 File Offset: 0x004C01B3
		public IFollowShooterComponentT AsIFollowShooterComponent()
		{
			return this.As<IFollowShooterComponentT>();
		}

		// Token: 0x0602293C RID: 141628 RVA: 0x004C1FBB File Offset: 0x004C01BB
		public static IComponentBase_UnionUnion FromIFollowShooterComponent(IFollowShooterComponentT _ifollowshootercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFollowShooterComponent,
				Value = _ifollowshootercomponent
			};
		}

		// Token: 0x0602293D RID: 141629 RVA: 0x004C1FD4 File Offset: 0x004C01D4
		public IConnectorComponentT AsIConnectorComponent()
		{
			return this.As<IConnectorComponentT>();
		}

		// Token: 0x0602293E RID: 141630 RVA: 0x004C1FDC File Offset: 0x004C01DC
		public static IComponentBase_UnionUnion FromIConnectorComponent(IConnectorComponentT _iconnectorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IConnectorComponent,
				Value = _iconnectorcomponent
			};
		}

		// Token: 0x0602293F RID: 141631 RVA: 0x004C1FF5 File Offset: 0x004C01F5
		public ISceneTextComponentT AsISceneTextComponent()
		{
			return this.As<ISceneTextComponentT>();
		}

		// Token: 0x06022940 RID: 141632 RVA: 0x004C1FFD File Offset: 0x004C01FD
		public static IComponentBase_UnionUnion FromISceneTextComponent(ISceneTextComponentT _iscenetextcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneTextComponent,
				Value = _iscenetextcomponent
			};
		}

		// Token: 0x06022941 RID: 141633 RVA: 0x004C2016 File Offset: 0x004C0216
		public INavMeshComponentT AsINavMeshComponent()
		{
			return this.As<INavMeshComponentT>();
		}

		// Token: 0x06022942 RID: 141634 RVA: 0x004C201E File Offset: 0x004C021E
		public static IComponentBase_UnionUnion FromINavMeshComponent(INavMeshComponentT _inavmeshcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INavMeshComponent,
				Value = _inavmeshcomponent
			};
		}

		// Token: 0x06022943 RID: 141635 RVA: 0x004C2037 File Offset: 0x004C0237
		public ICharacterConnectorComponentT AsICharacterConnectorComponent()
		{
			return this.As<ICharacterConnectorComponentT>();
		}

		// Token: 0x06022944 RID: 141636 RVA: 0x004C203F File Offset: 0x004C023F
		public static IComponentBase_UnionUnion FromICharacterConnectorComponent(ICharacterConnectorComponentT _icharacterconnectorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICharacterConnectorComponent,
				Value = _icharacterconnectorcomponent
			};
		}

		// Token: 0x06022945 RID: 141637 RVA: 0x004C2058 File Offset: 0x004C0258
		public IAiGearStrategyComponentT AsIAiGearStrategyComponent()
		{
			return this.As<IAiGearStrategyComponentT>();
		}

		// Token: 0x06022946 RID: 141638 RVA: 0x004C2060 File Offset: 0x004C0260
		public static IComponentBase_UnionUnion FromIAiGearStrategyComponent(IAiGearStrategyComponentT _iaigearstrategycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAiGearStrategyComponent,
				Value = _iaigearstrategycomponent
			};
		}

		// Token: 0x06022947 RID: 141639 RVA: 0x004C2079 File Offset: 0x004C0279
		public IPickInteractComponentT AsIPickInteractComponent()
		{
			return this.As<IPickInteractComponentT>();
		}

		// Token: 0x06022948 RID: 141640 RVA: 0x004C2081 File Offset: 0x004C0281
		public static IComponentBase_UnionUnion FromIPickInteractComponent(IPickInteractComponentT _ipickinteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPickInteractComponent,
				Value = _ipickinteractcomponent
			};
		}

		// Token: 0x06022949 RID: 141641 RVA: 0x004C209A File Offset: 0x004C029A
		public IChessmanComponentT AsIChessmanComponent()
		{
			return this.As<IChessmanComponentT>();
		}

		// Token: 0x0602294A RID: 141642 RVA: 0x004C20A2 File Offset: 0x004C02A2
		public static IComponentBase_UnionUnion FromIChessmanComponent(IChessmanComponentT _ichessmancomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IChessmanComponent,
				Value = _ichessmancomponent
			};
		}

		// Token: 0x0602294B RID: 141643 RVA: 0x004C20BB File Offset: 0x004C02BB
		public IClientTriggerComponentT AsIClientTriggerComponent()
		{
			return this.As<IClientTriggerComponentT>();
		}

		// Token: 0x0602294C RID: 141644 RVA: 0x004C20C3 File Offset: 0x004C02C3
		public static IComponentBase_UnionUnion FromIClientTriggerComponent(IClientTriggerComponentT _iclienttriggercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IClientTriggerComponent,
				Value = _iclienttriggercomponent
			};
		}

		// Token: 0x0602294D RID: 141645 RVA: 0x004C20DC File Offset: 0x004C02DC
		public ILocationSafetyComponentT AsILocationSafetyComponent()
		{
			return this.As<ILocationSafetyComponentT>();
		}

		// Token: 0x0602294E RID: 141646 RVA: 0x004C20E4 File Offset: 0x004C02E4
		public static IComponentBase_UnionUnion FromILocationSafetyComponent(ILocationSafetyComponentT _ilocationsafetycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILocationSafetyComponent,
				Value = _ilocationsafetycomponent
			};
		}

		// Token: 0x0602294F RID: 141647 RVA: 0x004C20FD File Offset: 0x004C02FD
		public IBatchBulletCasterComponentT AsIBatchBulletCasterComponent()
		{
			return this.As<IBatchBulletCasterComponentT>();
		}

		// Token: 0x06022950 RID: 141648 RVA: 0x004C2105 File Offset: 0x004C0305
		public static IComponentBase_UnionUnion FromIBatchBulletCasterComponent(IBatchBulletCasterComponentT _ibatchbulletcastercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBatchBulletCasterComponent,
				Value = _ibatchbulletcastercomponent
			};
		}

		// Token: 0x06022951 RID: 141649 RVA: 0x004C211E File Offset: 0x004C031E
		public IVehicleComponentT AsIVehicleComponent()
		{
			return this.As<IVehicleComponentT>();
		}

		// Token: 0x06022952 RID: 141650 RVA: 0x004C2126 File Offset: 0x004C0326
		public static IComponentBase_UnionUnion FromIVehicleComponent(IVehicleComponentT _ivehiclecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVehicleComponent,
				Value = _ivehiclecomponent
			};
		}

		// Token: 0x06022953 RID: 141651 RVA: 0x004C213F File Offset: 0x004C033F
		public IEnrichmentAreaComponentT AsIEnrichmentAreaComponent()
		{
			return this.As<IEnrichmentAreaComponentT>();
		}

		// Token: 0x06022954 RID: 141652 RVA: 0x004C2147 File Offset: 0x004C0347
		public static IComponentBase_UnionUnion FromIEnrichmentAreaComponent(IEnrichmentAreaComponentT _ienrichmentareacomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEnrichmentAreaComponent,
				Value = _ienrichmentareacomponent
			};
		}

		// Token: 0x06022955 RID: 141653 RVA: 0x004C2160 File Offset: 0x004C0360
		public IMonitorComponentT AsIMonitorComponent()
		{
			return this.As<IMonitorComponentT>();
		}

		// Token: 0x06022956 RID: 141654 RVA: 0x004C2168 File Offset: 0x004C0368
		public static IComponentBase_UnionUnion FromIMonitorComponent(IMonitorComponentT _imonitorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMonitorComponent,
				Value = _imonitorcomponent
			};
		}

		// Token: 0x06022957 RID: 141655 RVA: 0x004C2181 File Offset: 0x004C0381
		public IGroupAiComponentT AsIGroupAiComponent()
		{
			return this.As<IGroupAiComponentT>();
		}

		// Token: 0x06022958 RID: 141656 RVA: 0x004C2189 File Offset: 0x004C0389
		public static IComponentBase_UnionUnion FromIGroupAiComponent(IGroupAiComponentT _igroupaicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGroupAiComponent,
				Value = _igroupaicomponent
			};
		}

		// Token: 0x06022959 RID: 141657 RVA: 0x004C21A2 File Offset: 0x004C03A2
		public IInhalationAbilityComponentT AsIInhalationAbilityComponent()
		{
			return this.As<IInhalationAbilityComponentT>();
		}

		// Token: 0x0602295A RID: 141658 RVA: 0x004C21AA File Offset: 0x004C03AA
		public static IComponentBase_UnionUnion FromIInhalationAbilityComponent(IInhalationAbilityComponentT _iinhalationabilitycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInhalationAbilityComponent,
				Value = _iinhalationabilitycomponent
			};
		}

		// Token: 0x0602295B RID: 141659 RVA: 0x004C21C3 File Offset: 0x004C03C3
		public IInhaledItemComponentT AsIInhaledItemComponent()
		{
			return this.As<IInhaledItemComponentT>();
		}

		// Token: 0x0602295C RID: 141660 RVA: 0x004C21CB File Offset: 0x004C03CB
		public static IComponentBase_UnionUnion FromIInhaledItemComponent(IInhaledItemComponentT _iinhaleditemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInhaledItemComponent,
				Value = _iinhaleditemcomponent
			};
		}

		// Token: 0x0602295D RID: 141661 RVA: 0x004C21E4 File Offset: 0x004C03E4
		public IAirPassageComponentT AsIAirPassageComponent()
		{
			return this.As<IAirPassageComponentT>();
		}

		// Token: 0x0602295E RID: 141662 RVA: 0x004C21EC File Offset: 0x004C03EC
		public static IComponentBase_UnionUnion FromIAirPassageComponent(IAirPassageComponentT _iairpassagecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAirPassageComponent,
				Value = _iairpassagecomponent
			};
		}

		// Token: 0x0602295F RID: 141663 RVA: 0x004C2205 File Offset: 0x004C0405
		public IRenderSpecifiedRangeComponentT AsIRenderSpecifiedRangeComponent()
		{
			return this.As<IRenderSpecifiedRangeComponentT>();
		}

		// Token: 0x06022960 RID: 141664 RVA: 0x004C220D File Offset: 0x004C040D
		public static IComponentBase_UnionUnion FromIRenderSpecifiedRangeComponent(IRenderSpecifiedRangeComponentT _irenderspecifiedrangecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRenderSpecifiedRangeComponent,
				Value = _irenderspecifiedrangecomponent
			};
		}

		// Token: 0x06022961 RID: 141665 RVA: 0x004C2226 File Offset: 0x004C0426
		public ILevelPrefabPerformComponentT AsILevelPrefabPerformComponent()
		{
			return this.As<ILevelPrefabPerformComponentT>();
		}

		// Token: 0x06022962 RID: 141666 RVA: 0x004C222E File Offset: 0x004C042E
		public static IComponentBase_UnionUnion FromILevelPrefabPerformComponent(ILevelPrefabPerformComponentT _ilevelprefabperformcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelPrefabPerformComponent,
				Value = _ilevelprefabperformcomponent
			};
		}

		// Token: 0x06022963 RID: 141667 RVA: 0x004C2247 File Offset: 0x004C0447
		public ISceneItemAiComponentT AsISceneItemAiComponent()
		{
			return this.As<ISceneItemAiComponentT>();
		}

		// Token: 0x06022964 RID: 141668 RVA: 0x004C224F File Offset: 0x004C044F
		public static IComponentBase_UnionUnion FromISceneItemAiComponent(ISceneItemAiComponentT _isceneitemaicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemAiComponent,
				Value = _isceneitemaicomponent
			};
		}

		// Token: 0x06022965 RID: 141669 RVA: 0x004C2268 File Offset: 0x004C0468
		public IGravityFlipComponentT AsIGravityFlipComponent()
		{
			return this.As<IGravityFlipComponentT>();
		}

		// Token: 0x06022966 RID: 141670 RVA: 0x004C2270 File Offset: 0x004C0470
		public static IComponentBase_UnionUnion FromIGravityFlipComponent(IGravityFlipComponentT _igravityflipcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGravityFlipComponent,
				Value = _igravityflipcomponent
			};
		}

		// Token: 0x06022967 RID: 141671 RVA: 0x004C2289 File Offset: 0x004C0489
		public ILevelSequenceFrameEventComponentT AsILevelSequenceFrameEventComponent()
		{
			return this.As<ILevelSequenceFrameEventComponentT>();
		}

		// Token: 0x06022968 RID: 141672 RVA: 0x004C2291 File Offset: 0x004C0491
		public static IComponentBase_UnionUnion FromILevelSequenceFrameEventComponent(ILevelSequenceFrameEventComponentT _ilevelsequenceframeeventcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelSequenceFrameEventComponent,
				Value = _ilevelsequenceframeeventcomponent
			};
		}

		// Token: 0x06022969 RID: 141673 RVA: 0x004C22AA File Offset: 0x004C04AA
		public ILevelQteComponentT AsILevelQteComponent()
		{
			return this.As<ILevelQteComponentT>();
		}

		// Token: 0x0602296A RID: 141674 RVA: 0x004C22B2 File Offset: 0x004C04B2
		public static IComponentBase_UnionUnion FromILevelQteComponent(ILevelQteComponentT _ilevelqtecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelQteComponent,
				Value = _ilevelqtecomponent
			};
		}

		// Token: 0x0602296B RID: 141675 RVA: 0x004C22CB File Offset: 0x004C04CB
		public IWalkingPatternComponentT AsIWalkingPatternComponent()
		{
			return this.As<IWalkingPatternComponentT>();
		}

		// Token: 0x0602296C RID: 141676 RVA: 0x004C22D3 File Offset: 0x004C04D3
		public static IComponentBase_UnionUnion FromIWalkingPatternComponent(IWalkingPatternComponentT _iwalkingpatterncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IWalkingPatternComponent,
				Value = _iwalkingpatterncomponent
			};
		}

		// Token: 0x0602296D RID: 141677 RVA: 0x004C22EC File Offset: 0x004C04EC
		public ILifePointCenterComponentT AsILifePointCenterComponent()
		{
			return this.As<ILifePointCenterComponentT>();
		}

		// Token: 0x0602296E RID: 141678 RVA: 0x004C22F4 File Offset: 0x004C04F4
		public static IComponentBase_UnionUnion FromILifePointCenterComponent(ILifePointCenterComponentT _ilifepointcentercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILifePointCenterComponent,
				Value = _ilifepointcentercomponent
			};
		}

		// Token: 0x0602296F RID: 141679 RVA: 0x004C230D File Offset: 0x004C050D
		public IHackManagementComponentT AsIHackManagementComponent()
		{
			return this.As<IHackManagementComponentT>();
		}

		// Token: 0x06022970 RID: 141680 RVA: 0x004C2315 File Offset: 0x004C0515
		public static IComponentBase_UnionUnion FromIHackManagementComponent(IHackManagementComponentT _ihackmanagementcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHackManagementComponent,
				Value = _ihackmanagementcomponent
			};
		}

		// Token: 0x06022971 RID: 141681 RVA: 0x004C232E File Offset: 0x004C052E
		public IClientConditionListenerComponentT AsIClientConditionListenerComponent()
		{
			return this.As<IClientConditionListenerComponentT>();
		}

		// Token: 0x06022972 RID: 141682 RVA: 0x004C2336 File Offset: 0x004C0536
		public static IComponentBase_UnionUnion FromIClientConditionListenerComponent(IClientConditionListenerComponentT _iclientconditionlistenercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IClientConditionListenerComponent,
				Value = _iclientconditionlistenercomponent
			};
		}

		// Token: 0x06022973 RID: 141683 RVA: 0x004C234F File Offset: 0x004C054F
		public ITemplateEntitySpawnerComponentT AsITemplateEntitySpawnerComponent()
		{
			return this.As<ITemplateEntitySpawnerComponentT>();
		}

		// Token: 0x06022974 RID: 141684 RVA: 0x004C2357 File Offset: 0x004C0557
		public static IComponentBase_UnionUnion FromITemplateEntitySpawnerComponent(ITemplateEntitySpawnerComponentT _itemplateentityspawnercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITemplateEntitySpawnerComponent,
				Value = _itemplateentityspawnercomponent
			};
		}

		// Token: 0x06022975 RID: 141685 RVA: 0x004C2370 File Offset: 0x004C0570
		public IWindSourceComponentT AsIWindSourceComponent()
		{
			return this.As<IWindSourceComponentT>();
		}

		// Token: 0x06022976 RID: 141686 RVA: 0x004C2378 File Offset: 0x004C0578
		public static IComponentBase_UnionUnion FromIWindSourceComponent(IWindSourceComponentT _iwindsourcecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IWindSourceComponent,
				Value = _iwindsourcecomponent
			};
		}

		// Token: 0x06022977 RID: 141687 RVA: 0x004C2391 File Offset: 0x004C0591
		public ISlideRailComponentT AsISlideRailComponent()
		{
			return this.As<ISlideRailComponentT>();
		}

		// Token: 0x06022978 RID: 141688 RVA: 0x004C2399 File Offset: 0x004C0599
		public static IComponentBase_UnionUnion FromISlideRailComponent(ISlideRailComponentT _isliderailcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISlideRailComponent,
				Value = _isliderailcomponent
			};
		}

		// Token: 0x06022979 RID: 141689 RVA: 0x004C23B2 File Offset: 0x004C05B2
		public ISlidePerformComponentT AsISlidePerformComponent()
		{
			return this.As<ISlidePerformComponentT>();
		}

		// Token: 0x0602297A RID: 141690 RVA: 0x004C23BA File Offset: 0x004C05BA
		public static IComponentBase_UnionUnion FromISlidePerformComponent(ISlidePerformComponentT _islideperformcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISlidePerformComponent,
				Value = _islideperformcomponent
			};
		}

		// Token: 0x0602297B RID: 141691 RVA: 0x004C23D3 File Offset: 0x004C05D3
		public IRollBlockComponentT AsIRollBlockComponent()
		{
			return this.As<IRollBlockComponentT>();
		}

		// Token: 0x0602297C RID: 141692 RVA: 0x004C23DB File Offset: 0x004C05DB
		public static IComponentBase_UnionUnion FromIRollBlockComponent(IRollBlockComponentT _irollblockcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRollBlockComponent,
				Value = _irollblockcomponent
			};
		}

		// Token: 0x0602297D RID: 141693 RVA: 0x004C23F4 File Offset: 0x004C05F4
		public IRollBlockFloorComponentT AsIRollBlockFloorComponent()
		{
			return this.As<IRollBlockFloorComponentT>();
		}

		// Token: 0x0602297E RID: 141694 RVA: 0x004C23FC File Offset: 0x004C05FC
		public static IComponentBase_UnionUnion FromIRollBlockFloorComponent(IRollBlockFloorComponentT _irollblockfloorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRollBlockFloorComponent,
				Value = _irollblockfloorcomponent
			};
		}

		// Token: 0x0602297F RID: 141695 RVA: 0x004C2415 File Offset: 0x004C0615
		public IRollBlockItemComponentT AsIRollBlockItemComponent()
		{
			return this.As<IRollBlockItemComponentT>();
		}

		// Token: 0x06022980 RID: 141696 RVA: 0x004C241D File Offset: 0x004C061D
		public static IComponentBase_UnionUnion FromIRollBlockItemComponent(IRollBlockItemComponentT _irollblockitemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRollBlockItemComponent,
				Value = _irollblockitemcomponent
			};
		}

		// Token: 0x06022981 RID: 141697 RVA: 0x004C2436 File Offset: 0x004C0636
		public ICurveControlComponentT AsICurveControlComponent()
		{
			return this.As<ICurveControlComponentT>();
		}

		// Token: 0x06022982 RID: 141698 RVA: 0x004C243E File Offset: 0x004C063E
		public static IComponentBase_UnionUnion FromICurveControlComponent(ICurveControlComponentT _icurvecontrolcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICurveControlComponent,
				Value = _icurvecontrolcomponent
			};
		}

		// Token: 0x06022983 RID: 141699 RVA: 0x004C2457 File Offset: 0x004C0657
		public ISimpleCombatComponentT AsISimpleCombatComponent()
		{
			return this.As<ISimpleCombatComponentT>();
		}

		// Token: 0x06022984 RID: 141700 RVA: 0x004C245F File Offset: 0x004C065F
		public static IComponentBase_UnionUnion FromISimpleCombatComponent(ISimpleCombatComponentT _isimplecombatcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISimpleCombatComponent,
				Value = _isimplecombatcomponent
			};
		}

		// Token: 0x06022985 RID: 141701 RVA: 0x004C2478 File Offset: 0x004C0678
		public IGridObjectComponentT AsIGridObjectComponent()
		{
			return this.As<IGridObjectComponentT>();
		}

		// Token: 0x06022986 RID: 141702 RVA: 0x004C2480 File Offset: 0x004C0680
		public static IComponentBase_UnionUnion FromIGridObjectComponent(IGridObjectComponentT _igridobjectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGridObjectComponent,
				Value = _igridobjectcomponent
			};
		}

		// Token: 0x06022987 RID: 141703 RVA: 0x004C2499 File Offset: 0x004C0699
		public IGodKingFrequencyControllerComponentT AsIGodKingFrequencyControllerComponent()
		{
			return this.As<IGodKingFrequencyControllerComponentT>();
		}

		// Token: 0x06022988 RID: 141704 RVA: 0x004C24A1 File Offset: 0x004C06A1
		public static IComponentBase_UnionUnion FromIGodKingFrequencyControllerComponent(IGodKingFrequencyControllerComponentT _igodkingfrequencycontrollercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGodKingFrequencyControllerComponent,
				Value = _igodkingfrequencycontrollercomponent
			};
		}

		// Token: 0x06022989 RID: 141705 RVA: 0x004C24BA File Offset: 0x004C06BA
		public IPerformanceOptimizationComponentT AsIPerformanceOptimizationComponent()
		{
			return this.As<IPerformanceOptimizationComponentT>();
		}

		// Token: 0x0602298A RID: 141706 RVA: 0x004C24C2 File Offset: 0x004C06C2
		public static IComponentBase_UnionUnion FromIPerformanceOptimizationComponent(IPerformanceOptimizationComponentT _iperformanceoptimizationcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPerformanceOptimizationComponent,
				Value = _iperformanceoptimizationcomponent
			};
		}

		// Token: 0x0602298B RID: 141707 RVA: 0x004C24DB File Offset: 0x004C06DB
		public ISceneItemEventListenerComponentT AsISceneItemEventListenerComponent()
		{
			return this.As<ISceneItemEventListenerComponentT>();
		}

		// Token: 0x0602298C RID: 141708 RVA: 0x004C24E3 File Offset: 0x004C06E3
		public static IComponentBase_UnionUnion FromISceneItemEventListenerComponent(ISceneItemEventListenerComponentT _isceneitemeventlistenercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemEventListenerComponent,
				Value = _isceneitemeventlistenercomponent
			};
		}

		// Token: 0x0602298D RID: 141709 RVA: 0x004C24FC File Offset: 0x004C06FC
		public IDynamicSpawnMonsterPointComponentT AsIDynamicSpawnMonsterPointComponent()
		{
			return this.As<IDynamicSpawnMonsterPointComponentT>();
		}

		// Token: 0x0602298E RID: 141710 RVA: 0x004C2504 File Offset: 0x004C0704
		public static IComponentBase_UnionUnion FromIDynamicSpawnMonsterPointComponent(IDynamicSpawnMonsterPointComponentT _idynamicspawnmonsterpointcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicSpawnMonsterPointComponent,
				Value = _idynamicspawnmonsterpointcomponent
			};
		}

		// Token: 0x0602298F RID: 141711 RVA: 0x004C251D File Offset: 0x004C071D
		public IDynamicSpawnMonsterComponentT AsIDynamicSpawnMonsterComponent()
		{
			return this.As<IDynamicSpawnMonsterComponentT>();
		}

		// Token: 0x06022990 RID: 141712 RVA: 0x004C2525 File Offset: 0x004C0725
		public static IComponentBase_UnionUnion FromIDynamicSpawnMonsterComponent(IDynamicSpawnMonsterComponentT _idynamicspawnmonstercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicSpawnMonsterComponent,
				Value = _idynamicspawnmonstercomponent
			};
		}

		// Token: 0x06022991 RID: 141713 RVA: 0x004C253E File Offset: 0x004C073E
		public ISunSpiritCollectComponentT AsISunSpiritCollectComponent()
		{
			return this.As<ISunSpiritCollectComponentT>();
		}

		// Token: 0x06022992 RID: 141714 RVA: 0x004C2546 File Offset: 0x004C0746
		public static IComponentBase_UnionUnion FromISunSpiritCollectComponent(ISunSpiritCollectComponentT _isunspiritcollectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISunSpiritCollectComponent,
				Value = _isunspiritcollectcomponent
			};
		}

		// Token: 0x06022993 RID: 141715 RVA: 0x004C255F File Offset: 0x004C075F
		public ISunSpiritLauncherComponentT AsISunSpiritLauncherComponent()
		{
			return this.As<ISunSpiritLauncherComponentT>();
		}

		// Token: 0x06022994 RID: 141716 RVA: 0x004C2567 File Offset: 0x004C0767
		public static IComponentBase_UnionUnion FromISunSpiritLauncherComponent(ISunSpiritLauncherComponentT _isunspiritlaunchercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISunSpiritLauncherComponent,
				Value = _isunspiritlaunchercomponent
			};
		}

		// Token: 0x06022995 RID: 141717 RVA: 0x004C2580 File Offset: 0x004C0780
		public ISunSpiritGearComponentT AsISunSpiritGearComponent()
		{
			return this.As<ISunSpiritGearComponentT>();
		}

		// Token: 0x06022996 RID: 141718 RVA: 0x004C2588 File Offset: 0x004C0788
		public static IComponentBase_UnionUnion FromISunSpiritGearComponent(ISunSpiritGearComponentT _isunspiritgearcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISunSpiritGearComponent,
				Value = _isunspiritgearcomponent
			};
		}

		// Token: 0x06022997 RID: 141719 RVA: 0x004C25A1 File Offset: 0x004C07A1
		public IMotorSlideComponentT AsIMotorSlideComponent()
		{
			return this.As<IMotorSlideComponentT>();
		}

		// Token: 0x06022998 RID: 141720 RVA: 0x004C25A9 File Offset: 0x004C07A9
		public static IComponentBase_UnionUnion FromIMotorSlideComponent(IMotorSlideComponentT _imotorslidecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMotorSlideComponent,
				Value = _imotorslidecomponent
			};
		}

		// Token: 0x06022999 RID: 141721 RVA: 0x004C25C2 File Offset: 0x004C07C2
		public IProceduralVisualComponentT AsIProceduralVisualComponent()
		{
			return this.As<IProceduralVisualComponentT>();
		}

		// Token: 0x0602299A RID: 141722 RVA: 0x004C25CA File Offset: 0x004C07CA
		public static IComponentBase_UnionUnion FromIProceduralVisualComponent(IProceduralVisualComponentT _iproceduralvisualcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IProceduralVisualComponent,
				Value = _iproceduralvisualcomponent
			};
		}

		// Token: 0x0602299B RID: 141723 RVA: 0x004C25E3 File Offset: 0x004C07E3
		public IRoadNetworkNavigationComponentT AsIRoadNetworkNavigationComponent()
		{
			return this.As<IRoadNetworkNavigationComponentT>();
		}

		// Token: 0x0602299C RID: 141724 RVA: 0x004C25EB File Offset: 0x004C07EB
		public static IComponentBase_UnionUnion FromIRoadNetworkNavigationComponent(IRoadNetworkNavigationComponentT _iroadnetworknavigationcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRoadNetworkNavigationComponent,
				Value = _iroadnetworknavigationcomponent
			};
		}

		// Token: 0x0602299D RID: 141725 RVA: 0x004C2604 File Offset: 0x004C0804
		public IFurnitureSlotComponentT AsIFurnitureSlotComponent()
		{
			return this.As<IFurnitureSlotComponentT>();
		}

		// Token: 0x0602299E RID: 141726 RVA: 0x004C260C File Offset: 0x004C080C
		public static IComponentBase_UnionUnion FromIFurnitureSlotComponent(IFurnitureSlotComponentT _ifurnitureslotcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFurnitureSlotComponent,
				Value = _ifurnitureslotcomponent
			};
		}

		// Token: 0x0602299F RID: 141727 RVA: 0x004C2625 File Offset: 0x004C0825
		public IVisionDisplayComponentT AsIVisionDisplayComponent()
		{
			return this.As<IVisionDisplayComponentT>();
		}

		// Token: 0x060229A0 RID: 141728 RVA: 0x004C262D File Offset: 0x004C082D
		public static IComponentBase_UnionUnion FromIVisionDisplayComponent(IVisionDisplayComponentT _ivisiondisplaycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVisionDisplayComponent,
				Value = _ivisiondisplaycomponent
			};
		}

		// Token: 0x060229A1 RID: 141729 RVA: 0x004C2646 File Offset: 0x004C0846
		public ISystemModuleDataSyncComponentT AsISystemModuleDataSyncComponent()
		{
			return this.As<ISystemModuleDataSyncComponentT>();
		}

		// Token: 0x060229A2 RID: 141730 RVA: 0x004C264E File Offset: 0x004C084E
		public static IComponentBase_UnionUnion FromISystemModuleDataSyncComponent(ISystemModuleDataSyncComponentT _isystemmoduledatasynccomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISystemModuleDataSyncComponent,
				Value = _isystemmoduledatasynccomponent
			};
		}

		// Token: 0x060229A3 RID: 141731 RVA: 0x004C2667 File Offset: 0x004C0867
		public IExhibitComponentT AsIExhibitComponent()
		{
			return this.As<IExhibitComponentT>();
		}

		// Token: 0x060229A4 RID: 141732 RVA: 0x004C266F File Offset: 0x004C086F
		public static IComponentBase_UnionUnion FromIExhibitComponent(IExhibitComponentT _iexhibitcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IExhibitComponent,
				Value = _iexhibitcomponent
			};
		}

		// Token: 0x060229A5 RID: 141733 RVA: 0x004C2688 File Offset: 0x004C0888
		public ITimeScheduleComponentT AsITimeScheduleComponent()
		{
			return this.As<ITimeScheduleComponentT>();
		}

		// Token: 0x060229A6 RID: 141734 RVA: 0x004C2690 File Offset: 0x004C0890
		public static IComponentBase_UnionUnion FromITimeScheduleComponent(ITimeScheduleComponentT _itimeschedulecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITimeScheduleComponent,
				Value = _itimeschedulecomponent
			};
		}

		// Token: 0x060229A7 RID: 141735 RVA: 0x004C26A9 File Offset: 0x004C08A9
		public IProjectorComponentT AsIProjectorComponent()
		{
			return this.As<IProjectorComponentT>();
		}

		// Token: 0x060229A8 RID: 141736 RVA: 0x004C26B1 File Offset: 0x004C08B1
		public static IComponentBase_UnionUnion FromIProjectorComponent(IProjectorComponentT _iprojectorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IProjectorComponent,
				Value = _iprojectorcomponent
			};
		}

		// Token: 0x060229A9 RID: 141737 RVA: 0x004C26CA File Offset: 0x004C08CA
		public IProceduralMaterialComponentT AsIProceduralMaterialComponent()
		{
			return this.As<IProceduralMaterialComponentT>();
		}

		// Token: 0x060229AA RID: 141738 RVA: 0x004C26D2 File Offset: 0x004C08D2
		public static IComponentBase_UnionUnion FromIProceduralMaterialComponent(IProceduralMaterialComponentT _iproceduralmaterialcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IProceduralMaterialComponent,
				Value = _iproceduralmaterialcomponent
			};
		}

		// Token: 0x060229AB RID: 141739 RVA: 0x004C26EB File Offset: 0x004C08EB
		public IGameplayDataPersistenceComponentT AsIGameplayDataPersistenceComponent()
		{
			return this.As<IGameplayDataPersistenceComponentT>();
		}

		// Token: 0x060229AC RID: 141740 RVA: 0x004C26F3 File Offset: 0x004C08F3
		public static IComponentBase_UnionUnion FromIGameplayDataPersistenceComponent(IGameplayDataPersistenceComponentT _igameplaydatapersistencecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGameplayDataPersistenceComponent,
				Value = _igameplaydatapersistencecomponent
			};
		}

		// Token: 0x060229AD RID: 141741 RVA: 0x004C270C File Offset: 0x004C090C
		public IFlowerPollutionComponentT AsIFlowerPollutionComponent()
		{
			return this.As<IFlowerPollutionComponentT>();
		}

		// Token: 0x060229AE RID: 141742 RVA: 0x004C2714 File Offset: 0x004C0914
		public static IComponentBase_UnionUnion FromIFlowerPollutionComponent(IFlowerPollutionComponentT _iflowerpollutioncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFlowerPollutionComponent,
				Value = _iflowerpollutioncomponent
			};
		}

		// Token: 0x060229AF RID: 141743 RVA: 0x004C272D File Offset: 0x004C092D
		public IQuickHackComponentT AsIQuickHackComponent()
		{
			return this.As<IQuickHackComponentT>();
		}

		// Token: 0x060229B0 RID: 141744 RVA: 0x004C2735 File Offset: 0x004C0935
		public static IComponentBase_UnionUnion FromIQuickHackComponent(IQuickHackComponentT _iquickhackcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IQuickHackComponent,
				Value = _iquickhackcomponent
			};
		}

		// Token: 0x060229B1 RID: 141745 RVA: 0x004C274E File Offset: 0x004C094E
		public IDollGrabMachineComponentT AsIDollGrabMachineComponent()
		{
			return this.As<IDollGrabMachineComponentT>();
		}

		// Token: 0x060229B2 RID: 141746 RVA: 0x004C2756 File Offset: 0x004C0956
		public static IComponentBase_UnionUnion FromIDollGrabMachineComponent(IDollGrabMachineComponentT _idollgrabmachinecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDollGrabMachineComponent,
				Value = _idollgrabmachinecomponent
			};
		}

		// Token: 0x060229B3 RID: 141747 RVA: 0x004C276F File Offset: 0x004C096F
		public IDollGrabShowcaseComponentT AsIDollGrabShowcaseComponent()
		{
			return this.As<IDollGrabShowcaseComponentT>();
		}

		// Token: 0x060229B4 RID: 141748 RVA: 0x004C2777 File Offset: 0x004C0977
		public static IComponentBase_UnionUnion FromIDollGrabShowcaseComponent(IDollGrabShowcaseComponentT _idollgrabshowcasecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDollGrabShowcaseComponent,
				Value = _idollgrabshowcasecomponent
			};
		}

		// Token: 0x060229B5 RID: 141749 RVA: 0x004C2790 File Offset: 0x004C0990
		public IWuWaGoComponentT AsIWuWaGoComponent()
		{
			return this.As<IWuWaGoComponentT>();
		}

		// Token: 0x060229B6 RID: 141750 RVA: 0x004C2798 File Offset: 0x004C0998
		public static IComponentBase_UnionUnion FromIWuWaGoComponent(IWuWaGoComponentT _iwuwagocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IWuWaGoComponent,
				Value = _iwuwagocomponent
			};
		}

		// Token: 0x060229B7 RID: 141751 RVA: 0x004C27B1 File Offset: 0x004C09B1
		public IDragActorPlayComponentT AsIDragActorPlayComponent()
		{
			return this.As<IDragActorPlayComponentT>();
		}

		// Token: 0x060229B8 RID: 141752 RVA: 0x004C27B9 File Offset: 0x004C09B9
		public static IComponentBase_UnionUnion FromIDragActorPlayComponent(IDragActorPlayComponentT _idragactorplaycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDragActorPlayComponent,
				Value = _idragactorplaycomponent
			};
		}

		// Token: 0x060229B9 RID: 141753 RVA: 0x004C27D2 File Offset: 0x004C09D2
		public IPathDrivenActorSpawnerComponentT AsIPathDrivenActorSpawnerComponent()
		{
			return this.As<IPathDrivenActorSpawnerComponentT>();
		}

		// Token: 0x060229BA RID: 141754 RVA: 0x004C27DA File Offset: 0x004C09DA
		public static IComponentBase_UnionUnion FromIPathDrivenActorSpawnerComponent(IPathDrivenActorSpawnerComponentT _ipathdrivenactorspawnercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPathDrivenActorSpawnerComponent,
				Value = _ipathdrivenactorspawnercomponent
			};
		}

		// Token: 0x060229BB RID: 141755 RVA: 0x004C27F3 File Offset: 0x004C09F3
		public IElementalHolderComponentT AsIElementalHolderComponent()
		{
			return this.As<IElementalHolderComponentT>();
		}

		// Token: 0x060229BC RID: 141756 RVA: 0x004C27FB File Offset: 0x004C09FB
		public static IComponentBase_UnionUnion FromIElementalHolderComponent(IElementalHolderComponentT _ielementalholdercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IElementalHolderComponent,
				Value = _ielementalholdercomponent
			};
		}

		// Token: 0x060229BD RID: 141757 RVA: 0x004C2814 File Offset: 0x004C0A14
		public IElementalEffectComponentT AsIElementalEffectComponent()
		{
			return this.As<IElementalEffectComponentT>();
		}

		// Token: 0x060229BE RID: 141758 RVA: 0x004C281C File Offset: 0x004C0A1C
		public static IComponentBase_UnionUnion FromIElementalEffectComponent(IElementalEffectComponentT _ielementaleffectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IElementalEffectComponent,
				Value = _ielementaleffectcomponent
			};
		}

		// Token: 0x060229BF RID: 141759 RVA: 0x004C2835 File Offset: 0x004C0A35
		public IElementalBoxFoundationComponentT AsIElementalBoxFoundationComponent()
		{
			return this.As<IElementalBoxFoundationComponentT>();
		}

		// Token: 0x060229C0 RID: 141760 RVA: 0x004C283D File Offset: 0x004C0A3D
		public static IComponentBase_UnionUnion FromIElementalBoxFoundationComponent(IElementalBoxFoundationComponentT _ielementalboxfoundationcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IElementalBoxFoundationComponent,
				Value = _ielementalboxfoundationcomponent
			};
		}

		// Token: 0x060229C1 RID: 141761 RVA: 0x004C2856 File Offset: 0x004C0A56
		public IElementalWellComponentT AsIElementalWellComponent()
		{
			return this.As<IElementalWellComponentT>();
		}

		// Token: 0x060229C2 RID: 141762 RVA: 0x004C285E File Offset: 0x004C0A5E
		public static IComponentBase_UnionUnion FromIElementalWellComponent(IElementalWellComponentT _ielementalwellcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IElementalWellComponent,
				Value = _ielementalwellcomponent
			};
		}

		// Token: 0x060229C3 RID: 141763 RVA: 0x004C2877 File Offset: 0x004C0A77
		public IStreamingSourceTriggerPointComponentT AsIStreamingSourceTriggerPointComponent()
		{
			return this.As<IStreamingSourceTriggerPointComponentT>();
		}

		// Token: 0x060229C4 RID: 141764 RVA: 0x004C287F File Offset: 0x004C0A7F
		public static IComponentBase_UnionUnion FromIStreamingSourceTriggerPointComponent(IStreamingSourceTriggerPointComponentT _istreamingsourcetriggerpointcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IStreamingSourceTriggerPointComponent,
				Value = _istreamingsourcetriggerpointcomponent
			};
		}

		// Token: 0x060229C5 RID: 141765 RVA: 0x004C2898 File Offset: 0x004C0A98
		public IGraph3dComponentT AsIGraph3dComponent()
		{
			return this.As<IGraph3dComponentT>();
		}

		// Token: 0x060229C6 RID: 141766 RVA: 0x004C28A0 File Offset: 0x004C0AA0
		public static IComponentBase_UnionUnion FromIGraph3dComponent(IGraph3dComponentT _igraph3dcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGraph3dComponent,
				Value = _igraph3dcomponent
			};
		}

		// Token: 0x060229C7 RID: 141767 RVA: 0x004C28B9 File Offset: 0x004C0AB9
		public IGraph3dEffectComponentT AsIGraph3dEffectComponent()
		{
			return this.As<IGraph3dEffectComponentT>();
		}

		// Token: 0x060229C8 RID: 141768 RVA: 0x004C28C1 File Offset: 0x004C0AC1
		public static IComponentBase_UnionUnion FromIGraph3dEffectComponent(IGraph3dEffectComponentT _igraph3deffectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGraph3dEffectComponent,
				Value = _igraph3deffectcomponent
			};
		}

		// Token: 0x060229C9 RID: 141769 RVA: 0x004C28DA File Offset: 0x004C0ADA
		public INoiseRemovalComponentT AsINoiseRemovalComponent()
		{
			return this.As<INoiseRemovalComponentT>();
		}

		// Token: 0x060229CA RID: 141770 RVA: 0x004C28E2 File Offset: 0x004C0AE2
		public static IComponentBase_UnionUnion FromINoiseRemovalComponent(INoiseRemovalComponentT _inoiseremovalcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INoiseRemovalComponent,
				Value = _inoiseremovalcomponent
			};
		}

		// Token: 0x060229CB RID: 141771 RVA: 0x004C28FB File Offset: 0x004C0AFB
		public IFrequencyPaintComponentT AsIFrequencyPaintComponent()
		{
			return this.As<IFrequencyPaintComponentT>();
		}

		// Token: 0x060229CC RID: 141772 RVA: 0x004C2903 File Offset: 0x004C0B03
		public static IComponentBase_UnionUnion FromIFrequencyPaintComponent(IFrequencyPaintComponentT _ifrequencypaintcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFrequencyPaintComponent,
				Value = _ifrequencypaintcomponent
			};
		}

		// Token: 0x060229CD RID: 141773 RVA: 0x004C291C File Offset: 0x004C0B1C
		public ITurntableConnectorComponentT AsITurntableConnectorComponent()
		{
			return this.As<ITurntableConnectorComponentT>();
		}

		// Token: 0x060229CE RID: 141774 RVA: 0x004C2924 File Offset: 0x004C0B24
		public static IComponentBase_UnionUnion FromITurntableConnectorComponent(ITurntableConnectorComponentT _iturntableconnectorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITurntableConnectorComponent,
				Value = _iturntableconnectorcomponent
			};
		}

		// Token: 0x060229CF RID: 141775 RVA: 0x004C2940 File Offset: 0x004C0B40
		public static int Pack(FlatBufferBuilder builder, IComponentBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IComponentBase_Union.IComponentBase:
				return IComponentBase.Pack(builder, _o.AsIComponentBase()).Value;
			case IComponentBase_Union.IUnUseComponent:
				return IUnUseComponent.Pack(builder, _o.AsIUnUseComponent()).Value;
			case IComponentBase_Union.IInteractiveComponent:
				return IInteractiveComponent.Pack(builder, _o.AsIInteractiveComponent()).Value;
			case IComponentBase_Union.ISwitcherComponent:
				return ISwitcherComponent.Pack(builder, _o.AsISwitcherComponent()).Value;
			case IComponentBase_Union.IRotatorComponent:
				return IRotatorComponent.Pack(builder, _o.AsIRotatorComponent()).Value;
			case IComponentBase_Union.IBehaviorFlowComponent:
				return IBehaviorFlowComponent.Pack(builder, _o.AsIBehaviorFlowComponent()).Value;
			case IComponentBase_Union.IFlowComponent:
				return IFlowComponent.Pack(builder, _o.AsIFlowComponent()).Value;
			case IComponentBase_Union.ITriggerUe5Component:
				return ITriggerUe5Component.Pack(builder, _o.AsITriggerUe5Component()).Value;
			case IComponentBase_Union.IMoveComponent:
				return IMoveComponent.Pack(builder, _o.AsIMoveComponent()).Value;
			case IComponentBase_Union.IActorStateComponent:
				return IActorStateComponent.Pack(builder, _o.AsIActorStateComponent()).Value;
			case IComponentBase_Union.ICalculateComponent:
				return ICalculateComponent.Pack(builder, _o.AsICalculateComponent()).Value;
			case IComponentBase_Union.IRefreshGroup:
				return IRefreshGroup.Pack(builder, _o.AsIRefreshGroup()).Value;
			case IComponentBase_Union.IRefreshSingleComponent:
				return IRefreshSingleComponent.Pack(builder, _o.AsIRefreshSingleComponent()).Value;
			case IComponentBase_Union.IRotatorComponent2:
				return IRotatorComponent2.Pack(builder, _o.AsIRotatorComponent2()).Value;
			case IComponentBase_Union.ISphereFactoryComponent:
				return ISphereFactoryComponent.Pack(builder, _o.AsISphereFactoryComponent()).Value;
			case IComponentBase_Union.ISpringComponent:
				return ISpringComponent.Pack(builder, _o.AsISpringComponent()).Value;
			case IComponentBase_Union.ITrampleUe5Component:
				return ITrampleUe5Component.Pack(builder, _o.AsITrampleUe5Component()).Value;
			case IComponentBase_Union.IUndergroundComponent:
				return IUndergroundComponent.Pack(builder, _o.AsIUndergroundComponent()).Value;
			case IComponentBase_Union.IGrabComponent:
				return IGrabComponent.Pack(builder, _o.AsIGrabComponent()).Value;
			case IComponentBase_Union.IInteractComponent:
				return IInteractComponent.Pack(builder, _o.AsIInteractComponent()).Value;
			case IComponentBase_Union.IVarComponent:
				return IVarComponent.Pack(builder, _o.AsIVarComponent()).Value;
			case IComponentBase_Union.IPatrol:
				return IPatrol.Pack(builder, _o.AsIPatrol()).Value;
			case IComponentBase_Union.IAiComponent:
				return IAiComponent.Pack(builder, _o.AsIAiComponent()).Value;
			case IComponentBase_Union.IAttributeComponent:
				return IAttributeComponent.Pack(builder, _o.AsIAttributeComponent()).Value;
			case IComponentBase_Union.IEditCustomAoiComponent:
				return IEditCustomAoiComponent.Pack(builder, _o.AsIEditCustomAoiComponent()).Value;
			case IComponentBase_Union.IBaseInfoComponent:
				return IBaseInfoComponent.Pack(builder, _o.AsIBaseInfoComponent()).Value;
			case IComponentBase_Union.IRewardComponent:
				return IRewardComponent.Pack(builder, _o.AsIRewardComponent()).Value;
			case IComponentBase_Union.IDynamicEntityRewardComponent:
				return IDynamicEntityRewardComponent.Pack(builder, _o.AsIDynamicEntityRewardComponent()).Value;
			case IComponentBase_Union.IIndependentSystemRewardComponent:
				return IIndependentSystemRewardComponent.Pack(builder, _o.AsIIndependentSystemRewardComponent()).Value;
			case IComponentBase_Union.IRefreshComponent:
				return IRefreshComponent.Pack(builder, _o.AsIRefreshComponent()).Value;
			case IComponentBase_Union.IRefreshGroupComponent:
				return IRefreshGroupComponent.Pack(builder, _o.AsIRefreshGroupComponent()).Value;
			case IComponentBase_Union.IEntityBatchRefreshComponent:
				return IEntityBatchRefreshComponent.Pack(builder, _o.AsIEntityBatchRefreshComponent()).Value;
			case IComponentBase_Union.ITreasureBoxComponent:
				return ITreasureBoxComponent.Pack(builder, _o.AsITreasureBoxComponent()).Value;
			case IComponentBase_Union.ITriggerComponent:
				return ITriggerComponent.Pack(builder, _o.AsITriggerComponent()).Value;
			case IComponentBase_Union.IEntityStateComponent:
				return IEntityStateComponent.Pack(builder, _o.AsIEntityStateComponent()).Value;
			case IComponentBase_Union.ISceneItemAttributeComponent:
				return ISceneItemAttributeComponent.Pack(builder, _o.AsISceneItemAttributeComponent()).Value;
			case IComponentBase_Union.IEntityAudioComponent:
				return IEntityAudioComponent.Pack(builder, _o.AsIEntityAudioComponent()).Value;
			case IComponentBase_Union.IEntityStateAudioComponent:
				return IEntityStateAudioComponent.Pack(builder, _o.AsIEntityStateAudioComponent()).Value;
			case IComponentBase_Union.IEntityCustomAudioComponent:
				return IEntityCustomAudioComponent.Pack(builder, _o.AsIEntityCustomAudioComponent()).Value;
			case IComponentBase_Union.ITrampleComponent:
				return ITrampleComponent.Pack(builder, _o.AsITrampleComponent()).Value;
			case IComponentBase_Union.IEntityGroupComponent:
				return IEntityGroupComponent.Pack(builder, _o.AsIEntityGroupComponent()).Value;
			case IComponentBase_Union.IHookLockPoint:
				return IHookLockPoint.Pack(builder, _o.AsIHookLockPoint()).Value;
			case IComponentBase_Union.IRoleMotionInteractComponent:
				return IRoleMotionInteractComponent.Pack(builder, _o.AsIRoleMotionInteractComponent()).Value;
			case IComponentBase_Union.IHookFetchComponent:
				return IHookFetchComponent.Pack(builder, _o.AsIHookFetchComponent()).Value;
			case IComponentBase_Union.IItemFoundation:
				return IItemFoundation.Pack(builder, _o.AsIItemFoundation()).Value;
			case IComponentBase_Union.IResetEntitiesPosComponent:
				return IResetEntitiesPosComponent.Pack(builder, _o.AsIResetEntitiesPosComponent()).Value;
			case IComponentBase_Union.IResetSelfPosComponent:
				return IResetSelfPosComponent.Pack(builder, _o.AsIResetSelfPosComponent()).Value;
			case IComponentBase_Union.ICollectComponent:
				return ICollectComponent.Pack(builder, _o.AsICollectComponent()).Value;
			case IComponentBase_Union.ITeleControl2:
				return ITeleControl2.Pack(builder, _o.AsITeleControl2()).Value;
			case IComponentBase_Union.IItemFoundation2:
				return IItemFoundation2.Pack(builder, _o.AsIItemFoundation2()).Value;
			case IComponentBase_Union.IPullingFoundation:
				return IPullingFoundation.Pack(builder, _o.AsIPullingFoundation()).Value;
			case IComponentBase_Union.ILevelPlayComponent:
				return ILevelPlayComponent.Pack(builder, _o.AsILevelPlayComponent()).Value;
			case IComponentBase_Union.IDynamicLevelPlayComponent:
				return IDynamicLevelPlayComponent.Pack(builder, _o.AsIDynamicLevelPlayComponent()).Value;
			case IComponentBase_Union.IVisionComponent:
				return IVisionComponent.Pack(builder, _o.AsIVisionComponent()).Value;
			case IComponentBase_Union.IVisionCaptureComponent:
				return IVisionCaptureComponent.Pack(builder, _o.AsIVisionCaptureComponent()).Value;
			case IComponentBase_Union.IAdsorbComponent:
				return IAdsorbComponent.Pack(builder, _o.AsIAdsorbComponent()).Value;
			case IComponentBase_Union.ITeleportComponent:
				return ITeleportComponent.Pack(builder, _o.AsITeleportComponent()).Value;
			case IComponentBase_Union.ISpawnMonsterComponent:
				return ISpawnMonsterComponent.Pack(builder, _o.AsISpawnMonsterComponent()).Value;
			case IComponentBase_Union.IHitComponentBase:
				return IHitComponentBase.Pack(builder, _o.AsIHitComponentBase()).Value;
			case IComponentBase_Union.IDestructibleItem:
				return IDestructibleItem.Pack(builder, _o.AsIDestructibleItem()).Value;
			case IComponentBase_Union.ITargetGearComponent:
				return ITargetGearComponent.Pack(builder, _o.AsITargetGearComponent()).Value;
			case IComponentBase_Union.IProgressBarControlComponent:
				return IProgressBarControlComponent.Pack(builder, _o.AsIProgressBarControlComponent()).Value;
			case IComponentBase_Union.IHitComponent:
				return IHitComponent.Pack(builder, _o.AsIHitComponent()).Value;
			case IComponentBase_Union.ITargetGearGroupComponent:
				return ITargetGearGroupComponent.Pack(builder, _o.AsITargetGearGroupComponent()).Value;
			case IComponentBase_Union.INpcPerformComponent:
				return INpcPerformComponent.Pack(builder, _o.AsINpcPerformComponent()).Value;
			case IComponentBase_Union.IInteractGearComponent:
				return IInteractGearComponent.Pack(builder, _o.AsIInteractGearComponent()).Value;
			case IComponentBase_Union.ILiftComponent:
				return ILiftComponent.Pack(builder, _o.AsILiftComponent()).Value;
			case IComponentBase_Union.IConveyorBeltComponent:
				return IConveyorBeltComponent.Pack(builder, _o.AsIConveyorBeltComponent()).Value;
			case IComponentBase_Union.IFollowTrackComponent:
				return IFollowTrackComponent.Pack(builder, _o.AsIFollowTrackComponent()).Value;
			case IComponentBase_Union.ISceneItemLifeCycleComponent:
				return ISceneItemLifeCycleComponent.Pack(builder, _o.AsISceneItemLifeCycleComponent()).Value;
			case IComponentBase_Union.IFightInteractComponent:
				return IFightInteractComponent.Pack(builder, _o.AsIFightInteractComponent()).Value;
			case IComponentBase_Union.IBubbleComponent:
				return IBubbleComponent.Pack(builder, _o.AsIBubbleComponent()).Value;
			case IComponentBase_Union.INearbyTrackingComponent:
				return INearbyTrackingComponent.Pack(builder, _o.AsINearbyTrackingComponent()).Value;
			case IComponentBase_Union.IEntityPackageComponent:
				return IEntityPackageComponent.Pack(builder, _o.AsIEntityPackageComponent()).Value;
			case IComponentBase_Union.ISkyboxComponent:
				return ISkyboxComponent.Pack(builder, _o.AsISkyboxComponent()).Value;
			case IComponentBase_Union.IStateHintComponent:
				return IStateHintComponent.Pack(builder, _o.AsIStateHintComponent()).Value;
			case IComponentBase_Union.IEntityVisibleComponent:
				return IEntityVisibleComponent.Pack(builder, _o.AsIEntityVisibleComponent()).Value;
			case IComponentBase_Union.ICombinedVisibleGroupComponent:
				return ICombinedVisibleGroupComponent.Pack(builder, _o.AsICombinedVisibleGroupComponent()).Value;
			case IComponentBase_Union.IWeaponComponent:
				return IWeaponComponent.Pack(builder, _o.AsIWeaponComponent()).Value;
			case IComponentBase_Union.IDungeonEntryComponent:
				return IDungeonEntryComponent.Pack(builder, _o.AsIDungeonEntryComponent()).Value;
			case IComponentBase_Union.IResurrectionComponent:
				return IResurrectionComponent.Pack(builder, _o.AsIResurrectionComponent()).Value;
			case IComponentBase_Union.IBuffProducerComponent:
				return IBuffProducerComponent.Pack(builder, _o.AsIBuffProducerComponent()).Value;
			case IComponentBase_Union.IBuffConsumerComponent:
				return IBuffConsumerComponent.Pack(builder, _o.AsIBuffConsumerComponent()).Value;
			case IComponentBase_Union.IGuideLineCreatorComponent:
				return IGuideLineCreatorComponent.Pack(builder, _o.AsIGuideLineCreatorComponent()).Value;
			case IComponentBase_Union.IInteractAudioComponent:
				return IInteractAudioComponent.Pack(builder, _o.AsIInteractAudioComponent()).Value;
			case IComponentBase_Union.IDropComponent:
				return IDropComponent.Pack(builder, _o.AsIDropComponent()).Value;
			case IComponentBase_Union.IVisionItemComponent:
				return IVisionItemComponent.Pack(builder, _o.AsIVisionItemComponent()).Value;
			case IComponentBase_Union.IAdviseItemComponent:
				return IAdviseItemComponent.Pack(builder, _o.AsIAdviseItemComponent()).Value;
			case IComponentBase_Union.IMonsterComponent:
				return IMonsterComponent.Pack(builder, _o.AsIMonsterComponent()).Value;
			case IComponentBase_Union.ICombatComponent:
				return ICombatComponent.Pack(builder, _o.AsICombatComponent()).Value;
			case IComponentBase_Union.IEntityListComponent:
				return IEntityListComponent.Pack(builder, _o.AsIEntityListComponent()).Value;
			case IComponentBase_Union.IAnimalComponent:
				return IAnimalComponent.Pack(builder, _o.AsIAnimalComponent()).Value;
			case IComponentBase_Union.ISceneItemMovementComponent:
				return ISceneItemMovementComponent.Pack(builder, _o.AsISceneItemMovementComponent()).Value;
			case IComponentBase_Union.IRangeComponent:
				return IRangeComponent.Pack(builder, _o.AsIRangeComponent()).Value;
			case IComponentBase_Union.IExtraRangeComponent:
				return IExtraRangeComponent.Pack(builder, _o.AsIExtraRangeComponent()).Value;
			case IComponentBase_Union.ITimelineTrackControlComponent:
				return ITimelineTrackControlComponent.Pack(builder, _o.AsITimelineTrackControlComponent()).Value;
			case IComponentBase_Union.ISplineComponent:
				return ISplineComponent.Pack(builder, _o.AsISplineComponent()).Value;
			case IComponentBase_Union.IAirWallSpawnerComponent:
				return IAirWallSpawnerComponent.Pack(builder, _o.AsIAirWallSpawnerComponent()).Value;
			case IComponentBase_Union.ISceneActorRefComponent:
				return ISceneActorRefComponent.Pack(builder, _o.AsISceneActorRefComponent()).Value;
			case IComponentBase_Union.ISceneBulletComponent:
				return ISceneBulletComponent.Pack(builder, _o.AsISceneBulletComponent()).Value;
			case IComponentBase_Union.ITurntableControlComponent:
				return ITurntableControlComponent.Pack(builder, _o.AsITurntableControlComponent()).Value;
			case IComponentBase_Union.IConditionListenerComponent:
				return IConditionListenerComponent.Pack(builder, _o.AsIConditionListenerComponent()).Value;
			case IComponentBase_Union.IAttachTargetComponent:
				return IAttachTargetComponent.Pack(builder, _o.AsIAttachTargetComponent()).Value;
			case IComponentBase_Union.IReboundComponent:
				return IReboundComponent.Pack(builder, _o.AsIReboundComponent()).Value;
			case IComponentBase_Union.IJigsawItem:
				return IJigsawItem.Pack(builder, _o.AsIJigsawItem()).Value;
			case IComponentBase_Union.IJigsawFoundation:
				return IJigsawFoundation.Pack(builder, _o.AsIJigsawFoundation()).Value;
			case IComponentBase_Union.ILevelAIComponent:
				return ILevelAIComponent.Pack(builder, _o.AsILevelAIComponent()).Value;
			case IComponentBase_Union.ILevitateMagnetComponent:
				return ILevitateMagnetComponent.Pack(builder, _o.AsILevitateMagnetComponent()).Value;
			case IComponentBase_Union.IPhotoTargetComponent:
				return IPhotoTargetComponent.Pack(builder, _o.AsIPhotoTargetComponent()).Value;
			case IComponentBase_Union.IAiAlertNotifyComponent:
				return IAiAlertNotifyComponent.Pack(builder, _o.AsIAiAlertNotifyComponent()).Value;
			case IComponentBase_Union.IMonsterGachaItemComponent:
				return IMonsterGachaItemComponent.Pack(builder, _o.AsIMonsterGachaItemComponent()).Value;
			case IComponentBase_Union.IMonsterGachaBaseComponent:
				return IMonsterGachaBaseComponent.Pack(builder, _o.AsIMonsterGachaBaseComponent()).Value;
			case IComponentBase_Union.IDynamicTeleportComponent:
				return IDynamicTeleportComponent.Pack(builder, _o.AsIDynamicTeleportComponent()).Value;
			case IComponentBase_Union.IExploreSkillInteractComponent:
				return IExploreSkillInteractComponent.Pack(builder, _o.AsIExploreSkillInteractComponent()).Value;
			case IComponentBase_Union.IExploreSkillInteractGroupComponent:
				return IExploreSkillInteractGroupComponent.Pack(builder, _o.AsIExploreSkillInteractGroupComponent()).Value;
			case IComponentBase_Union.IFanComponent:
				return IFanComponent.Pack(builder, _o.AsIFanComponent()).Value;
			case IComponentBase_Union.IPasserbyNpcSpawnComponent:
				return IPasserbyNpcSpawnComponent.Pack(builder, _o.AsIPasserbyNpcSpawnComponent()).Value;
			case IComponentBase_Union.IModelComponent:
				return IModelComponent.Pack(builder, _o.AsIModelComponent()).Value;
			case IComponentBase_Union.IEntityBundleComponent:
				return IEntityBundleComponent.Pack(builder, _o.AsIEntityBundleComponent()).Value;
			case IComponentBase_Union.IBeamCastComponent:
				return IBeamCastComponent.Pack(builder, _o.AsIBeamCastComponent()).Value;
			case IComponentBase_Union.IBeamReceiveComponent:
				return IBeamReceiveComponent.Pack(builder, _o.AsIBeamReceiveComponent()).Value;
			case IComponentBase_Union.ITimeStopComponent:
				return ITimeStopComponent.Pack(builder, _o.AsITimeStopComponent()).Value;
			case IComponentBase_Union.IPortalComponent:
				return IPortalComponent.Pack(builder, _o.AsIPortalComponent()).Value;
			case IComponentBase_Union.IDynamicPortalCreatorComponent:
				return IDynamicPortalCreatorComponent.Pack(builder, _o.AsIDynamicPortalCreatorComponent()).Value;
			case IComponentBase_Union.INoRenderPortalComponent:
				return INoRenderPortalComponent.Pack(builder, _o.AsINoRenderPortalComponent()).Value;
			case IComponentBase_Union.IEffectAreaComponent:
				return IEffectAreaComponent.Pack(builder, _o.AsIEffectAreaComponent()).Value;
			case IComponentBase_Union.IPhysicsConstraintComponent:
				return IPhysicsConstraintComponent.Pack(builder, _o.AsIPhysicsConstraintComponent()).Value;
			case IComponentBase_Union.IFollowDecorationComponent:
				return IFollowDecorationComponent.Pack(builder, _o.AsIFollowDecorationComponent()).Value;
			case IComponentBase_Union.IFollowShooterComponent:
				return IFollowShooterComponent.Pack(builder, _o.AsIFollowShooterComponent()).Value;
			case IComponentBase_Union.IConnectorComponent:
				return IConnectorComponent.Pack(builder, _o.AsIConnectorComponent()).Value;
			case IComponentBase_Union.ISceneTextComponent:
				return ISceneTextComponent.Pack(builder, _o.AsISceneTextComponent()).Value;
			case IComponentBase_Union.INavMeshComponent:
				return INavMeshComponent.Pack(builder, _o.AsINavMeshComponent()).Value;
			case IComponentBase_Union.ICharacterConnectorComponent:
				return ICharacterConnectorComponent.Pack(builder, _o.AsICharacterConnectorComponent()).Value;
			case IComponentBase_Union.IAiGearStrategyComponent:
				return IAiGearStrategyComponent.Pack(builder, _o.AsIAiGearStrategyComponent()).Value;
			case IComponentBase_Union.IPickInteractComponent:
				return IPickInteractComponent.Pack(builder, _o.AsIPickInteractComponent()).Value;
			case IComponentBase_Union.IChessmanComponent:
				return IChessmanComponent.Pack(builder, _o.AsIChessmanComponent()).Value;
			case IComponentBase_Union.IClientTriggerComponent:
				return IClientTriggerComponent.Pack(builder, _o.AsIClientTriggerComponent()).Value;
			case IComponentBase_Union.ILocationSafetyComponent:
				return ILocationSafetyComponent.Pack(builder, _o.AsILocationSafetyComponent()).Value;
			case IComponentBase_Union.IBatchBulletCasterComponent:
				return IBatchBulletCasterComponent.Pack(builder, _o.AsIBatchBulletCasterComponent()).Value;
			case IComponentBase_Union.IVehicleComponent:
				return IVehicleComponent.Pack(builder, _o.AsIVehicleComponent()).Value;
			case IComponentBase_Union.IEnrichmentAreaComponent:
				return IEnrichmentAreaComponent.Pack(builder, _o.AsIEnrichmentAreaComponent()).Value;
			case IComponentBase_Union.IMonitorComponent:
				return IMonitorComponent.Pack(builder, _o.AsIMonitorComponent()).Value;
			case IComponentBase_Union.IGroupAiComponent:
				return IGroupAiComponent.Pack(builder, _o.AsIGroupAiComponent()).Value;
			case IComponentBase_Union.IInhalationAbilityComponent:
				return IInhalationAbilityComponent.Pack(builder, _o.AsIInhalationAbilityComponent()).Value;
			case IComponentBase_Union.IInhaledItemComponent:
				return IInhaledItemComponent.Pack(builder, _o.AsIInhaledItemComponent()).Value;
			case IComponentBase_Union.IAirPassageComponent:
				return IAirPassageComponent.Pack(builder, _o.AsIAirPassageComponent()).Value;
			case IComponentBase_Union.IRenderSpecifiedRangeComponent:
				return IRenderSpecifiedRangeComponent.Pack(builder, _o.AsIRenderSpecifiedRangeComponent()).Value;
			case IComponentBase_Union.ILevelPrefabPerformComponent:
				return ILevelPrefabPerformComponent.Pack(builder, _o.AsILevelPrefabPerformComponent()).Value;
			case IComponentBase_Union.ISceneItemAiComponent:
				return ISceneItemAiComponent.Pack(builder, _o.AsISceneItemAiComponent()).Value;
			case IComponentBase_Union.IGravityFlipComponent:
				return IGravityFlipComponent.Pack(builder, _o.AsIGravityFlipComponent()).Value;
			case IComponentBase_Union.ILevelSequenceFrameEventComponent:
				return ILevelSequenceFrameEventComponent.Pack(builder, _o.AsILevelSequenceFrameEventComponent()).Value;
			case IComponentBase_Union.ILevelQteComponent:
				return ILevelQteComponent.Pack(builder, _o.AsILevelQteComponent()).Value;
			case IComponentBase_Union.IWalkingPatternComponent:
				return IWalkingPatternComponent.Pack(builder, _o.AsIWalkingPatternComponent()).Value;
			case IComponentBase_Union.ILifePointCenterComponent:
				return ILifePointCenterComponent.Pack(builder, _o.AsILifePointCenterComponent()).Value;
			case IComponentBase_Union.IHackManagementComponent:
				return IHackManagementComponent.Pack(builder, _o.AsIHackManagementComponent()).Value;
			case IComponentBase_Union.IClientConditionListenerComponent:
				return IClientConditionListenerComponent.Pack(builder, _o.AsIClientConditionListenerComponent()).Value;
			case IComponentBase_Union.ITemplateEntitySpawnerComponent:
				return ITemplateEntitySpawnerComponent.Pack(builder, _o.AsITemplateEntitySpawnerComponent()).Value;
			case IComponentBase_Union.IWindSourceComponent:
				return IWindSourceComponent.Pack(builder, _o.AsIWindSourceComponent()).Value;
			case IComponentBase_Union.ISlideRailComponent:
				return ISlideRailComponent.Pack(builder, _o.AsISlideRailComponent()).Value;
			case IComponentBase_Union.ISlidePerformComponent:
				return ISlidePerformComponent.Pack(builder, _o.AsISlidePerformComponent()).Value;
			case IComponentBase_Union.IRollBlockComponent:
				return IRollBlockComponent.Pack(builder, _o.AsIRollBlockComponent()).Value;
			case IComponentBase_Union.IRollBlockFloorComponent:
				return IRollBlockFloorComponent.Pack(builder, _o.AsIRollBlockFloorComponent()).Value;
			case IComponentBase_Union.IRollBlockItemComponent:
				return IRollBlockItemComponent.Pack(builder, _o.AsIRollBlockItemComponent()).Value;
			case IComponentBase_Union.ICurveControlComponent:
				return ICurveControlComponent.Pack(builder, _o.AsICurveControlComponent()).Value;
			case IComponentBase_Union.ISimpleCombatComponent:
				return ISimpleCombatComponent.Pack(builder, _o.AsISimpleCombatComponent()).Value;
			case IComponentBase_Union.IGridObjectComponent:
				return IGridObjectComponent.Pack(builder, _o.AsIGridObjectComponent()).Value;
			case IComponentBase_Union.IGodKingFrequencyControllerComponent:
				return IGodKingFrequencyControllerComponent.Pack(builder, _o.AsIGodKingFrequencyControllerComponent()).Value;
			case IComponentBase_Union.IPerformanceOptimizationComponent:
				return IPerformanceOptimizationComponent.Pack(builder, _o.AsIPerformanceOptimizationComponent()).Value;
			case IComponentBase_Union.ISceneItemEventListenerComponent:
				return ISceneItemEventListenerComponent.Pack(builder, _o.AsISceneItemEventListenerComponent()).Value;
			case IComponentBase_Union.IDynamicSpawnMonsterPointComponent:
				return IDynamicSpawnMonsterPointComponent.Pack(builder, _o.AsIDynamicSpawnMonsterPointComponent()).Value;
			case IComponentBase_Union.IDynamicSpawnMonsterComponent:
				return IDynamicSpawnMonsterComponent.Pack(builder, _o.AsIDynamicSpawnMonsterComponent()).Value;
			case IComponentBase_Union.ISunSpiritCollectComponent:
				return ISunSpiritCollectComponent.Pack(builder, _o.AsISunSpiritCollectComponent()).Value;
			case IComponentBase_Union.ISunSpiritLauncherComponent:
				return ISunSpiritLauncherComponent.Pack(builder, _o.AsISunSpiritLauncherComponent()).Value;
			case IComponentBase_Union.ISunSpiritGearComponent:
				return ISunSpiritGearComponent.Pack(builder, _o.AsISunSpiritGearComponent()).Value;
			case IComponentBase_Union.IMotorSlideComponent:
				return IMotorSlideComponent.Pack(builder, _o.AsIMotorSlideComponent()).Value;
			case IComponentBase_Union.IProceduralVisualComponent:
				return IProceduralVisualComponent.Pack(builder, _o.AsIProceduralVisualComponent()).Value;
			case IComponentBase_Union.IRoadNetworkNavigationComponent:
				return IRoadNetworkNavigationComponent.Pack(builder, _o.AsIRoadNetworkNavigationComponent()).Value;
			case IComponentBase_Union.IFurnitureSlotComponent:
				return IFurnitureSlotComponent.Pack(builder, _o.AsIFurnitureSlotComponent()).Value;
			case IComponentBase_Union.IVisionDisplayComponent:
				return IVisionDisplayComponent.Pack(builder, _o.AsIVisionDisplayComponent()).Value;
			case IComponentBase_Union.ISystemModuleDataSyncComponent:
				return ISystemModuleDataSyncComponent.Pack(builder, _o.AsISystemModuleDataSyncComponent()).Value;
			case IComponentBase_Union.IExhibitComponent:
				return IExhibitComponent.Pack(builder, _o.AsIExhibitComponent()).Value;
			case IComponentBase_Union.ITimeScheduleComponent:
				return ITimeScheduleComponent.Pack(builder, _o.AsITimeScheduleComponent()).Value;
			case IComponentBase_Union.IProjectorComponent:
				return IProjectorComponent.Pack(builder, _o.AsIProjectorComponent()).Value;
			case IComponentBase_Union.IProceduralMaterialComponent:
				return IProceduralMaterialComponent.Pack(builder, _o.AsIProceduralMaterialComponent()).Value;
			case IComponentBase_Union.IGameplayDataPersistenceComponent:
				return IGameplayDataPersistenceComponent.Pack(builder, _o.AsIGameplayDataPersistenceComponent()).Value;
			case IComponentBase_Union.IFlowerPollutionComponent:
				return IFlowerPollutionComponent.Pack(builder, _o.AsIFlowerPollutionComponent()).Value;
			case IComponentBase_Union.IQuickHackComponent:
				return IQuickHackComponent.Pack(builder, _o.AsIQuickHackComponent()).Value;
			case IComponentBase_Union.IDollGrabMachineComponent:
				return IDollGrabMachineComponent.Pack(builder, _o.AsIDollGrabMachineComponent()).Value;
			case IComponentBase_Union.IDollGrabShowcaseComponent:
				return IDollGrabShowcaseComponent.Pack(builder, _o.AsIDollGrabShowcaseComponent()).Value;
			case IComponentBase_Union.IWuWaGoComponent:
				return IWuWaGoComponent.Pack(builder, _o.AsIWuWaGoComponent()).Value;
			case IComponentBase_Union.IDragActorPlayComponent:
				return IDragActorPlayComponent.Pack(builder, _o.AsIDragActorPlayComponent()).Value;
			case IComponentBase_Union.IPathDrivenActorSpawnerComponent:
				return IPathDrivenActorSpawnerComponent.Pack(builder, _o.AsIPathDrivenActorSpawnerComponent()).Value;
			case IComponentBase_Union.IElementalHolderComponent:
				return IElementalHolderComponent.Pack(builder, _o.AsIElementalHolderComponent()).Value;
			case IComponentBase_Union.IElementalEffectComponent:
				return IElementalEffectComponent.Pack(builder, _o.AsIElementalEffectComponent()).Value;
			case IComponentBase_Union.IElementalBoxFoundationComponent:
				return IElementalBoxFoundationComponent.Pack(builder, _o.AsIElementalBoxFoundationComponent()).Value;
			case IComponentBase_Union.IElementalWellComponent:
				return IElementalWellComponent.Pack(builder, _o.AsIElementalWellComponent()).Value;
			case IComponentBase_Union.IStreamingSourceTriggerPointComponent:
				return IStreamingSourceTriggerPointComponent.Pack(builder, _o.AsIStreamingSourceTriggerPointComponent()).Value;
			case IComponentBase_Union.IGraph3dComponent:
				return IGraph3dComponent.Pack(builder, _o.AsIGraph3dComponent()).Value;
			case IComponentBase_Union.IGraph3dEffectComponent:
				return IGraph3dEffectComponent.Pack(builder, _o.AsIGraph3dEffectComponent()).Value;
			case IComponentBase_Union.INoiseRemovalComponent:
				return INoiseRemovalComponent.Pack(builder, _o.AsINoiseRemovalComponent()).Value;
			case IComponentBase_Union.IFrequencyPaintComponent:
				return IFrequencyPaintComponent.Pack(builder, _o.AsIFrequencyPaintComponent()).Value;
			case IComponentBase_Union.ITurntableConnectorComponent:
				return ITurntableConnectorComponent.Pack(builder, _o.AsITurntableConnectorComponent()).Value;
			default:
				return 0;
			}
		}
	}
}
