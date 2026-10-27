using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A81 RID: 2689
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractStyleEntityPart : IInteractStyleBase
	{
		// Token: 0x06003DDB RID: 15835 RVA: 0x0009E7C1 File Offset: 0x0009C9C1
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

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x0009E7E0 File Offset: 0x0009C9E0
		public override EInteractStyleType Type
		{
			get
			{
				return (EInteractStyleType)this.Instance.Type;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06003DDD RID: 15837 RVA: 0x0009E7ED File Offset: 0x0009C9ED
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

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x0009E81C File Offset: 0x0009CA1C
		public virtual float ShowAngle
		{
			get
			{
				return this.Instance.ShowAngle;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06003DDF RID: 15839 RVA: 0x0009E829 File Offset: 0x0009CA29
		public virtual float TriggerAngle
		{
			get
			{
				return this.Instance.TriggerAngle;
			}
		}

		// Token: 0x0400226E RID: 8814
		private IInteractStyleEntityPart Instance;

		// Token: 0x0400226F RID: 8815
		private IInteractEntityPartBindBase _BindCache;

		// Token: 0x04002270 RID: 8816
		private bool _BindInited;
	}
}
