using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001B8 RID: 440
	public class IActivateSpecifiedPieceConfig
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x000237F4 File Offset: 0x000219F4
		private IActivateSpecifiedPieceConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActivateSpecifiedPieceConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActivateSpecifiedPieceConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActivateSpecifiedPieceConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0002382C File Offset: 0x00021A2C
		public static IActivateSpecifiedPieceConfig Create([Nullable(2)] IActivateSpecifiedPieceConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActivateSpecifiedPieceConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002383F File Offset: 0x00021A3F
		public static IActivateSpecifiedPieceConfig CreateFromSetValue([Nullable(2)] IActivateSpecifiedPieceConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActivateSpecifiedPieceConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00023852 File Offset: 0x00021A52
		public IActivateSpecifiedPieceConfig_SetValue ToSetValue()
		{
			return new IActivateSpecifiedPieceConfig_SetValue
			{
				Jigsaw = this.Jigsaw,
				SelfState = this.SelfState
			};
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00023874 File Offset: 0x00021A74
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x000238D5 File Offset: 0x00021AD5
		public virtual IJigsawConfig Jigsaw
		{
			get
			{
				if (this._JigsawInited)
				{
					return this._JigsawCache;
				}
				this._JigsawInited = true;
				if (this.FbInstance != null)
				{
					this._JigsawCache = IJigsawConfig.Create(this.FbInstance.Jigsaw);
				}
				else
				{
					IActivateSpecifiedPieceConfig_SetValue pocoInterface = this.PocoInterface;
					this._JigsawCache = ((pocoInterface != null) ? pocoInterface.Jigsaw : null);
				}
				return this._JigsawCache;
			}
			set
			{
				this.GetOrCreatePoco().Jigsaw = value;
				this._JigsawInited = false;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x000238EA File Offset: 0x00021AEA
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00023915 File Offset: 0x00021B15
		public virtual string SelfState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SelfState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SelfState;
			}
			set
			{
				this.GetOrCreatePoco().SelfState = value;
			}
		}

		// Token: 0x0400085F RID: 2143
		[Nullable(2)]
		protected IActivateSpecifiedPieceConfig FbInstance;

		// Token: 0x04000860 RID: 2144
		[Nullable(2)]
		protected IActivateSpecifiedPieceConfig_SetValue PocoInterface;

		// Token: 0x04000861 RID: 2145
		private IJigsawConfig _JigsawCache;

		// Token: 0x04000862 RID: 2146
		private bool _JigsawInited;
	}
}
