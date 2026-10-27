using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000827 RID: 2087
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelQteComponent : IComponentBase
	{
		// Token: 0x06002D6D RID: 11629 RVA: 0x00075B18 File Offset: 0x00073D18
		private LevelQteComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LevelQteComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LevelQteComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LevelQteComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00075B50 File Offset: 0x00073D50
		public static LevelQteComponent Create([Nullable(2)] LevelQteComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelQteComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00075B63 File Offset: 0x00073D63
		public static LevelQteComponent CreateFromSetValue([Nullable(2)] LevelQteComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LevelQteComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00075B76 File Offset: 0x00073D76
		public new LevelQteComponent_SetValue ToSetValue()
		{
			return new LevelQteComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				QteConfig = this.QteConfig
			};
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x00075BA4 File Offset: 0x00073DA4
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x00075BDE File Offset: 0x00073DDE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				LevelQteComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x00075BEC File Offset: 0x00073DEC
		// (set) Token: 0x06002D74 RID: 11636 RVA: 0x00075C16 File Offset: 0x00073E16
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x00075C24 File Offset: 0x00073E24
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x00075C85 File Offset: 0x00073E85
		public virtual ISingleBtnQte QteConfig
		{
			get
			{
				if (this._QteConfigInited)
				{
					return this._QteConfigCache;
				}
				this._QteConfigInited = true;
				if (this.FbInstance != null)
				{
					this._QteConfigCache = ISingleBtnQte.Create(this.FbInstance.QteConfig);
				}
				else
				{
					LevelQteComponent_SetValue pocoInterface = this.PocoInterface;
					this._QteConfigCache = ((pocoInterface != null) ? pocoInterface.QteConfig : null);
				}
				return this._QteConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().QteConfig = value;
				this._QteConfigInited = false;
			}
		}

		// Token: 0x04001E11 RID: 7697
		[Nullable(2)]
		protected new LevelQteComponent FbInstance;

		// Token: 0x04001E12 RID: 7698
		[Nullable(2)]
		protected new LevelQteComponent_SetValue PocoInterface;

		// Token: 0x04001E13 RID: 7699
		private ISingleBtnQte _QteConfigCache;

		// Token: 0x04001E14 RID: 7700
		private bool _QteConfigInited;
	}
}
