using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200560E RID: 22030
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DropCatchModel : ModelBase
	{
		// Token: 0x060367E6 RID: 223206 RVA: 0x00F35C1C File Offset: 0x00F33E1C
		public void AddGameplayScoreRecord(int gameplayId, float score)
		{
			if (this.GameplayScoreRecord.ContainsKey(gameplayId))
			{
				this.GameplayScoreRecord[gameplayId] = score;
				return;
			}
			this.GameplayScoreRecord.Add(gameplayId, score);
		}

		// Token: 0x060367E7 RID: 223207 RVA: 0x00F35C48 File Offset: 0x00F33E48
		public float GetGameplayScoreRecord(int gameplayId)
		{
			float result;
			if (this.GameplayScoreRecord.TryGetValue(gameplayId, out result))
			{
				return result;
			}
			return 0f;
		}

		// Token: 0x060367E8 RID: 223208 RVA: 0x00F35C6C File Offset: 0x00F33E6C
		protected override bool OnClear()
		{
			this.GameplayScoreRecord.Clear();
			return true;
		}

		// Token: 0x17006982 RID: 27010
		// (get) Token: 0x060367E9 RID: 223209 RVA: 0x00F35C7A File Offset: 0x00F33E7A
		public static DropCatchModel Instance
		{
			get
			{
				return DropCatchModel._Instance;
			}
		}

		// Token: 0x060367EA RID: 223210 RVA: 0x00F35C81 File Offset: 0x00F33E81
		public static DropCatchModel GetOrCreateInstance()
		{
			if (DropCatchModel._Instance == null)
			{
				DropCatchModel.CreateInstance();
			}
			return DropCatchModel._Instance;
		}

		// Token: 0x060367EB RID: 223211 RVA: 0x00F35C95 File Offset: 0x00F33E95
		public static bool CreateInstance()
		{
			if (DropCatchModel._Instance != null)
			{
				return true;
			}
			DropCatchModel._Instance = new DropCatchModel();
			return true;
		}

		// Token: 0x060367EC RID: 223212 RVA: 0x00F35CAB File Offset: 0x00F33EAB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060367ED RID: 223213 RVA: 0x00F35CAD File Offset: 0x00F33EAD
		public static void ResetStaticDefaultValue()
		{
			DropCatchModel._Instance = null;
		}

		// Token: 0x060367EE RID: 223214 RVA: 0x00F35CB5 File Offset: 0x00F33EB5
		static DropCatchModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchModel.CreateStaticDefaultValue), new Action(DropCatchModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CCA6 RID: 117926
		private readonly Dictionary<int, float> GameplayScoreRecord = new Dictionary<int, float>();

		// Token: 0x0401CCA7 RID: 117927
		[Nullable(2)]
		private static DropCatchModel _Instance;
	}
}
