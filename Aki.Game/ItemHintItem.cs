using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FFE RID: 8190
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ItemHintItem : ItemHintItemBase<ItemRewardInfo>
{
	// Token: 0x060100D7 RID: 65751 RVA: 0x003E99D4 File Offset: 0x003E7BD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060100D8 RID: 65752 RVA: 0x003E9A44 File Offset: 0x003E7C44
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
	}

	// Token: 0x060100D9 RID: 65753 RVA: 0x003E9A6F File Offset: 0x003E7C6F
	protected override void OnBeforeDestroy()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}
	}

	// Token: 0x060100DA RID: 65754 RVA: 0x003E9A8B File Offset: 0x003E7C8B
	[NullableContext(1)]
	private void FinishSequenceEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			base.FinishPlayStart();
			return;
		}
		if (sequenceName == "Move")
		{
			base.FinishPlayHalfway();
			return;
		}
		if (sequenceName == "Close")
		{
			base.FinishPlayEnd();
		}
	}

	// Token: 0x060100DB RID: 65755 RVA: 0x003E9AC8 File Offset: 0x003E7CC8
	public override UniTask AsyncLoadUiResource()
	{
		ItemHintItem.<AsyncLoadUiResource>d__10 <AsyncLoadUiResource>d__;
		<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AsyncLoadUiResource>d__.<>4__this = this;
		<AsyncLoadUiResource>d__.<>1__state = -1;
		<AsyncLoadUiResource>d__.<>t__builder.Start<ItemHintItem.<AsyncLoadUiResource>d__10>(ref <AsyncLoadUiResource>d__);
		return <AsyncLoadUiResource>d__.<>t__builder.Task;
	}

	// Token: 0x060100DC RID: 65756 RVA: 0x003E9B0C File Offset: 0x003E7D0C
	public override void InitData()
	{
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.Data.ItemId.GetValueOrDefault());
		if (itemConfigData != null)
		{
			string name = itemConfigData.Name;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
			int? itemCount = this.Data.ItemCount;
			base.GetText(2).SetText(itemCount.ToString(), true);
			TItemQualityConfig itemQualityByItemIdAndQuality = InventoryConfig.Instance.GetItemQualityByItemIdAndQuality(this.Data.ItemId, itemConfigData.QualityId);
			if (itemQualityByItemIdAndQuality != null)
			{
				FColor color = FColor.FromHex(itemQualityByItemIdAndQuality.TextColor);
				base.GetText(1).SetColor(color);
				base.GetText(3).SetColor(color);
				base.GetText(2).SetColor(color);
				this.ItemAudioQuality = new int?(itemConfigData.QualityId);
			}
		}
		this.CurSequencePlayer = null;
	}

	// Token: 0x060100DD RID: 65757 RVA: 0x003E9BEC File Offset: 0x003E7DEC
	protected override void PlayStart()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		this.CurSequencePlayer = "Start";
		this.PlayItemHintAudio();
	}

	// Token: 0x060100DE RID: 65758 RVA: 0x003E9C28 File Offset: 0x003E7E28
	private void PlayItemHintAudio()
	{
		if (this.ItemAudioQuality != null)
		{
			int? itemAudioQuality = this.ItemAudioQuality;
			int num = 4;
			if (itemAudioQuality.GetValueOrDefault() >= num & itemAudioQuality != null)
			{
				if (ItemController.Instance.LastItemHintAudioPlayedTime != null)
				{
					double? num2 = Time.Instance.Now - ItemController.Instance.LastItemHintAudioPlayedTime;
					double num3 = (double)500;
					if (!(num2.GetValueOrDefault() > num3 & num2 != null) && ItemController.Instance.LastItemHintAudioLevel >= 2)
					{
						Log.Instance.Info(ELogModule.Audio, ELogAuthor.YJY, "[Item] 物品音效冷却中，不播放音效", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
				}
				AudioSystem.Instance.PostEvent("play_ui_item_hint_in_list_rare");
				ItemController.Instance.LastItemHintAudioLevel = 2;
				Log.Instance.Info(ELogModule.Audio, ELogAuthor.YJY, "[Item] 播放高品质物品提示音效", default(ReadOnlySpan<ValueTuple<string, object>>));
				ItemController.Instance.LastItemHintAudioPlayedTime = new double?(Time.Instance.Now);
				return;
			}
		}
		if (ItemController.Instance.LastItemHintAudioPlayedTime != null)
		{
			double? num2 = Time.Instance.Now - ItemController.Instance.LastItemHintAudioPlayedTime;
			double num3 = (double)500;
			if (!(num2.GetValueOrDefault() > num3 & num2 != null))
			{
				Log.Instance.Info(ELogModule.Audio, ELogAuthor.YJY, "[Item] 物品提示音效冷却中，跳过播放", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
		}
		AudioSystem.Instance.PostEvent("play_ui_item_hint_in_list_normal");
		ItemController.Instance.LastItemHintAudioLevel = 1;
		Log.Instance.Info(ELogModule.Audio, ELogAuthor.YJY, "[Item] 播放普通品质物品提示音效", default(ReadOnlySpan<ValueTuple<string, object>>));
		ItemController.Instance.LastItemHintAudioPlayedTime = new double?(Time.Instance.Now);
	}

	// Token: 0x060100DF RID: 65759 RVA: 0x003E9E28 File Offset: 0x003E8028
	protected override void PlayHalfway()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Move", false, null, false);
		this.CurSequencePlayer = "Move";
	}

	// Token: 0x060100E0 RID: 65760 RVA: 0x003E9E5C File Offset: 0x003E805C
	public override void PlayEnd()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		this.CurSequencePlayer = "Close";
	}

	// Token: 0x060100E1 RID: 65761 RVA: 0x003E9E90 File Offset: 0x003E8090
	protected unsafe override void OnActiveStatusChange(bool value)
	{
		if (this.CurSequencePlayer != null)
		{
			if (value)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ItemHint;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "[ItemHintItem]奖励列表重新可见时暂停条目动画";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "itemId";
				ItemRewardInfo data = this.Data;
				ptr = new ValueTuple<string, object>(item, (data != null) ? data.ItemId : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("status", base.Status);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("sequence", this.CurSequencePlayer);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.LevelSequencePlayer.PauseSequence();
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.ItemHint;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "[ItemHintItem]奖励列表不可见时恢复条目动画";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item2 = "itemId";
			ItemRewardInfo data2 = this.Data;
			ptr2 = new ValueTuple<string, object>(item2, (data2 != null) ? data2.ItemId : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("status", base.Status);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("sequence", this.CurSequencePlayer);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			this.LevelSequencePlayer.ResumeSequence();
		}
	}

	// Token: 0x040076BF RID: 30399
	private const int AUDIO_EFFECT_RARE_LEVEL = 4;

	// Token: 0x040076C0 RID: 30400
	private const int AUDIO_HINT_CD_MS = 500;

	// Token: 0x040076C1 RID: 30401
	protected string CurSequencePlayer;

	// Token: 0x040076C2 RID: 30402
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040076C3 RID: 30403
	private int? ItemAudioQuality;

	// Token: 0x02008606 RID: 34310
	[NullableContext(0)]
	private enum EItemHintItemCom
	{
		// Token: 0x0402B9EF RID: 178671
		ItemIcon,
		// Token: 0x0402B9F0 RID: 178672
		ItemNameText,
		// Token: 0x0402B9F1 RID: 178673
		ItemCountText,
		// Token: 0x0402B9F2 RID: 178674
		ItemXText
	}
}
