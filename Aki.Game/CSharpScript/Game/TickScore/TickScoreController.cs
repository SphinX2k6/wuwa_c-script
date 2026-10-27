using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.TickScore
{
	// Token: 0x02004580 RID: 17792
	[NullableContext(1)]
	[Nullable(0)]
	public class TickScoreController : Singleton, ITickable
	{
		// Token: 0x0602DE83 RID: 188035 RVA: 0x00A8DD86 File Offset: 0x00A8BF86
		public void Init()
		{
			this.SwimTickScore = new ScoreUpdateManager(1f, 3);
		}

		// Token: 0x0602DE84 RID: 188036 RVA: 0x00A8DD99 File Offset: 0x00A8BF99
		public void Tick(float delta)
		{
			this.SwimTickScore.Update();
		}

		// Token: 0x17007594 RID: 30100
		// (get) Token: 0x0602DE85 RID: 188037 RVA: 0x00A8DDA6 File Offset: 0x00A8BFA6
		public static TickScoreController Instance
		{
			get
			{
				if (TickScoreController._instance == null)
				{
					TickScoreController._instance = new TickScoreController();
					TickScoreController._instance.OnInit();
				}
				return TickScoreController._instance;
			}
		}

		// Token: 0x0602DE86 RID: 188038 RVA: 0x00A8DDC9 File Offset: 0x00A8BFC9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DE87 RID: 188039 RVA: 0x00A8DDCB File Offset: 0x00A8BFCB
		public static void ResetStaticDefaultValue()
		{
			TickScoreController instance = TickScoreController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TickScoreController._instance = null;
		}

		// Token: 0x0602DE88 RID: 188040 RVA: 0x00A8DDE4 File Offset: 0x00A8BFE4
		static TickScoreController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TickScoreController.CreateStaticDefaultValue), new Action(TickScoreController.ResetStaticDefaultValue));
		}

		// Token: 0x0401883E RID: 100414
		private const int SWIM_MAX_COUNT = 3;

		// Token: 0x0401883F RID: 100415
		public ScoreUpdateManager SwimTickScore;

		// Token: 0x04018840 RID: 100416
		[Nullable(2)]
		private static TickScoreController _instance;
	}
}
