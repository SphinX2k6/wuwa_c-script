using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.DemoInteract
{
	// Token: 0x02006C35 RID: 27701
	public class LevelEventRunDemoActorCustomEvent : LevelEventBase
	{
		// Token: 0x060444BE RID: 279742 RVA: 0x010D3754 File Offset: 0x010D1954
		public LevelEventRunDemoActorCustomEvent(int id) : base(id)
		{
		}

		// Token: 0x060444BF RID: 279743 RVA: 0x010D3760 File Offset: 0x010D1960
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (!Info.Instance.IsPlayInEditor)
			{
				return;
			}
			string[] array = (inParams as RunActorCustomEvent).ActorRef.PathName.Split('.', StringSplitOptions.None);
			array[1] + "." + array[2];
		}
	}
}
