using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Pause
{
	// Token: 0x0200573F RID: 22335
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupSaveView : UiViewBase, IExtraUiPopFrameType
	{
		// Token: 0x06038C77 RID: 232567 RVA: 0x00D7B195 File Offset: 0x00D79395
		public KurotatoPopupSaveView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038C78 RID: 232568 RVA: 0x00D7B1D4 File Offset: 0x00D793D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnHelp));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C79 RID: 232569 RVA: 0x00D7B364 File Offset: 0x00D79564
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPopupSaveView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPopupSaveView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C7A RID: 232570 RVA: 0x00D7B3A7 File Offset: 0x00D795A7
		protected override void OnStart()
		{
			this.RefreshSaveState();
			this.RefreshOverwriteConfirmPanel();
		}

		// Token: 0x06038C7B RID: 232571 RVA: 0x00D7B3B8 File Offset: 0x00D795B8
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.SetBackBtnShowState(this.Config.Value.NeedClose);
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 != null)
			{
				childPopView2.PopItem.SetMaskResponsibleState(this.Config.Value.NeedMaskClose);
			}
			IUiPopFrameInterface childPopView3 = this.ChildPopView;
			if (childPopView3 == null)
			{
				return;
			}
			childPopView3.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
		}

		// Token: 0x06038C7C RID: 232572 RVA: 0x00D7B433 File Offset: 0x00D79633
		protected override void OnAfterShow()
		{
			Action afterShowFunction = this.ConfirmBoxData.GetAfterShowFunction();
			if (afterShowFunction == null)
			{
				return;
			}
			afterShowFunction();
		}

		// Token: 0x06038C7D RID: 232573 RVA: 0x00D7B44A File Offset: 0x00D7964A
		protected override void OnBeforeHide()
		{
			if (this.LastHide)
			{
				ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
				if (confirmBoxData == null)
				{
					return;
				}
				Action beforePlayCloseFunction = confirmBoxData.BeforePlayCloseFunction;
				if (beforePlayCloseFunction == null)
				{
					return;
				}
				beforePlayCloseFunction();
			}
		}

		// Token: 0x06038C7E RID: 232574 RVA: 0x00D7B470 File Offset: 0x00D79670
		protected override void OnBeforeDestroy()
		{
			this.ResetButtonList();
			this.HandleSelectedIndexWhenClose();
			Action action;
			if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action))
			{
				action();
			}
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			if (confirmBoxData == null)
			{
				return;
			}
			Action destroyFunction = confirmBoxData.DestroyFunction;
			if (destroyFunction == null)
			{
				return;
			}
			destroyFunction();
		}

		// Token: 0x06038C7F RID: 232575 RVA: 0x00D7B4CC File Offset: 0x00D796CC
		private void RefreshSaveState()
		{
			List<KurotatoInstInfo> roleSaveInstInfos = KurotatoModel.Instance.GetRoleSaveInstInfos();
			KurotatoInstInfo kurotatoInstInfo = (roleSaveInstInfos.Count > 0) ? roleSaveInstInfos[0] : null;
			KurotatoInstInfo kurotatoInstInfo2 = (roleSaveInstInfos.Count > 1) ? roleSaveInstInfos[1] : null;
			this.HasOldSave = (kurotatoInstInfo2 != null);
			KurotatoSaveArchivePanel newSavePanel = this.NewSavePanel;
			KurotatoSaveData saveData;
			if (kurotatoInstInfo == null)
			{
				saveData = null;
			}
			else
			{
				KurotatoSaveData kurotatoSaveData = new KurotatoSaveData();
				kurotatoSaveData.SaveTimestamp = kurotatoInstInfo.SaveTimestamp;
				kurotatoSaveData.RoleLevel = kurotatoInstInfo.RoleLevel;
				saveData = kurotatoSaveData;
				kurotatoSaveData.WaveNum = kurotatoInstInfo.CurWave;
			}
			newSavePanel.RefreshSaveInfo(saveData, 0);
			KurotatoSaveArchivePanel oldSavePanel = this.OldSavePanel;
			KurotatoSaveData saveData2;
			if (kurotatoInstInfo2 == null)
			{
				saveData2 = null;
			}
			else
			{
				KurotatoSaveData kurotatoSaveData2 = new KurotatoSaveData();
				kurotatoSaveData2.SaveTimestamp = kurotatoInstInfo2.SaveTimestamp;
				kurotatoSaveData2.RoleLevel = kurotatoInstInfo2.RoleLevel;
				saveData2 = kurotatoSaveData2;
				kurotatoSaveData2.WaveNum = kurotatoInstInfo2.CurWave;
			}
			oldSavePanel.RefreshSaveInfo(saveData2, 1);
		}

		// Token: 0x06038C80 RID: 232576 RVA: 0x00D7B58C File Offset: 0x00D7978C
		private void RefreshOverwriteConfirmPanel()
		{
			base.GetItem(5).SetUIActive(this.HasOldSave);
			UUIItem uuiitem = base.GetButton(7).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(this.HasOldSave);
		}

		// Token: 0x06038C81 RID: 232577 RVA: 0x00D7B5CF File Offset: 0x00D797CF
		private bool IsOverwriteConfirmChecked()
		{
			return base.GetExtendToggle(6).ToggleState == EToggleState.ETT_Checked;
		}

		// Token: 0x06038C82 RID: 232578 RVA: 0x00D7B5E0 File Offset: 0x00D797E0
		private void OnClose()
		{
			this.SelectedIndex = -1;
			base.CloseMe(delegate(bool _)
			{
				Action closeFunction = this.ConfirmBoxData.GetCloseFunction();
				if (closeFunction == null)
				{
					return;
				}
				closeFunction();
			});
		}

		// Token: 0x06038C83 RID: 232579 RVA: 0x00D7B5FB File Offset: 0x00D797FB
		private void HandleSelectedIndexWhenClose()
		{
			if (this.SelectedIndex == -1)
			{
				this.SelectedIndex = 0;
			}
		}

		// Token: 0x06038C84 RID: 232580 RVA: 0x00D7B610 File Offset: 0x00D79810
		private void OnClickBtnHelp()
		{
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("KurotatoSavePopupHelpId").GetValueOrDefault();
			HelpController.Instance.OpenHelpById(valueOrDefault);
		}

		// Token: 0x06038C85 RID: 232581 RVA: 0x00D7B63C File Offset: 0x00D7983C
		private UniTask InitButton()
		{
			KurotatoPopupSaveView.<InitButton>d__23 <InitButton>d__;
			<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButton>d__.<>4__this = this;
			<InitButton>d__.<>1__state = -1;
			<InitButton>d__.<>t__builder.Start<KurotatoPopupSaveView.<InitButton>d__23>(ref <InitButton>d__);
			return <InitButton>d__.<>t__builder.Task;
		}

		// Token: 0x06038C86 RID: 232582 RVA: 0x00D7B680 File Offset: 0x00D79880
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<ConfirmBoxButton> CreateButton(UUIItem uiItem, int index, Action clickFunction)
		{
			KurotatoPopupSaveView.<CreateButton>d__24 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<ConfirmBoxButton>.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.uiItem = uiItem;
			<CreateButton>d__.index = index;
			<CreateButton>d__.clickFunction = clickFunction;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<KurotatoPopupSaveView.<CreateButton>d__24>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x06038C87 RID: 232583 RVA: 0x00D7B6DC File Offset: 0x00D798DC
		private void ResetButtonList()
		{
			int i = 0;
			int count = this.ButtonList.Count;
			while (i < count)
			{
				this.ButtonList[i].Destroy(null);
				i++;
			}
			this.ButtonList.Clear();
		}

		// Token: 0x06038C88 RID: 232584 RVA: 0x00D7B720 File Offset: 0x00D79920
		private void OnConfirmBoxButtonClick(int buttonIndex)
		{
			if (buttonIndex == 1)
			{
				this.HandleSaveAction();
				return;
			}
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			Func<int, bool> func = (confirmBoxData != null) ? confirmBoxData.CanExecuteCloseFunc : null;
			if (func != null && !func(this.SelectedIndex))
			{
				Action action;
				if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action))
				{
					action();
					return;
				}
			}
			else
			{
				base.CloseMe(delegate(bool _)
				{
					Action closeFunction = this.ConfirmBoxData.GetCloseFunction();
					if (closeFunction == null)
					{
						return;
					}
					closeFunction();
				});
			}
		}

		// Token: 0x06038C89 RID: 232585 RVA: 0x00D7B798 File Offset: 0x00D79998
		private void HandleSaveAction()
		{
			if (!this.HasOldSave)
			{
				this.DoSaveRecord().Forget();
				return;
			}
			if (!this.IsOverwriteConfirmChecked())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Kurotato_Character_Save_File_Tips", Array.Empty<object>());
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KurotatoOverwriteSave);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.DoSaveRecord().Forget();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06038C8A RID: 232586 RVA: 0x00D7B808 File Offset: 0x00D79A08
		private UniTask DoSaveRecord()
		{
			KurotatoPopupSaveView.<DoSaveRecord>d__28 <DoSaveRecord>d__;
			<DoSaveRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoSaveRecord>d__.<>4__this = this;
			<DoSaveRecord>d__.<>1__state = -1;
			<DoSaveRecord>d__.<>t__builder.Start<KurotatoPopupSaveView.<DoSaveRecord>d__28>(ref <DoSaveRecord>d__);
			return <DoSaveRecord>d__.<>t__builder.Task;
		}

		// Token: 0x06038C8B RID: 232587 RVA: 0x00D7B84B File Offset: 0x00D79A4B
		[NullableContext(2)]
		public EUiBehaviourPopType? GetExtraPopFrameType(object param = null)
		{
			return new EUiBehaviourPopType?(EUiBehaviourPopType.Middle);
		}

		// Token: 0x0401DC89 RID: 121993
		private readonly KurotatoSaveArchivePanel OldSavePanel = new KurotatoSaveArchivePanel();

		// Token: 0x0401DC8A RID: 121994
		private readonly KurotatoSaveArchivePanel NewSavePanel = new KurotatoSaveArchivePanel();

		// Token: 0x0401DC8B RID: 121995
		private bool HasOldSave;

		// Token: 0x0401DC8C RID: 121996
		[Nullable(2)]
		private ConfirmBoxDataNew ConfirmBoxData;

		// Token: 0x0401DC8D RID: 121997
		private ConfirmBox? Config;

		// Token: 0x0401DC8E RID: 121998
		private int SelectedIndex = -1;

		// Token: 0x0401DC8F RID: 121999
		private readonly List<ConfirmBoxButton> ButtonList = new List<ConfirmBoxButton>();

		// Token: 0x0401DC90 RID: 122000
		private readonly List<UUIButtonComponent> ButtonComponentList = new List<UUIButtonComponent>();

		// Token: 0x0200B923 RID: 47395
		[NullableContext(0)]
		private enum EComps
		{
			// Token: 0x04037FE5 RID: 229349
			BtnHelp,
			// Token: 0x04037FE6 RID: 229350
			TextSaveExpireTime,
			// Token: 0x04037FE7 RID: 229351
			TextSaveTip,
			// Token: 0x04037FE8 RID: 229352
			OldSavePanel,
			// Token: 0x04037FE9 RID: 229353
			NewSavePanel,
			// Token: 0x04037FEA RID: 229354
			PanelOverwriteConfirm,
			// Token: 0x04037FEB RID: 229355
			ToggleOverwriteConfirm,
			// Token: 0x04037FEC RID: 229356
			BtnLeft,
			// Token: 0x04037FED RID: 229357
			BtnRight
		}
	}
}
