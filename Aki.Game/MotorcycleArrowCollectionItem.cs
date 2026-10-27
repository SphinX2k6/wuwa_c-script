using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CCA RID: 7370
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowCollectionItem : UiPanelBase
{
	// Token: 0x0600DF1B RID: 57115 RVA: 0x00343F24 File Offset: 0x00342124
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

	// Token: 0x0600DF1C RID: 57116 RVA: 0x00344010 File Offset: 0x00342210
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowCollectionItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowCollectionItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF1D RID: 57117 RVA: 0x00344054 File Offset: 0x00342254
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600DF1E RID: 57118 RVA: 0x00344080 File Offset: 0x00342280
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

	// Token: 0x0600DF1F RID: 57119 RVA: 0x003440C0 File Offset: 0x003422C0
	private void UpdateBgQuality()
	{
		base.SetTextureByPath(ConfigMotorFightQualityById.GetConfig(this.CollectionData.Config.Quality, true).Value.DetailCardBg, this.TextureQualityBg, null, null);
	}

	// Token: 0x0600DF20 RID: 57120 RVA: 0x0034410C File Offset: 0x0034230C
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

	// Token: 0x0600DF21 RID: 57121 RVA: 0x003441C8 File Offset: 0x003423C8
	public void SetTextureBgByResId(string resId, UUITexture uiTexture)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
		base.SetTextureByPath(resourcePath, uiTexture, null, null);
	}

	// Token: 0x0600DF22 RID: 57122 RVA: 0x003441F4 File Offset: 0x003423F4
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

	// Token: 0x0600DF23 RID: 57123 RVA: 0x0034421E File Offset: 0x0034241E
	public void OnClickToggleRoot(EToggleState check)
	{
		Action<MotorcycleArrowCollectionItemData> onSelectCallback = this.OnSelectCallback;
		if (onSelectCallback == null)
		{
			return;
		}
		onSelectCallback(this.CollectionData);
	}

	// Token: 0x04006692 RID: 26258
	public MotorcycleArrowCollectionItemData CollectionData;

	// Token: 0x04006693 RID: 26259
	public UUITexture TextureQualityBg;

	// Token: 0x04006694 RID: 26260
	public UUIText TextTitle;

	// Token: 0x04006695 RID: 26261
	public UUITexture TextureIcon;

	// Token: 0x04006696 RID: 26262
	public UUIText TextCollectionType;

	// Token: 0x04006697 RID: 26263
	public UUISprite SpriteTypeIcon;

	// Token: 0x04006698 RID: 26264
	public UUIText TextCollectionDesc;

	// Token: 0x04006699 RID: 26265
	public UUIItem LockItem;

	// Token: 0x0400669A RID: 26266
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400669B RID: 26267
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleArrowCollectionItemData> OnSelectCallback;

	// Token: 0x020082C9 RID: 33481
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AA9D RID: 174749
		public const int ToggleRoot = 0;

		// Token: 0x0402AA9E RID: 174750
		public const int TextureQualityBg = 1;

		// Token: 0x0402AA9F RID: 174751
		public const int TextTitle = 2;

		// Token: 0x0402AAA0 RID: 174752
		public const int TextureIcon = 3;

		// Token: 0x0402AAA1 RID: 174753
		public const int TextCollectionType = 4;

		// Token: 0x0402AAA2 RID: 174754
		public const int SpriteTypeIcon = 5;

		// Token: 0x0402AAA3 RID: 174755
		public const int TextCollectionDesc = 6;

		// Token: 0x0402AAA4 RID: 174756
		public const int LockItem = 7;
	}
}
