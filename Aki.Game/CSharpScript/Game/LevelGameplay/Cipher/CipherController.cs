using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x02006F35 RID: 28469
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CipherController : UiControllerBase
	{
		// Token: 0x06045425 RID: 283685 RVA: 0x01122C7B File Offset: 0x01120E7B
		public void OpenCipherView(string inId)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.CipherView))
			{
				return;
			}
			CipherModel.Instance.InitCipherConfig(inId);
			UiManager.Instance.OpenView(EUiViewName.CipherView, null, null);
		}

		// Token: 0x06045426 RID: 283686 RVA: 0x01122CAC File Offset: 0x01120EAC
		public void RequestCipherComplete()
		{
			UiGamePlayRequest uiGamePlayRequest = UiGamePlayRequest.Create();
			uiGamePlayRequest.GamePlayKey = CipherModel.Instance.GetCipherConfigId();
			uiGamePlayRequest.Type = UiGamePlayType.Cipher;
			Net.Instance.Call(ERequestMessageId.UiGamePlayRequest, uiGamePlayRequest, null, 0);
		}

		// Token: 0x17009B20 RID: 39712
		// (get) Token: 0x06045427 RID: 283687 RVA: 0x01122CE8 File Offset: 0x01120EE8
		public static CipherController Instance
		{
			get
			{
				return CipherController._Instance;
			}
		}

		// Token: 0x06045428 RID: 283688 RVA: 0x01122CEF File Offset: 0x01120EEF
		public static CipherController GetOrCreateInstance()
		{
			if (CipherController._Instance == null)
			{
				CipherController.CreateInstance();
			}
			return CipherController._Instance;
		}

		// Token: 0x06045429 RID: 283689 RVA: 0x01122D03 File Offset: 0x01120F03
		public static bool CreateInstance()
		{
			if (CipherController._Instance != null)
			{
				return true;
			}
			CipherController._Instance = new CipherController();
			return true;
		}

		// Token: 0x0604542A RID: 283690 RVA: 0x01122D19 File Offset: 0x01120F19
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604542B RID: 283691 RVA: 0x01122D1B File Offset: 0x01120F1B
		public static void ResetStaticDefaultValue()
		{
			CipherController._Instance = null;
		}

		// Token: 0x0604542C RID: 283692 RVA: 0x01122D23 File Offset: 0x01120F23
		static CipherController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CipherController.CreateStaticDefaultValue), new Action(CipherController.ResetStaticDefaultValue));
		}

		// Token: 0x040241C9 RID: 147913
		[Nullable(2)]
		private static CipherController _Instance;
	}
}
