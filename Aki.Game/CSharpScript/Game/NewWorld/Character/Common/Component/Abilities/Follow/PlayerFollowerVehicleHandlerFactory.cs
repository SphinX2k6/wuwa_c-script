using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007152 RID: 29010
	public class PlayerFollowerVehicleHandlerFactory : IPlayerFollowerHandlerFactory<IPlayerFollowerVehicleHandler>
	{
		// Token: 0x06046D36 RID: 290102 RVA: 0x011D97FC File Offset: 0x011D79FC
		[NullableContext(1)]
		public IPlayerFollowerVehicleHandler Create(int playerId)
		{
			return new PlayerFollowerVehicleHandler();
		}
	}
}
