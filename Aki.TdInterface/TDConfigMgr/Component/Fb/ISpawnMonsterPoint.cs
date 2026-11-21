using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EAF RID: 3759
	public class ISpawnMonsterPoint : IPointChooseType
	{
		// Token: 0x060054C4 RID: 21700 RVA: 0x000D0996 File Offset: 0x000CEB96
		public static ISpawnMonsterPoint Create(ISpawnMonsterPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x060054C5 RID: 21701 RVA: 0x000D09B5 File Offset: 0x000CEBB5
		public override EPointChooseType Type
		{
			get
			{
				return (EPointChooseType)this.Instance.Type;
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x000D09C2 File Offset: 0x000CEBC2
		public virtual ISearchSpawnMonsterPoint RangeConstraint
		{
			get
			{
				if (this._RangeConstraintInited)
				{
					return this._RangeConstraintCache;
				}
				this._RangeConstraintInited = true;
				this._RangeConstraintCache = ISearchSpawnMonsterPoint.Create(this.Instance.RangeConstraint);
				return this._RangeConstraintCache;
			}
		}

		// Token: 0x04003070 RID: 12400
		private ISpawnMonsterPoint Instance;

		// Token: 0x04003071 RID: 12401
		[Nullable(2)]
		private ISearchSpawnMonsterPoint _RangeConstraintCache;

		// Token: 0x04003072 RID: 12402
		private bool _RangeConstraintInited;
	}
}
