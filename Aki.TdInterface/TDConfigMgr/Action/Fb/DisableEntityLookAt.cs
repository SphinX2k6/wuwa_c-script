using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D6B RID: 11627
	public class DisableEntityLookAt : ActionParams
	{
		// Token: 0x0600FDB7 RID: 64951 RVA: 0x0024A140 File Offset: 0x00248340
		public static DisableEntityLookAt Create(IDisableEntityLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DisableEntityLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F8F RID: 20367
		// (get) Token: 0x0600FDB8 RID: 64952 RVA: 0x0024A15F File Offset: 0x0024835F
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008A85 RID: 35461
		private IDisableEntityLookAt Instance;
	}
}
