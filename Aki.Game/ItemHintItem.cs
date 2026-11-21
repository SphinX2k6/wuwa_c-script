using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014D1 RID: 5329
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ItemHintItem : ItemHintItemBase<ItemRewardInfo>
{
	// Token: 0x0600D53F RID: 54591 RVA: 0x003F5FCC File Offset: 0x003F41CC
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

	// Token: 0x0600D540 RID: 54592 RVA: 0x003F603C File Offset: 0x003F423C
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
	}

	// Token: 0x0600D541 RID: 54593 RVA: 0x003F6067 File Offset: 0x003F4267
	protected override void OnBeforeDestroy()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}
	}

	// Token: 0x0600D542 RID: 54594 RVA: 0x003F6083 File Offset: 0x003F4283
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

	// Token: 0x0600D543 RID: 54595 RVA: 0x003F60C0 File Offset: 0x003F42C0
	public override UniTask AsyncLoadUiResource()
	{
		ItemHintItem.<AsyncLoadUiResource>d__10 <AsyncLoadUiResource>d__;
		<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AsyncLoadUiResource>d__.<>4__this = this;
		<AsyncLoadUiResource>d__.<>1__state = -1;
		<AsyncLoadUiResource>d__.<>t__builder.Start<ItemHintItem.<AsyncLoadUiResource>d__10>(ref <AsyncLoadUiResource>d__);
		return <AsyncLoadUiResource>d__.<>t__builder.Task;
	}

	// Token: 0x0600D544 RID: 54596 RVA: 0x003F6104 File Offset: 0x003F4304
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

	// Token: 0x0600D545 RID: 54597 RVA: 0x003F61E4 File Offset: 0x003F43E4
	protected override void PlayStart()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		this.CurSequencePlayer = "Start";
		this.PlayItemHintAudio();
	}

	// Token: 0x0600D546 RID: 54598 RVA: 0x003F6220 File Offset: 0x003F4420
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

	// Token: 0x0600D547 RID: 54599 RVA: 0x003F6420 File Offset: 0x003F4620
	protected override void PlayHalfway()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Move", false, null, false);
		this.CurSequencePlayer = "Move";
	}

	// Token: 0x0600D548 RID: 54600 RVA: 0x003F6454 File Offset: 0x003F4654
	public override void PlayEnd()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		this.CurSequencePlayer = "Close";
	}

	// Token: 0x0600D549 RID: 54601 RVA: 0x003F6488 File Offset: 0x003F4688
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

	// Token: 0x040077A8 RID: 30632
	private const int AUDIO_EFFECT_RARE_LEVEL = 4;

	// Token: 0x040077A9 RID: 30633
	private const int AUDIO_HINT_CD_MS = 500;

	// Token: 0x040077AA RID: 30634
	protected string CurSequencePlayer;

	// Token: 0x040077AB RID: 30635
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040077AC RID: 30636
	private int? ItemAudioQuality;

	// Token: 0x0200778D RID: 30605
	[NullableContext(0)]
	private enum EItemHintItemCom
	{
		// Token: 0x04026CFE RID: 158974
		ItemIcon,
		// Token: 0x04026CFF RID: 158975
		ItemNameText,
		// Token: 0x04026D00 RID: 158976
		ItemCountText,
		// Token: 0x04026D01 RID: 158977
		ItemXText
	}
}
