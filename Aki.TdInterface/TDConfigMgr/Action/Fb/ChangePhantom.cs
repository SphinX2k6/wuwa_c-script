using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B60 RID: 11104
	public class ChangePhantom : ActionParams
	{
		// Token: 0x0600F41A RID: 62490 RVA: 0x00239B2C File Offset: 0x00237D2C
		public static ChangePhantom Create(IChangePhantom? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangePhantom
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x0600F41B RID: 62491 RVA: 0x00239B4B File Offset: 0x00237D4B
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040085DC RID: 34268
		private IChangePhantom Instance;
	}
}
