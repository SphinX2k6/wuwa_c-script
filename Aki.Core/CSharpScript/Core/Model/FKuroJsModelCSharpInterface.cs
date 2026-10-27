using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Model
{
	// Token: 0x02000130 RID: 304
	public class FKuroJsModelCSharpInterface
	{
		// Token: 0x06000AE3 RID: 2787
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern bool ContainsActivateAiSenseObjects(int AiPerceptionDataHandle, byte SenseTarget, void* AiSenseObjectData);

		// Token: 0x06000AE4 RID: 2788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void AddActivateAiSenseObjects(int AiPerceptionDataHandle, byte SenseTarget, void* AiSenseObjectData);

		// Token: 0x06000AE5 RID: 2789
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void RemoveActivateAiSenseObjects(int AiPerceptionDataHandle, byte SenseTarget, void* AiSenseObjectData);

		// Token: 0x06000AE6 RID: 2790
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetAiPerceptionDataMap(int AiPerceptionDataHandle, ref IntPtr OutEntitiesInSense, ref IntPtr OutEntitiesToAdd, ref IntPtr OutEntitiesRemoveTime, ref IntPtr OutEntitiesNotSense);

		// Token: 0x06000AE7 RID: 2791
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetEntitySenseType(int AiPerceptionDataHandle, int EntityId, ref byte OutSenseType);
	}
}
