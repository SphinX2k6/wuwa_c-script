using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB2 RID: 3506
	public class ISearchSpawnMonsterPoint : IRangeConstraint
	{
		// Token: 0x06004F9A RID: 20378 RVA: 0x000C50CD File Offset: 0x000C32CD
		[NullableContext(1)]
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

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06004F9B RID: 20379 RVA: 0x000C50EC File Offset: 0x000C32EC
		public override ERangeConstraint Type
		{
			get
			{
				return (ERangeConstraint)this.Instance.Type;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06004F9C RID: 20380 RVA: 0x000C50F9 File Offset: 0x000C32F9
		public virtual int Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06004F9D RID: 20381 RVA: 0x000C5108 File Offset: 0x000C3308
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

		// Token: 0x04002DA9 RID: 11689
		private ISearchSpawnMonsterPoint Instance;
	}
}
