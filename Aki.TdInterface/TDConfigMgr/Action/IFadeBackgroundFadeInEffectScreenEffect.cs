using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD8 RID: 7128
	[JsonConverter(typeof(IFadeBackgroundFadeInEffectScreenEffectConverter))]
	public class IFadeBackgroundFadeInEffectScreenEffect : IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x0600975A RID: 38746 RVA: 0x0015FBB8 File Offset: 0x0015DDB8
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

		// Token: 0x0600975B RID: 38747 RVA: 0x0015FBF0 File Offset: 0x0015DDF0
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

		// Token: 0x0600975C RID: 38748 RVA: 0x0015FC03 File Offset: 0x0015DE03
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

		// Token: 0x0600975D RID: 38749 RVA: 0x0015FC16 File Offset: 0x0015DE16
		public new IFadeBackgroundFadeInEffectScreenEffect_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeInEffectScreenEffect_SetValue
			{
				Type = this.Type,
				ScreenEffect = this.ScreenEffect
			};
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x0600975E RID: 38750 RVA: 0x0015FC35 File Offset: 0x0015DE35
		// (set) Token: 0x0600975F RID: 38751 RVA: 0x0015FC60 File Offset: 0x0015DE60
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

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x06009760 RID: 38752 RVA: 0x0015FC6E File Offset: 0x0015DE6E
		// (set) Token: 0x06009761 RID: 38753 RVA: 0x0015FC99 File Offset: 0x0015DE99
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

		// Token: 0x04005D59 RID: 23897
		[Nullable(2)]
		protected new IFadeBackgroundFadeInEffectScreenEffect FbInstance;

		// Token: 0x04005D5A RID: 23898
		[Nullable(2)]
		protected new IFadeBackgroundFadeInEffectScreenEffect_SetValue PocoInterface;
	}
}
