using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200051F RID: 1311
	public class ILifeStageConfig
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x0004DDC4 File Offset: 0x0004BFC4
		private ILifeStageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILifeStageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILifeStageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILifeStageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0004DDFC File Offset: 0x0004BFFC
		public static ILifeStageConfig Create([Nullable(2)] ILifeStageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifeStageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0004DE0F File Offset: 0x0004C00F
		public static ILifeStageConfig CreateFromSetValue([Nullable(2)] ILifeStageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILifeStageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0004DE22 File Offset: 0x0004C022
		public ILifeStageConfig_SetValue ToSetValue()
		{
			return new ILifeStageConfig_SetValue
			{
				PerformDuration = this.PerformDuration
			};
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0004DE38 File Offset: 0x0004C038
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0004DE72 File Offset: 0x0004C072
		public virtual float? PerformDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformDuration;
				}
				ILifeStageConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformDuration;
			}
			set
			{
				this.GetOrCreatePoco().PerformDuration = value;
			}
		}

		// Token: 0x04001380 RID: 4992
		[Nullable(2)]
		protected ILifeStageConfig FbInstance;

		// Token: 0x04001381 RID: 4993
		[Nullable(2)]
		protected ILifeStageConfig_SetValue PocoInterface;
	}
}
