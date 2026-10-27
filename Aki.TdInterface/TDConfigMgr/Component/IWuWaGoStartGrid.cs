using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200081B RID: 2075
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoStartGrid : IWuWaGoEntityBase
	{
		// Token: 0x06002D0F RID: 11535 RVA: 0x00074C74 File Offset: 0x00072E74
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

		// Token: 0x06002D10 RID: 11536 RVA: 0x00074CAC File Offset: 0x00072EAC
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

		// Token: 0x06002D11 RID: 11537 RVA: 0x00074CBF File Offset: 0x00072EBF
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

		// Token: 0x06002D12 RID: 11538 RVA: 0x00074CD2 File Offset: 0x00072ED2
		public new IWuWaGoStartGrid_SetValue ToSetValue()
		{
			return new IWuWaGoStartGrid_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData,
				HintSteps = this.HintSteps
			};
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x00074CFD File Offset: 0x00072EFD
		// (set) Token: 0x06002D14 RID: 11540 RVA: 0x00074D28 File Offset: 0x00072F28
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

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x00074D38 File Offset: 0x00072F38
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x00074D99 File Offset: 0x00072F99
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

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x00074DAE File Offset: 0x00072FAE
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x00074DD5 File Offset: 0x00072FD5
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IWuWaGoHintStepBase> HintSteps
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().HintSteps = value;
			}
		}

		// Token: 0x04001DD2 RID: 7634
		[Nullable(2)]
		protected new IWuWaGoStartGrid FbInstance;

		// Token: 0x04001DD3 RID: 7635
		[Nullable(2)]
		protected new IWuWaGoStartGrid_SetValue PocoInterface;

		// Token: 0x04001DD4 RID: 7636
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001DD5 RID: 7637
		private bool _LinkDataInited;
	}
}
