using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001958 RID: 6488
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomShowUi
	{
		// Token: 0x06008AFD RID: 35581 RVA: 0x00147004 File Offset: 0x00145204
		private ICustomShowUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomShowUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomShowUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomShowUi_SetValue());
			}
			return result;
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x0014703C File Offset: 0x0014523C
		public static ICustomShowUi Create([Nullable(2)] ICustomShowUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomShowUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AFF RID: 35583 RVA: 0x0014704F File Offset: 0x0014524F
		public static ICustomShowUi CreateFromSetValue([Nullable(2)] ICustomShowUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomShowUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B00 RID: 35584 RVA: 0x00147062 File Offset: 0x00145262
		public ICustomShowUi_SetValue ToSetValue()
		{
			return new ICustomShowUi_SetValue
			{
				TextSetting = this.TextSetting,
				IsHideCircle = this.IsHideCircle
			};
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x06008B01 RID: 35585 RVA: 0x00147084 File Offset: 0x00145284
		// (set) Token: 0x06008B02 RID: 35586 RVA: 0x001470E5 File Offset: 0x001452E5
		[Nullable(2)]
		public virtual ICustomScreenTextSetting TextSetting
		{
			[NullableContext(2)]
			get
			{
				if (this._TextSettingInited)
				{
					return this._TextSettingCache;
				}
				this._TextSettingInited = true;
				if (this.FbInstance != null)
				{
					this._TextSettingCache = ICustomScreenTextSetting.Create(this.FbInstance.TextSetting);
				}
				else
				{
					ICustomShowUi_SetValue pocoInterface = this.PocoInterface;
					this._TextSettingCache = ((pocoInterface != null) ? pocoInterface.TextSetting : null);
				}
				return this._TextSettingCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TextSetting = value;
				this._TextSettingInited = false;
			}
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x06008B03 RID: 35587 RVA: 0x001470FC File Offset: 0x001452FC
		// (set) Token: 0x06008B04 RID: 35588 RVA: 0x00147136 File Offset: 0x00145336
		public virtual bool? IsHideCircle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsHideCircle;
				}
				ICustomShowUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsHideCircle;
			}
			set
			{
				this.GetOrCreatePoco().IsHideCircle = value;
			}
		}

		// Token: 0x040056C4 RID: 22212
		[Nullable(2)]
		protected ICustomShowUi FbInstance;

		// Token: 0x040056C5 RID: 22213
		[Nullable(2)]
		protected ICustomShowUi_SetValue PocoInterface;

		// Token: 0x040056C6 RID: 22214
		private ICustomScreenTextSetting _TextSettingCache;

		// Token: 0x040056C7 RID: 22215
		private bool _TextSettingInited;
	}
}
