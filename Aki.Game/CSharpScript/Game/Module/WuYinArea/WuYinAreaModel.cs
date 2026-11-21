using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using CSharpScript.Game.Render;

namespace CSharpScript.Game.Module.WuYinArea
{
	// Token: 0x02003626 RID: 13862
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class WuYinAreaModel : ModelBase
	{
		// Token: 0x06023FDA RID: 147418 RVA: 0x00A3320D File Offset: 0x00A3140D
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06023FDB RID: 147419 RVA: 0x00A33210 File Offset: 0x00A31410
		protected override bool OnClear()
		{
			this.WuYinLevelSequenceState.Clear();
			return true;
		}

		// Token: 0x06023FDC RID: 147420 RVA: 0x00A33220 File Offset: 0x00A31420
		public EWuYinSequencePlayState? GetWuYinLevelSequenceState(string sequenceName)
		{
			if (!this.WuYinLevelSequenceState.ContainsKey(sequenceName))
			{
				return null;
			}
			return new EWuYinSequencePlayState?(this.WuYinLevelSequenceState[sequenceName]);
		}

		// Token: 0x06023FDD RID: 147421 RVA: 0x00A33258 File Offset: 0x00A31458
		public void PlayWuYinSequence(string sequenceName, string playState)
		{
			EWuYinQuState state = (playState == "Play") ? EWuYinQuState.StateFighting1 : EWuYinQuState.StateIdle;
			RenderModuleController.Instance.SetBattleState(sequenceName, state, false);
		}

		// Token: 0x17004948 RID: 18760
		// (get) Token: 0x06023FDE RID: 147422 RVA: 0x00A33284 File Offset: 0x00A31484
		public static WuYinAreaModel Instance
		{
			get
			{
				return WuYinAreaModel._Instance;
			}
		}

		// Token: 0x06023FDF RID: 147423 RVA: 0x00A3328B File Offset: 0x00A3148B
		public static WuYinAreaModel GetOrCreateInstance()
		{
			if (WuYinAreaModel._Instance == null)
			{
				WuYinAreaModel.CreateInstance();
			}
			return WuYinAreaModel._Instance;
		}

		// Token: 0x06023FE0 RID: 147424 RVA: 0x00A3329F File Offset: 0x00A3149F
		public static bool CreateInstance()
		{
			if (WuYinAreaModel._Instance != null)
			{
				return true;
			}
			WuYinAreaModel._Instance = new WuYinAreaModel();
			return true;
		}

		// Token: 0x06023FE1 RID: 147425 RVA: 0x00A332B5 File Offset: 0x00A314B5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023FE2 RID: 147426 RVA: 0x00A332B7 File Offset: 0x00A314B7
		public static void ResetStaticDefaultValue()
		{
			WuYinAreaModel._Instance = null;
		}

		// Token: 0x06023FE3 RID: 147427 RVA: 0x00A332BF File Offset: 0x00A314BF
		static WuYinAreaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuYinAreaModel.CreateStaticDefaultValue), new Action(WuYinAreaModel.ResetStaticDefaultValue));
		}

		// Token: 0x04014156 RID: 82262
		private readonly Dictionary<string, EWuYinSequencePlayState> WuYinLevelSequenceState = new Dictionary<string, EWuYinSequencePlayState>();

		// Token: 0x04014157 RID: 82263
		[Nullable(2)]
		private static WuYinAreaModel _Instance;
	}
}
