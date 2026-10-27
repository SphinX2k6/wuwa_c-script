using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000855 RID: 2133
	[NullableContext(1)]
	[Nullable(0)]
	public class PickInteractComponent : IComponentBase
	{
		// Token: 0x06002F13 RID: 12051 RVA: 0x00079994 File Offset: 0x00077B94
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

		// Token: 0x06002F14 RID: 12052 RVA: 0x000799CC File Offset: 0x00077BCC
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

		// Token: 0x06002F15 RID: 12053 RVA: 0x000799DF File Offset: 0x00077BDF
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

		// Token: 0x06002F16 RID: 12054 RVA: 0x000799F2 File Offset: 0x00077BF2
		public new PickInteractComponent_SetValue ToSetValue()
		{
			return new PickInteractComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				PickInteractType = this.PickInteractType
			};
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x00079A20 File Offset: 0x00077C20
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x00079A5A File Offset: 0x00077C5A
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

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x00079A68 File Offset: 0x00077C68
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x00079A92 File Offset: 0x00077C92
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

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x00079AA0 File Offset: 0x00077CA0
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00079B01 File Offset: 0x00077D01
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

		// Token: 0x04001F17 RID: 7959
		[Nullable(2)]
		protected new PickInteractComponent FbInstance;

		// Token: 0x04001F18 RID: 7960
		[Nullable(2)]
		protected new PickInteractComponent_SetValue PocoInterface;

		// Token: 0x04001F19 RID: 7961
		private IChessmanPickInteraction _PickInteractTypeCache;

		// Token: 0x04001F1A RID: 7962
		private bool _PickInteractTypeInited;
	}
}
