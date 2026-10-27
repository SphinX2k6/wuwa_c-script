using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B80 RID: 19328
	[NullableContext(2)]
	[Nullable(0)]
	public class SlidingBlocksGameAudioData
	{
		// Token: 0x06032165 RID: 205157 RVA: 0x00BA16D8 File Offset: 0x00B9F8D8
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

		// Token: 0x06032166 RID: 205158 RVA: 0x00BA1785 File Offset: 0x00B9F985
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

		// Token: 0x0401AAE8 RID: 109288
		public string GameSpeedUpAudio;

		// Token: 0x0401AAE9 RID: 109289
		public string TetrominoStartFallAudio;

		// Token: 0x0401AAEA RID: 109290
		public string SuccessAudio;

		// Token: 0x0401AAEB RID: 109291
		public string FailAudio;

		// Token: 0x0401AAEC RID: 109292
		public string RestartAudio;

		// Token: 0x0401AAED RID: 109293
		public string RotateAudio;

		// Token: 0x0401AAEE RID: 109294
		public string AimingMoveAudio;
	}
}
