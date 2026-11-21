using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037EA RID: 14314
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrBuildInfoView : UiViewBase
	{
		// Token: 0x060253C6 RID: 152518 RVA: 0x00A80608 File Offset: 0x00A7E808
		public VillageInfrBuildInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060253C7 RID: 152519 RVA: 0x00A80634 File Offset: 0x00A7E834
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickMaskClose)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickBack))
			};
		}

		// Token: 0x060253C8 RID: 152520 RVA: 0x00A8070C File Offset: 0x00A7E90C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IVillageInfrBuildInfoParam>(EEventName.VillageInfrMainViewOnSelect, new Action<IVillageInfrBuildInfoParam>(this.OnSelect));
			EventSystem.Instance.Add(EEventName.CloseVillageInfrBuildInfoView, new Action(this.OnClickMaskClose));
			EventSystem.Instance.Add(EEventName.VillageInfrMissionItemClick, new Action(this.OnClickMaskClose));
		}

		// Token: 0x060253C9 RID: 152521 RVA: 0x00A80770 File Offset: 0x00A7E970
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.VillageInfrMainViewOnSelect, new Action<IVillageInfrBuildInfoParam>(this.OnSelect));
			EventSystem.Instance.Remove(EEventName.CloseVillageInfrBuildInfoView, new Action(this.OnClickMaskClose));
			EventSystem.Instance.Remove(EEventName.VillageInfrMissionItemClick, new Action(this.OnClickMaskClose));
		}

		// Token: 0x060253CA RID: 152522 RVA: 0x00A807D4 File Offset: 0x00A7E9D4
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrBuildInfoView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrBuildInfoView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060253CB RID: 152523 RVA: 0x00A80818 File Offset: 0x00A7EA18
		private void SetOpenParam()
		{
			IVillageInfrBuildInfoParam villageInfrBuildInfoParam = this.OpenParam as IVillageInfrBuildInfoParam;
			this.SelectType = villageInfrBuildInfoParam.SelectType;
			this.SelectId = villageInfrBuildInfoParam.SelectId;
			this.CloseCb = villageInfrBuildInfoParam.CloseCb;
		}

		// Token: 0x060253CC RID: 152524 RVA: 0x00A80858 File Offset: 0x00A7EA58
		private UniTask CreateCaption()
		{
			VillageInfrBuildInfoView.<CreateCaption>d__12 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<VillageInfrBuildInfoView.<CreateCaption>d__12>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060253CD RID: 152525 RVA: 0x00A8089C File Offset: 0x00A7EA9C
		private UniTask RefreshCurrencyList()
		{
			VillageInfrBuildInfoView.<RefreshCurrencyList>d__13 <RefreshCurrencyList>d__;
			<RefreshCurrencyList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCurrencyList>d__.<>4__this = this;
			<RefreshCurrencyList>d__.<>1__state = -1;
			<RefreshCurrencyList>d__.<>t__builder.Start<VillageInfrBuildInfoView.<RefreshCurrencyList>d__13>(ref <RefreshCurrencyList>d__);
			return <RefreshCurrencyList>d__.<>t__builder.Task;
		}

		// Token: 0x060253CE RID: 152526 RVA: 0x00A808E0 File Offset: 0x00A7EAE0
		private UniTask CreateBuildPanel()
		{
			VillageInfrBuildInfoView.<CreateBuildPanel>d__14 <CreateBuildPanel>d__;
			<CreateBuildPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuildPanel>d__.<>4__this = this;
			<CreateBuildPanel>d__.<>1__state = -1;
			<CreateBuildPanel>d__.<>t__builder.Start<VillageInfrBuildInfoView.<CreateBuildPanel>d__14>(ref <CreateBuildPanel>d__);
			return <CreateBuildPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060253CF RID: 152527 RVA: 0x00A80924 File Offset: 0x00A7EB24
		private UniTask CreateChatItem()
		{
			VillageInfrBuildInfoView.<CreateChatItem>d__15 <CreateChatItem>d__;
			<CreateChatItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateChatItem>d__.<>4__this = this;
			<CreateChatItem>d__.<>1__state = -1;
			<CreateChatItem>d__.<>t__builder.Start<VillageInfrBuildInfoView.<CreateChatItem>d__15>(ref <CreateChatItem>d__);
			return <CreateChatItem>d__.<>t__builder.Task;
		}

		// Token: 0x060253D0 RID: 152528 RVA: 0x00A80968 File Offset: 0x00A7EB68
		protected override void OnStart()
		{
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			this.RefreshBuildInfo();
			this.RefreshChat(false);
		}

		// Token: 0x060253D1 RID: 152529 RVA: 0x00A8099C File Offset: 0x00A7EB9C
		private void RefreshBuildInfo()
		{
			VillageInfrModel modelData = VillageInfrModel.Instance;
			this.BuildPanel.SetBottomBtnClickCb(delegate
			{
				Action closeCb = this.CloseCb;
				if (closeCb != null)
				{
					closeCb();
				}
				this.CloseMe(null);
				if (this.SelectType != EVillageInfrSelectType.Tree)
				{
					SkipTaskManager.RunByConfigId(ConfigCommonParamById.GetIntConfig("VillageInfrLevelAccessPath").Value, null);
					return;
				}
				InfrV2TreeBuild? infrTreeBuild = VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId);
				if (!modelData.GetTreeIsUnlock(this.SelectId))
				{
					SkipTaskManager.RunByConfigId(infrTreeBuild.Value.LockJumpId, null);
					return;
				}
				if (!modelData.GetCanTreeLevelUp(this.SelectId) && !modelData.GetTreeIsComplete(this.SelectId))
				{
					VillageInfrController.Instance.RequestInfrV2ManualSwitchTraceTree(this.SelectId).Forget<bool>();
					SkipTaskManager.RunByConfigId(infrTreeBuild.Value.JumpId, null);
					return;
				}
				SkipTaskManager.RunByConfigId(infrTreeBuild.Value.JumpId, null);
			});
		}

		// Token: 0x060253D2 RID: 152530 RVA: 0x00A809D8 File Offset: 0x00A7EBD8
		private void RefreshChat(bool isStart = false)
		{
			IReadOnlyList<InfrV2PopupMsg> popupMsgAll = VillageInfrConfig.Instance.GetPopupMsgAll();
			EVillageInfrPopupMsgType popupMsgType = this.GetPopupMsgType();
			List<InfrV2PopupMsg> list = new List<InfrV2PopupMsg>();
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				using (IEnumerator<InfrV2PopupMsg> enumerator = popupMsgAll.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						InfrV2PopupMsg item = enumerator.Current;
						if (item.Type == (int)popupMsgType && item.TreeId == this.SelectId)
						{
							list.Add(item);
						}
					}
					goto IL_A8;
				}
			}
			foreach (InfrV2PopupMsg item2 in popupMsgAll)
			{
				if (item2.Type == (int)popupMsgType)
				{
					list.Add(item2);
				}
			}
			IL_A8:
			if (list.Count <= 0)
			{
				this.ChatItem.SetShow(false, true);
				return;
			}
			this.ChatItem.SetShow(true, !isStart);
			InfrV2PopupMsg infrV2PopupMsg = list[(int)Math.Floor(new Random().NextDouble() * (double)list.Count)];
			this.ChatItem.Refresh(new VillageInfrChat
			{
				HeadTexture = infrV2PopupMsg.HeadTexturePath,
				Chat = infrV2PopupMsg.Text
			});
		}

		// Token: 0x060253D3 RID: 152531 RVA: 0x00A80B1C File Offset: 0x00A7ED1C
		private EVillageInfrPopupMsgType GetPopupMsgType()
		{
			VillageInfrModel instance = VillageInfrModel.Instance;
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				IVillageInfrTreeData treeData = instance.GetTreeData(this.SelectId);
				if (treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusLock)
				{
					return EVillageInfrPopupMsgType.TreeLock;
				}
				if (treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusProgress)
				{
					if (instance.GetCanTreeLevelUp(this.SelectId))
					{
						return EVillageInfrPopupMsgType.TreeCanBuild;
					}
					return EVillageInfrPopupMsgType.TreeProgress;
				}
				else
				{
					if (treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusComplete)
					{
						return EVillageInfrPopupMsgType.TreeComplete;
					}
					return EVillageInfrPopupMsgType.TreeLock;
				}
			}
			else
			{
				if (instance.GetVillageLevel() >= VillageInfrConfig.Instance.GetInfrMaxLevel())
				{
					return EVillageInfrPopupMsgType.VillageComplete;
				}
				if (instance.GetCanVillageLevelUp())
				{
					return EVillageInfrPopupMsgType.VillageCanBuild;
				}
				return EVillageInfrPopupMsgType.VillageProgress;
			}
		}

		// Token: 0x060253D4 RID: 152532 RVA: 0x00A80B9F File Offset: 0x00A7ED9F
		private void OnClickMaskClose()
		{
			Action closeCb = this.CloseCb;
			if (closeCb != null)
			{
				closeCb();
			}
			base.CloseMe(null);
		}

		// Token: 0x060253D5 RID: 152533 RVA: 0x00A80BB9 File Offset: 0x00A7EDB9
		private void OnClickBack()
		{
			Action closeCb = this.CloseCb;
			if (closeCb != null)
			{
				closeCb();
			}
			base.CloseMe(null);
		}

		// Token: 0x060253D6 RID: 152534 RVA: 0x00A80BD3 File Offset: 0x00A7EDD3
		public void SetCloseCallBack(Action cb)
		{
			this.CloseCb = cb;
		}

		// Token: 0x060253D7 RID: 152535 RVA: 0x00A80BDC File Offset: 0x00A7EDDC
		private void OnSelect(IVillageInfrBuildInfoParam param)
		{
			this.OpenParam = param;
			this.SetOpenParam();
			this.RefreshCurrencyList().Forget();
			this.RefreshBuildInfo();
			this.RefreshChat(false);
			this.BuildPanel.Refresh(param);
		}

		// Token: 0x0401499C RID: 84380
		private int SelectId;

		// Token: 0x0401499D RID: 84381
		private EVillageInfrSelectType SelectType;

		// Token: 0x0401499E RID: 84382
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x0401499F RID: 84383
		private readonly VillageInfrBuildPanel BuildPanel = new VillageInfrBuildPanel();

		// Token: 0x040149A0 RID: 84384
		private readonly ChatItem ChatItem = new ChatItem();

		// Token: 0x040149A1 RID: 84385
		[Nullable(2)]
		private Action CloseCb;
	}
}
