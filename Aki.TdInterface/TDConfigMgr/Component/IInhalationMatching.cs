using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B1 RID: 1201
	public class IInhalationMatching
	{
		// Token: 0x06001815 RID: 6165 RVA: 0x000492AC File Offset: 0x000474AC
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

		// Token: 0x06001816 RID: 6166 RVA: 0x000492E4 File Offset: 0x000474E4
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

		// Token: 0x06001817 RID: 6167 RVA: 0x000492F7 File Offset: 0x000474F7
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

		// Token: 0x06001818 RID: 6168 RVA: 0x0004930A File Offset: 0x0004750A
		public IInhalationMatching_SetValue ToSetValue()
		{
			return new IInhalationMatching_SetValue
			{
				InhalationStrength = this.InhalationStrength,
				EntityMatch = this.EntityMatch
			};
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00049329 File Offset: 0x00047529
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x00049354 File Offset: 0x00047554
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00049364 File Offset: 0x00047564
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x000493C5 File Offset: 0x000475C5
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

		// Token: 0x04001246 RID: 4678
		[Nullable(2)]
		protected IInhalationMatching FbInstance;

		// Token: 0x04001247 RID: 4679
		[Nullable(2)]
		protected IInhalationMatching_SetValue PocoInterface;

		// Token: 0x04001248 RID: 4680
		private ICategoryMatchingCondition _EntityMatchCache;

		// Token: 0x04001249 RID: 4681
		private bool _EntityMatchInited;
	}
}
