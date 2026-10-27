using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FDD RID: 20445
	public class IComponentBase_UnionUnion
	{
		// Token: 0x17009421 RID: 37921
		// (get) Token: 0x06020919 RID: 133401 RVA: 0x004876AE File Offset: 0x004858AE
		// (set) Token: 0x0602091A RID: 133402 RVA: 0x004876B6 File Offset: 0x004858B6
		public IComponentBase_Union Type { get; set; }

		// Token: 0x17009422 RID: 37922
		// (get) Token: 0x0602091B RID: 133403 RVA: 0x004876BF File Offset: 0x004858BF
		// (set) Token: 0x0602091C RID: 133404 RVA: 0x004876C7 File Offset: 0x004858C7
		public object Value { get; set; }

		// Token: 0x0602091D RID: 133405 RVA: 0x004876D0 File Offset: 0x004858D0
		public IComponentBase_UnionUnion()
		{
			this.Type = IComponentBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602091E RID: 133406 RVA: 0x004876E6 File Offset: 0x004858E6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602091F RID: 133407 RVA: 0x004876F8 File Offset: 0x004858F8
		public IComponentBaseT AsIComponentBase()
		{
			return this.As<IComponentBaseT>();
		}

		// Token: 0x06020920 RID: 133408 RVA: 0x00487700 File Offset: 0x00485900
		public static IComponentBase_UnionUnion FromIComponentBase(IComponentBaseT _icomponentbase)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IComponentBase,
				Value = _icomponentbase
			};
		}

		// Token: 0x06020921 RID: 133409 RVA: 0x00487715 File Offset: 0x00485915
		public IUnUseComponentT AsIUnUseComponent()
		{
			return this.As<IUnUseComponentT>();
		}

		// Token: 0x06020922 RID: 133410 RVA: 0x0048771D File Offset: 0x0048591D
		public static IComponentBase_UnionUnion FromIUnUseComponent(IUnUseComponentT _iunusecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IUnUseComponent,
				Value = _iunusecomponent
			};
		}

		// Token: 0x06020923 RID: 133411 RVA: 0x00487732 File Offset: 0x00485932
		public IInteractiveComponentT AsIInteractiveComponent()
		{
			return this.As<IInteractiveComponentT>();
		}

		// Token: 0x06020924 RID: 133412 RVA: 0x0048773A File Offset: 0x0048593A
		public static IComponentBase_UnionUnion FromIInteractiveComponent(IInteractiveComponentT _iinteractivecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInteractiveComponent,
				Value = _iinteractivecomponent
			};
		}

		// Token: 0x06020925 RID: 133413 RVA: 0x0048774F File Offset: 0x0048594F
		public ISwitcherComponentT AsISwitcherComponent()
		{
			return this.As<ISwitcherComponentT>();
		}

		// Token: 0x06020926 RID: 133414 RVA: 0x00487757 File Offset: 0x00485957
		public static IComponentBase_UnionUnion FromISwitcherComponent(ISwitcherComponentT _iswitchercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISwitcherComponent,
				Value = _iswitchercomponent
			};
		}

		// Token: 0x06020927 RID: 133415 RVA: 0x0048776C File Offset: 0x0048596C
		public IRotatorComponentT AsIRotatorComponent()
		{
			return this.As<IRotatorComponentT>();
		}

		// Token: 0x06020928 RID: 133416 RVA: 0x00487774 File Offset: 0x00485974
		public static IComponentBase_UnionUnion FromIRotatorComponent(IRotatorComponentT _irotatorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRotatorComponent,
				Value = _irotatorcomponent
			};
		}

		// Token: 0x06020929 RID: 133417 RVA: 0x00487789 File Offset: 0x00485989
		public IBehaviorFlowComponentT AsIBehaviorFlowComponent()
		{
			return this.As<IBehaviorFlowComponentT>();
		}

		// Token: 0x0602092A RID: 133418 RVA: 0x00487791 File Offset: 0x00485991
		public static IComponentBase_UnionUnion FromIBehaviorFlowComponent(IBehaviorFlowComponentT _ibehaviorflowcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBehaviorFlowComponent,
				Value = _ibehaviorflowcomponent
			};
		}

		// Token: 0x0602092B RID: 133419 RVA: 0x004877A6 File Offset: 0x004859A6
		public IFlowComponentT AsIFlowComponent()
		{
			return this.As<IFlowComponentT>();
		}

		// Token: 0x0602092C RID: 133420 RVA: 0x004877AE File Offset: 0x004859AE
		public static IComponentBase_UnionUnion FromIFlowComponent(IFlowComponentT _iflowcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFlowComponent,
				Value = _iflowcomponent
			};
		}

		// Token: 0x0602092D RID: 133421 RVA: 0x004877C3 File Offset: 0x004859C3
		public ITriggerUe5ComponentT AsITriggerUe5Component()
		{
			return this.As<ITriggerUe5ComponentT>();
		}

		// Token: 0x0602092E RID: 133422 RVA: 0x004877CB File Offset: 0x004859CB
		public static IComponentBase_UnionUnion FromITriggerUe5Component(ITriggerUe5ComponentT _itriggerue5component)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITriggerUe5Component,
				Value = _itriggerue5component
			};
		}

		// Token: 0x0602092F RID: 133423 RVA: 0x004877E0 File Offset: 0x004859E0
		public IMoveComponentT AsIMoveComponent()
		{
			return this.As<IMoveComponentT>();
		}

		// Token: 0x06020930 RID: 133424 RVA: 0x004877E8 File Offset: 0x004859E8
		public static IComponentBase_UnionUnion FromIMoveComponent(IMoveComponentT _imovecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMoveComponent,
				Value = _imovecomponent
			};
		}

		// Token: 0x06020931 RID: 133425 RVA: 0x004877FE File Offset: 0x004859FE
		public IActorStateComponentT AsIActorStateComponent()
		{
			return this.As<IActorStateComponentT>();
		}

		// Token: 0x06020932 RID: 133426 RVA: 0x00487806 File Offset: 0x00485A06
		public static IComponentBase_UnionUnion FromIActorStateComponent(IActorStateComponentT _iactorstatecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IActorStateComponent,
				Value = _iactorstatecomponent
			};
		}

		// Token: 0x06020933 RID: 133427 RVA: 0x0048781C File Offset: 0x00485A1C
		public ICalculateComponentT AsICalculateComponent()
		{
			return this.As<ICalculateComponentT>();
		}

		// Token: 0x06020934 RID: 133428 RVA: 0x00487824 File Offset: 0x00485A24
		public static IComponentBase_UnionUnion FromICalculateComponent(ICalculateComponentT _icalculatecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICalculateComponent,
				Value = _icalculatecomponent
			};
		}

		// Token: 0x06020935 RID: 133429 RVA: 0x0048783A File Offset: 0x00485A3A
		public IRefreshGroupT AsIRefreshGroup()
		{
			return this.As<IRefreshGroupT>();
		}

		// Token: 0x06020936 RID: 133430 RVA: 0x00487842 File Offset: 0x00485A42
		public static IComponentBase_UnionUnion FromIRefreshGroup(IRefreshGroupT _irefreshgroup)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRefreshGroup,
				Value = _irefreshgroup
			};
		}

		// Token: 0x06020937 RID: 133431 RVA: 0x00487858 File Offset: 0x00485A58
		public IRefreshSingleComponentT AsIRefreshSingleComponent()
		{
			return this.As<IRefreshSingleComponentT>();
		}

		// Token: 0x06020938 RID: 133432 RVA: 0x00487860 File Offset: 0x00485A60
		public static IComponentBase_UnionUnion FromIRefreshSingleComponent(IRefreshSingleComponentT _irefreshsinglecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRefreshSingleComponent,
				Value = _irefreshsinglecomponent
			};
		}

		// Token: 0x06020939 RID: 133433 RVA: 0x00487876 File Offset: 0x00485A76
		public IRotatorComponent2T AsIRotatorComponent2()
		{
			return this.As<IRotatorComponent2T>();
		}

		// Token: 0x0602093A RID: 133434 RVA: 0x0048787E File Offset: 0x00485A7E
		public static IComponentBase_UnionUnion FromIRotatorComponent2(IRotatorComponent2T _irotatorcomponent2)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRotatorComponent2,
				Value = _irotatorcomponent2
			};
		}

		// Token: 0x0602093B RID: 133435 RVA: 0x00487894 File Offset: 0x00485A94
		public ISphereFactoryComponentT AsISphereFactoryComponent()
		{
			return this.As<ISphereFactoryComponentT>();
		}

		// Token: 0x0602093C RID: 133436 RVA: 0x0048789C File Offset: 0x00485A9C
		public static IComponentBase_UnionUnion FromISphereFactoryComponent(ISphereFactoryComponentT _ispherefactorycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISphereFactoryComponent,
				Value = _ispherefactorycomponent
			};
		}

		// Token: 0x0602093D RID: 133437 RVA: 0x004878B2 File Offset: 0x00485AB2
		public ISpringComponentT AsISpringComponent()
		{
			return this.As<ISpringComponentT>();
		}

		// Token: 0x0602093E RID: 133438 RVA: 0x004878BA File Offset: 0x00485ABA
		public static IComponentBase_UnionUnion FromISpringComponent(ISpringComponentT _ispringcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISpringComponent,
				Value = _ispringcomponent
			};
		}

		// Token: 0x0602093F RID: 133439 RVA: 0x004878D0 File Offset: 0x00485AD0
		public ITrampleUe5ComponentT AsITrampleUe5Component()
		{
			return this.As<ITrampleUe5ComponentT>();
		}

		// Token: 0x06020940 RID: 133440 RVA: 0x004878D8 File Offset: 0x00485AD8
		public static IComponentBase_UnionUnion FromITrampleUe5Component(ITrampleUe5ComponentT _itrampleue5component)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITrampleUe5Component,
				Value = _itrampleue5component
			};
		}

		// Token: 0x06020941 RID: 133441 RVA: 0x004878EE File Offset: 0x00485AEE
		public IUndergroundComponentT AsIUndergroundComponent()
		{
			return this.As<IUndergroundComponentT>();
		}

		// Token: 0x06020942 RID: 133442 RVA: 0x004878F6 File Offset: 0x00485AF6
		public static IComponentBase_UnionUnion FromIUndergroundComponent(IUndergroundComponentT _iundergroundcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IUndergroundComponent,
				Value = _iundergroundcomponent
			};
		}

		// Token: 0x06020943 RID: 133443 RVA: 0x0048790C File Offset: 0x00485B0C
		public IGrabComponentT AsIGrabComponent()
		{
			return this.As<IGrabComponentT>();
		}

		// Token: 0x06020944 RID: 133444 RVA: 0x00487914 File Offset: 0x00485B14
		public static IComponentBase_UnionUnion FromIGrabComponent(IGrabComponentT _igrabcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGrabComponent,
				Value = _igrabcomponent
			};
		}

		// Token: 0x06020945 RID: 133445 RVA: 0x0048792A File Offset: 0x00485B2A
		public IInteractComponentT AsIInteractComponent()
		{
			return this.As<IInteractComponentT>();
		}

		// Token: 0x06020946 RID: 133446 RVA: 0x00487932 File Offset: 0x00485B32
		public static IComponentBase_UnionUnion FromIInteractComponent(IInteractComponentT _iinteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInteractComponent,
				Value = _iinteractcomponent
			};
		}

		// Token: 0x06020947 RID: 133447 RVA: 0x00487948 File Offset: 0x00485B48
		public IVarComponentT AsIVarComponent()
		{
			return this.As<IVarComponentT>();
		}

		// Token: 0x06020948 RID: 133448 RVA: 0x00487950 File Offset: 0x00485B50
		public static IComponentBase_UnionUnion FromIVarComponent(IVarComponentT _ivarcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVarComponent,
				Value = _ivarcomponent
			};
		}

		// Token: 0x06020949 RID: 133449 RVA: 0x00487966 File Offset: 0x00485B66
		public IPatrolT AsIPatrol()
		{
			return this.As<IPatrolT>();
		}

		// Token: 0x0602094A RID: 133450 RVA: 0x0048796E File Offset: 0x00485B6E
		public static IComponentBase_UnionUnion FromIPatrol(IPatrolT _ipatrol)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPatrol,
				Value = _ipatrol
			};
		}

		// Token: 0x0602094B RID: 133451 RVA: 0x00487984 File Offset: 0x00485B84
		public IAiComponentT AsIAiComponent()
		{
			return this.As<IAiComponentT>();
		}

		// Token: 0x0602094C RID: 133452 RVA: 0x0048798C File Offset: 0x00485B8C
		public static IComponentBase_UnionUnion FromIAiComponent(IAiComponentT _iaicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAiComponent,
				Value = _iaicomponent
			};
		}

		// Token: 0x0602094D RID: 133453 RVA: 0x004879A2 File Offset: 0x00485BA2
		public IAttributeComponentT AsIAttributeComponent()
		{
			return this.As<IAttributeComponentT>();
		}

		// Token: 0x0602094E RID: 133454 RVA: 0x004879AA File Offset: 0x00485BAA
		public static IComponentBase_UnionUnion FromIAttributeComponent(IAttributeComponentT _iattributecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAttributeComponent,
				Value = _iattributecomponent
			};
		}

		// Token: 0x0602094F RID: 133455 RVA: 0x004879C0 File Offset: 0x00485BC0
		public IEditCustomAoiComponentT AsIEditCustomAoiComponent()
		{
			return this.As<IEditCustomAoiComponentT>();
		}

		// Token: 0x06020950 RID: 133456 RVA: 0x004879C8 File Offset: 0x00485BC8
		public static IComponentBase_UnionUnion FromIEditCustomAoiComponent(IEditCustomAoiComponentT _ieditcustomaoicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEditCustomAoiComponent,
				Value = _ieditcustomaoicomponent
			};
		}

		// Token: 0x06020951 RID: 133457 RVA: 0x004879DE File Offset: 0x00485BDE
		public IBaseInfoComponentT AsIBaseInfoComponent()
		{
			return this.As<IBaseInfoComponentT>();
		}

		// Token: 0x06020952 RID: 133458 RVA: 0x004879E6 File Offset: 0x00485BE6
		public static IComponentBase_UnionUnion FromIBaseInfoComponent(IBaseInfoComponentT _ibaseinfocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBaseInfoComponent,
				Value = _ibaseinfocomponent
			};
		}

		// Token: 0x06020953 RID: 133459 RVA: 0x004879FC File Offset: 0x00485BFC
		public IRewardComponentT AsIRewardComponent()
		{
			return this.As<IRewardComponentT>();
		}

		// Token: 0x06020954 RID: 133460 RVA: 0x00487A04 File Offset: 0x00485C04
		public static IComponentBase_UnionUnion FromIRewardComponent(IRewardComponentT _irewardcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRewardComponent,
				Value = _irewardcomponent
			};
		}

		// Token: 0x06020955 RID: 133461 RVA: 0x00487A1A File Offset: 0x00485C1A
		public IDynamicEntityRewardComponentT AsIDynamicEntityRewardComponent()
		{
			return this.As<IDynamicEntityRewardComponentT>();
		}

		// Token: 0x06020956 RID: 133462 RVA: 0x00487A22 File Offset: 0x00485C22
		public static IComponentBase_UnionUnion FromIDynamicEntityRewardComponent(IDynamicEntityRewardComponentT _idynamicentityrewardcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicEntityRewardComponent,
				Value = _idynamicentityrewardcomponent
			};
		}

		// Token: 0x06020957 RID: 133463 RVA: 0x00487A38 File Offset: 0x00485C38
		public IIndependentSystemRewardComponentT AsIIndependentSystemRewardComponent()
		{
			return this.As<IIndependentSystemRewardComponentT>();
		}

		// Token: 0x06020958 RID: 133464 RVA: 0x00487A40 File Offset: 0x00485C40
		public static IComponentBase_UnionUnion FromIIndependentSystemRewardComponent(IIndependentSystemRewardComponentT _iindependentsystemrewardcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IIndependentSystemRewardComponent,
				Value = _iindependentsystemrewardcomponent
			};
		}

		// Token: 0x06020959 RID: 133465 RVA: 0x00487A56 File Offset: 0x00485C56
		public IRefreshComponentT AsIRefreshComponent()
		{
			return this.As<IRefreshComponentT>();
		}

		// Token: 0x0602095A RID: 133466 RVA: 0x00487A5E File Offset: 0x00485C5E
		public static IComponentBase_UnionUnion FromIRefreshComponent(IRefreshComponentT _irefreshcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRefreshComponent,
				Value = _irefreshcomponent
			};
		}

		// Token: 0x0602095B RID: 133467 RVA: 0x00487A74 File Offset: 0x00485C74
		public IRefreshGroupComponentT AsIRefreshGroupComponent()
		{
			return this.As<IRefreshGroupComponentT>();
		}

		// Token: 0x0602095C RID: 133468 RVA: 0x00487A7C File Offset: 0x00485C7C
		public static IComponentBase_UnionUnion FromIRefreshGroupComponent(IRefreshGroupComponentT _irefreshgroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRefreshGroupComponent,
				Value = _irefreshgroupcomponent
			};
		}

		// Token: 0x0602095D RID: 133469 RVA: 0x00487A92 File Offset: 0x00485C92
		public IEntityBatchRefreshComponentT AsIEntityBatchRefreshComponent()
		{
			return this.As<IEntityBatchRefreshComponentT>();
		}

		// Token: 0x0602095E RID: 133470 RVA: 0x00487A9A File Offset: 0x00485C9A
		public static IComponentBase_UnionUnion FromIEntityBatchRefreshComponent(IEntityBatchRefreshComponentT _ientitybatchrefreshcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityBatchRefreshComponent,
				Value = _ientitybatchrefreshcomponent
			};
		}

		// Token: 0x0602095F RID: 133471 RVA: 0x00487AB0 File Offset: 0x00485CB0
		public ITreasureBoxComponentT AsITreasureBoxComponent()
		{
			return this.As<ITreasureBoxComponentT>();
		}

		// Token: 0x06020960 RID: 133472 RVA: 0x00487AB8 File Offset: 0x00485CB8
		public static IComponentBase_UnionUnion FromITreasureBoxComponent(ITreasureBoxComponentT _itreasureboxcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITreasureBoxComponent,
				Value = _itreasureboxcomponent
			};
		}

		// Token: 0x06020961 RID: 133473 RVA: 0x00487ACE File Offset: 0x00485CCE
		public ITriggerComponentT AsITriggerComponent()
		{
			return this.As<ITriggerComponentT>();
		}

		// Token: 0x06020962 RID: 133474 RVA: 0x00487AD6 File Offset: 0x00485CD6
		public static IComponentBase_UnionUnion FromITriggerComponent(ITriggerComponentT _itriggercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITriggerComponent,
				Value = _itriggercomponent
			};
		}

		// Token: 0x06020963 RID: 133475 RVA: 0x00487AEC File Offset: 0x00485CEC
		public IEntityStateComponentT AsIEntityStateComponent()
		{
			return this.As<IEntityStateComponentT>();
		}

		// Token: 0x06020964 RID: 133476 RVA: 0x00487AF4 File Offset: 0x00485CF4
		public static IComponentBase_UnionUnion FromIEntityStateComponent(IEntityStateComponentT _ientitystatecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityStateComponent,
				Value = _ientitystatecomponent
			};
		}

		// Token: 0x06020965 RID: 133477 RVA: 0x00487B0A File Offset: 0x00485D0A
		public ISceneItemAttributeComponentT AsISceneItemAttributeComponent()
		{
			return this.As<ISceneItemAttributeComponentT>();
		}

		// Token: 0x06020966 RID: 133478 RVA: 0x00487B12 File Offset: 0x00485D12
		public static IComponentBase_UnionUnion FromISceneItemAttributeComponent(ISceneItemAttributeComponentT _isceneitemattributecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemAttributeComponent,
				Value = _isceneitemattributecomponent
			};
		}

		// Token: 0x06020967 RID: 133479 RVA: 0x00487B28 File Offset: 0x00485D28
		public IEntityAudioComponentT AsIEntityAudioComponent()
		{
			return this.As<IEntityAudioComponentT>();
		}

		// Token: 0x06020968 RID: 133480 RVA: 0x00487B30 File Offset: 0x00485D30
		public static IComponentBase_UnionUnion FromIEntityAudioComponent(IEntityAudioComponentT _ientityaudiocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityAudioComponent,
				Value = _ientityaudiocomponent
			};
		}

		// Token: 0x06020969 RID: 133481 RVA: 0x00487B46 File Offset: 0x00485D46
		public IEntityStateAudioComponentT AsIEntityStateAudioComponent()
		{
			return this.As<IEntityStateAudioComponentT>();
		}

		// Token: 0x0602096A RID: 133482 RVA: 0x00487B4E File Offset: 0x00485D4E
		public static IComponentBase_UnionUnion FromIEntityStateAudioComponent(IEntityStateAudioComponentT _ientitystateaudiocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityStateAudioComponent,
				Value = _ientitystateaudiocomponent
			};
		}

		// Token: 0x0602096B RID: 133483 RVA: 0x00487B64 File Offset: 0x00485D64
		public IEntityCustomAudioComponentT AsIEntityCustomAudioComponent()
		{
			return this.As<IEntityCustomAudioComponentT>();
		}

		// Token: 0x0602096C RID: 133484 RVA: 0x00487B6C File Offset: 0x00485D6C
		public static IComponentBase_UnionUnion FromIEntityCustomAudioComponent(IEntityCustomAudioComponentT _ientitycustomaudiocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityCustomAudioComponent,
				Value = _ientitycustomaudiocomponent
			};
		}

		// Token: 0x0602096D RID: 133485 RVA: 0x00487B82 File Offset: 0x00485D82
		public ITrampleComponentT AsITrampleComponent()
		{
			return this.As<ITrampleComponentT>();
		}

		// Token: 0x0602096E RID: 133486 RVA: 0x00487B8A File Offset: 0x00485D8A
		public static IComponentBase_UnionUnion FromITrampleComponent(ITrampleComponentT _itramplecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITrampleComponent,
				Value = _itramplecomponent
			};
		}

		// Token: 0x0602096F RID: 133487 RVA: 0x00487BA0 File Offset: 0x00485DA0
		public IEntityGroupComponentT AsIEntityGroupComponent()
		{
			return this.As<IEntityGroupComponentT>();
		}

		// Token: 0x06020970 RID: 133488 RVA: 0x00487BA8 File Offset: 0x00485DA8
		public static IComponentBase_UnionUnion FromIEntityGroupComponent(IEntityGroupComponentT _ientitygroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityGroupComponent,
				Value = _ientitygroupcomponent
			};
		}

		// Token: 0x06020971 RID: 133489 RVA: 0x00487BBE File Offset: 0x00485DBE
		public IHookLockPointT AsIHookLockPoint()
		{
			return this.As<IHookLockPointT>();
		}

		// Token: 0x06020972 RID: 133490 RVA: 0x00487BC6 File Offset: 0x00485DC6
		public static IComponentBase_UnionUnion FromIHookLockPoint(IHookLockPointT _ihooklockpoint)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHookLockPoint,
				Value = _ihooklockpoint
			};
		}

		// Token: 0x06020973 RID: 133491 RVA: 0x00487BDC File Offset: 0x00485DDC
		public IRoleMotionInteractComponentT AsIRoleMotionInteractComponent()
		{
			return this.As<IRoleMotionInteractComponentT>();
		}

		// Token: 0x06020974 RID: 133492 RVA: 0x00487BE4 File Offset: 0x00485DE4
		public static IComponentBase_UnionUnion FromIRoleMotionInteractComponent(IRoleMotionInteractComponentT _irolemotioninteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRoleMotionInteractComponent,
				Value = _irolemotioninteractcomponent
			};
		}

		// Token: 0x06020975 RID: 133493 RVA: 0x00487BFA File Offset: 0x00485DFA
		public IHookFetchComponentT AsIHookFetchComponent()
		{
			return this.As<IHookFetchComponentT>();
		}

		// Token: 0x06020976 RID: 133494 RVA: 0x00487C02 File Offset: 0x00485E02
		public static IComponentBase_UnionUnion FromIHookFetchComponent(IHookFetchComponentT _ihookfetchcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHookFetchComponent,
				Value = _ihookfetchcomponent
			};
		}

		// Token: 0x06020977 RID: 133495 RVA: 0x00487C18 File Offset: 0x00485E18
		public IItemFoundationT AsIItemFoundation()
		{
			return this.As<IItemFoundationT>();
		}

		// Token: 0x06020978 RID: 133496 RVA: 0x00487C20 File Offset: 0x00485E20
		public static IComponentBase_UnionUnion FromIItemFoundation(IItemFoundationT _iitemfoundation)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IItemFoundation,
				Value = _iitemfoundation
			};
		}

		// Token: 0x06020979 RID: 133497 RVA: 0x00487C36 File Offset: 0x00485E36
		public IResetEntitiesPosComponentT AsIResetEntitiesPosComponent()
		{
			return this.As<IResetEntitiesPosComponentT>();
		}

		// Token: 0x0602097A RID: 133498 RVA: 0x00487C3E File Offset: 0x00485E3E
		public static IComponentBase_UnionUnion FromIResetEntitiesPosComponent(IResetEntitiesPosComponentT _iresetentitiesposcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IResetEntitiesPosComponent,
				Value = _iresetentitiesposcomponent
			};
		}

		// Token: 0x0602097B RID: 133499 RVA: 0x00487C54 File Offset: 0x00485E54
		public IResetSelfPosComponentT AsIResetSelfPosComponent()
		{
			return this.As<IResetSelfPosComponentT>();
		}

		// Token: 0x0602097C RID: 133500 RVA: 0x00487C5C File Offset: 0x00485E5C
		public static IComponentBase_UnionUnion FromIResetSelfPosComponent(IResetSelfPosComponentT _iresetselfposcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IResetSelfPosComponent,
				Value = _iresetselfposcomponent
			};
		}

		// Token: 0x0602097D RID: 133501 RVA: 0x00487C72 File Offset: 0x00485E72
		public ICollectComponentT AsICollectComponent()
		{
			return this.As<ICollectComponentT>();
		}

		// Token: 0x0602097E RID: 133502 RVA: 0x00487C7A File Offset: 0x00485E7A
		public static IComponentBase_UnionUnion FromICollectComponent(ICollectComponentT _icollectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICollectComponent,
				Value = _icollectcomponent
			};
		}

		// Token: 0x0602097F RID: 133503 RVA: 0x00487C90 File Offset: 0x00485E90
		public ITeleControl2T AsITeleControl2()
		{
			return this.As<ITeleControl2T>();
		}

		// Token: 0x06020980 RID: 133504 RVA: 0x00487C98 File Offset: 0x00485E98
		public static IComponentBase_UnionUnion FromITeleControl2(ITeleControl2T _itelecontrol2)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITeleControl2,
				Value = _itelecontrol2
			};
		}

		// Token: 0x06020981 RID: 133505 RVA: 0x00487CAE File Offset: 0x00485EAE
		public IItemFoundation2T AsIItemFoundation2()
		{
			return this.As<IItemFoundation2T>();
		}

		// Token: 0x06020982 RID: 133506 RVA: 0x00487CB6 File Offset: 0x00485EB6
		public static IComponentBase_UnionUnion FromIItemFoundation2(IItemFoundation2T _iitemfoundation2)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IItemFoundation2,
				Value = _iitemfoundation2
			};
		}

		// Token: 0x06020983 RID: 133507 RVA: 0x00487CCC File Offset: 0x00485ECC
		public IPullingFoundationT AsIPullingFoundation()
		{
			return this.As<IPullingFoundationT>();
		}

		// Token: 0x06020984 RID: 133508 RVA: 0x00487CD4 File Offset: 0x00485ED4
		public static IComponentBase_UnionUnion FromIPullingFoundation(IPullingFoundationT _ipullingfoundation)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPullingFoundation,
				Value = _ipullingfoundation
			};
		}

		// Token: 0x06020985 RID: 133509 RVA: 0x00487CEA File Offset: 0x00485EEA
		public ILevelPlayComponentT AsILevelPlayComponent()
		{
			return this.As<ILevelPlayComponentT>();
		}

		// Token: 0x06020986 RID: 133510 RVA: 0x00487CF2 File Offset: 0x00485EF2
		public static IComponentBase_UnionUnion FromILevelPlayComponent(ILevelPlayComponentT _ilevelplaycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelPlayComponent,
				Value = _ilevelplaycomponent
			};
		}

		// Token: 0x06020987 RID: 133511 RVA: 0x00487D08 File Offset: 0x00485F08
		public IDynamicLevelPlayComponentT AsIDynamicLevelPlayComponent()
		{
			return this.As<IDynamicLevelPlayComponentT>();
		}

		// Token: 0x06020988 RID: 133512 RVA: 0x00487D10 File Offset: 0x00485F10
		public static IComponentBase_UnionUnion FromIDynamicLevelPlayComponent(IDynamicLevelPlayComponentT _idynamiclevelplaycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicLevelPlayComponent,
				Value = _idynamiclevelplaycomponent
			};
		}

		// Token: 0x06020989 RID: 133513 RVA: 0x00487D26 File Offset: 0x00485F26
		public IVisionComponentT AsIVisionComponent()
		{
			return this.As<IVisionComponentT>();
		}

		// Token: 0x0602098A RID: 133514 RVA: 0x00487D2E File Offset: 0x00485F2E
		public static IComponentBase_UnionUnion FromIVisionComponent(IVisionComponentT _ivisioncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVisionComponent,
				Value = _ivisioncomponent
			};
		}

		// Token: 0x0602098B RID: 133515 RVA: 0x00487D44 File Offset: 0x00485F44
		public IVisionCaptureComponentT AsIVisionCaptureComponent()
		{
			return this.As<IVisionCaptureComponentT>();
		}

		// Token: 0x0602098C RID: 133516 RVA: 0x00487D4C File Offset: 0x00485F4C
		public static IComponentBase_UnionUnion FromIVisionCaptureComponent(IVisionCaptureComponentT _ivisioncapturecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVisionCaptureComponent,
				Value = _ivisioncapturecomponent
			};
		}

		// Token: 0x0602098D RID: 133517 RVA: 0x00487D62 File Offset: 0x00485F62
		public IAdsorbComponentT AsIAdsorbComponent()
		{
			return this.As<IAdsorbComponentT>();
		}

		// Token: 0x0602098E RID: 133518 RVA: 0x00487D6A File Offset: 0x00485F6A
		public static IComponentBase_UnionUnion FromIAdsorbComponent(IAdsorbComponentT _iadsorbcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAdsorbComponent,
				Value = _iadsorbcomponent
			};
		}

		// Token: 0x0602098F RID: 133519 RVA: 0x00487D80 File Offset: 0x00485F80
		public ITeleportComponentT AsITeleportComponent()
		{
			return this.As<ITeleportComponentT>();
		}

		// Token: 0x06020990 RID: 133520 RVA: 0x00487D88 File Offset: 0x00485F88
		public static IComponentBase_UnionUnion FromITeleportComponent(ITeleportComponentT _iteleportcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITeleportComponent,
				Value = _iteleportcomponent
			};
		}

		// Token: 0x06020991 RID: 133521 RVA: 0x00487D9E File Offset: 0x00485F9E
		public ISpawnMonsterComponentT AsISpawnMonsterComponent()
		{
			return this.As<ISpawnMonsterComponentT>();
		}

		// Token: 0x06020992 RID: 133522 RVA: 0x00487DA6 File Offset: 0x00485FA6
		public static IComponentBase_UnionUnion FromISpawnMonsterComponent(ISpawnMonsterComponentT _ispawnmonstercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISpawnMonsterComponent,
				Value = _ispawnmonstercomponent
			};
		}

		// Token: 0x06020993 RID: 133523 RVA: 0x00487DBC File Offset: 0x00485FBC
		public IHitComponentBaseT AsIHitComponentBase()
		{
			return this.As<IHitComponentBaseT>();
		}

		// Token: 0x06020994 RID: 133524 RVA: 0x00487DC4 File Offset: 0x00485FC4
		public static IComponentBase_UnionUnion FromIHitComponentBase(IHitComponentBaseT _ihitcomponentbase)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHitComponentBase,
				Value = _ihitcomponentbase
			};
		}

		// Token: 0x06020995 RID: 133525 RVA: 0x00487DDA File Offset: 0x00485FDA
		public IDestructibleItemT AsIDestructibleItem()
		{
			return this.As<IDestructibleItemT>();
		}

		// Token: 0x06020996 RID: 133526 RVA: 0x00487DE2 File Offset: 0x00485FE2
		public static IComponentBase_UnionUnion FromIDestructibleItem(IDestructibleItemT _idestructibleitem)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDestructibleItem,
				Value = _idestructibleitem
			};
		}

		// Token: 0x06020997 RID: 133527 RVA: 0x00487DF8 File Offset: 0x00485FF8
		public ITargetGearComponentT AsITargetGearComponent()
		{
			return this.As<ITargetGearComponentT>();
		}

		// Token: 0x06020998 RID: 133528 RVA: 0x00487E00 File Offset: 0x00486000
		public static IComponentBase_UnionUnion FromITargetGearComponent(ITargetGearComponentT _itargetgearcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITargetGearComponent,
				Value = _itargetgearcomponent
			};
		}

		// Token: 0x06020999 RID: 133529 RVA: 0x00487E16 File Offset: 0x00486016
		public IProgressBarControlComponentT AsIProgressBarControlComponent()
		{
			return this.As<IProgressBarControlComponentT>();
		}

		// Token: 0x0602099A RID: 133530 RVA: 0x00487E1E File Offset: 0x0048601E
		public static IComponentBase_UnionUnion FromIProgressBarControlComponent(IProgressBarControlComponentT _iprogressbarcontrolcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IProgressBarControlComponent,
				Value = _iprogressbarcontrolcomponent
			};
		}

		// Token: 0x0602099B RID: 133531 RVA: 0x00487E34 File Offset: 0x00486034
		public IHitComponentT AsIHitComponent()
		{
			return this.As<IHitComponentT>();
		}

		// Token: 0x0602099C RID: 133532 RVA: 0x00487E3C File Offset: 0x0048603C
		public static IComponentBase_UnionUnion FromIHitComponent(IHitComponentT _ihitcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHitComponent,
				Value = _ihitcomponent
			};
		}

		// Token: 0x0602099D RID: 133533 RVA: 0x00487E52 File Offset: 0x00486052
		public ITargetGearGroupComponentT AsITargetGearGroupComponent()
		{
			return this.As<ITargetGearGroupComponentT>();
		}

		// Token: 0x0602099E RID: 133534 RVA: 0x00487E5A File Offset: 0x0048605A
		public static IComponentBase_UnionUnion FromITargetGearGroupComponent(ITargetGearGroupComponentT _itargetgeargroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITargetGearGroupComponent,
				Value = _itargetgeargroupcomponent
			};
		}

		// Token: 0x0602099F RID: 133535 RVA: 0x00487E70 File Offset: 0x00486070
		public INpcPerformComponentT AsINpcPerformComponent()
		{
			return this.As<INpcPerformComponentT>();
		}

		// Token: 0x060209A0 RID: 133536 RVA: 0x00487E78 File Offset: 0x00486078
		public static IComponentBase_UnionUnion FromINpcPerformComponent(INpcPerformComponentT _inpcperformcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INpcPerformComponent,
				Value = _inpcperformcomponent
			};
		}

		// Token: 0x060209A1 RID: 133537 RVA: 0x00487E8E File Offset: 0x0048608E
		public IInteractGearComponentT AsIInteractGearComponent()
		{
			return this.As<IInteractGearComponentT>();
		}

		// Token: 0x060209A2 RID: 133538 RVA: 0x00487E96 File Offset: 0x00486096
		public static IComponentBase_UnionUnion FromIInteractGearComponent(IInteractGearComponentT _iinteractgearcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInteractGearComponent,
				Value = _iinteractgearcomponent
			};
		}

		// Token: 0x060209A3 RID: 133539 RVA: 0x00487EAC File Offset: 0x004860AC
		public ILiftComponentT AsILiftComponent()
		{
			return this.As<ILiftComponentT>();
		}

		// Token: 0x060209A4 RID: 133540 RVA: 0x00487EB4 File Offset: 0x004860B4
		public static IComponentBase_UnionUnion FromILiftComponent(ILiftComponentT _iliftcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILiftComponent,
				Value = _iliftcomponent
			};
		}

		// Token: 0x060209A5 RID: 133541 RVA: 0x00487ECA File Offset: 0x004860CA
		public IConveyorBeltComponentT AsIConveyorBeltComponent()
		{
			return this.As<IConveyorBeltComponentT>();
		}

		// Token: 0x060209A6 RID: 133542 RVA: 0x00487ED2 File Offset: 0x004860D2
		public static IComponentBase_UnionUnion FromIConveyorBeltComponent(IConveyorBeltComponentT _iconveyorbeltcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IConveyorBeltComponent,
				Value = _iconveyorbeltcomponent
			};
		}

		// Token: 0x060209A7 RID: 133543 RVA: 0x00487EE8 File Offset: 0x004860E8
		public IFollowTrackComponentT AsIFollowTrackComponent()
		{
			return this.As<IFollowTrackComponentT>();
		}

		// Token: 0x060209A8 RID: 133544 RVA: 0x00487EF0 File Offset: 0x004860F0
		public static IComponentBase_UnionUnion FromIFollowTrackComponent(IFollowTrackComponentT _ifollowtrackcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFollowTrackComponent,
				Value = _ifollowtrackcomponent
			};
		}

		// Token: 0x060209A9 RID: 133545 RVA: 0x00487F06 File Offset: 0x00486106
		public ISceneItemLifeCycleComponentT AsISceneItemLifeCycleComponent()
		{
			return this.As<ISceneItemLifeCycleComponentT>();
		}

		// Token: 0x060209AA RID: 133546 RVA: 0x00487F0E File Offset: 0x0048610E
		public static IComponentBase_UnionUnion FromISceneItemLifeCycleComponent(ISceneItemLifeCycleComponentT _isceneitemlifecyclecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemLifeCycleComponent,
				Value = _isceneitemlifecyclecomponent
			};
		}

		// Token: 0x060209AB RID: 133547 RVA: 0x00487F24 File Offset: 0x00486124
		public IFightInteractComponentT AsIFightInteractComponent()
		{
			return this.As<IFightInteractComponentT>();
		}

		// Token: 0x060209AC RID: 133548 RVA: 0x00487F2C File Offset: 0x0048612C
		public static IComponentBase_UnionUnion FromIFightInteractComponent(IFightInteractComponentT _ifightinteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFightInteractComponent,
				Value = _ifightinteractcomponent
			};
		}

		// Token: 0x060209AD RID: 133549 RVA: 0x00487F42 File Offset: 0x00486142
		public IBubbleComponentT AsIBubbleComponent()
		{
			return this.As<IBubbleComponentT>();
		}

		// Token: 0x060209AE RID: 133550 RVA: 0x00487F4A File Offset: 0x0048614A
		public static IComponentBase_UnionUnion FromIBubbleComponent(IBubbleComponentT _ibubblecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBubbleComponent,
				Value = _ibubblecomponent
			};
		}

		// Token: 0x060209AF RID: 133551 RVA: 0x00487F60 File Offset: 0x00486160
		public INearbyTrackingComponentT AsINearbyTrackingComponent()
		{
			return this.As<INearbyTrackingComponentT>();
		}

		// Token: 0x060209B0 RID: 133552 RVA: 0x00487F68 File Offset: 0x00486168
		public static IComponentBase_UnionUnion FromINearbyTrackingComponent(INearbyTrackingComponentT _inearbytrackingcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INearbyTrackingComponent,
				Value = _inearbytrackingcomponent
			};
		}

		// Token: 0x060209B1 RID: 133553 RVA: 0x00487F7E File Offset: 0x0048617E
		public IEntityPackageComponentT AsIEntityPackageComponent()
		{
			return this.As<IEntityPackageComponentT>();
		}

		// Token: 0x060209B2 RID: 133554 RVA: 0x00487F86 File Offset: 0x00486186
		public static IComponentBase_UnionUnion FromIEntityPackageComponent(IEntityPackageComponentT _ientitypackagecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityPackageComponent,
				Value = _ientitypackagecomponent
			};
		}

		// Token: 0x060209B3 RID: 133555 RVA: 0x00487F9C File Offset: 0x0048619C
		public ISkyboxComponentT AsISkyboxComponent()
		{
			return this.As<ISkyboxComponentT>();
		}

		// Token: 0x060209B4 RID: 133556 RVA: 0x00487FA4 File Offset: 0x004861A4
		public static IComponentBase_UnionUnion FromISkyboxComponent(ISkyboxComponentT _iskyboxcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISkyboxComponent,
				Value = _iskyboxcomponent
			};
		}

		// Token: 0x060209B5 RID: 133557 RVA: 0x00487FBA File Offset: 0x004861BA
		public IStateHintComponentT AsIStateHintComponent()
		{
			return this.As<IStateHintComponentT>();
		}

		// Token: 0x060209B6 RID: 133558 RVA: 0x00487FC2 File Offset: 0x004861C2
		public static IComponentBase_UnionUnion FromIStateHintComponent(IStateHintComponentT _istatehintcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IStateHintComponent,
				Value = _istatehintcomponent
			};
		}

		// Token: 0x060209B7 RID: 133559 RVA: 0x00487FD8 File Offset: 0x004861D8
		public IEntityVisibleComponentT AsIEntityVisibleComponent()
		{
			return this.As<IEntityVisibleComponentT>();
		}

		// Token: 0x060209B8 RID: 133560 RVA: 0x00487FE0 File Offset: 0x004861E0
		public static IComponentBase_UnionUnion FromIEntityVisibleComponent(IEntityVisibleComponentT _ientityvisiblecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityVisibleComponent,
				Value = _ientityvisiblecomponent
			};
		}

		// Token: 0x060209B9 RID: 133561 RVA: 0x00487FF6 File Offset: 0x004861F6
		public ICombinedVisibleGroupComponentT AsICombinedVisibleGroupComponent()
		{
			return this.As<ICombinedVisibleGroupComponentT>();
		}

		// Token: 0x060209BA RID: 133562 RVA: 0x00487FFE File Offset: 0x004861FE
		public static IComponentBase_UnionUnion FromICombinedVisibleGroupComponent(ICombinedVisibleGroupComponentT _icombinedvisiblegroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICombinedVisibleGroupComponent,
				Value = _icombinedvisiblegroupcomponent
			};
		}

		// Token: 0x060209BB RID: 133563 RVA: 0x00488014 File Offset: 0x00486214
		public IWeaponComponentT AsIWeaponComponent()
		{
			return this.As<IWeaponComponentT>();
		}

		// Token: 0x060209BC RID: 133564 RVA: 0x0048801C File Offset: 0x0048621C
		public static IComponentBase_UnionUnion FromIWeaponComponent(IWeaponComponentT _iweaponcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IWeaponComponent,
				Value = _iweaponcomponent
			};
		}

		// Token: 0x060209BD RID: 133565 RVA: 0x00488032 File Offset: 0x00486232
		public IDungeonEntryComponentT AsIDungeonEntryComponent()
		{
			return this.As<IDungeonEntryComponentT>();
		}

		// Token: 0x060209BE RID: 133566 RVA: 0x0048803A File Offset: 0x0048623A
		public static IComponentBase_UnionUnion FromIDungeonEntryComponent(IDungeonEntryComponentT _idungeonentrycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDungeonEntryComponent,
				Value = _idungeonentrycomponent
			};
		}

		// Token: 0x060209BF RID: 133567 RVA: 0x00488050 File Offset: 0x00486250
		public IResurrectionComponentT AsIResurrectionComponent()
		{
			return this.As<IResurrectionComponentT>();
		}

		// Token: 0x060209C0 RID: 133568 RVA: 0x00488058 File Offset: 0x00486258
		public static IComponentBase_UnionUnion FromIResurrectionComponent(IResurrectionComponentT _iresurrectioncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IResurrectionComponent,
				Value = _iresurrectioncomponent
			};
		}

		// Token: 0x060209C1 RID: 133569 RVA: 0x0048806E File Offset: 0x0048626E
		public IBuffProducerComponentT AsIBuffProducerComponent()
		{
			return this.As<IBuffProducerComponentT>();
		}

		// Token: 0x060209C2 RID: 133570 RVA: 0x00488076 File Offset: 0x00486276
		public static IComponentBase_UnionUnion FromIBuffProducerComponent(IBuffProducerComponentT _ibuffproducercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBuffProducerComponent,
				Value = _ibuffproducercomponent
			};
		}

		// Token: 0x060209C3 RID: 133571 RVA: 0x0048808C File Offset: 0x0048628C
		public IBuffConsumerComponentT AsIBuffConsumerComponent()
		{
			return this.As<IBuffConsumerComponentT>();
		}

		// Token: 0x060209C4 RID: 133572 RVA: 0x00488094 File Offset: 0x00486294
		public static IComponentBase_UnionUnion FromIBuffConsumerComponent(IBuffConsumerComponentT _ibuffconsumercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBuffConsumerComponent,
				Value = _ibuffconsumercomponent
			};
		}

		// Token: 0x060209C5 RID: 133573 RVA: 0x004880AA File Offset: 0x004862AA
		public IGuideLineCreatorComponentT AsIGuideLineCreatorComponent()
		{
			return this.As<IGuideLineCreatorComponentT>();
		}

		// Token: 0x060209C6 RID: 133574 RVA: 0x004880B2 File Offset: 0x004862B2
		public static IComponentBase_UnionUnion FromIGuideLineCreatorComponent(IGuideLineCreatorComponentT _iguidelinecreatorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGuideLineCreatorComponent,
				Value = _iguidelinecreatorcomponent
			};
		}

		// Token: 0x060209C7 RID: 133575 RVA: 0x004880C8 File Offset: 0x004862C8
		public IInteractAudioComponentT AsIInteractAudioComponent()
		{
			return this.As<IInteractAudioComponentT>();
		}

		// Token: 0x060209C8 RID: 133576 RVA: 0x004880D0 File Offset: 0x004862D0
		public static IComponentBase_UnionUnion FromIInteractAudioComponent(IInteractAudioComponentT _iinteractaudiocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInteractAudioComponent,
				Value = _iinteractaudiocomponent
			};
		}

		// Token: 0x060209C9 RID: 133577 RVA: 0x004880E6 File Offset: 0x004862E6
		public IDropComponentT AsIDropComponent()
		{
			return this.As<IDropComponentT>();
		}

		// Token: 0x060209CA RID: 133578 RVA: 0x004880EE File Offset: 0x004862EE
		public static IComponentBase_UnionUnion FromIDropComponent(IDropComponentT _idropcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDropComponent,
				Value = _idropcomponent
			};
		}

		// Token: 0x060209CB RID: 133579 RVA: 0x00488104 File Offset: 0x00486304
		public IVisionItemComponentT AsIVisionItemComponent()
		{
			return this.As<IVisionItemComponentT>();
		}

		// Token: 0x060209CC RID: 133580 RVA: 0x0048810C File Offset: 0x0048630C
		public static IComponentBase_UnionUnion FromIVisionItemComponent(IVisionItemComponentT _ivisionitemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVisionItemComponent,
				Value = _ivisionitemcomponent
			};
		}

		// Token: 0x060209CD RID: 133581 RVA: 0x00488122 File Offset: 0x00486322
		public IAdviseItemComponentT AsIAdviseItemComponent()
		{
			return this.As<IAdviseItemComponentT>();
		}

		// Token: 0x060209CE RID: 133582 RVA: 0x0048812A File Offset: 0x0048632A
		public static IComponentBase_UnionUnion FromIAdviseItemComponent(IAdviseItemComponentT _iadviseitemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAdviseItemComponent,
				Value = _iadviseitemcomponent
			};
		}

		// Token: 0x060209CF RID: 133583 RVA: 0x00488140 File Offset: 0x00486340
		public IMonsterComponentT AsIMonsterComponent()
		{
			return this.As<IMonsterComponentT>();
		}

		// Token: 0x060209D0 RID: 133584 RVA: 0x00488148 File Offset: 0x00486348
		public static IComponentBase_UnionUnion FromIMonsterComponent(IMonsterComponentT _imonstercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMonsterComponent,
				Value = _imonstercomponent
			};
		}

		// Token: 0x060209D1 RID: 133585 RVA: 0x0048815E File Offset: 0x0048635E
		public ICombatComponentT AsICombatComponent()
		{
			return this.As<ICombatComponentT>();
		}

		// Token: 0x060209D2 RID: 133586 RVA: 0x00488166 File Offset: 0x00486366
		public static IComponentBase_UnionUnion FromICombatComponent(ICombatComponentT _icombatcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICombatComponent,
				Value = _icombatcomponent
			};
		}

		// Token: 0x060209D3 RID: 133587 RVA: 0x0048817C File Offset: 0x0048637C
		public IEntityListComponentT AsIEntityListComponent()
		{
			return this.As<IEntityListComponentT>();
		}

		// Token: 0x060209D4 RID: 133588 RVA: 0x00488184 File Offset: 0x00486384
		public static IComponentBase_UnionUnion FromIEntityListComponent(IEntityListComponentT _ientitylistcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityListComponent,
				Value = _ientitylistcomponent
			};
		}

		// Token: 0x060209D5 RID: 133589 RVA: 0x0048819A File Offset: 0x0048639A
		public IAnimalComponentT AsIAnimalComponent()
		{
			return this.As<IAnimalComponentT>();
		}

		// Token: 0x060209D6 RID: 133590 RVA: 0x004881A2 File Offset: 0x004863A2
		public static IComponentBase_UnionUnion FromIAnimalComponent(IAnimalComponentT _ianimalcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAnimalComponent,
				Value = _ianimalcomponent
			};
		}

		// Token: 0x060209D7 RID: 133591 RVA: 0x004881B8 File Offset: 0x004863B8
		public ISceneItemMovementComponentT AsISceneItemMovementComponent()
		{
			return this.As<ISceneItemMovementComponentT>();
		}

		// Token: 0x060209D8 RID: 133592 RVA: 0x004881C0 File Offset: 0x004863C0
		public static IComponentBase_UnionUnion FromISceneItemMovementComponent(ISceneItemMovementComponentT _isceneitemmovementcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemMovementComponent,
				Value = _isceneitemmovementcomponent
			};
		}

		// Token: 0x060209D9 RID: 133593 RVA: 0x004881D6 File Offset: 0x004863D6
		public IRangeComponentT AsIRangeComponent()
		{
			return this.As<IRangeComponentT>();
		}

		// Token: 0x060209DA RID: 133594 RVA: 0x004881DE File Offset: 0x004863DE
		public static IComponentBase_UnionUnion FromIRangeComponent(IRangeComponentT _irangecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRangeComponent,
				Value = _irangecomponent
			};
		}

		// Token: 0x060209DB RID: 133595 RVA: 0x004881F4 File Offset: 0x004863F4
		public IExtraRangeComponentT AsIExtraRangeComponent()
		{
			return this.As<IExtraRangeComponentT>();
		}

		// Token: 0x060209DC RID: 133596 RVA: 0x004881FC File Offset: 0x004863FC
		public static IComponentBase_UnionUnion FromIExtraRangeComponent(IExtraRangeComponentT _iextrarangecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IExtraRangeComponent,
				Value = _iextrarangecomponent
			};
		}

		// Token: 0x060209DD RID: 133597 RVA: 0x00488212 File Offset: 0x00486412
		public ITimelineTrackControlComponentT AsITimelineTrackControlComponent()
		{
			return this.As<ITimelineTrackControlComponentT>();
		}

		// Token: 0x060209DE RID: 133598 RVA: 0x0048821A File Offset: 0x0048641A
		public static IComponentBase_UnionUnion FromITimelineTrackControlComponent(ITimelineTrackControlComponentT _itimelinetrackcontrolcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITimelineTrackControlComponent,
				Value = _itimelinetrackcontrolcomponent
			};
		}

		// Token: 0x060209DF RID: 133599 RVA: 0x00488230 File Offset: 0x00486430
		public ISplineComponentT AsISplineComponent()
		{
			return this.As<ISplineComponentT>();
		}

		// Token: 0x060209E0 RID: 133600 RVA: 0x00488238 File Offset: 0x00486438
		public static IComponentBase_UnionUnion FromISplineComponent(ISplineComponentT _isplinecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISplineComponent,
				Value = _isplinecomponent
			};
		}

		// Token: 0x060209E1 RID: 133601 RVA: 0x0048824E File Offset: 0x0048644E
		public IAirWallSpawnerComponentT AsIAirWallSpawnerComponent()
		{
			return this.As<IAirWallSpawnerComponentT>();
		}

		// Token: 0x060209E2 RID: 133602 RVA: 0x00488256 File Offset: 0x00486456
		public static IComponentBase_UnionUnion FromIAirWallSpawnerComponent(IAirWallSpawnerComponentT _iairwallspawnercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAirWallSpawnerComponent,
				Value = _iairwallspawnercomponent
			};
		}

		// Token: 0x060209E3 RID: 133603 RVA: 0x0048826C File Offset: 0x0048646C
		public ISceneActorRefComponentT AsISceneActorRefComponent()
		{
			return this.As<ISceneActorRefComponentT>();
		}

		// Token: 0x060209E4 RID: 133604 RVA: 0x00488274 File Offset: 0x00486474
		public static IComponentBase_UnionUnion FromISceneActorRefComponent(ISceneActorRefComponentT _isceneactorrefcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneActorRefComponent,
				Value = _isceneactorrefcomponent
			};
		}

		// Token: 0x060209E5 RID: 133605 RVA: 0x0048828A File Offset: 0x0048648A
		public ISceneBulletComponentT AsISceneBulletComponent()
		{
			return this.As<ISceneBulletComponentT>();
		}

		// Token: 0x060209E6 RID: 133606 RVA: 0x00488292 File Offset: 0x00486492
		public static IComponentBase_UnionUnion FromISceneBulletComponent(ISceneBulletComponentT _iscenebulletcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneBulletComponent,
				Value = _iscenebulletcomponent
			};
		}

		// Token: 0x060209E7 RID: 133607 RVA: 0x004882A8 File Offset: 0x004864A8
		public ITurntableControlComponentT AsITurntableControlComponent()
		{
			return this.As<ITurntableControlComponentT>();
		}

		// Token: 0x060209E8 RID: 133608 RVA: 0x004882B0 File Offset: 0x004864B0
		public static IComponentBase_UnionUnion FromITurntableControlComponent(ITurntableControlComponentT _iturntablecontrolcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITurntableControlComponent,
				Value = _iturntablecontrolcomponent
			};
		}

		// Token: 0x060209E9 RID: 133609 RVA: 0x004882C6 File Offset: 0x004864C6
		public IConditionListenerComponentT AsIConditionListenerComponent()
		{
			return this.As<IConditionListenerComponentT>();
		}

		// Token: 0x060209EA RID: 133610 RVA: 0x004882CE File Offset: 0x004864CE
		public static IComponentBase_UnionUnion FromIConditionListenerComponent(IConditionListenerComponentT _iconditionlistenercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IConditionListenerComponent,
				Value = _iconditionlistenercomponent
			};
		}

		// Token: 0x060209EB RID: 133611 RVA: 0x004882E4 File Offset: 0x004864E4
		public IAttachTargetComponentT AsIAttachTargetComponent()
		{
			return this.As<IAttachTargetComponentT>();
		}

		// Token: 0x060209EC RID: 133612 RVA: 0x004882EC File Offset: 0x004864EC
		public static IComponentBase_UnionUnion FromIAttachTargetComponent(IAttachTargetComponentT _iattachtargetcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAttachTargetComponent,
				Value = _iattachtargetcomponent
			};
		}

		// Token: 0x060209ED RID: 133613 RVA: 0x00488302 File Offset: 0x00486502
		public IReboundComponentT AsIReboundComponent()
		{
			return this.As<IReboundComponentT>();
		}

		// Token: 0x060209EE RID: 133614 RVA: 0x0048830A File Offset: 0x0048650A
		public static IComponentBase_UnionUnion FromIReboundComponent(IReboundComponentT _ireboundcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IReboundComponent,
				Value = _ireboundcomponent
			};
		}

		// Token: 0x060209EF RID: 133615 RVA: 0x00488320 File Offset: 0x00486520
		public IJigsawItemT AsIJigsawItem()
		{
			return this.As<IJigsawItemT>();
		}

		// Token: 0x060209F0 RID: 133616 RVA: 0x00488328 File Offset: 0x00486528
		public static IComponentBase_UnionUnion FromIJigsawItem(IJigsawItemT _ijigsawitem)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IJigsawItem,
				Value = _ijigsawitem
			};
		}

		// Token: 0x060209F1 RID: 133617 RVA: 0x0048833E File Offset: 0x0048653E
		public IJigsawFoundationT AsIJigsawFoundation()
		{
			return this.As<IJigsawFoundationT>();
		}

		// Token: 0x060209F2 RID: 133618 RVA: 0x00488346 File Offset: 0x00486546
		public static IComponentBase_UnionUnion FromIJigsawFoundation(IJigsawFoundationT _ijigsawfoundation)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IJigsawFoundation,
				Value = _ijigsawfoundation
			};
		}

		// Token: 0x060209F3 RID: 133619 RVA: 0x0048835C File Offset: 0x0048655C
		public ILevelAIComponentT AsILevelAIComponent()
		{
			return this.As<ILevelAIComponentT>();
		}

		// Token: 0x060209F4 RID: 133620 RVA: 0x00488364 File Offset: 0x00486564
		public static IComponentBase_UnionUnion FromILevelAIComponent(ILevelAIComponentT _ilevelaicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelAIComponent,
				Value = _ilevelaicomponent
			};
		}

		// Token: 0x060209F5 RID: 133621 RVA: 0x0048837A File Offset: 0x0048657A
		public ILevitateMagnetComponentT AsILevitateMagnetComponent()
		{
			return this.As<ILevitateMagnetComponentT>();
		}

		// Token: 0x060209F6 RID: 133622 RVA: 0x00488382 File Offset: 0x00486582
		public static IComponentBase_UnionUnion FromILevitateMagnetComponent(ILevitateMagnetComponentT _ilevitatemagnetcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevitateMagnetComponent,
				Value = _ilevitatemagnetcomponent
			};
		}

		// Token: 0x060209F7 RID: 133623 RVA: 0x00488398 File Offset: 0x00486598
		public IPhotoTargetComponentT AsIPhotoTargetComponent()
		{
			return this.As<IPhotoTargetComponentT>();
		}

		// Token: 0x060209F8 RID: 133624 RVA: 0x004883A0 File Offset: 0x004865A0
		public static IComponentBase_UnionUnion FromIPhotoTargetComponent(IPhotoTargetComponentT _iphototargetcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPhotoTargetComponent,
				Value = _iphototargetcomponent
			};
		}

		// Token: 0x060209F9 RID: 133625 RVA: 0x004883B6 File Offset: 0x004865B6
		public IAiAlertNotifyComponentT AsIAiAlertNotifyComponent()
		{
			return this.As<IAiAlertNotifyComponentT>();
		}

		// Token: 0x060209FA RID: 133626 RVA: 0x004883BE File Offset: 0x004865BE
		public static IComponentBase_UnionUnion FromIAiAlertNotifyComponent(IAiAlertNotifyComponentT _iaialertnotifycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAiAlertNotifyComponent,
				Value = _iaialertnotifycomponent
			};
		}

		// Token: 0x060209FB RID: 133627 RVA: 0x004883D4 File Offset: 0x004865D4
		public IMonsterGachaItemComponentT AsIMonsterGachaItemComponent()
		{
			return this.As<IMonsterGachaItemComponentT>();
		}

		// Token: 0x060209FC RID: 133628 RVA: 0x004883DC File Offset: 0x004865DC
		public static IComponentBase_UnionUnion FromIMonsterGachaItemComponent(IMonsterGachaItemComponentT _imonstergachaitemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMonsterGachaItemComponent,
				Value = _imonstergachaitemcomponent
			};
		}

		// Token: 0x060209FD RID: 133629 RVA: 0x004883F2 File Offset: 0x004865F2
		public IMonsterGachaBaseComponentT AsIMonsterGachaBaseComponent()
		{
			return this.As<IMonsterGachaBaseComponentT>();
		}

		// Token: 0x060209FE RID: 133630 RVA: 0x004883FA File Offset: 0x004865FA
		public static IComponentBase_UnionUnion FromIMonsterGachaBaseComponent(IMonsterGachaBaseComponentT _imonstergachabasecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMonsterGachaBaseComponent,
				Value = _imonstergachabasecomponent
			};
		}

		// Token: 0x060209FF RID: 133631 RVA: 0x00488410 File Offset: 0x00486610
		public IDynamicTeleportComponentT AsIDynamicTeleportComponent()
		{
			return this.As<IDynamicTeleportComponentT>();
		}

		// Token: 0x06020A00 RID: 133632 RVA: 0x00488418 File Offset: 0x00486618
		public static IComponentBase_UnionUnion FromIDynamicTeleportComponent(IDynamicTeleportComponentT _idynamicteleportcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicTeleportComponent,
				Value = _idynamicteleportcomponent
			};
		}

		// Token: 0x06020A01 RID: 133633 RVA: 0x0048842E File Offset: 0x0048662E
		public IExploreSkillInteractComponentT AsIExploreSkillInteractComponent()
		{
			return this.As<IExploreSkillInteractComponentT>();
		}

		// Token: 0x06020A02 RID: 133634 RVA: 0x00488436 File Offset: 0x00486636
		public static IComponentBase_UnionUnion FromIExploreSkillInteractComponent(IExploreSkillInteractComponentT _iexploreskillinteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IExploreSkillInteractComponent,
				Value = _iexploreskillinteractcomponent
			};
		}

		// Token: 0x06020A03 RID: 133635 RVA: 0x0048844C File Offset: 0x0048664C
		public IExploreSkillInteractGroupComponentT AsIExploreSkillInteractGroupComponent()
		{
			return this.As<IExploreSkillInteractGroupComponentT>();
		}

		// Token: 0x06020A04 RID: 133636 RVA: 0x00488454 File Offset: 0x00486654
		public static IComponentBase_UnionUnion FromIExploreSkillInteractGroupComponent(IExploreSkillInteractGroupComponentT _iexploreskillinteractgroupcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IExploreSkillInteractGroupComponent,
				Value = _iexploreskillinteractgroupcomponent
			};
		}

		// Token: 0x06020A05 RID: 133637 RVA: 0x0048846A File Offset: 0x0048666A
		public IFanComponentT AsIFanComponent()
		{
			return this.As<IFanComponentT>();
		}

		// Token: 0x06020A06 RID: 133638 RVA: 0x00488472 File Offset: 0x00486672
		public static IComponentBase_UnionUnion FromIFanComponent(IFanComponentT _ifancomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFanComponent,
				Value = _ifancomponent
			};
		}

		// Token: 0x06020A07 RID: 133639 RVA: 0x00488488 File Offset: 0x00486688
		public IPasserbyNpcSpawnComponentT AsIPasserbyNpcSpawnComponent()
		{
			return this.As<IPasserbyNpcSpawnComponentT>();
		}

		// Token: 0x06020A08 RID: 133640 RVA: 0x00488490 File Offset: 0x00486690
		public static IComponentBase_UnionUnion FromIPasserbyNpcSpawnComponent(IPasserbyNpcSpawnComponentT _ipasserbynpcspawncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPasserbyNpcSpawnComponent,
				Value = _ipasserbynpcspawncomponent
			};
		}

		// Token: 0x06020A09 RID: 133641 RVA: 0x004884A6 File Offset: 0x004866A6
		public IModelComponentT AsIModelComponent()
		{
			return this.As<IModelComponentT>();
		}

		// Token: 0x06020A0A RID: 133642 RVA: 0x004884AE File Offset: 0x004866AE
		public static IComponentBase_UnionUnion FromIModelComponent(IModelComponentT _imodelcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IModelComponent,
				Value = _imodelcomponent
			};
		}

		// Token: 0x06020A0B RID: 133643 RVA: 0x004884C4 File Offset: 0x004866C4
		public IEntityBundleComponentT AsIEntityBundleComponent()
		{
			return this.As<IEntityBundleComponentT>();
		}

		// Token: 0x06020A0C RID: 133644 RVA: 0x004884CC File Offset: 0x004866CC
		public static IComponentBase_UnionUnion FromIEntityBundleComponent(IEntityBundleComponentT _ientitybundlecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEntityBundleComponent,
				Value = _ientitybundlecomponent
			};
		}

		// Token: 0x06020A0D RID: 133645 RVA: 0x004884E2 File Offset: 0x004866E2
		public IBeamCastComponentT AsIBeamCastComponent()
		{
			return this.As<IBeamCastComponentT>();
		}

		// Token: 0x06020A0E RID: 133646 RVA: 0x004884EA File Offset: 0x004866EA
		public static IComponentBase_UnionUnion FromIBeamCastComponent(IBeamCastComponentT _ibeamcastcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBeamCastComponent,
				Value = _ibeamcastcomponent
			};
		}

		// Token: 0x06020A0F RID: 133647 RVA: 0x00488500 File Offset: 0x00486700
		public IBeamReceiveComponentT AsIBeamReceiveComponent()
		{
			return this.As<IBeamReceiveComponentT>();
		}

		// Token: 0x06020A10 RID: 133648 RVA: 0x00488508 File Offset: 0x00486708
		public static IComponentBase_UnionUnion FromIBeamReceiveComponent(IBeamReceiveComponentT _ibeamreceivecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBeamReceiveComponent,
				Value = _ibeamreceivecomponent
			};
		}

		// Token: 0x06020A11 RID: 133649 RVA: 0x0048851E File Offset: 0x0048671E
		public ITimeStopComponentT AsITimeStopComponent()
		{
			return this.As<ITimeStopComponentT>();
		}

		// Token: 0x06020A12 RID: 133650 RVA: 0x00488526 File Offset: 0x00486726
		public static IComponentBase_UnionUnion FromITimeStopComponent(ITimeStopComponentT _itimestopcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITimeStopComponent,
				Value = _itimestopcomponent
			};
		}

		// Token: 0x06020A13 RID: 133651 RVA: 0x0048853C File Offset: 0x0048673C
		public IPortalComponentT AsIPortalComponent()
		{
			return this.As<IPortalComponentT>();
		}

		// Token: 0x06020A14 RID: 133652 RVA: 0x00488544 File Offset: 0x00486744
		public static IComponentBase_UnionUnion FromIPortalComponent(IPortalComponentT _iportalcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPortalComponent,
				Value = _iportalcomponent
			};
		}

		// Token: 0x06020A15 RID: 133653 RVA: 0x0048855A File Offset: 0x0048675A
		public IDynamicPortalCreatorComponentT AsIDynamicPortalCreatorComponent()
		{
			return this.As<IDynamicPortalCreatorComponentT>();
		}

		// Token: 0x06020A16 RID: 133654 RVA: 0x00488562 File Offset: 0x00486762
		public static IComponentBase_UnionUnion FromIDynamicPortalCreatorComponent(IDynamicPortalCreatorComponentT _idynamicportalcreatorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicPortalCreatorComponent,
				Value = _idynamicportalcreatorcomponent
			};
		}

		// Token: 0x06020A17 RID: 133655 RVA: 0x00488578 File Offset: 0x00486778
		public INoRenderPortalComponentT AsINoRenderPortalComponent()
		{
			return this.As<INoRenderPortalComponentT>();
		}

		// Token: 0x06020A18 RID: 133656 RVA: 0x00488580 File Offset: 0x00486780
		public static IComponentBase_UnionUnion FromINoRenderPortalComponent(INoRenderPortalComponentT _inorenderportalcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INoRenderPortalComponent,
				Value = _inorenderportalcomponent
			};
		}

		// Token: 0x06020A19 RID: 133657 RVA: 0x00488596 File Offset: 0x00486796
		public IEffectAreaComponentT AsIEffectAreaComponent()
		{
			return this.As<IEffectAreaComponentT>();
		}

		// Token: 0x06020A1A RID: 133658 RVA: 0x0048859E File Offset: 0x0048679E
		public static IComponentBase_UnionUnion FromIEffectAreaComponent(IEffectAreaComponentT _ieffectareacomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEffectAreaComponent,
				Value = _ieffectareacomponent
			};
		}

		// Token: 0x06020A1B RID: 133659 RVA: 0x004885B4 File Offset: 0x004867B4
		public IPhysicsConstraintComponentT AsIPhysicsConstraintComponent()
		{
			return this.As<IPhysicsConstraintComponentT>();
		}

		// Token: 0x06020A1C RID: 133660 RVA: 0x004885BC File Offset: 0x004867BC
		public static IComponentBase_UnionUnion FromIPhysicsConstraintComponent(IPhysicsConstraintComponentT _iphysicsconstraintcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPhysicsConstraintComponent,
				Value = _iphysicsconstraintcomponent
			};
		}

		// Token: 0x06020A1D RID: 133661 RVA: 0x004885D2 File Offset: 0x004867D2
		public IFollowDecorationComponentT AsIFollowDecorationComponent()
		{
			return this.As<IFollowDecorationComponentT>();
		}

		// Token: 0x06020A1E RID: 133662 RVA: 0x004885DA File Offset: 0x004867DA
		public static IComponentBase_UnionUnion FromIFollowDecorationComponent(IFollowDecorationComponentT _ifollowdecorationcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFollowDecorationComponent,
				Value = _ifollowdecorationcomponent
			};
		}

		// Token: 0x06020A1F RID: 133663 RVA: 0x004885F3 File Offset: 0x004867F3
		public IFollowShooterComponentT AsIFollowShooterComponent()
		{
			return this.As<IFollowShooterComponentT>();
		}

		// Token: 0x06020A20 RID: 133664 RVA: 0x004885FB File Offset: 0x004867FB
		public static IComponentBase_UnionUnion FromIFollowShooterComponent(IFollowShooterComponentT _ifollowshootercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFollowShooterComponent,
				Value = _ifollowshootercomponent
			};
		}

		// Token: 0x06020A21 RID: 133665 RVA: 0x00488614 File Offset: 0x00486814
		public IConnectorComponentT AsIConnectorComponent()
		{
			return this.As<IConnectorComponentT>();
		}

		// Token: 0x06020A22 RID: 133666 RVA: 0x0048861C File Offset: 0x0048681C
		public static IComponentBase_UnionUnion FromIConnectorComponent(IConnectorComponentT _iconnectorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IConnectorComponent,
				Value = _iconnectorcomponent
			};
		}

		// Token: 0x06020A23 RID: 133667 RVA: 0x00488635 File Offset: 0x00486835
		public ISceneTextComponentT AsISceneTextComponent()
		{
			return this.As<ISceneTextComponentT>();
		}

		// Token: 0x06020A24 RID: 133668 RVA: 0x0048863D File Offset: 0x0048683D
		public static IComponentBase_UnionUnion FromISceneTextComponent(ISceneTextComponentT _iscenetextcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneTextComponent,
				Value = _iscenetextcomponent
			};
		}

		// Token: 0x06020A25 RID: 133669 RVA: 0x00488656 File Offset: 0x00486856
		public INavMeshComponentT AsINavMeshComponent()
		{
			return this.As<INavMeshComponentT>();
		}

		// Token: 0x06020A26 RID: 133670 RVA: 0x0048865E File Offset: 0x0048685E
		public static IComponentBase_UnionUnion FromINavMeshComponent(INavMeshComponentT _inavmeshcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INavMeshComponent,
				Value = _inavmeshcomponent
			};
		}

		// Token: 0x06020A27 RID: 133671 RVA: 0x00488677 File Offset: 0x00486877
		public ICharacterConnectorComponentT AsICharacterConnectorComponent()
		{
			return this.As<ICharacterConnectorComponentT>();
		}

		// Token: 0x06020A28 RID: 133672 RVA: 0x0048867F File Offset: 0x0048687F
		public static IComponentBase_UnionUnion FromICharacterConnectorComponent(ICharacterConnectorComponentT _icharacterconnectorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICharacterConnectorComponent,
				Value = _icharacterconnectorcomponent
			};
		}

		// Token: 0x06020A29 RID: 133673 RVA: 0x00488698 File Offset: 0x00486898
		public IAiGearStrategyComponentT AsIAiGearStrategyComponent()
		{
			return this.As<IAiGearStrategyComponentT>();
		}

		// Token: 0x06020A2A RID: 133674 RVA: 0x004886A0 File Offset: 0x004868A0
		public static IComponentBase_UnionUnion FromIAiGearStrategyComponent(IAiGearStrategyComponentT _iaigearstrategycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAiGearStrategyComponent,
				Value = _iaigearstrategycomponent
			};
		}

		// Token: 0x06020A2B RID: 133675 RVA: 0x004886B9 File Offset: 0x004868B9
		public IPickInteractComponentT AsIPickInteractComponent()
		{
			return this.As<IPickInteractComponentT>();
		}

		// Token: 0x06020A2C RID: 133676 RVA: 0x004886C1 File Offset: 0x004868C1
		public static IComponentBase_UnionUnion FromIPickInteractComponent(IPickInteractComponentT _ipickinteractcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPickInteractComponent,
				Value = _ipickinteractcomponent
			};
		}

		// Token: 0x06020A2D RID: 133677 RVA: 0x004886DA File Offset: 0x004868DA
		public IChessmanComponentT AsIChessmanComponent()
		{
			return this.As<IChessmanComponentT>();
		}

		// Token: 0x06020A2E RID: 133678 RVA: 0x004886E2 File Offset: 0x004868E2
		public static IComponentBase_UnionUnion FromIChessmanComponent(IChessmanComponentT _ichessmancomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IChessmanComponent,
				Value = _ichessmancomponent
			};
		}

		// Token: 0x06020A2F RID: 133679 RVA: 0x004886FB File Offset: 0x004868FB
		public IClientTriggerComponentT AsIClientTriggerComponent()
		{
			return this.As<IClientTriggerComponentT>();
		}

		// Token: 0x06020A30 RID: 133680 RVA: 0x00488703 File Offset: 0x00486903
		public static IComponentBase_UnionUnion FromIClientTriggerComponent(IClientTriggerComponentT _iclienttriggercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IClientTriggerComponent,
				Value = _iclienttriggercomponent
			};
		}

		// Token: 0x06020A31 RID: 133681 RVA: 0x0048871C File Offset: 0x0048691C
		public ILocationSafetyComponentT AsILocationSafetyComponent()
		{
			return this.As<ILocationSafetyComponentT>();
		}

		// Token: 0x06020A32 RID: 133682 RVA: 0x00488724 File Offset: 0x00486924
		public static IComponentBase_UnionUnion FromILocationSafetyComponent(ILocationSafetyComponentT _ilocationsafetycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILocationSafetyComponent,
				Value = _ilocationsafetycomponent
			};
		}

		// Token: 0x06020A33 RID: 133683 RVA: 0x0048873D File Offset: 0x0048693D
		public IBatchBulletCasterComponentT AsIBatchBulletCasterComponent()
		{
			return this.As<IBatchBulletCasterComponentT>();
		}

		// Token: 0x06020A34 RID: 133684 RVA: 0x00488745 File Offset: 0x00486945
		public static IComponentBase_UnionUnion FromIBatchBulletCasterComponent(IBatchBulletCasterComponentT _ibatchbulletcastercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IBatchBulletCasterComponent,
				Value = _ibatchbulletcastercomponent
			};
		}

		// Token: 0x06020A35 RID: 133685 RVA: 0x0048875E File Offset: 0x0048695E
		public IVehicleComponentT AsIVehicleComponent()
		{
			return this.As<IVehicleComponentT>();
		}

		// Token: 0x06020A36 RID: 133686 RVA: 0x00488766 File Offset: 0x00486966
		public static IComponentBase_UnionUnion FromIVehicleComponent(IVehicleComponentT _ivehiclecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVehicleComponent,
				Value = _ivehiclecomponent
			};
		}

		// Token: 0x06020A37 RID: 133687 RVA: 0x0048877F File Offset: 0x0048697F
		public IEnrichmentAreaComponentT AsIEnrichmentAreaComponent()
		{
			return this.As<IEnrichmentAreaComponentT>();
		}

		// Token: 0x06020A38 RID: 133688 RVA: 0x00488787 File Offset: 0x00486987
		public static IComponentBase_UnionUnion FromIEnrichmentAreaComponent(IEnrichmentAreaComponentT _ienrichmentareacomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IEnrichmentAreaComponent,
				Value = _ienrichmentareacomponent
			};
		}

		// Token: 0x06020A39 RID: 133689 RVA: 0x004887A0 File Offset: 0x004869A0
		public IMonitorComponentT AsIMonitorComponent()
		{
			return this.As<IMonitorComponentT>();
		}

		// Token: 0x06020A3A RID: 133690 RVA: 0x004887A8 File Offset: 0x004869A8
		public static IComponentBase_UnionUnion FromIMonitorComponent(IMonitorComponentT _imonitorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMonitorComponent,
				Value = _imonitorcomponent
			};
		}

		// Token: 0x06020A3B RID: 133691 RVA: 0x004887C1 File Offset: 0x004869C1
		public IGroupAiComponentT AsIGroupAiComponent()
		{
			return this.As<IGroupAiComponentT>();
		}

		// Token: 0x06020A3C RID: 133692 RVA: 0x004887C9 File Offset: 0x004869C9
		public static IComponentBase_UnionUnion FromIGroupAiComponent(IGroupAiComponentT _igroupaicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGroupAiComponent,
				Value = _igroupaicomponent
			};
		}

		// Token: 0x06020A3D RID: 133693 RVA: 0x004887E2 File Offset: 0x004869E2
		public IInhalationAbilityComponentT AsIInhalationAbilityComponent()
		{
			return this.As<IInhalationAbilityComponentT>();
		}

		// Token: 0x06020A3E RID: 133694 RVA: 0x004887EA File Offset: 0x004869EA
		public static IComponentBase_UnionUnion FromIInhalationAbilityComponent(IInhalationAbilityComponentT _iinhalationabilitycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInhalationAbilityComponent,
				Value = _iinhalationabilitycomponent
			};
		}

		// Token: 0x06020A3F RID: 133695 RVA: 0x00488803 File Offset: 0x00486A03
		public IInhaledItemComponentT AsIInhaledItemComponent()
		{
			return this.As<IInhaledItemComponentT>();
		}

		// Token: 0x06020A40 RID: 133696 RVA: 0x0048880B File Offset: 0x00486A0B
		public static IComponentBase_UnionUnion FromIInhaledItemComponent(IInhaledItemComponentT _iinhaleditemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IInhaledItemComponent,
				Value = _iinhaleditemcomponent
			};
		}

		// Token: 0x06020A41 RID: 133697 RVA: 0x00488824 File Offset: 0x00486A24
		public IAirPassageComponentT AsIAirPassageComponent()
		{
			return this.As<IAirPassageComponentT>();
		}

		// Token: 0x06020A42 RID: 133698 RVA: 0x0048882C File Offset: 0x00486A2C
		public static IComponentBase_UnionUnion FromIAirPassageComponent(IAirPassageComponentT _iairpassagecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IAirPassageComponent,
				Value = _iairpassagecomponent
			};
		}

		// Token: 0x06020A43 RID: 133699 RVA: 0x00488845 File Offset: 0x00486A45
		public IRenderSpecifiedRangeComponentT AsIRenderSpecifiedRangeComponent()
		{
			return this.As<IRenderSpecifiedRangeComponentT>();
		}

		// Token: 0x06020A44 RID: 133700 RVA: 0x0048884D File Offset: 0x00486A4D
		public static IComponentBase_UnionUnion FromIRenderSpecifiedRangeComponent(IRenderSpecifiedRangeComponentT _irenderspecifiedrangecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRenderSpecifiedRangeComponent,
				Value = _irenderspecifiedrangecomponent
			};
		}

		// Token: 0x06020A45 RID: 133701 RVA: 0x00488866 File Offset: 0x00486A66
		public ILevelPrefabPerformComponentT AsILevelPrefabPerformComponent()
		{
			return this.As<ILevelPrefabPerformComponentT>();
		}

		// Token: 0x06020A46 RID: 133702 RVA: 0x0048886E File Offset: 0x00486A6E
		public static IComponentBase_UnionUnion FromILevelPrefabPerformComponent(ILevelPrefabPerformComponentT _ilevelprefabperformcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelPrefabPerformComponent,
				Value = _ilevelprefabperformcomponent
			};
		}

		// Token: 0x06020A47 RID: 133703 RVA: 0x00488887 File Offset: 0x00486A87
		public ISceneItemAiComponentT AsISceneItemAiComponent()
		{
			return this.As<ISceneItemAiComponentT>();
		}

		// Token: 0x06020A48 RID: 133704 RVA: 0x0048888F File Offset: 0x00486A8F
		public static IComponentBase_UnionUnion FromISceneItemAiComponent(ISceneItemAiComponentT _isceneitemaicomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemAiComponent,
				Value = _isceneitemaicomponent
			};
		}

		// Token: 0x06020A49 RID: 133705 RVA: 0x004888A8 File Offset: 0x00486AA8
		public IGravityFlipComponentT AsIGravityFlipComponent()
		{
			return this.As<IGravityFlipComponentT>();
		}

		// Token: 0x06020A4A RID: 133706 RVA: 0x004888B0 File Offset: 0x00486AB0
		public static IComponentBase_UnionUnion FromIGravityFlipComponent(IGravityFlipComponentT _igravityflipcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGravityFlipComponent,
				Value = _igravityflipcomponent
			};
		}

		// Token: 0x06020A4B RID: 133707 RVA: 0x004888C9 File Offset: 0x00486AC9
		public ILevelSequenceFrameEventComponentT AsILevelSequenceFrameEventComponent()
		{
			return this.As<ILevelSequenceFrameEventComponentT>();
		}

		// Token: 0x06020A4C RID: 133708 RVA: 0x004888D1 File Offset: 0x00486AD1
		public static IComponentBase_UnionUnion FromILevelSequenceFrameEventComponent(ILevelSequenceFrameEventComponentT _ilevelsequenceframeeventcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelSequenceFrameEventComponent,
				Value = _ilevelsequenceframeeventcomponent
			};
		}

		// Token: 0x06020A4D RID: 133709 RVA: 0x004888EA File Offset: 0x00486AEA
		public ILevelQteComponentT AsILevelQteComponent()
		{
			return this.As<ILevelQteComponentT>();
		}

		// Token: 0x06020A4E RID: 133710 RVA: 0x004888F2 File Offset: 0x00486AF2
		public static IComponentBase_UnionUnion FromILevelQteComponent(ILevelQteComponentT _ilevelqtecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILevelQteComponent,
				Value = _ilevelqtecomponent
			};
		}

		// Token: 0x06020A4F RID: 133711 RVA: 0x0048890B File Offset: 0x00486B0B
		public IWalkingPatternComponentT AsIWalkingPatternComponent()
		{
			return this.As<IWalkingPatternComponentT>();
		}

		// Token: 0x06020A50 RID: 133712 RVA: 0x00488913 File Offset: 0x00486B13
		public static IComponentBase_UnionUnion FromIWalkingPatternComponent(IWalkingPatternComponentT _iwalkingpatterncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IWalkingPatternComponent,
				Value = _iwalkingpatterncomponent
			};
		}

		// Token: 0x06020A51 RID: 133713 RVA: 0x0048892C File Offset: 0x00486B2C
		public ILifePointCenterComponentT AsILifePointCenterComponent()
		{
			return this.As<ILifePointCenterComponentT>();
		}

		// Token: 0x06020A52 RID: 133714 RVA: 0x00488934 File Offset: 0x00486B34
		public static IComponentBase_UnionUnion FromILifePointCenterComponent(ILifePointCenterComponentT _ilifepointcentercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ILifePointCenterComponent,
				Value = _ilifepointcentercomponent
			};
		}

		// Token: 0x06020A53 RID: 133715 RVA: 0x0048894D File Offset: 0x00486B4D
		public IHackManagementComponentT AsIHackManagementComponent()
		{
			return this.As<IHackManagementComponentT>();
		}

		// Token: 0x06020A54 RID: 133716 RVA: 0x00488955 File Offset: 0x00486B55
		public static IComponentBase_UnionUnion FromIHackManagementComponent(IHackManagementComponentT _ihackmanagementcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IHackManagementComponent,
				Value = _ihackmanagementcomponent
			};
		}

		// Token: 0x06020A55 RID: 133717 RVA: 0x0048896E File Offset: 0x00486B6E
		public IClientConditionListenerComponentT AsIClientConditionListenerComponent()
		{
			return this.As<IClientConditionListenerComponentT>();
		}

		// Token: 0x06020A56 RID: 133718 RVA: 0x00488976 File Offset: 0x00486B76
		public static IComponentBase_UnionUnion FromIClientConditionListenerComponent(IClientConditionListenerComponentT _iclientconditionlistenercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IClientConditionListenerComponent,
				Value = _iclientconditionlistenercomponent
			};
		}

		// Token: 0x06020A57 RID: 133719 RVA: 0x0048898F File Offset: 0x00486B8F
		public ITemplateEntitySpawnerComponentT AsITemplateEntitySpawnerComponent()
		{
			return this.As<ITemplateEntitySpawnerComponentT>();
		}

		// Token: 0x06020A58 RID: 133720 RVA: 0x00488997 File Offset: 0x00486B97
		public static IComponentBase_UnionUnion FromITemplateEntitySpawnerComponent(ITemplateEntitySpawnerComponentT _itemplateentityspawnercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITemplateEntitySpawnerComponent,
				Value = _itemplateentityspawnercomponent
			};
		}

		// Token: 0x06020A59 RID: 133721 RVA: 0x004889B0 File Offset: 0x00486BB0
		public IWindSourceComponentT AsIWindSourceComponent()
		{
			return this.As<IWindSourceComponentT>();
		}

		// Token: 0x06020A5A RID: 133722 RVA: 0x004889B8 File Offset: 0x00486BB8
		public static IComponentBase_UnionUnion FromIWindSourceComponent(IWindSourceComponentT _iwindsourcecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IWindSourceComponent,
				Value = _iwindsourcecomponent
			};
		}

		// Token: 0x06020A5B RID: 133723 RVA: 0x004889D1 File Offset: 0x00486BD1
		public ISlideRailComponentT AsISlideRailComponent()
		{
			return this.As<ISlideRailComponentT>();
		}

		// Token: 0x06020A5C RID: 133724 RVA: 0x004889D9 File Offset: 0x00486BD9
		public static IComponentBase_UnionUnion FromISlideRailComponent(ISlideRailComponentT _isliderailcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISlideRailComponent,
				Value = _isliderailcomponent
			};
		}

		// Token: 0x06020A5D RID: 133725 RVA: 0x004889F2 File Offset: 0x00486BF2
		public ISlidePerformComponentT AsISlidePerformComponent()
		{
			return this.As<ISlidePerformComponentT>();
		}

		// Token: 0x06020A5E RID: 133726 RVA: 0x004889FA File Offset: 0x00486BFA
		public static IComponentBase_UnionUnion FromISlidePerformComponent(ISlidePerformComponentT _islideperformcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISlidePerformComponent,
				Value = _islideperformcomponent
			};
		}

		// Token: 0x06020A5F RID: 133727 RVA: 0x00488A13 File Offset: 0x00486C13
		public IRollBlockComponentT AsIRollBlockComponent()
		{
			return this.As<IRollBlockComponentT>();
		}

		// Token: 0x06020A60 RID: 133728 RVA: 0x00488A1B File Offset: 0x00486C1B
		public static IComponentBase_UnionUnion FromIRollBlockComponent(IRollBlockComponentT _irollblockcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRollBlockComponent,
				Value = _irollblockcomponent
			};
		}

		// Token: 0x06020A61 RID: 133729 RVA: 0x00488A34 File Offset: 0x00486C34
		public IRollBlockFloorComponentT AsIRollBlockFloorComponent()
		{
			return this.As<IRollBlockFloorComponentT>();
		}

		// Token: 0x06020A62 RID: 133730 RVA: 0x00488A3C File Offset: 0x00486C3C
		public static IComponentBase_UnionUnion FromIRollBlockFloorComponent(IRollBlockFloorComponentT _irollblockfloorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRollBlockFloorComponent,
				Value = _irollblockfloorcomponent
			};
		}

		// Token: 0x06020A63 RID: 133731 RVA: 0x00488A55 File Offset: 0x00486C55
		public IRollBlockItemComponentT AsIRollBlockItemComponent()
		{
			return this.As<IRollBlockItemComponentT>();
		}

		// Token: 0x06020A64 RID: 133732 RVA: 0x00488A5D File Offset: 0x00486C5D
		public static IComponentBase_UnionUnion FromIRollBlockItemComponent(IRollBlockItemComponentT _irollblockitemcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRollBlockItemComponent,
				Value = _irollblockitemcomponent
			};
		}

		// Token: 0x06020A65 RID: 133733 RVA: 0x00488A76 File Offset: 0x00486C76
		public ICurveControlComponentT AsICurveControlComponent()
		{
			return this.As<ICurveControlComponentT>();
		}

		// Token: 0x06020A66 RID: 133734 RVA: 0x00488A7E File Offset: 0x00486C7E
		public static IComponentBase_UnionUnion FromICurveControlComponent(ICurveControlComponentT _icurvecontrolcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ICurveControlComponent,
				Value = _icurvecontrolcomponent
			};
		}

		// Token: 0x06020A67 RID: 133735 RVA: 0x00488A97 File Offset: 0x00486C97
		public ISimpleCombatComponentT AsISimpleCombatComponent()
		{
			return this.As<ISimpleCombatComponentT>();
		}

		// Token: 0x06020A68 RID: 133736 RVA: 0x00488A9F File Offset: 0x00486C9F
		public static IComponentBase_UnionUnion FromISimpleCombatComponent(ISimpleCombatComponentT _isimplecombatcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISimpleCombatComponent,
				Value = _isimplecombatcomponent
			};
		}

		// Token: 0x06020A69 RID: 133737 RVA: 0x00488AB8 File Offset: 0x00486CB8
		public IGridObjectComponentT AsIGridObjectComponent()
		{
			return this.As<IGridObjectComponentT>();
		}

		// Token: 0x06020A6A RID: 133738 RVA: 0x00488AC0 File Offset: 0x00486CC0
		public static IComponentBase_UnionUnion FromIGridObjectComponent(IGridObjectComponentT _igridobjectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGridObjectComponent,
				Value = _igridobjectcomponent
			};
		}

		// Token: 0x06020A6B RID: 133739 RVA: 0x00488AD9 File Offset: 0x00486CD9
		public IGodKingFrequencyControllerComponentT AsIGodKingFrequencyControllerComponent()
		{
			return this.As<IGodKingFrequencyControllerComponentT>();
		}

		// Token: 0x06020A6C RID: 133740 RVA: 0x00488AE1 File Offset: 0x00486CE1
		public static IComponentBase_UnionUnion FromIGodKingFrequencyControllerComponent(IGodKingFrequencyControllerComponentT _igodkingfrequencycontrollercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGodKingFrequencyControllerComponent,
				Value = _igodkingfrequencycontrollercomponent
			};
		}

		// Token: 0x06020A6D RID: 133741 RVA: 0x00488AFA File Offset: 0x00486CFA
		public IPerformanceOptimizationComponentT AsIPerformanceOptimizationComponent()
		{
			return this.As<IPerformanceOptimizationComponentT>();
		}

		// Token: 0x06020A6E RID: 133742 RVA: 0x00488B02 File Offset: 0x00486D02
		public static IComponentBase_UnionUnion FromIPerformanceOptimizationComponent(IPerformanceOptimizationComponentT _iperformanceoptimizationcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPerformanceOptimizationComponent,
				Value = _iperformanceoptimizationcomponent
			};
		}

		// Token: 0x06020A6F RID: 133743 RVA: 0x00488B1B File Offset: 0x00486D1B
		public ISceneItemEventListenerComponentT AsISceneItemEventListenerComponent()
		{
			return this.As<ISceneItemEventListenerComponentT>();
		}

		// Token: 0x06020A70 RID: 133744 RVA: 0x00488B23 File Offset: 0x00486D23
		public static IComponentBase_UnionUnion FromISceneItemEventListenerComponent(ISceneItemEventListenerComponentT _isceneitemeventlistenercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISceneItemEventListenerComponent,
				Value = _isceneitemeventlistenercomponent
			};
		}

		// Token: 0x06020A71 RID: 133745 RVA: 0x00488B3C File Offset: 0x00486D3C
		public IDynamicSpawnMonsterPointComponentT AsIDynamicSpawnMonsterPointComponent()
		{
			return this.As<IDynamicSpawnMonsterPointComponentT>();
		}

		// Token: 0x06020A72 RID: 133746 RVA: 0x00488B44 File Offset: 0x00486D44
		public static IComponentBase_UnionUnion FromIDynamicSpawnMonsterPointComponent(IDynamicSpawnMonsterPointComponentT _idynamicspawnmonsterpointcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicSpawnMonsterPointComponent,
				Value = _idynamicspawnmonsterpointcomponent
			};
		}

		// Token: 0x06020A73 RID: 133747 RVA: 0x00488B5D File Offset: 0x00486D5D
		public IDynamicSpawnMonsterComponentT AsIDynamicSpawnMonsterComponent()
		{
			return this.As<IDynamicSpawnMonsterComponentT>();
		}

		// Token: 0x06020A74 RID: 133748 RVA: 0x00488B65 File Offset: 0x00486D65
		public static IComponentBase_UnionUnion FromIDynamicSpawnMonsterComponent(IDynamicSpawnMonsterComponentT _idynamicspawnmonstercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDynamicSpawnMonsterComponent,
				Value = _idynamicspawnmonstercomponent
			};
		}

		// Token: 0x06020A75 RID: 133749 RVA: 0x00488B7E File Offset: 0x00486D7E
		public ISunSpiritCollectComponentT AsISunSpiritCollectComponent()
		{
			return this.As<ISunSpiritCollectComponentT>();
		}

		// Token: 0x06020A76 RID: 133750 RVA: 0x00488B86 File Offset: 0x00486D86
		public static IComponentBase_UnionUnion FromISunSpiritCollectComponent(ISunSpiritCollectComponentT _isunspiritcollectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISunSpiritCollectComponent,
				Value = _isunspiritcollectcomponent
			};
		}

		// Token: 0x06020A77 RID: 133751 RVA: 0x00488B9F File Offset: 0x00486D9F
		public ISunSpiritLauncherComponentT AsISunSpiritLauncherComponent()
		{
			return this.As<ISunSpiritLauncherComponentT>();
		}

		// Token: 0x06020A78 RID: 133752 RVA: 0x00488BA7 File Offset: 0x00486DA7
		public static IComponentBase_UnionUnion FromISunSpiritLauncherComponent(ISunSpiritLauncherComponentT _isunspiritlaunchercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISunSpiritLauncherComponent,
				Value = _isunspiritlaunchercomponent
			};
		}

		// Token: 0x06020A79 RID: 133753 RVA: 0x00488BC0 File Offset: 0x00486DC0
		public ISunSpiritGearComponentT AsISunSpiritGearComponent()
		{
			return this.As<ISunSpiritGearComponentT>();
		}

		// Token: 0x06020A7A RID: 133754 RVA: 0x00488BC8 File Offset: 0x00486DC8
		public static IComponentBase_UnionUnion FromISunSpiritGearComponent(ISunSpiritGearComponentT _isunspiritgearcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISunSpiritGearComponent,
				Value = _isunspiritgearcomponent
			};
		}

		// Token: 0x06020A7B RID: 133755 RVA: 0x00488BE1 File Offset: 0x00486DE1
		public IMotorSlideComponentT AsIMotorSlideComponent()
		{
			return this.As<IMotorSlideComponentT>();
		}

		// Token: 0x06020A7C RID: 133756 RVA: 0x00488BE9 File Offset: 0x00486DE9
		public static IComponentBase_UnionUnion FromIMotorSlideComponent(IMotorSlideComponentT _imotorslidecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IMotorSlideComponent,
				Value = _imotorslidecomponent
			};
		}

		// Token: 0x06020A7D RID: 133757 RVA: 0x00488C02 File Offset: 0x00486E02
		public IProceduralVisualComponentT AsIProceduralVisualComponent()
		{
			return this.As<IProceduralVisualComponentT>();
		}

		// Token: 0x06020A7E RID: 133758 RVA: 0x00488C0A File Offset: 0x00486E0A
		public static IComponentBase_UnionUnion FromIProceduralVisualComponent(IProceduralVisualComponentT _iproceduralvisualcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IProceduralVisualComponent,
				Value = _iproceduralvisualcomponent
			};
		}

		// Token: 0x06020A7F RID: 133759 RVA: 0x00488C23 File Offset: 0x00486E23
		public IRoadNetworkNavigationComponentT AsIRoadNetworkNavigationComponent()
		{
			return this.As<IRoadNetworkNavigationComponentT>();
		}

		// Token: 0x06020A80 RID: 133760 RVA: 0x00488C2B File Offset: 0x00486E2B
		public static IComponentBase_UnionUnion FromIRoadNetworkNavigationComponent(IRoadNetworkNavigationComponentT _iroadnetworknavigationcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IRoadNetworkNavigationComponent,
				Value = _iroadnetworknavigationcomponent
			};
		}

		// Token: 0x06020A81 RID: 133761 RVA: 0x00488C44 File Offset: 0x00486E44
		public IFurnitureSlotComponentT AsIFurnitureSlotComponent()
		{
			return this.As<IFurnitureSlotComponentT>();
		}

		// Token: 0x06020A82 RID: 133762 RVA: 0x00488C4C File Offset: 0x00486E4C
		public static IComponentBase_UnionUnion FromIFurnitureSlotComponent(IFurnitureSlotComponentT _ifurnitureslotcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFurnitureSlotComponent,
				Value = _ifurnitureslotcomponent
			};
		}

		// Token: 0x06020A83 RID: 133763 RVA: 0x00488C65 File Offset: 0x00486E65
		public IVisionDisplayComponentT AsIVisionDisplayComponent()
		{
			return this.As<IVisionDisplayComponentT>();
		}

		// Token: 0x06020A84 RID: 133764 RVA: 0x00488C6D File Offset: 0x00486E6D
		public static IComponentBase_UnionUnion FromIVisionDisplayComponent(IVisionDisplayComponentT _ivisiondisplaycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IVisionDisplayComponent,
				Value = _ivisiondisplaycomponent
			};
		}

		// Token: 0x06020A85 RID: 133765 RVA: 0x00488C86 File Offset: 0x00486E86
		public ISystemModuleDataSyncComponentT AsISystemModuleDataSyncComponent()
		{
			return this.As<ISystemModuleDataSyncComponentT>();
		}

		// Token: 0x06020A86 RID: 133766 RVA: 0x00488C8E File Offset: 0x00486E8E
		public static IComponentBase_UnionUnion FromISystemModuleDataSyncComponent(ISystemModuleDataSyncComponentT _isystemmoduledatasynccomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ISystemModuleDataSyncComponent,
				Value = _isystemmoduledatasynccomponent
			};
		}

		// Token: 0x06020A87 RID: 133767 RVA: 0x00488CA7 File Offset: 0x00486EA7
		public IExhibitComponentT AsIExhibitComponent()
		{
			return this.As<IExhibitComponentT>();
		}

		// Token: 0x06020A88 RID: 133768 RVA: 0x00488CAF File Offset: 0x00486EAF
		public static IComponentBase_UnionUnion FromIExhibitComponent(IExhibitComponentT _iexhibitcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IExhibitComponent,
				Value = _iexhibitcomponent
			};
		}

		// Token: 0x06020A89 RID: 133769 RVA: 0x00488CC8 File Offset: 0x00486EC8
		public ITimeScheduleComponentT AsITimeScheduleComponent()
		{
			return this.As<ITimeScheduleComponentT>();
		}

		// Token: 0x06020A8A RID: 133770 RVA: 0x00488CD0 File Offset: 0x00486ED0
		public static IComponentBase_UnionUnion FromITimeScheduleComponent(ITimeScheduleComponentT _itimeschedulecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.ITimeScheduleComponent,
				Value = _itimeschedulecomponent
			};
		}

		// Token: 0x06020A8B RID: 133771 RVA: 0x00488CE9 File Offset: 0x00486EE9
		public IProjectorComponentT AsIProjectorComponent()
		{
			return this.As<IProjectorComponentT>();
		}

		// Token: 0x06020A8C RID: 133772 RVA: 0x00488CF1 File Offset: 0x00486EF1
		public static IComponentBase_UnionUnion FromIProjectorComponent(IProjectorComponentT _iprojectorcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IProjectorComponent,
				Value = _iprojectorcomponent
			};
		}

		// Token: 0x06020A8D RID: 133773 RVA: 0x00488D0A File Offset: 0x00486F0A
		public IProceduralMaterialComponentT AsIProceduralMaterialComponent()
		{
			return this.As<IProceduralMaterialComponentT>();
		}

		// Token: 0x06020A8E RID: 133774 RVA: 0x00488D12 File Offset: 0x00486F12
		public static IComponentBase_UnionUnion FromIProceduralMaterialComponent(IProceduralMaterialComponentT _iproceduralmaterialcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IProceduralMaterialComponent,
				Value = _iproceduralmaterialcomponent
			};
		}

		// Token: 0x06020A8F RID: 133775 RVA: 0x00488D2B File Offset: 0x00486F2B
		public IGameplayDataPersistenceComponentT AsIGameplayDataPersistenceComponent()
		{
			return this.As<IGameplayDataPersistenceComponentT>();
		}

		// Token: 0x06020A90 RID: 133776 RVA: 0x00488D33 File Offset: 0x00486F33
		public static IComponentBase_UnionUnion FromIGameplayDataPersistenceComponent(IGameplayDataPersistenceComponentT _igameplaydatapersistencecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGameplayDataPersistenceComponent,
				Value = _igameplaydatapersistencecomponent
			};
		}

		// Token: 0x06020A91 RID: 133777 RVA: 0x00488D4C File Offset: 0x00486F4C
		public IFlowerPollutionComponentT AsIFlowerPollutionComponent()
		{
			return this.As<IFlowerPollutionComponentT>();
		}

		// Token: 0x06020A92 RID: 133778 RVA: 0x00488D54 File Offset: 0x00486F54
		public static IComponentBase_UnionUnion FromIFlowerPollutionComponent(IFlowerPollutionComponentT _iflowerpollutioncomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IFlowerPollutionComponent,
				Value = _iflowerpollutioncomponent
			};
		}

		// Token: 0x06020A93 RID: 133779 RVA: 0x00488D6D File Offset: 0x00486F6D
		public IQuickHackComponentT AsIQuickHackComponent()
		{
			return this.As<IQuickHackComponentT>();
		}

		// Token: 0x06020A94 RID: 133780 RVA: 0x00488D75 File Offset: 0x00486F75
		public static IComponentBase_UnionUnion FromIQuickHackComponent(IQuickHackComponentT _iquickhackcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IQuickHackComponent,
				Value = _iquickhackcomponent
			};
		}

		// Token: 0x06020A95 RID: 133781 RVA: 0x00488D8E File Offset: 0x00486F8E
		public IDollGrabMachineComponentT AsIDollGrabMachineComponent()
		{
			return this.As<IDollGrabMachineComponentT>();
		}

		// Token: 0x06020A96 RID: 133782 RVA: 0x00488D96 File Offset: 0x00486F96
		public static IComponentBase_UnionUnion FromIDollGrabMachineComponent(IDollGrabMachineComponentT _idollgrabmachinecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDollGrabMachineComponent,
				Value = _idollgrabmachinecomponent
			};
		}

		// Token: 0x06020A97 RID: 133783 RVA: 0x00488DAF File Offset: 0x00486FAF
		public IDollGrabShowcaseComponentT AsIDollGrabShowcaseComponent()
		{
			return this.As<IDollGrabShowcaseComponentT>();
		}

		// Token: 0x06020A98 RID: 133784 RVA: 0x00488DB7 File Offset: 0x00486FB7
		public static IComponentBase_UnionUnion FromIDollGrabShowcaseComponent(IDollGrabShowcaseComponentT _idollgrabshowcasecomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDollGrabShowcaseComponent,
				Value = _idollgrabshowcasecomponent
			};
		}

		// Token: 0x06020A99 RID: 133785 RVA: 0x00488DD0 File Offset: 0x00486FD0
		public IWuWaGoComponentT AsIWuWaGoComponent()
		{
			return this.As<IWuWaGoComponentT>();
		}

		// Token: 0x06020A9A RID: 133786 RVA: 0x00488DD8 File Offset: 0x00486FD8
		public static IComponentBase_UnionUnion FromIWuWaGoComponent(IWuWaGoComponentT _iwuwagocomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IWuWaGoComponent,
				Value = _iwuwagocomponent
			};
		}

		// Token: 0x06020A9B RID: 133787 RVA: 0x00488DF1 File Offset: 0x00486FF1
		public IDragActorPlayComponentT AsIDragActorPlayComponent()
		{
			return this.As<IDragActorPlayComponentT>();
		}

		// Token: 0x06020A9C RID: 133788 RVA: 0x00488DF9 File Offset: 0x00486FF9
		public static IComponentBase_UnionUnion FromIDragActorPlayComponent(IDragActorPlayComponentT _idragactorplaycomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IDragActorPlayComponent,
				Value = _idragactorplaycomponent
			};
		}

		// Token: 0x06020A9D RID: 133789 RVA: 0x00488E12 File Offset: 0x00487012
		public IPathDrivenActorSpawnerComponentT AsIPathDrivenActorSpawnerComponent()
		{
			return this.As<IPathDrivenActorSpawnerComponentT>();
		}

		// Token: 0x06020A9E RID: 133790 RVA: 0x00488E1A File Offset: 0x0048701A
		public static IComponentBase_UnionUnion FromIPathDrivenActorSpawnerComponent(IPathDrivenActorSpawnerComponentT _ipathdrivenactorspawnercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IPathDrivenActorSpawnerComponent,
				Value = _ipathdrivenactorspawnercomponent
			};
		}

		// Token: 0x06020A9F RID: 133791 RVA: 0x00488E33 File Offset: 0x00487033
		public IElementalHolderComponentT AsIElementalHolderComponent()
		{
			return this.As<IElementalHolderComponentT>();
		}

		// Token: 0x06020AA0 RID: 133792 RVA: 0x00488E3B File Offset: 0x0048703B
		public static IComponentBase_UnionUnion FromIElementalHolderComponent(IElementalHolderComponentT _ielementalholdercomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IElementalHolderComponent,
				Value = _ielementalholdercomponent
			};
		}

		// Token: 0x06020AA1 RID: 133793 RVA: 0x00488E54 File Offset: 0x00487054
		public IElementalEffectComponentT AsIElementalEffectComponent()
		{
			return this.As<IElementalEffectComponentT>();
		}

		// Token: 0x06020AA2 RID: 133794 RVA: 0x00488E5C File Offset: 0x0048705C
		public static IComponentBase_UnionUnion FromIElementalEffectComponent(IElementalEffectComponentT _ielementaleffectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IElementalEffectComponent,
				Value = _ielementaleffectcomponent
			};
		}

		// Token: 0x06020AA3 RID: 133795 RVA: 0x00488E75 File Offset: 0x00487075
		public IElementalBoxFoundationComponentT AsIElementalBoxFoundationComponent()
		{
			return this.As<IElementalBoxFoundationComponentT>();
		}

		// Token: 0x06020AA4 RID: 133796 RVA: 0x00488E7D File Offset: 0x0048707D
		public static IComponentBase_UnionUnion FromIElementalBoxFoundationComponent(IElementalBoxFoundationComponentT _ielementalboxfoundationcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IElementalBoxFoundationComponent,
				Value = _ielementalboxfoundationcomponent
			};
		}

		// Token: 0x06020AA5 RID: 133797 RVA: 0x00488E96 File Offset: 0x00487096
		public IElementalWellComponentT AsIElementalWellComponent()
		{
			return this.As<IElementalWellComponentT>();
		}

		// Token: 0x06020AA6 RID: 133798 RVA: 0x00488E9E File Offset: 0x0048709E
		public static IComponentBase_UnionUnion FromIElementalWellComponent(IElementalWellComponentT _ielementalwellcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IElementalWellComponent,
				Value = _ielementalwellcomponent
			};
		}

		// Token: 0x06020AA7 RID: 133799 RVA: 0x00488EB7 File Offset: 0x004870B7
		public IStreamingSourceTriggerPointComponentT AsIStreamingSourceTriggerPointComponent()
		{
			return this.As<IStreamingSourceTriggerPointComponentT>();
		}

		// Token: 0x06020AA8 RID: 133800 RVA: 0x00488EBF File Offset: 0x004870BF
		public static IComponentBase_UnionUnion FromIStreamingSourceTriggerPointComponent(IStreamingSourceTriggerPointComponentT _istreamingsourcetriggerpointcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IStreamingSourceTriggerPointComponent,
				Value = _istreamingsourcetriggerpointcomponent
			};
		}

		// Token: 0x06020AA9 RID: 133801 RVA: 0x00488ED8 File Offset: 0x004870D8
		public IGraph3dComponentT AsIGraph3dComponent()
		{
			return this.As<IGraph3dComponentT>();
		}

		// Token: 0x06020AAA RID: 133802 RVA: 0x00488EE0 File Offset: 0x004870E0
		public static IComponentBase_UnionUnion FromIGraph3dComponent(IGraph3dComponentT _igraph3dcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGraph3dComponent,
				Value = _igraph3dcomponent
			};
		}

		// Token: 0x06020AAB RID: 133803 RVA: 0x00488EF9 File Offset: 0x004870F9
		public IGraph3dEffectComponentT AsIGraph3dEffectComponent()
		{
			return this.As<IGraph3dEffectComponentT>();
		}

		// Token: 0x06020AAC RID: 133804 RVA: 0x00488F01 File Offset: 0x00487101
		public static IComponentBase_UnionUnion FromIGraph3dEffectComponent(IGraph3dEffectComponentT _igraph3deffectcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.IGraph3dEffectComponent,
				Value = _igraph3deffectcomponent
			};
		}

		// Token: 0x06020AAD RID: 133805 RVA: 0x00488F1A File Offset: 0x0048711A
		public INoiseRemovalComponentT AsINoiseRemovalComponent()
		{
			return this.As<INoiseRemovalComponentT>();
		}

		// Token: 0x06020AAE RID: 133806 RVA: 0x00488F22 File Offset: 0x00487122
		public static IComponentBase_UnionUnion FromINoiseRemovalComponent(INoiseRemovalComponentT _inoiseremovalcomponent)
		{
			return new IComponentBase_UnionUnion
			{
				Type = IComponentBase_Union.INoiseRemovalComponent,
				Value = _inoiseremovalcomponent
			};
		}

		// Token: 0x06020AAF RID: 133807 RVA: 0x00488F3C File Offset: 0x0048713C
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
			default:
				return 0;
			}
		}
	}
}
