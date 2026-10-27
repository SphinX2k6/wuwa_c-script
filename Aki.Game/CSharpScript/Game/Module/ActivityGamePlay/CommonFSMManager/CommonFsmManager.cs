using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager
{
	// Token: 0x02006934 RID: 26932
	public abstract class CommonFsmManager<TStateClass, TStateType> where TStateClass : ActivityGameplayTurnStateBase<TStateType> where TStateType : struct, Enum
	{
		// Token: 0x0604322F RID: 274991 RVA: 0x0105D6E8 File Offset: 0x0105B8E8
		public void Init()
		{
			if (this.IsInited)
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.WHJ, "CommonFsmManager 重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.InitState();
			this.IsInited = true;
		}

		// Token: 0x06043230 RID: 274992
		protected abstract void InitState();

		// Token: 0x06043231 RID: 274993 RVA: 0x0105D72C File Offset: 0x0105B92C
		public void Clear()
		{
			if (!this.IsInited)
			{
				return;
			}
			if (this.CurrentState != null)
			{
				this.CurrentState.Exit(null);
			}
			this.CurrentState = default(TStateClass);
			this.CurrentStateType = default(TStateType);
			this.StateMap.Clear();
			this.StateParentInfo.Clear();
			this.IsChangingState = false;
			this.IsInited = false;
			this.PendingStateType = null;
		}

		// Token: 0x06043232 RID: 274994 RVA: 0x0105D7B0 File Offset: 0x0105B9B0
		public void Tick(float deltaTime)
		{
			if (this.IsChangingState)
			{
				return;
			}
			if (this.CurrentState != null)
			{
				this.CurrentState.Tick(deltaTime);
			}
		}

		// Token: 0x06043233 RID: 274995 RVA: 0x0105D7DC File Offset: 0x0105B9DC
		protected void RegisterTransition(TStateType from, [Nullable(new byte[]
		{
			1,
			0
		})] List<TStateType> to)
		{
			if (this.StateParentInfo.ContainsKey(from))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "CommonFsmManager 状态流转重复";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("from", from);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.StateParentInfo[from] = to;
		}

		// Token: 0x06043234 RID: 274996 RVA: 0x0105D834 File Offset: 0x0105BA34
		protected void RegisterState(TStateType type, [Nullable(1)] TStateClass stateClass)
		{
			if (this.StateMap.ContainsKey(type))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "CommonFsmManager 注册状态失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stateType", stateClass);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.StateMap[type] = stateClass;
		}

		// Token: 0x06043235 RID: 274997 RVA: 0x0105D88C File Offset: 0x0105BA8C
		public UniTask ChangeState(TStateType stateType)
		{
			CommonFsmManager<TStateClass, TStateType>.<ChangeState>d__13 <ChangeState>d__;
			<ChangeState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeState>d__.<>4__this = this;
			<ChangeState>d__.stateType = stateType;
			<ChangeState>d__.<>1__state = -1;
			<ChangeState>d__.<>t__builder.Start<CommonFsmManager<TStateClass, TStateType>.<ChangeState>d__13>(ref <ChangeState>d__);
			return <ChangeState>d__.<>t__builder.Task;
		}

		// Token: 0x06043236 RID: 274998 RVA: 0x0105D8D8 File Offset: 0x0105BAD8
		[return: Nullable(2)]
		private TStateClass GetStateInstance(TStateType stateType)
		{
			if (!this.StateMap.ContainsKey(stateType))
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.WHJ, "CommonFsmManager 获取状态实例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return default(TStateClass);
			}
			return this.StateMap[stateType];
		}

		// Token: 0x06043237 RID: 274999 RVA: 0x0105D928 File Offset: 0x0105BB28
		public TStateType GetCurrentStateType()
		{
			return this.CurrentStateType;
		}

		// Token: 0x06043238 RID: 275000 RVA: 0x0105D930 File Offset: 0x0105BB30
		[NullableContext(2)]
		public TStateClass GetCurrentState()
		{
			return this.CurrentState;
		}

		// Token: 0x06043239 RID: 275001 RVA: 0x0105D938 File Offset: 0x0105BB38
		protected bool CheckCanChangeState(TStateType curStateType, TStateType nextStateType)
		{
			List<TStateType> list;
			return this.CurrentState == null || (this.StateParentInfo.TryGetValue(curStateType, out list) && list.Contains(nextStateType));
		}

		// Token: 0x04022F4B RID: 143179
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			0
		})]
		protected Dictionary<TStateType, List<TStateType>> StateParentInfo = new Dictionary<TStateType, List<TStateType>>();

		// Token: 0x04022F4C RID: 143180
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected Dictionary<TStateType, TStateClass> StateMap = new Dictionary<TStateType, TStateClass>();

		// Token: 0x04022F4D RID: 143181
		protected TStateType CurrentStateType;

		// Token: 0x04022F4E RID: 143182
		[Nullable(2)]
		protected TStateClass CurrentState;

		// Token: 0x04022F4F RID: 143183
		private bool IsChangingState;

		// Token: 0x04022F50 RID: 143184
		private bool IsInited;

		// Token: 0x04022F51 RID: 143185
		private TStateType? PendingStateType;
	}
}
