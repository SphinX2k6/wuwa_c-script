using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C4 RID: 22980
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolMapTilePanel : UiPanelBase
	{
		// Token: 0x06038A36 RID: 231990 RVA: 0x00FD929C File Offset: 0x00FD749C
		public SolarSchoolMapTilePanel()
		{
			this.MapItemComponents = new int[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				12,
				13
			};
		}

		// Token: 0x06038A37 RID: 231991 RVA: 0x00FD92C8 File Offset: 0x00FD74C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038A38 RID: 231992 RVA: 0x00FD94E8 File Offset: 0x00FD76E8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolMapTilePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolMapTilePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038A39 RID: 231993 RVA: 0x00FD952C File Offset: 0x00FD772C
		protected override void OnStart()
		{
			foreach (SolarSchoolMapItem solarSchoolMapItem in this.MapItems)
			{
				solarSchoolMapItem.ClickCallback = new Action<int>(this.OnMapItemClicked);
				solarSchoolMapItem.PointerDownCallback = new Action(this.OnMapItemPointerDown);
			}
		}

		// Token: 0x06038A3A RID: 231994 RVA: 0x00FD959C File Offset: 0x00FD779C
		public void RefreshLocations()
		{
			this.RefreshMapItems();
		}

		// Token: 0x06038A3B RID: 231995 RVA: 0x00FD95A4 File Offset: 0x00FD77A4
		public UUIItem GetSlotItem(int locationId)
		{
			int num = this.FindSlotIndexByLocationId(locationId);
			if (num < 0)
			{
				return null;
			}
			return this.MapItems[num].GetRootItem();
		}

		// Token: 0x06038A3C RID: 231996 RVA: 0x00FD95D0 File Offset: 0x00FD77D0
		public UUIItem GetRedDotItem(int locationId)
		{
			int num = this.FindSlotIndexByLocationId(locationId);
			if (num < 0)
			{
				return null;
			}
			return this.MapItems[num].GetRedDotItem();
		}

		// Token: 0x06038A3D RID: 231997 RVA: 0x00FD95FC File Offset: 0x00FD77FC
		[NullableContext(1)]
		public void PlayLocationAnimation(int locationId, string animationName)
		{
			int num = this.FindSlotIndexByLocationId(locationId);
			if (num < 0)
			{
				return;
			}
			this.MapItems[num].PlayAnimation(animationName);
		}

		// Token: 0x06038A3E RID: 231998 RVA: 0x00FD962C File Offset: 0x00FD782C
		[NullableContext(0)]
		public UniTask<bool> PlayLocationAnimationAsync(int locationId, [Nullable(1)] string animationName, bool blockClick)
		{
			SolarSchoolMapTilePanel.<PlayLocationAnimationAsync>d__13 <PlayLocationAnimationAsync>d__;
			<PlayLocationAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayLocationAnimationAsync>d__.<>4__this = this;
			<PlayLocationAnimationAsync>d__.locationId = locationId;
			<PlayLocationAnimationAsync>d__.animationName = animationName;
			<PlayLocationAnimationAsync>d__.blockClick = blockClick;
			<PlayLocationAnimationAsync>d__.<>1__state = -1;
			<PlayLocationAnimationAsync>d__.<>t__builder.Start<SolarSchoolMapTilePanel.<PlayLocationAnimationAsync>d__13>(ref <PlayLocationAnimationAsync>d__);
			return <PlayLocationAnimationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038A3F RID: 231999 RVA: 0x00FD9688 File Offset: 0x00FD7888
		public SolarSchoolMapItem GetMapItem(int locationId)
		{
			int num = this.FindSlotIndexByLocationId(locationId);
			if (num < 0)
			{
				return null;
			}
			return this.MapItems[num];
		}

		// Token: 0x06038A40 RID: 232000 RVA: 0x00FD96B0 File Offset: 0x00FD78B0
		private void RefreshMapItems()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			HashSet<int> hashSet = new HashSet<int>(instance.GetMapVisibleLocations());
			IEnumerable<SolarSchoolLocation> locationList = SolarSchoolConfig.Instance.GetLocationList(instance.ActivityId, instance.InstanceId);
			Dictionary<int, SolarSchoolLocation> dictionary = new Dictionary<int, SolarSchoolLocation>();
			foreach (SolarSchoolLocation value in locationList)
			{
				dictionary[value.UiIndex] = value;
			}
			for (int i = 0; i < this.MapItems.Count; i++)
			{
				int key = i + 1;
				SolarSchoolLocation loc;
				if (dictionary.TryGetValue(key, out loc))
				{
					this.MapItems[i].RefreshByLocation(loc, hashSet.Contains(loc.Id));
					this.MapItems[i].SetActive(true);
				}
				else
				{
					this.MapItems[i].SetActive(false);
				}
			}
		}

		// Token: 0x06038A41 RID: 232001 RVA: 0x00FD97A4 File Offset: 0x00FD79A4
		private int FindSlotIndexByLocationId(int locationId)
		{
			SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(locationId);
			if (location == null)
			{
				return -1;
			}
			int num = location.Value.UiIndex - 1;
			if (num < 0 || num >= this.MapItems.Count)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x06038A42 RID: 232002 RVA: 0x00FD97EF File Offset: 0x00FD79EF
		private void OnMapItemClicked(int locationId)
		{
			Action<int> mapItemClickCallback = this.MapItemClickCallback;
			if (mapItemClickCallback == null)
			{
				return;
			}
			mapItemClickCallback(locationId);
		}

		// Token: 0x06038A43 RID: 232003 RVA: 0x00FD9802 File Offset: 0x00FD7A02
		private void OnMapItemPointerDown()
		{
			Action mapItemPointerDownCallback = this.MapItemPointerDownCallback;
			if (mapItemPointerDownCallback == null)
			{
				return;
			}
			mapItemPointerDownCallback();
		}

		// Token: 0x0401DD34 RID: 122164
		[Nullable(1)]
		private readonly int[] MapItemComponents;

		// Token: 0x0401DD35 RID: 122165
		[Nullable(1)]
		private readonly List<SolarSchoolMapItem> MapItems = new List<SolarSchoolMapItem>();

		// Token: 0x0401DD36 RID: 122166
		public Action<int> MapItemClickCallback;

		// Token: 0x0401DD37 RID: 122167
		public Action MapItemPointerDownCallback;

		// Token: 0x0200B573 RID: 46451
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040381A6 RID: 229798
			public const int MapItem01 = 0;

			// Token: 0x040381A7 RID: 229799
			public const int MapItem02 = 1;

			// Token: 0x040381A8 RID: 229800
			public const int MapItem03 = 2;

			// Token: 0x040381A9 RID: 229801
			public const int MapItem04 = 3;

			// Token: 0x040381AA RID: 229802
			public const int MapItem05 = 4;

			// Token: 0x040381AB RID: 229803
			public const int MapItem06 = 5;

			// Token: 0x040381AC RID: 229804
			public const int MapItem07 = 6;

			// Token: 0x040381AD RID: 229805
			public const int MapItem08 = 7;

			// Token: 0x040381AE RID: 229806
			public const int MapItem09 = 8;

			// Token: 0x040381AF RID: 229807
			public const int MapItem10 = 9;

			// Token: 0x040381B0 RID: 229808
			public const int MapItem11 = 10;

			// Token: 0x040381B1 RID: 229809
			public const int MapItem12 = 11;

			// Token: 0x040381B2 RID: 229810
			public const int MapItem13 = 12;

			// Token: 0x040381B3 RID: 229811
			public const int MapItem14 = 13;

			// Token: 0x040381B4 RID: 229812
			public const int PnlMapItems = 14;
		}
	}
}
