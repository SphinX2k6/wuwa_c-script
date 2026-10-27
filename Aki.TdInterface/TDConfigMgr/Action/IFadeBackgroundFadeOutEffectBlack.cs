using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A49 RID: 6729
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundFadeOutEffectBlackConverter))]
	public class IFadeBackgroundFadeOutEffectBlack : IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x0600900A RID: 36874 RVA: 0x0014FF00 File Offset: 0x0014E100
		private IFadeBackgroundFadeOutEffectBlack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeOutEffectBlack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeOutEffectBlack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeOutEffectBlack_SetValue());
			}
			return result;
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x0014FF38 File Offset: 0x0014E138
		public static IFadeBackgroundFadeOutEffectBlack Create([Nullable(2)] IFadeBackgroundFadeOutEffectBlack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectBlack
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600900C RID: 36876 RVA: 0x0014FF4B File Offset: 0x0014E14B
		public static IFadeBackgroundFadeOutEffectBlack CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeOutEffectBlack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectBlack
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600900D RID: 36877 RVA: 0x0014FF5E File Offset: 0x0014E15E
		public new IFadeBackgroundFadeOutEffectBlack_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeOutEffectBlack_SetValue
			{
				Type = this.Type,
				FadeColor = this.FadeColor,
				FadeInTime = this.FadeInTime,
				FadeOutTime = this.FadeOutTime
			};
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600900E RID: 36878 RVA: 0x0014FF95 File Offset: 0x0014E195
		// (set) Token: 0x0600900F RID: 36879 RVA: 0x0014FFC0 File Offset: 0x0014E1C0
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

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x06009010 RID: 36880 RVA: 0x0014FFCE File Offset: 0x0014E1CE
		// (set) Token: 0x06009011 RID: 36881 RVA: 0x0014FFF9 File Offset: 0x0014E1F9
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

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x06009012 RID: 36882 RVA: 0x00150008 File Offset: 0x0014E208
		// (set) Token: 0x06009013 RID: 36883 RVA: 0x00150042 File Offset: 0x0014E242
		public virtual float? FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				IFadeBackgroundFadeOutEffectBlack_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x06009014 RID: 36884 RVA: 0x00150050 File Offset: 0x0014E250
		// (set) Token: 0x06009015 RID: 36885 RVA: 0x0015008A File Offset: 0x0014E28A
		public virtual float? FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				IFadeBackgroundFadeOutEffectBlack_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040058FE RID: 22782
		[Nullable(2)]
		protected new IFadeBackgroundFadeOutEffectBlack FbInstance;

		// Token: 0x040058FF RID: 22783
		[Nullable(2)]
		protected new IFadeBackgroundFadeOutEffectBlack_SetValue PocoInterface;
	}
}
