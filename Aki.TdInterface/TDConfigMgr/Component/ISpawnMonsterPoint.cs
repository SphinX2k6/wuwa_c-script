using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006EA RID: 1770
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterPoint : IPointChooseType
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x000664F8 File Offset: 0x000646F8
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

		// Token: 0x06002627 RID: 9767 RVA: 0x00066530 File Offset: 0x00064730
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

		// Token: 0x06002628 RID: 9768 RVA: 0x00066543 File Offset: 0x00064743
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

		// Token: 0x06002629 RID: 9769 RVA: 0x00066556 File Offset: 0x00064756
		public new ISpawnMonsterPoint_SetValue ToSetValue()
		{
			return new ISpawnMonsterPoint_SetValue
			{
				Type = this.Type,
				RangeConstraint = this.RangeConstraint
			};
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x00066575 File Offset: 0x00064775
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x000665A0 File Offset: 0x000647A0
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

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000665B0 File Offset: 0x000647B0
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x00066611 File Offset: 0x00064811
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

		// Token: 0x040019F1 RID: 6641
		[Nullable(2)]
		protected new ISpawnMonsterPoint FbInstance;

		// Token: 0x040019F2 RID: 6642
		[Nullable(2)]
		protected new ISpawnMonsterPoint_SetValue PocoInterface;

		// Token: 0x040019F3 RID: 6643
		private ISearchSpawnMonsterPoint _RangeConstraintCache;

		// Token: 0x040019F4 RID: 6644
		private bool _RangeConstraintInited;
	}
}
