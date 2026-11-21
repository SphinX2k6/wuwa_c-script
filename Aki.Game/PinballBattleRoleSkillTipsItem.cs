using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011CB RID: 4555
internal class PinballBattleRoleSkillTipsItem : GridProxyAbstract<int>
{
	// Token: 0x0600B4D9 RID: 46297 RVA: 0x00356E6C File Offset: 0x0035506C
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

	// Token: 0x0600B4DA RID: 46298 RVA: 0x00356ED8 File Offset: 0x003550D8
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600B4DB RID: 46299 RVA: 0x00356F11 File Offset: 0x00355111
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.Clear();
	}

	// Token: 0x0600B4DC RID: 46300 RVA: 0x00356F24 File Offset: 0x00355124
	public UniTask PlayCloseSequence()
	{
		PinballBattleRoleSkillTipsItem.<PlayCloseSequence>d__4 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<PinballBattleRoleSkillTipsItem.<PlayCloseSequence>d__4>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600B4DD RID: 46301 RVA: 0x00356F68 File Offset: 0x00355168
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

	// Token: 0x040068A4 RID: 26788
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;
}
