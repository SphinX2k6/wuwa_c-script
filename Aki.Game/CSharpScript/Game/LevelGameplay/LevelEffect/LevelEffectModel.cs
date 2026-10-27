using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEffect
{
	// Token: 0x02006C37 RID: 27703
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelEffectModel : ModelBase
	{
		// Token: 0x060444C2 RID: 279746 RVA: 0x010D3826 File Offset: 0x010D1A26
		public void AcquireMpcParam(string key, int effectId)
		{
			this.MpcParamOwners[key] = effectId;
		}

		// Token: 0x060444C3 RID: 279747 RVA: 0x010D3838 File Offset: 0x010D1A38
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

		// Token: 0x060444C4 RID: 279748 RVA: 0x010D3869 File Offset: 0x010D1A69
		protected override bool OnLeaveLevel()
		{
			this.MpcParamOwners.Clear();
			return true;
		}

		// Token: 0x060444C5 RID: 279749 RVA: 0x010D3877 File Offset: 0x010D1A77
		protected override bool OnClear()
		{
			this.MpcParamOwners.Clear();
			return true;
		}

		// Token: 0x170099A7 RID: 39335
		// (get) Token: 0x060444C6 RID: 279750 RVA: 0x010D3885 File Offset: 0x010D1A85
		public static LevelEffectModel Instance
		{
			get
			{
				return LevelEffectModel._Instance;
			}
		}

		// Token: 0x060444C7 RID: 279751 RVA: 0x010D388C File Offset: 0x010D1A8C
		public static LevelEffectModel GetOrCreateInstance()
		{
			if (LevelEffectModel._Instance == null)
			{
				LevelEffectModel.CreateInstance();
			}
			return LevelEffectModel._Instance;
		}

		// Token: 0x060444C8 RID: 279752 RVA: 0x010D38A0 File Offset: 0x010D1AA0
		public static bool CreateInstance()
		{
			if (LevelEffectModel._Instance != null)
			{
				return true;
			}
			LevelEffectModel._Instance = new LevelEffectModel();
			return true;
		}

		// Token: 0x060444C9 RID: 279753 RVA: 0x010D38B6 File Offset: 0x010D1AB6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060444CA RID: 279754 RVA: 0x010D38B8 File Offset: 0x010D1AB8
		public static void ResetStaticDefaultValue()
		{
			LevelEffectModel._Instance = null;
		}

		// Token: 0x060444CB RID: 279755 RVA: 0x010D38C0 File Offset: 0x010D1AC0
		static LevelEffectModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEffectModel.CreateStaticDefaultValue), new Action(LevelEffectModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402398D RID: 145805
		private readonly Dictionary<string, int> MpcParamOwners = new Dictionary<string, int>();

		// Token: 0x0402398E RID: 145806
		[Nullable(2)]
		private static LevelEffectModel _Instance;
	}
}
