using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000157 RID: 343
	[NullableContext(1)]
	[Nullable(0)]
	public class GraphDefine : IStaticVariableResetter
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x00038C9C File Offset: 0x00036E9C
		static GraphDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GraphDefine.CreateStaticDefaultValue), new Action(GraphDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00038CBB File Offset: 0x00036EBB
		public static void CreateStaticDefaultValue()
		{
			GraphDefine.vector3Space = new Vector3Space();
			GraphDefine.vector2Space = new Vector2Space();
			GraphDefine.vector3SpaceDouble = new Vector3SpaceDouble();
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00038CDB File Offset: 0x00036EDB
		public static void ResetStaticDefaultValue()
		{
			GraphDefine.vector3Space = null;
			GraphDefine.vector2Space = null;
			GraphDefine.vector3SpaceDouble = null;
		}

		// Token: 0x04000702 RID: 1794
		public static IGraphSpace<Vector> vector3Space;

		// Token: 0x04000703 RID: 1795
		public static IGraphSpace<Vector2D> vector2Space;

		// Token: 0x04000704 RID: 1796
		public static IGraphSpace<FVectorDouble> vector3SpaceDouble;
	}
}
