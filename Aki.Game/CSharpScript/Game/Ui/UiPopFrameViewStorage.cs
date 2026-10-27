using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046D9 RID: 18137
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPopFrameViewStorage : Singleton
	{
		// Token: 0x0602EC98 RID: 191640 RVA: 0x00AD53D5 File Offset: 0x00AD35D5
		public void RegisterUiBehaviourPop(int type, UiPopFrameViewInfo info)
		{
			this.UiBehaviourPopMap[type] = info;
		}

		// Token: 0x0602EC99 RID: 191641 RVA: 0x00AD53E4 File Offset: 0x00AD35E4
		[NullableContext(2)]
		public UiPopFrameViewInfo GetUiBehaviourPopInfo(int type)
		{
			UiPopFrameViewInfo result;
			if (!this.UiBehaviourPopMap.TryGetValue(type, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x1700767F RID: 30335
		// (get) Token: 0x0602EC9A RID: 191642 RVA: 0x00AD5404 File Offset: 0x00AD3604
		public static UiPopFrameViewStorage Instance
		{
			get
			{
				if (UiPopFrameViewStorage._instance == null)
				{
					UiPopFrameViewStorage._instance = new UiPopFrameViewStorage();
					UiPopFrameViewStorage._instance.OnInit();
				}
				return UiPopFrameViewStorage._instance;
			}
		}

		// Token: 0x0602EC9B RID: 191643 RVA: 0x00AD5427 File Offset: 0x00AD3627
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EC9C RID: 191644 RVA: 0x00AD5429 File Offset: 0x00AD3629
		public static void ResetStaticDefaultValue()
		{
			UiPopFrameViewStorage instance = UiPopFrameViewStorage._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiPopFrameViewStorage._instance = null;
		}

		// Token: 0x0602EC9D RID: 191645 RVA: 0x00AD5442 File Offset: 0x00AD3642
		static UiPopFrameViewStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiPopFrameViewStorage.CreateStaticDefaultValue), new Action(UiPopFrameViewStorage.ResetStaticDefaultValue));
		}

		// Token: 0x04019748 RID: 104264
		private readonly Dictionary<int, UiPopFrameViewInfo> UiBehaviourPopMap = new Dictionary<int, UiPopFrameViewInfo>();

		// Token: 0x04019749 RID: 104265
		[Nullable(2)]
		private static UiPopFrameViewStorage _instance;
	}
}
