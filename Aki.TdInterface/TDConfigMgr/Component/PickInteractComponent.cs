using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F8 RID: 2296
	public class PickInteractComponent : IComponentBase
	{
		// Token: 0x0600324F RID: 12879 RVA: 0x00080E7C File Offset: 0x0007F07C
		private PickInteractComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PickInteractComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PickInteractComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PickInteractComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x00080EB4 File Offset: 0x0007F0B4
		public static PickInteractComponent Create([Nullable(2)] PickInteractComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PickInteractComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x00080EC7 File Offset: 0x0007F0C7
		public static PickInteractComponent CreateFromSetValue([Nullable(2)] PickInteractComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PickInteractComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x00080EDA File Offset: 0x0007F0DA
		public new PickInteractComponent_SetValue ToSetValue()
		{
			return new PickInteractComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				PickInteractType = this.PickInteractType
			};
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x00080F08 File Offset: 0x0007F108
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x00080F42 File Offset: 0x0007F142
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				PickInteractComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x00080F50 File Offset: 0x0007F150
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x00080F7A File Offset: 0x0007F17A
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

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x00080F88 File Offset: 0x0007F188
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x00080FE9 File Offset: 0x0007F1E9
		public virtual IChessmanPickInteraction PickInteractType
		{
			get
			{
				if (this._PickInteractTypeInited)
				{
					return this._PickInteractTypeCache;
				}
				this._PickInteractTypeInited = true;
				if (this.FbInstance != null)
				{
					this._PickInteractTypeCache = IChessmanPickInteraction.Create(this.FbInstance.PickInteractType);
				}
				else
				{
					PickInteractComponent_SetValue pocoInterface = this.PocoInterface;
					this._PickInteractTypeCache = ((pocoInterface != null) ? pocoInterface.PickInteractType : null);
				}
				return this._PickInteractTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().PickInteractType = value;
				this._PickInteractTypeInited = false;
			}
		}

		// Token: 0x04002129 RID: 8489
		[Nullable(2)]
		protected new PickInteractComponent FbInstance;

		// Token: 0x0400212A RID: 8490
		[Nullable(2)]
		protected new PickInteractComponent_SetValue PocoInterface;

		// Token: 0x0400212B RID: 8491
		private IChessmanPickInteraction _PickInteractTypeCache;

		// Token: 0x0400212C RID: 8492
		private bool _PickInteractTypeInited;
	}
}
