using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Model
{
	// Token: 0x02000131 RID: 305
	public class FKuroJsModelCSharpInterface
	{
		// Token: 0x06000B3A RID: 2874
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern bool ContainsActivateAiSenseObjects(int AiPerceptionDataHandle, byte SenseTarget, void* AiSenseObjectData);

		// Token: 0x06000B3B RID: 2875
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void AddActivateAiSenseObjects(int AiPerceptionDataHandle, byte SenseTarget, void* AiSenseObjectData);

		// Token: 0x06000B3C RID: 2876
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void RemoveActivateAiSenseObjects(int AiPerceptionDataHandle, byte SenseTarget, void* AiSenseObjectData);

		// Token: 0x06000B3D RID: 2877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetAiPerceptionDataMap(int AiPerceptionDataHandle, ref IntPtr OutEntitiesInSense, ref IntPtr OutEntitiesToAdd, ref IntPtr OutEntitiesRemoveTime, ref IntPtr OutEntitiesNotSense);

		// Token: 0x06000B3E RID: 2878
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetEntitySenseType(int AiPerceptionDataHandle, int EntityId, ref byte OutSenseType);
	}
}
