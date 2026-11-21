using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096F RID: 2415
	public class TreasureBoxComponent : IComponentBase
	{
		// Token: 0x0600360F RID: 13839 RVA: 0x00089AFC File Offset: 0x00087CFC
		private TreasureBoxComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TreasureBoxComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TreasureBoxComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TreasureBoxComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00089B34 File Offset: 0x00087D34
		public static TreasureBoxComponent Create([Nullable(2)] TreasureBoxComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TreasureBoxComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00089B47 File Offset: 0x00087D47
		public static TreasureBoxComponent CreateFromSetValue([Nullable(2)] TreasureBoxComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TreasureBoxComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00089B5A File Offset: 0x00087D5A
		public new TreasureBoxComponent_SetValue ToSetValue()
		{
			return new TreasureBoxComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TypeId = this.TypeId,
				IsSupportDiscoverDevice = this.IsSupportDiscoverDevice
			};
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x00089B94 File Offset: 0x00087D94
		// (set) Token: 0x06003614 RID: 13844 RVA: 0x00089BCE File Offset: 0x00087DCE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TreasureBoxComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x00089BDC File Offset: 0x00087DDC
		// (set) Token: 0x06003616 RID: 13846 RVA: 0x00089C06 File Offset: 0x00087E06
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

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x00089C14 File Offset: 0x00087E14
		// (set) Token: 0x06003618 RID: 13848 RVA: 0x00089C3F File Offset: 0x00087E3F
		public virtual int TypeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TypeId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TypeId;
			}
			set
			{
				this.GetOrCreatePoco().TypeId = value;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06003619 RID: 13849 RVA: 0x00089C50 File Offset: 0x00087E50
		// (set) Token: 0x0600361A RID: 13850 RVA: 0x00089C8A File Offset: 0x00087E8A
		public virtual bool? IsSupportDiscoverDevice
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSupportDiscoverDevice;
				}
				TreasureBoxComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSupportDiscoverDevice;
			}
			set
			{
				this.GetOrCreatePoco().IsSupportDiscoverDevice = value;
			}
		}

		// Token: 0x04002370 RID: 9072
		[Nullable(2)]
		protected new TreasureBoxComponent FbInstance;

		// Token: 0x04002371 RID: 9073
		[Nullable(2)]
		protected new TreasureBoxComponent_SetValue PocoInterface;
	}
}
