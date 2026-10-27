using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002530 RID: 9520
	public class IActorFxEmoteStopAll : IActorFxEmoteStopSubType
	{
		// Token: 0x0600D437 RID: 54327 RVA: 0x001F6BE1 File Offset: 0x001F4DE1
		[NullableContext(1)]
		public static IActorFxEmoteStopAll Create(IActorFxEmoteStopAll? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStopAll
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x0600D438 RID: 54328 RVA: 0x001F6C00 File Offset: 0x001F4E00
		public override EActorFxEmoteStopSubType Type
		{
			get
			{
				return (EActorFxEmoteStopSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007442 RID: 29762
		private IActorFxEmoteStopAll Instance;
	}
}
