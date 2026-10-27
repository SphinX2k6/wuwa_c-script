using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200583F RID: 22591
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractionController : UiControllerBase
	{
		// Token: 0x060396B7 RID: 235191 RVA: 0x00DA0A6B File Offset: 0x00D9EC6B
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(this.OnLocalStorageInitPlayerId));
		}

		// Token: 0x060396B8 RID: 235192 RVA: 0x00DA0A89 File Offset: 0x00D9EC89
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(this.OnLocalStorageInitPlayerId));
		}

		// Token: 0x060396B9 RID: 235193 RVA: 0x00DA0AA7 File Offset: 0x00D9ECA7
		private void OnLocalStorageInitPlayerId()
		{
			InteractionModel instance = InteractionModel.Instance;
			instance.LoadInteractGuideData();
			instance.LoadAutoInteractionGuideAppearCount();
		}

		// Token: 0x17008A39 RID: 35385
		// (get) Token: 0x060396BA RID: 235194 RVA: 0x00DA0AB9 File Offset: 0x00D9ECB9
		public static InteractionController Instance
		{
			get
			{
				return InteractionController._Instance;
			}
		}

		// Token: 0x060396BB RID: 235195 RVA: 0x00DA0AC0 File Offset: 0x00D9ECC0
		public static InteractionController GetOrCreateInstance()
		{
			if (InteractionController._Instance == null)
			{
				InteractionController.CreateInstance();
			}
			return InteractionController._Instance;
		}

		// Token: 0x060396BC RID: 235196 RVA: 0x00DA0AD4 File Offset: 0x00D9ECD4
		public static bool CreateInstance()
		{
			if (InteractionController._Instance != null)
			{
				return true;
			}
			InteractionController._Instance = new InteractionController();
			return true;
		}

		// Token: 0x060396BD RID: 235197 RVA: 0x00DA0AEA File Offset: 0x00D9ECEA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060396BE RID: 235198 RVA: 0x00DA0AEC File Offset: 0x00D9ECEC
		public static void ResetStaticDefaultValue()
		{
			InteractionController._Instance = null;
		}

		// Token: 0x060396BF RID: 235199 RVA: 0x00DA0AF4 File Offset: 0x00D9ECF4
		static InteractionController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InteractionController.CreateStaticDefaultValue), new Action(InteractionController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E072 RID: 122994
		[Nullable(2)]
		private static InteractionController _Instance;
	}
}
