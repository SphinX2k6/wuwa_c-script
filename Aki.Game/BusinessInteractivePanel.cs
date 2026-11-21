using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007CF RID: 1999
[NullableContext(1)]
[Nullable(0)]
public class BusinessInteractivePanel : UiPanelBase
{
	// Token: 0x06005B50 RID: 23376 RVA: 0x001D8598 File Offset: 0x001D6798
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

	// Token: 0x06005B51 RID: 23377 RVA: 0x001D8620 File Offset: 0x001D6820
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessInteractivePanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessInteractivePanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005B52 RID: 23378 RVA: 0x001D8664 File Offset: 0x001D6864
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		BusinessInteractivePanel.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<BusinessInteractivePanel.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06005B53 RID: 23379 RVA: 0x001D86A8 File Offset: 0x001D68A8
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

	// Token: 0x06005B54 RID: 23380 RVA: 0x001D86D4 File Offset: 0x001D68D4
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

	// Token: 0x06005B55 RID: 23381 RVA: 0x001D874E File Offset: 0x001D694E
	private BusinessInteractivePanel.InteractiveItem InitInteractiveItem()
	{
		BusinessInteractivePanel.InteractiveItem interactiveItem = new BusinessInteractivePanel.InteractiveItem();
		interactiveItem.SetButtonFunction(new Action<RoleDevelopCurve>(this.OnInteractiveToggle));
		return interactiveItem;
	}

	// Token: 0x06005B56 RID: 23382 RVA: 0x001D8767 File Offset: 0x001D6967
	private CharacterItem InitCharacterItem()
	{
		return new CharacterItem();
	}

	// Token: 0x06005B57 RID: 23383 RVA: 0x001D876E File Offset: 0x001D696E
	public void RegisterViewController(BusinessHelperViewController vc)
	{
		this.Vc = vc;
	}

	// Token: 0x06005B58 RID: 23384 RVA: 0x001D8778 File Offset: 0x001D6978
	public UniTask Refresh()
	{
		BusinessInteractivePanel.<Refresh>d__15 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<BusinessInteractivePanel.<Refresh>d__15>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x04003D1A RID: 15642
	protected int RoleId;

	// Token: 0x04003D1B RID: 15643
	protected CharacterListModule<CharacterItem> CharacterListModule;

	// Token: 0x04003D1C RID: 15644
	protected GenericLayout<BusinessInteractivePanel.InteractiveItem, RoleDevelopCurve> InteractiveLayout;

	// Token: 0x04003D1D RID: 15645
	[Nullable(2)]
	private BusinessHelperViewController Vc;

	// Token: 0x02006AF7 RID: 27383
	[NullableContext(0)]
	private static class EInteractiveItem
	{
		// Token: 0x04023306 RID: 144134
		public const int Button = 0;

		// Token: 0x04023307 RID: 144135
		public const int Icon = 1;

		// Token: 0x04023308 RID: 144136
		public const int IconTransition = 2;

		// Token: 0x04023309 RID: 144137
		public const int Content = 3;

		// Token: 0x0402330A RID: 144138
		public const int CostItem = 4;
	}

	// Token: 0x02006AF8 RID: 27384
	[Nullable(0)]
	protected class InteractiveItem : GridProxyAbstract<RoleDevelopCurve>
	{
		// Token: 0x0603F74F RID: 259919 RVA: 0x0128A990 File Offset: 0x01288B90
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

		// Token: 0x0603F750 RID: 259920 RVA: 0x0128AA3C File Offset: 0x01288C3C
		protected override UniTask OnBeforeStartAsync()
		{
			BusinessInteractivePanel.InteractiveItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessInteractivePanel.InteractiveItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F751 RID: 259921 RVA: 0x0128AA7F File Offset: 0x01288C7F
		private void OnButton()
		{
			Action<RoleDevelopCurve> buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction(this.Data);
		}

		// Token: 0x0603F752 RID: 259922 RVA: 0x0128AA98 File Offset: 0x01288C98
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

		// Token: 0x0603F753 RID: 259923 RVA: 0x0128AB40 File Offset: 0x01288D40
		public void SetButtonFunction(Action<RoleDevelopCurve> callback)
		{
			this.ButtonFunction = callback;
		}

		// Token: 0x0402330B RID: 144139
		[Nullable(2)]
		private Action<RoleDevelopCurve> ButtonFunction;

		// Token: 0x0402330C RID: 144140
		private RoleDevelopCurve Data;

		// Token: 0x0402330D RID: 144141
		private CommonCostItem CostItem;
	}

	// Token: 0x02006AF9 RID: 27385
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402330E RID: 144142
		public const int Name = 0;

		// Token: 0x0402330F RID: 144143
		public const int CharacterListItem = 1;

		// Token: 0x04023310 RID: 144144
		public const int Level = 2;

		// Token: 0x04023311 RID: 144145
		public const int InteractiveLayout = 3;

		// Token: 0x04023312 RID: 144146
		public const int InteractiveItem = 4;
	}
}
