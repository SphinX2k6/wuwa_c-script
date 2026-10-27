using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200254E RID: 9550
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhonographModel : ModelBase
{
	// Token: 0x060133CB RID: 78795 RVA: 0x004C8D7C File Offset: 0x004C6F7C
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

	// Token: 0x170018DA RID: 6362
	// (get) Token: 0x060133CD RID: 78797 RVA: 0x004C8DFC File Offset: 0x004C6FFC
	// (set) Token: 0x060133CC RID: 78796 RVA: 0x004C8DE8 File Offset: 0x004C6FE8
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

	// Token: 0x060133CE RID: 78798 RVA: 0x004C8E24 File Offset: 0x004C7024
	public int GetRecordMusicId(int actorEntityId)
	{
		int result;
		if (!this.RecordMusicIdMap.TryGetValue(actorEntityId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x060133CF RID: 78799 RVA: 0x004C8E44 File Offset: 0x004C7044
	public int GetPlayIdRecord(int actorEntityId)
	{
		int result;
		if (!this.PlayIdRecordMap.TryGetValue(actorEntityId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x060133D0 RID: 78800 RVA: 0x004C8E64 File Offset: 0x004C7064
	public void SetPlayIdRecord(int actorEntityId, int musicId)
	{
		this.PlayIdRecordMap[actorEntityId] = musicId;
	}

	// Token: 0x060133D1 RID: 78801 RVA: 0x004C8E73 File Offset: 0x004C7073
	public void RemovePlayIdRecord(int actorEntityId)
	{
		this.PlayIdRecordMap.Remove(actorEntityId);
	}

	// Token: 0x060133D2 RID: 78802 RVA: 0x004C8E84 File Offset: 0x004C7084
	public bool IsUnlockMusic(int musicId)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(musicId) : null;
		return (phonographMusic != null && phonographMusic.Value.Lock) || this.UnlockMusicIds.Contains(musicId);
	}

	// Token: 0x060133D3 RID: 78803 RVA: 0x004C8ED4 File Offset: 0x004C70D4
	public bool IsNewMusic(int musicId)
	{
		return this.NewMusicIds.Contains(musicId);
	}

	// Token: 0x060133D4 RID: 78804 RVA: 0x004C8EE4 File Offset: 0x004C70E4
	public void RemoveNewMusic(int musicId)
	{
		int num = this.NewMusicIds.IndexOf(musicId);
		if (num >= 0)
		{
			this.NewMusicIds.RemoveAt(num);
		}
	}

	// Token: 0x170018DB RID: 6363
	// (get) Token: 0x060133D5 RID: 78805 RVA: 0x004C8F10 File Offset: 0x004C7110
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

	// Token: 0x170018DC RID: 6364
	// (get) Token: 0x060133D6 RID: 78806 RVA: 0x004C8F58 File Offset: 0x004C7158
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

	// Token: 0x060133D7 RID: 78807 RVA: 0x004C8FA8 File Offset: 0x004C71A8
	public bool CheckAlbumHasNewMusic(int albumId)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		foreach (PhonographMusic phonographMusic in (((instance != null) ? instance.GetMusicList() : null) ?? new List<PhonographMusic>()))
		{
			if (this.IsNewMusic(phonographMusic.Id))
			{
				int[] albumArray = phonographMusic.GetAlbumArray();
				if (albumArray != null && albumArray.Contains(albumId))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060133D8 RID: 78808 RVA: 0x004C902C File Offset: 0x004C722C
	public void ClearPlayInfo()
	{
		this.CurrentPlayMusicId = 0;
		this.CurrentPlayActorEntityId = 0;
		this.CurrentPlayMusicTime = 0;
		this.CurrentPlayMusicTotalTime = 0;
	}

	// Token: 0x060133D9 RID: 78809 RVA: 0x004C904C File Offset: 0x004C724C
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

	// Token: 0x060133DA RID: 78810 RVA: 0x004C9090 File Offset: 0x004C7290
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

	// Token: 0x060133DB RID: 78811 RVA: 0x004C90DC File Offset: 0x004C72DC
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

	// Token: 0x170018DD RID: 6365
	// (get) Token: 0x060133DC RID: 78812 RVA: 0x004C9168 File Offset: 0x004C7368
	public static PhonographModel Instance
	{
		get
		{
			return PhonographModel._Instance;
		}
	}

	// Token: 0x060133DD RID: 78813 RVA: 0x004C916F File Offset: 0x004C736F
	public static PhonographModel GetOrCreateInstance()
	{
		if (PhonographModel._Instance == null)
		{
			PhonographModel.CreateInstance();
		}
		return PhonographModel._Instance;
	}

	// Token: 0x060133DE RID: 78814 RVA: 0x004C9183 File Offset: 0x004C7383
	public static bool CreateInstance()
	{
		if (PhonographModel._Instance != null)
		{
			return true;
		}
		PhonographModel._Instance = new PhonographModel();
		return true;
	}

	// Token: 0x060133DF RID: 78815 RVA: 0x004C9199 File Offset: 0x004C7399
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060133E0 RID: 78816 RVA: 0x004C919B File Offset: 0x004C739B
	public static void ResetStaticDefaultValue()
	{
		PhonographModel._Instance = null;
	}

	// Token: 0x060133E1 RID: 78817 RVA: 0x004C91A3 File Offset: 0x004C73A3
	static PhonographModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhonographModel.CreateStaticDefaultValue), new Action(PhonographModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009138 RID: 37176
	public int CurrentPlayMusicId;

	// Token: 0x04009139 RID: 37177
	public int CurrentSelectMusicId;

	// Token: 0x0400913A RID: 37178
	public int CurrentPlayActorEntityId;

	// Token: 0x0400913B RID: 37179
	public bool IsGlobal;

	// Token: 0x0400913C RID: 37180
	public int CurrentPlayMusicTime;

	// Token: 0x0400913D RID: 37181
	public int CurrentPlayMusicTotalTime;

	// Token: 0x0400913E RID: 37182
	public List<int> UnlockMusicIds = new List<int>();

	// Token: 0x0400913F RID: 37183
	public List<int> NewMusicIds = new List<int>();

	// Token: 0x04009140 RID: 37184
	public int GlobalMusicId;

	// Token: 0x04009141 RID: 37185
	public int CurrentMusicHandleId;

	// Token: 0x04009142 RID: 37186
	public readonly Dictionary<int, int> RecordMusicIdMap = new Dictionary<int, int>();

	// Token: 0x04009143 RID: 37187
	private readonly Dictionary<int, int> PlayIdRecordMap = new Dictionary<int, int>();

	// Token: 0x04009144 RID: 37188
	private readonly HashSet<int> MusicItemIdSet = new HashSet<int>();

	// Token: 0x04009145 RID: 37189
	[Nullable(2)]
	private static PhonographModel _Instance;
}
