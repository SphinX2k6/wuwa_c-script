using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D9F RID: 7583
	public class ILoopSeasonChange : IClientSetSeasonStateConfig
	{
		// Token: 0x0600A0F3 RID: 41203 RVA: 0x00170FB8 File Offset: 0x0016F1B8
		private ILoopSeasonChange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILoopSeasonChange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILoopSeasonChange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILoopSeasonChange_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x00170FF0 File Offset: 0x0016F1F0
		public static ILoopSeasonChange Create([Nullable(2)] ILoopSeasonChange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILoopSeasonChange
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x00171003 File Offset: 0x0016F203
		public static ILoopSeasonChange CreateFromSetValue([Nullable(2)] ILoopSeasonChange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILoopSeasonChange
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x00171018 File Offset: 0x0016F218
		public new ILoopSeasonChange_SetValue ToSetValue()
		{
			return new ILoopSeasonChange_SetValue
			{
				Type = this.Type,
				EnableLoop = this.EnableLoop,
				SpringConfig = this.SpringConfig,
				SummerConfig = this.SummerConfig,
				AutumnConfig = this.AutumnConfig,
				WinterConfig = this.WinterConfig
			};
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600A0F7 RID: 41207 RVA: 0x00171072 File Offset: 0x0016F272
		// (set) Token: 0x0600A0F8 RID: 41208 RVA: 0x0017109D File Offset: 0x0016F29D
		public override EClientSetSeasonStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientSetSeasonStateType.SwitchSeason;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600A0F9 RID: 41209 RVA: 0x001710AB File Offset: 0x0016F2AB
		// (set) Token: 0x0600A0FA RID: 41210 RVA: 0x001710D6 File Offset: 0x0016F2D6
		public virtual bool EnableLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableLoop;
				}
				return this.PocoInterface != null && this.PocoInterface.EnableLoop;
			}
			set
			{
				this.GetOrCreatePoco().EnableLoop = value;
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600A0FB RID: 41211 RVA: 0x001710E4 File Offset: 0x0016F2E4
		// (set) Token: 0x0600A0FC RID: 41212 RVA: 0x00171145 File Offset: 0x0016F345
		public virtual ISeasonLoopConfig SpringConfig
		{
			get
			{
				if (this._SpringConfigInited)
				{
					return this._SpringConfigCache;
				}
				this._SpringConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SpringConfigCache = ISeasonLoopConfig.Create(this.FbInstance.SpringConfig);
				}
				else
				{
					ILoopSeasonChange_SetValue pocoInterface = this.PocoInterface;
					this._SpringConfigCache = ((pocoInterface != null) ? pocoInterface.SpringConfig : null);
				}
				return this._SpringConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SpringConfig = value;
				this._SpringConfigInited = false;
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600A0FD RID: 41213 RVA: 0x0017115C File Offset: 0x0016F35C
		// (set) Token: 0x0600A0FE RID: 41214 RVA: 0x001711BD File Offset: 0x0016F3BD
		public virtual ISeasonLoopConfig SummerConfig
		{
			get
			{
				if (this._SummerConfigInited)
				{
					return this._SummerConfigCache;
				}
				this._SummerConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SummerConfigCache = ISeasonLoopConfig.Create(this.FbInstance.SummerConfig);
				}
				else
				{
					ILoopSeasonChange_SetValue pocoInterface = this.PocoInterface;
					this._SummerConfigCache = ((pocoInterface != null) ? pocoInterface.SummerConfig : null);
				}
				return this._SummerConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SummerConfig = value;
				this._SummerConfigInited = false;
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600A0FF RID: 41215 RVA: 0x001711D4 File Offset: 0x0016F3D4
		// (set) Token: 0x0600A100 RID: 41216 RVA: 0x00171235 File Offset: 0x0016F435
		public virtual ISeasonLoopConfig AutumnConfig
		{
			get
			{
				if (this._AutumnConfigInited)
				{
					return this._AutumnConfigCache;
				}
				this._AutumnConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AutumnConfigCache = ISeasonLoopConfig.Create(this.FbInstance.AutumnConfig);
				}
				else
				{
					ILoopSeasonChange_SetValue pocoInterface = this.PocoInterface;
					this._AutumnConfigCache = ((pocoInterface != null) ? pocoInterface.AutumnConfig : null);
				}
				return this._AutumnConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().AutumnConfig = value;
				this._AutumnConfigInited = false;
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600A101 RID: 41217 RVA: 0x0017124C File Offset: 0x0016F44C
		// (set) Token: 0x0600A102 RID: 41218 RVA: 0x001712AD File Offset: 0x0016F4AD
		public virtual ISeasonLoopConfig WinterConfig
		{
			get
			{
				if (this._WinterConfigInited)
				{
					return this._WinterConfigCache;
				}
				this._WinterConfigInited = true;
				if (this.FbInstance != null)
				{
					this._WinterConfigCache = ISeasonLoopConfig.Create(this.FbInstance.WinterConfig);
				}
				else
				{
					ILoopSeasonChange_SetValue pocoInterface = this.PocoInterface;
					this._WinterConfigCache = ((pocoInterface != null) ? pocoInterface.WinterConfig : null);
				}
				return this._WinterConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().WinterConfig = value;
				this._WinterConfigInited = false;
			}
		}

		// Token: 0x040061C8 RID: 25032
		[Nullable(2)]
		protected new ILoopSeasonChange FbInstance;

		// Token: 0x040061C9 RID: 25033
		[Nullable(2)]
		protected new ILoopSeasonChange_SetValue PocoInterface;

		// Token: 0x040061CA RID: 25034
		private ISeasonLoopConfig _SpringConfigCache;

		// Token: 0x040061CB RID: 25035
		private bool _SpringConfigInited;

		// Token: 0x040061CC RID: 25036
		private ISeasonLoopConfig _SummerConfigCache;

		// Token: 0x040061CD RID: 25037
		private bool _SummerConfigInited;

		// Token: 0x040061CE RID: 25038
		private ISeasonLoopConfig _AutumnConfigCache;

		// Token: 0x040061CF RID: 25039
		private bool _AutumnConfigInited;

		// Token: 0x040061D0 RID: 25040
		private ISeasonLoopConfig _WinterConfigCache;

		// Token: 0x040061D1 RID: 25041
		private bool _WinterConfigInited;
	}
}
