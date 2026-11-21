using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.TickScore
{
	// Token: 0x020034A8 RID: 13480
	[NullableContext(1)]
	[Nullable(0)]
	public class TickScoreController : Singleton, ITickable
	{
		// Token: 0x06022565 RID: 140645 RVA: 0x009B949E File Offset: 0x009B769E
		public void Init()
		{
			this.SwimTickScore = new ScoreUpdateManager(1f, 3);
		}

		// Token: 0x06022566 RID: 140646 RVA: 0x009B94B1 File Offset: 0x009B76B1
		public void Tick(float delta)
		{
			this.SwimTickScore.Update();
		}

		// Token: 0x1700484B RID: 18507
		// (get) Token: 0x06022567 RID: 140647 RVA: 0x009B94BE File Offset: 0x009B76BE
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

		// Token: 0x06022568 RID: 140648 RVA: 0x009B94E1 File Offset: 0x009B76E1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022569 RID: 140649 RVA: 0x009B94E3 File Offset: 0x009B76E3
		public static void ResetStaticDefaultValue()
		{
			TickScoreController instance = TickScoreController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TickScoreController._instance = null;
		}

		// Token: 0x0602256A RID: 140650 RVA: 0x009B94FC File Offset: 0x009B76FC
		static TickScoreController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TickScoreController.CreateStaticDefaultValue), new Action(TickScoreController.ResetStaticDefaultValue));
		}

		// Token: 0x04012E78 RID: 77432
		private const int SWIM_MAX_COUNT = 3;

		// Token: 0x04012E79 RID: 77433
		public ScoreUpdateManager SwimTickScore;

		// Token: 0x04012E7A RID: 77434
		[Nullable(2)]
		private static TickScoreController _instance;
	}
}
