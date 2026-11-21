using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.View.Components;
using CSharpScript.Game.Module.Kurotato.View.Overview;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004756 RID: 18262
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoCommonPopupPanel : UiPanelBase
	{
		// Token: 0x0602DD74 RID: 187764 RVA: 0x00CD4A1C File Offset: 0x00CD2C1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DD75 RID: 187765 RVA: 0x00CD4B04 File Offset: 0x00CD2D04
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoCommonPopupPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD76 RID: 187766 RVA: 0x00CD4B48 File Offset: 0x00CD2D48
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.KurotatoOnItemUpdate, new Action<int, bool>(this.OnItemUpdate));
			EventSystem.Instance.Add(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnWeaponUpdate));
			this.CaptionItem.SetCloseBtnActive(false);
			this.SetCloseBtnVisible(true);
		}

		// Token: 0x0602DD77 RID: 187767 RVA: 0x00CD4BA0 File Offset: 0x00CD2DA0
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int, bool>(EEventName.KurotatoOnItemUpdate, new Action<int, bool>(this.OnItemUpdate));
			EventSystem.Instance.Remove(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnWeaponUpdate));
		}

		// Token: 0x0602DD78 RID: 187768 RVA: 0x00CD4BDC File Offset: 0x00CD2DDC
		private UniTask CreateCaption()
		{
			KurotatoCommonPopupPanel.<CreateCaption>d__10 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<CreateCaption>d__10>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD79 RID: 187769 RVA: 0x00CD4C20 File Offset: 0x00CD2E20
		private UniTask CreateCostInfoItem()
		{
			KurotatoCommonPopupPanel.<CreateCostInfoItem>d__11 <CreateCostInfoItem>d__;
			<CreateCostInfoItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCostInfoItem>d__.<>4__this = this;
			<CreateCostInfoItem>d__.<>1__state = -1;
			<CreateCostInfoItem>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<CreateCostInfoItem>d__11>(ref <CreateCostInfoItem>d__);
			return <CreateCostInfoItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD7A RID: 187770 RVA: 0x00CD4C64 File Offset: 0x00CD2E64
		private UniTask CreateRoleAttributePanel()
		{
			KurotatoCommonPopupPanel.<CreateRoleAttributePanel>d__12 <CreateRoleAttributePanel>d__;
			<CreateRoleAttributePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRoleAttributePanel>d__.<>4__this = this;
			<CreateRoleAttributePanel>d__.<>1__state = -1;
			<CreateRoleAttributePanel>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<CreateRoleAttributePanel>d__12>(ref <CreateRoleAttributePanel>d__);
			return <CreateRoleAttributePanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD7B RID: 187771 RVA: 0x00CD4CA8 File Offset: 0x00CD2EA8
		private UniTask CreateCurrencyAsync()
		{
			KurotatoCommonPopupPanel.<CreateCurrencyAsync>d__13 <CreateCurrencyAsync>d__;
			<CreateCurrencyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCurrencyAsync>d__.<>4__this = this;
			<CreateCurrencyAsync>d__.<>1__state = -1;
			<CreateCurrencyAsync>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<CreateCurrencyAsync>d__13>(ref <CreateCurrencyAsync>d__);
			return <CreateCurrencyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD7C RID: 187772 RVA: 0x00CD4CEB File Offset: 0x00CD2EEB
		public void SetCloseCb(Action cb)
		{
			this.CloseCb = cb;
		}

		// Token: 0x0602DD7D RID: 187773 RVA: 0x00CD4CF4 File Offset: 0x00CD2EF4
		public void SetCloseBtnVisible(bool isVisible)
		{
			UUIItem uuiitem = base.GetButton(1).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(isVisible);
		}

		// Token: 0x0602DD7E RID: 187774 RVA: 0x00CD4D20 File Offset: 0x00CD2F20
		public void SetHelpButtonCallBack(Action cb)
		{
			this.CaptionItem.SetHelpCallBack(cb);
		}

		// Token: 0x0602DD7F RID: 187775 RVA: 0x00CD4D2E File Offset: 0x00CD2F2E
		public void SetTitleLocalText(string textId)
		{
			this.CaptionItem.SetTitleLocalText(textId);
		}

		// Token: 0x0602DD80 RID: 187776 RVA: 0x00CD4D3C File Offset: 0x00CD2F3C
		public void SetCostInfoVisible(bool isVisible)
		{
			this.CostInfoItem.SetUiActive(isVisible);
		}

		// Token: 0x0602DD81 RID: 187777 RVA: 0x00CD4D4A File Offset: 0x00CD2F4A
		public void ShowAttrPreview(IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			this.RoleAttributePanel.ShowPreview(deltas);
		}

		// Token: 0x0602DD82 RID: 187778 RVA: 0x00CD4D58 File Offset: 0x00CD2F58
		public void ClearAttrPreview()
		{
			this.RoleAttributePanel.ClearPreview();
		}

		// Token: 0x0602DD83 RID: 187779 RVA: 0x00CD4D65 File Offset: 0x00CD2F65
		public void HideAttrChangeFx()
		{
			this.RoleAttributePanel.HideAllChangeFx();
		}

		// Token: 0x0602DD84 RID: 187780 RVA: 0x00CD4D72 File Offset: 0x00CD2F72
		private void OnItemUpdate(int itemId, bool bIsAdd)
		{
			this.RoleAttributePanel.RefreshAttributeList();
		}

		// Token: 0x0602DD85 RID: 187781 RVA: 0x00CD4D7F File Offset: 0x00CD2F7F
		private void OnWeaponUpdate()
		{
			this.RoleAttributePanel.RefreshAttributeList();
		}

		// Token: 0x0602DD86 RID: 187782 RVA: 0x00CD4D8C File Offset: 0x00CD2F8C
		private void OnClickClose()
		{
			Action closeCb = this.CloseCb;
			if (closeCb == null)
			{
				return;
			}
			closeCb();
		}

		// Token: 0x040187E9 RID: 100329
		private readonly PopupCaptionItem CaptionItem = new PopupCaptionItem(null);

		// Token: 0x040187EA RID: 100330
		private readonly CostInfoItem CostInfoItem = new CostInfoItem();

		// Token: 0x040187EB RID: 100331
		private readonly KurotatoCurrencyItem CurrencyItem = new KurotatoCurrencyItem();

		// Token: 0x040187EC RID: 100332
		private readonly KurotatoAttributePanel RoleAttributePanel = new KurotatoAttributePanel();

		// Token: 0x040187ED RID: 100333
		[Nullable(2)]
		private Action CloseCb;

		// Token: 0x0200A3B1 RID: 41905
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x04032BE3 RID: 207843
			public const int Caption = 0;

			// Token: 0x04032BE4 RID: 207844
			public const int BtnBack = 1;

			// Token: 0x04032BE5 RID: 207845
			public const int CostInfo = 2;

			// Token: 0x04032BE6 RID: 207846
			public const int RoleAttr = 3;
		}
	}
}
