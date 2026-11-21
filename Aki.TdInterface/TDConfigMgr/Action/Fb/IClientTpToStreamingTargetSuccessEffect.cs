using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002983 RID: 10627
	public class IClientTpToStreamingTargetSuccessEffect
	{
		// Token: 0x0600EBB9 RID: 60345 RVA: 0x0022B820 File Offset: 0x00229A20
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

		// Token: 0x17004561 RID: 17761
		// (get) Token: 0x0600EBBA RID: 60346 RVA: 0x0022B83F File Offset: 0x00229A3F
		[Nullable(2)]
		public virtual string SceneEffectDaPath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SceneEffectDaPath;
			}
		}

		// Token: 0x040081CB RID: 33227
		private IClientTpToStreamingTargetSuccessEffect Instance;
	}
}
