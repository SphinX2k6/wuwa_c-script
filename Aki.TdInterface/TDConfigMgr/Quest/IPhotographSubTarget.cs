using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200116F RID: 4463
	public class IPhotographSubTarget
	{
		// Token: 0x0600632C RID: 25388 RVA: 0x000EED08 File Offset: 0x000ECF08
		private IPhotographSubTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographSubTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographSubTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographSubTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x000EED40 File Offset: 0x000ECF40
		public static IPhotographSubTarget Create([Nullable(2)] IPhotographSubTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographSubTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x000EED53 File Offset: 0x000ECF53
		public static IPhotographSubTarget CreateFromSetValue([Nullable(2)] IPhotographSubTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographSubTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x000EED66 File Offset: 0x000ECF66
		public IPhotographSubTarget_SetValue ToSetValue()
		{
			return new IPhotographSubTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x000EED79 File Offset: 0x000ECF79
		// (set) Token: 0x06006331 RID: 25393 RVA: 0x000EEDA4 File Offset: 0x000ECFA4
		public virtual EPhotographSubTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhotographSubTargetType.SpecificRole;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B70 RID: 15216
		[Nullable(2)]
		protected IPhotographSubTarget FbInstance;

		// Token: 0x04003B71 RID: 15217
		[Nullable(2)]
		protected IPhotographSubTarget_SetValue PocoInterface;
	}
}
