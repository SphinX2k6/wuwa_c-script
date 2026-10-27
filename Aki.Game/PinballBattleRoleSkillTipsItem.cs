using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D09 RID: 7433
internal class PinballBattleRoleSkillTipsItem : GridProxyAbstract<int>
{
	// Token: 0x0600E0BC RID: 57532 RVA: 0x0034B43C File Offset: 0x0034963C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E0BD RID: 57533 RVA: 0x0034B4A8 File Offset: 0x003496A8
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600E0BE RID: 57534 RVA: 0x0034B4E1 File Offset: 0x003496E1
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.Clear();
	}

	// Token: 0x0600E0BF RID: 57535 RVA: 0x0034B4F4 File Offset: 0x003496F4
	public UniTask PlayCloseSequence()
	{
		PinballBattleRoleSkillTipsItem.<PlayCloseSequence>d__4 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<PinballBattleRoleSkillTipsItem.<PlayCloseSequence>d__4>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0C0 RID: 57536 RVA: 0x0034B538 File Offset: 0x00349738
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		PinballRoleConfig value = PinballConfig.Instance.GetPinballRoleConfigById(data).Value;
		base.SetTextureShowUntilLoaded(value.RoleSkillReleaseIcon, base.GetTexture(0), null);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(value.RoleSkillReleaseDesc);
	}

	// Token: 0x040067C5 RID: 26565
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;
}
