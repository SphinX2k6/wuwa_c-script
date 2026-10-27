using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A3F RID: 6719
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundFadeInEffectConverter))]
	public class IFadeBackgroundFadeInEffect
	{
		// Token: 0x06008FDA RID: 36826 RVA: 0x0014FA2C File Offset: 0x0014DC2C
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

		// Token: 0x06008FDB RID: 36827 RVA: 0x0014FA64 File Offset: 0x0014DC64
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

		// Token: 0x06008FDC RID: 36828 RVA: 0x0014FA77 File Offset: 0x0014DC77
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

		// Token: 0x06008FDD RID: 36829 RVA: 0x0014FA8A File Offset: 0x0014DC8A
		public IFadeBackgroundFadeInEffect_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeInEffect_SetValue
			{
				FadeInEffect = this.FadeInEffect
			};
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x06008FDE RID: 36830 RVA: 0x0014FA9D File Offset: 0x0014DC9D
		// (set) Token: 0x06008FDF RID: 36831 RVA: 0x0014FAC4 File Offset: 0x0014DCC4
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

		// Token: 0x040058EB RID: 22763
		[Nullable(2)]
		protected IFadeBackgroundFadeInEffect FbInstance;

		// Token: 0x040058EC RID: 22764
		[Nullable(2)]
		protected IFadeBackgroundFadeInEffect_SetValue PocoInterface;
	}
}
