using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047D6 RID: 18390
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class QuickNavigateLoopScrollAreaGridItem : GridProxyAbstract<QuickNavigateLoopScrollAreaGridItemData>
	{
		// Token: 0x060302E4 RID: 197348 RVA: 0x00B2A29C File Offset: 0x00B2849C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060302E5 RID: 197349 RVA: 0x00B2A3E7 File Offset: 0x00B285E7
		protected override void OnStart()
		{
			base.GetExtendToggle(3).bLockStateOnSelect = false;
			base.GetSprite(5).SetUIActive(false);
			base.GetSprite(6).SetUIActive(false);
		}

		// Token: 0x060302E6 RID: 197350 RVA: 0x00B2A410 File Offset: 0x00B28610
		public override void Refresh(QuickNavigateLoopScrollAreaGridItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			int areaId = data.AreaNavigateInfo.AreaId;
			this.SetNameLocalText(AreaConfig.Instance.GetAreaInfo(areaId).Value.Title);
			if (data.RefreshType == ERefreshNavigateType.AreaOnly || data.RefreshType == ERefreshNavigateType.StateAndAreaBoth || data.RefreshType == ERefreshNavigateType.All)
			{
				this.UpdateToggleSetState();
			}
			if (MapUtil.GetWorldMapLevelOneAreaId() == areaId)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_IconCommonPlayer");
				base.GetSprite(0).SetUIActive(true);
				this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
			}
			else
			{
				int trackTaskAreaId = ExploreProgressModel.Instance.TrackTaskAreaId;
				base.GetSprite(0).SetUIActive(trackTaskAreaId == areaId);
				if (trackTaskAreaId == areaId)
				{
					string trackTaskIconPath = ExploreProgressModel.Instance.TrackTaskIconPath;
					this.SetSpriteByPath(trackTaskIconPath, base.GetSprite(0), false, null, null);
				}
			}
			List<int> onlinePlayerIndexListByAreaId = ExploreProgressModel.Instance.GetOnlinePlayerIndexListByAreaId(areaId);
			foreach (int name in new int[]
			{
				5,
				6
			})
			{
				int num = (onlinePlayerIndexListByAreaId.Count > 0) ? onlinePlayerIndexListByAreaId[onlinePlayerIndexListByAreaId.Count - 1] : -1;
				if (onlinePlayerIndexListByAreaId.Count > 0)
				{
					onlinePlayerIndexListByAreaId.RemoveAt(onlinePlayerIndexListByAreaId.Count - 1);
				}
				UUISprite sprite = base.GetSprite(name);
				bool flag = num != -1;
				sprite.SetUIActive(flag);
				if (flag)
				{
					string resourceId = WorldMapDefine.OnlinePlayerIconPathList2[num - 1];
					string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(resourceId);
					this.SetSpriteByPath(resourcePath2, sprite, false, null, null);
				}
			}
		}

		// Token: 0x060302E7 RID: 197351 RVA: 0x00B2A5C0 File Offset: 0x00B287C0
		private void SetNameLocalText(string localTextId)
		{
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, localTextId, Array.Empty<object>());
		}

		// Token: 0x060302E8 RID: 197352 RVA: 0x00B2A5E6 File Offset: 0x00B287E6
		private void OnClickToggle(EToggleState toggleState)
		{
			this.UpdateToggleSetState();
			EventSystem.Instance.Emit<int>(EEventName.WorldMapSecondNavigateSelect, base.GridIndex);
		}

		// Token: 0x060302E9 RID: 197353 RVA: 0x00B2A604 File Offset: 0x00B28804
		private void UpdateToggleSetState()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (this.Data.IsSelected)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x04019F2A RID: 106282
		[Nullable(2)]
		private QuickNavigateLoopScrollAreaGridItemData Data;
	}
}
