using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004D9 RID: 1241
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskFactory
	{
		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x000ED6DF File Offset: 0x000EB8DF
		private TaskScheduler DefaultScheduler
		{
			get
			{
				return this.m_defaultScheduler ?? TaskScheduler.Current;
			}
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x000ED6F0 File Offset: 0x000EB8F0
		private TaskScheduler GetDefaultScheduler(Task currTask)
		{
			TaskScheduler result;
			if ((result = this.m_defaultScheduler) == null)
			{
				if (currTask == null || (currTask.CreationOptions & TaskCreationOptions.HideScheduler) != TaskCreationOptions.None)
				{
					return TaskScheduler.Default;
				}
				result = currTask.ExecutingTaskScheduler;
			}
			return result;
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x00005ACC File Offset: 0x00003CCC
		public TaskFactory()
		{
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x000ED716 File Offset: 0x000EB916
		public TaskFactory(CancellationToken cancellationToken)
		{
			this.m_defaultCancellationToken = cancellationToken;
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x000ED725 File Offset: 0x000EB925
		[NullableContext(2)]
		public TaskFactory(TaskScheduler scheduler)
		{
			this.m_defaultScheduler = scheduler;
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x000ED734 File Offset: 0x000EB934
		public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			TaskFactory.CheckCreationOptions(creationOptions);
			this.m_defaultCreationOptions = creationOptions;
			this.m_defaultContinuationOptions = continuationOptions;
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x000ED756 File Offset: 0x000EB956
		[NullableContext(2)]
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) : this(creationOptions, continuationOptions)
		{
			this.m_defaultCancellationToken = cancellationToken;
			this.m_defaultScheduler = scheduler;
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x000ED76F File Offset: 0x000EB96F
		internal static void CheckCreationOptions(TaskCreationOptions creationOptions)
		{
			if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.creationOptions);
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x000ED77E File Offset: 0x000EB97E
		public CancellationToken CancellationToken
		{
			get
			{
				return this.m_defaultCancellationToken;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x000ED786 File Offset: 0x000EB986
		[Nullable(2)]
		public TaskScheduler Scheduler
		{
			[NullableContext(2)]
			get
			{
				return this.m_defaultScheduler;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060046FE RID: 18174 RVA: 0x000ED78E File Offset: 0x000EB98E
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.m_defaultCreationOptions;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x000ED796 File Offset: 0x000EB996
		public TaskContinuationOptions ContinuationOptions
		{
			get
			{
				return this.m_defaultContinuationOptions;
			}
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x000ED7A0 File Offset: 0x000EB9A0
		public Task StartNew(Action action)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, null, this.m_defaultCancellationToken, this.GetDefaultScheduler(internalCurrent), this.m_defaultCreationOptions, InternalTaskOptions.None);
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x000ED7D0 File Offset: 0x000EB9D0
		public Task StartNew(Action action, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, null, cancellationToken, this.GetDefaultScheduler(internalCurrent), this.m_defaultCreationOptions, InternalTaskOptions.None);
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x000ED7FC File Offset: 0x000EB9FC
		public Task StartNew(Action action, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, null, this.m_defaultCancellationToken, this.GetDefaultScheduler(internalCurrent), creationOptions, InternalTaskOptions.None);
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x000ED826 File Offset: 0x000EBA26
		public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task.InternalStartNew(Task.InternalCurrentIfAttached(creationOptions), action, null, cancellationToken, scheduler, creationOptions, InternalTaskOptions.None);
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x000ED83C File Offset: 0x000EBA3C
		public Task StartNew([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> action, [Nullable(2)] object state)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, state, this.m_defaultCancellationToken, this.GetDefaultScheduler(internalCurrent), this.m_defaultCreationOptions, InternalTaskOptions.None);
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x000ED86C File Offset: 0x000EBA6C
		public Task StartNew([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> action, [Nullable(2)] object state, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, state, cancellationToken, this.GetDefaultScheduler(internalCurrent), this.m_defaultCreationOptions, InternalTaskOptions.None);
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x000ED898 File Offset: 0x000EBA98
		public Task StartNew([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> action, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, state, this.m_defaultCancellationToken, this.GetDefaultScheduler(internalCurrent), creationOptions, InternalTaskOptions.None);
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x000ED8C2 File Offset: 0x000EBAC2
		public Task StartNew([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> action, [Nullable(2)] object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task.InternalStartNew(Task.InternalCurrentIfAttached(creationOptions), action, state, cancellationToken, scheduler, creationOptions, InternalTaskOptions.None);
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x000ED8D8 File Offset: 0x000EBAD8
		public Task<TResult> StartNew<[Nullable(2)] TResult>(Func<TResult> function)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, this.m_defaultCancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x000ED908 File Offset: 0x000EBB08
		public Task<TResult> StartNew<[Nullable(2)] TResult>(Func<TResult> function, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, cancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x000ED934 File Offset: 0x000EBB34
		public Task<TResult> StartNew<[Nullable(2)] TResult>(Func<TResult> function, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, this.m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x000ED95D File Offset: 0x000EBB5D
		public Task<TResult> StartNew<[Nullable(2)] TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler);
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x000ED970 File Offset: 0x000EBB70
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TResult> StartNew<TResult>([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, object state)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, this.m_defaultCancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x000ED9A0 File Offset: 0x000EBBA0
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TResult> StartNew<TResult>([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, object state, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, cancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x000ED9CC File Offset: 0x000EBBCC
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TResult> StartNew<TResult>([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, this.m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x000ED9F6 File Offset: 0x000EBBF6
		public Task<TResult> StartNew<[Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, [Nullable(2)] object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, state, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler);
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x000EDA0C File Offset: 0x000EBC0C
		public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod)
		{
			return this.FromAsync(asyncResult, endMethod, this.m_defaultCreationOptions, this.DefaultScheduler);
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x000EDA22 File Offset: 0x000EBC22
		public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions)
		{
			return this.FromAsync(asyncResult, endMethod, creationOptions, this.DefaultScheduler);
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x000EDA33 File Offset: 0x000EBC33
		public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl(asyncResult, null, endMethod, creationOptions, scheduler);
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x000EDA40 File Offset: 0x000EBC40
		public Task FromAsync([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, [Nullable(2)] object state)
		{
			return this.FromAsync(beginMethod, endMethod, state, this.m_defaultCreationOptions);
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x000EDA51 File Offset: 0x000EBC51
		public Task FromAsync([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl(beginMethod, null, endMethod, state, creationOptions);
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x000EDA5E File Offset: 0x000EBC5E
		public Task FromAsync<[Nullable(2)] TArg1>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, [Nullable(2)] object state)
		{
			return this.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, this.m_defaultCreationOptions);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x000EDA71 File Offset: 0x000EBC71
		public Task FromAsync<[Nullable(2)] TArg1>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl<TArg1>(beginMethod, null, endMethod, arg1, state, creationOptions);
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x000EDA80 File Offset: 0x000EBC80
		public Task FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, [Nullable(2)] object state)
		{
			return this.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, this.m_defaultCreationOptions);
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x000EDA95 File Offset: 0x000EBC95
		public Task FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, null, endMethod, arg1, arg2, state, creationOptions);
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x000EDAA6 File Offset: 0x000EBCA6
		public Task FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2, [Nullable(2)] TArg3>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, [Nullable(2)] object state)
		{
			return this.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, this.m_defaultCreationOptions);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x000EDABD File Offset: 0x000EBCBD
		public Task FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2, [Nullable(2)] TArg3>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, null, endMethod, arg1, arg2, arg3, state, creationOptions);
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x000EDAD0 File Offset: 0x000EBCD0
		public Task<TResult> FromAsync<[Nullable(2)] TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, this.m_defaultCreationOptions, this.DefaultScheduler);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x000EDAE6 File Offset: 0x000EBCE6
		public Task<TResult> FromAsync<[Nullable(2)] TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, this.DefaultScheduler);
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x000EDAF7 File Offset: 0x000EBCF7
		public Task<TResult> FromAsync<[Nullable(2)] TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, scheduler);
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x000EDB04 File Offset: 0x000EBD04
		public Task<TResult> FromAsync<[Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, [Nullable(2)] object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, this.m_defaultCreationOptions);
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x000EDB15 File Offset: 0x000EBD15
		public Task<TResult> FromAsync<[Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, creationOptions);
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x000EDB22 File Offset: 0x000EBD22
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, [Nullable(2)] object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1>(beginMethod, endMethod, null, arg1, state, this.m_defaultCreationOptions);
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x000EDB35 File Offset: 0x000EBD35
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1>(beginMethod, endMethod, null, arg1, state, creationOptions);
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x000EDB44 File Offset: 0x000EBD44
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2, [Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, [Nullable(2)] object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, endMethod, null, arg1, arg2, state, this.m_defaultCreationOptions);
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x000EDB59 File Offset: 0x000EBD59
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2, [Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, endMethod, null, arg1, arg2, state, creationOptions);
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x000EDB6A File Offset: 0x000EBD6A
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2, [Nullable(2)] TArg3, [Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, [Nullable(2)] object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, endMethod, null, arg1, arg2, arg3, state, this.m_defaultCreationOptions);
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x000EDB81 File Offset: 0x000EBD81
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2, [Nullable(2)] TArg3, [Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, endMethod, null, arg1, arg2, arg3, state, creationOptions);
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x000EDB94 File Offset: 0x000EBD94
		internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
		{
			if (hasBeginMethod)
			{
				if ((creationOptions & TaskCreationOptions.LongRunning) != TaskCreationOptions.None)
				{
					throw new ArgumentOutOfRangeException("creationOptions", SR.Task_FromAsync_LongRunning);
				}
				if ((creationOptions & TaskCreationOptions.PreferFairness) != TaskCreationOptions.None)
				{
					throw new ArgumentOutOfRangeException("creationOptions", SR.Task_FromAsync_PreferFairness);
				}
			}
			if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler)) != TaskCreationOptions.None)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.creationOptions);
			}
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x000EDBD0 File Offset: 0x000EBDD0
		internal static Task<Task[]> CommonCWAllLogic(Task[] tasksCopy)
		{
			TaskFactory.CompleteOnCountdownPromise completeOnCountdownPromise = new TaskFactory.CompleteOnCountdownPromise(tasksCopy);
			for (int i = 0; i < tasksCopy.Length; i++)
			{
				if (tasksCopy[i].IsCompleted)
				{
					completeOnCountdownPromise.Invoke(tasksCopy[i]);
				}
				else
				{
					tasksCopy[i].AddCompletionAction(completeOnCountdownPromise, false);
				}
			}
			return completeOnCountdownPromise;
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x000EDC14 File Offset: 0x000EBE14
		internal static Task<Task<T>[]> CommonCWAllLogic<T>(Task<T>[] tasksCopy)
		{
			TaskFactory.CompleteOnCountdownPromise<T> completeOnCountdownPromise = new TaskFactory.CompleteOnCountdownPromise<T>(tasksCopy);
			for (int i = 0; i < tasksCopy.Length; i++)
			{
				if (tasksCopy[i].IsCompleted)
				{
					completeOnCountdownPromise.Invoke(tasksCopy[i]);
				}
				else
				{
					tasksCopy[i].AddCompletionAction(completeOnCountdownPromise, false);
				}
			}
			return completeOnCountdownPromise;
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x000EDC56 File Offset: 0x000EBE56
		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x000EDC7D File Offset: 0x000EBE7D
		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x000EDC9F File Offset: 0x000EBE9F
		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, TaskContinuationOptions continuationOptions)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x000EDCC1 File Offset: 0x000EBEC1
		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x000EDCDB File Offset: 0x000EBEDB
		public Task ContinueWhenAll<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, null, continuationAction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x000EDD02 File Offset: 0x000EBF02
		public Task ContinueWhenAll<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, null, continuationAction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x000EDD24 File Offset: 0x000EBF24
		public Task ContinueWhenAll<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, null, continuationAction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x000EDD46 File Offset: 0x000EBF46
		public Task ContinueWhenAll<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, null, continuationAction, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x000EDD60 File Offset: 0x000EBF60
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x000EDD87 File Offset: 0x000EBF87
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x000EDDA9 File Offset: 0x000EBFA9
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x000EDDCB File Offset: 0x000EBFCB
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x000EDDE5 File Offset: 0x000EBFE5
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TAntecedentResult, [Nullable(2)] TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, null, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x000EDE0C File Offset: 0x000EC00C
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TAntecedentResult, [Nullable(2)] TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, null, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x000EDE2E File Offset: 0x000EC02E
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TAntecedentResult, [Nullable(2)] TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, null, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x000EDE50 File Offset: 0x000EC050
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TAntecedentResult, [Nullable(2)] TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x000EDE6C File Offset: 0x000EC06C
		internal static Task<TTask> CommonCWAnyLogic<TTask>(IList<TTask> tasks, bool isSyncBlocking = false) where TTask : Task
		{
			TaskFactory.CompleteOnInvokePromise<TTask> completeOnInvokePromise = new TaskFactory.CompleteOnInvokePromise<TTask>(tasks, isSyncBlocking);
			bool flag = false;
			int count = tasks.Count;
			for (int i = 0; i < count; i++)
			{
				TTask ttask = tasks[i];
				if (ttask == null)
				{
					throw new ArgumentException(SR.Task_MultiTaskContinuation_NullTask, "tasks");
				}
				Task task = ttask;
				if (!flag)
				{
					if (completeOnInvokePromise.IsCompleted)
					{
						flag = true;
					}
					else if (task.IsCompleted)
					{
						completeOnInvokePromise.Invoke(task);
						flag = true;
					}
					else
					{
						task.AddCompletionAction(completeOnInvokePromise, isSyncBlocking);
						if (completeOnInvokePromise.IsCompleted)
						{
							task.RemoveContinuation(completeOnInvokePromise);
						}
					}
				}
			}
			return completeOnInvokePromise;
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x000EDEFB File Offset: 0x000EC0FB
		internal static void CommonCWAnyLogicCleanup(Task<Task> continuation)
		{
			((TaskFactory.CompleteOnInvokePromise<Task>)continuation).Invoke(null);
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x000EDF09 File Offset: 0x000EC109
		public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x000EDF30 File Offset: 0x000EC130
		public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x000EDF52 File Offset: 0x000EC152
		public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x000EDF74 File Offset: 0x000EC174
		public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x000EDF8E File Offset: 0x000EC18E
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TResult>(Task[] tasks, Func<Task, TResult> continuationFunction)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x000EDFB5 File Offset: 0x000EC1B5
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x000EDFD7 File Offset: 0x000EC1D7
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x000EDFF9 File Offset: 0x000EC1F9
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x000EE013 File Offset: 0x000EC213
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TAntecedentResult, [Nullable(2)] TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, null, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x000EE03A File Offset: 0x000EC23A
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TAntecedentResult, [Nullable(2)] TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, null, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x000EE05C File Offset: 0x000EC25C
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TAntecedentResult, [Nullable(2)] TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, null, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x000EE07E File Offset: 0x000EC27E
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TAntecedentResult, [Nullable(2)] TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			ArgumentNullException.ThrowIfNull(continuationFunction, "continuationFunction");
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x000EE098 File Offset: 0x000EC298
		public Task ContinueWhenAny<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, null, continuationAction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x000EE0BF File Offset: 0x000EC2BF
		public Task ContinueWhenAny<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, null, continuationAction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x000EE0E1 File Offset: 0x000EC2E1
		public Task ContinueWhenAny<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, null, continuationAction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x000EE103 File Offset: 0x000EC303
		public Task ContinueWhenAny<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			ArgumentNullException.ThrowIfNull(continuationAction, "continuationAction");
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, null, continuationAction, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x000EE120 File Offset: 0x000EC320
		internal static Task[] CheckMultiContinuationTasksAndCopy(Task[] tasks)
		{
			ArgumentNullException.ThrowIfNull(tasks, "tasks");
			if (tasks.Length == 0)
			{
				throw new ArgumentException(SR.Task_MultiTaskContinuation_EmptyTaskList, "tasks");
			}
			Task[] array = new Task[tasks.Length];
			for (int i = 0; i < tasks.Length; i++)
			{
				array[i] = tasks[i];
				if (array[i] == null)
				{
					throw new ArgumentException(SR.Task_MultiTaskContinuation_NullTask, "tasks");
				}
			}
			return array;
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x000EE180 File Offset: 0x000EC380
		internal static Task<TResult>[] CheckMultiContinuationTasksAndCopy<TResult>(Task<TResult>[] tasks)
		{
			ArgumentNullException.ThrowIfNull(tasks, "tasks");
			if (tasks.Length == 0)
			{
				throw new ArgumentException(SR.Task_MultiTaskContinuation_EmptyTaskList, "tasks");
			}
			Task<TResult>[] array = new Task<TResult>[tasks.Length];
			for (int i = 0; i < tasks.Length; i++)
			{
				array[i] = tasks[i];
				if (array[i] == null)
				{
					throw new ArgumentException(SR.Task_MultiTaskContinuation_NullTask, "tasks");
				}
			}
			return array;
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x000EE1E0 File Offset: 0x000EC3E0
		internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
		{
			if ((continuationOptions & (TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously)) == (TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously))
			{
				throw new ArgumentOutOfRangeException("continuationOptions", SR.Task_ContinueWith_ESandLR);
			}
			if ((continuationOptions & ~(TaskContinuationOptions.PreferFairness | TaskContinuationOptions.LongRunning | TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.HideScheduler | TaskContinuationOptions.LazyCancellation | TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled | TaskContinuationOptions.ExecuteSynchronously)) != TaskContinuationOptions.None)
			{
				throw new ArgumentOutOfRangeException("continuationOptions");
			}
			if ((continuationOptions & (TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled)) != TaskContinuationOptions.None)
			{
				throw new ArgumentOutOfRangeException("continuationOptions", SR.Task_MultiTaskContinuation_FireOptions);
			}
		}

		// Token: 0x040010AB RID: 4267
		private readonly CancellationToken m_defaultCancellationToken;

		// Token: 0x040010AC RID: 4268
		private readonly TaskScheduler m_defaultScheduler;

		// Token: 0x040010AD RID: 4269
		private readonly TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x040010AE RID: 4270
		private readonly TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x020004DA RID: 1242
		private sealed class CompleteOnCountdownPromise : Task<Task[]>, ITaskCompletionAction
		{
			// Token: 0x0600474E RID: 18254 RVA: 0x000EE238 File Offset: 0x000EC438
			internal CompleteOnCountdownPromise(Task[] tasksCopy)
			{
				this._tasks = tasksCopy;
				this._count = tasksCopy.Length;
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationBegin(base.Id, "TaskFactory.ContinueWhenAll", 0L);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.AddToActiveTasks(this);
				}
			}

			// Token: 0x0600474F RID: 18255 RVA: 0x000EE28C File Offset: 0x000EC48C
			public void Invoke(Task completingTask)
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationRelation(base.Id, CausalityRelation.Join);
				}
				if (completingTask.IsWaitNotificationEnabled)
				{
					base.SetNotificationForWaitCompletion(true);
				}
				if (Interlocked.Decrement(ref this._count) == 0)
				{
					if (TplEventSource.Log.IsEnabled())
					{
						TplEventSource.Log.TraceOperationEnd(base.Id, AsyncCausalityStatus.Completed);
					}
					if (Task.s_asyncDebuggingEnabled)
					{
						Task.RemoveFromActiveTasks(this);
					}
					base.TrySetResult(this._tasks);
				}
			}

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x06004750 RID: 18256 RVA: 0x000070DD File Offset: 0x000052DD
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000C97 RID: 3223
			// (get) Token: 0x06004751 RID: 18257 RVA: 0x000EE309 File Offset: 0x000EC509
			private protected override bool ShouldNotifyDebuggerOfWaitCompletion
			{
				get
				{
					return base.ShouldNotifyDebuggerOfWaitCompletion && Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(this._tasks);
				}
			}

			// Token: 0x040010AF RID: 4271
			private readonly Task[] _tasks;

			// Token: 0x040010B0 RID: 4272
			private int _count;
		}

		// Token: 0x020004DB RID: 1243
		private sealed class CompleteOnCountdownPromise<T> : Task<Task<T>[]>, ITaskCompletionAction
		{
			// Token: 0x06004752 RID: 18258 RVA: 0x000EE320 File Offset: 0x000EC520
			internal CompleteOnCountdownPromise(Task<T>[] tasksCopy)
			{
				this._tasks = tasksCopy;
				this._count = tasksCopy.Length;
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationBegin(base.Id, "TaskFactory.ContinueWhenAll<>", 0L);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.AddToActiveTasks(this);
				}
			}

			// Token: 0x06004753 RID: 18259 RVA: 0x000EE374 File Offset: 0x000EC574
			public void Invoke(Task completingTask)
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationRelation(base.Id, CausalityRelation.Join);
				}
				if (completingTask.IsWaitNotificationEnabled)
				{
					base.SetNotificationForWaitCompletion(true);
				}
				if (Interlocked.Decrement(ref this._count) == 0)
				{
					if (TplEventSource.Log.IsEnabled())
					{
						TplEventSource.Log.TraceOperationEnd(base.Id, AsyncCausalityStatus.Completed);
					}
					if (Task.s_asyncDebuggingEnabled)
					{
						Task.RemoveFromActiveTasks(this);
					}
					base.TrySetResult(this._tasks);
				}
			}

			// Token: 0x17000C98 RID: 3224
			// (get) Token: 0x06004754 RID: 18260 RVA: 0x000070DD File Offset: 0x000052DD
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000C99 RID: 3225
			// (get) Token: 0x06004755 RID: 18261 RVA: 0x000EE3F4 File Offset: 0x000EC5F4
			private protected override bool ShouldNotifyDebuggerOfWaitCompletion
			{
				get
				{
					if (base.ShouldNotifyDebuggerOfWaitCompletion)
					{
						Task[] tasks = this._tasks;
						return Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(tasks);
					}
					return false;
				}
			}

			// Token: 0x040010B1 RID: 4273
			private readonly Task<T>[] _tasks;

			// Token: 0x040010B2 RID: 4274
			private int _count;
		}

		// Token: 0x020004DC RID: 1244
		internal sealed class CompleteOnInvokePromise<TTask> : Task<TTask>, ITaskCompletionAction where TTask : Task
		{
			// Token: 0x06004756 RID: 18262 RVA: 0x000EE418 File Offset: 0x000EC618
			public CompleteOnInvokePromise(IList<TTask> tasks, bool isSyncBlocking)
			{
				this._tasks = tasks;
				if (isSyncBlocking)
				{
					this._stateFlags = 2;
				}
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationBegin(base.Id, "TaskFactory.ContinueWhenAny", 0L);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.AddToActiveTasks(this);
				}
			}

			// Token: 0x06004757 RID: 18263 RVA: 0x000EE470 File Offset: 0x000EC670
			public void Invoke(Task completingTask)
			{
				int stateFlags = this._stateFlags;
				int num = stateFlags & 2;
				if ((stateFlags & 1) == 0 && Interlocked.Exchange(ref this._stateFlags, num | 1) == num)
				{
					if (TplEventSource.Log.IsEnabled())
					{
						TplEventSource.Log.TraceOperationRelation(base.Id, CausalityRelation.Choice);
						TplEventSource.Log.TraceOperationEnd(base.Id, AsyncCausalityStatus.Completed);
					}
					if (Task.s_asyncDebuggingEnabled)
					{
						Task.RemoveFromActiveTasks(this);
					}
					base.TrySetResult((TTask)((object)completingTask));
					IList<TTask> tasks = this._tasks;
					int count = tasks.Count;
					for (int i = 0; i < count; i++)
					{
						TTask ttask = tasks[i];
						if (ttask != null && !ttask.IsCompleted)
						{
							ttask.RemoveContinuation(this);
						}
					}
					this._tasks = null;
				}
			}

			// Token: 0x17000C9A RID: 3226
			// (get) Token: 0x06004758 RID: 18264 RVA: 0x000EE538 File Offset: 0x000EC738
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return (this._stateFlags & 2) == 0;
				}
			}

			// Token: 0x040010B3 RID: 4275
			private IList<TTask> _tasks;

			// Token: 0x040010B4 RID: 4276
			private int _stateFlags;
		}
	}
}
