using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Language
{
	// Token: 0x020046A8 RID: 18088
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class LanguageController : ControllerBase
	{
		// Token: 0x0602D79F RID: 186271 RVA: 0x00CBCBCF File Offset: 0x00CBADCF
		protected override bool OnInit()
		{
			this.OnAddEvents();
			return true;
		}

		// Token: 0x0602D7A0 RID: 186272 RVA: 0x00CBCBD8 File Offset: 0x00CBADD8
		protected override bool OnClear()
		{
			this.OnRemoveEvents();
			return true;
		}

		// Token: 0x0602D7A1 RID: 186273 RVA: 0x00CBCBE1 File Offset: 0x00CBADE1
		private void OnAddEvents()
		{
			EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
		}

		// Token: 0x0602D7A2 RID: 186274 RVA: 0x00CBCBFF File Offset: 0x00CBADFF
		private void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
		}

		// Token: 0x0602D7A3 RID: 186275 RVA: 0x00CBCC20 File Offset: 0x00CBAE20
		private void OnLanguageChange(string oldLanguage, string newLanguage)
		{
			int languageType = LanguageSystem.Instance.GetLanguageDefineByCode(newLanguage).LanguageType;
			this.RequestSetLanguage(languageType);
		}

		// Token: 0x0602D7A4 RID: 186276 RVA: 0x00CBCC48 File Offset: 0x00CBAE48
		public void RequestSetLanguage(int languageCode)
		{
			LanguageSettingUpdateRequest languageSettingUpdateRequest = LanguageSettingUpdateRequest.Create();
			languageSettingUpdateRequest.Language = languageCode;
			Net.Instance.Call(ERequestMessageId.LanguageSettingUpdateRequest, languageSettingUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				LanguageSettingUpdateResponse languageSettingUpdateResponse = (LanguageSettingUpdateResponse)msg;
				if (languageSettingUpdateResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(languageSettingUpdateResponse.ErrorCode, 23816, null, true, true);
				}
			}, 0);
		}

		// Token: 0x17005B72 RID: 23410
		// (get) Token: 0x0602D7A5 RID: 186277 RVA: 0x00CBCC92 File Offset: 0x00CBAE92
		public static LanguageController Instance
		{
			get
			{
				return LanguageController._Instance;
			}
		}

		// Token: 0x0602D7A6 RID: 186278 RVA: 0x00CBCC99 File Offset: 0x00CBAE99
		public static LanguageController GetOrCreateInstance()
		{
			if (LanguageController._Instance == null)
			{
				LanguageController.CreateInstance();
			}
			return LanguageController._Instance;
		}

		// Token: 0x0602D7A7 RID: 186279 RVA: 0x00CBCCAD File Offset: 0x00CBAEAD
		public static bool CreateInstance()
		{
			if (LanguageController._Instance != null)
			{
				return true;
			}
			LanguageController._Instance = new LanguageController();
			return true;
		}

		// Token: 0x0602D7A8 RID: 186280 RVA: 0x00CBCCC3 File Offset: 0x00CBAEC3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D7A9 RID: 186281 RVA: 0x00CBCCC5 File Offset: 0x00CBAEC5
		public static void ResetStaticDefaultValue()
		{
			LanguageController._Instance = null;
		}

		// Token: 0x0602D7AA RID: 186282 RVA: 0x00CBCCCD File Offset: 0x00CBAECD
		static LanguageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LanguageController.CreateStaticDefaultValue), new Action(LanguageController.ResetStaticDefaultValue));
		}

		// Token: 0x040185B5 RID: 99765
		[Nullable(2)]
		private static LanguageController _Instance;
	}
}
