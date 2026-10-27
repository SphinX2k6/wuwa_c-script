using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046E3 RID: 18147
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTabViewStorage : Singleton
	{
		// Token: 0x0602ECBB RID: 191675 RVA: 0x00AD57EC File Offset: 0x00AD39EC
		public IUiTabViewTsInfo GetUiTabViewBase(EUiTabViewName tabViewName)
		{
			IUiTabViewTsInfo result;
			this.UiTabViewStorageMap.TryGetValue(tabViewName, out result);
			return result;
		}

		// Token: 0x0602ECBC RID: 191676 RVA: 0x00AD580C File Offset: 0x00AD3A0C
		public void AddUiTabViewBase([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] ValueTuple<EUiTabViewName, Type, string>[] uiTabViewTsInfoList)
		{
			for (int i = 0; i < uiTabViewTsInfoList.Length; i++)
			{
				ValueTuple<EUiTabViewName, Type, string> uiTabViewTsInfo = uiTabViewTsInfoList[i];
				this.UiTabViewStorageMap[uiTabViewTsInfo.Item1] = new UiTabViewTsInfo(() => (UiTabViewBase)Activator.CreateInstance(uiTabViewTsInfo.Item2), uiTabViewTsInfo.Item3);
			}
		}

		// Token: 0x17007684 RID: 30340
		// (get) Token: 0x0602ECBD RID: 191677 RVA: 0x00AD586E File Offset: 0x00AD3A6E
		public static UiTabViewStorage Instance
		{
			get
			{
				if (UiTabViewStorage._instance == null)
				{
					UiTabViewStorage._instance = new UiTabViewStorage();
					UiTabViewStorage._instance.OnInit();
				}
				return UiTabViewStorage._instance;
			}
		}

		// Token: 0x0602ECBE RID: 191678 RVA: 0x00AD5891 File Offset: 0x00AD3A91
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602ECBF RID: 191679 RVA: 0x00AD5893 File Offset: 0x00AD3A93
		public static void ResetStaticDefaultValue()
		{
			UiTabViewStorage instance = UiTabViewStorage._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiTabViewStorage._instance = null;
		}

		// Token: 0x0602ECC0 RID: 191680 RVA: 0x00AD58AC File Offset: 0x00AD3AAC
		static UiTabViewStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiTabViewStorage.CreateStaticDefaultValue), new Action(UiTabViewStorage.ResetStaticDefaultValue));
		}

		// Token: 0x04019752 RID: 104274
		private readonly Dictionary<EUiTabViewName, IUiTabViewTsInfo> UiTabViewStorageMap = new Dictionary<EUiTabViewName, IUiTabViewTsInfo>();

		// Token: 0x04019753 RID: 104275
		[Nullable(2)]
		private static UiTabViewStorage _instance;
	}
}
