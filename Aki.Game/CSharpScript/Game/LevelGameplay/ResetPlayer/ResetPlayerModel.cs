using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ResetPlayer
{
	// Token: 0x02006AB4 RID: 27316
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetPlayerModel : ModelBase
	{
		// Token: 0x1700994F RID: 39247
		// (get) Token: 0x06043DC6 RID: 277958 RVA: 0x010A1A1E File Offset: 0x0109FC1E
		public static ResetPlayerModel Instance
		{
			get
			{
				return ResetPlayerModel._Instance;
			}
		}

		// Token: 0x06043DC7 RID: 277959 RVA: 0x010A1A25 File Offset: 0x0109FC25
		public static ResetPlayerModel GetOrCreateInstance()
		{
			if (ResetPlayerModel._Instance == null)
			{
				ResetPlayerModel.CreateInstance();
			}
			return ResetPlayerModel._Instance;
		}

		// Token: 0x06043DC8 RID: 277960 RVA: 0x010A1A39 File Offset: 0x0109FC39
		public static bool CreateInstance()
		{
			if (ResetPlayerModel._Instance != null)
			{
				return true;
			}
			ResetPlayerModel._Instance = new ResetPlayerModel();
			return true;
		}

		// Token: 0x06043DC9 RID: 277961 RVA: 0x010A1A4F File Offset: 0x0109FC4F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043DCA RID: 277962 RVA: 0x010A1A51 File Offset: 0x0109FC51
		public static void ResetStaticDefaultValue()
		{
			ResetPlayerModel._Instance = null;
		}

		// Token: 0x06043DCB RID: 277963 RVA: 0x010A1A59 File Offset: 0x0109FC59
		static ResetPlayerModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResetPlayerModel.CreateStaticDefaultValue), new Action(ResetPlayerModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402376F RID: 145263
		public bool IsReseting;

		// Token: 0x04023770 RID: 145264
		public HashSet<int> CueHandleSet = new HashSet<int>();

		// Token: 0x04023771 RID: 145265
		[Nullable(2)]
		public EntityHandle DisableMoveEntityHandle;

		// Token: 0x04023772 RID: 145266
		[Nullable(2)]
		private static ResetPlayerModel _Instance;
	}
}
