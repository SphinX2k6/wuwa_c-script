using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045BB RID: 17851
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoguePanelLv : UiPanelBase
	{
		// Token: 0x0602CF30 RID: 184112 RVA: 0x00C9221C File Offset: 0x00C9041C
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

		// Token: 0x0602CF31 RID: 184113 RVA: 0x00C92283 File Offset: 0x00C90483
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602CF32 RID: 184114 RVA: 0x00C92296 File Offset: 0x00C90496
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0602CF33 RID: 184115 RVA: 0x00C922B4 File Offset: 0x00C904B4
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0602CF34 RID: 184116 RVA: 0x00C922D2 File Offset: 0x00C904D2
		private void OnActivitySequenceEmitEvent(string name)
		{
			if (name == "LevelChange")
			{
				this.RefreshLv();
			}
		}

		// Token: 0x0602CF35 RID: 184117 RVA: 0x00C922E8 File Offset: 0x00C904E8
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

		// Token: 0x0602CF36 RID: 184118 RVA: 0x00C92344 File Offset: 0x00C90544
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

		// Token: 0x0602CF37 RID: 184119 RVA: 0x00C923A9 File Offset: 0x00C905A9
		public void SetButtonActive(bool bActive)
		{
			base.GetButton(1).SetSelfInteractive(bActive);
		}

		// Token: 0x0602CF38 RID: 184120 RVA: 0x00C923B8 File Offset: 0x00C905B8
		private void OnMenuBtnClick()
		{
			if (this.CheckCanOpenMenu != null && !this.CheckCanOpenMenu())
			{
				return;
			}
			MapRogueController.Instance.OpenRogueMenuView();
		}

		// Token: 0x04018165 RID: 98661
		private int Lv;

		// Token: 0x04018166 RID: 98662
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x04018167 RID: 98663
		[Nullable(2)]
		public Func<bool> CheckCanOpenMenu;

		// Token: 0x04018168 RID: 98664
		private const string LEVEL_CHANGE_SEQ_EVENT = "LevelChange";
	}
}
