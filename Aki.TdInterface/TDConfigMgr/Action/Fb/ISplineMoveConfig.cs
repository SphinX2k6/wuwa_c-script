using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E2 RID: 10466
	[NullableContext(1)]
	[Nullable(0)]
	public class ISplineMoveConfig
	{
		// Token: 0x0600E88E RID: 59534 RVA: 0x002221AB File Offset: 0x002203AB
		public static ISplineMoveConfig Create(ISplineMoveConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700488C RID: 18572
		// (get) Token: 0x0600E88F RID: 59535 RVA: 0x002221CA File Offset: 0x002203CA
		public virtual ESplineMoveConfigType Type
		{
			get
			{
				return (ESplineMoveConfigType)this.Instance.Type;
			}
		}

		// Token: 0x1700488D RID: 18573
		// (get) Token: 0x0600E890 RID: 59536 RVA: 0x002221D7 File Offset: 0x002203D7
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadISplineMoveConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x0600E891 RID: 59537 RVA: 0x00222206 File Offset: 0x00220406
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x04008066 RID: 32870
		private ISplineMoveConfig Instance;

		// Token: 0x04008067 RID: 32871
		private ITargetEntityType _TargetCache;

		// Token: 0x04008068 RID: 32872
		private bool _TargetInited;
	}
}
