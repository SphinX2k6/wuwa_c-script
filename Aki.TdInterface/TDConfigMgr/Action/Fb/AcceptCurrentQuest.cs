using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002649 RID: 9801
	public class AcceptCurrentQuest : ActionParams
	{
		// Token: 0x0600DBD8 RID: 56280 RVA: 0x0020B7ED File Offset: 0x002099ED
		[NullableContext(1)]
		public static AcceptCurrentQuest Create(IAcceptCurrentQuest? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AcceptCurrentQuest
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007A2D RID: 31277
		private IAcceptCurrentQuest Instance;
	}
}
