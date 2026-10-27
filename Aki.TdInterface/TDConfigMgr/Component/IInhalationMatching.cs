using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000458 RID: 1112
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhalationMatching
	{
		// Token: 0x0600167B RID: 5755 RVA: 0x00045564 File Offset: 0x00043764
		private IInhalationMatching_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhalationMatching 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhalationMatching_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhalationMatching_SetValue());
			}
			return result;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0004559C File Offset: 0x0004379C
		public static IInhalationMatching Create([Nullable(2)] IInhalationMatching instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationMatching
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000455AF File Offset: 0x000437AF
		public static IInhalationMatching CreateFromSetValue([Nullable(2)] IInhalationMatching_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhalationMatching
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000455C2 File Offset: 0x000437C2
		public IInhalationMatching_SetValue ToSetValue()
		{
			return new IInhalationMatching_SetValue
			{
				InhalationStrength = this.InhalationStrength,
				EntityMatch = this.EntityMatch
			};
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x000455E1 File Offset: 0x000437E1
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x0004560C File Offset: 0x0004380C
		public virtual int InhalationStrength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InhalationStrength;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InhalationStrength;
			}
			set
			{
				this.GetOrCreatePoco().InhalationStrength = value;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x0004561C File Offset: 0x0004381C
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x0004567D File Offset: 0x0004387D
		public virtual ICategoryMatchingCondition EntityMatch
		{
			get
			{
				if (this._EntityMatchInited)
				{
					return this._EntityMatchCache;
				}
				this._EntityMatchInited = true;
				if (this.FbInstance != null)
				{
					this._EntityMatchCache = ICategoryMatchingCondition.Create(this.FbInstance.EntityMatch);
				}
				else
				{
					IInhalationMatching_SetValue pocoInterface = this.PocoInterface;
					this._EntityMatchCache = ((pocoInterface != null) ? pocoInterface.EntityMatch : null);
				}
				return this._EntityMatchCache;
			}
			set
			{
				this.GetOrCreatePoco().EntityMatch = value;
				this._EntityMatchInited = false;
			}
		}

		// Token: 0x04001124 RID: 4388
		[Nullable(2)]
		protected IInhalationMatching FbInstance;

		// Token: 0x04001125 RID: 4389
		[Nullable(2)]
		protected IInhalationMatching_SetValue PocoInterface;

		// Token: 0x04001126 RID: 4390
		private ICategoryMatchingCondition _EntityMatchCache;

		// Token: 0x04001127 RID: 4391
		private bool _EntityMatchInited;
	}
}
