using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F50 RID: 3920
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnableSystemConfig
	{
		// Token: 0x0600572A RID: 22314 RVA: 0x000D5454 File Offset: 0x000D3654
		private IEnableSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x000D548C File Offset: 0x000D368C
		public static IEnableSystemConfig Create([Nullable(2)] IEnableSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x000D549F File Offset: 0x000D369F
		public static IEnableSystemConfig CreateFromSetValue([Nullable(2)] IEnableSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x000D54B2 File Offset: 0x000D36B2
		public IEnableSystemConfig_SetValue ToSetValue()
		{
			return new IEnableSystemConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x0600572E RID: 22318 RVA: 0x000D54C5 File Offset: 0x000D36C5
		// (set) Token: 0x0600572F RID: 22319 RVA: 0x000D54F0 File Offset: 0x000D36F0
		public virtual EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040034C5 RID: 13509
		[Nullable(2)]
		protected IEnableSystemConfig FbInstance;

		// Token: 0x040034C6 RID: 13510
		[Nullable(2)]
		protected IEnableSystemConfig_SetValue PocoInterface;
	}
}
