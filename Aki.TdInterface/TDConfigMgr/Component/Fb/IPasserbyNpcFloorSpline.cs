using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB9 RID: 3513
	[NullableContext(2)]
	[Nullable(0)]
	public class IPasserbyNpcFloorSpline
	{
		// Token: 0x06004FD5 RID: 20437 RVA: 0x000C68E1 File Offset: 0x000C4AE1
		[NullableContext(0)]
		public static IPasserbyNpcFloorSpline Create(IPasserbyNpcFloorSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcFloorSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x000C6900 File Offset: 0x000C4B00
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x000C690D File Offset: 0x000C4B0D
		public virtual int Floor
		{
			get
			{
				return this.Instance.Floor;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x000C691A File Offset: 0x000C4B1A
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

		// Token: 0x04002D7E RID: 11646
		private IPasserbyNpcFloorSpline Instance;

		// Token: 0x04002D7F RID: 11647
		private IPasserbyNpcMoveState _MoveStateCache;

		// Token: 0x04002D80 RID: 11648
		private bool _MoveStateInited;
	}
}
