using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AB1 RID: 23217
	public class LevelEventLockMaskModule : IStaticVariableResetter
	{
		// Token: 0x0603932E RID: 234286 RVA: 0x01005FF5 File Offset: 0x010041F5
		static LevelEventLockMaskModule()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEventLockMaskModule.CreateStaticDefaultValue), new Action(LevelEventLockMaskModule.ResetStaticDefaultValue));
		}

		// Token: 0x0603932F RID: 234287 RVA: 0x01006014 File Offset: 0x01004214
		public static void SetLockMask(bool state)
		{
			if (LevelEventLockMaskModule.IsLockMask == state)
			{
				return;
			}
			LevelEventLockMaskModule.IsLockMask = state;
			LevelEventLockMaskModule.RefreshLockMask(null);
			LevelEventLockMaskModule.HandleEventSystem();
		}

		// Token: 0x06039330 RID: 234288 RVA: 0x01006030 File Offset: 0x01004230
		public static void Clear()
		{
			LevelEventLockMaskModule.SetLockMask(false);
		}

		// Token: 0x06039331 RID: 234289 RVA: 0x01006038 File Offset: 0x01004238
		private static void HandleEventSystem()
		{
			if (LevelEventLockMaskModule.IsLockMask)
			{
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.OnInputDistributeTagChanged;
				Action<IReadOnlyList<InputDistributeTag>> handle;
				if ((handle = LevelEventLockMaskModule.<>O.<0>__RefreshLockMask) == null)
				{
					handle = (LevelEventLockMaskModule.<>O.<0>__RefreshLockMask = new Action<IReadOnlyList<InputDistributeTag>>(LevelEventLockMaskModule.RefreshLockMask));
				}
				instance.Add<IReadOnlyList<InputDistributeTag>>(name, handle);
				return;
			}
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnInputDistributeTagChanged;
			Action<IReadOnlyList<InputDistributeTag>> handle2;
			if ((handle2 = LevelEventLockMaskModule.<>O.<0>__RefreshLockMask) == null)
			{
				handle2 = (LevelEventLockMaskModule.<>O.<0>__RefreshLockMask = new Action<IReadOnlyList<InputDistributeTag>>(LevelEventLockMaskModule.RefreshLockMask));
			}
			instance2.Remove<IReadOnlyList<InputDistributeTag>>(name2, handle2);
		}

		// Token: 0x06039332 RID: 234290 RVA: 0x010060A4 File Offset: 0x010042A4
		private static void RefreshLockMask([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<InputDistributeTag> _)
		{
			if (!LevelEventLockMaskModule.IsLockMask)
			{
				UiLayer.Instance.SetShowMaskLayer("LevelEventSetPlayerOperation", false);
				return;
			}
			InputDistributeModel instance = InputDistributeModel.Instance;
			if (instance.IsTagMatchAnyCurrentInputTag("UiInputRoot.MouseInputTag", false) || instance.IsTagMatchAnyCurrentInputTag("UiInputRoot.ShortcutKeyTag", false) || instance.IsTagMatchAnyCurrentInputTag("UiInputRoot.Navigation", false))
			{
				UiLayer.Instance.SetShowMaskLayer("LevelEventSetPlayerOperation", false);
				return;
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.BattleView))
			{
				UiLayer.Instance.SetShowMaskLayer("LevelEventSetPlayerOperation", true);
				return;
			}
			UiLayer.Instance.SetShowMaskLayer("LevelEventSetPlayerOperation", false);
		}

		// Token: 0x06039333 RID: 234291 RVA: 0x0100613C File Offset: 0x0100433C
		public static void CreateStaticDefaultValue()
		{
			LevelEventLockMaskModule.IsLockMask = false;
		}

		// Token: 0x06039334 RID: 234292 RVA: 0x01006144 File Offset: 0x01004344
		public static void ResetStaticDefaultValue()
		{
			LevelEventLockMaskModule.IsLockMask = false;
		}

		// Token: 0x0401E1AC RID: 123308
		private static bool IsLockMask;

		// Token: 0x0200B6BB RID: 46779
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040388CD RID: 231629
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<IReadOnlyList<InputDistributeTag>> <0>__RefreshLockMask;
		}
	}
}
