using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200457A RID: 17786
	internal static class <MapRogueDefine>FFB60DD1BDB7EE79E3D5ADDF3E8B32FDDC5EC45690124173B57D5FF5169319C7A__EMapRogueSpineAnimExtension
	{
		// Token: 0x0602CD05 RID: 183557 RVA: 0x00C8B930 File Offset: 0x00C89B30
		[NullableContext(1)]
		public static string ToAnimString(this EMapRogueSpineAnim anim)
		{
			switch (anim)
			{
			case EMapRogueSpineAnim.Idle:
				return "Idle";
			case EMapRogueSpineAnim.Move:
				return "Run";
			case EMapRogueSpineAnim.Cheer:
				return "Cheer";
			case EMapRogueSpineAnim.Fight:
				return "Fight";
			default:
				return "Idle";
			}
		}
	}
}
