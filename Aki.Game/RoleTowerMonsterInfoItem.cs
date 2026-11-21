using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CDA RID: 7386
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerMonsterInfoItem : GridProxyAbstract<RoleTowerMonsterInfoData>
{
	// Token: 0x0601248E RID: 74894 RVA: 0x00564498 File Offset: 0x00562698
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout))
		};
	}

	// Token: 0x0601248F RID: 74895 RVA: 0x00564508 File Offset: 0x00562708
	protected override void OnStart()
	{
		this.ElementList = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(3), () => new TowerElementItem(), null, false, true);
	}

	// Token: 0x06012490 RID: 74896 RVA: 0x00564540 File Offset: 0x00562740
	public override void Refresh(RoleTowerMonsterInfoData data, bool isSelected, int gridIndex)
	{
		int monsterInfoId = data.MonsterInfoId;
		MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(monsterInfoId);
		if (monsterInfoConfig == null)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText("", true);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText("", true);
			}
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			GenericLayout<TowerElementItem, int> elementList = this.ElementList;
			if (elementList != null)
			{
				elementList.RefreshByData(new List<int>(), null, false);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.MonsterInfo 无怪物信息配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("monsterId", monsterInfoId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		MonsterInfo value = monsterInfoConfig.Value;
		UUIText text3 = base.GetText(0);
		if (text3 != null)
		{
			text3.SetText(MonsterInfoConfig.Instance.GetMonsterName(monsterInfoId), true);
		}
		UUITexture texture2 = base.GetTexture(2);
		if (texture2 != null)
		{
			texture2.SetUIActive(true);
		}
		base.SetTextureByPath(MonsterInfoConfig.Instance.GetMonsterIcon(monsterInfoId), base.GetTexture(2), null, null);
		int[] array = value.ElementIdArray();
		GenericLayout<TowerElementItem, int> elementList2 = this.ElementList;
		if (elementList2 != null)
		{
			elementList2.RefreshByData((array != null) ? new List<int>(array) : new List<int>(), null, false);
		}
		UUIText text4 = base.GetText(1);
		if (text4 == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Lv.");
		defaultInterpolatedStringHandler.AppendFormatted<int>(RoleTowerModel.Instance.GetCurLevelEntityLevel().GetValueOrDefault());
		text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06012491 RID: 74897 RVA: 0x005646C1 File Offset: 0x005628C1
	public override object GetKey(RoleTowerMonsterInfoData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x04009F9B RID: 40859
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> ElementList;

	// Token: 0x02007FD6 RID: 32726
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040295AC RID: 169388
		public const int NameText = 0;

		// Token: 0x040295AD RID: 169389
		public const int LevelText = 1;

		// Token: 0x040295AE RID: 169390
		public const int IconTexture = 2;

		// Token: 0x040295AF RID: 169391
		public const int ElementLayout = 3;
	}
}
