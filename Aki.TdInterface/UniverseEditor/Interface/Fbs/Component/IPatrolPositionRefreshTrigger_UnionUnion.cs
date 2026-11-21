using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D0F RID: 23823
	public class IPatrolPositionRefreshTrigger_UnionUnion
	{
		// Token: 0x1700AF01 RID: 44801
		// (get) Token: 0x0602790A RID: 162058 RVA: 0x00569959 File Offset: 0x00567B59
		// (set) Token: 0x0602790B RID: 162059 RVA: 0x00569961 File Offset: 0x00567B61
		public IPatrolPositionRefreshTrigger_Union Type { get; set; }

		// Token: 0x1700AF02 RID: 44802
		// (get) Token: 0x0602790C RID: 162060 RVA: 0x0056996A File Offset: 0x00567B6A
		// (set) Token: 0x0602790D RID: 162061 RVA: 0x00569972 File Offset: 0x00567B72
		public object Value { get; set; }

		// Token: 0x0602790E RID: 162062 RVA: 0x0056997B File Offset: 0x00567B7B
		public IPatrolPositionRefreshTrigger_UnionUnion()
		{
			this.Type = IPatrolPositionRefreshTrigger_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602790F RID: 162063 RVA: 0x00569991 File Offset: 0x00567B91
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027910 RID: 162064 RVA: 0x005699A3 File Offset: 0x00567BA3
		public IPatrolPositionRefreshTriggerT AsIPatrolPositionRefreshTrigger()
		{
			return this.As<IPatrolPositionRefreshTriggerT>();
		}

		// Token: 0x06027911 RID: 162065 RVA: 0x005699AB File Offset: 0x00567BAB
		public static IPatrolPositionRefreshTrigger_UnionUnion FromIPatrolPositionRefreshTrigger(IPatrolPositionRefreshTriggerT _ipatrolpositionrefreshtrigger)
		{
			return new IPatrolPositionRefreshTrigger_UnionUnion
			{
				Type = IPatrolPositionRefreshTrigger_Union.IPatrolPositionRefreshTrigger,
				Value = _ipatrolpositionrefreshtrigger
			};
		}

		// Token: 0x06027912 RID: 162066 RVA: 0x005699C0 File Offset: 0x00567BC0
		public IPatrolPositionRefreshOnEntityAwakeT AsIPatrolPositionRefreshOnEntityAwake()
		{
			return this.As<IPatrolPositionRefreshOnEntityAwakeT>();
		}

		// Token: 0x06027913 RID: 162067 RVA: 0x005699C8 File Offset: 0x00567BC8
		public static IPatrolPositionRefreshTrigger_UnionUnion FromIPatrolPositionRefreshOnEntityAwake(IPatrolPositionRefreshOnEntityAwakeT _ipatrolpositionrefreshonentityawake)
		{
			return new IPatrolPositionRefreshTrigger_UnionUnion
			{
				Type = IPatrolPositionRefreshTrigger_Union.IPatrolPositionRefreshOnEntityAwake,
				Value = _ipatrolpositionrefreshonentityawake
			};
		}

		// Token: 0x06027914 RID: 162068 RVA: 0x005699DD File Offset: 0x00567BDD
		public IPatrolPositionRefreshOnEntityVisibilityShownT AsIPatrolPositionRefreshOnEntityVisibilityShown()
		{
			return this.As<IPatrolPositionRefreshOnEntityVisibilityShownT>();
		}

		// Token: 0x06027915 RID: 162069 RVA: 0x005699E5 File Offset: 0x00567BE5
		public static IPatrolPositionRefreshTrigger_UnionUnion FromIPatrolPositionRefreshOnEntityVisibilityShown(IPatrolPositionRefreshOnEntityVisibilityShownT _ipatrolpositionrefreshonentityvisibilityshown)
		{
			return new IPatrolPositionRefreshTrigger_UnionUnion
			{
				Type = IPatrolPositionRefreshTrigger_Union.IPatrolPositionRefreshOnEntityVisibilityShown,
				Value = _ipatrolpositionrefreshonentityvisibilityshown
			};
		}

		// Token: 0x06027916 RID: 162070 RVA: 0x005699FC File Offset: 0x00567BFC
		public static int Pack(FlatBufferBuilder builder, IPatrolPositionRefreshTrigger_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPatrolPositionRefreshTrigger_Union.IPatrolPositionRefreshTrigger:
				return IPatrolPositionRefreshTrigger.Pack(builder, _o.AsIPatrolPositionRefreshTrigger()).Value;
			case IPatrolPositionRefreshTrigger_Union.IPatrolPositionRefreshOnEntityAwake:
				return IPatrolPositionRefreshOnEntityAwake.Pack(builder, _o.AsIPatrolPositionRefreshOnEntityAwake()).Value;
			case IPatrolPositionRefreshTrigger_Union.IPatrolPositionRefreshOnEntityVisibilityShown:
				return IPatrolPositionRefreshOnEntityVisibilityShown.Pack(builder, _o.AsIPatrolPositionRefreshOnEntityVisibilityShown()).Value;
			default:
				return 0;
			}
		}
	}
}
