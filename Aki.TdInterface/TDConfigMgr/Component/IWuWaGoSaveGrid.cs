using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008BA RID: 2234
	public class IWuWaGoSaveGrid : IWuWaGoEntityBase
	{
		// Token: 0x06003029 RID: 12329 RVA: 0x0007BD18 File Offset: 0x00079F18
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

		// Token: 0x0600302A RID: 12330 RVA: 0x0007BD50 File Offset: 0x00079F50
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

		// Token: 0x0600302B RID: 12331 RVA: 0x0007BD63 File Offset: 0x00079F63
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

		// Token: 0x0600302C RID: 12332 RVA: 0x0007BD76 File Offset: 0x00079F76
		public new IWuWaGoSaveGrid_SetValue ToSetValue()
		{
			return new IWuWaGoSaveGrid_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData,
				HintSteps = this.HintSteps
			};
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x0007BDA1 File Offset: 0x00079FA1
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x0007BDCC File Offset: 0x00079FCC
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

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x0007BDDC File Offset: 0x00079FDC
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x0007BE3D File Offset: 0x0007A03D
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

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x0007BE52 File Offset: 0x0007A052
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x0007BE79 File Offset: 0x0007A079
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().HintSteps = value;
			}
		}

		// Token: 0x04001FD1 RID: 8145
		[Nullable(2)]
		protected new IWuWaGoSaveGrid FbInstance;

		// Token: 0x04001FD2 RID: 8146
		[Nullable(2)]
		protected new IWuWaGoSaveGrid_SetValue PocoInterface;

		// Token: 0x04001FD3 RID: 8147
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001FD4 RID: 8148
		private bool _LinkDataInited;
	}
}
