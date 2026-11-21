using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB6 RID: 3510
	[NullableContext(2)]
	[Nullable(0)]
	public class IPasserbyNpcSpline
	{
		// Token: 0x06004FC7 RID: 20423 RVA: 0x000C672A File Offset: 0x000C492A
		[NullableContext(0)]
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

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x000C6749 File Offset: 0x000C4949
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x000C6756 File Offset: 0x000C4956
		public virtual int SpawnWeight
		{
			get
			{
				return this.Instance.SpawnWeight;
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06004FCA RID: 20426 RVA: 0x000C6764 File Offset: 0x000C4964
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

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x000C679A File Offset: 0x000C499A
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

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06004FCC RID: 20428 RVA: 0x000C67D0 File Offset: 0x000C49D0
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

		// Token: 0x04002D77 RID: 11639
		private IPasserbyNpcSpline Instance;

		// Token: 0x04002D78 RID: 11640
		private IPasserbyNpcMoveState _MoveStateCache;

		// Token: 0x04002D79 RID: 11641
		private bool _MoveStateInited;
	}
}
