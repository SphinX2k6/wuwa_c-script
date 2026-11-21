using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062B0 RID: 25264
	public class TPatrolPositionRefreshTriggerUnion
	{
		// Token: 0x1700BB8C RID: 48012
		// (get) Token: 0x0602AF57 RID: 175959 RVA: 0x005DC4E2 File Offset: 0x005DA6E2
		// (set) Token: 0x0602AF58 RID: 175960 RVA: 0x005DC4EA File Offset: 0x005DA6EA
		public TPatrolPositionRefreshTrigger Type { get; set; }

		// Token: 0x1700BB8D RID: 48013
		// (get) Token: 0x0602AF59 RID: 175961 RVA: 0x005DC4F3 File Offset: 0x005DA6F3
		// (set) Token: 0x0602AF5A RID: 175962 RVA: 0x005DC4FB File Offset: 0x005DA6FB
		public object Value { get; set; }

		// Token: 0x0602AF5B RID: 175963 RVA: 0x005DC504 File Offset: 0x005DA704
		public TPatrolPositionRefreshTriggerUnion()
		{
			this.Type = TPatrolPositionRefreshTrigger.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF5C RID: 175964 RVA: 0x005DC51A File Offset: 0x005DA71A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF5D RID: 175965 RVA: 0x005DC52C File Offset: 0x005DA72C
		public IPatrolPositionRefreshOnEntityAwakeT AsIPatrolPositionRefreshOnEntityAwake()
		{
			return this.As<IPatrolPositionRefreshOnEntityAwakeT>();
		}

		// Token: 0x0602AF5E RID: 175966 RVA: 0x005DC534 File Offset: 0x005DA734
		public static TPatrolPositionRefreshTriggerUnion FromIPatrolPositionRefreshOnEntityAwake(IPatrolPositionRefreshOnEntityAwakeT _ipatrolpositionrefreshonentityawake)
		{
			return new TPatrolPositionRefreshTriggerUnion
			{
				Type = TPatrolPositionRefreshTrigger.IPatrolPositionRefreshOnEntityAwake,
				Value = _ipatrolpositionrefreshonentityawake
			};
		}

		// Token: 0x0602AF5F RID: 175967 RVA: 0x005DC549 File Offset: 0x005DA749
		public IPatrolPositionRefreshOnEntityVisibilityShownT AsIPatrolPositionRefreshOnEntityVisibilityShown()
		{
			return this.As<IPatrolPositionRefreshOnEntityVisibilityShownT>();
		}

		// Token: 0x0602AF60 RID: 175968 RVA: 0x005DC551 File Offset: 0x005DA751
		public static TPatrolPositionRefreshTriggerUnion FromIPatrolPositionRefreshOnEntityVisibilityShown(IPatrolPositionRefreshOnEntityVisibilityShownT _ipatrolpositionrefreshonentityvisibilityshown)
		{
			return new TPatrolPositionRefreshTriggerUnion
			{
				Type = TPatrolPositionRefreshTrigger.IPatrolPositionRefreshOnEntityVisibilityShown,
				Value = _ipatrolpositionrefreshonentityvisibilityshown
			};
		}

		// Token: 0x0602AF61 RID: 175969 RVA: 0x005DC568 File Offset: 0x005DA768
		public static int Pack(FlatBufferBuilder builder, TPatrolPositionRefreshTriggerUnion _o)
		{
			TPatrolPositionRefreshTrigger type = _o.Type;
			if (type == TPatrolPositionRefreshTrigger.IPatrolPositionRefreshOnEntityAwake)
			{
				return IPatrolPositionRefreshOnEntityAwake.Pack(builder, _o.AsIPatrolPositionRefreshOnEntityAwake()).Value;
			}
			if (type != TPatrolPositionRefreshTrigger.IPatrolPositionRefreshOnEntityVisibilityShown)
			{
				return 0;
			}
			return IPatrolPositionRefreshOnEntityVisibilityShown.Pack(builder, _o.AsIPatrolPositionRefreshOnEntityVisibilityShown()).Value;
		}
	}
}
