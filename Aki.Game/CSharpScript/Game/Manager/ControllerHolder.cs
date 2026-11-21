using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using CSharpScript.Game.LevelGamePlay.WriteLetter;
using CSharpScript.Game.Module.LevelPlay;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02005A9E RID: 23198
	[NullableContext(1)]
	[Nullable(0)]
	public static class ControllerHolder
	{
		// Token: 0x17006CD6 RID: 27862
		// (get) Token: 0x060392A6 RID: 234150 RVA: 0x010025B7 File Offset: 0x010007B7
		public static WriteLetterController WriteLetterController
		{
			get
			{
				return WriteLetterController.Instance;
			}
		}

		// Token: 0x17006CD7 RID: 27863
		// (get) Token: 0x060392A7 RID: 234151 RVA: 0x010025BE File Offset: 0x010007BE
		public static CapabilityController CapabilityController
		{
			get
			{
				return CapabilityController.Instance;
			}
		}

		// Token: 0x17006CD8 RID: 27864
		// (get) Token: 0x060392A8 RID: 234152 RVA: 0x010025C5 File Offset: 0x010007C5
		public static SceneUiController SceneUiController
		{
			get
			{
				return SceneUiController.Instance;
			}
		}

		// Token: 0x17006CD9 RID: 27865
		// (get) Token: 0x060392A9 RID: 234153 RVA: 0x010025CC File Offset: 0x010007CC
		public static LoopTeleportVolumeController LoopTeleportVolumeController
		{
			get
			{
				return LoopTeleportVolumeController.Instance;
			}
		}

		// Token: 0x17006CDA RID: 27866
		// (get) Token: 0x060392AA RID: 234154 RVA: 0x010025D3 File Offset: 0x010007D3
		public static InputDistributeController InputDistributeController
		{
			get
			{
				return InputDistributeController.Instance;
			}
		}
	}
}
