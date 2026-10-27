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
	// Token: 0x02004C6F RID: 19567
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainDialogPanel : UiPanelBase
	{
		// Token: 0x06032939 RID: 207161 RVA: 0x00BC9C21 File Offset: 0x00BC7E21
		public SheriffMainDialogPanel(TsUiBlur uiBlur)
		{
			this.UiBlur = uiBlur;
		}

		// Token: 0x0603293A RID: 207162 RVA: 0x00BC9C3C File Offset: 0x00BC7E3C
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

		// Token: 0x0603293B RID: 207163 RVA: 0x00BC9DCC File Offset: 0x00BC7FCC
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

		// Token: 0x0603293C RID: 207164 RVA: 0x00BC9E9C File Offset: 0x00BC809C
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

		// Token: 0x0603293D RID: 207165 RVA: 0x00BC9FD4 File Offset: 0x00BC81D4
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

		// Token: 0x0603293E RID: 207166 RVA: 0x00BCA077 File Offset: 0x00BC8277
		private void OnClickBtnNextPage()
		{
			this.CurTalkIndex++;
			this.ShowTalk();
		}

		// Token: 0x0603293F RID: 207167 RVA: 0x00BCA08D File Offset: 0x00BC828D
		private void OnCloseSeqEnd(string seqName)
		{
			if (seqName == "Close")
			{
				base.SetUiActive(false);
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "SheriffMainViewDialogClose");
			}
		}

		// Token: 0x0401AE9A RID: 110234
		protected List<string> TalkList = new List<string>();

		// Token: 0x0401AE9B RID: 110235
		protected int CurTalkIndex;

		// Token: 0x0401AE9C RID: 110236
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401AE9D RID: 110237
		protected TsUiBlur UiBlur;

		// Token: 0x0200AE22 RID: 44578
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x04034E27 RID: 216615
			public const int TexRole = 0;

			// Token: 0x04034E28 RID: 216616
			public const int BtnNextPage = 1;

			// Token: 0x04034E29 RID: 216617
			public const int PanelTitle = 2;

			// Token: 0x04034E2A RID: 216618
			public const int TxtTitle = 3;

			// Token: 0x04034E2B RID: 216619
			public const int TxtList = 4;

			// Token: 0x04034E2C RID: 216620
			public const int PanelButton = 5;

			// Token: 0x04034E2D RID: 216621
			public const int BtnLeft = 6;

			// Token: 0x04034E2E RID: 216622
			public const int BtnRight = 7;

			// Token: 0x04034E2F RID: 216623
			public const int SpriteArrow = 8;
		}
	}
}
