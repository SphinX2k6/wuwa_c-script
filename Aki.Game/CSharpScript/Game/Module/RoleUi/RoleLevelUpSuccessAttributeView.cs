using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C8D RID: 15501
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleLevelUpSuccessAttributeView : UiViewBase
	{
		// Token: 0x06027A75 RID: 162421 RVA: 0x00B1AF5A File Offset: 0x00B1915A
		[NullableContext(1)]
		public RoleLevelUpSuccessAttributeView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06027A76 RID: 162422 RVA: 0x00B1AF64 File Offset: 0x00B19164
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIDynScrollViewComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickButton)),
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickButton))
			};
		}

		// Token: 0x06027A77 RID: 162423 RVA: 0x00B1B0C4 File Offset: 0x00B192C4
		protected override void OnBeforeCreate()
		{
			if (this.OpenParam == null)
			{
				Log.Instance.Error(ELogModule.Role, ELogAuthor.YYZ, "RoleLevelUpSuccessAttributeView 打开失败,未传入界面数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Data = (ILevelUpSuccessAttributeData)this.OpenParam;
			this.SetAudio();
		}

		// Token: 0x06027A78 RID: 162424 RVA: 0x00B1B110 File Offset: 0x00B19310
		protected override UniTask OnBeforeStartAsync()
		{
			RoleLevelUpSuccessAttributeView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleLevelUpSuccessAttributeView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027A79 RID: 162425 RVA: 0x00B1B154 File Offset: 0x00B19354
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(5);
			this.LevelPanel = new LevelShowItem();
			this.LevelPanel.CreateThenShowByActor(item.GetOwner(), null);
			bool valueOrDefault = this.Data.WiderScrollView.GetValueOrDefault();
			base.GetItem(9).SetUIActive(valueOrDefault);
			base.GetItem(3).SetUIActive(!valueOrDefault);
			UUIItem uuiitem = valueOrDefault ? base.GetItem(9) : base.GetItem(3);
			UUIDynScrollViewComponent uidynScrollViewComponent = base.GetUIDynScrollViewComponent(6);
			uidynScrollViewComponent.RootUIComp.Get().SetWidth(uuiitem.GetWidth());
			base.GetItem(8).SetWidth(uuiitem.GetWidth());
			this.AttributeSlotDynItem = new AttributeSlotDynItem();
			this.AttributeDynScrollView = new DynamicScrollView<AttributeDynScrollItem, AttributeSlotDynItem, IAttributeInfo>(uidynScrollViewComponent, uuiitem, this.AttributeSlotDynItem, (IAttributeInfo _1, UUIItem _2, int _3) => new AttributeDynScrollItem());
			this.AttributeDynScrollView.Init().Forget();
		}

		// Token: 0x06027A7A RID: 162426 RVA: 0x00B1B24F File Offset: 0x00B1944F
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x06027A7B RID: 162427 RVA: 0x00B1B257 File Offset: 0x00B19457
		protected override void OnBeforeDestroy()
		{
			this.LevelPanel.Destroy(null);
			this.LevelPanel = null;
			this.AttributeDynScrollView.ClearChildren();
			this.AttributeDynScrollView = null;
		}

		// Token: 0x06027A7C RID: 162428 RVA: 0x00B1B280 File Offset: 0x00B19480
		private void SetAudio()
		{
			string audioId = this.Data.AudioId;
			if (audioId != null)
			{
				string path = AudioConfig.Instance.GetAudioPath(audioId).Value.Path;
				base.SetAudioEvent(path);
			}
		}

		// Token: 0x06027A7D RID: 162429 RVA: 0x00B1B2C0 File Offset: 0x00B194C0
		private void OnClickButton()
		{
			Action clickFunction = this.Data.ClickFunction;
			if (clickFunction != null)
			{
				clickFunction();
			}
			base.CloseMe(null);
		}

		// Token: 0x06027A7E RID: 162430 RVA: 0x00B1B2E9 File Offset: 0x00B194E9
		public void Refresh()
		{
			this.SetTitle();
			this.SetTipsText();
			this.RefreshLevelPanel();
			this.RefreshStrengthInfo();
			this.RefreshAttributePanel();
			this.RefreshArrowPanel();
		}

		// Token: 0x06027A7F RID: 162431 RVA: 0x00B1B310 File Offset: 0x00B19510
		private void SetTipsText()
		{
			string key = this.Data.ClickText ?? "Text_BackToView_Text";
			base.GetText(1).ShowTextNew(key);
		}

		// Token: 0x06027A80 RID: 162432 RVA: 0x00B1B340 File Offset: 0x00B19540
		private void SetTitle()
		{
			string key = this.Data.Title ?? "Text_LevelUpSuccessful_Text";
			base.GetText(0).ShowTextNew(key);
		}

		// Token: 0x06027A81 RID: 162433 RVA: 0x00B1B370 File Offset: 0x00B19570
		private void RefreshLevelPanel()
		{
			ILevelInfo levelInfo = this.Data.LevelInfo;
			if (levelInfo != null)
			{
				this.LevelPanel.Refresh(levelInfo.PreUpgradeLv, levelInfo.UpgradeLv, levelInfo.FormatStringId, levelInfo.IsMaxLevel);
			}
			base.GetItem(5).SetUIActive(levelInfo != null);
		}

		// Token: 0x06027A82 RID: 162434 RVA: 0x00B1B3C0 File Offset: 0x00B195C0
		private void RefreshStrengthInfo()
		{
			IStrengthUpgradeData strengthUpgradeData = this.Data.StrengthUpgradeData;
			if (strengthUpgradeData != null)
			{
				this.StrengthItem.Update(strengthUpgradeData);
			}
		}

		// Token: 0x06027A83 RID: 162435 RVA: 0x00B1B3E8 File Offset: 0x00B195E8
		private void RefreshAttributePanel()
		{
			if (this.Data.AttributeInfo == null || this.Data.AttributeInfo.Count == 0)
			{
				base.GetUIDynScrollViewComponent(6).RootUIComp.Get().SetUIActive(false);
				return;
			}
			this.AttributeDynScrollView.RefreshByData(this.Data.AttributeInfo.ToArray(), false, false);
		}

		// Token: 0x06027A84 RID: 162436 RVA: 0x00B1B44C File Offset: 0x00B1964C
		private void RefreshArrowPanel()
		{
			base.GetItem(4).SetUIActive(this.Data.IsShowArrow.GetValueOrDefault());
		}

		// Token: 0x04015A28 RID: 88616
		private ILevelUpSuccessAttributeData Data;

		// Token: 0x04015A29 RID: 88617
		private LevelShowItem LevelPanel;

		// Token: 0x04015A2A RID: 88618
		private StrengthUpgradeBarItem StrengthItem;

		// Token: 0x04015A2B RID: 88619
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<AttributeDynScrollItem, AttributeSlotDynItem, IAttributeInfo> AttributeDynScrollView;

		// Token: 0x04015A2C RID: 88620
		private AttributeSlotDynItem AttributeSlotDynItem;

		// Token: 0x02009872 RID: 39026
		[NullableContext(0)]
		private enum ERoleSuccessAttributeNode
		{
			// Token: 0x0402F889 RID: 194697
			Title,
			// Token: 0x0402F88A RID: 194698
			TipsText,
			// Token: 0x0402F88B RID: 194699
			TipsButton,
			// Token: 0x0402F88C RID: 194700
			AttributeSlot,
			// Token: 0x0402F88D RID: 194701
			PanelArrow,
			// Token: 0x0402F88E RID: 194702
			PanelLevel,
			// Token: 0x0402F88F RID: 194703
			DynScrollView,
			// Token: 0x0402F890 RID: 194704
			ButtonScrollView,
			// Token: 0x0402F891 RID: 194705
			AttributeContent,
			// Token: 0x0402F892 RID: 194706
			AttributeSlotWider,
			// Token: 0x0402F893 RID: 194707
			StrengthItem,
			// Token: 0x0402F894 RID: 194708
			SoarStrengthItem
		}
	}
}
