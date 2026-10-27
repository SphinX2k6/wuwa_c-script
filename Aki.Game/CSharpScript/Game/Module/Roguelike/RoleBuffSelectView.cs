using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E3B RID: 20027
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleBuffSelectView : RogueSelectBaseView
	{
		// Token: 0x06033A0B RID: 211467 RVA: 0x00C15392 File Offset: 0x00C13592
		[NullableContext(1)]
		public RoleBuffSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033A0C RID: 211468 RVA: 0x00C1539C File Offset: 0x00C1359C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033A0D RID: 211469 RVA: 0x00C1548C File Offset: 0x00C1368C
		private void ConfirmBtn(int _)
		{
			if (this.RoguelikeChooseData.RogueGainEntryList.Count <= 0)
			{
				RoguelikeChooseDataResultRequest roguelikeChooseDataResultRequest = new RoguelikeChooseDataResultRequest();
				RoguelikeChooseDataResultRequest roguelikeChooseDataResultRequest2 = roguelikeChooseDataResultRequest;
				RoguelikeChooseData roguelikeChooseData = this.RoguelikeChooseData;
				roguelikeChooseDataResultRequest2.BindId = ((roguelikeChooseData != null) ? roguelikeChooseData.Index : 0);
				roguelikeChooseDataResultRequest.Layer = RoguelikeModel.Instance.CurRoomCount;
				Net.Instance.Call(ERequestMessageId.RoguelikeChooseDataResultRequest, roguelikeChooseDataResultRequest, delegate(IMessage _, Net.CallbackStatus _)
				{
					UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool _)
					{
						RoguelikeChooseData roguelikeChooseData2 = this.RoguelikeChooseData;
						if (roguelikeChooseData2 == null)
						{
							return;
						}
						Action callBack = roguelikeChooseData2.CallBack;
						if (callBack == null)
						{
							return;
						}
						callBack();
					});
				}, 0);
				return;
			}
			RoleBuffSelectItem roleBuffSelectItem = this.GetRoleBuffSelectItem();
			if (roleBuffSelectItem == null)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.ZJC, "当前没有选中的角色Buff", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RoguelikeModel.Instance.CurrentRogueGainEntry = roleBuffSelectItem.RogueGainEntry;
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Role);
		}

		// Token: 0x06033A0E RID: 211470 RVA: 0x00C1553C File Offset: 0x00C1373C
		private void OnToggleStateChange(int index, bool state)
		{
			this.RoleBuffSelectLayout.DeselectCurrentGridProxy();
			if (state)
			{
				this.RoleBuffSelectLayout.SelectGridProxy(index, false);
			}
			this.RefreshBtnEnableClick();
		}

		// Token: 0x06033A0F RID: 211471 RVA: 0x00C15560 File Offset: 0x00C13760
		protected void RefreshBtnEnableClick()
		{
			List<RogueGainEntry> rogueGainEntryList = this.RoguelikeChooseData.RogueGainEntryList;
			if (rogueGainEntryList != null && rogueGainEntryList.Count <= 0)
			{
				this.ButtonItem.SetEnableClick(true);
				return;
			}
			RoleBuffSelectItem roleBuffSelectItem = this.GetRoleBuffSelectItem();
			this.ButtonItem.SetEnableClick(roleBuffSelectItem != null);
		}

		// Token: 0x06033A10 RID: 211472 RVA: 0x00C155B0 File Offset: 0x00C137B0
		protected RoleBuffSelectItem GetRoleBuffSelectItem()
		{
			foreach (RoleBuffSelectItem roleBuffSelectItem in this.RoleBuffSelectLayout.GetLayoutItemList())
			{
				if (roleBuffSelectItem.IsSelect())
				{
					return roleBuffSelectItem;
				}
			}
			return null;
		}

		// Token: 0x06033A11 RID: 211473 RVA: 0x00C15610 File Offset: 0x00C13810
		protected override UniTask OnBeforeStartAsync()
		{
			RoleBuffSelectView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleBuffSelectView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A12 RID: 211474 RVA: 0x00C15654 File Offset: 0x00C13854
		protected override void OnStart()
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = null;
			this.RoguelikeChooseData = (RoguelikeChooseData)this.OpenParam;
			this.TopPanel.CloseCallback = new Action(base.CloseMySelf);
			this.ButtonItem = new ButtonItem(base.GetButton(4).GetRootComponent());
			this.ButtonItem.SetFunction(new Action<int>(this.ConfirmBtn));
			this.RoleBuffSelectLayout = new GenericLayout<RoleBuffSelectItem, RogueGainEntry>(base.GetVerticalLayout(2), new Func<RoleBuffSelectItem>(this.CreateRoleBuffItem), null, false, true);
			this.RefreshPanel();
		}

		// Token: 0x06033A13 RID: 211475 RVA: 0x00C156E9 File Offset: 0x00C138E9
		[NullableContext(1)]
		private RoleBuffSelectItem CreateRoleBuffItem()
		{
			RoleBuffSelectItem roleBuffSelectItem = new RoleBuffSelectItem();
			roleBuffSelectItem.SetToggleStateChangeCallback(new Action<int, bool>(this.OnToggleStateChange));
			roleBuffSelectItem.OnClickBtnDetailCallback = new Action<int>(this.OnClickBtnDetail);
			return roleBuffSelectItem;
		}

		// Token: 0x06033A14 RID: 211476 RVA: 0x00C15714 File Offset: 0x00C13914
		protected override void OnBeforeDestroy()
		{
			this.TopPanel.Destroy(null);
		}

		// Token: 0x06033A15 RID: 211477 RVA: 0x00C15724 File Offset: 0x00C13924
		protected override void OnDescModelChange()
		{
			foreach (RoleBuffSelectItem roleBuffSelectItem in this.RoleBuffSelectLayout.GetLayoutItemList())
			{
				roleBuffSelectItem.RefreshPanel();
			}
		}

		// Token: 0x06033A16 RID: 211478 RVA: 0x00C1577C File Offset: 0x00C1397C
		private void RefreshPanel()
		{
			this.RefreshTopPanel();
			this.RefreshRoleBuffList();
			this.RefreshBtnText();
			this.RefreshBtnEnableClick();
		}

		// Token: 0x06033A17 RID: 211479 RVA: 0x00C15796 File Offset: 0x00C13996
		private void RefreshTopPanel()
		{
			this.TopPanel.RefreshTitle("RoguelikeView_7_Text");
			this.TopPanel.RefreshSelectTipsText("RoguelikeView_8_Text", true, Array.Empty<object>());
		}

		// Token: 0x06033A18 RID: 211480 RVA: 0x00C157BE File Offset: 0x00C139BE
		private void RefreshRoleBuffList()
		{
			this.RoleBuffSelectLayout.RefreshByData(this.RoguelikeChooseData.RogueGainEntryList ?? new List<RogueGainEntry>(), null, false);
		}

		// Token: 0x06033A19 RID: 211481 RVA: 0x00C157E1 File Offset: 0x00C139E1
		protected void RefreshBtnText()
		{
			this.ButtonItem.SetShowText("RoguelikeView_15_Text");
		}

		// Token: 0x06033A1A RID: 211482 RVA: 0x00C157F4 File Offset: 0x00C139F4
		[NullableContext(1)]
		protected override void RoguelikeChooseDataResult(RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response)
		{
			if (isSuccess)
			{
				RoguelikeChooseData roguelikeChooseData = this.RoguelikeChooseData;
				int? num = (roguelikeChooseData != null) ? new int?(roguelikeChooseData.Index) : null;
				if (bindId == num.GetValueOrDefault() & num != null)
				{
					RoleBuffSelectItem roleBuffSelectItem = this.GetRoleBuffSelectItem();
					RogueSelectResult rogueSelectResult = new RogueSelectResult(newRogueGainEntry, oldRogueGainEntry, (roleBuffSelectItem != null) ? roleBuffSelectItem.RogueGainEntry : null, false);
					rogueSelectResult.CallBack = this.RoguelikeChooseData.CallBack;
					UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.RogueRoleSelectResultView, rogueSelectResult, null, true);
					return;
				}
			}
		}

		// Token: 0x06033A1B RID: 211483 RVA: 0x00C15884 File Offset: 0x00C13A84
		private void OnClickBtnDetail(int index)
		{
			List<RogueGainEntry> rogueGainEntryList = this.RoguelikeChooseData.RogueGainEntryList;
			List<int> list = new List<int>();
			foreach (RogueGainEntry rogueGainEntry in rogueGainEntryList)
			{
				list.Add(rogueGainEntry.ConfigId);
			}
			RoguelikeRoleAffixDetailViewParam param = new RoguelikeRoleAffixDetailViewParam
			{
				Index = index,
				AffixIds = list
			};
			UiManager.Instance.OpenView(EUiViewName.RoguelikeRoleAffixDetailView, param, null);
		}

		// Token: 0x0401B619 RID: 112153
		private RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x0401B61A RID: 112154
		private TopPanel TopPanel;

		// Token: 0x0401B61B RID: 112155
		protected ButtonItem ButtonItem;

		// Token: 0x0401B61C RID: 112156
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RoleBuffSelectItem, RogueGainEntry> RoleBuffSelectLayout;

		// Token: 0x0200AFF0 RID: 45040
		[NullableContext(0)]
		public static class ERoleBuffSelectViewCom
		{
			// Token: 0x040356A3 RID: 218787
			public const int TopPanelItem = 0;

			// Token: 0x040356A4 RID: 218788
			public const int RoleTexture = 1;

			// Token: 0x040356A5 RID: 218789
			public const int RoleBuffListLayout = 2;

			// Token: 0x040356A6 RID: 218790
			public const int RoleBuffItem = 3;

			// Token: 0x040356A7 RID: 218791
			public const int ConfirmBtn = 4;

			// Token: 0x040356A8 RID: 218792
			public const int RoleShadowTexture = 5;
		}
	}
}
