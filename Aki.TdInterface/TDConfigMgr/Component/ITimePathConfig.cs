using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200081A RID: 2074
	public class ITimePathConfig
	{
		// Token: 0x06002C9C RID: 11420 RVA: 0x00074848 File Offset: 0x00072A48
		private ITimePathConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimePathConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimePathConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimePathConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00074880 File Offset: 0x00072A80
		public static ITimePathConfig Create([Nullable(2)] ITimePathConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimePathConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x00074893 File Offset: 0x00072A93
		public static ITimePathConfig CreateFromSetValue([Nullable(2)] ITimePathConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimePathConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000748A6 File Offset: 0x00072AA6
		public ITimePathConfig_SetValue ToSetValue()
		{
			return new ITimePathConfig_SetValue
			{
				TotalTime = this.TotalTime,
				TimePathCurve = this.TimePathCurve
			};
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x000748C5 File Offset: 0x00072AC5
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x000748F4 File Offset: 0x00072AF4
		public virtual float TotalTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TotalTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TotalTime;
			}
			set
			{
				this.GetOrCreatePoco().TotalTime = value;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x00074902 File Offset: 0x00072B02
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x0007492D File Offset: 0x00072B2D
		public virtual string TimePathCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimePathCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TimePathCurve;
			}
			set
			{
				this.GetOrCreatePoco().TimePathCurve = value;
			}
		}

		// Token: 0x04001DD4 RID: 7636
		[Nullable(2)]
		protected ITimePathConfig FbInstance;

		// Token: 0x04001DD5 RID: 7637
		[Nullable(2)]
		protected ITimePathConfig_SetValue PocoInterface;
	}
}
