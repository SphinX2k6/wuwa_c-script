using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DFB RID: 7675
	public class IMoraleAreaTip : ICommonTipType
	{
		// Token: 0x0600A313 RID: 41747 RVA: 0x001750E0 File Offset: 0x001732E0
		private IMoraleAreaTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMoraleAreaTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMoraleAreaTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMoraleAreaTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x00175118 File Offset: 0x00173318
		public static IMoraleAreaTip Create([Nullable(2)] IMoraleAreaTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoraleAreaTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x0017512B File Offset: 0x0017332B
		public static IMoraleAreaTip CreateFromSetValue([Nullable(2)] IMoraleAreaTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMoraleAreaTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x00175140 File Offset: 0x00173340
		public new IMoraleAreaTip_SetValue ToSetValue()
		{
			return new IMoraleAreaTip_SetValue
			{
				Type = this.Type,
				TidAreaNameText = this.TidAreaNameText,
				TidRecommendText = this.TidRecommendText,
				AreaType = this.AreaType,
				UiType = this.UiType,
				EdTidAreaNameText = this.EdTidAreaNameText,
				EdTidRecommendText = this.EdTidRecommendText
			};
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600A317 RID: 41751 RVA: 0x001751A6 File Offset: 0x001733A6
		// (set) Token: 0x0600A318 RID: 41752 RVA: 0x001751D1 File Offset: 0x001733D1
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600A319 RID: 41753 RVA: 0x001751DF File Offset: 0x001733DF
		// (set) Token: 0x0600A31A RID: 41754 RVA: 0x0017520A File Offset: 0x0017340A
		public virtual string TidAreaNameText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidAreaNameText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidAreaNameText;
			}
			set
			{
				this.GetOrCreatePoco().TidAreaNameText = value;
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600A31B RID: 41755 RVA: 0x00175218 File Offset: 0x00173418
		// (set) Token: 0x0600A31C RID: 41756 RVA: 0x00175243 File Offset: 0x00173443
		public virtual string TidRecommendText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidRecommendText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidRecommendText;
			}
			set
			{
				this.GetOrCreatePoco().TidRecommendText = value;
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600A31D RID: 41757 RVA: 0x00175251 File Offset: 0x00173451
		// (set) Token: 0x0600A31E RID: 41758 RVA: 0x0017527C File Offset: 0x0017347C
		public virtual EMoraleAreaType AreaType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaType;
				}
				if (this.PocoInterface == null)
				{
					return EMoraleAreaType.MoraleArea1;
				}
				return this.PocoInterface.AreaType;
			}
			set
			{
				this.GetOrCreatePoco().AreaType = value;
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600A31F RID: 41759 RVA: 0x0017528C File Offset: 0x0017348C
		// (set) Token: 0x0600A320 RID: 41760 RVA: 0x001752C6 File Offset: 0x001734C6
		public virtual EMoraleUiType? UiType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiType;
				}
				IMoraleAreaTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiType;
			}
			set
			{
				this.GetOrCreatePoco().UiType = value;
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600A321 RID: 41761 RVA: 0x001752D4 File Offset: 0x001734D4
		// (set) Token: 0x0600A322 RID: 41762 RVA: 0x001752EB File Offset: 0x001734EB
		[Nullable(2)]
		public virtual string EdTidAreaNameText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidAreaNameText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidAreaNameText = value;
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600A323 RID: 41763 RVA: 0x001752F9 File Offset: 0x001734F9
		// (set) Token: 0x0600A324 RID: 41764 RVA: 0x00175310 File Offset: 0x00173510
		[Nullable(2)]
		public virtual string EdTidRecommendText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidRecommendText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidRecommendText = value;
			}
		}

		// Token: 0x040062D0 RID: 25296
		[Nullable(2)]
		protected new IMoraleAreaTip FbInstance;

		// Token: 0x040062D1 RID: 25297
		[Nullable(2)]
		protected new IMoraleAreaTip_SetValue PocoInterface;
	}
}
