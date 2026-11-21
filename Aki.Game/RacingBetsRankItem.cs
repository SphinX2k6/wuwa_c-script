using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C0A RID: 7178
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsRankItem : GridProxyAbstract<IRacingBetsRankData>
{
	// Token: 0x06011D45 RID: 73029 RVA: 0x0053D5E4 File Offset: 0x0053B7E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
		};
	}

	// Token: 0x06011D46 RID: 73030 RVA: 0x0053D696 File Offset: 0x0053B896
	public override void Refresh(IRacingBetsRankData data, bool isSelected, int gridIndex)
	{
		this.PlayerData = data;
		this.UpdateItem();
	}

	// Token: 0x06011D47 RID: 73031 RVA: 0x0053D6A8 File Offset: 0x0053B8A8
	private void UpdateItem()
	{
		if (this.PlayerData == null)
		{
			return;
		}
		IRacingBetsRankData playerData = this.PlayerData;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(playerData.Name, true);
		}
		UUIText text2 = base.GetText(0);
		if (text2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(playerData.RankNum);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIText text3 = base.GetText(4);
		if (text3 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(playerData.HitNum);
			text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIText text4 = base.GetText(5);
		if (text4 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(playerData.CashNum);
			text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUITexture texture = base.GetTexture(1);
		int playerHeadPhoto = playerData.PlayerHeadPhoto;
		PersonalModel instance = PersonalModel.Instance;
		PlayerHeadData playerHeadData = (instance != null) ? instance.GetPlayerHeadData(playerHeadPhoto, true) : null;
		if (playerHeadData == null || texture == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), texture, null);
		int num = 3;
		string hexStr = (playerData.RankNum <= num) ? RacingBetsRankItem.ColorValueList[playerData.RankNum] : RacingBetsRankItem.ColorValueList[0];
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		sprite.SetColor(FColor.FromHex(hexStr));
	}

	// Token: 0x04009BB3 RID: 39859
	[Nullable(2)]
	private IRacingBetsRankData PlayerData;

	// Token: 0x04009BB4 RID: 39860
	[StaticVariableRuleIgnore]
	protected static readonly string[] ColorValueList = new string[]
	{
		"1d4970ff",
		"e4733eff",
		"b444c8ff",
		"0084ffff"
	};

	// Token: 0x02007EFB RID: 32507
	[NullableContext(0)]
	private enum EItemComponents
	{
		// Token: 0x04029163 RID: 168291
		RankText,
		// Token: 0x04029164 RID: 168292
		HeadPhoto,
		// Token: 0x04029165 RID: 168293
		NameText,
		// Token: 0x04029166 RID: 168294
		BgSprite,
		// Token: 0x04029167 RID: 168295
		ObjectText,
		// Token: 0x04029168 RID: 168296
		RankScoreText,
		// Token: 0x04029169 RID: 168297
		PlayerItemButton
	}
}
