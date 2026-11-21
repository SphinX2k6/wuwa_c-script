using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE3 RID: 6883
	public class ICustomShowUi
	{
		// Token: 0x06009231 RID: 37425 RVA: 0x00156A00 File Offset: 0x00154C00
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

		// Token: 0x06009232 RID: 37426 RVA: 0x00156A38 File Offset: 0x00154C38
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

		// Token: 0x06009233 RID: 37427 RVA: 0x00156A4B File Offset: 0x00154C4B
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

		// Token: 0x06009234 RID: 37428 RVA: 0x00156A5E File Offset: 0x00154C5E
		public ICustomShowUi_SetValue ToSetValue()
		{
			return new ICustomShowUi_SetValue
			{
				TextSetting = this.TextSetting,
				IsHideCircle = this.IsHideCircle
			};
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x06009235 RID: 37429 RVA: 0x00156A80 File Offset: 0x00154C80
		// (set) Token: 0x06009236 RID: 37430 RVA: 0x00156AE1 File Offset: 0x00154CE1
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

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x06009237 RID: 37431 RVA: 0x00156AF8 File Offset: 0x00154CF8
		// (set) Token: 0x06009238 RID: 37432 RVA: 0x00156B32 File Offset: 0x00154D32
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

		// Token: 0x04005B17 RID: 23319
		[Nullable(2)]
		protected ICustomShowUi FbInstance;

		// Token: 0x04005B18 RID: 23320
		[Nullable(2)]
		protected ICustomShowUi_SetValue PocoInterface;

		// Token: 0x04005B19 RID: 23321
		private ICustomScreenTextSetting _TextSettingCache;

		// Token: 0x04005B1A RID: 23322
		private bool _TextSettingInited;
	}
}
