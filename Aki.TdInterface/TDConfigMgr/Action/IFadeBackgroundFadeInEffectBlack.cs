using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD6 RID: 7126
	[JsonConverter(typeof(IFadeBackgroundFadeInEffectBlackConverter))]
	public class IFadeBackgroundFadeInEffectBlack : IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x0600974C RID: 38732 RVA: 0x0015FA10 File Offset: 0x0015DC10
		private IFadeBackgroundFadeInEffectBlack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeInEffectBlack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeInEffectBlack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeInEffectBlack_SetValue());
			}
			return result;
		}

		// Token: 0x0600974D RID: 38733 RVA: 0x0015FA48 File Offset: 0x0015DC48
		public static IFadeBackgroundFadeInEffectBlack Create([Nullable(2)] IFadeBackgroundFadeInEffectBlack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectBlack
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x0015FA5B File Offset: 0x0015DC5B
		public static IFadeBackgroundFadeInEffectBlack CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeInEffectBlack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectBlack
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600974F RID: 38735 RVA: 0x0015FA6E File Offset: 0x0015DC6E
		public new IFadeBackgroundFadeInEffectBlack_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeInEffectBlack_SetValue
			{
				Type = this.Type,
				FadeColor = this.FadeColor,
				FadeInTime = this.FadeInTime,
				FadeOutTime = this.FadeOutTime
			};
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x06009750 RID: 38736 RVA: 0x0015FAA5 File Offset: 0x0015DCA5
		// (set) Token: 0x06009751 RID: 38737 RVA: 0x0015FAD0 File Offset: 0x0015DCD0
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

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x06009752 RID: 38738 RVA: 0x0015FADE File Offset: 0x0015DCDE
		// (set) Token: 0x06009753 RID: 38739 RVA: 0x0015FB09 File Offset: 0x0015DD09
		public virtual EFadeInScreenShowType FadeColor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeColor;
				}
				if (this.PocoInterface == null)
				{
					return EFadeInScreenShowType.White;
				}
				return this.PocoInterface.FadeColor;
			}
			set
			{
				this.GetOrCreatePoco().FadeColor = value;
			}
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x06009754 RID: 38740 RVA: 0x0015FB18 File Offset: 0x0015DD18
		// (set) Token: 0x06009755 RID: 38741 RVA: 0x0015FB52 File Offset: 0x0015DD52
		public virtual float? FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				IFadeBackgroundFadeInEffectBlack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x06009756 RID: 38742 RVA: 0x0015FB60 File Offset: 0x0015DD60
		// (set) Token: 0x06009757 RID: 38743 RVA: 0x0015FB9A File Offset: 0x0015DD9A
		public virtual float? FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				IFadeBackgroundFadeInEffectBlack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x04005D53 RID: 23891
		[Nullable(2)]
		protected new IFadeBackgroundFadeInEffectBlack FbInstance;

		// Token: 0x04005D54 RID: 23892
		[Nullable(2)]
		protected new IFadeBackgroundFadeInEffectBlack_SetValue PocoInterface;
	}
}
