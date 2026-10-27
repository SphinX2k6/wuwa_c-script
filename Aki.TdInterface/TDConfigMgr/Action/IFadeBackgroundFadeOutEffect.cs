using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A47 RID: 6727
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundFadeOutEffectConverter))]
	public class IFadeBackgroundFadeOutEffect
	{
		// Token: 0x06009002 RID: 36866 RVA: 0x0014FE48 File Offset: 0x0014E048
		private IFadeBackgroundFadeOutEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeOutEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeOutEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeOutEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06009003 RID: 36867 RVA: 0x0014FE80 File Offset: 0x0014E080
		public static IFadeBackgroundFadeOutEffect Create([Nullable(2)] IFadeBackgroundFadeOutEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009004 RID: 36868 RVA: 0x0014FE93 File Offset: 0x0014E093
		public static IFadeBackgroundFadeOutEffect CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeOutEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009005 RID: 36869 RVA: 0x0014FEA6 File Offset: 0x0014E0A6
		public IFadeBackgroundFadeOutEffect_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeOutEffect_SetValue
			{
				FadeOutEffect = this.FadeOutEffect
			};
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x06009006 RID: 36870 RVA: 0x0014FEB9 File Offset: 0x0014E0B9
		// (set) Token: 0x06009007 RID: 36871 RVA: 0x0014FEE0 File Offset: 0x0014E0E0
		public virtual IFadeBackgroundFadeOutEffectTypeBase FadeOutEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutEffect;
				}
				IFadeBackgroundFadeOutEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutEffect;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutEffect = value;
			}
		}

		// Token: 0x040058FB RID: 22779
		[Nullable(2)]
		protected IFadeBackgroundFadeOutEffect FbInstance;

		// Token: 0x040058FC RID: 22780
		[Nullable(2)]
		protected IFadeBackgroundFadeOutEffect_SetValue PocoInterface;
	}
}
