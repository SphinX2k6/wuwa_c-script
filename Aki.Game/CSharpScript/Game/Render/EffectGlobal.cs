using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045CD RID: 17869
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectGlobal : Singleton
	{
		// Token: 0x170075A1 RID: 30113
		// (get) Token: 0x0602E106 RID: 188678 RVA: 0x00A9E839 File Offset: 0x00A9CA39
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

		// Token: 0x0602E107 RID: 188679 RVA: 0x00A9E85C File Offset: 0x00A9CA5C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E108 RID: 188680 RVA: 0x00A9E85E File Offset: 0x00A9CA5E
		public static void ResetStaticDefaultValue()
		{
			EffectGlobal instance = EffectGlobal._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EffectGlobal._instance = null;
		}

		// Token: 0x0602E109 RID: 188681 RVA: 0x00A9E877 File Offset: 0x00A9CA77
		static EffectGlobal()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectGlobal.CreateStaticDefaultValue), new Action(EffectGlobal.ResetStaticDefaultValue));
		}

		// Token: 0x04018ADA RID: 101082
		public bool EnableSpawnLog = true;

		// Token: 0x04018ADB RID: 101083
		public bool GlobalGamePaused;

		// Token: 0x04018ADC RID: 101084
		public Vector LastCameraLocation = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04018ADD RID: 101085
		public Vector CameraLocation = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04018ADE RID: 101086
		public bool HasPlayer0;

		// Token: 0x04018ADF RID: 101087
		public double GameTimeInSeconds;

		// Token: 0x04018AE0 RID: 101088
		public double GlobalTimeDilation = 1.0;

		// Token: 0x04018AE1 RID: 101089
		public bool AllowEffectOutPool = true;

		// Token: 0x04018AE2 RID: 101090
		public bool AllowEffectInPool = true;

		// Token: 0x04018AE3 RID: 101091
		public bool SceneObjectWaterEffectShowDebugTrace;

		// Token: 0x04018AE4 RID: 101092
		public bool SceneObjectAirWallEffectShowDebugTrace;

		// Token: 0x04018AE5 RID: 101093
		public bool CgMode;

		// Token: 0x04018AE6 RID: 101094
		[Nullable(2)]
		private static EffectGlobal _instance;
	}
}
