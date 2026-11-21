using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200256C RID: 9580
[NullableContext(1)]
[Nullable(0)]
public class BoneHiddenSwitch : IDynamicConditionSwitch
{
	// Token: 0x06017A89 RID: 96905 RVA: 0x006FE228 File Offset: 0x006FC428
	public void Init(CharacterActorComponent actor, EntityAudioConfig config)
	{
		if (config.BoneHiddenSwitchLength != 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[BoneHiddenSwitch] BoneHiddenSwitch配置无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId:", config.Id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.BoneName = config.BoneHiddenSwitch(0);
		this.SwitchGroup = config.BoneHiddenSwitch(1);
		this.HiddenSwitch = config.BoneHiddenSwitch(2);
		this.VisibleSwitch = config.BoneHiddenSwitch(3);
		this.LastHidden = actor.Actor.Mesh.IsBoneHiddenByName(FNameUtil.GetDynamicFName(this.BoneName) ?? FName.NAME_None);
		this.SetSwitch(this.LastHidden, actor);
	}

	// Token: 0x06017A8A RID: 96906 RVA: 0x006FE2EC File Offset: 0x006FC4EC
	public void Do(CharacterActorComponent actor)
	{
		bool flag = actor.Actor.Mesh.IsBoneHiddenByName(FNameUtil.GetDynamicFName(this.BoneName) ?? FName.NAME_None);
		bool flag2 = flag != this.LastHidden;
		this.LastHidden = flag;
		if (flag2)
		{
			this.SetSwitch(this.LastHidden, actor);
		}
	}

	// Token: 0x06017A8B RID: 96907 RVA: 0x006FE34F File Offset: 0x006FC54F
	private void SetSwitch(bool isHiddenBone, CharacterActorComponent actor)
	{
	}

	// Token: 0x06017A8C RID: 96908 RVA: 0x006FE351 File Offset: 0x006FC551
	public void Clear()
	{
	}

	// Token: 0x0400C980 RID: 51584
	private const int BONE_HIDDEN_SWITCH = 4;

	// Token: 0x0400C981 RID: 51585
	public string BoneName = "";

	// Token: 0x0400C982 RID: 51586
	public string SwitchGroup = "";

	// Token: 0x0400C983 RID: 51587
	public string HiddenSwitch = "";

	// Token: 0x0400C984 RID: 51588
	public string VisibleSwitch = "";

	// Token: 0x0400C985 RID: 51589
	public bool LastHidden;
}
