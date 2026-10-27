using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using CSharpScript.Game.LevelGamePlay.WriteLetter;
using CSharpScript.Game.Module.LevelPlay;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02006943 RID: 26947
	[NullableContext(1)]
	[Nullable(0)]
	public static class ControllerHolder
	{
		// Token: 0x170097F6 RID: 38902
		// (get) Token: 0x0604326F RID: 275055 RVA: 0x0105E3F8 File Offset: 0x0105C5F8
		public static WriteLetterController WriteLetterController
		{
			get
			{
				return WriteLetterController.Instance;
			}
		}

		// Token: 0x170097F7 RID: 38903
		// (get) Token: 0x06043270 RID: 275056 RVA: 0x0105E3FF File Offset: 0x0105C5FF
		public static CapabilityController CapabilityController
		{
			get
			{
				return CapabilityController.Instance;
			}
		}

		// Token: 0x170097F8 RID: 38904
		// (get) Token: 0x06043271 RID: 275057 RVA: 0x0105E406 File Offset: 0x0105C606
		public static SceneUiController SceneUiController
		{
			get
			{
				return SceneUiController.Instance;
			}
		}

		// Token: 0x170097F9 RID: 38905
		// (get) Token: 0x06043272 RID: 275058 RVA: 0x0105E40D File Offset: 0x0105C60D
		public static LoopTeleportVolumeController LoopTeleportVolumeController
		{
			get
			{
				return LoopTeleportVolumeController.Instance;
			}
		}

		// Token: 0x170097FA RID: 38906
		// (get) Token: 0x06043273 RID: 275059 RVA: 0x0105E414 File Offset: 0x0105C614
		public static InputDistributeController InputDistributeController
		{
			get
			{
				return InputDistributeController.Instance;
			}
		}
	}
}
