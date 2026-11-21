using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200118C RID: 4492
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowCollectionItem : UiPanelBase
{
	// Token: 0x0600B338 RID: 45880 RVA: 0x0034F94C File Offset: 0x0034DB4C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggleRoot))
		};
	}

	// Token: 0x0600B339 RID: 45881 RVA: 0x0034FA38 File Offset: 0x0034DC38
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowCollectionItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowCollectionItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B33A RID: 45882 RVA: 0x0034FA7C File Offset: 0x0034DC7C
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600B33B RID: 45883 RVA: 0x0034FAA8 File Offset: 0x0034DCA8
	public void UpdateData(MotorcycleArrowCollectionItemData collectionItemData, bool bRefresh)
	{
		this.CollectionData = collectionItemData;
		this.UpdateBgQuality();
		this.UpdateCollectionConfig();
		if (bRefresh)
		{
			this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}
	}

	// Token: 0x0600B33C RID: 45884 RVA: 0x0034FAE8 File Offset: 0x0034DCE8
	private void UpdateBgQuality()
	{
		base.SetTextureByPath(ConfigMotorFightQualityById.GetConfig(this.CollectionData.Config.Quality, true).Value.DetailCardBg, this.TextureQualityBg, null, null);
	}

	// Token: 0x0600B33D RID: 45885 RVA: 0x0034FB34 File Offset: 0x0034DD34
	private void UpdateCollectionConfig()
	{
		MotorFightItem config = this.CollectionData.Config;
		base.GetText(2).ShowTextNew(config.Name);
		LguiUtil.Instance.SetLocalTextNew(this.TextCollectionDesc, config.Desc, config.DescParam());
		MotorFightItemType? collectionTypeConfigById = MotorcycleArrowConfig.Instance.GetCollectionTypeConfigById(config.Type);
		this.TextCollectionType.ShowTextNew(collectionTypeConfigById.Value.Name);
		this.SetSpriteByPath(collectionTypeConfigById.Value.Icon, this.SpriteTypeIcon, false, null, null);
		base.SetTextureByPath(config.IconBig, this.TextureIcon, null, null);
	}

	// Token: 0x0600B33E RID: 45886 RVA: 0x0034FBF0 File Offset: 0x0034DDF0
	public void SetTextureBgByResId(string resId, UUITexture uiTexture)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
		base.SetTextureByPath(resourcePath, uiTexture, null, null);
	}

	// Token: 0x0600B33F RID: 45887 RVA: 0x0034FC1C File Offset: 0x0034DE1C
	public void SetSelect(bool select)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		EToggleState state = select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x0600B340 RID: 45888 RVA: 0x0034FC46 File Offset: 0x0034DE46
	public void OnClickToggleRoot(EToggleState check)
	{
		Action<MotorcycleArrowCollectionItemData> onSelectCallback = this.OnSelectCallback;
		if (onSelectCallback == null)
		{
			return;
		}
		onSelectCallback(this.CollectionData);
	}

	// Token: 0x04006771 RID: 26481
	public MotorcycleArrowCollectionItemData CollectionData;

	// Token: 0x04006772 RID: 26482
	public UUITexture TextureQualityBg;

	// Token: 0x04006773 RID: 26483
	public UUIText TextTitle;

	// Token: 0x04006774 RID: 26484
	public UUITexture TextureIcon;

	// Token: 0x04006775 RID: 26485
	public UUIText TextCollectionType;

	// Token: 0x04006776 RID: 26486
	public UUISprite SpriteTypeIcon;

	// Token: 0x04006777 RID: 26487
	public UUIText TextCollectionDesc;

	// Token: 0x04006778 RID: 26488
	public UUIItem LockItem;

	// Token: 0x04006779 RID: 26489
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400677A RID: 26490
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleArrowCollectionItemData> OnSelectCallback;

	// Token: 0x02007452 RID: 29778
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025DC5 RID: 155077
		public const int ToggleRoot = 0;

		// Token: 0x04025DC6 RID: 155078
		public const int TextureQualityBg = 1;

		// Token: 0x04025DC7 RID: 155079
		public const int TextTitle = 2;

		// Token: 0x04025DC8 RID: 155080
		public const int TextureIcon = 3;

		// Token: 0x04025DC9 RID: 155081
		public const int TextCollectionType = 4;

		// Token: 0x04025DCA RID: 155082
		public const int SpriteTypeIcon = 5;

		// Token: 0x04025DCB RID: 155083
		public const int TextCollectionDesc = 6;

		// Token: 0x04025DCC RID: 155084
		public const int LockItem = 7;
	}
}
