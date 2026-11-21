using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004AF RID: 1199
	public class IInhalationConfig
	{
		// Token: 0x0600180B RID: 6155 RVA: 0x00049170 File Offset: 0x00047370
		private IInhalationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhalationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhalationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhalationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000491A8 File Offset: 0x000473A8
		public static IInhalationConfig Create([Nullable(2)] IInhalationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x000491BB File Offset: 0x000473BB
		public static IInhalationConfig CreateFromSetValue([Nullable(2)] IInhalationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhalationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000491CE File Offset: 0x000473CE
		public IInhalationConfig_SetValue ToSetValue()
		{
			return new IInhalationConfig_SetValue
			{
				InhalationMatching = this.InhalationMatching,
				InhalationPerformance = this.InhalationPerformance
			};
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x000491F0 File Offset: 0x000473F0
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x00049251 File Offset: 0x00047451
		public virtual IInhalationMatching InhalationMatching
		{
			get
			{
				if (this._InhalationMatchingInited)
				{
					return this._InhalationMatchingCache;
				}
				this._InhalationMatchingInited = true;
				if (this.FbInstance != null)
				{
					this._InhalationMatchingCache = IInhalationMatching.Create(this.FbInstance.InhalationMatching);
				}
				else
				{
					IInhalationConfig_SetValue pocoInterface = this.PocoInterface;
					this._InhalationMatchingCache = ((pocoInterface != null) ? pocoInterface.InhalationMatching : null);
				}
				return this._InhalationMatchingCache;
			}
			set
			{
				this.GetOrCreatePoco().InhalationMatching = value;
				this._InhalationMatchingInited = false;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00049266 File Offset: 0x00047466
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x0004928D File Offset: 0x0004748D
		public virtual IInhalationPerformanceType InhalationPerformance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InhalationPerformance;
				}
				IInhalationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InhalationPerformance;
			}
			set
			{
				this.GetOrCreatePoco().InhalationPerformance = value;
			}
		}

		// Token: 0x04001240 RID: 4672
		[Nullable(2)]
		protected IInhalationConfig FbInstance;

		// Token: 0x04001241 RID: 4673
		[Nullable(2)]
		protected IInhalationConfig_SetValue PocoInterface;

		// Token: 0x04001242 RID: 4674
		private IInhalationMatching _InhalationMatchingCache;

		// Token: 0x04001243 RID: 4675
		private bool _InhalationMatchingInited;
	}
}
