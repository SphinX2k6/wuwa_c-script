using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A0 RID: 10400
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoopSeasonChange : IClientSetSeasonStateConfig
	{
		// Token: 0x0600E63A RID: 58938 RVA: 0x0021D448 File Offset: 0x0021B648
		public static ILoopSeasonChange Create(ILoopSeasonChange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILoopSeasonChange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046BC RID: 18108
		// (get) Token: 0x0600E63B RID: 58939 RVA: 0x0021D467 File Offset: 0x0021B667
		public override EClientSetSeasonStateType Type
		{
			get
			{
				return (EClientSetSeasonStateType)this.Instance.Type;
			}
		}

		// Token: 0x170046BD RID: 18109
		// (get) Token: 0x0600E63C RID: 58940 RVA: 0x0021D474 File Offset: 0x0021B674
		public virtual bool EnableLoop
		{
			get
			{
				return this.Instance.EnableLoop;
			}
		}

		// Token: 0x170046BE RID: 18110
		// (get) Token: 0x0600E63D RID: 58941 RVA: 0x0021D481 File Offset: 0x0021B681
		public virtual ISeasonLoopConfig SpringConfig
		{
			get
			{
				if (this._SpringConfigInited)
				{
					return this._SpringConfigCache;
				}
				this._SpringConfigInited = true;
				this._SpringConfigCache = ISeasonLoopConfig.Create(this.Instance.SpringConfig);
				return this._SpringConfigCache;
			}
		}

		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x0600E63E RID: 58942 RVA: 0x0021D4B5 File Offset: 0x0021B6B5
		public virtual ISeasonLoopConfig SummerConfig
		{
			get
			{
				if (this._SummerConfigInited)
				{
					return this._SummerConfigCache;
				}
				this._SummerConfigInited = true;
				this._SummerConfigCache = ISeasonLoopConfig.Create(this.Instance.SummerConfig);
				return this._SummerConfigCache;
			}
		}

		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x0600E63F RID: 58943 RVA: 0x0021D4E9 File Offset: 0x0021B6E9
		public virtual ISeasonLoopConfig AutumnConfig
		{
			get
			{
				if (this._AutumnConfigInited)
				{
					return this._AutumnConfigCache;
				}
				this._AutumnConfigInited = true;
				this._AutumnConfigCache = ISeasonLoopConfig.Create(this.Instance.AutumnConfig);
				return this._AutumnConfigCache;
			}
		}

		// Token: 0x170046C1 RID: 18113
		// (get) Token: 0x0600E640 RID: 58944 RVA: 0x0021D51D File Offset: 0x0021B71D
		public virtual ISeasonLoopConfig WinterConfig
		{
			get
			{
				if (this._WinterConfigInited)
				{
					return this._WinterConfigCache;
				}
				this._WinterConfigInited = true;
				this._WinterConfigCache = ISeasonLoopConfig.Create(this.Instance.WinterConfig);
				return this._WinterConfigCache;
			}
		}

		// Token: 0x04007F46 RID: 32582
		private ILoopSeasonChange Instance;

		// Token: 0x04007F47 RID: 32583
		[Nullable(2)]
		private ISeasonLoopConfig _SpringConfigCache;

		// Token: 0x04007F48 RID: 32584
		private bool _SpringConfigInited;

		// Token: 0x04007F49 RID: 32585
		[Nullable(2)]
		private ISeasonLoopConfig _SummerConfigCache;

		// Token: 0x04007F4A RID: 32586
		private bool _SummerConfigInited;

		// Token: 0x04007F4B RID: 32587
		[Nullable(2)]
		private ISeasonLoopConfig _AutumnConfigCache;

		// Token: 0x04007F4C RID: 32588
		private bool _AutumnConfigInited;

		// Token: 0x04007F4D RID: 32589
		[Nullable(2)]
		private ISeasonLoopConfig _WinterConfigCache;

		// Token: 0x04007F4E RID: 32590
		private bool _WinterConfigInited;
	}
}
