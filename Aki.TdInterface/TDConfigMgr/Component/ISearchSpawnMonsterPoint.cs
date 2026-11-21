using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200075B RID: 1883
	public class ISearchSpawnMonsterPoint : IRangeConstraint
	{
		// Token: 0x06002820 RID: 10272 RVA: 0x0006AF14 File Offset: 0x00069114
		private ISearchSpawnMonsterPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISearchSpawnMonsterPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISearchSpawnMonsterPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISearchSpawnMonsterPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0006AF4C File Offset: 0x0006914C
		public static ISearchSpawnMonsterPoint Create([Nullable(2)] ISearchSpawnMonsterPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISearchSpawnMonsterPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0006AF5F File Offset: 0x0006915F
		public static ISearchSpawnMonsterPoint CreateFromSetValue([Nullable(2)] ISearchSpawnMonsterPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISearchSpawnMonsterPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x0006AF72 File Offset: 0x00069172
		public new ISearchSpawnMonsterPoint_SetValue ToSetValue()
		{
			return new ISearchSpawnMonsterPoint_SetValue
			{
				Type = this.Type,
				Radius = this.Radius,
				TagId = this.TagId
			};
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x0006AF9D File Offset: 0x0006919D
		// (set) Token: 0x06002825 RID: 10277 RVA: 0x0006AFC8 File Offset: 0x000691C8
		public override ERangeConstraint Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERangeConstraint.SearchSpawnMonsterPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0006AFD6 File Offset: 0x000691D6
		// (set) Token: 0x06002827 RID: 10279 RVA: 0x0006B001 File Offset: 0x00069201
		public virtual int Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x0006B010 File Offset: 0x00069210
		// (set) Token: 0x06002829 RID: 10281 RVA: 0x0006B04A File Offset: 0x0006924A
		public virtual int? TagId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TagId;
				}
				ISearchSpawnMonsterPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TagId;
			}
			set
			{
				this.GetOrCreatePoco().TagId = value;
			}
		}

		// Token: 0x04001B53 RID: 6995
		[Nullable(2)]
		protected new ISearchSpawnMonsterPoint FbInstance;

		// Token: 0x04001B54 RID: 6996
		[Nullable(2)]
		protected new ISearchSpawnMonsterPoint_SetValue PocoInterface;
	}
}
