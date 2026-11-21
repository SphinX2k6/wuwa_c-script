using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB0 RID: 10928
	public class ISuperCatapult : ILeisureInteractType
	{
		// Token: 0x0600F0FD RID: 61693 RVA: 0x002349A7 File Offset: 0x00232BA7
		public static ISuperCatapult Create(ISuperCatapult? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuperCatapult
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700484B RID: 18507
		// (get) Token: 0x0600F0FE RID: 61694 RVA: 0x002349C6 File Offset: 0x00232BC6
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x0600F0FF RID: 61695 RVA: 0x002349D3 File Offset: 0x00232BD3
		public virtual ICatapultParam Param
		{
			get
			{
				if (this._ParamInited)
				{
					return this._ParamCache;
				}
				this._ParamInited = true;
				this._ParamCache = ICatapultParam.Create(this.Instance.Param);
				return this._ParamCache;
			}
		}

		// Token: 0x0400847A RID: 33914
		private ISuperCatapult Instance;

		// Token: 0x0400847B RID: 33915
		[Nullable(2)]
		private ICatapultParam _ParamCache;

		// Token: 0x0400847C RID: 33916
		private bool _ParamInited;
	}
}
