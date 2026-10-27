using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C0C RID: 7180
	[NullableContext(1)]
	[Nullable(0)]
	public class IMoraleAreaTip : ICommonTipType
	{
		// Token: 0x060099E3 RID: 39395 RVA: 0x00162194 File Offset: 0x00160394
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

		// Token: 0x060099E4 RID: 39396 RVA: 0x001621CC File Offset: 0x001603CC
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

		// Token: 0x060099E5 RID: 39397 RVA: 0x001621DF File Offset: 0x001603DF
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

		// Token: 0x060099E6 RID: 39398 RVA: 0x001621F4 File Offset: 0x001603F4
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

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x060099E7 RID: 39399 RVA: 0x0016225A File Offset: 0x0016045A
		// (set) Token: 0x060099E8 RID: 39400 RVA: 0x00162285 File Offset: 0x00160485
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

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x060099E9 RID: 39401 RVA: 0x00162293 File Offset: 0x00160493
		// (set) Token: 0x060099EA RID: 39402 RVA: 0x001622BE File Offset: 0x001604BE
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

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x060099EB RID: 39403 RVA: 0x001622CC File Offset: 0x001604CC
		// (set) Token: 0x060099EC RID: 39404 RVA: 0x001622F7 File Offset: 0x001604F7
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

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x060099ED RID: 39405 RVA: 0x00162305 File Offset: 0x00160505
		// (set) Token: 0x060099EE RID: 39406 RVA: 0x00162330 File Offset: 0x00160530
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

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x060099EF RID: 39407 RVA: 0x00162340 File Offset: 0x00160540
		// (set) Token: 0x060099F0 RID: 39408 RVA: 0x0016237A File Offset: 0x0016057A
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

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x060099F1 RID: 39409 RVA: 0x00162388 File Offset: 0x00160588
		// (set) Token: 0x060099F2 RID: 39410 RVA: 0x0016239F File Offset: 0x0016059F
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

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x060099F3 RID: 39411 RVA: 0x001623AD File Offset: 0x001605AD
		// (set) Token: 0x060099F4 RID: 39412 RVA: 0x001623C4 File Offset: 0x001605C4
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

		// Token: 0x04005DA9 RID: 23977
		[Nullable(2)]
		protected new IMoraleAreaTip FbInstance;

		// Token: 0x04005DAA RID: 23978
		[Nullable(2)]
		protected new IMoraleAreaTip_SetValue PocoInterface;
	}
}
