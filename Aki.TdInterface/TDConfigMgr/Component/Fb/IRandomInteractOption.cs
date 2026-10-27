using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A74 RID: 2676
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomInteractOption
	{
		// Token: 0x06003DA8 RID: 15784 RVA: 0x0009E277 File Offset: 0x0009C477
		public static IRandomInteractOption Create(IRandomInteractOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomInteractOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06003DA9 RID: 15785 RVA: 0x0009E296 File Offset: 0x0009C496
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06003DAA RID: 15786 RVA: 0x0009E2A3 File Offset: 0x0009C4A3
		public virtual IInteractOption Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IInteractOption.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x04002255 RID: 8789
		private IRandomInteractOption Instance;

		// Token: 0x04002256 RID: 8790
		[Nullable(2)]
		private IInteractOption _OptionCache;

		// Token: 0x04002257 RID: 8791
		private bool _OptionInited;
	}
}
