using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BBA RID: 11194
	public class ISplineMoveConfig
	{
		// Token: 0x0600F6CF RID: 63183 RVA: 0x0023F363 File Offset: 0x0023D563
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

		// Token: 0x17004C09 RID: 19465
		// (get) Token: 0x0600F6D0 RID: 63184 RVA: 0x0023F382 File Offset: 0x0023D582
		public virtual ESplineMoveConfigType Type
		{
			get
			{
				return (ESplineMoveConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004C0A RID: 19466
		// (get) Token: 0x0600F6D1 RID: 63185 RVA: 0x0023F38F File Offset: 0x0023D58F
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

		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x0600F6D2 RID: 63186 RVA: 0x0023F3BE File Offset: 0x0023D5BE
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x0400872A RID: 34602
		private ISplineMoveConfig Instance;

		// Token: 0x0400872B RID: 34603
		private ITargetEntityType _TargetCache;

		// Token: 0x0400872C RID: 34604
		private bool _TargetInited;
	}
}
