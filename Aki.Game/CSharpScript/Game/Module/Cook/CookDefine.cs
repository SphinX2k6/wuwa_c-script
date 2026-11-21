using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AD8 RID: 19160
	[NullableContext(1)]
	[Nullable(0)]
	public class CookDefine : IStaticVariableResetter
	{
		// Token: 0x17006011 RID: 24593
		// (get) Token: 0x0602FE9F RID: 196255 RVA: 0x00D5EF16 File Offset: 0x00D5D116
		public static IReadOnlyList<EUiViewName> CookEntityCanChangeArray
		{
			get
			{
				return CookDefine._cookEntityCanChangeArray;
			}
		}

		// Token: 0x0602FEA0 RID: 196256 RVA: 0x00D5EF1D File Offset: 0x00D5D11D
		static CookDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CookDefine.CreateStaticDefaultValue), new Action(CookDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0602FEA1 RID: 196257 RVA: 0x00D5EF3C File Offset: 0x00D5D13C
		public static void CreateStaticDefaultValue()
		{
			CookDefine._cookEntityCanChangeArray = new List<EUiViewName>
			{
				EUiViewName.CookMechanismRootView,
				EUiViewName.CookSchoolMechanismRootView
			};
		}

		// Token: 0x0602FEA2 RID: 196258 RVA: 0x00D5EF5E File Offset: 0x00D5D15E
		public static void ResetStaticDefaultValue()
		{
			CookDefine._cookEntityCanChangeArray = null;
		}

		// Token: 0x04019703 RID: 104195
		public const int COOK_SEQUENCE_TIME_LENGTH = 300;

		// Token: 0x04019704 RID: 104196
		public const string COOK_TYPE_TEXTURE_KEY = "T_CookingType";

		// Token: 0x04019705 RID: 104197
		public const string INVENTORY_ACTIVE_COLOR = "aa9b6a";

		// Token: 0x04019706 RID: 104198
		public const string INVENTORY_DEACTIVE_COLOR = "ece5d8";

		// Token: 0x04019707 RID: 104199
		[Nullable(2)]
		private static IReadOnlyList<EUiViewName> _cookEntityCanChangeArray;
	}
}
