using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu.DropDownLogic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043F1 RID: 17393
	public class MenuScrollSettingDropDown : MenuScrollSettingBaseItem
	{
		// Token: 0x0602BF39 RID: 180025 RVA: 0x00C57530 File Offset: 0x00C55730
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggleSpriteTransition))
			};
		}

		// Token: 0x0602BF3A RID: 180026 RVA: 0x00C575CC File Offset: 0x00C557CC
		[NullableContext(1)]
		private TableTextArgNew GetDropDownTextId(object data)
		{
			return this.Logic.GetDataTextId(data, this.Data);
		}

		// Token: 0x0602BF3B RID: 180027 RVA: 0x00C575E0 File Offset: 0x00C557E0
		protected override UniTask OnBeforeStartAsync()
		{
			MenuScrollSettingDropDown.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuScrollSettingDropDown.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BF3C RID: 180028 RVA: 0x00C57623 File Offset: 0x00C55823
		protected override void OnStart()
		{
		}

		// Token: 0x0602BF3D RID: 180029 RVA: 0x00C57625 File Offset: 0x00C55825
		protected override void OnBeforeDestroy()
		{
			this.DropDown.Destroy(null);
		}

		// Token: 0x0602BF3E RID: 180030 RVA: 0x00C57633 File Offset: 0x00C55833
		private void RefreshTitle()
		{
			base.GetText(0).ShowTextNew(this.Data.FunctionName ?? "");
		}

		// Token: 0x0602BF3F RID: 180031 RVA: 0x00C57658 File Offset: 0x00C55858
		private void RefreshDropDown()
		{
			this.Logic = DropDownLogicCreator.GetDropDownLogic(this.Data.FunctionId);
			if (this.Logic == null)
			{
				return;
			}
			IReadOnlyList<object> dropDownDataList = this.Logic.GetDropDownDataList();
			int defaultIndex = this.Logic.GetDefaultIndex(this.Data);
			this.DropDown.InitScroll(dropDownDataList, new Func<object, TableTextArgNew>(this.GetDropDownTextId), defaultIndex, true);
		}

		// Token: 0x0602BF40 RID: 180032 RVA: 0x00C576BC File Offset: 0x00C558BC
		[NullableContext(1)]
		public override void Update(MenuData data, bool bGameSettingsUpdate)
		{
			this.Data = data;
			this.RefreshTitle();
			this.RefreshDropDown();
			this.RefreshDetailText();
			this.RefreshDetailSpriteVisible();
			this.RefreshDetailSprite().Forget();
		}

		// Token: 0x0602BF41 RID: 180033 RVA: 0x00C576E8 File Offset: 0x00C558E8
		public override UniTask ClearAsync()
		{
			MenuScrollSettingDropDown.<ClearAsync>d__11 <ClearAsync>d__;
			<ClearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearAsync>d__.<>4__this = this;
			<ClearAsync>d__.<>1__state = -1;
			<ClearAsync>d__.<>t__builder.Start<MenuScrollSettingDropDown.<ClearAsync>d__11>(ref <ClearAsync>d__);
			return <ClearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BF42 RID: 180034 RVA: 0x00C5772B File Offset: 0x00C5592B
		public override void SetInteractionActive(bool val)
		{
		}

		// Token: 0x0602BF43 RID: 180035 RVA: 0x00C57730 File Offset: 0x00C55930
		protected override void OnSetDetailVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(bVisible);
			}
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.CanClickWhenDisable && !this.Data.GetEnable())
			{
				FColor color = bVisible ? FColor.FromHex("FFF7B6FF") : FColor.FromHex("FFFFFFFF");
				base.GetSprite(4).SetColor(color);
				base.GetUiExtendToggleSpriteTransition(5).TransitionState.UnDetermineUnHoverState.Color = color;
				base.GetUiExtendToggleSpriteTransition(5).TransitionState.UnDetermineHoverState.Color = color;
				base.GetUiExtendToggleSpriteTransition(5).TransitionState.UnDeterminePressedState.Color = color;
			}
		}

		// Token: 0x0602BF44 RID: 180036 RVA: 0x00C577E0 File Offset: 0x00C559E0
		private void RefreshDetailText()
		{
			if (this.Data == null)
			{
				return;
			}
			if (!this.Data.HasDetailText())
			{
				return;
			}
			UUIText text = base.GetText(3);
			string detailTextId = this.Data.GetDetailTextId();
			LguiUtil.Instance.SetLocalTextNew(text, detailTextId, Array.Empty<object>());
		}

		// Token: 0x0602BF45 RID: 180037 RVA: 0x00C57829 File Offset: 0x00C55A29
		private void RefreshDetailSpriteVisible()
		{
			if (this.Data == null)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(this.Data.ShowHelpBtn());
		}

		// Token: 0x0602BF46 RID: 180038 RVA: 0x00C57850 File Offset: 0x00C55A50
		public UniTask RefreshDetailSprite()
		{
			MenuScrollSettingDropDown.<RefreshDetailSprite>d__16 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<MenuScrollSettingDropDown.<RefreshDetailSprite>d__16>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x04017AD9 RID: 96985
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private CommonDropDown<TableTextArgNew, object> DropDown;

		// Token: 0x04017ADA RID: 96986
		[Nullable(2)]
		private DropDownLogicBase Logic;

		// Token: 0x0200A0D9 RID: 41177
		private class ECompDefine
		{
			// Token: 0x04031F9E RID: 204702
			public const int Title = 0;

			// Token: 0x04031F9F RID: 204703
			public const int DropDown = 1;

			// Token: 0x04031FA0 RID: 204704
			public const int DetailItem = 2;

			// Token: 0x04031FA1 RID: 204705
			public const int DetailText = 3;

			// Token: 0x04031FA2 RID: 204706
			public const int DetailSprite = 4;

			// Token: 0x04031FA3 RID: 204707
			public const int DetailToggleTransition = 5;
		}
	}
}
