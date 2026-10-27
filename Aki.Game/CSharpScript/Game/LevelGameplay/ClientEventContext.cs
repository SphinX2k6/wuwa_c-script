using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A4 RID: 27044
	[NullableContext(2)]
	[Nullable(0)]
	public class ClientEventContext : GeneralContext
	{
		// Token: 0x06043458 RID: 275544 RVA: 0x0106612D File Offset: 0x0106432D
		public object GetEventHandleParams(int index)
		{
			object[] @params = this.Params;
			if (@params == null)
			{
				return null;
			}
			return @params.GetValueOrDefault(index);
		}

		// Token: 0x06043459 RID: 275545 RVA: 0x01066141 File Offset: 0x01064341
		public ClientEventContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.ClientEvent);
		}

		// Token: 0x0604345A RID: 275546 RVA: 0x01066156 File Offset: 0x01064356
		public override void Reset()
		{
			this.EventName = null;
			this.Params = null;
		}

		// Token: 0x0604345B RID: 275547 RVA: 0x0106616C File Offset: 0x0106436C
		[NullableContext(1)]
		public static ClientEventContext Create(EEventName eventName, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] @params)
		{
			ClientEventContext clientEventContext = GeneralContext.GetObj(EGeneralContextType.ClientEvent, null, () => new ClientEventContext()) as ClientEventContext;
			clientEventContext.EventName = new EEventName?(eventName);
			clientEventContext.Params = @params;
			return clientEventContext;
		}

		// Token: 0x040230B8 RID: 143544
		public EEventName? EventName;

		// Token: 0x040230B9 RID: 143545
		public object[] Params;
	}
}
