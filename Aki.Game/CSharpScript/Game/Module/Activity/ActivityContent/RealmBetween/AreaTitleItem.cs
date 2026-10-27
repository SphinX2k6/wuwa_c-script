using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006291 RID: 25233
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AreaTitleItem : SyncGridProxyAbstract<RealmBetweenAreaData>
	{
		// Token: 0x0603F7DC RID: 260060 RVA: 0x00F59A94 File Offset: 0x00F57C94
		public AreaTitleItem(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F7DD RID: 260061 RVA: 0x00F59AA4 File Offset: 0x00F57CA4
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

		// Token: 0x0603F7DE RID: 260062 RVA: 0x00F59B14 File Offset: 0x00F57D14
		protected override void OnStart()
		{
			this.TitleSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603F7DF RID: 260063 RVA: 0x00F59B28 File Offset: 0x00F57D28
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

		// Token: 0x0603F7E0 RID: 260064 RVA: 0x00F59C44 File Offset: 0x00F57E44
		public void PlayUnlockAnim()
		{
			LevelSequencePlayer titleSequencePlayer = this.TitleSequencePlayer;
			if (titleSequencePlayer == null)
			{
				return;
			}
			titleSequencePlayer.PlayLevelSequenceByName("Unlock", true, null, false);
		}

		// Token: 0x0603F7E1 RID: 260065 RVA: 0x00F59C71 File Offset: 0x00F57E71
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer titleSequencePlayer = this.TitleSequencePlayer;
			if (titleSequencePlayer != null)
			{
				titleSequencePlayer.Clear();
			}
			this.TitleSequencePlayer = null;
		}

		// Token: 0x04021307 RID: 135943
		[Nullable(2)]
		private LevelSequencePlayer TitleSequencePlayer;

		// Token: 0x04021308 RID: 135944
		protected ActivityRealmBetweenData ActivityBaseData;
	}
}
