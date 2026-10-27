using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A3 RID: 8355
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelRoleIntroductionConfigBase
	{
		// Token: 0x0600B7C8 RID: 47048 RVA: 0x001A9BA4 File Offset: 0x001A7DA4
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

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x001A9BDC File Offset: 0x001A7DDC
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

		// Token: 0x0600B7CA RID: 47050 RVA: 0x001A9BEF File Offset: 0x001A7DEF
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

		// Token: 0x0600B7CB RID: 47051 RVA: 0x001A9C02 File Offset: 0x001A7E02
		public IVisualNovelRoleIntroductionConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelRoleIntroductionConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600B7CC RID: 47052 RVA: 0x001A9C15 File Offset: 0x001A7E15
		// (set) Token: 0x0600B7CD RID: 47053 RVA: 0x001A9C40 File Offset: 0x001A7E40
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

		// Token: 0x04006E47 RID: 28231
		[Nullable(2)]
		protected IVisualNovelRoleIntroductionConfigBase FbInstance;

		// Token: 0x04006E48 RID: 28232
		[Nullable(2)]
		protected IVisualNovelRoleIntroductionConfigBase_SetValue PocoInterface;
	}
}
