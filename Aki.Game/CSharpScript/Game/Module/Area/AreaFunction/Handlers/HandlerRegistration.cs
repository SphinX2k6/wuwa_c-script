using System;

namespace CSharpScript.Game.Module.Area.AreaFunction.Handlers
{
	// Token: 0x02004E91 RID: 20113
	public static class HandlerRegistration
	{
		// Token: 0x06032A34 RID: 207412 RVA: 0x00E35BB6 File Offset: 0x00E33DB6
		public static void RegisterAllAreaFunctionHandlers()
		{
			AreaFunctionRegistry.RegisterFunctionHandler(new AirCurrentHandler());
		}
	}
}
