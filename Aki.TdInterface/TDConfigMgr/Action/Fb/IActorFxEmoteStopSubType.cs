using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200252F RID: 9519
	public class IActorFxEmoteStopSubType
	{
		// Token: 0x0600D434 RID: 54324 RVA: 0x001F6BAD File Offset: 0x001F4DAD
		[NullableContext(1)]
		public static IActorFxEmoteStopSubType Create(IActorFxEmoteStopSubType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStopSubType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x0600D435 RID: 54325 RVA: 0x001F6BCC File Offset: 0x001F4DCC
		public virtual EActorFxEmoteStopSubType Type
		{
			get
			{
				return (EActorFxEmoteStopSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007441 RID: 29761
		private IActorFxEmoteStopSubType Instance;
	}
}
