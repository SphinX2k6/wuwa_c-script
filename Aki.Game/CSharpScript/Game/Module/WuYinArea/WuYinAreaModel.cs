using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using CSharpScript.Game.Render;

namespace CSharpScript.Game.Module.WuYinArea
{
	// Token: 0x020046F6 RID: 18166
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class WuYinAreaModel : ModelBase
	{
		// Token: 0x0602F814 RID: 194580 RVA: 0x00B0353D File Offset: 0x00B0173D
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602F815 RID: 194581 RVA: 0x00B03540 File Offset: 0x00B01740
		protected override bool OnClear()
		{
			this.WuYinLevelSequenceState.Clear();
			return true;
		}

		// Token: 0x0602F816 RID: 194582 RVA: 0x00B03550 File Offset: 0x00B01750
		public EWuYinSequencePlayState? GetWuYinLevelSequenceState(string sequenceName)
		{
			if (!this.WuYinLevelSequenceState.ContainsKey(sequenceName))
			{
				return null;
			}
			return new EWuYinSequencePlayState?(this.WuYinLevelSequenceState[sequenceName]);
		}

		// Token: 0x0602F817 RID: 194583 RVA: 0x00B03588 File Offset: 0x00B01788
		public void PlayWuYinSequence(string sequenceName, string playState)
		{
			EWuYinQuState state = (playState == "Play") ? EWuYinQuState.StateFighting1 : EWuYinQuState.StateIdle;
			RenderModuleController.Instance.SetBattleState(sequenceName, state, false);
		}

		// Token: 0x1700768C RID: 30348
		// (get) Token: 0x0602F818 RID: 194584 RVA: 0x00B035B4 File Offset: 0x00B017B4
		public static WuYinAreaModel Instance
		{
			get
			{
				return WuYinAreaModel._Instance;
			}
		}

		// Token: 0x0602F819 RID: 194585 RVA: 0x00B035BB File Offset: 0x00B017BB
		public static WuYinAreaModel GetOrCreateInstance()
		{
			if (WuYinAreaModel._Instance == null)
			{
				WuYinAreaModel.CreateInstance();
			}
			return WuYinAreaModel._Instance;
		}

		// Token: 0x0602F81A RID: 194586 RVA: 0x00B035CF File Offset: 0x00B017CF
		public static bool CreateInstance()
		{
			if (WuYinAreaModel._Instance != null)
			{
				return true;
			}
			WuYinAreaModel._Instance = new WuYinAreaModel();
			return true;
		}

		// Token: 0x0602F81B RID: 194587 RVA: 0x00B035E5 File Offset: 0x00B017E5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F81C RID: 194588 RVA: 0x00B035E7 File Offset: 0x00B017E7
		public static void ResetStaticDefaultValue()
		{
			WuYinAreaModel._Instance = null;
		}

		// Token: 0x0602F81D RID: 194589 RVA: 0x00B035EF File Offset: 0x00B017EF
		static WuYinAreaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuYinAreaModel.CreateStaticDefaultValue), new Action(WuYinAreaModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019AA7 RID: 105127
		private readonly Dictionary<string, EWuYinSequencePlayState> WuYinLevelSequenceState = new Dictionary<string, EWuYinSequencePlayState>();

		// Token: 0x04019AA8 RID: 105128
		[Nullable(2)]
		private static WuYinAreaModel _Instance;
	}
}
