using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200111B RID: 4379
public class BabelTowerBuffDetailItem : UiPanelBase
{
	// Token: 0x06007297 RID: 29335 RVA: 0x00177EE0 File Offset: 0x001760E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007298 RID: 29336 RVA: 0x00177FAC File Offset: 0x001761AC
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerBuffDetailItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerBuffDetailItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007299 RID: 29337 RVA: 0x00177FEF File Offset: 0x001761EF
	[NullableContext(1)]
	public void Update(IBabelTowerBuffItemData data)
	{
		this.Data = data;
		this.Refresh();
	}

	// Token: 0x0600729A RID: 29338 RVA: 0x00178000 File Offset: 0x00176200
	public void Refresh()
	{
		if (this.Data == null)
		{
			return;
		}
		string nameText;
		string texture;
		string desText;
		int star;
		if (this.Data.IsDeTerm)
		{
			BabelTowerDeTerm value = ConfigBabelTowerDeTermById.GetConfig(this.Data.Id, true).Value;
			nameText = value.NameText;
			texture = value.Texture;
			desText = value.DesText;
			star = value.Star;
		}
		else
		{
			BabelTowerBuff value2 = ConfigBabelTowerBuffById.GetConfig(this.Data.Id, true).Value;
			nameText = value2.NameText;
			texture = value2.Texture;
			desText = value2.DesText;
			star = value2.Star;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), nameText, Array.Empty<object>());
		this.StarAndDescItem.Refresh(star.ToString(), this.Data.ShowStar.GetValueOrDefault(), desText);
		base.SetTextureByPath(texture, base.GetTexture(2), null, null);
		int num = BabelTowerModel.Instance.CoverStarNumToQualityId(star);
		UiResourceConfig instance = UiResourceConfig.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral("T_TipsQualityTypeLevel");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
		FColor color = FColor.FromHex(InventoryConfig.Instance.GetItemQualityConfig(num).Value.QualityColor);
		UUINiagara uiNiagara = base.GetUiNiagara(3);
		uiNiagara.SetColor(color);
		uiNiagara.ActivateSystem(true);
	}

	// Token: 0x0400350A RID: 13578
	[Nullable(2)]
	private BabelTowerBuffStarAndDescItem StarAndDescItem;

	// Token: 0x0400350B RID: 13579
	[Nullable(2)]
	private IBabelTowerBuffItemData Data;

	// Token: 0x020076E0 RID: 30432
	private class EComponents
	{
		// Token: 0x040273A3 RID: 160675
		public const int NameText = 0;

		// Token: 0x040273A4 RID: 160676
		public const int QualityBgTexture = 1;

		// Token: 0x040273A5 RID: 160677
		public const int ItemIconTexture = 2;

		// Token: 0x040273A6 RID: 160678
		public const int QualityNiagara = 3;

		// Token: 0x040273A7 RID: 160679
		public const int ContentItem = 4;
	}
}
