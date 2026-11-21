using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C20 RID: 15392
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainDialogPanel : UiPanelBase
	{
		// Token: 0x060276EC RID: 161516 RVA: 0x00B0E885 File Offset: 0x00B0CA85
		public SheriffMainDialogPanel(TsUiBlur uiBlur)
		{
			this.UiBlur = uiBlur;
		}

		// Token: 0x060276ED RID: 161517 RVA: 0x00B0E8A0 File Offset: 0x00B0CAA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnNextPage));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060276EE RID: 161518 RVA: 0x00B0EA30 File Offset: 0x00B0CC30
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnCloseSeqEnd), false);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			UUIButtonComponent button2 = base.GetButton(7);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(false);
			}
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if (playerGender == EPlayerGender.None)
			{
				return;
			}
			string resourceId = (playerGender == EPlayerGender.Male) ? "T_SkyEyeRoleMale" : "T_SkyEyeRoleFemale";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		}

		// Token: 0x060276EF RID: 161519 RVA: 0x00B0EB00 File Offset: 0x00B0CD00
		public void Refresh(List<string> stateIds)
		{
			if (stateIds.Count == 0)
			{
				return;
			}
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			this.UiBlur.SetEnableUiBlur(true);
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.SetSelfInteractive(true);
			}
			this.TalkList.Clear();
			this.CurTalkIndex = 0;
			foreach (ActionInfo actionInfo in FlowConfig.Instance.GetFlowStateActions(stateIds[0], int.Parse(stateIds[1]), int.Parse(stateIds[2])))
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					foreach (ITalkItem talkItem in (actionInfo.Params as ShowTalk).TalkItems)
					{
						this.TalkList.Add(talkItem.TidTalk ?? "");
					}
				}
			}
			this.ShowTalk();
		}

		// Token: 0x060276F0 RID: 161520 RVA: 0x00B0EC38 File Offset: 0x00B0CE38
		private void ShowTalk()
		{
			if (this.CurTalkIndex >= this.TalkList.Count)
			{
				if (this.LevelSequencePlayer.IsPlayingSequence("Start"))
				{
					this.LevelSequencePlayer.StopSequenceByKey("Start", false, false);
				}
				this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
				UUIButtonComponent button = base.GetButton(1);
				if (button != null)
				{
					button.SetSelfInteractive(false);
				}
				this.UiBlur.SetEnableUiBlur(false);
				return;
			}
			string key = this.TalkList[this.CurTalkIndex];
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(key);
		}

		// Token: 0x060276F1 RID: 161521 RVA: 0x00B0ECDB File Offset: 0x00B0CEDB
		private void OnClickBtnNextPage()
		{
			this.CurTalkIndex++;
			this.ShowTalk();
		}

		// Token: 0x060276F2 RID: 161522 RVA: 0x00B0ECF1 File Offset: 0x00B0CEF1
		private void OnCloseSeqEnd(string seqName)
		{
			if (seqName == "Close")
			{
				base.SetUiActive(false);
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "SheriffMainViewDialogClose");
			}
		}

		// Token: 0x040157F7 RID: 88055
		protected List<string> TalkList = new List<string>();

		// Token: 0x040157F8 RID: 88056
		protected int CurTalkIndex;

		// Token: 0x040157F9 RID: 88057
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040157FA RID: 88058
		protected TsUiBlur UiBlur;

		// Token: 0x02009840 RID: 38976
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x0402F7CC RID: 194508
			public const int TexRole = 0;

			// Token: 0x0402F7CD RID: 194509
			public const int BtnNextPage = 1;

			// Token: 0x0402F7CE RID: 194510
			public const int PanelTitle = 2;

			// Token: 0x0402F7CF RID: 194511
			public const int TxtTitle = 3;

			// Token: 0x0402F7D0 RID: 194512
			public const int TxtList = 4;

			// Token: 0x0402F7D1 RID: 194513
			public const int PanelButton = 5;

			// Token: 0x0402F7D2 RID: 194514
			public const int BtnLeft = 6;

			// Token: 0x0402F7D3 RID: 194515
			public const int BtnRight = 7;

			// Token: 0x0402F7D4 RID: 194516
			public const int SpriteArrow = 8;
		}
	}
}
