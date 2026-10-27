using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using UnrealEngine;

// Token: 0x02002571 RID: 9585
[NullableContext(2)]
[Nullable(0)]
public class PhotoUnlockAnimPlayer
{
	// Token: 0x060135A6 RID: 79270 RVA: 0x004D0AB4 File Offset: 0x004CECB4
	public static bool IsUnlockByItem(int relativeItem)
	{
		return relativeItem == 0 || InventoryModel.Instance.GetItemCountByConfigId(relativeItem, 0) > 0;
	}

	// Token: 0x060135A7 RID: 79271 RVA: 0x004D0ACC File Offset: 0x004CECCC
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

	// Token: 0x060135A8 RID: 79272 RVA: 0x004D0B89 File Offset: 0x004CED89
	public void Clear()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x040091D6 RID: 37334
	private LevelSequencePlayer SequencePlayer;
}
