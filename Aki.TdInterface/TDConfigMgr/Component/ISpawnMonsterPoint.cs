using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200078B RID: 1931
	public class ISpawnMonsterPoint : IPointChooseType
	{
		// Token: 0x06002946 RID: 10566 RVA: 0x0006D568 File Offset: 0x0006B768
		private ISpawnMonsterPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0006D5A0 File Offset: 0x0006B7A0
		public static ISpawnMonsterPoint Create([Nullable(2)] ISpawnMonsterPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0006D5B3 File Offset: 0x0006B7B3
		public static ISpawnMonsterPoint CreateFromSetValue([Nullable(2)] ISpawnMonsterPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x0006D5C6 File Offset: 0x0006B7C6
		public new ISpawnMonsterPoint_SetValue ToSetValue()
		{
			return new ISpawnMonsterPoint_SetValue
			{
				Type = this.Type,
				RangeConstraint = this.RangeConstraint
			};
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x0006D5E5 File Offset: 0x0006B7E5
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x0006D610 File Offset: 0x0006B810
		public override EPointChooseType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPointChooseType.SpawnMonsterPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x0006D620 File Offset: 0x0006B820
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x0006D681 File Offset: 0x0006B881
		public virtual ISearchSpawnMonsterPoint RangeConstraint
		{
			get
			{
				if (this._RangeConstraintInited)
				{
					return this._RangeConstraintCache;
				}
				this._RangeConstraintInited = true;
				if (this.FbInstance != null)
				{
					this._RangeConstraintCache = ISearchSpawnMonsterPoint.Create(this.FbInstance.RangeConstraint);
				}
				else
				{
					ISpawnMonsterPoint_SetValue pocoInterface = this.PocoInterface;
					this._RangeConstraintCache = ((pocoInterface != null) ? pocoInterface.RangeConstraint : null);
				}
				return this._RangeConstraintCache;
			}
			set
			{
				this.GetOrCreatePoco().RangeConstraint = value;
				this._RangeConstraintInited = false;
			}
		}

		// Token: 0x04001BF0 RID: 7152
		[Nullable(2)]
		protected new ISpawnMonsterPoint FbInstance;

		// Token: 0x04001BF1 RID: 7153
		[Nullable(2)]
		protected new ISpawnMonsterPoint_SetValue PocoInterface;

		// Token: 0x04001BF2 RID: 7154
		private ISearchSpawnMonsterPoint _RangeConstraintCache;

		// Token: 0x04001BF3 RID: 7155
		private bool _RangeConstraintInited;
	}
}
