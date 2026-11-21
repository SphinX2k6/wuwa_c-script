using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B2A RID: 15146
	[NullableContext(2)]
	[Nullable(0)]
	public class SlidingBlocksGameAudioData
	{
		// Token: 0x06026EF6 RID: 159478 RVA: 0x00AE5868 File Offset: 0x00AE3A68
		public void Init()
		{
			Bp_Tetris_C setting = SlidingBlocksGlobal.Setting;
			this.GameSpeedUpAudio = AudioSystem.Instance.parseAudioEventPath(setting.AudioGameSpeedUp);
			this.TetrominoStartFallAudio = AudioSystem.Instance.parseAudioEventPath(setting.AudioTetrominoStartFall);
			this.SuccessAudio = AudioSystem.Instance.parseAudioEventPath(setting.AudioGameSuccess);
			this.FailAudio = AudioSystem.Instance.parseAudioEventPath(setting.AudioGameFail);
			this.RestartAudio = AudioSystem.Instance.parseAudioEventPath(setting.AudioGameRestart);
			this.RotateAudio = AudioSystem.Instance.parseAudioEventPath(setting.AudioTetrominoRotate);
			this.AimingMoveAudio = AudioSystem.Instance.parseAudioEventPath(setting.AudioAimingMove);
		}

		// Token: 0x06026EF7 RID: 159479 RVA: 0x00AE5915 File Offset: 0x00AE3B15
		public void Reset()
		{
			this.GameSpeedUpAudio = null;
			this.TetrominoStartFallAudio = null;
			this.SuccessAudio = null;
			this.FailAudio = null;
			this.RestartAudio = null;
			this.RotateAudio = null;
			this.AimingMoveAudio = null;
		}

		// Token: 0x0401543C RID: 87100
		public string GameSpeedUpAudio;

		// Token: 0x0401543D RID: 87101
		public string TetrominoStartFallAudio;

		// Token: 0x0401543E RID: 87102
		public string SuccessAudio;

		// Token: 0x0401543F RID: 87103
		public string FailAudio;

		// Token: 0x04015440 RID: 87104
		public string RestartAudio;

		// Token: 0x04015441 RID: 87105
		public string RotateAudio;

		// Token: 0x04015442 RID: 87106
		public string AimingMoveAudio;
	}
}
