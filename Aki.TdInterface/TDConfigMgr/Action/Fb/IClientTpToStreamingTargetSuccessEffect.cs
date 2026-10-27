using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026BF RID: 9919
	[NullableContext(2)]
	[Nullable(0)]
	public class IClientTpToStreamingTargetSuccessEffect
	{
		// Token: 0x0600DDDD RID: 56797 RVA: 0x0020EFE0 File Offset: 0x0020D1E0
		[NullableContext(1)]
		public static IClientTpToStreamingTargetSuccessEffect Create(IClientTpToStreamingTargetSuccessEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientTpToStreamingTargetSuccessEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x0600DDDE RID: 56798 RVA: 0x0020EFFF File Offset: 0x0020D1FF
		public virtual string SceneEffectDaPath
		{
			get
			{
				return this.Instance.SceneEffectDaPath;
			}
		}

		// Token: 0x04007B2B RID: 31531
		private IClientTpToStreamingTargetSuccessEffect Instance;
	}
}
