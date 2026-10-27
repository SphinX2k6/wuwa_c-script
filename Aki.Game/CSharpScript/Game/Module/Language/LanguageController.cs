using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Language
{
	// Token: 0x020056D1 RID: 22225
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class LanguageController : ControllerBase
	{
		// Token: 0x0603888F RID: 231567 RVA: 0x00D6E60B File Offset: 0x00D6C80B
		protected override bool OnInit()
		{
			this.OnAddEvents();
			return true;
		}

		// Token: 0x06038890 RID: 231568 RVA: 0x00D6E614 File Offset: 0x00D6C814
		protected override bool OnClear()
		{
			this.OnRemoveEvents();
			return true;
		}

		// Token: 0x06038891 RID: 231569 RVA: 0x00D6E61D File Offset: 0x00D6C81D
		private void OnAddEvents()
		{
			EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
		}

		// Token: 0x06038892 RID: 231570 RVA: 0x00D6E63B File Offset: 0x00D6C83B
		private void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
		}

		// Token: 0x06038893 RID: 231571 RVA: 0x00D6E65C File Offset: 0x00D6C85C
		private void OnLanguageChange(string oldLanguage, string newLanguage)
		{
			int languageType = LanguageSystem.Instance.GetLanguageDefineByCode(newLanguage).LanguageType;
			this.RequestSetLanguage(languageType);
		}

		// Token: 0x06038894 RID: 231572 RVA: 0x00D6E684 File Offset: 0x00D6C884
		public void RequestSetLanguage(int languageCode)
		{
			LanguageSettingUpdateRequest languageSettingUpdateRequest = LanguageSettingUpdateRequest.Create();
			languageSettingUpdateRequest.Language = languageCode;
			Net.Instance.Call(ERequestMessageId.LanguageSettingUpdateRequest, languageSettingUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				LanguageSettingUpdateResponse languageSettingUpdateResponse = (LanguageSettingUpdateResponse)msg;
				if (languageSettingUpdateResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(languageSettingUpdateResponse.ErrorCode, 27367, null, true, true);
				}
			}, 0);
		}

		// Token: 0x170087AA RID: 34730
		// (get) Token: 0x06038895 RID: 231573 RVA: 0x00D6E6CE File Offset: 0x00D6C8CE
		public static LanguageController Instance
		{
			get
			{
				return LanguageController._Instance;
			}
		}

		// Token: 0x06038896 RID: 231574 RVA: 0x00D6E6D5 File Offset: 0x00D6C8D5
		public static LanguageController GetOrCreateInstance()
		{
			if (LanguageController._Instance == null)
			{
				LanguageController.CreateInstance();
			}
			return LanguageController._Instance;
		}

		// Token: 0x06038897 RID: 231575 RVA: 0x00D6E6E9 File Offset: 0x00D6C8E9
		public static bool CreateInstance()
		{
			if (LanguageController._Instance != null)
			{
				return true;
			}
			LanguageController._Instance = new LanguageController();
			return true;
		}

		// Token: 0x06038898 RID: 231576 RVA: 0x00D6E6FF File Offset: 0x00D6C8FF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038899 RID: 231577 RVA: 0x00D6E701 File Offset: 0x00D6C901
		public static void ResetStaticDefaultValue()
		{
			LanguageController._Instance = null;
		}

		// Token: 0x0603889A RID: 231578 RVA: 0x00D6E709 File Offset: 0x00D6C909
		static LanguageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LanguageController.CreateStaticDefaultValue), new Action(LanguageController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DB1F RID: 121631
		[Nullable(2)]
		private static LanguageController _Instance;
	}
}
