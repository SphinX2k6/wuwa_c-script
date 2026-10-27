using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066BE RID: 26302
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DropCatchModel : ModelBase
	{
		// Token: 0x06041C9A RID: 269466 RVA: 0x00FF4818 File Offset: 0x00FF2A18
		public void AddGameplayScoreRecord(int gameplayId, float score)
		{
			if (this.GameplayScoreRecord.ContainsKey(gameplayId))
			{
				this.GameplayScoreRecord[gameplayId] = score;
				return;
			}
			this.GameplayScoreRecord.Add(gameplayId, score);
		}

		// Token: 0x06041C9B RID: 269467 RVA: 0x00FF4844 File Offset: 0x00FF2A44
		public float GetGameplayScoreRecord(int gameplayId)
		{
			float result;
			if (this.GameplayScoreRecord.TryGetValue(gameplayId, out result))
			{
				return result;
			}
			return 0f;
		}

		// Token: 0x06041C9C RID: 269468 RVA: 0x00FF4868 File Offset: 0x00FF2A68
		protected override bool OnClear()
		{
			this.GameplayScoreRecord.Clear();
			return true;
		}

		// Token: 0x17009643 RID: 38467
		// (get) Token: 0x06041C9D RID: 269469 RVA: 0x00FF4876 File Offset: 0x00FF2A76
		public static DropCatchModel Instance
		{
			get
			{
				return DropCatchModel._Instance;
			}
		}

		// Token: 0x06041C9E RID: 269470 RVA: 0x00FF487D File Offset: 0x00FF2A7D
		public static DropCatchModel GetOrCreateInstance()
		{
			if (DropCatchModel._Instance == null)
			{
				DropCatchModel.CreateInstance();
			}
			return DropCatchModel._Instance;
		}

		// Token: 0x06041C9F RID: 269471 RVA: 0x00FF4891 File Offset: 0x00FF2A91
		public static bool CreateInstance()
		{
			if (DropCatchModel._Instance != null)
			{
				return true;
			}
			DropCatchModel._Instance = new DropCatchModel();
			return true;
		}

		// Token: 0x06041CA0 RID: 269472 RVA: 0x00FF48A7 File Offset: 0x00FF2AA7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041CA1 RID: 269473 RVA: 0x00FF48A9 File Offset: 0x00FF2AA9
		public static void ResetStaticDefaultValue()
		{
			DropCatchModel._Instance = null;
		}

		// Token: 0x06041CA2 RID: 269474 RVA: 0x00FF48B1 File Offset: 0x00FF2AB1
		static DropCatchModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchModel.CreateStaticDefaultValue), new Action(DropCatchModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402244D RID: 140365
		private readonly Dictionary<int, float> GameplayScoreRecord = new Dictionary<int, float>();

		// Token: 0x0402244E RID: 140366
		[Nullable(2)]
		private static DropCatchModel _Instance;
	}
}
