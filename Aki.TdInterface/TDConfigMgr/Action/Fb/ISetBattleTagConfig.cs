using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A9 RID: 10665
	public class ISetBattleTagConfig
	{
		// Token: 0x0600EC49 RID: 60489 RVA: 0x0022C82C File Offset: 0x0022AA2C
		public static ISetBattleTagConfig Create(ISetBattleTagConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTagConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x0600EC4A RID: 60490 RVA: 0x0022C84B File Offset: 0x0022AA4B
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x0600EC4B RID: 60491 RVA: 0x0022C858 File Offset: 0x0022AA58
		public virtual int TagConfigId
		{
			get
			{
				return this.Instance.TagConfigId;
			}
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x0600EC4C RID: 60492 RVA: 0x0022C868 File Offset: 0x0022AA68
		public virtual int? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DelayTime);
			}
		}

		// Token: 0x04008217 RID: 33303
		private ISetBattleTagConfig Instance;
	}
}
