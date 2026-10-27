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
	// Token: 0x02004873 RID: 18547
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrBuildInfoView : UiViewBase
	{
		// Token: 0x0603089A RID: 198810 RVA: 0x00B4586C File Offset: 0x00B43A6C
		public VillageInfrBuildInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603089B RID: 198811 RVA: 0x00B45898 File Offset: 0x00B43A98
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

		// Token: 0x0603089C RID: 198812 RVA: 0x00B45970 File Offset: 0x00B43B70
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IVillageInfrBuildInfoParam>(EEventName.VillageInfrMainViewOnSelect, new Action<IVillageInfrBuildInfoParam>(this.OnSelect));
			EventSystem.Instance.Add(EEventName.CloseVillageInfrBuildInfoView, new Action(this.OnClickMaskClose));
			EventSystem.Instance.Add(EEventName.VillageInfrMissionItemClick, new Action(this.OnClickMaskClose));
		}

		// Token: 0x0603089D RID: 198813 RVA: 0x00B459D4 File Offset: 0x00B43BD4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.VillageInfrMainViewOnSelect, new Action<IVillageInfrBuildInfoParam>(this.OnSelect));
			EventSystem.Instance.Remove(EEventName.CloseVillageInfrBuildInfoView, new Action(this.OnClickMaskClose));
			EventSystem.Instance.Remove(EEventName.VillageInfrMissionItemClick, new Action(this.OnClickMaskClose));
		}

		// Token: 0x0603089E RID: 198814 RVA: 0x00B45A38 File Offset: 0x00B43C38
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrBuildInfoView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrBuildInfoView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603089F RID: 198815 RVA: 0x00B45A7C File Offset: 0x00B43C7C
		private void SetOpenParam()
		{
			IVillageInfrBuildInfoParam villageInfrBuildInfoParam = this.OpenParam as IVillageInfrBuildInfoParam;
			this.SelectType = villageInfrBuildInfoParam.SelectType;
			this.SelectId = villageInfrBuildInfoParam.SelectId;
			this.CloseCb = villageInfrBuildInfoParam.CloseCb;
		}

		// Token: 0x060308A0 RID: 198816 RVA: 0x00B45ABC File Offset: 0x00B43CBC
		private UniTask CreateCaption()
		{
			VillageInfrBuildInfoView.<CreateCaption>d__12 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<VillageInfrBuildInfoView.<CreateCaption>d__12>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060308A1 RID: 198817 RVA: 0x00B45B00 File Offset: 0x00B43D00
		private UniTask RefreshCurrencyList()
		{
			VillageInfrBuildInfoView.<RefreshCurrencyList>d__13 <RefreshCurrencyList>d__;
			<RefreshCurrencyList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCurrencyList>d__.<>4__this = this;
			<RefreshCurrencyList>d__.<>1__state = -1;
			<RefreshCurrencyList>d__.<>t__builder.Start<VillageInfrBuildInfoView.<RefreshCurrencyList>d__13>(ref <RefreshCurrencyList>d__);
			return <RefreshCurrencyList>d__.<>t__builder.Task;
		}

		// Token: 0x060308A2 RID: 198818 RVA: 0x00B45B44 File Offset: 0x00B43D44
		private UniTask CreateBuildPanel()
		{
			VillageInfrBuildInfoView.<CreateBuildPanel>d__14 <CreateBuildPanel>d__;
			<CreateBuildPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuildPanel>d__.<>4__this = this;
			<CreateBuildPanel>d__.<>1__state = -1;
			<CreateBuildPanel>d__.<>t__builder.Start<VillageInfrBuildInfoView.<CreateBuildPanel>d__14>(ref <CreateBuildPanel>d__);
			return <CreateBuildPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060308A3 RID: 198819 RVA: 0x00B45B88 File Offset: 0x00B43D88
		private UniTask CreateChatItem()
		{
			VillageInfrBuildInfoView.<CreateChatItem>d__15 <CreateChatItem>d__;
			<CreateChatItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateChatItem>d__.<>4__this = this;
			<CreateChatItem>d__.<>1__state = -1;
			<CreateChatItem>d__.<>t__builder.Start<VillageInfrBuildInfoView.<CreateChatItem>d__15>(ref <CreateChatItem>d__);
			return <CreateChatItem>d__.<>t__builder.Task;
		}

		// Token: 0x060308A4 RID: 198820 RVA: 0x00B45BCC File Offset: 0x00B43DCC
		protected override void OnStart()
		{
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			this.RefreshBuildInfo();
			this.RefreshChat(false);
		}

		// Token: 0x060308A5 RID: 198821 RVA: 0x00B45C00 File Offset: 0x00B43E00
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

		// Token: 0x060308A6 RID: 198822 RVA: 0x00B45C3C File Offset: 0x00B43E3C
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

		// Token: 0x060308A7 RID: 198823 RVA: 0x00B45D80 File Offset: 0x00B43F80
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

		// Token: 0x060308A8 RID: 198824 RVA: 0x00B45E03 File Offset: 0x00B44003
		private void OnClickMaskClose()
		{
			Action closeCb = this.CloseCb;
			if (closeCb != null)
			{
				closeCb();
			}
			base.CloseMe(null);
		}

		// Token: 0x060308A9 RID: 198825 RVA: 0x00B45E1D File Offset: 0x00B4401D
		private void OnClickBack()
		{
			Action closeCb = this.CloseCb;
			if (closeCb != null)
			{
				closeCb();
			}
			base.CloseMe(null);
		}

		// Token: 0x060308AA RID: 198826 RVA: 0x00B45E37 File Offset: 0x00B44037
		public void SetCloseCallBack(Action cb)
		{
			this.CloseCb = cb;
		}

		// Token: 0x060308AB RID: 198827 RVA: 0x00B45E40 File Offset: 0x00B44040
		private void OnSelect(IVillageInfrBuildInfoParam param)
		{
			this.OpenParam = param;
			this.SetOpenParam();
			this.RefreshCurrencyList().Forget();
			this.RefreshBuildInfo();
			this.RefreshChat(false);
			this.BuildPanel.Refresh(param);
		}

		// Token: 0x0401A129 RID: 106793
		private int SelectId;

		// Token: 0x0401A12A RID: 106794
		private EVillageInfrSelectType SelectType;

		// Token: 0x0401A12B RID: 106795
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x0401A12C RID: 106796
		private readonly VillageInfrBuildPanel BuildPanel = new VillageInfrBuildPanel();

		// Token: 0x0401A12D RID: 106797
		private readonly ChatItem ChatItem = new ChatItem();

		// Token: 0x0401A12E RID: 106798
		[Nullable(2)]
		private Action CloseCb;
	}
}
