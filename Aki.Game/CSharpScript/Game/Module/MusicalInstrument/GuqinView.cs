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
	// Token: 0x0200536A RID: 21354
	[NullableContext(1)]
	[Nullable(0)]
	public class GuqinView : MusicalInstrumentBaseView
	{
		// Token: 0x060368FC RID: 223484 RVA: 0x00CEB9DB File Offset: 0x00CE9BDB
		public GuqinView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060368FD RID: 223485 RVA: 0x00CEBA01 File Offset: 0x00CE9C01
		protected override EInstrumentType GetMusicalInstrumentType()
		{
			return EInstrumentType.ChineseZither;
		}

		// Token: 0x060368FE RID: 223486 RVA: 0x00CEBA04 File Offset: 0x00CE9C04
		[PreserveBaseOverrides]
		protected new virtual GuqinSubModel GetSubModel()
		{
			return (GuqinSubModel)MusicalInstrumentModel.Instance.GetSubModel(EInstrumentType.ChineseZither);
		}

		// Token: 0x060368FF RID: 223487 RVA: 0x00CEBA18 File Offset: 0x00CE9C18
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

		// Token: 0x06036900 RID: 223488 RVA: 0x00CEBB8C File Offset: 0x00CE9D8C
		protected override UniTask OnBeforeStartAsync()
		{
			GuqinView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuqinView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036901 RID: 223489 RVA: 0x00CEBBD0 File Offset: 0x00CE9DD0
		private UniTask CreateKeyItems()
		{
			GuqinView.<CreateKeyItems>d__12 <CreateKeyItems>d__;
			<CreateKeyItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateKeyItems>d__.<>4__this = this;
			<CreateKeyItems>d__.<>1__state = -1;
			<CreateKeyItems>d__.<>t__builder.Start<GuqinView.<CreateKeyItems>d__12>(ref <CreateKeyItems>d__);
			return <CreateKeyItems>d__.<>t__builder.Task;
		}

		// Token: 0x06036902 RID: 223490 RVA: 0x00CEBC14 File Offset: 0x00CE9E14
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

		// Token: 0x06036903 RID: 223491 RVA: 0x00CEBCA7 File Offset: 0x00CE9EA7
		private void AddEvents()
		{
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x06036904 RID: 223492 RVA: 0x00CEBCC5 File Offset: 0x00CE9EC5
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x06036905 RID: 223493 RVA: 0x00CEBCE4 File Offset: 0x00CE9EE4
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

		// Token: 0x06036906 RID: 223494 RVA: 0x00CEBD44 File Offset: 0x00CE9F44
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

		// Token: 0x06036907 RID: 223495 RVA: 0x00CEBE34 File Offset: 0x00CEA034
		private GuqinQteItem InitGuqinQteItem()
		{
			return new GuqinQteItem
			{
				GetKeyConfigCallback = new Func<int, int, GuqinKeyConfig>(this.GetKeyConfigCallback)
			};
		}

		// Token: 0x06036908 RID: 223496 RVA: 0x00CEBE4D File Offset: 0x00CEA04D
		[NullableContext(2)]
		private GuqinKeyConfig GetKeyConfigCallback(int rowIndex, int columnIndex)
		{
			return this.GetSubModel().GetKeyConfig(rowIndex, columnIndex);
		}

		// Token: 0x06036909 RID: 223497 RVA: 0x00CEBE5C File Offset: 0x00CEA05C
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

		// Token: 0x0603690A RID: 223498 RVA: 0x00CEBF40 File Offset: 0x00CEA140
		private void OnCloseBtnClick()
		{
			base.Exit();
		}

		// Token: 0x0603690B RID: 223499 RVA: 0x00CEBF48 File Offset: 0x00CEA148
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(662);
		}

		// Token: 0x0603690C RID: 223500 RVA: 0x00CEBF59 File Offset: 0x00CEA159
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

		// Token: 0x0603690D RID: 223501 RVA: 0x00CEBF70 File Offset: 0x00CEA170
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

		// Token: 0x0603690E RID: 223502 RVA: 0x00CEBFCC File Offset: 0x00CEA1CC
		public void OnGamepadChangePitch(EZitherGamepadPitchType pitchType)
		{
			for (int i = 0; i < this.KeyGroupViews.Count; i++)
			{
				this.KeyGroupViews[i].Refresh(i == (int)pitchType);
			}
		}

		// Token: 0x0603690F RID: 223503 RVA: 0x00CEC004 File Offset: 0x00CEA204
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

		// Token: 0x06036910 RID: 223504 RVA: 0x00CEC044 File Offset: 0x00CEA244
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

		// Token: 0x06036911 RID: 223505 RVA: 0x00CEC09F File Offset: 0x00CEA29F
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
		}

		// Token: 0x0401CD7E RID: 118142
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CD7F RID: 118143
		[Nullable(2)]
		private GuqinModeToggleItem FundamentalToneToggleItem;

		// Token: 0x0401CD80 RID: 118144
		[Nullable(2)]
		private GuqinModeToggleItem OverToneToggleItem;

		// Token: 0x0401CD81 RID: 118145
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GuqinQteItem, MusicalInstrumentQteItemData> QteLayout;

		// Token: 0x0401CD82 RID: 118146
		private EZitherAudioType AudioType = EZitherAudioType.FundamentalTone;

		// Token: 0x0401CD83 RID: 118147
		private readonly List<ZitherKeyGroupView> KeyGroupViews = new List<ZitherKeyGroupView>();

		// Token: 0x0401CD84 RID: 118148
		private readonly List<EZitherGamepadPitchType> HeldPitchTypes = new List<EZitherGamepadPitchType>();

		// Token: 0x0200B5E3 RID: 46563
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037184 RID: 225668
			CaptionItem,
			// Token: 0x04037185 RID: 225669
			NormalMode,
			// Token: 0x04037186 RID: 225670
			SpecialMode,
			// Token: 0x04037187 RID: 225671
			HighGroup,
			// Token: 0x04037188 RID: 225672
			MiddleGroup,
			// Token: 0x04037189 RID: 225673
			LowGroup,
			// Token: 0x0403718A RID: 225674
			PnlTopQte,
			// Token: 0x0403718B RID: 225675
			PnlQteLayout,
			// Token: 0x0403718C RID: 225676
			QteKeyItem,
			// Token: 0x0403718D RID: 225677
			BtnVisible
		}
	}
}
