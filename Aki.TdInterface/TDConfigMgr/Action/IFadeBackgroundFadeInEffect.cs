using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD4 RID: 7124
	[JsonConverter(typeof(IFadeBackgroundFadeInEffectConverter))]
	public class IFadeBackgroundFadeInEffect
	{
		// Token: 0x06009744 RID: 38724 RVA: 0x0015F958 File Offset: 0x0015DB58
		private IFadeBackgroundFadeInEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeInEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeInEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeInEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x0015F990 File Offset: 0x0015DB90
		public static IFadeBackgroundFadeInEffect Create([Nullable(2)] IFadeBackgroundFadeInEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x0015F9A3 File Offset: 0x0015DBA3
		public static IFadeBackgroundFadeInEffect CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeInEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x0015F9B6 File Offset: 0x0015DBB6
		public IFadeBackgroundFadeInEffect_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeInEffect_SetValue
			{
				FadeInEffect = this.FadeInEffect
			};
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x06009748 RID: 38728 RVA: 0x0015F9C9 File Offset: 0x0015DBC9
		// (set) Token: 0x06009749 RID: 38729 RVA: 0x0015F9F0 File Offset: 0x0015DBF0
		public virtual IFadeBackgroundFadeInEffectTypeBase FadeInEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInEffect;
				}
				IFadeBackgroundFadeInEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeInEffect;
			}
			set
			{
				this.GetOrCreatePoco().FadeInEffect = value;
			}
		}

		// Token: 0x04005D50 RID: 23888
		[Nullable(2)]
		protected IFadeBackgroundFadeInEffect FbInstance;

		// Token: 0x04005D51 RID: 23889
		[Nullable(2)]
		protected IFadeBackgroundFadeInEffect_SetValue PocoInterface;
	}
}
