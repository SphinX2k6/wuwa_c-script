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
	// Token: 0x02003E05 RID: 15877
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleReplaceView : RogueSelectBaseView
	{
		// Token: 0x06028889 RID: 166025 RVA: 0x00B5EE73 File Offset: 0x00B5D073
		public RoleReplaceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602888A RID: 166026 RVA: 0x00B5EEA4 File Offset: 0x00B5D0A4
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

		// Token: 0x0602888B RID: 166027 RVA: 0x00B5EF94 File Offset: 0x00B5D194
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

		// Token: 0x0602888C RID: 166028 RVA: 0x00B5EFFC File Offset: 0x00B5D1FC
		protected override UniTask OnCreateAsync()
		{
			RoleReplaceView.<OnCreateAsync>d__9 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<RoleReplaceView.<OnCreateAsync>d__9>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602888D RID: 166029 RVA: 0x00B5F040 File Offset: 0x00B5D240
		protected override UniTask OnBeforeStartAsync()
		{
			RoleReplaceView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleReplaceView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602888E RID: 166030 RVA: 0x00B5F084 File Offset: 0x00B5D284
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

		// Token: 0x0602888F RID: 166031 RVA: 0x00B5F136 File Offset: 0x00B5D336
		protected override void OnBeforeDestroy()
		{
			this.TopPanel.Destroy(null);
			this.ElementPanel.Destroy(null);
			base.RecycleUiPoolActor();
		}

		// Token: 0x06028890 RID: 166032 RVA: 0x00B5F156 File Offset: 0x00B5D356
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x06028891 RID: 166033 RVA: 0x00B5F15E File Offset: 0x00B5D35E
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x06028892 RID: 166034 RVA: 0x00B5F168 File Offset: 0x00B5D368
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

		// Token: 0x06028893 RID: 166035 RVA: 0x00B5F1D3 File Offset: 0x00B5D3D3
		private void Refresh()
		{
			this.RefreshPhantomSelectItemList();
			this.RefreshTopPanel();
			this.RefreshElementPanel();
			this.RefreshBtnText();
			this.RefreshOldNewText();
		}

		// Token: 0x06028894 RID: 166036 RVA: 0x00B5F1F4 File Offset: 0x00B5D3F4
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

		// Token: 0x06028895 RID: 166037 RVA: 0x00B5F2AD File Offset: 0x00B5D4AD
		protected void RefreshElementPanel()
		{
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x06028896 RID: 166038 RVA: 0x00B5F2BC File Offset: 0x00B5D4BC
		protected void RefreshPhantomSelectItemList()
		{
			List<RogueGainEntry> rogueGainEntryList = this.GetRogueGainEntryList();
			this.RoleSelectItemLayout.RefreshByData(rogueGainEntryList, null, false);
		}

		// Token: 0x06028897 RID: 166039 RVA: 0x00B5F2DE File Offset: 0x00B5D4DE
		protected void RefreshBtnText()
		{
			this.ButtonItem.SetShowText("RoguelikeView_14_Text");
		}

		// Token: 0x06028898 RID: 166040 RVA: 0x00B5F2F0 File Offset: 0x00B5D4F0
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

		// Token: 0x06028899 RID: 166041 RVA: 0x00B5F348 File Offset: 0x00B5D548
		private void RefreshOldNewText()
		{
			base.GetText(4).ShowTextNew("RoguelikeView_23_Text");
			base.GetText(5).ShowTextNew("RoguelikeView_24_Text");
		}

		// Token: 0x04015FF0 RID: 90096
		[Nullable(2)]
		protected RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x04015FF1 RID: 90097
		[Nullable(2)]
		protected TopPanel TopPanel;

		// Token: 0x04015FF2 RID: 90098
		[Nullable(2)]
		protected ElementPanel ElementPanel;

		// Token: 0x04015FF3 RID: 90099
		[Nullable(2)]
		protected ButtonItem ButtonItem;

		// Token: 0x04015FF4 RID: 90100
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RoleSelectItem, RogueGainEntry> RoleSelectItemLayout;

		// Token: 0x04015FF5 RID: 90101
		protected readonly Func<RoleSelectItem> CreateRoleSelectItem = () => new RoleSelectItem();

		// Token: 0x02009A24 RID: 39460
		[NullableContext(0)]
		private static class ERoleReplaceViewCom
		{
			// Token: 0x040300DD RID: 196829
			public const int TopPanelItem = 0;

			// Token: 0x040300DE RID: 196830
			public const int ItemListLayout = 1;

			// Token: 0x040300DF RID: 196831
			public const int ConfirmBtn = 2;

			// Token: 0x040300E0 RID: 196832
			public const int ElementPanelItem = 3;

			// Token: 0x040300E1 RID: 196833
			public const int OldText = 4;

			// Token: 0x040300E2 RID: 196834
			public const int NewText = 5;
		}
	}
}
