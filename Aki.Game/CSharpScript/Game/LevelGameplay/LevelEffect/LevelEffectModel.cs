using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEffect
{
	// Token: 0x02005DB0 RID: 23984
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelEffectModel : ModelBase
	{
		// Token: 0x0603A61A RID: 239130 RVA: 0x0107D6D9 File Offset: 0x0107B8D9
		public void AcquireMpcParam(string key, int effectId)
		{
			this.MpcParamOwners[key] = effectId;
		}

		// Token: 0x0603A61B RID: 239131 RVA: 0x0107D6E8 File Offset: 0x0107B8E8
		public bool ReleaseMpcParamIfOwner(string key, int effectId)
		{
			int num;
			if (!this.MpcParamOwners.TryGetValue(key, out num) || num != effectId)
			{
				return false;
			}
			this.MpcParamOwners.Remove(key);
			return true;
		}

		// Token: 0x0603A61C RID: 239132 RVA: 0x0107D719 File Offset: 0x0107B919
		protected override bool OnLeaveLevel()
		{
			this.MpcParamOwners.Clear();
			return true;
		}

		// Token: 0x0603A61D RID: 239133 RVA: 0x0107D727 File Offset: 0x0107B927
		protected override bool OnClear()
		{
			this.MpcParamOwners.Clear();
			return true;
		}

		// Token: 0x17006EAA RID: 28330
		// (get) Token: 0x0603A61E RID: 239134 RVA: 0x0107D735 File Offset: 0x0107B935
		public static LevelEffectModel Instance
		{
			get
			{
				return LevelEffectModel._Instance;
			}
		}

		// Token: 0x0603A61F RID: 239135 RVA: 0x0107D73C File Offset: 0x0107B93C
		public static LevelEffectModel GetOrCreateInstance()
		{
			if (LevelEffectModel._Instance == null)
			{
				LevelEffectModel.CreateInstance();
			}
			return LevelEffectModel._Instance;
		}

		// Token: 0x0603A620 RID: 239136 RVA: 0x0107D750 File Offset: 0x0107B950
		public static bool CreateInstance()
		{
			if (LevelEffectModel._Instance != null)
			{
				return true;
			}
			LevelEffectModel._Instance = new LevelEffectModel();
			return true;
		}

		// Token: 0x0603A621 RID: 239137 RVA: 0x0107D766 File Offset: 0x0107B966
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A622 RID: 239138 RVA: 0x0107D768 File Offset: 0x0107B968
		public static void ResetStaticDefaultValue()
		{
			LevelEffectModel._Instance = null;
		}

		// Token: 0x0603A623 RID: 239139 RVA: 0x0107D770 File Offset: 0x0107B970
		static LevelEffectModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEffectModel.CreateStaticDefaultValue), new Action(LevelEffectModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EC2F RID: 125999
		private readonly Dictionary<string, int> MpcParamOwners = new Dictionary<string, int>();

		// Token: 0x0401EC30 RID: 126000
		[Nullable(2)]
		private static LevelEffectModel _Instance;
	}
}
