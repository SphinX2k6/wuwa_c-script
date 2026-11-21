using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.World.EntityReadCode
{
	// Token: 0x02003453 RID: 13395
	[NullableContext(1)]
	[Nullable(0)]
	public class FbProperty : Singleton
	{
		// Token: 0x170047CD RID: 18381
		// (get) Token: 0x060222C3 RID: 139971 RVA: 0x009AE097 File Offset: 0x009AC297
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

		// Token: 0x060222C4 RID: 139972 RVA: 0x009AE0BA File Offset: 0x009AC2BA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060222C5 RID: 139973 RVA: 0x009AE0BC File Offset: 0x009AC2BC
		public static void ResetStaticDefaultValue()
		{
			FbProperty instance = FbProperty._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FbProperty._instance = null;
		}

		// Token: 0x060222C6 RID: 139974 RVA: 0x009AE0D5 File Offset: 0x009AC2D5
		static FbProperty()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FbProperty.CreateStaticDefaultValue), new Action(FbProperty.ResetStaticDefaultValue));
		}

		// Token: 0x04012CEF RID: 77039
		public readonly Dictionary<string, HashSet<string>> AllPropertySet = new Dictionary<string, HashSet<string>>();

		// Token: 0x04012CF0 RID: 77040
		public readonly Dictionary<string, HashSet<string>> InitPropertySet = new Dictionary<string, HashSet<string>>();

		// Token: 0x04012CF1 RID: 77041
		public readonly HashSet<string> CreateClassSet = new HashSet<string>();

		// Token: 0x04012CF2 RID: 77042
		[Nullable(2)]
		private static FbProperty _instance;
	}
}
