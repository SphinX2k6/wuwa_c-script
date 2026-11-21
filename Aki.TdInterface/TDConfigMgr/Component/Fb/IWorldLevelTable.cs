using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B63 RID: 2915
	public class IWorldLevelTable : IWorldLevelBonusType
	{
		// Token: 0x0600428B RID: 17035 RVA: 0x000A902F File Offset: 0x000A722F
		public static IWorldLevelTable Create(IWorldLevelTable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWorldLevelTable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x000A904E File Offset: 0x000A724E
		public override EWorldLevelBonus Type
		{
			get
			{
				return (EWorldLevelBonus)this.Instance.Type;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x000A905C File Offset: 0x000A725C
		public virtual int? WorldLevelBonusId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.WorldLevelBonusId);
			}
		}

		// Token: 0x040024DC RID: 9436
		private IWorldLevelTable Instance;
	}
}
