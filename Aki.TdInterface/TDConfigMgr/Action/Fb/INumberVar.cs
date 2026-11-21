using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028BE RID: 10430
	public class INumberVar
	{
		// Token: 0x0600E84B RID: 59467 RVA: 0x00225627 File Offset: 0x00223827
		public static INumberVar Create(INumberVar? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INumberVar
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x0600E84C RID: 59468 RVA: 0x00225646 File Offset: 0x00223846
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x0600E84D RID: 59469 RVA: 0x00225653 File Offset: 0x00223853
		public virtual float Value
		{
			get
			{
				return this.Instance.Value;
			}
		}

		// Token: 0x04007FF0 RID: 32752
		private INumberVar Instance;
	}
}
