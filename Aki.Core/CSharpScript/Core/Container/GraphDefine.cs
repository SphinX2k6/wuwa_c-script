using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000153 RID: 339
	public class GraphDefine : IStaticVariableResetter
	{
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00038092 File Offset: 0x00036292
		static GraphDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GraphDefine.CreateStaticDefaultValue), new Action(GraphDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000380B1 File Offset: 0x000362B1
		public static void CreateStaticDefaultValue()
		{
			GraphDefine.vector3Space = new Vector3Space();
			GraphDefine.vector2Space = new Vector2Space();
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000380C7 File Offset: 0x000362C7
		public static void ResetStaticDefaultValue()
		{
			GraphDefine.vector3Space = null;
			GraphDefine.vector2Space = null;
		}

		// Token: 0x040006F4 RID: 1780
		[Nullable(1)]
		public static IGraphSpace<Vector> vector3Space;

		// Token: 0x040006F5 RID: 1781
		[Nullable(1)]
		public static IGraphSpace<Vector2D> vector2Space;
	}
}
