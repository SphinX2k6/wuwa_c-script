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
	// Token: 0x02004714 RID: 18196
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPauseView : UiViewBase
	{
		// Token: 0x0602DB74 RID: 187252 RVA: 0x00CC9080 File Offset: 0x00CC7280
		public KurotatoPauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DB75 RID: 187253 RVA: 0x00CC90D8 File Offset: 0x00CC72D8
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

		// Token: 0x0602DB76 RID: 187254 RVA: 0x00CC92EF File Offset: 0x00CC74EF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnRoleSaveStateUpdate, new Action(this.OnRoleSaveStateUpdate));
		}

		// Token: 0x0602DB77 RID: 187255 RVA: 0x00CC930D File Offset: 0x00CC750D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnRoleSaveStateUpdate, new Action(this.OnRoleSaveStateUpdate));
		}

		// Token: 0x0602DB78 RID: 187256 RVA: 0x00CC932C File Offset: 0x00CC752C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPauseView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPauseView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB79 RID: 187257 RVA: 0x00CC9370 File Offset: 0x00CC7570
		private UniTask CreateCaption()
		{
			KurotatoPauseView.<CreateCaption>d__12 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<KurotatoPauseView.<CreateCaption>d__12>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB7A RID: 187258 RVA: 0x00CC93B3 File Offset: 0x00CC75B3
		protected override void OnBeforeShow()
		{
			this.RefreshRoleInfo();
			this.RefreshCurrencyNum();
			this.RefreshWaveInfo();
			this.RefreshSaveStateButtons();
			this.SetupButtonCallbacks();
		}

		// Token: 0x0602DB7B RID: 187259 RVA: 0x00CC93D4 File Offset: 0x00CC75D4
		private void RefreshRoleInfo()
		{
			int roleId = KurotatoModel.Instance.GetRoleId();
			RoleDataBase roleDataByKurotatoRoleId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(roleId);
			base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value.RoleHeadIconCircle, base.GetTexture(1), null, null);
			base.GetText(2).SetText(KurotatoModel.Instance.BattleData.GetRoleLevel().ToString(), true);
		}

		// Token: 0x0602DB7C RID: 187260 RVA: 0x00CC9458 File Offset: 0x00CC7658
		private void RefreshCurrencyNum()
		{
			base.GetText(4).SetText(KurotatoModel.Instance.BattleData.GetCurrencyCount().ToString(), true);
		}

		// Token: 0x0602DB7D RID: 187261 RVA: 0x00CC948C File Offset: 0x00CC768C
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

		// Token: 0x0602DB7E RID: 187262 RVA: 0x00CC95F4 File Offset: 0x00CC77F4
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

		// Token: 0x0602DB7F RID: 187263 RVA: 0x00CC96AC File Offset: 0x00CC78AC
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

		// Token: 0x0602DB80 RID: 187264 RVA: 0x00CC9758 File Offset: 0x00CC7958
		private void OnRoleSaveStateUpdate()
		{
			this.RefreshSaveStateButtons();
		}

		// Token: 0x0602DB81 RID: 187265 RVA: 0x00CC9760 File Offset: 0x00CC7960
		private void OnClickBtnInfo()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoTabMainView, null, null);
		}

		// Token: 0x04018718 RID: 100120
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x04018719 RID: 100121
		private readonly PauseButtonItem BtnSaveFixedWave = new PauseButtonItem();

		// Token: 0x0401871A RID: 100122
		private readonly PauseButtonItem BtnFixedWaveSaved = new PauseButtonItem();

		// Token: 0x0401871B RID: 100123
		private readonly PauseButtonItem BtnRestart = new PauseButtonItem();

		// Token: 0x0401871C RID: 100124
		private readonly PauseButtonItem BtnSaveAndExit = new PauseButtonItem();

		// Token: 0x0401871D RID: 100125
		private readonly PauseButtonItem BtnSettle = new PauseButtonItem();

		// Token: 0x0200A33F RID: 41791
		[NullableContext(0)]
		private enum EComps
		{
			// Token: 0x040329D7 RID: 207319
			Caption,
			// Token: 0x040329D8 RID: 207320
			TextureRole,
			// Token: 0x040329D9 RID: 207321
			TextLevel,
			// Token: 0x040329DA RID: 207322
			TextureCurrency,
			// Token: 0x040329DB RID: 207323
			TextCurrency,
			// Token: 0x040329DC RID: 207324
			TextWave,
			// Token: 0x040329DD RID: 207325
			TextNextEliteWave,
			// Token: 0x040329DE RID: 207326
			BtnSaveFixedWave,
			// Token: 0x040329DF RID: 207327
			BtnFixedWaveSaved,
			// Token: 0x040329E0 RID: 207328
			BtnRestart,
			// Token: 0x040329E1 RID: 207329
			BtnSaveAndExit,
			// Token: 0x040329E2 RID: 207330
			BtnSettle,
			// Token: 0x040329E3 RID: 207331
			BtnInfo
		}
	}
}
