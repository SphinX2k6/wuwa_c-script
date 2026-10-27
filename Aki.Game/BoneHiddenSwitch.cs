using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02003016 RID: 12310
[NullableContext(1)]
[Nullable(0)]
public class BoneHiddenSwitch : IDynamicConditionSwitch
{
	// Token: 0x0601A141 RID: 106817 RVA: 0x006D6320 File Offset: 0x006D4520
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

	// Token: 0x0601A142 RID: 106818 RVA: 0x006D63E4 File Offset: 0x006D45E4
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

	// Token: 0x0601A143 RID: 106819 RVA: 0x006D6447 File Offset: 0x006D4647
	private void SetSwitch(bool isHiddenBone, CharacterActorComponent actor)
	{
	}

	// Token: 0x0601A144 RID: 106820 RVA: 0x006D6449 File Offset: 0x006D4649
	public void Clear()
	{
	}

	// Token: 0x0400C5B3 RID: 50611
	private const int BONE_HIDDEN_SWITCH = 4;

	// Token: 0x0400C5B4 RID: 50612
	public string BoneName = "";

	// Token: 0x0400C5B5 RID: 50613
	public string SwitchGroup = "";

	// Token: 0x0400C5B6 RID: 50614
	public string HiddenSwitch = "";

	// Token: 0x0400C5B7 RID: 50615
	public string VisibleSwitch = "";

	// Token: 0x0400C5B8 RID: 50616
	public bool LastHidden;
}
