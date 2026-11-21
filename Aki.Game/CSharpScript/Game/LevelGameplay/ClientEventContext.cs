using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B00 RID: 23296
	[NullableContext(2)]
	[Nullable(0)]
	public class ClientEventContext : GeneralContext
	{
		// Token: 0x06039490 RID: 234640 RVA: 0x0100A395 File Offset: 0x01008595
		public object GetEventHandleParams(int index)
		{
			object[] @params = this.Params;
			if (@params == null)
			{
				return null;
			}
			return @params.GetValueOrDefault(index);
		}

		// Token: 0x06039491 RID: 234641 RVA: 0x0100A3A9 File Offset: 0x010085A9
		public ClientEventContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.ClientEvent);
		}

		// Token: 0x06039492 RID: 234642 RVA: 0x0100A3BE File Offset: 0x010085BE
		public override void Reset()
		{
			this.EventName = null;
			this.Params = null;
		}

		// Token: 0x06039493 RID: 234643 RVA: 0x0100A3D4 File Offset: 0x010085D4
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

		// Token: 0x0401E2A2 RID: 123554
		public EEventName? EventName;

		// Token: 0x0401E2A3 RID: 123555
		public object[] Params;
	}
}
