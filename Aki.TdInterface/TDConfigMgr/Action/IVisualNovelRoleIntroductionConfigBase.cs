using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F4 RID: 8948
	public class IVisualNovelRoleIntroductionConfigBase
	{
		// Token: 0x0600C30E RID: 49934 RVA: 0x001C0630 File Offset: 0x001BE830
		private IVisualNovelRoleIntroductionConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelRoleIntroductionConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelRoleIntroductionConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelRoleIntroductionConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C30F RID: 49935 RVA: 0x001C0668 File Offset: 0x001BE868
		public static IVisualNovelRoleIntroductionConfigBase Create([Nullable(2)] IVisualNovelRoleIntroductionConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelRoleIntroductionConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C310 RID: 49936 RVA: 0x001C067B File Offset: 0x001BE87B
		public static IVisualNovelRoleIntroductionConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelRoleIntroductionConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelRoleIntroductionConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x001C068E File Offset: 0x001BE88E
		public IVisualNovelRoleIntroductionConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelRoleIntroductionConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0600C312 RID: 49938 RVA: 0x001C06A1 File Offset: 0x001BE8A1
		// (set) Token: 0x0600C313 RID: 49939 RVA: 0x001C06CC File Offset: 0x001BE8CC
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

		// Token: 0x0400745E RID: 29790
		[Nullable(2)]
		protected IVisualNovelRoleIntroductionConfigBase FbInstance;

		// Token: 0x0400745F RID: 29791
		[Nullable(2)]
		protected IVisualNovelRoleIntroductionConfigBase_SetValue PocoInterface;
	}
}
