using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AF8 RID: 23288
	public class MaterialSelectionCacheData : IStaticVariableResetter
	{
		// Token: 0x0603AF32 RID: 241458 RVA: 0x00E0E27A File Offset: 0x00E0C47A
		public static void SetMaterialSelectIndex(int index)
		{
			MaterialSelectionCacheData.TmpIndex = index;
		}

		// Token: 0x0603AF33 RID: 241459 RVA: 0x00E0E282 File Offset: 0x00E0C482
		public static int GetMaterialSelectIndex()
		{
			return MaterialSelectionCacheData.TmpIndex;
		}

		// Token: 0x0603AF34 RID: 241460 RVA: 0x00E0E289 File Offset: 0x00E0C489
		public static void SetMaterialUseNum(int num)
		{
			MaterialSelectionCacheData.TmpNum = num;
		}

		// Token: 0x0603AF35 RID: 241461 RVA: 0x00E0E291 File Offset: 0x00E0C491
		public static int GetMaterialUseNum()
		{
			return MaterialSelectionCacheData.TmpNum;
		}

		// Token: 0x0603AF36 RID: 241462 RVA: 0x00E0E298 File Offset: 0x00E0C498
		public static bool CheckCanSelected(int itemId)
		{
			return InventoryModel.Instance.GetCommonItemCount(itemId, 0) >= MaterialSelectionCacheData.GetMaterialUseNum();
		}

		// Token: 0x0603AF37 RID: 241463 RVA: 0x00E0E2B0 File Offset: 0x00E0C4B0
		static MaterialSelectionCacheData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MaterialSelectionCacheData.CreateStaticDefaultValue), new Action(MaterialSelectionCacheData.ResetStaticDefaultValue));
		}

		// Token: 0x0603AF38 RID: 241464 RVA: 0x00E0E2CF File Offset: 0x00E0C4CF
		public static void CreateStaticDefaultValue()
		{
			MaterialSelectionCacheData.TmpSelectedMaterialData = null;
			MaterialSelectionCacheData.MaterialTypeNum = 0;
			MaterialSelectionCacheData.TmpIndex = 0;
			MaterialSelectionCacheData.TmpNum = 0;
		}

		// Token: 0x0603AF39 RID: 241465 RVA: 0x00E0E2E9 File Offset: 0x00E0C4E9
		public static void ResetStaticDefaultValue()
		{
			MaterialSelectionCacheData.TmpSelectedMaterialData = null;
			MaterialSelectionCacheData.MaterialTypeNum = 0;
			MaterialSelectionCacheData.TmpIndex = 0;
			MaterialSelectionCacheData.TmpNum = 0;
		}

		// Token: 0x0401EC4C RID: 126028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<ISelectedData> TmpSelectedMaterialData;

		// Token: 0x0401EC4D RID: 126029
		public static int MaterialTypeNum;

		// Token: 0x0401EC4E RID: 126030
		private static int TmpIndex;

		// Token: 0x0401EC4F RID: 126031
		private static int TmpNum;
	}
}
