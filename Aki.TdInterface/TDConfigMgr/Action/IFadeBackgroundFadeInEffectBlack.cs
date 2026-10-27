using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A41 RID: 6721
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundFadeInEffectBlackConverter))]
	public class IFadeBackgroundFadeInEffectBlack : IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x06008FE2 RID: 36834 RVA: 0x0014FAE4 File Offset: 0x0014DCE4
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

		// Token: 0x06008FE3 RID: 36835 RVA: 0x0014FB1C File Offset: 0x0014DD1C
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

		// Token: 0x06008FE4 RID: 36836 RVA: 0x0014FB2F File Offset: 0x0014DD2F
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

		// Token: 0x06008FE5 RID: 36837 RVA: 0x0014FB42 File Offset: 0x0014DD42
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

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x06008FE6 RID: 36838 RVA: 0x0014FB79 File Offset: 0x0014DD79
		// (set) Token: 0x06008FE7 RID: 36839 RVA: 0x0014FBA4 File Offset: 0x0014DDA4
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

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x06008FE8 RID: 36840 RVA: 0x0014FBB2 File Offset: 0x0014DDB2
		// (set) Token: 0x06008FE9 RID: 36841 RVA: 0x0014FBDD File Offset: 0x0014DDDD
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

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x06008FEA RID: 36842 RVA: 0x0014FBEC File Offset: 0x0014DDEC
		// (set) Token: 0x06008FEB RID: 36843 RVA: 0x0014FC26 File Offset: 0x0014DE26
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

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x06008FEC RID: 36844 RVA: 0x0014FC34 File Offset: 0x0014DE34
		// (set) Token: 0x06008FED RID: 36845 RVA: 0x0014FC6E File Offset: 0x0014DE6E
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

		// Token: 0x040058EE RID: 22766
		[Nullable(2)]
		protected new IFadeBackgroundFadeInEffectBlack FbInstance;

		// Token: 0x040058EF RID: 22767
		[Nullable(2)]
		protected new IFadeBackgroundFadeInEffectBlack_SetValue PocoInterface;
	}
}
