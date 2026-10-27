using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A5 RID: 8357
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelRoleIntroductionSolarSchool : IVisualNovelRoleIntroductionConfigBase
	{
		// Token: 0x0600B7D0 RID: 47056 RVA: 0x001A9C60 File Offset: 0x001A7E60
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

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x001A9C98 File Offset: 0x001A7E98
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

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x001A9CAB File Offset: 0x001A7EAB
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

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x001A9CBE File Offset: 0x001A7EBE
		public new IVisualNovelRoleIntroductionSolarSchool_SetValue ToSetValue()
		{
			return new IVisualNovelRoleIntroductionSolarSchool_SetValue
			{
				Type = this.Type,
				IntroductionId = this.IntroductionId,
				Duration = this.Duration
			};
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600B7D4 RID: 47060 RVA: 0x001A9CE9 File Offset: 0x001A7EE9
		// (set) Token: 0x0600B7D5 RID: 47061 RVA: 0x001A9D14 File Offset: 0x001A7F14
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

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600B7D6 RID: 47062 RVA: 0x001A9D22 File Offset: 0x001A7F22
		// (set) Token: 0x0600B7D7 RID: 47063 RVA: 0x001A9D4D File Offset: 0x001A7F4D
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

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600B7D8 RID: 47064 RVA: 0x001A9D5C File Offset: 0x001A7F5C
		// (set) Token: 0x0600B7D9 RID: 47065 RVA: 0x001A9D96 File Offset: 0x001A7F96
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

		// Token: 0x04006E4A RID: 28234
		[Nullable(2)]
		protected new IVisualNovelRoleIntroductionSolarSchool FbInstance;

		// Token: 0x04006E4B RID: 28235
		[Nullable(2)]
		protected new IVisualNovelRoleIntroductionSolarSchool_SetValue PocoInterface;
	}
}
