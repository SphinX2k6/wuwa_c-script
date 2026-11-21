using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB1 RID: 3505
	public class IFanInteractByHit : IFanInteractType
	{
		// Token: 0x06004FA7 RID: 20391 RVA: 0x000C633F File Offset: 0x000C453F
		public static IFanInteractByHit Create(IFanInteractByHit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractByHit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x000C635E File Offset: 0x000C455E
		public override EFanInteractType Type
		{
			get
			{
				return (EFanInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002D68 RID: 11624
		private IFanInteractByHit Instance;
	}
}
