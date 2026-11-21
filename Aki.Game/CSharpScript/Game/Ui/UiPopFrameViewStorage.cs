using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003609 RID: 13833
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPopFrameViewStorage : Singleton
	{
		// Token: 0x060233D2 RID: 144338 RVA: 0x00A02E79 File Offset: 0x00A01079
		public void RegisterUiBehaviourPop(int type, UiPopFrameViewInfo info)
		{
			this.UiBehaviourPopMap[type] = info;
		}

		// Token: 0x060233D3 RID: 144339 RVA: 0x00A02E88 File Offset: 0x00A01088
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

		// Token: 0x1700493B RID: 18747
		// (get) Token: 0x060233D4 RID: 144340 RVA: 0x00A02EA8 File Offset: 0x00A010A8
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

		// Token: 0x060233D5 RID: 144341 RVA: 0x00A02ECB File Offset: 0x00A010CB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060233D6 RID: 144342 RVA: 0x00A02ECD File Offset: 0x00A010CD
		public static void ResetStaticDefaultValue()
		{
			UiPopFrameViewStorage instance = UiPopFrameViewStorage._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiPopFrameViewStorage._instance = null;
		}

		// Token: 0x060233D7 RID: 144343 RVA: 0x00A02EE6 File Offset: 0x00A010E6
		static UiPopFrameViewStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiPopFrameViewStorage.CreateStaticDefaultValue), new Action(UiPopFrameViewStorage.ResetStaticDefaultValue));
		}

		// Token: 0x04013DE6 RID: 81382
		private readonly Dictionary<int, UiPopFrameViewInfo> UiBehaviourPopMap = new Dictionary<int, UiPopFrameViewInfo>();

		// Token: 0x04013DE7 RID: 81383
		[Nullable(2)]
		private static UiPopFrameViewStorage _instance;
	}
}
