using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003613 RID: 13843
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTabViewStorage : Singleton
	{
		// Token: 0x060233F6 RID: 144374 RVA: 0x00A032C4 File Offset: 0x00A014C4
		public IUiTabViewTsInfo GetUiTabViewBase(EUiTabViewName tabViewName)
		{
			IUiTabViewTsInfo result;
			this.UiTabViewStorageMap.TryGetValue(tabViewName, out result);
			return result;
		}

		// Token: 0x060233F7 RID: 144375 RVA: 0x00A032E4 File Offset: 0x00A014E4
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

		// Token: 0x17004940 RID: 18752
		// (get) Token: 0x060233F8 RID: 144376 RVA: 0x00A03346 File Offset: 0x00A01546
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

		// Token: 0x060233F9 RID: 144377 RVA: 0x00A03369 File Offset: 0x00A01569
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060233FA RID: 144378 RVA: 0x00A0336B File Offset: 0x00A0156B
		public static void ResetStaticDefaultValue()
		{
			UiTabViewStorage instance = UiTabViewStorage._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiTabViewStorage._instance = null;
		}

		// Token: 0x060233FB RID: 144379 RVA: 0x00A03384 File Offset: 0x00A01584
		static UiTabViewStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiTabViewStorage.CreateStaticDefaultValue), new Action(UiTabViewStorage.ResetStaticDefaultValue));
		}

		// Token: 0x04013DF0 RID: 81392
		private readonly Dictionary<EUiTabViewName, IUiTabViewTsInfo> UiTabViewStorageMap = new Dictionary<EUiTabViewName, IUiTabViewTsInfo>();

		// Token: 0x04013DF1 RID: 81393
		[Nullable(2)]
		private static UiTabViewStorage _instance;
	}
}
