using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using UnrealEngine;

// Token: 0x02001A5C RID: 6748
[NullableContext(2)]
[Nullable(0)]
public class PhotoUnlockAnimPlayer
{
	// Token: 0x06010A88 RID: 68232 RVA: 0x004DF6EC File Offset: 0x004DD8EC
	public static bool IsUnlockByItem(int relativeItem)
	{
		return relativeItem == 0 || InventoryModel.Instance.GetItemCountByConfigId(relativeItem, 0) > 0;
	}

	// Token: 0x06010A89 RID: 68233 RVA: 0x004DF702 File Offset: 0x004DD902
	public static bool IsUnlockAnimationUnplayed(int relativeItem)
	{
		if (relativeItem == 0 || !PhotoUnlockAnimPlayer.IsUnlockByItem(relativeItem))
		{
			return false;
		}
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Photography) as ServerStorageSet;
		return serverStorageSet != null && !serverStorageSet.Has(relativeItem);
	}

	// Token: 0x06010A8A RID: 68234 RVA: 0x004DF734 File Offset: 0x004DD934
	public void TryPlay(UUIItem rootItem, int relativeItem)
	{
		if (rootItem == null || !rootItem.IsValid())
		{
			return;
		}
		if (this.SequencePlayer == null)
		{
			this.SequencePlayer = new LevelSequencePlayer(rootItem);
		}
		this.SequencePlayer.StopSequenceByKey("Unlock", false, true);
		if (relativeItem == 0)
		{
			return;
		}
		if (!PhotoUnlockAnimPlayer.IsUnlockByItem(relativeItem))
		{
			return;
		}
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Photography) as ServerStorageSet;
		if (serverStorageSet == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "拍照解锁动画取存储项失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("道具id", relativeItem);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (serverStorageSet.Has(relativeItem))
		{
			return;
		}
		serverStorageSet.Add(relativeItem);
		this.SequencePlayer.PlayLevelSequenceByName("Unlock", false, null, false);
	}

	// Token: 0x06010A8B RID: 68235 RVA: 0x004DF7F1 File Offset: 0x004DD9F1
	public void Clear()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x0400932F RID: 37679
	private LevelSequencePlayer SequencePlayer;
}
