using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADC RID: 10972
	public class ISceneActorMusicLightsEvent : ISceneActorEvent
	{
		// Token: 0x0600F091 RID: 61585 RVA: 0x0022ED3E File Offset: 0x0022CF3E
		[NullableContext(1)]
		public static ISceneActorMusicLightsEvent Create(ISceneActorMusicLightsEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorMusicLightsEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x0600F092 RID: 61586 RVA: 0x0022ED5D File Offset: 0x0022CF5D
		public override ESceneActorEventType Type
		{
			get
			{
				return (ESceneActorEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008456 RID: 33878
		private ISceneActorMusicLightsEvent Instance;
	}
}
