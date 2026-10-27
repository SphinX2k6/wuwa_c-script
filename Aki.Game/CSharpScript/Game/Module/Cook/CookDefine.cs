using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AF7 RID: 23287
	[NullableContext(1)]
	[Nullable(0)]
	public class CookDefine : IStaticVariableResetter
	{
		// Token: 0x17008C37 RID: 35895
		// (get) Token: 0x0603AF2D RID: 241453 RVA: 0x00E0E222 File Offset: 0x00E0C422
		public static IReadOnlyList<EUiViewName> CookEntityCanChangeArray
		{
			get
			{
				return CookDefine._cookEntityCanChangeArray;
			}
		}

		// Token: 0x0603AF2E RID: 241454 RVA: 0x00E0E229 File Offset: 0x00E0C429
		static CookDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CookDefine.CreateStaticDefaultValue), new Action(CookDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603AF2F RID: 241455 RVA: 0x00E0E248 File Offset: 0x00E0C448
		public static void CreateStaticDefaultValue()
		{
			CookDefine._cookEntityCanChangeArray = new List<EUiViewName>
			{
				EUiViewName.CookMechanismRootView,
				EUiViewName.CookSchoolMechanismRootView
			};
		}

		// Token: 0x0603AF30 RID: 241456 RVA: 0x00E0E26A File Offset: 0x00E0C46A
		public static void ResetStaticDefaultValue()
		{
			CookDefine._cookEntityCanChangeArray = null;
		}

		// Token: 0x0401EC47 RID: 126023
		public const int COOK_SEQUENCE_TIME_LENGTH = 300;

		// Token: 0x0401EC48 RID: 126024
		public const string COOK_TYPE_TEXTURE_KEY = "T_CookingType";

		// Token: 0x0401EC49 RID: 126025
		public const string INVENTORY_ACTIVE_COLOR = "aa9b6a";

		// Token: 0x0401EC4A RID: 126026
		public const string INVENTORY_DEACTIVE_COLOR = "ece5d8";

		// Token: 0x0401EC4B RID: 126027
		[Nullable(2)]
		private static IReadOnlyList<EUiViewName> _cookEntityCanChangeArray;
	}
}
