using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD2 RID: 3282
	[NullableContext(2)]
	[Nullable(0)]
	public class IPasserbyNpcSpline
	{
		// Token: 0x06004B0C RID: 19212 RVA: 0x000BBAF2 File Offset: 0x000B9CF2
		[NullableContext(1)]
		public static IPasserbyNpcSpline Create(IPasserbyNpcSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x000BBB11 File Offset: 0x000B9D11
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x000BBB1E File Offset: 0x000B9D1E
		public virtual int SpawnWeight
		{
			get
			{
				return this.Instance.SpawnWeight;
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06004B0F RID: 19215 RVA: 0x000BBB2C File Offset: 0x000B9D2C
		public virtual bool? IsLoop
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLoop);
			}
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06004B10 RID: 19216 RVA: 0x000BBB62 File Offset: 0x000B9D62
		public virtual IPasserbyNpcMoveState MoveState
		{
			get
			{
				if (this._MoveStateInited)
				{
					return this._MoveStateCache;
				}
				this._MoveStateInited = true;
				this._MoveStateCache = IPasserbyNpcMoveState.Create(this.Instance.MoveState);
				return this._MoveStateCache;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06004B11 RID: 19217 RVA: 0x000BBB98 File Offset: 0x000B9D98
		public virtual bool? IsIkEnabled
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsIkEnabled);
			}
		}

		// Token: 0x04002AF1 RID: 10993
		private IPasserbyNpcSpline Instance;

		// Token: 0x04002AF2 RID: 10994
		private IPasserbyNpcMoveState _MoveStateCache;

		// Token: 0x04002AF3 RID: 10995
		private bool _MoveStateInited;
	}
}
