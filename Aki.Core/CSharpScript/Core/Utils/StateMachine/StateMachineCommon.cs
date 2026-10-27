using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Utils.StateMachine
{
	// Token: 0x0200012B RID: 299
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class StateMachineCommon<[Nullable(2)] TObject, [Nullable(2)] TState>
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x000345B4 File Offset: 0x000327B4
		public bool HasSubNode
		{
			get
			{
				return this.HasSubNodeInternal;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x000345BC File Offset: 0x000327BC
		public bool Activated
		{
			get
			{
				return this.ActivatedInternal;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x000345C4 File Offset: 0x000327C4
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

		// Token: 0x06000ABD RID: 2749 RVA: 0x000345DB File Offset: 0x000327DB
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00034603 File Offset: 0x00032803
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

		// Token: 0x06000ABF RID: 2751 RVA: 0x0003461A File Offset: 0x0003281A
		public void Tick(float delta)
		{
			StateMachineCommon<TObject, TState> currentNode = this.CurrentNode;
			if (currentNode != null)
			{
				currentNode.Tick(delta);
			}
			this.OnTick(delta);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00034635 File Offset: 0x00032835
		public void Start(params object[] pairs)
		{
			if (this.Parent != null)
			{
				this.Parent.Start(Array.Empty<object>());
				this.Parent.CurrentNode = this;
			}
			this.Enter(null, true, false, pairs);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00034668 File Offset: 0x00032868
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

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0003470C File Offset: 0x0003290C
		private void ReEnter()
		{
			this.OnReEnter();
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00034714 File Offset: 0x00032914
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

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0003476C File Offset: 0x0003296C
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

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000347E8 File Offset: 0x000329E8
		public virtual bool CanReEnter()
		{
			return false;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000347EB File Offset: 0x000329EB
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000347ED File Offset: 0x000329ED
		protected virtual void OnEnter([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> lastState = null, params object[] pairs)
		{
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000347EF File Offset: 0x000329EF
		protected virtual void OnReEnter()
		{
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000347F1 File Offset: 0x000329F1
		protected virtual void OnExit([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> nextState = null, params object[] pairs)
		{
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000347F3 File Offset: 0x000329F3
		protected virtual void OnClear()
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000347F5 File Offset: 0x000329F5
		protected virtual void OnActivate([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> last = null, params object[] pairs)
		{
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000347F7 File Offset: 0x000329F7
		protected virtual void OnDeactivate([Nullable(new byte[]
		{
			2,
			1,
			1
		})] StateMachineCommon<TObject, TState> next = null, params object[] pairs)
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000347F9 File Offset: 0x000329F9
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

		// Token: 0x06000ACE RID: 2766 RVA: 0x000347FC File Offset: 0x000329FC
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

		// Token: 0x06000ACF RID: 2767 RVA: 0x00034848 File Offset: 0x00032A48
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

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000348D8 File Offset: 0x00032AD8
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

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00034958 File Offset: 0x00032B58
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

		// Token: 0x040006A9 RID: 1705
		public readonly TObject Owner;

		// Token: 0x040006AA RID: 1706
		public readonly TState State;

		// Token: 0x040006AB RID: 1707
		[Nullable(2)]
		public TState FirstState;

		// Token: 0x040006AC RID: 1708
		private readonly Dictionary<TState, StateMachineCommon<TObject, TState>> StateMap = new Dictionary<TState, StateMachineCommon<TObject, TState>>();

		// Token: 0x040006AD RID: 1709
		private bool HasSubNodeInternal;

		// Token: 0x040006AE RID: 1710
		private bool ActivatedInternal;

		// Token: 0x040006AF RID: 1711
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public StateMachineCommon<TObject, TState> CurrentNode;

		// Token: 0x040006B0 RID: 1712
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public StateMachineCommon<TObject, TState> Parent;
	}
}
