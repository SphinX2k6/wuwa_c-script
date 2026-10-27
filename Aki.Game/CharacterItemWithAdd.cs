using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001305 RID: 4869
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterItemWithAdd : GridProxyAbstract<CharacterData>
{
	// Token: 0x060086F1 RID: 34545 RVA: 0x001CCE04 File Offset: 0x001CB004
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060086F2 RID: 34546 RVA: 0x001CCE60 File Offset: 0x001CB060
	protected override UniTask OnBeforeStartAsync()
	{
		CharacterItemWithAdd.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CharacterItemWithAdd.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060086F3 RID: 34547 RVA: 0x001CCEA4 File Offset: 0x001CB0A4
	public void RefreshAddText()
	{
		if (this.Data.ValueInterval > 0)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText("+" + this.Data.ValueInterval.ToString(), true);
			return;
		}
		else
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText("", true);
			return;
		}
	}

	// Token: 0x060086F4 RID: 34548 RVA: 0x001CCF03 File Offset: 0x001CB103
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.CharacterItem.Refresh(data, isSelected, gridIndex);
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(gridIndex != 0);
	}

	// Token: 0x060086F5 RID: 34549 RVA: 0x001CCF30 File Offset: 0x001CB130
	public void RefreshProgress(float percent)
	{
		int value = this.Data.CurrentValue - this.Data.ValueInterval + (int)((float)this.Data.ValueInterval * percent);
		this.CharacterItem.RefreshProgress(value, this.Data.MaxValue);
	}

	// Token: 0x060086F6 RID: 34550 RVA: 0x001CCF7C File Offset: 0x001CB17C
	public void RefreshCurrentValue(float percent)
	{
		int value = this.Data.CurrentValue - this.Data.ValueInterval + (int)((float)this.Data.ValueInterval * percent);
		this.CharacterItem.RefreshCurrentValue(value);
	}

	// Token: 0x060086F7 RID: 34551 RVA: 0x001CCFC0 File Offset: 0x001CB1C0
	public void RefreshProgressAdd(float percent)
	{
		int value = this.Data.CurrentValue - this.Data.ValueInterval + (int)((float)this.Data.ValueInterval * percent);
		this.CharacterItem.RefreshProgressAdd(value, this.Data.MaxValue);
	}

	// Token: 0x060086F8 RID: 34552 RVA: 0x001CD00C File Offset: 0x001CB20C
	public void PlayStartAction()
	{
		this.CharacterItem.SetLightProgressWidth();
		this.SequencePlayer.PlayLevelSequenceByName("Action01", false, null, false);
	}

	// Token: 0x060086F9 RID: 34553 RVA: 0x001CD040 File Offset: 0x001CB240
	public void PlayAddAction()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Action02", false, null, false);
	}

	// Token: 0x060086FA RID: 34554 RVA: 0x001CD068 File Offset: 0x001CB268
	public void SetLightProgressWidth()
	{
		this.CharacterItem.SetLightProgressWidth();
	}

	// Token: 0x060086FB RID: 34555 RVA: 0x001CD078 File Offset: 0x001CB278
	public void PlayEndAction()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Action03", false, null, false);
	}

	// Token: 0x04003C4F RID: 15439
	[Nullable(2)]
	protected CharacterItem CharacterItem;

	// Token: 0x04003C50 RID: 15440
	protected CharacterData Data;

	// Token: 0x04003C51 RID: 15441
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02007940 RID: 31040
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027F0B RID: 163595
		public const int CharacterItem = 0;

		// Token: 0x04027F0C RID: 163596
		public const int AddText = 1;

		// Token: 0x04027F0D RID: 163597
		public const int LineItem = 2;
	}
}
