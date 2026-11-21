using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200520F RID: 21007
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AreaTitleItem : SyncGridProxyAbstract<RealmBetweenAreaData>
	{
		// Token: 0x0603449D RID: 214173 RVA: 0x00EA09F0 File Offset: 0x00E9EBF0
		public AreaTitleItem(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603449E RID: 214174 RVA: 0x00EA0A00 File Offset: 0x00E9EC00
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0603449F RID: 214175 RVA: 0x00EA0A70 File Offset: 0x00E9EC70
		protected override void OnStart()
		{
			this.TitleSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060344A0 RID: 214176 RVA: 0x00EA0A84 File Offset: 0x00E9EC84
		public override void Refresh(RealmBetweenAreaData areaData)
		{
			Area value = AreaConfig.Instance.GetAreaInfo(areaData.AreaId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Title, Array.Empty<object>());
			bool uiactive = true;
			foreach (int key in areaData.TravelTaskIdSet)
			{
				ActivityTaskData activityTaskData;
				if (!this.ActivityBaseData.AreaTaskMap.TryGetValue(key, out activityTaskData) || activityTaskData.Status != EActivityTaskState.FinishedAndClaimed)
				{
					uiactive = false;
					break;
				}
			}
			UUIText text = base.GetText(1);
			UUIItem uuiitem = text;
			bool bUseChangeColor = !areaData.IsUnlock;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUITexture texture = base.GetTexture(0);
			UUIItem uuiitem2 = texture;
			bool bUseChangeColor2 = !areaData.IsUnlock;
			fcolor = new FColor?(texture.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			base.GetItem(2).SetUIActive(!areaData.IsUnlock);
			base.GetItem(3).SetUIActive(uiactive);
		}

		// Token: 0x060344A1 RID: 214177 RVA: 0x00EA0BA0 File Offset: 0x00E9EDA0
		public void PlayUnlockAnim()
		{
			LevelSequencePlayer titleSequencePlayer = this.TitleSequencePlayer;
			if (titleSequencePlayer == null)
			{
				return;
			}
			titleSequencePlayer.PlayLevelSequenceByName("Unlock", true, null, false);
		}

		// Token: 0x060344A2 RID: 214178 RVA: 0x00EA0BCD File Offset: 0x00E9EDCD
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer titleSequencePlayer = this.TitleSequencePlayer;
			if (titleSequencePlayer != null)
			{
				titleSequencePlayer.Clear();
			}
			this.TitleSequencePlayer = null;
		}

		// Token: 0x0401BC36 RID: 113718
		[Nullable(2)]
		private LevelSequencePlayer TitleSequencePlayer;

		// Token: 0x0401BC37 RID: 113719
		protected ActivityRealmBetweenData ActivityBaseData;
	}
}
