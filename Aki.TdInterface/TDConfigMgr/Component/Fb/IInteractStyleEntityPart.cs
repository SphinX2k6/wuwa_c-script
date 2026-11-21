using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4B RID: 2891
	public class IInteractStyleEntityPart : IInteractStyleBase
	{
		// Token: 0x06004204 RID: 16900 RVA: 0x000A7D79 File Offset: 0x000A5F79
		public static IInteractStyleEntityPart Create(IInteractStyleEntityPart? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractStyleEntityPart
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x000A7D98 File Offset: 0x000A5F98
		public override EInteractStyleType Type
		{
			get
			{
				return (EInteractStyleType)this.Instance.Type;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06004206 RID: 16902 RVA: 0x000A7DA5 File Offset: 0x000A5FA5
		public virtual IInteractEntityPartBindBase Bind
		{
			get
			{
				if (this._BindInited)
				{
					return this._BindCache;
				}
				this._BindInited = true;
				this._BindCache = ComponentReadHelper.ReadIInteractStyleEntityPart_Bind(this.Instance);
				return this._BindCache;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x000A7DD4 File Offset: 0x000A5FD4
		public virtual float ShowAngle
		{
			get
			{
				return this.Instance.ShowAngle;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06004208 RID: 16904 RVA: 0x000A7DE1 File Offset: 0x000A5FE1
		public virtual float TriggerAngle
		{
			get
			{
				return this.Instance.TriggerAngle;
			}
		}

		// Token: 0x0400248A RID: 9354
		private IInteractStyleEntityPart Instance;

		// Token: 0x0400248B RID: 9355
		private IInteractEntityPartBindBase _BindCache;

		// Token: 0x0400248C RID: 9356
		private bool _BindInited;
	}
}
