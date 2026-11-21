using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000457 RID: 1111
	public class IGroupFinishConfig
	{
		// Token: 0x06001639 RID: 5689 RVA: 0x00045874 File Offset: 0x00043A74
		private IGroupFinishConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupFinishConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupFinishConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupFinishConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000458AC File Offset: 0x00043AAC
		public static IGroupFinishConfig Create([Nullable(2)] IGroupFinishConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x000458BF File Offset: 0x00043ABF
		public static IGroupFinishConfig CreateFromSetValue([Nullable(2)] IGroupFinishConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupFinishConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x000458D2 File Offset: 0x00043AD2
		public IGroupFinishConfig_SetValue ToSetValue()
		{
			return new IGroupFinishConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x000458E5 File Offset: 0x00043AE5
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x00045910 File Offset: 0x00043B10
		public virtual EGroupFinishConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupFinishConfig.Silence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400114F RID: 4431
		[Nullable(2)]
		protected IGroupFinishConfig FbInstance;

		// Token: 0x04001150 RID: 4432
		[Nullable(2)]
		protected IGroupFinishConfig_SetValue PocoInterface;
	}
}
