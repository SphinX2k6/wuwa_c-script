using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001CC7 RID: 7367
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CollectionGridItemPanel : LoopScrollSmallItemGrid<MotorcycleArrowCollectionItemData>
{
	// Token: 0x0600DF0D RID: 57101 RVA: 0x00343C2C File Offset: 0x00341E2C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600DF0E RID: 57102 RVA: 0x00343D01 File Offset: 0x00341F01
	protected override void OnRefresh(MotorcycleArrowCollectionItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0600DF0F RID: 57103 RVA: 0x00343D0C File Offset: 0x00341F0C
	public void Refresh(MotorcycleArrowCollectionItemData data)
	{
		this.Data = data;
		MotorFightItem config = data.Config;
		this.SetSpriteByPath(ConfigMotorFightQualityById.GetConfig(config.Quality, true).Value.SmallGridBg, base.GetSprite(0), false, null, null);
		base.SetTextureByPath(config.Icon, base.GetTexture(1), null, null);
		base.GetText(3).SetText("x" + data.Num.ToString(), true);
		base.SetLeftTopIconVisible(ConfigMotorFightItemTypeById.GetConfig(config.Type, true).Value.Icon);
	}

	// Token: 0x0600DF10 RID: 57104 RVA: 0x00343DC2 File Offset: 0x00341FC2
	private void OnClickToggle(EToggleState toggleState)
	{
		this.OnClickCallBack(this.Data as MotorcycleArrowCollectionItemData);
		if (!this.NeedSelectedState)
		{
			this.SetToggleState(false);
		}
	}

	// Token: 0x0600DF11 RID: 57105 RVA: 0x00343DEC File Offset: 0x00341FEC
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(7).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0400668D RID: 26253
	public bool NeedSelectedState = true;

	// Token: 0x0400668E RID: 26254
	public Action<MotorcycleArrowCollectionItemData> OnClickCallBack = delegate(MotorcycleArrowCollectionItemData _)
	{
	};

	// Token: 0x020082C5 RID: 33477
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402AA8E RID: 174734
		public const int SpriteQuality = 0;

		// Token: 0x0402AA8F RID: 174735
		public const int TextureIcon = 1;

		// Token: 0x0402AA90 RID: 174736
		public const int ItemText = 2;

		// Token: 0x0402AA91 RID: 174737
		public const int TextName = 3;

		// Token: 0x0402AA92 RID: 174738
		public const int SpriteBg = 4;

		// Token: 0x0402AA93 RID: 174739
		public const int ItemAddPanel = 5;

		// Token: 0x0402AA94 RID: 174740
		public const int ItemBottomAddPanel = 6;

		// Token: 0x0402AA95 RID: 174741
		public const int ToggleRoot = 7;

		// Token: 0x0402AA96 RID: 174742
		public const int SpriteSkinQuality = 8;

		// Token: 0x0402AA97 RID: 174743
		public const int ItemAdditionBottomA = 9;
	}
}
