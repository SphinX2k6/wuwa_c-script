using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034F5 RID: 13557
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectGlobal : Singleton
	{
		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x060227F1 RID: 141297 RVA: 0x009CAB01 File Offset: 0x009C8D01
		public static EffectGlobal Instance
		{
			get
			{
				if (EffectGlobal._instance == null)
				{
					EffectGlobal._instance = new EffectGlobal();
					EffectGlobal._instance.OnInit();
				}
				return EffectGlobal._instance;
			}
		}

		// Token: 0x060227F2 RID: 141298 RVA: 0x009CAB24 File Offset: 0x009C8D24
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060227F3 RID: 141299 RVA: 0x009CAB26 File Offset: 0x009C8D26
		public static void ResetStaticDefaultValue()
		{
			EffectGlobal instance = EffectGlobal._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EffectGlobal._instance = null;
		}

		// Token: 0x060227F4 RID: 141300 RVA: 0x009CAB3F File Offset: 0x009C8D3F
		static EffectGlobal()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectGlobal.CreateStaticDefaultValue), new Action(EffectGlobal.ResetStaticDefaultValue));
		}

		// Token: 0x04013115 RID: 78101
		public bool EnableSpawnLog = true;

		// Token: 0x04013116 RID: 78102
		public bool GlobalGamePaused;

		// Token: 0x04013117 RID: 78103
		public Vector LastCameraLocation = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04013118 RID: 78104
		public Vector CameraLocation = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04013119 RID: 78105
		public bool HasPlayer0;

		// Token: 0x0401311A RID: 78106
		public double GameTimeInSeconds;

		// Token: 0x0401311B RID: 78107
		public double GlobalTimeDilation = 1.0;

		// Token: 0x0401311C RID: 78108
		public bool AllowEffectOutPool = true;

		// Token: 0x0401311D RID: 78109
		public bool AllowEffectInPool = true;

		// Token: 0x0401311E RID: 78110
		public bool SceneObjectWaterEffectShowDebugTrace;

		// Token: 0x0401311F RID: 78111
		public bool SceneObjectAirWallEffectShowDebugTrace;

		// Token: 0x04013120 RID: 78112
		public bool CgMode;

		// Token: 0x04013121 RID: 78113
		[Nullable(2)]
		private static EffectGlobal _instance;
	}
}
