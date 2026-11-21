using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F40 RID: 3904
	public class IGraph3dEffectBase
	{
		// Token: 0x060057A8 RID: 22440 RVA: 0x000D6A9A File Offset: 0x000D4C9A
		public static IGraph3dEffectBase Create(IGraph3dEffectBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEffectBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x060057A9 RID: 22441 RVA: 0x000D6AB9 File Offset: 0x000D4CB9
		public virtual EGraph3dEffectType Type
		{
			get
			{
				return (EGraph3dEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04003257 RID: 12887
		private IGraph3dEffectBase Instance;
	}
}
