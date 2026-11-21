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
	// Token: 0x02004716 RID: 18198
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupSaveView : UiViewBase, IExtraUiPopFrameType
	{
		// Token: 0x0602DB87 RID: 187271 RVA: 0x00CC9845 File Offset: 0x00CC7A45
		public KurotatoPopupSaveView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DB88 RID: 187272 RVA: 0x00CC9884 File Offset: 0x00CC7A84
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

		// Token: 0x0602DB89 RID: 187273 RVA: 0x00CC9A14 File Offset: 0x00CC7C14
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPopupSaveView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPopupSaveView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB8A RID: 187274 RVA: 0x00CC9A57 File Offset: 0x00CC7C57
		protected override void OnStart()
		{
			this.RefreshSaveState();
			this.RefreshOverwriteConfirmPanel();
		}

		// Token: 0x0602DB8B RID: 187275 RVA: 0x00CC9A68 File Offset: 0x00CC7C68
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

		// Token: 0x0602DB8C RID: 187276 RVA: 0x00CC9AE3 File Offset: 0x00CC7CE3
		protected override void OnAfterShow()
		{
			Action afterShowFunction = this.ConfirmBoxData.GetAfterShowFunction();
			if (afterShowFunction == null)
			{
				return;
			}
			afterShowFunction();
		}

		// Token: 0x0602DB8D RID: 187277 RVA: 0x00CC9AFA File Offset: 0x00CC7CFA
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

		// Token: 0x0602DB8E RID: 187278 RVA: 0x00CC9B20 File Offset: 0x00CC7D20
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

		// Token: 0x0602DB8F RID: 187279 RVA: 0x00CC9B7C File Offset: 0x00CC7D7C
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

		// Token: 0x0602DB90 RID: 187280 RVA: 0x00CC9C3C File Offset: 0x00CC7E3C
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

		// Token: 0x0602DB91 RID: 187281 RVA: 0x00CC9C7F File Offset: 0x00CC7E7F
		private bool IsOverwriteConfirmChecked()
		{
			return base.GetExtendToggle(6).ToggleState == EToggleState.ETT_Checked;
		}

		// Token: 0x0602DB92 RID: 187282 RVA: 0x00CC9C90 File Offset: 0x00CC7E90
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

		// Token: 0x0602DB93 RID: 187283 RVA: 0x00CC9CAB File Offset: 0x00CC7EAB
		private void HandleSelectedIndexWhenClose()
		{
			if (this.SelectedIndex == -1)
			{
				this.SelectedIndex = 0;
			}
		}

		// Token: 0x0602DB94 RID: 187284 RVA: 0x00CC9CC0 File Offset: 0x00CC7EC0
		private void OnClickBtnHelp()
		{
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("KurotatoSavePopupHelpId").GetValueOrDefault();
			HelpController.Instance.OpenHelpById(valueOrDefault);
		}

		// Token: 0x0602DB95 RID: 187285 RVA: 0x00CC9CEC File Offset: 0x00CC7EEC
		private UniTask InitButton()
		{
			KurotatoPopupSaveView.<InitButton>d__23 <InitButton>d__;
			<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButton>d__.<>4__this = this;
			<InitButton>d__.<>1__state = -1;
			<InitButton>d__.<>t__builder.Start<KurotatoPopupSaveView.<InitButton>d__23>(ref <InitButton>d__);
			return <InitButton>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB96 RID: 187286 RVA: 0x00CC9D30 File Offset: 0x00CC7F30
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

		// Token: 0x0602DB97 RID: 187287 RVA: 0x00CC9D8C File Offset: 0x00CC7F8C
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

		// Token: 0x0602DB98 RID: 187288 RVA: 0x00CC9DD0 File Offset: 0x00CC7FD0
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

		// Token: 0x0602DB99 RID: 187289 RVA: 0x00CC9E48 File Offset: 0x00CC8048
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

		// Token: 0x0602DB9A RID: 187290 RVA: 0x00CC9EB8 File Offset: 0x00CC80B8
		private UniTask DoSaveRecord()
		{
			KurotatoPopupSaveView.<DoSaveRecord>d__28 <DoSaveRecord>d__;
			<DoSaveRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoSaveRecord>d__.<>4__this = this;
			<DoSaveRecord>d__.<>1__state = -1;
			<DoSaveRecord>d__.<>t__builder.Start<KurotatoPopupSaveView.<DoSaveRecord>d__28>(ref <DoSaveRecord>d__);
			return <DoSaveRecord>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB9B RID: 187291 RVA: 0x00CC9EFB File Offset: 0x00CC80FB
		[NullableContext(2)]
		public EUiBehaviourPopType? GetExtraPopFrameType(object param = null)
		{
			return new EUiBehaviourPopType?(EUiBehaviourPopType.Middle);
		}

		// Token: 0x0401871F RID: 100127
		private readonly KurotatoSaveArchivePanel OldSavePanel = new KurotatoSaveArchivePanel();

		// Token: 0x04018720 RID: 100128
		private readonly KurotatoSaveArchivePanel NewSavePanel = new KurotatoSaveArchivePanel();

		// Token: 0x04018721 RID: 100129
		private bool HasOldSave;

		// Token: 0x04018722 RID: 100130
		[Nullable(2)]
		private ConfirmBoxDataNew ConfirmBoxData;

		// Token: 0x04018723 RID: 100131
		private ConfirmBox? Config;

		// Token: 0x04018724 RID: 100132
		private int SelectedIndex = -1;

		// Token: 0x04018725 RID: 100133
		private readonly List<ConfirmBoxButton> ButtonList = new List<ConfirmBoxButton>();

		// Token: 0x04018726 RID: 100134
		private readonly List<UUIButtonComponent> ButtonComponentList = new List<UUIButtonComponent>();

		// Token: 0x0200A344 RID: 41796
		[NullableContext(0)]
		private enum EComps
		{
			// Token: 0x040329F5 RID: 207349
			BtnHelp,
			// Token: 0x040329F6 RID: 207350
			TextSaveExpireTime,
			// Token: 0x040329F7 RID: 207351
			TextSaveTip,
			// Token: 0x040329F8 RID: 207352
			OldSavePanel,
			// Token: 0x040329F9 RID: 207353
			NewSavePanel,
			// Token: 0x040329FA RID: 207354
			PanelOverwriteConfirm,
			// Token: 0x040329FB RID: 207355
			ToggleOverwriteConfirm,
			// Token: 0x040329FC RID: 207356
			BtnLeft,
			// Token: 0x040329FD RID: 207357
			BtnRight
		}
	}
}
