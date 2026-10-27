using System;

namespace CSharpScript.Game.Module.Area.AreaFunction.Handlers
{
	// Token: 0x02005EAC RID: 24236
	public static class HandlerRegistration
	{
		// Token: 0x0603DAA4 RID: 252580 RVA: 0x00EE466A File Offset: 0x00EE286A
		public static void RegisterAllAreaFunctionHandlers()
		{
			AreaFunctionRegistry.RegisterFunctionHandler(new AirCurrentHandler());
		}
	}
}
