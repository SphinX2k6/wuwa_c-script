using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x020022BC RID: 8892
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MotorcycleMusicPlayerModel : ModelBase
{
	// Token: 0x17001631 RID: 5681
	// (get) Token: 0x06011702 RID: 71426 RVA: 0x00445806 File Offset: 0x00443A06
	public bool IsEnable
	{
		get
		{
			return VisibleStateUtil.GetVisible(this.VisibleState);
		}
	}

	// Token: 0x06011703 RID: 71427 RVA: 0x00445813 File Offset: 0x00443A13
	public void IncreaseDisableCount()
	{
		this.DisableCount++;
		this.UpdateDisableVisibleState();
	}

	// Token: 0x06011704 RID: 71428 RVA: 0x00445829 File Offset: 0x00443A29
	public void DecreaseDisableCount()
	{
		this.DisableCount--;
		this.UpdateDisableVisibleState();
	}

	// Token: 0x06011705 RID: 71429 RVA: 0x0044583F File Offset: 0x00443A3F
	public void SetFunctionEnable(bool isEnable)
	{
		this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, isEnable, 0);
	}

	// Token: 0x06011706 RID: 71430 RVA: 0x00445854 File Offset: 0x00443A54
	public void SetFightMusicEnable(bool isEnable)
	{
		this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, isEnable, 2);
	}

	// Token: 0x06011707 RID: 71431 RVA: 0x0044586C File Offset: 0x00443A6C
	private void UpdateDisableVisibleState()
	{
		bool bVisible = this.DisableCount == 0;
		this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, bVisible, 1);
	}

	// Token: 0x06011708 RID: 71432 RVA: 0x00445896 File Offset: 0x00443A96
	public bool LoadLocalStorageData()
	{
		this.MusicNewSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorcycleMusicRedDot, null);
		this.PlayMode = LocalStorage.GetPlayer<EMotorMusicPlayMode>(ELocalStoragePlayerKey.MotorcyclePlayMode, EMotorMusicPlayMode.Order);
		return true;
	}

	// Token: 0x06011709 RID: 71433 RVA: 0x004458BB File Offset: 0x00443ABB
	public bool IsMusicFavorite(int id)
	{
		return this.FavoriteMusicList.Contains(id);
	}

	// Token: 0x0601170A RID: 71434 RVA: 0x004458CC File Offset: 0x00443ACC
	public bool ToggleMusicFavorite(int id)
	{
		if (this.IsMusicFavorite(id))
		{
			int num = this.FavoriteMusicList.IndexOf(id);
			if (num != -1)
			{
				this.FavoriteMusicList.RemoveAt(num);
			}
		}
		else
		{
			if (this.FavoriteMusicList.Count >= MotorcycleMusicPlayerConfig.Instance.GetFavoriteCountLimit())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("MotorMusicTips06", Array.Empty<object>());
				return false;
			}
			this.FavoriteMusicList.Insert(0, id);
		}
		return true;
	}

	// Token: 0x0601170B RID: 71435 RVA: 0x0044593C File Offset: 0x00443B3C
	public IReadOnlyList<int> GetFavoriteMusicList()
	{
		return this.FavoriteMusicList;
	}

	// Token: 0x0601170C RID: 71436 RVA: 0x00445944 File Offset: 0x00443B44
	public void SetFavoriteMusicList(IReadOnlyList<int> musicList)
	{
		this.FavoriteMusicList = new List<int>(musicList);
	}

	// Token: 0x0601170D RID: 71437 RVA: 0x00445952 File Offset: 0x00443B52
	public IReadOnlyList<int> GetCurrentPlayList()
	{
		return this.CurrentPlayList;
	}

	// Token: 0x0601170E RID: 71438 RVA: 0x0044595A File Offset: 0x00443B5A
	public void SetPlayList(List<int> musicList)
	{
		this.CurrentPlayList = musicList;
	}

	// Token: 0x0601170F RID: 71439 RVA: 0x00445963 File Offset: 0x00443B63
	public bool IsMusicUnlock(int id)
	{
		return PhonographModel.Instance.IsUnlockMusic(id);
	}

	// Token: 0x06011710 RID: 71440 RVA: 0x00445970 File Offset: 0x00443B70
	public List<PhonographMusic> GetMusicByAlbum(int albumId)
	{
		if (albumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			List<PhonographMusic> list = new List<PhonographMusic>();
			foreach (int id in this.FavoriteMusicList)
			{
				PhonographMusic? musicById = PhonographConfig.Instance.GetMusicById(id);
				if (musicById != null)
				{
					list.Add(musicById.Value);
				}
			}
			return list;
		}
		if (this.Album2MusicCache.ContainsKey(albumId))
		{
			return this.Album2MusicCache[albumId];
		}
		IEnumerable<PhonographMusic> enumerable = PhonographConfig.Instance.GetMusicList() ?? new List<PhonographMusic>();
		List<PhonographMusic> list2 = new List<PhonographMusic>();
		foreach (PhonographMusic item in enumerable)
		{
			if (item.GetAlbumArray().Contains(albumId))
			{
				list2.Add(item);
			}
		}
		this.Album2MusicCache[albumId] = list2;
		return list2;
	}

	// Token: 0x06011711 RID: 71441 RVA: 0x00445A84 File Offset: 0x00443C84
	public List<PhonographMusic> GetUnlockMusicByAlbum(int albumId)
	{
		List<PhonographMusic> musicByAlbum = this.GetMusicByAlbum(albumId);
		if (albumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			return musicByAlbum;
		}
		List<PhonographMusic> list = new List<PhonographMusic>();
		foreach (PhonographMusic item in musicByAlbum)
		{
			if (this.IsMusicUnlock(item.Id))
			{
				list.Add(item);
			}
		}
		list.Sort((PhonographMusic a, PhonographMusic b) => a.Id.CompareTo(b.Id));
		return list;
	}

	// Token: 0x06011712 RID: 71442 RVA: 0x00445B24 File Offset: 0x00443D24
	public int GetCurPlayMusicId()
	{
		return this.CurPlayMusicId;
	}

	// Token: 0x06011713 RID: 71443 RVA: 0x00445B2C File Offset: 0x00443D2C
	public void SetCurPlayMusic(int albumId, int id)
	{
		if (albumId == this.CurPlayAlbum)
		{
			this.PrevMusicId = this.CurPlayMusicId;
		}
		else
		{
			this.CurPlayAlbum = albumId;
			this.PrevMusicId = -1;
		}
		this.CurPlayMusicId = id;
		this.IsPause = false;
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.MotorcycleCurPlayAlbumId, albumId);
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.MotorcycleCurPlayMusicId, id);
	}

	// Token: 0x06011714 RID: 71444 RVA: 0x00445B84 File Offset: 0x00443D84
	public int GetPrevMusicId()
	{
		return this.PrevMusicId;
	}

	// Token: 0x06011715 RID: 71445 RVA: 0x00445B8C File Offset: 0x00443D8C
	public void ClearPrevMusicId()
	{
		this.PrevMusicId = -1;
	}

	// Token: 0x06011716 RID: 71446 RVA: 0x00445B95 File Offset: 0x00443D95
	public int GetCurPlayAlbum()
	{
		return this.CurPlayAlbum;
	}

	// Token: 0x06011717 RID: 71447 RVA: 0x00445BA0 File Offset: 0x00443DA0
	public int GetDefaultMusicId()
	{
		List<PhonographMusic> unlockMusicByAlbum = this.GetUnlockMusicByAlbum(1);
		if (unlockMusicByAlbum.Count <= 0)
		{
			return -1;
		}
		return unlockMusicByAlbum[0].Id;
	}

	// Token: 0x06011718 RID: 71448 RVA: 0x00445BD0 File Offset: 0x00443DD0
	public void SwitchToDefaultAlbumWithoutPlay()
	{
		int defaultMusicId = this.GetDefaultMusicId();
		if (defaultMusicId == -1)
		{
			return;
		}
		this.SetCurPlayMusic(1, defaultMusicId);
		this.SetIsPause(true);
		this.ClearPrevMusicId();
	}

	// Token: 0x06011719 RID: 71449 RVA: 0x00445BFE File Offset: 0x00443DFE
	public bool GetIsPause()
	{
		return this.IsPause;
	}

	// Token: 0x0601171A RID: 71450 RVA: 0x00445C06 File Offset: 0x00443E06
	public void SetIsPause(bool isPause)
	{
		this.IsPause = isPause;
	}

	// Token: 0x0601171B RID: 71451 RVA: 0x00445C0F File Offset: 0x00443E0F
	public EMotorMusicPlayMode GetPlayMode()
	{
		return this.PlayMode;
	}

	// Token: 0x0601171C RID: 71452 RVA: 0x00445C17 File Offset: 0x00443E17
	public void SetCurPlayMode(EMotorMusicPlayMode mode)
	{
		this.PlayMode = mode;
		LocalStorage.SetPlayer<EMotorMusicPlayMode>(ELocalStoragePlayerKey.MotorcyclePlayMode, mode);
	}

	// Token: 0x0601171D RID: 71453 RVA: 0x00445C2C File Offset: 0x00443E2C
	public bool IsMusicNew(int id)
	{
		if (this.MusicNewSet == null)
		{
			this.MusicNewSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorcycleMusicRedDot, null);
		}
		if (this.IsMusicUnlock(id))
		{
			HashSet<int> musicNewSet = this.MusicNewSet;
			return musicNewSet != null && musicNewSet.Contains(id);
		}
		return false;
	}

	// Token: 0x0601171E RID: 71454 RVA: 0x00445C64 File Offset: 0x00443E64
	public void AddMusicListToNew(List<int> musicList)
	{
		if (this.MusicNewSet == null)
		{
			this.MusicNewSet = new HashSet<int>();
		}
		foreach (int item in musicList)
		{
			if (!this.MusicNewSet.Contains(item))
			{
				this.MusicNewSet.Add(item);
			}
		}
		this.SaveCacheMusicNewData();
	}

	// Token: 0x0601171F RID: 71455 RVA: 0x00445CE0 File Offset: 0x00443EE0
	public void ClearMusicNew(int id)
	{
		if (this.MusicNewSet == null)
		{
			return;
		}
		if (this.MusicNewSet.Contains(id))
		{
			this.MusicNewSet.Remove(id);
			this.SaveCacheMusicNewData();
		}
	}

	// Token: 0x06011720 RID: 71456 RVA: 0x00445D0C File Offset: 0x00443F0C
	public void SaveCacheMusicNewData()
	{
		if (this.MusicNewSet != null)
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorcycleMusicRedDot, this.MusicNewSet);
		}
	}

	// Token: 0x06011721 RID: 71457 RVA: 0x00445D28 File Offset: 0x00443F28
	public bool CheckAlbumHasNewMusic(int albumId)
	{
		foreach (PhonographMusic phonographMusic in this.GetMusicByAlbum(albumId))
		{
			if (this.IsMusicNew(phonographMusic.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06011722 RID: 71458 RVA: 0x00445D8C File Offset: 0x00443F8C
	public void ClearAlbum2MusicCache()
	{
		this.Album2MusicCache.Clear();
	}

	// Token: 0x06011723 RID: 71459 RVA: 0x00445D9C File Offset: 0x00443F9C
	public void SetAlbumTimeInfoMaps(IReadOnlyDictionary<int, IAlbumTimeInfo> albumMap, IReadOnlyDictionary<int, IAlbumTimeInfo> musicMap)
	{
		this.AlbumTimeInfoMap.Clear();
		this.MusicId2TimeInfoMap.Clear();
		foreach (KeyValuePair<int, IAlbumTimeInfo> keyValuePair in albumMap)
		{
			this.AlbumTimeInfoMap[keyValuePair.Key] = keyValuePair.Value;
		}
		foreach (KeyValuePair<int, IAlbumTimeInfo> keyValuePair2 in musicMap)
		{
			this.MusicId2TimeInfoMap[keyValuePair2.Key] = keyValuePair2.Value;
		}
	}

	// Token: 0x06011724 RID: 71460 RVA: 0x00445E58 File Offset: 0x00444058
	public void ClearAlbumTimeInfos()
	{
		this.AlbumTimeInfoMap.Clear();
		this.MusicId2TimeInfoMap.Clear();
	}

	// Token: 0x06011725 RID: 71461 RVA: 0x00445E70 File Offset: 0x00444070
	public bool IsTimeLimitAlbum(int albumId)
	{
		IAlbumTimeInfo albumTimeInfo;
		return this.AlbumTimeInfoMap.TryGetValue(albumId, out albumTimeInfo) && albumTimeInfo != null && (albumTimeInfo.BeginTime != 0L || albumTimeInfo.EndTime != 0L);
	}

	// Token: 0x06011726 RID: 71462 RVA: 0x00445EA3 File Offset: 0x004440A3
	public bool ShouldFallbackForExpired(int albumId)
	{
		return albumId != -1 && this.GetAlbumTimeState(albumId).Item1 == EAlbumTimeState.Expired;
	}

	// Token: 0x06011727 RID: 71463 RVA: 0x00445EBC File Offset: 0x004440BC
	[return: TupleElementNames(new string[]
	{
		"State",
		"Info",
		"NowSec"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private ValueTuple<EAlbumTimeState, IAlbumTimeInfo, long> GetAlbumTimeState(int albumId)
	{
		long num = 0L;
		IAlbumTimeInfo albumTimeInfo;
		this.AlbumTimeInfoMap.TryGetValue(albumId, out albumTimeInfo);
		if (albumTimeInfo == null)
		{
			return new ValueTuple<EAlbumTimeState, IAlbumTimeInfo, long>(EAlbumTimeState.Expired, null, num);
		}
		if (albumTimeInfo.BeginTime == 0L && albumTimeInfo.EndTime == 0L)
		{
			return new ValueTuple<EAlbumTimeState, IAlbumTimeInfo, long>(EAlbumTimeState.NoLimit, albumTimeInfo, num);
		}
		num = (long)Math.Floor(TimeUtil.Instance.GetServerTime());
		if (albumTimeInfo.BeginTime != 0L && num < albumTimeInfo.BeginTime)
		{
			return new ValueTuple<EAlbumTimeState, IAlbumTimeInfo, long>(EAlbumTimeState.NotStarted, albumTimeInfo, num);
		}
		if (albumTimeInfo.EndTime != 0L && num >= albumTimeInfo.EndTime)
		{
			return new ValueTuple<EAlbumTimeState, IAlbumTimeInfo, long>(EAlbumTimeState.Expired, albumTimeInfo, num);
		}
		return new ValueTuple<EAlbumTimeState, IAlbumTimeInfo, long>(EAlbumTimeState.InRange, albumTimeInfo, num);
	}

	// Token: 0x06011728 RID: 71464 RVA: 0x00445F50 File Offset: 0x00444150
	public bool IsAlbumInTimeRange(int albumId)
	{
		EAlbumTimeState item = this.GetAlbumTimeState(albumId).Item1;
		return item == EAlbumTimeState.NoLimit || item == EAlbumTimeState.InRange;
	}

	// Token: 0x06011729 RID: 71465 RVA: 0x00445F78 File Offset: 0x00444178
	public bool IsTimeLimitMusic(int musicId)
	{
		IAlbumTimeInfo albumTimeInfo;
		return this.MusicId2TimeInfoMap.TryGetValue(musicId, out albumTimeInfo) && albumTimeInfo != null && (albumTimeInfo.BeginTime != 0L || albumTimeInfo.EndTime != 0L);
	}

	// Token: 0x0601172A RID: 71466 RVA: 0x00445FAC File Offset: 0x004441AC
	[NullableContext(2)]
	public IAlbumTimeInfo GetAlbumTimeInfo(int albumId)
	{
		IAlbumTimeInfo result;
		this.AlbumTimeInfoMap.TryGetValue(albumId, out result);
		return result;
	}

	// Token: 0x0601172B RID: 71467 RVA: 0x00445FCC File Offset: 0x004441CC
	public string GetAlbumTimeLimitRemainText(int albumId)
	{
		ValueTuple<EAlbumTimeState, IAlbumTimeInfo, long> albumTimeState = this.GetAlbumTimeState(albumId);
		EAlbumTimeState item = albumTimeState.Item1;
		IAlbumTimeInfo item2 = albumTimeState.Item2;
		long item3 = albumTimeState.Item3;
		if (item != EAlbumTimeState.InRange || item2 == null)
		{
			if (item == EAlbumTimeState.NotStarted)
			{
			}
			return string.Empty;
		}
		long num = item2.EndTime - item3;
		return TimeUtil.Instance.GetRemainTimeDataFormat8((double)num).CountDownText;
	}

	// Token: 0x17001632 RID: 5682
	// (get) Token: 0x0601172C RID: 71468 RVA: 0x00446021 File Offset: 0x00444221
	public static MotorcycleMusicPlayerModel Instance
	{
		get
		{
			return MotorcycleMusicPlayerModel._Instance;
		}
	}

	// Token: 0x0601172D RID: 71469 RVA: 0x00446028 File Offset: 0x00444228
	public static MotorcycleMusicPlayerModel GetOrCreateInstance()
	{
		if (MotorcycleMusicPlayerModel._Instance == null)
		{
			MotorcycleMusicPlayerModel.CreateInstance();
		}
		return MotorcycleMusicPlayerModel._Instance;
	}

	// Token: 0x0601172E RID: 71470 RVA: 0x0044603C File Offset: 0x0044423C
	public static bool CreateInstance()
	{
		if (MotorcycleMusicPlayerModel._Instance != null)
		{
			return true;
		}
		MotorcycleMusicPlayerModel._Instance = new MotorcycleMusicPlayerModel();
		return true;
	}

	// Token: 0x0601172F RID: 71471 RVA: 0x00446052 File Offset: 0x00444252
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011730 RID: 71472 RVA: 0x00446054 File Offset: 0x00444254
	public static void ResetStaticDefaultValue()
	{
		MotorcycleMusicPlayerModel._Instance = null;
	}

	// Token: 0x06011731 RID: 71473 RVA: 0x0044605C File Offset: 0x0044425C
	static MotorcycleMusicPlayerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleMusicPlayerModel.CreateStaticDefaultValue), new Action(MotorcycleMusicPlayerModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400846D RID: 33901
	private List<int> FavoriteMusicList = new List<int>();

	// Token: 0x0400846E RID: 33902
	private int CurPlayMusicId = -1;

	// Token: 0x0400846F RID: 33903
	private int CurPlayAlbum = -1;

	// Token: 0x04008470 RID: 33904
	public HashSet<int> UnlockMusicIds = new HashSet<int>();

	// Token: 0x04008471 RID: 33905
	private EMotorMusicPlayMode PlayMode;

	// Token: 0x04008472 RID: 33906
	private bool IsPause;

	// Token: 0x04008473 RID: 33907
	private int PrevMusicId = -1;

	// Token: 0x04008474 RID: 33908
	[Nullable(2)]
	private HashSet<int> MusicNewSet;

	// Token: 0x04008475 RID: 33909
	public int CurrentPlayMusicTotalTime;

	// Token: 0x04008476 RID: 33910
	private List<int> CurrentPlayList = new List<int>();

	// Token: 0x04008477 RID: 33911
	private readonly Dictionary<int, List<PhonographMusic>> Album2MusicCache = new Dictionary<int, List<PhonographMusic>>();

	// Token: 0x04008478 RID: 33912
	private readonly Dictionary<int, IAlbumTimeInfo> AlbumTimeInfoMap = new Dictionary<int, IAlbumTimeInfo>();

	// Token: 0x04008479 RID: 33913
	private readonly Dictionary<int, IAlbumTimeInfo> MusicId2TimeInfoMap = new Dictionary<int, IAlbumTimeInfo>();

	// Token: 0x0400847A RID: 33914
	private int DisableCount;

	// Token: 0x0400847B RID: 33915
	private int VisibleState;

	// Token: 0x0400847C RID: 33916
	[Nullable(2)]
	private static MotorcycleMusicPlayerModel _Instance;
}
