using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C64 RID: 11364
	public class IResetEntityConfig
	{
		// Token: 0x0600F9D1 RID: 63953 RVA: 0x0024446A File Offset: 0x0024266A
		public static IResetEntityConfig Create(IResetEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DB7 RID: 19895
		// (get) Token: 0x0600F9D2 RID: 63954 RVA: 0x00244489 File Offset: 0x00242689
		public virtual EResetEntityType Type
		{
			get
			{
				return (EResetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x0400887E RID: 34942
		private IResetEntityConfig Instance;
	}
}
