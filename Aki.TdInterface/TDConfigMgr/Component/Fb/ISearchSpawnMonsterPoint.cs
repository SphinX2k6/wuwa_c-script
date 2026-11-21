using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EAE RID: 3758
	public class ISearchSpawnMonsterPoint : IRangeConstraint
	{
		// Token: 0x060054BF RID: 21695 RVA: 0x000D091D File Offset: 0x000CEB1D
		public static ISearchSpawnMonsterPoint Create(ISearchSpawnMonsterPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISearchSpawnMonsterPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x060054C0 RID: 21696 RVA: 0x000D093C File Offset: 0x000CEB3C
		public override ERangeConstraint Type
		{
			get
			{
				return (ERangeConstraint)this.Instance.Type;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x000D0949 File Offset: 0x000CEB49
		public virtual int Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x000D0958 File Offset: 0x000CEB58
		public virtual int? TagId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TagId);
			}
		}

		// Token: 0x0400306F RID: 12399
		private ISearchSpawnMonsterPoint Instance;
	}
}
