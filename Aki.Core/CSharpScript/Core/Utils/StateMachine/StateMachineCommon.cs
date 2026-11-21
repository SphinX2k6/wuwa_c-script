using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Utils.StateMachine
{
	// Token: 0x0200012C RID: 300
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class StateMachineCommon<[Nullable(2)] TObject, [Nullable(2)] TState>
	{
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00035028 File Offset: 0x00033228
		public bool HasSubNode
		{
			get
			{
				return this.HasSubNodeInternal;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00035030 File Offset: 0x00033230
		public bool Activated
		{
			get
			{
				return this.ActivatedInternal;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00035038 File Offset: 0x00033238
		public virtual StateMachineCommon<TObject, TState> CurrentLeafNode
		{
			get
			{
				if (this.CurrentNode == null)
				{
					return this;
				}
				return this.CurrentNode.CurrentLeafNode;
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0003504F File Offset: 0x0003324F
		public StateMachineCommon(TObject owner, TState state, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> parent = null)
		{
			this.Owner = owner;
			this.State = state;
			this.Parent = parent;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00035077 File Offset: 0x00033277
		public StateMachineCommon<TObject, TState> Root
		{
			get
			{
				if (this.Parent == null)
				{
					return this;
				}
				return this.Parent.Root;
			}
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0003508E File Offset: 0x0003328E
		public void Tick(float delta)
		{
			StateMachineCommon<TObject, TState> currentNode = this.CurrentNode;
			if (currentNode != null)
			{
				currentNode.Tick(delta);
			}
			this.OnTick(delta);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x000350A9 File Offset: 0x000332A9
		public void Start(params object[] pairs)
		{
			if (this.Parent != null)
			{
				this.Parent.Start(Array.Empty<object>());
				this.Parent.CurrentNode = this;
			}
			this.Enter(null, true, false, pairs);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000350DC File Offset: 0x000332DC
		public void Enter([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> lastState = null, bool triggerEvent = true, bool triggerSubNode = true, params object[] pairs)
		{
			this.ActivatedInternal = true;
			this.OnActivate(lastState, pairs);
			if (triggerEvent)
			{
				this.OnEnter(lastState, pairs);
			}
			if (triggerSubNode && this.HasSubNodeInternal && this.FirstState != null)
			{
				this.CurrentNode = this.GetState(this.FirstState);
				if (this.CurrentNode != null)
				{
					this.CurrentNode.Enter(null, triggerEvent, true, pairs);
					if (new Action<StateMachineCommon<TObject, TState>, StateMachineCommon<TObject, TState>>(this.OnSwitchState) != null)
					{
						this.OnSwitchState(null, this.CurrentNode);
						return;
					}
				}
				else
				{
					Log.Instance.Error(ELogModule.StateMachine, ELogAuthor.WCL, "状态机切换失败，子节点查找失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00035180 File Offset: 0x00033380
		private void ReEnter()
		{
			this.OnReEnter();
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00035188 File Offset: 0x00033388
		public void Exit([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> nextState = null, bool triggerEvent = true, bool triggerSubNode = true, params object[] pairs)
		{
			if (triggerSubNode && this.CurrentNode != null)
			{
				this.OnSwitchState(this.CurrentNode, null);
				this.CurrentNode.Exit(nextState, triggerEvent, triggerSubNode, pairs);
			}
			this.OnDeactivate(nextState, pairs);
			this.OnExit(nextState, pairs);
			this.ActivatedInternal = false;
			this.CurrentNode = null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000351E0 File Offset: 0x000333E0
		public void Clear()
		{
			foreach (StateMachineCommon<TObject, TState> stateMachineCommon in this.StateMap.Values)
			{
				stateMachineCommon.Clear();
			}
			this.OnClear();
			this.StateMap.Clear();
			this.Parent = null;
			this.FirstState = default(TState);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0003525C File Offset: 0x0003345C
		public virtual bool CanReEnter()
		{
			return false;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0003525F File Offset: 0x0003345F
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00035261 File Offset: 0x00033461
		protected virtual void OnEnter([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> lastState = null, params object[] pairs)
		{
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00035263 File Offset: 0x00033463
		protected virtual void OnReEnter()
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00035265 File Offset: 0x00033465
		protected virtual void OnExit([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> nextState = null, params object[] pairs)
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00035267 File Offset: 0x00033467
		protected virtual void OnClear()
		{
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00035269 File Offset: 0x00033469
		protected virtual void OnActivate([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> last = null, params object[] pairs)
		{
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0003526B File Offset: 0x0003346B
		protected virtual void OnDeactivate([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> next = null, params object[] pairs)
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0003526D File Offset: 0x0003346D
		protected virtual void OnSwitchState([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> lastState, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> nextState)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00035270 File Offset: 0x00033470
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public StateMachineCommon<TObject, TState> GetState(TState state)
		{
			StateMachineCommon<TObject, TState> result;
			if (this.StateMap.TryGetValue(state, out result))
			{
				return result;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.StateMachine;
			ELogAuthor author = ELogAuthor.HCS;
			string message = "状态不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000352BC File Offset: 0x000334BC
		public void AddState(TState state, Func<TObject, TState, StateMachineCommon<TObject, TState>, StateMachineCommon<TObject, TState>> ctor)
		{
			if (this.FirstState == null || EqualityComparer<TState>.Default.Equals(this.FirstState, default(TState)))
			{
				this.FirstState = state;
			}
			StateMachineCommon<TObject, TState> value = ctor(this.Owner, state, this);
			if (!this.StateMap.TryAdd(state, value))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.StateMachine;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "状态重复添加";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.HasSubNodeInternal = true;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0003534C File Offset: 0x0003354C
		public void AddStateInstance(TState state, StateMachineCommon<TObject, TState> node)
		{
			if (this.FirstState == null || EqualityComparer<TState>.Default.Equals(this.FirstState, default(TState)))
			{
				this.FirstState = state;
			}
			if (!this.StateMap.TryAdd(state, node))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.StateMachine;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "状态重复添加";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.HasSubNodeInternal = true;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000353CC File Offset: 0x000335CC
		public bool Switch(TState state, bool triggerEvent = true, bool triggerSubNode = true, params object[] pairs)
		{
			if (this.CurrentNode == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.StateMachine;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "状态机没有启动";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			StateMachineCommon<TObject, TState> state2 = this.GetState(state);
			if (state2 == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.StateMachine;
				ELogAuthor author2 = ELogAuthor.WCL;
				string message2 = "状态机切换失败，目标节点不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("state", state);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (!EqualityComparer<TState>.Default.Equals(state, this.CurrentNode.State))
			{
				StateMachineCommon<TObject, TState> currentNode = this.CurrentNode;
				currentNode.Exit(state2, triggerEvent, triggerSubNode, pairs);
				this.CurrentNode = state2;
				state2.Enter(currentNode, triggerEvent, triggerSubNode, pairs);
				this.OnSwitchState(currentNode, state2);
				return true;
			}
			if (!this.CurrentNode.CanReEnter())
			{
				return false;
			}
			this.CurrentNode.ReEnter();
			return true;
		}

		// Token: 0x040006B7 RID: 1719
		public readonly TObject Owner;

		// Token: 0x040006B8 RID: 1720
		public readonly TState State;

		// Token: 0x040006B9 RID: 1721
		[Nullable(2)]
		public TState FirstState;

		// Token: 0x040006BA RID: 1722
		private readonly Dictionary<TState, StateMachineCommon<TObject, TState>> StateMap = new Dictionary<TState, StateMachineCommon<TObject, TState>>();

		// Token: 0x040006BB RID: 1723
		private bool HasSubNodeInternal;

		// Token: 0x040006BC RID: 1724
		private bool ActivatedInternal;

		// Token: 0x040006BD RID: 1725
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public StateMachineCommon<TObject, TState> CurrentNode;

		// Token: 0x040006BE RID: 1726
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public StateMachineCommon<TObject, TState> Parent;
	}
}
