using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A7C RID: 23164
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ActivityConditionBase
	{
		// Token: 0x17006CC2 RID: 27842
		// (get) Token: 0x06039190 RID: 233872 RVA: 0x00FFE1D2 File Offset: 0x00FFC3D2
		// (set) Token: 0x06039191 RID: 233873 RVA: 0x00FFE1DA File Offset: 0x00FFC3DA
		public long UniqueId { get; private set; }

		// Token: 0x17006CC3 RID: 27843
		// (get) Token: 0x06039192 RID: 233874 RVA: 0x00FFE1E3 File Offset: 0x00FFC3E3
		// (set) Token: 0x06039193 RID: 233875 RVA: 0x00FFE1EB File Offset: 0x00FFC3EB
		public int ConditionId { get; private set; }

		// Token: 0x17006CC4 RID: 27844
		// (get) Token: 0x06039194 RID: 233876 RVA: 0x00FFE1F4 File Offset: 0x00FFC3F4
		internal bool CanListen
		{
			get
			{
				return this.CanListenInternal;
			}
		}

		// Token: 0x17006CC5 RID: 27845
		// (get) Token: 0x06039195 RID: 233877 RVA: 0x00FFE1FC File Offset: 0x00FFC3FC
		// (set) Token: 0x06039196 RID: 233878 RVA: 0x00FFE204 File Offset: 0x00FFC404
		internal EActivityConditionState State { get; private set; }

		// Token: 0x06039197 RID: 233879 RVA: 0x00FFE210 File Offset: 0x00FFC410
		internal bool Initialize(int conditionId, ConditionParams conditionParams)
		{
			return this.InitializeCore(conditionId, () => this.OnInitialize(conditionParams));
		}

		// Token: 0x06039198 RID: 233880 RVA: 0x00FFE244 File Offset: 0x00FFC444
		protected unsafe bool InitializeCore(int conditionId, Func<bool> initializeAction)
		{
			if (this.State != EActivityConditionState.Idle)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] Condition 状态异常，无法初始化";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", this.ConditionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uniqueId", this.UniqueId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("conditionType", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("state", this.State);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
			this.State = EActivityConditionState.Initializing;
			this.UniqueId = Interlocked.Increment(ref ActivityConditionBase.NextUniqueId);
			this.ConditionId = conditionId;
			bool removeEventListener = false;
			bool result;
			try
			{
				if (!initializeAction() || !this.ValidateInitialized())
				{
					result = this.RollbackInitialization(false);
				}
				else
				{
					removeEventListener = true;
					this.OnAddEventListener();
					this.State = EActivityConditionState.Active;
					result = true;
				}
			}
			catch (Exception ex)
			{
				this.State = EActivityConditionState.Faulted;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ActivityCondition;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[ActivityCondition] Condition 初始化异常";
				Exception error = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("conditionId", this.ConditionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("uniqueId", this.UniqueId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("conditionType", base.GetType().Name);
				instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				this.CleanupFaulted(removeEventListener);
				result = false;
			}
			return result;
		}

		// Token: 0x06039199 RID: 233881 RVA: 0x00FFE40C File Offset: 0x00FFC60C
		public unsafe bool Check()
		{
			if (this.State != EActivityConditionState.Active)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] 当前状态不允许执行 Check";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", this.ConditionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uniqueId", this.UniqueId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("conditionType", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("state", this.State);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
			if (ActivityConditionCenter.Instance.IsGmForced(this.ConditionId))
			{
				return true;
			}
			bool result;
			try
			{
				result = this.OnCheck();
			}
			catch (Exception ex)
			{
				this.State = EActivityConditionState.Faulted;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ActivityCondition;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[ActivityCondition] Condition 检查异常";
				Exception error = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("conditionId", this.ConditionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("uniqueId", this.UniqueId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("conditionType", base.GetType().Name);
				instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				result = false;
			}
			return result;
		}

		// Token: 0x0603919A RID: 233882 RVA: 0x00FFE59C File Offset: 0x00FFC79C
		protected void FinishExecute()
		{
			if (this.State != EActivityConditionState.Active)
			{
				return;
			}
			bool flag = this.Check();
			if (flag || this.State == EActivityConditionState.Faulted)
			{
				this.InvokeFinishCallback(flag);
			}
		}

		// Token: 0x0603919B RID: 233883 RVA: 0x00FFE5CD File Offset: 0x00FFC7CD
		protected void FinishExecute(bool isSuccess)
		{
			if (this.State != EActivityConditionState.Active)
			{
				return;
			}
			this.InvokeFinishCallback(isSuccess);
		}

		// Token: 0x0603919C RID: 233884 RVA: 0x00FFE5E0 File Offset: 0x00FFC7E0
		private unsafe void InvokeFinishCallback(bool isSuccess)
		{
			Action finishCallback = this.FinishCallback;
			if (finishCallback == null)
			{
				return;
			}
			long uniqueId = this.UniqueId;
			int conditionId = this.ConditionId;
			ActivityConditionBase activityConditionBase;
			bool flag = ActivityConditionCenter.Instance.TryGetCondition(uniqueId, out activityConditionBase);
			if (flag)
			{
				this.FinishCallback = null;
			}
			try
			{
				if (isSuccess || !flag)
				{
					finishCallback();
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] Condition 业务回调异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", conditionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uniqueId", uniqueId);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			finally
			{
				if (flag)
				{
					ActivityConditionCenter.Instance.Unregister(uniqueId);
				}
			}
		}

		// Token: 0x0603919D RID: 233885 RVA: 0x00FFE6BC File Offset: 0x00FFC8BC
		internal void Recheck()
		{
			this.FinishExecute();
		}

		// Token: 0x0603919E RID: 233886 RVA: 0x00FFE6C4 File Offset: 0x00FFC8C4
		internal bool SetFinishCallback(Action finishCallback)
		{
			if (this.State != EActivityConditionState.Active || this.FinishCallback != null)
			{
				return false;
			}
			this.FinishCallback = finishCallback;
			return true;
		}

		// Token: 0x0603919F RID: 233887 RVA: 0x00FFE6E4 File Offset: 0x00FFC8E4
		internal unsafe bool Clear()
		{
			if (this.State == EActivityConditionState.Idle || this.State == EActivityConditionState.Clearing)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] Condition 重复清理";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", this.ConditionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uniqueId", this.UniqueId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("conditionType", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("state", this.State);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
			this.State = EActivityConditionState.Clearing;
			this.FinishCallback = null;
			if (!this.CleanupHooks(true, "Condition 清理异常，实例不会重新进入对象池"))
			{
				this.State = EActivityConditionState.Faulted;
				return false;
			}
			this.ResetBaseData();
			this.State = EActivityConditionState.Idle;
			return true;
		}

		// Token: 0x060391A0 RID: 233888 RVA: 0x00FFE7E5 File Offset: 0x00FFC9E5
		private bool RollbackInitialization(bool removeEventListener)
		{
			this.State = EActivityConditionState.Clearing;
			this.FinishCallback = null;
			if (this.CleanupHooks(removeEventListener, "Condition 初始化回滚异常"))
			{
				this.ResetBaseData();
				this.State = EActivityConditionState.Idle;
			}
			else
			{
				this.State = EActivityConditionState.Faulted;
			}
			return false;
		}

		// Token: 0x060391A1 RID: 233889 RVA: 0x00FFE81A File Offset: 0x00FFCA1A
		private void CleanupFaulted(bool removeEventListener)
		{
			this.FinishCallback = null;
			this.CleanupHooks(removeEventListener, "Faulted Condition 清理仍然异常");
		}

		// Token: 0x060391A2 RID: 233890 RVA: 0x00FFE830 File Offset: 0x00FFCA30
		private unsafe bool CleanupHooks(bool removeEventListener, string errorMessage)
		{
			bool result = true;
			if (removeEventListener)
			{
				try
				{
					this.OnRemoveEventListener();
				}
				catch (Exception ex)
				{
					result = false;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.ActivityCondition;
					ELogAuthor author = ELogAuthor.BB;
					string message = "[ActivityCondition] " + errorMessage + "：移除事件监听失败";
					Exception error = ex;
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", this.ConditionId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uniqueId", this.UniqueId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("conditionType", base.GetType().Name);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
			try
			{
				this.OnClear();
			}
			catch (Exception ex2)
			{
				result = false;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ActivityCondition;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[ActivityCondition] " + errorMessage + "：清理字段失败";
				Exception error2 = ex2;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("conditionId", this.ConditionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("uniqueId", this.UniqueId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("conditionType", base.GetType().Name);
				instance2.ErrorWithStack(module2, author2, message2, error2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
			return result;
		}

		// Token: 0x060391A3 RID: 233891 RVA: 0x00FFE9B0 File Offset: 0x00FFCBB0
		private void ResetBaseData()
		{
			this.UniqueId = 0L;
			this.ConditionId = 0;
		}

		// Token: 0x060391A4 RID: 233892 RVA: 0x00FFE9C1 File Offset: 0x00FFCBC1
		protected virtual bool OnInitialize(ConditionParams conditionParams)
		{
			return false;
		}

		// Token: 0x060391A5 RID: 233893 RVA: 0x00FFE9C4 File Offset: 0x00FFCBC4
		protected virtual bool ValidateInitialized()
		{
			return true;
		}

		// Token: 0x060391A6 RID: 233894
		protected abstract bool OnCheck();

		// Token: 0x17006CC6 RID: 27846
		// (get) Token: 0x060391A7 RID: 233895 RVA: 0x00FFE9C7 File Offset: 0x00FFCBC7
		protected virtual bool CanListenInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060391A8 RID: 233896 RVA: 0x00FFE9CA File Offset: 0x00FFCBCA
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x060391A9 RID: 233897 RVA: 0x00FFE9CC File Offset: 0x00FFCBCC
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x060391AA RID: 233898 RVA: 0x00FFE9CE File Offset: 0x00FFCBCE
		protected virtual void OnClear()
		{
		}

		// Token: 0x0401E0B0 RID: 123056
		[StaticVariableRuleIgnore]
		private static long NextUniqueId;

		// Token: 0x0401E0B1 RID: 123057
		[Nullable(2)]
		private Action FinishCallback;
	}
}
