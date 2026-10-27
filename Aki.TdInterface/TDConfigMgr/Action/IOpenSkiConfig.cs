using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CAC RID: 7340
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenSkiConfig : ISkiConfigType
	{
		// Token: 0x06009D89 RID: 40329 RVA: 0x00168C9C File Offset: 0x00166E9C
		private IOpenSkiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenSkiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenSkiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenSkiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x00168CD4 File Offset: 0x00166ED4
		public static IOpenSkiConfig Create([Nullable(2)] IOpenSkiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSkiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x00168CE7 File Offset: 0x00166EE7
		public static IOpenSkiConfig CreateFromSetValue([Nullable(2)] IOpenSkiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenSkiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x00168CFA File Offset: 0x00166EFA
		public new IOpenSkiConfig_SetValue ToSetValue()
		{
			return new IOpenSkiConfig_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				SkiConfig = this.SkiConfig
			};
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x06009D8D RID: 40333 RVA: 0x00168D25 File Offset: 0x00166F25
		// (set) Token: 0x06009D8E RID: 40334 RVA: 0x00168D50 File Offset: 0x00166F50
		public override ESkiConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkiConfig.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x06009D8F RID: 40335 RVA: 0x00168D5E File Offset: 0x00166F5E
		// (set) Token: 0x06009D90 RID: 40336 RVA: 0x00168D85 File Offset: 0x00166F85
		public override ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IOpenSkiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x06009D91 RID: 40337 RVA: 0x00168D93 File Offset: 0x00166F93
		// (set) Token: 0x06009D92 RID: 40338 RVA: 0x00168DBE File Offset: 0x00166FBE
		public virtual string SkiConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkiConfig;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SkiConfig;
			}
			set
			{
				this.GetOrCreatePoco().SkiConfig = value;
			}
		}

		// Token: 0x04005F5E RID: 24414
		[Nullable(2)]
		protected new IOpenSkiConfig FbInstance;

		// Token: 0x04005F5F RID: 24415
		[Nullable(2)]
		protected new IOpenSkiConfig_SetValue PocoInterface;
	}
}
