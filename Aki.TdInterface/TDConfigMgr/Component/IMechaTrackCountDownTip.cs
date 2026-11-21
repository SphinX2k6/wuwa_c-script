using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000543 RID: 1347
	public class IMechaTrackCountDownTip : ITrampleTipType
	{
		// Token: 0x06001B26 RID: 6950 RVA: 0x0004F228 File Offset: 0x0004D428
		private IMechaTrackCountDownTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechaTrackCountDownTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechaTrackCountDownTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechaTrackCountDownTip_SetValue());
			}
			return result;
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0004F260 File Offset: 0x0004D460
		public static IMechaTrackCountDownTip Create([Nullable(2)] IMechaTrackCountDownTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackCountDownTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0004F273 File Offset: 0x0004D473
		public static IMechaTrackCountDownTip CreateFromSetValue([Nullable(2)] IMechaTrackCountDownTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechaTrackCountDownTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0004F286 File Offset: 0x0004D486
		public new IMechaTrackCountDownTip_SetValue ToSetValue()
		{
			return new IMechaTrackCountDownTip_SetValue
			{
				Type = this.Type,
				TidCountDownTip = this.TidCountDownTip,
				EdTidCountDownTip = this.EdTidCountDownTip
			};
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0004F2B1 File Offset: 0x0004D4B1
		// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0004F2DC File Offset: 0x0004D4DC
		public override ETrampleTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0004F2EA File Offset: 0x0004D4EA
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0004F315 File Offset: 0x0004D515
		public virtual string TidCountDownTip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidCountDownTip;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidCountDownTip;
			}
			set
			{
				this.GetOrCreatePoco().TidCountDownTip = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0004F323 File Offset: 0x0004D523
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0004F33A File Offset: 0x0004D53A
		[Nullable(2)]
		public virtual string EdTidCountDownTip
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidCountDownTip;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidCountDownTip = value;
			}
		}

		// Token: 0x040013D4 RID: 5076
		[Nullable(2)]
		protected new IMechaTrackCountDownTip FbInstance;

		// Token: 0x040013D5 RID: 5077
		[Nullable(2)]
		protected new IMechaTrackCountDownTip_SetValue PocoInterface;
	}
}
