using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020009FE RID: 2558
public class ActivityRoleDescribeComponent : UiPanelBase
{
	// Token: 0x06006F87 RID: 28551 RVA: 0x00224FA8 File Offset: 0x002231A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006F88 RID: 28552 RVA: 0x00225098 File Offset: 0x00223298
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(2));
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetUIActive(true);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x06006F89 RID: 28553 RVA: 0x00225118 File Offset: 0x00223318
	public void Update(int roleId)
	{
		this.RoleId = roleId;
		RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(this.RoleId);
		if (roleInfoById == null)
		{
			return;
		}
		base.GetText(0).ShowTextNew(roleInfoById.Value.Name);
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(roleInfoById.Value.ElementId);
		UUITexture texture = base.GetTexture(3);
		UUISprite sprite = base.GetSprite(4);
		base.SetTextureByPath(elementConfig.Value.Icon, texture, null, null);
		this.SetSpriteByPath(elementConfig.Value.GachaElementBgSpritePath, sprite, false, null, null);
		this.UpdateQuality(roleInfoById.Value.QualityId);
	}

	// Token: 0x06006F8A RID: 28554 RVA: 0x002251E9 File Offset: 0x002233E9
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
	}

	// Token: 0x04004509 RID: 17673
	private int RoleId;

	// Token: 0x0400450A RID: 17674
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400450B RID: 17675
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x02006D06 RID: 27910
	private class EComponent
	{
		// Token: 0x04023CCF RID: 146639
		public const int RoleNameText = 0;

		// Token: 0x04023CD0 RID: 146640
		public const int UpItem = 1;

		// Token: 0x04023CD1 RID: 146641
		public const int StarLayout = 2;

		// Token: 0x04023CD2 RID: 146642
		public const int AttrTexture = 3;

		// Token: 0x04023CD3 RID: 146643
		public const int AttrBgSprite = 4;

		// Token: 0x04023CD4 RID: 146644
		public const int AttrSprite = 5;
	}
}
