using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E04 RID: 3588
	public class IEffectAreaMode
	{
		// Token: 0x06005152 RID: 20818 RVA: 0x000C96E2 File Offset: 0x000C78E2
		public static IEffectAreaMode Create(IEffectAreaMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectAreaMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x000C9701 File Offset: 0x000C7901
		public virtual EEffectAreaType Type
		{
			get
			{
				return (EEffectAreaType)this.Instance.Type;
			}
		}

		// Token: 0x04002E61 RID: 11873
		private IEffectAreaMode Instance;
	}
}
