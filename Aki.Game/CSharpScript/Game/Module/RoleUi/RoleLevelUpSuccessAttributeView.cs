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
	// Token: 0x02004CDB RID: 19675
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleLevelUpSuccessAttributeView : UiViewBase
	{
		// Token: 0x06032CA0 RID: 208032 RVA: 0x00BD5853 File Offset: 0x00BD3A53
		[NullableContext(1)]
		public RoleLevelUpSuccessAttributeView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032CA1 RID: 208033 RVA: 0x00BD585C File Offset: 0x00BD3A5C
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

		// Token: 0x06032CA2 RID: 208034 RVA: 0x00BD59BC File Offset: 0x00BD3BBC
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

		// Token: 0x06032CA3 RID: 208035 RVA: 0x00BD5A08 File Offset: 0x00BD3C08
		protected override UniTask OnBeforeStartAsync()
		{
			RoleLevelUpSuccessAttributeView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleLevelUpSuccessAttributeView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032CA4 RID: 208036 RVA: 0x00BD5A4C File Offset: 0x00BD3C4C
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

		// Token: 0x06032CA5 RID: 208037 RVA: 0x00BD5B47 File Offset: 0x00BD3D47
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x06032CA6 RID: 208038 RVA: 0x00BD5B4F File Offset: 0x00BD3D4F
		protected override void OnBeforeDestroy()
		{
			this.LevelPanel.Destroy(null);
			this.LevelPanel = null;
			this.AttributeDynScrollView.ClearChildren();
			this.AttributeDynScrollView = null;
		}

		// Token: 0x06032CA7 RID: 208039 RVA: 0x00BD5B78 File Offset: 0x00BD3D78
		private void SetAudio()
		{
			string audioId = this.Data.AudioId;
			if (audioId != null)
			{
				string path = AudioConfig.Instance.GetAudioPath(audioId).Value.Path;
				base.SetAudioEvent(path);
			}
		}

		// Token: 0x06032CA8 RID: 208040 RVA: 0x00BD5BB8 File Offset: 0x00BD3DB8
		private void OnClickButton()
		{
			Action clickFunction = this.Data.ClickFunction;
			if (clickFunction != null)
			{
				clickFunction();
			}
			base.CloseMe(null);
		}

		// Token: 0x06032CA9 RID: 208041 RVA: 0x00BD5BE1 File Offset: 0x00BD3DE1
		public void Refresh()
		{
			this.SetTitle();
			this.SetTipsText();
			this.RefreshLevelPanel();
			this.RefreshStrengthInfo();
			this.RefreshAttributePanel();
			this.RefreshArrowPanel();
		}

		// Token: 0x06032CAA RID: 208042 RVA: 0x00BD5C08 File Offset: 0x00BD3E08
		private void SetTipsText()
		{
			string key = this.Data.ClickText ?? "Text_BackToView_Text";
			base.GetText(1).ShowTextNew(key);
		}

		// Token: 0x06032CAB RID: 208043 RVA: 0x00BD5C38 File Offset: 0x00BD3E38
		private void SetTitle()
		{
			string key = this.Data.Title ?? "Text_LevelUpSuccessful_Text";
			base.GetText(0).ShowTextNew(key);
		}

		// Token: 0x06032CAC RID: 208044 RVA: 0x00BD5C68 File Offset: 0x00BD3E68
		private void RefreshLevelPanel()
		{
			ILevelInfo levelInfo = this.Data.LevelInfo;
			if (levelInfo != null)
			{
				this.LevelPanel.Refresh(levelInfo.PreUpgradeLv, levelInfo.UpgradeLv, levelInfo.FormatStringId, levelInfo.IsMaxLevel);
			}
			base.GetItem(5).SetUIActive(levelInfo != null);
		}

		// Token: 0x06032CAD RID: 208045 RVA: 0x00BD5CB8 File Offset: 0x00BD3EB8
		private void RefreshStrengthInfo()
		{
			IStrengthUpgradeData strengthUpgradeData = this.Data.StrengthUpgradeData;
			if (strengthUpgradeData != null)
			{
				this.StrengthItem.Update(strengthUpgradeData);
			}
		}

		// Token: 0x06032CAE RID: 208046 RVA: 0x00BD5CE0 File Offset: 0x00BD3EE0
		private void RefreshAttributePanel()
		{
			if (this.Data.AttributeInfo == null || this.Data.AttributeInfo.Count == 0)
			{
				base.GetUIDynScrollViewComponent(6).RootUIComp.Get().SetUIActive(false);
				return;
			}
			this.AttributeDynScrollView.RefreshByData(this.Data.AttributeInfo.ToArray(), false, false);
		}

		// Token: 0x06032CAF RID: 208047 RVA: 0x00BD5D44 File Offset: 0x00BD3F44
		private void RefreshArrowPanel()
		{
			base.GetItem(4).SetUIActive(this.Data.IsShowArrow.GetValueOrDefault());
		}

		// Token: 0x0401B0A4 RID: 110756
		private ILevelUpSuccessAttributeData Data;

		// Token: 0x0401B0A5 RID: 110757
		private LevelShowItem LevelPanel;

		// Token: 0x0401B0A6 RID: 110758
		private StrengthUpgradeBarItem StrengthItem;

		// Token: 0x0401B0A7 RID: 110759
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<AttributeDynScrollItem, AttributeSlotDynItem, IAttributeInfo> AttributeDynScrollView;

		// Token: 0x0401B0A8 RID: 110760
		private AttributeSlotDynItem AttributeSlotDynItem;

		// Token: 0x0200AE53 RID: 44627
		[NullableContext(0)]
		private enum ERoleSuccessAttributeNode
		{
			// Token: 0x04034EE1 RID: 216801
			Title,
			// Token: 0x04034EE2 RID: 216802
			TipsText,
			// Token: 0x04034EE3 RID: 216803
			TipsButton,
			// Token: 0x04034EE4 RID: 216804
			AttributeSlot,
			// Token: 0x04034EE5 RID: 216805
			PanelArrow,
			// Token: 0x04034EE6 RID: 216806
			PanelLevel,
			// Token: 0x04034EE7 RID: 216807
			DynScrollView,
			// Token: 0x04034EE8 RID: 216808
			ButtonScrollView,
			// Token: 0x04034EE9 RID: 216809
			AttributeContent,
			// Token: 0x04034EEA RID: 216810
			AttributeSlotWider,
			// Token: 0x04034EEB RID: 216811
			StrengthItem,
			// Token: 0x04034EEC RID: 216812
			SoarStrengthItem
		}
	}
}
