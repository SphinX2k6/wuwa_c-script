using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000372 RID: 882
	[NullableContext(1)]
	[Nullable(0)]
	public class IFanEffectConfig
	{
		// Token: 0x06001183 RID: 4483 RVA: 0x0003B144 File Offset: 0x00039344
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

		// Token: 0x06001184 RID: 4484 RVA: 0x0003B17C File Offset: 0x0003937C
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

		// Token: 0x06001185 RID: 4485 RVA: 0x0003B18F File Offset: 0x0003938F
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

		// Token: 0x06001186 RID: 4486 RVA: 0x0003B1A2 File Offset: 0x000393A2
		public IFanEffectConfig_SetValue ToSetValue()
		{
			return new IFanEffectConfig_SetValue
			{
				EffectPath = this.EffectPath,
				DefaultEffectLength = this.DefaultEffectLength,
				HitEffectPath = this.HitEffectPath
			};
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x0003B1CD File Offset: 0x000393CD
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0003B1F8 File Offset: 0x000393F8
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0003B206 File Offset: 0x00039406
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x0003B235 File Offset: 0x00039435
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0003B243 File Offset: 0x00039443
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x0003B26A File Offset: 0x0003946A
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

		// Token: 0x04000E5F RID: 3679
		[Nullable(2)]
		protected IFanEffectConfig FbInstance;

		// Token: 0x04000E60 RID: 3680
		[Nullable(2)]
		protected IFanEffectConfig_SetValue PocoInterface;
	}
}
