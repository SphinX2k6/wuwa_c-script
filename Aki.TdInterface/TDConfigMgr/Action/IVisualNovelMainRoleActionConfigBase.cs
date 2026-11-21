using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BC RID: 8892
	public class IVisualNovelMainRoleActionConfigBase
	{
		// Token: 0x0600C1A2 RID: 49570 RVA: 0x001BD824 File Offset: 0x001BBA24
		private IVisualNovelMainRoleActionConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelMainRoleActionConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelMainRoleActionConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelMainRoleActionConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C1A3 RID: 49571 RVA: 0x001BD85C File Offset: 0x001BBA5C
		public static IVisualNovelMainRoleActionConfigBase Create([Nullable(2)] IVisualNovelMainRoleActionConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelMainRoleActionConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C1A4 RID: 49572 RVA: 0x001BD86F File Offset: 0x001BBA6F
		public static IVisualNovelMainRoleActionConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelMainRoleActionConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelMainRoleActionConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C1A5 RID: 49573 RVA: 0x001BD882 File Offset: 0x001BBA82
		public IVisualNovelMainRoleActionConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelMainRoleActionConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x0600C1A6 RID: 49574 RVA: 0x001BD895 File Offset: 0x001BBA95
		// (set) Token: 0x0600C1A7 RID: 49575 RVA: 0x001BD8C0 File Offset: 0x001BBAC0
		public virtual EVisualNovelSubType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040073A4 RID: 29604
		[Nullable(2)]
		protected IVisualNovelMainRoleActionConfigBase FbInstance;

		// Token: 0x040073A5 RID: 29605
		[Nullable(2)]
		protected IVisualNovelMainRoleActionConfigBase_SetValue PocoInterface;
	}
}
