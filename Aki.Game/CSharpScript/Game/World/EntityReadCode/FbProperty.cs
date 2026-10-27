using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.World.EntityReadCode
{
	// Token: 0x0200452E RID: 17710
	[NullableContext(1)]
	[Nullable(0)]
	public class FbProperty : Singleton
	{
		// Token: 0x1700751A RID: 29978
		// (get) Token: 0x0602DBFB RID: 187387 RVA: 0x00A82E32 File Offset: 0x00A81032
		public static FbProperty Instance
		{
			get
			{
				if (FbProperty._instance == null)
				{
					FbProperty._instance = new FbProperty();
					FbProperty._instance.OnInit();
				}
				return FbProperty._instance;
			}
		}

		// Token: 0x0602DBFC RID: 187388 RVA: 0x00A82E55 File Offset: 0x00A81055
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DBFD RID: 187389 RVA: 0x00A82E57 File Offset: 0x00A81057
		public static void ResetStaticDefaultValue()
		{
			FbProperty instance = FbProperty._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FbProperty._instance = null;
		}

		// Token: 0x0602DBFE RID: 187390 RVA: 0x00A82E70 File Offset: 0x00A81070
		static FbProperty()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FbProperty.CreateStaticDefaultValue), new Action(FbProperty.ResetStaticDefaultValue));
		}

		// Token: 0x040186CA RID: 100042
		public readonly Dictionary<string, HashSet<string>> AllPropertySet = new Dictionary<string, HashSet<string>>();

		// Token: 0x040186CB RID: 100043
		public readonly Dictionary<string, HashSet<string>> InitPropertySet = new Dictionary<string, HashSet<string>>();

		// Token: 0x040186CC RID: 100044
		public readonly HashSet<string> CreateClassSet = new HashSet<string>();

		// Token: 0x040186CD RID: 100045
		[Nullable(2)]
		private static FbProperty _instance;
	}
}
