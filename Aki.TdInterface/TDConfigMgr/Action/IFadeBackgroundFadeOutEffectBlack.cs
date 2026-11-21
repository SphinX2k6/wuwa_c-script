using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BDE RID: 7134
	[JsonConverter(typeof(IFadeBackgroundFadeOutEffectBlackConverter))]
	public class IFadeBackgroundFadeOutEffectBlack : IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x06009774 RID: 38772 RVA: 0x0015FE2C File Offset: 0x0015E02C
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

		// Token: 0x06009775 RID: 38773 RVA: 0x0015FE64 File Offset: 0x0015E064
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

		// Token: 0x06009776 RID: 38774 RVA: 0x0015FE77 File Offset: 0x0015E077
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

		// Token: 0x06009777 RID: 38775 RVA: 0x0015FE8A File Offset: 0x0015E08A
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

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x06009778 RID: 38776 RVA: 0x0015FEC1 File Offset: 0x0015E0C1
		// (set) Token: 0x06009779 RID: 38777 RVA: 0x0015FEEC File Offset: 0x0015E0EC
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

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x0600977A RID: 38778 RVA: 0x0015FEFA File Offset: 0x0015E0FA
		// (set) Token: 0x0600977B RID: 38779 RVA: 0x0015FF25 File Offset: 0x0015E125
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

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0600977C RID: 38780 RVA: 0x0015FF34 File Offset: 0x0015E134
		// (set) Token: 0x0600977D RID: 38781 RVA: 0x0015FF6E File Offset: 0x0015E16E
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

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x0600977E RID: 38782 RVA: 0x0015FF7C File Offset: 0x0015E17C
		// (set) Token: 0x0600977F RID: 38783 RVA: 0x0015FFB6 File Offset: 0x0015E1B6
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

		// Token: 0x04005D63 RID: 23907
		[Nullable(2)]
		protected new IFadeBackgroundFadeOutEffectBlack FbInstance;

		// Token: 0x04005D64 RID: 23908
		[Nullable(2)]
		protected new IFadeBackgroundFadeOutEffectBlack_SetValue PocoInterface;
	}
}
