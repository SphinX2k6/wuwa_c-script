using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A39 RID: 6713
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhonographModel : ModelBase
{
	// Token: 0x060108AB RID: 67755 RVA: 0x004D78F8 File Offset: 0x004D5AF8
	protected override bool OnInit()
	{
		PhonographConfig instance = PhonographConfig.Instance;
		IReadOnlyList<PhonographMusic> readOnlyList = (instance != null) ? instance.GetMusicList() : null;
		if (readOnlyList == null)
		{
			return true;
		}
		foreach (PhonographMusic phonographMusic in readOnlyList)
		{
			this.MusicItemIdSet.Add(phonographMusic.ItemId);
		}
		return true;
	}

	// Token: 0x17001913 RID: 6419
	// (get) Token: 0x060108AD RID: 67757 RVA: 0x004D7978 File Offset: 0x004D5B78
	// (set) Token: 0x060108AC RID: 67756 RVA: 0x004D7964 File Offset: 0x004D5B64
	public int RecordMusicId
	{
		get
		{
			int result;
			if (!this.RecordMusicIdMap.TryGetValue(this.CurrentPlayActorEntityId, out result))
			{
				return 0;
			}
			return result;
		}
		set
		{
			this.RecordMusicIdMap[this.CurrentPlayActorEntityId] = value;
		}
	}

	// Token: 0x060108AE RID: 67758 RVA: 0x004D79A0 File Offset: 0x004D5BA0
	public int GetRecordMusicId(int actorEntityId)
	{
		int result;
		if (!this.RecordMusicIdMap.TryGetValue(actorEntityId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x060108AF RID: 67759 RVA: 0x004D79C0 File Offset: 0x004D5BC0
	public int GetPlayIdRecord(int actorEntityId)
	{
		int result;
		if (!this.PlayIdRecordMap.TryGetValue(actorEntityId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x060108B0 RID: 67760 RVA: 0x004D79E0 File Offset: 0x004D5BE0
	public void SetPlayIdRecord(int actorEntityId, int musicId)
	{
		this.PlayIdRecordMap[actorEntityId] = musicId;
	}

	// Token: 0x060108B1 RID: 67761 RVA: 0x004D79EF File Offset: 0x004D5BEF
	public void RemovePlayIdRecord(int actorEntityId)
	{
		this.PlayIdRecordMap.Remove(actorEntityId);
	}

	// Token: 0x060108B2 RID: 67762 RVA: 0x004D7A00 File Offset: 0x004D5C00
	public bool IsUnlockMusic(int musicId)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(musicId) : null;
		return (phonographMusic != null && phonographMusic.Value.Lock) || this.UnlockMusicIds.Contains(musicId);
	}

	// Token: 0x060108B3 RID: 67763 RVA: 0x004D7A50 File Offset: 0x004D5C50
	public bool IsNewMusic(int musicId)
	{
		return this.NewMusicIds.Contains(musicId);
	}

	// Token: 0x060108B4 RID: 67764 RVA: 0x004D7A60 File Offset: 0x004D5C60
	public void RemoveNewMusic(int musicId)
	{
		int num = this.NewMusicIds.IndexOf(musicId);
		if (num >= 0)
		{
			this.NewMusicIds.RemoveAt(num);
		}
	}

	// Token: 0x17001914 RID: 6420
	// (get) Token: 0x060108B5 RID: 67765 RVA: 0x004D7A8C File Offset: 0x004D5C8C
	[Nullable(2)]
	public AActor EntityActor
	{
		[NullableContext(2)]
		get
		{
			CreatureModel instance = CreatureModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(this.CurrentPlayActorEntityId) : null;
			if (entityHandle == null)
			{
				return null;
			}
			WorldEntity entity = entityHandle.Entity;
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				return null;
			}
			return baseActorComponent.Owner;
		}
	}

	// Token: 0x17001915 RID: 6421
	// (get) Token: 0x060108B6 RID: 67766 RVA: 0x004D7AD4 File Offset: 0x004D5CD4
	public int? EntityId
	{
		get
		{
			CreatureModel instance = CreatureModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(this.CurrentPlayActorEntityId) : null;
			if (entityHandle == null)
			{
				return null;
			}
			WorldEntity entity = entityHandle.Entity;
			if (entity == null)
			{
				return null;
			}
			return new int?(entity.Id);
		}
	}

	// Token: 0x060108B7 RID: 67767 RVA: 0x004D7B24 File Offset: 0x004D5D24
	public bool CheckAlbumHasNewMusic(int albumId)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		foreach (PhonographMusic phonographMusic in (((instance != null) ? instance.GetMusicList() : null) ?? new List<PhonographMusic>()))
		{
			if (this.IsNewMusic(phonographMusic.Id))
			{
				int[] albumArray = phonographMusic.GetAlbumArray();
				if (albumArray != null && Array.IndexOf<int>(albumArray, albumId) >= 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060108B8 RID: 67768 RVA: 0x004D7BAC File Offset: 0x004D5DAC
	public void ClearPlayInfo()
	{
		this.CurrentPlayMusicId = 0;
		this.CurrentPlayActorEntityId = 0;
		this.CurrentPlayMusicTime = 0;
		this.CurrentPlayMusicTotalTime = 0;
	}

	// Token: 0x060108B9 RID: 67769 RVA: 0x004D7BCC File Offset: 0x004D5DCC
	[NullableContext(0)]
	public UniTask<float> GetMusicDuration(int musicId)
	{
		PhonographModel.<GetMusicDuration>d__30 <GetMusicDuration>d__;
		<GetMusicDuration>d__.<>t__builder = AsyncUniTaskMethodBuilder<float>.Create();
		<GetMusicDuration>d__.musicId = musicId;
		<GetMusicDuration>d__.<>1__state = -1;
		<GetMusicDuration>d__.<>t__builder.Start<PhonographModel.<GetMusicDuration>d__30>(ref <GetMusicDuration>d__);
		return <GetMusicDuration>d__.<>t__builder.Task;
	}

	// Token: 0x060108BA RID: 67770 RVA: 0x004D7C10 File Offset: 0x004D5E10
	public int GetCurrentPlayTimeFromAudio()
	{
		if (this.CurrentMusicHandleId == -1)
		{
			return 0;
		}
		int? sourcePlayPosition = AudioSystem.Instance.GetSourcePlayPosition(this.CurrentMusicHandleId, false);
		if (sourcePlayPosition == null)
		{
			return 0;
		}
		return (int)Math.Floor((double)((float)sourcePlayPosition.Value * 0.001f));
	}

	// Token: 0x060108BB RID: 67771 RVA: 0x004D7C5C File Offset: 0x004D5E5C
	public List<int> GetUnlockItemIds()
	{
		List<int> list = new List<int>();
		InventoryModel instance = InventoryModel.Instance;
		List<CommonItemData> list2 = (instance != null) ? instance.GetCommonItemByItemType(InventoryDefine.EItemType.Phonograph) : null;
		if (list2 == null)
		{
			return list;
		}
		foreach (CommonItemData commonItemData in list2)
		{
			if (this.MusicItemIdSet.Contains(commonItemData.GetConfigId()))
			{
				list.Add(commonItemData.GetConfigId());
			}
		}
		return list;
	}

	// Token: 0x17001916 RID: 6422
	// (get) Token: 0x060108BC RID: 67772 RVA: 0x004D7CE8 File Offset: 0x004D5EE8
	public static PhonographModel Instance
	{
		get
		{
			return PhonographModel._Instance;
		}
	}

	// Token: 0x060108BD RID: 67773 RVA: 0x004D7CEF File Offset: 0x004D5EEF
	public static PhonographModel GetOrCreateInstance()
	{
		if (PhonographModel._Instance == null)
		{
			PhonographModel.CreateInstance();
		}
		return PhonographModel._Instance;
	}

	// Token: 0x060108BE RID: 67774 RVA: 0x004D7D03 File Offset: 0x004D5F03
	public static bool CreateInstance()
	{
		if (PhonographModel._Instance != null)
		{
			return true;
		}
		PhonographModel._Instance = new PhonographModel();
		return true;
	}

	// Token: 0x060108BF RID: 67775 RVA: 0x004D7D19 File Offset: 0x004D5F19
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060108C0 RID: 67776 RVA: 0x004D7D1B File Offset: 0x004D5F1B
	public static void ResetStaticDefaultValue()
	{
		PhonographModel._Instance = null;
	}

	// Token: 0x060108C1 RID: 67777 RVA: 0x004D7D23 File Offset: 0x004D5F23
	static PhonographModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhonographModel.CreateStaticDefaultValue), new Action(PhonographModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009291 RID: 37521
	public int CurrentPlayMusicId;

	// Token: 0x04009292 RID: 37522
	public int CurrentSelectMusicId;

	// Token: 0x04009293 RID: 37523
	public int CurrentPlayActorEntityId;

	// Token: 0x04009294 RID: 37524
	public bool IsGlobal;

	// Token: 0x04009295 RID: 37525
	public int CurrentPlayMusicTime;

	// Token: 0x04009296 RID: 37526
	public int CurrentPlayMusicTotalTime;

	// Token: 0x04009297 RID: 37527
	public List<int> UnlockMusicIds = new List<int>();

	// Token: 0x04009298 RID: 37528
	public List<int> NewMusicIds = new List<int>();

	// Token: 0x04009299 RID: 37529
	public int GlobalMusicId;

	// Token: 0x0400929A RID: 37530
	public int CurrentMusicHandleId;

	// Token: 0x0400929B RID: 37531
	public readonly Dictionary<int, int> RecordMusicIdMap = new Dictionary<int, int>();

	// Token: 0x0400929C RID: 37532
	private readonly Dictionary<int, int> PlayIdRecordMap = new Dictionary<int, int>();

	// Token: 0x0400929D RID: 37533
	private readonly HashSet<int> MusicItemIdSet = new HashSet<int>();

	// Token: 0x0400929E RID: 37534
	[Nullable(2)]
	private static PhonographModel _Instance;
}
