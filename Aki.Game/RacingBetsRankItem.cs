using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200271F RID: 10015
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsRankItem : GridProxyAbstract<IRacingBetsRankData>
{
	// Token: 0x06014863 RID: 84067 RVA: 0x0052E8C8 File Offset: 0x0052CAC8
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

	// Token: 0x06014864 RID: 84068 RVA: 0x0052E97A File Offset: 0x0052CB7A
	public override void Refresh(IRacingBetsRankData data, bool isSelected, int gridIndex)
	{
		this.PlayerData = data;
		this.UpdateItem();
	}

	// Token: 0x06014865 RID: 84069 RVA: 0x0052E98C File Offset: 0x0052CB8C
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

	// Token: 0x04009A5B RID: 39515
	[Nullable(2)]
	private IRacingBetsRankData PlayerData;

	// Token: 0x04009A5C RID: 39516
	[StaticVariableRuleIgnore]
	protected static readonly string[] ColorValueList = new string[]
	{
		"1d4970ff",
		"e4733eff",
		"b444c8ff",
		"0084ffff"
	};

	// Token: 0x02008D72 RID: 36210
	[NullableContext(0)]
	private enum EItemComponents
	{
		// Token: 0x0402DE4C RID: 187980
		RankText,
		// Token: 0x0402DE4D RID: 187981
		HeadPhoto,
		// Token: 0x0402DE4E RID: 187982
		NameText,
		// Token: 0x0402DE4F RID: 187983
		BgSprite,
		// Token: 0x0402DE50 RID: 187984
		ObjectText,
		// Token: 0x0402DE51 RID: 187985
		RankScoreText,
		// Token: 0x0402DE52 RID: 187986
		PlayerItemButton
	}
}
