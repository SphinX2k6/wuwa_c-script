using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Pause
{
	// Token: 0x0200573D RID: 22333
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPauseView : UiViewBase
	{
		// Token: 0x06038C64 RID: 232548 RVA: 0x00D7A9D0 File Offset: 0x00D78BD0
		public KurotatoPauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038C65 RID: 232549 RVA: 0x00D7AA28 File Offset: 0x00D78C28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickBtnInfo));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C66 RID: 232550 RVA: 0x00D7AC3F File Offset: 0x00D78E3F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnRoleSaveStateUpdate, new Action(this.OnRoleSaveStateUpdate));
		}

		// Token: 0x06038C67 RID: 232551 RVA: 0x00D7AC5D File Offset: 0x00D78E5D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnRoleSaveStateUpdate, new Action(this.OnRoleSaveStateUpdate));
		}

		// Token: 0x06038C68 RID: 232552 RVA: 0x00D7AC7C File Offset: 0x00D78E7C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPauseView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPauseView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C69 RID: 232553 RVA: 0x00D7ACC0 File Offset: 0x00D78EC0
		private UniTask CreateCaption()
		{
			KurotatoPauseView.<CreateCaption>d__12 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<KurotatoPauseView.<CreateCaption>d__12>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06038C6A RID: 232554 RVA: 0x00D7AD03 File Offset: 0x00D78F03
		protected override void OnBeforeShow()
		{
			this.RefreshRoleInfo();
			this.RefreshCurrencyNum();
			this.RefreshWaveInfo();
			this.RefreshSaveStateButtons();
			this.SetupButtonCallbacks();
		}

		// Token: 0x06038C6B RID: 232555 RVA: 0x00D7AD24 File Offset: 0x00D78F24
		private void RefreshRoleInfo()
		{
			int roleId = KurotatoModel.Instance.GetRoleId();
			RoleDataBase roleDataByKurotatoRoleId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(roleId);
			base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value.RoleHeadIconCircle, base.GetTexture(1), null, null);
			base.GetText(2).SetText(KurotatoModel.Instance.BattleData.GetRoleLevel().ToString(), true);
		}

		// Token: 0x06038C6C RID: 232556 RVA: 0x00D7ADA8 File Offset: 0x00D78FA8
		private void RefreshCurrencyNum()
		{
			base.GetText(4).SetText(KurotatoModel.Instance.BattleData.GetCurrencyCount().ToString(), true);
		}

		// Token: 0x06038C6D RID: 232557 RVA: 0x00D7ADDC File Offset: 0x00D78FDC
		private void RefreshWaveInfo()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			KurotatoConfig instance2 = KurotatoConfig.Instance;
			int curLevelId = instance.GetCurLevelId();
			int batch = instance.BattleData.GetBatch();
			List<KurotatoWave> waveByLevelId = instance2.GetWaveByLevelId(curLevelId);
			bool flag = false;
			foreach (KurotatoWave kurotatoWave in waveByLevelId)
			{
				if (kurotatoWave.Wave == batch)
				{
					flag = (kurotatoWave.WaveType == 1);
					break;
				}
			}
			if (flag)
			{
				base.GetText(5).ShowTextNew("Kurotato_Special_Boss");
			}
			else
			{
				UUIText text = base.GetText(5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(instance.BattleData.GetBatch());
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(instance.BattleData.GetMaxBatch());
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			int num = 0;
			foreach (KurotatoWave kurotatoWave2 in waveByLevelId)
			{
				if (kurotatoWave2.Wave > batch && kurotatoWave2.IsPowerWave)
				{
					num = kurotatoWave2.Wave;
					break;
				}
			}
			base.GetText(6).SetText((num > 0) ? num.ToString() : "-", true);
		}

		// Token: 0x06038C6E RID: 232558 RVA: 0x00D7AF44 File Offset: 0x00D79144
		private void SetupButtonCallbacks()
		{
			this.BtnSaveFixedWave.SetClickCb(delegate
			{
				if (KurotatoModel.Instance.GetRoleSaveInstInfos().Count > 1 && KurotatoModel.Instance.GetRoleSaveInstInfos()[1] != null)
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KurotatoSaveNotifyConfirm);
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					return;
				}
				KurotatoController.Instance.RequestKurotatoRoleRecord().Forget<bool>();
			});
			this.BtnRestart.SetClickCb(delegate
			{
				KurotatoController.Instance.RequestKurotatoReChallenge(true).Forget<bool>();
			});
			this.BtnSaveAndExit.SetClickCb(delegate
			{
				if (KurotatoModel.Instance.BattleData.GetBatch() <= 1)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("KurotatoSaveLockedTip", Array.Empty<object>());
					return;
				}
				KurotatoController.Instance.LeaveInstanceDungeon();
			});
			this.BtnSettle.SetClickCb(delegate
			{
				KurotatoController.Instance.RequestKurotatoSettlement().Forget<bool>();
			});
		}

		// Token: 0x06038C6F RID: 232559 RVA: 0x00D7AFFC File Offset: 0x00D791FC
		private void RefreshSaveStateButtons()
		{
			int curLevelId = KurotatoModel.Instance.GetCurLevelId();
			KurotatoLevel? kurotatoLevel;
			bool flag = ((KurotatoConfig.Instance.GetLevelConfig(curLevelId) != null) ? new int?(kurotatoLevel.GetValueOrDefault().Difficulty) : null).GetValueOrDefault() == 3;
			KurotatoRoleSaveState roleSaveState = KurotatoModel.Instance.GetRoleSaveState();
			bool flag2 = roleSaveState == KurotatoRoleSaveState.NotSaved;
			bool flag3 = roleSaveState == KurotatoRoleSaveState.ClientSaved || roleSaveState == KurotatoRoleSaveState.ServerSaved;
			UUIItem rootItem = this.BtnSaveFixedWave.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetUIActive(flag2 && flag);
			}
			UUIItem rootItem2 = this.BtnFixedWaveSaved.GetRootItem();
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetUIActive(flag3 && flag);
		}

		// Token: 0x06038C70 RID: 232560 RVA: 0x00D7B0A8 File Offset: 0x00D792A8
		private void OnRoleSaveStateUpdate()
		{
			this.RefreshSaveStateButtons();
		}

		// Token: 0x06038C71 RID: 232561 RVA: 0x00D7B0B0 File Offset: 0x00D792B0
		private void OnClickBtnInfo()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoTabMainView, null, null);
		}

		// Token: 0x0401DC82 RID: 121986
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x0401DC83 RID: 121987
		private readonly PauseButtonItem BtnSaveFixedWave = new PauseButtonItem();

		// Token: 0x0401DC84 RID: 121988
		private readonly PauseButtonItem BtnFixedWaveSaved = new PauseButtonItem();

		// Token: 0x0401DC85 RID: 121989
		private readonly PauseButtonItem BtnRestart = new PauseButtonItem();

		// Token: 0x0401DC86 RID: 121990
		private readonly PauseButtonItem BtnSaveAndExit = new PauseButtonItem();

		// Token: 0x0401DC87 RID: 121991
		private readonly PauseButtonItem BtnSettle = new PauseButtonItem();

		// Token: 0x0200B91E RID: 47390
		[NullableContext(0)]
		private enum EComps
		{
			// Token: 0x04037FC7 RID: 229319
			Caption,
			// Token: 0x04037FC8 RID: 229320
			TextureRole,
			// Token: 0x04037FC9 RID: 229321
			TextLevel,
			// Token: 0x04037FCA RID: 229322
			TextureCurrency,
			// Token: 0x04037FCB RID: 229323
			TextCurrency,
			// Token: 0x04037FCC RID: 229324
			TextWave,
			// Token: 0x04037FCD RID: 229325
			TextNextEliteWave,
			// Token: 0x04037FCE RID: 229326
			BtnSaveFixedWave,
			// Token: 0x04037FCF RID: 229327
			BtnFixedWaveSaved,
			// Token: 0x04037FD0 RID: 229328
			BtnRestart,
			// Token: 0x04037FD1 RID: 229329
			BtnSaveAndExit,
			// Token: 0x04037FD2 RID: 229330
			BtnSettle,
			// Token: 0x04037FD3 RID: 229331
			BtnInfo
		}
	}
}
