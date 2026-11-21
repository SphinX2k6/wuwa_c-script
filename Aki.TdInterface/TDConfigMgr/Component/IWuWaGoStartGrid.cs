using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008BE RID: 2238
	public class IWuWaGoStartGrid : IWuWaGoEntityBase
	{
		// Token: 0x0600303F RID: 12351 RVA: 0x0007BFD8 File Offset: 0x0007A1D8
		private IWuWaGoStartGrid_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoStartGrid 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoStartGrid_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoStartGrid_SetValue());
			}
			return result;
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0007C010 File Offset: 0x0007A210
		public static IWuWaGoStartGrid Create([Nullable(2)] IWuWaGoStartGrid instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoStartGrid
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0007C023 File Offset: 0x0007A223
		public static IWuWaGoStartGrid CreateFromSetValue([Nullable(2)] IWuWaGoStartGrid_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoStartGrid
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0007C036 File Offset: 0x0007A236
		public new IWuWaGoStartGrid_SetValue ToSetValue()
		{
			return new IWuWaGoStartGrid_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData,
				HintSteps = this.HintSteps
			};
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06003043 RID: 12355 RVA: 0x0007C061 File Offset: 0x0007A261
		// (set) Token: 0x06003044 RID: 12356 RVA: 0x0007C08C File Offset: 0x0007A28C
		public override EWuWaGoEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x0007C09C File Offset: 0x0007A29C
		// (set) Token: 0x06003046 RID: 12358 RVA: 0x0007C0FD File Offset: 0x0007A2FD
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				if (this.FbInstance != null)
				{
					this._LinkDataCache = IWuWaGoGridLinkData.Create(this.FbInstance.LinkData);
				}
				else
				{
					IWuWaGoStartGrid_SetValue pocoInterface = this.PocoInterface;
					this._LinkDataCache = ((pocoInterface != null) ? pocoInterface.LinkData : null);
				}
				return this._LinkDataCache;
			}
			set
			{
				this.GetOrCreatePoco().LinkData = value;
				this._LinkDataInited = false;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x0007C112 File Offset: 0x0007A312
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x0007C139 File Offset: 0x0007A339
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IWuWaGoHintStepBase> HintSteps
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HintSteps;
				}
				IWuWaGoStartGrid_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HintSteps;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().HintSteps = value;
			}
		}

		// Token: 0x04001FDE RID: 8158
		[Nullable(2)]
		protected new IWuWaGoStartGrid FbInstance;

		// Token: 0x04001FDF RID: 8159
		[Nullable(2)]
		protected new IWuWaGoStartGrid_SetValue PocoInterface;

		// Token: 0x04001FE0 RID: 8160
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001FE1 RID: 8161
		private bool _LinkDataInited;
	}
}
