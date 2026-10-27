using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000817 RID: 2071
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoSaveGrid : IWuWaGoEntityBase
	{
		// Token: 0x06002CF9 RID: 11513 RVA: 0x000749B4 File Offset: 0x00072BB4
		private IWuWaGoSaveGrid_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoSaveGrid 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoSaveGrid_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoSaveGrid_SetValue());
			}
			return result;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000749EC File Offset: 0x00072BEC
		public static IWuWaGoSaveGrid Create([Nullable(2)] IWuWaGoSaveGrid instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoSaveGrid
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000749FF File Offset: 0x00072BFF
		public static IWuWaGoSaveGrid CreateFromSetValue([Nullable(2)] IWuWaGoSaveGrid_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoSaveGrid
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00074A12 File Offset: 0x00072C12
		public new IWuWaGoSaveGrid_SetValue ToSetValue()
		{
			return new IWuWaGoSaveGrid_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData,
				HintSteps = this.HintSteps
			};
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x00074A3D File Offset: 0x00072C3D
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00074A68 File Offset: 0x00072C68
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

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x00074A78 File Offset: 0x00072C78
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x00074AD9 File Offset: 0x00072CD9
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
					IWuWaGoSaveGrid_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x00074AEE File Offset: 0x00072CEE
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x00074B15 File Offset: 0x00072D15
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
				IWuWaGoSaveGrid_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001DC5 RID: 7621
		[Nullable(2)]
		protected new IWuWaGoSaveGrid FbInstance;

		// Token: 0x04001DC6 RID: 7622
		[Nullable(2)]
		protected new IWuWaGoSaveGrid_SetValue PocoInterface;

		// Token: 0x04001DC7 RID: 7623
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001DC8 RID: 7624
		private bool _LinkDataInited;
	}
}
