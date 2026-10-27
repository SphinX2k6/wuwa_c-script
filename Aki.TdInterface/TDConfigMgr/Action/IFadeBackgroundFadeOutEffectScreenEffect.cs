using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A4B RID: 6731
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundFadeOutEffectScreenEffectConverter))]
	public class IFadeBackgroundFadeOutEffectScreenEffect : IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x06009018 RID: 36888 RVA: 0x001500A8 File Offset: 0x0014E2A8
		private IFadeBackgroundFadeOutEffectScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeOutEffectScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeOutEffectScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeOutEffectScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x001500E0 File Offset: 0x0014E2E0
		public static IFadeBackgroundFadeOutEffectScreenEffect Create([Nullable(2)] IFadeBackgroundFadeOutEffectScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x001500F3 File Offset: 0x0014E2F3
		public static IFadeBackgroundFadeOutEffectScreenEffect CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeOutEffectScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x00150106 File Offset: 0x0014E306
		public new IFadeBackgroundFadeOutEffectScreenEffect_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeOutEffectScreenEffect_SetValue
			{
				Type = this.Type,
				ScreenEffect = this.ScreenEffect
			};
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600901C RID: 36892 RVA: 0x00150125 File Offset: 0x0014E325
		// (set) Token: 0x0600901D RID: 36893 RVA: 0x00150150 File Offset: 0x0014E350
		public override EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFadeBackgroundFadeOutEffectType.Black;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0600901E RID: 36894 RVA: 0x0015015E File Offset: 0x0014E35E
		// (set) Token: 0x0600901F RID: 36895 RVA: 0x00150189 File Offset: 0x0014E389
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

		// Token: 0x04005904 RID: 22788
		[Nullable(2)]
		protected new IFadeBackgroundFadeOutEffectScreenEffect FbInstance;

		// Token: 0x04005905 RID: 22789
		[Nullable(2)]
		protected new IFadeBackgroundFadeOutEffectScreenEffect_SetValue PocoInterface;
	}
}
