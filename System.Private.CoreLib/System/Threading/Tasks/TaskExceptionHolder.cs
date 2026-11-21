using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004D7 RID: 1239
	internal sealed class TaskExceptionHolder
	{
		// Token: 0x060046E7 RID: 18151 RVA: 0x000ED414 File Offset: 0x000EB614
		internal TaskExceptionHolder(Task task)
		{
			this.m_task = task;
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x000ED424 File Offset: 0x000EB624
		protected override void Finalize()
		{
			try
			{
				if (this.m_faultExceptions != null && !this.m_isHandled)
				{
					UnobservedTaskExceptionEventArgs ueea = new UnobservedTaskExceptionEventArgs(new AggregateException(SR.TaskExceptionHolder_UnhandledException, this.m_faultExceptions));
					TaskScheduler.PublishUnobservedTaskException(this.m_task, ueea);
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060046E9 RID: 18153 RVA: 0x000ED484 File Offset: 0x000EB684
		internal bool ContainsFaultList
		{
			get
			{
				return this.m_faultExceptions != null;
			}
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x000ED491 File Offset: 0x000EB691
		internal void Add(object exceptionObject, bool representsCancellation)
		{
			if (representsCancellation)
			{
				this.SetCancellationException(exceptionObject);
				return;
			}
			this.AddFaultException(exceptionObject);
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x000ED4A8 File Offset: 0x000EB6A8
		private void SetCancellationException(object exceptionObject)
		{
			OperationCanceledException ex = exceptionObject as OperationCanceledException;
			if (ex != null)
			{
				this.m_cancellationException = ExceptionDispatchInfo.Capture(ex);
			}
			else
			{
				ExceptionDispatchInfo cancellationException = exceptionObject as ExceptionDispatchInfo;
				this.m_cancellationException = cancellationException;
			}
			this.MarkAsHandled(false);
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x000ED4E4 File Offset: 0x000EB6E4
		private void AddFaultException(object exceptionObject)
		{
			List<ExceptionDispatchInfo> list;
			if ((list = this.m_faultExceptions) == null)
			{
				list = (this.m_faultExceptions = new List<ExceptionDispatchInfo>(1));
			}
			List<ExceptionDispatchInfo> list2 = list;
			Exception ex = exceptionObject as Exception;
			if (ex != null)
			{
				list2.Add(ExceptionDispatchInfo.Capture(ex));
			}
			else
			{
				ExceptionDispatchInfo exceptionDispatchInfo = exceptionObject as ExceptionDispatchInfo;
				if (exceptionDispatchInfo != null)
				{
					list2.Add(exceptionDispatchInfo);
				}
				else
				{
					IEnumerable<Exception> enumerable = exceptionObject as IEnumerable<Exception>;
					if (enumerable != null)
					{
						using (IEnumerator<Exception> enumerator = enumerable.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Exception source = enumerator.Current;
								list2.Add(ExceptionDispatchInfo.Capture(source));
							}
							goto IL_B3;
						}
					}
					IEnumerable<ExceptionDispatchInfo> enumerable2 = exceptionObject as IEnumerable<ExceptionDispatchInfo>;
					if (enumerable2 == null)
					{
						throw new ArgumentException(SR.TaskExceptionHolder_UnknownExceptionType, "exceptionObject");
					}
					list2.AddRange(enumerable2);
				}
			}
			IL_B3:
			if (list2.Count > 0)
			{
				this.MarkAsUnhandled();
			}
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x000ED5C4 File Offset: 0x000EB7C4
		private void MarkAsUnhandled()
		{
			if (this.m_isHandled)
			{
				GC.ReRegisterForFinalize(this);
				this.m_isHandled = false;
			}
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x000ED5DF File Offset: 0x000EB7DF
		internal void MarkAsHandled(bool calledFromFinalizer)
		{
			if (!this.m_isHandled)
			{
				if (!calledFromFinalizer)
				{
					GC.SuppressFinalize(this);
				}
				this.m_isHandled = true;
			}
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x000ED600 File Offset: 0x000EB800
		internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException)
		{
			List<ExceptionDispatchInfo> faultExceptions = this.m_faultExceptions;
			this.MarkAsHandled(calledFromFinalizer);
			if (includeThisException == null)
			{
				return new AggregateException(faultExceptions);
			}
			Exception[] array = new Exception[faultExceptions.Count + 1];
			for (int i = 0; i < array.Length - 1; i++)
			{
				array[i] = faultExceptions[i].SourceException;
			}
			Exception[] array2 = array;
			array2[array2.Length - 1] = includeThisException;
			return new AggregateException(array);
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x000ED662 File Offset: 0x000EB862
		internal List<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			List<ExceptionDispatchInfo> faultExceptions = this.m_faultExceptions;
			this.MarkAsHandled(false);
			return faultExceptions;
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x000ED673 File Offset: 0x000EB873
		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			return this.m_cancellationException;
		}

		// Token: 0x040010A7 RID: 4263
		private readonly Task m_task;

		// Token: 0x040010A8 RID: 4264
		private volatile List<ExceptionDispatchInfo> m_faultExceptions;

		// Token: 0x040010A9 RID: 4265
		private ExceptionDispatchInfo m_cancellationException;

		// Token: 0x040010AA RID: 4266
		private volatile bool m_isHandled;
	}
}
