using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02004C57 RID: 19543
	public class SheriffCriminalIdentityConfirmedView : UiViewBase
	{
		// Token: 0x06032867 RID: 206951 RVA: 0x00BC4DDD File Offset: 0x00BC2FDD
		[NullableContext(1)]
		public SheriffCriminalIdentityConfirmedView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032868 RID: 206952 RVA: 0x00BC4DE8 File Offset: 0x00BC2FE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnCloseClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032869 RID: 206953 RVA: 0x00BC4F34 File Offset: 0x00BC3134
		protected override void OnStart()
		{
			SheriffCriminalIdentityConfirmedViewData sheriffCriminalIdentityConfirmedViewData = this.OpenParam as SheriffCriminalIdentityConfirmedViewData;
			if (sheriffCriminalIdentityConfirmedViewData == null)
			{
				return;
			}
			SheriffIdentity? identityConfigById = SheriffConfig.Instance.GetIdentityConfigById(sheriffCriminalIdentityConfirmedViewData.BoardId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), (identityConfigById != null) ? identityConfigById.GetValueOrDefault().Name : null, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), (identityConfigById != null) ? identityConfigById.GetValueOrDefault().Accusal : null, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), (identityConfigById != null) ? identityConfigById.GetValueOrDefault().Witness : null, Array.Empty<object>());
			string valueOrDefault = SheriffPopupDefine.SheriffCriminalIdentityTxt.GetValueOrDefault((identityConfigById != null) ? identityConfigById.GetValueOrDefault().IdentityState : 0, "");
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), valueOrDefault, Array.Empty<object>());
			if (identityConfigById != null && !string.IsNullOrEmpty(identityConfigById.Value.IconConfirm))
			{
				base.SetTextureByPath(identityConfigById.Value.IconConfirm, base.GetTexture(1), null, null);
			}
			SheriffCriminal? criminalConfigById = SheriffConfig.Instance.GetCriminalConfigById((identityConfigById != null) ? identityConfigById.GetValueOrDefault().CriminalId : 0);
			Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview((criminalConfigById != null) ? criminalConfigById.GetValueOrDefault().DropId : 0);
			List<int> payShopInfoMoney = PayShopModel.Instance.GetPayShopInfoMoney(SheriffModel.Instance.ShopId);
			int num = (payShopInfoMoney.Count > 0) ? payShopInfoMoney[0] : 0;
			int num3;
			int num2 = (dropPackagePreview != null && dropPackagePreview.TryGetValue(num, out num3)) ? num3 : 0;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num);
			string str = (itemConfigData != null) ? itemConfigData.Icon : "";
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), "Sheriff_HudDesc_7", new <>z__ReadOnlyArray<object>(new object[]
			{
				str + ",0.2",
				num2
			}));
		}

		// Token: 0x0603286A RID: 206954 RVA: 0x00BC5172 File Offset: 0x00BC3372
		private void OnBtnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200ADFA RID: 44538
		private static class EComponents
		{
			// Token: 0x04034D7C RID: 216444
			public const int BtnClose = 0;

			// Token: 0x04034D7D RID: 216445
			public const int ImgNpc = 1;

			// Token: 0x04034D7E RID: 216446
			public const int TxtBountyNum = 2;

			// Token: 0x04034D7F RID: 216447
			public const int TxtCriminalName = 3;

			// Token: 0x04034D80 RID: 216448
			public const int TxtCriminalDescription = 4;

			// Token: 0x04034D81 RID: 216449
			public const int TxtEnvironment = 5;

			// Token: 0x04034D82 RID: 216450
			public const int TxtCriminalIdentity = 6;
		}
	}
}
