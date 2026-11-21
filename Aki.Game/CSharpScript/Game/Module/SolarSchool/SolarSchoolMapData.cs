using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D4 RID: 22740
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolMapData : SolarSchoolRecordBase
	{
		// Token: 0x17006B6C RID: 27500
		// (get) Token: 0x06037FF1 RID: 229361 RVA: 0x00FA6E0B File Offset: 0x00FA500B
		// (set) Token: 0x06037FF2 RID: 229362 RVA: 0x00FA6E13 File Offset: 0x00FA5013
		public int CurrentLocationId { get; private set; }

		// Token: 0x06037FF3 RID: 229363 RVA: 0x00FA6E1C File Offset: 0x00FA501C
		public void SetCurrentLocation(int locationId)
		{
			this.MarkLocationEntered(locationId);
			if (this.CurrentLocationId == locationId)
			{
				return;
			}
			this.CurrentLocationId = locationId;
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolLocationChanged, locationId);
		}

		// Token: 0x06037FF4 RID: 229364 RVA: 0x00FA6E47 File Offset: 0x00FA5047
		public bool HasEnteredLocation(int locationId)
		{
			return this.EnteredLocationIds.Contains(locationId);
		}

		// Token: 0x06037FF5 RID: 229365 RVA: 0x00FA6E58 File Offset: 0x00FA5058
		public void MarkLocationEntered(int locationId)
		{
			if (this.GetLocationData(locationId) == null)
			{
				return;
			}
			SolarSchoolLocation? solarSchoolLocation;
			if (SolarSchoolConfig.Instance.GetLocation(locationId) == null || !solarSchoolLocation.GetValueOrDefault().FirstRedDot)
			{
				return;
			}
			this.EnteredLocationIds.Add(locationId);
		}

		// Token: 0x06037FF6 RID: 229366 RVA: 0x00FA6EAC File Offset: 0x00FA50AC
		public void InitLocations(int activityId)
		{
			this.Clear();
			this.LocationMap.Clear();
			foreach (SolarSchoolLocation solarSchoolLocation in SolarSchoolConfig.Instance.GetLocationListByActivityId(activityId))
			{
				this.LocationMap[solarSchoolLocation.Id] = new SolarSchoolLocationData(solarSchoolLocation.Id);
			}
		}

		// Token: 0x06037FF7 RID: 229367 RVA: 0x00FA6F28 File Offset: 0x00FA5128
		public void WatchLocationsUnlock()
		{
			foreach (KeyValuePair<int, SolarSchoolLocationData> keyValuePair in this.LocationMap)
			{
				keyValuePair.Value.WatchUnlock();
			}
		}

		// Token: 0x06037FF8 RID: 229368 RVA: 0x00FA6F80 File Offset: 0x00FA5180
		public void NotifyLocationUnlocked(int locationId)
		{
			this.UnlockedNotifyQueue.Add(locationId);
			if (this.Notifying)
			{
				return;
			}
			this.Notifying = true;
			try
			{
				for (int i = 0; i < this.UnlockedNotifyQueue.Count; i++)
				{
					EventSystem.Instance.Emit<int>(EEventName.SolarSchoolLocationUnlocked, this.UnlockedNotifyQueue[i]);
				}
			}
			finally
			{
				this.UnlockedNotifyQueue.Clear();
				this.Notifying = false;
			}
		}

		// Token: 0x06037FF9 RID: 229369 RVA: 0x00FA7000 File Offset: 0x00FA5200
		public void Clear()
		{
			foreach (KeyValuePair<int, SolarSchoolLocationData> keyValuePair in this.LocationMap)
			{
				keyValuePair.Value.UnwatchUnlock();
			}
			this.LocationMap.Clear();
			this.UnlockedNotifyQueue.Clear();
			this.EnteredLocationIds.Clear();
			this.Notifying = false;
			this.CurrentLocationId = 0;
		}

		// Token: 0x06037FFA RID: 229370 RVA: 0x00FA7088 File Offset: 0x00FA5288
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolLocationDataPb solarSchoolLocationDataPb = SolarSchoolLocationDataPb.Create();
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			foreach (SolarSchoolLocation solarSchoolLocation in SolarSchoolConfig.Instance.GetLocationListByActivityId(activityId))
			{
				if (solarSchoolLocation.FirstRedDot && this.EnteredLocationIds.Contains(solarSchoolLocation.Id))
				{
					SolarSchoolUtils.SetSaveBit(solarSchoolLocationDataPb.ViewedBit, solarSchoolLocation.BitFlag);
				}
			}
			gameData.Location = solarSchoolLocationDataPb;
		}

		// Token: 0x06037FFB RID: 229371 RVA: 0x00FA711C File Offset: 0x00FA531C
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.EnteredLocationIds.Clear();
			if (gameData.Location == null)
			{
				return;
			}
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			foreach (SolarSchoolLocation solarSchoolLocation in SolarSchoolConfig.Instance.GetLocationListByActivityId(activityId))
			{
				if (solarSchoolLocation.FirstRedDot && SolarSchoolUtils.GetSaveBit(gameData.Location.ViewedBit, solarSchoolLocation.BitFlag))
				{
					this.EnteredLocationIds.Add(solarSchoolLocation.Id);
				}
			}
		}

		// Token: 0x06037FFC RID: 229372 RVA: 0x00FA71BC File Offset: 0x00FA53BC
		[NullableContext(2)]
		public SolarSchoolLocationData GetLocationData(int locationId)
		{
			return this.LocationMap.GetValueOrDefault(locationId);
		}

		// Token: 0x06037FFD RID: 229373 RVA: 0x00FA71CC File Offset: 0x00FA53CC
		public void ClearLocationsDaily()
		{
			foreach (KeyValuePair<int, SolarSchoolLocationData> keyValuePair in this.LocationMap)
			{
				keyValuePair.Value.ClearDaily();
			}
		}

		// Token: 0x06037FFE RID: 229374 RVA: 0x00FA7224 File Offset: 0x00FA5424
		public void ClearAllLocationRoles()
		{
			foreach (KeyValuePair<int, SolarSchoolLocationData> keyValuePair in this.LocationMap)
			{
				keyValuePair.Value.ClearRole();
			}
		}

		// Token: 0x06037FFF RID: 229375 RVA: 0x00FA727C File Offset: 0x00FA547C
		public void FillLocationOptions(int activityId, int instanceId)
		{
			Dictionary<int, List<SolarSchoolOptions>> dictionary = new Dictionary<int, List<SolarSchoolOptions>>();
			SolarSchoolUtils.CollectOptionRows(activityId, instanceId, ESolarSchoolOptionOwnerType.Location, dictionary);
			foreach (KeyValuePair<int, SolarSchoolLocationData> keyValuePair in this.LocationMap)
			{
				keyValuePair.Value.SetOptionRows(dictionary.GetValueOrDefault(keyValuePair.Key));
			}
		}

		// Token: 0x06038000 RID: 229376 RVA: 0x00FA72F0 File Offset: 0x00FA54F0
		public bool IsLocationShowEnable(int locationId)
		{
			SolarSchoolLocationData locationData = this.GetLocationData(locationId);
			return locationData != null && locationData.IsShowEnable;
		}

		// Token: 0x06038001 RID: 229377 RVA: 0x00FA7304 File Offset: 0x00FA5504
		public bool IsLocationUnlocked(int locationId)
		{
			SolarSchoolLocationData locationData = this.GetLocationData(locationId);
			return locationData != null && locationData.IsUnlocked;
		}

		// Token: 0x06038002 RID: 229378 RVA: 0x00FA7318 File Offset: 0x00FA5518
		public bool IsLocationAvailable(int locationId)
		{
			return this.IsLocationUnlocked(locationId) && this.IsLocationShowEnable(locationId);
		}

		// Token: 0x06038003 RID: 229379 RVA: 0x00FA732C File Offset: 0x00FA552C
		public List<SolarSchoolOptionInfo> GetLocationOptions(int locationId)
		{
			SolarSchoolLocationData locationData = this.GetLocationData(locationId);
			return ((locationData != null) ? locationData.GetOptions() : null) ?? new List<SolarSchoolOptionInfo>();
		}

		// Token: 0x06038004 RID: 229380 RVA: 0x00FA734C File Offset: 0x00FA554C
		public unsafe void SetLocationRole(int locationId, int roleId, bool isResident)
		{
			SolarSchoolLocationData locationData = this.GetLocationData(locationId);
			if (locationData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 放置地点角色失败：地点表没有该地点";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleId", roleId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			locationData.SetRole(roleId, isResident);
		}

		// Token: 0x06038005 RID: 229381 RVA: 0x00FA73D0 File Offset: 0x00FA55D0
		public SolarSchoolLocationRole GetLocationRole(int locationId)
		{
			SolarSchoolLocationData locationData = this.GetLocationData(locationId);
			if (locationData == null)
			{
				return default(SolarSchoolLocationRole);
			}
			return locationData.Role;
		}

		// Token: 0x0401D87F RID: 120959
		private readonly Dictionary<int, SolarSchoolLocationData> LocationMap = new Dictionary<int, SolarSchoolLocationData>();

		// Token: 0x0401D880 RID: 120960
		private readonly List<int> UnlockedNotifyQueue = new List<int>();

		// Token: 0x0401D881 RID: 120961
		private readonly HashSet<int> EnteredLocationIds = new HashSet<int>();

		// Token: 0x0401D882 RID: 120962
		private bool Notifying;
	}
}
