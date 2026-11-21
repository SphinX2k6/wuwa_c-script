using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB1 RID: 7857
	public class IOpenQuickHackCameraFovConfig
	{
		// Token: 0x0600A72B RID: 42795 RVA: 0x0017C7B8 File Offset: 0x0017A9B8
		private IOpenQuickHackCameraFovConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenQuickHackCameraFovConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenQuickHackCameraFovConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenQuickHackCameraFovConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x0017C7F0 File Offset: 0x0017A9F0
		public static IOpenQuickHackCameraFovConfig Create([Nullable(2)] IOpenQuickHackCameraFovConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenQuickHackCameraFovConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A72D RID: 42797 RVA: 0x0017C803 File Offset: 0x0017AA03
		public static IOpenQuickHackCameraFovConfig CreateFromSetValue([Nullable(2)] IOpenQuickHackCameraFovConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenQuickHackCameraFovConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x0017C816 File Offset: 0x0017AA16
		public IOpenQuickHackCameraFovConfig_SetValue ToSetValue()
		{
			return new IOpenQuickHackCameraFovConfig_SetValue
			{
				DefaultValue = this.DefaultValue,
				Min = this.Min,
				Max = this.Max
			};
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600A72F RID: 42799 RVA: 0x0017C841 File Offset: 0x0017AA41
		// (set) Token: 0x0600A730 RID: 42800 RVA: 0x0017C86C File Offset: 0x0017AA6C
		public virtual int DefaultValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DefaultValue;
			}
			set
			{
				this.GetOrCreatePoco().DefaultValue = value;
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600A731 RID: 42801 RVA: 0x0017C87A File Offset: 0x0017AA7A
		// (set) Token: 0x0600A732 RID: 42802 RVA: 0x0017C8A5 File Offset: 0x0017AAA5
		public virtual int Min
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Min;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Min;
			}
			set
			{
				this.GetOrCreatePoco().Min = value;
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600A733 RID: 42803 RVA: 0x0017C8B3 File Offset: 0x0017AAB3
		// (set) Token: 0x0600A734 RID: 42804 RVA: 0x0017C8DE File Offset: 0x0017AADE
		public virtual int Max
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Max;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Max;
			}
			set
			{
				this.GetOrCreatePoco().Max = value;
			}
		}

		// Token: 0x040064B5 RID: 25781
		[Nullable(2)]
		protected IOpenQuickHackCameraFovConfig FbInstance;

		// Token: 0x040064B6 RID: 25782
		[Nullable(2)]
		protected IOpenQuickHackCameraFovConfig_SetValue PocoInterface;
	}
}
