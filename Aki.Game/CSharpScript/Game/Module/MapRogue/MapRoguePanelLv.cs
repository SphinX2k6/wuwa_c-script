using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055E5 RID: 21989
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoguePanelLv : UiPanelBase
	{
		// Token: 0x06038032 RID: 229426 RVA: 0x00D444D4 File Offset: 0x00D426D4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnMenuBtnClick))
			};
		}

		// Token: 0x06038033 RID: 229427 RVA: 0x00D4453B File Offset: 0x00D4273B
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06038034 RID: 229428 RVA: 0x00D4454E File Offset: 0x00D4274E
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06038035 RID: 229429 RVA: 0x00D4456C File Offset: 0x00D4276C
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06038036 RID: 229430 RVA: 0x00D4458A File Offset: 0x00D4278A
		private void OnActivitySequenceEmitEvent(string name)
		{
			if (name == "LevelChange")
			{
				this.RefreshLv();
			}
		}

		// Token: 0x06038037 RID: 229431 RVA: 0x00D445A0 File Offset: 0x00D427A0
		private void RefreshLv()
		{
			UUIArtText artText = base.GetArtText(0);
			string text;
			if (this.Lv < 10)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Lv);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text = this.Lv.ToString();
			}
			artText.SetText(text);
		}

		// Token: 0x06038038 RID: 229432 RVA: 0x00D445FC File Offset: 0x00D427FC
		public void SetLv(int lv, bool needAnim = false)
		{
			if (this.Lv == lv)
			{
				return;
			}
			this.Lv = lv;
			if (!needAnim)
			{
				this.RefreshLv();
				return;
			}
			string text = "LevelUp";
			if (this.LevelSequencePlayerInstance.GetCurrentSequence() == text)
			{
				this.LevelSequencePlayerInstance.ReplaySequenceByKey(text);
				return;
			}
			this.LevelSequencePlayerInstance.PlayLevelSequenceByName(text, false, null, false);
		}

		// Token: 0x06038039 RID: 229433 RVA: 0x00D44661 File Offset: 0x00D42861
		public void SetButtonActive(bool bActive)
		{
			base.GetButton(1).SetSelfInteractive(bActive);
		}

		// Token: 0x0603803A RID: 229434 RVA: 0x00D44670 File Offset: 0x00D42870
		private void OnMenuBtnClick()
		{
			if (this.CheckCanOpenMenu != null && !this.CheckCanOpenMenu())
			{
				return;
			}
			MapRogueController.Instance.OpenRogueMenuView();
		}

		// Token: 0x0401D6DA RID: 120538
		private int Lv;

		// Token: 0x0401D6DB RID: 120539
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x0401D6DC RID: 120540
		[Nullable(2)]
		public Func<bool> CheckCanOpenMenu;

		// Token: 0x0401D6DD RID: 120541
		private const string LEVEL_CHANGE_SEQ_EVENT = "LevelChange";
	}
}
