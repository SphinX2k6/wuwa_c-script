using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB8 RID: 7096
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoopSeasonChange : IClientSetSeasonStateConfig
	{
		// Token: 0x060097EF RID: 38895 RVA: 0x0015E4F8 File Offset: 0x0015C6F8
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

		// Token: 0x060097F0 RID: 38896 RVA: 0x0015E530 File Offset: 0x0015C730
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

		// Token: 0x060097F1 RID: 38897 RVA: 0x0015E543 File Offset: 0x0015C743
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

		// Token: 0x060097F2 RID: 38898 RVA: 0x0015E558 File Offset: 0x0015C758
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

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x060097F3 RID: 38899 RVA: 0x0015E5B2 File Offset: 0x0015C7B2
		// (set) Token: 0x060097F4 RID: 38900 RVA: 0x0015E5DD File Offset: 0x0015C7DD
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

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x060097F5 RID: 38901 RVA: 0x0015E5EB File Offset: 0x0015C7EB
		// (set) Token: 0x060097F6 RID: 38902 RVA: 0x0015E616 File Offset: 0x0015C816
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

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x060097F7 RID: 38903 RVA: 0x0015E624 File Offset: 0x0015C824
		// (set) Token: 0x060097F8 RID: 38904 RVA: 0x0015E685 File Offset: 0x0015C885
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

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x060097F9 RID: 38905 RVA: 0x0015E69C File Offset: 0x0015C89C
		// (set) Token: 0x060097FA RID: 38906 RVA: 0x0015E6FD File Offset: 0x0015C8FD
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

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x060097FB RID: 38907 RVA: 0x0015E714 File Offset: 0x0015C914
		// (set) Token: 0x060097FC RID: 38908 RVA: 0x0015E775 File Offset: 0x0015C975
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

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x060097FD RID: 38909 RVA: 0x0015E78C File Offset: 0x0015C98C
		// (set) Token: 0x060097FE RID: 38910 RVA: 0x0015E7ED File Offset: 0x0015C9ED
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

		// Token: 0x04005CB3 RID: 23731
		[Nullable(2)]
		protected new ILoopSeasonChange FbInstance;

		// Token: 0x04005CB4 RID: 23732
		[Nullable(2)]
		protected new ILoopSeasonChange_SetValue PocoInterface;

		// Token: 0x04005CB5 RID: 23733
		private ISeasonLoopConfig _SpringConfigCache;

		// Token: 0x04005CB6 RID: 23734
		private bool _SpringConfigInited;

		// Token: 0x04005CB7 RID: 23735
		private ISeasonLoopConfig _SummerConfigCache;

		// Token: 0x04005CB8 RID: 23736
		private bool _SummerConfigInited;

		// Token: 0x04005CB9 RID: 23737
		private ISeasonLoopConfig _AutumnConfigCache;

		// Token: 0x04005CBA RID: 23738
		private bool _AutumnConfigInited;

		// Token: 0x04005CBB RID: 23739
		private ISeasonLoopConfig _WinterConfigCache;

		// Token: 0x04005CBC RID: 23740
		private bool _WinterConfigInited;
	}
}
