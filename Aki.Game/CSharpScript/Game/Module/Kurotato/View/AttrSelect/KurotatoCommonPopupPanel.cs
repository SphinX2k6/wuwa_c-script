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
	// Token: 0x0200577F RID: 22399
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoCommonPopupPanel : UiPanelBase
	{
		// Token: 0x06038E64 RID: 233060 RVA: 0x00D85D5C File Offset: 0x00D83F5C
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

		// Token: 0x06038E65 RID: 233061 RVA: 0x00D85E44 File Offset: 0x00D84044
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoCommonPopupPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E66 RID: 233062 RVA: 0x00D85E88 File Offset: 0x00D84088
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.KurotatoOnItemUpdate, new Action<int, bool>(this.OnItemUpdate));
			EventSystem.Instance.Add(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnWeaponUpdate));
			this.CaptionItem.SetCloseBtnActive(false);
			this.SetCloseBtnVisible(true);
		}

		// Token: 0x06038E67 RID: 233063 RVA: 0x00D85EE0 File Offset: 0x00D840E0
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int, bool>(EEventName.KurotatoOnItemUpdate, new Action<int, bool>(this.OnItemUpdate));
			EventSystem.Instance.Remove(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnWeaponUpdate));
		}

		// Token: 0x06038E68 RID: 233064 RVA: 0x00D85F1C File Offset: 0x00D8411C
		private UniTask CreateCaption()
		{
			KurotatoCommonPopupPanel.<CreateCaption>d__10 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<CreateCaption>d__10>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06038E69 RID: 233065 RVA: 0x00D85F60 File Offset: 0x00D84160
		private UniTask CreateCostInfoItem()
		{
			KurotatoCommonPopupPanel.<CreateCostInfoItem>d__11 <CreateCostInfoItem>d__;
			<CreateCostInfoItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCostInfoItem>d__.<>4__this = this;
			<CreateCostInfoItem>d__.<>1__state = -1;
			<CreateCostInfoItem>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<CreateCostInfoItem>d__11>(ref <CreateCostInfoItem>d__);
			return <CreateCostInfoItem>d__.<>t__builder.Task;
		}

		// Token: 0x06038E6A RID: 233066 RVA: 0x00D85FA4 File Offset: 0x00D841A4
		private UniTask CreateRoleAttributePanel()
		{
			KurotatoCommonPopupPanel.<CreateRoleAttributePanel>d__12 <CreateRoleAttributePanel>d__;
			<CreateRoleAttributePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRoleAttributePanel>d__.<>4__this = this;
			<CreateRoleAttributePanel>d__.<>1__state = -1;
			<CreateRoleAttributePanel>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<CreateRoleAttributePanel>d__12>(ref <CreateRoleAttributePanel>d__);
			return <CreateRoleAttributePanel>d__.<>t__builder.Task;
		}

		// Token: 0x06038E6B RID: 233067 RVA: 0x00D85FE8 File Offset: 0x00D841E8
		private UniTask CreateCurrencyAsync()
		{
			KurotatoCommonPopupPanel.<CreateCurrencyAsync>d__13 <CreateCurrencyAsync>d__;
			<CreateCurrencyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCurrencyAsync>d__.<>4__this = this;
			<CreateCurrencyAsync>d__.<>1__state = -1;
			<CreateCurrencyAsync>d__.<>t__builder.Start<KurotatoCommonPopupPanel.<CreateCurrencyAsync>d__13>(ref <CreateCurrencyAsync>d__);
			return <CreateCurrencyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E6C RID: 233068 RVA: 0x00D8602B File Offset: 0x00D8422B
		public void SetCloseCb(Action cb)
		{
			this.CloseCb = cb;
		}

		// Token: 0x06038E6D RID: 233069 RVA: 0x00D86034 File Offset: 0x00D84234
		public void SetCloseBtnVisible(bool isVisible)
		{
			UUIItem uuiitem = base.GetButton(1).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(isVisible);
		}

		// Token: 0x06038E6E RID: 233070 RVA: 0x00D86060 File Offset: 0x00D84260
		public void SetHelpButtonCallBack(Action cb)
		{
			this.CaptionItem.SetHelpCallBack(cb);
		}

		// Token: 0x06038E6F RID: 233071 RVA: 0x00D8606E File Offset: 0x00D8426E
		public void SetTitleLocalText(string textId)
		{
			this.CaptionItem.SetTitleLocalText(textId);
		}

		// Token: 0x06038E70 RID: 233072 RVA: 0x00D8607C File Offset: 0x00D8427C
		public void SetCostInfoVisible(bool isVisible)
		{
			this.CostInfoItem.SetUiActive(isVisible);
		}

		// Token: 0x06038E71 RID: 233073 RVA: 0x00D8608A File Offset: 0x00D8428A
		public void ShowAttrPreview(IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			this.RoleAttributePanel.ShowPreview(deltas);
		}

		// Token: 0x06038E72 RID: 233074 RVA: 0x00D86098 File Offset: 0x00D84298
		public void ClearAttrPreview()
		{
			this.RoleAttributePanel.ClearPreview();
		}

		// Token: 0x06038E73 RID: 233075 RVA: 0x00D860A5 File Offset: 0x00D842A5
		public void HideAttrChangeFx()
		{
			this.RoleAttributePanel.HideAllChangeFx();
		}

		// Token: 0x06038E74 RID: 233076 RVA: 0x00D860B2 File Offset: 0x00D842B2
		private void OnItemUpdate(int itemId, bool bIsAdd)
		{
			this.RoleAttributePanel.RefreshAttributeList();
		}

		// Token: 0x06038E75 RID: 233077 RVA: 0x00D860BF File Offset: 0x00D842BF
		private void OnWeaponUpdate()
		{
			this.RoleAttributePanel.RefreshAttributeList();
		}

		// Token: 0x06038E76 RID: 233078 RVA: 0x00D860CC File Offset: 0x00D842CC
		private void OnClickClose()
		{
			Action closeCb = this.CloseCb;
			if (closeCb == null)
			{
				return;
			}
			closeCb();
		}

		// Token: 0x0401DD53 RID: 122195
		private readonly PopupCaptionItem CaptionItem = new PopupCaptionItem(null);

		// Token: 0x0401DD54 RID: 122196
		private readonly CostInfoItem CostInfoItem = new CostInfoItem();

		// Token: 0x0401DD55 RID: 122197
		private readonly KurotatoCurrencyItem CurrencyItem = new KurotatoCurrencyItem();

		// Token: 0x0401DD56 RID: 122198
		private readonly KurotatoAttributePanel RoleAttributePanel = new KurotatoAttributePanel();

		// Token: 0x0401DD57 RID: 122199
		[Nullable(2)]
		private Action CloseCb;

		// Token: 0x0200B999 RID: 47513
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x040381EE RID: 229870
			public const int Caption = 0;

			// Token: 0x040381EF RID: 229871
			public const int BtnBack = 1;

			// Token: 0x040381F0 RID: 229872
			public const int CostInfo = 2;

			// Token: 0x040381F1 RID: 229873
			public const int RoleAttr = 3;
		}
	}
}
