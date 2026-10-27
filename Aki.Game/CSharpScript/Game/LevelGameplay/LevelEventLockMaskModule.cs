using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006956 RID: 26966
	public class LevelEventLockMaskModule : IStaticVariableResetter
	{
		// Token: 0x060432F7 RID: 275191 RVA: 0x01061D95 File Offset: 0x0105FF95
		static LevelEventLockMaskModule()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEventLockMaskModule.CreateStaticDefaultValue), new Action(LevelEventLockMaskModule.ResetStaticDefaultValue));
		}

		// Token: 0x060432F8 RID: 275192 RVA: 0x01061DB4 File Offset: 0x0105FFB4
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

		// Token: 0x060432F9 RID: 275193 RVA: 0x01061DD0 File Offset: 0x0105FFD0
		public static void Clear()
		{
			LevelEventLockMaskModule.SetLockMask(false);
		}

		// Token: 0x060432FA RID: 275194 RVA: 0x01061DD8 File Offset: 0x0105FFD8
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

		// Token: 0x060432FB RID: 275195 RVA: 0x01061E44 File Offset: 0x01060044
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

		// Token: 0x060432FC RID: 275196 RVA: 0x01061EDC File Offset: 0x010600DC
		public static void CreateStaticDefaultValue()
		{
			LevelEventLockMaskModule.IsLockMask = false;
		}

		// Token: 0x060432FD RID: 275197 RVA: 0x01061EE4 File Offset: 0x010600E4
		public static void ResetStaticDefaultValue()
		{
			LevelEventLockMaskModule.IsLockMask = false;
		}

		// Token: 0x04022FC2 RID: 143298
		private static bool IsLockMask;

		// Token: 0x0200CADC RID: 51932
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403D4EB RID: 251115
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
