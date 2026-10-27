using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu.DropDownLogic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x0200540E RID: 21518
	public class MenuScrollSettingDropDown : MenuScrollSettingBaseItem
	{
		// Token: 0x06036FF0 RID: 225264 RVA: 0x00D08114 File Offset: 0x00D06314
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

		// Token: 0x06036FF1 RID: 225265 RVA: 0x00D081B0 File Offset: 0x00D063B0
		[NullableContext(1)]
		private TableTextArgNew GetDropDownTextId(object data)
		{
			return this.Logic.GetDataTextId(data, this.Data);
		}

		// Token: 0x06036FF2 RID: 225266 RVA: 0x00D081C4 File Offset: 0x00D063C4
		protected override UniTask OnBeforeStartAsync()
		{
			MenuScrollSettingDropDown.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuScrollSettingDropDown.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036FF3 RID: 225267 RVA: 0x00D08207 File Offset: 0x00D06407
		protected override void OnStart()
		{
		}

		// Token: 0x06036FF4 RID: 225268 RVA: 0x00D08209 File Offset: 0x00D06409
		protected override void OnBeforeDestroy()
		{
			this.DropDown.Destroy(null);
		}

		// Token: 0x06036FF5 RID: 225269 RVA: 0x00D08217 File Offset: 0x00D06417
		private void RefreshTitle()
		{
			base.GetText(0).ShowTextNew(this.Data.FunctionName ?? "");
		}

		// Token: 0x06036FF6 RID: 225270 RVA: 0x00D0823C File Offset: 0x00D0643C
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

		// Token: 0x06036FF7 RID: 225271 RVA: 0x00D082A0 File Offset: 0x00D064A0
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

		// Token: 0x06036FF8 RID: 225272 RVA: 0x00D082CC File Offset: 0x00D064CC
		public override UniTask ClearAsync()
		{
			MenuScrollSettingDropDown.<ClearAsync>d__11 <ClearAsync>d__;
			<ClearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearAsync>d__.<>4__this = this;
			<ClearAsync>d__.<>1__state = -1;
			<ClearAsync>d__.<>t__builder.Start<MenuScrollSettingDropDown.<ClearAsync>d__11>(ref <ClearAsync>d__);
			return <ClearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036FF9 RID: 225273 RVA: 0x00D0830F File Offset: 0x00D0650F
		public override void SetInteractionActive(bool val)
		{
		}

		// Token: 0x06036FFA RID: 225274 RVA: 0x00D08314 File Offset: 0x00D06514
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

		// Token: 0x06036FFB RID: 225275 RVA: 0x00D083C4 File Offset: 0x00D065C4
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

		// Token: 0x06036FFC RID: 225276 RVA: 0x00D0840D File Offset: 0x00D0660D
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

		// Token: 0x06036FFD RID: 225277 RVA: 0x00D08434 File Offset: 0x00D06634
		public UniTask RefreshDetailSprite()
		{
			MenuScrollSettingDropDown.<RefreshDetailSprite>d__16 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<MenuScrollSettingDropDown.<RefreshDetailSprite>d__16>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x0401D040 RID: 118848
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private CommonDropDown<TableTextArgNew, object> DropDown;

		// Token: 0x0401D041 RID: 118849
		[Nullable(2)]
		private DropDownLogicBase Logic;

		// Token: 0x0200B6A1 RID: 46753
		private class ECompDefine
		{
			// Token: 0x04037549 RID: 226633
			public const int Title = 0;

			// Token: 0x0403754A RID: 226634
			public const int DropDown = 1;

			// Token: 0x0403754B RID: 226635
			public const int DetailItem = 2;

			// Token: 0x0403754C RID: 226636
			public const int DetailText = 3;

			// Token: 0x0403754D RID: 226637
			public const int DetailSprite = 4;

			// Token: 0x0403754E RID: 226638
			public const int DetailToggleTransition = 5;
		}
	}
}
