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
	// Token: 0x02003E04 RID: 15876
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleBuffSelectView : RogueSelectBaseView
	{
		// Token: 0x06028876 RID: 166006 RVA: 0x00B5E8BA File Offset: 0x00B5CABA
		[NullableContext(1)]
		public RoleBuffSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028877 RID: 166007 RVA: 0x00B5E8C4 File Offset: 0x00B5CAC4
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

		// Token: 0x06028878 RID: 166008 RVA: 0x00B5E9B4 File Offset: 0x00B5CBB4
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

		// Token: 0x06028879 RID: 166009 RVA: 0x00B5EA64 File Offset: 0x00B5CC64
		private void OnToggleStateChange(int index, bool state)
		{
			this.RoleBuffSelectLayout.DeselectCurrentGridProxy();
			if (state)
			{
				this.RoleBuffSelectLayout.SelectGridProxy(index, false);
			}
			this.RefreshBtnEnableClick();
		}

		// Token: 0x0602887A RID: 166010 RVA: 0x00B5EA88 File Offset: 0x00B5CC88
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

		// Token: 0x0602887B RID: 166011 RVA: 0x00B5EAD8 File Offset: 0x00B5CCD8
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

		// Token: 0x0602887C RID: 166012 RVA: 0x00B5EB38 File Offset: 0x00B5CD38
		protected override UniTask OnBeforeStartAsync()
		{
			RoleBuffSelectView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleBuffSelectView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602887D RID: 166013 RVA: 0x00B5EB7C File Offset: 0x00B5CD7C
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

		// Token: 0x0602887E RID: 166014 RVA: 0x00B5EC11 File Offset: 0x00B5CE11
		[NullableContext(1)]
		private RoleBuffSelectItem CreateRoleBuffItem()
		{
			RoleBuffSelectItem roleBuffSelectItem = new RoleBuffSelectItem();
			roleBuffSelectItem.SetToggleStateChangeCallback(new Action<int, bool>(this.OnToggleStateChange));
			roleBuffSelectItem.OnClickBtnDetailCallback = new Action<int>(this.OnClickBtnDetail);
			return roleBuffSelectItem;
		}

		// Token: 0x0602887F RID: 166015 RVA: 0x00B5EC3C File Offset: 0x00B5CE3C
		protected override void OnBeforeDestroy()
		{
			this.TopPanel.Destroy(null);
		}

		// Token: 0x06028880 RID: 166016 RVA: 0x00B5EC4C File Offset: 0x00B5CE4C
		protected override void OnDescModelChange()
		{
			foreach (RoleBuffSelectItem roleBuffSelectItem in this.RoleBuffSelectLayout.GetLayoutItemList())
			{
				roleBuffSelectItem.RefreshPanel();
			}
		}

		// Token: 0x06028881 RID: 166017 RVA: 0x00B5ECA4 File Offset: 0x00B5CEA4
		private void RefreshPanel()
		{
			this.RefreshTopPanel();
			this.RefreshRoleBuffList();
			this.RefreshBtnText();
			this.RefreshBtnEnableClick();
		}

		// Token: 0x06028882 RID: 166018 RVA: 0x00B5ECBE File Offset: 0x00B5CEBE
		private void RefreshTopPanel()
		{
			this.TopPanel.RefreshTitle("RoguelikeView_7_Text");
			this.TopPanel.RefreshSelectTipsText("RoguelikeView_8_Text", true, Array.Empty<object>());
		}

		// Token: 0x06028883 RID: 166019 RVA: 0x00B5ECE6 File Offset: 0x00B5CEE6
		private void RefreshRoleBuffList()
		{
			this.RoleBuffSelectLayout.RefreshByData(this.RoguelikeChooseData.RogueGainEntryList ?? new List<RogueGainEntry>(), null, false);
		}

		// Token: 0x06028884 RID: 166020 RVA: 0x00B5ED09 File Offset: 0x00B5CF09
		protected void RefreshBtnText()
		{
			this.ButtonItem.SetShowText("RoguelikeView_15_Text");
		}

		// Token: 0x06028885 RID: 166021 RVA: 0x00B5ED1C File Offset: 0x00B5CF1C
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

		// Token: 0x06028886 RID: 166022 RVA: 0x00B5EDAC File Offset: 0x00B5CFAC
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

		// Token: 0x04015FEC RID: 90092
		private RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x04015FED RID: 90093
		private TopPanel TopPanel;

		// Token: 0x04015FEE RID: 90094
		protected ButtonItem ButtonItem;

		// Token: 0x04015FEF RID: 90095
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RoleBuffSelectItem, RogueGainEntry> RoleBuffSelectLayout;

		// Token: 0x02009A22 RID: 39458
		[NullableContext(0)]
		public static class ERoleBuffSelectViewCom
		{
			// Token: 0x040300D3 RID: 196819
			public const int TopPanelItem = 0;

			// Token: 0x040300D4 RID: 196820
			public const int RoleTexture = 1;

			// Token: 0x040300D5 RID: 196821
			public const int RoleBuffListLayout = 2;

			// Token: 0x040300D6 RID: 196822
			public const int RoleBuffItem = 3;

			// Token: 0x040300D7 RID: 196823
			public const int ConfirmBtn = 4;

			// Token: 0x040300D8 RID: 196824
			public const int RoleShadowTexture = 5;
		}
	}
}
