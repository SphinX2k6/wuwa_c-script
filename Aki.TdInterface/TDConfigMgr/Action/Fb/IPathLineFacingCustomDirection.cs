using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BAE RID: 11182
	public class IPathLineFacingCustomDirection : IPathLineFacingType
	{
		// Token: 0x0600F665 RID: 63077 RVA: 0x0023E426 File Offset: 0x0023C626
		public static IPathLineFacingCustomDirection Create(IPathLineFacingCustomDirection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingCustomDirection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x0600F666 RID: 63078 RVA: 0x0023E445 File Offset: 0x0023C645
		public override EPathLineFacingType Type
		{
			get
			{
				return (EPathLineFacingType)this.Instance.Type;
			}
		}

		// Token: 0x17004BB8 RID: 19384
		// (get) Token: 0x0600F667 RID: 63079 RVA: 0x0023E452 File Offset: 0x0023C652
		public virtual float Yaw
		{
			get
			{
				return this.Instance.Yaw;
			}
		}

		// Token: 0x04008716 RID: 34582
		private IPathLineFacingCustomDirection Instance;
	}
}
