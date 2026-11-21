using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE0 RID: 7136
	[JsonConverter(typeof(IFadeBackgroundFadeOutEffectScreenEffectConverter))]
	public class IFadeBackgroundFadeOutEffectScreenEffect : IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x06009782 RID: 38786 RVA: 0x0015FFD4 File Offset: 0x0015E1D4
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

		// Token: 0x06009783 RID: 38787 RVA: 0x0016000C File Offset: 0x0015E20C
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

		// Token: 0x06009784 RID: 38788 RVA: 0x0016001F File Offset: 0x0015E21F
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

		// Token: 0x06009785 RID: 38789 RVA: 0x00160032 File Offset: 0x0015E232
		public new IFadeBackgroundFadeOutEffectScreenEffect_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeOutEffectScreenEffect_SetValue
			{
				Type = this.Type,
				ScreenEffect = this.ScreenEffect
			};
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x06009786 RID: 38790 RVA: 0x00160051 File Offset: 0x0015E251
		// (set) Token: 0x06009787 RID: 38791 RVA: 0x0016007C File Offset: 0x0015E27C
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

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x06009788 RID: 38792 RVA: 0x0016008A File Offset: 0x0015E28A
		// (set) Token: 0x06009789 RID: 38793 RVA: 0x001600B5 File Offset: 0x0015E2B5
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

		// Token: 0x04005D69 RID: 23913
		[Nullable(2)]
		protected new IFadeBackgroundFadeOutEffectScreenEffect FbInstance;

		// Token: 0x04005D6A RID: 23914
		[Nullable(2)]
		protected new IFadeBackgroundFadeOutEffectScreenEffect_SetValue PocoInterface;
	}
}
