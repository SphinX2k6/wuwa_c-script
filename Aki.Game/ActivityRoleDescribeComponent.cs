using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001546 RID: 5446
public class ActivityRoleDescribeComponent : UiPanelBase
{
	// Token: 0x06009BA9 RID: 39849 RVA: 0x0021B1F8 File Offset: 0x002193F8
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

	// Token: 0x06009BAA RID: 39850 RVA: 0x0021B2E8 File Offset: 0x002194E8
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

	// Token: 0x06009BAB RID: 39851 RVA: 0x0021B368 File Offset: 0x00219568
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

	// Token: 0x06009BAC RID: 39852 RVA: 0x0021B439 File Offset: 0x00219639
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
	}

	// Token: 0x04004463 RID: 17507
	private int RoleId;

	// Token: 0x04004464 RID: 17508
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004465 RID: 17509
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x02007B7B RID: 31611
	private class EComponent
	{
		// Token: 0x04028994 RID: 166292
		public const int RoleNameText = 0;

		// Token: 0x04028995 RID: 166293
		public const int UpItem = 1;

		// Token: 0x04028996 RID: 166294
		public const int StarLayout = 2;

		// Token: 0x04028997 RID: 166295
		public const int AttrTexture = 3;

		// Token: 0x04028998 RID: 166296
		public const int AttrBgSprite = 4;

		// Token: 0x04028999 RID: 166297
		public const int AttrSprite = 5;
	}
}
