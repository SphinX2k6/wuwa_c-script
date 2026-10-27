using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200461B RID: 17947
	public class ComponentAction
	{
		// Token: 0x170075C6 RID: 30150
		// (get) Token: 0x0602E3DE RID: 189406 RVA: 0x00AB1683 File Offset: 0x00AAF883
		private bool IsAsyncExecuting
		{
			get
			{
				return this.AsyncExecuteSet.Count > 0;
			}
		}

		// Token: 0x0602E3DF RID: 189407 RVA: 0x00AB1694 File Offset: 0x00AAF894
		public ComponentAction()
		{
			ComponentActionId instance = ComponentActionId.Instance;
			int num = instance.SelfIncrementId + 1;
			instance.SelfIncrementId = num;
			this.ComponentId = num;
		}

		// Token: 0x0602E3E0 RID: 189408 RVA: 0x00AB16F6 File Offset: 0x00AAF8F6
		public static void SyncComponentId(int id)
		{
			ComponentActionId.Instance.SelfIncrementId = id;
		}

		// Token: 0x170075C7 RID: 30151
		// (get) Token: 0x0602E3E1 RID: 189409 RVA: 0x00AB1703 File Offset: 0x00AAF903
		public bool IsRegister
		{
			get
			{
				return this.ComponentState == EComponentState.Register;
			}
		}

		// Token: 0x170075C8 RID: 30152
		// (get) Token: 0x0602E3E2 RID: 189410 RVA: 0x00AB170E File Offset: 0x00AAF90E
		public bool IsCreating
		{
			get
			{
				return this.ComponentState == EComponentState.Creating;
			}
		}

		// Token: 0x170075C9 RID: 30153
		// (get) Token: 0x0602E3E3 RID: 189411 RVA: 0x00AB1719 File Offset: 0x00AAF919
		public bool IsCreate
		{
			get
			{
				return this.ComponentState == EComponentState.Create;
			}
		}

		// Token: 0x170075CA RID: 30154
		// (get) Token: 0x0602E3E4 RID: 189412 RVA: 0x00AB1724 File Offset: 0x00AAF924
		public bool IsCreateOrCreating
		{
			get
			{
				return this.IsCreating || this.IsCreate;
			}
		}

		// Token: 0x170075CB RID: 30155
		// (get) Token: 0x0602E3E5 RID: 189413 RVA: 0x00AB1736 File Offset: 0x00AAF936
		public bool IsStarting
		{
			get
			{
				return this.ComponentState == EComponentState.Starting;
			}
		}

		// Token: 0x170075CC RID: 30156
		// (get) Token: 0x0602E3E6 RID: 189414 RVA: 0x00AB1741 File Offset: 0x00AAF941
		public bool IsStart
		{
			get
			{
				return this.ComponentState == EComponentState.Start;
			}
		}

		// Token: 0x170075CD RID: 30157
		// (get) Token: 0x0602E3E7 RID: 189415 RVA: 0x00AB174C File Offset: 0x00AAF94C
		public bool IsStartOrStarting
		{
			get
			{
				return this.IsStarting || this.IsStart;
			}
		}

		// Token: 0x170075CE RID: 30158
		// (get) Token: 0x0602E3E8 RID: 189416 RVA: 0x00AB175E File Offset: 0x00AAF95E
		public bool IsShowing
		{
			get
			{
				return this.ComponentState == EComponentState.Showing;
			}
		}

		// Token: 0x170075CF RID: 30159
		// (get) Token: 0x0602E3E9 RID: 189417 RVA: 0x00AB1769 File Offset: 0x00AAF969
		public bool IsShow
		{
			get
			{
				return this.ComponentState == EComponentState.Show;
			}
		}

		// Token: 0x170075D0 RID: 30160
		// (get) Token: 0x0602E3EA RID: 189418 RVA: 0x00AB1774 File Offset: 0x00AAF974
		public bool IsShowOrShowing
		{
			get
			{
				return this.IsShowing || this.IsShow;
			}
		}

		// Token: 0x170075D1 RID: 30161
		// (get) Token: 0x0602E3EB RID: 189419 RVA: 0x00AB1786 File Offset: 0x00AAF986
		public bool IsHiding
		{
			get
			{
				return this.ComponentState == EComponentState.Hiding;
			}
		}

		// Token: 0x170075D2 RID: 30162
		// (get) Token: 0x0602E3EC RID: 189420 RVA: 0x00AB1791 File Offset: 0x00AAF991
		public bool IsHide
		{
			get
			{
				return this.ComponentState == EComponentState.Hide;
			}
		}

		// Token: 0x170075D3 RID: 30163
		// (get) Token: 0x0602E3ED RID: 189421 RVA: 0x00AB179C File Offset: 0x00AAF99C
		public bool IsHideOrHiding
		{
			get
			{
				return this.IsHiding || this.IsHide;
			}
		}

		// Token: 0x170075D4 RID: 30164
		// (get) Token: 0x0602E3EE RID: 189422 RVA: 0x00AB17AE File Offset: 0x00AAF9AE
		public bool IsDestroying
		{
			get
			{
				return this.ComponentState == EComponentState.Destroying;
			}
		}

		// Token: 0x170075D5 RID: 30165
		// (get) Token: 0x0602E3EF RID: 189423 RVA: 0x00AB17BA File Offset: 0x00AAF9BA
		public bool IsDestroy
		{
			get
			{
				return this.ComponentState == EComponentState.Destroy;
			}
		}

		// Token: 0x170075D6 RID: 30166
		// (get) Token: 0x0602E3F0 RID: 189424 RVA: 0x00AB17C6 File Offset: 0x00AAF9C6
		public bool IsDestroyOrDestroying
		{
			get
			{
				return this.IsDestroy || this.IsDestroying;
			}
		}

		// Token: 0x170075D7 RID: 30167
		// (get) Token: 0x0602E3F1 RID: 189425 RVA: 0x00AB17D8 File Offset: 0x00AAF9D8
		public bool IsBusy
		{
			get
			{
				return this.IsCreating || this.IsStarting || this.IsShowing || this.IsHiding || this.IsDestroying || this.IsAsyncExecuting;
			}
		}

		// Token: 0x170075D8 RID: 30168
		// (get) Token: 0x0602E3F2 RID: 189426 RVA: 0x00AB180C File Offset: 0x00AAFA0C
		public bool IsPendingDestroy
		{
			get
			{
				for (LinkedNode<ActionCommandNode> linkedNode = this.ActionLinkedList.GetHeadNextNode(); linkedNode != null; linkedNode = linkedNode.Next)
				{
					if (linkedNode.Element.ActionCommand == EActionCommandType.Destroy && !linkedNode.Element.Processed)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0602E3F3 RID: 189427 RVA: 0x00AB1850 File Offset: 0x00AAFA50
		public UniTask<bool> CreateAsync()
		{
			ComponentAction.<CreateAsync>d__47 <CreateAsync>d__;
			<CreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CreateAsync>d__.<>4__this = this;
			<CreateAsync>d__.<>1__state = -1;
			<CreateAsync>d__.<>t__builder.Start<ComponentAction.<CreateAsync>d__47>(ref <CreateAsync>d__);
			return <CreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3F4 RID: 189428 RVA: 0x00AB1894 File Offset: 0x00AAFA94
		public UniTask<bool> StartAsync()
		{
			ComponentAction.<StartAsync>d__48 <StartAsync>d__;
			<StartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartAsync>d__.<>4__this = this;
			<StartAsync>d__.<>1__state = -1;
			<StartAsync>d__.<>t__builder.Start<ComponentAction.<StartAsync>d__48>(ref <StartAsync>d__);
			return <StartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3F5 RID: 189429 RVA: 0x00AB18D8 File Offset: 0x00AAFAD8
		private UniTask<bool> StartAsyncImplement()
		{
			ComponentAction.<StartAsyncImplement>d__49 <StartAsyncImplement>d__;
			<StartAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartAsyncImplement>d__.<>4__this = this;
			<StartAsyncImplement>d__.<>1__state = -1;
			<StartAsyncImplement>d__.<>t__builder.Start<ComponentAction.<StartAsyncImplement>d__49>(ref <StartAsyncImplement>d__);
			return <StartAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3F6 RID: 189430 RVA: 0x00AB191C File Offset: 0x00AAFB1C
		public UniTask<bool> ShowAsync()
		{
			ComponentAction.<ShowAsync>d__50 <ShowAsync>d__;
			<ShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowAsync>d__.<>4__this = this;
			<ShowAsync>d__.<>1__state = -1;
			<ShowAsync>d__.<>t__builder.Start<ComponentAction.<ShowAsync>d__50>(ref <ShowAsync>d__);
			return <ShowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3F7 RID: 189431 RVA: 0x00AB1960 File Offset: 0x00AAFB60
		private UniTask<bool> ShowAsyncImplement()
		{
			ComponentAction.<ShowAsyncImplement>d__51 <ShowAsyncImplement>d__;
			<ShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowAsyncImplement>d__.<>4__this = this;
			<ShowAsyncImplement>d__.<>1__state = -1;
			<ShowAsyncImplement>d__.<>t__builder.Start<ComponentAction.<ShowAsyncImplement>d__51>(ref <ShowAsyncImplement>d__);
			return <ShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3F8 RID: 189432 RVA: 0x00AB19A4 File Offset: 0x00AAFBA4
		public UniTask<bool> HideAsync()
		{
			ComponentAction.<HideAsync>d__52 <HideAsync>d__;
			<HideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<HideAsync>d__.<>4__this = this;
			<HideAsync>d__.<>1__state = -1;
			<HideAsync>d__.<>t__builder.Start<ComponentAction.<HideAsync>d__52>(ref <HideAsync>d__);
			return <HideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3F9 RID: 189433 RVA: 0x00AB19E8 File Offset: 0x00AAFBE8
		private UniTask<bool> HideAsyncImplement()
		{
			ComponentAction.<HideAsyncImplement>d__53 <HideAsyncImplement>d__;
			<HideAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<HideAsyncImplement>d__.<>4__this = this;
			<HideAsyncImplement>d__.<>1__state = -1;
			<HideAsyncImplement>d__.<>t__builder.Start<ComponentAction.<HideAsyncImplement>d__53>(ref <HideAsyncImplement>d__);
			return <HideAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3FA RID: 189434 RVA: 0x00AB1A2C File Offset: 0x00AAFC2C
		public UniTask<bool> DestroyAsync()
		{
			ComponentAction.<DestroyAsync>d__54 <DestroyAsync>d__;
			<DestroyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DestroyAsync>d__.<>4__this = this;
			<DestroyAsync>d__.<>1__state = -1;
			<DestroyAsync>d__.<>t__builder.Start<ComponentAction.<DestroyAsync>d__54>(ref <DestroyAsync>d__);
			return <DestroyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3FB RID: 189435 RVA: 0x00AB1A70 File Offset: 0x00AAFC70
		public virtual UniTask<bool> CloseMeAsync()
		{
			ComponentAction.<CloseMeAsync>d__55 <CloseMeAsync>d__;
			<CloseMeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseMeAsync>d__.<>4__this = this;
			<CloseMeAsync>d__.<>1__state = -1;
			<CloseMeAsync>d__.<>t__builder.Start<ComponentAction.<CloseMeAsync>d__55>(ref <CloseMeAsync>d__);
			return <CloseMeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3FC RID: 189436 RVA: 0x00AB1AB4 File Offset: 0x00AAFCB4
		private UniTask<bool> DestroyAsyncImplement()
		{
			ComponentAction.<DestroyAsyncImplement>d__56 <DestroyAsyncImplement>d__;
			<DestroyAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DestroyAsyncImplement>d__.<>4__this = this;
			<DestroyAsyncImplement>d__.<>1__state = -1;
			<DestroyAsyncImplement>d__.<>t__builder.Start<ComponentAction.<DestroyAsyncImplement>d__56>(ref <DestroyAsyncImplement>d__);
			return <DestroyAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3FD RID: 189437 RVA: 0x00AB1AF8 File Offset: 0x00AAFCF8
		[NullableContext(2)]
		public void Show(Action callback = null)
		{
			this.ShowAsync().ContinueWith(delegate(bool task)
			{
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			});
		}

		// Token: 0x0602E3FE RID: 189438 RVA: 0x00AB1B2C File Offset: 0x00AAFD2C
		[NullableContext(2)]
		public void Hide(Action callback = null)
		{
			this.HideAsync().ContinueWith(delegate(bool task)
			{
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			});
		}

		// Token: 0x0602E3FF RID: 189439 RVA: 0x00AB1B60 File Offset: 0x00AAFD60
		[NullableContext(2)]
		public void Destroy(Action callback = null)
		{
			this.DestroyAsync().ContinueWith(delegate(bool task)
			{
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			});
		}

		// Token: 0x0602E400 RID: 189440 RVA: 0x00AB1B94 File Offset: 0x00AAFD94
		protected virtual UniTask<bool> OnCreateAsyncImplement()
		{
			ComponentAction.<OnCreateAsyncImplement>d__60 <OnCreateAsyncImplement>d__;
			<OnCreateAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnCreateAsyncImplement>d__.<>1__state = -1;
			<OnCreateAsyncImplement>d__.<>t__builder.Start<ComponentAction.<OnCreateAsyncImplement>d__60>(ref <OnCreateAsyncImplement>d__);
			return <OnCreateAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E401 RID: 189441 RVA: 0x00AB1BCF File Offset: 0x00AAFDCF
		protected virtual UniTask OnStartAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E402 RID: 189442 RVA: 0x00AB1BD6 File Offset: 0x00AAFDD6
		protected virtual UniTask OnShowAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E403 RID: 189443 RVA: 0x00AB1BDD File Offset: 0x00AAFDDD
		protected virtual void OnFinishShow()
		{
		}

		// Token: 0x0602E404 RID: 189444 RVA: 0x00AB1BDF File Offset: 0x00AAFDDF
		protected virtual UniTask OnHideAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E405 RID: 189445 RVA: 0x00AB1BE6 File Offset: 0x00AAFDE6
		protected virtual UniTask OnDestroyAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E406 RID: 189446 RVA: 0x00AB1BF0 File Offset: 0x00AAFDF0
		private static bool IsPair(EActionCommandType? actionTypeA, EActionCommandType? actionTypeB)
		{
			EActionCommandType? eactionCommandType = actionTypeA;
			EActionCommandType? eactionCommandType2 = actionTypeB;
			return (eactionCommandType.GetValueOrDefault() == eactionCommandType2.GetValueOrDefault() & eactionCommandType != null == (eactionCommandType2 != null)) || (actionTypeA.GetValueOrDefault() == EActionCommandType.Show && actionTypeB.GetValueOrDefault() == EActionCommandType.Hide) || (actionTypeA.GetValueOrDefault() == EActionCommandType.Hide && actionTypeB.GetValueOrDefault() == EActionCommandType.Show);
		}

		// Token: 0x0602E407 RID: 189447 RVA: 0x00AB1C50 File Offset: 0x00AAFE50
		private EActionCommandType GetCurrentActionType()
		{
			switch (this.ComponentState)
			{
			case EComponentState.Starting:
			case EComponentState.Start:
				return EActionCommandType.Start;
			case EComponentState.Showing:
			case EComponentState.Show:
				return EActionCommandType.Show;
			case EComponentState.Hiding:
			case EComponentState.Hide:
				return EActionCommandType.Hide;
			case EComponentState.Destroying:
			case EComponentState.Destroy:
				return EActionCommandType.Destroy;
			default:
				return EActionCommandType.Default;
			}
		}

		// Token: 0x0602E408 RID: 189448 RVA: 0x00AB1C97 File Offset: 0x00AAFE97
		private void HandleCacheActionFailIfIsPair(EActionCommandType actionTypeA, EActionCommandType actionTypeB)
		{
			if (actionTypeA == actionTypeB)
			{
				return;
			}
			if (actionTypeB == EActionCommandType.Show)
			{
				this.HandleCacheShowActionFailIfIsPair();
			}
		}

		// Token: 0x0602E409 RID: 189449 RVA: 0x00AB1CA8 File Offset: 0x00AAFEA8
		private bool TryCacheAction(EActionCommandType actionType)
		{
			if (!ComponentAction.SwitchCheckSameTypeLogic && this.GetCurrentActionType() == actionType)
			{
				return false;
			}
			LinkedNode<ActionCommandNode> tailNode = this.ActionLinkedList.TailNode;
			EActionCommandType actionCommand = tailNode.Element.ActionCommand;
			if (actionCommand == actionType)
			{
				return false;
			}
			if (actionCommand == EActionCommandType.Destroy)
			{
				return false;
			}
			if (ComponentAction.IsPair(new EActionCommandType?(actionCommand), new EActionCommandType?(actionType)))
			{
				this.HandleCacheActionFailIfIsPair(actionCommand, actionType);
				this.ActionLinkedList.RemoveNode(tailNode);
				return false;
			}
			if (ComponentAction.SwitchCheckSameTypeLogic && this.GetCurrentActionType() == actionType)
			{
				return false;
			}
			ActionCommandNode newElement = new ActionCommandNode
			{
				ActionCommand = actionType,
				Processed = false
			};
			this.ActionLinkedList.AddTail(newElement);
			return true;
		}

		// Token: 0x0602E40A RID: 189450 RVA: 0x00AB1D48 File Offset: 0x00AAFF48
		private UniTask ExecuteCachedActions()
		{
			ComponentAction.<ExecuteCachedActions>d__71 <ExecuteCachedActions>d__;
			<ExecuteCachedActions>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCachedActions>d__.<>4__this = this;
			<ExecuteCachedActions>d__.<>1__state = -1;
			<ExecuteCachedActions>d__.<>t__builder.Start<ComponentAction.<ExecuteCachedActions>d__71>(ref <ExecuteCachedActions>d__);
			return <ExecuteCachedActions>d__.<>t__builder.Task;
		}

		// Token: 0x0602E40B RID: 189451 RVA: 0x00AB1D8B File Offset: 0x00AAFF8B
		protected virtual void HandleCacheShowActionFailIfIsPair()
		{
		}

		// Token: 0x0602E40C RID: 189452 RVA: 0x00AB1D8D File Offset: 0x00AAFF8D
		protected virtual void OnStartImplementCompatible()
		{
		}

		// Token: 0x0602E40D RID: 189453 RVA: 0x00AB1D8F File Offset: 0x00AAFF8F
		protected virtual void OnShowImplementCompatible()
		{
		}

		// Token: 0x0602E40E RID: 189454 RVA: 0x00AB1D91 File Offset: 0x00AAFF91
		protected virtual void OnHideImplementCompatible()
		{
		}

		// Token: 0x0602E40F RID: 189455 RVA: 0x00AB1D93 File Offset: 0x00AAFF93
		protected virtual void OnDestroyImplementCompatible()
		{
		}

		// Token: 0x0602E410 RID: 189456 RVA: 0x00AB1D95 File Offset: 0x00AAFF95
		public void StartCompatible()
		{
			this.ComponentState = EComponentState.Starting;
			this.OnStartImplementCompatible();
			this.ComponentState = EComponentState.Start;
		}

		// Token: 0x0602E411 RID: 189457 RVA: 0x00AB1DAB File Offset: 0x00AAFFAB
		public void ShowCompatible()
		{
			this.ComponentState = EComponentState.Showing;
			this.OnShowImplementCompatible();
			this.ComponentState = EComponentState.Show;
		}

		// Token: 0x0602E412 RID: 189458 RVA: 0x00AB1DC1 File Offset: 0x00AAFFC1
		public void HideCompatible()
		{
			this.ComponentState = EComponentState.Hiding;
			this.OnHideImplementCompatible();
			this.ComponentState = EComponentState.Hide;
		}

		// Token: 0x0602E413 RID: 189459 RVA: 0x00AB1DD7 File Offset: 0x00AAFFD7
		public void DestroyCompatible()
		{
			if (this.IsShowOrShowing)
			{
				this.HideCompatible();
			}
			this.ComponentState = EComponentState.Destroying;
			this.OnDestroyImplementCompatible();
			this.ComponentState = EComponentState.Destroy;
			this.DeadPromise.SetResult();
		}

		// Token: 0x04018D37 RID: 101687
		[StaticVariableRuleIgnore]
		public static bool OpenLog = true;

		// Token: 0x04018D38 RID: 101688
		[StaticVariableRuleIgnore]
		public static bool SwitchCheckSameTypeLogic = true;

		// Token: 0x04018D39 RID: 101689
		public int ComponentId;

		// Token: 0x04018D3A RID: 101690
		private EComponentState ComponentState;

		// Token: 0x04018D3B RID: 101691
		public bool WaitToDestroy;

		// Token: 0x04018D3C RID: 101692
		[Nullable(1)]
		public CustomPromise DeadPromise = new CustomPromise();

		// Token: 0x04018D3D RID: 101693
		[Nullable(1)]
		private HashSet<EComponentState> AsyncExecuteSet = new HashSet<EComponentState>();

		// Token: 0x04018D3E RID: 101694
		[Nullable(1)]
		private readonly global::LinkedList<ActionCommandNode> ActionLinkedList = new global::LinkedList<ActionCommandNode>(new ActionCommandNode
		{
			ActionCommand = EActionCommandType.Default,
			Processed = true
		});
	}
}
