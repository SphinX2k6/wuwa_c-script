using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A1 RID: 417
	[NullableContext(1)]
	[Nullable(0)]
	public class IActivateSpecifiedPieceConfig
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x00022B94 File Offset: 0x00020D94
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

		// Token: 0x06000659 RID: 1625 RVA: 0x00022BCC File Offset: 0x00020DCC
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

		// Token: 0x0600065A RID: 1626 RVA: 0x00022BDF File Offset: 0x00020DDF
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

		// Token: 0x0600065B RID: 1627 RVA: 0x00022BF2 File Offset: 0x00020DF2
		public IActivateSpecifiedPieceConfig_SetValue ToSetValue()
		{
			return new IActivateSpecifiedPieceConfig_SetValue
			{
				Jigsaw = this.Jigsaw,
				SelfState = this.SelfState
			};
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00022C14 File Offset: 0x00020E14
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00022C75 File Offset: 0x00020E75
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

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00022C8A File Offset: 0x00020E8A
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00022CB5 File Offset: 0x00020EB5
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

		// Token: 0x04000806 RID: 2054
		[Nullable(2)]
		protected IActivateSpecifiedPieceConfig FbInstance;

		// Token: 0x04000807 RID: 2055
		[Nullable(2)]
		protected IActivateSpecifiedPieceConfig_SetValue PocoInterface;

		// Token: 0x04000808 RID: 2056
		private IJigsawConfig _JigsawCache;

		// Token: 0x04000809 RID: 2057
		private bool _JigsawInited;
	}
}
