using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001189 RID: 4489
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CollectionGridItemPanel : LoopScrollSmallItemGrid<MotorcycleArrowCollectionItemData>
{
	// Token: 0x0600B32A RID: 45866 RVA: 0x0034F654 File Offset: 0x0034D854
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

	// Token: 0x0600B32B RID: 45867 RVA: 0x0034F729 File Offset: 0x0034D929
	protected override void OnRefresh(MotorcycleArrowCollectionItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0600B32C RID: 45868 RVA: 0x0034F734 File Offset: 0x0034D934
	public void Refresh(MotorcycleArrowCollectionItemData data)
	{
		this.Data = data;
		MotorFightItem config = data.Config;
		this.SetSpriteByPath(ConfigMotorFightQualityById.GetConfig(config.Quality, true).Value.SmallGridBg, base.GetSprite(0), false, null, null);
		base.SetTextureByPath(config.Icon, base.GetTexture(1), null, null);
		base.GetText(3).SetText("x" + data.Num.ToString(), true);
		base.SetLeftTopIconVisible(ConfigMotorFightItemTypeById.GetConfig(config.Type, true).Value.Icon);
	}

	// Token: 0x0600B32D RID: 45869 RVA: 0x0034F7EA File Offset: 0x0034D9EA
	private void OnClickToggle(EToggleState toggleState)
	{
		this.OnClickCallBack(this.Data as MotorcycleArrowCollectionItemData);
		if (!this.NeedSelectedState)
		{
			this.SetToggleState(false);
		}
	}

	// Token: 0x0600B32E RID: 45870 RVA: 0x0034F814 File Offset: 0x0034DA14
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(7).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0400676C RID: 26476
	public bool NeedSelectedState = true;

	// Token: 0x0400676D RID: 26477
	public Action<MotorcycleArrowCollectionItemData> OnClickCallBack = delegate(MotorcycleArrowCollectionItemData _)
	{
	};

	// Token: 0x0200744E RID: 29774
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04025DB6 RID: 155062
		public const int SpriteQuality = 0;

		// Token: 0x04025DB7 RID: 155063
		public const int TextureIcon = 1;

		// Token: 0x04025DB8 RID: 155064
		public const int ItemText = 2;

		// Token: 0x04025DB9 RID: 155065
		public const int TextName = 3;

		// Token: 0x04025DBA RID: 155066
		public const int SpriteBg = 4;

		// Token: 0x04025DBB RID: 155067
		public const int ItemAddPanel = 5;

		// Token: 0x04025DBC RID: 155068
		public const int ItemBottomAddPanel = 6;

		// Token: 0x04025DBD RID: 155069
		public const int ToggleRoot = 7;

		// Token: 0x04025DBE RID: 155070
		public const int SpriteSkinQuality = 8;

		// Token: 0x04025DBF RID: 155071
		public const int ItemAdditionBottomA = 9;
	}
}
