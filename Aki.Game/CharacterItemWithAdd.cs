using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007B9 RID: 1977
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterItemWithAdd : GridProxyAbstract<CharacterData>
{
	// Token: 0x06005A8C RID: 23180 RVA: 0x001D5C70 File Offset: 0x001D3E70
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06005A8D RID: 23181 RVA: 0x001D5CCC File Offset: 0x001D3ECC
	protected override UniTask OnBeforeStartAsync()
	{
		CharacterItemWithAdd.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CharacterItemWithAdd.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005A8E RID: 23182 RVA: 0x001D5D10 File Offset: 0x001D3F10
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

	// Token: 0x06005A8F RID: 23183 RVA: 0x001D5D6F File Offset: 0x001D3F6F
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

	// Token: 0x06005A90 RID: 23184 RVA: 0x001D5D9C File Offset: 0x001D3F9C
	public void RefreshProgress(float percent)
	{
		int value = this.Data.CurrentValue - this.Data.ValueInterval + (int)((float)this.Data.ValueInterval * percent);
		this.CharacterItem.RefreshProgress(value, this.Data.MaxValue);
	}

	// Token: 0x06005A91 RID: 23185 RVA: 0x001D5DE8 File Offset: 0x001D3FE8
	public void RefreshCurrentValue(float percent)
	{
		int value = this.Data.CurrentValue - this.Data.ValueInterval + (int)((float)this.Data.ValueInterval * percent);
		this.CharacterItem.RefreshCurrentValue(value);
	}

	// Token: 0x06005A92 RID: 23186 RVA: 0x001D5E2C File Offset: 0x001D402C
	public void RefreshProgressAdd(float percent)
	{
		int value = this.Data.CurrentValue - this.Data.ValueInterval + (int)((float)this.Data.ValueInterval * percent);
		this.CharacterItem.RefreshProgressAdd(value, this.Data.MaxValue);
	}

	// Token: 0x06005A93 RID: 23187 RVA: 0x001D5E78 File Offset: 0x001D4078
	public void PlayStartAction()
	{
		this.CharacterItem.SetLightProgressWidth();
		this.SequencePlayer.PlayLevelSequenceByName("Action01", false, null, false);
	}

	// Token: 0x06005A94 RID: 23188 RVA: 0x001D5EAC File Offset: 0x001D40AC
	public void PlayAddAction()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Action02", false, null, false);
	}

	// Token: 0x06005A95 RID: 23189 RVA: 0x001D5ED4 File Offset: 0x001D40D4
	public void SetLightProgressWidth()
	{
		this.CharacterItem.SetLightProgressWidth();
	}

	// Token: 0x06005A96 RID: 23190 RVA: 0x001D5EE4 File Offset: 0x001D40E4
	public void PlayEndAction()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Action03", false, null, false);
	}

	// Token: 0x04003CE7 RID: 15591
	[Nullable(2)]
	protected CharacterItem CharacterItem;

	// Token: 0x04003CE8 RID: 15592
	protected CharacterData Data;

	// Token: 0x04003CE9 RID: 15593
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02006ACA RID: 27338
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04023238 RID: 143928
		public const int CharacterItem = 0;

		// Token: 0x04023239 RID: 143929
		public const int AddText = 1;

		// Token: 0x0402323A RID: 143930
		public const int LineItem = 2;
	}
}
