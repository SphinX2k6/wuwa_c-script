using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ResetPlayer
{
	// Token: 0x02005C11 RID: 23569
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetPlayerModel : ModelBase
	{
		// Token: 0x17006E3D RID: 28221
		// (get) Token: 0x06039E1D RID: 237085 RVA: 0x0104613E File Offset: 0x0104433E
		public static ResetPlayerModel Instance
		{
			get
			{
				return ResetPlayerModel._Instance;
			}
		}

		// Token: 0x06039E1E RID: 237086 RVA: 0x01046145 File Offset: 0x01044345
		public static ResetPlayerModel GetOrCreateInstance()
		{
			if (ResetPlayerModel._Instance == null)
			{
				ResetPlayerModel.CreateInstance();
			}
			return ResetPlayerModel._Instance;
		}

		// Token: 0x06039E1F RID: 237087 RVA: 0x01046159 File Offset: 0x01044359
		public static bool CreateInstance()
		{
			if (ResetPlayerModel._Instance != null)
			{
				return true;
			}
			ResetPlayerModel._Instance = new ResetPlayerModel();
			return true;
		}

		// Token: 0x06039E20 RID: 237088 RVA: 0x0104616F File Offset: 0x0104436F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039E21 RID: 237089 RVA: 0x01046171 File Offset: 0x01044371
		public static void ResetStaticDefaultValue()
		{
			ResetPlayerModel._Instance = null;
		}

		// Token: 0x06039E22 RID: 237090 RVA: 0x01046179 File Offset: 0x01044379
		static ResetPlayerModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResetPlayerModel.CreateStaticDefaultValue), new Action(ResetPlayerModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E961 RID: 125281
		public bool IsReseting;

		// Token: 0x0401E962 RID: 125282
		public HashSet<int> CueHandleSet = new HashSet<int>();

		// Token: 0x0401E963 RID: 125283
		[Nullable(2)]
		public EntityHandle DisableMoveEntityHandle;

		// Token: 0x0401E964 RID: 125284
		[Nullable(2)]
		private static ResetPlayerModel _Instance;
	}
}
