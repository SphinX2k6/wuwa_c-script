using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006380 RID: 25472
	public class PlayerFollowerVehicleHandlerFactory : IPlayerFollowerHandlerFactory<IPlayerFollowerVehicleHandler>
	{
		// Token: 0x0603DB90 RID: 252816 RVA: 0x011E29B0 File Offset: 0x011E0BB0
		[NullableContext(1)]
		public IPlayerFollowerVehicleHandler Create(int playerId)
		{
			return new PlayerFollowerVehicleHandler();
		}
	}
}
