using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager
{
	// Token: 0x02005884 RID: 22660
	public abstract class CommonFsmManager<TStateClass, TStateType> where TStateClass : ActivityGameplayTurnStateBase<TStateType> where TStateType : struct, Enum
	{
		// Token: 0x06037D87 RID: 228743 RVA: 0x00F9ED14 File Offset: 0x00F9CF14
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

		// Token: 0x06037D88 RID: 228744
		protected abstract void InitState();

		// Token: 0x06037D89 RID: 228745 RVA: 0x00F9ED58 File Offset: 0x00F9CF58
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

		// Token: 0x06037D8A RID: 228746 RVA: 0x00F9EDDC File Offset: 0x00F9CFDC
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

		// Token: 0x06037D8B RID: 228747 RVA: 0x00F9EE08 File Offset: 0x00F9D008
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

		// Token: 0x06037D8C RID: 228748 RVA: 0x00F9EE60 File Offset: 0x00F9D060
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

		// Token: 0x06037D8D RID: 228749 RVA: 0x00F9EEB8 File Offset: 0x00F9D0B8
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

		// Token: 0x06037D8E RID: 228750 RVA: 0x00F9EF04 File Offset: 0x00F9D104
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

		// Token: 0x06037D8F RID: 228751 RVA: 0x00F9EF54 File Offset: 0x00F9D154
		public TStateType GetCurrentStateType()
		{
			return this.CurrentStateType;
		}

		// Token: 0x06037D90 RID: 228752 RVA: 0x00F9EF5C File Offset: 0x00F9D15C
		[NullableContext(2)]
		public TStateClass GetCurrentState()
		{
			return this.CurrentState;
		}

		// Token: 0x06037D91 RID: 228753 RVA: 0x00F9EF64 File Offset: 0x00F9D164
		protected bool CheckCanChangeState(TStateType curStateType, TStateType nextStateType)
		{
			List<TStateType> list;
			return this.CurrentState == null || (this.StateParentInfo.TryGetValue(curStateType, out list) && list.Contains(nextStateType));
		}

		// Token: 0x0401D7A7 RID: 120743
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			0
		})]
		protected Dictionary<TStateType, List<TStateType>> StateParentInfo = new Dictionary<TStateType, List<TStateType>>();

		// Token: 0x0401D7A8 RID: 120744
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected Dictionary<TStateType, TStateClass> StateMap = new Dictionary<TStateType, TStateClass>();

		// Token: 0x0401D7A9 RID: 120745
		protected TStateType CurrentStateType;

		// Token: 0x0401D7AA RID: 120746
		[Nullable(2)]
		protected TStateClass CurrentState;

		// Token: 0x0401D7AB RID: 120747
		private bool IsChangingState;

		// Token: 0x0401D7AC RID: 120748
		private bool IsInited;

		// Token: 0x0401D7AD RID: 120749
		private TStateType? PendingStateType;
	}
}
