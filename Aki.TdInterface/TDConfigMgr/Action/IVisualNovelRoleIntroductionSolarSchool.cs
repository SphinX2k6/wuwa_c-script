using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F6 RID: 8950
	public class IVisualNovelRoleIntroductionSolarSchool : IVisualNovelRoleIntroductionConfigBase
	{
		// Token: 0x0600C316 RID: 49942 RVA: 0x001C06EC File Offset: 0x001BE8EC
		private IVisualNovelRoleIntroductionSolarSchool_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelRoleIntroductionSolarSchool 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelRoleIntroductionSolarSchool_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelRoleIntroductionSolarSchool_SetValue());
			}
			return result;
		}

		// Token: 0x0600C317 RID: 49943 RVA: 0x001C0724 File Offset: 0x001BE924
		public static IVisualNovelRoleIntroductionSolarSchool Create([Nullable(2)] IVisualNovelRoleIntroductionSolarSchool instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelRoleIntroductionSolarSchool
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C318 RID: 49944 RVA: 0x001C0737 File Offset: 0x001BE937
		public static IVisualNovelRoleIntroductionSolarSchool CreateFromSetValue([Nullable(2)] IVisualNovelRoleIntroductionSolarSchool_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelRoleIntroductionSolarSchool
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C319 RID: 49945 RVA: 0x001C074A File Offset: 0x001BE94A
		public new IVisualNovelRoleIntroductionSolarSchool_SetValue ToSetValue()
		{
			return new IVisualNovelRoleIntroductionSolarSchool_SetValue
			{
				Type = this.Type,
				IntroductionId = this.IntroductionId,
				Duration = this.Duration
			};
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0600C31A RID: 49946 RVA: 0x001C0775 File Offset: 0x001BE975
		// (set) Token: 0x0600C31B RID: 49947 RVA: 0x001C07A0 File Offset: 0x001BE9A0
		public override EVisualNovelSubType Type
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

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x0600C31C RID: 49948 RVA: 0x001C07AE File Offset: 0x001BE9AE
		// (set) Token: 0x0600C31D RID: 49949 RVA: 0x001C07D9 File Offset: 0x001BE9D9
		public virtual int IntroductionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IntroductionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.IntroductionId;
			}
			set
			{
				this.GetOrCreatePoco().IntroductionId = value;
			}
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x0600C31E RID: 49950 RVA: 0x001C07E8 File Offset: 0x001BE9E8
		// (set) Token: 0x0600C31F RID: 49951 RVA: 0x001C0822 File Offset: 0x001BEA22
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				IVisualNovelRoleIntroductionSolarSchool_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04007461 RID: 29793
		[Nullable(2)]
		protected new IVisualNovelRoleIntroductionSolarSchool FbInstance;

		// Token: 0x04007462 RID: 29794
		[Nullable(2)]
		protected new IVisualNovelRoleIntroductionSolarSchool_SetValue PocoInterface;
	}
}
