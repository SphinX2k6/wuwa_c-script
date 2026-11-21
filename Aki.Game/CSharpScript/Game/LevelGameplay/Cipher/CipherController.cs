using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x020060B6 RID: 24758
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CipherController : UiControllerBase
	{
		// Token: 0x0603B5D3 RID: 243155 RVA: 0x010CCC27 File Offset: 0x010CAE27
		public void OpenCipherView(string inId)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.CipherView))
			{
				return;
			}
			CipherModel.Instance.InitCipherConfig(inId);
			UiManager.Instance.OpenView(EUiViewName.CipherView, null, null);
		}

		// Token: 0x0603B5D4 RID: 243156 RVA: 0x010CCC58 File Offset: 0x010CAE58
		public void RequestCipherComplete()
		{
			UiGamePlayRequest uiGamePlayRequest = UiGamePlayRequest.Create();
			uiGamePlayRequest.GamePlayKey = CipherModel.Instance.GetCipherConfigId();
			uiGamePlayRequest.Type = UiGamePlayType.Cipher;
			Net.Instance.Call(ERequestMessageId.UiGamePlayRequest, uiGamePlayRequest, null, 0);
		}

		// Token: 0x1700705F RID: 28767
		// (get) Token: 0x0603B5D5 RID: 243157 RVA: 0x010CCC94 File Offset: 0x010CAE94
		public static CipherController Instance
		{
			get
			{
				return CipherController._Instance;
			}
		}

		// Token: 0x0603B5D6 RID: 243158 RVA: 0x010CCC9B File Offset: 0x010CAE9B
		public static CipherController GetOrCreateInstance()
		{
			if (CipherController._Instance == null)
			{
				CipherController.CreateInstance();
			}
			return CipherController._Instance;
		}

		// Token: 0x0603B5D7 RID: 243159 RVA: 0x010CCCAF File Offset: 0x010CAEAF
		public static bool CreateInstance()
		{
			if (CipherController._Instance != null)
			{
				return true;
			}
			CipherController._Instance = new CipherController();
			return true;
		}

		// Token: 0x0603B5D8 RID: 243160 RVA: 0x010CCCC5 File Offset: 0x010CAEC5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B5D9 RID: 243161 RVA: 0x010CCCC7 File Offset: 0x010CAEC7
		public static void ResetStaticDefaultValue()
		{
			CipherController._Instance = null;
		}

		// Token: 0x0603B5DA RID: 243162 RVA: 0x010CCCCF File Offset: 0x010CAECF
		static CipherController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CipherController.CreateStaticDefaultValue), new Action(CipherController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F47E RID: 128126
		[Nullable(2)]
		private static CipherController _Instance;
	}
}
