using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200105A RID: 4186
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchRaceItem : GridProxyAbstract<FloroRanchSelectRaceData>
{
	// Token: 0x0600A682 RID: 42626 RVA: 0x00310588 File Offset: 0x0030E788
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A683 RID: 42627 RVA: 0x00310694 File Offset: 0x0030E894
	public override void Refresh(FloroRanchSelectRaceData data, bool isSelected, int gridIndex)
	{
		this.SubDungeonData = data.SubDungeonData;
		this.ActivityDataType = data.ActivityDataType;
		int[] raceList = this.SubDungeonData.RaceList;
		int raceId = data.RaceId;
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetUIActive(raceId == 0);
		}
		if (raceId == 0)
		{
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(data.ActivityDataType, true);
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(activityData != null && activityData.IsOtherRaceHasRedDot(new List<int>(raceList)));
			return;
		}
		else
		{
			bool uiactive = Array.IndexOf<int>(raceList, raceId) >= 0;
			UUISprite sprite3 = base.GetSprite(3);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(uiactive);
			}
			FloroRanchRaceData floroRanchRaceData = FloroRanchModel.Instance.GetFloroRanchRaceData(raceId);
			UUITexture texture2 = base.GetTexture(2);
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			base.SetTextureByPath(floroRanchRaceData.Icon, base.GetTexture(2), null, null);
			FloroRanchActivityData activityData2 = FloroRanchModel.Instance.GetActivityData(data.ActivityDataType, true);
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(activityData2 != null && activityData2.IsRaceItemHasRedDot(data.RaceId));
			return;
		}
	}

	// Token: 0x0600A684 RID: 42628 RVA: 0x003107DC File Offset: 0x0030E9DC
	private void OnClickToggle()
	{
		FloroRanchRaceSelectViewParam floroRanchRaceSelectViewParam = new FloroRanchRaceSelectViewParam
		{
			SubDungeonData = this.SubDungeonData,
			ActivityDataType = this.ActivityDataType
		};
		UiManager.Instance.OpenView(EUiViewName.FloroRanchRaceSelectView, floroRanchRaceSelectViewParam, null);
	}

	// Token: 0x0400614D RID: 24909
	private FloroRanchSubDungeonData SubDungeonData;

	// Token: 0x0400614E RID: 24910
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x020072C4 RID: 29380
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025604 RID: 153092
		public const int Button = 0;

		// Token: 0x04025605 RID: 153093
		public const int SpriteAdd = 1;

		// Token: 0x04025606 RID: 153094
		public const int TextureRaceIcon = 2;

		// Token: 0x04025607 RID: 153095
		public const int SpriteFixed = 3;

		// Token: 0x04025608 RID: 153096
		public const int ItemRedDot = 4;
	}
}
