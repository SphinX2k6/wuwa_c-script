using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D73 RID: 7539
	public class ILiveUiConfig
	{
		// Token: 0x0600A011 RID: 40977 RVA: 0x0016F4A8 File Offset: 0x0016D6A8
		private ILiveUiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveUiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveUiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveUiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x0016F4E0 File Offset: 0x0016D6E0
		public static ILiveUiConfig Create([Nullable(2)] ILiveUiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x0016F4F3 File Offset: 0x0016D6F3
		public static ILiveUiConfig CreateFromSetValue([Nullable(2)] ILiveUiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveUiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x0016F506 File Offset: 0x0016D706
		public ILiveUiConfig_SetValue ToSetValue()
		{
			return new ILiveUiConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600A015 RID: 40981 RVA: 0x0016F519 File Offset: 0x0016D719
		// (set) Token: 0x0600A016 RID: 40982 RVA: 0x0016F544 File Offset: 0x0016D744
		public virtual ELiveUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveUiType.Start;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006157 RID: 24919
		[Nullable(2)]
		protected ILiveUiConfig FbInstance;

		// Token: 0x04006158 RID: 24920
		[Nullable(2)]
		protected ILiveUiConfig_SetValue PocoInterface;
	}
}
