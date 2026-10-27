using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB3 RID: 3507
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterPoint : IPointChooseType
	{
		// Token: 0x06004F9F RID: 20383 RVA: 0x000C5146 File Offset: 0x000C3346
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

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x000C5165 File Offset: 0x000C3365
		public override EPointChooseType Type
		{
			get
			{
				return (EPointChooseType)this.Instance.Type;
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x000C5172 File Offset: 0x000C3372
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

		// Token: 0x04002DAA RID: 11690
		private ISpawnMonsterPoint Instance;

		// Token: 0x04002DAB RID: 11691
		[Nullable(2)]
		private ISearchSpawnMonsterPoint _RangeConstraintCache;

		// Token: 0x04002DAC RID: 11692
		private bool _RangeConstraintInited;
	}
}
