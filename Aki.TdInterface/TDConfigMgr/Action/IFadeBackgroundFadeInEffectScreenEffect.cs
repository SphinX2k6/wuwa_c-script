using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A43 RID: 6723
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundFadeInEffectScreenEffectConverter))]
	public class IFadeBackgroundFadeInEffectScreenEffect : IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x06008FF0 RID: 36848 RVA: 0x0014FC8C File Offset: 0x0014DE8C
		private IFadeBackgroundFadeInEffectScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeInEffectScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeInEffectScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeInEffectScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06008FF1 RID: 36849 RVA: 0x0014FCC4 File Offset: 0x0014DEC4
		public static IFadeBackgroundFadeInEffectScreenEffect Create([Nullable(2)] IFadeBackgroundFadeInEffectScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x0014FCD7 File Offset: 0x0014DED7
		public static IFadeBackgroundFadeInEffectScreenEffect CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeInEffectScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FF3 RID: 36851 RVA: 0x0014FCEA File Offset: 0x0014DEEA
		public new IFadeBackgroundFadeInEffectScreenEffect_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeInEffectScreenEffect_SetValue
			{
				Type = this.Type,
				ScreenEffect = this.ScreenEffect
			};
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x06008FF4 RID: 36852 RVA: 0x0014FD09 File Offset: 0x0014DF09
		// (set) Token: 0x06008FF5 RID: 36853 RVA: 0x0014FD34 File Offset: 0x0014DF34
		public override EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFadeBackgroundFadeInEffectType.Black;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x06008FF6 RID: 36854 RVA: 0x0014FD42 File Offset: 0x0014DF42
		// (set) Token: 0x06008FF7 RID: 36855 RVA: 0x0014FD6D File Offset: 0x0014DF6D
		public virtual string ScreenEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ScreenEffect;
			}
			set
			{
				this.GetOrCreatePoco().ScreenEffect = value;
			}
		}

		// Token: 0x040058F4 RID: 22772
		[Nullable(2)]
		protected new IFadeBackgroundFadeInEffectScreenEffect FbInstance;

		// Token: 0x040058F5 RID: 22773
		[Nullable(2)]
		protected new IFadeBackgroundFadeInEffectScreenEffect_SetValue PocoInterface;
	}
}
