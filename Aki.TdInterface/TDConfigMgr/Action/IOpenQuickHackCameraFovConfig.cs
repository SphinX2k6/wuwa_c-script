using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CAA RID: 7338
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenQuickHackCameraFovConfig
	{
		// Token: 0x06009D7D RID: 40317 RVA: 0x00168B58 File Offset: 0x00166D58
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

		// Token: 0x06009D7E RID: 40318 RVA: 0x00168B90 File Offset: 0x00166D90
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

		// Token: 0x06009D7F RID: 40319 RVA: 0x00168BA3 File Offset: 0x00166DA3
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

		// Token: 0x06009D80 RID: 40320 RVA: 0x00168BB6 File Offset: 0x00166DB6
		public IOpenQuickHackCameraFovConfig_SetValue ToSetValue()
		{
			return new IOpenQuickHackCameraFovConfig_SetValue
			{
				DefaultValue = this.DefaultValue,
				Min = this.Min,
				Max = this.Max
			};
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x06009D81 RID: 40321 RVA: 0x00168BE1 File Offset: 0x00166DE1
		// (set) Token: 0x06009D82 RID: 40322 RVA: 0x00168C0C File Offset: 0x00166E0C
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

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x06009D83 RID: 40323 RVA: 0x00168C1A File Offset: 0x00166E1A
		// (set) Token: 0x06009D84 RID: 40324 RVA: 0x00168C45 File Offset: 0x00166E45
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

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x06009D85 RID: 40325 RVA: 0x00168C53 File Offset: 0x00166E53
		// (set) Token: 0x06009D86 RID: 40326 RVA: 0x00168C7E File Offset: 0x00166E7E
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

		// Token: 0x04005F59 RID: 24409
		[Nullable(2)]
		protected IOpenQuickHackCameraFovConfig FbInstance;

		// Token: 0x04005F5A RID: 24410
		[Nullable(2)]
		protected IOpenQuickHackCameraFovConfig_SetValue PocoInterface;
	}
}
