using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A95 RID: 6805
	public class ICommonTip2PrepareCountdown : ICommonTip2Type
	{
		// Token: 0x06009091 RID: 37009 RVA: 0x00153F24 File Offset: 0x00152124
		private ICommonTip2PrepareCountdown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTip2PrepareCountdown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTip2PrepareCountdown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTip2PrepareCountdown_SetValue());
			}
			return result;
		}

		// Token: 0x06009092 RID: 37010 RVA: 0x00153F5C File Offset: 0x0015215C
		public static ICommonTip2PrepareCountdown Create([Nullable(2)] ICommonTip2PrepareCountdown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTip2PrepareCountdown
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x00153F6F File Offset: 0x0015216F
		public static ICommonTip2PrepareCountdown CreateFromSetValue([Nullable(2)] ICommonTip2PrepareCountdown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTip2PrepareCountdown
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x00153F84 File Offset: 0x00152184
		public new ICommonTip2PrepareCountdown_SetValue ToSetValue()
		{
			return new ICommonTip2PrepareCountdown_SetValue
			{
				Type = this.Type,
				CountDownNum = this.CountDownNum,
				TidCountDownTxt = this.TidCountDownTxt,
				UiStyle = this.UiStyle,
				IsBlockPlayer = this.IsBlockPlayer,
				EdTidCountDownTxt = this.EdTidCountDownTxt
			};
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x06009095 RID: 37013 RVA: 0x00153FDE File Offset: 0x001521DE
		// (set) Token: 0x06009096 RID: 37014 RVA: 0x00154009 File Offset: 0x00152209
		public override ECommonTip2Type Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTip2Type.PrepareCountdown;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x06009097 RID: 37015 RVA: 0x00154017 File Offset: 0x00152217
		// (set) Token: 0x06009098 RID: 37016 RVA: 0x00154042 File Offset: 0x00152242
		public virtual int CountDownNum
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CountDownNum;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CountDownNum;
			}
			set
			{
				this.GetOrCreatePoco().CountDownNum = value;
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x06009099 RID: 37017 RVA: 0x00154050 File Offset: 0x00152250
		// (set) Token: 0x0600909A RID: 37018 RVA: 0x0015407B File Offset: 0x0015227B
		public virtual string TidCountDownTxt
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidCountDownTxt;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidCountDownTxt;
			}
			set
			{
				this.GetOrCreatePoco().TidCountDownTxt = value;
			}
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600909B RID: 37019 RVA: 0x0015408C File Offset: 0x0015228C
		// (set) Token: 0x0600909C RID: 37020 RVA: 0x001540C6 File Offset: 0x001522C6
		public virtual ECountDownUiStyle? UiStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiStyle;
				}
				ICommonTip2PrepareCountdown_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiStyle;
			}
			set
			{
				this.GetOrCreatePoco().UiStyle = value;
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600909D RID: 37021 RVA: 0x001540D4 File Offset: 0x001522D4
		// (set) Token: 0x0600909E RID: 37022 RVA: 0x0015410E File Offset: 0x0015230E
		public virtual bool? IsBlockPlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsBlockPlayer;
				}
				ICommonTip2PrepareCountdown_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsBlockPlayer;
			}
			set
			{
				this.GetOrCreatePoco().IsBlockPlayer = value;
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600909F RID: 37023 RVA: 0x0015411C File Offset: 0x0015231C
		// (set) Token: 0x060090A0 RID: 37024 RVA: 0x00154133 File Offset: 0x00152333
		[Nullable(2)]
		public virtual string EdTidCountDownTxt
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidCountDownTxt;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidCountDownTxt = value;
			}
		}

		// Token: 0x04005A68 RID: 23144
		[Nullable(2)]
		protected new ICommonTip2PrepareCountdown FbInstance;

		// Token: 0x04005A69 RID: 23145
		[Nullable(2)]
		protected new ICommonTip2PrepareCountdown_SetValue PocoInterface;
	}
}
