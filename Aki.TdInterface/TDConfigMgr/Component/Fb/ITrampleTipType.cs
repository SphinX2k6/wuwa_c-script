using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAF RID: 2991
	public class ITrampleTipType
	{
		// Token: 0x0600445E RID: 17502 RVA: 0x000AD481 File Offset: 0x000AB681
		public static ITrampleTipType Create(ITrampleTipType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrampleTipType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x000AD4A0 File Offset: 0x000AB6A0
		public virtual ETrampleTipType Type
		{
			get
			{
				return (ETrampleTipType)this.Instance.Type;
			}
		}

		// Token: 0x040025D4 RID: 9684
		private ITrampleTipType Instance;
	}
}
