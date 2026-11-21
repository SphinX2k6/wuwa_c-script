using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003BB RID: 955
	public class IFanEffectConfig
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x0003E428 File Offset: 0x0003C628
		private IFanEffectConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFanEffectConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFanEffectConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFanEffectConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0003E460 File Offset: 0x0003C660
		public static IFanEffectConfig Create([Nullable(2)] IFanEffectConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanEffectConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0003E473 File Offset: 0x0003C673
		public static IFanEffectConfig CreateFromSetValue([Nullable(2)] IFanEffectConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFanEffectConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0003E486 File Offset: 0x0003C686
		public IFanEffectConfig_SetValue ToSetValue()
		{
			return new IFanEffectConfig_SetValue
			{
				EffectPath = this.EffectPath,
				DefaultEffectLength = this.DefaultEffectLength,
				HitEffectPath = this.HitEffectPath
			};
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x0003E4B1 File Offset: 0x0003C6B1
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		public virtual string EffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectPath;
			}
			set
			{
				this.GetOrCreatePoco().EffectPath = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x0003E4EA File Offset: 0x0003C6EA
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x0003E519 File Offset: 0x0003C719
		public virtual float DefaultEffectLength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultEffectLength;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DefaultEffectLength;
			}
			set
			{
				this.GetOrCreatePoco().DefaultEffectLength = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x0003E527 File Offset: 0x0003C727
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x0003E54E File Offset: 0x0003C74E
		[Nullable(2)]
		public virtual string HitEffectPath
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitEffectPath;
				}
				IFanEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitEffectPath;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().HitEffectPath = value;
			}
		}

		// Token: 0x04000F56 RID: 3926
		[Nullable(2)]
		protected IFanEffectConfig FbInstance;

		// Token: 0x04000F57 RID: 3927
		[Nullable(2)]
		protected IFanEffectConfig_SetValue PocoInterface;
	}
}
