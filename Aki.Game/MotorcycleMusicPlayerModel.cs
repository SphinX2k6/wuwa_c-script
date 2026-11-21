using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x020017A0 RID: 6048
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MotorcycleMusicPlayerModel : ModelBase
{
	// Token: 0x17001668 RID: 5736
	// (get) Token: 0x0600EB9A RID: 60314 RVA: 0x0045245A File Offset: 0x0045065A
	public bool IsEnable
	{
		get
		{
			return VisibleStateUtil.GetVisible(this.VisibleState);
		}
	}

	// Token: 0x0600EB9B RID: 60315 RVA: 0x00452467 File Offset: 0x00450667
	public void IncreaseDisableCount()
	{
		this.DisableCount++;
		this.UpdateDisableVisibleState();
	}

	// Token: 0x0600EB9C RID: 60316 RVA: 0x0045247D File Offset: 0x0045067D
	public void DecreaseDisableCount()
	{
		this.DisableCount--;
		this.UpdateDisableVisibleState();
	}

	// Token: 0x0600EB9D RID: 60317 RVA: 0x00452493 File Offset: 0x00450693
	public void SetFunctionEnable(bool isEnable)
	{
		this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, isEnable, 0);
	}

	// Token: 0x0600EB9E RID: 60318 RVA: 0x004524A8 File Offset: 0x004506A8
	public void SetFightMusicEnable(bool isEnable)
	{
		this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, isEnable, 2);
	}

	// Token: 0x0600EB9F RID: 60319 RVA: 0x004524C0 File Offset: 0x004506C0
	private void UpdateDisableVisibleState()
	{
		bool bVisible = this.DisableCount == 0;
		this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, bVisible, 1);
	}

	// Token: 0x0600EBA0 RID: 60320 RVA: 0x004524EA File Offset: 0x004506EA
	public bool LoadLocalStorageData()
	{
		this.MusicNewSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorcycleMusicRedDot, null);
		this.PlayMode = LocalStorage.GetPlayer<EMotorMusicPlayMode>(ELocalStoragePlayerKey.MotorcyclePlayMode, EMotorMusicPlayMode.Order);
		this.IsPause = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.MotorcycleMusicIsPause, false);
		return true;
	}

	// Token: 0x0600EBA1 RID: 60321 RVA: 0x00452520 File Offset: 0x00450720
	public bool IsMusicFavorite(int id)
	{
		return this.FavoriteMusicList.Contains(id);
	}

	// Token: 0x0600EBA2 RID: 60322 RVA: 0x00452530 File Offset: 0x00450730
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

	// Token: 0x0600EBA3 RID: 60323 RVA: 0x004525A0 File Offset: 0x004507A0
	public IReadOnlyList<int> GetFavoriteMusicList()
	{
		return this.FavoriteMusicList;
	}

	// Token: 0x0600EBA4 RID: 60324 RVA: 0x004525A8 File Offset: 0x004507A8
	public void SetFavoriteMusicList(IReadOnlyList<int> musicList)
	{
		this.FavoriteMusicList = new List<int>(musicList);
	}

	// Token: 0x0600EBA5 RID: 60325 RVA: 0x004525B6 File Offset: 0x004507B6
	public IReadOnlyList<int> GetCurrentPlayList()
	{
		return this.CurrentPlayList;
	}

	// Token: 0x0600EBA6 RID: 60326 RVA: 0x004525BE File Offset: 0x004507BE
	public void SetPlayList(List<int> musicList)
	{
		this.CurrentPlayList = musicList;
	}

	// Token: 0x0600EBA7 RID: 60327 RVA: 0x004525C7 File Offset: 0x004507C7
	public bool IsMusicUnlock(int id)
	{
		return PhonographModel.Instance.IsUnlockMusic(id);
	}

	// Token: 0x0600EBA8 RID: 60328 RVA: 0x004525D4 File Offset: 0x004507D4
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
		List<PhonographMusic> list2 = NoLinq.WhereToList<PhonographMusic>(PhonographConfig.Instance.GetMusicList() ?? new List<PhonographMusic>(), (PhonographMusic music) => NoLinq.Contains<int>(music.GetAlbumBytes(), albumId));
		this.Album2MusicCache[albumId] = list2;
		return list2;
	}

	// Token: 0x0600EBA9 RID: 60329 RVA: 0x004526CC File Offset: 0x004508CC
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

	// Token: 0x0600EBAA RID: 60330 RVA: 0x0045276C File Offset: 0x0045096C
	public int GetCurPlayMusicId()
	{
		return this.CurPlayMusicId;
	}

	// Token: 0x0600EBAB RID: 60331 RVA: 0x00452774 File Offset: 0x00450974
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

	// Token: 0x0600EBAC RID: 60332 RVA: 0x004527CC File Offset: 0x004509CC
	public int GetPrevMusicId()
	{
		return this.PrevMusicId;
	}

	// Token: 0x0600EBAD RID: 60333 RVA: 0x004527D4 File Offset: 0x004509D4
	public void ClearPrevMusicId()
	{
		this.PrevMusicId = -1;
	}

	// Token: 0x0600EBAE RID: 60334 RVA: 0x004527DD File Offset: 0x004509DD
	public int GetCurPlayAlbum()
	{
		return this.CurPlayAlbum;
	}

	// Token: 0x0600EBAF RID: 60335 RVA: 0x004527E8 File Offset: 0x004509E8
	public int GetDefaultMusicId()
	{
		List<PhonographMusic> unlockMusicByAlbum = this.GetUnlockMusicByAlbum(1);
		if (unlockMusicByAlbum.Count <= 0)
		{
			return -1;
		}
		return unlockMusicByAlbum[0].Id;
	}

	// Token: 0x0600EBB0 RID: 60336 RVA: 0x00452818 File Offset: 0x00450A18
	public void SwitchToDefaultAlbumWithoutPlay()
	{
		int defaultMusicId = this.GetDefaultMusicId();
		if (defaultMusicId == -1)
		{
			return;
		}
		this.SetCurPlayMusic(1, defaultMusicId);
		this.SetIsPause(true, false);
		this.ClearPrevMusicId();
	}

	// Token: 0x0600EBB1 RID: 60337 RVA: 0x00452847 File Offset: 0x00450A47
	public bool GetIsPause()
	{
		return this.IsPause;
	}

	// Token: 0x0600EBB2 RID: 60338 RVA: 0x0045284F File Offset: 0x00450A4F
	public void SetIsPause(bool isPause, bool saveToLocalStorage = false)
	{
		this.IsPause = isPause;
		if (saveToLocalStorage)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.MotorcycleMusicIsPause, isPause);
		}
	}

	// Token: 0x0600EBB3 RID: 60339 RVA: 0x00452867 File Offset: 0x00450A67
	public EMotorMusicPlayMode GetPlayMode()
	{
		return this.PlayMode;
	}

	// Token: 0x0600EBB4 RID: 60340 RVA: 0x0045286F File Offset: 0x00450A6F
	public void SetCurPlayMode(EMotorMusicPlayMode mode)
	{
		this.PlayMode = mode;
		LocalStorage.SetPlayer<EMotorMusicPlayMode>(ELocalStoragePlayerKey.MotorcyclePlayMode, mode);
	}

	// Token: 0x0600EBB5 RID: 60341 RVA: 0x00452884 File Offset: 0x00450A84
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

	// Token: 0x0600EBB6 RID: 60342 RVA: 0x004528BC File Offset: 0x00450ABC
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

	// Token: 0x0600EBB7 RID: 60343 RVA: 0x00452938 File Offset: 0x00450B38
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

	// Token: 0x0600EBB8 RID: 60344 RVA: 0x00452964 File Offset: 0x00450B64
	public void SaveCacheMusicNewData()
	{
		if (this.MusicNewSet != null)
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorcycleMusicRedDot, this.MusicNewSet);
		}
	}

	// Token: 0x0600EBB9 RID: 60345 RVA: 0x00452980 File Offset: 0x00450B80
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

	// Token: 0x0600EBBA RID: 60346 RVA: 0x004529E4 File Offset: 0x00450BE4
	public void ClearAlbum2MusicCache()
	{
		this.Album2MusicCache.Clear();
	}

	// Token: 0x0600EBBB RID: 60347 RVA: 0x004529F4 File Offset: 0x00450BF4
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

	// Token: 0x0600EBBC RID: 60348 RVA: 0x00452AB0 File Offset: 0x00450CB0
	public void ClearAlbumTimeInfos()
	{
		this.AlbumTimeInfoMap.Clear();
		this.MusicId2TimeInfoMap.Clear();
	}

	// Token: 0x0600EBBD RID: 60349 RVA: 0x00452AC8 File Offset: 0x00450CC8
	public bool IsTimeLimitAlbum(int albumId)
	{
		IAlbumTimeInfo albumTimeInfo;
		return this.AlbumTimeInfoMap.TryGetValue(albumId, out albumTimeInfo) && albumTimeInfo != null && (albumTimeInfo.BeginTime != 0L || albumTimeInfo.EndTime != 0L);
	}

	// Token: 0x0600EBBE RID: 60350 RVA: 0x00452AFB File Offset: 0x00450CFB
	public bool ShouldFallbackForExpired(int albumId)
	{
		return albumId != -1 && this.GetAlbumTimeState(albumId).Item1 == EAlbumTimeState.Expired;
	}

	// Token: 0x0600EBBF RID: 60351 RVA: 0x00452B14 File Offset: 0x00450D14
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

	// Token: 0x0600EBC0 RID: 60352 RVA: 0x00452BA8 File Offset: 0x00450DA8
	public bool IsAlbumInTimeRange(int albumId)
	{
		EAlbumTimeState item = this.GetAlbumTimeState(albumId).Item1;
		return item == EAlbumTimeState.NoLimit || item == EAlbumTimeState.InRange;
	}

	// Token: 0x0600EBC1 RID: 60353 RVA: 0x00452BD0 File Offset: 0x00450DD0
	public bool IsTimeLimitMusic(int musicId)
	{
		IAlbumTimeInfo albumTimeInfo;
		return this.MusicId2TimeInfoMap.TryGetValue(musicId, out albumTimeInfo) && albumTimeInfo != null && (albumTimeInfo.BeginTime != 0L || albumTimeInfo.EndTime != 0L);
	}

	// Token: 0x0600EBC2 RID: 60354 RVA: 0x00452C04 File Offset: 0x00450E04
	[NullableContext(2)]
	public IAlbumTimeInfo GetAlbumTimeInfo(int albumId)
	{
		IAlbumTimeInfo result;
		this.AlbumTimeInfoMap.TryGetValue(albumId, out result);
		return result;
	}

	// Token: 0x0600EBC3 RID: 60355 RVA: 0x00452C24 File Offset: 0x00450E24
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

	// Token: 0x17001669 RID: 5737
	// (get) Token: 0x0600EBC4 RID: 60356 RVA: 0x00452C79 File Offset: 0x00450E79
	public static MotorcycleMusicPlayerModel Instance
	{
		get
		{
			return MotorcycleMusicPlayerModel._Instance;
		}
	}

	// Token: 0x0600EBC5 RID: 60357 RVA: 0x00452C80 File Offset: 0x00450E80
	public static MotorcycleMusicPlayerModel GetOrCreateInstance()
	{
		if (MotorcycleMusicPlayerModel._Instance == null)
		{
			MotorcycleMusicPlayerModel.CreateInstance();
		}
		return MotorcycleMusicPlayerModel._Instance;
	}

	// Token: 0x0600EBC6 RID: 60358 RVA: 0x00452C94 File Offset: 0x00450E94
	public static bool CreateInstance()
	{
		if (MotorcycleMusicPlayerModel._Instance != null)
		{
			return true;
		}
		MotorcycleMusicPlayerModel._Instance = new MotorcycleMusicPlayerModel();
		return true;
	}

	// Token: 0x0600EBC7 RID: 60359 RVA: 0x00452CAA File Offset: 0x00450EAA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EBC8 RID: 60360 RVA: 0x00452CAC File Offset: 0x00450EAC
	public static void ResetStaticDefaultValue()
	{
		MotorcycleMusicPlayerModel._Instance = null;
	}

	// Token: 0x0600EBC9 RID: 60361 RVA: 0x00452CB4 File Offset: 0x00450EB4
	static MotorcycleMusicPlayerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleMusicPlayerModel.CreateStaticDefaultValue), new Action(MotorcycleMusicPlayerModel.ResetStaticDefaultValue));
	}

	// Token: 0x040085AB RID: 34219
	private List<int> FavoriteMusicList = new List<int>();

	// Token: 0x040085AC RID: 34220
	private int CurPlayMusicId = -1;

	// Token: 0x040085AD RID: 34221
	private int CurPlayAlbum = -1;

	// Token: 0x040085AE RID: 34222
	public HashSet<int> UnlockMusicIds = new HashSet<int>();

	// Token: 0x040085AF RID: 34223
	private EMotorMusicPlayMode PlayMode;

	// Token: 0x040085B0 RID: 34224
	private bool IsPause;

	// Token: 0x040085B1 RID: 34225
	private int PrevMusicId = -1;

	// Token: 0x040085B2 RID: 34226
	[Nullable(2)]
	private HashSet<int> MusicNewSet;

	// Token: 0x040085B3 RID: 34227
	public int CurrentPlayMusicTotalTime;

	// Token: 0x040085B4 RID: 34228
	private List<int> CurrentPlayList = new List<int>();

	// Token: 0x040085B5 RID: 34229
	private readonly Dictionary<int, List<PhonographMusic>> Album2MusicCache = new Dictionary<int, List<PhonographMusic>>();

	// Token: 0x040085B6 RID: 34230
	private readonly Dictionary<int, IAlbumTimeInfo> AlbumTimeInfoMap = new Dictionary<int, IAlbumTimeInfo>();

	// Token: 0x040085B7 RID: 34231
	private readonly Dictionary<int, IAlbumTimeInfo> MusicId2TimeInfoMap = new Dictionary<int, IAlbumTimeInfo>();

	// Token: 0x040085B8 RID: 34232
	private int DisableCount;

	// Token: 0x040085B9 RID: 34233
	private int VisibleState;

	// Token: 0x040085BA RID: 34234
	[Nullable(2)]
	private static MotorcycleMusicPlayerModel _Instance;
}
