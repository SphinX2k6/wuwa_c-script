using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003544 RID: 13636
	public class ComponentAction
	{
		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x06022AD3 RID: 142035 RVA: 0x009DDD77 File Offset: 0x009DBF77
		private bool IsAsyncExecuting
		{
			get
			{
				return this.AsyncExecuteSet.Count > 0;
			}
		}

		// Token: 0x06022AD4 RID: 142036 RVA: 0x009DDD88 File Offset: 0x009DBF88
		public ComponentAction()
		{
			ComponentActionId instance = ComponentActionId.Instance;
			int num = instance.SelfIncrementId + 1;
			instance.SelfIncrementId = num;
			this.ComponentId = num;
		}

		// Token: 0x06022AD5 RID: 142037 RVA: 0x009DDDEA File Offset: 0x009DBFEA
		public static void SyncComponentId(int id)
		{
			ComponentActionId.Instance.SelfIncrementId = id;
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x06022AD6 RID: 142038 RVA: 0x009DDDF7 File Offset: 0x009DBFF7
		public bool IsRegister
		{
			get
			{
				return this.ComponentState == EComponentState.Register;
			}
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x06022AD7 RID: 142039 RVA: 0x009DDE02 File Offset: 0x009DC002
		public bool IsCreating
		{
			get
			{
				return this.ComponentState == EComponentState.Creating;
			}
		}

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x06022AD8 RID: 142040 RVA: 0x009DDE0D File Offset: 0x009DC00D
		public bool IsCreate
		{
			get
			{
				return this.ComponentState == EComponentState.Create;
			}
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x06022AD9 RID: 142041 RVA: 0x009DDE18 File Offset: 0x009DC018
		public bool IsCreateOrCreating
		{
			get
			{
				return this.IsCreating || this.IsCreate;
			}
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x06022ADA RID: 142042 RVA: 0x009DDE2A File Offset: 0x009DC02A
		public bool IsStarting
		{
			get
			{
				return this.ComponentState == EComponentState.Starting;
			}
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x06022ADB RID: 142043 RVA: 0x009DDE35 File Offset: 0x009DC035
		public bool IsStart
		{
			get
			{
				return this.ComponentState == EComponentState.Start;
			}
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x06022ADC RID: 142044 RVA: 0x009DDE40 File Offset: 0x009DC040
		public bool IsStartOrStarting
		{
			get
			{
				return this.IsStarting || this.IsStart;
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x06022ADD RID: 142045 RVA: 0x009DDE52 File Offset: 0x009DC052
		public bool IsShowing
		{
			get
			{
				return this.ComponentState == EComponentState.Showing;
			}
		}

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x06022ADE RID: 142046 RVA: 0x009DDE5D File Offset: 0x009DC05D
		public bool IsShow
		{
			get
			{
				return this.ComponentState == EComponentState.Show;
			}
		}

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x06022ADF RID: 142047 RVA: 0x009DDE68 File Offset: 0x009DC068
		public bool IsShowOrShowing
		{
			get
			{
				return this.IsShowing || this.IsShow;
			}
		}

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x06022AE0 RID: 142048 RVA: 0x009DDE7A File Offset: 0x009DC07A
		public bool IsHiding
		{
			get
			{
				return this.ComponentState == EComponentState.Hiding;
			}
		}

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x06022AE1 RID: 142049 RVA: 0x009DDE85 File Offset: 0x009DC085
		public bool IsHide
		{
			get
			{
				return this.ComponentState == EComponentState.Hide;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x06022AE2 RID: 142050 RVA: 0x009DDE90 File Offset: 0x009DC090
		public bool IsHideOrHiding
		{
			get
			{
				return this.IsHiding || this.IsHide;
			}
		}

		// Token: 0x1700488C RID: 18572
		// (get) Token: 0x06022AE3 RID: 142051 RVA: 0x009DDEA2 File Offset: 0x009DC0A2
		public bool IsDestroying
		{
			get
			{
				return this.ComponentState == EComponentState.Destroying;
			}
		}

		// Token: 0x1700488D RID: 18573
		// (get) Token: 0x06022AE4 RID: 142052 RVA: 0x009DDEAE File Offset: 0x009DC0AE
		public bool IsDestroy
		{
			get
			{
				return this.ComponentState == EComponentState.Destroy;
			}
		}

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x06022AE5 RID: 142053 RVA: 0x009DDEBA File Offset: 0x009DC0BA
		public bool IsDestroyOrDestroying
		{
			get
			{
				return this.IsDestroy || this.IsDestroying;
			}
		}

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x06022AE6 RID: 142054 RVA: 0x009DDECC File Offset: 0x009DC0CC
		public bool IsBusy
		{
			get
			{
				return this.IsCreating || this.IsStarting || this.IsShowing || this.IsHiding || this.IsDestroying || this.IsAsyncExecuting;
			}
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x06022AE7 RID: 142055 RVA: 0x009DDF00 File Offset: 0x009DC100
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

		// Token: 0x06022AE8 RID: 142056 RVA: 0x009DDF44 File Offset: 0x009DC144
		public UniTask<bool> CreateAsync()
		{
			ComponentAction.<CreateAsync>d__47 <CreateAsync>d__;
			<CreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CreateAsync>d__.<>4__this = this;
			<CreateAsync>d__.<>1__state = -1;
			<CreateAsync>d__.<>t__builder.Start<ComponentAction.<CreateAsync>d__47>(ref <CreateAsync>d__);
			return <CreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022AE9 RID: 142057 RVA: 0x009DDF88 File Offset: 0x009DC188
		public UniTask<bool> StartAsync()
		{
			ComponentAction.<StartAsync>d__48 <StartAsync>d__;
			<StartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartAsync>d__.<>4__this = this;
			<StartAsync>d__.<>1__state = -1;
			<StartAsync>d__.<>t__builder.Start<ComponentAction.<StartAsync>d__48>(ref <StartAsync>d__);
			return <StartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022AEA RID: 142058 RVA: 0x009DDFCC File Offset: 0x009DC1CC
		private UniTask<bool> StartAsyncImplement()
		{
			ComponentAction.<StartAsyncImplement>d__49 <StartAsyncImplement>d__;
			<StartAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartAsyncImplement>d__.<>4__this = this;
			<StartAsyncImplement>d__.<>1__state = -1;
			<StartAsyncImplement>d__.<>t__builder.Start<ComponentAction.<StartAsyncImplement>d__49>(ref <StartAsyncImplement>d__);
			return <StartAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022AEB RID: 142059 RVA: 0x009DE010 File Offset: 0x009DC210
		public UniTask<bool> ShowAsync()
		{
			ComponentAction.<ShowAsync>d__50 <ShowAsync>d__;
			<ShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowAsync>d__.<>4__this = this;
			<ShowAsync>d__.<>1__state = -1;
			<ShowAsync>d__.<>t__builder.Start<ComponentAction.<ShowAsync>d__50>(ref <ShowAsync>d__);
			return <ShowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022AEC RID: 142060 RVA: 0x009DE054 File Offset: 0x009DC254
		private UniTask<bool> ShowAsyncImplement()
		{
			ComponentAction.<ShowAsyncImplement>d__51 <ShowAsyncImplement>d__;
			<ShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowAsyncImplement>d__.<>4__this = this;
			<ShowAsyncImplement>d__.<>1__state = -1;
			<ShowAsyncImplement>d__.<>t__builder.Start<ComponentAction.<ShowAsyncImplement>d__51>(ref <ShowAsyncImplement>d__);
			return <ShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022AED RID: 142061 RVA: 0x009DE098 File Offset: 0x009DC298
		public UniTask<bool> HideAsync()
		{
			ComponentAction.<HideAsync>d__52 <HideAsync>d__;
			<HideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<HideAsync>d__.<>4__this = this;
			<HideAsync>d__.<>1__state = -1;
			<HideAsync>d__.<>t__builder.Start<ComponentAction.<HideAsync>d__52>(ref <HideAsync>d__);
			return <HideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022AEE RID: 142062 RVA: 0x009DE0DC File Offset: 0x009DC2DC
		private UniTask<bool> HideAsyncImplement()
		{
			ComponentAction.<HideAsyncImplement>d__53 <HideAsyncImplement>d__;
			<HideAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<HideAsyncImplement>d__.<>4__this = this;
			<HideAsyncImplement>d__.<>1__state = -1;
			<HideAsyncImplement>d__.<>t__builder.Start<ComponentAction.<HideAsyncImplement>d__53>(ref <HideAsyncImplement>d__);
			return <HideAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022AEF RID: 142063 RVA: 0x009DE120 File Offset: 0x009DC320
		public UniTask<bool> DestroyAsync()
		{
			ComponentAction.<DestroyAsync>d__54 <DestroyAsync>d__;
			<DestroyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DestroyAsync>d__.<>4__this = this;
			<DestroyAsync>d__.<>1__state = -1;
			<DestroyAsync>d__.<>t__builder.Start<ComponentAction.<DestroyAsync>d__54>(ref <DestroyAsync>d__);
			return <DestroyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022AF0 RID: 142064 RVA: 0x009DE164 File Offset: 0x009DC364
		public virtual UniTask<bool> CloseMeAsync()
		{
			ComponentAction.<CloseMeAsync>d__55 <CloseMeAsync>d__;
			<CloseMeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseMeAsync>d__.<>4__this = this;
			<CloseMeAsync>d__.<>1__state = -1;
			<CloseMeAsync>d__.<>t__builder.Start<ComponentAction.<CloseMeAsync>d__55>(ref <CloseMeAsync>d__);
			return <CloseMeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022AF1 RID: 142065 RVA: 0x009DE1A8 File Offset: 0x009DC3A8
		private UniTask<bool> DestroyAsyncImplement()
		{
			ComponentAction.<DestroyAsyncImplement>d__56 <DestroyAsyncImplement>d__;
			<DestroyAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DestroyAsyncImplement>d__.<>4__this = this;
			<DestroyAsyncImplement>d__.<>1__state = -1;
			<DestroyAsyncImplement>d__.<>t__builder.Start<ComponentAction.<DestroyAsyncImplement>d__56>(ref <DestroyAsyncImplement>d__);
			return <DestroyAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022AF2 RID: 142066 RVA: 0x009DE1EC File Offset: 0x009DC3EC
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

		// Token: 0x06022AF3 RID: 142067 RVA: 0x009DE220 File Offset: 0x009DC420
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

		// Token: 0x06022AF4 RID: 142068 RVA: 0x009DE254 File Offset: 0x009DC454
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

		// Token: 0x06022AF5 RID: 142069 RVA: 0x009DE288 File Offset: 0x009DC488
		protected virtual UniTask<bool> OnCreateAsyncImplement()
		{
			ComponentAction.<OnCreateAsyncImplement>d__60 <OnCreateAsyncImplement>d__;
			<OnCreateAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnCreateAsyncImplement>d__.<>1__state = -1;
			<OnCreateAsyncImplement>d__.<>t__builder.Start<ComponentAction.<OnCreateAsyncImplement>d__60>(ref <OnCreateAsyncImplement>d__);
			return <OnCreateAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022AF6 RID: 142070 RVA: 0x009DE2C3 File Offset: 0x009DC4C3
		protected virtual UniTask OnStartAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022AF7 RID: 142071 RVA: 0x009DE2CA File Offset: 0x009DC4CA
		protected virtual UniTask OnShowAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022AF8 RID: 142072 RVA: 0x009DE2D1 File Offset: 0x009DC4D1
		protected virtual void OnFinishShow()
		{
		}

		// Token: 0x06022AF9 RID: 142073 RVA: 0x009DE2D3 File Offset: 0x009DC4D3
		protected virtual UniTask OnHideAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022AFA RID: 142074 RVA: 0x009DE2DA File Offset: 0x009DC4DA
		protected virtual UniTask OnDestroyAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022AFB RID: 142075 RVA: 0x009DE2E4 File Offset: 0x009DC4E4
		private static bool IsPair(EActionCommandType? actionTypeA, EActionCommandType? actionTypeB)
		{
			EActionCommandType? eactionCommandType = actionTypeA;
			EActionCommandType? eactionCommandType2 = actionTypeB;
			return (eactionCommandType.GetValueOrDefault() == eactionCommandType2.GetValueOrDefault() & eactionCommandType != null == (eactionCommandType2 != null)) || (actionTypeA.GetValueOrDefault() == EActionCommandType.Show && actionTypeB.GetValueOrDefault() == EActionCommandType.Hide) || (actionTypeA.GetValueOrDefault() == EActionCommandType.Hide && actionTypeB.GetValueOrDefault() == EActionCommandType.Show);
		}

		// Token: 0x06022AFC RID: 142076 RVA: 0x009DE344 File Offset: 0x009DC544
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

		// Token: 0x06022AFD RID: 142077 RVA: 0x009DE38B File Offset: 0x009DC58B
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

		// Token: 0x06022AFE RID: 142078 RVA: 0x009DE39C File Offset: 0x009DC59C
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

		// Token: 0x06022AFF RID: 142079 RVA: 0x009DE43C File Offset: 0x009DC63C
		private UniTask ExecuteCachedActions()
		{
			ComponentAction.<ExecuteCachedActions>d__71 <ExecuteCachedActions>d__;
			<ExecuteCachedActions>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCachedActions>d__.<>4__this = this;
			<ExecuteCachedActions>d__.<>1__state = -1;
			<ExecuteCachedActions>d__.<>t__builder.Start<ComponentAction.<ExecuteCachedActions>d__71>(ref <ExecuteCachedActions>d__);
			return <ExecuteCachedActions>d__.<>t__builder.Task;
		}

		// Token: 0x06022B00 RID: 142080 RVA: 0x009DE47F File Offset: 0x009DC67F
		protected virtual void HandleCacheShowActionFailIfIsPair()
		{
		}

		// Token: 0x06022B01 RID: 142081 RVA: 0x009DE481 File Offset: 0x009DC681
		protected virtual void OnStartImplementCompatible()
		{
		}

		// Token: 0x06022B02 RID: 142082 RVA: 0x009DE483 File Offset: 0x009DC683
		protected virtual void OnShowImplementCompatible()
		{
		}

		// Token: 0x06022B03 RID: 142083 RVA: 0x009DE485 File Offset: 0x009DC685
		protected virtual void OnHideImplementCompatible()
		{
		}

		// Token: 0x06022B04 RID: 142084 RVA: 0x009DE487 File Offset: 0x009DC687
		protected virtual void OnDestroyImplementCompatible()
		{
		}

		// Token: 0x06022B05 RID: 142085 RVA: 0x009DE489 File Offset: 0x009DC689
		public void StartCompatible()
		{
			this.ComponentState = EComponentState.Starting;
			this.OnStartImplementCompatible();
			this.ComponentState = EComponentState.Start;
		}

		// Token: 0x06022B06 RID: 142086 RVA: 0x009DE49F File Offset: 0x009DC69F
		public void ShowCompatible()
		{
			this.ComponentState = EComponentState.Showing;
			this.OnShowImplementCompatible();
			this.ComponentState = EComponentState.Show;
		}

		// Token: 0x06022B07 RID: 142087 RVA: 0x009DE4B5 File Offset: 0x009DC6B5
		public void HideCompatible()
		{
			this.ComponentState = EComponentState.Hiding;
			this.OnHideImplementCompatible();
			this.ComponentState = EComponentState.Hide;
		}

		// Token: 0x06022B08 RID: 142088 RVA: 0x009DE4CB File Offset: 0x009DC6CB
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

		// Token: 0x04013376 RID: 78710
		[StaticVariableRuleIgnore]
		public static bool OpenLog = true;

		// Token: 0x04013377 RID: 78711
		[StaticVariableRuleIgnore]
		public static bool SwitchCheckSameTypeLogic = true;

		// Token: 0x04013378 RID: 78712
		public int ComponentId;

		// Token: 0x04013379 RID: 78713
		private EComponentState ComponentState;

		// Token: 0x0401337A RID: 78714
		public bool WaitToDestroy;

		// Token: 0x0401337B RID: 78715
		[Nullable(1)]
		public CustomPromise DeadPromise = new CustomPromise();

		// Token: 0x0401337C RID: 78716
		[Nullable(1)]
		private HashSet<EComponentState> AsyncExecuteSet = new HashSet<EComponentState>();

		// Token: 0x0401337D RID: 78717
		[Nullable(1)]
		private readonly global::LinkedList<ActionCommandNode> ActionLinkedList = new global::LinkedList<ActionCommandNode>(new ActionCommandNode
		{
			ActionCommand = EActionCommandType.Default,
			Processed = true
		});
	}
}
