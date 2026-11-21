using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004816 RID: 18454
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractionController : UiControllerBase
	{
		// Token: 0x0602E5CB RID: 189899 RVA: 0x00CEF977 File Offset: 0x00CEDB77
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(this.OnLocalStorageInitPlayerId));
		}

		// Token: 0x0602E5CC RID: 189900 RVA: 0x00CEF995 File Offset: 0x00CEDB95
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(this.OnLocalStorageInitPlayerId));
		}

		// Token: 0x0602E5CD RID: 189901 RVA: 0x00CEF9B3 File Offset: 0x00CEDBB3
		private void OnLocalStorageInitPlayerId()
		{
			InteractionModel instance = InteractionModel.Instance;
			instance.LoadInteractGuideData();
			instance.LoadAutoInteractionGuideAppearCount();
		}

		// Token: 0x17005E02 RID: 24066
		// (get) Token: 0x0602E5CE RID: 189902 RVA: 0x00CEF9C5 File Offset: 0x00CEDBC5
		public static InteractionController Instance
		{
			get
			{
				return InteractionController._Instance;
			}
		}

		// Token: 0x0602E5CF RID: 189903 RVA: 0x00CEF9CC File Offset: 0x00CEDBCC
		public static InteractionController GetOrCreateInstance()
		{
			if (InteractionController._Instance == null)
			{
				InteractionController.CreateInstance();
			}
			return InteractionController._Instance;
		}

		// Token: 0x0602E5D0 RID: 189904 RVA: 0x00CEF9E0 File Offset: 0x00CEDBE0
		public static bool CreateInstance()
		{
			if (InteractionController._Instance != null)
			{
				return true;
			}
			InteractionController._Instance = new InteractionController();
			return true;
		}

		// Token: 0x0602E5D1 RID: 189905 RVA: 0x00CEF9F6 File Offset: 0x00CEDBF6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E5D2 RID: 189906 RVA: 0x00CEF9F8 File Offset: 0x00CEDBF8
		public static void ResetStaticDefaultValue()
		{
			InteractionController._Instance = null;
		}

		// Token: 0x0602E5D3 RID: 189907 RVA: 0x00CEFA00 File Offset: 0x00CEDC00
		static InteractionController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InteractionController.CreateStaticDefaultValue), new Action(InteractionController.ResetStaticDefaultValue));
		}

		// Token: 0x04018B0B RID: 101131
		[Nullable(2)]
		private static InteractionController _Instance;
	}
}
