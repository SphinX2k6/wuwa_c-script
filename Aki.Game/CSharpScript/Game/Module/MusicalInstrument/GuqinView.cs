using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200434D RID: 17229
	[NullableContext(1)]
	[Nullable(0)]
	public class GuqinView : MusicalInstrumentBaseView
	{
		// Token: 0x0602B842 RID: 178242 RVA: 0x00C3A867 File Offset: 0x00C38A67
		public GuqinView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602B843 RID: 178243 RVA: 0x00C3A88D File Offset: 0x00C38A8D
		protected override EInstrumentType GetMusicalInstrumentType()
		{
			return EInstrumentType.ChineseZither;
		}

		// Token: 0x0602B844 RID: 178244 RVA: 0x00C3A890 File Offset: 0x00C38A90
		[PreserveBaseOverrides]
		protected new virtual GuqinSubModel GetSubModel()
		{
			return (GuqinSubModel)MusicalInstrumentModel.Instance.GetSubModel(EInstrumentType.ChineseZither);
		}

		// Token: 0x0602B845 RID: 178245 RVA: 0x00C3A8A4 File Offset: 0x00C38AA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602B846 RID: 178246 RVA: 0x00C3AA18 File Offset: 0x00C38C18
		protected override UniTask OnBeforeStartAsync()
		{
			GuqinView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuqinView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B847 RID: 178247 RVA: 0x00C3AA5C File Offset: 0x00C38C5C
		private UniTask CreateKeyItems()
		{
			GuqinView.<CreateKeyItems>d__12 <CreateKeyItems>d__;
			<CreateKeyItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateKeyItems>d__.<>4__this = this;
			<CreateKeyItems>d__.<>1__state = -1;
			<CreateKeyItems>d__.<>t__builder.Start<GuqinView.<CreateKeyItems>d__12>(ref <CreateKeyItems>d__);
			return <CreateKeyItems>d__.<>t__builder.Task;
		}

		// Token: 0x0602B848 RID: 178248 RVA: 0x00C3AAA0 File Offset: 0x00C38CA0
		protected override void OnStart()
		{
			this.AddEvents();
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnHelpBtnClick));
			GuqinModeToggleItem fundamentalToneToggleItem = this.FundamentalToneToggleItem;
			if (fundamentalToneToggleItem != null)
			{
				fundamentalToneToggleItem.SetToggleState(EToggleState.ETT_Checked, true);
			}
			this.InitQteMode();
			if (Info.Instance.IsInGamepad())
			{
				this.OnGamepadChangePitch(EZitherGamepadPitchType.Middle);
			}
		}

		// Token: 0x0602B849 RID: 178249 RVA: 0x00C3AB33 File Offset: 0x00C38D33
		private void AddEvents()
		{
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x0602B84A RID: 178250 RVA: 0x00C3AB51 File Offset: 0x00C38D51
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x0602B84B RID: 178251 RVA: 0x00C3AB70 File Offset: 0x00C38D70
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (now == EInputControllerMainType.Gamepad)
			{
				this.OnGamepadChangePitch(EZitherGamepadPitchType.Middle);
				return;
			}
			foreach (ZitherKeyGroupView zitherKeyGroupView in this.KeyGroupViews)
			{
				zitherKeyGroupView.Refresh(true);
			}
		}

		// Token: 0x0602B84C RID: 178252 RVA: 0x00C3ABD0 File Offset: 0x00C38DD0
		private void InitQteMode()
		{
			MusicalInstrumentQteData qteData = this.GetSubModel().GetQteData();
			if (qteData != null)
			{
				PopupCaptionItem captionItem = this.CaptionItem;
				if (captionItem != null)
				{
					captionItem.SetUiActive(false);
				}
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(2);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				this.QteLayout = new GenericLayout<GuqinQteItem, MusicalInstrumentQteItemData>(base.GetLayoutBase(7), new Func<GuqinQteItem>(this.InitGuqinQteItem), (AUIBaseActor)base.GetItem(8).GetOwner(), false, true);
				GenericLayout<GuqinQteItem, MusicalInstrumentQteItemData> qteLayout = this.QteLayout;
				if (qteLayout != null)
				{
					qteLayout.RefreshByData(qteData.ItemDataList, null, false);
				}
				base.FocusCurrentQte();
				return;
			}
			UUIItem item4 = base.GetItem(6);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			UUIItem item5 = base.GetItem(1);
			if (item5 != null)
			{
				item5.SetUIActive(true);
			}
			UUIItem item6 = base.GetItem(2);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(true);
		}

		// Token: 0x0602B84D RID: 178253 RVA: 0x00C3ACC0 File Offset: 0x00C38EC0
		private GuqinQteItem InitGuqinQteItem()
		{
			return new GuqinQteItem
			{
				GetKeyConfigCallback = new Func<int, int, GuqinKeyConfig>(this.GetKeyConfigCallback)
			};
		}

		// Token: 0x0602B84E RID: 178254 RVA: 0x00C3ACD9 File Offset: 0x00C38ED9
		[NullableContext(2)]
		private GuqinKeyConfig GetKeyConfigCallback(int rowIndex, int columnIndex)
		{
			return this.GetSubModel().GetKeyConfig(rowIndex, columnIndex);
		}

		// Token: 0x0602B84F RID: 178255 RVA: 0x00C3ACE8 File Offset: 0x00C38EE8
		private void OnSelectAudioType(EZitherAudioType audioType)
		{
			this.AudioType = audioType;
			if (this.AudioType == EZitherAudioType.FundamentalTone)
			{
				GuqinModeToggleItem overToneToggleItem = this.OverToneToggleItem;
				if (overToneToggleItem != null)
				{
					overToneToggleItem.SetToggleState(EToggleState.ETT_UnChecked, true);
				}
			}
			else
			{
				GuqinModeToggleItem fundamentalToneToggleItem = this.FundamentalToneToggleItem;
				if (fundamentalToneToggleItem != null)
				{
					fundamentalToneToggleItem.SetToggleState(EToggleState.ETT_UnChecked, true);
				}
			}
			foreach (List<MusicalInstrumentKeyItem> list in this.KeyItems)
			{
				foreach (MusicalInstrumentKeyItem musicalInstrumentKeyItem in list)
				{
					((GuqinKeyItem)musicalInstrumentKeyItem).RefreshMode(audioType);
				}
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0602B850 RID: 178256 RVA: 0x00C3ADCC File Offset: 0x00C38FCC
		private void OnCloseBtnClick()
		{
			base.Exit();
		}

		// Token: 0x0602B851 RID: 178257 RVA: 0x00C3ADD4 File Offset: 0x00C38FD4
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(662);
		}

		// Token: 0x0602B852 RID: 178258 RVA: 0x00C3ADE5 File Offset: 0x00C38FE5
		protected override void OnQtePerformance(int rowIndex, int columnIndex, bool success)
		{
			if (success)
			{
				GenericLayout<GuqinQteItem, MusicalInstrumentQteItemData> qteLayout = this.QteLayout;
				if (qteLayout == null)
				{
					return;
				}
				qteLayout.RefreshWithoutDataSync();
			}
		}

		// Token: 0x0602B853 RID: 178259 RVA: 0x00C3ADFC File Offset: 0x00C38FFC
		protected override void PostAudioEventByIndex(int rowIndex, int columnIndex)
		{
			GuqinKeyConfig keyConfig = this.GetSubModel().GetKeyConfig(rowIndex, columnIndex);
			if (keyConfig == null)
			{
				return;
			}
			string @event = (this.AudioType == EZitherAudioType.FundamentalTone) ? keyConfig.FundamentalToneAudioEvent : keyConfig.OverToneAudioEvent;
			AudioSystem.Instance.PostEvent(@event, Global.BaseCharacter, null);
			MusicalInstrumentController.Instance.SyncServerRequest(@event);
		}

		// Token: 0x0602B854 RID: 178260 RVA: 0x00C3AE58 File Offset: 0x00C39058
		public void OnGamepadChangePitch(EZitherGamepadPitchType pitchType)
		{
			for (int i = 0; i < this.KeyGroupViews.Count; i++)
			{
				this.KeyGroupViews[i].Refresh(i == (int)pitchType);
			}
		}

		// Token: 0x0602B855 RID: 178261 RVA: 0x00C3AE90 File Offset: 0x00C39090
		public void OnGamepadPressPitch(EZitherGamepadPitchType pitchType)
		{
			int num = this.HeldPitchTypes.IndexOf(pitchType);
			if (num >= 0)
			{
				this.HeldPitchTypes.RemoveAt(num);
			}
			this.HeldPitchTypes.Add(pitchType);
			this.OnGamepadChangePitch(pitchType);
		}

		// Token: 0x0602B856 RID: 178262 RVA: 0x00C3AED0 File Offset: 0x00C390D0
		public void OnGamepadReleasePitch(EZitherGamepadPitchType pitchType)
		{
			int num = this.HeldPitchTypes.IndexOf(pitchType);
			if (num >= 0)
			{
				this.HeldPitchTypes.RemoveAt(num);
			}
			EZitherGamepadPitchType pitchType2 = (this.HeldPitchTypes.Count > 0) ? this.HeldPitchTypes[this.HeldPitchTypes.Count - 1] : EZitherGamepadPitchType.Middle;
			this.OnGamepadChangePitch(pitchType2);
		}

		// Token: 0x0602B857 RID: 178263 RVA: 0x00C3AF2B File Offset: 0x00C3912B
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
		}

		// Token: 0x04017814 RID: 96276
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017815 RID: 96277
		[Nullable(2)]
		private GuqinModeToggleItem FundamentalToneToggleItem;

		// Token: 0x04017816 RID: 96278
		[Nullable(2)]
		private GuqinModeToggleItem OverToneToggleItem;

		// Token: 0x04017817 RID: 96279
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GuqinQteItem, MusicalInstrumentQteItemData> QteLayout;

		// Token: 0x04017818 RID: 96280
		private EZitherAudioType AudioType = EZitherAudioType.FundamentalTone;

		// Token: 0x04017819 RID: 96281
		private readonly List<ZitherKeyGroupView> KeyGroupViews = new List<ZitherKeyGroupView>();

		// Token: 0x0401781A RID: 96282
		private readonly List<EZitherGamepadPitchType> HeldPitchTypes = new List<EZitherGamepadPitchType>();

		// Token: 0x0200A01A RID: 40986
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04031BD7 RID: 203735
			CaptionItem,
			// Token: 0x04031BD8 RID: 203736
			NormalMode,
			// Token: 0x04031BD9 RID: 203737
			SpecialMode,
			// Token: 0x04031BDA RID: 203738
			HighGroup,
			// Token: 0x04031BDB RID: 203739
			MiddleGroup,
			// Token: 0x04031BDC RID: 203740
			LowGroup,
			// Token: 0x04031BDD RID: 203741
			PnlTopQte,
			// Token: 0x04031BDE RID: 203742
			PnlQteLayout,
			// Token: 0x04031BDF RID: 203743
			QteKeyItem,
			// Token: 0x04031BE0 RID: 203744
			BtnVisible
		}
	}
}
