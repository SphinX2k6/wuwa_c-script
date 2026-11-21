using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AD9 RID: 19161
	public class MaterialSelectionCacheData : IStaticVariableResetter
	{
		// Token: 0x0602FEA4 RID: 196260 RVA: 0x00D5EF6E File Offset: 0x00D5D16E
		public static void SetMaterialSelectIndex(int index)
		{
			MaterialSelectionCacheData.TmpIndex = index;
		}

		// Token: 0x0602FEA5 RID: 196261 RVA: 0x00D5EF76 File Offset: 0x00D5D176
		public static int GetMaterialSelectIndex()
		{
			return MaterialSelectionCacheData.TmpIndex;
		}

		// Token: 0x0602FEA6 RID: 196262 RVA: 0x00D5EF7D File Offset: 0x00D5D17D
		public static void SetMaterialUseNum(int num)
		{
			MaterialSelectionCacheData.TmpNum = num;
		}

		// Token: 0x0602FEA7 RID: 196263 RVA: 0x00D5EF85 File Offset: 0x00D5D185
		public static int GetMaterialUseNum()
		{
			return MaterialSelectionCacheData.TmpNum;
		}

		// Token: 0x0602FEA8 RID: 196264 RVA: 0x00D5EF8C File Offset: 0x00D5D18C
		public static bool CheckCanSelected(int itemId)
		{
			return InventoryModel.Instance.GetCommonItemCount(itemId, 0) >= MaterialSelectionCacheData.GetMaterialUseNum();
		}

		// Token: 0x0602FEA9 RID: 196265 RVA: 0x00D5EFA4 File Offset: 0x00D5D1A4
		static MaterialSelectionCacheData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MaterialSelectionCacheData.CreateStaticDefaultValue), new Action(MaterialSelectionCacheData.ResetStaticDefaultValue));
		}

		// Token: 0x0602FEAA RID: 196266 RVA: 0x00D5EFC3 File Offset: 0x00D5D1C3
		public static void CreateStaticDefaultValue()
		{
			MaterialSelectionCacheData.TmpSelectedMaterialData = null;
			MaterialSelectionCacheData.MaterialTypeNum = 0;
			MaterialSelectionCacheData.TmpIndex = 0;
			MaterialSelectionCacheData.TmpNum = 0;
		}

		// Token: 0x0602FEAB RID: 196267 RVA: 0x00D5EFDD File Offset: 0x00D5D1DD
		public static void ResetStaticDefaultValue()
		{
			MaterialSelectionCacheData.TmpSelectedMaterialData = null;
			MaterialSelectionCacheData.MaterialTypeNum = 0;
			MaterialSelectionCacheData.TmpIndex = 0;
			MaterialSelectionCacheData.TmpNum = 0;
		}

		// Token: 0x04019708 RID: 104200
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<ISelectedData> TmpSelectedMaterialData;

		// Token: 0x04019709 RID: 104201
		public static int MaterialTypeNum;

		// Token: 0x0401970A RID: 104202
		private static int TmpIndex;

		// Token: 0x0401970B RID: 104203
		private static int TmpNum;
	}
}
