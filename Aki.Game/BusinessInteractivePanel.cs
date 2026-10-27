using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200131B RID: 4891
[NullableContext(1)]
[Nullable(0)]
public class BusinessInteractivePanel : UiPanelBase
{
	// Token: 0x060087B5 RID: 34741 RVA: 0x001CF72C File Offset: 0x001CD92C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x060087B6 RID: 34742 RVA: 0x001CF7B4 File Offset: 0x001CD9B4
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessInteractivePanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessInteractivePanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060087B7 RID: 34743 RVA: 0x001CF7F8 File Offset: 0x001CD9F8
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		BusinessInteractivePanel.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<BusinessInteractivePanel.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060087B8 RID: 34744 RVA: 0x001CF83C File Offset: 0x001CDA3C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIItem guideUiItem = base.GetGuideUiItem("1");
		if (guideUiItem != null)
		{
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}
		return null;
	}

	// Token: 0x060087B9 RID: 34745 RVA: 0x001CF868 File Offset: 0x001CDA68
	private void OnInteractiveToggle(RoleDevelopCurve data)
	{
		if (MoonChasingModel.Instance.GetWishValue() < data.WishConsume)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingRoleCostNotEnough);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				MoonChasingController.Instance.OpenBusinessMainView();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		MoonChasingController.Instance.RoleTrainRequest(this.RoleId, data.TrainType);
	}

	// Token: 0x060087BA RID: 34746 RVA: 0x001CF8E2 File Offset: 0x001CDAE2
	private BusinessInteractivePanel.InteractiveItem InitInteractiveItem()
	{
		BusinessInteractivePanel.InteractiveItem interactiveItem = new BusinessInteractivePanel.InteractiveItem();
		interactiveItem.SetButtonFunction(new Action<RoleDevelopCurve>(this.OnInteractiveToggle));
		return interactiveItem;
	}

	// Token: 0x060087BB RID: 34747 RVA: 0x001CF8FB File Offset: 0x001CDAFB
	private CharacterItem InitCharacterItem()
	{
		return new CharacterItem();
	}

	// Token: 0x060087BC RID: 34748 RVA: 0x001CF902 File Offset: 0x001CDB02
	public void RegisterViewController(BusinessHelperViewController vc)
	{
		this.Vc = vc;
	}

	// Token: 0x060087BD RID: 34749 RVA: 0x001CF90C File Offset: 0x001CDB0C
	public UniTask Refresh()
	{
		BusinessInteractivePanel.<Refresh>d__15 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<BusinessInteractivePanel.<Refresh>d__15>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x04003C82 RID: 15490
	protected int RoleId;

	// Token: 0x04003C83 RID: 15491
	protected CharacterListModule<CharacterItem> CharacterListModule;

	// Token: 0x04003C84 RID: 15492
	protected GenericLayout<BusinessInteractivePanel.InteractiveItem, RoleDevelopCurve> InteractiveLayout;

	// Token: 0x04003C85 RID: 15493
	[Nullable(2)]
	private BusinessHelperViewController Vc;

	// Token: 0x0200796D RID: 31085
	[NullableContext(0)]
	private static class EInteractiveItem
	{
		// Token: 0x04027FD9 RID: 163801
		public const int Button = 0;

		// Token: 0x04027FDA RID: 163802
		public const int Icon = 1;

		// Token: 0x04027FDB RID: 163803
		public const int IconTransition = 2;

		// Token: 0x04027FDC RID: 163804
		public const int Content = 3;

		// Token: 0x04027FDD RID: 163805
		public const int CostItem = 4;
	}

	// Token: 0x0200796E RID: 31086
	[Nullable(0)]
	protected class InteractiveItem : GridProxyAbstract<RoleDevelopCurve>
	{
		// Token: 0x0604931B RID: 299803 RVA: 0x012E7794 File Offset: 0x012E5994
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITextureTransitionComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnButton))
			};
		}

		// Token: 0x0604931C RID: 299804 RVA: 0x012E7840 File Offset: 0x012E5A40
		protected override UniTask OnBeforeStartAsync()
		{
			BusinessInteractivePanel.InteractiveItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessInteractivePanel.InteractiveItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604931D RID: 299805 RVA: 0x012E7883 File Offset: 0x012E5A83
		private void OnButton()
		{
			Action<RoleDevelopCurve> buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction(this.Data);
		}

		// Token: 0x0604931E RID: 299806 RVA: 0x012E789C File Offset: 0x012E5A9C
		public override void Refresh(RoleDevelopCurve data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.TrainContent, Array.Empty<object>());
			int wishItemId = BusinessConfig.Instance.GetWishItemId();
			this.CostItem.UpdateItem(wishItemId, data.WishConsume);
			this.CostItem.RefreshCountEnableState();
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(true);
			}
			base.SetTextureByPath(BusinessConfig.Instance.GetRoleDevelopTypeById(data.TrainType).Icon, base.GetTexture(1), null, delegate(bool _)
			{
				base.GetUiTextureTransitionComponent(2).SetAllStateTexture(base.GetTexture(1).GetTexture());
			});
		}

		// Token: 0x0604931F RID: 299807 RVA: 0x012E7944 File Offset: 0x012E5B44
		public void SetButtonFunction(Action<RoleDevelopCurve> callback)
		{
			this.ButtonFunction = callback;
		}

		// Token: 0x04027FDE RID: 163806
		[Nullable(2)]
		private Action<RoleDevelopCurve> ButtonFunction;

		// Token: 0x04027FDF RID: 163807
		private RoleDevelopCurve Data;

		// Token: 0x04027FE0 RID: 163808
		private CommonCostItem CostItem;
	}

	// Token: 0x0200796F RID: 31087
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027FE1 RID: 163809
		public const int Name = 0;

		// Token: 0x04027FE2 RID: 163810
		public const int CharacterListItem = 1;

		// Token: 0x04027FE3 RID: 163811
		public const int Level = 2;

		// Token: 0x04027FE4 RID: 163812
		public const int InteractiveLayout = 3;

		// Token: 0x04027FE5 RID: 163813
		public const int InteractiveItem = 4;
	}
}
