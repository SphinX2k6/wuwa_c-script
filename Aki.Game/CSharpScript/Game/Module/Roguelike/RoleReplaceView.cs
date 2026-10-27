using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E3C RID: 20028
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleReplaceView : RogueSelectBaseView
	{
		// Token: 0x06033A1E RID: 211486 RVA: 0x00C1594B File Offset: 0x00C13B4B
		public RoleReplaceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033A1F RID: 211487 RVA: 0x00C1597C File Offset: 0x00C13B7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033A20 RID: 211488 RVA: 0x00C15A6C File Offset: 0x00C13C6C
		private void ConfirmBtn(int _)
		{
			if (this.RoguelikeChooseData.RogueGainEntryList.Count <= 0)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.ZJC, "当前可选角色为0", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RoguelikeModel.Instance.CurrentRogueGainEntry = this.RoguelikeChooseData.RogueGainEntryList[0];
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Role);
		}

		// Token: 0x06033A21 RID: 211489 RVA: 0x00C15AD4 File Offset: 0x00C13CD4
		protected override UniTask OnCreateAsync()
		{
			RoleReplaceView.<OnCreateAsync>d__9 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<RoleReplaceView.<OnCreateAsync>d__9>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A22 RID: 211490 RVA: 0x00C15B18 File Offset: 0x00C13D18
		protected override UniTask OnBeforeStartAsync()
		{
			RoleReplaceView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleReplaceView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A23 RID: 211491 RVA: 0x00C15B5C File Offset: 0x00C13D5C
		protected override void OnStart()
		{
			this.UiPoolActorPrivate.UiItem.SetUIParent(base.GetHorizontalLayout(1).GetRootComponent(), false);
			RoguelikeModel.Instance.CurrentRogueGainEntry = null;
			this.RoguelikeChooseData = (this.OpenParam as RoguelikeChooseData);
			this.TopPanel.CloseCallback = new Action(base.CloseMySelf);
			this.ElementPanel.SetActive(false);
			this.ButtonItem = new ButtonItem(base.GetButton(2).GetRootComponent());
			this.ButtonItem.SetFunction(new Action<int>(this.ConfirmBtn));
			this.RoleSelectItemLayout = new GenericLayout<RoleSelectItem, RogueGainEntry>(base.GetHorizontalLayout(1), this.CreateRoleSelectItem, null, false, true);
		}

		// Token: 0x06033A24 RID: 211492 RVA: 0x00C15C0E File Offset: 0x00C13E0E
		protected override void OnBeforeDestroy()
		{
			this.TopPanel.Destroy(null);
			this.ElementPanel.Destroy(null);
			base.RecycleUiPoolActor();
		}

		// Token: 0x06033A25 RID: 211493 RVA: 0x00C15C2E File Offset: 0x00C13E2E
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x06033A26 RID: 211494 RVA: 0x00C15C36 File Offset: 0x00C13E36
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x06033A27 RID: 211495 RVA: 0x00C15C40 File Offset: 0x00C13E40
		protected override void RoguelikeChooseDataResult(RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response)
		{
			if (isSuccess)
			{
				RoguelikeChooseData roguelikeChooseData = this.RoguelikeChooseData;
				int? num = (roguelikeChooseData != null) ? new int?(roguelikeChooseData.Index) : null;
				if (bindId == num.GetValueOrDefault() & num != null)
				{
					UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.RogueRoleSelectResultView, new RogueSelectResult(newRogueGainEntry, oldRogueGainEntry, null, false), null, true);
					return;
				}
			}
		}

		// Token: 0x06033A28 RID: 211496 RVA: 0x00C15CAB File Offset: 0x00C13EAB
		private void Refresh()
		{
			this.RefreshPhantomSelectItemList();
			this.RefreshTopPanel();
			this.RefreshElementPanel();
			this.RefreshBtnText();
			this.RefreshOldNewText();
		}

		// Token: 0x06033A29 RID: 211497 RVA: 0x00C15CCC File Offset: 0x00C13ECC
		protected void RefreshTopPanel()
		{
			this.TopPanel.RefreshTitle("RoguelikeView_3_Text");
			List<RogueGainEntry> rogueGainEntryList = this.GetRogueGainEntryList();
			RogueCharacter? rogueCharacterConfig = RoguelikeConfig.Instance.GetRogueCharacterConfig(rogueGainEntryList[0].ConfigId);
			RogueCharacter? rogueCharacterConfig2 = RoguelikeConfig.Instance.GetRogueCharacterConfig(rogueGainEntryList[1].ConfigId);
			this.TopPanel.RefreshSelectTipsText("RoguelikeView_4_Text", false, new object[]
			{
				new TableTextArgNew((rogueCharacterConfig != null) ? rogueCharacterConfig.GetValueOrDefault().RoleName : null, Array.Empty<object>()),
				new TableTextArgNew((rogueCharacterConfig2 != null) ? rogueCharacterConfig2.GetValueOrDefault().RoleName : null, Array.Empty<object>())
			});
		}

		// Token: 0x06033A2A RID: 211498 RVA: 0x00C15D85 File Offset: 0x00C13F85
		protected void RefreshElementPanel()
		{
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x06033A2B RID: 211499 RVA: 0x00C15D94 File Offset: 0x00C13F94
		protected void RefreshPhantomSelectItemList()
		{
			List<RogueGainEntry> rogueGainEntryList = this.GetRogueGainEntryList();
			this.RoleSelectItemLayout.RefreshByData(rogueGainEntryList, null, false);
		}

		// Token: 0x06033A2C RID: 211500 RVA: 0x00C15DB6 File Offset: 0x00C13FB6
		protected void RefreshBtnText()
		{
			this.ButtonItem.SetShowText("RoguelikeView_14_Text");
		}

		// Token: 0x06033A2D RID: 211501 RVA: 0x00C15DC8 File Offset: 0x00C13FC8
		private List<RogueGainEntry> GetRogueGainEntryList()
		{
			List<RogueGainEntry> list = new List<RogueGainEntry>();
			RogueGainEntry roleEntry = RoguelikeModel.Instance.RogueInfo.RoleEntry;
			if (roleEntry != null)
			{
				list.Add(roleEntry);
			}
			if (this.RoguelikeChooseData.RogueGainEntryList.Count > 0)
			{
				list.Add(this.RoguelikeChooseData.RogueGainEntryList[0]);
			}
			return list;
		}

		// Token: 0x06033A2E RID: 211502 RVA: 0x00C15E20 File Offset: 0x00C14020
		private void RefreshOldNewText()
		{
			base.GetText(4).ShowTextNew("RoguelikeView_23_Text");
			base.GetText(5).ShowTextNew("RoguelikeView_24_Text");
		}

		// Token: 0x0401B61D RID: 112157
		[Nullable(2)]
		protected RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x0401B61E RID: 112158
		[Nullable(2)]
		protected TopPanel TopPanel;

		// Token: 0x0401B61F RID: 112159
		[Nullable(2)]
		protected ElementPanel ElementPanel;

		// Token: 0x0401B620 RID: 112160
		[Nullable(2)]
		protected ButtonItem ButtonItem;

		// Token: 0x0401B621 RID: 112161
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RoleSelectItem, RogueGainEntry> RoleSelectItemLayout;

		// Token: 0x0401B622 RID: 112162
		protected readonly Func<RoleSelectItem> CreateRoleSelectItem = () => new RoleSelectItem();

		// Token: 0x0200AFF2 RID: 45042
		[NullableContext(0)]
		private static class ERoleReplaceViewCom
		{
			// Token: 0x040356AD RID: 218797
			public const int TopPanelItem = 0;

			// Token: 0x040356AE RID: 218798
			public const int ItemListLayout = 1;

			// Token: 0x040356AF RID: 218799
			public const int ConfirmBtn = 2;

			// Token: 0x040356B0 RID: 218800
			public const int ElementPanelItem = 3;

			// Token: 0x040356B1 RID: 218801
			public const int OldText = 4;

			// Token: 0x040356B2 RID: 218802
			public const int NewText = 5;
		}
	}
}
